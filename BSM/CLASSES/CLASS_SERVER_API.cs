using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Borealis
{
    public class ServerAPI
    {
        //===================================================================================//
        // Download Config Data via API into Memory                                          //
        //===================================================================================//
        public static GameServerObject QUERY_DATA(string appID)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://sfo2.hauteclaire.me:1337/config/" + appID);
                return JsonConvert.DeserializeObject<GameServerObject>(json);
            }
        }

        //===================================================================================//
        // Query STEAM_APPID Data via API                                                    //
        //===================================================================================//
        public static string QUERY_STEAM_APPID(string serverGiven)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://sfo2.hauteclaire.me:1337/index");
                JObject o = JObject.Parse(json);

                foreach (var serverAppIDLink in o)
                {
                    JToken value = serverAppIDLink.Value; //ServerName
                    string appID = serverAppIDLink.Key; //Steam appID

                    if (value.ToString() == serverGiven)
                    {
                        return appID; //appID
                    }
                }
                return "NULL";
            }
        }
    }
}
