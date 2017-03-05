namespace Borealis
{
    partial class ServerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBrowseDestination = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboboxGameserverList = new MetroFramework.Controls.MetroComboBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnUpdateServerConfig = new Bunifu.Framework.UI.BunifuFlatButton();
            this.serverPropertiesTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnLoadConfig = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.columnGameServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnServerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.serverPropertiesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBrowseDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnBrowseDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseDestination.BorderRadius = 0;
            this.btnBrowseDestination.ButtonText = "     Advanced Config";
            this.btnBrowseDestination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseDestination.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowseDestination.Enabled = false;
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
            this.btnBrowseDestination.Location = new System.Drawing.Point(418, 72);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnBrowseDestination.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBrowseDestination.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowseDestination.selected = false;
            this.btnBrowseDestination.Size = new System.Drawing.Size(125, 29);
            this.btnBrowseDestination.TabIndex = 44;
            this.btnBrowseDestination.Text = "     Advanced Config";
            this.btnBrowseDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseDestination.Textcolor = System.Drawing.Color.White;
            this.btnBrowseDestination.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnBrowseDestination, "Not implemented yet.");
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
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
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
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
            this.btnUpdateServerConfig.ButtonText = "Update";
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
            this.btnUpdateServerConfig.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateServerConfig.selected = false;
            this.btnUpdateServerConfig.Size = new System.Drawing.Size(143, 48);
            this.btnUpdateServerConfig.TabIndex = 14;
            this.btnUpdateServerConfig.Text = "Update";
            this.btnUpdateServerConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateServerConfig.Textcolor = System.Drawing.Color.White;
            this.btnUpdateServerConfig.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnUpdateServerConfig, "Commit the changes to the associated configuration files.");
            this.btnUpdateServerConfig.Click += new System.EventHandler(this.btnUpdateServerConfig_Click);
            // 
            // serverPropertiesTable
            // 
            this.serverPropertiesTable.AllowUserToAddRows = false;
            this.serverPropertiesTable.AllowUserToDeleteRows = false;
            this.serverPropertiesTable.AllowUserToOrderColumns = true;
            this.serverPropertiesTable.AllowUserToResizeColumns = false;
            this.serverPropertiesTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.serverPropertiesTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.serverPropertiesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serverPropertiesTable.BackgroundColor = System.Drawing.Color.White;
            this.serverPropertiesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serverPropertiesTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.serverPropertiesTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serverPropertiesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.serverPropertiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serverPropertiesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnGameServerName,
            this.columnServerType});
            this.serverPropertiesTable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serverPropertiesTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.serverPropertiesTable.DoubleBuffered = false;
            this.serverPropertiesTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.serverPropertiesTable.EnableHeadersVisualStyles = false;
            this.serverPropertiesTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.serverPropertiesTable.HeaderForeColor = System.Drawing.Color.White;
            this.serverPropertiesTable.Location = new System.Drawing.Point(18, 107);
            this.serverPropertiesTable.MultiSelect = false;
            this.serverPropertiesTable.Name = "serverPropertiesTable";
            this.serverPropertiesTable.ReadOnly = true;
            this.serverPropertiesTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serverPropertiesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.serverPropertiesTable.RowHeadersVisible = false;
            this.serverPropertiesTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.serverPropertiesTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serverPropertiesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serverPropertiesTable.ShowCellToolTips = false;
            this.serverPropertiesTable.ShowEditingIcon = false;
            this.serverPropertiesTable.Size = new System.Drawing.Size(693, 368);
            this.serverPropertiesTable.TabIndex = 45;
            this.toolTip1.SetToolTip(this.serverPropertiesTable, "Choose properties to change, and hit \'Update\' when you are done.");
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLoadConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnLoadConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadConfig.BorderRadius = 0;
            this.btnLoadConfig.ButtonText = "      Load Config";
            this.btnLoadConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadConfig.DisabledColor = System.Drawing.Color.Gray;
            this.btnLoadConfig.Enabled = false;
            this.btnLoadConfig.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnLoadConfig.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLoadConfig.Iconimage = null;
            this.btnLoadConfig.Iconimage_right = null;
            this.btnLoadConfig.Iconimage_right_Selected = null;
            this.btnLoadConfig.Iconimage_Selected = null;
            this.btnLoadConfig.IconMarginLeft = 0;
            this.btnLoadConfig.IconMarginRight = 0;
            this.btnLoadConfig.IconRightVisible = true;
            this.btnLoadConfig.IconRightZoom = 0D;
            this.btnLoadConfig.IconVisible = true;
            this.btnLoadConfig.IconZoom = 90D;
            this.btnLoadConfig.IsTab = false;
            this.btnLoadConfig.Location = new System.Drawing.Point(18, 72);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnLoadConfig.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLoadConfig.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLoadConfig.selected = false;
            this.btnLoadConfig.Size = new System.Drawing.Size(100, 29);
            this.btnLoadConfig.TabIndex = 46;
            this.btnLoadConfig.Text = "      Load Config";
            this.btnLoadConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadConfig.Textcolor = System.Drawing.Color.White;
            this.btnLoadConfig.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnLoadConfig, "Manually open the config files associated with the selected gameserver.");
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
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
            // columnGameServerName
            // 
            this.columnGameServerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnGameServerName.HeaderText = "Server Property";
            this.columnGameServerName.Name = "columnGameServerName";
            this.columnGameServerName.ReadOnly = true;
            this.columnGameServerName.Width = 110;
            // 
            // columnServerType
            // 
            this.columnServerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnServerType.HeaderText = "Value";
            this.columnServerType.Name = "columnServerType";
            this.columnServerType.ReadOnly = true;
            // 
            // ServerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(725, 557);
            this.Controls.Add(this.btnLoadConfig);
            this.Controls.Add(this.serverPropertiesTable);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnBrowseDestination);
            this.Controls.Add(this.comboboxGameserverList);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.btnUpdateServerConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServerManagement";
            this.Text = "ServerManagement";
            this.Load += new System.EventHandler(this.GSM_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serverPropertiesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateServerConfig;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private MetroFramework.Controls.MetroComboBox comboboxGameserverList;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowseDestination;
        private Bunifu.Framework.UI.BunifuCustomDataGrid serverPropertiesTable;
        private Bunifu.Framework.UI.BunifuFlatButton btnLoadConfig;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGameServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnServerType;
    }
}