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
            panel_ban.Controls.Clear();
            dtTable = table.getListTable();
            foreach (DataRow row in dtTable.Rows)
            {
                Button btn = new Button()
                {
                    Width = 100,
                    Height = 100,
                    Margin = new Padding(10),
                    Location = new Point(x, y)
                };
                btn.Text = (string)row["TenBan"];
                btn.Click += Button_Table_Click;
                btn.Tag = (int)row["MaBan"];
                
                switch ((string)row["TrangThai"])
                {
                    case "Trống":
                        btn.ForeColor = Color.Black;
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.ForeColor = Color.White;
                        btn.BackColor = Color.Red;
                        break;
                }
                panel_ban.Controls.Add(btn);
                x += 100;
                if ((int)row["MaBan"] % 5 == 0)
                {
                    x = 0;
                    y += 100;
                }
            }
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
