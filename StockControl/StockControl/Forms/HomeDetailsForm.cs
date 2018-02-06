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
    public partial class HomeDetailsForm : Form
    {
        public HomeDetailsForm()
        {
            InitializeComponent();
        }

        private void pbxStock_Click(object sender, EventArgs e)
        {
            StockAllForm stockAllForm = new StockAllForm();

            stockAllForm.Show();
            this.Hide();

        }

        private void pbxCategory_Click(object sender, EventArgs e)
        {
            CategoryAllForm categoryAllForm = new CategoryAllForm();

            categoryAllForm.Show();
            this.Hide();

        }

        private void pbxUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileAllForm userProfileAllForm = new UserProfileAllForm();

            userProfileAllForm.Show();
            this.Hide();

        }

        private void pbxUser_Click(object sender, EventArgs e)
        {
            UserAllForm userAllForm = new UserAllForm();

            userAllForm.Show();
            this.Hide();

        }

        private void pbxLog_Click(object sender, EventArgs e)
        {
            LogAllForm logAllForm = new LogAllForm();

            logAllForm.Show();
            this.Hide();

        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            LoginDetailsForm loginForm = new LoginDetailsForm();

            loginForm.Show();
            this.Hide();

        }

        private void pbxStock_MouseEnter(object sender, EventArgs e)
        {
            pbxStock.BackColor = Color.DeepSkyBlue;
            lblStock.Visible = true;
        }

        private void pbxStock_MouseLeave(object sender, EventArgs e)
        {
            pbxStock.BackColor = Color.Transparent;
            lblStock.Visible = false;
        }


        private void pbxCategory_MouseEnter(object sender, EventArgs e)
        {
            pbxCategory.BackColor = Color.DeepSkyBlue;
            lblCategory.Visible = true;
        }

        private void pbxCategory_MouseLeave(object sender, EventArgs e)
        {
            pbxCategory.BackColor = Color.Transparent;
            lblCategory.Visible = false;
        }


        private void pbxLog_MouseEnter(object sender, EventArgs e)
        {
            pbxLog.BackColor = Color.DeepSkyBlue;
            lblLog.Visible = true;
        }

        private void pbxLog_MouseLeave(object sender, EventArgs e)
        {
            pbxLog.BackColor = Color.Transparent;
            lblLog.Visible = false;
        }


        private void pbxUser_MouseEnter(object sender, EventArgs e)
        {
            pbxUser.BackColor = Color.DeepSkyBlue;
            lblUser.Visible = true;
        }

        private void pbxUser_MouseLeave(object sender, EventArgs e)
        {
            pbxUser.BackColor = Color.Transparent;
            lblUser.Visible = false;
        }

        private void pbxUserProfile_MouseEnter(object sender, EventArgs e)
        {
            pbxUserProfile.BackColor = Color.DeepSkyBlue;
            lblProfile.Visible = true;
        }
        private void pbxUserProfile_MouseLeave(object sender, EventArgs e)
        {
            pbxUserProfile.BackColor = Color.Transparent;
            lblProfile.Visible = false;
        }

        private void pbxProduct_Click(object sender, EventArgs e)
        {
            ProductAllForm p = new ProductAllForm();
            p.Show();
            this.Hide();
        }

        private void pbxProduct_MouseEnter(object sender, EventArgs e)
        {
            pbxProduct.BackColor = Color.DeepSkyBlue;
            lblProduct.Visible = true;
        }

        private void pbxProduct_MouseLeave(object sender, EventArgs e)
        {
            pbxProduct.BackColor = Color.Transparent;
            lblProduct.Visible = false;
        }

        private void HomeDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
