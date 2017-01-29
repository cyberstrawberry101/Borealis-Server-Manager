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
            string json = @"{
           'CPU': 'Intel',
           'PSU': '500W',
           'Drives': [
           'DVD read/writer'
           /*(broken)*/,
           '500 gigabyte hard drive',
           '200 gigabype hard drive'
           ]
           }";

           //GSM_SettingsManagement_Classes.ReadJSONData(json);


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

            //------- Startup Panel -------
            GSM_Performance_Dashboard GSM_Performance_Dashboard_ChildInstance = new GSM_Performance_Dashboard();
            DisposeAllButThis(GSM_Performance_Dashboard_ChildInstance);
            GSM_Performance_Dashboard_ChildInstance.MdiParent = this;
            GSM_Performance_Dashboard_ChildInstance.AutoScroll = false;
            GSM_Performance_Dashboard_ChildInstance.Dock = DockStyle.Fill;
            indicatorTabDashboard.Visible = true;
            indicatorTabManagement.Visible = indicatorTabControl.Visible = indicatorTabDeployment.Visible = false;
            GSM_Performance_Dashboard_ChildInstance.Show();
        }


        //===================================================================================//
        // LEFT-SIDE NAVIGATION TABS                                                         //
        //===================================================================================//
        //------- Startup Dashboard Panel -------
        private void tabDashboard_Click_1(object sender, EventArgs e)
        {
            GSM_Performance_Dashboard GSM_Performance_Dashboard_ChildInstance = new GSM_Performance_Dashboard();
            DisposeAllButThis(GSM_Performance_Dashboard_ChildInstance);
            GSM_Performance_Dashboard_ChildInstance.MdiParent = this;
            GSM_Performance_Dashboard_ChildInstance.AutoScroll = false;
            GSM_Performance_Dashboard_ChildInstance.Dock = DockStyle.Fill;
            indicatorTabDashboard.Visible = true;
            indicatorTabManagement.Visible = indicatorTabControl.Visible = indicatorTabDeployment.Visible = false;
            GSM_Performance_Dashboard_ChildInstance.Show();
        }
        //------- Deploy GameServers Tab -------
        private void tabDeployGameservers_Click_1(object sender, EventArgs e)
        {
            GSM_Deployment GSM_Deployment_ChildInstance = new GSM_Deployment();
            DisposeAllButThis(GSM_Deployment_ChildInstance);
            GSM_Deployment_ChildInstance.MdiParent = this;
            GSM_Deployment_ChildInstance.AutoScroll = false;
            GSM_Deployment_ChildInstance.Dock = DockStyle.Fill;
            indicatorTabManagement.Visible = indicatorTabControl.Visible = indicatorTabDashboard.Visible = false;
            indicatorTabDeployment.Visible = true;
            GSM_Deployment_ChildInstance.Show();
        }
        //------- Manage GameServers Tab -------
        private void tabManageGameservers_Click(object sender, EventArgs e)
        {
            GSM_Management GSM_Management_ChildInstance = new GSM_Management();
            DisposeAllButThis(GSM_Management_ChildInstance);
            GSM_Management_ChildInstance.MdiParent = this;
            GSM_Management_ChildInstance.AutoScroll = false;
            GSM_Management_ChildInstance.Dock = DockStyle.Fill;
            indicatorTabDeployment.Visible = indicatorTabControl.Visible = indicatorTabDashboard.Visible = false;
            indicatorTabManagement.Visible = true;
            GSM_Management_ChildInstance.Show();
        }
        //------- Control GameServers Tab -------
        private void tabControlGameservers_Click(object sender, EventArgs e)
        {
            GSM_Console GSM_Console_ChildInstance = new GSM_Console();
            DisposeAllButThis(GSM_Console_ChildInstance);
            GSM_Console_ChildInstance.MdiParent = this;
            GSM_Console_ChildInstance.AutoScroll = false;
            GSM_Console_ChildInstance.Dock = DockStyle.Fill;
            indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabDashboard.Visible = false;
            indicatorTabControl.Visible = true;
            GSM_Console_ChildInstance.Show();
        }

        private void bunifuCustomLabel17_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(GameServerManager.ActiveForm, "Software Designer: Nicole Rappe \nIcons: https://icons8.com/web-app/418/Console \nMetroFramework: https://github.com/thielj/MetroFramework \nBunifuUI: https://devtools.bunifu.co.ke/", "About GameServerManager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
