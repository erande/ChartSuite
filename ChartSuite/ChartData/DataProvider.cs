
namespace ChartSuite
{
    public abstract class DataProvider
    {
        private static string path;

        public static string Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }        

        public DataProvider()
            :this(null)
        {

        }

        public DataProvider(string path)
        {
            Path = path;
        }

        public ChartData Load()
        {
            return LoadCore(Path);
        }

        public ChartData Load(string path)
        {
            return LoadCore(path);
        }

        protected virtual ChartData LoadCore(string path)
        {
            return null;
        }
       
    }
}
