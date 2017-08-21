using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Borealis
{
    public class GameServerObject
    {
        //Server-based Properties
        public string SERVER_name_friendly { get; set; }    //User-designated name
        public string SERVER_type { get; set; }             //Type of gameserver (e.g. "Garry's Mod", "Synergy", etc)
        public string SERVER_launch_arguments { get; set; } //Default launch arguments and current launch arguments
        public string SERVER_executable { get; set; }       //The relative location of where the server executable is located relative to install location
        public string SERVER_port { get; set; }
        public int SERVER_processID { get; set; }

        //Custom configuration values given to server
        public int GAME_maxplayers { get; set; }
        public string GAME_map { get; set; }

        //Directory-based Properties
        public string DIR_install_location { get; set; }    //Location of where gameserver was deployed
        public string DIR_root { get; set; }                //Location of root directory where the server is to be expected
        public string DIR_maps { get; set; }                //Location of where gameserver's maps are located.
        public string DIR_maps_file_extension { get; set; }  //Tell Borealis what file extension to look for when populating the map listing
        public string DIR_mods { get; set; }                //Location of where gameserver's mods/workshop subscriptions are located
        public string DIR_config { get; set; }              //Location of where gameserver's primary configuration files are stored

        //Steam-based Properties
        public bool STEAM_authrequired { get; set; }        //Determine whether the server requires Steam Guard or allows anonymous login
        public bool STEAM_steamcmd_required { get; set; }   //Determines if the gameserver is deployed using steamcmd or not
        public bool STEAM_workshop_enabled { get; set; }    //Determines if the gameserver supports Steam Workshop

        //Miscellanious Properties
        public string ENGINE_type { get; set; }             //Determines the game engine, and by proxy, how to hook onto it
        public string bsm_integration { get; set; }         //Determines the support level of the gameserver in Borealis
        public bool bsm_custominstallfolder { get; set; }   //Determines whether the user gave a custom install folder or not.
    }

    public static class GameServerManagement
    {
        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented
        };

        //=====================================================================================//
        // Store all gameservers into a collections in memory                                  //
        //=====================================================================================//
        public static List<GameServerObject> ServerCollection = new List<GameServerObject>(); //Master collection of deployed gameservers

        //=====================================================================================//
        // Method to add a gameserver JObject to the collection                                //
        //=====================================================================================//
        public static void GameserverAdd(GameServerObject gameserver)
        {
            ServerCollection.Add(gameserver);
        }

        //=====================================================================================//
        // Method to import all jsonstrings from gameservers.json into the JObject collection  //
        //=====================================================================================//
        public static void ConfigRead()
        {
            string gameServerJson = File.ReadAllText(Environment.CurrentDirectory + @"\gameservers.json");

            if (gameServerJson[0] == '[')
            {
                // Use the new parsing method
                var gameServers = JsonConvert.DeserializeObject<IEnumerable<GameServerObject>>(gameServerJson, SerializerSettings);

                ServerCollection.AddRange(gameServers);
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
                        var importedServer = JsonConvert.DeserializeObject<GameServerObject>(json.ToString());
                        GameserverAdd(importedServer);

                        json.Clear();
                    }
                }
            }
        }
        public static void ConfigWrite()
        {
            string gameServersJson = JsonConvert.SerializeObject(ServerCollection, SerializerSettings);
            File.WriteAllText(Environment.CurrentDirectory + @"\gameservers.json", gameServersJson);
        }

        public static GameServerObject PropertyGetSet(string SERVER_name_friendly)
        {
            //Check to make sure the gameserver collection isn't empty.
            if (ServerCollection != null)
            {
                //Iterate throught all gameservers in collection.
                foreach (GameServerObject gameserver in ServerCollection)
                {
                    //Locate specific gameserver
                    if (SERVER_name_friendly == gameserver.SERVER_name_friendly)
                    {
                        return gameserver;
                    }
                }
                return null;
            }
            return null;
        }
    }



}

