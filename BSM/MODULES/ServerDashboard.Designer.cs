namespace Borealis
{
    partial class ServerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerDashboard));
            this.lblDetailedCPUUsage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCPUUsage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDetailedDISKUsage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDISKUsage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDetailedRAMUsage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRAMUsage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.overallServerStatsGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.columnGameServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGameServerRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGameServerDISK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGameServerCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNetworkUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRestartFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundMetrics = new System.ComponentModel.BackgroundWorker();
            this.panelMemoryUsage = new System.Windows.Forms.Panel();
            this.progressRAMUsage = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panelDiskUsage = new System.Windows.Forms.Panel();
            this.progressDISKUsage = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panelCPUUsage = new System.Windows.Forms.Panel();
            this.progressCPUUsage = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.overallServerStatsGrid)).BeginInit();
            this.panelMemoryUsage.SuspendLayout();
            this.panelDiskUsage.SuspendLayout();
            this.panelCPUUsage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDetailedCPUUsage
            // 
            this.lblDetailedCPUUsage.AutoSize = true;
            this.lblDetailedCPUUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.lblDetailedCPUUsage.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblDetailedCPUUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblDetailedCPUUsage.Location = new System.Drawing.Point(53, 185);
            this.lblDetailedCPUUsage.Name = "lblDetailedCPUUsage";
            this.lblDetailedCPUUsage.Size = new System.Drawing.Size(95, 19);
            this.lblDetailedCPUUsage.TabIndex = 57;
            this.lblDetailedCPUUsage.Text = "0% @ 0-Cores";
            // 
            // lblCPUUsage
            // 
            this.lblCPUUsage.AutoSize = true;
            this.lblCPUUsage.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCPUUsage.Location = new System.Drawing.Point(40, 151);
            this.lblCPUUsage.Name = "lblCPUUsage";
            this.lblCPUUsage.Size = new System.Drawing.Size(128, 32);
            this.lblCPUUsage.TabIndex = 56;
            this.lblCPUUsage.Text = "CPU Usage";
            // 
            // lblDetailedDISKUsage
            // 
            this.lblDetailedDISKUsage.AutoSize = true;
            this.lblDetailedDISKUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.lblDetailedDISKUsage.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblDetailedDISKUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblDetailedDISKUsage.Location = new System.Drawing.Point(36, 185);
            this.lblDetailedDISKUsage.Name = "lblDetailedDISKUsage";
            this.lblDetailedDISKUsage.Size = new System.Drawing.Size(70, 19);
            this.lblDetailedDISKUsage.TabIndex = 54;
            this.lblDetailedDISKUsage.Text = "0GB / 0GB";
            // 
            // lblDISKUsage
            // 
            this.lblDISKUsage.AutoSize = true;
            this.lblDISKUsage.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDISKUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDISKUsage.Location = new System.Drawing.Point(41, 151);
            this.lblDISKUsage.Name = "lblDISKUsage";
            this.lblDISKUsage.Size = new System.Drawing.Size(125, 32);
            this.lblDISKUsage.TabIndex = 53;
            this.lblDISKUsage.Text = "Disk Usage";
            // 
            // lblDetailedRAMUsage
            // 
            this.lblDetailedRAMUsage.AutoSize = true;
            this.lblDetailedRAMUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.lblDetailedRAMUsage.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblDetailedRAMUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblDetailedRAMUsage.Location = new System.Drawing.Point(37, 185);
            this.lblDetailedRAMUsage.Name = "lblDetailedRAMUsage";
            this.lblDetailedRAMUsage.Size = new System.Drawing.Size(90, 19);
            this.lblDetailedRAMUsage.TabIndex = 51;
            this.lblDetailedRAMUsage.Text = "0.0GB / 0.0GB";
            // 
            // lblRAMUsage
            // 
            this.lblRAMUsage.AutoSize = true;
            this.lblRAMUsage.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAMUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblRAMUsage.Location = new System.Drawing.Point(16, 151);
            this.lblRAMUsage.Name = "lblRAMUsage";
            this.lblRAMUsage.Size = new System.Drawing.Size(169, 32);
            this.lblRAMUsage.TabIndex = 50;
            this.lblRAMUsage.Text = "Memory Usage";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 42);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(224, 19);
            this.bunifuCustomLabel5.TabIndex = 47;
            this.bunifuCustomLabel5.Text = "List performance metrics at a glance.";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(10, 10);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(255, 32);
            this.bunifuCustomLabel2.TabIndex = 46;
            this.bunifuCustomLabel2.Text = "GameServer Dashboard";
            // 
            // overallServerStatsGrid
            // 
            this.overallServerStatsGrid.AllowUserToAddRows = false;
            this.overallServerStatsGrid.AllowUserToDeleteRows = false;
            this.overallServerStatsGrid.AllowUserToOrderColumns = true;
            this.overallServerStatsGrid.AllowUserToResizeColumns = false;
            this.overallServerStatsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.overallServerStatsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.overallServerStatsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.overallServerStatsGrid.BackgroundColor = System.Drawing.Color.White;
            this.overallServerStatsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.overallServerStatsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.overallServerStatsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.overallServerStatsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.overallServerStatsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overallServerStatsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnGameServerName,
            this.columnGameServerRAM,
            this.columnGameServerDISK,
            this.columnGameServerCPU,
            this.columnNetworkUsage,
            this.columnStatus,
            this.columnRestartFlag});
            this.overallServerStatsGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.overallServerStatsGrid.DefaultCellStyle = dataGridViewCellStyle19;
            this.overallServerStatsGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.overallServerStatsGrid.DoubleBuffered = false;
            this.overallServerStatsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.overallServerStatsGrid.EnableHeadersVisualStyles = false;
            this.overallServerStatsGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.overallServerStatsGrid.HeaderForeColor = System.Drawing.Color.White;
            this.overallServerStatsGrid.Location = new System.Drawing.Point(0, 314);
            this.overallServerStatsGrid.MultiSelect = false;
            this.overallServerStatsGrid.Name = "overallServerStatsGrid";
            this.overallServerStatsGrid.ReadOnly = true;
            this.overallServerStatsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.overallServerStatsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.overallServerStatsGrid.RowHeadersVisible = false;
            this.overallServerStatsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.overallServerStatsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.overallServerStatsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.overallServerStatsGrid.ShowCellToolTips = false;
            this.overallServerStatsGrid.ShowEditingIcon = false;
            this.overallServerStatsGrid.Size = new System.Drawing.Size(700, 223);
            this.overallServerStatsGrid.TabIndex = 43;
            // 
            // columnGameServerName
            // 
            this.columnGameServerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnGameServerName.HeaderText = "Name";
            this.columnGameServerName.Name = "columnGameServerName";
            this.columnGameServerName.ReadOnly = true;
            // 
            // columnGameServerRAM
            // 
            this.columnGameServerRAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnGameServerRAM.HeaderText = "Memory";
            this.columnGameServerRAM.Name = "columnGameServerRAM";
            this.columnGameServerRAM.ReadOnly = true;
            // 
            // columnGameServerDISK
            // 
            this.columnGameServerDISK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnGameServerDISK.HeaderText = "Disk";
            this.columnGameServerDISK.Name = "columnGameServerDISK";
            this.columnGameServerDISK.ReadOnly = true;
            // 
            // columnGameServerCPU
            // 
            this.columnGameServerCPU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnGameServerCPU.HeaderText = "CPU";
            this.columnGameServerCPU.Name = "columnGameServerCPU";
            this.columnGameServerCPU.ReadOnly = true;
            // 
            // columnNetworkUsage
            // 
            this.columnNetworkUsage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNetworkUsage.HeaderText = "Network";
            this.columnNetworkUsage.Name = "columnNetworkUsage";
            this.columnNetworkUsage.ReadOnly = true;
            // 
            // columnStatus
            // 
            this.columnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnStatus.HeaderText = "Status";
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.ReadOnly = true;
            // 
            // columnRestartFlag
            // 
            this.columnRestartFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnRestartFlag.HeaderText = "Auto-Restart";
            this.columnRestartFlag.Name = "columnRestartFlag";
            this.columnRestartFlag.ReadOnly = true;
            // 
            // backgroundMetrics
            // 
            this.backgroundMetrics.WorkerReportsProgress = true;
            this.backgroundMetrics.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundMetrics_DoWork);
            this.backgroundMetrics.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundMetrics_ProgressChanged);
            // 
            // panelMemoryUsage
            // 
            this.panelMemoryUsage.Controls.Add(this.progressRAMUsage);
            this.panelMemoryUsage.Controls.Add(this.lblDetailedRAMUsage);
            this.panelMemoryUsage.Controls.Add(this.lblRAMUsage);
            this.panelMemoryUsage.Location = new System.Drawing.Point(23, 68);
            this.panelMemoryUsage.Name = "panelMemoryUsage";
            this.panelMemoryUsage.Size = new System.Drawing.Size(200, 205);
            this.panelMemoryUsage.TabIndex = 61;
            // 
            // progressRAMUsage
            // 
            this.progressRAMUsage.animated = true;
            this.progressRAMUsage.animationIterval = 1;
            this.progressRAMUsage.animationSpeed = 60;
            this.progressRAMUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.progressRAMUsage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressRAMUsage.BackgroundImage")));
            this.progressRAMUsage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressRAMUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.progressRAMUsage.LabelVisible = true;
            this.progressRAMUsage.LineProgressThickness = 8;
            this.progressRAMUsage.LineThickness = 5;
            this.progressRAMUsage.Location = new System.Drawing.Point(23, 1);
            this.progressRAMUsage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.progressRAMUsage.MaxValue = 100;
            this.progressRAMUsage.Name = "progressRAMUsage";
            this.progressRAMUsage.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.progressRAMUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressRAMUsage.Size = new System.Drawing.Size(155, 155);
            this.progressRAMUsage.TabIndex = 49;
            this.progressRAMUsage.Value = 0;
            // 
            // panelDiskUsage
            // 
            this.panelDiskUsage.Controls.Add(this.progressDISKUsage);
            this.panelDiskUsage.Controls.Add(this.lblDISKUsage);
            this.panelDiskUsage.Controls.Add(this.lblDetailedDISKUsage);
            this.panelDiskUsage.Location = new System.Drawing.Point(248, 68);
            this.panelDiskUsage.Name = "panelDiskUsage";
            this.panelDiskUsage.Size = new System.Drawing.Size(200, 205);
            this.panelDiskUsage.TabIndex = 62;
            // 
            // progressDISKUsage
            // 
            this.progressDISKUsage.animated = true;
            this.progressDISKUsage.animationIterval = 1;
            this.progressDISKUsage.animationSpeed = 60;
            this.progressDISKUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.progressDISKUsage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressDISKUsage.BackgroundImage")));
            this.progressDISKUsage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressDISKUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.progressDISKUsage.LabelVisible = true;
            this.progressDISKUsage.LineProgressThickness = 8;
            this.progressDISKUsage.LineThickness = 5;
            this.progressDISKUsage.Location = new System.Drawing.Point(23, 1);
            this.progressDISKUsage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.progressDISKUsage.MaxValue = 100;
            this.progressDISKUsage.Name = "progressDISKUsage";
            this.progressDISKUsage.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.progressDISKUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressDISKUsage.Size = new System.Drawing.Size(155, 155);
            this.progressDISKUsage.TabIndex = 52;
            this.progressDISKUsage.Value = 0;
            // 
            // panelCPUUsage
            // 
            this.panelCPUUsage.Controls.Add(this.progressCPUUsage);
            this.panelCPUUsage.Controls.Add(this.lblCPUUsage);
            this.panelCPUUsage.Controls.Add(this.lblDetailedCPUUsage);
            this.panelCPUUsage.Location = new System.Drawing.Point(472, 68);
            this.panelCPUUsage.Name = "panelCPUUsage";
            this.panelCPUUsage.Size = new System.Drawing.Size(200, 205);
            this.panelCPUUsage.TabIndex = 62;
            // 
            // progressCPUUsage
            // 
            this.progressCPUUsage.animated = true;
            this.progressCPUUsage.animationIterval = 1;
            this.progressCPUUsage.animationSpeed = 60;
            this.progressCPUUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.progressCPUUsage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressCPUUsage.BackgroundImage")));
            this.progressCPUUsage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressCPUUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.progressCPUUsage.LabelVisible = true;
            this.progressCPUUsage.LineProgressThickness = 8;
            this.progressCPUUsage.LineThickness = 5;
            this.progressCPUUsage.Location = new System.Drawing.Point(23, 1);
            this.progressCPUUsage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.progressCPUUsage.MaxValue = 100;
            this.progressCPUUsage.Name = "progressCPUUsage";
            this.progressCPUUsage.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.progressCPUUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressCPUUsage.Size = new System.Drawing.Size(155, 155);
            this.progressCPUUsage.TabIndex = 55;
            this.progressCPUUsage.Value = 0;
            // 
            // ServerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(700, 537);
            this.Controls.Add(this.panelDiskUsage);
            this.Controls.Add(this.panelCPUUsage);
            this.Controls.Add(this.panelMemoryUsage);
            this.Controls.Add(this.overallServerStatsGrid);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServerDashboard";
            this.Text = "GSM_Performance_Dashboard";
            this.Load += new System.EventHandler(this.GSM_Performance_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.overallServerStatsGrid)).EndInit();
            this.panelMemoryUsage.ResumeLayout(false);
            this.panelMemoryUsage.PerformLayout();
            this.panelDiskUsage.ResumeLayout(false);
            this.panelDiskUsage.PerformLayout();
            this.panelCPUUsage.ResumeLayout(false);
            this.panelCPUUsage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblDetailedCPUUsage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCPUUsage;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressCPUUsage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDetailedDISKUsage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDISKUsage;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressDISKUsage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDetailedRAMUsage;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRAMUsage;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressRAMUsage;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid overallServerStatsGrid;
        private System.ComponentModel.BackgroundWorker backgroundMetrics;
        private System.Windows.Forms.Panel panelMemoryUsage;
        private System.Windows.Forms.Panel panelDiskUsage;
        private System.Windows.Forms.Panel panelCPUUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGameServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGameServerRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGameServerDISK;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGameServerCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNetworkUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRestartFlag;
    }
}