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
    public partial class UC_QuanLyThongKe : UserControl
    {
        public UC_QuanLyThongKe()
        {
            InitializeComponent();
        }
        private XL_NHANVIEN nhanvien = new XL_NHANVIEN();
        private XL_MENU menu = new XL_MENU();
        private XL_HOADON hoadon = new XL_HOADON();
        private DataTable dtThongKe = new DataTable();
        private Global global = new Global();

        private void UC_QuanLyThongKe_Load(object sender, EventArgs e)
        {
            lb_nhanvien.Text = nhanvien.getSumNhanVien().ToString();
            lb_hoadon.Text = hoadon.getSumHoaDon().ToString();
            lb_menu.Text = menu.getSumMenu().ToString();
            dtThongKe = hoadon.getThongKe();
            global.addDataGridView(dtThongKe, dg_thongke);
        }
    }
}
