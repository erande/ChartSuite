using System.Collections.Generic;

namespace ChartSuite
{
    public class DataSeries
    {
        private string name;
        private List<DataPoint> point;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public List<DataPoint> Point
        {
            get
            {
                return point;
            }

            set
            {
                point = value;
            }
        }

        public DataSeries()
        {
            name = "";
            point = new List<DataPoint>();
        }
    }
}
