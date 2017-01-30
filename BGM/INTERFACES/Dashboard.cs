using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;

namespace GameServer_Manager
{
    public partial class GSM_Performance_Dashboard : Form
    {
        public GSM_Performance_Dashboard()
        {
            InitializeComponent();
        }

        private void GSM_Performance_Dashboard_Load(object sender, EventArgs e)
        {
            GSM_MonitoringFunctions Monitoring_Instance = new GSM_MonitoringFunctions();
            //OVERALL RAM USAGE
            //progressRAMUsage.Value = Convert.ToInt32(Monitoring_Instance.RetrieveRAMUsage(true, false));
            //lblDetailedRAMUsage.Text = Convert.ToString(Monitoring_Instance.RetrieveRAMUsage(true, false));

            //OVERALL STORAGE USAGE
            progressDISKUsage.Value = Convert.ToInt32(Monitoring_Instance.RetrieveDISKInfo(@"C:\", false, false, true, false));
            lblDetailedDISKUsage.Text = Convert.ToString(Monitoring_Instance.RetrieveDISKInfo(@"C:\", false, true, false, false) + "GB" + " / " + Monitoring_Instance.RetrieveDISKInfo("C:\\", true, false, false, false) + "GB");

            //OVERALL CPU USAGE
            //progressCPUUsage.Value = Monitoring_Instance.RetrieveCPUUsage(true, false);
            //lblDetailedCPUUsage.Text = Convert.ToString(Monitoring_Instance.RetrieveCPUUsage(true, false) + "%" + " @ " + Environment.ProcessorCount + "-Cores");

            //backgroundMetrics.RunWorkerAsync(); //DISABLED FOR NOW

            // PLACEHOLDER DATA /////////////////////////////////////////////////////////////////////////////
            overallServerStatsGrid.Rows.Add("TestServer01", "1.0GB", "2.00GB", "5.0%", "15 Kb/s", "Running");
            overallServerStatsGrid.Rows.Add("TestServer02", "3.0GB", "5.00GB", "2.0%", "56 Kb/s", "Running");
            overallServerStatsGrid.Rows.Add("TestServer03", "0.0GB", "3.1GB", "0.0%", "0 Kb/s", "Stopped");
            overallServerStatsGrid.Rows.Add("TestServer04", "4.0GB", "8.2GB", "13.0%", "572 Kb/s", "Running");
            overallServerStatsGrid.Rows.Add("TestServer05", "0.0GB", "5.9GB", "0.0%", "0 Kb/s", "Stopped");
            // PLACEHOLDER DATA /////////////////////////////////////////////////////////////////////////////
        }

        private void backgroundMetrics_DoWork(object sender, DoWorkEventArgs e)
        {
            //Instance Function from MonitoringFunctions Class
            //GSM_MonitoringFunctions Monitoring_Instance = new GSM_MonitoringFunctions();
            //BackgroundWorker worker = (BackgroundWorker)sender;
            //while (!worker.CancellationPending)
            //{
                //Task.Delay(1000);

                //BeginInvoke((MethodInvoker)delegate
                //{
                    //BACKGROUNDWORKER CODE
                //});
                //worker.ReportProgress(0, "AN OBJECT TO PASS TO THE UI-THREAD");
            //} 
        }
    }
}
