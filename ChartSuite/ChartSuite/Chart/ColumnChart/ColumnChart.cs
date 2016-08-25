
namespace ChartSuite
{
    public class ColumnChart : Chart
    {
        protected override int CalculateInterval(Painter painter,ChartData data)
        {
            PaintArguments paintArguments = new PaintArguments(painter, null, ChartMargin);
            return paintArguments.AxisWidth / ((data.CalculateColumnCount() + 1) * data.CalculateRowCount());
        }        
    }
}
