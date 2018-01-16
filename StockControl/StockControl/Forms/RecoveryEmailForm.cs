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
    public partial class RecoveryEmailForm : Form
    {
        string email;
      

        public RecoveryEmailForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            LoginDetailsForm loginForm = new LoginDetailsForm();

            loginForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GetData();

            CleanData();

            LoginDetailsForm loginForm = new LoginDetailsForm();

            loginForm.Show();
            this.Hide();

            MessageBox.Show("Verifique seu email para redefinição de senha.");

        }

        void GetData()
        {
            email = tbxEmail.Text;
        }

        void CleanData()
        {
            tbxEmail.Text = "";
        }
    }
}
