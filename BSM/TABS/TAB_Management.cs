using MetroFramework;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Borealis
{
    public partial class TAB_MANAGEMENT : Form
    {
        public TAB_MANAGEMENT()
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
                    gameserver.GAME_maxplayers = Convert.ToInt32(incMaxPlayers.Value);
                    gameserver.GAME_map = txtboxStartingMap.Text;
                    gameserver.SERVER_port = txtboxPORT.Text;
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
                    btnSteamWorkshop.Enabled = gameserver.STEAM_workshop_enabled;
                    incMaxPlayers.Value = gameserver.GAME_maxplayers;
                    txtboxPORT.Text = gameserver.SERVER_port;

                    //Clear the map dropdown list before adding new data to it.
                    txtboxStartingMap.Items.Clear();


                    var mapListing = Directory
                    .EnumerateFiles(gameserver.DIR_install_location + @"\steamapps\common" + gameserver.DIR_root + gameserver.DIR_maps, gameserver.DIR_maps_file_extension, SearchOption.AllDirectories)
                    .Select(Path.GetFileName); // <-- note you can shorten the lambda

                    foreach (var mapfile in mapListing)
                    {
                        string preparedmap = Path.GetFileNameWithoutExtension(mapfile);

                        //Specifically check for KF2's map system screwup to get around it.
                        if (gameserver.SERVER_type == "Killing Floor 2")
                        {
                            if (preparedmap.StartsWith("KF-"))
                            {
                                txtboxStartingMap.Items.Add(preparedmap);
                            }
                        }
                        else //Any other kind of gameserver / wildcard
                        {
                            txtboxStartingMap.Items.Add(preparedmap);
                        }
                    }

                    //The selected index indicating the original value must be called AFTER populating the Map List Combo Box.
                    txtboxStartingMap.Text = gameserver.GAME_map;

                    //Make properties boxes visible.
                    groupboxServerProperties.Visible = true;
                    groupboxGameProperties.Visible = true;
                    btnDestroyServer.Visible = true;
                    btnUpdateServerConfig.Visible = true;
                    btnAddonControl.Visible = true;
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
                        txtboxPORT.Text = "";
                        txtboxStartingMap.Items.Clear();
                        incMaxPlayers.Value = 0;
                        chkFirewallToggle.Checked = false;

                        //Update the panel information after destroying the gameserver.
                        RefreshData();
                    }
                }
            }
        }

        private void btnSteamWorkshop_Click(object sender, EventArgs e)
        {
            TAB_STEAMWORKSHOP DEBUGWINDOW = new TAB_STEAMWORKSHOP();
            DEBUGWINDOW.Show();
        }

        private void btnAddonControl_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(ActiveForm,
                    "Addon / Mod management has not yet been implemented into Borealis.  Come back later! :)",
                    "Addon / Mod Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkFirewallToggle_OnChange(object sender, EventArgs e)
        {
            if (chkFirewallToggle.Checked == true)
            {
                lblAddFirewallRule.Text = "Firewall Rule [Enabled]";
            }
            else
            {
                lblAddFirewallRule.Text = "Firewall Rule [Disabled]";
            }
        }
    }
}
