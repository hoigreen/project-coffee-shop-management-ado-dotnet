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
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT MaCa FROM CALAM";

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

        public DataTable getListWorkTime()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM CALAM";

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

        public string getIdWorkTimeLastRow()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectCommand = "SELECT MaCa FROM CALAM ORDER BY MaCa DESC OFFSET 0 ROWS FETCH FIRST 1 ROW ONLY;";

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return "";
            }
        }

        public bool ExistsWorkTime(string MaCa)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectCommand = "SELECT COUNT(*) FROM CALAM WHERE MaCa = @MaCa";

                    using (SqlCommand command = new SqlCommand(selectCommand, connection))
                    {
                        command.Parameters.AddWithValue("@MaCa", MaCa);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            int count = Convert.ToInt32(result);
                            return count > 0;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool AddWorkTime(string MaCa, string TenCa, string ThoiGian, int Luong)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertCommand = "INSERT INTO CALAM VALUES(@MaCa, @TenCa, @ThoiGian, @Luong)";

                    using (SqlCommand command = new SqlCommand(insertCommand, connection))
                    {
                        command.Parameters.AddWithValue("@MaCa", MaCa);
                        command.Parameters.AddWithValue("@TenCa", TenCa);
                        command.Parameters.AddWithValue("@ThoiGian", ThoiGian);
                        command.Parameters.AddWithValue("@Luong", Luong);

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

        public bool DeleteWorkTime(string MaCa)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteCommand = "DELETE FROM CALAM WHERE MaCa = @MaCa";

                    using (SqlCommand command = new SqlCommand(deleteCommand, connection))
                    {
                        command.Parameters.AddWithValue("@MaCa", MaCa);

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

        public bool UpdateWorkTime(string MaCa, string TenCa, string ThoiGian, int Luong)
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
                                           "WHERE MaCa = @MaCa";

                    using (SqlCommand command = new SqlCommand(updateCommand, connection))
                    {
                        command.Parameters.AddWithValue("@TenCa", TenCa);
                        command.Parameters.AddWithValue("@ThoiGian", ThoiGian);
                        command.Parameters.AddWithValue("@Luong", Luong);
                        command.Parameters.AddWithValue("@MaCa", MaCa);

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
