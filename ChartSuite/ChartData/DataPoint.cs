
namespace ChartSuite
{
    public class DataPoint
    {
        private string columnName;
        private float value;
        private bool isValid;

        public string ColumnName
        {
            get
            {
                return columnName;
            }

            set
            {
                columnName = value;
            }
        }

        public float Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public bool IsValid
        {
            get
            {
                return isValid;
            }
            
            set
            {
                isValid = value;
            }
        }

        public DataPoint()
        {
            isValid = true;
            columnName = "";
        }
    }
}
