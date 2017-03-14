namespace Borealis
{
    partial class TAB_SCHEDULEDTASKS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAB_SCHEDULEDTASKS));
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tableScheduledTasks = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnBrowseDestination = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtboxCommand = new System.Windows.Forms.TextBox();
            this.lblArguments = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtboxTaskName = new System.Windows.Forms.TextBox();
            this.lblFriendlyName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtboxRunTime = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkVerifyIntegrity = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.lblEnableTasks = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGameServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnServerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelAddTask = new System.Windows.Forms.Panel();
            this.btnAddTask = new Bunifu.Framework.UI.BunifuFlatButton();
            this.switchEnabled = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.tableScheduledTasks)).BeginInit();
            this.panelAddTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(156)))), ((int)(((byte)(159)))));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(12, 42);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(338, 19);
            this.bunifuCustomLabel14.TabIndex = 15;
            this.bunifuCustomLabel14.Text = "Schedule server backups and general maintenance tasks.";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(10, 10);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(175, 32);
            this.bunifuCustomLabel16.TabIndex = 14;
            this.bunifuCustomLabel16.Text = "Scheduled Tasks";
            // 
            // tableScheduledTasks
            // 
            this.tableScheduledTasks.AllowUserToAddRows = false;
            this.tableScheduledTasks.AllowUserToDeleteRows = false;
            this.tableScheduledTasks.AllowUserToOrderColumns = true;
            this.tableScheduledTasks.AllowUserToResizeColumns = false;
            this.tableScheduledTasks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.tableScheduledTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableScheduledTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableScheduledTasks.BackgroundColor = System.Drawing.Color.White;
            this.tableScheduledTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableScheduledTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableScheduledTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableScheduledTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableScheduledTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.columnGameServerName,
            this.columnServerType,
            this.Column2});
            this.tableScheduledTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableScheduledTasks.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableScheduledTasks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableScheduledTasks.DoubleBuffered = false;
            this.tableScheduledTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tableScheduledTasks.EnableHeadersVisualStyles = false;
            this.tableScheduledTasks.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.tableScheduledTasks.HeaderForeColor = System.Drawing.Color.White;
            this.tableScheduledTasks.Location = new System.Drawing.Point(0, 288);
            this.tableScheduledTasks.MaximumSize = new System.Drawing.Size(0, 269);
            this.tableScheduledTasks.MultiSelect = false;
            this.tableScheduledTasks.Name = "tableScheduledTasks";
            this.tableScheduledTasks.ReadOnly = true;
            this.tableScheduledTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableScheduledTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableScheduledTasks.RowHeadersVisible = false;
            this.tableScheduledTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tableScheduledTasks.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tableScheduledTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableScheduledTasks.ShowCellToolTips = false;
            this.tableScheduledTasks.ShowEditingIcon = false;
            this.tableScheduledTasks.Size = new System.Drawing.Size(725, 269);
            this.tableScheduledTasks.TabIndex = 44;
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBrowseDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnBrowseDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseDestination.BorderRadius = 0;
            this.btnBrowseDestination.ButtonText = "Add Task";
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
            this.btnBrowseDestination.Location = new System.Drawing.Point(16, 91);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnBrowseDestination.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBrowseDestination.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowseDestination.selected = false;
            this.btnBrowseDestination.Size = new System.Drawing.Size(112, 29);
            this.btnBrowseDestination.TabIndex = 45;
            this.btnBrowseDestination.Text = "Add Task";
            this.btnBrowseDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowseDestination.Textcolor = System.Drawing.Color.White;
            this.btnBrowseDestination.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(129)))), ((int)(((byte)(67)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Modify Task";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(141, 91);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(129)))), ((int)(((byte)(67)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(77)))), ((int)(((byte)(36)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(112, 29);
            this.bunifuFlatButton1.TabIndex = 46;
            this.bunifuFlatButton1.Text = "Modify Task";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Remove Task";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(266, 91);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(112, 29);
            this.bunifuFlatButton2.TabIndex = 47;
            this.bunifuFlatButton2.Text = "Remove Task";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // txtboxCommand
            // 
            this.txtboxCommand.BackColor = System.Drawing.Color.White;
            this.txtboxCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxCommand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtboxCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxCommand.Location = new System.Drawing.Point(0, 88);
            this.txtboxCommand.Name = "txtboxCommand";
            this.txtboxCommand.Size = new System.Drawing.Size(362, 25);
            this.txtboxCommand.TabIndex = 55;
            // 
            // lblArguments
            // 
            this.lblArguments.AutoSize = true;
            this.lblArguments.BackColor = System.Drawing.Color.Transparent;
            this.lblArguments.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblArguments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblArguments.Location = new System.Drawing.Point(-2, 66);
            this.lblArguments.Name = "lblArguments";
            this.lblArguments.Size = new System.Drawing.Size(139, 19);
            this.lblArguments.TabIndex = 54;
            this.lblArguments.Text = "Command to Execute:";
            // 
            // txtboxTaskName
            // 
            this.txtboxTaskName.BackColor = System.Drawing.Color.White;
            this.txtboxTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxTaskName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtboxTaskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxTaskName.Location = new System.Drawing.Point(0, 25);
            this.txtboxTaskName.Name = "txtboxTaskName";
            this.txtboxTaskName.Size = new System.Drawing.Size(362, 25);
            this.txtboxTaskName.TabIndex = 53;
            // 
            // lblFriendlyName
            // 
            this.lblFriendlyName.AutoSize = true;
            this.lblFriendlyName.BackColor = System.Drawing.Color.Transparent;
            this.lblFriendlyName.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblFriendlyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblFriendlyName.Location = new System.Drawing.Point(-4, 3);
            this.lblFriendlyName.Name = "lblFriendlyName";
            this.lblFriendlyName.Size = new System.Drawing.Size(75, 19);
            this.lblFriendlyName.TabIndex = 52;
            this.lblFriendlyName.Text = "Task Name:";
            // 
            // txtboxRunTime
            // 
            this.txtboxRunTime.BackColor = System.Drawing.Color.White;
            this.txtboxRunTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxRunTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtboxRunTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxRunTime.Location = new System.Drawing.Point(398, 25);
            this.txtboxRunTime.Name = "txtboxRunTime";
            this.txtboxRunTime.Size = new System.Drawing.Size(295, 25);
            this.txtboxRunTime.TabIndex = 57;
            this.toolTip1.SetToolTip(this.txtboxRunTime, resources.GetString("txtboxRunTime.ToolTip"));
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(396, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(83, 19);
            this.bunifuCustomLabel1.TabIndex = 56;
            this.bunifuCustomLabel1.Text = "Time to Run:";
            // 
            // chkVerifyIntegrity
            // 
            this.chkVerifyIntegrity.BackColor = System.Drawing.Color.Transparent;
            this.chkVerifyIntegrity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkVerifyIntegrity.BackgroundImage")));
            this.chkVerifyIntegrity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkVerifyIntegrity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkVerifyIntegrity.Location = new System.Drawing.Point(414, 95);
            this.chkVerifyIntegrity.Name = "chkVerifyIntegrity";
            this.chkVerifyIntegrity.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.chkVerifyIntegrity.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.chkVerifyIntegrity.Size = new System.Drawing.Size(43, 25);
            this.chkVerifyIntegrity.TabIndex = 61;
            this.chkVerifyIntegrity.Value = false;
            this.chkVerifyIntegrity.Visible = false;
            // 
            // lblEnableTasks
            // 
            this.lblEnableTasks.AutoSize = true;
            this.lblEnableTasks.BackColor = System.Drawing.Color.Transparent;
            this.lblEnableTasks.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblEnableTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblEnableTasks.Location = new System.Drawing.Point(463, 101);
            this.lblEnableTasks.Name = "lblEnableTasks";
            this.lblEnableTasks.Size = new System.Drawing.Size(80, 19);
            this.lblEnableTasks.TabIndex = 60;
            this.lblEnableTasks.Text = "Enable Tasks";
            this.lblEnableTasks.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Friendly Description";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.ToolTipText = "A useful description to describe what your task does.";
            this.Column1.Width = 123;
            // 
            // columnGameServerName
            // 
            this.columnGameServerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnGameServerName.HeaderText = "Command to Execute";
            this.columnGameServerName.Name = "columnGameServerName";
            this.columnGameServerName.ReadOnly = true;
            this.columnGameServerName.ToolTipText = "The command the user wants to execute based on the schedule.";
            // 
            // columnServerType
            // 
            this.columnServerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnServerType.HeaderText = "When to Run";
            this.columnServerType.Name = "columnServerType";
            this.columnServerType.ReadOnly = true;
            this.columnServerType.ToolTipText = "When you want the command to execute.";
            this.columnServerType.Width = 72;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Enabled";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.ToolTipText = "Determines whether the task is set to run or not.";
            this.Column2.Width = 72;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // panelAddTask
            // 
            this.panelAddTask.BackColor = System.Drawing.Color.Transparent;
            this.panelAddTask.Controls.Add(this.bunifuFlatButton3);
            this.panelAddTask.Controls.Add(this.switchEnabled);
            this.panelAddTask.Controls.Add(this.bunifuCustomLabel2);
            this.panelAddTask.Controls.Add(this.btnAddTask);
            this.panelAddTask.Controls.Add(this.lblFriendlyName);
            this.panelAddTask.Controls.Add(this.txtboxTaskName);
            this.panelAddTask.Controls.Add(this.lblArguments);
            this.panelAddTask.Controls.Add(this.txtboxRunTime);
            this.panelAddTask.Controls.Add(this.txtboxCommand);
            this.panelAddTask.Controls.Add(this.bunifuCustomLabel1);
            this.panelAddTask.Location = new System.Drawing.Point(16, 126);
            this.panelAddTask.Name = "panelAddTask";
            this.panelAddTask.Size = new System.Drawing.Size(697, 126);
            this.panelAddTask.TabIndex = 62;
            this.panelAddTask.Visible = false;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnAddTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTask.BorderRadius = 0;
            this.btnAddTask.ButtonText = "Add";
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnAddTask.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddTask.Iconimage = null;
            this.btnAddTask.Iconimage_right = null;
            this.btnAddTask.Iconimage_right_Selected = null;
            this.btnAddTask.Iconimage_Selected = null;
            this.btnAddTask.IconMarginLeft = 0;
            this.btnAddTask.IconMarginRight = 0;
            this.btnAddTask.IconRightVisible = true;
            this.btnAddTask.IconRightZoom = 0D;
            this.btnAddTask.IconVisible = true;
            this.btnAddTask.IconZoom = 90D;
            this.btnAddTask.IsTab = false;
            this.btnAddTask.Location = new System.Drawing.Point(518, 88);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnAddTask.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddTask.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddTask.selected = false;
            this.btnAddTask.Size = new System.Drawing.Size(81, 29);
            this.btnAddTask.TabIndex = 63;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddTask.Textcolor = System.Drawing.Color.White;
            this.btnAddTask.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // switchEnabled
            // 
            this.switchEnabled.BackColor = System.Drawing.Color.Transparent;
            this.switchEnabled.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchEnabled.BackgroundImage")));
            this.switchEnabled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchEnabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchEnabled.Location = new System.Drawing.Point(398, 88);
            this.switchEnabled.Name = "switchEnabled";
            this.switchEnabled.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.switchEnabled.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.switchEnabled.Size = new System.Drawing.Size(43, 25);
            this.switchEnabled.TabIndex = 64;
            this.switchEnabled.Value = true;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(447, 94);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(54, 19);
            this.bunifuCustomLabel2.TabIndex = 63;
            this.bunifuCustomLabel2.Text = "Enable?";
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Cancel";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(612, 88);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(81, 29);
            this.bunifuFlatButton3.TabIndex = 65;
            this.bunifuFlatButton3.Text = "Cancel";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // TAB_SCHEDULEDTASKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.BackgroundImage = global::Borealis_Default_Namespace.Properties.Resources.backdrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 557);
            this.Controls.Add(this.panelAddTask);
            this.Controls.Add(this.chkVerifyIntegrity);
            this.Controls.Add(this.lblEnableTasks);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnBrowseDestination);
            this.Controls.Add(this.tableScheduledTasks);
            this.Controls.Add(this.bunifuCustomLabel14);
            this.Controls.Add(this.bunifuCustomLabel16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TAB_SCHEDULEDTASKS";
            this.Text = "TAB_ScheduledTasks";
            ((System.ComponentModel.ISupportInitialize)(this.tableScheduledTasks)).EndInit();
            this.panelAddTask.ResumeLayout(false);
            this.panelAddTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tableScheduledTasks;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowseDestination;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.TextBox txtboxCommand;
        private Bunifu.Framework.UI.BunifuCustomLabel lblArguments;
        private System.Windows.Forms.TextBox txtboxTaskName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFriendlyName;
        private System.Windows.Forms.TextBox txtboxRunTime;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGameServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnServerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Bunifu.Framework.UI.BunifuiOSSwitch chkVerifyIntegrity;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEnableTasks;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelAddTask;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddTask;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchEnabled;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
    }
}