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

            bool FIRST_TIME_SETUP = false; //DEBUG DEBUG DEBUG

            if (FIRST_TIME_SETUP == true)
            {
                panelTabDashboard.Visible = false;
                panelTabDeployment.Visible = false;
                panelTabManagement.Visible = false;
                panelTabControl.Visible = false;
                panelTabExperimental.Visible = false;
                toggleExperimentalMode.Visible = false;
                lblAutoRestart.Visible = false;

                //Render child MDI form---------------------------------------------
                WelcomeScreen ChildInstance = new WelcomeScreen();
                ChildInstance.MdiParent = this;
                ChildInstance.AutoScroll = false;
                ChildInstance.Dock = DockStyle.Fill;
                ChildInstance.Show();
            }
            else
            {
                //Render child MDI form---------------------------------------------
                ServerDashboard ChildInstance = new ServerDashboard();
                ChildInstance.MdiParent = this;
                ChildInstance.AutoScroll = false;
                ChildInstance.Dock = DockStyle.Fill;
                ChildInstance.Show();
            }

            //Display current product version.
            lblVersion.Text = "Version " + Application.ProductVersion;

            //Fade In
            fadingTransition.ShowAsyc(ActiveForm);
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
            ServerDashboard ChildInstance = new ServerDashboard();
            DisposeAllButThis(ChildInstance); //Destroy all other MDI child forms.
            ChildInstance.MdiParent = this;
            ChildInstance.AutoScroll = false;
            ChildInstance.Dock = DockStyle.Fill;
            ChildInstance.Show();
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
            ServerDeployment ChildInstance = new ServerDeployment();
            DisposeAllButThis(ChildInstance); //Destroy all other MDI child forms.
            ChildInstance.MdiParent = this;
            ChildInstance.AutoScroll = false;
            ChildInstance.Dock = DockStyle.Fill;
            ChildInstance.Show();
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
            ServerManagement ChildInstance = new ServerManagement();
            DisposeAllButThis(ChildInstance); //Destroy all other MDI child forms.
            ChildInstance.MdiParent = this;
            ChildInstance.AutoScroll = false;
            ChildInstance.Dock = DockStyle.Fill;
            ChildInstance.Show();
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
            ServerControl ChildInstance = new ServerControl();
            DisposeAllButThis(ChildInstance); //Destroy all other MDI child forms.
            ChildInstance.MdiParent = this;
            ChildInstance.AutoScroll = false;
            ChildInstance.Dock = DockStyle.Fill;
            ChildInstance.Show();
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
            Experimental_Area ChildInstance = new Experimental_Area();
            DisposeAllButThis(ChildInstance); //Destroy all other MDI child forms.
            ChildInstance.MdiParent = this;
            ChildInstance.AutoScroll = false;
            ChildInstance.Dock = DockStyle.Fill;
            ChildInstance.Show();
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
            About_DialogBox ChildInstance = new About_DialogBox();
            DisposeAllButThis(ChildInstance); //Destroy all other MDI child forms.
            ChildInstance.MdiParent = this;
            ChildInstance.AutoScroll = false;
            ChildInstance.Dock = DockStyle.Fill;
            ChildInstance.Show();
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

        private void toggleExperimentalMode_OnValueChange(object sender, EventArgs e)
        {
            if (toggleExperimentalMode.Value == true)
            {
                panelTabExperimental.Visible = true;
            }
            else
            {
                panelTabExperimental.Visible = false;
            }
        }
    }
}
