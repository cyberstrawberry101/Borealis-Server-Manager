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

                    MetroMessageBox.Show(GameServerManager.ActiveForm, "Sorry, " + dropdownServerSelection.Text + " has not been coded into GSM yet, please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dropdownServerSelection.Text == "Team Fortress 2")
                {
                    MetroMessageBox.Show(GameServerManager.ActiveForm, "Sorry, " + dropdownServerSelection.Text + " has not been coded into GSM yet, please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dropdownServerSelection.Text == "SynergyMod HL2-Coop")
                {
                    MetroMessageBox.Show(GameServerManager.ActiveForm, "Sorry, " + dropdownServerSelection.Text + " has not been coded into GSM yet, please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dropdownServerSelection.Text == "Killing Floor 2")
                {
                    MetroMessageBox.Show(GameServerManager.ActiveForm, "Sorry, " + dropdownServerSelection.Text + " has not been coded into GSM yet, please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dropdownServerSelection.Text == "Minecraft")
                {
                    lblDownloadProgress.Visible = true;
                    lblDownloadProgressDetails.Visible = true;
                    progressbarDownloadProgress.Visible = true;
                    MetroMessageBox.Show(GameServerManager.ActiveForm, "Sorry, " + dropdownServerSelection.Text + " has not been coded into GSM yet, please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblDownloadProgress.Visible = false;
                    lblDownloadProgressDetails.Visible = false;
                    progressbarDownloadProgress.Visible = false;
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
            if (dropdownServerSelection.SelectedValue != "< Select a GameServer >")
            {
                //Enable the option to choose where to install the server.
                lblDestination.Visible = true;
                lblDestinationDetails.Visible = true;
                txtboxDestinationFolder.Visible = true;
                btnBrowseDestination.Visible = true;
                btnDeployGameserver.Enabled = true;
            }
            else
            {
                //Disable the option to choose where to install the server.
                lblDestination.Enabled = false;
                txtboxDestinationFolder.Enabled = false;
                btnBrowseDestination.Enabled = false;
                btnDeployGameserver.Enabled = false;
                lblDownloadProgress.Visible = false;
                lblDownloadProgressDetails.Visible = false;
                progressbarDownloadProgress.Visible = false;
            }
        }


    }
}
