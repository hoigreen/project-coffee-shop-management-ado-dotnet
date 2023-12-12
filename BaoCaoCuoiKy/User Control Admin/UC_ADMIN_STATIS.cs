using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.WinForms;
using LiveCharts.Definitions.Charts;
using LiveCharts.Helpers;
using System.Windows.Media;

namespace BaoCaoCuoiKy.User_Control_Admin
{
    public partial class UC_ADMIN_STATIS : UserControl
    {
        public UC_ADMIN_STATIS()
        {
            InitializeComponent();
        }
        private XL_STAFF staff = new XL_STAFF();
        private XL_MENU menu = new XL_MENU();
        private XL_ORDER order = new XL_ORDER();
        private DataTable dtThongKe = new DataTable();
        private DataTable dtTopBestSaler = new DataTable();
        private Global global = new Global();

        private void UC_QuanLyThongKe_Load(object sender, EventArgs e)
        {
            setValueLabelStatis();
            loadCartesianChart();
            loadPieChart();
        }

        private void setValueLabelStatis()
        {
            lblAmountRenevue.Text = global.FormatPrice(order.getTotalRevenue());
            lblAmountStaff.Text = staff.getCountSumStaff().ToString();
            lblAmountOrder.Text = order.getCountSumOrder().ToString();
            lblAmountItems.Text = menu.getCountSumMenu().ToString();
        }

        private void loadCartesianChart()
        {
            dtThongKe = order.getTotalRevenue_Month();
            SeriesCollection seriesCollection = new SeriesCollection();
            ColumnSeries columnSeries = new ColumnSeries
            {
                Title = "Doanh thu",
                Values = new ChartValues<double>(dtThongKe.AsEnumerable().Select(row => Convert.ToDouble(row["TongDoanhThu"]))),
                MaxColumnWidth = 40,
                Fill = System.Windows.Media.Brushes.Red
            };
            seriesCollection.Add(columnSeries);
            Axis axisX = new Axis
            {
                Labels = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" },
                Separator = new Separator { Step = 1 },
            };
            Axis axisY = new Axis
            {
                LabelFormatter = value => global.FormatPrice((int)value)
            };
            axisX.Foreground = System.Windows.Media.Brushes.Black; 
            axisX.FontSize = 20; 
            axisY.Foreground = System.Windows.Media.Brushes.Black; 
            axisY.FontSize = 20;

            chartReportRenevue.Series = seriesCollection;
            chartReportRenevue.AxisX.Add(axisX);
            chartReportRenevue.AxisY.Add(axisY);
            
            panelChartLine.Controls.Add(chartReportRenevue);
        }

        private void setNotePieChart(int i)
        {
            if(i == 0) lb_topSaler1.Text = dtTopBestSaler.Rows[0]["Ten"].ToString();
            if(i == 1) lb_topSaler2.Text = dtTopBestSaler.Rows[1]["Ten"].ToString();
            if(i == 2) lb_topSaler3.Text = dtTopBestSaler.Rows[2]["Ten"].ToString();
            if(i == 3) lb_topSaler4.Text = dtTopBestSaler.Rows[3]["Ten"].ToString();
            if(i == 4) lb_topSaler5.Text = dtTopBestSaler.Rows[4]["Ten"].ToString();
        }

        private void loadPieChart()
        {
            dtTopBestSaler = menu.getTopBestSaler();
            System.Windows.Media.Brush[] arrColor = { System.Windows.Media.Brushes.Red, System.Windows.Media.Brushes.Blue, System.Windows.Media.Brushes.Green, System.Windows.Media.Brushes.Yellow, System.Windows.Media.Brushes.Orange };
            for (int i = 0; i < Math.Min(5, dtTopBestSaler.Rows.Count); i++)
                setNotePieChart(i);

            SeriesCollection seriesCollection = new SeriesCollection();

            int count = 0;
            foreach (DataRow row in dtTopBestSaler.Rows)
            {
                string tenMonAn = row["Ten"].ToString();

                int soLuongBan = Convert.ToInt32(row["SoLuongBan"]);

                seriesCollection.Add(new PieSeries
                {
                    Title = tenMonAn,
                    Values = new ChartValues<double> { soLuongBan },
                    Fill = arrColor[count],
                    DataLabels = true,
                });
                count += 1;
            }

            pieChartBestItems.Series = seriesCollection;
            panel_Piechart.Controls.Add(pieChartBestItems);
        }
    }
}
