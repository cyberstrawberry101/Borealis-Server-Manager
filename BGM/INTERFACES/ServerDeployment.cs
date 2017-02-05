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

namespace GameServer_Manager

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
            //Query the gameserver_data.xml to list all servers in dropdown menu.
            if (File.Exists(Environment.CurrentDirectory + @"\gameservers_data.xml"))
            {
                var xdoc = XDocument.Load(Environment.CurrentDirectory + @"\gameservers_data.xml");
                foreach (var child in xdoc.Elements("gameserver_listing").Elements("server").Elements("server_name"))
                {
                    dropdownServerSelection.Items.Add(child.Value);
                }
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
        private void btnDeployGameserver_Click(object sender, EventArgs e)
        {
            btnCancelDeployGameserver.Visible = true;

            //Download and prepare SteamCMD
            lblDownloadProgressDetails.Text = "Status: Downloading / Installing SteamCMD...";
            SteamCMD_Classes.DownloadSteamCMD(txtboxDestinationFolder.Text);

            //Inform the user what level of support BGM provides for the gameserver they are about to deploy.

            //NO CURRENT SUPPORT IMPLEMENTED
            if (SettingsManagement_Classes.GameServerXMLData(dropdownServerSelection.Text, "bgm_integration") == "none")
            {
                if (MetroMessageBox.Show(BorealisGameManager.ActiveForm, dropdownServerSelection.Text + "\n\nWARNING: This gameserver currently has NO BGM support.\nYou can deploy it, but BGM cannot configure it at this time.", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    //Indicate what gameserver is currently being downloaded.
                    lblDownloadProgressDetails.Text = "Status: Downloading " + dropdownServerSelection.Text + "...";
                    ExternalExecution_Classes.LaunchExternalProgram(txtboxDestinationFolder.Text + @"\steamcmd.exe", SettingsManagement_Classes.GameServerXMLData(dropdownServerSelection.Text, "deployment_parameters"), false);
                    MetroMessageBox.Show(BorealisGameManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }

            //PARTIAL SUPPORT IMPLEMENTED
            if (SettingsManagement_Classes.GameServerXMLData(dropdownServerSelection.Text, "bgm_integration") == "partial")
            {
                if (MetroMessageBox.Show(BorealisGameManager.ActiveForm, dropdownServerSelection.Text + "\n\nWARNING: This gameserver currently has PARTIAL BGM support.\nYou can deploy it, but BGM can only minimally configure it at this time.", "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    //Indicate what gameserver is currently being downloaded.
                    lblDownloadProgressDetails.Text = "Status: Downloading " + dropdownServerSelection.Text + "...";
                    ExternalExecution_Classes.LaunchExternalProgram(txtboxDestinationFolder.Text + @"\steamcmd.exe", SettingsManagement_Classes.GameServerXMLData(dropdownServerSelection.Text, "deployment_parameters"), false);
                    MetroMessageBox.Show(BorealisGameManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }

            //FULL SUPPORT IMPLEMENTED
            if (SettingsManagement_Classes.GameServerXMLData(dropdownServerSelection.Text, "bgm_integration") == "full")
            {
                if (MetroMessageBox.Show(BorealisGameManager.ActiveForm, dropdownServerSelection.Text, "Deploy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Indicate what gameserver is currently being downloaded.
                    lblDownloadProgressDetails.Text = "Status: Downloading " + dropdownServerSelection.Text + "...";
                    ExternalExecution_Classes.LaunchExternalProgram(txtboxDestinationFolder.Text + @"\steamcmd.exe", SettingsManagement_Classes.GameServerXMLData(dropdownServerSelection.Text, "deployment_parameters"), false);
                    MetroMessageBox.Show(BorealisGameManager.ActiveForm, txtServerGivenName.Text + " [" + dropdownServerSelection.Text + "]" + " has been successfully deployed with default configurations!\nPlease goto the management tab to configure it.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }

            //Finish up the process!
            lblDownloadProgressDetails.Text = "Status: Idle";
            btnCancelDeployGameserver.Visible = false;
        }

        //===================================================================================//
        // UPDATE INTERFACE WHEN A GAMESERVER HAS BEEN CHOSEN FROM THE DROPDOWN LIST         //
        //===================================================================================//
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
