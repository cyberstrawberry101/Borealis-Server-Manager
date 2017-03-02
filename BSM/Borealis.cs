using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace Borealis
{

    public partial class BorealisServerManager : Form
    {
        public BorealisServerManager()
        {
            InitializeComponent();
        }

        //===================================================================================//
        // STARTUP:                                                                          //
        //===================================================================================//
        public void BorealisServerManager_Load(object sender, EventArgs e)
        {
            //Create blank config.json
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\config.json") == false)
            {
                File.Create(Environment.CurrentDirectory + @"\config.json").Dispose();
            }

            //Destroy the bevelled border around MDI parent container.
            this.SetBevel(false);
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (System.Windows.Forms.Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }

            //Display current product version.
            lblVersion.Text = "Version " + Application.ProductVersion + " Alpha";

            //Store all gameservers into memory to be used by Borealis.
            GameServer_Management PullConfig = new GameServer_Management();
            PullConfig.addAllServers_fromConfig();


            //Instanciate all Panels Immediately

            //TAB INDEX 0
            ServerDeployment ChildInstance_Deployment = new ServerDeployment();
            ChildInstance_Deployment.MdiParent = this;
            ChildInstance_Deployment.AutoScroll = false;
            ChildInstance_Deployment.Dock = DockStyle.Fill;
            ChildInstance_Deployment.Show();

            //TAB INDEX 1
            ServerManagement ChildInstance_Management = new ServerManagement();
            ChildInstance_Management.MdiParent = this;
            ChildInstance_Management.AutoScroll = false;
            ChildInstance_Management.Dock = DockStyle.Fill;
            ChildInstance_Management.Show();

            //TAB INDEX 2
            ServerControl ChildInstance_Control = new ServerControl();
            ChildInstance_Control.MdiParent = this;
            ChildInstance_Control.AutoScroll = false;
            ChildInstance_Control.Dock = DockStyle.Fill;
            ChildInstance_Control.Show();

            //TAB INDEX 3
            About_DialogBox ChildInstance_Attribution = new About_DialogBox();
            ChildInstance_Attribution.MdiParent = this;
            ChildInstance_Attribution.AutoScroll = false;
            ChildInstance_Attribution.Dock = DockStyle.Fill;
            ChildInstance_Attribution.Show();

            //TAB INDEX 4
            Experimental_Area ChildInstance_ExperimentalArea = new Experimental_Area();
            ChildInstance_ExperimentalArea.MdiParent = this;
            ChildInstance_ExperimentalArea.AutoScroll = false;
            ChildInstance_ExperimentalArea.Dock = DockStyle.Fill;
            ChildInstance_ExperimentalArea.Show();

            //TAB INDEX 5
            ServerDashboard ChildInstance_Dashboard = new ServerDashboard();
            ChildInstance_Dashboard.MdiParent = this;
            ChildInstance_Dashboard.AutoScroll = false;
            ChildInstance_Dashboard.Dock = DockStyle.Fill;
            ChildInstance_Dashboard.Show();

            MDI_SHIELD.Visible = false;
        }




        //===================================================================================//
        // TAB ANIMATION AND SWITCHING CODE:                                                 //
        //===================================================================================//
        public void tab_animate(Bunifu.Framework.UI.BunifuFlatButton SelectedTab, Panel SelectedIndicator, bool SelectNewTab)
        {
            //Deactivate all other tabs
            dashboard_indicator.Visible = deployment_indicator.Visible = management_indicator.Visible = control_indicator.Visible = experiment_indicator.Visible = false;
            dashboard_tab.Textcolor = deployment_tab.Textcolor = management_tab.Textcolor = control_tab.Textcolor = experiment_tab.Textcolor = Color.FromArgb(145, 155, 166);
            dashboard_tab.Activecolor = deployment_tab.Activecolor = management_tab.Activecolor = control_tab.Activecolor = experiment_tab.Activecolor = Color.FromArgb(26, 32, 40);
            dashboard_tab.BackColor = deployment_tab.BackColor = management_tab.BackColor = control_tab.BackColor = experiment_tab.BackColor = Color.FromArgb(26, 32, 40);

            if (SelectNewTab == true)
            {
                //Make selected tab active
                SelectedTab.Textcolor = Color.FromArgb(67, 181, 129);
                SelectedTab.Activecolor = Color.FromArgb(16, 22, 30);
                SelectedTab.BackColor = Color.FromArgb(16, 22, 30);
                SelectedIndicator.Visible = true;
            }

        }
        private void tabDashboard_Click_1(object sender, EventArgs e)
        {
            tab_animate(dashboard_tab, dashboard_indicator, true);
            tabForms.SelectedIndex = 5;
        }
        private void tabDeployGameservers_Click_1(object sender, EventArgs e)
        {
            tab_animate(deployment_tab, deployment_indicator, true);
            tabForms.SelectedIndex = 0;
        }
        private void tabManageGameservers_Click(object sender, EventArgs e)
        {
            tab_animate(management_tab, management_indicator, true);
            tabForms.SelectedIndex = 1;
        }
        private void tabControlGameservers_Click(object sender, EventArgs e)
        {
            tab_animate(control_tab, control_indicator, true);
            tabForms.SelectedIndex = 2;
        }
        private void attribution_tab_Click(object sender, EventArgs e)
        {
            tab_animate(null, null, false);
            tabForms.SelectedIndex = 3;
        }
        private void tabExperimentalArea_Click(object sender, EventArgs e)
        {
            tab_animate(experiment_tab, experiment_indicator, true);
            tabForms.SelectedIndex = 4;
        }

        //===================================================================================//
        // MDI HANDLING CODE:                                                                //
        //===================================================================================//
        //Add MDI Child to tabpages of tabControl
        private void tabForms_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ((tabForms.SelectedTab != null) && (tabForms.SelectedTab.Tag != null))
                (tabForms.SelectedTab.Tag as Form).Select();

            /* TESTING DEBUG OPTIMIZATION CODE
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType()
                    && frm != form)
                {
                    frm.Close();
                }
            }
            */
        }
        private void BorealisServerManager_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                // If child form is new and no has tabPage, create new tabPage
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child form caption
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms;
                    tabForms.SelectedTab = tp;

                    this.ActiveMdiChild.Tag = tp;
                }
            }
        }

        //===================================================================================//
        // CLOSING:                                                                          //
        //===================================================================================//
        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose(); //Dispose of Notification Tray Icon
            this.Close();
        }
        private void BorealisServerManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Write data in memory to disk into config.json
            if (GameServer_Management.server_collection != null)
            {
                //Delete existing config.json
                if (System.IO.File.Exists(Environment.CurrentDirectory + @"\config.json"))
                {
                    System.IO.File.Delete(Environment.CurrentDirectory + @"\config.json");
                }

                foreach (JObject gameserver in GameServer_Management.server_collection)
                {
                    GameServer_Management WriteConfigOnClose = new GameServer_Management();
                    WriteConfigOnClose.DeployGameserver((string)gameserver["server_name"], (string)gameserver["server_type"], (string)gameserver["install_dir"], (string)gameserver["executable_dir"], (string)gameserver["launch_arguments"], (string)gameserver["server_config_file"], (bool)gameserver["running_status"], true);
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Unfortunately this feature has not been implemented yet.  Please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
