namespace Borealis
{
    partial class TAB_DASHBOARD
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAB_DASHBOARD));
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
            this.columnServerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressLANUsage = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDetailedLANUsage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.overallServerStatsGrid)).BeginInit();
            this.panelMemoryUsage.SuspendLayout();
            this.panelDiskUsage.SuspendLayout();
            this.panelCPUUsage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDetailedCPUUsage
            // 
            this.lblDetailedCPUUsage.AutoSize = true;
            this.lblDetailedCPUUsage.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailedCPUUsage.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblDetailedCPUUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblDetailedCPUUsage.Location = new System.Drawing.Point(34, 166);
            this.lblDetailedCPUUsage.Name = "lblDetailedCPUUsage";
            this.lblDetailedCPUUsage.Size = new System.Drawing.Size(106, 19);
            this.lblDetailedCPUUsage.TabIndex = 57;
            this.lblDetailedCPUUsage.Text = "Gathering Data...";
            this.lblDetailedCPUUsage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCPUUsage
            // 
            this.lblCPUUsage.AutoSize = true;
            this.lblCPUUsage.BackColor = System.Drawing.Color.Transparent;
            this.lblCPUUsage.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCPUUsage.Location = new System.Drawing.Point(21, 134);
            this.lblCPUUsage.Name = "lblCPUUsage";
            this.lblCPUUsage.Size = new System.Drawing.Size(128, 32);
            this.lblCPUUsage.TabIndex = 56;
            this.lblCPUUsage.Text = "CPU Usage";
            this.toolTip1.SetToolTip(this.lblCPUUsage, "Overall system CPU usage.");
            // 
            // lblDetailedDISKUsage
            // 
            this.lblDetailedDISKUsage.AutoSize = true;
            this.lblDetailedDISKUsage.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailedDISKUsage.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblDetailedDISKUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblDetailedDISKUsage.Location = new System.Drawing.Point(17, 165);
            this.lblDetailedDISKUsage.Name = "lblDetailedDISKUsage";
            this.lblDetailedDISKUsage.Size = new System.Drawing.Size(106, 19);
            this.lblDetailedDISKUsage.TabIndex = 54;
            this.lblDetailedDISKUsage.Text = "Gathering Data...";
            this.lblDetailedDISKUsage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDISKUsage
            // 
            this.lblDISKUsage.AutoSize = true;
            this.lblDISKUsage.BackColor = System.Drawing.Color.Transparent;
            this.lblDISKUsage.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDISKUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDISKUsage.Location = new System.Drawing.Point(24, 134);
            this.lblDISKUsage.Name = "lblDISKUsage";
            this.lblDISKUsage.Size = new System.Drawing.Size(125, 32);
            this.lblDISKUsage.TabIndex = 53;
            this.lblDISKUsage.Text = "Disk Usage";
            this.toolTip1.SetToolTip(this.lblDISKUsage, "Overall system disk usage.");
            // 
            // lblDetailedRAMUsage
            // 
            this.lblDetailedRAMUsage.AutoSize = true;
            this.lblDetailedRAMUsage.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailedRAMUsage.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblDetailedRAMUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblDetailedRAMUsage.Location = new System.Drawing.Point(26, 166);
            this.lblDetailedRAMUsage.Name = "lblDetailedRAMUsage";
            this.lblDetailedRAMUsage.Size = new System.Drawing.Size(106, 19);
            this.lblDetailedRAMUsage.TabIndex = 51;
            this.lblDetailedRAMUsage.Text = "Gathering Data...";
            this.lblDetailedRAMUsage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRAMUsage
            // 
            this.lblRAMUsage.AutoSize = true;
            this.lblRAMUsage.BackColor = System.Drawing.Color.Transparent;
            this.lblRAMUsage.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAMUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblRAMUsage.Location = new System.Drawing.Point(3, 134);
            this.lblRAMUsage.Name = "lblRAMUsage";
            this.lblRAMUsage.Size = new System.Drawing.Size(169, 32);
            this.lblRAMUsage.TabIndex = 50;
            this.lblRAMUsage.Text = "Memory Usage";
            this.toolTip1.SetToolTip(this.lblRAMUsage, "Overall system memory usage.");
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 42);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(261, 19);
            this.bunifuCustomLabel5.TabIndex = 47;
            this.bunifuCustomLabel5.Text = "List gameserver system metrics at a glance.";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(10, 10);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(260, 32);
            this.bunifuCustomLabel2.TabIndex = 46;
            this.bunifuCustomLabel2.Text = "Performance Dashboard";
            // 
            // overallServerStatsGrid
            // 
            this.overallServerStatsGrid.AllowUserToAddRows = false;
            this.overallServerStatsGrid.AllowUserToDeleteRows = false;
            this.overallServerStatsGrid.AllowUserToOrderColumns = true;
            this.overallServerStatsGrid.AllowUserToResizeColumns = false;
            this.overallServerStatsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.overallServerStatsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.overallServerStatsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.overallServerStatsGrid.BackgroundColor = System.Drawing.Color.White;
            this.overallServerStatsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.overallServerStatsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.overallServerStatsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.overallServerStatsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overallServerStatsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnGameServerName,
            this.columnServerType,
            this.columnGameServerRAM,
            this.columnGameServerDISK,
            this.columnGameServerCPU,
            this.columnNetworkUsage,
            this.columnStatus,
            this.columnRestartFlag});
            this.overallServerStatsGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.overallServerStatsGrid.DefaultCellStyle = dataGridViewCellStyle13;
            this.overallServerStatsGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.overallServerStatsGrid.DoubleBuffered = false;
            this.overallServerStatsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.overallServerStatsGrid.EnableHeadersVisualStyles = false;
            this.overallServerStatsGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.overallServerStatsGrid.HeaderForeColor = System.Drawing.Color.White;
            this.overallServerStatsGrid.Location = new System.Drawing.Point(0, 288);
            this.overallServerStatsGrid.MaximumSize = new System.Drawing.Size(0, 269);
            this.overallServerStatsGrid.MultiSelect = false;
            this.overallServerStatsGrid.Name = "overallServerStatsGrid";
            this.overallServerStatsGrid.ReadOnly = true;
            this.overallServerStatsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.overallServerStatsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.overallServerStatsGrid.RowHeadersVisible = false;
            this.overallServerStatsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.overallServerStatsGrid.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.overallServerStatsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.overallServerStatsGrid.ShowCellToolTips = false;
            this.overallServerStatsGrid.ShowEditingIcon = false;
            this.overallServerStatsGrid.Size = new System.Drawing.Size(725, 269);
            this.overallServerStatsGrid.TabIndex = 43;
            this.toolTip1.SetToolTip(this.overallServerStatsGrid, "This is where all of your deployed gameservers will be listed with their configur" +
        "ed properties.");
            // 
            // columnGameServerName
            // 
            this.columnGameServerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnGameServerName.HeaderText = "Friendly Name";
            this.columnGameServerName.Name = "columnGameServerName";
            this.columnGameServerName.ReadOnly = true;
            this.columnGameServerName.ToolTipText = "The user-given friendly-name of the gameserver";
            // 
            // columnServerType
            // 
            this.columnServerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnServerType.HeaderText = "Server Type";
            this.columnServerType.Name = "columnServerType";
            this.columnServerType.ReadOnly = true;
            this.columnServerType.ToolTipText = "The classification of server, such as Garry\'s Mod";
            this.columnServerType.Width = 90;
            // 
            // columnGameServerRAM
            // 
            this.columnGameServerRAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnGameServerRAM.HeaderText = "Memory";
            this.columnGameServerRAM.Name = "columnGameServerRAM";
            this.columnGameServerRAM.ReadOnly = true;
            this.columnGameServerRAM.ToolTipText = "How much RAM the gameserver is currently utilizing";
            this.columnGameServerRAM.Width = 75;
            // 
            // columnGameServerDISK
            // 
            this.columnGameServerDISK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnGameServerDISK.HeaderText = "Disk";
            this.columnGameServerDISK.Name = "columnGameServerDISK";
            this.columnGameServerDISK.ReadOnly = true;
            this.columnGameServerDISK.ToolTipText = "How much disk activity the gameserver is currently utilizing";
            this.columnGameServerDISK.Width = 52;
            // 
            // columnGameServerCPU
            // 
            this.columnGameServerCPU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnGameServerCPU.HeaderText = "CPU";
            this.columnGameServerCPU.Name = "columnGameServerCPU";
            this.columnGameServerCPU.ReadOnly = true;
            this.columnGameServerCPU.ToolTipText = "How much CPU the gameserver is currently utilizing";
            this.columnGameServerCPU.Width = 53;
            // 
            // columnNetworkUsage
            // 
            this.columnNetworkUsage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnNetworkUsage.HeaderText = "Network";
            this.columnNetworkUsage.Name = "columnNetworkUsage";
            this.columnNetworkUsage.ReadOnly = true;
            this.columnNetworkUsage.ToolTipText = "How much incoming and outgoing bandwidth the gameserver is using";
            this.columnNetworkUsage.Width = 75;
            // 
            // columnStatus
            // 
            this.columnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnStatus.HeaderText = "Running";
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.ReadOnly = true;
            this.columnStatus.ToolTipText = "Determines if the server is currently running or stopped";
            this.columnStatus.Width = 75;
            // 
            // columnRestartFlag
            // 
            this.columnRestartFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnRestartFlag.HeaderText = "Auto-Restart";
            this.columnRestartFlag.Name = "columnRestartFlag";
            this.columnRestartFlag.ReadOnly = true;
            this.columnRestartFlag.ToolTipText = "Determines if the server is configured to be automatically re-launched if it cras" +
    "hes";
            this.columnRestartFlag.Width = 97;
            // 
            // backgroundMetrics
            // 
            this.backgroundMetrics.WorkerReportsProgress = true;
            this.backgroundMetrics.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundMetrics_DoWork);
            this.backgroundMetrics.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundMetrics_ProgressChanged);
            // 
            // panelMemoryUsage
            // 
            this.panelMemoryUsage.BackColor = System.Drawing.Color.Transparent;
            this.panelMemoryUsage.Controls.Add(this.progressRAMUsage);
            this.panelMemoryUsage.Controls.Add(this.lblDetailedRAMUsage);
            this.panelMemoryUsage.Controls.Add(this.lblRAMUsage);
            this.panelMemoryUsage.Location = new System.Drawing.Point(11, 68);
            this.panelMemoryUsage.Name = "panelMemoryUsage";
            this.panelMemoryUsage.Size = new System.Drawing.Size(171, 188);
            this.panelMemoryUsage.TabIndex = 61;
            // 
            // progressRAMUsage
            // 
            this.progressRAMUsage.animated = true;
            this.progressRAMUsage.animationIterval = 1;
            this.progressRAMUsage.animationSpeed = 60;
            this.progressRAMUsage.BackColor = System.Drawing.Color.Transparent;
            this.progressRAMUsage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressRAMUsage.BackgroundImage")));
            this.progressRAMUsage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressRAMUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.progressRAMUsage.LabelVisible = true;
            this.progressRAMUsage.LineProgressThickness = 8;
            this.progressRAMUsage.LineThickness = 5;
            this.progressRAMUsage.Location = new System.Drawing.Point(15, 1);
            this.progressRAMUsage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressRAMUsage.MaxValue = 100;
            this.progressRAMUsage.Name = "progressRAMUsage";
            this.progressRAMUsage.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(189)))), ((int)(((byte)(192)))));
            this.progressRAMUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressRAMUsage.Size = new System.Drawing.Size(140, 140);
            this.progressRAMUsage.TabIndex = 49;
            this.progressRAMUsage.Value = 0;
            // 
            // panelDiskUsage
            // 
            this.panelDiskUsage.BackColor = System.Drawing.Color.Transparent;
            this.panelDiskUsage.Controls.Add(this.progressDISKUsage);
            this.panelDiskUsage.Controls.Add(this.lblDISKUsage);
            this.panelDiskUsage.Controls.Add(this.lblDetailedDISKUsage);
            this.panelDiskUsage.Location = new System.Drawing.Point(188, 68);
            this.panelDiskUsage.Name = "panelDiskUsage";
            this.panelDiskUsage.Size = new System.Drawing.Size(171, 188);
            this.panelDiskUsage.TabIndex = 62;
            // 
            // progressDISKUsage
            // 
            this.progressDISKUsage.animated = true;
            this.progressDISKUsage.animationIterval = 1;
            this.progressDISKUsage.animationSpeed = 60;
            this.progressDISKUsage.BackColor = System.Drawing.Color.Transparent;
            this.progressDISKUsage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressDISKUsage.BackgroundImage")));
            this.progressDISKUsage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressDISKUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.progressDISKUsage.LabelVisible = true;
            this.progressDISKUsage.LineProgressThickness = 8;
            this.progressDISKUsage.LineThickness = 5;
            this.progressDISKUsage.Location = new System.Drawing.Point(15, 1);
            this.progressDISKUsage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressDISKUsage.MaxValue = 100;
            this.progressDISKUsage.Name = "progressDISKUsage";
            this.progressDISKUsage.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(189)))), ((int)(((byte)(192)))));
            this.progressDISKUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressDISKUsage.Size = new System.Drawing.Size(140, 140);
            this.progressDISKUsage.TabIndex = 52;
            this.progressDISKUsage.Value = 0;
            // 
            // panelCPUUsage
            // 
            this.panelCPUUsage.BackColor = System.Drawing.Color.Transparent;
            this.panelCPUUsage.Controls.Add(this.progressCPUUsage);
            this.panelCPUUsage.Controls.Add(this.lblCPUUsage);
            this.panelCPUUsage.Controls.Add(this.lblDetailedCPUUsage);
            this.panelCPUUsage.Location = new System.Drawing.Point(365, 68);
            this.panelCPUUsage.Name = "panelCPUUsage";
            this.panelCPUUsage.Size = new System.Drawing.Size(171, 188);
            this.panelCPUUsage.TabIndex = 62;
            // 
            // progressCPUUsage
            // 
            this.progressCPUUsage.animated = true;
            this.progressCPUUsage.animationIterval = 1;
            this.progressCPUUsage.animationSpeed = 60;
            this.progressCPUUsage.BackColor = System.Drawing.Color.Transparent;
            this.progressCPUUsage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressCPUUsage.BackgroundImage")));
            this.progressCPUUsage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressCPUUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.progressCPUUsage.LabelVisible = true;
            this.progressCPUUsage.LineProgressThickness = 8;
            this.progressCPUUsage.LineThickness = 5;
            this.progressCPUUsage.Location = new System.Drawing.Point(15, 1);
            this.progressCPUUsage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressCPUUsage.MaxValue = 100;
            this.progressCPUUsage.Name = "progressCPUUsage";
            this.progressCPUUsage.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(189)))), ((int)(((byte)(192)))));
            this.progressCPUUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressCPUUsage.Size = new System.Drawing.Size(140, 140);
            this.progressCPUUsage.TabIndex = 55;
            this.progressCPUUsage.Value = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.progressLANUsage);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.lblDetailedLANUsage);
            this.panel1.Location = new System.Drawing.Point(542, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 188);
            this.panel1.TabIndex = 63;
            // 
            // progressLANUsage
            // 
            this.progressLANUsage.animated = true;
            this.progressLANUsage.animationIterval = 1;
            this.progressLANUsage.animationSpeed = 60;
            this.progressLANUsage.BackColor = System.Drawing.Color.Transparent;
            this.progressLANUsage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressLANUsage.BackgroundImage")));
            this.progressLANUsage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLANUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.progressLANUsage.LabelVisible = true;
            this.progressLANUsage.LineProgressThickness = 8;
            this.progressLANUsage.LineThickness = 5;
            this.progressLANUsage.Location = new System.Drawing.Point(16, 1);
            this.progressLANUsage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.progressLANUsage.MaxValue = 100;
            this.progressLANUsage.Name = "progressLANUsage";
            this.progressLANUsage.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(189)))), ((int)(((byte)(192)))));
            this.progressLANUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressLANUsage.Size = new System.Drawing.Size(140, 140);
            this.progressLANUsage.TabIndex = 55;
            this.progressLANUsage.Value = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(22, 134);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(128, 32);
            this.bunifuCustomLabel1.TabIndex = 56;
            this.bunifuCustomLabel1.Text = "LAN Usage";
            this.toolTip1.SetToolTip(this.bunifuCustomLabel1, "Overall system network usage.");
            // 
            // lblDetailedLANUsage
            // 
            this.lblDetailedLANUsage.AutoSize = true;
            this.lblDetailedLANUsage.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailedLANUsage.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblDetailedLANUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblDetailedLANUsage.Location = new System.Drawing.Point(18, 165);
            this.lblDetailedLANUsage.Name = "lblDetailedLANUsage";
            this.lblDetailedLANUsage.Size = new System.Drawing.Size(133, 19);
            this.lblDetailedLANUsage.TabIndex = 57;
            this.lblDetailedLANUsage.Text = "0 Kb/s RX / 0 Kb/s TX";
            this.lblDetailedLANUsage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // TAB_DASHBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.BackgroundImage = global::Borealis_Default_Namespace.Properties.Resources.backdrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDiskUsage);
            this.Controls.Add(this.panelCPUUsage);
            this.Controls.Add(this.panelMemoryUsage);
            this.Controls.Add(this.overallServerStatsGrid);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TAB_DASHBOARD";
            this.Text = "ServerDashboard";
            this.Activated += new System.EventHandler(this.ServerDashboard_Activated);
            this.Load += new System.EventHandler(this.GSM_Performance_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.overallServerStatsGrid)).EndInit();
            this.panelMemoryUsage.ResumeLayout(false);
            this.panelMemoryUsage.PerformLayout();
            this.panelDiskUsage.ResumeLayout(false);
            this.panelDiskUsage.PerformLayout();
            this.panelCPUUsage.ResumeLayout(false);
            this.panelCPUUsage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressLANUsage;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDetailedLANUsage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGameServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnServerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGameServerRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGameServerDISK;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGameServerCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNetworkUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRestartFlag;
    }
}