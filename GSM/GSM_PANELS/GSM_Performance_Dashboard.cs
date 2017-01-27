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
            backgroundMetrics.RunWorkerAsync();
        }

        private void backgroundMetrics_DoWork(object sender, DoWorkEventArgs e)
        {
            //Instance Function from MonitoringFunctions Class
            GSM_MonitoringFunctions Monitoring_Instance = new GSM_MonitoringFunctions();
            BackgroundWorker worker = (BackgroundWorker)sender;
            //while (!worker.CancellationPending)
            //{
                //Task.Delay(1000);

                BeginInvoke((MethodInvoker)delegate
                {
                    //RAM USAGE
                    //progressRAMUsage.Value = Convert.ToInt32(Monitoring_Instance.RetrieveRAMUsage(true, false));
                    //lblDetailedRAMUsage.Text = Convert.ToString(Monitoring_Instance.RetrieveRAMUsage(true, false));

                    //STORAGE USAGE
                    progressDISKUsage.Value = Convert.ToInt32(Monitoring_Instance.RetrieveDISKInfo("C:\\", false, false, true, false));
                    lblDetailedDISKUsage.Text = Convert.ToString(Monitoring_Instance.RetrieveDISKInfo("C:\\", false, true, false, false) + "GB" + " / " + Monitoring_Instance.RetrieveDISKInfo("C:\\", true, false, false, false) + "GB");

                    //CPU USAGE
                    progressCPUUsage.Value = Monitoring_Instance.RetrieveCPUUsage(true, false);
                    lblDetailedCPUUsage.Text = Convert.ToString(Monitoring_Instance.RetrieveCPUUsage(true, false) + "%" + " @ " + Environment.ProcessorCount + "-Cores");
                });
                //worker.ReportProgress(0, "AN OBJECT TO PASS TO THE UI-THREAD");
            //}


            
        }
    }
}
