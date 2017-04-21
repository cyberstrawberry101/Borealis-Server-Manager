using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Borealis
{
    public partial class TAB_DASHBOARD : Form
    {
        private readonly System_Monitoring _systemMonitoring;

        public TAB_DASHBOARD()
        {
            this.InitializeComponent();
            this._systemMonitoring = new System_Monitoring();
        }

        public void RefreshData()
        {
            //Pull all gameserver data from gameservers.json, split all json strings into a list, iterate through that list for specific data.
            if (GameServer_Management.server_collection != null)
            {
                if (GameServer_Management.server_collection.Count != 0)
                {
                    this.overallServerStatsGrid.Rows.Clear();
                    foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
                    {
                        this.overallServerStatsGrid.Rows.Add(gameserver.SERVER_name_friendly, gameserver.SERVER_type, "0.0GB", "0.0GB", "0.0%", "0 Kb/s", gameserver.SERVER_running_status, "No");
                    }

                    this.overallServerStatsGrid.Visible = true; //Show Table only if values have been added.
                }
                else
                {
                    this.overallServerStatsGrid.Visible = false; //Hide Table
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
            this.backgroundMetrics.RunWorkerAsync();
        }

        //===================================================================================//
        // DASHBOARD:                                                                        //
        //===================================================================================//
        private DashboardInfo GetInfo()
        {

            var dashboardInfo = new DashboardInfo
            {
                TotalRAM = this._systemMonitoring.RetreiveTotalAvailableRAM(),
                RAM = this._systemMonitoring.RetreiveTotalAvailableRAM() - this._systemMonitoring.RetreiveFreeRAM(),
                DiskUsed = this._systemMonitoring.RetrieveDISKInfo(@"C:\", false, true, false),
                DiskTotal = this._systemMonitoring.RetrieveDISKInfo(@"C:\", true, false, false),
                CPU = this._systemMonitoring.RetrieveCPUUsage(),
                LAN_DOWN = this._systemMonitoring.RetrieveLANUsage(true, false),
                LAN_UP = this._systemMonitoring.RetrieveLANUsage(false, true)
            };

            return dashboardInfo;
        }

        private void backgroundMetrics_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;

            while (!worker.CancellationPending)
            {
                DashboardInfo dashboardInfo = this.GetInfo();
                worker.ReportProgress(0, dashboardInfo);

                Thread.Sleep(500);
            }
        }

        private void RefreshUI(DashboardInfo info)
        {
            if (info == null)
                return;

            this.progressRAMUsage.Value = (int)((info.RAM / (double)info.TotalRAM) * 100);
            this.lblDetailedRAMUsage.Text = string.Format("{0:0.00} GB / {1:0.00} GB", info.RAM / 1024.0, info.TotalRAM / 1024.0);

            this.progressDISKUsage.Value = (int)(info.DiskUsed / info.DiskTotal * 100);
            this.lblDetailedDISKUsage.Text = string.Format("{0:0.00} GB / {1:0.00} GB", info.DiskUsed, info.DiskTotal);

            this.progressCPUUsage.Value = (int)(info.CPU);
            this.lblDetailedCPUUsage.Text = string.Format("{0}% @ {1}-Cores", info.CPU, Environment.ProcessorCount);

            this.progressLANUsage.Value = (int)(info.LAN_DOWN); //PLACEHOLDER 0 Kb/s RX / 0 Kb/s TX
            this.lblDetailedLANUsage.Text = string.Format("{0} Kb/s TX {1} Kb/s RX", Convert.ToString(info.LAN_UP), Convert.ToString(info.LAN_DOWN));
        }

        private void backgroundMetrics_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.RefreshUI(e.UserState as DashboardInfo);
        }

        private void ServerDashboard_Activated(object sender, EventArgs e)
        {
            this.RefreshData();
        }
    }
}