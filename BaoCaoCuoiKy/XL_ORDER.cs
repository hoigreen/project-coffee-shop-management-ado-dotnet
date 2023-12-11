using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BaoCaoCuoiKy
{
    internal class XL_ORDER
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        private Global global = new Global();
        private string connectionString;
        public XL_ORDER()
        {
            connectionString = global.pathDatabase;
            connection = new SqlConnection(connectionString);
        }

        public string getIdOrderLastRow()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string selectCommand = "SELECT MaHD FROM HOADON ORDER BY MaHD DESC OFFSET 0 ROWS FETCH FIRST 1 ROW ONLY;";
                using (SqlCommand command = new SqlCommand(selectCommand, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "";
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public int getCountSumOrder()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string selectCommand = "SELECT COUNT(*) FROM HOADON";
                using (SqlCommand command = new SqlCommand(selectCommand, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public DataTable getStatis()
        {
            try
            {
                string query = "SELECT " +
                    "MONTH(Ngay) AS Thang, " +
                    "YEAR(Ngay) AS Nam, " +
                    "COUNT(MaHD) AS TongSoHoaDon, " +
                    "SUM(TongTien) AS TongDanhThu " +
                    "FROM HOADON " +
                    "GROUP BY MONTH(Ngay), YEAR(Ngay);";

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                adapter = new SqlDataAdapter(query, connection);
                dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null; 
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public int getTotalPay(string maHD)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT TongTien FROM HOADON WHERE MaHD = @MaHD";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaHD", maHD);
                        int result = Convert.ToInt32(command.ExecuteScalar());
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return 0;
            }
        }
        public string getDateTime(string maHD)
        {
            if (maHD == "") return "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Ngay FROM HOADON WHERE MaHD = @MaHD";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaHD", maHD);
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

        public DataTable getListOrder()
        {
            try
            {
                string query = "SELECT " +
                    "HOADON.MaHD, " +
                    "NHANVIEN.HoTenNV, " +
                    "NHANVIEN.MaNV, " +
                    "HOADON.Ngay, " +
                    "HOADON.TongTien " +
                    "FROM HOADON " +
                    "JOIN NHANVIEN ON HOADON.MaNV = NHANVIEN.MaNV;";

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                adapter = new SqlDataAdapter(query, connection);
                dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null; 
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public DataTable getListOrder_Month(string thang)
        {
            try
            {
                int thangValue = int.Parse(thang); 

                string query = "SELECT " +
                    "HOADON.MaHD, " +
                    "NHANVIEN.HoTenNV, " +
                    "NHANVIEN.MaNV, " +
                    "HOADON.Ngay, " +
                    "HOADON.TongTien " +
                    "FROM HOADON " +
                    "JOIN NHANVIEN ON HOADON.MaNV = NHANVIEN.MaNV " +
                    "WHERE MONTH(CONVERT(DATETIME, Ngay, 103)) = @Thang";

                adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Thang", thangValue);

                dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null; 
            }
        }

        public bool addOrder(string MaHD, string MaNV, string Ngay, int TongTien)
        {
            try
            {
                connection.Open();
                string insertCommand = "INSERT INTO HOADON (MaHD, MaNV, Ngay, TongTien) VALUES (@MaHD, @MaNV, @Ngay, @TongTien)";
                command = new SqlCommand(insertCommand, connection);
                command.Parameters.AddWithValue("@MaHD", MaHD);
                command.Parameters.AddWithValue("@MaNV", MaNV);
                command.Parameters.AddWithValue("@Ngay", Ngay);
                command.Parameters.AddWithValue("@TongTien", TongTien);

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

        public int getTotalRevenue()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string selectCommand = "SELECT SUM(TongTien) AS TongDoanhThu FROM HOADON";
                using (SqlCommand command = new SqlCommand(selectCommand, connection))
                {
                    int result = Convert.ToInt32(command.ExecuteScalar());
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public DataTable getTotalRevenue_Month()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string selectCommand = "SELECT " +
                                        "MONTH(CONVERT(DATETIME, Ngay, 103)) AS Thang, " +
                                        "SUM(TongTien) AS TongDoanhThu " +
                                        "FROM HOADON " +
                                        "GROUP BY MONTH(CONVERT(DATETIME, Ngay, 103));";
                using (SqlCommand command = new SqlCommand(selectCommand, connection))
                {
                    adapter = new SqlDataAdapter(selectCommand, connection);
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
                {
                    connection.Close();
                }
            }
        }
    }
}
