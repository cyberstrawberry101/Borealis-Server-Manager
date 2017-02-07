namespace GameServer_Manager
{
    partial class ServerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerControl));
            this.panelTechServices = new System.Windows.Forms.Panel();
            this.chkAutoRestart = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboboxGameserverList = new MetroFramework.Controls.MetroComboBox();
            this.txtboxIssueCommand = new System.Windows.Forms.TextBox();
            this.lblAutoRestart = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnStartServer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.consoleViewport = new Bunifu.Framework.UI.BunifuCards();
            this.txtboxConsoleOutput = new System.Windows.Forms.ListBox();
            this.btnStopServer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.serverProcess01 = new System.Diagnostics.Process();
            this.serverProcess02 = new System.Diagnostics.Process();
            this.backgroundWorker01 = new System.ComponentModel.BackgroundWorker();
            this.panelTechServices.SuspendLayout();
            this.consoleViewport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTechServices
            // 
            this.panelTechServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.panelTechServices.Controls.Add(this.chkAutoRestart);
            this.panelTechServices.Controls.Add(this.bunifuCustomLabel1);
            this.panelTechServices.Controls.Add(this.comboboxGameserverList);
            this.panelTechServices.Controls.Add(this.lblAutoRestart);
            this.panelTechServices.Controls.Add(this.btnStartServer);
            this.panelTechServices.Controls.Add(this.consoleViewport);
            this.panelTechServices.Controls.Add(this.btnStopServer);
            this.panelTechServices.Controls.Add(this.bunifuCustomLabel14);
            this.panelTechServices.Controls.Add(this.bunifuCustomLabel16);
            this.panelTechServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTechServices.Location = new System.Drawing.Point(0, 0);
            this.panelTechServices.Name = "panelTechServices";
            this.panelTechServices.Size = new System.Drawing.Size(700, 537);
            this.panelTechServices.TabIndex = 20;
            // 
            // chkAutoRestart
            // 
            this.chkAutoRestart.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoRestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkAutoRestart.BackgroundImage")));
            this.chkAutoRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkAutoRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoRestart.Location = new System.Drawing.Point(16, 496);
            this.chkAutoRestart.Name = "chkAutoRestart";
            this.chkAutoRestart.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.chkAutoRestart.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.chkAutoRestart.Size = new System.Drawing.Size(43, 25);
            this.chkAutoRestart.TabIndex = 42;
            this.chkAutoRestart.Value = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(383, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(142, 19);
            this.bunifuCustomLabel1.TabIndex = 41;
            this.bunifuCustomLabel1.Text = "Choose a gameserver:";
            // 
            // comboboxGameserverList
            // 
            this.comboboxGameserverList.BackColor = System.Drawing.Color.White;
            this.comboboxGameserverList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.comboboxGameserverList.FormattingEnabled = true;
            this.comboboxGameserverList.ItemHeight = 23;
            this.comboboxGameserverList.Location = new System.Drawing.Point(387, 30);
            this.comboboxGameserverList.Name = "comboboxGameserverList";
            this.comboboxGameserverList.Size = new System.Drawing.Size(293, 29);
            this.comboboxGameserverList.Sorted = true;
            this.comboboxGameserverList.TabIndex = 40;
            this.comboboxGameserverList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboboxGameserverList.UseCustomBackColor = true;
            this.comboboxGameserverList.UseCustomForeColor = true;
            this.comboboxGameserverList.UseSelectable = true;
            // 
            // txtboxIssueCommand
            // 
            this.txtboxIssueCommand.BackColor = System.Drawing.Color.White;
            this.txtboxIssueCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxIssueCommand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtboxIssueCommand.Enabled = false;
            this.txtboxIssueCommand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxIssueCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxIssueCommand.Location = new System.Drawing.Point(0, 320);
            this.txtboxIssueCommand.Multiline = true;
            this.txtboxIssueCommand.Name = "txtboxIssueCommand";
            this.txtboxIssueCommand.Size = new System.Drawing.Size(662, 32);
            this.txtboxIssueCommand.TabIndex = 33;
            this.txtboxIssueCommand.Text = "> Server is not running";
            this.txtboxIssueCommand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtboxIssueCommand_MouseClick);
            // 
            // lblAutoRestart
            // 
            this.lblAutoRestart.AutoSize = true;
            this.lblAutoRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.lblAutoRestart.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblAutoRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblAutoRestart.Location = new System.Drawing.Point(65, 502);
            this.lblAutoRestart.Name = "lblAutoRestart";
            this.lblAutoRestart.Size = new System.Drawing.Size(189, 19);
            this.lblAutoRestart.TabIndex = 18;
            this.lblAutoRestart.Text = "Auto-restart server if it crashes";
            // 
            // btnStartServer
            // 
            this.btnStartServer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStartServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnStartServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartServer.BorderRadius = 0;
            this.btnStartServer.ButtonText = "Start Server";
            this.btnStartServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartServer.DisabledColor = System.Drawing.Color.Gray;
            this.btnStartServer.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnStartServer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStartServer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStartServer.Iconimage")));
            this.btnStartServer.Iconimage_right = null;
            this.btnStartServer.Iconimage_right_Selected = null;
            this.btnStartServer.Iconimage_Selected = null;
            this.btnStartServer.IconMarginLeft = 0;
            this.btnStartServer.IconMarginRight = 0;
            this.btnStartServer.IconRightVisible = true;
            this.btnStartServer.IconRightZoom = 0D;
            this.btnStartServer.IconVisible = true;
            this.btnStartServer.IconZoom = 90D;
            this.btnStartServer.IsTab = false;
            this.btnStartServer.Location = new System.Drawing.Point(378, 473);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnStartServer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnStartServer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStartServer.selected = false;
            this.btnStartServer.Size = new System.Drawing.Size(143, 48);
            this.btnStartServer.TabIndex = 16;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartServer.Textcolor = System.Drawing.Color.White;
            this.btnStartServer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // consoleViewport
            // 
            this.consoleViewport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.consoleViewport.BorderRadius = 5;
            this.consoleViewport.BottomSahddow = true;
            this.consoleViewport.color = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.consoleViewport.Controls.Add(this.txtboxIssueCommand);
            this.consoleViewport.Controls.Add(this.txtboxConsoleOutput);
            this.consoleViewport.LeftSahddow = false;
            this.consoleViewport.Location = new System.Drawing.Point(16, 66);
            this.consoleViewport.Name = "consoleViewport";
            this.consoleViewport.RightSahddow = true;
            this.consoleViewport.ShadowDepth = 20;
            this.consoleViewport.Size = new System.Drawing.Size(664, 352);
            this.consoleViewport.TabIndex = 15;
            // 
            // txtboxConsoleOutput
            // 
            this.txtboxConsoleOutput.BackColor = System.Drawing.Color.White;
            this.txtboxConsoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxConsoleOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxConsoleOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxConsoleOutput.FormattingEnabled = true;
            this.txtboxConsoleOutput.Items.AddRange(new object[] {
            "",
            "Example console output will be displayed here.",
            "Pretty much whatever you normally would see is here.",
            "",
            "Yep, pretty boring in this white box."});
            this.txtboxConsoleOutput.Location = new System.Drawing.Point(0, 0);
            this.txtboxConsoleOutput.Name = "txtboxConsoleOutput";
            this.txtboxConsoleOutput.Size = new System.Drawing.Size(664, 352);
            this.txtboxConsoleOutput.TabIndex = 2;
            // 
            // btnStopServer
            // 
            this.btnStopServer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStopServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.btnStopServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStopServer.BorderRadius = 0;
            this.btnStopServer.ButtonText = "   Stop Server";
            this.btnStopServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopServer.DisabledColor = System.Drawing.Color.Gray;
            this.btnStopServer.Enabled = false;
            this.btnStopServer.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnStopServer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStopServer.Iconimage = global::Borealis_Game_Manager.Properties.Resources.STOP_ICON;
            this.btnStopServer.Iconimage_right = null;
            this.btnStopServer.Iconimage_right_Selected = null;
            this.btnStopServer.Iconimage_Selected = null;
            this.btnStopServer.IconMarginLeft = 0;
            this.btnStopServer.IconMarginRight = 0;
            this.btnStopServer.IconRightVisible = true;
            this.btnStopServer.IconRightZoom = 0D;
            this.btnStopServer.IconVisible = true;
            this.btnStopServer.IconZoom = 45D;
            this.btnStopServer.IsTab = false;
            this.btnStopServer.Location = new System.Drawing.Point(537, 473);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.btnStopServer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnStopServer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStopServer.selected = false;
            this.btnStopServer.Size = new System.Drawing.Size(143, 48);
            this.btnStopServer.TabIndex = 14;
            this.btnStopServer.Text = "   Stop Server";
            this.btnStopServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopServer.Textcolor = System.Drawing.Color.White;
            this.btnStopServer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(156)))), ((int)(((byte)(159)))));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(12, 42);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(233, 19);
            this.bunifuCustomLabel14.TabIndex = 11;
            this.bunifuCustomLabel14.Text = "Issue commands to your gameservers.";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(10, 10);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(220, 32);
            this.bunifuCustomLabel16.TabIndex = 4;
            this.bunifuCustomLabel16.Text = "GameServer Control";
            // 
            // serverProcess01
            // 
            this.serverProcess01.StartInfo.Domain = "";
            this.serverProcess01.StartInfo.LoadUserProfile = false;
            this.serverProcess01.StartInfo.Password = null;
            this.serverProcess01.StartInfo.StandardErrorEncoding = null;
            this.serverProcess01.StartInfo.StandardOutputEncoding = null;
            this.serverProcess01.StartInfo.UserName = "";
            this.serverProcess01.SynchronizingObject = this;
            // 
            // serverProcess02
            // 
            this.serverProcess02.StartInfo.Domain = "";
            this.serverProcess02.StartInfo.LoadUserProfile = false;
            this.serverProcess02.StartInfo.Password = null;
            this.serverProcess02.StartInfo.StandardErrorEncoding = null;
            this.serverProcess02.StartInfo.StandardOutputEncoding = null;
            this.serverProcess02.StartInfo.UserName = "";
            this.serverProcess02.SynchronizingObject = this;
            // 
            // backgroundWorker01
            // 
            this.backgroundWorker01.WorkerSupportsCancellation = true;
            this.backgroundWorker01.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker01_DoWork);
            // 
            // ServerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 537);
            this.Controls.Add(this.panelTechServices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServerControl";
            this.Text = "Toolkit_TechServices_Panel";
            this.panelTechServices.ResumeLayout(false);
            this.panelTechServices.PerformLayout();
            this.consoleViewport.ResumeLayout(false);
            this.consoleViewport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTechServices;
        private Bunifu.Framework.UI.BunifuFlatButton btnStopServer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCards consoleViewport;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAutoRestart;
        private Bunifu.Framework.UI.BunifuFlatButton btnStartServer;
        private System.Windows.Forms.TextBox txtboxIssueCommand;
        private System.Windows.Forms.ListBox txtboxConsoleOutput;
        private System.Diagnostics.Process serverProcess01;
        private System.Diagnostics.Process serverProcess02;
        private System.ComponentModel.BackgroundWorker backgroundWorker01;
        private MetroFramework.Controls.MetroComboBox comboboxGameserverList;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuiOSSwitch chkAutoRestart;
    }
}