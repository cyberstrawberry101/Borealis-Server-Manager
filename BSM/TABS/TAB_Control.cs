using System;
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
            if (GameServerManagement.ServerCollection != null)
            {
                foreach (GameServerObject gameserver in GameServerManagement.ServerCollection)
                {
                    comboboxGameserverList.Items.Add(gameserver.SERVER_name_friendly);
                }
            }
        }

        private void comboboxGameserverList_SelectedValueChanged(object sender, EventArgs e)
        {
            var currentServer = GameServerManagement.PropertyGetSet(comboboxGameserverList.Text);
            var process = ProcessManager.GetProcessByNickname(currentServer.SERVER_name_friendly);
            var isRunning = process?.IsRunning ?? false;
            if (isRunning)
            {
                btnStartServer.Enabled = false;
                chkAutoRestart.Enabled = false;
                lblAutoRestart.Enabled = false;
                //lblRedirectInOut.Enabled = false;
                //chkRedirectInOut.Enabled = false;
                btnStopServer.Enabled = true;
            }
            else
            {
                btnStartServer.Enabled = true;
                chkAutoRestart.Enabled = true;
                lblAutoRestart.Enabled = true;
                //lblRedirectInOut.Enabled = true;
                //chkRedirectInOut.Enabled = true;
                btnStopServer.Enabled = false;
            }

            SubscribeToProcess(process);
            return;
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
            Invoke(new Action(() => consoleOutputList.Items.Add(e)));
            consoleOutputList.SelectedIndex = consoleOutputList.Items.Count - 1;
        }

        private void RefreshData()
        {
            UnsubscribeToProcess();
            comboboxGameserverList.Items.Clear();
            if (GameServerManagement.ServerCollection != null)
            {
                foreach (GameServerObject gameserver in GameServerManagement.ServerCollection)
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
            var currentServer = GameServerManagement.PropertyGetSet(comboboxGameserverList.Text);
            //These strings tell the process manager how exactly to start the server processes based on the engine they use.
            string engineSpecificDirectory = null;
            string engineSpecificArguments = null;

            switch (currentServer.ENGINE_type)
            {
                case "SOURCE":
                    //Copy SRCDS Redirection utility (Band-Aid Redirection Fix) into working gameserver.DIR_root directory.
                    string fileName = "SrcdsConRedirect.exe";
                    string sourcePath = Environment.CurrentDirectory;
                    string targetPath = currentServer.DIR_install_location + @"\steamapps\common" + currentServer.DIR_root;

                    // Use Path class to manipulate file and directory paths.
                    string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                    string destFile = System.IO.Path.Combine(targetPath, fileName);

                    // Create a new target folder, if necessary.
                    if (!System.IO.Directory.Exists(targetPath))
                    {
                        System.IO.Directory.CreateDirectory(targetPath);
                    }

                    // overwrite the destination file if it already exists.
                    System.IO.File.Copy(sourceFile, destFile, true);
                                
                    engineSpecificDirectory = currentServer.DIR_install_location + @"\steamapps\common" + currentServer.DIR_root + @"\SrcdsConRedirect.exe";
                    engineSpecificArguments =
                        $"-console {currentServer.SERVER_launch_arguments} +port {currentServer.SERVER_port} +map {currentServer.GAME_map} +maxplayers {currentServer.GAME_maxplayers}";
                    break;

                case "UNREAL":
                    engineSpecificDirectory =
                        currentServer.DIR_install_location + @"\steamapps\common" + currentServer.DIR_root + currentServer.SERVER_executable;
                    engineSpecificArguments = string.Format("{0}{1}?maxplayers={3}",
                        currentServer.GAME_map,
                        currentServer.SERVER_launch_arguments,
                        currentServer.GAME_maxplayers);
                    break;

                case "GENERIC":
                    engineSpecificDirectory = currentServer.DIR_install_location + currentServer.DIR_root + currentServer.SERVER_executable;
                    engineSpecificArguments = currentServer.SERVER_launch_arguments;
                    break;
            }

            if (chkRedirectInOut.Value)
            {
                //CREATE THE PROCESS
                var process = ProcessManager.GetOrCreate(currentServer.SERVER_name_friendly,
                    engineSpecificDirectory, engineSpecificArguments, new ProcessLaunchOptions
                    {
                        ShowWindowOnStart = false
                    });

                //Start the Process!
                SubscribeToProcess(process);
                ProcessManager.GetProcessByNickname(currentServer.SERVER_name_friendly)?.Start();
            }
            else
            {
                //CREATE THE PROCESS
                var process = ProcessManager.GetOrCreate(currentServer.SERVER_name_friendly,
                    engineSpecificDirectory, engineSpecificArguments, new ProcessLaunchOptions
                    {
                        ShowWindowOnStart = true
                    });

                //Start the Process!
                SubscribeToProcess(process);
                ProcessManager.GetProcessByNickname(currentServer.SERVER_name_friendly)?.Start();
            }

            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;

            txtboxIssueCommand.Enabled = true;
            txtboxIssueCommand.Text = "";

            //chkRedirectInOut.Enabled = false;
            //lblRedirectInOut.Enabled = false;
        }

        private void btnStopServer_Click(object senders, EventArgs e)
        {
            btnStopServer.Enabled = false;
            btnStartServer.Enabled = true;
            chkAutoRestart.Enabled = true;
            lblAutoRestart.Enabled = true;
            //chkRedirectInOut.Enabled = true;
            //lblRedirectInOut.Enabled = true;
            txtboxIssueCommand.Text = " > Server is Not Running";
            txtboxIssueCommand.Enabled = false;

            var currentServer = GameServerManagement.PropertyGetSet(comboboxGameserverList.Text);
            ProcessManager.GetProcessByNickname(currentServer.SERVER_name_friendly)?.Stop();
        }

        private void txtboxIssueCommand_Enter(object sender, EventArgs e)
        {
            txtboxIssueCommand.Text = "";
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            var currentServer = GameServerManagement.PropertyGetSet(comboboxGameserverList.Text);
            consoleOutputList.Items.Add("Command Issued to Server: " + txtboxIssueCommand.Text);
            ProcessManager.GetProcessByNickname(currentServer.SERVER_name_friendly)?.WriteLine(txtboxIssueCommand.Text);
            txtboxIssueCommand.Text = "";
        }

        private void txtboxIssueCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                var currentServer = GameServerManagement.PropertyGetSet(comboboxGameserverList.Text);
                consoleOutputList.Items.Add("Command Issued to Server: " + txtboxIssueCommand.Text);
                ProcessManager.GetProcessByNickname(currentServer.SERVER_name_friendly)?.WriteLine(txtboxIssueCommand.Text);
                txtboxIssueCommand.Text = "";
            }
        }
    }
}