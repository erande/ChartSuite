
namespace ChartSuite
{
    internal class PaintArguments
    {
        private int axisWidth;
        private int axisHeight;
        private float ratio;
        private int axisXLocation;
        private int axisYLocation;

        public PaintArguments(Painter painter, ChartData data, Margin chartMargin)
        {
            axisWidth = painter.Width - chartMargin.Left - chartMargin.Right - 50 - 80;
            axisHeight = painter.Height - chartMargin.Top - chartMargin.Bottom - 30 * 2;
            if (data != null)
                ratio = data.CalculateMaxValue() / axisHeight;
            axisXLocation = chartMargin.Left + 50;
            axisYLocation = chartMargin.Bottom + 30;
        }

        public int AxisWidth
        {
            get
            {
                return axisWidth;
            }
        }

        public int AxisHeight
        {
            get
            {
                return axisHeight;
            }
        }

        public int AxisXLocation
        {
            get
            {
                return axisXLocation;
            }
        }

        public int AxisYLocation
        {
            get
            {
                return axisYLocation;
            }
        }

        public float Ratio
        {
            get
            {
                return ratio;
            }
        }
    }
}
