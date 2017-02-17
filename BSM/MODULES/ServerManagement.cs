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
        // Class to store JSON data during management                                        //
        //===================================================================================//
        public static class MANAGED_OBJECT
        {
            //Variables to be used during deployment:
            public static string server_name { get; set; }
            public static string server_type { get; set; }
            public static string install_dir { get; set; }
            public static string executable_dir { get; set; }
            public static string launch_arguments { get; set; }
            public static string server_config_file { get; set; }
        }

        //===================================================================================//
        // QUERY AND STORE LOCAL DATA TO BE MODIFIED                                         //
        //===================================================================================//
        private void Prepare_Config_Data()
        {
            foreach (var jsonString in Settings.GetConfigJsonStrings())
            {
                Newtonsoft.Json.Linq.JObject o = Newtonsoft.Json.Linq.JObject.Parse(jsonString);
                if ((string)o["server_name"] == comboboxGameserverList.Text)
                {
                    MANAGED_OBJECT.server_name = (string)o["server_name"];
                    MANAGED_OBJECT.server_type = (string)o["server_type"];
                    MANAGED_OBJECT.install_dir = (string)o["install_dir"];
                    MANAGED_OBJECT.executable_dir = (string)o["executable_dir"];
                    MANAGED_OBJECT.launch_arguments = (string)o["launch_arguments"];
                    MANAGED_OBJECT.server_config_file = (string)o["server_config_file"];
                }
            }
        }

        //===================================================================================//
        // STARTUP                                                                           //
        //===================================================================================//
        private void GSM_Management_Load(object sender, EventArgs e)
        {
            //Pull all gameserver data from config.json, split all json strings into a list, iterate through that list for specific data.
            foreach (var jsonString in Settings.GetConfigJsonStrings())
            {
                Newtonsoft.Json.Linq.JObject o = Newtonsoft.Json.Linq.JObject.Parse(jsonString);
                comboboxGameserverList.Items.Add((string)o["server_name"]);
            }
        }

        //===================================================================================//
        // UPDATE SERVER CONFIGURATION                                                       //
        //===================================================================================//
        private void btnUpdateServerConfig_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Unfortunately this feature has not been implemented yet.  Please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void comboboxGameserverList_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            foreach (var jsonString in SettingsManagement_Classes.GetConfigJsonStrings())
            {
                foreach (var serverAppIDLink in jsonString)
                {
                    JToken value = serverAppIDLink.Value; //ServerName
                    string name = serverAppIDLink.Key; //Steam appID

                    if (value.ToString() == serverGiven)
                    {
                        return name; //appID
                    }
                }
                Newtonsoft.Json.Linq.JObject o = Newtonsoft.Json.Linq.JObject.Parse(jsonString);
                comboboxGameserverList.Items.Add((string)o["server_name"]);
            }
            */
        }

        //===================================================================================//
        // Class to store JSON data during management                                        //
        //===================================================================================//
        public static class Management_JObject
        {
            //Variables to be used during management:
            public static string server_name { get; set; }
            public static string server_type { get; set; }
            public static string install_dir { get; set; }
            public static string executable_dir { get; set; }
            public static string launch_arguments { get; set; }
            public static string server_config_file { get; set; }
        }

        private void comboboxGameserverList_SelectedValueChanged(object sender, EventArgs e)
        {
            Prepare_Config_Data();
            serverPropertiesTable.Rows.Clear();
            serverPropertiesTable.Rows.Add(MANAGED_OBJECT.server_name);
            serverPropertiesTable.Rows.Add(MANAGED_OBJECT.server_type);
            serverPropertiesTable.Rows.Add(MANAGED_OBJECT.install_dir);
            serverPropertiesTable.Rows.Add(MANAGED_OBJECT.executable_dir);
            serverPropertiesTable.Rows.Add(MANAGED_OBJECT.launch_arguments);
            serverPropertiesTable.Rows.Add(MANAGED_OBJECT.server_config_file);
        }
    }
}
