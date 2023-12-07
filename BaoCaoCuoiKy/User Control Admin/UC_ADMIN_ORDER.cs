using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoCuoiKy.User_Control
{
    public partial class UC_ADMIN_ORDER : UserControl
    {
        public UC_ADMIN_ORDER()
        {
            InitializeComponent();
        }
        private DataTable dtHoaDon = new DataTable();
        private DataTable dtdetail_order = new DataTable();
        private XL_ORDER order = new XL_ORDER();
        private XL_DETAIL_ORDER detail_order = new XL_DETAIL_ORDER();
        private Global global = new Global();

        private string MaHD, TenNV, MaNV, Ngay, Tong;

        private void cb_locThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetDataTable();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_maHD.Text = "";
            tb_tenNV.Text = "";
            tb_maNV.Text = "";
            dt_ngay.Text = "01/01/2023";
            tb_tong.Text = "";
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            cb_locThang.Text = "--";
        }

        private void UC_QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            cb_locThang.SelectedIndex = 0;
            resetDataTable();
            dg_hoadon.Columns["col_ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dg_hoadon.SelectionChanged += DgHoaDon_SelectionChanged;
        }
        private void DgHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_hoadon.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dg_hoadon.SelectedRows[0];
                string MaHD = selectedRow.Cells["col_maHD"].Value.ToString();
                string TenNV = selectedRow.Cells["col_ten"].Value.ToString();
                string MaNV = selectedRow.Cells["col_maNV"].Value.ToString();
                string Ngay = selectedRow.Cells["col_ngay"].Value.ToString();
                string Tong = selectedRow.Cells["col_tong"].Value.ToString();

                tb_maHD.Text = MaHD;
                tb_tenNV.Text = TenNV;
                tb_maNV.Text = MaNV;
                dt_ngay.Text = Ngay;
                tb_tong.Text = Tong;

                dtdetail_order = detail_order.getListDetailOrder(MaHD);
                global.addDataGridView(dtdetail_order, dg_chitiethoadon);
            }
        }
        private void clearData()
        {
            tb_maHD.Text = "";
            tb_tenNV.Text = "";
            tb_maNV.Text = "";
            dt_ngay.Text = "";
            tb_tong.Text = "";
        }
        private void resetDataTable()
        {
            clearData();
            if (cb_locThang.Text == "--")
            {
                dtHoaDon = order.getListOrder();
            }
            else
            {
                dtHoaDon = order.getListOrder_Month(cb_locThang.Text);
            }
            global.addDataGridView(dtHoaDon, dg_hoadon);
        }
    }
}
