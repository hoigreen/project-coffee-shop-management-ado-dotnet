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
    public partial class UC_ADMIN_WORKTIME : UserControl
    {
        public UC_ADMIN_WORKTIME()
        {
            InitializeComponent();
        }
        private string MaCa, TenCa, ThoiGian, functionSave;
        private int Luong;

        private DataTable dtCaLam = new DataTable();
        private XL_WORK_TIME work_time = new XL_WORK_TIME();
        private Global global = new Global();

        private void UC_QuanLyCaLam_Load(object sender, EventArgs e)
        {
            disableButton();
            isEnableTextBox(false);
            resetDataTable();
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

                textBoxId.Text = maCa;
                textBoxName.Text = tenCa;
                textBoxTime.Text = thoiGian;
                textBoxSalary.Text = luong;

                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btn_save.Enabled = false;
                btn_cancelSave.Enabled = false;
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
                        addWorkTime();
                        break;
                    case "update":
                        updateWorkTime();
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
                btnCreate.Enabled = true;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
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
            string id = work_time.getIdWorkTimeLastRow();
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
                if (work_time.DeleteWorkTime(textBoxId.Text))
                {
                    textBoxId.Text = "";
                    resetDataTable();
                    global.notify("Xóa ca làm thành công");
                }
                else
                    global.notify("Xóa ca làm không thành công");
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

        private void updateWorkTime()
        {
            getData();
            if (work_time.UpdateWorkTime(MaCa, TenCa, ThoiGian, Luong))
            {
                resetDataTable();
                global.notify("Cập nhật ca làm thành công");
            }
            else
                global.notify("Cập nhật ca làm không thành công");
        }

        private void addWorkTime()
        {
            getData();
            if (work_time.AddWorkTime(MaCa, TenCa, ThoiGian, Luong))
            {
                resetDataTable();
                global.notify("Thêm ca làm thành công");
            }
            else
                global.notify("Thêm ca làm không thành công");
        }
        
        private void clearData()
        {
            textBoxName.Text = "";
            textBoxTime.Text = "";
            textBoxSalary.Text = "";
        }

        private void resetDataTable()
        {
            clearData();
            dtCaLam = work_time.getListWorkTime();
            global.addDataGridView(dtCaLam, dg_calam);

        }

        public void isEnableTextBox(bool isEnable)
        {
            textBoxId.Enabled = false;
            textBoxName.Enabled = isEnable;
            textBoxTime.Enabled = isEnable;
            textBoxSalary.Enabled = isEnable;
        }

        private void getData()
        {
            MaCa = textBoxId.Text;
            TenCa = textBoxName.Text;
            ThoiGian = textBoxTime.Text;
            Luong = int.Parse(textBoxSalary.Text);
        }

        private void disableButton()
        {
            btn_save.Enabled = false;
            btn_cancelSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnClear.Enabled = false;
        }

        private bool isEmpty()
        {
            bool isEmpty = true;
            if (textBoxName.Text == "" || textBoxSalary.Text == "" || textBoxTime.Text == "")
                isEmpty = true;
            else
                isEmpty = false;
            return isEmpty;
        }
    }
}
