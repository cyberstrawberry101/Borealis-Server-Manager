using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Borealis
{
    public class ServerAPI
    {
        //===================================================================================//
        // Class to store JSON data during deployment                                        //
        //===================================================================================//
        public static class QUERY_JOBJECT
        {
            //Variables to be used during deployment:
            public static string name { get; set; }
            public static string steam_authrequired { get; set; }
            public static string steamcmd_required { get; set; }
            public static string server_executable_location { get; set; }
            public static string default_launch_arguments { get; set; }
            public static string server_config_file { get; set; }
            public static string bsm_integration { get; set; }
        }


        //===================================================================================//
        // Download Config Data via API into Memory                                          //
        //===================================================================================//
        public static void QUERY_DATA(string appID)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://phantom-net.duckdns.org:1337/config/" + appID);
                JObject o = JObject.Parse(json);
                QUERY_JOBJECT.name = (string)o["name"];
                QUERY_JOBJECT.steam_authrequired = (string)o["steam_authrequired"];
                QUERY_JOBJECT.steamcmd_required = (string)o["steamcmd_required"];
                QUERY_JOBJECT.server_executable_location = (string)o["server_executable_location"];
                QUERY_JOBJECT.default_launch_arguments = (string)o["default_launch_arguments"];
                QUERY_JOBJECT.server_config_file = (string)o["server_config_file"];
                QUERY_JOBJECT.bsm_integration = (string)o["bsm_integration"];
            }
        }

        //===================================================================================//
        // Query STEAM_APPID Data via API                                                    //
        //===================================================================================//
        public static string QUERY_STEAM_APPID(string serverGiven)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://phantom-net.duckdns.org:1337/index");
                JObject o = JObject.Parse(json);

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
    }
}