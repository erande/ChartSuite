
namespace ChartSuite
{
    public class BrokenLineChart : LineChart
    {
        public BrokenLineChart()
            :this(new Margin())
        {

        }

        public BrokenLineChart(Margin chartMargin)
        {
            ChartMargin = chartMargin;
            Style = new Style();
            ChartType = ChartType.Line;
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
                        start = paintArguments.AxisXLocation + (data.Series.IndexOf(dataSeries)) * CalculateInterval(painter, data);
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
                    DrawLineCore(painter,data, point);
                }
                catch
                {
                    //To do
                }
            }
        }

        private void DrawLineCore(Painter painter,ChartData data, ChartPoint[][] point)
        {
            ChartPoint[] pointF = new ChartPoint[2];
            int rowCount = data.CalculateRowCount();
            for (int column = 0; column < data.CalculateColumnCount(); column++)
            {
                for (int row = 0; row < rowCount; row++)
                {
                    if (row < rowCount - 1)
                    {
                        if (point[row][column].X != 0)
                        {
                            pointF[0] = new ChartPoint(point[row][column].X, point[row][column].Y);

                            if (point[row + 1][column].X != 0)
                            {
                                pointF[1] = new ChartPoint(point[row + 1][column].X, point[row + 1][column].Y);
                                painter.DrawLine(Style, pointF, LineType.SolidLine);
                            }
                            else
                            {
                                ChartPoint p = new ChartPoint(point[row + 1][column].X, point[row + 1][column].Y);
                            }
                        }
                    }
                    else
                    {
                        ChartPoint p = new ChartPoint(point[row][column].X, point[row][column].Y);
                    }
                }
            }
        }

    }
}
