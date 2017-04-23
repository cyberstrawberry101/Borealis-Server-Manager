using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Borealis
{
    public static class GameServer_Management
    {
        private static readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented
        };

        //=====================================================================================//
        // Store all gameservers into a collections in memory                                  //
        //=====================================================================================//
        public static List<GameServer_Object> server_collection = new List<GameServer_Object>(); //Master collection of deployed gameservers

        //=====================================================================================//
        // Method to add a gameserver JObject to the collection                                //
        //=====================================================================================//
        public static void addServer(GameServer_Object gameserver)
        {
            server_collection.Add(gameserver);
        }

        //=====================================================================================//
        // Method to import all jsonstrings from gameservers.json into the JObject collection  //
        //=====================================================================================//
        public static void ReadServersFromConfig()
        {
            string gameServerJson = File.ReadAllText(Environment.CurrentDirectory + @"\gameservers.json");

            if (gameServerJson[0] == '[')
            {
                // Use the new parsing method
                var gameServers = JsonConvert.DeserializeObject<IEnumerable<GameServer_Object>>(gameServerJson, _serializerSettings);

                server_collection.AddRange(gameServers);
            }
            else
            {
                int bracketCount = 0;
                StringBuilder json = new StringBuilder();

                foreach (char c in gameServerJson)
                {
                    if (c == '{')
                        ++bracketCount;
                    else if (c == '}')
                        --bracketCount;
                    json.Append(c);

                    if (bracketCount == 0 && c != ' ')
                    {
                        var importedServer = JsonConvert.DeserializeObject<GameServer_Object>(json.ToString());
                        addServer(importedServer);

                        json.Clear();
                    }
                }
            }
        }

        public static void WriteServersToConfig()
        {
            string gameServersJson = JsonConvert.SerializeObject(server_collection, _serializerSettings);
            File.WriteAllText(Environment.CurrentDirectory + @"\gameservers.json", gameServersJson);
        }
    }


    public class GameServer_Object
    {
        //Server-based Properties
        public string SERVER_name_friendly { get; set; }    //User-designated name
        public string SERVER_type { get; set; }             //Type of gameserver (e.g. "Garry's Mod", "Synergy", etc)
        public string SERVER_launch_arguments { get; set; } //Default launch arguments and current launch arguments
        public bool SERVER_running_status { get; set; }     //Determine whether the server is running or stopped
        public string SERVER_executable { get; set; }          //The relative location of where the server executable is located relative to install location

        //Custom configuration values given to server
        public int SERVER_maxplayers { get; set; }
        public string SERVER_map { get; set; }

        //Directory-based Properties
        public string DIR_install_location { get; set; }    //Location of where gameserver was deployed
        public string DIR_root { get; set; }                //Location of root directory where the server is to be expected

        //Steam-based Properties
        public bool STEAM_authrequired { get; set; }        //Determine whether the server requires Steam Guard or allows anonymous login
        public bool STEAM_steamcmd_required { get; set; }   //Determines if the gameserver is deployed using steamcmd or not
        public bool STEAM_workshop_enabled { get; set; }    //Determines if the gameserver supports Steam Workshop

        //Miscellanious Properties
        public string ENGINE_type { get; set; }             //Determines the game engine, and by proxy, how to hook onto it
        public string bsm_integration { get; set; }         //Determines the support level of the gameserver in Borealis
        public bool bsm_custominstallfolder { get; set; }   //Determines whether the user gave a custom install folder or not.
    }
}

