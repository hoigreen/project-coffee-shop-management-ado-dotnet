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
    internal class XL_STAFF
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        private Global global = new Global();
        private string connectionString;


        public XL_STAFF()
        {
            connectionString = global.pathDatabase;
            connection = new SqlConnection(connectionString);
        }

        public string getNameStaff(string maNV)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT HoTenNV FROM NHANVIEN WHERE MaNV = @MaNV";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNV", maNV);

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

        public DataTable getListStaff()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string query = "SELECT * FROM NHANVIEN";
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
                {
                    connection.Close();
                }
            }
        }

        public string getIdStaffLastRow()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string selectCommand = "SELECT MaNV FROM NHANVIEN ORDER BY MaNV DESC OFFSET 0 ROWS FETCH FIRST 1 ROW ONLY;";
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

        public int getCountSumStaff()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string selectCommand = "SELECT COUNT(*) FROM NHANVIEN";
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

        public bool ExistsStaff(string MaNV)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string selectCommand = "SELECT COUNT(*) FROM NHANVIEN WHERE MaNV = @MaNV";
                using (SqlCommand command = new SqlCommand(selectCommand, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", MaNV);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public bool AddStaff(string MaNV, string TenNV, string DienThoai, string GioiTinh, string ChucVu, string DiaChi, DateTime NgaySinh, DateTime NgayVaoLam)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string insertCommand = "INSERT INTO NHANVIEN VALUES(" +
                    "@MaNV, @TenNV, @DienThoai, @GioiTinh, @NgaySinh, @ChucVu, @DiaChi, @NgayVaoLam)";

                using (SqlCommand command = new SqlCommand(insertCommand, connection))
                {
                    command.Parameters.AddWithValue("@MaNV", MaNV);
                    command.Parameters.AddWithValue("@TenNV", TenNV);
                    command.Parameters.AddWithValue("@DienThoai", DienThoai);
                    command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    command.Parameters.AddWithValue("@ChucVu", ChucVu);
                    command.Parameters.AddWithValue("@DiaChi", DiaChi);
                    command.Parameters.AddWithValue("@NgayVaoLam", NgayVaoLam);

                    command.ExecuteNonQuery();
                }

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
                {
                    connection.Close();
                }
            }
        }

        public bool DeleteStaff(string MaNV)

        {
            try
            {
                connection.Open();
                string deleteCommand = "DELETE FROM NHANVIEN" +
                    " WHERE MaNV = '" + MaNV + "'";
                command = new SqlCommand(deleteCommand, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateStaff(string MaNV, string TenNV, string DienThoai, string GioiTinh, string ChucVu, string DiaChi, DateTime NgaySinh, DateTime NgayVaoLam)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string updateCommand = "UPDATE NHANVIEN SET " +
                                       "HoTenNV = @TenNV, " +
                                       "DienThoai = @DienThoai, " +
                                       "GioiTinh = @GioiTinh, " +
                                       "NgaySinh = @NgaySinh, " +
                                       "ChucVu = @ChucVu, " +
                                       "DiaChi = @DiaChi, " +
                                       "NgayVaoLam = @NgayVaoLam " +
                                       "Where MaNV = @MaNV";

                using (SqlCommand command = new SqlCommand(updateCommand, connection))
                {
                    command.Parameters.AddWithValue("@TenNV", TenNV);
                    command.Parameters.AddWithValue("@DienThoai", DienThoai);
                    command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    command.Parameters.AddWithValue("@ChucVu", ChucVu);
                    command.Parameters.AddWithValue("@DiaChi", DiaChi);
                    command.Parameters.AddWithValue("@NgayVaoLam", NgayVaoLam);
                    command.Parameters.AddWithValue("@MaNV", MaNV);

                    command.ExecuteNonQuery();
                }

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
                {
                    connection.Close();
                }
            }
        }

    }
}
