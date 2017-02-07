using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections;
using System.Runtime.InteropServices;

namespace GameServer_Manager
{
    public class ExternalExecution_Classes
    {
        #region pInvoke
        [DllImport( "kernel32.dll", SetLastError = true )]
        static extern bool AttachConsole( uint dwProcessId );

        [DllImport( "kernel32.dll", SetLastError = true, ExactSpelling = true )]
        static extern bool FreeConsole();

        [DllImport( "kernel32.dll" )]
        static extern bool SetConsoleCtrlHandler( ConsoleCtrlDelegate HandlerRoutine, bool Add );
        // Delegate type to be used as the Handler Routine for SCCH
        delegate Boolean ConsoleCtrlDelegate( CtrlTypes CtrlType );

        // Enumerated type for the control messages sent to the handler routine
        enum CtrlTypes : uint
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT,
            CTRL_CLOSE_EVENT,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT
        }

        [DllImport( "kernel32.dll" )]
        [return: MarshalAs( UnmanagedType.Bool )]
        private static extern bool GenerateConsoleCtrlEvent( CtrlTypes dwCtrlEvent, uint dwProcessGroupId );

        public static void StopProgramByAttachingToItsConsoleAndIssuingCtrlCEvent( Process proc )
        {
            //This does not require the console window to be visible.
            if( AttachConsole( (uint) proc.Id ) )
            {
                //Disable Ctrl-C handling for our program
                SetConsoleCtrlHandler( null, true );
                GenerateConsoleCtrlEvent( CtrlTypes.CTRL_C_EVENT, 0 );

                //Must wait here. If we don't and re-enable Ctrl-C handling below too fast, we might terminate ourselves.
                var wasAborted = false;
                var procTask = Task.Run( () => 
                {
                    //This is necessary because when we kill the process, it obviously exits. At that point, there is no proc object to wait for any longer
                    if( !wasAborted )
                        proc.WaitForExit();
                } );
                if( !procTask.Wait( 10000 ) )
                {
                    wasAborted = true;
                    proc.Kill();
                }

                FreeConsole();

                //Re-enable Ctrl-C handling or any subsequently started programs will inherit the disabled state.
                SetConsoleCtrlHandler( null, false );
            }
        }

        #endregion

        //===================================================================================//
        // LAUNCH EXTERNAL PROGRAM WITH GIVEN ARGUMENTS                                      //
        //===================================================================================//
        public static void LaunchExternalProgram( string argProgramName, string argParameters, Action<string> redirectedOutputCallback = null, TextReader input = null, string argWorkingDirectory = null, EventHandler onExitedCallback = null, CancellationToken cancelToken = default(CancellationToken) )
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = argParameters;
            startInfo.FileName = argProgramName;

            if( !string.IsNullOrEmpty( argWorkingDirectory ) )
                startInfo.WorkingDirectory = argWorkingDirectory;

            if( redirectedOutputCallback != null )  //Redirect Output to somewhere else.
            {
                startInfo.UseShellExecute = false; //Redirect the programs.
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.RedirectStandardError = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardInput = true;
                startInfo.ErrorDialog = false;

                try
                {
                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.

                    using( var process = Process.Start( startInfo ) )
                    {
                        if( onExitedCallback != null )
                        {
                            process.EnableRaisingEvents = true;
                            process.Exited += onExitedCallback;
                        }

                        if( cancelToken != null )
                        {
                            cancelToken.Register( () => 
                            {
                                StopProgramByAttachingToItsConsoleAndIssuingCtrlCEvent( process );

                                redirectedOutputCallback?.Invoke( "Shutting down the server..." );
                            } );
                        }

                        process.OutputDataReceived += ( sender, args ) =>
                        {
                            if( !string.IsNullOrEmpty( args?.Data) )
                                redirectedOutputCallback( args.Data );
                        };
                        process.BeginOutputReadLine();

                        process.ErrorDataReceived += ( sender, args ) =>
                        {
                            if( !string.IsNullOrEmpty( args?.Data ) )
                                redirectedOutputCallback( args.Data );
                        };
                        process.BeginErrorReadLine();

                        //For whenever input is needed
                        string line;
                        while( input != null && ( line = input.ReadLine() ) != null )
                            process.StandardInput.WriteLine( line );

                        //process.StandardInput.Close();
                        process.WaitForExit();
                    }


                }
                catch
                {
                    StringBuilder errorDialog = new StringBuilder();
                    errorDialog.Append( "There was an error launching the following server:\n" )
                               .Append( startInfo.FileName )
                               .Append( "\n\n" )
                               .Append( "[Retry]: Attempt to start the same server again.\n" )
                               .Append( "[Cancel]: Cancel attempting to start server." );
                    //if (MetroMessageBox.Show(this, errorDialog.ToString(), "Error Launching Cleanup Tool", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                    //{
                    //    goto LaunchTool_Retry; //Hacky way retry the method.
                    //}
                }
            }
            else  //No not redirect output somewhere else
            {
                startInfo.UseShellExecute = true; //Execute the programs.
                //startInfo.WindowStyle = ProcessWindowStyle.Hidden; //ONLY ENABLE THIS WHEN DATA HAS BEEN SUCCESSFULLY PIPED TO THE PROGRAM ITSELF

                try
                {
                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using( Process exeProcess = Process.Start( startInfo ) )
                    {
                        exeProcess.WaitForExit();
                    }
                }
                catch
                {
                    StringBuilder errorDialog = new StringBuilder();
                    errorDialog.Append( "There was an error launching the following server:\n" )
                               .Append( startInfo.FileName )
                               .Append( "\n\n" )
                               .Append( "[Retry]: Attempt to start the same server again.\n" )
                               .Append( "[Cancel]: Cancel attempting to start server." );
                    /*
                    if (MetroMessageBox.Show(this, errorDialog.ToString(), "Error Launching Cleanup Tool", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                    {
                    goto LaunchTool_Retry; //Hacky way retry the method.
                    }
                    */
                }
            }


        }

        //===================================================================================//
        // LAUNCH EXTERNAL PROGRAM AND REDIRECT ITS OUTPUT (DEPRECIATED)                     //
        //===================================================================================//
        public static void RunWithRedirect( string cmdPath )
        {
            /*
            var proc = new Process();
            proc.StartInfo.FileName = cmdPath;

            // set up output redirection
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.EnableRaisingEvents = true;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            // see below for output handler
            proc.ErrorDataReceived += proc_DataReceived;
            proc.OutputDataReceived += proc_DataReceived;

            proc.Start();

            proc.BeginErrorReadLine();
            proc.BeginOutputReadLine();

            proc.WaitForExit();
            */
        }

        public void proc_DataReceived( object sender, DataReceivedEventArgs e )
        {
            // output will be in string e.Data
            //txtboxConsoleOutput.Text = e.Data;
        }
    }
}
