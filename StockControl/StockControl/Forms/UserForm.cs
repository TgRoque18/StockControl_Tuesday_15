using StockControl.Class;
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
    public partial class UserForm : Form
    {
        string name;
        string email;
        string password;
        string passwordConfirm;
        bool active = false;
        UserProfile userProfile;
        Image profilePicture;
        string fileName;
       

        public UserForm()
        {
            InitializeComponent();
            
        }

        private void pbxAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                fileName = ofdSearchProfilePicture.FileName;
                tbxFileName.Text = fileName;
                profilePicture = Image.FromFile(fileName);
                pbxAddProfilePicture.Image = profilePicture;

                
              
            }
            
            catch (Exception ex)
            {

                MessageBox.Show("Não é possível exibir a imagem \n\nErro reportado : " + ex.Message);
            }
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserAllForm userAllForm = new UserAllForm();
            userAllForm.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            GetData();
            Construct();
            CleanData();
        }

        private void CleanData()
        {
            tbxName.Text = "";
            tbxEmail.Text = "";
            tbxPassword.Text = "";
            tbxConfirmPassword.Text = "";
            tbxProfile.Text = "";
            cbxActive.Checked = false;

        }

        private void Construct()
        {
            User user = new User(name, password, email, active, userProfile);
        }

        private void GetData()
        {
            name = tbxName.Text;
            email = tbxEmail.Text;
            password = tbxPassword.Text;
            passwordConfirm = tbxConfirmPassword.Text;
           
            active = cbxActive.Checked;

        }
    }
}
