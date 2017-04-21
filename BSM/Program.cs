using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;

namespace Borealis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureLogging();

            Log.Information("Starting Borealis Server Manager {version} at {time}", Application.ProductVersion, DateTime.Now);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BorealisServerManager());
        }

        private static void ConfigureLogging()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose() // For now
                .WriteTo.Trace()
                .WriteTo.File("Borealis-log.txt")
                .CreateLogger();
        }
    }
}
