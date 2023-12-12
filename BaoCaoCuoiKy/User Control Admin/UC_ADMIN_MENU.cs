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
        private string MaMon, Ten, functionSave;
        private int DanhMuc, Gia;

        private XL_MENU menu = new XL_MENU();
        private XL_CATEGORY category = new XL_CATEGORY();
        private DataTable dtMenu = new DataTable();
        private Global global = new Global();
        
        private void UC_QuanLyMenu_Load(object sender, EventArgs e)
        {
            setDropCombox_Category(comboBoxSortByType);
            setDropCombox_Category(comboBoxType);

            disableButton();
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
                textBoxId.Text = maMon;
                textBoxName.Text = tenMon;
                textBoxPrice.Text = donGia;
                comboBoxType.Text = danhMuc;

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btn_save.Enabled = false;
                btn_cancelSave.Enabled = false;
            }
        }

        private void comboBoxSortByType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)comboBoxSortByType.SelectedItem;
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
            allRow["ten"] = "Tất cả";
            dtCategory.Rows.Add(allRow);

            combobox.DataSource = dtCategory;
            combobox.DisplayMember = dtCategory.Columns[1].ColumnName;
            combobox.ValueMember = dtCategory.Columns[0].ColumnName;
            combobox.SelectedIndex = comboBoxSortByType.Items.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm?", "Thông báo",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (menu.DeleteMenu(textBoxId.Text))
                {
                    textBoxId.Text = "";
                    resetDataTable();
                    global.notify("Xóa sản phẩm thành công");
                }
                else
                    global.notify("Xóa sản phẩm không thành công");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEnableTextBox(true);
            btn_save.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnEdit.Enabled = true;
            functionSave = "update";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            clearData();
            string id = menu.getIdMenuLastRow();
            textBoxId.Text = global.autoIncrementId(id);
            isEnableTextBox(true);
            btn_save.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = true;
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
                    textBoxId.Text = "";
                    functionSave = "";
                    isEnableTextBox(false);
                    clearData();
                }
            }
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
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            textBoxId.Text = "";
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
                textBoxId.Text = "";
                functionSave = "";
                isEnableTextBox(false);
                clearData();
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
            DataRowView selectedRow = (DataRowView)comboBoxType.SelectedItem;
            int idCate = Convert.ToInt32(selectedRow.Row[0]);
            MaMon = textBoxId.Text;
            Ten = textBoxName.Text;
            Gia = int.Parse(textBoxPrice.Text);
            DanhMuc = idCate;
        }

        private void clearData()
        {
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            comboBoxType.SelectedIndex = comboBoxSortByType.Items.Count - 1;
        }

        private bool isEmpty()
        {
            bool isEmpty = true;
            if (textBoxName.Text == "" || textBoxPrice.Text == "" || comboBoxType.Text == "")
                isEmpty = true;
            else
                isEmpty = false;
            return isEmpty;
        }

        private void isEnableTextBox(bool isEnable)
        {
            textBoxId.Enabled = false;
            textBoxName.Enabled = isEnable;
            textBoxPrice.Enabled = isEnable;
            comboBoxType.Enabled = isEnable;
        }

        private void disableButton()
        {
            btn_save.Enabled = false;
            btn_cancelSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
        }

        private void resetDataTable()
        {
            clearData();
            dtMenu = menu.getListMenuAll();
            global.addDataGridView(dtMenu,dg_menu);
        }
    }
}
