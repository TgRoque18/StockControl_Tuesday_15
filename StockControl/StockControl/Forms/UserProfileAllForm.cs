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
    public partial class UserProfileAllForm : Form
    {
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";


        public UserProfileAllForm()
        {
            InitializeComponent();
            ShowData();
            ResizeDataGridView();
        }

        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM USER_PROFILE", sqlConnect);
                // SqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvUserProfile.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar. " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void ResizeDataGridView()
        {
            dgvUserProfile.Columns["ID"].Visible = false;
            dgvUserProfile.Columns["NAME"].HeaderText = "Nome";
            dgvUserProfile.Columns["ACTIVE"].HeaderText = "Ativo";

            foreach (DataGridViewColumn col in dgvUserProfile.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void pbxBack_Click_1(object sender, EventArgs e)
        {
            HomeDetailsForm homeDetails = new HomeDetailsForm();
            homeDetails.Show();
            this.Hide();
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            UserProfileForm userProfileDetails = new UserProfileForm();
            userProfileDetails.Show();
            this.Hide();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {

            int idUser = Int32.Parse(dgvUserProfile.SelectedRows[0].Cells[0].Value.ToString());

            UserProfileForm userProfileDetailsForm = new UserProfileForm(idUser);
            userProfileDetailsForm.Show();

            this.Close();
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            string optionForm = "UserProfileForm";
            string optionString = "name";

            Search search = new Search();
            dgvUserProfile.DataSource = search.SearchFilter(connectionString, tbxSearch.Text, optionString, optionForm);

            tbxSearch.Text = "";
        
    }

        private void pbxDelete_Click_1(object sender, EventArgs e)
        {
            int idUser = Int32.Parse(dgvUserProfile.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                //Conectar
                sqlConnect.Open();
                string sql = "DELETE FROM USER_PROFILE WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idUser));

                cmd.ExecuteNonQuery();

                ShowData();

                MessageBox.Show("Removido com sucesso!");
                Log.SalvarLog("Removido perfil de usuário", DateTime.Now);
            }
            catch (Exception ex)
            {
                //Tratar exce��es
                MessageBox.Show("Erro ao remover perfil!" + "\n\n" + ex.Message);
                
            }
            finally
            {
                //Fechar
                sqlConnect.Close();
            }

        }

        private void dgvUserProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
