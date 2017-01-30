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
        public static void LaunchExternalProgram(string argProgramName, string argParameters, bool argFullManualPath, bool argRedirectOutput)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;


            if (argFullManualPath == true)  //Pass ENTIRE PATH from argument.
            {
                startInfo.FileName = argProgramName;
            }
            else  //Let Method PREPEND the CurrentDirectory to path argument 
            {
                startInfo.FileName = Environment.CurrentDirectory + argProgramName;
            }

            if (argRedirectOutput == true)  //Redirect Output to somewhere else.
            {
                startInfo.FileName = argProgramName;
                startInfo.UseShellExecute = false; //Redirect the programs.
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            }
            else  //No not redirect output somewhere else
            {
                startInfo.FileName = Environment.CurrentDirectory + argProgramName;
                startInfo.UseShellExecute = true; //Execute the programs.
                startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            }

            startInfo.Arguments = argParameters;
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
                           .Append("[Retry]: Attempt to run the same server again.\n")
                           .Append("[Cancel]: Cancel attempting to run server.");
                //if (MetroMessageBox.Show(this, errorDialog.ToString(), "Error Launching Cleanup Tool", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                //{
                //    goto LaunchTool_Retry; //Hacky way retry the method.
                //}
            }
        }
        

    }


}
