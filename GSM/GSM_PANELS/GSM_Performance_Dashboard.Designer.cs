namespace GameServer_Manager
{
    partial class GSM_Performance_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GSM_Performance_Dashboard));
            this.lblDetailedCPUUsage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCPUUsage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDetailedDISKUsage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDISKUsage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDetailedRAMUsage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRAMUsage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.progressCPUUsage = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.progressDISKUsage = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.progressRAMUsage = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuProgressBar3 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.progressbarDownloadProgress = new Bunifu.Framework.UI.BunifuProgressBar();
            this.backgroundMetrics = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDetailedCPUUsage
            // 
            this.lblDetailedCPUUsage.AutoSize = true;
            this.lblDetailedCPUUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.lblDetailedCPUUsage.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblDetailedCPUUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblDetailedCPUUsage.Location = new System.Drawing.Point(535, 254);
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
            this.lblCPUUsage.Location = new System.Drawing.Point(521, 220);
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
            this.lblDetailedDISKUsage.Location = new System.Drawing.Point(303, 254);
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
            this.lblDISKUsage.Location = new System.Drawing.Point(289, 220);
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
            this.lblDetailedRAMUsage.Location = new System.Drawing.Point(63, 254);
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
            this.lblRAMUsage.Location = new System.Drawing.Point(24, 220);
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
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 40);
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
            this.progressCPUUsage.Location = new System.Drawing.Point(506, 68);
            this.progressCPUUsage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.progressCPUUsage.MaxValue = 100;
            this.progressCPUUsage.Name = "progressCPUUsage";
            this.progressCPUUsage.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.progressCPUUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressCPUUsage.Size = new System.Drawing.Size(155, 155);
            this.progressCPUUsage.TabIndex = 55;
            this.progressCPUUsage.Value = 0;
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
            this.progressDISKUsage.Location = new System.Drawing.Point(268, 68);
            this.progressDISKUsage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.progressDISKUsage.MaxValue = 100;
            this.progressDISKUsage.Name = "progressDISKUsage";
            this.progressDISKUsage.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.progressDISKUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressDISKUsage.Size = new System.Drawing.Size(155, 155);
            this.progressDISKUsage.TabIndex = 52;
            this.progressDISKUsage.Value = 0;
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
            this.progressRAMUsage.Location = new System.Drawing.Point(28, 68);
            this.progressRAMUsage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.progressRAMUsage.MaxValue = 100;
            this.progressRAMUsage.Name = "progressRAMUsage";
            this.progressRAMUsage.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.progressRAMUsage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressRAMUsage.Size = new System.Drawing.Size(155, 155);
            this.progressRAMUsage.TabIndex = 49;
            this.progressRAMUsage.Value = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuProgressBar1);
            this.groupBox1.Controls.Add(this.bunifuProgressBar3);
            this.groupBox1.Controls.Add(this.bunifuProgressBar2);
            this.groupBox1.Controls.Add(this.progressbarDownloadProgress);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 225);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detailed Resource Utilization";
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(334, 100);
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.bunifuProgressBar1.Size = new System.Drawing.Size(324, 13);
            this.bunifuProgressBar1.TabIndex = 41;
            this.bunifuProgressBar1.Value = 62;
            // 
            // bunifuProgressBar3
            // 
            this.bunifuProgressBar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.bunifuProgressBar3.BorderRadius = 5;
            this.bunifuProgressBar3.Location = new System.Drawing.Point(334, 75);
            this.bunifuProgressBar3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuProgressBar3.MaximumValue = 100;
            this.bunifuProgressBar3.Name = "bunifuProgressBar3";
            this.bunifuProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.bunifuProgressBar3.Size = new System.Drawing.Size(324, 13);
            this.bunifuProgressBar3.TabIndex = 40;
            this.bunifuProgressBar3.Value = 85;
            // 
            // bunifuProgressBar2
            // 
            this.bunifuProgressBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.bunifuProgressBar2.BorderRadius = 5;
            this.bunifuProgressBar2.Location = new System.Drawing.Point(334, 50);
            this.bunifuProgressBar2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.bunifuProgressBar2.MaximumValue = 100;
            this.bunifuProgressBar2.Name = "bunifuProgressBar2";
            this.bunifuProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.bunifuProgressBar2.Size = new System.Drawing.Size(324, 13);
            this.bunifuProgressBar2.TabIndex = 39;
            this.bunifuProgressBar2.Value = 48;
            // 
            // progressbarDownloadProgress
            // 
            this.progressbarDownloadProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.progressbarDownloadProgress.BorderRadius = 5;
            this.progressbarDownloadProgress.Location = new System.Drawing.Point(334, 26);
            this.progressbarDownloadProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressbarDownloadProgress.MaximumValue = 100;
            this.progressbarDownloadProgress.Name = "progressbarDownloadProgress";
            this.progressbarDownloadProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressbarDownloadProgress.Size = new System.Drawing.Size(324, 13);
            this.progressbarDownloadProgress.TabIndex = 36;
            this.progressbarDownloadProgress.Value = 23;
            // 
            // backgroundMetrics
            // 
            this.backgroundMetrics.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundMetrics_DoWork);
            // 
            // GSM_Performance_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(697, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDetailedCPUUsage);
            this.Controls.Add(this.lblCPUUsage);
            this.Controls.Add(this.progressCPUUsage);
            this.Controls.Add(this.lblDetailedDISKUsage);
            this.Controls.Add(this.lblDISKUsage);
            this.Controls.Add(this.progressDISKUsage);
            this.Controls.Add(this.lblDetailedRAMUsage);
            this.Controls.Add(this.lblRAMUsage);
            this.Controls.Add(this.progressRAMUsage);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GSM_Performance_Dashboard";
            this.Text = "GSM_Performance_Dashboard";
            this.Load += new System.EventHandler(this.GSM_Performance_Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundMetrics;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar3;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar2;
        private Bunifu.Framework.UI.BunifuProgressBar progressbarDownloadProgress;
    }
}