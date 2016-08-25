using Microsoft.Office.Interop.Excel;
using System;
using System.Runtime.InteropServices;

namespace ChartSuite
{
    public class ExcelProvider : DataProvider
    {
        protected override ChartData LoadCore(string path)
        {
            ChartData data = new ChartData();

            Application app = new Application();
            Workbook workbook = app.Workbooks.Open(path);
            Sheets sheets = workbook.Worksheets;
            Worksheet worksheet = (Worksheet)sheets.get_Item(1);

            try
            {
                int rowCount = worksheet.UsedRange.Rows.Count;
                int columnCount = worksheet.UsedRange.Columns.Count;

                for (int row = 2; row <= rowCount; row++)
                {
                    DataSeries series = new DataSeries();
                    for (int column = 2; column <= columnCount; column++)
                    {
                        series.Name = ReadCellValue(worksheet, row, 1);

                        DataPoint point = new DataPoint();
                        point.ColumnName = ReadCellValue(worksheet, 1, column);

                        float value;
                        point.IsValid = float.TryParse(ReadCellValue(worksheet, row, column), out value);
                        point.Value = value;

                        series.Point.Add(point);
                    }
                    data.Series.Add(series);
                }
                return data;
            }
            catch(IndexOutOfRangeException exception)
            {
                exception.Source = "Please check the cells text, whether it is format.";
                throw exception;
            }

            finally
            {
                ReleaseSource(workbook, app);
            }
        }
       
        private void ReleaseSource(Workbook workbook, Application app)
        {
            workbook.Close(false);
            Marshal.ReleaseComObject(workbook);
            app.Workbooks.Close();
            app.Quit();
            Marshal.ReleaseComObject(app);
        }

        private string ReadCellValue(Worksheet worksheet, int row, int column)
        {
            Range range = worksheet.Cells[row, column];
            string value = range.Text.ToString().Trim();
            return value;
        }
    }
}
