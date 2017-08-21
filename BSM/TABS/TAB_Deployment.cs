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
            InitializeComponent();
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
            private string Name { get; }

            public GameserverType(string id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString() => Name;
        }

        //===================================================================================//
        // UI HANDLING CODE                                                                  //
        //===================================================================================//
        private async void ServerDeployment_LoadAsync(object sender, EventArgs e)
        {
            try
            {
                IList<GameserverType> gameserverTypes = await RefreshDataAsync();

                foreach (GameserverType serverName in gameserverTypes)
                {
                    dropdownServerSelection.Items.Add(serverName);
                }

                dropdownServerSelection.PromptText = "< Select a gameserver to deploy >";
            }
            catch (Exception)
            {
                MetroMessageBox.Show(ActiveForm,
                    "Borealis cannot establish a connection to API server.\nGameserver deployment at this time is unavailable.\nPlease reach out to Nicole @ cyberstrawberry101@gmail.com to resolve this issue.",
                    "Cannot Establish Connection to API Server", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                Invoke(new Action(() =>
                {
                    if (_currentDeploymentValues == null)
                        return;

                    lblDownloadProgressDetails.Text = e.Data;

                    // I'm a bit uneasy with directly calling .Groups, what happens when there isn't a match?
                    string progressMatch = Regex.Match(e.Data, @"\:([^)]*)\(").Groups[1].Value;
                    if (double.TryParse(progressMatch, out double result))
                    {
                        progressbarDownloadProgressOverall.Value = Convert.ToInt32(result);
                    }

                    if (_currentDeploymentValues.STEAM_steamcmd_required)
                    {
                        string steamAppId = ((GameserverType)dropdownServerSelection.SelectedItem).Id;

                        if (e.Data == "Success! App '" + steamAppId + "' already up to date." || e.Data == "Success! App '" + steamAppId + "' fully installed." || e.Data == "[----] Update complete, launching..." || e.Data == "[---] Update complete, launching...")
                        {
                            progressbarDownloadProgressOverall.Value = 100;
                            serverStoreInMemory();
                            lblDownloadProgress.Text = "GameServer Deployed / Updated Successfully!";
                            lblVerifyIntegrity.Visible = true;
                            chkVerifyIntegrity.Visible = true;
                            lblSteamToken.Enabled = false;
                            txtSteamToken.Enabled = false;
                            btnSteamToken.Enabled = false;
                            //MetroMessageBox.Show(BorealisServerManager.ActiveForm, txtServerGivenName.Text + "\n" + "Deployed to: [" + DeploymentValues.DIR_install_location + "]", "Gameserver Successfully Deployed!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            //panelProgress.Visible = false;
                        }
                        else if (e.Data == "Error! App '" + steamAppId + "' state is 0x202 after update job." || e.Data == "Error! App '" + steamAppId + "' state is 0x602 after update job.")
                        {
                            btnDeployGameserver.Enabled = false;
                            btnCancelDeployGameserver.Visible = true;
                            serverDeploy(_currentDeploymentValues);
                        }
                        else if (e.Data == "Enter the current code from your Steam Guard Mobile Authenticator app" || e.Data == "Two-factor code:" || e.Data == "Please check your email for the message from Steam, and enter the Steam Guard" || e.Data == "code from that message." || e.Data == "Please check your email for the message from Steam, and enter the Steam Guard code from that message.")
                        {
                            lblSteamToken.Enabled = true;
                            txtSteamUsername.Text = "";
                            txtSteamPassword.Text = "";
                            txtSteamToken.Text = "INPUT CODE";
                            txtSteamToken.Enabled = true;
                            btnSteamToken.Enabled = true;
                        }
                        else if (e.Data == "Logged in OK" || e.Data == "Waiting for License info...OK")
                        {

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

        //===================================================================================//
        // DEPLOYMENT CODE                                                                   //
        //===================================================================================//
        
        //Class to store relevant deployment values during deployment
        private class DeploymentValues
        {
            public string SERVER_type { get; set; }
            public string verify_integrity { get; set; }
            public string SERVER_launch_arguments { get; set; }
            public string SERVER_executable { get; set; }
            public string DIR_install_location { get; set; }
            public string DIR_root { get; set; }
            public string DIR_maps { get; set; }
            public string DIR_maps_file_extension { get; set; }
            public string DIR_mods { get; set; }
            public string DIR_config { get; set; }
            public bool STEAM_authrequired { get; set; }
            public bool STEAM_steamcmd_required { get; set; }
            public bool STEAM_workshop_enabled { get; set; }
            public string ENGINE_type { get; set; }
            public string bsm_integration { get; set; }
            public bool bsm_custominstallfolder { get; set; }
        }

        //Method to deploy gameservers given values from the DeploymentValues class
        private void serverDeploy(DeploymentValues deploymentValues)
        {
            _currentDeploymentValues = deploymentValues;

            //Enable cancel button to terminate deployment process if needed.
            lblDownloadProgressDetails.Text = "Status: Downloading " + dropdownServerSelection.Text + "...";

            switch (deploymentValues.STEAM_steamcmd_required)
            {
                case true:
                    {
                        lblDownloadProgressDetails.Text = "Status: Downloading / Initializing SteamCMD...";
                        SteamCMD.DownloadSteamCMD();
                        switch (deploymentValues.STEAM_authrequired)
                        {
                            case true:
                                if (txtSteamUsername.Text == "" || txtSteamPassword.Text == "")
                                {
                                    MetroMessageBox.Show(ActiveForm, "Please fill out your Steam username and password.", "Steam Credentials Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                SteamGuardProcess.StartInfo.Arguments = string.Format(@"+login {0} {1} +force_install_dir {2} +app_update {3} {4} +quit",
                                        txtSteamUsername.Text,
                                        txtSteamPassword.Text,
                                        deploymentValues.DIR_install_location,
                                        ServerAPI.QUERY_STEAM_APPID(dropdownServerSelection.Text),
                                        deploymentValues.verify_integrity);

                                SteamGuardProcess.StartInfo.FileName = Environment.CurrentDirectory + @"\steamcmd.exe";
                                SteamGuardProcess.StartInfo.UseShellExecute = false;
                                SteamGuardProcess.StartInfo.RedirectStandardOutput = true;
                                SteamGuardProcess.StartInfo.RedirectStandardInput = true;
                                SteamGuardProcess.StartInfo.RedirectStandardError = true;
                                SteamGuardProcess.EnableRaisingEvents = true;
                                SteamGuardProcess.StartInfo.CreateNoWindow = true;
                                SteamGuardProcess.ErrorDataReceived += proc_DataReceived;
                                SteamGuardProcess.OutputDataReceived += proc_DataReceived;
                                SteamGuardProcess.Start();
                                SteamGuardProcess.BeginErrorReadLine();
                                SteamGuardProcess.BeginOutputReadLine();
                                break;

                            case false:
                                try
                                {
                                    Execute(Environment.CurrentDirectory + @"\steamcmd.exe",
                                        string.Format(@"+login anonymous +force_install_dir {0} +app_update {1} {2} +quit",
                                        deploymentValues.DIR_install_location,
                                        ServerAPI.QUERY_STEAM_APPID(dropdownServerSelection.Text),
                                        deploymentValues.verify_integrity), true);

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
        private void serverStoreInMemory()
        {
            //Create the GameServerObject
            GameServerObject deployConfiguredServer = new GameServerObject();

            //Assign Data to the GameServerObject
            //Server-based Properties
            deployConfiguredServer.SERVER_name_friendly = txtServerGivenName.Text;
            deployConfiguredServer.SERVER_type = _currentDeploymentValues.SERVER_type;
            deployConfiguredServer.SERVER_launch_arguments = _currentDeploymentValues.SERVER_launch_arguments;
            deployConfiguredServer.SERVER_executable = _currentDeploymentValues.SERVER_executable;
            deployConfiguredServer.SERVER_port = "";

            //Game-based properties
            deployConfiguredServer.GAME_maxplayers = 6; //Defalt middle value
            deployConfiguredServer.GAME_map = "NONE";

            //Directory-based Properties
            deployConfiguredServer.DIR_install_location = _currentDeploymentValues.DIR_install_location;
            deployConfiguredServer.DIR_root = _currentDeploymentValues.DIR_root;
            deployConfiguredServer.DIR_maps = _currentDeploymentValues.DIR_maps;
            deployConfiguredServer.DIR_maps_file_extension = _currentDeploymentValues.DIR_maps_file_extension;
            deployConfiguredServer.DIR_mods = _currentDeploymentValues.DIR_mods;
            deployConfiguredServer.DIR_config = _currentDeploymentValues.DIR_config;

            //Steam-based Properties
            deployConfiguredServer.STEAM_authrequired = _currentDeploymentValues.STEAM_authrequired;
            deployConfiguredServer.STEAM_steamcmd_required = _currentDeploymentValues.STEAM_steamcmd_required;
            deployConfiguredServer.STEAM_workshop_enabled = _currentDeploymentValues.STEAM_workshop_enabled;

            //Miscellanious Properties
            deployConfiguredServer.ENGINE_type = _currentDeploymentValues.ENGINE_type;
            deployConfiguredServer.bsm_integration = _currentDeploymentValues.bsm_integration;
            deployConfiguredServer.bsm_custominstallfolder = _currentDeploymentValues.bsm_custominstallfolder;

            //Store that newly assigned and JSON-filled server into the GameServerObject Collection
            GameServerManagement.ServerCollection.Add(deployConfiguredServer);

            //Redundantly write the data to disk in the event of a crash.
            GameServerManagement.ConfigWrite();

            btnCancelDeployGameserver.Visible = false;
            btnDeployGameserver.Enabled = true;
            _currentDeploymentValues = null;
        }
        private void Execute(string argProgramName, string argParameters, bool Redirect)
        {
            try
            {
                var proc = new Process();
                proc.StartInfo.Arguments = argParameters;
                proc.StartInfo.FileName = argProgramName;

                if (Redirect)
                {
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.RedirectStandardInput = true;
                    proc.StartInfo.RedirectStandardError = true;
                    proc.EnableRaisingEvents = true;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.ErrorDataReceived += proc_DataReceived;
                    proc.OutputDataReceived += proc_DataReceived;
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
                MetroMessageBox.Show(ActiveForm, "Borealis cannot find the required executable to launch!  Either it is missing, or your configuration for Borealis is corrupted.", "Error Launching Executable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void dropdownServerSelection_SelectedValueChanged(object sender, EventArgs e)
        {
            txtServerGivenName.Text = dropdownServerSelection.Text;

            //Query specific appID for Steam Guard requirement check
            var dataChecker = (GameserverType)dropdownServerSelection.SelectedItem;
            GameServerObject gameServer = ServerAPI.QUERY_DATA(dataChecker.Id);

            if (gameServer.STEAM_authrequired)
            {
                panelSteamGuard.Visible = true;
            }
            else
            {
                panelSteamGuard.Visible = false;
            }

            //Check if existing server was already deployed with the given type, and allow the user to update it instead.
            foreach (GameServerObject gameserver in GameServerManagement.ServerCollection)
            {
                if (gameserver.SERVER_type == dropdownServerSelection.Text)
                {
                    deploymentAnimator.ShowSync(btnUpdateServer);
                }
                else
                {
                    deploymentAnimator.HideSync(btnUpdateServer);
                }
            }

            btnDeployGameserver.Enabled = true;
            panelStep2.Visible = true;
            panelStep3.Visible = true;
            panelProgress.Visible = true;
        }
        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            browseDestinationFolder.ShowDialog();
            txtboxDestinationFolder.Text = browseDestinationFolder.SelectedPath;
        }
        private void btnDeployGameserver_Click(object sender, EventArgs e)
        {
            //Pull all gameserver data from gameservers.json, split all json strings into a list, iterate through that list for specific data.
            if (GameServerManagement.ServerCollection != null)
            {
                foreach (GameServerObject gameserver in GameServerManagement.ServerCollection)
                {
                    if (txtServerGivenName.Text == gameserver.SERVER_name_friendly)
                    {
                        MetroMessageBox.Show(ActiveForm, "Unfortunately, you must give unique names to every server you deploy, using the exact same name would cause several issues.", "Identical gameserver name already exists.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; //Break gracefully out of the entire void function.
                    }
                }
            }

            //Query specific appID for all required data.
            var gameserverType = (GameserverType) dropdownServerSelection.SelectedItem;
            GameServerObject gameServer = ServerAPI.QUERY_DATA(gameserverType.Id);

            //Retrieve the data that was just stored into the deployment server list.
            var deploymentValues = new DeploymentValues
            {
                SERVER_type = gameServer.SERVER_type,
                SERVER_launch_arguments = gameServer.SERVER_launch_arguments,
                SERVER_executable = gameServer.SERVER_executable,
                DIR_root = gameServer.DIR_root,
                DIR_maps = gameServer.DIR_maps,
                DIR_maps_file_extension = gameServer.DIR_maps_file_extension,
                DIR_mods = gameServer.DIR_mods,
                DIR_config = gameServer.DIR_config,
                STEAM_authrequired = gameServer.STEAM_authrequired,
                STEAM_steamcmd_required = gameServer.STEAM_steamcmd_required,
                STEAM_workshop_enabled = gameServer.STEAM_workshop_enabled,
                ENGINE_type = gameServer.ENGINE_type,
                bsm_integration = gameServer.bsm_integration,
                bsm_custominstallfolder = gameServer.bsm_custominstallfolder
            };

            //Determine where to deploy the server based on user input.
            if (txtboxDestinationFolder.Text == "")
            {
                deploymentValues.DIR_install_location = Environment.CurrentDirectory;
                deploymentValues.bsm_custominstallfolder = false;
            }
            else
            {
                deploymentValues.DIR_install_location = txtboxDestinationFolder.Text;
                deploymentValues.bsm_custominstallfolder = true;
            }

            //Determine whether or not to verify integrity of the installation.
            if (chkVerifyIntegrity.Value)
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
                        "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" +
                        deploymentValues.DIR_install_location + "]" +
                        "\n\nWARNING: This gameserver currently has NO BSM support.\nYou can deploy it, and launch it, but BSM cannot configure it at this time.",
                        "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    break;
                case "partial":
                    result = MetroMessageBox.Show(ActiveForm,
                        "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" +
                        deploymentValues.DIR_install_location + "]" +
                        "\n\nWARNING: This gameserver currently has PARTIAL BSM support.\nYou can deploy it, and launch it, and have experimental control over it directly through BSM.",
                        "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    break;
                case "full":
                    result = MetroMessageBox.Show(ActiveForm,
                        "Type of GameServer: [" + dropdownServerSelection.Text + "]\n" + "Deploy to: [" +
                        deploymentValues.DIR_install_location + "]", "Deploy GameServer?", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    break;
                default:
                    result = DialogResult.Yes;
                    break;
            }

            if (result == DialogResult.Yes)
            {
                btnCancelDeployGameserver.Visible = true;
                btnDeployGameserver.Enabled = false;
                serverDeploy(deploymentValues);
                lblDownloadProgress.Text = "Download / Installation Progress:";
                lblVerifyIntegrity.Visible = false;
                chkVerifyIntegrity.Visible = false;
            }
        }
        private void btnCancelDeployGameserver_Click(object sender, EventArgs e)
        {
            if (_currentDeploymentValues.STEAM_steamcmd_required)
            {
                Execute(@"C:\Windows\System32\taskkill", "/F /IM steamcmd.exe", true);
                btnCancelDeployGameserver.Visible = false;
            }
            else
            {
                //Kill program being used to deploy a server.
            }
            btnDeployGameserver.Enabled = true;
            progressbarDownloadProgressOverall.Value = 0;
            _currentDeploymentValues = null;
            lblDownloadProgress.Text = "Download / Installation Progress:";
            lblDownloadProgressDetails.Text = "Status: Deployment Cancelled";
            lblVerifyIntegrity.Visible = true;
            chkVerifyIntegrity.Visible = true;
        }

        private void btnSteamToken_Click(object sender, EventArgs e)
        {
            SteamGuardProcess.StandardInput.WriteLine(txtSteamToken.Text);
            panelSteamGuard.Visible = false;
        }
        private void txtSteamToken_Click(object sender, EventArgs e)
        {
            txtSteamToken.Text = "";
        }
        private void btnUpdateServer_Click(object sender, EventArgs e)
        {
            lblDownloadProgress.Text = string.Format("Updating existing {0} gameservers:", dropdownServerSelection.Text);
            MetroMessageBox.Show(ActiveForm, "The ability to update an existing deployed gameserver is coming soon.", "Updating Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            lblDownloadProgress.Text = "Download / Installation Progress:";
        }
    }
 }
