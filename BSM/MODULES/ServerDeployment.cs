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
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;

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
            public static string deployment_directory { get; set; }
            public static string verify_integrity { get; set; }
        }

        public void ExecuteWithRedirect(string argProgramName, string argParameters)
        {
            var proc = new Process();
            proc.StartInfo.Arguments = argParameters;
            proc.StartInfo.FileName = argProgramName;
            proc.StartInfo.UseShellExecute = false;

            // set up output redirection
            proc.StartInfo.RedirectStandardOutput = true;
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

        void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                lblDownloadProgressDetails.Text = e.Data;
                try
                {
                    progressbarDownloadProgressOverall.Value = Convert.ToInt32(Double.Parse(Regex.Match(e.Data, @"\:([^)]*)\(").Groups[1].Value));
                }
                catch (Exception)
                {
                    //Do nothing
                }
                
                //SteamCMD error and success handler.
                if (ServerAPI_Classes.QUERY_JOBJECT.steamcmd_required == "True")
                {
                    if (e.Data == "Success! App '" + ServerAPI_Classes.QUERY_STEAM_APPID(dropdownServerSelection.Text) + "' already up to date." || e.Data == "Success! App '" + ServerAPI_Classes.QUERY_STEAM_APPID(dropdownServerSelection.Text) + "' fully installed.")
                    {
                        MetroMessageBox.Show(BorealisServerManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        SettingsManagement_Classes.DeployGameserver(txtServerGivenName.Text, dropdownServerSelection.Text, DeploymentValues.deployment_directory, ServerAPI_Classes.QUERY_JOBJECT.server_executable_location, ServerAPI_Classes.QUERY_JOBJECT.default_launch_arguments, ServerAPI_Classes.QUERY_JOBJECT.server_config_file);
                        btnCancelDeployGameserver.Visible = false;
                    }
                    else if (e.Data == "Error! App '" + ServerAPI_Classes.QUERY_STEAM_APPID(dropdownServerSelection.Text) + "' state is 0x202 after update job.")
                    {
                        DeployGameServer();
                    }
                }
                else
                {
                    //RUN OTHER CODE FOR NON-STEAMCMD GAMESERVER
                }
            }
        }

        //===================================================================================//
        // STAND-ALONE DEPLOYMENT CODE                                                       //
        //===================================================================================//
        private void DeployGameServer()
        {
            //Enable cancel button to terminate deployment process if needed.
            lblDownloadProgressDetails.Text = "Status: Downloading " + dropdownServerSelection.Text + "...";
            btnCancelDeployGameserver.Visible = true;

            switch (ServerAPI_Classes.QUERY_JOBJECT.steamcmd_required)
            {
                case "True":
                    {
                        SteamCMD_Classes.DownloadSteamCMD();
                        switch (ServerAPI_Classes.QUERY_JOBJECT.steam_authrequired)
                        {
                            case "True":
                                MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Due to the fact that we do not have an authentication system in place for Steam, you cannot download non-anonymous SteamCMD dedicated servers at this time.  We apologize, and hope to get this incorporated soon!", "Steam Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;

                            case "False":
                                ExecuteWithRedirect(Environment.CurrentDirectory + @"\steamcmd.exe", string.Concat("+login anonymous +force_install_dir ", "\"", DeploymentValues.deployment_directory, "\"", " +app_update ", ServerAPI_Classes.QUERY_STEAM_APPID(dropdownServerSelection.Text), DeploymentValues.verify_integrity, " +quit"));
                                break;
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

        //===================================================================================//
        // QUERY THE USER TO VERIFY DEPLOYMENT BEFORE BEGINNING SERVER DEPLOYMENT            //
        //===================================================================================//
        private void btnDeployGameserver_Click(object sender, EventArgs e)
        {
            //Query specific appID for all required data.
            ServerAPI_Classes.QUERY_DATA(ServerAPI_Classes.QUERY_STEAM_APPID(dropdownServerSelection.Text));

            //Determine where to deploy the server based on user input.
            if (txtboxDestinationFolder.Text == "")
            {
                DeploymentValues.deployment_directory = Environment.CurrentDirectory;
            }
            else
            {
                DeploymentValues.deployment_directory = txtboxDestinationFolder.Text;
            }

            //Determine whether or not to verify integrity of the installation.
            if (chkVerifyIntegrity.Value == true)
            {
                DeploymentValues.verify_integrity = " +validate";
            }
            else
            {
                DeploymentValues.verify_integrity = "";
            }

            switch (ServerAPI_Classes.QUERY_JOBJECT.bsm_integration)
            {
                case "none":
                    if (MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" + DeploymentValues.deployment_directory + "]" + "\n\nWARNING: This gameserver currently has NO BGM support.\nYou can deploy it, but BGM cannot configure or control it at this time.", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        DeployGameServer();
                    }
                    break;
                case "partial":
                    if (MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" + DeploymentValues.deployment_directory + "]" + "\n\nWARNING: This gameserver currently has PARTIAL BGM support.\nYou can deploy it, but BGM can only configure it at this time, you have no ability to control it directly through BGM.", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        DeployGameServer();
                    }
                    break;
                case "full":
                    if (MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" + DeploymentValues.deployment_directory + "]", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DeployGameServer();
                    }
                    break;
            }
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
            chkVerifyIntegrity.Visible = true;
            lblVerifyIntegrity.Visible = true;
            panelProgress.Visible = true;

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
                txtServerGivenName.Text = dropdownExistingServer.Text + " Instance";
            }
            else
            {
                txtServerGivenName.Text = dropdownServerSelection.Text;
            }
        }

        private void btnCancelDeployGameserver_Click(object sender, EventArgs e)
        {
            if (ServerAPI_Classes.QUERY_JOBJECT.steamcmd_required == "True")
            {
                ExecuteWithRedirect(@"C:\Windows\System32\taskkill", "/F /IM steamcmd.exe");
                btnCancelDeployGameserver.Visible = false;
            }
            else
            {
                //Kill program being used to deploy a server.
            }
        }
    }
 }
