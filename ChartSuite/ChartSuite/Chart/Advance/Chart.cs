using System.Collections.Generic;

namespace ChartSuite
{
    public abstract class Chart
    {
        private Style style;
        private ChartType chartType;
        private string title;
        private Margin chartMargin;

        public Style Style
        {
            get
            {
                return style;
            }

            set
            {
                style = value;
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

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public Margin ChartMargin
        {
            get
            {
                return chartMargin;
            }

            set
            {
                chartMargin = value;
            }
        }

        public void Draw(Painter painter, ChartData data)
        {
            Draw(painter, data, new Margin());
        }

        public void Draw(Painter painter, ChartData data, Margin chartMargin)
        {            
            DrawCore(painter, data);
        }

        protected ChartPoint[][] ChangeDataToPoints(ChartData data, Painter painter)
        {
            int x;
            PaintArguments paintArguments = new PaintArguments(painter, data, chartMargin);
            ChartPoint[][] point = new ChartPoint[data.CalculateRowCount()][];

            foreach (DataSeries dataSeries in data.Series)
            {
                point[data.Series.IndexOf(dataSeries)] = new ChartPoint[dataSeries.Point.Count];
                x = paintArguments.AxisXLocation + data.Series.IndexOf(dataSeries) *CalculateInterval(painter,data);

                foreach (DataPoint dataPoint in dataSeries.Point)
                {
                    float y = dataPoint.Value / paintArguments.Ratio;
                    if (dataPoint.IsValid == true)
                    {
                        point[data.Series.IndexOf(dataSeries)][dataSeries.Point.IndexOf(dataPoint)] =
                            new ChartPoint(x, (int)(painter.Height - y - paintArguments.AxisYLocation));
                    }
                }
            }
            return point;
        }

        protected virtual void DrawCore(Painter painter, ChartData data)
        {
            DrawFram(painter, data, chartType);
        }

        protected virtual int CalculateInterval(Painter painter,ChartData data)
        {
            return 0;
        }

        private void DrawFram(Painter painter, ChartData data, ChartType chartType)
        {
            DrawLegend(painter, data.ReadRowName().ToArray());

            if (chartType != ChartType.Pie)
            {
                //Draw axis's points
                ChartPoint[] axisPoint = new ChartPoint[2];
                PaintArguments paintArguments = new PaintArguments(painter, data, chartMargin);

                float tmpX = paintArguments.AxisXLocation;
                float tmpY = painter.Height - paintArguments.AxisYLocation;
                //X axis
                axisPoint[0] = new ChartPoint(tmpX, tmpY);
                axisPoint[1] = new ChartPoint(tmpX + paintArguments.AxisWidth + 20, tmpY);
                DrawAxis(painter, axisPoint);

                //Y axis
                axisPoint[0] = new ChartPoint(tmpX, tmpY);
                axisPoint[1] = new ChartPoint(tmpX, tmpY - paintArguments.AxisHeight - 10);
                DrawAxis(painter, axisPoint);

                DrawHorizontalGrid(painter, data);
                if (chartType == ChartType.Line || chartType == ChartType.Curve)
                    DrawVerticalGrid(painter, data);
            }
        }

        private void DrawLegend(Painter painter, string[] legends)
        {
            //Four points to draw rectangle
            ChartPoint[] rectanglePoint = new ChartPoint[4];
            ChartPoint labelPoint;
            PaintArguments paintArguments = new PaintArguments(painter,null,chartMargin);
            float tmpX = paintArguments.AxisXLocation + paintArguments.AxisWidth + 15;

            for (int i = 0; i < legends.Length; i++)
            {
                //Set four points to draw legend rectangle                
                float tmpY = painter.Height - paintArguments.AxisYLocation - paintArguments.AxisHeight + i * 10;
                rectanglePoint[0] = new ChartPoint(tmpX, tmpY);
                rectanglePoint[1] = new ChartPoint(tmpX + 6, tmpY);
                rectanglePoint[2] = new ChartPoint(tmpX + 6, tmpY + 5);
                rectanglePoint[3] = new ChartPoint(tmpX, tmpY + 5);
                painter.DrawPolygon(style, rectanglePoint);

                //Set point to draw legend string
                labelPoint = new ChartPoint(tmpX + 8, tmpY - 5);
                painter.DrawString(legends[i], style, labelPoint);
            }
        }

        private void DrawVerticalGrid(Painter painter, ChartData data)
        {
            PaintArguments paintArguments = new PaintArguments(painter, null, chartMargin);
            foreach (DataSeries dataSeries in data.Series)
            {
                int x = paintArguments.AxisXLocation + (data.Series.IndexOf(dataSeries)) *CalculateInterval(painter,data);
                ChartPoint[] yLinePoint = new ChartPoint[2];
                foreach (DataPoint dataPoint in dataSeries.Point)
                {
                    yLinePoint[0] = new ChartPoint(x, painter.Height - paintArguments.AxisYLocation);
                    yLinePoint[1] = new ChartPoint(x, painter.Height - paintArguments.AxisYLocation - paintArguments.AxisHeight);
                }
                painter.DrawLine(style, yLinePoint, LineType.DotLine);
            }
        }

        private void DrawHorizontalGrid(Painter painter, ChartData data)
        {
            PaintArguments paintArguments = new PaintArguments(painter, data, chartMargin);
            float value = data.CalculateMaxValue();
            float height = 20 / paintArguments.Ratio;
            ChartPoint[] points = new ChartPoint[2];
            ChartPoint point = new ChartPoint();

            float tmpX = paintArguments.AxisXLocation;
            if (value < height)
            {
                //Data max value is too small, so the offset is small
                for (int i = 0; i < value; i++)
                {
                    float tmpY = painter.Height - i / paintArguments.Ratio - paintArguments.AxisYLocation;
                    //One line-one string
                    points[0] = new ChartPoint(tmpX, tmpY);
                    points[1] = new ChartPoint(tmpX + paintArguments.AxisWidth, tmpY);
                    painter.DrawLine(style, points, LineType.DotLine);
                    point = new ChartPoint(tmpX - 30, tmpY - 2);
                    painter.DrawString(i.ToString(), style, point);
                }
            }
            else
            {

                float tmp = painter.Height - paintArguments.AxisYLocation;
                //Normal offset
                for (int i = 0; i < paintArguments.AxisHeight / height; i++)
                {
                    float tmpY = tmp - i * height;
                    points[0] = new ChartPoint(tmpX, tmpY);
                    points[1] = new ChartPoint(tmpX + paintArguments.AxisWidth, tmpY);
                    painter.DrawLine(style, points, LineType.DotLine);
                    point = new ChartPoint(tmpX - 30, tmpY - 2);
                    painter.DrawString(((int)(i * height * paintArguments.Ratio)).ToString(), style, point);
                }
            }
        }

        private void DrawAxis(Painter painter, IEnumerable<ChartPoint> point)
        {
            painter.DrawLine(style, point, LineType.ArrowAnchor);
        }

        private void DrawTitle(Painter painter, string title)
        {
            //To do
        }
    }
}
