using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Borealis
{
    public class Server_Process_Management
    {
        public enum ProcessHelperEventType
        {
            OutputMessage,
            ErrorMessage,
            ProcessStarted,
            ProcessStopped
        }

        // basic event type for the process helper
        public class ProcessHelperEvent
        {
            public ProcessHelperEvent(string message, ProcessHelperEventType type, string nickname, int? pid)
            {
                Message = message;
                Type = type;
                Occurred = DateTimeOffset.Now;
                ProcessNickname = nickname;
                Pid = pid;
            }

            public int? Pid { get; }
            public string ProcessNickname { get; }
            public string Message { get; }
            public ProcessHelperEventType Type { get; }
            public DateTimeOffset Occurred { get; }
        }

        // Goal of this class is to wrap all process start / stop logic
        // we avoid blocking methods on the public methods in general here
        // keep a buffered log of console redirect content
        // ensure methods defined are thread safe in case someone gets click happy in a UI somewhere ;)
        public interface IProcess : IDisposable
        {
            bool IsRunning { get; }

            void Start(); // start this process if not already
            void Stop(); // ask process to close nicely

            void Kill(); // kick chair out from under the process	

            event EventHandler<ProcessHelperEvent> EventOccured; // an event transpired

            IEnumerable<ProcessHelperEvent> ProcessEvents { get; } // events currently stored
        }

        public class ProcessHelper : IProcess
        {
            public static readonly TraceSwitch traceSwitch = new TraceSwitch("Process", "Process manager info");

            private readonly string nickname;
            private readonly string SERVER_executable;
            private readonly string SERVER_launch_arguments;
            private readonly object processSync = new object();

            private readonly ConcurrentQueue<ProcessHelperEvent> processEvents =
                new ConcurrentQueue<ProcessHelperEvent>();

            private bool disposed;
            private Process currentProcess;

            [DllImport("user32.dll")]
            static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

            const int SW_HIDE = 0;
            const UInt32 WM_CLOSE = 0x0010; // ask nicely to close window

            public ProcessHelper(string nickname, string SERVER_executable, string SERVER_launch_arguments)
            {
                this.nickname = nickname;
                this.SERVER_executable = SERVER_executable;
                this.SERVER_launch_arguments = SERVER_launch_arguments;
            }

            public event EventHandler<ProcessHelperEvent> EventOccured;

            public IEnumerable<ProcessHelperEvent> ProcessEvents => processEvents;

            // inaccurate, but good enough with the other aspects of this helper
            public bool IsRunning => currentProcess != null;

            public void Start()
            {
                lock (processSync)
                {
                    DisposeGuard();
                    if (currentProcess != null)
                    {
                        return;
                    }

                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    // let's be kind here! we want to use WM_CLOSE as a graceful close attempt, and we need a window for that
                    // insead, lets hide the window all sneaky like
                    startInfo.CreateNoWindow = false;

                    startInfo.Arguments = SERVER_launch_arguments;
                    startInfo.FileName = SERVER_executable;

                    startInfo.UseShellExecute = false; //Redirect the programs.

                    startInfo.RedirectStandardError = true;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.RedirectStandardInput = true;
                    startInfo.ErrorDialog = false;

                    var process = new Process();
                    process.EnableRaisingEvents = true;
                    process.OutputDataReceived += (sender, args) => DataRecieved(args, false);
                    process.ErrorDataReceived += (sender, args) => DataRecieved(args, true);
                    process.StartInfo = startInfo;
                    process.Exited += (sender, args) => ProcessClosed(process);

                    TraceMessage(TraceLevel.Verbose, $"about to start process {nickname} @'{SERVER_executable}'");
                    if (!process.Start())
                    {
                        throw new Exception(
                            $"cannot get the process {nickname} @'{SERVER_executable}' to start - returns false");
                    }

                    OnEventOccurred(new ProcessHelperEvent(null, ProcessHelperEventType.ProcessStarted, nickname,
                        process?.Id));
                    TraceMessage(TraceLevel.Info,
                        $"process {nickname} started with pid {process.Id} @'{SERVER_executable}'");

                    //note: only works as long as your process actually creates a main window.
                    while (process.MainWindowHandle == IntPtr.Zero)
                    {
                        System.Threading.Thread.Sleep(10);
                    }

                    // this hides the window without disable message pumping
                    ShowWindow(process.MainWindowHandle, SW_HIDE);

                    TraceMessage(TraceLevel.Verbose, $"window hidden for {nickname} pid {process.Id}");

                    currentProcess = process;
                }
            }

            public void Stop()
            {
                lock (processSync)
                {
                    DisposeGuard();
                    if (currentProcess == null)
                    {
                        TraceMessage(TraceLevel.Warning,
                            $"attempted to stop process {nickname} when no process is running - likely a race condition!");
                        return;
                    }

                    SendMessage(currentProcess.MainWindowHandle, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                    TraceMessage(TraceLevel.Verbose, $"sent WM_CLOSE to process {nickname} pid {currentProcess.Id}");
                }
            }

            public void Kill()
            {
                lock (processSync)
                {
                    DisposeGuard();
                    if (currentProcess == null)
                    {
                        TraceMessage(TraceLevel.Warning,
                            $"attempted to KILL process {nickname} when no process is running - likely a race condition!");
                        return;
                    }

                    currentProcess.Kill();
                    TraceMessage(TraceLevel.Warning, $"KILLED process {nickname} pid {currentProcess.Id}");
                    currentProcess.Dispose();
                    currentProcess = null;
                }
            }

            public void Dispose()
            {
                lock (processSync)
                {
                    if (!disposed && currentProcess != null)
                    {
                        TraceMessage(TraceLevel.Warning,
                            $"KILLING {nickname} beccause you forgot to stop it before calling Dispose");
                        // welp, time waits for no one!
                        currentProcess.Kill();
                        currentProcess = null;
                    }
                    else if (!disposed)
                    {
                        TraceMessage(TraceLevel.Verbose, $"diposed {nickname} gracefully, good job!");
                    }
                    disposed = true;
                }
            }

            private void ProcessClosed(Process process)
            {
                lock (processSync)
                {
                    OnEventOccurred(new ProcessHelperEvent(null, ProcessHelperEventType.ProcessStopped, nickname,
                        process?.Id));
                    TraceMessage(TraceLevel.Info, $"process {nickname} pid {process?.Id} has closed, RIP");
                    process.Dispose();
                    if (currentProcess == process)
                    {
                        currentProcess = null;
                    }
                }
            }

            private void DataRecieved(DataReceivedEventArgs args, bool wasError)
            {
                lock (processSync)
                {
                    var type = wasError ? ProcessHelperEventType.ErrorMessage : ProcessHelperEventType.OutputMessage;
                    OnEventOccurred(new ProcessHelperEvent(args.Data, type, nickname, currentProcess?.Id));
                }
            }

            private void DisposeGuard([CallerMemberName] string callerName = "")
            {
                if (disposed)
                {
                    throw new Exception($"attempted to call {callerName} after a dispose!!");
                }
            }

            private void OnEventOccurred(ProcessHelperEvent args)
            {
                processEvents.Enqueue(args);
                EventOccured?.Invoke(this, args);
            }


            private static void TraceMessage(TraceLevel level, string message)
            {
                if (traceSwitch.Level >= level)
                {
                    Trace.WriteLine(message, "Process");
                }
            }
        }

        private CancellationTokenSource cancelToken;
    }
}

