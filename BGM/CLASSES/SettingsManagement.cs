using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace GameServer_Manager
{
    public class SettingsManagement_Classes
    {
        //=====================================================================================//
        // Read XML Data Function                                                              //
        //=====================================================================================//
        public static string GameServerXMLData(string serverName, string elementToFind)
        {
            //Read the XML file to determine what the launch parameters are.
            var xdoc = XDocument.Load(Environment.CurrentDirectory + @"\gameservers_data.xml");
            string retrievedValue = xdoc.Descendants("server")
                .Where(s => (string)s.Element("server_name") == serverName)
                .Select(s => (string)s.Element(elementToFind))
                .FirstOrDefault();
            return retrievedValue;
        }
    }
}
