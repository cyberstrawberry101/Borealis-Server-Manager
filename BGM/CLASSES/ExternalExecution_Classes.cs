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

namespace GameServer_Manager
{
    public class ExternalExecution_Classes
    {
        //===================================================================================//
        // LAUNCH EXTERNAL PROGRAM WITH GIVEN ARGUMENTS                                      //
        //===================================================================================//
        public static void LaunchExternalProgram(string argProgramName, string argParameters, bool argRedirectOutput)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = argParameters;
            startInfo.FileName = argProgramName;

            if (argRedirectOutput == true)  //Redirect Output to somewhere else.
            {
                startInfo.UseShellExecute = false; //Redirect the programs.
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                try
                {
                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        exeProcess.WaitForExit();
                    }
                }
                catch
                {
                    StringBuilder errorDialog = new StringBuilder();
                    errorDialog.Append("There was an error launching the following server:\n")
                               .Append(startInfo.FileName)
                               .Append("\n\n")
                               .Append("[Retry]: Attempt to start the same server again.\n")
                               .Append("[Cancel]: Cancel attempting to start server.");
                    //if (MetroMessageBox.Show(this, errorDialog.ToString(), "Error Launching Cleanup Tool", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                    //{
                    //    goto LaunchTool_Retry; //Hacky way retry the method.
                    //}
                }
            }
            else  //No not redirect output somewhere else
            {
                startInfo.UseShellExecute = true; //Execute the programs.
                startInfo.WindowStyle = ProcessWindowStyle.Hidden; //DEBUG, DISABLED FOR NOW

                try
                {
                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        exeProcess.WaitForExit();
                    }
                }
                catch
                {
                    StringBuilder errorDialog = new StringBuilder();
                    errorDialog.Append("There was an error launching the following server:\n")
                               .Append(startInfo.FileName)
                               .Append("\n\n")
                               .Append("[Retry]: Attempt to start the same server again.\n")
                               .Append("[Cancel]: Cancel attempting to start server.");
                    //if (MetroMessageBox.Show(this, errorDialog.ToString(), "Error Launching Cleanup Tool", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                    //{
                    //    goto LaunchTool_Retry; //Hacky way retry the method.
                    //}
                }
            }

            
        }
        

    }


}
