
namespace ChartSuite
{
   public class ChartPoint
    {
        private float x;
        private float y;

        public ChartPoint()
            :this(0,0)
        {

        }

        public ChartPoint(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
    }
}
