using MetroFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Serilog;

namespace Borealis
{
    public partial class TAB_DEPLOYMENT : Form
    {
        private DeploymentValues _currentDeploymentValues;

        public TAB_DEPLOYMENT()
        {
            this.InitializeComponent();
        }

        private void UIControlsHider(bool showHide)
        {
            if (showHide)
            {
                //Disable the option to choose where to install the server.
                this.lblDestination.Visible = true;
                this.lblDestinationDetails.Visible = true;
                this.lblDestinationDetailsSubtext.Visible = true;
                this.txtboxDestinationFolder.Visible = true;
                this.btnBrowseDestination.Visible = true;
                this.chkSeparateConfig.Visible = true;
                this.lblSeparateConfig.Visible = true;
                this.chkVerifyIntegrity.Visible = true;
                this.lblVerifyIntegrity.Visible = true;

                //Server Name Controls
                this.lblServerName.Visible = true;
                this.lblServerNameDetails.Visible = true;
                this.txtServerGivenName.Visible = true;

                //Deployment Button
                this.btnDeployGameserver.Enabled = true;
            }
            else
            {
                //Disable the option to choose where to install the server.
                this.lblDestination.Visible = false;
                this.lblDestinationDetails.Visible = false;
                this.lblDestinationDetailsSubtext.Visible = false;
                this.txtboxDestinationFolder.Visible = false;
                this.btnBrowseDestination.Visible = false;
                this.chkSeparateConfig.Visible = false;
                this.lblSeparateConfig.Visible = false;
                this.chkVerifyIntegrity.Visible = false;
                this.lblVerifyIntegrity.Visible = false;

                //Server Name Controls
                this.lblServerName.Visible = false;
                this.lblServerNameDetails.Visible = false;
                this.txtServerGivenName.Visible = false;

                //Deployment Button
                this.btnDeployGameserver.Enabled = false;
            }
        }

