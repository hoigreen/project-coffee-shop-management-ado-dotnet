using BaoCaoCuoiKy.User_Control;
using BaoCaoCuoiKy.User_Control_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoCuoiKy
{
    public partial class Form_Main_Admin : Form
    {
        public string ValueFromForm1 { get; set; }
        private XL_ADMIN admin = new XL_ADMIN();
        public Form_Main_Admin()
        {
            InitializeComponent();
            UC_QuanLyMenu uc = new UC_QuanLyMenu();
            addUserControl(uc);
        }
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        string connectionString = @"Data Source=DangQuocHuy\SQLEXPRESS;Initial Catalog=QL_CAFE;Integrated Security=True";

        private void Form_Main_Admin_Load(object sender, EventArgs e)
        {
            lb_ma_admin.Text = ValueFromForm1;
            lb_name_admin.Text = getNameAdmin(ValueFromForm1);
        }

        // Hiển thị lại form trước đó khi form hiện tại đóng
        private void Form_Main_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Close();
            }
        }

        // Event Button đăng xuất
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string getNameAdmin(string maAD)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT HoTen FROM ADMIN WHERE MaAD = @MaAD";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaAD", maAD);
            object result = command.ExecuteScalar();
            return result.ToString();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
            panel_container.Controls.Clear();
            panel_container.Controls.Add(userControl);
            userControl.BringToFront(); 
        }

        private void btn_qly_menu_Click(object sender, EventArgs e)
        {
            UC_QuanLyMenu uc = new UC_QuanLyMenu();
            addUserControl(uc);
        }

        private void btn_qly_nhanvien_Click(object sender, EventArgs e)
        {
            UC_QuanLyNhanVien uc = new UC_QuanLyNhanVien();
            addUserControl(uc);
        }

        private void btn_qly_calam_Click(object sender, EventArgs e)
        {
            UC_QuanLyCaLam uc = new UC_QuanLyCaLam();
            addUserControl(uc);
        }

        private void btn_qly_ngaycong_Click(object sender, EventArgs e)
        {
            UC_QuanLyNgayCong uc = new UC_QuanLyNgayCong();
            addUserControl(uc);
        }

        private void btn_qly_hoadon_Click(object sender, EventArgs e)
        {
            UC_QuanLyHoaDon uc = new UC_QuanLyHoaDon();
            addUserControl(uc);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            UC_QuanLyThongKe uc = new UC_QuanLyThongKe();
            addUserControl(uc);
        }
    }
}
