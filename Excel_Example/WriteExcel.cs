using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
namespace Excel_Example
{
    class WriteExcel
    {
        public static void writeExcel()
        {
            string filePath = @"D:\Students.xlsx";
            Application excel = new Application();
            Workbook wb = excel.Workbooks.Open(filePath);
            Worksheet ws = wb.Worksheets[1];

            string[] names = System.IO.File.ReadAllText(@"D:\names.txt").Replace(" ", "").Split(',');
            
            Range cellRange = ws.Range["A1:E1"];

            cellRange.set_Value(XlRangeValueDataType.xlRangeValueDefault, names);

            wb.SaveAs(filePath);
            wb.Close();
            
            Process.Start(@"D:\Students.xlsx");
        }
    }
}
