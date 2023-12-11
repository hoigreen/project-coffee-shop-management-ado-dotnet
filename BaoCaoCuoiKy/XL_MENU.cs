using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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

        public DataTable getTopBestSaler()
        {
            try
            {
                string query = "SELECT TOP 5 M.Ten, SUM(CHD.SoLuong) AS SoLuongBan " +
                               "FROM MENU AS M " +
                               "JOIN CHITIETHOADON AS CHD ON M.MaMon = CHD.MaMon " +
                               "GROUP BY M.MaMon, M.Ten " +
                               "ORDER BY SoLuongBan DESC;";
                connection.Open();

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
                    connection.Close();
            }
        }

        public DataTable getListMenuAll()
        {
            try
            {
                string query = "SELECT " +
                    "M.MaMon, " +
                    "M.Ten, " +
                    "M.Gia, " +
                    "D.ten AS DanhMuc " +
                    "FROM MENU M " +
                    "JOIN DANHMUC D ON M.DanhMuc = D.id;";

                connection.Open();

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
                    connection.Close();
            }
        }

        public DataTable getListMenu_Category(int id)
        {
            try
            {
                string query = "SELECT " +
                    "M.MaMon, " +
                    "M.Ten, " +
                    "M.Gia, " +
                    "D.ten AS DanhMuc " +
                    "FROM MENU M " +
                    "JOIN DANHMUC D ON M.DanhMuc = D.id " +
                    "WHERE M.DanhMuc = @id";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    adapter = new SqlDataAdapter(command);
                    dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    return dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null; // hoặc trả về DataTable.Empty nếu bạn không muốn trả về null
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public string getIdMenuLastRow()
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT MaMon FROM MENU ORDER BY MaMon DESC OFFSET 0 ROWS FETCH FIRST 1 ROW ONLY;";

                using (command = new SqlCommand(selectCommand, connection))
                {
                    object result = command.ExecuteScalar();
                    string id = (result != null) ? result.ToString() : "";
                    return id;
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
                    connection.Close();
            }
        }

        public int getPrice_Id(string maMon)
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT Gia FROM MENU WHERE MaMon = @maMon;";

                using (command = new SqlCommand(selectCommand, connection))
                {
                    command.Parameters.AddWithValue("@maMon", maMon);
                    int price = Convert.ToInt32(command.ExecuteScalar());
                    return price;
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
                    connection.Close();
            }
        }

        public int getCountSumMenu()
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT COUNT(*) FROM MENU";

                using (command = new SqlCommand(selectCommand, connection))
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
                    connection.Close();
            }
        }

        public bool ExistsMenu(string MaMon)
        {
            try
            {
                connection.Open();
                string selectCommand = "SELECT COUNT(*) FROM MENU WHERE MaMon = @MaMon";

                using (command = new SqlCommand(selectCommand, connection))
                {
                    command.Parameters.AddWithValue("@MaMon", MaMon);
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
                    connection.Close();
            }
        }

        public bool AddMenu(string MaMon, string Ten, int Gia, int DanhMuc)
        {
            try
            {
                connection.Open();
                string insertCommand = "INSERT INTO MENU VALUES(@MaMon, @Ten, @Gia, @DanhMuc)";

                using (command = new SqlCommand(insertCommand, connection))
                {
                    command.Parameters.AddWithValue("@MaMon", MaMon);
                    command.Parameters.AddWithValue("@Ten", Ten);
                    command.Parameters.AddWithValue("@Gia", Gia);
                    command.Parameters.AddWithValue("@DanhMuc", DanhMuc);

                    command.ExecuteNonQuery();
                    return true;
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
                    connection.Close();
            }
        }

        public bool DeleteMenu(string MaMon)
        {
            try
            {
                connection.Open();
                string deleteCommand = "DELETE FROM MENU WHERE MaMon = @MaMon";

                using (command = new SqlCommand(deleteCommand, connection))
                {
                    command.Parameters.AddWithValue("@MaMon", MaMon);
                    command.ExecuteNonQuery();
                    return true;
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
                    connection.Close();
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
                                           "WHERE MaMon = @MaMon";

                    using (SqlCommand command = new SqlCommand(updateCommand, connection))
                    {
                        command.Parameters.AddWithValue("@Ten", Ten);
                        command.Parameters.AddWithValue("@Gia", Gia);
                        command.Parameters.AddWithValue("@DanhMuc", DanhMuc);
                        command.Parameters.AddWithValue("@MaMon", MaMon);

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }



    }

}