        private async Task<IList<GameserverType>> RefreshDataAsync()
        {
            //Populate gameserver list by querying the available configurations from the server.
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    var json = await webClient.DownloadStringTaskAsync("http://phantom-net.duckdns.org:1337/index").ConfigureAwait(false);

                    return JsonConvert.DeserializeObject<IDictionary<string, string>>(json)
                        .Select(kv => new GameserverType(kv.Key, kv.Value))
                        .ToList();
                }

            }
            catch (Exception ex)
            {
                Log.Error(ex, "Could not load the gameserver list");
                throw;
            }
        }

        private class GameserverType
        {
            public string Id { get; }
            public string Name { get; }

            public GameserverType(string id, string name)
            {
                this.Id = id;
                this.Name = name;
            }

            public override string ToString() => this.Name;
        }

        //===================================================================================//
        // STARTUP:                                                                          //
        //===================================================================================//
        private async void ServerDeployment_LoadAsync(object sender, EventArgs e)
        {
            try
            {
                IList<GameserverType> gameserverTypes = await this.RefreshDataAsync();

                foreach (GameserverType serverName in gameserverTypes)
                {
                    this.dropdownServerSelection.Items.Add(serverName);
                }

                this.dropdownServerSelection.PromptText = "< Select a gameserver to deploy >";
            }
            catch (Exception)
            {
                MetroMessageBox.Show(ActiveForm,
                    "Cannot connect to http://phantom-net.duckdns.org:1337 \nThis means that deployment at this time is impossible.",
                    "Server Unreachable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameServer_Management.server_collection != null)
            {
                foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
                {
                    this.dropdownExistingServer.Items.Add(gameserver.SERVER_name_friendly);
                }
            }
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

        private void deployServerToMemory()
        {
            //Create the GameServer_Object
            GameServer_Object DeployConfiguredServer = new GameServer_Object();

            //Assign Data to the GameServer_Object
            //Server-based Properties
            DeployConfiguredServer.SERVER_name_friendly = this.txtServerGivenName.Text;
            DeployConfiguredServer.SERVER_type = this._currentDeploymentValues.SERVER_type;
            DeployConfiguredServer.SERVER_launch_arguments = this._currentDeploymentValues.SERVER_launch_arguments;

            //Directory-based Properties
            DeployConfiguredServer.DIR_install_location = this._currentDeploymentValues.DIR_install_location;
            DeployConfiguredServer.DIR_executable = this._currentDeploymentValues.DIR_executable;
            DeployConfiguredServer.DIR_config = this._currentDeploymentValues.DIR_config;
            DeployConfiguredServer.DIR_config_file = this._currentDeploymentValues.DIR_config_file;

            //Steam-based Properties
            DeployConfiguredServer.STEAM_authrequired = this._currentDeploymentValues.STEAM_authrequired;
            DeployConfiguredServer.STEAM_steamcmd_required = this._currentDeploymentValues.STEAM_steamcmd_required;
            DeployConfiguredServer.STEAM_workshop_enabled = this._currentDeploymentValues.STEAM_workshop_enabled;

            //Miscellanious Properties
            DeployConfiguredServer.ENGINE_type = this._currentDeploymentValues.ENGINE_type;
            DeployConfiguredServer.bsm_integration = this._currentDeploymentValues.bsm_integration;

            //Store that newly assigned and JSON-filled server into the GameServer_Object Collection
            GameServer_Management.server_collection.Add(DeployConfiguredServer);

            //Redundantly write the data to disk in the event of a crash.
            DeployConfiguredServer.ExportJSON(true);

            this.btnCancelDeployGameserver.Visible = false;
            this.btnDeployGameserver.Enabled = true;
            this._currentDeploymentValues = null;
        }

        private void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.Invoke(new Action(() =>
                {
                    this.lblDownloadProgressDetails.Text = e.Data;

                    // I'm a bit uneasy with directly calling .Groups, what happens when there isn't a match?
                    string progressMatch = Regex.Match(e.Data, @"\:([^)]*)\(").Groups[1].Value;
                    if (double.TryParse(progressMatch, out double result))
                    {
                        this.progressbarDownloadProgressOverall.Value = Convert.ToInt32(result);
                    }

                    if (this._currentDeploymentValues.STEAM_steamcmd_required)
                    {
                        if (e.Data == "Success! App '" + ServerAPI.QUERY_STEAM_APPID(this.dropdownServerSelection.Text) + "' already up to date." || e.Data == "Success! App '" + ServerAPI.QUERY_STEAM_APPID(this.dropdownServerSelection.Text) + "' fully installed." || e.Data == "[----] Update complete, launching..." || e.Data == "[---] Update complete, launching...")
                        {
                            this.progressbarDownloadProgressOverall.Value = 100;
                            this.deployServerToMemory();
                            //MetroMessageBox.Show(BorealisServerManager.ActiveForm, txtServerGivenName.Text + "\n" + "Deployed to: [" + DeploymentValues.DIR_install_location + "]", "Gameserver Successfully Deployed!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            //panelProgress.Visible = false;
                        }
                        else if (e.Data == "Error! App '" + ServerAPI.QUERY_STEAM_APPID(this.dropdownServerSelection.Text) + "' state is 0x202 after update job." || e.Data == "Error! App '" + ServerAPI.QUERY_STEAM_APPID(this.dropdownServerSelection.Text) + "' state is 0x602 after update job.")
                        {
                            this.btnDeployGameserver.Enabled = false;
                            this.btnCancelDeployGameserver.Visible = true;
                            this.DeployGameServer(this._currentDeploymentValues);
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
            this.UIControlsHider(true); //Show UI elements to end-user

            if (this.chkSeparateConfig.Checked)
            {
                this.lblDestination.Text = "Step 2: Choose existing " + this.dropdownServerSelection.Text + " server";
            }

            if (this.chkSeparateConfig.Checked)
            {
                this.txtServerGivenName.Text = this.dropdownExistingServer.Text + " Instance01";
            }
            else
            {
                this.txtServerGivenName.Text = this.dropdownServerSelection.Text;
            }
        }

        private void dropdownExistingServer_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.chkSeparateConfig.Checked)
            {
                this.txtServerGivenName.Text = this.dropdownExistingServer.Text + " Instance";
            }
            else
            {
                this.txtServerGivenName.Text = this.dropdownServerSelection.Text;
            }
        }

        private void chkSeparateConfig_OnChange_1(object sender, EventArgs e)
        {
            if (this.chkSeparateConfig.Checked)
            {
                this.lblDestination.Text = "Step 2: Choose existing " + this.dropdownServerSelection.Text + " server";
                this.lblDestinationDetails.Text = "This will add a new configuration to an existing server to run a new instance of the server";
                this.txtboxDestinationFolder.Text = "N/A";
                this.txtboxDestinationFolder.Visible = false;
                this.dropdownExistingServer.Visible = true;
                this.txtServerGivenName.Text = "";
                this.lblDestinationDetailsSubtext.Visible = false;
            }
            else
            {
                this.lblDestination.Text = "Step 2: Destination";
                this.lblDestinationDetails.Text = "Choose where you want to install the server";
                this.txtboxDestinationFolder.Text = @"C:\BSM\";
                this.txtboxDestinationFolder.Visible = true;
                this.dropdownExistingServer.Visible = false;
                this.lblDestinationDetailsSubtext.Visible = true;
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
            proc.ErrorDataReceived += this.proc_DataReceived;
            proc.OutputDataReceived += this.proc_DataReceived;

            proc.Start();

            proc.BeginErrorReadLine();
            proc.BeginOutputReadLine();
        }

        private void DeployGameServer(DeploymentValues deploymentValues)
        {
            this._currentDeploymentValues = deploymentValues;

            //Enable cancel button to terminate deployment process if needed.
            this.lblDownloadProgressDetails.Text = "Status: Downloading " + this.dropdownServerSelection.Text + "...";

            switch (deploymentValues.STEAM_steamcmd_required)
            {
                case true:
                    {
                        this.lblDownloadProgressDetails.Text = "Status: Downloading / Initializing SteamCMD...";
                        SteamCMD.DownloadSteamCMD();
                        switch (deploymentValues.STEAM_authrequired)
                        {
                            case true:
                                MetroMessageBox.Show(ActiveForm, "Due to the fact that we do not have an authentication system in place for Steam, you cannot download non-anonymous SteamCMD dedicated servers at this time.  We apologize, and hope to get this incorporated soon!", "Steam Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.btnDeployGameserver.Enabled = true;
                                this.btnCancelDeployGameserver.Visible = false;
                                break;

                            case false:
                                try
                                {
                                    this.ExecuteWithRedirect(Environment.CurrentDirectory + @"\steamcmd.exe", string.Concat("+login anonymous +force_install_dir ", "\"", deploymentValues.DIR_install_location, "\"", " +app_update ", ServerAPI.QUERY_STEAM_APPID(this.dropdownServerSelection.Text), deploymentValues.verify_integrity, " +quit"));
                                }
                                catch (Exception)
                                {
                                    MetroMessageBox.Show(ActiveForm, "We cannot find the required executable to deploy the server!  Either it is missing, or the server configuration for this gameserver is corrupted.", "Error Deploying GameServer", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.browseDestinationFolder.ShowDialog();
            this.txtboxDestinationFolder.Text = this.browseDestinationFolder.SelectedPath;
        }

        private void btnDeployGameserver_Click(object sender, EventArgs e)
        {
            //Pull all gameserver data from gameservers.json, split all json strings into a list, iterate through that list for specific data.
            if (GameServer_Management.server_collection != null)
            {
                foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
                {
                    if (this.txtServerGivenName.Text == gameserver.SERVER_name_friendly)
                    {
                        MetroMessageBox.Show(ActiveForm, "Unfortunately, you must give unique names to every server you deploy, using the exact same name would cause several issues.", "Identical gameserver name already exists.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; //Break gracefully out of the entire void function.
                    }
                }
            }

            if (this.chkSeparateConfig.Checked)
            {
                MetroMessageBox.Show(ActiveForm, "Unfortunately at this time, deploying instances of gameservers is not supported.", "Deploy New GameServer Instance?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Query specific appID for all required data.
            var gameserverType = (GameserverType) this.dropdownServerSelection.SelectedItem;
            GameServer_Object gameServer = ServerAPI.QUERY_DATA(gameserverType.Id);

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
            if (this.txtboxDestinationFolder.Text == "")
            {
                deploymentValues.DIR_install_location = Environment.CurrentDirectory;
            }
            else
            {
                deploymentValues.DIR_install_location = this.txtboxDestinationFolder.Text;
            }

            //Determine whether or not to verify integrity of the installation.
            if (this.chkVerifyIntegrity.Value)
            {
                deploymentValues.verify_integrity = " +validate";
            }
            else
            {
                deploymentValues.verify_integrity = "";
            }

            DialogResult result;
            switch (deploymentValues.bsm_integration)
            {
                case "none":
                    result = MetroMessageBox.Show(ActiveForm,
                        "Type of GameServer: [" + this.dropdownServerSelection.Text + "]\n" + "Deploy to: [" +
                        deploymentValues.DIR_install_location + "]" +
                        "\n\nWARNING: This gameserver currently has NO BSM support.\nYou can deploy it, but BSM cannot configure or control it at this time.",
                        "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    break;
                case "partial":
                    result = MetroMessageBox.Show(ActiveForm,
                        "Type of GameServer: [" + this.dropdownServerSelection.Text + "]\n" + "Deploy to: [" +
                        deploymentValues.DIR_install_location + "]" +
                        "\n\nWARNING: This gameserver currently has PARTIAL BSM support.\nYou can deploy it, but BSM can only configure it at this time, you have no ability to control it directly through BSM.",
                        "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    break;
                case "full":
                    result = MetroMessageBox.Show(ActiveForm,
                        "Type of GameServer: [" + this.dropdownServerSelection.Text + "]\n" + "Deploy to: [" +
                        deploymentValues.DIR_install_location + "]", "Deploy GameServer?", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    break;
                default:
                    result = DialogResult.Yes;
                    break;
            }

            if (result == DialogResult.Yes)
            {
                this.panelProgress.Visible = true;
                this.btnCancelDeployGameserver.Visible = true;
                this.btnDeployGameserver.Enabled = false;
                this.DeployGameServer(deploymentValues);
            }
        }
        private void btnCancelDeployGameserver_Click(object sender, EventArgs e)
        {
            if (this._currentDeploymentValues.STEAM_steamcmd_required)
            {
                this.ExecuteWithRedirect(@"C:\Windows\System32\taskkill", "/F /IM steamcmd.exe");
                this.btnCancelDeployGameserver.Visible = false;
            }
            else
            {
                //Kill program being used to deploy a server.
            }
            this.btnDeployGameserver.Enabled = true;
            this.progressbarDownloadProgressOverall.Value = 0;
            this._currentDeploymentValues = null;
        }
    }
 }
