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
    public partial class CategoryAllForm : Form
    {

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";

        public CategoryAllForm()
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

                SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY", sqlConnect);
                // SqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvCategory.DataSource = dt;

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
             dgvCategory.Columns["ID"].Visible = false;
             dgvCategory.Columns["NAME"].HeaderText = "Nome";
             dgvCategory.Columns["ACTIVE"].HeaderText = "Ativo";
           

            foreach (DataGridViewColumn col in dgvCategory.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeDetailsForm homeForm = new HomeDetailsForm();

            homeForm.Show();
            this.Hide();

        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm categoryForm = new CategoryDetailsForm();

            categoryForm.Show();
            this.Hide();
        }

        private void CategoryAllForm_Load(object sender, EventArgs e)
        {

        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idUser = Int32.Parse(dgvCategory.SelectedRows[0].Cells[0].Value.ToString());

            CategoryDetailsForm categoryDetailsForm = new CategoryDetailsForm(idUser);
            categoryDetailsForm.Show();

            this.Close();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idUser = Int32.Parse(dgvCategory.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    //Conectar
                    sqlConnect.Open();
                    string sql = "DELETE FROM CATEGORY WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idUser));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Removido com sucesso!");

                    ShowData();

                }
                catch (Exception ex)
                {
                    //Tratar exce��es
                    MessageBox.Show("Erro ao remover usu�rio!" + "\n\n" + ex.Message);
                    throw;
                }
                finally
                {
                    //Fechar
                    sqlConnect.Close();
                }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string optionForm = "CategoryForm";
            string optionString = "name";

            Search search = new Search();
            dgvCategory.DataSource = search.SearchFilter(connectionString, tbxSearch.Text, optionString, optionForm);

            tbxSearch.Text = "";
        }
    }
}
