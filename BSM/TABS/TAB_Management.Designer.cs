namespace Borealis
{
    partial class TAB_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAB_Management));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboboxGameserverList = new MetroFramework.Controls.MetroComboBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnUpdateServerConfig = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtboxFriendlyName = new System.Windows.Forms.TextBox();
            this.txtboxArguments = new System.Windows.Forms.TextBox();
            this.btnDestroyServer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtboxStartingMap = new MetroFramework.Controls.MetroComboBox();
            this.btnSteamWorkshop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblFriendlyName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblArguments = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblStartingMap = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblServerSpecs = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGameType = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGameEngine = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSteamWorkshop = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
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
            this.bunifuCustomLabel1.TabIndex = 43;
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
            this.comboboxGameserverList.TabIndex = 42;
            this.comboboxGameserverList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.comboboxGameserverList, "Select a deployed gameserver to configure.");
            this.comboboxGameserverList.UseCustomBackColor = true;
            this.comboboxGameserverList.UseCustomForeColor = true;
            this.comboboxGameserverList.UseSelectable = true;
            this.comboboxGameserverList.SelectedValueChanged += new System.EventHandler(this.comboboxGameserverList_SelectedValueChanged);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(12, 42);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(276, 19);
            this.bunifuCustomLabel4.TabIndex = 11;
            this.bunifuCustomLabel4.Text = "Here you can manage individual gameservers";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(10, 10);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(280, 32);
            this.bunifuCustomLabel7.TabIndex = 4;
            this.bunifuCustomLabel7.Text = "GameServer Management";
            // 
            // btnUpdateServerConfig
            // 
            this.btnUpdateServerConfig.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateServerConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnUpdateServerConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateServerConfig.BorderRadius = 0;
            this.btnUpdateServerConfig.ButtonText = "   Update";
            this.btnUpdateServerConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateServerConfig.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateServerConfig.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnUpdateServerConfig.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateServerConfig.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateServerConfig.Iconimage")));
            this.btnUpdateServerConfig.Iconimage_right = null;
            this.btnUpdateServerConfig.Iconimage_right_Selected = null;
            this.btnUpdateServerConfig.Iconimage_Selected = null;
            this.btnUpdateServerConfig.IconMarginLeft = 0;
            this.btnUpdateServerConfig.IconMarginRight = 0;
            this.btnUpdateServerConfig.IconRightVisible = true;
            this.btnUpdateServerConfig.IconRightZoom = 0D;
            this.btnUpdateServerConfig.IconVisible = true;
            this.btnUpdateServerConfig.IconZoom = 90D;
            this.btnUpdateServerConfig.IsTab = false;
            this.btnUpdateServerConfig.Location = new System.Drawing.Point(568, 493);
            this.btnUpdateServerConfig.Name = "btnUpdateServerConfig";
            this.btnUpdateServerConfig.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnUpdateServerConfig.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdateServerConfig.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.btnUpdateServerConfig.selected = false;
            this.btnUpdateServerConfig.Size = new System.Drawing.Size(143, 48);
            this.btnUpdateServerConfig.TabIndex = 14;
            this.btnUpdateServerConfig.Text = "   Update";
            this.btnUpdateServerConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateServerConfig.Textcolor = System.Drawing.Color.White;
            this.btnUpdateServerConfig.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnUpdateServerConfig, "Commit the changes to the associated configuration files.");
            this.btnUpdateServerConfig.Visible = false;
            this.btnUpdateServerConfig.Click += new System.EventHandler(this.btnUpdateServerConfig_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "config.ini / config.txt / server.ini / etc...";
            this.openFileDialog1.Filter = "Server Config Files|*.cfg;*.ini;|All Files|*.*";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // txtboxFriendlyName
            // 
            this.txtboxFriendlyName.BackColor = System.Drawing.Color.White;
            this.txtboxFriendlyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxFriendlyName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtboxFriendlyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxFriendlyName.Location = new System.Drawing.Point(16, 102);
            this.txtboxFriendlyName.Name = "txtboxFriendlyName";
            this.txtboxFriendlyName.Size = new System.Drawing.Size(377, 25);
            this.txtboxFriendlyName.TabIndex = 49;
            this.toolTip1.SetToolTip(this.txtboxFriendlyName, "Give the server a user-friendly name to reference within Borealis.");
            this.txtboxFriendlyName.Visible = false;
            // 
            // txtboxArguments
            // 
            this.txtboxArguments.BackColor = System.Drawing.Color.White;
            this.txtboxArguments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxArguments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtboxArguments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxArguments.Location = new System.Drawing.Point(16, 165);
            this.txtboxArguments.Name = "txtboxArguments";
            this.txtboxArguments.Size = new System.Drawing.Size(377, 25);
            this.txtboxArguments.TabIndex = 51;
            this.toolTip1.SetToolTip(this.txtboxArguments, "Give the server a user-friendly name to reference within Borealis.");
            this.txtboxArguments.Visible = false;
            // 
            // btnDestroyServer
            // 
            this.btnDestroyServer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.btnDestroyServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.btnDestroyServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDestroyServer.BorderRadius = 0;
            this.btnDestroyServer.ButtonText = "   Destroy Server";
            this.btnDestroyServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDestroyServer.DisabledColor = System.Drawing.Color.Gray;
            this.btnDestroyServer.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnDestroyServer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDestroyServer.Iconimage = global::Borealis_Default_Namespace.Properties.Resources.STOP_ICON;
            this.btnDestroyServer.Iconimage_right = null;
            this.btnDestroyServer.Iconimage_right_Selected = null;
            this.btnDestroyServer.Iconimage_Selected = null;
            this.btnDestroyServer.IconMarginLeft = 0;
            this.btnDestroyServer.IconMarginRight = 0;
            this.btnDestroyServer.IconRightVisible = true;
            this.btnDestroyServer.IconRightZoom = 0D;
            this.btnDestroyServer.IconVisible = true;
            this.btnDestroyServer.IconZoom = 45D;
            this.btnDestroyServer.IsTab = false;
            this.btnDestroyServer.Location = new System.Drawing.Point(16, 493);
            this.btnDestroyServer.Name = "btnDestroyServer";
            this.btnDestroyServer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.btnDestroyServer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnDestroyServer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDestroyServer.selected = false;
            this.btnDestroyServer.Size = new System.Drawing.Size(155, 48);
            this.btnDestroyServer.TabIndex = 53;
            this.btnDestroyServer.Text = "   Destroy Server";
            this.btnDestroyServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDestroyServer.Textcolor = System.Drawing.Color.White;
            this.btnDestroyServer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnDestroyServer, "Forcefully terminate the process (not gracefully).");
            this.btnDestroyServer.Visible = false;
            this.btnDestroyServer.Click += new System.EventHandler(this.btnDestroyServer_Click_1);
            // 
            // txtboxStartingMap
            // 
            this.txtboxStartingMap.BackColor = System.Drawing.Color.White;
            this.txtboxStartingMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxStartingMap.FormattingEnabled = true;
            this.txtboxStartingMap.ItemHeight = 23;
            this.txtboxStartingMap.Location = new System.Drawing.Point(16, 228);
            this.txtboxStartingMap.Name = "txtboxStartingMap";
            this.txtboxStartingMap.Size = new System.Drawing.Size(377, 29);
            this.txtboxStartingMap.Sorted = true;
            this.txtboxStartingMap.TabIndex = 56;
            this.txtboxStartingMap.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.txtboxStartingMap, "Select which map you want the server to start on when launched.");
            this.txtboxStartingMap.UseCustomBackColor = true;
            this.txtboxStartingMap.UseCustomForeColor = true;
            this.txtboxStartingMap.UseSelectable = true;
            this.txtboxStartingMap.Visible = false;
            // 
            // btnSteamWorkshop
            // 
            this.btnSteamWorkshop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(137)))), ((int)(((byte)(173)))));
            this.btnSteamWorkshop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.btnSteamWorkshop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSteamWorkshop.BorderRadius = 0;
            this.btnSteamWorkshop.ButtonText = "   Steam Workshop";
            this.btnSteamWorkshop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSteamWorkshop.DisabledColor = System.Drawing.Color.Gray;
            this.btnSteamWorkshop.Enabled = false;
            this.btnSteamWorkshop.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnSteamWorkshop.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSteamWorkshop.Iconimage = global::Borealis_Default_Namespace.Properties.Resources.Steam_48;
            this.btnSteamWorkshop.Iconimage_right = null;
            this.btnSteamWorkshop.Iconimage_right_Selected = null;
            this.btnSteamWorkshop.Iconimage_Selected = null;
            this.btnSteamWorkshop.IconMarginLeft = 0;
            this.btnSteamWorkshop.IconMarginRight = 0;
            this.btnSteamWorkshop.IconRightVisible = true;
            this.btnSteamWorkshop.IconRightZoom = 0D;
            this.btnSteamWorkshop.IconVisible = true;
            this.btnSteamWorkshop.IconZoom = 70D;
            this.btnSteamWorkshop.IsTab = false;
            this.btnSteamWorkshop.Location = new System.Drawing.Point(413, 493);
            this.btnSteamWorkshop.Name = "btnSteamWorkshop";
            this.btnSteamWorkshop.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.btnSteamWorkshop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(127)))), ((int)(((byte)(163)))));
            this.btnSteamWorkshop.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSteamWorkshop.selected = false;
            this.btnSteamWorkshop.Size = new System.Drawing.Size(143, 48);
            this.btnSteamWorkshop.TabIndex = 57;
            this.btnSteamWorkshop.Text = "   Steam Workshop";
            this.btnSteamWorkshop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSteamWorkshop.Textcolor = System.Drawing.Color.White;
            this.btnSteamWorkshop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnSteamWorkshop, "Commit the changes to the associated configuration files.");
            this.btnSteamWorkshop.Visible = false;
            this.btnSteamWorkshop.Click += new System.EventHandler(this.btnSteamWorkshop_Click);
            // 
            // lblFriendlyName
            // 
            this.lblFriendlyName.AutoSize = true;
            this.lblFriendlyName.BackColor = System.Drawing.Color.Transparent;
            this.lblFriendlyName.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblFriendlyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblFriendlyName.Location = new System.Drawing.Point(12, 80);
            this.lblFriendlyName.Name = "lblFriendlyName";
            this.lblFriendlyName.Size = new System.Drawing.Size(90, 19);
            this.lblFriendlyName.TabIndex = 48;
            this.lblFriendlyName.Text = "Server Name:";
            this.lblFriendlyName.Visible = false;
            // 
            // lblArguments
            // 
            this.lblArguments.AutoSize = true;
            this.lblArguments.BackColor = System.Drawing.Color.Transparent;
            this.lblArguments.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblArguments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblArguments.Location = new System.Drawing.Point(12, 143);
            this.lblArguments.Name = "lblArguments";
            this.lblArguments.Size = new System.Drawing.Size(120, 19);
            this.lblArguments.TabIndex = 50;
            this.lblArguments.Text = "Launch Arguments:";
            this.lblArguments.Visible = false;
            // 
            // lblStartingMap
            // 
            this.lblStartingMap.AutoSize = true;
            this.lblStartingMap.BackColor = System.Drawing.Color.Transparent;
            this.lblStartingMap.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblStartingMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblStartingMap.Location = new System.Drawing.Point(12, 206);
            this.lblStartingMap.Name = "lblStartingMap";
            this.lblStartingMap.Size = new System.Drawing.Size(89, 19);
            this.lblStartingMap.TabIndex = 54;
            this.lblStartingMap.Text = "Starting Map:";
            this.lblStartingMap.Visible = false;
            // 
            // lblServerSpecs
            // 
            this.lblServerSpecs.AutoSize = true;
            this.lblServerSpecs.BackColor = System.Drawing.Color.Transparent;
            this.lblServerSpecs.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblServerSpecs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblServerSpecs.Location = new System.Drawing.Point(414, 80);
            this.lblServerSpecs.Name = "lblServerSpecs";
            this.lblServerSpecs.Size = new System.Drawing.Size(87, 19);
            this.lblServerSpecs.TabIndex = 58;
            this.lblServerSpecs.Text = "Server Specs:";
            this.lblServerSpecs.Visible = false;
            // 
            // lblGameType
            // 
            this.lblGameType.AutoSize = true;
            this.lblGameType.BackColor = System.Drawing.Color.Transparent;
            this.lblGameType.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblGameType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblGameType.Location = new System.Drawing.Point(414, 102);
            this.lblGameType.Name = "lblGameType";
            this.lblGameType.Size = new System.Drawing.Size(61, 13);
            this.lblGameType.TabIndex = 59;
            this.lblGameType.Text = "Game Type:";
            this.lblGameType.Visible = false;
            // 
            // lblGameEngine
            // 
            this.lblGameEngine.AutoSize = true;
            this.lblGameEngine.BackColor = System.Drawing.Color.Transparent;
            this.lblGameEngine.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblGameEngine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblGameEngine.Location = new System.Drawing.Point(414, 115);
            this.lblGameEngine.Name = "lblGameEngine";
            this.lblGameEngine.Size = new System.Drawing.Size(71, 13);
            this.lblGameEngine.TabIndex = 60;
            this.lblGameEngine.Text = "Game Engine:";
            this.lblGameEngine.Visible = false;
            // 
            // lblSteamWorkshop
            // 
            this.lblSteamWorkshop.AutoSize = true;
            this.lblSteamWorkshop.BackColor = System.Drawing.Color.Transparent;
            this.lblSteamWorkshop.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblSteamWorkshop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblSteamWorkshop.Location = new System.Drawing.Point(414, 128);
            this.lblSteamWorkshop.Name = "lblSteamWorkshop";
            this.lblSteamWorkshop.Size = new System.Drawing.Size(87, 13);
            this.lblSteamWorkshop.TabIndex = 61;
            this.lblSteamWorkshop.Text = "Steam Workshop:";
            this.lblSteamWorkshop.Visible = false;
            // 
            // TAB_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.BackgroundImage = global::Borealis_Default_Namespace.Properties.Resources.backdrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 557);
            this.Controls.Add(this.lblSteamWorkshop);
            this.Controls.Add(this.lblGameEngine);
            this.Controls.Add(this.lblGameType);
            this.Controls.Add(this.lblServerSpecs);
            this.Controls.Add(this.btnSteamWorkshop);
            this.Controls.Add(this.txtboxStartingMap);
            this.Controls.Add(this.lblStartingMap);
            this.Controls.Add(this.btnDestroyServer);
            this.Controls.Add(this.txtboxArguments);
            this.Controls.Add(this.lblArguments);
            this.Controls.Add(this.txtboxFriendlyName);
            this.Controls.Add(this.lblFriendlyName);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.comboboxGameserverList);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.btnUpdateServerConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TAB_Management";
            this.Text = "ServerManagement";
            this.Activated += new System.EventHandler(this.ServerManagement_Activated);
            this.Load += new System.EventHandler(this.GSM_Management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateServerConfig;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private MetroFramework.Controls.MetroComboBox comboboxGameserverList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFriendlyName;
        private System.Windows.Forms.TextBox txtboxFriendlyName;
        private System.Windows.Forms.TextBox txtboxArguments;
        private Bunifu.Framework.UI.BunifuCustomLabel lblArguments;
        private Bunifu.Framework.UI.BunifuFlatButton btnDestroyServer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStartingMap;
        private MetroFramework.Controls.MetroComboBox txtboxStartingMap;
        private Bunifu.Framework.UI.BunifuFlatButton btnSteamWorkshop;
        private Bunifu.Framework.UI.BunifuCustomLabel lblServerSpecs;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGameType;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGameEngine;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSteamWorkshop;
    }
}