using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Office.Interop.Excel;


namespace Excel_Example
{
    class ReadExcel
    {
        public static void readExcel()
        {

            string filePath = @"D:\Names_Basic.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];
            Range cell = ws.Range["A1:A1"];
            foreach (var Result in cell.Value)
            {
                MessageBox.Show(Result);
            }
            wb.Close();

        }
    }
}
