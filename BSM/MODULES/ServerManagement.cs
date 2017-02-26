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
        // STARTUP                                                                           //
        //===================================================================================//
        private void GSM_Management_Load(object sender, EventArgs e)
        {
            serverPropertiesTable.BorderStyle = BorderStyle.FixedSingle; //Override painting method.


            if (GameServer_Management.server_collection != null)
            {
                foreach (JObject gameserver in GameServer_Management.server_collection)
                {
                    comboboxGameserverList.Items.Add((string)gameserver["server_name"]);
                }
            }
        }

        //===================================================================================//
        // UPDATE SERVER CONFIGURATION                                                       //
        //===================================================================================//
        private void btnUpdateServerConfig_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Unfortunately this feature has not been implemented yet.  Please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboboxGameserverList_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (JObject gameserver in GameServer_Management.server_collection)
            {
                if ((string)gameserver["server_name"] == comboboxGameserverList.Text)
                {
                    GameServer_Management.GameServer Management_Instance = new GameServer_Management.GameServer();
                    Management_Instance.server_name = (string)gameserver["server_name"];
                    Management_Instance.server_type = (string)gameserver["server_type"];
                    Management_Instance.install_dir = (string)gameserver["install_dir"];
                    Management_Instance.executable_dir = (string)gameserver["executable_dir"];
                    Management_Instance.launch_arguments = (string)gameserver["launch_arguments"];
                    Management_Instance.server_config_file = (string)gameserver["server_config_file"];
                    Management_Instance.running_status = (bool)gameserver["running_status"];

                    serverPropertiesTable.Rows.Clear();
                    serverPropertiesTable.Rows.Add("server_name", Management_Instance.server_name);
                    serverPropertiesTable.Rows.Add("server_type", Management_Instance.server_type);
                    serverPropertiesTable.Rows.Add("install_dir", Management_Instance.install_dir);
                    serverPropertiesTable.Rows.Add("executable_dir", Management_Instance.executable_dir);
                    serverPropertiesTable.Rows.Add("launch_arguments", Management_Instance.launch_arguments);
                    serverPropertiesTable.Rows.Add("server_config_file", Management_Instance.server_config_file);
                    serverPropertiesTable.Rows.Add("running_status", Management_Instance.running_status);
                }
            }
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            foreach (JObject gameserver in GameServer_Management.server_collection)
            {
                if ((string)gameserver["server_name"] == comboboxGameserverList.Text)
                {
                    GameServer_Management.GameServer Management_Instance = new GameServer_Management.GameServer();
                    openFileDialog1.InitialDirectory = (string)gameserver["install_dir"];
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
    }
}
