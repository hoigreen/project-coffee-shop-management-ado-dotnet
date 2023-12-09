using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CoffeeShopManagement;
using System.Xml.Linq;
using ComboBox = System.Windows.Forms.ComboBox;

namespace BaoCaoCuoiKy.User_Control
{
    public partial class UC_ADMIN_MENU : UserControl
    {
        public UC_ADMIN_MENU()
        {
            InitializeComponent();
        }
        private string MaMon, Ten;
        private int DanhMuc;
        private int Gia;

        private DataTable dtMenu = new DataTable();
        private XL_MENU menu = new XL_MENU();
        private XL_CATEGORY category = new XL_CATEGORY();
        private Global global = new Global();
        private string functionSave;

        
        private void UC_QuanLyMenu_Load(object sender, EventArgs e)
        {
            dg_menu.SelectionChanged += DgMenu_SelectionChanged;
            setDropCombox_Category(cb_loc_danhmuc);
            setDropCombox_Category(cb_danhmuc);

            btn_save.Enabled = false;
            btn_cancelSave.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_clear.Enabled = false;

            isEnableTextBox(false);
            resetDataTable();
        }

        private void DgMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_menu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dg_menu.SelectedRows[0];
                string maMon = selectedRow.Cells["col_ma"].Value.ToString();
                string tenMon = selectedRow.Cells["col_ten"].Value.ToString();
                string donGia = selectedRow.Cells["col_gia"].Value.ToString();
                string danhMuc = selectedRow.Cells["col_loai"].Value.ToString();
                tb_ma.Text = maMon;
                tb_ten.Text = tenMon;
                tb_gia.Text = donGia;
                cb_danhmuc.Text = danhMuc;

                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_save.Enabled = false;
                btn_cancelSave.Enabled = false;
            }
        }

        private void cb_loc_danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cb_loc_danhmuc.SelectedItem;
            int realValue = Convert.ToInt32(selectedRow.Row[0]);
            if (realValue == 0)
                dtMenu = menu.getListMenuAll();
            else
                dtMenu = menu.getListMenu_Category(realValue);
            global.addDataGridView(dtMenu, dg_menu);
        }

        private void setDropCombox_Category(ComboBox combobox)
        {
            DataTable dtCategory = new DataTable();
            dtCategory = category.getListNameCategory();
            DataRow allRow = dtCategory.NewRow();
            allRow["id"] = 0;
            allRow["ten"] = "--";
            dtCategory.Rows.Add(allRow);

            combobox.DataSource = dtCategory;
            combobox.DisplayMember = dtCategory.Columns[1].ColumnName;
            combobox.ValueMember = dtCategory.Columns[0].ColumnName;
            combobox.SelectedIndex = cb_loc_danhmuc.Items.Count - 1;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm?", "Thông báo",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (menu.DeleteMenu(tb_ma.Text))
                {
                    tb_ma.Text = "";
                    resetDataTable();
                    global.notify("Xóa sản phẩm thành công");
                }
                else
                    global.notify("Xóa sản phẩm không thành công");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            isEnableTextBox(true);
            btn_save.Enabled = true;
            btn_cancelSave.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_clear.Enabled = true;
            functionSave = "update";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            clearData();
            string id = menu.getIdMenuLastRow();
            tb_ma.Text = global.autoIncrementId(id);
            isEnableTextBox(true);
            btn_save.Enabled = true;
            btn_cancelSave.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_clear.Enabled = true;
            functionSave = "insert";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isEmpty())
                global.notify("Vui lòng nhập đây đủ các trường");
            else
            {
                switch (functionSave)
                {
                    case "insert":
                        addMenu();
                        break;
                    case "update":
                        updateMenu();
                        break;
                    default:
                        break;
                }
            }
            isEnableTextBox(false);
            btn_save.Enabled = false;
            btn_cancelSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = true;
            btnClear.Enabled = false;
            tb_ma.Text = "";
            functionSave = "";
        }

        private void btn_cancelSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn không muốn lưu?", "Thông báo",
                        MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                btn_cancelSave.Enabled = false;
                btn_save.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnCreate.Enabled = true;
                btnClear.Enabled = false;
                tb_ma.Text = "";
                functionSave = "";
                isEnableTextBox(false);
                clearData();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (functionSave == "insert" || functionSave == "update")
            {
                var result = MessageBox.Show("Thông tin chưa được lưu!\nBạn chắc chắn muốn xóa chứ?", "Thông báo",
                        MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    btn_cancelSave.Enabled = false;
                    btn_save.Enabled = false;
                    btn_sua.Enabled = false;
                    btn_xoa.Enabled = false;
                    btn_them.Enabled = true;
                    btn_clear.Enabled = false;
                    tb_ma.Text = "";
                    functionSave = "";
                    isEnableTextBox(false);
                    clearData();
                }
            }
        }

        public void addMenu()
        {
            getData();
            if (menu.AddMenu(MaMon, Ten, Gia, DanhMuc))
            {
                resetDataTable();
                global.notify("Thêm sản phẩm thành công");
            }
            else
                global.notify("Thêm sản phẩm không thành công");
        }

        public void updateMenu()
        {
            getData();
            if (menu.UpdateMenu(MaMon, Ten, Gia, DanhMuc))
            {
                resetDataTable();
                global.notify("Cập nhật sản phẩm thành công");
            }
            else
                global.notify("Cập nhật sản phẩm không thành công");
        }

        private void getData()
        {
            DataRowView selectedRow = (DataRowView)cb_danhmuc.SelectedItem;
            int idCate = Convert.ToInt32(selectedRow.Row[0]);
            MaMon = tb_ma.Text;
            Ten = tb_ten.Text;
            Gia = int.Parse(tb_gia.Text);
            DanhMuc = idCate;
        }

        private void clearData()
        {
            tb_ten.Text = "";
            tb_gia.Text = "";
            cb_danhmuc.SelectedIndex = cb_loc_danhmuc.Items.Count - 1;
        }

        private bool isEmpty()
        {
            bool isEmpty = true;
            if (tb_ten.Text == "" || tb_gia.Text == "" || cb_danhmuc.Text == "")
                isEmpty = true;
            else
                isEmpty = false;
            return isEmpty;
        }

        public void isEnableTextBox(bool isEnable)
        {
            tb_ma.Enabled = false;
            tb_ten.Enabled = isEnable;
            tb_gia.Enabled = isEnable;
            cb_danhmuc.Enabled = isEnable;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_gia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEnableTextBox(true);
            btn_save.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btn_clear.Enabled = true;
            functionSave = "update";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            clearData();
            string id = menu.getIdMenuLastRow();
            tb_ma.Text = global.autoIncrementId(id);
            isEnableTextBox(true);
            btn_save.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btn_clear.Enabled = true;
            functionSave = "insert";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (functionSave == "insert" || functionSave == "update")
            {
                var result = MessageBox.Show("Thông tin chưa được lưu!\nBạn chắc chắn muốn xóa chứ?", "Thông báo",
                        MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    btn_cancelSave.Enabled = false;
                    btn_save.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCreate.Enabled = true;
                    btnClear.Enabled = false;
                    tb_ma.Text = "";
                    functionSave = "";
                    isEnableTextBox(false);
                    clearData();
                }
            }
        }

        private void resetDataTable()
        {
            clearData();
            dtMenu = menu.getListMenuAll();
            global.addDataGridView(dtMenu,dg_menu);
        }
    }
}
