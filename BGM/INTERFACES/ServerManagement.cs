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
    public partial class ServerManagement : Form
    {
        public ServerManagement()
        {
            InitializeComponent();
        }

        //===================================================================================//
        // STARTUP                                                                           //
        //===================================================================================//
        private void GSM_Management_Load(object sender, EventArgs e)
        {
            //comboboxGameserverList.Items.Add(GSM_SettingsManagement_Classes.ReadValueFromXML("gameserver01/server_alias"));
        }

        //===================================================================================//
        // UPDATE SERVER CONFIGURATION                                                       //
        //===================================================================================//
        private void btnUpdateServerConfig_Click(object sender, EventArgs e)
        {
            txtCustomerName.Enabled = false;
            MetroMessageBox.Show(this, "Unfortunately this feature has not been implemented yet.  Please wait for an update to fix this!", "Not Implemented Yet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
