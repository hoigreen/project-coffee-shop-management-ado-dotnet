using BaoCaoCuoiKy.User_Control;
using CoffeeShopManagement.User_Control_Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace BaoCaoCuoiKy
{
    public partial class Form_Main_Staff : Form
    {
        public Form_Main_Staff()
        {
            InitializeComponent();
        }

        private void Form_Main_Staff_Load(object sender, EventArgs e)
        {
            UC_STAFF_TABLE uc = new UC_STAFF_TABLE();
            addUserControl(uc);
        }

        // Xử lý khi Form mới đóng -> form cũ hiển thị lại
        private void Form_Main_Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đảm bảo rằng khi form mới đóng, form cũ sẽ được hiển thị lại
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Hủy sự kiện đóng form để xử lý tại sự kiện FormClosed
                this.Close();
            }
        }

        private void addUserControl(System.Windows.Forms.UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_staff_container.Controls.Clear();
            panel_staff_container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnExitWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            UC_STAFF_TABLE uc = new UC_STAFF_TABLE();
            addUserControl(uc);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UC_STAFF_CREATEORDER uc = new UC_STAFF_CREATEORDER();
            addUserControl(uc);
        }
    }
}
