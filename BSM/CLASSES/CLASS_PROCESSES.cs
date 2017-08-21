using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Serilog;

namespace Borealis
{
    // note: this is really bad practice, but I'm forcing users to go through this factory/singleton manager
    public static class ProcessManager
    {
        private static readonly object ManagerSync = new object();
        private static readonly Dictionary<string, IProcess> ProcessList = new Dictionary<string, IProcess>();
        public static readonly TraceSwitch TraceSwitch = new TraceSwitch("Process", "Process manager info");

        // usage here is is for other areas to use
        public static IProcess GetProcessByNickname(string nickname)
        {
            lock (ManagerSync)
            {
                return ProcessList.ContainsKey(nickname) ? ProcessList[nickname] : null;
            }
        }

        // see above usage - we want to have instances use this to find a process
        public static IProcess GetOrCreate(
            string nickname,
            string SERVER_executable,
            string SERVER_launch_arguments,
            ProcessLaunchOptions? launchOptions = null)
        {
            lock (ManagerSync)
            {
                if (ProcessList.ContainsKey(nickname))
                {
                    Log.Information($"process {nickname} found by manager");
                    TraceMessage(TraceLevel.Info, $"process {nickname} found by manager");
                    return ProcessList[nickname];
                }
                Log.Warning($"process {nickname} NOT found - cache miss by manager");
                TraceMessage(TraceLevel.Info, $"process {nickname} NOT found - cache miss by manager");
                var newInstance = new ProcessHelper(nickname, SERVER_executable, SERVER_launch_arguments, launchOptions ?? new ProcessLaunchOptions());
                newInstance.EventOccured += NewInstanceOnEventOccured;
                ProcessList.Add(nickname, newInstance);
                return newInstance;
            }
        }

        private static void NewInstanceOnEventOccured(object o, ProcessHelperEvent e)
        {
            if (e.Type == ProcessHelperEventType.InstanceDisposed)
            {
                lock (ManagerSync)
                {
                    // remove instances that are disposed from the manager automatically, we don't want to have anyone sending "Start" to a disposed instance
                    var record = ProcessList.FirstOrDefault(x => ReferenceEquals(o, x.Value));
                    if (ProcessList.ContainsKey(record.Key))
                    {
                        Log.Information($"removed process {record.Key} from manager after dispose");
                        TraceMessage(TraceLevel.Info, $"removed process {record.Key} from manager after dispose");
                        ProcessList.Remove(record.Key);
                    }
                }
            }
        }

        // we are disble direct access to this - it will keep someone from trying to create a new instance to
        private class ProcessHelper : IProcess
        {
            private readonly string nickname;
            private readonly string SERVER_executable;
            private readonly string SERVER_launch_arguments;
            private readonly ProcessLaunchOptions launchOptions;
            private readonly object processSync = new object();
            private readonly ConcurrentQueue<ProcessHelperEvent> processEvents = new ConcurrentQueue<ProcessHelperEvent>();

            private bool disposed;
            private Process currentProcess;

            [DllImport("user32.dll")]
            static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

            const int SW_HIDE = 0;
            const UInt32 WM_CLOSE = 0x0010; // ask nicely to close window

            public ProcessHelper(string nickname, string SERVER_executable, string SERVER_launch_arguments, ProcessLaunchOptions launchOptions)
            {
                this.nickname = nickname;
                this.SERVER_executable = SERVER_executable;
                this.SERVER_launch_arguments = SERVER_launch_arguments;
                this.launchOptions = launchOptions;
            }

