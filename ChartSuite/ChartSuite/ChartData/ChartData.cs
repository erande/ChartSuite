using System.Collections.Generic;

namespace ChartSuite
{
    public class ChartData
    {
        private List<DataSeries> series;

        public List<DataSeries> Series
        {
            get
            {
                return series;
            }

            set
            {
                series = value;
            }
        }
       
        public ChartData()
        {
            series = new List<DataSeries>();
        }

        public List<DataSeries> TransposeMatrix(List<DataSeries> series)
        {
            List<DataSeries> tmpSeries = new List<DataSeries>();

            foreach (DataSeries dataSeries in series)
            {
                foreach (DataPoint dataPoint in dataSeries.Point)
                {
                    if (series.IndexOf(dataSeries) == 0)
                    {
                        DataSeries tmpS = new DataSeries();
                        tmpS.Name = dataPoint.ColumnName;
                        tmpSeries.Add(tmpS);
                    }

                    DataPoint tmpPoint = new DataPoint();
                    tmpPoint.Value = dataPoint.Value;
                    tmpPoint.ColumnName = dataSeries.Name;
                    tmpPoint.IsValid = dataPoint.IsValid;

                    tmpSeries[dataSeries.Point.IndexOf(dataPoint)].Point.Add(tmpPoint);
                }
            }
            return tmpSeries;
        }

        public float CalculateMaxValue()
        {
            float maxValue = 0;
            foreach (DataSeries series in series)
            {
                foreach (DataPoint point in series.Point)
                {
                    if (maxValue < point.Value)
                        maxValue = point.Value;
                }
            }
            return maxValue;
        }

        public float CalculateMinValue()
        {
            float minValue = 0;
            foreach (DataSeries series in series)
            {
                foreach (DataPoint point in series.Point)
                {
                    if (minValue > point.Value)
                        minValue = point.Value;
                }
            }
            return minValue;
        }

        public List<string> ReadColumnName()
        {
            List<string> name = new List<string>();
            DataSeries dataSeries = series[0];

            foreach (DataPoint point in dataSeries.Point)
            {
                name.Add(point.ColumnName);
            }
            return name;
        }

        public List<string> ReadRowName()
        {
            List<string> name = new List<string>();

            foreach (DataSeries dataSeries in series)
            {
                name.Add(dataSeries.Name);
            }
            return name;
        }

        public int CalculateRowCount()
        {
            int number = 0;
            number = series.Count;
            return number;
        }

        public int CalculateColumnCount()
        {
            int number = 0;
            foreach (DataSeries dataSeries in series)
            {
                if (number < dataSeries.Point.Count)
                    number = dataSeries.Point.Count;
            }
            return number;
        }

        public float[][] ChangeSeiresToArry(List<DataSeries> series)
        {
            //Change DataSeries list to float arry
            float[][] point = new float[series.Count][];
            foreach (DataSeries dataSeries in series)
            {
                point[series.IndexOf(dataSeries)] = new float[dataSeries.Point.Count];
                foreach (DataPoint dataPoint in dataSeries.Point)
                {
                    point[series.IndexOf(dataSeries)][dataSeries.Point.IndexOf(dataPoint)] = dataPoint.Value;
                }
            }
            return point;
        }
    }
}
