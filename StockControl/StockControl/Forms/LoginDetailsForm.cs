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
    public partial class LoginDetailsForm : Form
    {
        string user;
        string password;

        public LoginDetailsForm()
        {
            InitializeComponent();
        }

        private void pbxLogIn_Click(object sender, EventArgs e)
        {
            GetData();

            HomeDetailsForm homeForm = new HomeDetailsForm();

            homeForm.Show();
            this.Hide();

        }

        private void pbxRecovery_Click(object sender, EventArgs e)
        {
            RecoveryEmailForm recoveryEmailForm = new RecoveryEmailForm();

            recoveryEmailForm.Show();
            this.Hide();

        }

        void GetData()
        {
            user = tbxUser.Text;
            password = tbxPassword.Text;
        }

        void CleanData()
        {
            tbxUser.Text = "";
            tbxPassword.Text = "";
        }


    }
}
