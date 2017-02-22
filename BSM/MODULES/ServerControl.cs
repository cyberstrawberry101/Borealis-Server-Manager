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

namespace Borealis
{
    public partial class ServerControl : Form
    {
        public ServerControl()
        {
            InitializeComponent();
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
            backgroundWorker01.RunWorkerAsync();

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
            txtboxIssueCommand.Text = " > Server is Not Running";
        }

        //===================================================================================//
        // ISSUE COMMAND TO SERVER VIA TEXTBOX                                               //
        //===================================================================================//
        private void txtboxIssueCommand_MouseClick(object sender, MouseEventArgs e)
        {
            txtboxIssueCommand.Text = "";
        }

        //===================================================================================//
        // LAUNCH BACKGROUND WORKER TO HANDLE PROCESS                                        //
        //===================================================================================//
        private void backgroundWorker01_DoWork(object sender, DoWorkEventArgs e)
        {
            //ExternalExecution_Classes.LaunchExternalProgram("C:\\Windows\\system32\\cmd.exe", " -k help", false);
        }

        private void panelTechServices_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ServerControl_Load(object sender, EventArgs e)
        {
            //Pull all gameserver data from config.json, split all json strings into a list, iterate through that list for specific data.
            if (GameServer_Management.server_collection != null)
            {
                foreach (Newtonsoft.Json.Linq.JObject gameserver in GameServer_Management.server_collection)
                {
                    comboboxGameserverList.Items.Add((string)gameserver["server_name"]);
                }
            }
        }

        private void txtboxIssueCommand_Enter(object sender, EventArgs e)
        {
            txtboxIssueCommand.Text = "";
        }
    }
}
