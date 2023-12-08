using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoCuoiKy
{
    public partial class Form_Begin : Form
    {
        private Form_Login_Admin form_login_admin;
        private Form_Main_Staff form_main_staff;
        public Form_Begin()
        {
            InitializeComponent();
        }

        // Load Form
        private void Form_Begin_Load(object sender, EventArgs e)
        {

        }

        // Event Button vào form đăng nhập quản lý
        private void btn_qly_Click(object sender, EventArgs e)
        {
            if (form_login_admin == null || form_login_admin.IsDisposed)
            {
                form_login_admin = new Form_Login_Admin();
                form_login_admin.FormClosed += Form_Login_Admin_FormClosed;
                this.Hide();
                form_login_admin.Show();
            }
        }

        // Hiển thị lại form hiện tại nếu form_login_admin đóng
        private void Form_Login_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        // Hiển thị lại form hiện tịa nếu form_main_staff đóng
        private void Form_Main_Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        // Event Button thoát form
        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event Button vào form nhân viên
        private void btn_nvien_Click(object sender, EventArgs e)
        {
            if (form_main_staff == null || form_main_staff.IsDisposed)
            {
                form_main_staff = new Form_Main_Staff();
                form_main_staff.FormClosed += Form_Main_Staff_FormClosed;
                this.Hide();
                form_main_staff.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
