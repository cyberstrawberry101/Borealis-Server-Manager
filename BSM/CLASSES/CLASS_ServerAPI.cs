﻿using Newtonsoft.Json.Linq;

namespace Borealis
{
    public class ServerAPI
    {
        //===================================================================================//
        // Download Config Data via API into Memory                                          //
        //===================================================================================//
        public static GameServer_Object QUERY_DATA(string appID)
        {
            GameServer_Management.deployment_server.Clear(); //Clear the deployment server list.
            GameServer_Object DeploymentServer = new GameServer_Object();
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://phantom-net.duckdns.org:1337/config/" + appID);
                DeploymentServer.ImportJSON(JObject.Parse(json));
                GameServer_Management.deployment_server.Add(DeploymentServer);
            }

            return DeploymentServer;
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