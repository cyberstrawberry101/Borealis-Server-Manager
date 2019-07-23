using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Borealis
{
    public partial class TAB_DASHBOARD : Form
    {
        private readonly SystemMonitoring _systemMonitoring;

        public TAB_DASHBOARD()
        {
            InitializeComponent();
            _systemMonitoring = new SystemMonitoring();
        }

        public void RefreshData()
        {
            //Pull all gameserver data from gameservers.json, split all json strings into a list, iterate through that list for specific data.
            if (GameServerManagement.ServerCollection != null)
            {
                if (GameServerManagement.ServerCollection.Count != 0)
                {
                    overallServerStatsGrid.Rows.Clear();
                    foreach (GameServerObject gameserver in GameServerManagement.ServerCollection)
                    {
                        var isRunning = ProcessManager.GetProcessByNickname(gameserver.SERVER_name_friendly)?.IsRunning ?? false;
                        overallServerStatsGrid.Rows.Add(gameserver.SERVER_name_friendly, gameserver.SERVER_type, "0.0GB", "0.0GB", "0.0%", "0 Kb/s", isRunning, "No");
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
            backgroundMetrics.RunWorkerAsync();
        }

        //===================================================================================//
        // DASHBOARD:                                                                        //
        //===================================================================================//
        private DashboardInfo GetInfo()
        {

            var dashboardInfo = new DashboardInfo
            {
                TotalRAM = _systemMonitoring.RetreiveTotalAvailableRAM(),
                RAM = _systemMonitoring.RetreiveTotalAvailableRAM() - _systemMonitoring.RetreiveFreeRAM(),
                DiskUsed = _systemMonitoring.RetrieveDISKInfo(@"C:\", false, true, false),
                DiskTotal = _systemMonitoring.RetrieveDISKInfo(@"C:\", true, false, false),
                CPU = _systemMonitoring.RetrieveCPUUsage(),
                LAN_DOWN = _systemMonitoring.RetrieveLANUsage(true, false),
                LAN_UP = _systemMonitoring.RetrieveLANUsage(false, true)
            };

            return dashboardInfo;
        }

        private void backgroundMetrics_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;

            while (!worker.CancellationPending)
            {
                DashboardInfo dashboardInfo = GetInfo();
                worker.ReportProgress(0, dashboardInfo);

                Thread.Sleep(200);
            }
        }

        private void RefreshUI(DashboardInfo info)
        {
            if (info == null)
                return;

            //Animate the color of the RAM progress bar circle.
            if (progressRAMUsage.Value <= 50)
            {
                progressRAMUsage.ProgressColor = Color.FromArgb(67, 181, 129);
            }
            if (progressRAMUsage.Value > 50)
            {
                progressRAMUsage.ProgressColor = Color.FromArgb(231, 145, 50);
            }
            if (progressRAMUsage.Value > 80)
            {
                progressRAMUsage.ProgressColor = Color.FromArgb(191, 45, 66);
            }

            //Animate the color of the CPU progress bar circle.
            if (progressCPUUsage.Value <= 50)
            {
                progressCPUUsage.ProgressColor = Color.FromArgb(67, 181, 129);
            }
            if (progressCPUUsage.Value > 50)
            {
                progressCPUUsage.ProgressColor = Color.FromArgb(231, 145, 50);
            }
            if (progressCPUUsage.Value > 80)
            {
                progressCPUUsage.ProgressColor = Color.FromArgb(191, 45, 66);
            }

            //Animate the color of the DISK progress bar circle.
            if (progressDISKUsage.Value <= 50)
            {
                progressDISKUsage.ProgressColor = Color.FromArgb(67, 181, 129);
            }
            if (progressDISKUsage.Value > 50)
            {
                progressDISKUsage.ProgressColor = Color.FromArgb(231, 145, 50);
            }
            if (progressDISKUsage.Value > 80)
            {
                progressDISKUsage.ProgressColor = Color.FromArgb(191, 45, 66);
            }

            progressRAMUsage.Value = (int)((info.RAM / (double)info.TotalRAM) * 100);
            lblDetailedRAMUsage.Text = string.Format("{0:0.00} GB / {1:0.00} GB", info.RAM / 1024.0, info.TotalRAM / 1024.0);

            progressDISKUsage.Value = (int)(info.DiskUsed / info.DiskTotal * 100);
            lblDetailedDISKUsage.Text = string.Format("{0:0.00} GB / {1:0.00} GB", info.DiskUsed, info.DiskTotal);

            progressCPUUsage.Value = (info.CPU);
            lblDetailedCPUUsage.Text = string.Format("{0}% @ {1}-Cores", info.CPU, Environment.ProcessorCount);

            progressLANUsage.Value = (int)(info.LAN_DOWN); //PLACEHOLDER 0 Kb/s RX / 0 Kb/s TX
            lblDetailedLANUsage.Text = string.Format("{0} Kb/s TX {1} Kb/s RX", info.LAN_UP, info.LAN_DOWN);
        }

        private void backgroundMetrics_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            RefreshUI(e.UserState as DashboardInfo);
        }

        private void ServerDashboard_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}