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

        
        private void UC_QuanLyMenu_Load(object sender, EventArgs e)
        {
            resetDataTable();
            dg_menu.SelectionChanged += DgMenu_SelectionChanged;
            setDropCombox_Category(cb_loc_danhmuc);
            setDropCombox_Category(cb_danhmuc);
        }
        
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text != "")
            {
                if (menu.ExistsMenu(tb_ma.Text))
                {
                    var result = MessageBox.Show("Bạn chắc chắn muốn xóa món ăn?", "Thông báo?",
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes) 
                    { 
                        if (menu.DeleteMenu(tb_ma.Text))
                        {
                            resetDataTable();
                            global.notify("Xóa món ăn thành công");
                        }
                        else
                            global.notify("Xóa món ăn không thành công");
                    }
                }
                else
                    global.notify("Mã món ăn không tồn tại");
            }
            else
                global.notify("Vui lòng nhập mã món ăn");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text != "")
            {
                if (menu.ExistsMenu(tb_ma.Text))
                {
                    getData();
                    if (menu.UpdateMenu(MaMon, Ten, Gia, DanhMuc))
                    {
                        resetDataTable();
                        global.notify("Cập nhật món ăn thành công");
                    }
                    else
                        global.notify("Cập nhật món ăn không thành công");
                }
                else
                    global.notify("Mã món ăn không tồn tại");
            }
            else
                global.notify("Vui lòng nhập mã món ăn");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text != "" && tb_ten.Text != "" && tb_gia.Text != "" && cb_danhmuc.Text != "")
            {
                if (menu.ExistsMenu(tb_ma.Text))
                    global.notify("Mã món ăn đã tồn tại");
                else
                {
                    getData();
                    if (menu.AddMenu(MaMon, Ten, Gia, DanhMuc))
                    {
                        resetDataTable();
                        global.notify("Thêm món ăn thành công");
                    }
                    else
                        global.notify("Thêm món ăn không thành công");
                }
            }
            else
                global.notify("Nhập đầy đủ các trường dữ liệu");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearData();
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
            }
        }

        private void cb_loc_danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cb_loc_danhmuc.SelectedItem;
            int realValue = Convert.ToInt32(selectedRow.Row[0]);
            if(realValue == 0)
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
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_gia.Text = "";
            cb_danhmuc.Text = "";
        }
        
        private void resetDataTable()
        {
            clearData();
            dtMenu = menu.getListMenuAll();
            global.addDataGridView(dtMenu,dg_menu);
        }
    }
}
