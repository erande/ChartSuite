using System;
using System.Windows.Forms;
using ChartSuite;

namespace DebugSamples
{
    public partial class Display_PieChart : Form
    {
        public string path = @"C:\Users\xieshuangshuang\Desktop\Dependencies\Test.xlsx";

        public Display_PieChart()
        {
            InitializeComponent();
        }

        private void chartView1_Load_1(object sender, EventArgs e)
        {
            chartView2.Path = path;
            chartView2.ChartType = ChartType.Pie;
            chartView2.Refresh();
        }
    }
}
