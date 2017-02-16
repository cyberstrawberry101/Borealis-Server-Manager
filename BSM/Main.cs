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

namespace Borealis
{

    public partial class BorealisServerManager : Form
    {
        public BorealisServerManager()
        {
            InitializeComponent();
        }

        //===================================================================================//
        // MDI CHILD CLEANUP FUNCTION                                                        //
        //===================================================================================//
        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType()
                    && frm != form)
                {
                    frm.Close();
                }
            }
        }

        //===================================================================================//
        // TOOLKIT EXIT BUTTON                                                              //
        //===================================================================================//
        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //===================================================================================//
        // STARTUP:                                                                          //
        //===================================================================================//
        private void BorealisServerManager_Load(object sender, EventArgs e)
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

                ServerDashboard ChildInstance = new ServerDashboard();
                ChildInstance.MdiParent = this;
                ChildInstance.AutoScroll = false;
                ChildInstance.Dock = DockStyle.Fill;
                ChildInstance.Show();

            //Display current product version.
            lblVersion.Text = "Version " + Application.ProductVersion;
        }


        //===================================================================================//
        // DASHBOARD PANEL                                                                   //
        //===================================================================================//
        private void tabDashboard_Click_1(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = indicatorTabExperimental.Visible = false;
            panelTabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = tabExperimental.Textcolor = Color.FromArgb(145, 155, 166);
            panelTabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = tabExperimental.Activecolor = Color.FromArgb(26, 32, 40);
            panelTabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = tabExperimental.BackColor = Color.FromArgb(26, 32, 40);

            //Select Tab
            panelTabDashboard.Textcolor = Color.FromArgb(67, 181, 129);
            panelTabDashboard.Activecolor = Color.FromArgb(16, 22, 30);
            panelTabDashboard.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabDashboard.Visible = true;

            //Render child MDI form---------------------------------------------
            ServerDashboard ChildInstance_Dashboard = new ServerDashboard();
            DisposeAllButThis(ChildInstance_Dashboard); //Destroy all other MDI child forms.
            ChildInstance_Dashboard.MdiParent = this;
            ChildInstance_Dashboard.AutoScroll = false;
            ChildInstance_Dashboard.Dock = DockStyle.Fill;
            ChildInstance_Dashboard.Show();
        }

        //===================================================================================//
        // DEPLOY GAMESERVERS TAB                                                            //
        //===================================================================================//
        private void tabDeployGameservers_Click_1(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = indicatorTabExperimental.Visible = false;
            panelTabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = tabExperimental .Textcolor = Color.FromArgb(145, 155, 166);
            panelTabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = tabExperimental.Activecolor = Color.FromArgb(26, 32, 40);
            panelTabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = tabExperimental.BackColor = Color.FromArgb(26, 32, 40);

            //Selected Tab
            tabDeployGameservers.Textcolor = Color.FromArgb(67, 181, 129);
            tabDeployGameservers.Activecolor = Color.FromArgb(16, 22, 30);
            tabDeployGameservers.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabDeployment.Visible = true;
            
            //Render child MDI form---------------------------------------------
            ServerDeployment ChildInstance_Deployment = new ServerDeployment();
            DisposeAllButThis(ChildInstance_Deployment); //Destroy all other MDI child forms.
            ChildInstance_Deployment.MdiParent = this;
            ChildInstance_Deployment.AutoScroll = false;
            ChildInstance_Deployment.Dock = DockStyle.Fill;
            ChildInstance_Deployment.Show();
        }

        //===================================================================================//
        // MANAGE GAMESERVERS TAB                                                            //
        //===================================================================================//
        private void tabManageGameservers_Click(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = indicatorTabExperimental.Visible = false;
            panelTabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = tabExperimental.Textcolor = Color.FromArgb(145, 155, 166);
            panelTabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = tabExperimental.Activecolor = Color.FromArgb(26, 32, 40);
            panelTabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = tabExperimental.BackColor = Color.FromArgb(26, 32, 40);

            //Selected Tab
            tabManageGameservers.Textcolor = Color.FromArgb(67, 181, 129);
            tabManageGameservers.Activecolor = Color.FromArgb(16, 22, 30);
            tabManageGameservers.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabManagement.Visible = true;

            //Render child MDI form---------------------------------------------
            ServerManagement ChildInstance_Management = new ServerManagement();
            DisposeAllButThis(ChildInstance_Management); //Destroy all other MDI child forms.
            ChildInstance_Management.MdiParent = this;
            ChildInstance_Management.AutoScroll = false;
            ChildInstance_Management.Dock = DockStyle.Fill;
            ChildInstance_Management.Show();
        }

        //===================================================================================//
        // CONTROL GAMESERVERS TAB                                                           //
        //===================================================================================//
        private void tabControlGameservers_Click(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = indicatorTabExperimental.Visible = false;
            panelTabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = tabExperimental.Textcolor = Color.FromArgb(145, 155, 166);
            panelTabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = tabExperimental.Activecolor = Color.FromArgb(26, 32, 40);
            panelTabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = tabExperimental.BackColor = Color.FromArgb(26, 32, 40);

            //Selected Tab
            tabControlGameservers.Textcolor = Color.FromArgb(67, 181, 129);
            tabControlGameservers.Activecolor = Color.FromArgb(16, 22, 30);
            tabControlGameservers.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabControl.Visible = true;

            //Render child MDI form---------------------------------------------
            ServerControl ChildInstance_Control = new ServerControl();
            DisposeAllButThis(ChildInstance_Control); //Destroy all other MDI child forms.
            ChildInstance_Control.MdiParent = this;
            ChildInstance_Control.AutoScroll = false;
            ChildInstance_Control.Dock = DockStyle.Fill;
            ChildInstance_Control.Show();
        }
        
        //===================================================================================//
        // EXPERIMENTAL AREA TAB                                                             //
        //===================================================================================//
        private void tabExperimental_Click(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = indicatorTabExperimental.Visible = false;
            panelTabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = tabExperimental.Textcolor = Color.FromArgb(145, 155, 166);
            panelTabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = tabExperimental.Activecolor = Color.FromArgb(26, 32, 40);
            panelTabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = tabExperimental.BackColor = Color.FromArgb(26, 32, 40);

            //Selected Tab
            tabExperimental.Textcolor = Color.FromArgb(67, 181, 129);
            tabExperimental.Activecolor = Color.FromArgb(16, 22, 30);
            tabExperimental.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabExperimental.Visible = true;

            //Render child MDI form---------------------------------------------
            Experimental_Area ChildInstance_Experimental = new Experimental_Area();
            DisposeAllButThis(ChildInstance_Experimental); //Destroy all other MDI child forms.
            ChildInstance_Experimental.MdiParent = this;
            ChildInstance_Experimental.AutoScroll = false;
            ChildInstance_Experimental.Dock = DockStyle.Fill;
            ChildInstance_Experimental.Show();
        }

        //===================================================================================//
        // ATTRIBUTION AND CREDITS TAB                                                       //
        //===================================================================================//
        private void lblAttribution_Click(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = indicatorTabExperimental.Visible = false;
            panelTabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = tabExperimental.Textcolor = Color.FromArgb(145, 155, 166);
            panelTabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = tabExperimental.Activecolor = Color.FromArgb(26, 32, 40);
            panelTabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = tabExperimental.BackColor = Color.FromArgb(26, 32, 40);

            //Render child MDI form---------------------------------------------
            About_DialogBox ChildInstance_Attribution = new About_DialogBox();
            DisposeAllButThis(ChildInstance_Attribution); //Destroy all other MDI child forms.
            ChildInstance_Attribution.MdiParent = this;
            ChildInstance_Attribution.AutoScroll = false;
            ChildInstance_Attribution.Dock = DockStyle.Fill;
            ChildInstance_Attribution.Show();
        }

        //===================================================================================//
        // MISCELLANIOUS UI CODE                                                             //
        //===================================================================================//
        private void lblAttribution_MouseHover(object sender, EventArgs e)
        {
            lblAttribution.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void lblAttribution_MouseLeave(object sender, EventArgs e)
        {
            lblAttribution.ForeColor = Color.FromArgb(145, 155, 166);
        }
    }
}
