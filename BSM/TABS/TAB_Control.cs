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
        private void Execute(string argProgramName, string argParameters, bool Redirect)
        {
            try
            {
                var proc = new Process();
                proc.StartInfo.Arguments = argParameters;
                proc.StartInfo.FileName = argProgramName;

                if (Redirect == true)
                {
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.RedirectStandardInput = true;
                    proc.StartInfo.RedirectStandardError = true;
                    proc.EnableRaisingEvents = true;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.ErrorDataReceived += proc_DataReceived;
                    proc.OutputDataReceived += proc_DataReceived;
                    proc.Start();
                    proc.BeginErrorReadLine();
                    proc.BeginOutputReadLine();
                }
                else
                {
                    proc.StartInfo.UseShellExecute = true;
                    proc.Start();
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(BorealisServerManager.ActiveForm, "We cannot find the required executable to launch the server!  Either it is missing, or your configuration for this gameserver is corrupted.", "Error Launching GameServer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStartServer.Enabled = true;
                btnStopServer.Visible = false;
                lblAutoRestart.Visible = true;
                chkAutoRestart.Visible = true;
                lblStandaloneMode.Visible = true;
                chkStandaloneMode.Visible = true;
                consolePanel.Visible = false;
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
                        //check to see what kind of engine the server is using, and determine the usage of the variables accordingly

                        //SOURCE ENGINE HANDLER
                        if (gameserver.ENGINE_type == "SOURCE")
                        {
                            //Check to see if the gameserver needs to be run with a visible console, or directly controlled by Borealis.
                            if (chkStandaloneMode.Value == true)
                            {
                                Execute(gameserver.DIR_install_location + @"\steamapps\common" + gameserver.DIR_root + @"\" + gameserver.SERVER_executable, string.Format("{0} +port {1} +map {2} +maxplayers {3}", 
                                    gameserver.SERVER_launch_arguments,
                                    gameserver.SERVER_port,
                                    gameserver.GAME_map,
                                    gameserver.GAME_maxplayers), false);
                            }
                            else
                            {
                                MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Unfortunately Borealis cannot directly control console output at this time; instead, please launch the server in 'standalone mode'.", "Unable to launch server within Borealis.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                /*
                                chkAutoRestart.Visible = false;
                                lblAutoRestart.Visible = false;
                                chkStandaloneMode.Visible = false;
                                lblStandaloneMode.Visible = false;
                                btnStartServer.Enabled = false;
                                btnStopServer.Visible = true;
                                consolePanel.Visible = true;
                                txtboxIssueCommand.Visible = true;
                                txtboxIssueCommand.Text = " > Enter a Command";
                                txtboxIssueCommand.Enabled = true;
                                Execute(Environment.CurrentDirectory + gameserver.SERVER_executable, gameserver.SERVER_launch_arguments, true);
                                */
                            }
                        }
                    }
                }
            }  
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            btnStopServer.Visible = false;
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
            btnStartServer.Visible = true;
            chkAutoRestart.Visible = true;
            lblAutoRestart.Visible = true;
            chkStandaloneMode.Visible = true;
            lblStandaloneMode.Visible = true;
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
