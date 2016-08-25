
namespace ChartSuite
{
    public class NormalPieChart : PieChart
    {
        public NormalPieChart()
            :this(new Margin())
        {

        }

        public NormalPieChart(Margin chartMargin)
        {
            ChartMargin = chartMargin;
            Style = new Style();
            ChartType = ChartType.Pie;
        }

        protected override void DrawCore(Painter painter, ChartData data)
        {
            base.DrawCore(painter, data);
            if (data != null)
            {
                try
                {
                    //Change DataSeries list to float arry
                    float[][] point = data.ChangeSeiresToArry(data.Series);

                    //Calculate each columns total value
                    float[] totalNumber = CaculateSummations(data,point);
                    float startAngle = 0;

                    for (int iCol = 0; iCol < data.CalculateColumnCount(); iCol++)
                    {
                        //Set circle's center point  
                        ChartPoint centerPoint = new ChartPoint((iCol) * 150 + 100, 100);

                        for (int iRow = 0; iRow < data.CalculateRowCount(); iRow++)
                        {
                            //Draw pie
                            float angle = (point[iRow][iCol] / totalNumber[iCol]) * 360;

                            painter.DrawPie(Style, centerPoint, startAngle, angle);

                            startAngle += angle;

                            painter.DrawString(data.ReadColumnName()[iCol], Style, new ChartPoint(3 / 2 * centerPoint.X, centerPoint.Y + 110));
                        }
                    }
                }
                catch
                {
                    //To do
                }
            }
        }

        /// <summary>
        /// Calculate each columns total value
        /// </summary>
        /// <param name="point"></param>
        /// <param name="rowCount"></param>
        /// <param name="columnCount"></param>
        /// <returns></returns>
        private float[] CaculateSummations(ChartData data,float[][] point)
        {
            int columnCount = data.CalculateColumnCount();
            float[] maxNum = new float[columnCount];
            for (int column = 0; column < columnCount; column++)
            {
                maxNum[column] = 0;
                for (int row = 0; row < data.CalculateRowCount(); row++)
                {
                    maxNum[column] += point[row][column];
                }
            }
            return maxNum;
        }
    }
}
