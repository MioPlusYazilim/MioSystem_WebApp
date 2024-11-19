using System.Runtime.InteropServices;

namespace MioSystem.Utils
{
    public class ExcelHelper : IDisposable
    {
        public string[] ConvertXlsToCsv(string xlsPath, char Delimitter)
        {
            string[] Lines = new string[0];
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                Microsoft.Office.Interop.Excel.Workbook workBook = ExcelApp.Workbooks.Open(xlsPath, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Microsoft.Office.Interop.Excel.Worksheet workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Sheets[1];

                Microsoft.Office.Interop.Excel.Range excelRange = workSheet.UsedRange;
                int rowCount = excelRange.Rows.Count;
                int colCount = excelRange.Columns.Count;

                Lines = new string[rowCount];
                for (int row = 1; row <= rowCount; row++)
                {
                    string line = string.Empty;
                    for (int col = 1; col <= colCount; col++)
                    {
                        try
                        {
                            line += (col == 1 ? "" : Delimitter) + excelRange.Cells[row, col].ToString();
                        }
                        catch (Exception ex)
                        {
                        }

                    }
                    Lines[row - 1] = line;
                }
                Marshal.ReleaseComObject(excelRange);
                Marshal.ReleaseComObject(workSheet);

                workBook.Close();
                Marshal.ReleaseComObject(workBook);
            }
            catch (Exception ex)
            {
            }
            try
            {
                ExcelApp.Quit();
                Marshal.ReleaseComObject(ExcelApp);
            }
            catch (Exception ex)
            {
            }
            return Lines;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }

    public class XlsColum : IDisposable
    {
        public int ColID { get; set; }
        public string NameEng { get; set; }
        public string NameTr { get; set; }

        public void Dispose()
        {

            GC.SuppressFinalize(this);
        }
    }
}
