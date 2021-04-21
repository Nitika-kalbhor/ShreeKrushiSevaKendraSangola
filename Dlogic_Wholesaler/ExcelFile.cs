using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
namespace Dlogic_Wholesaler
{
    public class ExcelFile
    {

        private string excelFilePath = @"D:\GSTR3B.xlsx";//string.Empty;
        private int rowNumber = 1; // define first row number to enter data in excel

        Excel.Application myExcelApplication;
        Excel.Workbook myExcelWorkbook;
        Excel.Worksheet myExcelWorkSheet;

        public string ExcelFilePath
        {
            get { return excelFilePath; }
            set { excelFilePath = value; }
        }

        public int Rownumber
        {
            get { return rowNumber; }
            set { rowNumber = value; }
        }

        public void openExcel(string excelFilePath)
        {
            myExcelApplication = null;

            myExcelApplication = new Excel.Application(); // create Excell App
            myExcelApplication.DisplayAlerts = false; // turn off alerts


            myExcelWorkbook = (Excel.Workbook)(myExcelApplication.Workbooks._Open(excelFilePath, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value)); // open the existing excel file

            int numberOfWorkbooks = myExcelApplication.Workbooks.Count; // get number of workbooks (optional)

            myExcelWorkSheet = (Excel.Worksheet)myExcelWorkbook.Worksheets[1]; // define in which worksheet, do you want to add data
            myExcelWorkSheet.Name = "WorkSheet 1"; // define a name for the worksheet (optinal)

            int numberOfSheets = myExcelWorkbook.Worksheets.Count; // get number of worksheets (optional)
        }

        public void addDataToExcel(string a, string firstname, string lastname, string language, string email, string company, int rowNumbers)
        {
            if (rowNumbers == 26)
            {
                myExcelWorkSheet.Cells[rowNumbers, "C"] = firstname;
                myExcelWorkSheet.Cells[rowNumbers, "D"] = lastname;
                myExcelWorkSheet.Cells[rowNumbers, "E"] = language;
                myExcelWorkSheet.Cells[6, "G"] = email;
                myExcelWorkSheet.Cells[5, "G"] = Utility.Financialyear;         
            }
            else
            {
                myExcelWorkSheet.Cells[rowNumbers, "C"] = firstname;
                myExcelWorkSheet.Cells[rowNumbers, "D"] = lastname;
                myExcelWorkSheet.Cells[rowNumbers, "E"] = language;
                myExcelWorkSheet.Cells[rowNumbers, "F"] = email;
                myExcelWorkSheet.Cells[rowNumbers, "G"] = company;
            }
            // if you put this method inside a loop, you should increase rownumber by one or wat ever is your logic

        }
        public void addMasterData(string GSTNo, string shopName, string months,int rowNumbers)
        { 
            try{
                   myExcelWorkSheet.Cells[rowNumbers, "C"] = GSTNo;
                   myExcelWorkSheet.Cells[rowNumbers+1, "C"] = shopName;
                 //  myExcelWorkSheet.Cells[rowNumbers+1, "G"] = months;
              //    myExcelWorkSheet.Cells[rowNumbers, "G"] = Utility.Financialyear;              
            }
            catch (Exception ex)
            {
               throw ex;
            }
        }
        public void closeExcel(string excelFilePath)
        {
            try
            {
                myExcelWorkbook.SaveAs(excelFilePath, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value, Excel.XlSaveAsAccessMode.xlNoChange,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value); // Save data in excel


                myExcelWorkbook.Close(true, excelFilePath, System.Reflection.Missing.Value); // close the worksheet


            }
            finally
            {
                if (myExcelApplication != null)
                {
                    myExcelApplication.Quit(); // close the excel application
                }
            }

        }
    }
}
