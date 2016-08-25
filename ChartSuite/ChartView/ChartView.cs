using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChartSuite
{
    public partial class ChartView : UserControl
    {
        private Image image;
        private string path;
        private PictureBoxSizeMode sizeMode;
        private ChartType chartType;

        public ChartView()
            : this(null)
        {

        }

        public ChartView(string path)
            : this(path, 0)
        {

        }

        public ChartView(string path, ChartType chartType)
        {
            this.path = path;
            this.chartType = chartType;
        }

        public string Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }

        public ChartType ChartType
        {
            get
            {
                return chartType;
            }

            set
            {
                chartType = value;
            }
        }

        public PictureBoxSizeMode SizeMode
        {
            get
            {
                return sizeMode;
            }

            set
            {
                sizeMode = value;
            }
        }

        public Image Image
        {
            get
            {
                return image;
            }
        }
        
        public delegate void OnPaintHandler(PaintEventArgs e);
        public event OnPaintHandler OnPainting;

        public override void Refresh()
        {
            base.Refresh();
            OnPainting = new OnPaintHandler(OnPaint);
        }

        private ChartData data;
        private GdiPlusPainter painter;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            try
            {
                DataProvider provider = SelectProvider(path);
                data = provider.Load(path);
                painter = new GdiPlusPainter(Width, Height);
                Chart chart = SelectChartType(chartType); 

                chart.Draw(painter, data);
                Graphics graphics = e.Graphics;
                graphics.DrawImage(painter.Bitmap, new PointF(0, 0));
            }
            catch (ArgumentNullException exception)
            {
                exception.Source = "Path is null.\nData is null.\nDrawImage method's Image parameter is null.";
                throw exception;
            }
        }

        private DataProvider SelectProvider(string path)
        {
            DataProvider provider;

            string type;
            if (Path != null)
            {
                type = System.IO.Path.GetExtension(Path);
                switch (type)
                {
                    case ".xls":
                    case ".xlsx":
                        provider = new ExcelProvider();
                        return provider;
                }
            }
            return null;
        }

        private Chart SelectChartType(ChartType chartType)
        {
            Chart chart;
            switch (chartType)
            {
                case ChartType.Column:
                    chart = new VerticalColumnChart();
                    return chart;
                case ChartType.Line:
                    chart = new BrokenLineChart();
                    return chart;
                case ChartType.Curve:
                    chart = new CurveLineChart();
                    return chart;
                case ChartType.Pie:
                    chart = new NormalPieChart();
                    return chart;
                default:
                    chart = new BrokenLineChart();
                    return chart;
            }
        }

        private void saveImageAsSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //To do: Save image
        }

        private void ChartView_Load(object sender, EventArgs e)
        {

        }
    }
}
