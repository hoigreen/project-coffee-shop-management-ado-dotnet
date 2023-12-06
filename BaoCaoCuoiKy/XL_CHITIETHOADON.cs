using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class XL_CHITIETHOADON
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        private Global global = new Global();
        private string connectionString;
        public XL_CHITIETHOADON()
        {
            connectionString = global.pathDatabase;
            connection = new SqlConnection(connectionString);
        }
        public DataTable getDSChiTietHoaDon(string MaHD)
        {
            string query = "SELECT " +
                "CHITIETHOADON.MaMon, " +
                "MENU.Ten, " +
                "CHITIETHOADON.SoLuong, " +
                "CHITIETHOADON.DonGia, " +
                "CHITIETHOADON.ThanhTien " +
                "FROM CHITIETHOADON " +
                "JOIN MENU ON CHITIETHOADON.MaMon = MENU.MaMon " +
                "WHERE CHITIETHOADON.MaHD = '" + MaHD + "'";
            adapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
    }
}
