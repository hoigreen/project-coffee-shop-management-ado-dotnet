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
        }
        private void loadTable()
        {
            panel_infoTable.Visible = false;
            x = 10;
            y = 10;
            panelListTable.Controls.Clear();
            dtTable = table.getListTable();
            foreach (DataRow row in dtTable.Rows)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button()
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
                        btn.BackColor = Color.ForestGreen;
                        btn.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        break;
                    case true:
                        btn.ForeColor = Color.White;
                        btn.BackColor = Color.Red;
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
     

        private void Button_Table_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;

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
            panel_infoTable.Visible = true;
        }


        private void btn_closeTable_Click(object sender, EventArgs e)
        {
            table.setStatusTable(idTable, false, "");
            global.notify("Đóng bàn thành công");
            loadTable();
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

        private void setValuePanelInfoTable()
        {
            lb_nameTable.Text = nameTable;
            lb_status.Text = statusTable ? "Có người" : "Trống";
            lb_timeTable.Text = string.IsNullOrEmpty(dateOpenTable) ? "..." : dateOpenTable;
            lb_idOrder.Text = string.IsNullOrEmpty(idOrder) ? "..." : idOrder;
            lb_totalPay.Text = totalPay == 0 ? "...":global.FormatPrice(totalPay);
            global.addDataGridView(dtDetailOrder, dg_tableDetailOrder);
        }
    }
}
