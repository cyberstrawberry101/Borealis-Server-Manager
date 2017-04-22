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

        public BorealisServerManager()
        {
            InitializeComponent();

        }

        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("User32.dll")]

        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            const int WM_NCPAINT = 0x85;
            base.WndProc(ref m);

            if (m.Msg == WM_NCPAINT)
            {

                IntPtr hdc = GetWindowDC(m.HWnd);
                if ((int)hdc != 0)
                {
                    Graphics g = Graphics.FromHdc(hdc);
                    g.DrawLine(Pens.Green, 10, 10, 100, 10);
                    g.Flush();
                    ReleaseDC(m.HWnd, hdc);
                }

            }

        }

        //===================================================================================//
        // STARTUP:                                                                          //
        //===================================================================================//
        public void BorealisServerManager_Load(object sender, EventArgs e)
        {
            //Create blank gameservers.json
            if (File.Exists(Environment.CurrentDirectory + @"\gameservers.json") == false)
            {
                File.Create(Environment.CurrentDirectory + @"\gameservers.json").Dispose();
            }

            //Destroy the bevelled border around MDI parent container.
            this.SetBevel(false);

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control control in this.Controls)
            {
                var controlMdi = control as MdiClient;
                if (controlMdi != null)
                {
                    controlMdi.BackColor = this.BackColor;
                }
            }

            //Display current product version.
            lblVersion.Text = "Version " + Application.ProductVersion + " Alpha";

            //Store all gameservers into memory to be used by Borealis.
            GameServer_Management.ReadServersFromConfig();


            // Instantiate all Panels Immediately
            var panels = new List<Form>
            {
                new TAB_DEPLOYMENT(),
                new TAB_Management(),
                new TAB_CONTROL(),
                new TAB_ABOUT(),
                new TAB_SCHEDULEDTASKS(),
                new TAB_DASHBOARD()
            };

            foreach (Form panel in panels)
            {
                panel.MdiParent = this;
                panel.AutoScroll = false;
                panel.Dock = DockStyle.Fill;
                panel.Show();
            }

            MDI_CURTAINHIDER.Visible = false;
        }

        //===================================================================================//
        // TAB ANIMATION AND SWITCHING CODE:                                                 //
        //===================================================================================//
        public void tab_animate(Bunifu.Framework.UI.BunifuFlatButton SelectedTab, Panel SelectedIndicator, bool SelectNewTab)
        {
            //Deactivate all other tabs
            dashboard_indicator.Visible = deployment_indicator.Visible = management_indicator.Visible = control_indicator.Visible = scheduledtasks_indicator.Visible = false;
            dashboard_tab.Textcolor = deployment_tab.Textcolor = management_tab.Textcolor = control_tab.Textcolor = scheduledtasks_tab.Textcolor = Color.FromArgb(145, 155, 166);
            dashboard_tab.Activecolor = deployment_tab.Activecolor = management_tab.Activecolor = control_tab.Activecolor = scheduledtasks_tab.Activecolor = Color.FromArgb(26, 32, 40);
            dashboard_tab.BackColor = deployment_tab.BackColor = management_tab.BackColor = control_tab.BackColor = scheduledtasks_tab.BackColor = Color.FromArgb(26, 32, 40);

            if (SelectNewTab == true)
            {
                //Make selected tab active
                SelectedTab.Textcolor = Color.FromArgb(67, 181, 129);
                SelectedTab.Activecolor = Color.FromArgb(16, 22, 30);
                SelectedTab.BackColor = Color.FromArgb(16, 22, 30);
                SelectedIndicator.Visible = true;
            }

            //Render the selection triangle programmatically.

        }

        private void tabDeployGameservers_Click_1(object sender, EventArgs e)
        {
            MDI_CURTAINHIDER.Visible = true;
            tab_animate(deployment_tab, deployment_indicator, true);
            tabForms.SelectedIndex = 0;
            MDI_CURTAINHIDER.Visible = false;
        }
        private void tabManageGameservers_Click(object sender, EventArgs e)
        {
            MDI_CURTAINHIDER.Visible = true;
            tab_animate(management_tab, management_indicator, true);
            tabForms.SelectedIndex = 1;
            MDI_CURTAINHIDER.Visible = false;
        }
        private void tabControlGameservers_Click(object sender, EventArgs e)
        {
            MDI_CURTAINHIDER.Visible = true;
            tab_animate(control_tab, control_indicator, true);
            tabForms.SelectedIndex = 2;
            MDI_CURTAINHIDER.Visible = false;
        }
        private void attribution_tab_Click(object sender, EventArgs e)
        {
            MDI_CURTAINHIDER.Visible = true;
            tab_animate(null, null, false);
            tabForms.SelectedIndex = 3;
            MDI_CURTAINHIDER.Visible = false;
        }
        private void scheduledtasks_tab_Click(object sender, EventArgs e)
        {
            MDI_CURTAINHIDER.Visible = true;
            tab_animate(scheduledtasks_tab, scheduledtasks_indicator, true);
            tabForms.SelectedIndex = 4;
            MDI_CURTAINHIDER.Visible = false;
        }
        private void tabDashboard_Click_1(object sender, EventArgs e)
        {
            MDI_CURTAINHIDER.Visible = true;
            tab_animate(dashboard_tab, dashboard_indicator, true);
            tabForms.SelectedIndex = 5;
            MDI_CURTAINHIDER.Visible = false;
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
            //Write data in memory to disk into gameservers.json
            if (GameServer_Management.server_collection != null)
            {
                //Delete existing gameservers.json
                if (System.IO.File.Exists(Environment.CurrentDirectory + @"\gameservers.json"))
                {
                    System.IO.File.Delete(Environment.CurrentDirectory + @"\gameservers.json");
                }

                GameServer_Management.WriteServersToConfig();
            }
        }
    }
}
