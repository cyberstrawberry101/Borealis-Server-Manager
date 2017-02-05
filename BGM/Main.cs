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

namespace GameServer_Manager
{

    public partial class BorealisGameManager : Form
    {
        public BorealisGameManager()
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
        private void BorealisGameManager_Load(object sender, EventArgs e)
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

            //------- Launch Startup Dashboard Panel -------
            //Render child MDI form---------------------------------------------
            ServerDashboard Dashboard_ChildInstance = new ServerDashboard();
            Dashboard_ChildInstance.MdiParent = this;
            Dashboard_ChildInstance.AutoScroll = false;
            Dashboard_ChildInstance.Dock = DockStyle.Fill;
            Dashboard_ChildInstance.Show();

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
            tabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = tabExperimental.Textcolor = Color.FromArgb(145, 155, 166);
            tabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = tabExperimental.Activecolor = Color.FromArgb(26, 32, 40);
            tabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = tabExperimental.BackColor = Color.FromArgb(26, 32, 40);

            //Select Tab
            tabDashboard.Textcolor = Color.FromArgb(67, 181, 129);
            tabDashboard.Activecolor = Color.FromArgb(16, 22, 30);
            tabDashboard.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabDashboard.Visible = true;

            //Render child MDI form---------------------------------------------
            ServerDashboard ServerDashboard_ChildInstance = new ServerDashboard();
            DisposeAllButThis(ServerDashboard_ChildInstance); //Destroy all other MDI child forms.
            ServerDashboard_ChildInstance.MdiParent = this;
            ServerDashboard_ChildInstance.AutoScroll = false;
            ServerDashboard_ChildInstance.Dock = DockStyle.Fill;
            ServerDashboard_ChildInstance.Show();
        }

        //===================================================================================//
        // DEPLOY GAMESERVERS TAB                                                            //
        //===================================================================================//
        private void tabDeployGameservers_Click_1(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = indicatorTabExperimental.Visible = false;
            tabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = tabExperimental .Textcolor = Color.FromArgb(145, 155, 166);
            tabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = tabExperimental.Activecolor = Color.FromArgb(26, 32, 40);
            tabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = tabExperimental.BackColor = Color.FromArgb(26, 32, 40);

            //Selected Tab
            tabDeployGameservers.Textcolor = Color.FromArgb(67, 181, 129);
            tabDeployGameservers.Activecolor = Color.FromArgb(16, 22, 30);
            tabDeployGameservers.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabDeployment.Visible = true;
            
            //Render child MDI form---------------------------------------------
            ServerDeployment ServerDeployment_ChildInstance = new ServerDeployment();
            DisposeAllButThis(ServerDeployment_ChildInstance); //Destroy all other MDI child forms.
            ServerDeployment_ChildInstance.MdiParent = this;
            ServerDeployment_ChildInstance.AutoScroll = false;
            ServerDeployment_ChildInstance.Dock = DockStyle.Fill;
            ServerDeployment_ChildInstance.Show();
        }

        //===================================================================================//
        // MANAGE GAMESERVERS TAB                                                            //
        //===================================================================================//
        private void tabManageGameservers_Click(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = indicatorTabExperimental.Visible = false;
            tabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = tabExperimental.Textcolor = Color.FromArgb(145, 155, 166);
            tabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = tabExperimental.Activecolor = Color.FromArgb(26, 32, 40);
            tabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = tabExperimental.BackColor = Color.FromArgb(26, 32, 40);

            //Selected Tab
            tabManageGameservers.Textcolor = Color.FromArgb(67, 181, 129);
            tabManageGameservers.Activecolor = Color.FromArgb(16, 22, 30);
            tabManageGameservers.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabManagement.Visible = true;

            //Render child MDI form---------------------------------------------
            ServerManagement ServerManagement_ChildInstance = new ServerManagement();
            DisposeAllButThis(ServerManagement_ChildInstance); //Destroy all other MDI child forms.
            ServerManagement_ChildInstance.MdiParent = this;
            ServerManagement_ChildInstance.AutoScroll = false;
            ServerManagement_ChildInstance.Dock = DockStyle.Fill;
            ServerManagement_ChildInstance.Show();
        }

        //===================================================================================//
        // CONTROL GAMESERVERS TAB                                                           //
        //===================================================================================//
        private void tabControlGameservers_Click(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = indicatorTabExperimental.Visible = false;
            tabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = tabExperimental.Textcolor = Color.FromArgb(145, 155, 166);
            tabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = tabExperimental.Activecolor = Color.FromArgb(26, 32, 40);
            tabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = tabExperimental.BackColor = Color.FromArgb(26, 32, 40);

            //Selected Tab
            tabControlGameservers.Textcolor = Color.FromArgb(67, 181, 129);
            tabControlGameservers.Activecolor = Color.FromArgb(16, 22, 30);
            tabControlGameservers.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabControl.Visible = true;

            //Render child MDI form---------------------------------------------
            ServerControl ServerControl_ChildInstance = new ServerControl();
            DisposeAllButThis(ServerControl_ChildInstance); //Destroy all other MDI child forms.
            ServerControl_ChildInstance.MdiParent = this;
            ServerControl_ChildInstance.AutoScroll = false;
            ServerControl_ChildInstance.Dock = DockStyle.Fill;
            ServerControl_ChildInstance.Show();
        }
        
        //===================================================================================//
        // EXPERIMENTAL AREA TAB                                                             //
        //===================================================================================//
        private void tabExperimental_Click(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = indicatorTabExperimental.Visible = false;
            tabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = tabExperimental.Textcolor = Color.FromArgb(145, 155, 166);
            tabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = tabExperimental.Activecolor = Color.FromArgb(26, 32, 40);
            tabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = tabExperimental.BackColor = Color.FromArgb(26, 32, 40);

            //Selected Tab
            tabExperimental.Textcolor = Color.FromArgb(67, 181, 129);
            tabExperimental.Activecolor = Color.FromArgb(16, 22, 30);
            tabExperimental.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabExperimental.Visible = true;

            //Render child MDI form---------------------------------------------
            Experimental_Area Experimental_Area_ChildInstance = new Experimental_Area();
            DisposeAllButThis(Experimental_Area_ChildInstance); //Destroy all other MDI child forms.
            Experimental_Area_ChildInstance.MdiParent = this;
            Experimental_Area_ChildInstance.AutoScroll = false;
            Experimental_Area_ChildInstance.Dock = DockStyle.Fill;
            Experimental_Area_ChildInstance.Show();
        }

        //===================================================================================//
        // ATTRIBUTION AND CREDITS DIALOG BOX                                                //
        //===================================================================================//
        private void lblAttribution_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(BorealisGameManager.ActiveForm, "Software Designer: Nicole Rappe \nIcons: https://icons8.com/web-app \nContributions by: Mezarith\nMetroFramework: https://github.com/thielj/MetroFramework \nBunifuFramework: https://devtools.bunifu.co.ke/", "About GameServerManager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

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
