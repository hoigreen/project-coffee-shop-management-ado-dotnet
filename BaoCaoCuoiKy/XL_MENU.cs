using System;
using System.CodeDom;
using System.Collections;
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
    internal class XL_MENU
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        private string connectionString;
        private Global global = new Global();

        public XL_MENU()
        {
            connectionString = global.pathDatabase;
            connection = new SqlConnection(connectionString);
        }

        public DataTable getListMenuAll()
        {
            string query = "SELECT " +
                "M.MaMon," +
                "M.Ten," +
                "M.Gia," +
                "D.ten " +
                "FROM MENU M " +
                "JOIN  DANHMUC D ON M.DanhMuc = D.id;";
            adapter = new SqlDataAdapter(query, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable getListMenu_Category(int id)
        {
            string query = "SELECT " +
                "M.MaMon," +
                "M.Ten," +
                "M.Gia," +
                "D.ten " +
                "FROM MENU M " +
                "JOIN  DANHMUC D ON M.DanhMuc = D.id " +
                "WHERE   M.DanhMuc = '" + id + "'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                adapter = new SqlDataAdapter(command);
                dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet.Tables[0];
            }
        }

        public string getIdMenuLastRow()
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT * FROM MENU ORDER BY MaMon DESC OFFSET 0 ROWS FETCH FIRST 1 ROW ONLY;";

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

        public int getCountSumMenu()
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT COUNT(*) FROM MENU";
                    
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

        public bool ExistsMenu(string MaMon)
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT COUNT(*) FROM MENU WHERE MaMon = @MaMon";
                command = new SqlCommand(selectCommand, connection);
                command.Parameters.AddWithValue("@MaMon", MaMon);
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return count > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool AddMenu(string MaMon, string Ten, int Gia, int DanhMuc)
        {
            try
            {
                connection.Open();
                string insertCommand = "INSERT INTO MENU VALUES(N'" +
                    MaMon + "', N'" +
                    Ten + "', N'" +
                    Gia + "', N'" +
                    DanhMuc + "')";
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

        public bool DeleteMenu(string MaMon)
        {
            try
            {
                connection.Open();
                string deleteCommand = "DELETE FROM MENU" +
                    " WHERE MaMon = '" + MaMon + "'";

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

        public bool UpdateMenu(string MaMon, string Ten, int Gia, int DanhMuc)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateCommand = "UPDATE MENU SET " +
                                           "Ten = @Ten, " +
                                           "Gia = @Gia, " +
                                           "DanhMuc = @DanhMuc " +
                                           "Where MaMon = @MaMon";
                    using (SqlCommand command = new SqlCommand(updateCommand, connection))
                    {
                        command.Parameters.AddWithValue("@Ten", Ten);
                        command.Parameters.AddWithValue("@Gia", Gia);
                        command.Parameters.AddWithValue("@DanhMuc", DanhMuc);
                        command.Parameters.AddWithValue("@MaMon", MaMon);
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
