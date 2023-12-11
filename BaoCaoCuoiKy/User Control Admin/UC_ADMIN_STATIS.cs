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

namespace BaoCaoCuoiKy.User_Control_Admin
{
    public partial class UC_ADMIN_STATIS : UserControl
    {
        public UC_ADMIN_STATIS()
        {
            InitializeComponent();
        }
        private XL_STAFF nhanvien = new XL_STAFF();
        private XL_MENU menu = new XL_MENU();
        private XL_ORDER hoadon = new XL_ORDER();
        private DataTable dtThongKe = new DataTable();
        private Global global = new Global();

        private void UC_QuanLyThongKe_Load(object sender, EventArgs e)
        {
            lblAmountStaff.Text = nhanvien.getCountSumStaff().ToString();
            lblAmountOrder.Text = hoadon.getCountSumOrder().ToString();
            lblAmountItems.Text = menu.getCountSumMenu().ToString();
            dtThongKe = hoadon.getStatis();
            global.addDataGridView(dtThongKe, dg_thongke);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
