using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Borealis
{
    public class GameServer_Management
    {
        //=====================================================================================//
        // Store all gameservers into a collections in memory                                  //
        //=====================================================================================//
        public static List<JObject> server_collection = new List<JObject>(); //Master collection of deployed gameservers
        public static List<JObject> deployment_server = new List<JObject>(); //Current server in memory being deployed

        //=====================================================================================//
        // The gameserver class that creates instances of itself to be added to the collection //
        //=====================================================================================//
        public class GameServer
        {
            //Server-based Properties
            public string SERVER_name { get; set; }             //Default name
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
        }

        //=====================================================================================//
        // Method to deploy gameserver data into config.json                                   //
        //=====================================================================================//
        public void DeployGameserver(

        //Server-based Properties
        string SERVER_name,             //Default name
        string SERVER_name_friendly,    //User-designated name
        string SERVER_type,             //Type of gameserver (e.g. "Garry's Mod", "Synergy", etc)
        string SERVER_launch_arguments, //Default launch arguments and current launch arguments
        bool SERVER_running_status,     //Determine whether the server is running or stopped

        //Directory-based Properties
        string DIR_install_location,    //Location of where gameserver was deployed
        string DIR_executable,          //The relative location of where the server executable is located relative to install location
        string DIR_config,              //Relative config directory 
        string DIR_config_file,         //Name of configuration file if there is only one that controls the server

        //Steam-based Properties
        bool STEAM_authrequired,        //Determine whether the server requires Steam Guard or allows anonymous login
        bool STEAM_steamcmd_required,   //Determines if the gameserver is deployed using steamcmd or not
        bool STEAM_workshop_enabled,    //Determines if the gameserver supports Steam Workshop

        //Miscellanious Properties
        string ENGINE_type,             //Determines the game engine, and by proxy, how to hook onto it
        string bsm_integration,         //Determines the support level of the gameserver in Borealis

        //Deployment Property
        bool borealis_closing)
        {
            dynamic serverData = new JObject();

            //Server-based Properties
            serverData.SERVER_name = SERVER_name;                           //Default name
            serverData.SERVER_name_friendly = SERVER_name_friendly;         //User-designated name
            serverData.SERVER_type = SERVER_type;                           //Type of gameserver (e.g. "Garry's Mod", "Synergy", etc)
            serverData.SERVER_launch_arguments = SERVER_launch_arguments;   //Default launch arguments and current launch arguments
            serverData.SERVER_running_status = SERVER_running_status;       //Determine whether the server is running or stopped

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

            if (borealis_closing == false)                                  //Only add data to active JObject list if it isn't being triggered by the closing event triggering it
            {
                    addServer(serverData);                                  //Send the server to the gameserver list.
            }

            using (StreamWriter file = File.AppendText(Environment.CurrentDirectory + @"\config.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                writer.WriteRaw(JsonConvert.SerializeObject(serverData, Formatting.Indented));
            }
        }

        //=====================================================================================//
        // Method to add a gameserver JObject to the collection                                //
        //=====================================================================================//
        public void addServer(JObject gameserver_object)
        {
            server_collection.Add(gameserver_object);
        }

        //=====================================================================================//
        // Method to add a gameserver JObject to the temporary deployment list                 //
        //=====================================================================================//
        public void addDeploymentServer(JObject gameserver_object)
        {
            deployment_server.Add(gameserver_object);
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

        
    }
}

