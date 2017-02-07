using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GameServer_Manager
{
    public class ServerAPI_Classes
    {
        //===================================================================================//
        // Download Config Data via API                                                      //
        //===================================================================================//
        public static string QUERY_DATA(string valueToRetrieve, string appID)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://sfo3.hauteclaire.me/config/" + appID);
                Newtonsoft.Json.Linq.JObject o = Newtonsoft.Json.Linq.JObject.Parse(json);
                var value = (string)o[valueToRetrieve];
                return value;
            }
        }

        //===================================================================================//
        // Query Index Data via API                                                          //
        //===================================================================================//
        public static string QUERY_STEAM_APPID(string serverGiven)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://sfo3.hauteclaire.me/index");
                Newtonsoft.Json.Linq.JObject o = Newtonsoft.Json.Linq.JObject.Parse(json);

                foreach (var serverAppIDLink in o)
                {
                    JToken value = serverAppIDLink.Value; //ServerName
                    string name = serverAppIDLink.Key; //Steam appID

                    if (value.ToString() == serverGiven)
                    {
                        return name; //appID
                    }
                }
                return "NULL";
            }
        }

        //===================================================================================//
        // Store Config Data into 2-Dimensional Array                                        //
        //===================================================================================//
        /*
        public static class ServerAPI_DataArray
        {
            //"name" | "steam_authrequired" | "default_launchscript" | "deployment_parameters" | "server_config_file" | "bgm_integration"

            //ServerAPI_Classes.ServerAPI_DataArray.ServerDataArray2D[1, 1] = "25"; //ADDS A VALUE TO ONE OF THE INDEXES OF THE 2D ARRAY
            public static string[,] ServerDataArray2D = new string[120, 6];
        }
        */
    }
}