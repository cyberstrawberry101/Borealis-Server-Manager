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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorealisServerManager));
            this.formHeaderDragger = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.btnExitProgram = new Bunifu.Framework.UI.BunifuImageButton();
            this.attribution_tab = new Bunifu.Framework.UI.BunifuImageButton();
            this.mainIcon = new System.Windows.Forms.PictureBox();
            this.lblVersion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelBorealisTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuBarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DO_NOT_DELETE = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.panel9 = new System.Windows.Forms.Panel();
            this.management_tab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.management_indicator = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.menuBarlblAdvanced = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.control_tab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.control_indicator = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.deployment_indicator = new System.Windows.Forms.Panel();
            this.deployment_tab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard_tab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dashboard_indicator = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuBarlblServerManagement = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuBarlblMenu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.scheduledtasks_tab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.scheduledtasks_indicator = new System.Windows.Forms.Panel();
            this.MENU_TOOLTIPS = new System.Windows.Forms.ToolTip(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.menuBarTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attribution_tab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).BeginInit();
            this.menuBarPanel.SuspendLayout();
            this.DO_NOT_DELETE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // formHeaderDragger
            // 
            this.formHeaderDragger.Fixed = true;
            this.formHeaderDragger.Horizontal = true;
            this.formHeaderDragger.TargetControl = this.header;
            this.formHeaderDragger.Vertical = true;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.header.Controls.Add(this.btnExitProgram);
            this.header.Controls.Add(this.attribution_tab);
            this.header.Controls.Add(this.mainIcon);
            this.header.Controls.Add(this.lblVersion);
            this.header.Controls.Add(this.labelBorealisTitle);
            this.menuBarTransition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(965, 45);
            this.header.TabIndex = 1;
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.menuBarTransition.SetDecoration(this.btnExitProgram, BunifuAnimatorNS.DecorationType.None);
            this.btnExitProgram.Image = ((System.Drawing.Image)(resources.GetObject("btnExitProgram.Image")));
            this.btnExitProgram.ImageActive = null;
            this.btnExitProgram.Location = new System.Drawing.Point(927, 10);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(26, 26);
            this.btnExitProgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExitProgram.TabIndex = 4;
            this.btnExitProgram.TabStop = false;
            this.MENU_TOOLTIPS.SetToolTip(this.btnExitProgram, "Save active configuration to disk and close Borealis.");
            this.btnExitProgram.Zoom = 20;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // attribution_tab
            // 
            this.attribution_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuBarTransition.SetDecoration(this.attribution_tab, BunifuAnimatorNS.DecorationType.None);
            this.attribution_tab.Image = global::Borealis.Properties.Resources.HELP_ICON;
            this.attribution_tab.ImageActive = null;
            this.attribution_tab.Location = new System.Drawing.Point(890, 10);
            this.attribution_tab.Name = "attribution_tab";
            this.attribution_tab.Size = new System.Drawing.Size(26, 26);
            this.attribution_tab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.attribution_tab.TabIndex = 46;
            this.attribution_tab.TabStop = false;
            this.MENU_TOOLTIPS.SetToolTip(this.attribution_tab, "Detailed attribution and credits for contributors to the project.");
            this.attribution_tab.Zoom = 20;
            this.attribution_tab.Click += new System.EventHandler(this.attribution_tab_Click);
            // 
            // mainIcon
            // 
            this.mainIcon.BackgroundImage = global::Borealis.Properties.Resources.TitleIcon_WHITE;
            this.mainIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuBarTransition.SetDecoration(this.mainIcon, BunifuAnimatorNS.DecorationType.None);
            this.mainIcon.Location = new System.Drawing.Point(10, 7);
            this.mainIcon.Name = "mainIcon";
            this.mainIcon.Size = new System.Drawing.Size(30, 30);
            this.mainIcon.TabIndex = 45;
            this.mainIcon.TabStop = false;
            this.MENU_TOOLTIPS.SetToolTip(this.mainIcon, "Boo!");
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(60)))));
            this.menuBarTransition.SetDecoration(this.lblVersion, BunifuAnimatorNS.DecorationType.None);
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Light", 7F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.lblVersion.Location = new System.Drawing.Point(45, 27);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(47, 12);
            this.lblVersion.TabIndex = 31;
            this.lblVersion.Text = "<Version>";
            this.MENU_TOOLTIPS.SetToolTip(this.lblVersion, "This program is in the alpha stage, meaning it is not fully featured yet, please " +
        "be patient.");
            // 
            // labelBorealisTitle
            // 
            this.labelBorealisTitle.AutoSize = true;
            this.menuBarTransition.SetDecoration(this.labelBorealisTitle, BunifuAnimatorNS.DecorationType.None);
            this.labelBorealisTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorealisTitle.ForeColor = System.Drawing.Color.White;
            this.labelBorealisTitle.Location = new System.Drawing.Point(42, 5);
            this.labelBorealisTitle.Name = "labelBorealisTitle";
            this.labelBorealisTitle.Size = new System.Drawing.Size(218, 25);
            this.labelBorealisTitle.TabIndex = 2;
            this.labelBorealisTitle.Text = "Borealis Server Manager";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Borealis Dedicated Server Manager";
            this.notifyIcon1.Visible = true;
            // 
            // menuBarPanel
            // 
            this.menuBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuBarPanel.ColumnCount = 1;
            this.menuBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuBarPanel.Controls.Add(this.DO_NOT_DELETE, 0, 8);
            this.menuBarPanel.Controls.Add(this.panel9, 0, 4);
            this.menuBarPanel.Controls.Add(this.panel13, 0, 6);
            this.menuBarPanel.Controls.Add(this.panel11, 0, 5);
            this.menuBarPanel.Controls.Add(this.panel7, 0, 3);
            this.menuBarPanel.Controls.Add(this.panel3, 0, 1);
            this.menuBarPanel.Controls.Add(this.panel2, 0, 2);
            this.menuBarPanel.Controls.Add(this.panel1, 0, 0);
            this.menuBarPanel.Controls.Add(this.panel4, 0, 7);
            this.menuBarTransition.SetDecoration(this.menuBarPanel, BunifuAnimatorNS.DecorationType.None);
            this.menuBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuBarPanel.Location = new System.Drawing.Point(0, 45);
            this.menuBarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuBarPanel.Name = "menuBarPanel";
            this.menuBarPanel.RowCount = 9;
            this.menuBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.menuBarPanel.Size = new System.Drawing.Size(240, 559);
            this.menuBarPanel.TabIndex = 28;
            // 
            // DO_NOT_DELETE
            // 
            this.DO_NOT_DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DO_NOT_DELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DO_NOT_DELETE.Controls.Add(this.pictureBox1);
            this.DO_NOT_DELETE.Controls.Add(this.tabForms);
            this.menuBarTransition.SetDecoration(this.DO_NOT_DELETE, BunifuAnimatorNS.DecorationType.None);
            this.DO_NOT_DELETE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DO_NOT_DELETE.Location = new System.Drawing.Point(0, 320);
            this.DO_NOT_DELETE.Margin = new System.Windows.Forms.Padding(0);
            this.DO_NOT_DELETE.Name = "DO_NOT_DELETE";
            this.DO_NOT_DELETE.Size = new System.Drawing.Size(240, 239);
            this.DO_NOT_DELETE.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Borealis.Properties.Resources.collapse_button;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuBarTransition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(7, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabForms
            // 
            this.menuBarTransition.SetDecoration(this.tabForms, BunifuAnimatorNS.DecorationType.None);
            this.tabForms.Location = new System.Drawing.Point(187, 250);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(37, 25);
            this.tabForms.TabIndex = 30;
            this.tabForms.SelectedIndexChanged += new System.EventHandler(this.tabForms_SelectedIndexChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel9.Controls.Add(this.management_tab);
            this.panel9.Controls.Add(this.management_indicator);
            this.menuBarTransition.SetDecoration(this.panel9, BunifuAnimatorNS.DecorationType.None);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 160);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(240, 40);
            this.panel9.TabIndex = 39;
            // 
            // management_tab
            // 
            this.management_tab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.management_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.management_tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.management_tab.BorderRadius = 0;
            this.management_tab.ButtonText = "   Manage GameServers";
            this.management_tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBarTransition.SetDecoration(this.management_tab, BunifuAnimatorNS.DecorationType.None);
            this.management_tab.DisabledColor = System.Drawing.Color.Gray;
            this.management_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.management_tab.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.management_tab.Iconcolor = System.Drawing.Color.Transparent;
            this.management_tab.Iconimage = ((System.Drawing.Image)(resources.GetObject("management_tab.Iconimage")));
            this.management_tab.Iconimage_right = null;
            this.management_tab.Iconimage_right_Selected = null;
            this.management_tab.Iconimage_Selected = null;
            this.management_tab.IconMarginLeft = 12;
            this.management_tab.IconMarginRight = 0;
            this.management_tab.IconRightVisible = false;
            this.management_tab.IconRightZoom = 0D;
            this.management_tab.IconVisible = true;
            this.management_tab.IconZoom = 50D;
            this.management_tab.IsTab = true;
            this.management_tab.Location = new System.Drawing.Point(0, 0);
            this.management_tab.Margin = new System.Windows.Forms.Padding(0);
            this.management_tab.Name = "management_tab";
            this.management_tab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.management_tab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.management_tab.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.management_tab.selected = true;
            this.management_tab.Size = new System.Drawing.Size(235, 40);
            this.management_tab.TabIndex = 19;
            this.management_tab.Text = "   Manage GameServers";
            this.management_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.management_tab.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.management_tab.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.MENU_TOOLTIPS.SetToolTip(this.management_tab, "Manage deployed gameservers with config files and other means.");
            this.management_tab.Click += new System.EventHandler(this.tabManageGameservers_Click);
            // 
            // management_indicator
            // 
            this.management_indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.menuBarTransition.SetDecoration(this.management_indicator, BunifuAnimatorNS.DecorationType.None);
            this.management_indicator.Dock = System.Windows.Forms.DockStyle.Right;
            this.management_indicator.Location = new System.Drawing.Point(235, 0);
            this.management_indicator.Margin = new System.Windows.Forms.Padding(0);
            this.management_indicator.Name = "management_indicator";
            this.management_indicator.Size = new System.Drawing.Size(5, 40);
            this.management_indicator.TabIndex = 40;
            this.management_indicator.Visible = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel13.Controls.Add(this.menuBarlblAdvanced);
            this.menuBarTransition.SetDecoration(this.panel13, BunifuAnimatorNS.DecorationType.None);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 240);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(240, 40);
            this.panel13.TabIndex = 43;
            // 
            // menuBarlblAdvanced
            // 
            this.menuBarlblAdvanced.AutoSize = true;
            this.menuBarlblAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuBarTransition.SetDecoration(this.menuBarlblAdvanced, BunifuAnimatorNS.DecorationType.None);
            this.menuBarlblAdvanced.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuBarlblAdvanced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.menuBarlblAdvanced.Location = new System.Drawing.Point(6, 22);
            this.menuBarlblAdvanced.Name = "menuBarlblAdvanced";
            this.menuBarlblAdvanced.Size = new System.Drawing.Size(60, 15);
            this.menuBarlblAdvanced.TabIndex = 50;
            this.menuBarlblAdvanced.Text = "Advanced";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel11.Controls.Add(this.control_tab);
            this.panel11.Controls.Add(this.control_indicator);
            this.menuBarTransition.SetDecoration(this.panel11, BunifuAnimatorNS.DecorationType.None);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 200);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(240, 40);
            this.panel11.TabIndex = 41;
            // 
            // control_tab
            // 
            this.control_tab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.control_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.control_tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.control_tab.BorderRadius = 0;
            this.control_tab.ButtonText = "   Control GameServers";
            this.control_tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBarTransition.SetDecoration(this.control_tab, BunifuAnimatorNS.DecorationType.None);
            this.control_tab.DisabledColor = System.Drawing.Color.Gray;
            this.control_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_tab.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.control_tab.Iconcolor = System.Drawing.Color.Transparent;
            this.control_tab.Iconimage = ((System.Drawing.Image)(resources.GetObject("control_tab.Iconimage")));
            this.control_tab.Iconimage_right = null;
            this.control_tab.Iconimage_right_Selected = null;
            this.control_tab.Iconimage_Selected = null;
            this.control_tab.IconMarginLeft = 14;
            this.control_tab.IconMarginRight = 0;
            this.control_tab.IconRightVisible = false;
            this.control_tab.IconRightZoom = 0D;
            this.control_tab.IconVisible = true;
            this.control_tab.IconZoom = 45D;
            this.control_tab.IsTab = true;
            this.control_tab.Location = new System.Drawing.Point(0, 0);
            this.control_tab.Margin = new System.Windows.Forms.Padding(0);
            this.control_tab.Name = "control_tab";
            this.control_tab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.control_tab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.control_tab.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.control_tab.selected = true;
            this.control_tab.Size = new System.Drawing.Size(235, 40);
            this.control_tab.TabIndex = 19;
            this.control_tab.Text = "   Control GameServers";
            this.control_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.control_tab.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.control_tab.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.MENU_TOOLTIPS.SetToolTip(this.control_tab, "Start, stop, and control deployed gameservers.");
            this.control_tab.Click += new System.EventHandler(this.tabControlGameservers_Click);
            // 
            // control_indicator
            // 
            this.control_indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.menuBarTransition.SetDecoration(this.control_indicator, BunifuAnimatorNS.DecorationType.None);
            this.control_indicator.Dock = System.Windows.Forms.DockStyle.Right;
            this.control_indicator.Location = new System.Drawing.Point(235, 0);
            this.control_indicator.Margin = new System.Windows.Forms.Padding(0);
            this.control_indicator.Name = "control_indicator";
            this.control_indicator.Size = new System.Drawing.Size(5, 40);
            this.control_indicator.TabIndex = 42;
            this.control_indicator.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel7.Controls.Add(this.deployment_indicator);
            this.panel7.Controls.Add(this.deployment_tab);
            this.menuBarTransition.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 120);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 40);
            this.panel7.TabIndex = 37;
            // 
            // deployment_indicator
            // 
            this.deployment_indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.menuBarTransition.SetDecoration(this.deployment_indicator, BunifuAnimatorNS.DecorationType.None);
            this.deployment_indicator.Dock = System.Windows.Forms.DockStyle.Right;
            this.deployment_indicator.Location = new System.Drawing.Point(235, 0);
            this.deployment_indicator.Margin = new System.Windows.Forms.Padding(0);
            this.deployment_indicator.Name = "deployment_indicator";
            this.deployment_indicator.Size = new System.Drawing.Size(5, 40);
            this.deployment_indicator.TabIndex = 38;
            this.deployment_indicator.Visible = false;
            // 
            // deployment_tab
            // 
            this.deployment_tab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.deployment_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.deployment_tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deployment_tab.BorderRadius = 0;
            this.deployment_tab.ButtonText = "   Deploy GameServers";
            this.deployment_tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBarTransition.SetDecoration(this.deployment_tab, BunifuAnimatorNS.DecorationType.None);
            this.deployment_tab.DisabledColor = System.Drawing.Color.Gray;
            this.deployment_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deployment_tab.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.deployment_tab.Iconcolor = System.Drawing.Color.Transparent;
            this.deployment_tab.Iconimage = ((System.Drawing.Image)(resources.GetObject("deployment_tab.Iconimage")));
            this.deployment_tab.Iconimage_right = null;
            this.deployment_tab.Iconimage_right_Selected = null;
            this.deployment_tab.Iconimage_Selected = null;
            this.deployment_tab.IconMarginLeft = 10;
            this.deployment_tab.IconMarginRight = 0;
            this.deployment_tab.IconRightVisible = false;
            this.deployment_tab.IconRightZoom = 0D;
            this.deployment_tab.IconVisible = true;
            this.deployment_tab.IconZoom = 55D;
            this.deployment_tab.IsTab = true;
            this.deployment_tab.Location = new System.Drawing.Point(0, 0);
            this.deployment_tab.Margin = new System.Windows.Forms.Padding(0);
            this.deployment_tab.Name = "deployment_tab";
            this.deployment_tab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.deployment_tab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.deployment_tab.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.deployment_tab.selected = true;
            this.deployment_tab.Size = new System.Drawing.Size(240, 40);
            this.deployment_tab.TabIndex = 18;
            this.deployment_tab.Text = "   Deploy GameServers";
            this.deployment_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deployment_tab.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.deployment_tab.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.MENU_TOOLTIPS.SetToolTip(this.deployment_tab, "Deploy a new gameserver of your choosing with user-specified parameters.");
            this.deployment_tab.Click += new System.EventHandler(this.tabDeployGameservers_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.dashboard_tab);
            this.panel3.Controls.Add(this.dashboard_indicator);
            this.menuBarTransition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 40);
            this.panel3.TabIndex = 33;
            // 
            // dashboard_tab
            // 
            this.dashboard_tab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.dashboard_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.dashboard_tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboard_tab.BorderRadius = 0;
            this.dashboard_tab.ButtonText = "   Dashboard";
            this.dashboard_tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBarTransition.SetDecoration(this.dashboard_tab, BunifuAnimatorNS.DecorationType.None);
            this.dashboard_tab.DisabledColor = System.Drawing.Color.Gray;
            this.dashboard_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_tab.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.dashboard_tab.Iconcolor = System.Drawing.Color.Transparent;
            this.dashboard_tab.Iconimage = ((System.Drawing.Image)(resources.GetObject("dashboard_tab.Iconimage")));
            this.dashboard_tab.Iconimage_right = null;
            this.dashboard_tab.Iconimage_right_Selected = null;
            this.dashboard_tab.Iconimage_Selected = null;
            this.dashboard_tab.IconMarginLeft = 10;
            this.dashboard_tab.IconMarginRight = 0;
            this.dashboard_tab.IconRightVisible = false;
            this.dashboard_tab.IconRightZoom = 0D;
            this.dashboard_tab.IconVisible = true;
            this.dashboard_tab.IconZoom = 55D;
            this.dashboard_tab.IsTab = true;
            this.dashboard_tab.Location = new System.Drawing.Point(0, 0);
            this.dashboard_tab.Margin = new System.Windows.Forms.Padding(0);
            this.dashboard_tab.Name = "dashboard_tab";
            this.dashboard_tab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.dashboard_tab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dashboard_tab.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.dashboard_tab.selected = true;
            this.dashboard_tab.Size = new System.Drawing.Size(235, 40);
            this.dashboard_tab.TabIndex = 18;
            this.dashboard_tab.Text = "   Dashboard";
            this.dashboard_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_tab.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.dashboard_tab.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.MENU_TOOLTIPS.SetToolTip(this.dashboard_tab, "List performance metrics of both the overall system as well as individual gameser" +
        "vers.");
            this.dashboard_tab.Click += new System.EventHandler(this.tabDashboard_Click_1);
            // 
            // dashboard_indicator
            // 
            this.dashboard_indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.menuBarTransition.SetDecoration(this.dashboard_indicator, BunifuAnimatorNS.DecorationType.None);
            this.dashboard_indicator.Dock = System.Windows.Forms.DockStyle.Right;
            this.dashboard_indicator.Location = new System.Drawing.Point(235, 0);
            this.dashboard_indicator.Margin = new System.Windows.Forms.Padding(0);
            this.dashboard_indicator.Name = "dashboard_indicator";
            this.dashboard_indicator.Size = new System.Drawing.Size(5, 40);
            this.dashboard_indicator.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.menuBarlblServerManagement);
            this.menuBarTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 40);
            this.panel2.TabIndex = 32;
            // 
            // menuBarlblServerManagement
            // 
            this.menuBarlblServerManagement.AutoSize = true;
            this.menuBarlblServerManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuBarTransition.SetDecoration(this.menuBarlblServerManagement, BunifuAnimatorNS.DecorationType.None);
            this.menuBarlblServerManagement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuBarlblServerManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.menuBarlblServerManagement.Location = new System.Drawing.Point(6, 22);
            this.menuBarlblServerManagement.Name = "menuBarlblServerManagement";
            this.menuBarlblServerManagement.Size = new System.Drawing.Size(113, 15);
            this.menuBarlblServerManagement.TabIndex = 49;
            this.menuBarlblServerManagement.Text = "Server Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.menuBarlblMenu);
            this.menuBarTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 40);
            this.panel1.TabIndex = 31;
            // 
            // menuBarlblMenu
            // 
            this.menuBarlblMenu.AutoSize = true;
            this.menuBarlblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuBarTransition.SetDecoration(this.menuBarlblMenu, BunifuAnimatorNS.DecorationType.None);
            this.menuBarlblMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuBarlblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(86)))), ((int)(((byte)(93)))));
            this.menuBarlblMenu.Location = new System.Drawing.Point(6, 22);
            this.menuBarlblMenu.Name = "menuBarlblMenu";
            this.menuBarlblMenu.Size = new System.Drawing.Size(34, 15);
            this.menuBarlblMenu.TabIndex = 48;
            this.menuBarlblMenu.Text = "Main";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.scheduledtasks_tab);
            this.panel4.Controls.Add(this.scheduledtasks_indicator);
            this.menuBarTransition.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 280);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 40);
            this.panel4.TabIndex = 50;
            // 
            // scheduledtasks_tab
            // 
            this.scheduledtasks_tab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.scheduledtasks_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.scheduledtasks_tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scheduledtasks_tab.BorderRadius = 0;
            this.scheduledtasks_tab.ButtonText = "   Scheduled Tasks";
            this.scheduledtasks_tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBarTransition.SetDecoration(this.scheduledtasks_tab, BunifuAnimatorNS.DecorationType.None);
            this.scheduledtasks_tab.DisabledColor = System.Drawing.Color.Gray;
            this.scheduledtasks_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduledtasks_tab.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.scheduledtasks_tab.Iconcolor = System.Drawing.Color.Transparent;
            this.scheduledtasks_tab.Iconimage = global::Borealis.Properties.Resources.TIME_ICON;
            this.scheduledtasks_tab.Iconimage_right = null;
            this.scheduledtasks_tab.Iconimage_right_Selected = null;
            this.scheduledtasks_tab.Iconimage_Selected = null;
            this.scheduledtasks_tab.IconMarginLeft = 10;
            this.scheduledtasks_tab.IconMarginRight = 0;
            this.scheduledtasks_tab.IconRightVisible = false;
            this.scheduledtasks_tab.IconRightZoom = 0D;
            this.scheduledtasks_tab.IconVisible = true;
            this.scheduledtasks_tab.IconZoom = 60D;
            this.scheduledtasks_tab.IsTab = true;
            this.scheduledtasks_tab.Location = new System.Drawing.Point(0, 0);
            this.scheduledtasks_tab.Margin = new System.Windows.Forms.Padding(0);
            this.scheduledtasks_tab.Name = "scheduledtasks_tab";
            this.scheduledtasks_tab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.scheduledtasks_tab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.scheduledtasks_tab.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.scheduledtasks_tab.selected = true;
            this.scheduledtasks_tab.Size = new System.Drawing.Size(235, 40);
            this.scheduledtasks_tab.TabIndex = 21;
            this.scheduledtasks_tab.Text = "   Scheduled Tasks";
            this.scheduledtasks_tab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scheduledtasks_tab.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.scheduledtasks_tab.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.MENU_TOOLTIPS.SetToolTip(this.scheduledtasks_tab, "Schedule backups, server updates, and maintenance tasks.");
            this.scheduledtasks_tab.Click += new System.EventHandler(this.scheduledtasks_tab_Click);
            // 
            // scheduledtasks_indicator
            // 
            this.scheduledtasks_indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.menuBarTransition.SetDecoration(this.scheduledtasks_indicator, BunifuAnimatorNS.DecorationType.None);
            this.scheduledtasks_indicator.Dock = System.Windows.Forms.DockStyle.Right;
            this.scheduledtasks_indicator.Location = new System.Drawing.Point(235, 0);
            this.scheduledtasks_indicator.Margin = new System.Windows.Forms.Padding(0);
            this.scheduledtasks_indicator.Name = "scheduledtasks_indicator";
            this.scheduledtasks_indicator.Size = new System.Drawing.Size(5, 40);
            this.scheduledtasks_indicator.TabIndex = 44;
            this.scheduledtasks_indicator.Visible = false;
            // 
            // MENU_TOOLTIPS
            // 
            this.MENU_TOOLTIPS.AutoPopDelay = 10000;
            this.MENU_TOOLTIPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MENU_TOOLTIPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(155)))), ((int)(((byte)(166)))));
            this.MENU_TOOLTIPS.InitialDelay = 500;
            this.MENU_TOOLTIPS.ReshowDelay = 100;
            this.MENU_TOOLTIPS.ShowAlways = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.menuBarTransition.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(240, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(725, 5);
            this.panel6.TabIndex = 55;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // menuBarTransition
            // 
            this.menuBarTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.menuBarTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.menuBarTransition.DefaultAnimation = animation2;
            // 
            // BorealisServerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 604);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.menuBarPanel);
            this.Controls.Add(this.header);
            this.menuBarTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "BorealisServerManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borealis Server Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BorealisServerManager_FormClosed);
            this.Load += new System.EventHandler(this.BorealisServerManager_Load);
            this.MdiChildActivate += new System.EventHandler(this.BorealisServerManager_MdiChildActivate);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attribution_tab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainIcon)).EndInit();
            this.menuBarPanel.ResumeLayout(false);
            this.DO_NOT_DELETE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl formHeaderDragger;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Bunifu.Framework.UI.BunifuFlatButton control_tab;
        private Bunifu.Framework.UI.BunifuFlatButton management_tab;
        private Bunifu.Framework.UI.BunifuFlatButton deployment_tab;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton btnExitProgram;
        private Bunifu.Framework.UI.BunifuCustomLabel labelBorealisTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVersion;
        private System.Windows.Forms.PictureBox mainIcon;
        private Bunifu.Framework.UI.BunifuImageButton attribution_tab;
        private System.Windows.Forms.TableLayoutPanel menuBarPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel menuBarlblMenu;
        private Bunifu.Framework.UI.BunifuCustomLabel menuBarlblServerManagement;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton dashboard_tab;
        private System.Windows.Forms.Panel dashboard_indicator;
        private System.Windows.Forms.Panel control_indicator;
        private System.Windows.Forms.Panel management_indicator;
        private System.Windows.Forms.Panel deployment_indicator;
        private Bunifu.Framework.UI.BunifuCustomLabel menuBarlblAdvanced;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel scheduledtasks_indicator;
        private Bunifu.Framework.UI.BunifuFlatButton scheduledtasks_tab;
        private System.Windows.Forms.ToolTip MENU_TOOLTIPS;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition menuBarTransition;
        private System.Windows.Forms.Panel DO_NOT_DELETE;
        private System.Windows.Forms.TabControl tabForms;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

