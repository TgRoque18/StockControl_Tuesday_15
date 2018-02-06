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
        List<UserProfile> userProfiles = new List<UserProfile>();
        string name;
        string email;
        string password;
        string passwordConfirm;
        bool active = false;
        Image profilePicture;
        string fileName;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";


        public UserForm()
        {
            InitializeComponent();
            LoadComboBox();
            cmbUserProfile.DisplayMember = "NAME";
        }

        private void LoadComboBox()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {

                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM USER_PROFILE", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UserProfile up = new UserProfile(Int32.Parse(reader["ID"].ToString()), bool.Parse(reader["ACTIVE"].ToString()),reader["NAME"].ToString());
                    //ers.Add(reader["ID"], reader["PRICE"],) // ??? not sure what to put here  as add is not available
                    userProfiles.Add(up);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar banco. " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            foreach (UserProfile p in userProfiles)
            {
                cmbUserProfile.Items.Add(p);
            }

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
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();

                //Conectar
                sqlConnect.Open();
                //COMENTARIOS THIAGO ROQUE
                /*Quando a tabela do banco usa uma palavra reservada pelo SQL 
                 * neste caso USER, devemos colocar ela entre []
                 * EX:. [USER]
                 */
                string sql = "INSERT INTO [USER](NAME, PASSWORD, EMAIL, ACTIVE, FK_USER_PROFILE) VALUES (@name, @password, @email, @active, @userProfile)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@password", password));
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.Parameters.Add(new SqlParameter("@active", active));
                //COMENTARIOS THIAGO ROQUE
                /*Pegar sempre o item de outra tabela pelo ID,
                 * O Index representa a posição dele no banco
                 * EX:. quarto item, setimo item
                 * Fiz uma conversao implicita, ou seja coloco o tipo do item pra qual 
                 * eu quero converter antes do item
                 * EX:. (Int32)idade -> converte a variavel idade no tipo Int32
                 */
                cmd.Parameters.Add(new SqlParameter("@userProfile", ((UserProfile)cmbUserProfile.SelectedItem).Id));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário adicionado com sucesso!");

            }
            catch (Exception ex)
            {
                //Tratar exceções
                MessageBox.Show("Erro ao adicionar o usuário!" + ex.Message);
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
            cmbUserProfile.Text = "";
            cbxActive.Checked = false;
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
