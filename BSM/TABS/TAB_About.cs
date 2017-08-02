using MetroFramework;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Borealis
{

    public partial class TAB_STEAMGUARD_TOKEN : Form
    {
        public TAB_STEAMGUARD_TOKEN()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://devtools.bunifu.co.ke");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/thielj/MetroFramework");
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://icons8.com/web-app");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.freepik.com");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://facepunch.com/showthread.php?t=1550584");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/6rMpYXz");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/cyberstrawberry101/Borealis-Server-Manager");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mezarith/bsmapi");
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
                    //proc.StartInfo.CreateNoWindow = true;
                    //proc.ErrorDataReceived += proc_DataReceived;
                    //proc.OutputDataReceived += proc_DataReceived;
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
            }
        }

        private void bunifuThinButton22_Click(object sender, System.EventArgs e)
        {
            Execute(@"C:\Windows\System32\cmd.exe", "-k help", true);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }
    }
}
