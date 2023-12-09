using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoCuoiKy
{
    internal class XL_ADMIN
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        private Global global = new Global();
        public XL_ADMIN()
        {
            string connectionString = global.pathDatabase;
            connection = new SqlConnection(connectionString);
        }

        public DataTable getAdmin(string maAD)
        {
            try
            {
                string selectCommand = "SELECT ad.MaAD, ad.HoTen, ad.SoDT FROM ADMIN ad WHERE ad.MaAD = @MaAD";

                connection.Open();

                using (SqlCommand command = new SqlCommand(selectCommand, connection))
                {
                    command.Parameters.AddWithValue("@MaAD", maAD);

                    adapter = new SqlDataAdapter(command);
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

        public bool AdminExists(string maAD)
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT COUNT(*) FROM ADMIN WHERE MaAD = @maAD";

                command = new SqlCommand(selectCommand, connection);
                command.Parameters.AddWithValue("@maAD", maAD);

                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
