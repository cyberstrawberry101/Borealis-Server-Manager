using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace GameServer_Manager
{
    public class Left4Dead2_Classes
    {
        //===================================================================================//
        // Download GameServer using SteamCMD                                                //
        //===================================================================================//
        public static void DownloadGameServer(string DestinationFolder)
        {
            ExternalExecution_Classes.LaunchExternalProgram(DestinationFolder + @"\steamcmd.exe", "+login anonymous +app_update 222860 +quit", false);
        }

        //===================================================================================//
        // Configure GameServer                                                              //
        //===================================================================================//
        public static void ConfigureGameServer()
        {

        }

        //===================================================================================//
        // Generate Launch Scripts                                                           //
        //===================================================================================//
        public static void GenerateScripts()
        {

        }

        //===================================================================================//
        // Install SourceMod                                                                 //
        //===================================================================================//
        public static void InstallSourceMod()
        {

        }
    }
}
