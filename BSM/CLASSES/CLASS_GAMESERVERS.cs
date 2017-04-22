using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Borealis
{
    public struct GameServer_Management
    {
        //=====================================================================================//
        // Store all gameservers into a collections in memory                                  //
        //=====================================================================================//
        public static List<GameServer_Object> server_collection = new List<GameServer_Object>(); //Master collection of deployed gameservers

        //=====================================================================================//
        // Method to add a gameserver JObject to the collection                                //
        //=====================================================================================//
        public void addServer(GameServer_Object gameserver)
        {
            server_collection.Add(gameserver);
        }

        //=====================================================================================//
        // Method to import all jsonstrings from gameservers.json into the JObject collection  //
        //=====================================================================================//
        public void addAllServers_fromConfig()
        {
            int BracketCount = 0;
            string GameServerList = File.ReadAllText(Environment.CurrentDirectory + @"\gameservers.json");
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
                    var importedServer = JsonConvert.DeserializeObject<GameServer_Object>(Json.ToString());
                    addServer(importedServer);

                    Json.Clear();
                }
            }
        }
    }


    public class GameServer_Object
    {
        //Server-based Properties
        public string SERVER_name_friendly { get; set; }    //User-designated name
        public string SERVER_type { get; set; }             //Type of gameserver (e.g. "Garry's Mod", "Synergy", etc)
        public string SERVER_launch_arguments { get; set; } //Default launch arguments and current launch arguments
        public bool SERVER_running_status { get; set; }     //Determine whether the server is running or stopped

        //Directory-based Properties
        public string DIR_install_location { get; set; }    //Location of where gameserver was deployed
        public string DIR_executable { get; set; }          //The relative location of where the server executable is located relative to install location
        public string DIR_config { get; set; }              //Relative config directory
        public string DIR_config_file { get; set; }         //Name of configuration file if there is only one that controls the server

        //Steam-based Properties
        public bool STEAM_authrequired { get; set; }        //Determine whether the server requires Steam Guard or allows anonymous login
        public bool STEAM_steamcmd_required { get; set; }   //Determines if the gameserver is deployed using steamcmd or not
        public bool STEAM_workshop_enabled { get; set; }    //Determines if the gameserver supports Steam Workshop

        //Miscellanious Properties
        public string ENGINE_type { get; set; }             //Determines the game engine, and by proxy, how to hook onto it
        public string bsm_integration { get; set; }         //Determines the support level of the gameserver in Borealis


        //=====================================================================================//
        // Method to retrieve all internal properties of JSON data                             //
        //=====================================================================================//
        public JObject ExportJSON(bool WriteToDisk)
        {
            dynamic serverData = new JObject();

            //Server-based Properties
            serverData.SERVER_name_friendly = SERVER_name_friendly;         //User-designated name
            serverData.SERVER_type = SERVER_type;                           //Type of gameserver (e.g. "Garry's Mod", "Synergy", etc)
            serverData.SERVER_launch_arguments = SERVER_launch_arguments;   //Default launch arguments and current launch arguments

            //Directory-based Properties
            serverData.DIR_install_location = DIR_install_location;         //Location of where gameserver was deployed
            serverData.DIR_executable = DIR_executable;                     //The relative location of where the server executable is located relative to install location
            serverData.DIR_config = DIR_config;                             //Relative config directory
            serverData.DIR_config_file = DIR_config_file;                   //Name of configuration file if there is only one that controls the server

            //Steam-based Properties
            serverData.STEAM_authrequired = STEAM_authrequired;             //Determine whether the server requires Steam Guard or allows anonymous login
            serverData.STEAM_steamcmd_required = STEAM_steamcmd_required;   //Determines if the gameserver is deployed using steamcmd or not
            serverData.STEAM_workshop_enabled = STEAM_workshop_enabled;     //Determines if the gameserver supports Steam Workshop

            //Miscellanious Properties
            serverData.ENGINE_type = ENGINE_type;                           //Determines the game engine, and by proxy, how to hook onto it
            serverData.bsm_integration = bsm_integration;                   //Determines the support level of the gameserver in Borealis

            if (WriteToDisk == true)
            {
                using (StreamWriter file = File.AppendText(Environment.CurrentDirectory + @"\gameservers.json"))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    writer.WriteRaw(JsonConvert.SerializeObject(serverData, Formatting.Indented));
                }
            }

            return serverData; //Returns all of the internal data as a JSON Object, usable by other internal methods.
        }
    }
}

