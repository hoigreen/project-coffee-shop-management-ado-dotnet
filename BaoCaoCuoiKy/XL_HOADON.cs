using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class XL_HOADON
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        private Global global = new Global();
        private string connectionString;
        public XL_HOADON()
        {
            connectionString = global.pathDatabase;
            connection = new SqlConnection(connectionString);
        }

        public int getSumHoaDon()
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT COUNT(*) FROM HOADON";
                command = new SqlCommand(selectCommand, connection);
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return count;
            }
            catch
            {
                return 0;
            }
        }

        public DataTable getThongKe()
        {
            string query = "SELECT " +
                "MONTH(Ngay) AS Thang, " +
                "YEAR(Ngay) AS Nam, " +
                "COUNT(MaHD) AS TongSoHoaDon, " +
                "SUM(TongTien) AS TongDanhThu " +
                "FROM HOADON " +
                "GROUP BY MONTH(Ngay), YEAR(Ngay);";
            adapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable getDSHoaDon()
        {
            string query = "SELECT " +
                "HOADON.MaHD, " +
                "NHANVIEN.HoTenNV, " +
                "NHANVIEN.MaNV, " +
                "HOADON.Ngay, " +
                "HOADON.TongTien " +
                "FROM HOADON " +
                "JOIN NHANVIEN ON HOADON.MaNV = NHANVIEN.MaNV;";
            adapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
        public DataTable getDSHoaDon_Thang(string thang)
        {
            string query = "SELECT " +
                "HOADON.MaHD, " +
                "NHANVIEN.HoTenNV, " +
                "NHANVIEN.MaNV, " +
                "HOADON.Ngay, " +
                "HOADON.TongTien " +
                "FROM HOADON " +
                "JOIN NHANVIEN ON HOADON.MaNV = NHANVIEN.MaNV " +
                "WHERE MONTH(Ngay) = " + thang;
            adapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
        public DataTable getDSHoaDon_Ngay(string ngay)
        {
            string query = "SELECT " +
                "HOADON.MaHD, " +
                "NHANVIEN.HoTenNV, " +
                "NHANVIEN.MaNV, " +
                "HOADON.Ngay, " +
                "HOADON.TongTien " +
                "FROM HOADON " +
                "JOIN NHANVIEN ON HOADON.MaNV = NHANVIEN.MaNV " +
                "WHERE Ngay = " + ngay;
            adapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
    }
}
