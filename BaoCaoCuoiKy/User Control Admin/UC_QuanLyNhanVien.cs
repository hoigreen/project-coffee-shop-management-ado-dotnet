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
    public partial class UC_QuanLyNhanVien : UserControl
    {
        public UC_QuanLyNhanVien()
        {
            InitializeComponent();
        }
        private string MaNV, TenNV, DienThoai, ChucVu, DiaChi, GioiTinh;
        private DateTime NgaySinh, NgayVaoLam;

        private DataTable dtNhanVien = new DataTable();
        private DataTable dtNgayCong = new DataTable();
        private XL_NHANVIEN nhanvien = new XL_NHANVIEN();
        private XL_NGAYCONG ngaycong = new XL_NGAYCONG();
        private Global global = new Global();

        private void UC_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            resetDataTable();
            dg_nhanvien.SelectionChanged += DgNhanVien_SelectionChanged;
        }

        private void DgNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_nhanvien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dg_nhanvien.SelectedRows[0];
                string maNV = selectedRow.Cells["col_ma"].Value.ToString();
                string tenNV = selectedRow.Cells["col_ten"].Value.ToString();
                string dt = selectedRow.Cells["col_dt"].Value.ToString();
                string gt = selectedRow.Cells["col_gt"].Value.ToString();
                string ngaySinh = selectedRow.Cells["col_ns"].Value.ToString();
                string chucVu = selectedRow.Cells["col_cv"].Value.ToString();
                string diaChi = selectedRow.Cells["col_dc"].Value.ToString();
                string ngayVaoLam = selectedRow.Cells["col_nvl"].Value.ToString();

                tb_ma.Text = maNV;
                tb_ten.Text = tenNV;
                tb_dienthoai.Text = dt;
                cb_gioitinh.Text = gt;
                dt_ngaysinh.Text = ngaySinh;
                tb_chucvu.Text = chucVu;
                tb_diachi.Text = diaChi;
                dt_ngayvaolam.Text = ngayVaoLam;

                dtNgayCong = ngaycong.getDSNgayCong_NhanVien(maNV);
                global.addDataGridView(dtNgayCong, dg_ngaycong);
                dg_ngaycong.Columns["col_ngayLam"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                if (nhanvien.ExistsNhanVien(tb_ma.Text))
                    global.notify("Mã nhân viên đã tồn tại");
                else
                {
                    getData();
                    if(nhanvien.AddNhanVien(MaNV, TenNV, DienThoai, GioiTinh, ChucVu, DiaChi, NgaySinh, NgayVaoLam))
                    {
                        resetDataTable();
                        global.notify("Thêm nhân viên thành công");
                    }
                    else
                        global.notify("Thêm nhân viên không thành công");
                }
            }
            else
                global.notify("Nhập đầy đủ các trường dữ liệu");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text != "")
            {
                if (nhanvien.ExistsNhanVien(tb_ma.Text))
                {
                    var result = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên?","Thông báo",
                        MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        if (nhanvien.DeleteNhanVien(tb_ma.Text))
                        {
                            resetDataTable();
                            global.notify("Xóa nhân viên thành công");
                        }
                        else
                            global.notify("Xóa nhân viên không thành công");
                    }    
                }
                else
                    global.notify("Mã nhân viên không tồn tại");
            }
            else
                global.notify("Vui lòng nhập mã nhân viên");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text != "")
            {
                if (nhanvien.ExistsNhanVien(tb_ma.Text))
                {
                    getData();
                    if (nhanvien.UpdateNhanVien(MaNV, TenNV, DienThoai, GioiTinh, ChucVu, DiaChi, NgaySinh, NgayVaoLam))
                    {
                        resetDataTable();
                        global.notify("Cập nhật thông tin nhân viên thành công");
                    }
                    else
                        global.notify("Cập nhật thông tin nhân viên không thành công");
                }
                else
                    global.notify("Mã nhân viên không tồn tại");
            }
            else
                global.notify("Vui lòng nhập mã nhân viên");
        }

        private bool checkEmpty()
        {
            if (tb_ma.Text == "" && tb_ten.Text == "" && tb_dienthoai.Text == "" && cb_gioitinh.Text == "" && tb_chucvu.Text == "" && tb_diachi.Text == "")
                return true;
            else
                return false; 
                    ;
        }

        private void getData()
        {
            MaNV = tb_ma.Text;
            TenNV = tb_ten.Text;
            DienThoai = tb_dienthoai.Text;
            DiaChi = tb_diachi.Text;
            ChucVu = tb_chucvu.Text;
            GioiTinh = cb_gioitinh.Text;
            NgaySinh = dt_ngaysinh.Value;
            NgayVaoLam = dt_ngayvaolam.Value;
        }

        private void clearData()
        {
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_dienthoai.Text = "";
            cb_gioitinh.Text = "";
            dt_ngaysinh.Text = "01/01/2023";
            tb_chucvu.Text = "";
            tb_diachi.Text = "";
            dt_ngayvaolam.Text = "01/01/2023";
        }

        private void resetDataTable()
        {
            clearData();
            dtNhanVien = nhanvien.getDSNhanVien();
            global.addDataGridView(dtNhanVien, dg_nhanvien);
            dg_nhanvien.Columns["col_ns"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dg_nhanvien.Columns["col_nvl"].DefaultCellStyle.Format = "dd/MM/yyyy";
            cb_gioitinh.Items.Add("Nam");
            cb_gioitinh.Items.Add("Nữ");
            dt_ngaysinh.Text = "01/01/2023";
            dt_ngayvaolam.Text = "01/01/2023";

        }
    }
}
