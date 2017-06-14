namespace Borealis
{
    partial class TAB_DEPLOYMENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAB_DEPLOYMENT));
            this.progressbarDownloadProgressOverall = new Bunifu.Framework.UI.BunifuProgressBar();
            this.dropdownServerSelection = new MetroFramework.Controls.MetroComboBox();
            this.lblDownloadProgressDetails = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDestinationDetails = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDownloadProgress = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnBrowseDestination = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtboxDestinationFolder = new System.Windows.Forms.TextBox();
            this.lblDestination = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSelectServerDetails = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSelectServer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.browseDestinationFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.lblServerNameDetails = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblServerName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtServerGivenName = new System.Windows.Forms.TextBox();
            this.lblDestinationDetailsSubtext = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.lblVerifyIntegrity = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkVerifyIntegrity = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.btnDeployGameserver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelDeployGameserver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSteamToken = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblSteamToken = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSteamToken = new System.Windows.Forms.TextBox();
            this.txtSteamPassword = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSteamUsername = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SteamGuardProcess = new System.Diagnostics.Process();
            this.panelSteamGuard = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelProgress.SuspendLayout();
            this.panelSteamGuard.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressbarDownloadProgressOverall
            // 
            this.progressbarDownloadProgressOverall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.progressbarDownloadProgressOverall.BorderRadius = 5;
            this.progressbarDownloadProgressOverall.Location = new System.Drawing.Point(11, 40);
            this.progressbarDownloadProgressOverall.MaximumValue = 100;
            this.progressbarDownloadProgressOverall.Name = "progressbarDownloadProgressOverall";
            this.progressbarDownloadProgressOverall.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressbarDownloadProgressOverall.Size = new System.Drawing.Size(695, 10);
            this.progressbarDownloadProgressOverall.TabIndex = 40;
            this.progressbarDownloadProgressOverall.Value = 0;
            // 
            // dropdownServerSelection
            // 
            this.dropdownServerSelection.BackColor = System.Drawing.Color.White;
            this.dropdownServerSelection.DropDownHeight = 140;
            this.dropdownServerSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dropdownServerSelection.FormattingEnabled = true;
            this.dropdownServerSelection.IntegralHeight = false;
            this.dropdownServerSelection.ItemHeight = 23;
            this.dropdownServerSelection.Location = new System.Drawing.Point(16, 113);
            this.dropdownServerSelection.MaxDropDownItems = 100;
            this.dropdownServerSelection.Name = "dropdownServerSelection";
            this.dropdownServerSelection.PromptText = "< Downloading data from API server... >";
            this.dropdownServerSelection.Size = new System.Drawing.Size(346, 29);
            this.dropdownServerSelection.Sorted = true;
            this.dropdownServerSelection.TabIndex = 39;
            this.dropdownServerSelection.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.dropdownServerSelection, "This retrieves a list of deployable gameservers using the server API.\r\nIf you are" +
        " unable to connect to http://phantom-net.duckdns.org:1337, you will be unable to" +
        " deploy any gameservers.");
            this.dropdownServerSelection.UseCustomBackColor = true;
            this.dropdownServerSelection.UseCustomForeColor = true;
            this.dropdownServerSelection.UseSelectable = true;
            this.dropdownServerSelection.UseStyleColors = true;
            this.dropdownServerSelection.SelectedValueChanged += new System.EventHandler(this.dropdownServerSelection_SelectedValueChanged);
            // 
            // lblDownloadProgressDetails
            // 
            this.lblDownloadProgressDetails.AutoSize = true;
            this.lblDownloadProgressDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDownloadProgressDetails.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblDownloadProgressDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblDownloadProgressDetails.Location = new System.Drawing.Point(8, 23);
            this.lblDownloadProgressDetails.Name = "lblDownloadProgressDetails";
            this.lblDownloadProgressDetails.Size = new System.Drawing.Size(55, 13);
            this.lblDownloadProgressDetails.TabIndex = 38;
            this.lblDownloadProgressDetails.Text = "Status: Idle";
            // 
            // lblDestinationDetails
            // 
            this.lblDestinationDetails.AutoSize = true;
            this.lblDestinationDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDestinationDetails.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblDestinationDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblDestinationDetails.Location = new System.Drawing.Point(13, 186);
            this.lblDestinationDetails.Name = "lblDestinationDetails";
            this.lblDestinationDetails.Size = new System.Drawing.Size(299, 13);
            this.lblDestinationDetails.TabIndex = 37;
            this.lblDestinationDetails.Text = "Choose where you want to install the gameserver (e.g. C:\\BSM\\)";
            // 
            // lblDownloadProgress
            // 
            this.lblDownloadProgress.AutoSize = true;
            this.lblDownloadProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblDownloadProgress.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblDownloadProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDownloadProgress.Location = new System.Drawing.Point(7, 2);
            this.lblDownloadProgress.Name = "lblDownloadProgress";
            this.lblDownloadProgress.Size = new System.Drawing.Size(230, 21);
            this.lblDownloadProgress.TabIndex = 36;
            this.lblDownloadProgress.Text = "Download / Installation Progress:";
            this.toolTip1.SetToolTip(this.lblDownloadProgress, "Deployment progress reporting both download and installation progress.");
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBrowseDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnBrowseDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseDestination.BorderRadius = 0;
            this.btnBrowseDestination.ButtonText = "Browse";
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
            this.btnBrowseDestination.Location = new System.Drawing.Point(368, 202);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnBrowseDestination.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBrowseDestination.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowseDestination.selected = false;
            this.btnBrowseDestination.Size = new System.Drawing.Size(72, 29);
            this.btnBrowseDestination.TabIndex = 33;
            this.btnBrowseDestination.Text = "Browse";
            this.btnBrowseDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowseDestination.Textcolor = System.Drawing.Color.White;
            this.btnBrowseDestination.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnBrowseDestination, "Select where to deploy the new gameserver on  your system.\r\nThis location can be " +
        "on the same disk or on another disk.");
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // txtboxDestinationFolder
            // 
            this.txtboxDestinationFolder.BackColor = System.Drawing.Color.White;
            this.txtboxDestinationFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxDestinationFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDestinationFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxDestinationFolder.Location = new System.Drawing.Point(16, 202);
            this.txtboxDestinationFolder.Name = "txtboxDestinationFolder";
            this.txtboxDestinationFolder.Size = new System.Drawing.Size(346, 29);
            this.txtboxDestinationFolder.TabIndex = 32;
            this.toolTip1.SetToolTip(this.txtboxDestinationFolder, "Select where you want to deploy your new gameserver.");
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.BackColor = System.Drawing.Color.Transparent;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDestination.Location = new System.Drawing.Point(12, 165);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(136, 21);
            this.lblDestination.TabIndex = 29;
            this.lblDestination.Text = "Step 2: Destination";
            // 
            // lblSelectServerDetails
            // 
            this.lblSelectServerDetails.AutoSize = true;
            this.lblSelectServerDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectServerDetails.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblSelectServerDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblSelectServerDetails.Location = new System.Drawing.Point(13, 97);
            this.lblSelectServerDetails.Name = "lblSelectServerDetails";
            this.lblSelectServerDetails.Size = new System.Drawing.Size(198, 13);
            this.lblSelectServerDetails.TabIndex = 12;
            this.lblSelectServerDetails.Text = "Which gameserver do you want to install?";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 42);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(295, 19);
            this.bunifuCustomLabel5.TabIndex = 11;
            this.bunifuCustomLabel5.Text = "Select a gameserver and destination to deploy it.";
            // 
            // lblSelectServer
            // 
            this.lblSelectServer.AutoSize = true;
            this.lblSelectServer.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectServer.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblSelectServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblSelectServer.Location = new System.Drawing.Point(12, 76);
            this.lblSelectServer.Name = "lblSelectServer";
            this.lblSelectServer.Size = new System.Drawing.Size(143, 21);
            this.lblSelectServer.TabIndex = 5;
            this.lblSelectServer.Text = "Step 1: Select Server";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(10, 10);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(268, 32);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "GameServer Deployment";
            // 
            // browseDestinationFolder
            // 
            this.browseDestinationFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // lblServerNameDetails
            // 
            this.lblServerNameDetails.AutoSize = true;
            this.lblServerNameDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblServerNameDetails.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblServerNameDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblServerNameDetails.Location = new System.Drawing.Point(13, 275);
            this.lblServerNameDetails.Name = "lblServerNameDetails";
            this.lblServerNameDetails.Size = new System.Drawing.Size(206, 13);
            this.lblServerNameDetails.TabIndex = 46;
            this.lblServerNameDetails.Text = "Choose what name to give the gameserver";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.BackColor = System.Drawing.Color.Transparent;
            this.lblServerName.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblServerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblServerName.Location = new System.Drawing.Point(12, 254);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(155, 21);
            this.lblServerName.TabIndex = 45;
            this.lblServerName.Text = "Step 3: Friendly Name";
            // 
            // txtServerGivenName
            // 
            this.txtServerGivenName.BackColor = System.Drawing.Color.White;
            this.txtServerGivenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerGivenName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerGivenName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtServerGivenName.Location = new System.Drawing.Point(16, 291);
            this.txtServerGivenName.Name = "txtServerGivenName";
            this.txtServerGivenName.Size = new System.Drawing.Size(346, 29);
            this.txtServerGivenName.TabIndex = 48;
            this.toolTip1.SetToolTip(this.txtServerGivenName, "Give the server a user-friendly name to reference within Borealis.");
            // 
            // lblDestinationDetailsSubtext
            // 
            this.lblDestinationDetailsSubtext.AutoSize = true;
            this.lblDestinationDetailsSubtext.BackColor = System.Drawing.Color.Transparent;
            this.lblDestinationDetailsSubtext.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblDestinationDetailsSubtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblDestinationDetailsSubtext.Location = new System.Drawing.Point(13, 234);
            this.lblDestinationDetailsSubtext.Name = "lblDestinationDetailsSubtext";
            this.lblDestinationDetailsSubtext.Size = new System.Drawing.Size(305, 13);
            this.lblDestinationDetailsSubtext.TabIndex = 49;
            this.lblDestinationDetailsSubtext.Text = " (Leave blank if you want it installed in the same directory as BSM)";
            this.toolTip1.SetToolTip(this.lblDestinationDetailsSubtext, "If you leave this field blank, the server will be deployed directly alongside Bor" +
        "ealis in a subdirectory.");
            // 
            // panelProgress
            // 
            this.panelProgress.BackColor = System.Drawing.Color.Transparent;
            this.panelProgress.Controls.Add(this.lblDownloadProgress);
            this.panelProgress.Controls.Add(this.lblDownloadProgressDetails);
            this.panelProgress.Controls.Add(this.progressbarDownloadProgressOverall);
            this.panelProgress.Location = new System.Drawing.Point(5, 434);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(717, 53);
            this.panelProgress.TabIndex = 50;
            // 
            // lblVerifyIntegrity
            // 
            this.lblVerifyIntegrity.AutoSize = true;
            this.lblVerifyIntegrity.BackColor = System.Drawing.Color.Transparent;
            this.lblVerifyIntegrity.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblVerifyIntegrity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblVerifyIntegrity.Location = new System.Drawing.Point(52, 522);
            this.lblVerifyIntegrity.Name = "lblVerifyIntegrity";
            this.lblVerifyIntegrity.Size = new System.Drawing.Size(125, 19);
            this.lblVerifyIntegrity.TabIndex = 51;
            this.lblVerifyIntegrity.Text = "Validate Server Files";
            this.toolTip1.SetToolTip(this.lblVerifyIntegrity, "Verify that server files are not corrupt by rechecking them.  \r\n(May remove custo" +
        "m server configurations)");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // chkVerifyIntegrity
            // 
            this.chkVerifyIntegrity.BackColor = System.Drawing.Color.Transparent;
            this.chkVerifyIntegrity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkVerifyIntegrity.BackgroundImage")));
            this.chkVerifyIntegrity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkVerifyIntegrity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkVerifyIntegrity.Location = new System.Drawing.Point(16, 521);
            this.chkVerifyIntegrity.Name = "chkVerifyIntegrity";
            this.chkVerifyIntegrity.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.chkVerifyIntegrity.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.chkVerifyIntegrity.Size = new System.Drawing.Size(35, 20);
            this.chkVerifyIntegrity.TabIndex = 52;
            this.toolTip1.SetToolTip(this.chkVerifyIntegrity, "Verify that server files are not corrupt by rechecking them.  \r\n(May remove custo" +
        "m server configurations)");
            this.chkVerifyIntegrity.Value = false;
            // 
            // btnDeployGameserver
            // 
            this.btnDeployGameserver.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeployGameserver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnDeployGameserver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeployGameserver.BorderRadius = 0;
            this.btnDeployGameserver.ButtonText = "Deploy   ";
            this.btnDeployGameserver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeployGameserver.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeployGameserver.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnDeployGameserver.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeployGameserver.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeployGameserver.Iconimage")));
            this.btnDeployGameserver.Iconimage_right = null;
            this.btnDeployGameserver.Iconimage_right_Selected = null;
            this.btnDeployGameserver.Iconimage_Selected = null;
            this.btnDeployGameserver.IconMarginLeft = 0;
            this.btnDeployGameserver.IconMarginRight = 0;
            this.btnDeployGameserver.IconRightVisible = true;
            this.btnDeployGameserver.IconRightZoom = 0D;
            this.btnDeployGameserver.IconVisible = true;
            this.btnDeployGameserver.IconZoom = 90D;
            this.btnDeployGameserver.IsTab = false;
            this.btnDeployGameserver.Location = new System.Drawing.Point(568, 493);
            this.btnDeployGameserver.Name = "btnDeployGameserver";
            this.btnDeployGameserver.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnDeployGameserver.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeployGameserver.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeployGameserver.selected = false;
            this.btnDeployGameserver.Size = new System.Drawing.Size(143, 48);
            this.btnDeployGameserver.TabIndex = 14;
            this.btnDeployGameserver.Text = "Deploy   ";
            this.btnDeployGameserver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeployGameserver.Textcolor = System.Drawing.Color.White;
            this.btnDeployGameserver.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnDeployGameserver, "Deploy the gameserver using the current configuration.");
            this.btnDeployGameserver.Click += new System.EventHandler(this.btnDeployGameserver_Click);
            // 
            // btnCancelDeployGameserver
            // 
            this.btnCancelDeployGameserver.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.btnCancelDeployGameserver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.btnCancelDeployGameserver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelDeployGameserver.BorderRadius = 0;
            this.btnCancelDeployGameserver.ButtonText = "Cancel";
            this.btnCancelDeployGameserver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelDeployGameserver.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelDeployGameserver.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnCancelDeployGameserver.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelDeployGameserver.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancelDeployGameserver.Iconimage")));
            this.btnCancelDeployGameserver.Iconimage_right = null;
            this.btnCancelDeployGameserver.Iconimage_right_Selected = null;
            this.btnCancelDeployGameserver.Iconimage_Selected = null;
            this.btnCancelDeployGameserver.IconMarginLeft = 0;
            this.btnCancelDeployGameserver.IconMarginRight = 0;
            this.btnCancelDeployGameserver.IconRightVisible = true;
            this.btnCancelDeployGameserver.IconRightZoom = 0D;
            this.btnCancelDeployGameserver.IconVisible = true;
            this.btnCancelDeployGameserver.IconZoom = 45D;
            this.btnCancelDeployGameserver.IsTab = false;
            this.btnCancelDeployGameserver.Location = new System.Drawing.Point(413, 493);
            this.btnCancelDeployGameserver.Name = "btnCancelDeployGameserver";
            this.btnCancelDeployGameserver.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.btnCancelDeployGameserver.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnCancelDeployGameserver.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelDeployGameserver.selected = false;
            this.btnCancelDeployGameserver.Size = new System.Drawing.Size(143, 48);
            this.btnCancelDeployGameserver.TabIndex = 41;
            this.btnCancelDeployGameserver.Text = "Cancel";
            this.btnCancelDeployGameserver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelDeployGameserver.Textcolor = System.Drawing.Color.White;
            this.btnCancelDeployGameserver.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnCancelDeployGameserver, "Forcefully terminate deployment (leftover files need to be manually cleaned up).");
            this.btnCancelDeployGameserver.Click += new System.EventHandler(this.btnCancelDeployGameserver_Click);
            // 
            // btnSteamToken
            // 
            this.btnSteamToken.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSteamToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnSteamToken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSteamToken.BorderRadius = 0;
            this.btnSteamToken.ButtonText = "Authorize";
            this.btnSteamToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSteamToken.DisabledColor = System.Drawing.Color.Gray;
            this.btnSteamToken.Enabled = false;
            this.btnSteamToken.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnSteamToken.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSteamToken.Iconimage = null;
            this.btnSteamToken.Iconimage_right = null;
            this.btnSteamToken.Iconimage_right_Selected = null;
            this.btnSteamToken.Iconimage_Selected = null;
            this.btnSteamToken.IconMarginLeft = 0;
            this.btnSteamToken.IconMarginRight = 0;
            this.btnSteamToken.IconRightVisible = true;
            this.btnSteamToken.IconRightZoom = 0D;
            this.btnSteamToken.IconVisible = true;
            this.btnSteamToken.IconZoom = 90D;
            this.btnSteamToken.IsTab = false;
            this.btnSteamToken.Location = new System.Drawing.Point(630, 43);
            this.btnSteamToken.Name = "btnSteamToken";
            this.btnSteamToken.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnSteamToken.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSteamToken.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSteamToken.selected = false;
            this.btnSteamToken.Size = new System.Drawing.Size(81, 29);
            this.btnSteamToken.TabIndex = 68;
            this.btnSteamToken.Text = "Authorize";
            this.btnSteamToken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSteamToken.Textcolor = System.Drawing.Color.White;
            this.btnSteamToken.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteamToken.Click += new System.EventHandler(this.btnSteamToken_Click);
            // 
            // lblSteamToken
            // 
            this.lblSteamToken.AutoSize = true;
            this.lblSteamToken.BackColor = System.Drawing.Color.Transparent;
            this.lblSteamToken.Enabled = false;
            this.lblSteamToken.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblSteamToken.ForeColor = System.Drawing.Color.White;
            this.lblSteamToken.Location = new System.Drawing.Point(474, 27);
            this.lblSteamToken.Name = "lblSteamToken";
            this.lblSteamToken.Size = new System.Drawing.Size(96, 13);
            this.lblSteamToken.TabIndex = 67;
            this.lblSteamToken.Text = "Steam Guard Code:";
            // 
            // txtSteamToken
            // 
            this.txtSteamToken.BackColor = System.Drawing.Color.White;
            this.txtSteamToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSteamToken.Enabled = false;
            this.txtSteamToken.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteamToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtSteamToken.Location = new System.Drawing.Point(513, 43);
            this.txtSteamToken.Name = "txtSteamToken";
            this.txtSteamToken.Size = new System.Drawing.Size(111, 29);
            this.txtSteamToken.TabIndex = 66;
            this.txtSteamToken.Text = "NOT READY";
            this.txtSteamToken.Click += new System.EventHandler(this.txtSteamToken_Click);
            // 
            // txtSteamPassword
            // 
            this.txtSteamPassword.BackColor = System.Drawing.Color.White;
            this.txtSteamPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSteamPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteamPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtSteamPassword.Location = new System.Drawing.Point(196, 43);
            this.txtSteamPassword.Name = "txtSteamPassword";
            this.txtSteamPassword.Size = new System.Drawing.Size(311, 29);
            this.txtSteamPassword.TabIndex = 63;
            this.txtSteamPassword.UseSystemPasswordChar = true;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(13, 27);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(396, 13);
            this.bunifuCustomLabel4.TabIndex = 62;
            this.bunifuCustomLabel4.Text = "You will need your Steam username and password to deploy this specific gameserver" +
    ".";
            // 
            // txtSteamUsername
            // 
            this.txtSteamUsername.BackColor = System.Drawing.Color.White;
            this.txtSteamUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSteamUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteamUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtSteamUsername.Location = new System.Drawing.Point(16, 43);
            this.txtSteamUsername.Name = "txtSteamUsername";
            this.txtSteamUsername.Size = new System.Drawing.Size(174, 29);
            this.txtSteamUsername.TabIndex = 61;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 6);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(252, 21);
            this.bunifuCustomLabel1.TabIndex = 59;
            this.bunifuCustomLabel1.Text = "Provide Credentials for Steam Guard";
            // 
            // SteamGuardProcess
            // 
            this.SteamGuardProcess.StartInfo.Domain = "";
            this.SteamGuardProcess.StartInfo.LoadUserProfile = false;
            this.SteamGuardProcess.StartInfo.Password = null;
            this.SteamGuardProcess.StartInfo.StandardErrorEncoding = null;
            this.SteamGuardProcess.StartInfo.StandardOutputEncoding = null;
            this.SteamGuardProcess.StartInfo.UserName = "";
            this.SteamGuardProcess.SynchronizingObject = this;
            // 
            // panelSteamGuard
            // 
            this.panelSteamGuard.BackColor = System.Drawing.Color.Transparent;
            this.panelSteamGuard.Controls.Add(this.bunifuCustomLabel6);
            this.panelSteamGuard.Controls.Add(this.bunifuCustomLabel3);
            this.panelSteamGuard.Controls.Add(this.bunifuCustomLabel1);
            this.panelSteamGuard.Controls.Add(this.btnSteamToken);
            this.panelSteamGuard.Controls.Add(this.txtSteamUsername);
            this.panelSteamGuard.Controls.Add(this.lblSteamToken);
            this.panelSteamGuard.Controls.Add(this.bunifuCustomLabel4);
            this.panelSteamGuard.Controls.Add(this.txtSteamToken);
            this.panelSteamGuard.Controls.Add(this.txtSteamPassword);
            this.panelSteamGuard.Location = new System.Drawing.Point(0, 334);
            this.panelSteamGuard.Name = "panelSteamGuard";
            this.panelSteamGuard.Size = new System.Drawing.Size(725, 94);
            this.panelSteamGuard.TabIndex = 69;
            this.panelSteamGuard.Visible = false;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(193, 72);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(48, 13);
            this.bunifuCustomLabel6.TabIndex = 70;
            this.bunifuCustomLabel6.Text = "Password";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(13, 72);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(54, 13);
            this.bunifuCustomLabel3.TabIndex = 69;
            this.bunifuCustomLabel3.Text = "Username";
            // 
            // TAB_DEPLOYMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.BackgroundImage = global::Borealis.Properties.Resources.backdrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 557);
            this.Controls.Add(this.panelSteamGuard);
            this.Controls.Add(this.chkVerifyIntegrity);
            this.Controls.Add(this.lblVerifyIntegrity);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.lblDestinationDetailsSubtext);
            this.Controls.Add(this.txtServerGivenName);
            this.Controls.Add(this.lblServerNameDetails);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.btnDeployGameserver);
            this.Controls.Add(this.btnCancelDeployGameserver);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dropdownServerSelection);
            this.Controls.Add(this.lblDestinationDetails);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.btnBrowseDestination);
            this.Controls.Add(this.lblSelectServer);
            this.Controls.Add(this.txtboxDestinationFolder);
            this.Controls.Add(this.lblSelectServerDetails);
            this.Controls.Add(this.lblDestination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TAB_DEPLOYMENT";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "sd";
            this.Load += new System.EventHandler(this.ServerDeployment_LoadAsync);
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            this.panelSteamGuard.ResumeLayout(false);
            this.panelSteamGuard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnDeployGameserver;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSelectServer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDestination;
        private System.Windows.Forms.TextBox txtboxDestinationFolder;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSelectServerDetails;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowseDestination;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDownloadProgressDetails;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDestinationDetails;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDownloadProgress;
        private System.Windows.Forms.FolderBrowserDialog browseDestinationFolder;
        private MetroFramework.Controls.MetroComboBox dropdownServerSelection;
        private Bunifu.Framework.UI.BunifuProgressBar progressbarDownloadProgressOverall;
        private Bunifu.Framework.UI.BunifuCustomLabel lblServerNameDetails;
        private Bunifu.Framework.UI.BunifuCustomLabel lblServerName;
        private System.Windows.Forms.TextBox txtServerGivenName;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelDeployGameserver;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDestinationDetailsSubtext;
        private System.Windows.Forms.Panel panelProgress;
        private Bunifu.Framework.UI.BunifuiOSSwitch chkVerifyIntegrity;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVerifyIntegrity;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSteamToken;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSteamToken;
        private System.Windows.Forms.TextBox txtSteamToken;
        private System.Windows.Forms.TextBox txtSteamPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox txtSteamUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Diagnostics.Process SteamGuardProcess;
        private System.Windows.Forms.Panel panelSteamGuard;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}