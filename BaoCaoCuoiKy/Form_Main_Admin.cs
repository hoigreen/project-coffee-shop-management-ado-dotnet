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
        private Global global = new Global();
        private string connectionString;
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private SqlCommand command;
        public Form_Main_Admin()
        {
            InitializeComponent();
            connectionString = global.pathDatabase;
            UC_ADMIN_STATIS uc = new UC_ADMIN_STATIS();
            addUserControl(uc);
        }

        private void Form_Main_Admin_Load(object sender, EventArgs e)
        {
            lblInfoID.Text = ValueFromForm1;
            lb_name_admin.Text = getNameAdmin(ValueFromForm1);
            lblInfoName.Text = getNameAdmin(ValueFromForm1);
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


        private void btnExitWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitWindow_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            UC_ADMIN_MENU uc = new UC_ADMIN_MENU();
            addUserControl(uc);
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            UC_ADMIN_STAFF uc = new UC_ADMIN_STAFF();
            addUserControl(uc);
        }

        private void btnManageWorkTime_Click(object sender, EventArgs e)
        {
            UC_ADMIN_WORKTIME uc = new UC_ADMIN_WORKTIME();
            addUserControl(uc);
        }

        private void btnManageWorkDay_Click(object sender, EventArgs e)
        {
            UC_QuanLyNgayCong uc = new UC_QuanLyNgayCong();
            addUserControl(uc);

        }

        private void btnManageInvoice_Click(object sender, EventArgs e)
        {
            UC_ADMIN_ORDER uc = new UC_ADMIN_ORDER();
            addUserControl(uc);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            UC_ADMIN_STATIS uc = new UC_ADMIN_STATIS();
            addUserControl(uc);
        }
    }
}
