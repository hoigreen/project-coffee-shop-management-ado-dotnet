using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BaoCaoCuoiKy.User_Control
{
    public partial class UC_QuanLyNgayCong : UserControl
    {
        public UC_QuanLyNgayCong()
        {
            InitializeComponent();
        }

        private DataTable dtNgayCong = new DataTable();
        private DataTable dtCaLam = new DataTable();
        private XL_WORK_DAY work_day = new XL_WORK_DAY();
        private XL_WORK_TIME calam = new XL_WORK_TIME();
        private Global global = new Global();

        private void UC_QuanLyNgayCong_Load(object sender, EventArgs e)
        {
            setListComboBoxWorkTime();
            setlistComboboxMonth();
            resetDataTable();
            dg_ngayCong.Columns["col_ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void setListComboBoxWorkTime()
        {
            dtCaLam = calam.getListIdWorkTime();
            dtCaLam.Rows.Add("--");
            comboBoxShift.DataSource = dtCaLam;
            comboBoxShift.DisplayMember = dtCaLam.Columns[0].ColumnName;
            comboBoxShift.ValueMember = dtCaLam.Columns[0].ColumnName;
            comboBoxShift.SelectedIndex = comboBoxShift.Items.Count - 1;
        }

        private void setlistComboboxMonth()
        {
            comboBoxMonth.Items.Add("--");
            for (int i = 1; i <= 12; i++)
            {
                comboBoxMonth.Items.Add(i);
            }
            comboBoxMonth.SelectedIndex = 0;
            
        }

        private void DgNgayCong_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_ngayCong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dg_ngayCong.SelectedRows[0];
                string maCa = selectedRow.Cells["col_maCa"].Value.ToString();
                string tenCa = selectedRow.Cells["col_tenCa"].Value.ToString();
                string maNV = selectedRow.Cells["col_maNV"].Value.ToString();
                string tenNV = selectedRow.Cells["col_tenNV"].Value.ToString();
                string ngayLam = selectedRow.Cells["col_ngay"].Value.ToString();

                textBoxShiftId.Text = maCa;
                textBoxShiftName.Text = tenCa;
                textBoxStaffId.Text = maNV;
                textBoxStaffName.Text = tenNV;
                dateTimePickerWorkDate.Text = ngayLam;
            }
        }

        private void comboBoxShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetDataTable();
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetDataTable();
        }

        public void resetDataTable()
        {
            clearData();
            if(comboBoxMonth.Text == "--" && comboBoxShift.Text == "--")
                dtNgayCong = work_day.getListWorkDay();
            else
               dtNgayCong = work_day.getListWorkDay_Month_Time(comboBoxMonth.Text, comboBoxShift.Text);
            global.addDataGridView(dtNgayCong, dg_ngayCong);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            comboBoxShift.Text = "--";
            comboBoxMonth.Text = "--";
        }

        private void clearData()
        {
            textBoxShiftId.Text = "";
            textBoxShiftName.Text = ""; 
            textBoxStaffId.Text = "";
            textBoxStaffName.Text = "";
            dateTimePickerWorkDate.Text = "01/01/2023";
        }
    }
}
