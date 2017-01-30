using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace GameServer_Manager
{
    public class SteamCMD_Classes
    {
        //===================================================================================//
        // Download SteamCMD                                                                 //
        //===================================================================================//
        public static void DownloadSteamCMD(string DestinationFolder)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) //Check for network connectivity
            {
                if (System.IO.Directory.Exists(DestinationFolder)) //If DestinationFolder already exists
                {
                    using (System.Net.WebClient client = new System.Net.WebClient()) //Download SteamCMD.zip
                    {
                        client.DownloadFileAsync(new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip"),
                        DestinationFolder + @"\SteamCMD.zip");
                    }
                }
                else //If DestinationFolder does not exist
                {
                    System.IO.FileInfo file = new System.IO.FileInfo(DestinationFolder);
                    file.Directory.Create(); //If the directory already exists, this method does nothing.

                    using (System.Net.WebClient client = new System.Net.WebClient()) //Download SteamCMD.zip
                    {
                        client.DownloadFileAsync(new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip"),
                        DestinationFolder + @"\SteamCMD.zip");
                    }
                }
            }
        }

        //===================================================================================//
        // Deploy SteamCMD                                                                   //
        //===================================================================================//
        public static void DeploySteamCMD()
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) //Check for network connectivity
                {
                    //Extract SteamCMD.zip
                    //System.IO.Compression.ZipFile.ExtractToDirectory(DestinationFolder + @"\SteamCMD.zip", DestinationFolder);
                    //Execute SteamCMD to download more files from steam.
                    ExternalExecution_Classes.LaunchExternalProgram("SteamCMD.exe", "arguments", false, false);
                }     
            }
        }
    }
