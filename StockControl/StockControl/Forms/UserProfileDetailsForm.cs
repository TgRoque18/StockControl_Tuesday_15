using StockControl.Class;
using StockControl.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl
{
    public partial class UserProfileForm : Form
    {
        string name;
        bool active = false;

        public UserProfileForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //erro
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserProfileAllForm userProfile = new UserProfileAllForm();
            userProfile.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            GetData();
            UserProfile userProfile = new UserProfile(active,name);
            CleanData();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

        }

        private void cbxActive_CheckedChanged(object sender, EventArgs e)
        {

        }
        void GetData()
        {
            name = tbxName.Text;
            active = cbxActive.Checked;
        }
        void CleanData()
        {
            tbxName.Text = "";
            cbxActive.Checked = false;
        }
    }
}
