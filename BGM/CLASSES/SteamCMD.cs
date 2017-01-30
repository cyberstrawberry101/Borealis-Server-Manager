using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace GameServer_Manager
{
    public class SteamCMD_Classes
    {
        //===================================================================================//
        // Download | Extract | First-Run SteamCMD                                           //
        //===================================================================================//
        public static void DownloadSteamCMD(string DestinationFolder)
        {
            ServerDeployment ServerDeploymentDelegate = new ServerDeployment();

            ServerDeploymentDelegate.updateProgressStatus(25, 30, "Checking for active internet connection...");
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) //Check for network connectivity
            {
                if (System.IO.File.Exists(DestinationFolder + @"\steamcmd.exe"))
                {
                    //Do nothing!
                }
                else
                {
                    //Create Server Directory for SteamCMD
                    System.IO.FileInfo file = new System.IO.FileInfo(DestinationFolder);
                    file.Directory.Create(); //If the directory already exists, this method does nothing.

                    //Download SteamCMD.zip to Server Directory
                    using (System.Net.WebClient client = new System.Net.WebClient()) //Download SteamCMD.zip
                    {
                        client.DownloadFile(new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip"),
                        DestinationFolder + @"\SteamCMD.zip");
                    }

                    //Extract SteamCMD.zip to Server Directory
                    ZipFile.ExtractToDirectory(DestinationFolder + @"\SteamCMD.zip", DestinationFolder);

                    //Delete old zip file.
                    System.IO.File.Delete(DestinationFolder + @"\SteamCMD.zip");

                    //Execute SteamCMD to download files from Valve.
                    ExternalExecution_Classes.LaunchExternalProgram(DestinationFolder + @"\steamcmd.exe", " +quit", false);
                }
            }
            else
            {
                MessageBox.Show("You have no active internet connection.  You won't be able to download anything.", "Aborting Process");
            }
        }
    }
}