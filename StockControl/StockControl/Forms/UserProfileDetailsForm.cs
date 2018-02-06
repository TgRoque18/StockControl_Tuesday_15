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

        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserProfileAllForm userProfile = new UserProfileAllForm();
            userProfile.Show();
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
