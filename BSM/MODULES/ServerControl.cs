using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace Borealis
{
    public partial class ServerControl : Form
    {
        public ServerControl()
        {
            InitializeComponent();
        }

        public class Managed_GameServer
        {
            public string server_name { get; set; }
            public string server_type { get; set; }
            public string install_dir { get; set; }
            public string executable_dir { get; set; }
            public string launch_arguments { get; set; }
            public string server_config_file { get; set; }
            public bool running_status { get; set; }
        }

        void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                consoleOutputList.Items.Add(e.Data);
            }
        }

        public void ExecuteWithRedirect(string argProgramName, string argParameters)
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

        //===================================================================================//
        // START THE CURRENTLY STOPPED SELECTED GAMESERVER                                   //
        //===================================================================================//
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
            chkAutoRestart.Visible = false;
            lblAutoRestart.Visible = false;
            txtboxIssueCommand.Visible = true;
            txtboxIssueCommand.Text = " > Enter a Command";

            //CONSOLIDATE THIS CODE AS SOON AS POSSIBLE DUE TO ITS REDUNDANCY
            foreach (JObject gameserver in GameServer_Management.server_collection)
            {
                if ((string)gameserver["server_name"] == comboboxGameserverList.Text)
                {
                    ExecuteWithRedirect(Environment.CurrentDirectory + (string)gameserver["executable_dir"], (string)gameserver["launch_arguments"]);
                }
            }
        }

        //===================================================================================//
        // STOP THE CURRENTLY RUNNING SELECTED GAMESERVER                                    //
        //===================================================================================//
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

        //===================================================================================//
        // ISSUE COMMAND TO SERVER VIA TEXTBOX                                               //
        //===================================================================================//
        private void txtboxIssueCommand_MouseClick(object sender, MouseEventArgs e)
        {
            txtboxIssueCommand.Text = "";
        }

        private void panelTechServices_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ServerControl_Load(object sender, EventArgs e)
        {
            //Pull all gameserver data from config.json, split all json strings into a list, iterate through that list for specific data.
            if (GameServer_Management.server_collection != null)
            {
                foreach (JObject gameserver in GameServer_Management.server_collection)
                {
                    comboboxGameserverList.Items.Add((string)gameserver["server_name"]);
                }
            }
        }

        private void txtboxIssueCommand_Enter(object sender, EventArgs e)
        {
            txtboxIssueCommand.Text = "";
        }

        private void comboboxGameserverList_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (JObject gameserver in GameServer_Management.server_collection)
            {
                if ((string)gameserver["server_name"] == comboboxGameserverList.Text)
                {
                    GameServer_Management.GameServer Controlled_GameServer = new GameServer_Management.GameServer();
                    Controlled_GameServer.server_name = (string)gameserver["server_name"];
                    Controlled_GameServer.server_type = (string)gameserver["server_type"];
                    Controlled_GameServer.install_dir = (string)gameserver["install_dir"];
                    Controlled_GameServer.executable_dir = (string)gameserver["executable_dir"];
                    Controlled_GameServer.launch_arguments = (string)gameserver["launch_arguments"];
                    Controlled_GameServer.server_config_file = (string)gameserver["server_config_file"];
                    Controlled_GameServer.running_status = (bool)gameserver["running_status"];
                }
            }
        }
    }
}
