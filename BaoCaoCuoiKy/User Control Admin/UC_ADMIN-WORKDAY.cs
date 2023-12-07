using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            dtCaLam = calam.getListIdWorkTime();
            dtCaLam.Rows.Add("--");
            cb_ca.DataSource = dtCaLam;
            cb_ca.DisplayMember = dtCaLam.Columns[0].ColumnName;
            cb_ca.ValueMember = dtCaLam.Columns[0].ColumnName;
            cb_thang.Items.Add("--");
            for (int i = 1; i <= 12; i++)
            {
                cb_thang.Items.Add(i);
            }
            cb_thang.SelectedIndex = 0;
            cb_ca.SelectedIndex = cb_ca.Items.Count - 1;
            resetDataTable();
            dg_ngayCong.Columns["col_ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dg_ngayCong.SelectionChanged += DgNgayCong_SelectionChanged;
            cb_ca.SelectedIndexChanged += cb_ca_SelectedIndexChanged;
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

                tb_maCa.Text = maCa;
                tb_tenCa.Text = tenCa;
                tb_maNV.Text = maNV;
                tb_tenNV.Text = tenNV;
                dt_ngayLam.Text = ngayLam;
            }
        }
        private void cb_ca_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetDataTable();
        }

        public void resetDataTable()
        {
            clearData();
            if(cb_thang.Text == "--" && cb_ca.Text == "--")
                dtNgayCong = work_day.getListWorkDay();
            else
               dtNgayCong = work_day.getListWorkDay_Month_Time(cb_thang.Text, cb_ca.Text);
            global.addDataGridView(dtNgayCong, dg_ngayCong);
        }

        private void clearData()
        {
            tb_maCa.Text = "";
            tb_tenCa.Text = ""; 
            tb_maNV.Text = "";
            tb_tenNV.Text = "";
            dt_ngayLam.Text = "01/01/2023";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void cb_thang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            resetDataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb_ca.Text = "--";
            cb_thang.Text = "--";
        }
    }
}
