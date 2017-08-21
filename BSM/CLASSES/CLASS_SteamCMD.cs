using System;
using System.IO;
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
            if (File.Exists(Environment.CurrentDirectory + @"\steamcmd.exe") == false)
            {
                //Create server directory for SteamCMD
                FileInfo file = new FileInfo(Environment.CurrentDirectory);
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
                File.Delete(Environment.CurrentDirectory + @"\SteamCMD.zip");
            }
        }
    }
}
