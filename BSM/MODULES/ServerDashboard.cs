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
using System.Threading;

namespace Borealis
{
    public partial class ServerDashboard : Form
    {
        private DashboardInfo _dashboardInfo;

        public ServerDashboard()
        {
            InitializeComponent();
            _dashboardInfo = new DashboardInfo();
        }

        //===================================================================================//
        // PANEL STARTUP                                                                     //
        //===================================================================================//
        private void GSM_Performance_Dashboard_Load(object sender, EventArgs e)
        {
            _dashboardInfo = GetInfo();
            RefreshUI(_dashboardInfo);

            backgroundMetrics.RunWorkerAsync(); //DISABLED FOR NOW

            // PLACEHOLDER DATA /////////////////////////////////////////////////////////////////////////////
            overallServerStatsGrid.Rows.Add("TestServer01", "1.0GB", "2.00GB", "5.0%", "15 Kb/s", "Running", "Yes");
            overallServerStatsGrid.Rows.Add("TestServer02", "3.0GB", "5.00GB", "2.0%", "56 Kb/s", "Running", "Yes");
            overallServerStatsGrid.Rows.Add("TestServer03", "0.0GB", "3.1GB", "0.0%", "0 Kb/s", "Stopped", "No");
            overallServerStatsGrid.Rows.Add("TestServer04", "4.0GB", "8.2GB", "13.0%", "572 Kb/s", "Running", "Yes");
            overallServerStatsGrid.Rows.Add("TestServer05", "0.0GB", "5.9GB", "0.0%", "0 Kb/s", "Stopped", "No");
            // PLACEHOLDER DATA /////////////////////////////////////////////////////////////////////////////
        }

        //===================================================================================//
        // BACKGROUNDWORKER TO COLLECT SYSTEM METRICS                                        //
        //===================================================================================//
        private void backgroundMetrics_DoWork(object sender, DoWorkEventArgs e)
        {
            //Instance Function from MonitoringFunctions Class

            BackgroundWorker worker = (BackgroundWorker)sender;
            while (!worker.CancellationPending)
            {
                Thread.Sleep(10);
                _dashboardInfo = GetInfo();
                worker.ReportProgress(0, "AN OBJECT TO PASS TO THE UI-THREAD");
            }
        }

        private void RefreshUI(DashboardInfo info)
        {
            progressRAMUsage.Value = (int)((info.RAM / (double)info.TotalRAM) * 100);
            lblDetailedRAMUsage.Text = string.Format("{0:0.00} GB / {1:0.00} GB", info.RAM / 1024.0, info.TotalRAM / 1024.0);

            progressDISKUsage.Value = (int)(info.DiskUsed / info.DiskTotal * 100);
            lblDetailedDISKUsage.Text = string.Format("{0:0.00} GB / {1:0.00} GB", info.DiskUsed, info.DiskTotal);

            progressCPUUsage.Value = (int)(info.CPU);
            lblDetailedCPUUsage.Text = string.Format("{0}% @ {1}-Cores", info.CPU, Environment.ProcessorCount);
        }

        private DashboardInfo GetInfo()
        {
            var monitoring = new MonitoringFunctions();
            var rtn = new DashboardInfo();
            rtn.TotalRAM = monitoring.RetreiveTotalAvailableRAM();
            rtn.RAM = monitoring.RetreiveTotalAvailableRAM() - monitoring.RetreiveFreeRAM();
            rtn.DiskUsed = monitoring.RetrieveDISKInfo(@"C:\", false, true, false);
            rtn.DiskTotal = monitoring.RetrieveDISKInfo("C:\\", true, false, false);
            rtn.CPU = monitoring.RetrieveCPUUsage();

            return rtn;
        }

        private void backgroundMetrics_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            RefreshUI(_dashboardInfo);
        }
    }

    public class DashboardInfo
    {
        public long RAM { get; set; }
        public long TotalRAM { get; set; }
        public double DiskUsed { get; set; }
        public double DiskTotal { get; set; }
        public int CPU { get; set; }
    }
}