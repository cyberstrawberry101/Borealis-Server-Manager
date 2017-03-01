using System.Diagnostics;

namespace Borealis
{
    public class Execution_Classes
    {
        //===================================================================================//
        // LAUNCH EXTERNAL PROGRAM WITH GIVEN ARGUMENTS                                      //
        //===================================================================================//
        public static void Execute(string argProgramName, string argParameters)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.Arguments = argParameters;
            startInfo.FileName = argProgramName;
            startInfo.UseShellExecute = true;

            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }  
        }
    }
}
