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
            if (GameServerManagement.ServerCollection != null)
            {
                foreach (GameServerObject gameserver in GameServerManagement.ServerCollection)
                {
                    comboboxGameserverList.Items.Add(gameserver.SERVER_name_friendly);
                }
            }
        }

        private void btnUpdateServerConfig_Click(object sender, EventArgs e)
        {
            //Locate the associated GameServerObject, and allow the user to edit the values associated with them.
            var currentServer = GameServerManagement.PropertyGetSet(comboboxGameserverList.Text);
            currentServer.SERVER_name_friendly = txtboxFriendlyName.Text;
            currentServer.SERVER_launch_arguments = txtboxArguments.Text;
            currentServer.GAME_maxplayers = Convert.ToInt32(incMaxPlayers.Value);
            currentServer.GAME_map = txtboxStartingMap.Text;
            currentServer.SERVER_port = txtboxPORT.Text;

            //Notify the user that the data has been committed to memory, and warn them that if Borealis crashes, they will lose their changes.
            MetroMessageBox.Show(ActiveForm, "The gameserver has been updated!\nPlease note: if Borealis crashes unexpectedly, these changes will be reverted.", "Changes Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question);

            //Update the panel information after committing the updates to the gameserver.
            RefreshData();
        }
        
        //Methods that handle reporting progress back to the UI
        private void comboboxGameserverList_SelectedValueChanged(object sender, EventArgs e)
        {
            var currentServer = GameServerManagement.PropertyGetSet(comboboxGameserverList.Text);
            //Populate applicable data fields using data from GameServerObject
            txtboxFriendlyName.Text = currentServer.SERVER_name_friendly;
            txtboxArguments.Text = currentServer.SERVER_launch_arguments;
            btnSteamWorkshop.Enabled = currentServer.STEAM_workshop_enabled;
            incMaxPlayers.Value = currentServer.GAME_maxplayers;
            txtboxPORT.Text = currentServer.SERVER_port;

            //Clear the map dropdown list before adding new data to it.
            txtboxStartingMap.Items.Clear();


            var mapListing = Directory
            .EnumerateFiles(currentServer.DIR_install_location + @"\steamapps\common" + currentServer.DIR_root + currentServer.DIR_maps, currentServer.DIR_maps_file_extension, SearchOption.AllDirectories)
            .Select(Path.GetFileName); // <-- note you can shorten the lambda

            foreach (var mapfile in mapListing)
            {
                string preparedmap = Path.GetFileNameWithoutExtension(mapfile);

                //Specifically check for KF2's map system screwup to get around it.
                if (currentServer.SERVER_type == "Killing Floor 2")
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
            txtboxStartingMap.Text = currentServer.GAME_map;

            //Make properties boxes visible.
            groupboxServerProperties.Visible = true;
            groupboxGameProperties.Visible = true;
            btnDestroyServer.Visible = true;
            btnUpdateServerConfig.Visible = true;
            btnAddonControl.Visible = true;
            btnSteamWorkshop.Visible = true;
        }

        public void RefreshData()
        {
            comboboxGameserverList.Items.Clear();
            if (GameServerManagement.ServerCollection != null)
            {
                foreach (GameServerObject gameserver in GameServerManagement.ServerCollection)
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
            //Locate the associated GameServerObject, and allow the user to edit the values associated with them.
            var currentServer = GameServerManagement.PropertyGetSet(comboboxGameserverList.Text);
            DialogResult result = MetroMessageBox.Show(ActiveForm,
            "WARNING: Destroying a server is irreversible. are you sure you wish to do this?\nCurrently only the configuration will be destroyed, game data will need to be manually deleted.",
            "Destroy GameServer?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (result == DialogResult.Yes)
            {
                int GameServer_ObjectIndex = GameServerManagement.ServerCollection.FindIndex(x => x==currentServer);
                GameServerManagement.ServerCollection.RemoveAt(GameServer_ObjectIndex);

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
            if (chkFirewallToggle.Checked)
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
