﻿using System;
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
            lblEstoque.Visible = true;
        }

        private void pbxStock_MouseLeave(object sender, EventArgs e)
        {
            pbxStock.BackColor = Color.White;
            lblEstoque.Visible = false;
        }

        private void HomeDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
