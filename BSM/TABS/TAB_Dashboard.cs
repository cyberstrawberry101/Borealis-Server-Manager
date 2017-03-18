using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace Borealis
{
    public partial class TAB_DASHBOARD : Form
    {
        private DashboardInfo _dashboardInfo;

        public TAB_DASHBOARD()
        {
            InitializeComponent();
            _dashboardInfo = new DashboardInfo();
        }

        public void RefreshData()
        {
            //Pull all gameserver data from config.json, split all json strings into a list, iterate through that list for specific data.
            if (GameServer_Management.server_collection != null)
            {
                if (GameServer_Management.server_collection.Count != 0)
                {
                    overallServerStatsGrid.Rows.Clear();
                    foreach (Newtonsoft.Json.Linq.JObject gameserver in GameServer_Management.server_collection)
                    {
                        overallServerStatsGrid.Rows.Add((string)gameserver["SERVER_name_friendly"], (string)gameserver["SERVER_type"], "0.0GB", "0.0GB", "0.0%", "0 Kb/s", (bool)gameserver["SERVER_running_status"], "No");
                    }

                    overallServerStatsGrid.Visible = true; //Show Table only if values have been added.
                }
                else
                {
                    overallServerStatsGrid.Visible = false; //Hide Table
                }
            }
        }

        //Class to store dashboard metrics
        public class DashboardInfo
        {
            public long RAM { get; set; }
            public long TotalRAM { get; set; }
            public double DiskUsed { get; set; }
            public double DiskTotal { get; set; }
            public int CPU { get; set; }
            public double LAN_DOWN { get; set; }
            public double LAN_UP { get; set; }
        }

        //===================================================================================//
        // STARTUP:                                                                          //
        //===================================================================================//
        private void GSM_Performance_Dashboard_Load(object sender, EventArgs e)
        {
            _dashboardInfo = GetInfo();
            RefreshUI(_dashboardInfo);
            backgroundMetrics.RunWorkerAsync();
        }

        //===================================================================================//
        // DASHBOARD:                                                                        //
        //===================================================================================//
        private DashboardInfo GetInfo()
        {
            var monitoring = new System_Monitoring();
            var rtn = new DashboardInfo();
            rtn.TotalRAM = monitoring.RetreiveTotalAvailableRAM();
            rtn.RAM = monitoring.RetreiveTotalAvailableRAM() - monitoring.RetreiveFreeRAM();
            rtn.DiskUsed = monitoring.RetrieveDISKInfo(@"C:\", false, true, false);
            rtn.DiskTotal = monitoring.RetrieveDISKInfo(@"C:\", true, false, false);
            rtn.CPU = monitoring.RetrieveCPUUsage();
            rtn.LAN_DOWN = monitoring.RetrieveLANUsage(true, false);
            rtn.LAN_UP = monitoring.RetrieveLANUsage(false, true);

            return rtn;
        }
        private void backgroundMetrics_DoWork(object sender, DoWorkEventArgs e)
        {
            //Instance Function from MonitoringFunctions Class
            var monitoring = new System_Monitoring();
            BackgroundWorker worker = (BackgroundWorker)sender;

            while (!worker.CancellationPending)
            {
                //overallServerStatsGrid.Rows.Clear();
                Thread.Sleep(500);
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

            progressLANUsage.Value = (int)(info.LAN_DOWN); //PLACEHOLDER 0 Kb/s RX / 0 Kb/s TX
            lblDetailedLANUsage.Text = string.Format("{0} Kb/s TX {1} Kb/s RX", Convert.ToString(info.LAN_UP), Convert.ToString(info.LAN_DOWN));
        }
        private void backgroundMetrics_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            RefreshUI(_dashboardInfo);
        }

        private void ServerDashboard_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}