namespace Borealis
{
    partial class TAB_MANAGEMENT
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
            this.txtboxPORT = new System.Windows.Forms.TextBox();
            this.btnAddonControl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.incMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.lblAddFirewallRule = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkFirewallToggle = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblFriendlyName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblArguments = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblStartingMap = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMaxPlayers = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPort = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupboxServerProperties = new System.Windows.Forms.GroupBox();
            this.groupboxGameProperties = new System.Windows.Forms.GroupBox();
            this.btnBrowseDestination = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.incMaxPlayers)).BeginInit();
            this.groupboxServerProperties.SuspendLayout();
            this.groupboxGameProperties.SuspendLayout();
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
            this.btnUpdateServerConfig.ButtonText = "Save";
            this.btnUpdateServerConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateServerConfig.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateServerConfig.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnUpdateServerConfig.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateServerConfig.Iconimage = global::Borealis.Properties.Resources.Apply;
            this.btnUpdateServerConfig.Iconimage_right = null;
            this.btnUpdateServerConfig.Iconimage_right_Selected = null;
            this.btnUpdateServerConfig.Iconimage_Selected = null;
            this.btnUpdateServerConfig.IconMarginLeft = 0;
            this.btnUpdateServerConfig.IconMarginRight = 0;
            this.btnUpdateServerConfig.IconRightVisible = true;
            this.btnUpdateServerConfig.IconRightZoom = 0D;
            this.btnUpdateServerConfig.IconVisible = true;
            this.btnUpdateServerConfig.IconZoom = 60D;
            this.btnUpdateServerConfig.IsTab = false;
            this.btnUpdateServerConfig.Location = new System.Drawing.Point(568, 493);
            this.btnUpdateServerConfig.Name = "btnUpdateServerConfig";
            this.btnUpdateServerConfig.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnUpdateServerConfig.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdateServerConfig.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.btnUpdateServerConfig.selected = false;
            this.btnUpdateServerConfig.Size = new System.Drawing.Size(143, 48);
            this.btnUpdateServerConfig.TabIndex = 14;
            this.btnUpdateServerConfig.Text = "Save";
            this.btnUpdateServerConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtboxFriendlyName.Location = new System.Drawing.Point(10, 41);
            this.txtboxFriendlyName.Name = "txtboxFriendlyName";
            this.txtboxFriendlyName.Size = new System.Drawing.Size(299, 25);
            this.txtboxFriendlyName.TabIndex = 49;
            this.toolTip1.SetToolTip(this.txtboxFriendlyName, "Give the server a user-friendly name to reference within Borealis.");
            // 
            // txtboxArguments
            // 
            this.txtboxArguments.BackColor = System.Drawing.Color.White;
            this.txtboxArguments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxArguments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtboxArguments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxArguments.Location = new System.Drawing.Point(10, 150);
            this.txtboxArguments.Name = "txtboxArguments";
            this.txtboxArguments.Size = new System.Drawing.Size(299, 25);
            this.txtboxArguments.TabIndex = 51;
            this.toolTip1.SetToolTip(this.txtboxArguments, "Assign any additional custom parameters to pass when the server launches.");
            // 
            // btnDestroyServer
            // 
            this.btnDestroyServer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.btnDestroyServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.btnDestroyServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDestroyServer.BorderRadius = 0;
            this.btnDestroyServer.ButtonText = "Destroy Server";
            this.btnDestroyServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDestroyServer.DisabledColor = System.Drawing.Color.Gray;
            this.btnDestroyServer.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnDestroyServer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDestroyServer.Iconimage = global::Borealis.Properties.Resources.STOP_ICON;
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
            this.btnDestroyServer.Text = "Destroy Server";
            this.btnDestroyServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDestroyServer.Textcolor = System.Drawing.Color.White;
            this.btnDestroyServer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnDestroyServer, "Forcefully terminate the process (not gracefully).");
            this.btnDestroyServer.Visible = false;
            this.btnDestroyServer.Click += new System.EventHandler(this.btnDestroyServer_Click_1);
            // 
            // txtboxStartingMap
            // 
            this.txtboxStartingMap.BackColor = System.Drawing.Color.White;
            this.txtboxStartingMap.DropDownHeight = 140;
            this.txtboxStartingMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxStartingMap.FormattingEnabled = true;
            this.txtboxStartingMap.IntegralHeight = false;
            this.txtboxStartingMap.ItemHeight = 23;
            this.txtboxStartingMap.Location = new System.Drawing.Point(10, 43);
            this.txtboxStartingMap.Name = "txtboxStartingMap";
            this.txtboxStartingMap.PromptText = "< Select a Map >";
            this.txtboxStartingMap.Size = new System.Drawing.Size(234, 29);
            this.txtboxStartingMap.Sorted = true;
            this.txtboxStartingMap.TabIndex = 56;
            this.txtboxStartingMap.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.txtboxStartingMap, "Select which map you want the server to start on when launched.");
            this.txtboxStartingMap.UseCustomBackColor = true;
            this.txtboxStartingMap.UseCustomForeColor = true;
            this.txtboxStartingMap.UseSelectable = true;
            // 
            // btnSteamWorkshop
            // 
            this.btnSteamWorkshop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(137)))), ((int)(((byte)(173)))));
            this.btnSteamWorkshop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.btnSteamWorkshop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSteamWorkshop.BorderRadius = 0;
            this.btnSteamWorkshop.ButtonText = "Workshop ";
            this.btnSteamWorkshop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSteamWorkshop.DisabledColor = System.Drawing.Color.Gray;
            this.btnSteamWorkshop.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnSteamWorkshop.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSteamWorkshop.Iconimage = global::Borealis.Properties.Resources.Steam_48;
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
            this.btnSteamWorkshop.Text = "Workshop ";
            this.btnSteamWorkshop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSteamWorkshop.Textcolor = System.Drawing.Color.White;
            this.btnSteamWorkshop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnSteamWorkshop, "Commit the changes to the associated configuration files.");
            this.btnSteamWorkshop.Visible = false;
            this.btnSteamWorkshop.Click += new System.EventHandler(this.btnSteamWorkshop_Click);
            // 
            // txtboxPORT
            // 
            this.txtboxPORT.BackColor = System.Drawing.Color.White;
            this.txtboxPORT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxPORT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtboxPORT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxPORT.Location = new System.Drawing.Point(11, 96);
            this.txtboxPORT.Name = "txtboxPORT";
            this.txtboxPORT.Size = new System.Drawing.Size(115, 25);
            this.txtboxPORT.TabIndex = 67;
            this.toolTip1.SetToolTip(this.txtboxPORT, "Assign the server a network port to communicate to the world with.");
            // 
            // btnAddonControl
            // 
            this.btnAddonControl.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(137)))), ((int)(((byte)(173)))));
            this.btnAddonControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.btnAddonControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddonControl.BorderRadius = 0;
            this.btnAddonControl.ButtonText = "Mods";
            this.btnAddonControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddonControl.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddonControl.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnAddonControl.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddonControl.Iconimage = global::Borealis.Properties.Resources.Addons;
            this.btnAddonControl.Iconimage_right = null;
            this.btnAddonControl.Iconimage_right_Selected = null;
            this.btnAddonControl.Iconimage_Selected = null;
            this.btnAddonControl.IconMarginLeft = 0;
            this.btnAddonControl.IconMarginRight = 0;
            this.btnAddonControl.IconRightVisible = true;
            this.btnAddonControl.IconRightZoom = 0D;
            this.btnAddonControl.IconVisible = true;
            this.btnAddonControl.IconZoom = 60D;
            this.btnAddonControl.IsTab = false;
            this.btnAddonControl.Location = new System.Drawing.Point(258, 493);
            this.btnAddonControl.Name = "btnAddonControl";
            this.btnAddonControl.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.btnAddonControl.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(127)))), ((int)(((byte)(163)))));
            this.btnAddonControl.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddonControl.selected = false;
            this.btnAddonControl.Size = new System.Drawing.Size(143, 48);
            this.btnAddonControl.TabIndex = 70;
            this.btnAddonControl.Text = "Mods";
            this.btnAddonControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddonControl.Textcolor = System.Drawing.Color.White;
            this.btnAddonControl.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnAddonControl, "Commit the changes to the associated configuration files.");
            this.btnAddonControl.Visible = false;
            this.btnAddonControl.Click += new System.EventHandler(this.btnAddonControl_Click);
            // 
            // incMaxPlayers
            // 
            this.incMaxPlayers.Location = new System.Drawing.Point(10, 99);
            this.incMaxPlayers.Name = "incMaxPlayers";
            this.incMaxPlayers.Size = new System.Drawing.Size(116, 25);
            this.incMaxPlayers.TabIndex = 62;
            this.toolTip1.SetToolTip(this.incMaxPlayers, "Select the maximum number of players you want to be able to join this server.");
            this.incMaxPlayers.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblAddFirewallRule
            // 
            this.lblAddFirewallRule.AutoSize = true;
            this.lblAddFirewallRule.BackColor = System.Drawing.Color.Transparent;
            this.lblAddFirewallRule.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblAddFirewallRule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblAddFirewallRule.Location = new System.Drawing.Point(30, 195);
            this.lblAddFirewallRule.Name = "lblAddFirewallRule";
            this.lblAddFirewallRule.Size = new System.Drawing.Size(144, 19);
            this.lblAddFirewallRule.TabIndex = 71;
            this.lblAddFirewallRule.Text = "Firewall Rule [Disabled]";
            this.toolTip1.SetToolTip(this.lblAddFirewallRule, "<NOT IMPLEMENTED YET>");
            // 
            // chkFirewallToggle
            // 
            this.chkFirewallToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkFirewallToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkFirewallToggle.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkFirewallToggle.Checked = false;
            this.chkFirewallToggle.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.chkFirewallToggle.ForeColor = System.Drawing.Color.White;
            this.chkFirewallToggle.Location = new System.Drawing.Point(11, 195);
            this.chkFirewallToggle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFirewallToggle.Name = "chkFirewallToggle";
            this.chkFirewallToggle.Size = new System.Drawing.Size(20, 20);
            this.chkFirewallToggle.TabIndex = 70;
            this.toolTip1.SetToolTip(this.chkFirewallToggle, "<NOT IMPLEMENTED YET>");
            this.chkFirewallToggle.OnChange += new System.EventHandler(this.chkFirewallToggle_OnChange);
            // 
            // lblFriendlyName
            // 
            this.lblFriendlyName.AutoSize = true;
            this.lblFriendlyName.BackColor = System.Drawing.Color.Transparent;
            this.lblFriendlyName.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblFriendlyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblFriendlyName.Location = new System.Drawing.Point(6, 19);
            this.lblFriendlyName.Name = "lblFriendlyName";
            this.lblFriendlyName.Size = new System.Drawing.Size(90, 19);
            this.lblFriendlyName.TabIndex = 48;
            this.lblFriendlyName.Text = "Server Name:";
            // 
            // lblArguments
            // 
            this.lblArguments.AutoSize = true;
            this.lblArguments.BackColor = System.Drawing.Color.Transparent;
            this.lblArguments.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblArguments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblArguments.Location = new System.Drawing.Point(6, 128);
            this.lblArguments.Name = "lblArguments";
            this.lblArguments.Size = new System.Drawing.Size(120, 19);
            this.lblArguments.TabIndex = 50;
            this.lblArguments.Text = "Launch Arguments:";
            // 
            // lblStartingMap
            // 
            this.lblStartingMap.AutoSize = true;
            this.lblStartingMap.BackColor = System.Drawing.Color.Transparent;
            this.lblStartingMap.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblStartingMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblStartingMap.Location = new System.Drawing.Point(6, 21);
            this.lblStartingMap.Name = "lblStartingMap";
            this.lblStartingMap.Size = new System.Drawing.Size(89, 19);
            this.lblStartingMap.TabIndex = 54;
            this.lblStartingMap.Text = "Starting Map:";
            // 
            // lblMaxPlayers
            // 
            this.lblMaxPlayers.AutoSize = true;
            this.lblMaxPlayers.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxPlayers.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblMaxPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblMaxPlayers.Location = new System.Drawing.Point(7, 77);
            this.lblMaxPlayers.Name = "lblMaxPlayers";
            this.lblMaxPlayers.Size = new System.Drawing.Size(82, 19);
            this.lblMaxPlayers.TabIndex = 63;
            this.lblMaxPlayers.Text = "Max Players:";
            this.lblMaxPlayers.UseMnemonic = false;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.BackColor = System.Drawing.Color.Transparent;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblPort.Location = new System.Drawing.Point(6, 74);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(79, 19);
            this.lblPort.TabIndex = 69;
            this.lblPort.Text = "Server Port:";
            // 
            // groupboxServerProperties
            // 
            this.groupboxServerProperties.BackColor = System.Drawing.Color.Transparent;
            this.groupboxServerProperties.Controls.Add(this.btnBrowseDestination);
            this.groupboxServerProperties.Controls.Add(this.lblFriendlyName);
            this.groupboxServerProperties.Controls.Add(this.lblAddFirewallRule);
            this.groupboxServerProperties.Controls.Add(this.txtboxFriendlyName);
            this.groupboxServerProperties.Controls.Add(this.lblPort);
            this.groupboxServerProperties.Controls.Add(this.txtboxPORT);
            this.groupboxServerProperties.Controls.Add(this.chkFirewallToggle);
            this.groupboxServerProperties.Controls.Add(this.lblArguments);
            this.groupboxServerProperties.Controls.Add(this.txtboxArguments);
            this.groupboxServerProperties.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.groupboxServerProperties.ForeColor = System.Drawing.Color.Black;
            this.groupboxServerProperties.Location = new System.Drawing.Point(12, 71);
            this.groupboxServerProperties.Name = "groupboxServerProperties";
            this.groupboxServerProperties.Size = new System.Drawing.Size(321, 226);
            this.groupboxServerProperties.TabIndex = 72;
            this.groupboxServerProperties.TabStop = false;
            this.groupboxServerProperties.Text = "Server Properties";
            this.groupboxServerProperties.Visible = false;
            // 
            // groupboxGameProperties
            // 
            this.groupboxGameProperties.BackColor = System.Drawing.Color.Transparent;
            this.groupboxGameProperties.Controls.Add(this.lblStartingMap);
            this.groupboxGameProperties.Controls.Add(this.txtboxStartingMap);
            this.groupboxGameProperties.Controls.Add(this.lblMaxPlayers);
            this.groupboxGameProperties.Controls.Add(this.incMaxPlayers);
            this.groupboxGameProperties.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.groupboxGameProperties.ForeColor = System.Drawing.Color.Black;
            this.groupboxGameProperties.Location = new System.Drawing.Point(12, 333);
            this.groupboxGameProperties.Name = "groupboxGameProperties";
            this.groupboxGameProperties.Size = new System.Drawing.Size(321, 136);
            this.groupboxGameProperties.TabIndex = 73;
            this.groupboxGameProperties.TabStop = false;
            this.groupboxGameProperties.Text = "Game Properties";
            this.groupboxGameProperties.Visible = false;
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBrowseDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnBrowseDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseDestination.BorderRadius = 0;
            this.btnBrowseDestination.ButtonText = "Open Config Folder";
            this.btnBrowseDestination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseDestination.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowseDestination.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnBrowseDestination.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowseDestination.Iconimage = null;
            this.btnBrowseDestination.Iconimage_right = null;
            this.btnBrowseDestination.Iconimage_right_Selected = null;
            this.btnBrowseDestination.Iconimage_Selected = null;
            this.btnBrowseDestination.IconMarginLeft = 0;
            this.btnBrowseDestination.IconMarginRight = 0;
            this.btnBrowseDestination.IconRightVisible = true;
            this.btnBrowseDestination.IconRightZoom = 0D;
            this.btnBrowseDestination.IconVisible = true;
            this.btnBrowseDestination.IconZoom = 90D;
            this.btnBrowseDestination.IsTab = false;
            this.btnBrowseDestination.Location = new System.Drawing.Point(176, 186);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnBrowseDestination.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBrowseDestination.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowseDestination.selected = false;
            this.btnBrowseDestination.Size = new System.Drawing.Size(133, 29);
            this.btnBrowseDestination.TabIndex = 64;
            this.btnBrowseDestination.Text = "Open Config Folder";
            this.btnBrowseDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowseDestination.Textcolor = System.Drawing.Color.White;
            this.btnBrowseDestination.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnBrowseDestination, "Select where to deploy the new gameserver on  your system.\r\nThis location can be " +
        "on the same disk or on another disk.");
            // 
            // TAB_MANAGEMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.BackgroundImage = global::Borealis.Properties.Resources.backdrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 557);
            this.Controls.Add(this.groupboxGameProperties);
            this.Controls.Add(this.groupboxServerProperties);
            this.Controls.Add(this.btnAddonControl);
            this.Controls.Add(this.btnSteamWorkshop);
            this.Controls.Add(this.btnDestroyServer);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.comboboxGameserverList);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.btnUpdateServerConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TAB_MANAGEMENT";
            this.Text = "ServerManagement";
            this.Activated += new System.EventHandler(this.ServerManagement_Activated);
            this.Load += new System.EventHandler(this.GSM_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incMaxPlayers)).EndInit();
            this.groupboxServerProperties.ResumeLayout(false);
            this.groupboxServerProperties.PerformLayout();
            this.groupboxGameProperties.ResumeLayout(false);
            this.groupboxGameProperties.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown incMaxPlayers;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMaxPlayers;
        private System.Windows.Forms.TextBox txtboxPORT;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPort;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddonControl;
        private System.Windows.Forms.GroupBox groupboxServerProperties;
        private System.Windows.Forms.GroupBox groupboxGameProperties;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAddFirewallRule;
        private Bunifu.Framework.UI.BunifuCheckbox chkFirewallToggle;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowseDestination;
    }
}