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

        public bool getStatusTable(int maBan)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT TrangThai FROM BAN WHERE MaBan = @MaBan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaBan", maBan);

                        bool result = (bool)command.ExecuteScalar();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return false;
            }
        }

        public string getIdOrderTable(int maBan)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT MaHD FROM BAN WHERE MaBan = @MaBan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaBan", maBan);

                        string result = command.ExecuteScalar().ToString();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return "";
            }
        }

        public bool combineTable(int maBan, string newMaHD)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE BAN SET MaHD = MaHD + ',' + @NewMaHD WHERE MaBan = @MaBan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewMaHD", newMaHD);
                        command.Parameters.AddWithValue("@MaBan", maBan);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return false;
            }
        }
        public bool setStatusTable(int maBan, bool trangThai, string maHD)
        {
            string MaHD = (string)((maHD == null) ? (object)DBNull.Value : maHD);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE BAN SET TrangThai = @TrangThai, MaHD = @MaHD WHERE MaBan = @MaBan";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaBan", maBan);
                        command.Parameters.AddWithValue("@TrangThai", trangThai);
                        command.Parameters.AddWithValue("@MaHD", MaHD);

                        command.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return false;
            }
        }
    }
}
