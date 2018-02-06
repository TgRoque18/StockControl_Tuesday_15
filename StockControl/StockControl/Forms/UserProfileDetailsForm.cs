using StockControl.Class;
using StockControl.Forms;
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

namespace StockControl
{
    public partial class UserProfileForm : Form
    {
        string name;
        bool active = false;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";

        public UserProfileForm()
        {
            InitializeComponent();
        }

        public UserProfileForm(int idUserProfile)
        {
            InitializeComponent();

            lblId.Text = idUserProfile.ToString(); 

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    //Conectar
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM USER_PROFILE WHERE ID = @id", sqlConnect);
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ID = " + idCategory.ToString(), sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idUserProfile));

                    UserProfile userProfile = new UserProfile(); //------

                    using (SqlDataReader reader = cmd.ExecuteReader()) //-----
                    {
                        while (reader.Read())
                        {
                            userProfile.Id = Int32.Parse(reader["ID"].ToString());
                            userProfile.Name = reader["NAME"].ToString();
                            userProfile.Active = bool.Parse(reader["ACTIVE"].ToString());
                        }
                    }

                    tbxName.Text = userProfile.Name;
                    cbxActive.Checked = userProfile.Active;
                    

                    

                }
                catch (Exception EX)
                {
                    //Tratar exce��es
                    throw;
                }
                finally
                {
                    //Fechar
                    sqlConnect.Close();
                }
            }
        }


        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserProfileAllForm userProfile = new UserProfileAllForm();
            userProfile.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId.Text))
            {
                GetData();
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    //Conectar
                    sqlConnect.Open();
                    string sql = "INSERT INTO USER_PROFILE(NAME, ACTIVE) VALUES (@name, @active)";
                    //string sql = "INSERT INTO CATEGORY(NAME, ACTIVE) VALUES (" 
                    //    + this.tbxName.Text + "," + this.cbxActive.Checked + ")";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@active", active));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Adicionado com sucesso!");
                    Log.SalvarLog("Adicionado perfil de usuário", DateTime.Now);
                    CleanData();
                }

                catch (Exception ex)
                {
                    //Tratar exce��es
                    MessageBox.Show("Erro ao adicionar perfil de usuário !" + ex.Message);
                    CleanData();
                }

                finally
                {
                    //Fechar
                    sqlConnect.Close();

                }

            }

            else
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    sqlConnect.Open();
                    string sql = "UPDATE USER_PROFILE SET NAME = @name, ACTIVE = @active Where ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);
                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.Parameters.Add(new SqlParameter("@name", this.tbxName.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", this.cbxActive.Checked));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Alterações salvas com sucesso!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar esta perfil de usuário!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();

                    UserProfileAllForm userProfile = new UserProfileAllForm();
                    userProfile.Show();
                    this.Hide();
                }

            }

        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            UserProfileAllForm userProfile = new UserProfileAllForm();
            userProfile.Show();
            this.Hide();
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
