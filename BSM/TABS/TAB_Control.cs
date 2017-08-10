using MetroFramework;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Borealis.Server_Process_Management;

namespace Borealis
{
    public partial class TAB_CONTROL : Form
    {
        private CancellationTokenSource cancelToken;

        #region pInvoke

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AttachConsole(uint dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool FreeConsole();

        [DllImport("kernel32.dll")]
        static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate HandlerRoutine, bool Add);

        // Delegate type to be used as the Handler Routine for SCCH
        delegate Boolean ConsoleCtrlDelegate(CtrlTypes CtrlType);

        // Enumerated type for the control messages sent to the handler routine
        enum CtrlTypes : uint
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT,
            CTRL_CLOSE_EVENT,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT
        }

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GenerateConsoleCtrlEvent(CtrlTypes dwCtrlEvent, uint dwProcessGroupId);

        public static void StopProgramByAttachingToItsConsoleAndIssuingCtrlCEvent(Process proc)
        {
            //This does not require the console window to be visible.
            if (AttachConsole((uint) proc.Id))
            {
                //Disable Ctrl-C handling for our program
                SetConsoleCtrlHandler(null, true);
                GenerateConsoleCtrlEvent(CtrlTypes.CTRL_C_EVENT, 0);

                //Must wait here. If we don't and re-enable Ctrl-C handling below too fast, we might terminate ourselves.
                var wasAborted = false;
                var procTask = Task.Run(() =>
                {
                    //This is necessary because when we kill the process, it obviously exits. At that point, there is no proc object to wait for any longer
                    if (!wasAborted)
                        proc.WaitForExit();
                });
                if (!procTask.Wait(10000))
                {
                    wasAborted = true;
                    proc.Kill();
                }

                FreeConsole();

                //Re-enable Ctrl-C handling or any subsequently started programs will inherit the disabled state.
                SetConsoleCtrlHandler(null, false);
            }
        }

        #endregion

        public TAB_CONTROL()
        {
            InitializeComponent();
        }

        //===================================================================================//
        // UI HANDLING CODE                                                                  //
        //===================================================================================//
        private void ServerControl_Load(object sender, EventArgs e)
        {
            //Pull all gameserver data from gameservers.json, split all json strings into a list, iterate through that list for specific data.
            if (GameServer_Management.server_collection != null)
            {
                foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
                {
                    comboboxGameserverList.Items.Add(gameserver.SERVER_name_friendly);
                }
            }
        }

