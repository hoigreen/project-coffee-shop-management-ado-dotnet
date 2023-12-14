using BaoCaoCuoiKy;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        private int sttDetailOrder = 1, SoLuong, DonGia, TongTien, MaBan;
        private string MaHD, MaNV, MaMon, Ngay;

        private Bitmap memoryimg;
        public UC_STAFF_CREATEORDER()
        {
            InitializeComponent();
        }

        private void UC_STAFF_CREATEORDER_Load(object sender, EventArgs e)
        {
            showInfoPayment(false);
            CreDataTbale_DeTailOrder();
            setAutoIdOrder();

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
            if (!IsDataTableEmpty(dtDetailOrder))
            {
                handleDataOrder();
                handleBeforeCreateOrder();
            }
            else
            {
                global.notify("Bạn chưa chọn món ăn nào");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            resetFromCreate();
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
            lb_totalMoney.Text = global.FormatPrice(calculateTotalMoney());
        }

        private void btn_printOrder_Click(object sender, EventArgs e)
        {
            Print(panel_infoPayment);
            global.notify("Xuất hóa đơn thành công");
            panel_createOrder.Enabled = true;
            dtDetailOrder.Clear();
            showInfoPayment(false);
            setAutoIdOrder();
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

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();

            memoryimg = new Bitmap(pnl.Width, pnl.Height);

            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));

            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrinterSettings ps = new PrinterSettings();
            int widthInInches = ps.DefaultPageSettings.PaperSize.Width ;
            int heightInInches = ps.DefaultPageSettings.PaperSize.Height ;

            int memoryimgWidth = memoryimg.Width;
            int memoryimgHeight = memoryimg.Height;

            int location_X = (widthInInches - memoryimgWidth) / 2;
            int location_y = (heightInInches - memoryimgHeight) / 2;

            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, location_X, location_y);
        }

        private void setListCombobox(ComboBox combobox, DataTable dataTable)
        {
            combobox.DataSource = dataTable;
            combobox.DisplayMember = dataTable.Columns[1].ColumnName;
            combobox.ValueMember = dataTable.Columns[0].ColumnName;
        }

        private void setAutoIdOrder()
        {
            string id = order.getIdOrderLastRow();
            tb_idOrder.Text = global.autoIncrementId(id);
        }

        private void handleBeforeCreateOrder()
        {
            if (MaBan == 0)
                HandleNoOpenTable();
            else
            {
                if (table.getStatusTable(MaBan))
                {
                    DialogResult result = MessageBox.Show("Bàn đã có người ngồi! Bạn có muốn ngồi bàn này không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        HandleCombineTable();
                    else
                        global.notify("Vui lòng chọn lại bàn");
                }
                else
                    HandleOpenTable();
            }
            showInfoPayment(true);
        }

        private void handleDataOrder()
        {
            DataRowView selectedRowCbStaff = (DataRowView)cb_staffPay.SelectedItem;
            DataRowView selectedRowCbTable = (DataRowView)cb_table.SelectedItem;
            MaHD = tb_idOrder.Text;
            MaNV = selectedRowCbStaff.Row[0].ToString();
            Ngay = dt_datePay.Value.ToString("dd/MM/yyyy HH:mm:ss");
            TongTien = calculateTotalMoney();
            MaBan = (int)selectedRowCbTable.Row[0];
        }

        private void HandleNoOpenTable()
        {
            createOrder();
            resetFromCreate();
            showInfoPayment(true);
            setInfoPayment();
        }

        private void HandleCombineTable()
        {
            createOrder();
            if (table.combineTable(MaBan, MaHD))
            {
                global.notify("Gộp bàn thành công");
                showInfoPayment(true);
                resetFromCreate();
                setInfoPayment();
            }
        }

        private void HandleOpenTable()
        {
            createOrder();
            if (table.setStatusTable(MaBan, true, MaHD))
            {
                global.notify("Mở bàn thành công");
                showInfoPayment(true);
                resetFromCreate();
                setInfoPayment();
            }
        }

        private void CreDataTbale_DeTailOrder()
        {
            dtDetailOrder.Columns.Add("stt", typeof(int));
            dtDetailOrder.Columns.Add("Mã món", typeof(string));
            dtDetailOrder.Columns.Add("Tên món ăn", typeof(string));
            dtDetailOrder.Columns.Add("Đơn giá", typeof(int));
            dtDetailOrder.Columns.Add("Số lượng", typeof(int));
            dtDetailOrder.Columns.Add("Thành tiền", typeof(int));
        }

        public void createOrder()
        {
            order.addOrder(MaHD, MaNV, Ngay, TongTien);
            foreach (DataRow row in dtDetailOrder.Rows)
            {
                 MaMon = row["Mã món"].ToString();
                 DonGia = Convert.ToInt32(row["Đơn giá"]);
                 SoLuong = Convert.ToInt32(row["Số lượng"]);
                detailOrder.addDetailOrder(MaHD, MaMon, SoLuong, DonGia);
            }
            global.notify("Tạo hóa đơn thành công");
        }

        public void setInfoPayment()
        {
            lb_idOrder.Text = "#" + MaHD;
            lb_nameStaff.Text = staff.getNameStaff(MaNV);
            lb_table.Text = MaBan == 0 ? "Mang đi" : MaBan.ToString();
            lb_datePay.Text = Ngay;
            lb_totalPay.Text = global.FormatPrice(TongTien);
            global.addDataGridView(dtDetailOrder, dg_infoPayment);
            panel_createOrder.Enabled = false;
        }

        public void resetFromCreate()
        {
            cb_table.SelectedIndex = cb_table.Items.Count - 1;
            cb_staffPay.SelectedIndex = cb_staffPay.Items.Count - 1;
            cb_category.SelectedIndex = cb_category.Items.Count - 1;
            tb_quantity.Text = "1";
            dg_infoOrder.Rows.Clear();
            lb_totalMoney.Text = "0đ";
            sttDetailOrder = 1;
            dg_infoOrder.Rows.Clear();
            dtDetailOrder.Rows.Clear();
        }

        public void showInfoPayment(bool isShow)
        {
            panel_infoPayment.Visible = isShow;
            btn_printOrder.Visible = isShow;
        }

        private void checkButtonQuantity()
        {
            int quantity = Convert.ToInt32(tb_quantity.Text);
            if(quantity == 1)
                btn_reduce.Enabled = false;
            else 
                btn_reduce.Enabled=true;
        }

        private int calculateTotalMoney()
        {
            int tongThanhTien = 0;

            foreach (DataRow row in dtDetailOrder.Rows)
            {
                tongThanhTien += (int)row["Thành tiền"];
            }
            return tongThanhTien;
        }

        private bool IsDataTableEmpty(DataTable dataTable)
        {
            return dataTable == null || dataTable.Rows.Count == 0;
        }
    }
}
