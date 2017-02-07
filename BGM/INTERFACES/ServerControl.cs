using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;
using System.Threading;

namespace GameServer_Manager
{
    public partial class ServerControl : Form
    {
        private CancellationTokenSource cancelToken;

        public ServerControl()
        {
            InitializeComponent();

            //Query the gameserver_data.xml to list all servers in dropdown menu.
            if( File.Exists( Environment.CurrentDirectory + @"\gameservers_data.xml" ) )
            {
                var xdoc = XDocument.Load( Environment.CurrentDirectory + @"\gameservers_data.xml" );
                foreach( var child in xdoc.Elements( "gameserver_listing" ).Elements( "server" ).Where( x => !string.IsNullOrEmpty( x.Element( "installation_folder" )?.Value ) ).Elements( "server_name" ) )
                {
                    comboboxGameserverList.Items.Add( child.Value );
                }
            }

            cancelToken = new CancellationTokenSource();
        }

        //===================================================================================//
        // START THE CURRENTLY STOPPED SELECTED GAMESERVER                                   //
        //===================================================================================//
        private void btnStartServer_Click( object sender, EventArgs e )
        {
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
            txtboxIssueCommand.Enabled = true;
            txtboxIssueCommand.Text = "> Type a command";
            consoleViewport.color = Color.FromArgb( 255, 67, 181, 129 );
            backgroundWorker01.RunWorkerAsync();

        }

        //===================================================================================//
        // STOP THE CURRENTLY RUNNING SELECTED GAMESERVER                                    //
        //===================================================================================//
        private void btnStopServer_Click( object sender, EventArgs e )
        {
            cancelToken.Cancel();
            backgroundWorker01.RunWorkerCompleted += (sender2, e2) =>
            {
                btnStopServer.Enabled = false;
                btnStartServer.Enabled = true;
                txtboxIssueCommand.Enabled = false;
                txtboxIssueCommand.Text = "> Server is not running";
                consoleViewport.color = Color.FromArgb( 255, 191, 75, 96 );
                txtboxConsoleOutput.Items.Add( "Server stopped..." );
            };

            
            //backgroundWorker01.CancelAsync();
            
        }

        //===================================================================================//
        // ISSUE COMMAND TO SERVER VIA TEXTBOX                                               //
        //===================================================================================//
        private void txtboxIssueCommand_MouseClick( object sender, MouseEventArgs e )
        {
            txtboxIssueCommand.Text = "";
        }

        //===================================================================================//
        // LAUNCH BACKGROUND WORKER TO HANDLE PROCESS                                        //
        //===================================================================================//
        private void backgroundWorker01_DoWork( object sender, DoWorkEventArgs e )
        {
            bool stopped = false;

            //It's an assumption that these 3 elements MUST exist
            var asyncCallback = comboboxGameserverList.BeginInvoke( (Func<string[]>) delegate ()
            {
                return new string[] {
                    SettingsManagement_Classes.GameServerXMLData( comboboxGameserverList.SelectedItem as string, "installation_folder" ),
                    SettingsManagement_Classes.GameServerXMLData( comboboxGameserverList.SelectedItem as string, "default_launchscript" ),
                    SettingsManagement_Classes.GameServerXMLData( comboboxGameserverList.SelectedItem as string, "binaries" )
                };
            } );
            asyncCallback.AsyncWaitHandle.WaitOne();
            var serverParams = comboboxGameserverList.EndInvoke( asyncCallback ) as string[];

            Action<string> textAddCallback = ( args ) =>
            {
                txtboxConsoleOutput.BeginInvoke( (Action) delegate ()
                {
                    txtboxConsoleOutput.Items.Add( args );
                } );
            };

            EventHandler exitedHandler = ( sender2, e2 ) =>
            {
                if( !cancelToken.IsCancellationRequested )
                {
                    //Wait a little until we restart the server
                    txtboxConsoleOutput.BeginInvoke( (Action) delegate ()
                    {
                        txtboxConsoleOutput.Items.Add( Environment.NewLine );
                        txtboxConsoleOutput.Items.Add( Environment.NewLine );
                        txtboxConsoleOutput.Items.Add( Environment.NewLine );

                        txtboxConsoleOutput.Items.Add( "An error occured and the process has crashed. Auto-restarting in 5 seconds..." );
                        //Scroll to the bottom
                        txtboxConsoleOutput.TopIndex = txtboxConsoleOutput.Items.Count - 1;

                        txtboxConsoleOutput.Items.Add( Environment.NewLine );
                        txtboxConsoleOutput.Items.Add( Environment.NewLine );
                        txtboxConsoleOutput.Items.Add( Environment.NewLine );
                    } );
                    Thread.Sleep( 5000 );
                }
                else
                    stopped = true;
            };

            while( chkAutoRestart.Value && !stopped )
                ExternalExecution_Classes.LaunchExternalProgram( serverParams[ 0 ] + serverParams[ 2 ], serverParams[ 1 ], textAddCallback, null, serverParams[ 0 ], chkAutoRestart.Value ? exitedHandler : null, chkAutoRestart.Value ? cancelToken.Token : default(System.Threading.CancellationToken) );
        }
    }
}
