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

    public partial class GameServerManager : Form
    {
        public GameServerManager()
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
        // STARTUP: POSITION THE UTILITY PANELS IN THEIR PROPER LOCATION                     //
        //===================================================================================//
        private void Main_Load_1(object sender, EventArgs e)
        {
            //Check to ensure that config file exists, and if it doesnt, generate a new one.
            GSM_SettingsManagement_Classes.CheckForConfigXML();
            
            //Destroy the bevelled border around MDI parent container.
            this.SetBevel(false);
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
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
            GSM_Performance_Dashboard GSM_Performance_Dashboard_ChildInstance = new GSM_Performance_Dashboard();
            GSM_Performance_Dashboard_ChildInstance.MdiParent = this;
            GSM_Performance_Dashboard_ChildInstance.AutoScroll = false;
            GSM_Performance_Dashboard_ChildInstance.Dock = DockStyle.Fill;
            GSM_Performance_Dashboard_ChildInstance.Show();
        }


        //===================================================================================//
        // DASHBOARD PANEL                                                                   //
        //===================================================================================//
        private void tabDashboard_Click_1(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = false;
            tabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = Color.FromArgb(145, 155, 166);
            tabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = Color.FromArgb(26, 32, 40);
            tabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = Color.FromArgb(26, 32, 40);

            //Select Tab
            tabDashboard.Textcolor = Color.FromArgb(67, 181, 129);
            tabDashboard.Activecolor = Color.FromArgb(16, 22, 30);
            tabDashboard.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabDashboard.Visible = true;

            //Render child MDI form---------------------------------------------
            GSM_Performance_Dashboard GSM_Performance_Dashboard_ChildInstance = new GSM_Performance_Dashboard();
            DisposeAllButThis(GSM_Performance_Dashboard_ChildInstance); //Destroy all other MDI child forms.
            GSM_Performance_Dashboard_ChildInstance.MdiParent = this;
            GSM_Performance_Dashboard_ChildInstance.AutoScroll = false;
            GSM_Performance_Dashboard_ChildInstance.Dock = DockStyle.Fill;
            GSM_Performance_Dashboard_ChildInstance.Show();
        }

        //===================================================================================//
        // DEPLOY GAMESERVERS PANEL                                                          //
        //===================================================================================//
        private void tabDeployGameservers_Click_1(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = false;
            tabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = Color.FromArgb(145, 155, 166);
            tabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = Color.FromArgb(26, 32, 40);
            tabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = Color.FromArgb(26, 32, 40);

            //Selected Tab
            tabDeployGameservers.Textcolor = Color.FromArgb(67, 181, 129);
            tabDeployGameservers.Activecolor = Color.FromArgb(16, 22, 30);
            tabDeployGameservers.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabDeployment.Visible = true;
            
            //Render child MDI form---------------------------------------------
            GSM_Deployment GSM_Deployment_ChildInstance = new GSM_Deployment();
            DisposeAllButThis(GSM_Deployment_ChildInstance); //Destroy all other MDI child forms.
            GSM_Deployment_ChildInstance.MdiParent = this;
            GSM_Deployment_ChildInstance.AutoScroll = false;
            GSM_Deployment_ChildInstance.Dock = DockStyle.Fill;
            GSM_Deployment_ChildInstance.Show();
        }

        //===================================================================================//
        // MANAGE GAMESERVERS PANEL                                                          //
        //===================================================================================//
        private void tabManageGameservers_Click(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = false;
            tabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = Color.FromArgb(145, 155, 166);
            tabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = Color.FromArgb(26, 32, 40);
            tabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = Color.FromArgb(26, 32, 40);

            //Selected Tab
            tabManageGameservers.Textcolor = Color.FromArgb(67, 181, 129);
            tabManageGameservers.Activecolor = Color.FromArgb(16, 22, 30);
            tabManageGameservers.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabManagement.Visible = true;

            //Render child MDI form---------------------------------------------
            GSM_Management GSM_Management_ChildInstance = new GSM_Management();
            DisposeAllButThis(GSM_Management_ChildInstance); //Destroy all other MDI child forms.
            GSM_Management_ChildInstance.MdiParent = this;
            GSM_Management_ChildInstance.AutoScroll = false;
            GSM_Management_ChildInstance.Dock = DockStyle.Fill;
            GSM_Management_ChildInstance.Show();
        }

        //===================================================================================//
        // CONTROL GAMESERVERS PANEL                                                         //
        //===================================================================================//
        private void tabControlGameservers_Click(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = false;
            tabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = Color.FromArgb(145, 155, 166);
            tabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = Color.FromArgb(26, 32, 40);
            tabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = Color.FromArgb(26, 32, 40);

            //Selected Tab
            tabControlGameservers.Textcolor = Color.FromArgb(67, 181, 129);
            tabControlGameservers.Activecolor = Color.FromArgb(16, 22, 30);
            tabControlGameservers.BackColor = Color.FromArgb(16, 22, 30);
            indicatorTabControl.Visible = true;

            //Render child MDI form---------------------------------------------
            GSM_Console GSM_Console_ChildInstance = new GSM_Console();
            DisposeAllButThis(GSM_Console_ChildInstance); //Destroy all other MDI child forms.
            GSM_Console_ChildInstance.MdiParent = this;
            GSM_Console_ChildInstance.AutoScroll = false;
            GSM_Console_ChildInstance.Dock = DockStyle.Fill;
            GSM_Console_ChildInstance.Show();
        }

        //===================================================================================//
        // ATTRIBUTION AND CREDITS DIALOG BOX                                                //
        //===================================================================================//
        private void bunifuCustomLabel17_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(GameServerManager.ActiveForm, "Software Designer: Nicole Rappe \nIcons: https://icons8.com/web-app/418/Console \nMetroFramework: https://github.com/thielj/MetroFramework \nBunifuUI: https://devtools.bunifu.co.ke/", "About GameServerManager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
