using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoCuoiKy
{
    internal class Global
    {
        public string pathDatabase = @"Data Source=DangQuocHuy\SQLEXPRESS;Initial Catalog=QL_CAFE;Integrated Security=True";
        public void notify(string content)
        {
            MessageBox.Show(content, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void addDataGridView(DataTable dtMenu, DataGridView dgView)
        {
            dgView.Rows.Clear();
            foreach (DataRow row in dtMenu.Rows)
            {
                int rowIndex = dgView.Rows.Add();
                for (int columnIndex = 0; columnIndex < dtMenu.Columns.Count; columnIndex++)
                {
                    dgView.Rows[rowIndex].Cells[columnIndex].Value = row[columnIndex];
                }
            }
        }
    }
    
}
