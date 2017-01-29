namespace GameServer_Manager
{
    partial class GameServerManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameServerManager));
            this.sidemenu = new System.Windows.Forms.Panel();
            this.panelTabTechServices = new System.Windows.Forms.Panel();
            this.tabControlGameservers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.indicatorTabControl = new System.Windows.Forms.Panel();
            this.panelTabCustomerInformation = new System.Windows.Forms.Panel();
            this.tabManageGameservers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.indicatorTabManagement = new System.Windows.Forms.Panel();
            this.panelTabAuthentication = new System.Windows.Forms.Panel();
            this.tabDeployGameservers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.indicatorTabDeployment = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.indicatorTabDashboard = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExitProgram = new Bunifu.Framework.UI.BunifuImageButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundMetrics = new System.ComponentModel.BackgroundWorker();
            this.sidemenu.SuspendLayout();
            this.panelTabTechServices.SuspendLayout();
            this.panelTabCustomerInformation.SuspendLayout();
            this.panelTabAuthentication.SuspendLayout();
            this.panel1.SuspendLayout();
            this.header.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sidemenu.Controls.Add(this.panelTabTechServices);
            this.sidemenu.Controls.Add(this.panelTabCustomerInformation);
            this.sidemenu.Controls.Add(this.panelTabAuthentication);
            this.sidemenu.Controls.Add(this.panel1);
            this.sidemenu.Controls.Add(this.bunifuCustomLabel17);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 48);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(260, 534);
            this.sidemenu.TabIndex = 0;
            // 
            // panelTabTechServices
            // 
            this.panelTabTechServices.Controls.Add(this.tabControlGameservers);
            this.panelTabTechServices.Controls.Add(this.indicatorTabControl);
            this.panelTabTechServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabTechServices.Location = new System.Drawing.Point(0, 144);
            this.panelTabTechServices.Name = "panelTabTechServices";
            this.panelTabTechServices.Size = new System.Drawing.Size(260, 48);
            this.panelTabTechServices.TabIndex = 30;
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
            this.tabControlGameservers.Iconimage = global::GameServer_Manager.Properties.Resources.CONSOLE_ICON;
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
            // panelTabCustomerInformation
            // 
            this.panelTabCustomerInformation.Controls.Add(this.tabManageGameservers);
            this.panelTabCustomerInformation.Controls.Add(this.indicatorTabManagement);
            this.panelTabCustomerInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabCustomerInformation.Location = new System.Drawing.Point(0, 96);
            this.panelTabCustomerInformation.Name = "panelTabCustomerInformation";
            this.panelTabCustomerInformation.Size = new System.Drawing.Size(260, 48);
            this.panelTabCustomerInformation.TabIndex = 29;
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
            this.tabManageGameservers.Iconimage = global::GameServer_Manager.Properties.Resources.MANAGEMENT_ICON;
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
            // panelTabAuthentication
            // 
            this.panelTabAuthentication.Controls.Add(this.tabDeployGameservers);
            this.panelTabAuthentication.Controls.Add(this.indicatorTabDeployment);
            this.panelTabAuthentication.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabAuthentication.Location = new System.Drawing.Point(0, 48);
            this.panelTabAuthentication.Name = "panelTabAuthentication";
            this.panelTabAuthentication.Size = new System.Drawing.Size(260, 48);
            this.panelTabAuthentication.TabIndex = 28;
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
            this.tabDeployGameservers.Iconimage = global::GameServer_Manager.Properties.Resources.DEPLOY_ICON;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabDashboard);
            this.panel1.Controls.Add(this.indicatorTabDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 48);
            this.panel1.TabIndex = 27;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDashboard.BorderRadius = 0;
            this.tabDashboard.ButtonText = "    Dashboard";
            this.tabDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.tabDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDashboard.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.tabDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.tabDashboard.Iconimage = global::GameServer_Manager.Properties.Resources.DASHBOARD_ICON;
            this.tabDashboard.Iconimage_right = null;
            this.tabDashboard.Iconimage_right_Selected = null;
            this.tabDashboard.Iconimage_Selected = null;
            this.tabDashboard.IconMarginLeft = 0;
            this.tabDashboard.IconMarginRight = 0;
            this.tabDashboard.IconRightVisible = true;
            this.tabDashboard.IconRightZoom = 0D;
            this.tabDashboard.IconVisible = true;
            this.tabDashboard.IconZoom = 55D;
            this.tabDashboard.IsTab = true;
            this.tabDashboard.Location = new System.Drawing.Point(0, 0);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.tabDashboard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.tabDashboard.selected = false;
            this.tabDashboard.Size = new System.Drawing.Size(255, 48);
            this.tabDashboard.TabIndex = 18;
            this.tabDashboard.Text = "    Dashboard";
            this.tabDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabDashboard.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.tabDashboard.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDashboard.Click += new System.EventHandler(this.tabDashboard_Click_1);
            // 
            // indicatorTabDashboard
            // 
            this.indicatorTabDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.indicatorTabDashboard.Dock = System.Windows.Forms.DockStyle.Right;
            this.indicatorTabDashboard.Location = new System.Drawing.Point(255, 0);
            this.indicatorTabDashboard.Name = "indicatorTabDashboard";
            this.indicatorTabDashboard.Size = new System.Drawing.Size(5, 48);
            this.indicatorTabDashboard.TabIndex = 17;
            this.indicatorTabDashboard.Visible = false;
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.bunifuCustomLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(6, 513);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(35, 13);
            this.bunifuCustomLabel17.TabIndex = 23;
            this.bunifuCustomLabel17.Text = "About";
            this.bunifuCustomLabel17.Click += new System.EventHandler(this.bunifuCustomLabel17_Click);
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
            this.header.Size = new System.Drawing.Size(957, 48);
            this.header.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 48);
            this.panel2.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(4, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(228, 25);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "GameServerManager v0.1";
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(77)))));
            this.btnExitProgram.Image = ((System.Drawing.Image)(resources.GetObject("btnExitProgram.Image")));
            this.btnExitProgram.ImageActive = null;
            this.btnExitProgram.Location = new System.Drawing.Point(915, 9);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(30, 30);
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
            // backgroundMetrics
            // 
            // 
            // GameServerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(957, 582);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "GameServerManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameServerManager v0.1";
            this.Load += new System.EventHandler(this.Main_Load_1);
            this.sidemenu.ResumeLayout(false);
            this.sidemenu.PerformLayout();
            this.panelTabTechServices.ResumeLayout(false);
            this.panelTabCustomerInformation.ResumeLayout(false);
            this.panelTabAuthentication.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitProgram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidemenu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panelTabTechServices;
        private System.Windows.Forms.Panel panelTabCustomerInformation;
        private System.Windows.Forms.Panel panelTabAuthentication;
        private System.Windows.Forms.Panel indicatorTabDeployment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel indicatorTabDashboard;
        private System.Windows.Forms.Panel indicatorTabControl;
        private Bunifu.Framework.UI.BunifuFlatButton tabControlGameservers;
        private Bunifu.Framework.UI.BunifuFlatButton tabManageGameservers;
        private System.Windows.Forms.Panel indicatorTabManagement;
        private Bunifu.Framework.UI.BunifuFlatButton tabDeployGameservers;
        private Bunifu.Framework.UI.BunifuFlatButton tabDashboard;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton btnExitProgram;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundMetrics;
    }
}

