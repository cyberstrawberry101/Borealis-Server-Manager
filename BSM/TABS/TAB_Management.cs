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
                    openFileDialog1.InitialDirectory = (string)gameserver["DIR_install_location"] + (string)gameserver["DIR_config"];
                }
            }

            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                int counter = 0;
                string line;
                txtboxConfigOutput.Text = ""; //Clear the table

                try
                {
                    // Read the file and display it line by line.
                    System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
                    while ((line = file.ReadLine()) != null)
                    {
                        txtboxConfigOutput.AppendText(line);
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
                    txtboxFriendlyName.Text = (string)gameserver["SERVER_name_friendly"];
                    txtboxArguments.Text = (string)gameserver["SERVER_launch_arguments"];

                    if ((string)gameserver["DIR_config_file"] != null)
                    {
                        int counter = 0;
                        string line;

                        System.IO.StreamReader file = new System.IO.StreamReader((string)gameserver["DIR_install_location"] + (string)gameserver["DIR_config"] + (string)gameserver["DIR_config_file"]);
                        while ((line = file.ReadLine()) != null)
                        {
                            txtboxConfigOutput.AppendText(line);
                            counter++;
                        }

                        file.Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Borealis does not have a default config file associated with this server, please load one manually.", "Config File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
