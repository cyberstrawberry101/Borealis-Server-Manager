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

namespace GameServer_Manager
{
    public partial class ServerControl : Form
    {
        public ServerControl()
        {
            InitializeComponent();
        }

        //===================================================================================//
        // LAUNCH EXTERNAL PROGRAM AND REDIRECT ITS OUTPUT                                   //
        //===================================================================================//
        public void RunWithRedirect(string cmdPath)
        {
            var proc = new Process();
            proc.StartInfo.FileName = cmdPath;

            // set up output redirection
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.EnableRaisingEvents = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            // see below for output handler
            proc.ErrorDataReceived += proc_DataReceived;
            proc.OutputDataReceived += proc_DataReceived;

            proc.Start();

            proc.BeginErrorReadLine();
            proc.BeginOutputReadLine();

            proc.WaitForExit();
        }

        public void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            // output will be in string e.Data
            txtboxConsoleOutput.Text = e.Data;

        }

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

        private void txtboxIssueCommand_MouseClick(object sender, MouseEventArgs e)
        {
            txtboxIssueCommand.Text = "";
        }


        //===================================================================================//
        // LAUNCH BACKGROUND WORKER TO HANDLE PROCESS                                        //
        //===================================================================================//
        private void backgroundWorker01_DoWork(object sender, DoWorkEventArgs e)
        {
            ExternalExecution_Classes.LaunchExternalProgram("C:\\Windows\\system32\\cmd.exe", " -k help", false);
        }
    }
}
