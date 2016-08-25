using System.Collections.Generic;
using System.Drawing;

namespace ChartSuite
{
    public abstract class Painter
    {
        private int width, height;
      
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }     

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }        

        public void DrawString(string content, Style style, ChartPoint point)
        {
            DrawStringCore(content, style, point);
        }

        public void DrawImage(Image image, ChartPoint point)
        {
            DrawImageCore(image, point);
        }

        public void DrawLine(Style style, IEnumerable<ChartPoint> points, LineType lineType)
        {
            DrawLineCore(style, points, lineType);
        }

        public void DrawCurve(Style style, IEnumerable<ChartPoint> points, int width)
        {
            DrawCurveCore(style, points, width);
        }

        public void DrawPie(Style style, ChartPoint point, float startAngle, float angle)
        {
            DrawPieCore(style, point, startAngle, angle);
        }

        public void DrawPolygon(Style style, IEnumerable<ChartPoint> points)
        {
            DrawPolygonCore(style, points);
        }

        public void MergeImage(List<Bitmap> bitmap)
        {
            MergeImageCore(bitmap);
        }

        protected virtual void DrawStringCore(string content, Style style, ChartPoint point) { }

        protected virtual void DrawImageCore(Image image, ChartPoint point) { }

        protected virtual void DrawLineCore(Style style, IEnumerable<ChartPoint> points, LineType lineType) { }

        protected virtual void DrawCurveCore(Style style, IEnumerable<ChartPoint> points, int width) { }

        protected virtual void DrawPieCore(Style style, ChartPoint point, float startAngle, float angle) { }

        protected virtual void DrawPolygonCore(Style style, IEnumerable<ChartPoint> points) { }

        protected virtual void MergeImageCore(List<Bitmap> bitmap) { }
    }
}
