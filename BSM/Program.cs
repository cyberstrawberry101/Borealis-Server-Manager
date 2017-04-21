using System;
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
            ConfigureExceptionHandling();

            Log.Information("Starting Borealis Server Manager {version} at {time}", Application.ProductVersion, DateTime.Now);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BorealisServerManager());

            Log.Information("Borealis Server Manager stopping.");
        }

        private static void ConfigureLogging()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose() // For now
                .WriteTo.Trace()
                .WriteTo.File("Borealis-log.txt")
                .CreateLogger();
        }

        private static void ConfigureExceptionHandling()
        {
            Application.ThreadException += (sender, args) =>
            {
                Log.Fatal(args.Exception, "Unhandled exception occurred in the main UI thread");
            };

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                var exception = args.ExceptionObject as Exception;
                if (exception == null)
                {
                    Log.Fatal("Unknown exception type was passed to the app domain exception handler.");
                    return;
                }

                Log.Fatal(exception, "Unhandled exception occurred");
            };
        }
    }
}
