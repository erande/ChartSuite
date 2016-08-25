using System.Collections.Generic;
using System.Drawing;

namespace ChartSuite
{
    public class ChartList
    {
        private List<Chart> itemList;

        public List<Chart> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public ChartList()
        {
            ItemList = new List<Chart>();
        }

        public void Add(Chart chart)
        {
            itemList.Add(chart);
        }

        public void Draw(Painter painter, ChartData data, List<Chart> itemList)
        {
            if (data != null && itemList.Count != 0)
            {
                List<Bitmap> bitmap = new List<Bitmap>();
                foreach (Chart item in itemList)
                {
                    bitmap.Add(DrawCore(item, data));
                }  
                painter.MergeImage(bitmap);
            }
        }

        protected virtual Bitmap DrawCore(Chart chart,ChartData data)
        {
            GdiPlusPainter painter = new GdiPlusPainter(600, 400);
            chart.Draw(painter, data);
            return painter.Bitmap;
        }
    }
}