            public void WriteLine(string input)
            {
                lock (processSync)
                {
                    DisposeGuard();
                    var stream = currentProcess?.StandardInput;
                    stream?.WriteLine(input);
                    stream?.Flush();
                }
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

                    Log.Information($"about to start process {nickname} @'{SERVER_executable}'");
                    TraceMessage(TraceLevel.Verbose, $"about to start process {nickname} @'{SERVER_executable}'");
                    if (!process.Start())
                    {
                        throw new Exception($"cannot get the process {nickname} @'{SERVER_executable}' to start - returns false");
                    }

                    process.BeginErrorReadLine();
                    process.BeginOutputReadLine();

                    OnEventOccurred(new ProcessHelperEvent(null, ProcessHelperEventType.ProcessStarted, nickname, process?.Id));
                    Log.Information($"process {nickname} started with pid {process.Id} @'{SERVER_executable}'");
                    TraceMessage(TraceLevel.Info, $"process {nickname} started with pid {process.Id} @'{SERVER_executable}'");

                    if (launchOptions.ShowWindowOnStart)
                    {
                        Log.Information($"window showing for {nickname} pid {process.Id} - ShowWindowOnStart set to true");
                        TraceMessage(TraceLevel.Verbose, $"window showing for {nickname} pid {process.Id} - ShowWindowOnStart set to true");
                    }
                    else
                    {
                        //note: only works as long as your process actually creates a main window.
                        for (int i = 0; i < 100 && process.MainWindowHandle == IntPtr.Zero; i++)
                        {
                            // we will only wait 1 second then, console programs are silly
                            Thread.Sleep(10);
                        }

                        // this hides the window without disable message pumping
                        ShowWindow(process.MainWindowHandle, SW_HIDE);
                        Log.Information($"window hidden for {nickname} pid {process.Id}");
                        TraceMessage(TraceLevel.Verbose, $"window hidden for {nickname} pid {process.Id}");
                    }
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
                        Log.Warning($"attempted to stop process {nickname} when no process is running - likely a race condition!");
                        TraceMessage(TraceLevel.Warning, $"attempted to stop process {nickname} when no process is running - likely a race condition!");
                        return;
                    }

                    SendMessage(currentProcess.MainWindowHandle, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                    Log.Information($"sent WM_CLOSE to process {nickname} pid {currentProcess.Id}");
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
                        Log.Warning($"attempted to KILL process {nickname} when no process is running - likely a race condition!");
                        TraceMessage(TraceLevel.Warning, $"attempted to KILL process {nickname} when no process is running - likely a race condition!");
                        return;
                    }

                    currentProcess.Kill();
                    Log.Information($"KILLED process {nickname} pid {currentProcess.Id}");
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
                        Log.Warning($"KILLING {nickname} because you forgot to stop it before calling Dispose");
                        TraceMessage(TraceLevel.Warning, $"KILLING {nickname} because you forgot to stop it before calling Dispose");
                        // welp, time waits for no one!
                        currentProcess.Kill();
                        currentProcess = null;
                    }
                    else if (!disposed)
                    {
                        Log.Information($"diposed {nickname} gracefully, good job!");
                        TraceMessage(TraceLevel.Verbose, $"diposed {nickname} gracefully, good job!");
                    }
                    disposed = true;
                    OnEventOccurred(new ProcessHelperEvent(null, ProcessHelperEventType.InstanceDisposed, nickname, null));
                }
            }

            private void ProcessClosed(Process process)
            {
                lock (processSync)
                {
                    OnEventOccurred(new ProcessHelperEvent(null, ProcessHelperEventType.ProcessStopped, nickname, process?.Id));
                    Log.Information($"process {nickname} pid {process?.Id} has closed, RIP");
                    TraceMessage(TraceLevel.Info, $"process {nickname} pid {process?.Id} has closed, RIP");
                    process?.Dispose();
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
        }

        private static void TraceMessage(TraceLevel level, string message)
        {
            if (TraceSwitch.Level >= level)
            {
                Trace.WriteLine(message, "Process");
            }
        }
    }

    public struct ProcessLaunchOptions
    {
        public bool ShowWindowOnStart;
    }


    public enum ProcessHelperEventType
    {
        OutputMessage,
        ErrorMessage,
        ProcessStarted,
        ProcessStopped,
        InstanceDisposed
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

        public override string ToString()
        {
            return $"{Occurred.ToString("hh:mm:ss tt zz")}:[Event: {Type.ToString().PadLeft(14)}] {Message}";
        }

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

        void WriteLine(string input); // this directly writes to the standard input

        event EventHandler<ProcessHelperEvent> EventOccured; // an event transpired

        IEnumerable<ProcessHelperEvent> ProcessEvents { get; } // events currently stored
    }
}
