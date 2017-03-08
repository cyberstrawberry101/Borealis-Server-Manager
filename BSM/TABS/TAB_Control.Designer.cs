namespace Borealis
{
    partial class TAB_CONTROL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAB_CONTROL));
            this.chkAutoRestart = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboboxGameserverList = new MetroFramework.Controls.MetroComboBox();
            this.lblAutoRestart = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnStartServer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStopServer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.serverProcess01 = new System.Diagnostics.Process();
            this.serverProcess02 = new System.Diagnostics.Process();
            this.consoleOutputList = new System.Windows.Forms.ListBox();
            this.txtboxIssueCommand = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAutoRestart
            // 
            this.chkAutoRestart.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoRestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkAutoRestart.BackgroundImage")));
            this.chkAutoRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkAutoRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoRestart.Location = new System.Drawing.Point(16, 516);
            this.chkAutoRestart.Name = "chkAutoRestart";
            this.chkAutoRestart.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.chkAutoRestart.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.chkAutoRestart.Size = new System.Drawing.Size(43, 25);
            this.chkAutoRestart.TabIndex = 42;
            this.toolTip1.SetToolTip(this.chkAutoRestart, "In the event that the server crashes or the process is terminated, it will be aut" +
        "omatically re-launched.");
            this.chkAutoRestart.Value = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(414, 10);
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
            this.comboboxGameserverList.Location = new System.Drawing.Point(418, 32);
            this.comboboxGameserverList.Name = "comboboxGameserverList";
            this.comboboxGameserverList.Size = new System.Drawing.Size(293, 29);
            this.comboboxGameserverList.Sorted = true;
            this.comboboxGameserverList.TabIndex = 40;
            this.comboboxGameserverList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.comboboxGameserverList, "Select a server that you have already deployed to start managing it.");
            this.comboboxGameserverList.UseCustomBackColor = true;
            this.comboboxGameserverList.UseCustomForeColor = true;
            this.comboboxGameserverList.UseSelectable = true;
            this.comboboxGameserverList.SelectedValueChanged += new System.EventHandler(this.comboboxGameserverList_SelectedValueChanged);
            // 
            // lblAutoRestart
            // 
            this.lblAutoRestart.AutoSize = true;
            this.lblAutoRestart.BackColor = System.Drawing.Color.Transparent;
            this.lblAutoRestart.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblAutoRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblAutoRestart.Location = new System.Drawing.Point(65, 522);
            this.lblAutoRestart.Name = "lblAutoRestart";
            this.lblAutoRestart.Size = new System.Drawing.Size(189, 19);
            this.lblAutoRestart.TabIndex = 18;
            this.lblAutoRestart.Text = "Auto-restart server if it crashes";
            this.toolTip1.SetToolTip(this.lblAutoRestart, "In the event that the server crashes or the process is terminated, it will be aut" +
        "omatically re-launched.");
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
            this.btnStartServer.Location = new System.Drawing.Point(413, 493);
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
            this.toolTip1.SetToolTip(this.btnStartServer, "Start the server process in the background.");
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
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
            this.btnStopServer.Iconimage = global::Borealis_Default_Namespace.Properties.Resources.STOP_ICON;
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
            this.btnStopServer.Location = new System.Drawing.Point(568, 493);
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
            this.toolTip1.SetToolTip(this.btnStopServer, "Forcefully terminate the process (not gracefully).");
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.BackColor = System.Drawing.Color.Transparent;
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
            this.bunifuCustomLabel16.BackColor = System.Drawing.Color.Transparent;
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
            // consoleOutputList
            // 
            this.consoleOutputList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleOutputList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleOutputList.FormattingEnabled = true;
            this.consoleOutputList.Location = new System.Drawing.Point(0, 0);
            this.consoleOutputList.Name = "consoleOutputList";
            this.consoleOutputList.Size = new System.Drawing.Size(692, 371);
            this.consoleOutputList.TabIndex = 43;
            this.toolTip1.SetToolTip(this.consoleOutputList, "Here you can read the output from your currently running servers.");
            // 
            // txtboxIssueCommand
            // 
            this.txtboxIssueCommand.BackColor = System.Drawing.Color.White;
            this.txtboxIssueCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxIssueCommand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtboxIssueCommand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxIssueCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxIssueCommand.Location = new System.Drawing.Point(0, 371);
            this.txtboxIssueCommand.Name = "txtboxIssueCommand";
            this.txtboxIssueCommand.Size = new System.Drawing.Size(692, 29);
            this.txtboxIssueCommand.TabIndex = 49;
            this.txtboxIssueCommand.Text = " > Server is Not Running";
            this.toolTip1.SetToolTip(this.txtboxIssueCommand, "You can issue commands to the actively selected gameserver here.");
            this.txtboxIssueCommand.Visible = false;
            this.txtboxIssueCommand.Enter += new System.EventHandler(this.txtboxIssueCommand_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.consoleOutputList);
            this.panel1.Controls.Add(this.txtboxIssueCommand);
            this.panel1.Location = new System.Drawing.Point(18, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 400);
            this.panel1.TabIndex = 50;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // TAB_CONTROL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borealis_Default_Namespace.Properties.Resources.backdrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkAutoRestart);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel16);
            this.Controls.Add(this.comboboxGameserverList);
            this.Controls.Add(this.bunifuCustomLabel14);
            this.Controls.Add(this.lblAutoRestart);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.btnStartServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TAB_CONTROL";
            this.Text = "ServerControl";
            this.Activated += new System.EventHandler(this.ServerControl_Activated);
            this.Load += new System.EventHandler(this.ServerControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnStopServer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAutoRestart;
        private Bunifu.Framework.UI.BunifuFlatButton btnStartServer;
        private System.Diagnostics.Process serverProcess01;
        private System.Diagnostics.Process serverProcess02;
        private MetroFramework.Controls.MetroComboBox comboboxGameserverList;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuiOSSwitch chkAutoRestart;
        private System.Windows.Forms.ListBox consoleOutputList;
        private System.Windows.Forms.TextBox txtboxIssueCommand;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}