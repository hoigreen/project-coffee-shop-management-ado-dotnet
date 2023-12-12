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
        private string MaNV, TenNV, DienThoai, ChucVu, DiaChi, GioiTinh, functionSave;
        private DateTime NgaySinh, NgayVaoLam;

        private XL_STAFF staff = new XL_STAFF();
        private XL_WORK_DAY ngaycong = new XL_WORK_DAY();
        private DataTable dtNhanVien = new DataTable();
        private DataTable dtNgayCong = new DataTable();
        private Global global = new Global();

        private void UC_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            disableButton();
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

                textBoxId.Text = maNV;
                textBoxName.Text = tenNV;
                textboxPhone.Text = dt;
                comboBoxGender.Text = gt;
                dateTimePickerDob.Text = ngaySinh;
                textBoxPosition.Text = chucVu;
                textBoxAddress.Text = diaChi;
                dateTimePickerStartDate.Text = ngayVaoLam;

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btn_save.Enabled = false;
                btn_cancelSave.Enabled = false;

                dtNgayCong = ngaycong.getListWorkDay_Staff(maNV);
                global.addDataGridView(dtNgayCong, dg_ngaycong);
                dg_ngaycong.Columns["col_ngayLam"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isEmptyInfoStaff())
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
            btnEdit.Enabled = false;
            btnCreate.Enabled = true;
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            clearData();
            string id = staff.getIdStaffLastRow();
            textBoxId.Text = global.autoIncrementId(id);
            isEnableTextBox(true);
            btn_save.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnClear.Enabled = true;
            functionSave = "insert";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên?", "Thông báo",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (staff.DeleteStaff(textBoxId.Text))
                {
                    textBoxId.Text = "";
                    resetDataTable();
                    global.notify("Xóa nhân viên thành công");
                }
                else
                    global.notify("Xóa nhân viên không thành công");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEnableTextBox(true);
            btn_save.Enabled = true;
            btn_cancelSave.Enabled = true;
            btnDelete.Enabled = false;
            btnCreate.Enabled = false;
            btnClear.Enabled = true;
            functionSave = "update";
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

        private bool isEmptyInfoStaff()
        {
            bool isEmpty = true;
            if (textBoxName.Text == "" || textboxPhone.Text == "" || comboBoxGender.Text == "" || textBoxPosition.Text == "" || textBoxAddress.Text == "")
                isEmpty = true;
            else
                isEmpty = false;
            return isEmpty;
        }

        private void getData()
        {
            MaNV = textBoxId.Text;
            TenNV = textBoxName.Text;
            DienThoai = textboxPhone.Text;
            DiaChi = textBoxAddress.Text;
            ChucVu = textBoxPosition.Text;
            GioiTinh = comboBoxGender.Text;
            NgaySinh = dateTimePickerDob.Value;
            NgayVaoLam = dateTimePickerStartDate.Value;
        }

        private void clearData()
        {
            textBoxName.Text = "";
            textboxPhone.Text = "";
            comboBoxGender.SelectedIndex = -1;
            dateTimePickerDob.Text = "01/01/2023";
            textBoxPosition.Text = "";
            textBoxAddress.Text = "";
            dateTimePickerStartDate.Text = "01/01/2023";
        }

        private void resetDataTable()
        {
            clearData();
            dtNhanVien = staff.getListStaff();
            global.addDataGridView(dtNhanVien, dg_nhanvien);
            dg_nhanvien.Columns["col_ns"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dg_nhanvien.Columns["col_nvl"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dateTimePickerDob.Text = "01/01/2023";
            dateTimePickerStartDate.Text = "01/01/2023";

        }

        private void disableButton()
        {
            btn_save.Enabled = false;
            btn_cancelSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
        }

        public void isEnableTextBox(bool isEnable)
        {
            textBoxId.Enabled = false;
            textBoxName.Enabled = isEnable;
            textboxPhone.Enabled = isEnable;
            comboBoxGender.Enabled = isEnable;
            dateTimePickerDob.Enabled = isEnable;
            textBoxPosition.Enabled = isEnable;
            textBoxAddress.Enabled = isEnable;
            dateTimePickerStartDate.Enabled = isEnable;
        }
    }
}
