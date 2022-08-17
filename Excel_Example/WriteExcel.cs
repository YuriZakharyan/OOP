using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Excel_Example
{
    class WriteExcel
    {
        public static void writeExcel()
        {
            string filePath = @"D:\Names_Basic.xlsx";
            Application excel = new Application();
            Workbook wb;
            Worksheet ws;
            
            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Range cellRange = ws.Range["C2:D3"];
            cellRange.Value = "Aram";

            wb.SaveAs(filePath);
            wb.Close();

        }
    }
}
