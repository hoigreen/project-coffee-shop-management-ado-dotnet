using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Get data admin
        public DataTable getAdmin(string maAD)
        {
            string selectCommand = "Select ad.MaAD, ad.HoTen , ad.SoDT From ADMIN ad";
            adapter = new SqlDataAdapter(selectCommand, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }

        // Kiểm tra tồn tại admin
        public bool AdminExists(string maAD)
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT COUNT(*) FROM ADMIN WHERE MaAD = @maAD";
                command = new SqlCommand(selectCommand, connection);
                command.Parameters.AddWithValue("@maAD", maAD);
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return count > 0;
            }
            catch
            {
                return false;
            }
        }

    }
}
