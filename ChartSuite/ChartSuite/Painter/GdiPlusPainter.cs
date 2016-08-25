using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace ChartSuite
{
    public class GdiPlusPainter : Painter
    {
        private Graphics graphics;
        private Bitmap bitmap;

        public Bitmap Bitmap
        {
            get
            {
                return bitmap;
            }
        }

        public GdiPlusPainter()
            :this(0,0)
        {

        }
        
        public GdiPlusPainter(int width, int height)
        {
            Width = width;
            Height = height;

            bitmap = new Bitmap(width, height);
            graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        protected override void DrawImageCore(Image image, ChartPoint point)
        {
            throw new NotImplementedException();
        }

        protected override void DrawPieCore(Style style, ChartPoint point, float startAngle, float angle)
        {
            Pen linePen = new Pen(Color.Black, 1);

            Pen piePen = new Pen(style.ColorList[0], 1);
            SolidBrush piebrush = new SolidBrush(piePen.Color);

            graphics.DrawPie(linePen, point.X, point.Y, 100, 100, startAngle, angle);
            graphics.FillPie(piebrush, point.X, point.Y, 100, 100, startAngle, angle);
        }

        protected override void DrawStringCore(string content, Style style, ChartPoint point)
        {
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            graphics.DrawString(content, style.Font, solidBrush, point.X, point.Y);
        }

        protected override void DrawLineCore(Style style, IEnumerable<ChartPoint> points, LineType lineType)
        {
            Pen pen;

            switch (lineType)
            {
                case LineType.ArrowAnchor:
                    pen = new Pen(style.OutLineColor, 2);
                    pen.EndCap = LineCap.ArrowAnchor;
                    break;
                case LineType.DotLine:
                    pen = new Pen(style.OutLineColor, 1);
                    pen.DashStyle = DashStyle.Dot;
                    break;
                case LineType.SolidLine:
                    pen = new Pen(style.ColorList[0], 2);
                    break;
                default:
                    pen = new Pen(style.ColorList[0], 2);
                    break;
            }

            graphics.DrawLines(pen, ToPointF(points));
        }

        protected override void DrawCurveCore(Style style, IEnumerable<ChartPoint> points, int width)
        {
            Pen pen = new Pen(style.ColorList[0], width);
            graphics.DrawCurve(pen, ToPointF(points));
        }

        protected override void DrawPolygonCore(Style style, IEnumerable<ChartPoint> points)
        {
            Pen pen = new Pen(style.ColorList[0], 1);
            Brush brush = pen.Brush;

            graphics.DrawPolygon(pen, ToPointF(points));
            graphics.FillPolygon(brush, ToPointF(points));
        }

        protected override void MergeImageCore(List<Bitmap> bitmap)
        {
            Graphics graphics = Graphics.FromImage(this.bitmap);
            graphics.DrawImage(this.bitmap, this.bitmap.Width, this.bitmap.Height);
            int currentHeight = 0;

            foreach (Bitmap myBitmap in bitmap)
            {
                graphics.DrawImage(myBitmap, 0, currentHeight);
                currentHeight += myBitmap.Height;
            }
        }

        private PointF[] ToPointF(IEnumerable<ChartPoint> points)
        {

            PointF[] point = new PointF[points.Count()];
            int index = 0;

            foreach(ChartPoint chartPoint in points.ToList())
            {
                point[index++] = new PointF(chartPoint.X, chartPoint.Y);
            }

            return point;
        }
    }
}
