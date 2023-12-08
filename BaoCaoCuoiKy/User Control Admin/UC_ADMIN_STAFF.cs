using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoCuoiKy.User_Control
{
    public partial class UC_ADMIN_STAFF : UserControl
    {
        public UC_ADMIN_STAFF()
        {
            InitializeComponent();
        }
        private string MaNV, TenNV, DienThoai, ChucVu, DiaChi, GioiTinh;
        private DateTime NgaySinh, NgayVaoLam;

        private DataTable dtNhanVien = new DataTable();
        private DataTable dtNgayCong = new DataTable();
        private XL_STAFF staff = new XL_STAFF();
        private XL_WORK_DAY ngaycong = new XL_WORK_DAY();
        private Global global = new Global();
        private string functionSave;

        private void UC_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            cb_gioitinh.Items.Add("Nam");
            cb_gioitinh.Items.Add("Nữ");

            dg_nhanvien.SelectionChanged += DgNhanVien_SelectionChanged;

            btn_save.Enabled = false;
            btn_cancelSave.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_clear.Enabled = false;

            isEnableTextBox(false);
            resetDataTable();
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

                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_save.Enabled = false;
                btn_cancelSave.Enabled = false;

                dtNgayCong = ngaycong.getListWorkDay_Staff(maNV);
                global.addDataGridView(dtNgayCong, dg_ngaycong);
                dg_ngaycong.Columns["col_ngayLam"].DefaultCellStyle.Format = "dd/MM/yyyy";
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            clearData();
            string id = staff.getIdStaffLastRow();
            tb_ma.Text = global.autoIncrementId(id);
            isEnableTextBox(true);
            btn_save.Enabled = true;
            btn_cancelSave.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
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
                        addStaff();
                        break;
                    case "update":
                        updateStaff();
                        break;
                    default:
                        break;
                }
            }
            isEnableTextBox(false);
            btn_save.Enabled = false;
            btn_cancelSave.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
            btn_clear.Enabled = false;
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên?", "Thông báo",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (staff.DeleteStaff(tb_ma.Text))
                {
                    tb_ma.Text = "";
                    resetDataTable();
                    global.notify("Xóa nhân viên thành công");
                }
                else
                    global.notify("Xóa nhân viên không thành công");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            isEnableTextBox(true);
            btn_save.Enabled = true;
            btn_cancelSave.Enabled = true;
            btn_xoa.Enabled = false;
            btn_them.Enabled = false;
            btn_clear.Enabled = true;
            functionSave = "update";
        }
        private void updateStaff()
        {
            getData();
            if (staff.UpdateStaff(MaNV, TenNV, DienThoai, GioiTinh, ChucVu, DiaChi, NgaySinh, NgayVaoLam))
            {
                resetDataTable();
                global.notify("Cập nhật thông tin nhân viên thành công");
            }
            else
                global.notify("Cập nhật thông tin nhân viên không thành công");
        }
        private void addStaff()
        {
            getData();
            if (staff.AddStaff(MaNV, TenNV, DienThoai, GioiTinh, ChucVu, DiaChi, NgaySinh, NgayVaoLam))
            {
                resetDataTable();
                global.notify("Thêm nhân viên thành công");
            }
            else
                global.notify("Thêm nhân viên không thành công");
        }

        private bool isEmpty()
        {
            bool isEmpty = true;
            if (tb_ten.Text == "" || tb_dienthoai.Text == "" || cb_gioitinh.Text == "" || tb_chucvu.Text == "" || tb_diachi.Text == "")
                isEmpty = true;
            else
                isEmpty = false;
            return isEmpty;
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
            tb_ten.Text = "";
            tb_dienthoai.Text = "";
            cb_gioitinh.SelectedIndex = -1;
            dt_ngaysinh.Text = "01/01/2023";
            tb_chucvu.Text = "";
            tb_diachi.Text = "";
            dt_ngayvaolam.Text = "01/01/2023";
        }

        private void resetDataTable()
        {
            clearData();
            dtNhanVien = staff.getListStaff();
            global.addDataGridView(dtNhanVien, dg_nhanvien);
            dg_nhanvien.Columns["col_ns"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dg_nhanvien.Columns["col_nvl"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dt_ngaysinh.Text = "01/01/2023";
            dt_ngayvaolam.Text = "01/01/2023";

        }
        public void isEnableTextBox(bool isEnable)
        {
            tb_ma.Enabled = false;
            tb_ten.Enabled = isEnable;
            tb_dienthoai.Enabled = isEnable;
            cb_gioitinh.Enabled = isEnable;
            dt_ngaysinh.Enabled = isEnable;
            tb_chucvu.Enabled = isEnable;
            tb_diachi.Enabled = isEnable;
            dt_ngayvaolam.Enabled = isEnable;
        }
    }
}
