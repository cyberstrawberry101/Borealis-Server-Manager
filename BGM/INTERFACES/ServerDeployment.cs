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

        private void btnDeployGameserver_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(GameServerManager.ActiveForm, dropdownServerSelection.Text, "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                btnCancelDeployGameserver.Visible = true;

                //Download and prepare SteamCMD
                lblDownloadProgressDetails.Text = "Status: Downloading / Installing SteamCMD...";
                SteamCMD_Classes.DownloadSteamCMD(txtboxDestinationFolder.Text);

                //Indicate what gameserver is currently being downloaded.
                lblDownloadProgressDetails.Text = "Status: Downloading " + dropdownServerSelection.Text + "...";
                switch (dropdownServerSelection.Text)
                {
                    case "Garry's Mod":
                        GarrysMod_Classes.DownloadGameServer(txtboxDestinationFolder.Text);
                        MetroMessageBox.Show(GameServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                    case "Team Fortress 2":
                        TeamFortress2_Classes.DownloadGameServer(txtboxDestinationFolder.Text);
                        MetroMessageBox.Show(GameServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                    case "SynergyMod HL2-Coop":
                        SynergyMod_Classes.DownloadGameServer(txtboxDestinationFolder.Text);
                        MetroMessageBox.Show(GameServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                    case "Killing Floor 2":
                        KillingFloor2_Classes.DownloadGameServer(txtboxDestinationFolder.Text);
                        MetroMessageBox.Show(GameServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                    case "Killing Floor":
                        KillingFloor_Classes.DownloadGameServer(txtboxDestinationFolder.Text);
                        MetroMessageBox.Show(GameServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                    case "Black Mesa: Deathmatch":
                        BlackMesaDeathmatch_Classes.DownloadGameServer(txtboxDestinationFolder.Text);
                        MetroMessageBox.Show(GameServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                    case "Chivalry: Deadliest Warrior":
                        ChivalryDW_Classes.DownloadGameServer(txtboxDestinationFolder.Text);
                        MetroMessageBox.Show(GameServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                    case "Chivalry: Medieval Warfare":
                        ChivalryMW_Classes.DownloadGameServer(txtboxDestinationFolder.Text);
                        MetroMessageBox.Show(GameServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                    case "Counter-Strike GO":
                        CounterStrikeGO_Classes.DownloadGameServer(txtboxDestinationFolder.Text);
                        MetroMessageBox.Show(GameServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                    case "Half-Life 2: Deathmatch":
                        HalfLife2Deathmatch_Classes.DownloadGameServer(txtboxDestinationFolder.Text);
                        MetroMessageBox.Show(GameServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                    case "Left 4 Dead":
                        Left4Dead_Classes.DownloadGameServer(txtboxDestinationFolder.Text);
                        MetroMessageBox.Show(GameServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                    case "Left 4 Dead 2":
                        Left4Dead2_Classes.DownloadGameServer(txtboxDestinationFolder.Text);
                        MetroMessageBox.Show(GameServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                    case "7 Days to Die":
                        SevenDaysToDie_Classes.DownloadGameServer(txtboxDestinationFolder.Text);
                        MetroMessageBox.Show(GameServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
