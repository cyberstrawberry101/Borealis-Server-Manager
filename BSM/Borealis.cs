using MetroFramework;
using ShadowDemo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Borealis
{
    public partial class BorealisServerManager : Form
    {
        private Dropshadow shadow;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0084 /*WM_NCHITTEST*/)
            {
                m.Result = (IntPtr)2;   // HTCLIENT
                return;
            }
            base.WndProc(ref m);
        }

        //===================================================================================//
        // MDI HANDLING CODE:                                                                //
        //===================================================================================//

        //Add MDI Child to tabpages of tabControl
        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tabForms.SelectedTab != null) && (tabForms.SelectedTab.Tag != null))
                (tabForms.SelectedTab.Tag as Form).Select();
        }

        private void BorealisServerManager_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                // If child form is new and no has tabPage, create new tabPage
                if (ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child form caption
                    TabPage tp = new TabPage(ActiveMdiChild.Text);
                    tp.Tag = ActiveMdiChild;
                    tp.Parent = tabForms;
                    tabForms.SelectedTab = tp;

                    ActiveMdiChild.Tag = tp;
                }
            }
        }

        public BorealisServerManager()
        {
            InitializeComponent();
        }

        //===================================================================================//
        // STARTUP:                                                                          //
        //===================================================================================//
        public void BorealisServerManager_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                shadow = new Dropshadow(this)
                {
                    ShadowBlur = 25,
                    ShadowSpread = -18,
                    ShadowColor = Color.FromArgb(170,0,0,0)
                };
                shadow.RefreshShadow();
            }
            //Destroy the bevelled border around MDI parent container.
            this.SetBevel(false);

            //Display current product version.
            lblVersion.Text = $"Version {Application.ProductVersion} Alpha";

            //Create blank gameservers.json
            if (File.Exists(Environment.CurrentDirectory + @"\gameservers.json"))
            {
                GameServerManagement.ConfigRead();
            }
            else
            {
                File.Create(Environment.CurrentDirectory + @"\gameservers.json").Dispose();
                GameServerManagement.ConfigRead();
            }

            //Store all gameservers into memory to be used by Borealis.

            GameServerManagement.ConfigRead();

            // Instantiate all Panels Immediately
            var panels = new List<Form>
            {
                new TAB_DEPLOYMENT(),
                new TAB_MANAGEMENT(),
                new TAB_CONTROL(),
                new TAB_STEAMGUARD_TOKEN(),
                new TAB_SCHEDULEDTASKS(),
                new TAB_STEAMWORKSHOP(),
                new TAB_DASHBOARD(),
            };

            foreach (Form panel in panels)
            {
                panel.MdiParent = this;
                panel.AutoScroll = false;
                panel.Dock = DockStyle.Fill;
                panel.Show();
            }
        }

        //===================================================================================//
        // TAB ANIMATION AND SWITCHING CODE:                                                 //
        //===================================================================================//
        public void tab_animate(Bunifu.Framework.UI.BunifuFlatButton selectedTab, Panel selectedIndicator, bool selectNewTab)
        {
            //Deactivate all other tabs
            dashboard_indicator.Visible = deployment_indicator.Visible = management_indicator.Visible = control_indicator.Visible = scheduledtasks_indicator.Visible = false;
            dashboard_tab.Textcolor = deployment_tab.Textcolor = management_tab.Textcolor = control_tab.Textcolor = scheduledtasks_tab.Textcolor = Color.FromArgb(145, 155, 166);
            dashboard_tab.Activecolor = deployment_tab.Activecolor = management_tab.Activecolor = control_tab.Activecolor = scheduledtasks_tab.Activecolor = Color.FromArgb(26, 32, 40);
            dashboard_tab.BackColor = deployment_tab.BackColor = management_tab.BackColor = control_tab.BackColor = scheduledtasks_tab.BackColor = Color.FromArgb(26, 32, 40);

            if (selectNewTab) //If True
            {
                //Make selected tab active
                selectedTab.Textcolor = Color.FromArgb(67, 181, 129);
                selectedTab.Activecolor = Color.FromArgb(16, 22, 30);
                selectedTab.BackColor = Color.FromArgb(16, 22, 30);
                selectedIndicator.Visible = true;
            }
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
        private void scheduledtasks_tab_Click(object sender, EventArgs e)
        {
            tab_animate(scheduledtasks_tab, scheduledtasks_indicator, true);
            tabForms.SelectedIndex = 4;
        }
        private void tabDashboard_Click_1(object sender, EventArgs e)
        {
            tab_animate(dashboard_tab, dashboard_indicator, true);
            tabForms.SelectedIndex = 6;
        }


        //===================================================================================//
        // CLOSING:                                                                          //
        //===================================================================================//
        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose(); //Dispose of Notification Tray Icon
            Close();
        }
        private void BorealisServerManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Write data in memory to disk into gameservers.json
            if (GameServerManagement.ServerCollection != null)
            {
                //Delete existing gameservers.json
                if (File.Exists(Environment.CurrentDirectory + @"\gameservers.json"))
                {
                    File.Delete(Environment.CurrentDirectory + @"\gameservers.json");
                }

                GameServerManagement.ConfigWrite();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuBarPanel.Width == 240)
            {
                AnimateMenuBar("compress");
            }
            else
            {
                AnimateMenuBar("expand");
            }

            void AnimateMenuBar(string toggleStatus)
            {
                if (toggleStatus == "expand")
                {
                    menuBarPanel.Visible = true;
                    //menuBarTransition.ShowSync(menuBarPanel);  //Need to get this to work properly and smoothly.
                    menuBarlblMenu.Text = "Menu";
                    dashboard_tab.Text = "   Dashboard";

                    menuBarlblServerManagement.Text = "Server Management";
                    deployment_tab.Text = "   Deploy GameServers";
                    management_tab.Text = "   Manage GameServers";
                    control_tab.Text = "   Control GameServers";

                    menuBarlblAdvanced.Text = "Advanced";
                    scheduledtasks_tab.Text = "   Scheduled Tasks";
                    menuBarPanel.Width = 240;
                    //logoAnimator.ShowSync(largeLogo);
                }

                if (toggleStatus == "compress")
                {
                    //menuBarTransition.HideSync(menuBarPanel);  //Need to get this to work properly and smoothly.
                    //menuBarPanel.Visible = false;
                    //logoAnimator.Hide(largeLogo);
                    menuBarlblMenu.Text = "";
                    dashboard_tab.Text = "";

                    menuBarlblServerManagement.Text = "";
                    deployment_tab.Text = "";
                    management_tab.Text = "";
                    control_tab.Text = "";

                    menuBarlblAdvanced.Text = "";
                    scheduledtasks_tab.Text = "";
                    menuBarPanel.Width = 51;
                    
                }
            }
        }
    }
}
