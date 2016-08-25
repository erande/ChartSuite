
namespace ChartSuite
{
    public class LineChart : Chart
    {
        protected override int CalculateInterval(Painter painter,ChartData data)
        {
            PaintArguments paintArguments = new PaintArguments(painter, null, ChartMargin);
            return paintArguments.AxisWidth/ (data.CalculateRowCount() - 1);
        }
    }
}
