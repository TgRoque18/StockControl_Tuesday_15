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
    public partial class ProductAllForm : Form
    {

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";

        public ProductAllForm()
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

                SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCT", sqlConnect);
                // SqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvProduct.DataSource = dt;

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
            dgvProduct.Columns["ID"].Visible = false;
            dgvProduct.Columns["NAME"].HeaderText = "Nome";
            dgvProduct.Columns["ACTIVE"].HeaderText = "Ativo";
            dgvProduct.Columns["PRICE"].HeaderText = "Preço";
            dgvProduct.Columns["FK_CATEGORY"].Visible = false;

            foreach (DataGridViewColumn col in dgvProduct.Columns)
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
            ProductDetailsForm productdetails = new ProductDetailsForm();

            productdetails.Show();
            this.Hide();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idProduct = Int32.Parse(dgvProduct.SelectedRows[0].Cells[0].Value.ToString());

            ProductDetailsForm productDetails = new ProductDetailsForm(idProduct);
            productDetails.Show();

            this.Close();

        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idProduct = Int32.Parse(dgvProduct.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                //Conectar
                sqlConnect.Open();
                string sql = "DELETE FROM PRODUCT WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idProduct));

                cmd.ExecuteNonQuery();

                ShowData();

                MessageBox.Show("Removido com sucesso!");
            }
            catch (Exception ex)
            {
                //Tratar exceções
                MessageBox.Show("Erro ao remover usu�rio!" + "\n\n" + ex.Message);
                throw;
            }
            finally
            {
                //Fechar
                sqlConnect.Close();
            }
        }
    }



}

