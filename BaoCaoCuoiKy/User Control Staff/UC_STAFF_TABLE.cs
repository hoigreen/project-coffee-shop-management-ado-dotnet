using BaoCaoCuoiKy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;

namespace CoffeeShopManagement.User_Control_Staff
{
    public partial class UC_STAFF_TABLE : UserControl
    {
        private XL_TABLE table = new XL_TABLE();
        private XL_ORDER order = new XL_ORDER();   
        private XL_DETAIL_ORDER detailOrder = new XL_DETAIL_ORDER();
        private DataTable dtDetailOrder = new DataTable();
        private DataTable dtTable = new DataTable();
        private Global global = new Global();
        private int x , y , totalPay, numerOrder = 1, idTable;
        private bool statusTable;
        private string nameTable, idOrder, dateOpenTable;
       

        public UC_STAFF_TABLE()
        {
            InitializeComponent();
        }

        private void UC_STAFF_TABLE_Load(object sender, EventArgs e)
        {
            loadTable();
            setListCombobox(cb_listTable, dtTable);
        }

        private void setListCombobox(ComboBox combobox, DataTable dataTable)
        {
            combobox.DataSource = dataTable;
            combobox.DisplayMember = dataTable.Columns[1].ColumnName;
            combobox.ValueMember = dataTable.Columns[0].ColumnName;
        }

        private void setDataTableDetailOrder(Array arrIdOrder)
        {
            dtDetailOrder.Rows.Clear();
            foreach (string item in arrIdOrder)
            {
                DataTable dataTable = new DataTable();
                dataTable = detailOrder.getListDetailOrder(item);
                dtDetailOrder.Merge(dataTable, false, MissingSchemaAction.Add);
            }
            if (!dtDetailOrder.Columns.Contains("STT"))
            {
                dtDetailOrder.Columns.Add("STT", typeof(int)).SetOrdinal(0);
            }
            int stt = 1;
            foreach (DataRow row in dtDetailOrder.Rows)
            {
                row["STT"] = stt++;
            }
        }

        private void setValuePanelInfoTable()
        {
            lb_nameTable.Text = nameTable;
            lb_status.Text = statusTable ? "Có người" : "Trống";
            lb_timeTable.Text = string.IsNullOrEmpty(dateOpenTable) ? "..." : dateOpenTable;
            lb_idOrder.Text = string.IsNullOrEmpty(idOrder) ? "..." : idOrder;
            lb_totalPay.Text = totalPay == 0 ? "...":global.FormatPrice(totalPay);
            global.addDataGridView(dtDetailOrder, dataGridViewTable);
           
        }

        private void btn_openTable_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cb_listTable.SelectedItem;
            int maBan = Convert.ToInt32(selectedRow.Row[0]);
            if (maBan == idTable)
                MessageBox.Show("Không thể tự nối bàn");
            else if (table.getStatusTable(maBan))
            {
                MessageBox.Show("Bàn đã có người");
            }
            else
            {
                if (table.setStatusTable(maBan, true, idOrder))
                {
                    MessageBox.Show("Nối bàn thành công");
                    loadTable();
                }
            }
        }

        private void btn_closeTable_Click_1(object sender, EventArgs e)
        {
            table.setStatusTable(idTable, false, "");
            global.notify("Đóng bàn thành công");
            loadTable();

        }

        private void Button_Table_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button clickedButton = (Guna.UI2.WinForms.Guna2Button)sender;

            idTable = (int)clickedButton.Tag;
            statusTable = table.getStatusTable(idTable);
            nameTable = (string)clickedButton.Text;
            idOrder = table.getIdOrderTable(idTable);
            string[] arrayIdOrder = idOrder.Split(',');
            totalPay = calculateTotalPay(arrayIdOrder);
            dateOpenTable = order.getDateTime(arrayIdOrder[arrayIdOrder.Length - 1]);
            setDataTableDetailOrder(arrayIdOrder);
            setValuePanelInfoTable();

            btn_closeTable.Visible = statusTable;
            panelInfoTableNotEmpty.Visible = statusTable;
            labelEmpty.Visible = !statusTable;
        }

        private void loadTable()
        {
            dtTable = table.getListTable();
            panel_infoTable.Visible = true;
            panelInfoTableNotEmpty.Visible = false;
            x = 10;
            y = 10;
            panelListTable.Controls.Clear();
           
            foreach (DataRow row in dtTable.Rows)
            {
                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button()
                {
                    Width = 225,
                    Height = 160,
                    Margin = new Padding(10),
                    Location = new Point(x, y)
                };
                btn.Text = (string)row["TenBan"];
                btn.Click += Button_Table_Click;
                btn.Tag = (int)row["MaBan"];
                
                switch ((bool)row["TrangThai"])
                {
                    case false:
                        btn.ForeColor = Color.White;
                        btn.BackColor = System.Drawing.Color.Transparent;
                        btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
                        btn.BorderRadius = 12;
                        btn.Font = new System.Drawing.Font("Roboto", 14.25F);
                        btn.UseTransparentBackground = true;
                        btn.BorderColor = Color.DimGray;
                        btn.BorderThickness = 1;
                        break;
                    case true:
                        btn.ForeColor = Color.White;
                        btn.BackColor = System.Drawing.Color.Transparent;
                        btn.FillColor = System.Drawing.Color.Red;
                        btn.BorderRadius = 12;
                        btn.Font = new System.Drawing.Font("Roboto", 14.25F);
                        btn.UseTransparentBackground = true;
                        btn.BorderColor = Color.DimGray;
                        btn.BorderThickness = 1;
                        break;
                    default:
                        break;
                }
                panelListTable.Controls.Add(btn);
                x += 225;
                if ((int)row["MaBan"] % 4 == 0)
                {
                    x = 10;
                    y += 160;
                }
            }
        }

        private int calculateTotalPay(Array arrIdOrder)
        {
            int tongTien = 0;
            
            foreach (string item in arrIdOrder)
            {
                tongTien += order.getTotalPay(item);
            }
            return tongTien;
        }
    }
}
