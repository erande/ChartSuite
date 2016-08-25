using ChartSuite;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace DebugSamples
{
    public partial class Display_ColumnChart : Form
    {
        public Display_ColumnChart()
        {
            InitializeComponent();
        }

        private string sourceFilePath = "";
        private ChartData data;

        private void dataSourcePathBtn_Click(object sender, EventArgs e)
        {
            LoadDataBtn.Enabled = false;
            ColumnChartBtn.Enabled = false;
            LineChartBtn.Enabled = false;
            CurveChartBtn.Enabled = false;
            ChangeStyleBtn.Enabled = false;
            AddChartBtn.Enabled = false;
            PieChartbtn.Enabled = false;
            AddRowDataBtn.Enabled = false;
            TransposeMatrixBtn.Enabled = false;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = @"Excel1|*.xlsx|Excel2|*.xls|csv|*.csv|mxl|*.xml";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dataSourcePathTxt.Text = dialog.FileName;
                sourceFilePath = dataSourcePathTxt.Text;

                LoadDataBtn.Enabled = true;
            }
        }

        private void LoadDataBtn_Click_1(object sender, EventArgs e)
        {
            DataProvider provider = new ExcelProvider();
            data = provider.Load(sourceFilePath);

            if (data != null)
            {
                ColumnChartBtn.Enabled = true;
                LineChartBtn.Enabled = true;
                CurveChartBtn.Enabled = true;
                ChangeStyleBtn.Enabled = true;
                AddChartBtn.Enabled = true;
                PieChartbtn.Enabled = true;
                AddRowDataBtn.Enabled = true;
                AddColumnDataBtn.Enabled = true;
                TransposeMatrixBtn.Enabled = true;
            }
        }

        private void ColumnChartBtn_Click(object sender, EventArgs e)
        {
            GdiPlusPainter painter = new GdiPlusPainter(600, 400);
            Chart chart = new VerticalColumnChart();
            chart.Style.Type = StyleType.Normal;
            chart.Draw(painter, data);
            pictureBox1.Image = painter.Bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataBtn.Enabled = false;
            ColumnChartBtn.Enabled = false;
            LineChartBtn.Enabled = false;
            CurveChartBtn.Enabled = false;
            ChangeStyleBtn.Enabled = false;
            AddChartBtn.Enabled = false;
            PieChartbtn.Enabled = false;
            AddRowDataBtn.Enabled = false;
            AddColumnDataBtn.Enabled = false;
            TransposeMatrixBtn.Enabled = false;
        }

        private void AddDataBtn_Click(object sender, EventArgs e)
        {           
            DataSeries series = new DataSeries();
            foreach (DataPoint dataPoint in data.Series[0].Point)
            {
                DataPoint point = new DataPoint();
                point.Value = 100;
                point.ColumnName = "testaddrow";
                series.Point.Add(point);
            }
            series.Name = "addrow";
            data.Series.Add(series);

            GdiPlusPainter painter = new GdiPlusPainter(600, 400);
            Chart chart = new VerticalColumnChart();
            chart.Style.Type = StyleType.Normal;
            chart.Draw(painter, data);
            pictureBox1.Image = painter.Bitmap;
        }

        private void AddColumnDataBtn_Click(object sender, EventArgs e)
        {
            foreach (DataSeries s in data.Series)
            {
                DataPoint point = new DataPoint();
                point.Value = data.Series.IndexOf(s) * 30 + 30;
                point.ColumnName = "testaddCol";
                s.Point.Add(point);
            }
            GdiPlusPainter painter = new GdiPlusPainter(600, 400);
            Chart line = new BrokenLineChart();
            line.Draw(painter, data);
            pictureBox1.Image = painter.Bitmap;
        }

        private void TransposeMatrixBtn_Click(object sender, EventArgs e)
        {
            data.Series = data.TransposeMatrix(data.Series);
            GdiPlusPainter painter = new GdiPlusPainter(600, 400);
            Chart column = new VerticalColumnChart();
            column.Draw(painter, data);
            pictureBox1.Image = painter.Bitmap;
        }

        private void LineChartBtn_Click(object sender, EventArgs e)
        {
            GdiPlusPainter painter = new GdiPlusPainter(600, 400);
            Chart chart = new BrokenLineChart();
            chart.Style.Type = StyleType.Light;
            chart.Draw(painter, data);
            pictureBox1.Image = painter.Bitmap;
        }

        private void ChangeStyleBtn_Click(object sender, EventArgs e)
        {
            ChartList list = new ChartList();
            Chart chart1 = new BrokenLineChart();
            chart1.Style.Type = StyleType.Light;
            list.ItemList.Add(chart1);

            Chart chart2 = new BrokenLineChart();
            chart2.Style.Type = StyleType.Normal;
            list.ItemList.Add(chart2);

            GdiPlusPainter painter = new GdiPlusPainter(800, list.ItemList.Count * 400);
            list.Draw(painter, data, list.ItemList);

            pictureBox1.Image = painter.Bitmap;
        }

        private void CurveChartBtn_Click(object sender, EventArgs e)
        {
            GdiPlusPainter painter = new GdiPlusPainter(600, 400);
            Chart chart = new CurveLineChart();
            chart.Style.Type = StyleType.Light;
            chart.Draw(painter, data);
            pictureBox1.Image = painter.Bitmap;
        }

        private void AddChartBtn_Click(object sender, EventArgs e)
        {
            ChartList chartItem = new ChartList();           

            Chart column = new VerticalColumnChart();
            column.Style.Type = StyleType.Light;
            chartItem.ItemList.Add(column);

            Chart curve = new BrokenLineChart();
            chartItem.ItemList.Add(curve);

            Chart pie = new NormalPieChart();
            chartItem.ItemList.Add(pie);

            GdiPlusPainter painter = new GdiPlusPainter(600, chartItem.ItemList.Count * (400 + 30));
            chartItem.Draw(painter, data, chartItem.ItemList);
            pictureBox1.Image = painter.Bitmap;
        }

        private void PieChartbtn_Click(object sender, EventArgs e)
        {
            GdiPlusPainter painter = new GdiPlusPainter(600, 400);
            Chart chart = new NormalPieChart();
            chart.Style.Type = StyleType.Light;
            chart.Draw(painter, data);
            pictureBox1.Image = painter.Bitmap;
        }
    }
}
