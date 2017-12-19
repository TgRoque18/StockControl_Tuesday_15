using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl.Forms
{
    public partial class UserProfileAllForm : Form
    {
        public UserProfileAllForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            //erro
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            //erro
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            //erro
        }

        private void pbxBack_Click_1(object sender, EventArgs e)
        {
            HomeDetailsForm homeDetails = new HomeDetailsForm();
            homeDetails.Show();
            this.Hide();
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            UserProfileForm userProfileDetails = new UserProfileForm();
            userProfileDetails.Show();
            this.Hide();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void pbxSave_Click_1(object sender, EventArgs e)
        {
            //erro
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {

        }

        private void pbxDelete_Click_1(object sender, EventArgs e)
        {

        }
    }
}
