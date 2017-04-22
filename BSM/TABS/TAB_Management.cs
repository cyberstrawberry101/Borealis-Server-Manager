﻿using MetroFramework;
using System;
using System.IO;
using System.Windows.Forms;

namespace Borealis
{
    public partial class TAB_Management : Form
    {
        public TAB_Management()
        {
            InitializeComponent();
        }

        //===================================================================================//
        // STARTUP:                                                                          //
        //===================================================================================//
        private void GSM_Management_Load(object sender, EventArgs e)
        {
            if (GameServer_Management.server_collection != null)
            {
                foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
                {
                    comboboxGameserverList.Items.Add(gameserver.SERVER_name_friendly);
                }
            }
        }

        //===================================================================================//
        // MANAGEMENT:                                                                       //
        //===================================================================================//
        //Methods that handle management itself.
        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
            {
                if (gameserver.SERVER_name_friendly == comboboxGameserverList.Text)
                {
                    //GameServer_Object Management_Instance = new GameServer_Object();
                    openFileDialog1.InitialDirectory = gameserver.DIR_install_location + gameserver.DIR_config;
                }
            }

            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                int counter = 0;
                string line;
                txtboxConfigOutput.Items.Clear(); //Clear the table

                try
                {
                    // Read the file and display it line by line.
                    System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
                    while ((line = file.ReadLine()) != null)
                    {
                        txtboxConfigOutput.Items.Add(line);
                        counter++;
                    }

                    file.Close();
                }
                catch (IOException)
                {
                }
            }
        }
        private void btnUpdateServerConfig_Click(object sender, EventArgs e)
        {
            //Locate the associated GameServer_Object, and allow the user to edit the values associated with them.
            foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
            {
                if (gameserver.SERVER_name_friendly == comboboxGameserverList.Text)
                {
                    gameserver.SERVER_name_friendly = txtboxFriendlyName.Text;
                    gameserver.SERVER_launch_arguments = txtboxArguments.Text;
                }
            }

            //Notify the user that the data has been committed to memory, and warn them that if Borealis crashes, they will lose their changes.
            MetroMessageBox.Show(BorealisServerManager.ActiveForm, "The gameserver has been updated!\nPlease note: if Borealis crashes unexpectedly, these changes will be reverted.", "Changes Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question);

            //Update the panel information after committing the updates to the gameserver.
            RefreshData();
        }
        
        //Methods that handle reporting progress back to the UI
        private void comboboxGameserverList_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
            {
                if (gameserver.SERVER_name_friendly == comboboxGameserverList.Text)
                {
                    txtboxFriendlyName.Text = gameserver.SERVER_name_friendly;
                    txtboxArguments.Text = gameserver.SERVER_launch_arguments;

                    if (gameserver.DIR_config_file != "")
                    {
                        int counter = 0;
                        string line;
                        txtboxConfigOutput.Items.Clear(); //Clear the table

                        try
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(gameserver.DIR_install_location + gameserver.DIR_config + gameserver.DIR_config_file);
                            while ((line = file.ReadLine()) != null)
                            {
                                txtboxConfigOutput.Items.Add(line);
                                counter++;
                            }
                            
                            file.Close();
                        }
                        catch (Exception)
                        {
                            
                        }

                        if (txtboxConfigOutput.Items.Count < 1)
                        {
                            MetroMessageBox.Show(BorealisServerManager.ActiveForm, "[" + gameserver.DIR_install_location + gameserver.DIR_config + gameserver.DIR_config_file + "]\nappears to be missing or empty.  Please load a config file manually or make a new one to fix this issue.", "Default Config File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    lblFriendlyName.Visible = true;
                    txtboxFriendlyName.Visible = true;
                    lblArguments.Visible = true;
                    txtboxArguments.Visible = true;
                    lblConfigOutput.Visible = true;
                    txtboxConfigOutput.Visible = true;
                    btnUpdateServerConfig.Visible = true;
                    btnLoadConfig.Visible = true;
                    btnDestroyServer.Visible = true;
                }
            }

            btnLoadConfig.Enabled = true;  //Enable loading a config file manually
        }

        public void RefreshData()
        {
            comboboxGameserverList.Items.Clear();
            if (GameServer_Management.server_collection != null)
            {
                foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
                {
                    comboboxGameserverList.Items.Add(gameserver.SERVER_name_friendly);
                }
            }
        }

        private void ServerManagement_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnDestroyServer_Click_1(object sender, EventArgs e)
        {
            //Locate the associated GameServer_Object, and allow the user to edit the values associated with them.
            foreach (GameServer_Object gameserver in GameServer_Management.server_collection)
            {
                if (gameserver.SERVER_name_friendly == comboboxGameserverList.Text)
                {
                    DialogResult result = MetroMessageBox.Show(ActiveForm,
                                            "WARNING: Destroying a server is irreversible. are you sure you wish to do this?\nCurrently only the configuration will be destroyed, game data will need to be manually deleted.",
                                            "Destroy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                    if (result == DialogResult.Yes)
                    {
                        int GameServer_ObjectIndex = GameServer_Management.server_collection.FindIndex(x => x==gameserver);
                        GameServer_Management.server_collection.RemoveAt(GameServer_ObjectIndex);

                        //Clear the text fields since the server no longer exists, to simply tidy things up.
                        txtboxFriendlyName.Text = "";
                        txtboxArguments.Text = "";

                        //Update the panel information after destroying the gameserver.
                        RefreshData();
                    }
                }
            }
        }
    }
}
