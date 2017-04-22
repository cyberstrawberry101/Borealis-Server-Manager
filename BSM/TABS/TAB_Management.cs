using MetroFramework;
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
                    //Populate applicable data fields using data from GameServer_Object
                    txtboxFriendlyName.Text = gameserver.SERVER_name_friendly;
                    txtboxArguments.Text = gameserver.SERVER_launch_arguments;
                    lblGameType.Text = string.Format("Game Type: {0}", gameserver.SERVER_type);
                    lblGameEngine.Text = string.Format("Game Engine: {0}", gameserver.ENGINE_type);
                    lblSteamWorkshop.Text = string.Format("Steam Workshop: {0}", gameserver.STEAM_workshop_enabled);

                    //Enable Steam Workshop button if the server is compatible with it.
                    if (gameserver.STEAM_workshop_enabled == true)
                    {
                        btnSteamWorkshop.Enabled = true;
                    }
                    else
                    {
                        btnSteamWorkshop.Enabled = false;
                    }

                    //Friendly user-given server name
                    lblFriendlyName.Visible = true;
                    txtboxFriendlyName.Visible = true;

                    //Command line launch arguments
                    lblArguments.Visible = true;
                    txtboxArguments.Visible = true;

                    //Starting map
                    lblStartingMap.Visible = true;
                    txtboxStartingMap.Visible = true;

                    //Make detailed server specs visible
                    lblServerSpecs.Visible = true;
                    lblGameType.Visible = true;
                    lblGameEngine.Visible = true;
                    lblSteamWorkshop.Visible = true;

                    //Make buttons on bottom visible
                    btnUpdateServerConfig.Visible = true;
                    btnDestroyServer.Visible = true;
                    btnSteamWorkshop.Visible = true;
                }
            }
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

        private void btnSteamWorkshop_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(ActiveForm,
            "Unfortunately, Steam Workshop management is not currently implemented.",
            "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
