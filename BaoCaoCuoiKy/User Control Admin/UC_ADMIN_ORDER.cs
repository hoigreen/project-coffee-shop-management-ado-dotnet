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

        private void UC_QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            comboBoxMonth.Items.Add("--");
            for (int i = 1; i <= 12; i++)
            {
                comboBoxMonth.Items.Add(i);
            }
            comboBoxMonth.SelectedIndex = 0;
            resetDataTable();
            dg_hoadon.Columns["col_ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
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

                textBoxOrderId.Text = MaHD;
                textBoxStaffName.Text = TenNV;
                textBoxStaffId.Text = MaNV;
                dateTimePickerPayment.Text = Ngay;
                textBoxTotalPayment.Text = Tong;

                dtdetail_order = detail_order.getListDetailOrder(MaHD);
                global.addDataGridView(dtdetail_order, dg_chitiethoadon);
            }
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetDataTable();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBoxOrderId.Text = "";
            textBoxStaffName.Text = "";
            textBoxStaffId.Text = "";
            dateTimePickerPayment.Text = "01/01/2023";
            textBoxTotalPayment.Text = "";
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            comboBoxMonth.Text = "--";
        }

        private void clearData()
        {
            textBoxOrderId.Text = "";
            textBoxStaffName.Text = "";
            textBoxStaffId.Text = "";
            dateTimePickerPayment.Text = "";
            textBoxTotalPayment.Text = "";
        }

        private void resetDataTable()
        {
            clearData();
            if (comboBoxMonth.Text == "--")
            {
                dtHoaDon = order.getListOrder();
            }
            else
            {
                dtHoaDon = order.getListOrder_Month(comboBoxMonth.Text);
            }
            global.addDataGridView(dtHoaDon, dg_hoadon);
        }
    }
}
