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
    }
}
