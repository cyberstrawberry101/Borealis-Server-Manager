using Newtonsoft.Json.Linq;

namespace Borealis
{
    public class ServerAPI
    {
        //===================================================================================//
        // Download Config Data via API into Memory                                          //
        //===================================================================================//
        public static void QUERY_DATA(string appID)
        {
            GameServer_Management.deployment_server.Clear(); //Clear the deployment server list.
            GameServer_Management.GameServer DeploymentServer = new GameServer_Management.GameServer();
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://phantom-net.duckdns.org:1337/config/" + appID);
                GameServer_Management Deploy = new GameServer_Management();
                Deploy.addDeploymentServer(JObject.Parse(json));
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