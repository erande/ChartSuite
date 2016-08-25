
namespace ChartSuite
{
    public class Margin
    {
        private int left;
        private int right;
        private int top;
        private int bottom;

        public Margin()
            :this(0,0,0,0)
        {

        }

        public Margin(int left, int right, int top, int bottom)
        {
            this.left = left;
            this.right = right;
            this.top = top;
            this.bottom = bottom;
        }

        public int Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }

        public int Right
        {
            get
            {
                return right;
            }

            set
            {
                right = value;
            }
        }

        public int Top
        {
            get
            {
                return top;
            }

            set
            {
                top = value;
            }
        }

        public int Bottom
        {
            get
            {
                return bottom;
            }

            set
            {
                bottom = value;
            }
        }

        public void ChangeMargin(int marginCount)
        {
            int tmpMargin = marginCount / 4;
            Left = tmpMargin;
            Right = tmpMargin;
            Top = tmpMargin;
            Bottom = tmpMargin;
        }

        public void ChangeMargin(int left, int right, int top, int bottom)
        {
            this.left = left;
            this.right = right;
            this.top = top;
            this.bottom = bottom;
        }
    }
}
