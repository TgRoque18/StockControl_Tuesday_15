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
    }
}
