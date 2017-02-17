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
            this.lblAttribution = new Bunifu.Framework.UI.BunifuCustomLabel();
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
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.mainIcon = new System.Windows.Forms.PictureBox();
            this.lblVersion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExitProgram = new Bunifu.Framework.UI.BunifuImageButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.sidemenu.SuspendLayout();
            this.panelTabControl.SuspendLayout();
            this.panelTabManagement.SuspendLayout();
            this.panelTabDeployment.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sidemenu.Controls.Add(this.lblAttribution);
            this.sidemenu.Controls.Add(this.panelTabControl);
            this.sidemenu.Controls.Add(this.panelTabManagement);
            this.sidemenu.Controls.Add(this.panelTabDeployment);
            this.sidemenu.Controls.Add(this.panelDashboard);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 45);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(260, 554);
            this.sidemenu.TabIndex = 0;
            // 
            // lblAttribution
            // 
            this.lblAttribution.AutoSize = true;
            this.lblAttribution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lblAttribution.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblAttribution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.lblAttribution.Location = new System.Drawing.Point(220, 532);
            this.lblAttribution.Name = "lblAttribution";
            this.lblAttribution.Size = new System.Drawing.Size(0, 13);
            this.lblAttribution.TabIndex = 23;
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
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.mainIcon);
            this.header.Controls.Add(this.lblVersion);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Controls.Add(this.btnExitProgram);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(985, 45);
            this.header.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.bunifuImageButton1.Image = global::Borealis_Default_Namespace.Properties.Resources.HELP_ICON;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(914, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 46;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // mainIcon
            // 
            this.mainIcon.BackgroundImage = global::Borealis_Default_Namespace.Properties.Resources.TitleIcon_WHITE;
            this.mainIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainIcon.Location = new System.Drawing.Point(10, 7);
            this.mainIcon.Name = "mainIcon";
            this.mainIcon.Size = new System.Drawing.Size(30, 30);
            this.mainIcon.TabIndex = 45;
            this.mainIcon.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Light", 7F);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(45, 27);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(66, 12);
            this.lblVersion.TabIndex = 31;
            this.lblVersion.Text = "<Version Info>";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(42, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(218, 25);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Borealis Server Manager";
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.btnExitProgram.Image = ((System.Drawing.Image)(resources.GetObject("btnExitProgram.Image")));
            this.btnExitProgram.ImageActive = null;
            this.btnExitProgram.Location = new System.Drawing.Point(949, 9);
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
            this.notifyIcon1.BalloonTipText = "Borealis Server Manager";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Borealis Server Manager";
            this.notifyIcon1.Visible = true;
            // 
            // BorealisServerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 599);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.header);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "BorealisServerManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borealis Server Manager";
            this.Load += new System.EventHandler(this.BorealisServerManager_Load);
            this.sidemenu.ResumeLayout(false);
            this.sidemenu.PerformLayout();
            this.panelTabControl.ResumeLayout(false);
            this.panelTabManagement.ResumeLayout(false);
            this.panelTabDeployment.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitProgram)).EndInit();
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
        private Bunifu.Framework.UI.BunifuCustomLabel lblVersion;
        private System.Windows.Forms.PictureBox mainIcon;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

