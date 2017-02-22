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

            //Display current product version.
            lblVersion.Text = "Version " + Application.ProductVersion + " Alpha";

            //Store all gameservers into memory to be used by Borealis.
            GameServer_Management PullConfig = new GameServer_Management();
            PullConfig.addAllServers_fromConfig();

            ServerDashboard ChildInstance = new ServerDashboard();
            ChildInstance.MdiParent = this;
            ChildInstance.AutoScroll = false;
            ChildInstance.Dock = DockStyle.Fill;
            ChildInstance.Show();
        }


        //===================================================================================//
        // DASHBOARD PANEL                                                                   //
        //===================================================================================//
        private void tabDashboard_Click_1(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = false;
            panelTabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = Color.FromArgb(145, 155, 166);
            panelTabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = Color.FromArgb(26, 32, 40);
            panelTabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = Color.FromArgb(26, 32, 40);

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
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = false;
            panelTabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = Color.FromArgb(145, 155, 166);
            panelTabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = Color.FromArgb(26, 32, 40);
            panelTabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = Color.FromArgb(26, 32, 40);

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
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = false;
            panelTabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = Color.FromArgb(145, 155, 166);
            panelTabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = Color.FromArgb(26, 32, 40);
            panelTabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = Color.FromArgb(26, 32, 40);

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
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = false;
            panelTabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = Color.FromArgb(145, 155, 166);
            panelTabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = Color.FromArgb(26, 32, 40);
            panelTabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = Color.FromArgb(26, 32, 40);

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
        // ATTRIBUTION AND CREDITS TAB                                                       //
        //===================================================================================//
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //Deselect all tabs
            indicatorTabDashboard.Visible = indicatorTabDeployment.Visible = indicatorTabManagement.Visible = indicatorTabControl.Visible = false;
            panelTabDashboard.Textcolor = tabDeployGameservers.Textcolor = tabManageGameservers.Textcolor = tabControlGameservers.Textcolor = Color.FromArgb(145, 155, 166);
            panelTabDashboard.Activecolor = tabDeployGameservers.Activecolor = tabManageGameservers.Activecolor = tabControlGameservers.Activecolor = Color.FromArgb(26, 32, 40);
            panelTabDashboard.BackColor = tabDeployGameservers.BackColor = tabManageGameservers.BackColor = tabControlGameservers.BackColor = Color.FromArgb(26, 32, 40);

            //Render child MDI form---------------------------------------------
            About_DialogBox ChildInstance_Attribution = new About_DialogBox();
            DisposeAllButThis(ChildInstance_Attribution); //Destroy all other MDI child forms.
            ChildInstance_Attribution.MdiParent = this;
            ChildInstance_Attribution.AutoScroll = false;
            ChildInstance_Attribution.Dock = DockStyle.Fill;
            ChildInstance_Attribution.Show();
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
    }
}
