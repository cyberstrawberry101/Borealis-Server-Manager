using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Borealis
{
    public class SettingsManagement_Classes
    {
        //=====================================================================================//
        // Deploy Gameserver                                                                   //
        //=====================================================================================//
        public static void DeployGameserver(string server_name, string server_type, string install_dir, string executable_dir, string launch_arguments, string server_config_file)
        {
            dynamic serverData = new JObject();
            serverData.server_name = server_name;
            serverData.server_type = server_type;
            serverData.install_dir = install_dir;
            serverData.executable_dir = executable_dir;
            serverData.launch_arguments = launch_arguments;
            serverData.server_config_file = server_config_file;

            // Write JSON directly to config.json
            using (StreamWriter file = File.AppendText(Environment.CurrentDirectory + @"\config.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                serverData.WriteTo(writer);
            }
        }

        //=====================================================================================//
        // Retrieve all config.json strings as list                                            //
        //=====================================================================================//
        public static List<string> GetConfigJsonStrings()
        {
            int BracketCount = 0;
            string GameServerList = new StreamReader(Environment.CurrentDirectory + @"\config.json").ReadToEnd();
            List<string> JsonItems = new List<string>();
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
                    JsonItems.Add(Json.ToString());
                    Json = new StringBuilder();
                }
            }
            return JsonItems;
        }

        public static void RetrieveGameserver(string name)
        {

        }


        //=====================================================================================//
        // Destroy Gameserver                                                                  //
        //=====================================================================================//
        public static void DestroyGameserver(string name)
        {

        }

        //=====================================================================================//
        // Write data to config.json                                                           //
        //=====================================================================================//
        public static void WriteToConfig(string data)
        {

        }

        //=====================================================================================//
        // Read data from config.json                                                          //
        //=====================================================================================//
        public static string ReadFromConfig(string data)
        {
            return "returndata";
        }

        //=====================================================================================//
        // Remove data from config.json                                                        //
        //=====================================================================================//
        public static void RemoveFromConfig(string data)
        {

        }
    }
}
