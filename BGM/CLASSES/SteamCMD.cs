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
            try
            {
                ServerDeployment ServerDeploymentDelegate = new ServerDeployment();
                if (System.IO.File.Exists(DestinationFolder + @"\steamcmd.exe") == false)
                {
                    //Create Server Directory for SteamCMD
                    System.IO.FileInfo file = new System.IO.FileInfo(DestinationFolder);
                    file.Directory.Create();

                    //Download SteamCMD.zip to Server Directory
                    using (System.Net.WebClient client = new System.Net.WebClient())
                    {
                        client.DownloadFile(new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip"),
                        DestinationFolder + @"\SteamCMD.zip");
                    }

                    //Extract SteamCMD.zip to Server Directory
                    ZipFile.ExtractToDirectory(DestinationFolder + @"\SteamCMD.zip", DestinationFolder);

                    //Delete old zip file.
                    System.IO.File.Delete(DestinationFolder + @"\SteamCMD.zip");

                    //Execute SteamCMD to download files from Valve.
                    ExternalExecution_Classes.LaunchExternalProgram(DestinationFolder + @"\steamcmd.exe", "+quit", null);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("It appears that either you have no internet connection, or you are unable to connect to Valve's servers.", "Unable to Connect");
            }
        }
    }
}