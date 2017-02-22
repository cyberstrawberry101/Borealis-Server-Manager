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
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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
            if (GameServer_Management.server_collection != null)
            {
                foreach (Newtonsoft.Json.Linq.JObject gameserver in GameServer_Management.server_collection)
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
            foreach (Newtonsoft.Json.Linq.JObject gameserver in GameServer_Management.server_collection)
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
                    serverPropertiesTable.Rows.Add(Management_Instance.server_name);
                    serverPropertiesTable.Rows.Add(Management_Instance.server_type);
                    serverPropertiesTable.Rows.Add(Management_Instance.install_dir);
                    serverPropertiesTable.Rows.Add(Management_Instance.executable_dir);
                    serverPropertiesTable.Rows.Add(Management_Instance.launch_arguments);
                    serverPropertiesTable.Rows.Add(Management_Instance.server_config_file);
                    serverPropertiesTable.Rows.Add(Management_Instance.running_status);
                }
            }
        }
    }
}
