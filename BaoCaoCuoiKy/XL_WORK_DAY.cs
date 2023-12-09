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
    internal class XL_WORK_DAY
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        private Global global = new Global();
        private string connectionString;

        public XL_WORK_DAY()
        {
            connectionString = global.pathDatabase;
            connection = new SqlConnection(connectionString);
        }
        public DataTable getListWorkDay()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT " +
                                   "NGAYCONG.MaCa, " +
                                   "CALAM.TenCa, " +
                                   "NGAYCONG.MaNV, " +
                                   "NHANVIEN.HoTenNV, " +
                                   "NGAYCONG.Ngay " +
                                   "FROM NGAYCONG " +
                                   "JOIN CALAM ON NGAYCONG.MaCa = CALAM.MaCa " +
                                   "JOIN NHANVIEN ON NGAYCONG.MaNV = NHANVIEN.MaNV;";

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

        public DataTable getListWorkDay_Month_Time(string thang, string MaCa)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query_where = "";
                    if (thang == "--")
                    {
                        query_where = "WHERE NGAYCONG.MaCa = @MaCa";
                    }
                    else if (MaCa == "--")
                    {
                        query_where = "WHERE MONTH(Ngay) = @Thang";
                    }
                    else
                    {
                        query_where = "WHERE NGAYCONG.MaCa = @MaCa and MONTH(Ngay) = @Thang";
                    }

                    string query = "SELECT " +
                                   "NGAYCONG.MaCa, " +
                                   "CALAM.TenCa, " +
                                   "NGAYCONG.MaNV, " +
                                   "NHANVIEN.HoTenNV, " +
                                   "NGAYCONG.Ngay " +
                                   "FROM NGAYCONG " +
                                   "JOIN CALAM ON NGAYCONG.MaCa = CALAM.MaCa " +
                                   "JOIN NHANVIEN ON NGAYCONG.MaNV = NHANVIEN.MaNV " +
                                   query_where;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@MaCa", MaCa);
                        adapter.SelectCommand.Parameters.AddWithValue("@Thang", thang);

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

        public DataTable getListWorkDay_Staff(string MaNV)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT " +
                                   "NGAYCONG.MaCa, " +
                                   "CALAM.TenCa, " +
                                   "NGAYCONG.Ngay " +
                                   "FROM NGAYCONG " +
                                   "JOIN CALAM ON NGAYCONG.MaCa = CALAM.MaCa " +
                                   "JOIN NHANVIEN ON NGAYCONG.MaNV = NHANVIEN.MaNV " +
                                   "WHERE NHANVIEN.MaNV = @MaNV";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@MaNV", MaNV);

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
