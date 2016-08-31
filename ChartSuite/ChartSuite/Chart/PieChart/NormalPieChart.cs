
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
                    float[] totalNumber = CaculateRowSummations(data,point);
                    float startAngle = 0; 

                    for(int row=0;row<data.CalculateRowCount();row++)
                    {
                        ChartPoint centerPoint = new ChartPoint((row) * 150 + 100, 100);
                        for (int column=0;column<data.CalculateColumnCount();column++)
                        {
                            float angle = (point[row][column] / totalNumber[row]) * 360;

                            Style.CurrentColor = Style.ColorList[column];
                            painter.DrawPie(Style, centerPoint, startAngle, angle);

                            startAngle += angle;

                            painter.DrawString(data.ReadRowName()[row], Style, new ChartPoint(3 / 2 * centerPoint.X, centerPoint.Y + 110));

                        }
                    }
                }
                catch
                {
                    //To do
                }
            }
        }

        private float[] CaculateRowSummations(ChartData data, float[][] point)
        {
            int rowCount = data.CalculateRowCount();
            float[] maxNum = new float[rowCount];
            for (int row = 0; row < rowCount; row++)
            {
                maxNum[row] = 0;
                for (int column = 0; column < data.CalculateColumnCount(); column++)
                {
                    maxNum[row] += point[row][column];
                }
            }
            return maxNum;
        }
    }
}
