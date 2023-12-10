using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BaoCaoCuoiKy
{
    internal class XL_DETAIL_ORDER
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        private Global global = new Global();
        private string connectionString;
        public XL_DETAIL_ORDER()
        {
            connectionString = global.pathDatabase;
            connection = new SqlConnection(connectionString);
        }
        public DataTable getListDetailOrder(string MaHD)
        {
            try
            {
                connection.Open();

                string query = "SELECT " +
                    "CHITIETHOADON.MaMon, " +
                    "MENU.Ten, " +
                    "CHITIETHOADON.SoLuong, " +
                    "CHITIETHOADON.DonGia, " +
                    "CHITIETHOADON.ThanhTien " +
                    "FROM CHITIETHOADON " +
                    "JOIN MENU ON CHITIETHOADON.MaMon = MENU.MaMon " +
                    "WHERE CHITIETHOADON.MaHD = @MaHD";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaHD", MaHD);

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



        public bool addDetailOrder(string MaHD, string MaMon, int SoLuong, int DonGia)
        {
            try
            {
                connection.Open();
                string insertCommand = "INSERT INTO CHITIETHOADON VALUES (@MaHD, @MaMon, @SoLuong, @DonGia)";

                command = new SqlCommand(insertCommand, connection);
                command.Parameters.AddWithValue("@MaHD", MaHD);
                command.Parameters.AddWithValue("@MaMon", MaMon);
                command.Parameters.AddWithValue("@SoLuong", SoLuong);
                command.Parameters.AddWithValue("@DonGia", DonGia);

                command.ExecuteNonQuery();
                return true;
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
