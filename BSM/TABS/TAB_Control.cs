using MetroFramework;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Borealis
{
    public partial class TAB_CONTROL : Form
    {
        public TAB_CONTROL()
        {
            InitializeComponent();
        }

        //===================================================================================//
        // STARTUP:                                                                          //
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

        //===================================================================================//
        // CONTROL:                                                                          //
        //===================================================================================//
        private void ExecuteWithRedirect(string argProgramName, string argParameters)
        {
            try
            {
                var proc = new Process();
                proc.StartInfo.Arguments = argParameters;
                proc.StartInfo.FileName = argProgramName;
                proc.StartInfo.UseShellExecute = false;

                // set up output redirection
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.EnableRaisingEvents = true;
                proc.StartInfo.CreateNoWindow = true;
                // see below for output handler
                proc.ErrorDataReceived += proc_DataReceived;
                proc.OutputDataReceived += proc_DataReceived;
                proc.Start();
                proc.BeginErrorReadLine();
                proc.BeginOutputReadLine();
            }
            catch (Exception)
            {
                MetroMessageBox.Show(BorealisServerManager.ActiveForm, "We cannot find the required executable to launch the server!  Either it is missing, or your configuration for this gameserver is corrupted.", "Error Launching GameServer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStartServer.Enabled = true;
                btnStopServer.Enabled = false;
            }
        }
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
            chkAutoRestart.Visible = false;
            lblAutoRestart.Visible = false;
            txtboxIssueCommand.Visible = true;
            txtboxIssueCommand.Text = " > Enter a Command";
            txtboxIssueCommand.Enabled = true;


            if (GameServer_Management.server_collection != null)
            {
                foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
                {
                    if (gameserver.SERVER_name_friendly == comboboxGameserverList.Text)
                    {
                        ExecuteWithRedirect(Environment.CurrentDirectory + gameserver.SERVER_executable, gameserver.SERVER_launch_arguments);
                    }
                }
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            btnStopServer.Enabled = false;
            btnStartServer.Enabled = true;
            chkAutoRestart.Visible = true;
            lblAutoRestart.Visible = true;
            txtboxIssueCommand.Visible = false;
            consoleOutputList.Items.Clear();
            txtboxIssueCommand.Text = " > Server is Not Running";
            txtboxIssueCommand.Enabled = false;
        }
        private void txtboxIssueCommand_MouseClick(object sender, MouseEventArgs e)
        {
            txtboxIssueCommand.Text = "";
        }
        private void txtboxIssueCommand_Enter(object sender, EventArgs e)
        {
            txtboxIssueCommand.Text = "";
        }
        private void comboboxGameserverList_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
            {
                if (gameserver.SERVER_name_friendly == comboboxGameserverList.Text)
                {
                    //Decide what data to pull from the object at this point in time of development.
                    
                    GameServer_Object Controlled_GameServer = new GameServer_Object();

                    Controlled_GameServer.DIR_install_location = Controlled_GameServer.DIR_install_location;
                    Controlled_GameServer.SERVER_executable = Controlled_GameServer.SERVER_executable;
                    Controlled_GameServer.SERVER_launch_arguments = Controlled_GameServer.SERVER_launch_arguments;
                    Controlled_GameServer.SERVER_running_status = Controlled_GameServer.SERVER_running_status;
                    
                }
            }
            consolePanel.Visible = true;
            btnStartServer.Visible = true;
            btnStopServer.Visible = true;
            chkAutoRestart.Visible = true;
            lblAutoRestart.Visible = true;
        }
        private void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                consoleOutputList.Items.Add(e.Data);
            }
        }

        public void RefreshData()
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
    }
}
