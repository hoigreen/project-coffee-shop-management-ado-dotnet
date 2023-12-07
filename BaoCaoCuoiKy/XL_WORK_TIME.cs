using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoCuoiKy
{
    internal class XL_WORK_TIME
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        private Global global = new Global();
        private string connectionString;

        public XL_WORK_TIME()
        {
            connectionString = global.pathDatabase;
            connection = new SqlConnection(connectionString);
        }

        public DataTable getListIdWorkTime()
        {
            string query = "SELECT MaCa FROM CALAM";
            adapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
        public DataTable getListWorkTime()
        {
            string query = "SELECT * FROM CALAM";
            adapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
        public bool ExistsWorkTime(string MaCa)
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT COUNT(*) FROM CALAM WHERE MaCa = @MaCa";
                command = new SqlCommand(selectCommand, connection);
                command.Parameters.AddWithValue("@MaCa", MaCa);
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return count > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool AddWorkTime(string MaCa, string TenCa, string ThoiGian, int Luong)
        {
            try
            {
                connection.Open();
                string insertCommand = "INSERT INTO CALAM VALUES(" +
                    "N'" + MaCa + "', " +
                    "N'" + TenCa + "', " +
                    "N'" + ThoiGian + "', " +
                    "N'" + Luong + "')";
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
        public bool DeleteWorkTime(string MaCa)
        {
            try
            {
                connection.Open();
                string deleteCommand = "DELETE FROM CALAM " +
                    "WHERE MaCa = '" + MaCa + "'";
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
        public bool UpdateWorkTIme(string MaCa, string TenCa, string ThoiGian, int Luong)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateCommand = "UPDATE CALAM SET " +
                                           "TenCa = @TenCa, " +
                                           "ThoiGian = @ThoiGian, " +
                                           "Luong = @Luong " +
                                           "Where MaCa = @MaCa";

                    using (SqlCommand command = new SqlCommand(updateCommand, connection))
                    {
                        command.Parameters.AddWithValue("@TenCa", TenCa);
                        command.Parameters.AddWithValue("@ThoiGian", ThoiGian);
                        command.Parameters.AddWithValue("@Luong", Luong);
                        command.Parameters.AddWithValue("@MaCa", MaCa);
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
