using System;
using System.Windows.Forms;
using MetroFramework;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace Borealis
{
    public partial class TAB_CONTROL : Form
    {
        public TAB_CONTROL()
        {
            InitializeComponent();
        }

        //Class to store the data regarding the currently managed server
        public class Managed_GameServer
        {

            public string server_type { get; set; }
            public string install_dir { get; set; }
            public string executable_dir { get; set; }
            public string launch_arguments { get; set; }
            public string server_config_file { get; set; }
            public bool running_status { get; set; }
        }

        //===================================================================================//
        // STARTUP:                                                                          //
        //===================================================================================//
        private void ServerControl_Load(object sender, EventArgs e)
        {
            //Pull all gameserver data from config.json, split all json strings into a list, iterate through that list for specific data.
            if (GameServer_Management.server_collection != null)
            {
                foreach (JObject gameserver in GameServer_Management.server_collection)
                {
                    comboboxGameserverList.Items.Add((string)gameserver["SERVER_name_friendly"]);
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


            if (GameServer_Management.server_collection != null)
            {
                foreach (JObject gameserver in GameServer_Management.server_collection)
                {
                    if ((string)gameserver["SERVER_name_friendly"] == comboboxGameserverList.Text)
                    {
                        ExecuteWithRedirect(Environment.CurrentDirectory + (string)gameserver["DIR_executable"], (string)gameserver["SERVER_launch_arguments"]);
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
            foreach (JObject gameserver in GameServer_Management.server_collection)
            {
                if ((string)gameserver["SERVER_name_friendly"] == comboboxGameserverList.Text)
                {
                    //Decide what data to pull from the object at this point in time of development.
                    
                    GameServer_Management.GameServer Controlled_GameServer = new GameServer_Management.GameServer();

                    Controlled_GameServer.DIR_install_location = (string)gameserver["DIR_install_location"];
                    Controlled_GameServer.DIR_executable = (string)gameserver["DIR_executable"];
                    Controlled_GameServer.SERVER_launch_arguments = (string)gameserver["SERVER_launch_arguments"];
                    Controlled_GameServer.SERVER_running_status = (bool)gameserver["SERVER_running_status"];
                    
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

        public void RefreshData()
        {
            comboboxGameserverList.Items.Clear();
            if (GameServer_Management.server_collection != null)
            {
                foreach (JObject gameserver in GameServer_Management.server_collection)
                {
                    comboboxGameserverList.Items.Add((string)gameserver["SERVER_name_friendly"]);
                }
            }
        }

        private void ServerControl_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
