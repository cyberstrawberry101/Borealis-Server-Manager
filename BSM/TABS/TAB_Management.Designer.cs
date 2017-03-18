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
            this.btnLoadConfig = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtboxFriendlyName = new System.Windows.Forms.TextBox();
            this.txtboxArguments = new System.Windows.Forms.TextBox();
            this.btnDestroyServer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblFriendlyName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblArguments = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblConfigOutput = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtboxConfigOutput = new System.Windows.Forms.ListBox();
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
            this.btnUpdateServerConfig.OnHoverTextColor = System.Drawing.Color.White;
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
            // btnLoadConfig
            // 
            this.btnLoadConfig.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLoadConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnLoadConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadConfig.BorderRadius = 0;
            this.btnLoadConfig.ButtonText = "Load Config Manually";
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
            this.btnLoadConfig.Location = new System.Drawing.Point(413, 493);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnLoadConfig.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLoadConfig.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLoadConfig.selected = false;
            this.btnLoadConfig.Size = new System.Drawing.Size(143, 48);
            this.btnLoadConfig.TabIndex = 46;
            this.btnLoadConfig.Text = "Load Config Manually";
            this.btnLoadConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadConfig.Textcolor = System.Drawing.Color.White;
            this.btnLoadConfig.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnLoadConfig, "Manually open the config files associated with the selected gameserver.");
            this.btnLoadConfig.Visible = false;
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
            // txtboxFriendlyName
            // 
            this.txtboxFriendlyName.BackColor = System.Drawing.Color.White;
            this.txtboxFriendlyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxFriendlyName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtboxFriendlyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxFriendlyName.Location = new System.Drawing.Point(16, 102);
            this.txtboxFriendlyName.Name = "txtboxFriendlyName";
            this.txtboxFriendlyName.Size = new System.Drawing.Size(388, 25);
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
            this.txtboxArguments.Size = new System.Drawing.Size(388, 25);
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
            this.lblArguments.Location = new System.Drawing.Point(14, 143);
            this.lblArguments.Name = "lblArguments";
            this.lblArguments.Size = new System.Drawing.Size(120, 19);
            this.lblArguments.TabIndex = 50;
            this.lblArguments.Text = "Launch Arguments:";
            this.lblArguments.Visible = false;
            // 
            // lblConfigOutput
            // 
            this.lblConfigOutput.AutoSize = true;
            this.lblConfigOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblConfigOutput.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblConfigOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblConfigOutput.Location = new System.Drawing.Point(14, 219);
            this.lblConfigOutput.Name = "lblConfigOutput";
            this.lblConfigOutput.Size = new System.Drawing.Size(93, 19);
            this.lblConfigOutput.TabIndex = 52;
            this.lblConfigOutput.Text = "Server Config:";
            this.lblConfigOutput.Visible = false;
            // 
            // txtboxConfigOutput
            // 
            this.txtboxConfigOutput.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.txtboxConfigOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxConfigOutput.FormattingEnabled = true;
            this.txtboxConfigOutput.Location = new System.Drawing.Point(16, 241);
            this.txtboxConfigOutput.Name = "txtboxConfigOutput";
            this.txtboxConfigOutput.Size = new System.Drawing.Size(693, 225);
            this.txtboxConfigOutput.TabIndex = 54;
            this.txtboxConfigOutput.TabStop = false;
            this.txtboxConfigOutput.Visible = false;
            // 
            // TAB_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.BackgroundImage = global::Borealis_Default_Namespace.Properties.Resources.backdrop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 557);
            this.Controls.Add(this.txtboxConfigOutput);
            this.Controls.Add(this.btnDestroyServer);
            this.Controls.Add(this.lblConfigOutput);
            this.Controls.Add(this.txtboxArguments);
            this.Controls.Add(this.lblArguments);
            this.Controls.Add(this.txtboxFriendlyName);
            this.Controls.Add(this.lblFriendlyName);
            this.Controls.Add(this.btnLoadConfig);
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
        private Bunifu.Framework.UI.BunifuFlatButton btnLoadConfig;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFriendlyName;
        private System.Windows.Forms.TextBox txtboxFriendlyName;
        private System.Windows.Forms.TextBox txtboxArguments;
        private Bunifu.Framework.UI.BunifuCustomLabel lblArguments;
        private Bunifu.Framework.UI.BunifuCustomLabel lblConfigOutput;
        private Bunifu.Framework.UI.BunifuFlatButton btnDestroyServer;
        private System.Windows.Forms.ListBox txtboxConfigOutput;
    }
}