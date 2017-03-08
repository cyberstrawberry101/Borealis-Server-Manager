using System;
using System.Windows.Forms;
using MetroFramework;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Borealis
{
    public partial class TAB_DEPLOYMENT : Form
    {
        public TAB_DEPLOYMENT()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            //Populate gameserver list by querying the available configurations from the server.
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    var json = webClient.DownloadString("http://phantom-net.duckdns.org:1337/index");

                    foreach (var serverAppName in JObject.Parse(json))
                    {
                        JToken value = serverAppName.Value;
                        dropdownServerSelection.Items.Add(value.ToString());
                    }
                }
                dropdownServerSelection.PromptText = "< Select a gameserver to deploy >";
            }
            catch (Exception)
            {
                MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Cannot connect to http://phantom-net.duckdns.org:1337 \nThis means that deployment at this time is impossible.", "Server Unreachable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameServer_Management.server_collection != null)
            {
                foreach (JObject gameserver in GameServer_Management.server_collection)
                {
                    dropdownExistingServer.Items.Add((string)gameserver["SERVER_name"]);
                }
            }
        }

        //===================================================================================//
        // STARTUP:                                                                          //
        //===================================================================================//
        private void ServerDeployment_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        //===================================================================================//
        // DEPLOYMENT:                                                                       //
        //===================================================================================//
        //Class to store relevant deployment values during deployment
        private static class DeploymentValues
        {
            public static string verify_integrity { get; set; }
            public static string SERVER_name { get; set; }
            public static string SERVER_launch_arguments { get; set; }
            public static string DIR_executable { get; set; }
            public static string DIR_config { get; set; }
            public static string DIR_config_file { get; set; }
            public static string DIR_install_location { get; set; }
            public static bool STEAM_authrequired { get; set; }
            public static bool STEAM_steamcmd_required { get; set; }
            public static bool STEAM_workshop_enabled { get; set; }
            public static string ENGINE_type { get; set; }
            public static string bsm_integration { get; set; }
        }

        //Methods that handle reporting progress back to the UI
        private void updateProgressStatus(int currentProgress, int overallProgress, string progressDetails)
        {
            progressbarDownloadProgressOverall.Value = overallProgress;
            lblDownloadProgressDetails.Text = progressDetails;
        }

        private void deployServerToMemory()
        {
            GameServer_Management DeployConfig = new GameServer_Management();
            DeployConfig.DeployGameserver(
                //Server-based Properties
                DeploymentValues.SERVER_name,
                txtServerGivenName.Text,
                DeploymentValues.SERVER_name,
                DeploymentValues.SERVER_launch_arguments,
                false,

                //Directory-based Properties
                DeploymentValues.DIR_install_location,
                DeploymentValues.DIR_executable,
                DeploymentValues.DIR_config,
                DeploymentValues.DIR_config_file,

                //Steam-based Properties
                DeploymentValues.STEAM_authrequired,
                DeploymentValues.STEAM_steamcmd_required,
                DeploymentValues.STEAM_workshop_enabled,

                //Miscellanious Properties
                DeploymentValues.ENGINE_type,
                DeploymentValues.bsm_integration,

                //Deployment Property
                false);
            btnCancelDeployGameserver.Visible = false;
            btnDeployGameserver.Enabled = true;
        }

        private void proc_DataReceived(object sender, DataReceivedEventArgs e)
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
                
                if (DeploymentValues.STEAM_steamcmd_required == true)
                {
                    if (e.Data == "Success! App '" + ServerAPI.QUERY_STEAM_APPID(dropdownServerSelection.Text) + "' already up to date." || e.Data == "Success! App '" + ServerAPI.QUERY_STEAM_APPID(dropdownServerSelection.Text) + "' fully installed." || e.Data == "[----] Update complete, launching..." || e.Data == "[---] Update complete, launching...")
                    {
                        deployServerToMemory();
                    }
                    else if (e.Data == "Error! App '" + ServerAPI.QUERY_STEAM_APPID(dropdownServerSelection.Text) + "' state is 0x202 after update job.")
                    {
                        btnDeployGameserver.Enabled = false;
                        btnCancelDeployGameserver.Visible = true;
                        DeployGameServer();
                    }
                }
                else
                {
                    //RUN OTHER CODE FOR NON-STEAMCMD GAMESERVER
                }
            }
        }
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
                lblDestinationDetailsSubtext.Visible = false;
            }
            else
            {
                lblDestination.Text = "Step 2: Destination";
                lblDestinationDetails.Text = "Choose where you want to install the server";
                txtboxDestinationFolder.Text = @"C:\BSM\";
                txtboxDestinationFolder.Visible = true;
                dropdownExistingServer.Visible = false;
                lblDestinationDetailsSubtext.Visible = true;
            }
        }

        //Methods that handle deployment itself.
        private void ExecuteWithRedirect(string argProgramName, string argParameters)
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
        private void DeployGameServer()
        {
            //Enable cancel button to terminate deployment process if needed.
            lblDownloadProgressDetails.Text = "Status: Downloading " + dropdownServerSelection.Text + "...";

            switch (DeploymentValues.STEAM_steamcmd_required == true)
            {
                case true:
                    {
                        lblDownloadProgressDetails.Text = "Status: Downloading / Initializing SteamCMD...";
                        SteamCMD.DownloadSteamCMD();
                        switch (DeploymentValues.STEAM_authrequired == true)
                        {
                            case true:
                                MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Due to the fact that we do not have an authentication system in place for Steam, you cannot download non-anonymous SteamCMD dedicated servers at this time.  We apologize, and hope to get this incorporated soon!", "Steam Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                btnDeployGameserver.Enabled = true;
                                btnCancelDeployGameserver.Visible = false;
                                break;

                            case false:
                                try
                                {
                                    ExecuteWithRedirect(Environment.CurrentDirectory + @"\steamcmd.exe", string.Concat("+login anonymous +force_install_dir ", "\"", DeploymentValues.DIR_install_location, "\"", " +app_update ", ServerAPI.QUERY_STEAM_APPID(dropdownServerSelection.Text), DeploymentValues.verify_integrity, " +quit"));
                                }
                                catch (Exception)
                                {
                                    MetroMessageBox.Show(BorealisServerManager.ActiveForm, "We cannot find the required executable to deploy the server!  Either it is missing, or the server configuration for this gameserver is corrupted.", "Error Deploying GameServer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;
                        }
                    }
                    break;

                case false:
                    {
                        //RUN OTHER CODE TO DEPLOY THE NON-STEAMCMD GAMESERVER
                    }
                    break;
            }
        }
        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            browseDestinationFolder.ShowDialog();
            txtboxDestinationFolder.Text = browseDestinationFolder.SelectedPath;
        }
        private void btnDeployGameserver_Click(object sender, EventArgs e)
        {
            if (chkSeparateConfig.Checked == true)
            {
                MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Unfortunately at this time, deploying instances of gameservers is not supported.", "Deploy New GameServer Instance?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Query specific appID for all required data.
                ServerAPI.QUERY_DATA(ServerAPI.QUERY_STEAM_APPID(dropdownServerSelection.Text));

                //Retrieve the data that was just stored into the deployment server list.
                if (GameServer_Management.deployment_server != null)
                {
                    //Create a new object to store the deployment data!
                    GameServer_Management.GameServer DeploymentServer = new GameServer_Management.GameServer();

                    foreach (JObject serverDeploymentData in GameServer_Management.deployment_server)
                    {
                        DeploymentValues.SERVER_name = (string)serverDeploymentData["SERVER_name"];
                        DeploymentValues.SERVER_launch_arguments = (string)serverDeploymentData["SERVER_launch_arguments"];
                        DeploymentValues.DIR_executable = (string)serverDeploymentData["DIR_executable"];
                        DeploymentValues.DIR_config = (string)serverDeploymentData["DIR_config"];
                        DeploymentValues.DIR_config_file = (string)serverDeploymentData["DIR_config_file"];
                        DeploymentValues.STEAM_authrequired = (bool)serverDeploymentData["STEAM_authrequired"];
                        DeploymentValues.STEAM_steamcmd_required = (bool)serverDeploymentData["STEAM_steamcmd_required"];
                        DeploymentValues.STEAM_workshop_enabled = (bool)serverDeploymentData["STEAM_workshop_enabled"];
                        DeploymentValues.ENGINE_type = (string)serverDeploymentData["ENGINE_type"];
                        DeploymentValues.bsm_integration = (string)serverDeploymentData["bsm_integration"];
                    }
                }

                //Determine where to deploy the server based on user input.
                if (txtboxDestinationFolder.Text == "")
                {
                    DeploymentValues.DIR_install_location = Environment.CurrentDirectory;
                }
                else
                {
                    DeploymentValues.DIR_install_location = txtboxDestinationFolder.Text;
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

                switch (DeploymentValues.bsm_integration)
                {
                    case "none":
                        if (MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" + DeploymentValues.DIR_install_location + "]" + "\n\nWARNING: This gameserver currently has NO BSM support.\nYou can deploy it, but BSM cannot configure or control it at this time.", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                        {
                            btnCancelDeployGameserver.Visible = true;
                            btnDeployGameserver.Enabled = false;
                            DeployGameServer();
                        }
                        break;
                    case "partial":
                        if (MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" + DeploymentValues.DIR_install_location + "]" + "\n\nWARNING: This gameserver currently has PARTIAL BSM support.\nYou can deploy it, but BSM can only configure it at this time, you have no ability to control it directly through BSM.", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            btnCancelDeployGameserver.Visible = true;
                            btnDeployGameserver.Enabled = false;
                            DeployGameServer();
                        }
                        break;
                    case "full":
                        if (MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" + DeploymentValues.DIR_install_location + "]", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            btnCancelDeployGameserver.Visible = true;
                            btnDeployGameserver.Enabled = false;
                            DeployGameServer();
                        }
                        break;
                }
            }
            
            
        }
        private void btnCancelDeployGameserver_Click(object sender, EventArgs e)
        {
            if (DeploymentValues.STEAM_steamcmd_required == true)
            {
                ExecuteWithRedirect(@"C:\Windows\System32\taskkill", "/F /IM steamcmd.exe");
                btnCancelDeployGameserver.Visible = false;
            }
            else
            {
                //Kill program being used to deploy a server.
            }
            btnDeployGameserver.Enabled = true;
            progressbarDownloadProgressOverall.Value = 0;
        }
    }
 }
