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
        private string MaCa, TenCa, ThoiGian;
        private int Luong;

        private DataTable dtCaLam = new DataTable();
        private XL_WORK_TIME work_time = new XL_WORK_TIME();
        private Global global = new Global();
        private string functionSave;

        private void UC_QuanLyCaLam_Load(object sender, EventArgs e)
        {
            dg_calam.SelectionChanged += DgCaLam_SelectionChanged;
            btn_save.Enabled = false;
            btn_cancelSave.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_clear.Enabled = false;
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

                tb_ma.Text = maCa;
                tb_ten.Text = tenCa;
                tb_thoigian.Text = thoiGian;
                tb_luong.Text = luong;

                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;
                btn_save.Enabled = false;
                btn_cancelSave.Enabled = false;
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
            string id = work_time.getIdWorkTimeLastRow();
            tb_ma.Text = global.autoIncrementId(id);
            isEnableTextBox(true);
            btn_save.Enabled = true;
            btn_cancelSave.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_clear.Enabled = true;
            functionSave = "insert";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên?", "Thông báo",
               MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (work_time.DeleteWorkTime(tb_ma.Text))
                {
                    tb_ma.Text = "";
                    resetDataTable();
                    global.notify("Xóa ca làm thành công");
                }
                else
                    global.notify("Xóa ca làm không thành công");
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
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_sua.Enabled = true;
                btn_clear.Enabled = false;
                tb_ma.Text = "";
                functionSave = "";
                isEnableTextBox(false);
                clearData();
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
            tb_ten.Text = "";
            tb_thoigian.Text = "";
            tb_luong.Text = "";
        }

        private void resetDataTable()
        {
            clearData();
            dtCaLam = work_time.getListWorkTime();
            global.addDataGridView(dtCaLam, dg_calam);

        }

        public void isEnableTextBox(bool isEnable)
        {
            tb_ma.Enabled = false;
            tb_ten.Enabled = isEnable;
            tb_thoigian.Enabled = isEnable;
            tb_luong.Enabled = isEnable;
        }

        private void getData()
        {
            MaCa = tb_ma.Text;
            TenCa = tb_ten.Text;
            ThoiGian = tb_thoigian.Text;
            Luong = int.Parse(tb_luong.Text);
        }

        private bool isEmpty()
        {
            bool isEmpty = true;
            if (tb_ten.Text == "" || tb_luong.Text == "" || tb_thoigian.Text == "")
                isEmpty = true;
            else
                isEmpty = false;
            return isEmpty;
        }
    }
}
