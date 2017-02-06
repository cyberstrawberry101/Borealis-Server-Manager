using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameServer_Manager
{
    public partial class Experimental_Area : Form
    {
        public Experimental_Area()
        {
            InitializeComponent();
        }

        private void Experimental_Area_Load(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                MetroMessageBox.Show(BorealisGameManager.ActiveForm, ServerAPI_Classes.QUERY_DATA(txtTriggerSearch.Text, txtPropertySearch.Text, txtappIDSearch.Text), "Query Result", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(BorealisGameManager.ActiveForm, "Cannot communicate with http://sfo3.hauteclaire.me", "Server Unreachable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
