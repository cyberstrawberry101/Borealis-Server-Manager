using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Borealis
{
    public partial class TAB_CONTROL : Form
    {

        private IProcess currentProcess;

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
                    var process = ProcessManager.GetProcessByNickname(gameserver.SERVER_name_friendly);
                    var isRunning = process?.IsRunning ?? false;
                    if (isRunning == true)
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
                    SubscribeToProcess(process);
                    return;
                }
            }

        }

        private void SubscribeToProcess(IProcess process)
        {
            UnsubscribeToProcess();
            if (process != null)
            {
                currentProcess = process;
                foreach (var @event in currentProcess.ProcessEvents)
                {
                    consoleOutputList.Items.Add(@event);
                }
                currentProcess.EventOccured += CurrentProcessOnEventOccured;
            }
        }

        private void UnsubscribeToProcess()
        {
            if (currentProcess != null)
            {
                currentProcess.EventOccured -= CurrentProcessOnEventOccured;
                consoleOutputList.Items.Clear();
                currentProcess = null;
            }
        }

        private void CurrentProcessOnEventOccured(object sender, ProcessHelperEvent e)
        {
            consoleOutputList.Items.Add(e);
        }

        private void RefreshData()
        {
            UnsubscribeToProcess();
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
                            //System.IO.File.Copy(Environment.CurrentDirectory + @"SrcdsConRedirect.exe", gameserver.DIR_install_location + @"\steamapps\common" + gameserver.DIR_root + @"SrcdsConRedirect.exe");

                            //Create a new process in the Process Manager Class
                            var process = ProcessManager.GetOrCreate(
                                gameserver.SERVER_name_friendly,
                                gameserver.DIR_install_location + @"\steamapps\common" + gameserver.DIR_root + gameserver.SERVER_executable,
                                string.Format("{0} +port {1} +map {2} +maxplayers {3}",
                                    gameserver.SERVER_launch_arguments,
                                    gameserver.SERVER_port,
                                    gameserver.GAME_map,
                                    gameserver.GAME_maxplayers));

                            //Start the Process!
                            SubscribeToProcess(process);
                            ProcessManager.GetProcessByNickname(gameserver.SERVER_name_friendly)?.Start();
                        }

                        //UNREAL ENGINE HANDLER
                        if (gameserver.ENGINE_type == "UNREAL")
                        {
                            //Create a new process in the Process Manager Class
                            var process = ProcessManager.GetOrCreate(
                                gameserver.SERVER_name_friendly,
                                gameserver.DIR_install_location + @"\steamapps\common" + gameserver.DIR_root +
                                gameserver.SERVER_executable,
                                string.Format(" {0}", gameserver.GAME_map));

                            //gameserver.SERVER_port,
                            //gameserver.GAME_maxplayers));

                            //Start the Process!
                            SubscribeToProcess(process);
                            ProcessManager.GetProcessByNickname(gameserver.SERVER_name_friendly)?.Start();
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
            btnStartServer.Visible = true;
            chkAutoRestart.Visible = true;
            lblAutoRestart.Visible = true;
            txtboxIssueCommand.Text = " > Server is Not Running";
            txtboxIssueCommand.Enabled = false;

            foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
            {
                if (gameserver.SERVER_name_friendly == comboboxGameserverList.Text)
                {
                    ProcessManager.GetProcessByNickname(gameserver.SERVER_name_friendly)?.Stop();
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

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            ProcessManager.GetProcessByNickname("test")?.WriteLine(txtboxIssueCommand.Text);
            consoleOutputList.Items.Add("Command Issued to Server: " + txtboxIssueCommand.Text);
            txtboxIssueCommand.Text = "";
            
            /*
            foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
            {
                if (gameserver.SERVER_name_friendly == comboboxGameserverList.Text)
                {
                    ProcessManager.GetProcessByNickname(gameserver.SERVER_name_friendly)?.WriteLine(txtboxIssueCommand.Text);
                    txtboxIssueCommand.Text = "";
                }
            }
            */
        }

        //SteamGuardProcess.OutputDataReceived += proc_DataReceived;

        private void button1_Click_1(object sender, EventArgs e)
        {
            consoleOutputList.Items.Add("\r\n// Starting DEBUG Test...");
            var test = ProcessManager.GetOrCreate("test", "C:\\Windows\\System32\\cmd.exe", "-k", new ProcessLaunchOptions
            {
                ShowWindowOnStart = true
            });
            test.EventOccured += (borealis, args) => consoleOutputList.Items.Add(args);
            test.Start();

            SubscribeToProcess(test);

            txtboxIssueCommand.Enabled = true;
        }
    }

}