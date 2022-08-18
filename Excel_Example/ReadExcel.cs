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
            string filePath = @"D:\Students.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Open(filePath); 
            Worksheet ws = wb.Worksheets[1];

            Range cell = ws.Range["A1:F1"];
            foreach (string Result in cell.Value)
            {
                MessageBox.Show(Result);
            }
            wb.Close();
        }
    }
}