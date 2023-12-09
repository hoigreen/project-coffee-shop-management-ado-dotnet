using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement.User_Control_Staff
{
    public partial class UC_STAFF_TABLE : UserControl
    {
        private XL_TABLE table = new XL_TABLE();
        private DataTable dtTable = new DataTable();
        private int x = 0, y = 0;

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
            panelListTable.Controls.Clear();
            dtTable = table.getListTable();
            foreach (DataRow row in dtTable.Rows)
            {
                Button btn = new Button()
                {
                    Width = 260,
                    Height = 200,
                    Margin = new Padding(10),
                    Location = new Point(x, y)
                };
                btn.Text = (string)row["TenBan"];
                btn.Click += Button_Table_Click;
                btn.Tag = (int)row["MaBan"];
                
                switch ((string)row["TrangThai"])
                {
                    case "Trống":
                        btn.ForeColor = Color.White;
                        btn.BackColor = Color.ForestGreen;
                        btn.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        break;
                    default:
                        btn.ForeColor = Color.White;
                        btn.BackColor = Color.Red;
                        break;
                }
                panelListTable.Controls.Add(btn);
                x += 260;
                if ((int)row["MaBan"] % 6 == 0)
                {
                    x = 0;
                    y += 200;
                }
            }
        }

        private void panel_ban_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTitleEmpty_Click(object sender, EventArgs e)
        {

        }

        private void panelListTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Table_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi Button được nhấn
            Button clickedButton = (Button)sender;
            int maBan = (int)clickedButton.Tag;
            string tenBan = (string)clickedButton.Text;

            // Hiển thị thông báo MaBan
            MessageBox.Show($"Đã nhấn vào {tenBan} với mã là {maBan}");
        }
    }
}
