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
            txtboxIssueCommand.Enabled = true;
            txtboxIssueCommand.Text = "> Type a command";
            consoleViewport.color = Color.FromArgb(255, 67, 181, 129);
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
            txtboxIssueCommand.Enabled = false;
            txtboxIssueCommand.Text = "> Server is not running";
            consoleViewport.color = Color.FromArgb(255, 191, 75, 96);
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
    }
}
