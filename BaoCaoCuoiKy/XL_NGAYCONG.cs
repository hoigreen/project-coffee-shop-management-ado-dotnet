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
    internal class XL_NGAYCONG
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        private Global global = new Global();
        private string connectionString;

        public XL_NGAYCONG()
        {
            connectionString = global.pathDatabase;
            connection = new SqlConnection(connectionString);
        }
        public DataTable getDSNgayCong()
        {
            string query = "SELECT " +
                "NGAYCONG.MaCa, " +
                "CALAM.TenCa, " +
                "NGAYCONG.MaNV, " +
                "NHANVIEN.HoTenNV, " +
                "NGAYCONG.Ngay " +
                "FROM NGAYCONG " +
                "JOIN CALAM ON NGAYCONG.MaCa = CALAM.MaCa " +
                "JOIN NHANVIEN ON NGAYCONG.MaNV = NHANVIEN.MaNV;";
            adapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
        public DataTable getDSNgayCong_Thang_Ca(string thang, string MaCa)
        {
            string query_where = "";
            if(thang == "--" )
            {
                query_where = "WHERE NGAYCONG.MaCa = '" + MaCa + "'";
            }
            else if(MaCa == "--")
            {
                query_where = "WHERE MONTH(Ngay) = " + thang;
            }
            else
            {
                query_where = "WHERE NGAYCONG.MaCa = '" + MaCa + "' and MONTH(Ngay) = " + thang;
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

            adapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
        public DataTable getDSNgayCong_NhanVien(string MaNV)
        {
            string query = "SELECT " +
               "NGAYCONG.MaCa, " +
               "CALAM.TenCa, " +
               "NGAYCONG.Ngay " +
               "FROM NGAYCONG " +
               "JOIN CALAM ON NGAYCONG.MaCa = CALAM.MaCa " +
               "JOIN NHANVIEN ON NGAYCONG.MaNV = NHANVIEN.MaNV " +
               "WHERE NHANVIEN.MaNV = '" + MaNV + "'";

            adapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
    }
}
