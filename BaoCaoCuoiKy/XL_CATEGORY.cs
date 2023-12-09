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
    internal class XL_CATEGORY
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        private string connectionString;
        private Global global = new Global();

        public XL_CATEGORY()
        {
            connectionString = global.pathDatabase;
            connection = new SqlConnection(connectionString);
        }
        public DataTable getListNameCategory()
        {
            try
            {
                string query = "SELECT * FROM DANHMUC";

                connection.Open();

                using (adapter = new SqlDataAdapter(query, connection))
                {
                    dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

    }
}
