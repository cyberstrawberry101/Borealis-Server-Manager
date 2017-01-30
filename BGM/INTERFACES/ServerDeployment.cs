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

    public partial class ServerDeployment : Form
    {
        public ServerDeployment()
        {
            InitializeComponent();
        }

        public void updateProgressStatus(int currentProgress, int overallProgress, string progressDetails)
        {
            progressbarDownloadProgress.Value = currentProgress;
            progressbarDownloadProgressOverall.Value = overallProgress;
            lblDownloadProgressDetails.Text = progressDetails;
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            browseDestinationFolder.ShowDialog();
            txtboxDestinationFolder.Text = browseDestinationFolder.SelectedPath;
        }

        //Download SteamCMD in the background and report work.
        private void steamCMDWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SteamCMD_Classes.DownloadSteamCMD(txtboxDestinationFolder.Text);
        }
        //Report progress of background worker.
        private void steamCMDWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressbarDownloadProgress.Value = e.ProgressPercentage;
            progressbarDownloadProgressOverall.Value = e.ProgressPercentage;
        }

        private void btnDeployGameserver_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(GameServerManager.ActiveForm, dropdownServerSelection.Text, "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                btnCancelDeployGameserver.Visible = true;

                //Download and prepare SteamCMD
                lblDownloadProgressDetails.Text = "Status: Downloading / Installing SteamCMD...";
                //steamCMDWorker.RunWorkerAsync();
                SteamCMD_Classes.DownloadSteamCMD(txtboxDestinationFolder.Text);
                switch (dropdownServerSelection.Text)
                {
                    case "Garry's Mod":
                        MetroMessageBox.Show(GameServerManager.ActiveForm, "Sorry, " + dropdownServerSelection.Text + " has not been fully coded into BGM yet, please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblDownloadProgressDetails.Text = "Status: Downloading " + dropdownServerSelection.Text + " ...";
                        GarrysMod_Classes.DownloadGameServer();
                        lblDownloadProgressDetails.Text = "Status: Configuring " + dropdownServerSelection.Text + " ...";
                        GarrysMod_Classes.ConfigureGameServer();
                        lblDownloadProgressDetails.Text = "Status: Generating Launch Scripts " + dropdownServerSelection.Text + " ...";
                        GarrysMod_Classes.GenerateScripts();
                        break;
                    case "Team Fortress 2":
                        MetroMessageBox.Show(GameServerManager.ActiveForm, "Sorry, " + dropdownServerSelection.Text + " has not been fully coded into BGM yet, please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblDownloadProgressDetails.Text = "Status: Downloading " + dropdownServerSelection.Text + " ...";
                        TeamFortress2_Classes.DownloadGameServer();
                        lblDownloadProgressDetails.Text = "Status: Configuring " + dropdownServerSelection.Text + " ...";
                        TeamFortress2_Classes.ConfigureGameServer();
                        lblDownloadProgressDetails.Text = "Status: Generating Launch Scripts " + dropdownServerSelection.Text + " ...";
                        TeamFortress2_Classes.GenerateScripts();
                        break;
                    case "SynergyMod HL2-Coop":
                        MetroMessageBox.Show(GameServerManager.ActiveForm, "Sorry, " + dropdownServerSelection.Text + " has not been fully coded into BGM yet, please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblDownloadProgressDetails.Text = "Status: Downloading " + dropdownServerSelection.Text + " ...";
                        SynergyMod_Classes.DownloadGameServer();
                        lblDownloadProgressDetails.Text = "Status: Configuring " + dropdownServerSelection.Text + " ...";
                        SynergyMod_Classes.ConfigureGameServer();
                        lblDownloadProgressDetails.Text = "Status: Generating Launch Scripts " + dropdownServerSelection.Text + " ...";
                        SynergyMod_Classes.GenerateScripts();
                        break;
                    case "Killing Floor 2":
                        MetroMessageBox.Show(GameServerManager.ActiveForm, "Sorry, " + dropdownServerSelection.Text + " has not been fully coded into BGM yet, please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblDownloadProgressDetails.Text = "Status: Downloading " + dropdownServerSelection.Text + " ...";
                        KillingFloor2_Classes.DownloadGameServer();
                        lblDownloadProgressDetails.Text = "Status: Configuring " + dropdownServerSelection.Text + " ...";
                        KillingFloor2_Classes.ConfigureGameServer();
                        lblDownloadProgressDetails.Text = "Status: Generating Launch Scripts " + dropdownServerSelection.Text + " ...";
                        KillingFloor2_Classes.GenerateScripts();
                        break;
                    default:
                        MetroMessageBox.Show(GameServerManager.ActiveForm, "You should not be seeing this right now.\nHow did you get here?", "Invalid Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                lblDownloadProgressDetails.Text = "Status: Idle";
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

        private void ServerDeployment_Load(object sender, EventArgs e)
        {

        }
    }
}
