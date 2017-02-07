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

        public static void WriteGameServerXMLData( string serverName, string elementName, string elementData, XAttribute[] elementAttributes = null )
        {
            var xdoc = XDocument.Load( Environment.CurrentDirectory + @"\gameservers_data.xml" );
            var serverNode = xdoc.Descendants( "server" )
                                 .Where( x => x.Element( "server_name" ).Value == serverName )
                                 .FirstOrDefault();

            if( serverNode == null )
                throw new ArgumentException( $"ERROR! Failed to find node by the name of: '{serverName} in '{Environment.CurrentDirectory + @"\gameservers_data.xml"}'" );

            if( serverNode.Element( "installation_folder" ) != null )
            {
                serverNode.Element( "installation_folder" )
                          .ReplaceWith( new XElement( elementName, elementData, elementAttributes ) );
            }
            else
            {
                serverNode.Descendants()
                          .Last()
                          .AddAfterSelf( new XElement( elementName, elementData, elementAttributes ) );
            }
                
            xdoc.Save( Environment.CurrentDirectory + @"\gameservers_data.xml" );
        }
    }
}