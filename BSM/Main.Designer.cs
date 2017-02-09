namespace Borealis
{
    partial class BorealisServerManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorealisServerManager));
            this.sidemenu = new System.Windows.Forms.Panel();
            this.toggleExperimentalMode = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.lblAutoRestart = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblAttribution = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelTabExperimental = new System.Windows.Forms.Panel();
            this.tabExperimental = new Bunifu.Framework.UI.BunifuFlatButton();
            this.indicatorTabExperimental = new System.Windows.Forms.Panel();
            this.panelTabControl = new System.Windows.Forms.Panel();
            this.tabControlGameservers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.indicatorTabControl = new System.Windows.Forms.Panel();
            this.panelTabManagement = new System.Windows.Forms.Panel();
            this.tabManageGameservers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.indicatorTabManagement = new System.Windows.Forms.Panel();
            this.panelTabDeployment = new System.Windows.Forms.Panel();
            this.tabDeployGameservers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.indicatorTabDeployment = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panelTabDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.indicatorTabDashboard = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVersion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExitProgram = new Bunifu.Framework.UI.BunifuImageButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.fadingTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.mainIcon = new System.Windows.Forms.PictureBox();
            this.sidemenu.SuspendLayout();
            this.panelTabExperimental.SuspendLayout();
            this.panelTabControl.SuspendLayout();
            this.panelTabManagement.SuspendLayout();
            this.panelTabDeployment.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.header.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sidemenu.Controls.Add(this.toggleExperimentalMode);
            this.sidemenu.Controls.Add(this.lblAutoRestart);
            this.sidemenu.Controls.Add(this.lblAttribution);
            this.sidemenu.Controls.Add(this.panelTabExperimental);
            this.sidemenu.Controls.Add(this.panelTabControl);
            this.sidemenu.Controls.Add(this.panelTabManagement);
            this.sidemenu.Controls.Add(this.panelTabDeployment);
            this.sidemenu.Controls.Add(this.panelDashboard);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 45);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(260, 537);
            this.sidemenu.TabIndex = 0;
            // 
            // toggleExperimentalMode
            // 
            this.toggleExperimentalMode.BackColor = System.Drawing.Color.Transparent;
            this.toggleExperimentalMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleExperimentalMode.BackgroundImage")));
            this.toggleExperimentalMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toggleExperimentalMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleExperimentalMode.Location = new System.Drawing.Point(9, 502);
            this.toggleExperimentalMode.Name = "toggleExperimentalMode";
            this.toggleExperimentalMode.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.toggleExperimentalMode.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.toggleExperimentalMode.Size = new System.Drawing.Size(43, 25);
            this.toggleExperimentalMode.TabIndex = 44;
            this.toggleExperimentalMode.Value = false;
            this.toggleExperimentalMode.OnValueChange += new System.EventHandler(this.toggleExperimentalMode_OnValueChange);
            // 
            // lblAutoRestart
            // 
            this.lblAutoRestart.AutoSize = true;
            this.lblAutoRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lblAutoRestart.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblAutoRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.lblAutoRestart.Location = new System.Drawing.Point(58, 508);
            this.lblAutoRestart.Name = "lblAutoRestart";
            this.lblAutoRestart.Size = new System.Drawing.Size(124, 19);
            this.lblAutoRestart.TabIndex = 43;
            this.lblAutoRestart.Text = "Experimental Mode";
            // 
            // lblAttribution
            // 
            this.lblAttribution.AutoSize = true;
            this.lblAttribution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lblAttribution.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblAttribution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.lblAttribution.Location = new System.Drawing.Point(220, 514);
            this.lblAttribution.Name = "lblAttribution";
            this.lblAttribution.Size = new System.Drawing.Size(35, 13);
            this.lblAttribution.TabIndex = 23;
            this.lblAttribution.Text = "About";
            this.lblAttribution.Click += new System.EventHandler(this.lblAttribution_Click);
            this.lblAttribution.MouseLeave += new System.EventHandler(this.lblAttribution_MouseLeave);
            this.lblAttribution.MouseHover += new System.EventHandler(this.lblAttribution_MouseHover);
            // 
            // panelTabExperimental
            // 
            this.panelTabExperimental.Controls.Add(this.tabExperimental);
            this.panelTabExperimental.Controls.Add(this.indicatorTabExperimental);
            this.panelTabExperimental.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabExperimental.Location = new System.Drawing.Point(0, 192);
            this.panelTabExperimental.Name = "panelTabExperimental";
            this.panelTabExperimental.Size = new System.Drawing.Size(260, 48);
            this.panelTabExperimental.TabIndex = 31;
            this.panelTabExperimental.Visible = false;
            // 
            // tabExperimental
            // 
            this.tabExperimental.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabExperimental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabExperimental.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabExperimental.BorderRadius = 0;
            this.tabExperimental.ButtonText = "    Experimental Area";
            this.tabExperimental.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabExperimental.DisabledColor = System.Drawing.Color.Gray;
            this.tabExperimental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabExperimental.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.tabExperimental.Iconcolor = System.Drawing.Color.Transparent;
            this.tabExperimental.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabExperimental.Iconimage")));
            this.tabExperimental.Iconimage_right = null;
            this.tabExperimental.Iconimage_right_Selected = null;
            this.tabExperimental.Iconimage_Selected = null;
            this.tabExperimental.IconMarginLeft = 0;
            this.tabExperimental.IconMarginRight = 0;
            this.tabExperimental.IconRightVisible = true;
            this.tabExperimental.IconRightZoom = 0D;
            this.tabExperimental.IconVisible = true;
            this.tabExperimental.IconZoom = 58D;
            this.tabExperimental.IsTab = true;
            this.tabExperimental.Location = new System.Drawing.Point(0, 0);
            this.tabExperimental.Name = "tabExperimental";
            this.tabExperimental.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabExperimental.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.tabExperimental.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.tabExperimental.selected = false;
            this.tabExperimental.Size = new System.Drawing.Size(255, 48);
            this.tabExperimental.TabIndex = 19;
            this.tabExperimental.Text = "    Experimental Area";
            this.tabExperimental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabExperimental.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.tabExperimental.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExperimental.Click += new System.EventHandler(this.tabExperimental_Click);
            // 
            // indicatorTabExperimental
            // 
            this.indicatorTabExperimental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.indicatorTabExperimental.Dock = System.Windows.Forms.DockStyle.Right;
            this.indicatorTabExperimental.Location = new System.Drawing.Point(255, 0);
            this.indicatorTabExperimental.Name = "indicatorTabExperimental";
            this.indicatorTabExperimental.Size = new System.Drawing.Size(5, 48);
            this.indicatorTabExperimental.TabIndex = 18;
            this.indicatorTabExperimental.Visible = false;
            // 
            // panelTabControl
            // 
            this.panelTabControl.Controls.Add(this.tabControlGameservers);
            this.panelTabControl.Controls.Add(this.indicatorTabControl);
            this.panelTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabControl.Location = new System.Drawing.Point(0, 144);
            this.panelTabControl.Name = "panelTabControl";
            this.panelTabControl.Size = new System.Drawing.Size(260, 48);
            this.panelTabControl.TabIndex = 30;
            // 
            // tabControlGameservers
            // 
            this.tabControlGameservers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabControlGameservers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabControlGameservers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabControlGameservers.BorderRadius = 0;
            this.tabControlGameservers.ButtonText = "    Control GameServers";
            this.tabControlGameservers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlGameservers.DisabledColor = System.Drawing.Color.Gray;
            this.tabControlGameservers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGameservers.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.tabControlGameservers.Iconcolor = System.Drawing.Color.Transparent;
            this.tabControlGameservers.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabControlGameservers.Iconimage")));
            this.tabControlGameservers.Iconimage_right = null;
            this.tabControlGameservers.Iconimage_right_Selected = null;
            this.tabControlGameservers.Iconimage_Selected = null;
            this.tabControlGameservers.IconMarginLeft = 0;
            this.tabControlGameservers.IconMarginRight = 0;
            this.tabControlGameservers.IconRightVisible = true;
            this.tabControlGameservers.IconRightZoom = 0D;
            this.tabControlGameservers.IconVisible = true;
            this.tabControlGameservers.IconZoom = 45D;
            this.tabControlGameservers.IsTab = true;
            this.tabControlGameservers.Location = new System.Drawing.Point(0, 0);
            this.tabControlGameservers.Name = "tabControlGameservers";
            this.tabControlGameservers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabControlGameservers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.tabControlGameservers.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.tabControlGameservers.selected = false;
            this.tabControlGameservers.Size = new System.Drawing.Size(255, 48);
            this.tabControlGameservers.TabIndex = 19;
            this.tabControlGameservers.Text = "    Control GameServers";
            this.tabControlGameservers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabControlGameservers.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.tabControlGameservers.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlGameservers.Click += new System.EventHandler(this.tabControlGameservers_Click);
            // 
            // indicatorTabControl
            // 
            this.indicatorTabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.indicatorTabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.indicatorTabControl.Location = new System.Drawing.Point(255, 0);
            this.indicatorTabControl.Name = "indicatorTabControl";
            this.indicatorTabControl.Size = new System.Drawing.Size(5, 48);
            this.indicatorTabControl.TabIndex = 18;
            this.indicatorTabControl.Visible = false;
            // 
            // panelTabManagement
            // 
            this.panelTabManagement.Controls.Add(this.tabManageGameservers);
            this.panelTabManagement.Controls.Add(this.indicatorTabManagement);
            this.panelTabManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabManagement.Location = new System.Drawing.Point(0, 96);
            this.panelTabManagement.Name = "panelTabManagement";
            this.panelTabManagement.Size = new System.Drawing.Size(260, 48);
            this.panelTabManagement.TabIndex = 29;
            // 
            // tabManageGameservers
            // 
            this.tabManageGameservers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabManageGameservers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabManageGameservers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabManageGameservers.BorderRadius = 0;
            this.tabManageGameservers.ButtonText = "    Manage GameServers";
            this.tabManageGameservers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabManageGameservers.DisabledColor = System.Drawing.Color.Gray;
            this.tabManageGameservers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManageGameservers.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.tabManageGameservers.Iconcolor = System.Drawing.Color.Transparent;
            this.tabManageGameservers.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabManageGameservers.Iconimage")));
            this.tabManageGameservers.Iconimage_right = null;
            this.tabManageGameservers.Iconimage_right_Selected = null;
            this.tabManageGameservers.Iconimage_Selected = null;
            this.tabManageGameservers.IconMarginLeft = 0;
            this.tabManageGameservers.IconMarginRight = 0;
            this.tabManageGameservers.IconRightVisible = true;
            this.tabManageGameservers.IconRightZoom = 0D;
            this.tabManageGameservers.IconVisible = true;
            this.tabManageGameservers.IconZoom = 50D;
            this.tabManageGameservers.IsTab = true;
            this.tabManageGameservers.Location = new System.Drawing.Point(0, 0);
            this.tabManageGameservers.Name = "tabManageGameservers";
            this.tabManageGameservers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabManageGameservers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.tabManageGameservers.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.tabManageGameservers.selected = false;
            this.tabManageGameservers.Size = new System.Drawing.Size(255, 48);
            this.tabManageGameservers.TabIndex = 19;
            this.tabManageGameservers.Text = "    Manage GameServers";
            this.tabManageGameservers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabManageGameservers.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.tabManageGameservers.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabManageGameservers.Click += new System.EventHandler(this.tabManageGameservers_Click);
            // 
            // indicatorTabManagement
            // 
            this.indicatorTabManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.indicatorTabManagement.Dock = System.Windows.Forms.DockStyle.Right;
            this.indicatorTabManagement.Location = new System.Drawing.Point(255, 0);
            this.indicatorTabManagement.Name = "indicatorTabManagement";
            this.indicatorTabManagement.Size = new System.Drawing.Size(5, 48);
            this.indicatorTabManagement.TabIndex = 18;
            this.indicatorTabManagement.Visible = false;
            // 
            // panelTabDeployment
            // 
            this.panelTabDeployment.Controls.Add(this.tabDeployGameservers);
            this.panelTabDeployment.Controls.Add(this.indicatorTabDeployment);
            this.panelTabDeployment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabDeployment.Location = new System.Drawing.Point(0, 48);
            this.panelTabDeployment.Name = "panelTabDeployment";
            this.panelTabDeployment.Size = new System.Drawing.Size(260, 48);
            this.panelTabDeployment.TabIndex = 28;
            // 
            // tabDeployGameservers
            // 
            this.tabDeployGameservers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabDeployGameservers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabDeployGameservers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDeployGameservers.BorderRadius = 0;
            this.tabDeployGameservers.ButtonText = "    Deploy GameServers";
            this.tabDeployGameservers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabDeployGameservers.DisabledColor = System.Drawing.Color.Gray;
            this.tabDeployGameservers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDeployGameservers.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.tabDeployGameservers.Iconcolor = System.Drawing.Color.Transparent;
            this.tabDeployGameservers.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabDeployGameservers.Iconimage")));
            this.tabDeployGameservers.Iconimage_right = null;
            this.tabDeployGameservers.Iconimage_right_Selected = null;
            this.tabDeployGameservers.Iconimage_Selected = null;
            this.tabDeployGameservers.IconMarginLeft = 0;
            this.tabDeployGameservers.IconMarginRight = 0;
            this.tabDeployGameservers.IconRightVisible = true;
            this.tabDeployGameservers.IconRightZoom = 0D;
            this.tabDeployGameservers.IconVisible = true;
            this.tabDeployGameservers.IconZoom = 55D;
            this.tabDeployGameservers.IsTab = true;
            this.tabDeployGameservers.Location = new System.Drawing.Point(0, 0);
            this.tabDeployGameservers.Name = "tabDeployGameservers";
            this.tabDeployGameservers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabDeployGameservers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.tabDeployGameservers.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.tabDeployGameservers.selected = false;
            this.tabDeployGameservers.Size = new System.Drawing.Size(255, 48);
            this.tabDeployGameservers.TabIndex = 18;
            this.tabDeployGameservers.Text = "    Deploy GameServers";
            this.tabDeployGameservers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabDeployGameservers.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.tabDeployGameservers.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDeployGameservers.Click += new System.EventHandler(this.tabDeployGameservers_Click_1);
            // 
            // indicatorTabDeployment
            // 
            this.indicatorTabDeployment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.indicatorTabDeployment.Dock = System.Windows.Forms.DockStyle.Right;
            this.indicatorTabDeployment.Location = new System.Drawing.Point(255, 0);
            this.indicatorTabDeployment.Name = "indicatorTabDeployment";
            this.indicatorTabDeployment.Size = new System.Drawing.Size(5, 48);
            this.indicatorTabDeployment.TabIndex = 17;
            this.indicatorTabDeployment.Visible = false;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.panelTabDashboard);
            this.panelDashboard.Controls.Add(this.indicatorTabDashboard);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(260, 48);
            this.panelDashboard.TabIndex = 27;
            // 
            // panelTabDashboard
            // 
            this.panelTabDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.panelTabDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.panelTabDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTabDashboard.BorderRadius = 0;
            this.panelTabDashboard.ButtonText = "    Dashboard";
            this.panelTabDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTabDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.panelTabDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabDashboard.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.panelTabDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.panelTabDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("panelTabDashboard.Iconimage")));
            this.panelTabDashboard.Iconimage_right = null;
            this.panelTabDashboard.Iconimage_right_Selected = null;
            this.panelTabDashboard.Iconimage_Selected = null;
            this.panelTabDashboard.IconMarginLeft = 0;
            this.panelTabDashboard.IconMarginRight = 0;
            this.panelTabDashboard.IconRightVisible = true;
            this.panelTabDashboard.IconRightZoom = 0D;
            this.panelTabDashboard.IconVisible = true;
            this.panelTabDashboard.IconZoom = 55D;
            this.panelTabDashboard.IsTab = true;
            this.panelTabDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelTabDashboard.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.panelTabDashboard.Name = "panelTabDashboard";
            this.panelTabDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.panelTabDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.panelTabDashboard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.panelTabDashboard.selected = false;
            this.panelTabDashboard.Size = new System.Drawing.Size(255, 48);
            this.panelTabDashboard.TabIndex = 18;
            this.panelTabDashboard.Text = "    Dashboard";
            this.panelTabDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelTabDashboard.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.panelTabDashboard.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTabDashboard.Click += new System.EventHandler(this.tabDashboard_Click_1);
            // 
            // indicatorTabDashboard
            // 
            this.indicatorTabDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.indicatorTabDashboard.Dock = System.Windows.Forms.DockStyle.Right;
            this.indicatorTabDashboard.Location = new System.Drawing.Point(255, 0);
            this.indicatorTabDashboard.Name = "indicatorTabDashboard";
            this.indicatorTabDashboard.Size = new System.Drawing.Size(5, 48);
            this.indicatorTabDashboard.TabIndex = 17;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(77)))));
            this.header.Controls.Add(this.panel2);
            this.header.Controls.Add(this.btnExitProgram);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(957, 45);
            this.header.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.mainIcon);
            this.panel2.Controls.Add(this.lblVersion);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 45);
            this.panel2.TabIndex = 5;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Light", 7F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.lblVersion.Location = new System.Drawing.Point(44, 26);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(66, 12);
            this.lblVersion.TabIndex = 31;
            this.lblVersion.Text = "<Version Info>";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(41, 4);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(218, 25);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Borealis Server Manager";
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(77)))));
            this.btnExitProgram.Image = ((System.Drawing.Image)(resources.GetObject("btnExitProgram.Image")));
            this.btnExitProgram.ImageActive = null;
            this.btnExitProgram.Location = new System.Drawing.Point(923, 9);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(26, 26);
            this.btnExitProgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExitProgram.TabIndex = 4;
            this.btnExitProgram.TabStop = false;
            this.btnExitProgram.Zoom = 20;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Advanced Tech Toolkit 4.0";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Advanced Tech Toolkit 4.0";
            this.notifyIcon1.Visible = true;
            // 
            // fadingTransition
            // 
            this.fadingTransition.Delay = 1;
            // 
            // mainIcon
            // 
            this.mainIcon.BackgroundImage = global::Borealis_Default_Namespace.Properties.Resources.System_Task_Filled_100;
            this.mainIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainIcon.Location = new System.Drawing.Point(9, 6);
            this.mainIcon.Name = "mainIcon";
            this.mainIcon.Size = new System.Drawing.Size(30, 30);
            this.mainIcon.TabIndex = 45;
            this.mainIcon.TabStop = false;
            // 
            // BorealisServerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 582);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.header);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "BorealisServerManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameServerManager v0.1";
            this.Load += new System.EventHandler(this.BorealisServerManager_Load);
            this.sidemenu.ResumeLayout(false);
            this.sidemenu.PerformLayout();
            this.panelTabExperimental.ResumeLayout(false);
            this.panelTabControl.ResumeLayout(false);
            this.panelTabManagement.ResumeLayout(false);
            this.panelTabDeployment.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidemenu;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAttribution;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panelTabControl;
        private System.Windows.Forms.Panel panelTabManagement;
        private System.Windows.Forms.Panel panelTabDeployment;
        private System.Windows.Forms.Panel indicatorTabDeployment;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel indicatorTabDashboard;
        private System.Windows.Forms.Panel indicatorTabControl;
        private Bunifu.Framework.UI.BunifuFlatButton tabControlGameservers;
        private Bunifu.Framework.UI.BunifuFlatButton tabManageGameservers;
        private System.Windows.Forms.Panel indicatorTabManagement;
        private Bunifu.Framework.UI.BunifuFlatButton tabDeployGameservers;
        private Bunifu.Framework.UI.BunifuFlatButton panelTabDashboard;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton btnExitProgram;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVersion;
        private Bunifu.Framework.UI.BunifuFormFadeTransition fadingTransition;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panelTabExperimental;
        private Bunifu.Framework.UI.BunifuFlatButton tabExperimental;
        private System.Windows.Forms.Panel indicatorTabExperimental;
        private Bunifu.Framework.UI.BunifuiOSSwitch toggleExperimentalMode;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAutoRestart;
        private System.Windows.Forms.PictureBox mainIcon;
    }
}

