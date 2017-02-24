using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Collections;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Borealis
{
    public class GameServer_Management
    {
        //=====================================================================================//
        // Store all gameservers into a collection in memory                                   //
        //=====================================================================================//
        public static List<JObject> server_collection = new List<JObject>();

        //=====================================================================================//
        // The gameserver class that creates instances of itself to be added to the collection //
        //=====================================================================================//
        public class GameServer
        {
            public string server_name { get; set; }
            public string server_type { get; set; }
            public string install_dir { get; set; }
            public string executable_dir { get; set; }
            public string launch_arguments { get; set; }
            public string server_config_file { get; set; }
            public bool running_status { get; set; }
        }

        //=====================================================================================//
        // Method to add a gameserver JObject to the collection                                //
        //=====================================================================================//
        public void addServer(JObject gameserver_object)
        {
            server_collection.Add(gameserver_object);
        }

        //=====================================================================================//
        // Method to import all jsonstrings from config.json into the JObject collection       //
        //=====================================================================================//
        public void addAllServers_fromConfig()
        {
            int BracketCount = 0;
            string GameServerList = new StreamReader(Environment.CurrentDirectory + @"\config.json").ReadToEnd();
            StringBuilder Json = new StringBuilder();
            foreach (char c in GameServerList)
            {
                if (c == '{')
                    ++BracketCount;
                else if (c == '}')
                    --BracketCount;
                Json.Append(c);

                if (BracketCount == 0 && c != ' ')
                {
                    addServer(JObject.Parse(Json.ToString()));
                    Json = new StringBuilder();
                }
            }
        }

        //=====================================================================================//
        // Method to deploy gameserver data into config.json                                   //
        //=====================================================================================//
        public void DeployGameserver(string server_name, string server_type, string install_dir, string executable_dir, string launch_arguments, string server_config_file, bool running_status, bool borealis_closing)
        {
            dynamic serverData = new JObject();
            serverData.server_name = server_name;
            serverData.server_type = server_type;
            serverData.install_dir = install_dir;
            serverData.executable_dir = executable_dir;
            serverData.launch_arguments = launch_arguments;
            serverData.server_config_file = server_config_file;
            serverData.running_status = running_status;

            if (borealis_closing == false)  //Only add data to active JObject list if it isn't being triggered by the closing event triggering it.
            {
                addServer(serverData);
            }

            // Write JSON directly to config.json in the event of a crash
            using (StreamWriter file = File.AppendText(Environment.CurrentDirectory + @"\config.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                serverData.WriteTo(writer);
            }
        }
    }
}

