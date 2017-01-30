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
using System.Net.NetworkInformation;

namespace GameServer_Manager

{
    public partial class GSM_Deployment : Form
    {
        public GSM_Deployment()
        {
            InitializeComponent();
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            browseDestinationFolder.ShowDialog();
            txtboxDestinationFolder.Text = browseDestinationFolder.SelectedPath;
        }



        private void btnDeployGameserver_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(GameServerManager.ActiveForm, dropdownServerSelection.Text, "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //Show the deployment progress bars
                lblDownloadProgress.Visible = true;
                lblDownloadProgressDetails.Visible = true;
                progressbarDownloadProgress.Visible = true;
                progressbarDownloadProgressOverall.Visible = true;
                btnCancelDeployGameserver.Visible = true;

                //Download and prepare SteamCMD
                lblDownloadProgressDetails.Text = "Status: Downloading SteamCMD...";
                SteamCMD_Classes.DownloadSteamCMD(txtboxDestinationFolder.Text);

                if (dropdownServerSelection.Text == "Garry's Mod")
                {
                    MetroMessageBox.Show(GameServerManager.ActiveForm, "Sorry, " + dropdownServerSelection.Text + " has not been coded into BGM yet, please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dropdownServerSelection.Text == "Team Fortress 2")
                {
                    MetroMessageBox.Show(GameServerManager.ActiveForm, "Sorry, " + dropdownServerSelection.Text + " has not been coded into BGM yet, please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dropdownServerSelection.Text == "SynergyMod HL2-Coop")
                {
                    MetroMessageBox.Show(GameServerManager.ActiveForm, "Sorry, " + dropdownServerSelection.Text + " has not been coded into BGM yet, please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dropdownServerSelection.Text == "Killing Floor 2")
                {
                    MetroMessageBox.Show(GameServerManager.ActiveForm, "Sorry, " + dropdownServerSelection.Text + " has not been coded into BGM yet, please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Hide the deployment progress bars
                lblDownloadProgressDetails.Text = "Status: Idle";
                lblDownloadProgress.Visible = false;
                lblDownloadProgressDetails.Visible = false;
                progressbarDownloadProgress.Visible = false;
                progressbarDownloadProgressOverall.Visible = false;
                btnCancelDeployGameserver.Visible = false;
            }
            else
            {
            }
            
        }


        private void dropdownServerSelection_SelectedValueChanged(object sender, EventArgs e)
        {
            //Enable the option to choose where to install the server.
            lblDestination.Visible = true;
            lblDestinationDetails.Visible = true;
            txtboxDestinationFolder.Visible = true;
            btnBrowseDestination.Visible = true;
            chkSeparateConfig.Visible = true;
            lblSeparateConfig.Visible = true;

            //Server Name Controls
            lblServerName.Visible = true;
            lblServerNameDetails.Visible = true;
            txtServerGivenName.Visible = true;

            //Deployment Button
            btnDeployGameserver.Enabled = true;

            if (chkSeparateConfig.Checked == true)
                {
                    lblDestination.Text = "Step 2: Choose existing " + dropdownServerSelection.Text + " server";
                }

            if (chkSeparateConfig.Checked == true)
            {
                txtServerGivenName.Text = dropdownExistingServer.Text + " Instance01";
            }
            else
            {
                txtServerGivenName.Text = dropdownServerSelection.Text;
            }
        }


        /*If the user checks to create a new config for an existing server, 
        rename the directory selector to indicate you are searching for an existing server.*/
        private void chkSeparateConfig_OnChange_1(object sender, EventArgs e)
        {
            if (chkSeparateConfig.Checked == true)
            {
                lblDestination.Text = "Step 2: Choose existing " + dropdownServerSelection.Text + " server";
                lblDestinationDetails.Text = "This will add a new configuration to an existing server to run a new instance of the server";
                txtboxDestinationFolder.Text = "N/A";
                txtboxDestinationFolder.Visible = false;
                dropdownExistingServer.Visible = true;
                txtServerGivenName.Text = "";
            }
            else
            {
                lblDestination.Text = "Step 2: Destination";
                lblDestinationDetails.Text = "Choose where you want to install the server";
                txtboxDestinationFolder.Text = @"C:\GSM\";
                txtboxDestinationFolder.Visible = true;
                dropdownExistingServer.Visible = false;
            }
        }

        //Server auto name-generation helper
        private void dropdownExistingServer_SelectedValueChanged(object sender, EventArgs e)
        {
            if (chkSeparateConfig.Checked == true)
            {
                txtServerGivenName.Text = dropdownExistingServer.Text + " Instance01";
            }
            else
            {
                txtServerGivenName.Text = dropdownServerSelection.Text;
            }
        }
    }
}
