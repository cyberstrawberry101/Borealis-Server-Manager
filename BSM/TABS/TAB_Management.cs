using System;
using System.Windows.Forms;
using MetroFramework;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Borealis
{
    public partial class TAB_Management : Form
    {
        public TAB_Management()
        {
            InitializeComponent();
        }

        //===================================================================================//
        // STARTUP:                                                                          //
        //===================================================================================//
        private void GSM_Management_Load(object sender, EventArgs e)
        {
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
                if ((string)gameserver["SERVER_name_friendly"] == comboboxGameserverList.Text)
                {
                    GameServer_Management.GameServer Management_Instance = new GameServer_Management.GameServer();
                    openFileDialog1.InitialDirectory = (string)gameserver["DIR_install_location"] + (string)gameserver["DIR_config"];
                }
            }

            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                int counter = 0;
                string line;
                txtboxConfigOutput.Items.Clear(); //Clear the table

                try
                {
                    // Read the file and display it line by line.
                    System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
                    while ((line = file.ReadLine()) != null)
                    {
                        txtboxConfigOutput.Items.Add(line);
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
            MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Unfortunately this feature has not been implemented yet.  Please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        //Methods that handle reporting progress back to the UI
        private void comboboxGameserverList_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (JObject gameserver in GameServer_Management.server_collection)
            {
                if ((string)gameserver["SERVER_name_friendly"] == comboboxGameserverList.Text)
                {
                    txtboxFriendlyName.Text = (string)gameserver["SERVER_name_friendly"];
                    txtboxArguments.Text = (string)gameserver["SERVER_launch_arguments"];

                    if ((string)gameserver["DIR_config_file"] != null)
                    {
                        int counter = 0;
                        string line;
                        txtboxConfigOutput.Items.Clear(); //Clear the table

                        try
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader((string)gameserver["DIR_install_location"] + (string)gameserver["DIR_config"] + (string)gameserver["DIR_config_file"]);
                            while ((line = file.ReadLine()) != null)
                            {
                                txtboxConfigOutput.Items.Add(line);
                                counter++;
                            }

                            file.Close();
                        }
                        catch (Exception)
                        {
                            MetroMessageBox.Show(BorealisServerManager.ActiveForm, "[" + (string)gameserver["DIR_install_location"] + (string)gameserver["DIR_config"] + (string)gameserver["DIR_config_file"] + "]\nappears to be missing or was never created.  Please load a config file manually or fix this issue.", "Default Config File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    lblFriendlyName.Visible = true;
                    txtboxFriendlyName.Visible = true;
                    lblArguments.Visible = true;
                    txtboxArguments.Visible = true;
                    lblConfigOutput.Visible = true;
                    txtboxConfigOutput.Visible = true;
                }
            }

            btnLoadConfig.Enabled = true;  //Enable loading a config file manually


        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {

        }

        private void btnDestroyServer_Click(object sender, EventArgs e)
        {

        }

        public void RefreshData()
        {
            comboboxGameserverList.Items.Clear();
            if (GameServer_Management.server_collection != null)
            {
                foreach (JObject gameserver in GameServer_Management.server_collection)
                {
                    comboboxGameserverList.Items.Add((string)gameserver["SERVER_name_friendly"]);
                }
            }
        }

        private void ServerManagement_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnDestroyServer_Click_1(object sender, EventArgs e)
        {
            MetroMessageBox.Show(BorealisServerManager.ActiveForm, "Unfortunately this feature has not been implemented yet.  Please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
