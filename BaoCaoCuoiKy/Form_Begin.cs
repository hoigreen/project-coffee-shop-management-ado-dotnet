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

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            if (form_main_staff == null || form_main_staff.IsDisposed)
            {
                form_main_staff = new Form_Main_Staff();
                form_main_staff.FormClosed += Form_Main_Staff_FormClosed;
                this.Hide();
                form_main_staff.Show();
            }
        }

        private void btnViewAdmin_Click(object sender, EventArgs e)
        {
            if (form_login_admin == null || form_login_admin.IsDisposed)
            {
                form_login_admin = new Form_Login_Admin();
                form_login_admin.FormClosed += Form_Login_Admin_FormClosed;
                this.Hide();
                form_login_admin.Show();
            }
        }

        private void btnExitWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
