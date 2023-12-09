using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Security.Cryptography;

namespace BaoCaoCuoiKy
{
    public partial class Form_Login_Admin : Form
    {
        private Form_Main_Admin form_main_admin;
        public Form_Login_Admin()
        {
            InitializeComponent();
        }
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;

        private String maAD, matKhau;
        private XL_ADMIN admin = new XL_ADMIN();
        private Global global = new Global();
        private string connectionString ;
        

        private void Form_Login_Admin_Load(object sender, EventArgs e)
        {
            connectionString = global.pathDatabase;
        }

        // button thoát
        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        // Hiển thị lại form trước đó khi form hiện tại đóng
        private void Form_Login_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đảm bảo rằng khi form mới đóng, form cũ sẽ được hiển thị lại
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Hủy sự kiện đóng form để xử lý tại sự kiện FormClosed
                this.Close();
            }
        }

        // Hiển thị lại form hiện tại khi form_main_admin đóng
        private void Form_Main_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        // button login
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        // Kiểm tra mật khẩu người dùng đăng nhập
        private bool checkMatKhau(string MaAD, string mk)
        {
            // Thiết lập chuỗi kết nối đến SQL Server
            connection = new SqlConnection(connectionString);
            connection.Open();

            // Tạo câu truy vấn SQL để kiểm tra mã học sinh
            string query = "SELECT MatKhau FROM ADMIN WHERE MaAD = @MaAD";
            SqlCommand command = new SqlCommand(query, connection);

            // Thực thi truy vấn và nhận giá trị trả về
            command.Parameters.AddWithValue("@MaAD", MaAD);
            object result = command.ExecuteScalar();

            // Nếu không tìm thấy kết quả trả về false 
            if (result == null) { return false; }

            // Nếu có kết quả trả về kết quả
            string hashedPasswordFromDatabase = result.ToString();
            return VerifyPassword(mk, hashedPasswordFromDatabase);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            maAD = textBoxUsername.Text;
            matKhau = textBoxPassword.Text;
            // Tồn tại admin
            if (admin.AdminExists(maAD))
            {
                if (checkMatKhau(maAD, matKhau))
                {
                    global.notify("Đăng nhập thành công");
                    textBoxPassword.Text = "";
                    // Kiểm tra nếu form mới chưa được khởi tạo hoặc đã bị giải phóng (đóng)
                    if (form_main_admin == null || form_main_admin.IsDisposed)
                    {
                        form_main_admin = new Form_Main_Admin();
                        // Gắn sự kiện cho form mới khi đóng
                        form_main_admin.FormClosed += Form_Main_Admin_FormClosed;
                        this.Hide();
                        form_main_admin.ValueFromForm1 = textBoxUsername.Text;
                        form_main_admin.Show();
                    }
                }
                else
                {
                    global.notify("Mật khẩu không chính xác");
                }
            }
            // Không tồn tại admin
            else
            {
                global.notify("Không tồn tại admin");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_loign_maNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_login_mk_TextChanged(object sender, EventArgs e)
        {

        }

        // So sánh mật khẩu sau khi hash
        static bool VerifyPassword(string enteredPassword, string hashedPasswordFromDatabase)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Hash mật khẩu được nhập từ người dùng
                byte[] enteredPasswordHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(enteredPassword));
                // Hash mật khẩu từ database
                byte[] hashedPasswordFromDatabaseHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(hashedPasswordFromDatabase));

                // So sánh mật khẩu đã hash
                return enteredPasswordHash.SequenceEqual(hashedPasswordFromDatabaseHash);
            }
        }
    }
}
