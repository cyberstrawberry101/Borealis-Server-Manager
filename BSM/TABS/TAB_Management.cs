using System;
using System.Windows.Forms;
using MetroFramework;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Borealis
{
    public partial class ServerManagement : Form
    {
        public ServerManagement()
        {
            InitializeComponent();
        }

        //===================================================================================//
        // STARTUP:                                                                          //
        //===================================================================================//
        private void GSM_Management_Load(object sender, EventArgs e)
        {
            serverPropertiesTable.BorderStyle = BorderStyle.FixedSingle; //Override painting method.


            if (GameServer_Management.server_collection != null)
            {
                foreach (JObject gameserver in GameServer_Management.server_collection)
                {
                    comboboxGameserverList.Items.Add((string)gameserver["SERVER_name_friendly"]);
                }
            }
        }

        //===================================================================================//
        // MANAGEMENT:                                                                       //
        //===================================================================================//
        //Methods that handle management itself.
        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            foreach (JObject gameserver in GameServer_Management.server_collection)
            {
                if ((string)gameserver["SERVER_name"] == comboboxGameserverList.Text)
                {
                    GameServer_Management.GameServer Management_Instance = new GameServer_Management.GameServer();
                    openFileDialog1.InitialDirectory = (string)gameserver["DIR_install_location"];
                }
            }

            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                int counter = 0;
                string line;
                serverPropertiesTable.Rows.Clear();

                try
                {
                    // Read the file and display it line by line.
                    System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
                    while ((line = file.ReadLine()) != null)
                    {
                        serverPropertiesTable.Rows.Add(line);
                        counter++;
                    }

                    file.Close();
                }
                catch (IOException)
                {
                }
            }
        }
        private void btnUpdateServerConfig_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Unfortunately this feature has not been implemented yet.  Please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        //Methods that handle reporting progress back to the UI
        private void comboboxGameserverList_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (JObject gameserver in GameServer_Management.server_collection)
            {
                if ((string)gameserver["SERVER_name_friendly"] == comboboxGameserverList.Text)
                {
                    GameServer_Management.GameServer Management_Instance = new GameServer_Management.GameServer();
                    Management_Instance.SERVER_name = (string)gameserver["SERVER_name"];
                    Management_Instance.SERVER_name_friendly = (string)gameserver["SERVER_name_friendly"];
                    Management_Instance.SERVER_type = (string)gameserver["SERVER_type"];
                    Management_Instance.SERVER_launch_arguments = (string)gameserver["SERVER_launch_arguments"];
                    Management_Instance.SERVER_running_status = (bool)gameserver["SERVER_running_status"];
                    Management_Instance.DIR_install_location = (string)gameserver["DIR_install_location"];
                    Management_Instance.DIR_executable = (string)gameserver["DIR_executable"];
                    Management_Instance.DIR_config = (string)gameserver["DIR_config"];
                    Management_Instance.DIR_config_file = (string)gameserver["DIR_config_file"];
                    Management_Instance.STEAM_authrequired = (bool)gameserver["STEAM_authrequired"];
                    Management_Instance.STEAM_steamcmd_required = (bool)gameserver["STEAM_steamcmd_required"];
                    Management_Instance.STEAM_workshop_enabled = (bool)gameserver["STEAM_workshop_enabled"];
                    Management_Instance.srcds_server = (bool)gameserver["srcds_server"];
                    Management_Instance.bsm_integration = (string)gameserver["bsm_integration"];

                    serverPropertiesTable.Rows.Clear();
                    serverPropertiesTable.Rows.Add("SERVER_name", Management_Instance.SERVER_name);
                    serverPropertiesTable.Rows.Add("SERVER_name_friendly", Management_Instance.SERVER_name_friendly);
                    serverPropertiesTable.Rows.Add("SERVER_type", Management_Instance.SERVER_type);
                    serverPropertiesTable.Rows.Add("SERVER_launch_arguments", Management_Instance.SERVER_launch_arguments);
                    serverPropertiesTable.Rows.Add("SERVER_running_status", Management_Instance.SERVER_running_status);
                    serverPropertiesTable.Rows.Add("DIR_install_location", Management_Instance.DIR_install_location);
                    serverPropertiesTable.Rows.Add("DIR_executable", Management_Instance.DIR_executable);
                    serverPropertiesTable.Rows.Add("DIR_config", Management_Instance.DIR_config);
                    serverPropertiesTable.Rows.Add("DIR_config_file", Management_Instance.DIR_config_file);
                    serverPropertiesTable.Rows.Add("STEAM_authrequired", Management_Instance.STEAM_authrequired);
                    serverPropertiesTable.Rows.Add("STEAM_steamcmd_required", Management_Instance.STEAM_steamcmd_required);
                    serverPropertiesTable.Rows.Add("STEAM_workshop_enabled", Management_Instance.STEAM_workshop_enabled);
                    serverPropertiesTable.Rows.Add("srcds_server", Management_Instance.srcds_server);
                    serverPropertiesTable.Rows.Add("bsm_integration", Management_Instance.bsm_integration);
                }
            }

            btnLoadConfig.Enabled = true;
        }
    }
}
