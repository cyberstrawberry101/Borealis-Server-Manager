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
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;
using Newtonsoft.Json.Linq;

namespace Borealis

{

    public partial class ServerDeployment : Form
    {
        public ServerDeployment()
        {
            InitializeComponent();
        }

        //===================================================================================//
        // STARTUP                                                                           //
        //===================================================================================//
        private void ServerDeployment_Load(object sender, EventArgs e)
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    var json = webClient.DownloadString("http://sfo3.hauteclaire.me/index");
                    Newtonsoft.Json.Linq.JObject o = Newtonsoft.Json.Linq.JObject.Parse(json);

                    foreach (var serverAppName in o)
                    {
                        JToken value = serverAppName.Value;
                        dropdownServerSelection.Items.Add(value.ToString());
                    }
                }
                dropdownServerSelection.PromptText = "< Select a gameserver to deploy >";
            }
            catch (Exception)
            {
                MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Cannot communicate with http://sfo3.hauteclaire.me \nThis means that deployment at this time is impossible.", "Server Unreachable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //===================================================================================//
        // REPORT PROGRESS UPDATES VIA THIS FUNCTION                                         //
        //===================================================================================//
        public void updateProgressStatus(int currentProgress, int overallProgress, string progressDetails)
        {
            progressbarDownloadProgress.Value = currentProgress;
            progressbarDownloadProgressOverall.Value = overallProgress;
            lblDownloadProgressDetails.Text = progressDetails;
        }

        //===================================================================================//
        // BROWSE FOR DIRECTORY USER WISHES TO DEPLOY SERVER TO                              //
        //===================================================================================//
        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            browseDestinationFolder.ShowDialog();
            txtboxDestinationFolder.Text = browseDestinationFolder.SelectedPath;
        }

        //===================================================================================//
        // DEPLOY A GAMESERVER                                                               //
        //===================================================================================//
        public static class DeploymentValues
        {
            //Variables to be used during deployment:
            public static string steamcmd_required { get; set; }
            public static string bsm_integration { get; set; }
            public static string steam_authrequired { get; set; }
            public static string deployment_directory { get; set; }
        }

        private void btnDeployGameserver_Click(object sender, EventArgs e)
        {
            //btnCancelDeployGameserver.Visible = true;
            lblDownloadProgressDetails.Text = "Status: Downloading " + dropdownServerSelection.Text + "...";

            //Assign Static Values:
            DeploymentValues.bsm_integration = ServerAPI_Classes.QUERY_DATA("bsm_integration", ServerAPI_Classes.QUERY_STEAM_APPID(dropdownServerSelection.Text));
            DeploymentValues.steamcmd_required = ServerAPI_Classes.QUERY_DATA("steamcmd_required", ServerAPI_Classes.QUERY_STEAM_APPID(dropdownServerSelection.Text));
            DeploymentValues.steam_authrequired = ServerAPI_Classes.QUERY_DATA("steam_authrequired", ServerAPI_Classes.QUERY_STEAM_APPID(dropdownServerSelection.Text));
            if (txtboxDestinationFolder.Text == "")
                {
                    DeploymentValues.deployment_directory = Environment.CurrentDirectory;
                }
            else
                {
                    DeploymentValues.deployment_directory = txtboxDestinationFolder.Text;
                }
            
            //Deploy the gameserver:
            switch (DeploymentValues.bsm_integration)
            {
                case "none":
                    {
                        switch (DeploymentValues.steamcmd_required)
                        {
                            case "True":
                                {
                                    if (MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" + DeploymentValues.deployment_directory + "]" + "\n\nWARNING: This gameserver currently has NO BGM support.\nYou can deploy it, but BGM cannot configure or control it at this time.", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                                    {
                                        SteamCMD_Classes.DownloadSteamCMD();
                                        switch (DeploymentValues.steam_authrequired)
                                        {
                                            case "True":
                                                MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Due to the fact that we do not have an authentication system in place for Steam, you cannot download non-anonymous SteamCMD dedicated servers at this time.  We apologize, and hope to get this incorporated soon!", "Steam Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;

                                            case "False":
                                                ExternalExecution_Classes.LaunchExternalProgram(Environment.CurrentDirectory + @"\steamcmd.exe", string.Concat("+login anonymous +force_install_dir ", "\"", DeploymentValues.deployment_directory, "\"", " +app_update ",ServerAPI_Classes.QUERY_STEAM_APPID(dropdownServerSelection.Text), " +quit"), false);
                                                break;
                                        }
                                        MetroMessageBox.Show(BorealisServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    }
                                }
                                break;

                            case "False":
                                {
                                    //RUN OTHER CODE TO DEPLOY THE NON-STEAMCMD GAMESERVER
                                }
                                break;
                        }
                    }
                    break;

                case "partial":
                    {
                        switch (DeploymentValues.steamcmd_required)
                        {
                            case "True":
                                {
                                    if (MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" + DeploymentValues.deployment_directory + "]" + "\n\nWARNING: This gameserver currently has PARTIAL BGM support.\nYou can deploy it, but BGM can only configure it at this time, you have no ability to control it directly through BGM.", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                                    {
                                        SteamCMD_Classes.DownloadSteamCMD();
                                        switch (DeploymentValues.steam_authrequired)
                                        {
                                            case "True":
                                                MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Due to the fact that we do not have an authentication system in place for Steam, you cannot download non-anonymous SteamCMD dedicated servers at this time.  We apologize, and hope to get this incorporated soon!", "Steam Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;

                                            case "False":
                                                ExternalExecution_Classes.LaunchExternalProgram(Environment.CurrentDirectory + @"\steamcmd.exe", string.Concat("+login anonymous +force_install_dir ", "\"", DeploymentValues.deployment_directory, "\"", " +app_update ", ServerAPI_Classes.QUERY_STEAM_APPID(dropdownServerSelection.Text), " +quit"), false);
                                                break;
                                        }
                                        MetroMessageBox.Show(BorealisServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    }
                                }
                                break;

                            case "False":
                                {
                                    //RUN OTHER CODE TO DEPLOY THE NON-STEAMCMD GAMESERVER
                                }
                                break;
                        }
                    }
                    break;

                case "full":
                    {
                        switch (DeploymentValues.steamcmd_required)
                        {
                            case "True":
                                {
                                    if (MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" + DeploymentValues.deployment_directory + "]", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        SteamCMD_Classes.DownloadSteamCMD();
                                        switch (DeploymentValues.steam_authrequired)
                                        {
                                            case "True":
                                                MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Due to the fact that we do not have an authentication system in place for Steam, you cannot download non-anonymous SteamCMD dedicated servers at this time.  We apologize, and hope to get this incorporated soon!", "Steam Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;

                                            case "False":
                                                ExternalExecution_Classes.LaunchExternalProgram(Environment.CurrentDirectory + @"\steamcmd.exe", string.Concat("+login anonymous +force_install_dir ", "\"", DeploymentValues.deployment_directory, "\"", " +app_update ", ServerAPI_Classes.QUERY_STEAM_APPID(dropdownServerSelection.Text), " +quit"), false);
                                                break;
                                        }
                                        MetroMessageBox.Show(BorealisServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    }
                                }
                                break;

                            case "False":
                                {
                                    //RUN OTHER CODE TO DEPLOY THE NON-STEAMCMD GAMESERVER
                                }
                                break;
                        }
                    }
                    break;
            }


            //Finish up the process!
            //btnCancelDeployGameserver.Visible = false;
            lblDownloadProgressDetails.Text = "Status: Idle";
        }

        //===================================================================================//
        // UPDATE INTERFACE WHEN A GAMESERVER HAS BEEN CHOSEN FROM THE DROPDOWN LIST         //
        //===================================================================================//
        private void dropdownServerSelection_SelectedValueChanged(object sender, EventArgs e)
        {
            //Enable the option to choose where to install the server.
            lblDestination.Visible = true;
            lblDestinationDetails.Visible = true;
            lblDestinationDetailsSubtext.Visible = true;
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

        //===================================================================================//
        // UPDATE INTERFACE IF A USER WANTS TO DEPLOY A SEPARATE CONFIGURATION               //
        //===================================================================================//
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

        //===================================================================================//
        // AUTO-GENERATE A NAME FOR SERVERS AND SERVER CONFIGURATION INSTANCES               //
        //===================================================================================//
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
