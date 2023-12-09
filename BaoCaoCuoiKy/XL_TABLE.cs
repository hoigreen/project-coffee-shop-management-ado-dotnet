using BaoCaoCuoiKy;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    internal class XL_TABLE
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        private string connectionString;
        private Global global = new Global();

        public XL_TABLE()
        {
            connectionString = global.pathDatabase;
            connection = new SqlConnection(connectionString);
        }
        public DataTable getListTable()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM BAN";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        return dataSet.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public DataTable getListIdTable()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT MaBan, TenBan FROM BAN";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        return dataSet.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

    }
}
