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


        public string getIdStaffLastRow()
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT * FROM NHANVIEN ORDER BY MaNV DESC OFFSET 0 ROWS FETCH FIRST 1 ROW ONLY;";

                command = new SqlCommand(selectCommand, connection);
                string id = command.ExecuteScalar().ToString();
                connection.Close();
                return id;
            }
            catch
            {
                return "";
            }
        }
        public int getCountSumStaff()
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT COUNT(*) FROM NHANVIEN";
                command = new SqlCommand(selectCommand, connection);
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return count ;
            }
            catch
            {
                return 0;
            }
        }

        public DataTable getListStaff()
        {
            string query = "SELECT * FROM NHANVIEN";
            adapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
        public bool ExistsStaff(string MaNV)
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT COUNT(*) FROM NHANVIEN WHERE MaNV = @MaNV";
                command = new SqlCommand(selectCommand, connection);
                command.Parameters.AddWithValue("@MaNV", MaNV);
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool AddStaff(string MaNV, string TenNV, string DienThoai, string GioiTinh,string ChucVu, string DiaChi, DateTime NgaySinh,DateTime NgayVaoLam )
        {
            try
            {
                connection.Open();
                string insertCommand = "INSERT INTO NHANVIEN VALUES(" +
                    "N'" + MaNV + "'," +
                    "N'" + TenNV + "'," +
                    "N'" + DienThoai + "'," +
                    "N'" + GioiTinh + "'," +
                    "'" + NgaySinh.ToShortDateString() + "'," +
                    "N'" + ChucVu + "'," +
                    "N'" + DiaChi + "'," +
                    "'" + NgayVaoLam.ToShortDateString() + "')";
                command = new SqlCommand(insertCommand, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
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
                        command.Parameters.AddWithValue("@NgaySinh", NgaySinh.ToShortDateString());
                        command.Parameters.AddWithValue("@ChucVu", ChucVu);
                        command.Parameters.AddWithValue("@DiaChi", DiaChi);
                        command.Parameters.AddWithValue("@NgayVaoLam", NgayVaoLam.ToShortDateString());
                        command.Parameters.AddWithValue("@MaNV", MaNV);
                        command.ExecuteNonQuery();
                    }
                }
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
