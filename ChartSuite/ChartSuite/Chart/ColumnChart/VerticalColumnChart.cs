using System;

namespace ChartSuite
{
    public class VerticalColumnChart : ColumnChart
    {
        public VerticalColumnChart()
            :this(new Margin())
        {
           
        }

        public VerticalColumnChart(Margin chartMargin)
        {
            ChartMargin = chartMargin;
            Style = new Style();
            ChartType = ChartType.Column;
        }

        protected override void DrawCore(Painter painter, ChartData data)
        {
            base.DrawCore(painter, data);
            if (data != null)
            {
                PaintArguments paintArguments = new PaintArguments(painter, data, ChartMargin);
                int start = paintArguments.AxisXLocation;

                try
                {
                    float tmpY = painter.Height - paintArguments.AxisYLocation;
                    int interval = CalculateInterval(painter,data);
                    float ratio = paintArguments.Ratio;
                    foreach (DataSeries dataSeries in data.Series)
                    {
                        painter.DrawString(dataSeries.Name, Style, new ChartPoint(start + interval, tmpY + 2));

                        foreach (DataPoint dataPoint in dataSeries.Point)
                        {
                            start += interval;

                            if (dataPoint.IsValid == true)
                            {
                                ChartPoint[] rectPoint = new ChartPoint[4];
                                float y = dataPoint.Value / ratio;
                                rectPoint[0] = new ChartPoint(start, tmpY - 1);
                                rectPoint[1] = new ChartPoint(start, tmpY - y);
                                rectPoint[2] = new ChartPoint(start + interval, tmpY - y);
                                rectPoint[3] = new ChartPoint(start + interval, tmpY - 1);
                                Style.CurrentColor = Style.ColorList[dataSeries.Point.IndexOf(dataPoint)];
                                painter.DrawPolygon(Style, rectPoint);

                                if (interval > 10)
                                    painter.DrawString(dataPoint.Value.ToString(), Style, new ChartPoint(start, tmpY - y - 15));
                            }
                        }
                        start += interval;
                    }
                }
                catch (IndexOutOfRangeException exception)
                {
                    exception.Source = "Check the Painter whether is error./n Check the data source whether is error.";
                    throw exception;
                }
            }
        }
    }
}
