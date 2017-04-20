using MetroFramework;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Borealis
{
    public partial class TAB_DEPLOYMENT : Form
    {
        private DeploymentValues _currentDeploymentValues;

        public TAB_DEPLOYMENT()
        {
            InitializeComponent();
        }

        private void UIControlsHider(bool showHide)
        {
            if (showHide == false)
            {
                //Disable the option to choose where to install the server.
                lblDestination.Visible = false;
                lblDestinationDetails.Visible = false;
                lblDestinationDetailsSubtext.Visible = false;
                txtboxDestinationFolder.Visible = false;
                btnBrowseDestination.Visible = false;
                chkSeparateConfig.Visible = false;
                lblSeparateConfig.Visible = false;
                chkVerifyIntegrity.Visible = false;
                lblVerifyIntegrity.Visible = false;

                //Server Name Controls
                lblServerName.Visible = false;
                lblServerNameDetails.Visible = false;
                txtServerGivenName.Visible = false;

                //Deployment Button
                btnDeployGameserver.Enabled = false;
            }
            if (showHide == true)
            {
                //Disable the option to choose where to install the server.
                lblDestination.Visible = true;
                lblDestinationDetails.Visible = true;
                lblDestinationDetailsSubtext.Visible = true;
                txtboxDestinationFolder.Visible = true;
                btnBrowseDestination.Visible = true;
                chkSeparateConfig.Visible = true;
                lblSeparateConfig.Visible = true;
                chkVerifyIntegrity.Visible = true;
                lblVerifyIntegrity.Visible = true;

                //Server Name Controls
                lblServerName.Visible = true;
                lblServerNameDetails.Visible = true;
                txtServerGivenName.Visible = true;

                //Deployment Button
                btnDeployGameserver.Enabled = true;
            }
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
                foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
                {
                    dropdownExistingServer.Items.Add(gameserver.SERVER_name_friendly);
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
        private class DeploymentValues
        {
            public string SERVER_type { get; set; }
            public string verify_integrity { get; set; }
            public string SERVER_launch_arguments { get; set; }
            public string DIR_executable { get; set; }
            public string DIR_config { get; set; }
            public string DIR_config_file { get; set; }
            public string DIR_install_location { get; set; }
            public bool STEAM_authrequired { get; set; }
            public bool STEAM_steamcmd_required { get; set; }
            public bool STEAM_workshop_enabled { get; set; }
            public string ENGINE_type { get; set; }
            public string bsm_integration { get; set; }
        }

        //Methods that handle reporting progress back to the UI
        private void updateProgressStatus(int currentProgress, int overallProgress, string progressDetails)
        {
            progressbarDownloadProgressOverall.Value = overallProgress;
            lblDownloadProgressDetails.Text = progressDetails;
        }

        private void deployServerToMemory()
        {
            //Create the GameServer_Object
            GameServer_Object DeployConfiguredServer = new GameServer_Object();

            //Assign Data to the GameServer_Object
            //Server-based Properties
            DeployConfiguredServer.SERVER_name_friendly = txtServerGivenName.Text;
            DeployConfiguredServer.SERVER_type = _currentDeploymentValues.SERVER_type;
            DeployConfiguredServer.SERVER_launch_arguments = _currentDeploymentValues.SERVER_launch_arguments;

            //Directory-based Properties
            DeployConfiguredServer.DIR_install_location = _currentDeploymentValues.DIR_install_location;
            DeployConfiguredServer.DIR_executable = _currentDeploymentValues.DIR_executable;
            DeployConfiguredServer.DIR_config = _currentDeploymentValues.DIR_config;
            DeployConfiguredServer.DIR_config_file = _currentDeploymentValues.DIR_config_file;

            //Steam-based Properties
            DeployConfiguredServer.STEAM_authrequired = _currentDeploymentValues.STEAM_authrequired;
            DeployConfiguredServer.STEAM_steamcmd_required = _currentDeploymentValues.STEAM_steamcmd_required;
            DeployConfiguredServer.STEAM_workshop_enabled = _currentDeploymentValues.STEAM_workshop_enabled;

            //Miscellanious Properties
            DeployConfiguredServer.ENGINE_type = _currentDeploymentValues.ENGINE_type;
            DeployConfiguredServer.bsm_integration = _currentDeploymentValues.bsm_integration;

            //Store that newly assigned and JSON-filled server into the GameServer_Object Collection
            GameServer_Management.server_collection.Add(DeployConfiguredServer);

            //Redundantly write the data to disk in the event of a crash.
            DeployConfiguredServer.ExportJSON(true);

            btnCancelDeployGameserver.Visible = false;
            btnDeployGameserver.Enabled = true;
            _currentDeploymentValues = null;
        }

        private void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                Invoke(new Action(() =>
                {
                    lblDownloadProgressDetails.Text = e.Data;

                    // I'm a bit uneasy with directly calling .Groups, what happens when there isn't a match?
                    string progressMatch = Regex.Match(e.Data, @"\:([^)]*)\(").Groups[1].Value;
                    if (double.TryParse(progressMatch, out double result))
                    {
                        progressbarDownloadProgressOverall.Value = Convert.ToInt32(result);
                    }

                    if (_currentDeploymentValues.STEAM_steamcmd_required)
                    {
                        if (e.Data == "Success! App '" + ServerAPI.QUERY_STEAM_APPID(dropdownServerSelection.Text) + "' already up to date." || e.Data == "Success! App '" + ServerAPI.QUERY_STEAM_APPID(dropdownServerSelection.Text) + "' fully installed." || e.Data == "[----] Update complete, launching..." || e.Data == "[---] Update complete, launching...")
                        {
                            progressbarDownloadProgressOverall.Value = 100;
                            deployServerToMemory();
                            //MetroMessageBox.Show(BorealisServerManager.ActiveForm, txtServerGivenName.Text + "\n" + "Deployed to: [" + DeploymentValues.DIR_install_location + "]", "Gameserver Successfully Deployed!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            //panelProgress.Visible = false;
                        }
                        else if (e.Data == "Error! App '" + ServerAPI.QUERY_STEAM_APPID(dropdownServerSelection.Text) + "' state is 0x202 after update job." || e.Data == "Error! App '" + ServerAPI.QUERY_STEAM_APPID(dropdownServerSelection.Text) + "' state is 0x602 after update job.")
                        {
                            btnDeployGameserver.Enabled = false;
                            btnCancelDeployGameserver.Visible = true;
                            DeployGameServer(_currentDeploymentValues);
                        }
                    }
                    else
                    {
                        //RUN OTHER CODE FOR NON-STEAMCMD GAMESERVER
                    }
                }));

                //SteamCMD error and success handler.
            }
        }

        private void dropdownServerSelection_SelectedValueChanged(object sender, EventArgs e)
        {
            UIControlsHider(true); //Show UI elements to end-user

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
        private void DeployGameServer(DeploymentValues deploymentValues)
        {
            _currentDeploymentValues = deploymentValues;

            //Enable cancel button to terminate deployment process if needed.
            lblDownloadProgressDetails.Text = "Status: Downloading " + dropdownServerSelection.Text + "...";

            switch (deploymentValues.STEAM_steamcmd_required == true)
            {
                case true:
                    {
                        lblDownloadProgressDetails.Text = "Status: Downloading / Initializing SteamCMD...";
                        SteamCMD.DownloadSteamCMD();
                        switch (deploymentValues.STEAM_authrequired == true)
                        {
                            case true:
                                MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Due to the fact that we do not have an authentication system in place for Steam, you cannot download non-anonymous SteamCMD dedicated servers at this time.  We apologize, and hope to get this incorporated soon!", "Steam Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                btnDeployGameserver.Enabled = true;
                                btnCancelDeployGameserver.Visible = false;
                                break;

                            case false:
                                try
                                {
                                    ExecuteWithRedirect(Environment.CurrentDirectory + @"\steamcmd.exe", string.Concat("+login anonymous +force_install_dir ", "\"", deploymentValues.DIR_install_location, "\"", " +app_update ", ServerAPI.QUERY_STEAM_APPID(dropdownServerSelection.Text), deploymentValues.verify_integrity, " +quit"));
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
            //Pull all gameserver data from gameservers.json, split all json strings into a list, iterate through that list for specific data.
            if (GameServer_Management.server_collection != null)
            {
                foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
                {
                    if (txtServerGivenName.Text == gameserver.SERVER_name_friendly)
                    {
                        MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Unfortunately, you must give unique names to every server you deploy, using the exact same name would cause several issues.", "Identical gameserver name already exists.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; //Break gracefully out of the entire void function.
                    }
                }
            }

            if (chkSeparateConfig.Checked == true)
            {
                MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Unfortunately at this time, deploying instances of gameservers is not supported.", "Deploy New GameServer Instance?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Query specific appID for all required data.
            GameServer_Object gameServer = ServerAPI.QUERY_DATA(ServerAPI.QUERY_STEAM_APPID(dropdownServerSelection.Text));

            //Retrieve the data that was just stored into the deployment server list.
            var deploymentValues = new DeploymentValues
            {
                SERVER_type = gameServer.SERVER_type,
                SERVER_launch_arguments = gameServer.SERVER_launch_arguments,
                DIR_executable = gameServer.DIR_executable,
                DIR_config = gameServer.DIR_config,
                DIR_config_file = gameServer.DIR_config_file,
                STEAM_authrequired = gameServer.STEAM_authrequired,
                STEAM_steamcmd_required = gameServer.STEAM_steamcmd_required,
                STEAM_workshop_enabled = gameServer.STEAM_workshop_enabled,
                ENGINE_type = gameServer.ENGINE_type,
                bsm_integration = gameServer.bsm_integration
            };

            //Determine where to deploy the server based on user input.
            if (txtboxDestinationFolder.Text == "")
            {
                deploymentValues.DIR_install_location = Environment.CurrentDirectory;
            }
            else
            {
                deploymentValues.DIR_install_location = txtboxDestinationFolder.Text;
            }

            //Determine whether or not to verify integrity of the installation.
            if (chkVerifyIntegrity.Value == true)
            {
                deploymentValues.verify_integrity = " +validate";
            }
            else
            {
                deploymentValues.verify_integrity = "";
            }

            switch (deploymentValues.bsm_integration)
            {
                case "none":
                    if (MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" + deploymentValues.DIR_install_location + "]" + "\n\nWARNING: This gameserver currently has NO BSM support.\nYou can deploy it, but BSM cannot configure or control it at this time.", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        panelProgress.Visible = true;
                        btnCancelDeployGameserver.Visible = true;
                        btnDeployGameserver.Enabled = false;
                        DeployGameServer(deploymentValues);
                    }
                    break;
                case "partial":
                    if (MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" + deploymentValues.DIR_install_location + "]" + "\n\nWARNING: This gameserver currently has PARTIAL BSM support.\nYou can deploy it, but BSM can only configure it at this time, you have no ability to control it directly through BSM.", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        panelProgress.Visible = true;
                        btnCancelDeployGameserver.Visible = true;
                        btnDeployGameserver.Enabled = false;
                        DeployGameServer(deploymentValues);
                    }
                    break;
                case "full":
                    if (MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" + deploymentValues.DIR_install_location + "]", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        panelProgress.Visible = true;
                        btnCancelDeployGameserver.Visible = true;
                        btnDeployGameserver.Enabled = false;
                        DeployGameServer(deploymentValues);
                    }
                    break;
            }
        }
        private void btnCancelDeployGameserver_Click(object sender, EventArgs e)
        {
            if (_currentDeploymentValues.STEAM_steamcmd_required == true)
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
            _currentDeploymentValues = null;
        }
    }
 }
