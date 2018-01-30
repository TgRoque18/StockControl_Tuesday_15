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
    public partial class StockDetailsForm : Form
    {
        string name;
        bool active;
        int quantity;

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";


        public StockDetailsForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            StockAllForm stockallForm = new StockAllForm();

            stockallForm.Show();
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
                string sql = "INSERT INTO STOCK(QUANTITY, ACTIVE, NAME) VALUES (@quantity, @active, @name)";
                //string sql = "INSERT INTO CATEGORY(NAME, ACTIVE) VALUES (" 
                //    + this.tbxName.Text + "," + this.cbxActive.Checked + ")";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@quantity", quantity));
                cmd.Parameters.Add(new SqlParameter("@active", active));
                cmd.Parameters.Add(new SqlParameter("@name", name));
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");

                CleanData();
                
            }
            catch (Exception ex)
            {
                //Tratar exceções
                MessageBox.Show("Erro ao adicionar estoque!" + ex.Message);
                CleanData();
            }
            finally
            {
                //Fechar
                sqlConnect.Close();

            }
            CleanData();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            StockAllForm stockallForm = new StockAllForm();

            stockallForm.Show();
            this.Hide();
        }

        void GetData()
        {
            name = tbxName.Text;
            active = cbxActive.Checked;
            quantity = Int32.Parse(tbxQuantity.Text);
        }

        void CleanData()
        {
            tbxName.Text = "";
            cbxActive.Checked = false;
            tbxQuantity.Text = "";
        }

        private void StockDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
