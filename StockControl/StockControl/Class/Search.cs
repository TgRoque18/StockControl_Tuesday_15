using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl.Class
{
    public class Search
    {
        public DataTable SearchFilter(string connectionString, string parameter, string query, string optionForm)
        {

            string optionString = query;

            if (optionForm == "LogForm")
            {
                switch (optionString)
                {
                    case "description":
                        optionString = "SELECT * FROM LOG WHERE DESCRIPTION LIKE @value";
                        break;

                    case "date":
                        optionString = "SELECT * FROM LOG WHERE DATE LIKE @value";
                        break;
                }
            }

            else if (optionForm == "CategoryForm")
            {
                switch (optionString)
                {
                    case "name":
                        optionString = "SELECT * FROM CATEGORY  WHERE NAME LIKE @value";
                        break;

                    case "active":
                        optionString = "SELECT * FROM CATEGORY WHERE ACTIVE LIKE @value";
                        break;
                }
            }

            else if (optionForm == "LogTypeForm")
            {
                switch (optionString)
                {
                    case "name":
                        optionString = "SELECT * FROM LOG_tYPE  WHERE NAME LIKE @value";
                        break;

                    case "active":
                        optionString = "SELECT * FROM LOG_TYPE WHERE ACTIVE LIKE @value";
                        break;
                }
            }

            else if (optionForm == "ProductForm")
            {
                switch (optionString)
                {
                    case "name":
                        optionString = "SELECT * FROM PRODUCT WHERE NAME LIKE @value";
                        break;

                    case "active":
                        optionString = "SELECT * FROM PRODUCT WHERE ACTIVE LIKE @value";
                        break;

                    case "price":
                        optionString = "SELECT * FROM PRODUCT WHERE PRICE LIKE @value";
                        break;
                }
            }

            else if (optionForm == "StockForm")
            {
                switch (optionString)
                {
                    case "name":
                        optionString = "SELECT * FROM STOCK  WHERE NAME LIKE @value";
                        break;

                    case "active":
                        optionString = "SELECT * FROM STOCK WHERE ACTIVE LIKE @value";
                        break;

                    case "quantity":
                        optionString = "SELECT * FROM STOCK WHERE QUANTITY LIKE @value";
                        break;
                }
            }

            else if (optionForm == "UserForm")
            {
                switch (optionString)
                {
                    case "name":
                        optionString = "SELECT * FROM [USER]  WHERE NAME LIKE @value";
                        break;

                    case "active":
                        optionString = "SELECT * FROM [USER] WHERE ACTIVE LIKE @value";
                        break;

                    case "email":
                        optionString = "SELECT * FROM [USER] WHERE EMAIL LIKE @value";
                        break;
                }
            }

            else if (optionForm == "UserProfileForm")
            {
                switch (optionString)
                {
                    case "name":
                        optionString = "SELECT * FROM USER_PROFILE  WHERE NAME LIKE @value";
                        break;

                    case "active":
                        optionString = "SELECT * FROM USER_PROFILE WHERE ACTIVE LIKE @value";
                        break;
                }
            }

            //MySqlConnection sqlConnect = new MySqlConnection(connectionString);
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                //MySqlCommand cmd = new MySqlCommand(optionString, sqlConnect);
                SqlCommand cmd = new SqlCommand(optionString, sqlConnect);




                //cmd.Parameters.Add(new MySqlParameter("@value", "%" + parameter + "%")); //o percent duplo funciona na consulta sql com o like trazendo todas as ocorrencias da letra ou palavra digitada 
                cmd.Parameters.Add(new SqlParameter("@value", "%" + parameter + "%")); //o percent duplo funciona na consulta sql com o like trazendo todas as ocorrencias da letra ou palavra digitada 
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                //MySqlDataAdapter sqlDtAdapter = new MySqlDataAdapter(cmd);
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                return dt;
            }
            catch (Exception EX)
            {
                MessageBox.Show("erro ao conectar" + "\n\n" + EX.Message);

                return null;
            }
            finally
            {
                //Fechar
                sqlConnect.Close();
            }
        }
    }
}
