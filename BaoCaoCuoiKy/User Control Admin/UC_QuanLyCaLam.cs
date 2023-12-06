using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoCuoiKy.User_Control
{
    public partial class UC_QuanLyCaLam : UserControl
    {
        public UC_QuanLyCaLam()
        {
            InitializeComponent();
        }
        private string MaCa, TenCa, ThoiGian;
        private int Luong;

        private DataTable dtCaLam = new DataTable();
        private XL_CALAM calam = new XL_CALAM();
        private Global global = new Global();

        private void UC_QuanLyCaLam_Load(object sender, EventArgs e)
        {
            resetDataTable();
            dg_calam.SelectionChanged += DgCaLam_SelectionChanged;
        }
        
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                if (calam.ExistsCaLam(tb_ma.Text))
                    global.notify("Mã ca làm đã tồn tại");
                else
                {
                    getData();
                    if (calam.AddCaLam(MaCa, TenCa, ThoiGian,Luong))
                    {
                        resetDataTable();
                        global.notify("Thêm ca làm thành công");
                    }
                    else
                        global.notify("Thêm ca làm không thành công");
                }
            }
            else
                global.notify("Nhập đầy đủ các trường");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text != "")
            {
                if (calam.ExistsCaLam(tb_ma.Text))
                {
                    var result = MessageBox.Show("Bạn chắc chắn muốn xóa ca làm?", "Thông báo",
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (calam.DeleteCaLam(tb_ma.Text))
                        {
                            resetDataTable();
                            global.notify("Xóa ca làm thành công");
                        }
                        else
                            global.notify("Xóa ca làm không thành công");
                    }
                }
                else
                    global.notify("Mã ca làm không tồn tại");
            }
            else
                global.notify("Vui lòng nhập mã ca làm");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text != "")
            {
                if (calam.ExistsCaLam(tb_ma.Text))
                {
                    getData();
                    if (calam.UpdateCaLam(MaCa,TenCa,ThoiGian,Luong))
                    {
                        resetDataTable();
                        global.notify("Cập nhật thông tin ca làm thành công");
                    }
                    else
                        global.notify("Cập nhật thông tin ca làm không thành công");
                }
                else
                    global.notify("Mã ca làm không tồn tại");
            }
            else
                global.notify("Vui lòng nhập mã ca làm");
        }
        
        private void DgCaLam_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_calam.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dg_calam.SelectedRows[0];
                string maCa = selectedRow.Cells["col_ma"].Value.ToString();
                string tenCa = selectedRow.Cells["col_ten"].Value.ToString();
                string thoiGian = selectedRow.Cells["col_thoigian"].Value.ToString();
                string luong = selectedRow.Cells["col_luong"].Value.ToString();

                tb_ma.Text = maCa;
                tb_ten.Text = tenCa;
                tb_thoigian.Text = thoiGian;
                tb_luong.Text = luong;
            }
        }

        private void resetDataTable()
        {
            clearData();
            dtCaLam = calam.getDSCaLam();
            global.addDataGridView(dtCaLam, dg_calam);

        }

        private void clearData()
        {
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_thoigian.Text = "";
            tb_luong.Text = "";
        }

        private bool checkEmpty()
        {
            if (tb_ma.Text == "" && tb_ten.Text == "" && tb_thoigian.Text == "" && tb_luong.Text == "")
                return true;
            else
                return false;
            ;
        }

        private void getData()
        {
            MaCa = tb_ma.Text;
            TenCa = tb_ten.Text;
            ThoiGian = tb_thoigian.Text;
            Luong = int.Parse(tb_luong.Text);
        }
    }
}
