
namespace ChartSuite
{
    public class CurveLineChart : LineChart
    {
        public CurveLineChart()
            :this(new Margin())
        {

        }

        public CurveLineChart(Margin chartMargin)
        {
            ChartMargin = chartMargin;
            Style = new Style();
            ChartType = ChartType.Curve;
        }

        protected override void DrawCore(Painter painter, ChartData data)
        {
            base.DrawCore(painter, data);
            if (data != null)
            {
                int start;
                PaintArguments paintArguments = new PaintArguments(painter, data, ChartMargin);

                try
                {
                    foreach (DataSeries dataSeries in data.Series)
                    {
                        float tmpY = painter.Height - paintArguments.AxisYLocation;
                        start = paintArguments.AxisXLocation + (data.Series.IndexOf(dataSeries)) * CalculateInterval(painter,data);
                        painter.DrawString(dataSeries.Name, Style, new ChartPoint(start, tmpY + 2));

                        foreach (DataPoint dataPoint in dataSeries.Point)
                        {
                            float y = dataPoint.Value / paintArguments.Ratio;
                            if (dataPoint.IsValid == true)
                            {
                                if (CalculateInterval(painter,data) > 10)
                                    painter.DrawString(dataPoint.Value.ToString(), Style, new ChartPoint(start - 7, tmpY - y - 15));
                            }
                        }
                    }
                    ChartPoint[][] point = ChangeDataToPoints(data, painter);
                    DrawCurveCore(painter,data, point);
                }
                catch
                {
                    //To do
                }
            }
        }

        private void DrawCurveCore(Painter painter,ChartData data, ChartPoint[][] point)
        {
            int rowCount = data.CalculateRowCount();
            for (int column = 0; column < data.CalculateColumnCount(); column++)
            {
                ChartPoint[] points = new ChartPoint[rowCount];
                for (int row = 0; row < rowCount; row++)
                {
                    points[row] = point[row][column];
                }
                Style.CurrentColor = Style.ColorList[column];
                painter.DrawCurve(Style, points, 2);
            }
        }
    }
}
