using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
