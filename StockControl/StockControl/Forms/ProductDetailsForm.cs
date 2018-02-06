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
    public partial class ProductDetailsForm : Form
    {
        List<Category> categories = new List<Category>();

        string name;
        float price;
        string category;
        bool active = false;

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";

        public ProductDetailsForm()
        {
            InitializeComponent();
            LoadComboBox();
            cmbCategory.DisplayMember = "NAME";
        }

        public ProductDetailsForm(int idProduct)
        {
            InitializeComponent();

            lblId.Text = idProduct.ToString(); //-------

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    //Conectar
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCT WHERE ID = @id", sqlConnect);
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ID = " + idCategory.ToString(), sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idProduct));

                    Product product = new Product(); //------

                    using (SqlDataReader reader = cmd.ExecuteReader()) //-----
                    {
                        while (reader.Read())
                        {
                            product.Id = Int32.Parse(reader["ID"].ToString());
                            product.Name = reader["NAME"].ToString();
                            product.Price = float.Parse(reader["PRICE"].ToString());
                            if(reader["ACTIVE"].ToString() == 1.ToString())
                            {
                                product.Active = true;
                            }
                            else
                            {
                                product.Active = false;
                            }
                            
                            //product.Category =
                            //{
                            //    Id = Int32.Parse(reader["FK_CATEGORY"].ToString())
                            //};

                        }
                    }

                    tbxName.Text = product.Name;
                    cbxActivation.Checked = product.Active;
                    

                    //Busca o index baseado no Select
                    int indexCombo = 0;
                    //if (user.UserProfile != null)
                    //{
                    //    indexCombo = user.UserProfile.Id;
                    //}

                    ////Inicializa o dropDown com as informações do banco
                    //InitializeComboBox(cbxProfile, indexCombo);

                }
                catch (Exception EX)
                {
                    //Tratar exceções
                    throw;
                }
                finally
                {
                    //Fechar
                    sqlConnect.Close();
                }
            }
        }

        private void LoadComboBox()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {

                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CATEGORY", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Category up = new Category(Int32.Parse(reader["ID"].ToString()), reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()));
                    //ers.Add(reader["ID"], reader["PRICE"],) // ??? not sure what to put here  as add is not available
                    categories.Add(up);
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
            foreach (Category p in categories)
            {
                cmbCategory.Items.Add(p);
            }

        }

        private void pbxReturn_Click(object sender, EventArgs e)
        {
            ProductAllForm productall = new ProductAllForm();

            productall.Show();
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
                string sql = "INSERT INTO PRODUCT(NAME, PRICE, ACTIVE, FK_CATEGORY) VALUES (@name, @price, @active, @category)";
                //string sql = "INSERT INTO CATEGORY(NAME, ACTIVE) VALUES (" 
                //    + this.tbxName.Text + "," + this.cbxActive.Checked + ")";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@price", price));
                cmd.Parameters.Add(new SqlParameter("@category", ((Category)cmbCategory.SelectedItem).Id));

                cmd.Parameters.Add(new SqlParameter("@active", active));


                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");

                CleanData();

            }
            catch (Exception ex)
            {
                //Tratar exceções
                MessageBox.Show("Erro ao adicionar produto!" + ex.Message);
                CleanData();
            }
            finally
            {
                //Fechar
                sqlConnect.Close();

            }
            CleanData();
        }


        void GetData()
        {
            name = tbxName.Text;
            price = float.Parse(tbxPrice.Text);
            category = cmbCategory.Text;
            cbxActivation.Checked = false;
        }

        void CleanData()
        {
            tbxName.Text = "";
            tbxPrice.Text = "";
            cmbCategory.Text = "";
            cbxActivation.Checked = false;
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