        private void comboboxGameserverList_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
            {
                if (gameserver.SERVER_name_friendly == comboboxGameserverList.Text)
                {
                    if (gameserver.SERVER_running_status == true)
                    {
                        btnStartServer.Visible = false;
                        chkAutoRestart.Visible = false;
                        lblAutoRestart.Visible = false;
                        btnStopServer.Visible = true;
                    }
                    else
                    {
                        btnStartServer.Visible = true;
                        chkAutoRestart.Visible = true;
                        lblAutoRestart.Visible = true;
                        btnStopServer.Visible = false;
                    }
                }
            }
            
        }

        private void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                consoleOutputList.Items.Add(e.Data);
            }
        }

        private void RefreshData()
        {
            comboboxGameserverList.Items.Clear();
            if (GameServer_Management.server_collection != null)
            {
                foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
                {
                    comboboxGameserverList.Items.Add(gameserver.SERVER_name_friendly);
                }
            }
        }

        private void ServerControl_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }

        //===================================================================================//
        // SERVER CONTROL:                                                                   //
        //===================================================================================//
        private void LaunchServer(string SERVER_executable, string SERVER_launch_arguments,
            Action<string> redirectedOutputCallback = null, TextReader input = null, string argWorkingDirectory = null,
            EventHandler onExitedCallback = null, CancellationToken cancelToken = default(CancellationToken))
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = SERVER_launch_arguments;
            startInfo.FileName = SERVER_executable;

            if (redirectedOutputCallback != null) //Redirect Output to somewhere else.
            {
                startInfo.UseShellExecute = false; //Redirect the programs.
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.RedirectStandardError = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardInput = true;
                startInfo.ErrorDialog = false;

                try
                {
                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.

                    using (var process = Process.Start(startInfo))
                    {
                        if (onExitedCallback != null)
                        {
                            process.EnableRaisingEvents = true;
                            process.Exited += onExitedCallback;
                        }

                        if (cancelToken != null)
                        {
                            cancelToken.Register(() =>
                            {
                                StopProgramByAttachingToItsConsoleAndIssuingCtrlCEvent(process);
                                redirectedOutputCallback?.Invoke("Shutting down the server...");
                            });
                        }

                        process.OutputDataReceived += (sender, args) =>
                        {
                            if (!string.IsNullOrEmpty(args?.Data))
                                redirectedOutputCallback(args.Data);
                        };
                        process.BeginOutputReadLine();

                        process.ErrorDataReceived += (sender, args) =>
                        {
                            if (!string.IsNullOrEmpty(args?.Data))
                                redirectedOutputCallback(args.Data);
                        };
                        process.BeginErrorReadLine();

                        //For whenever input is needed
                        string line;
                        while (input != null && (line = input.ReadLine()) != null)
                            process.StandardInput.WriteLine(line);
                        process.WaitForExit();
                    }
                }
                catch
                {
                    StringBuilder errorDialog = new StringBuilder();
                    errorDialog.Append("There was an error launching the following server:\n")
                        .Append(startInfo.FileName)
                        .Append("\n\n")
                        .Append("[Retry]: Attempt to start the same server again.\n")
                        .Append("[Cancel]: Cancel attempting to start server.");
                }
            }
            else //No not redirect output somewhere else
            {
                startInfo.UseShellExecute = true; //Execute the programs.

                try
                {
                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        exeProcess.WaitForExit();
                    }
                }
                catch
                {
                    StringBuilder errorDialog = new StringBuilder();
                    errorDialog.Append("There was an error launching the following server:\n")
                        .Append(startInfo.FileName)
                        .Append("\n\n")
                        .Append("[Retry]: Attempt to start the same server again.\n")
                        .Append("[Cancel]: Cancel attempting to start server.");
                }
            }
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (GameServer_Management.server_collection != null)
            {
                foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
                {
                    if (gameserver.SERVER_name_friendly == comboboxGameserverList.Text)
                    {
                        //SOURCE ENGINE HANDLER
                        if (gameserver.ENGINE_type == "SOURCE")
                        {
                            //Copy SRCDS Redirection utility (Band-Aid Redirection Fix) into working gameserver.DIR_root directory.
                            System.IO.File.Copy(Environment.CurrentDirectory + @"SrcdsConRedirect.exe", gameserver.DIR_install_location + @"\steamapps\common" + gameserver.DIR_root + @"SrcdsConRedirect.exe");

                            //ProcessHelper.traceSwitch.Level = TraceLevel.Warning;
                            ProcessHelper.traceSwitch.Level = TraceLevel.Verbose;

                            var serverInstance = new ProcessHelper(
                                gameserver.SERVER_name_friendly,
                                gameserver.DIR_install_location + @"\steamapps\common" + gameserver.DIR_root +
                                @"\SrcdsConRedirect.exe",
                                string.Format("{0} +port {1} +map {2} +maxplayers {3}",
                                    gameserver.SERVER_launch_arguments,
                                    gameserver.SERVER_port,
                                    gameserver.GAME_map,
                                    gameserver.GAME_maxplayers));
                            serverInstance.EventOccured +=
                                (borealis, args) => consoleOutputList.Items.Add(args.ToString());
                            serverInstance.Start();
                            gameserver.SERVER_running_status = serverInstance.IsRunning;
                        }

                        //UNREAL ENGINE HANDLER
                        if (gameserver.ENGINE_type == "UNREAL")
                        {
                            //ProcessHelper.traceSwitch.Level = TraceLevel.Warning;
                            ProcessHelper.traceSwitch.Level = TraceLevel.Verbose;

                            var serverInstance = new ProcessHelper(
                                gameserver.SERVER_name_friendly,
                                gameserver.DIR_install_location + @"\steamapps\common" + gameserver.DIR_root +
                                gameserver.SERVER_executable,
                                string.Format("{0} +port {1} +map {2} +maxplayers {3}",
                                    gameserver.SERVER_launch_arguments,
                                    gameserver.SERVER_port,
                                    gameserver.GAME_map,
                                    gameserver.GAME_maxplayers));
                            serverInstance.EventOccured +=
                                (borealis, args) => consoleOutputList.Items.Add(args);
                            
                            serverInstance.Start();
                            gameserver.SERVER_running_status = serverInstance.IsRunning;
                        }

                        btnStartServer.Visible = false;
                        btnStopServer.Visible = true;

                        txtboxIssueCommand.Enabled = true;
                        txtboxIssueCommand.Text = "";
                    }
                }
            }
        }

        private void btnStopServer_Click(object senders, EventArgs e)
        {
            btnStopServer.Visible = false;
            btnStartServer.Enabled = true;
            chkAutoRestart.Visible = true;
            lblAutoRestart.Visible = true;
            txtboxIssueCommand.Text = " > Server is Not Running";
            txtboxIssueCommand.Enabled = false;

            cancelToken.Cancel();

            backgroundWorker01.RunWorkerCompleted += (sender2, e2) =>
            {
                chkAutoRestart.Visible = true;
                lblAutoRestart.Visible = true;
                btnStopServer.Enabled = false;
                btnStartServer.Enabled = true;
                txtboxIssueCommand.Enabled = false;
                txtboxIssueCommand.Text = "> Server is not running";
                consoleOutputList.Items.Add("Server stopped...");
            };

            foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
            {
                if (gameserver.SERVER_name_friendly == comboboxGameserverList.Text)
                {
                    ProcessHelper KillServer = new ProcessHelper(gameserver.SERVER_name_friendly, gameserver.SERVER_executable, gameserver.SERVER_launch_arguments);
                    KillServer.Kill();
                    gameserver.SERVER_running_status = false;
                }
            }
        }

        private void txtboxIssueCommand_Enter(object sender, EventArgs e)
        {
            txtboxIssueCommand.Text = "";
        }

        private void txtboxIssueCommand_MouseClick(object sender, MouseEventArgs e)
        {
            txtboxIssueCommand.Text = "";
        }

        private void backgroundWorker01_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            bool stopped = false;


            //It's an assumption that these 3 elements MUST exist
            var asyncCallback = comboboxGameserverList.BeginInvoke((Func<string[]>) delegate()
            {
                return new string[]
                {
                    //GameServerXMLData( comboboxGameserverList.SelectedItem as string, "installation_folder" ),
                    //GameServerXMLData( comboboxGameserverList.SelectedItem as string, "default_launchscript" ),
                    //GameServerXMLData( comboboxGameserverList.SelectedItem as string, "binaries" )
                };
            });
            asyncCallback.AsyncWaitHandle.WaitOne();
            var serverParams = comboboxGameserverList.EndInvoke(asyncCallback) as string[];

            Action<string> textAddCallback = (args) =>
            {
                consoleOutputList.BeginInvoke((Action) delegate()
                {
                    consoleOutputList.Items.Add(args);
                });
            };

            EventHandler exitedHandler = (sender2, e2) =>
            {
                if (!cancelToken.IsCancellationRequested)
                {
                    //Wait a little until we restart the server
                    consoleOutputList.BeginInvoke((Action) delegate()
                    {
                        consoleOutputList.Items.Add(Environment.NewLine);
                        consoleOutputList.Items.Add(Environment.NewLine);
                        consoleOutputList.Items.Add(Environment.NewLine);

                        consoleOutputList.Items.Add(
                            "An error occured and the process has crashed. Auto-restarting in 5 seconds...");
                        //Scroll to the bottom
                        consoleOutputList.TopIndex = consoleOutputList.Items.Count - 1;

                        consoleOutputList.Items.Add(Environment.NewLine);
                        consoleOutputList.Items.Add(Environment.NewLine);
                        consoleOutputList.Items.Add(Environment.NewLine);
                    });
                    Thread.Sleep(5000);
                }
                else
                    stopped = true;
            };

            while (chkAutoRestart.Value && !stopped)
                LaunchServer(serverParams[0] + serverParams[2], serverParams[1], textAddCallback, null, serverParams[0],
                    chkAutoRestart.Value ? exitedHandler : null,
                    chkAutoRestart.Value ? cancelToken.Token : default(System.Threading.CancellationToken));
        }


    }

}
