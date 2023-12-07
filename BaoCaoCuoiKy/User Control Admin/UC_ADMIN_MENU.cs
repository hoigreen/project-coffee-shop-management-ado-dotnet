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

namespace BaoCaoCuoiKy.User_Control
{
    public partial class UC_ADMIN_MENU : UserControl
    {
        public UC_ADMIN_MENU()
        {
            InitializeComponent();
        }
        private string MaMon, Ten, Loai;
        private int Gia;

        private DataTable dtMenu = new DataTable();
        private XL_MENU menu = new XL_MENU();
        private Global global = new Global();

        private void UC_QuanLyMenu_Load(object sender, EventArgs e)
        {
            radio_all.Checked = true;
            dg_menu.SelectionChanged += DgMenu_SelectionChanged;
            cb_loai.Items.Add("nước uống");
            cb_loai.Items.Add("đồ ăn");
        }

        private void radio_all_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_all.Checked)
            {
                dtMenu = menu.getListMenuAll();
                global.addDataGridView(dtMenu, dg_menu);
            }
        }

        private void radio_drink_CheckedChanged(object sender, EventArgs e)
        {
            string loai = "nước uống";
            if (radio_drink.Checked)
            {
                dtMenu = menu.getListMenu_Category(loai);
                global.addDataGridView(dtMenu, dg_menu);
            }
        }

        private void radio_food_CheckedChanged(object sender, EventArgs e)
        {
            string loai = "đồ ăn";
            if (radio_food.Checked)
            {
                dtMenu = menu.getListMenu_Category(loai);
                global.addDataGridView(dtMenu, dg_menu);
            }
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
                    if (menu.UpdateMenu(MaMon, Ten, Gia, Loai))
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
            if (tb_ma.Text != "" && tb_ten.Text != "" && tb_gia.Text != "" && cb_loai.Text != "")
            {
                if (menu.ExistsMenu(tb_ma.Text))
                    global.notify("Mã món ăn đã tồn tại");
                else
                {
                    getData();
                    if (menu.AddMenu(MaMon, Ten, Gia, Loai))
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
                string loai = selectedRow.Cells["col_loai"].Value.ToString();
                tb_ma.Text = maMon;
                tb_ten.Text = tenMon;
                tb_gia.Text = donGia;
                cb_loai.Text = loai;
            }
        }

        private void getData()
        {
            MaMon = tb_ma.Text;
            Ten = tb_ten.Text;
            Gia = int.Parse(tb_gia.Text);
            Loai = cb_loai.Text;
        }

        private void clearData()
        {
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_gia.Text = "";
            cb_loai.Text = "";
        }
        
        private void resetDataTable()
        {
            clearData();
            radio_all.Checked = true;
            dtMenu = menu.getListMenuAll();
            global.addDataGridView(dtMenu,dg_menu);
        }
    }
}
