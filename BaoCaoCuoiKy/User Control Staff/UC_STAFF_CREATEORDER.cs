using BaoCaoCuoiKy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoffeeShopManagement.User_Control_Staff
{
    public partial class UC_STAFF_CREATEORDER : UserControl
    {
        private XL_ORDER order = new XL_ORDER();
        private XL_TABLE table = new XL_TABLE();
        private XL_STAFF staff = new XL_STAFF();
        private XL_CATEGORY catgory = new XL_CATEGORY();
        private XL_MENU menu = new XL_MENU();
        private XL_DETAIL_ORDER detailOrder = new XL_DETAIL_ORDER();
        private DataTable dtTable = new DataTable();
        private DataTable dtStaff = new DataTable();
        private DataTable dtCategory = new DataTable();
        private DataTable dtMenu = new DataTable();

        private DataTable dtDetailOrder = new DataTable();

        private Global global = new Global();

        private int sttDetailOrder = 1, SoLuong, DonGia, TongTien;
        private string MaHD, MaNV, MaMon, Ngay;
        public UC_STAFF_CREATEORDER()
        {
            InitializeComponent();
        }

        private void UC_STAFF_CREATEORDER_Load(object sender, EventArgs e)
        {
            panel_infoPayment.Visible = false;
            btn_printOrder.Visible = false;

            dtDetailOrder.Columns.Add("stt", typeof(int));
            dtDetailOrder.Columns.Add("Mã món", typeof(string));
            dtDetailOrder.Columns.Add("Tên món ăn", typeof(string));
            dtDetailOrder.Columns.Add("Đơn giá", typeof(int));
            dtDetailOrder.Columns.Add("Số lượng", typeof(int));
            dtDetailOrder.Columns.Add("Thành tiền", typeof(int));

            string id = order.getIdOrderLastRow();
            tb_idOrder.Text = global.autoIncrementId(id);

            dtTable = table.getListIdTable();
            dtTable.Rows.Add(0,"Không");
            setListCombobox(cb_table, dtTable);
            cb_table.SelectedIndex = cb_table.Items.Count - 1;

            dtStaff = staff.getListStaff();
            setListCombobox(cb_staffPay, dtStaff);

            dtCategory = catgory.getListNameCategory();
            setListCombobox(cb_category, dtCategory);

            DateTime currentDateTime = DateTime.Now;
            dt_datePay.Value = currentDateTime;

            tb_quantity.Text = "1";
            btn_reduce.Enabled = false;
        }

        private void btn_createOrder_Click(object sender, EventArgs e)
        {
            panel_infoPayment.Visible = true;
            btn_printOrder.Visible = true;

            MaHD = tb_idOrder.Text;
            DataRowView selectedRow = (DataRowView)cb_staffPay.SelectedItem;
            MaNV = selectedRow.Row[0].ToString();
            Ngay = dt_datePay.Value.ToString("dd/MM/yyyy HH:mm:ss");
            TongTien = caculateTotalMoney();
            MessageBox.Show("NV: " + Ngay);

            order.addOrder(MaHD, MaNV, Ngay, TongTien);
            foreach (DataRow row in dtDetailOrder.Rows)
            {
                MaMon = row["Mã món"].ToString();
                SoLuong = (int)row["Số lượng"];
                DonGia = (int)row["Đơn giá"];
                detailOrder.addDetailOrder(MaHD, MaMon, SoLuong, DonGia);
            }

        }

        private void btn_printOrder_Click(object sender, EventArgs e)
        {

        }
        private void tb_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cb_category.SelectedItem;
            int idCate = Convert.ToInt32(selectedRow.Row[0]);

            dtMenu = menu.getListMenu_Category(idCate);
            setListCombobox(cb_product, dtMenu);
        }

        private void setListCombobox(ComboBox combobox, DataTable dataTable)
        {
            combobox.DataSource = dataTable;
            combobox.DisplayMember = dataTable.Columns[1].ColumnName;
            combobox.ValueMember = dataTable.Columns[0].ColumnName;
        }

        private void btn_reduce_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(tb_quantity.Text);
            quantity -= 1;
            tb_quantity.Text = quantity.ToString();
            checkButtonQuantity();
        }

        private void btn_increase_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(tb_quantity.Text);
            quantity += 1;
            tb_quantity.Text = quantity.ToString();
            checkButtonQuantity();
        }
        private void checkButtonQuantity()
        {
            int quantity = Convert.ToInt32(tb_quantity.Text);
            if(quantity == 1)
                btn_reduce.Enabled = false;
            else 
                btn_reduce.Enabled=true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cb_product.SelectedItem;
            string maMon = selectedRow.Row[0].ToString();
            DataRow row = dtDetailOrder.NewRow();
            row["stt"] = sttDetailOrder;
            row["Mã món"] = maMon;
            row["Tên món ăn"] = cb_product.Text;
            row["Đơn giá"] = menu.getPrice_Id(maMon);
            row["Số lượng"] = tb_quantity.Text;
            row["Thành tiền"] = (int)row["Đơn giá"] * (int)row["Số lượng"]; ;
            dtDetailOrder.Rows.Add(row);
            sttDetailOrder += 1;

            global.addDataGridView(dtDetailOrder, dg_infoOrder);
            lb_totalMoney.Text = global.FormatPrice(caculateTotalMoney());
        }
        private int caculateTotalMoney()
        {
            int tongThanhTien = 0;

            foreach (DataRow row in dtDetailOrder.Rows)
            {
                tongThanhTien += (int)row["Thành tiền"];
            }
            return tongThanhTien;
        }
    }
}
