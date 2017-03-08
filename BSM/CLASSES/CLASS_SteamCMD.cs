using System;
using System.IO.Compression;

namespace Borealis
{
    public class SteamCMD
    {
        //===================================================================================//
        // Download | Extract | First-Run SteamCMD                                           //
        //===================================================================================//
        public static void DownloadSteamCMD()
        {
            TAB_DEPLOYMENT ServerDeploymentDelegate = new TAB_DEPLOYMENT();
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\steamcmd.exe") == false)
            {
                //Create server directory for SteamCMD
                System.IO.FileInfo file = new System.IO.FileInfo(Environment.CurrentDirectory);
                file.Directory.Create();

                //Download SteamCMD.zip to Borealis directory
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    client.DownloadFile(new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip"),
                    Environment.CurrentDirectory + @"\SteamCMD.zip");
                }

                //Extract SteamCMD.zip to server directory
                ZipFile.ExtractToDirectory(Environment.CurrentDirectory + @"\SteamCMD.zip", Environment.CurrentDirectory);

                //Delete old zip file.
                System.IO.File.Delete(Environment.CurrentDirectory + @"\SteamCMD.zip");
            }
        }
    }
}
