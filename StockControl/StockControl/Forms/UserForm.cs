using StockControl.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";


        public UserForm()
        {
            InitializeComponent();

            //select para popular perfil
            
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

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                //Conectar
                sqlConnect.Open();
               string sql = "INSERT INTO USER(NAME, PASSWORD, EMAIL, ACTIVE) VALUES (@name, @password, @email, @active)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@password", password));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.Parameters.Add(new SqlParameter("@active", active));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");
                CleanData();

            }
            catch (Exception ex)
            {
                //Tratar exceções
                MessageBox.Show("Erro ao adicionar categoria!" + ex.Message);
                CleanData();
            }
            finally
            {
                //Fechar
                sqlConnect.Close();

            }
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
