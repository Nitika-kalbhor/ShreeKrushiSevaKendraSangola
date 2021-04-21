using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer.controller;
using DataAccessLayer.models;
using MetroFramework.Forms;
using MetroFramework;

using System.Globalization;
using ExcelAutoFormat =
    Microsoft.Office.Interop.Excel.XlRangeAutoFormat;
using System.IO;
using System.Diagnostics; 
namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class frmGST3BReport : MetroForm
    {
        public frmGST3BReport()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataSet gstR3B = gstR3BController.getGSTR3BReport(Convert.ToDateTime(dtpFrom.Value.ToShortDateString()), Convert.ToDateTime(dtpTo.Value.ToShortDateString()), Utility.FinancilaYearId, "GSTR3B");
                dgvOutwardSupplies.DataSource = gstR3B.Tables[0];
                dgvEligibleITC.DataSource = gstR3B.Tables[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void gttDate()
        {
            try
            {
                System.Data.DataSet dateCurrentDt = gstR1Controller.getGSTR1Report(Convert.ToDateTime(dtpFrom.Value.ToShortDateString()), Convert.ToDateTime(dtpTo.Value.ToShortDateString()), Utility.FinancilaYearId, "dateCurrent");
                dtpFrom.Value = Convert.ToDateTime(dateCurrentDt.Tables[0].Rows[0]["fromDate"]);
                dtpTo.Value = Convert.ToDateTime(dateCurrentDt.Tables[0].Rows[0]["toDate"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmGST3BReport_Load(object sender, EventArgs e)
        {
            try
            {
                gttDate();
                btnShow_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btneExcelReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtAccount = new DataTable();
                //Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                //Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                //Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                //Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                //xlSheets = ExcelApp.Sheets;
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Workbooks.Add();

                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheetToUpload = default(Microsoft.Office.Interop.Excel.Worksheet);
             //  xlWorkSheetToUpload = ExcelApp.Sheets["Sheet1"];
                ExcelApp.Visible = true;
                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;

                //Create Excel Sheets
                xlSheets = ExcelApp.Sheets;
                xlWorkSheetToUpload = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);
                System.Data.DataSet gstR3B = gstR3BController.getGSTR3BReport(Convert.ToDateTime(dtpFrom.Value.ToShortDateString()), Convert.ToDateTime(dtpTo.Value.ToShortDateString()), Utility.FinancilaYearId, "GSTR3B");
                dtAccount = gstR3B.Tables[0];
                dtAccount.TableName = "GST 3B Report";
                xlWorkSheetToUpload.Name = dtAccount.TableName;
                xlWorkSheetToUpload.Cells[8, 2] = "3.1 Details of Outward Supplies and inward supplies liable to reverse charge";

                xlWorkSheetToUpload.Range["B8:G8"].MergeCells = true;
                int iRowCnt = 10;
                xlWorkSheetToUpload.Cells[iRowCnt - 1, 2] = "Nature of Supplies";
                xlWorkSheetToUpload.Cells[iRowCnt - 1, 3] = "Total Taxable Value";
                xlWorkSheetToUpload.Cells[iRowCnt - 1, 4] = "Integrated Tax";
                xlWorkSheetToUpload.Cells[iRowCnt - 1, 5] = "Central Tax";
                xlWorkSheetToUpload.Cells[iRowCnt - 1, 6] = "State UT Tax";
                xlWorkSheetToUpload.Cells[iRowCnt - 1, 7] = "Cess";
                // SHOW THE EXCEL SHEET. 
                // SETTING IT VISIBLE WILL ALLOW YOU TO SEE HOW IT WRITES DATA TO EACH CELL.

                // Storing Each row and column value to excel sheet
                for (var i = 0; i <= dtAccount.Rows.Count - 1; i++)
                {
                    xlWorkSheetToUpload.Cells[iRowCnt, 2] = dtAccount.Rows[i]["NatureofSupplies"];
                    xlWorkSheetToUpload.Cells[iRowCnt, 3] = dtAccount.Rows[i]["TotalTaxableValue"];
                    xlWorkSheetToUpload.Cells[iRowCnt, 4] = dtAccount.Rows[i]["IntegratedTax"];
                    xlWorkSheetToUpload.Cells[iRowCnt, 5] = dtAccount.Rows[i]["CentralTax"];
                    xlWorkSheetToUpload.Cells[iRowCnt, 6] = dtAccount.Rows[i]["StateUTTax"];
                    xlWorkSheetToUpload.Cells[iRowCnt, 7] = dtAccount.Rows[i]["Cess"];              
                    iRowCnt = iRowCnt + 1;
                }
                xlWorkSheetToUpload.Cells[18, 2] = "4. Eligible ITC";
                xlWorkSheetToUpload.Range["B18:F18"].MergeCells = true;
                xlWorkSheetToUpload.Cells[19, 2] = "Details";
                xlWorkSheetToUpload.Cells[19, 3] = "Integrated Tax";
                xlWorkSheetToUpload.Cells[19, 4] = "Central Tax";
                xlWorkSheetToUpload.Cells[19, 5] = "State UT Tax";
                xlWorkSheetToUpload.Cells[19, 6] = "Cess";

                xlWorkSheetToUpload.Cells[20, 2] = "1";
                xlWorkSheetToUpload.Cells[20, 3] = "2";
                xlWorkSheetToUpload.Cells[20, 4] = "3";
                xlWorkSheetToUpload.Cells[20, 5] = "4";
                xlWorkSheetToUpload.Cells[20, 6] = "5";
                // Storing Each row and column value to excel sheet
                int newRow =21;
                for (var i = 0; i <= gstR3B.Tables[1].Rows.Count - 1; i++)
                {
                    xlWorkSheetToUpload.Cells[newRow, 2] = gstR3B.Tables[1].Rows[i]["Details"];
                    xlWorkSheetToUpload.Cells[newRow, 3] = gstR3B.Tables[1].Rows[i]["IntegratedTax"];
                    xlWorkSheetToUpload.Cells[newRow, 4] = gstR3B.Tables[1].Rows[i]["CentralTax"];
                    xlWorkSheetToUpload.Cells[newRow, 5] = gstR3B.Tables[1].Rows[i]["StateUTTax"];
                    xlWorkSheetToUpload.Cells[newRow, 6] = gstR3B.Tables[1].Rows[i]["Cess"];                   
                    newRow = newRow + 1;
                }
              
                Microsoft.Office.Interop.Excel.Range formatRange;
                formatRange = xlWorkSheetToUpload.get_Range("B18:F18");
                xlWorkSheetToUpload.get_Range("B8:G8").Font.Bold = true;
                xlWorkSheetToUpload.get_Range("B8:G8").Font.Size = 13;
                xlWorkSheetToUpload.get_Range("B9:G9").Font.Size = 11;
                xlWorkSheetToUpload.get_Range("B9:G9").Font.Bold = true;
               // formatRange.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheetToUpload.Columns.AutoFit();

                ExcelApp = null;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcelGST3B_Click(object sender, EventArgs e)
        {
            ExcelFile exs = new ExcelFile(); string folderPath = "";
            try
            {
                //OpenFileDialog choofdlog = new OpenFileDialog();
                //choofdlog.Filter = "Excel (*.xlsx*)|*.xlsx*";
                //choofdlog.FilterIndex = 1;
                //choofdlog.Multiselect = true;

                //if (choofdlog.ShowDialog() == DialogResult.OK)
                //{
                //    folderPath = choofdlog.FileName;
                //    //string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
                //}
               // folderPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "\\GSTEXCEL\\GSTR3B.xlsx";
                folderPath=Directory.GetCurrentDirectory()+ "\\GSTEXCEL\\GSTR3B.xlsx";
                System.Data.DataSet gstR3B = gstR3BController.getGSTR3BReport(Convert.ToDateTime(dtpFrom.Value.ToShortDateString()), Convert.ToDateTime(dtpTo.Value.ToShortDateString()), Utility.FinancilaYearId, "GSTR3B");
                DataTable Org = gstR3BController.getOrgDetails();
            int rows = 11;
            exs.openExcel(folderPath);
                for(int x=0;x<gstR3B.Tables[0].Rows.Count;x++)
                {
                    exs.addDataToExcel(gstR3B.Tables[0].Rows[x]["NatureofSupplies"].ToString(), gstR3B.Tables[0].Rows[x]["TotalTaxablevalue"].ToString(),
                        gstR3B.Tables[0].Rows[x]["IntegratedTax"].ToString(), gstR3B.Tables[0].Rows[x]["CentralTax"].ToString(),
                        gstR3B.Tables[0].Rows[x]["StateUTTax"].ToString(), gstR3B.Tables[0].Rows[x]["Cess"].ToString(),rows);
                    rows++;
                }
                for (int y = 0; y < gstR3B.Tables[1].Rows.Count; y++)
                {
                    exs.addDataToExcel("", gstR3B.Tables[1].Rows[y]["IntegratedTax"].ToString(), gstR3B.Tables[1].Rows[y]["CentralTax"].ToString()
                        , gstR3B.Tables[1].Rows[y]["StateUTTax"].ToString(), dtpFrom.Value.ToString("MMMM", CultureInfo.InvariantCulture), "", 26);
                }
                if(Org.Rows.Count > 0)
                {
                    exs.addMasterData(Org.Rows[0]["GSTTIN"].ToString(), Org.Rows[0]["orgName"].ToString(), dtpFrom.Value.ToString("MMMM", CultureInfo.InvariantCulture), 5);
                }
                string Monthsf = dtpFrom.Value.ToString("dd-MMMM-yyyy", CultureInfo.InvariantCulture);
                string Monthst = dtpTo.Value.ToString("dd-MMMM-yyyy", CultureInfo.InvariantCulture);
                MessageBox.Show("Excel Update  From-" + Monthsf + " to-" + Monthst);
                //var excelApp = new Microsoft.Office.Interop.Excel.Application();
                //excelApp.Visible = true;
                //Microsoft.Office.Interop.Excel.Workbook workBook = excelApp.Workbooks.Open(folderPath);
                //Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets[1];
                //Microsoft.Office.Interop.Excel.Range rg = ws.UsedRange;
              
            }
            catch (Exception ex)
            {
                exs.closeExcel(folderPath);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                exs.closeExcel(folderPath);
                Process.Start(folderPath);
              
            }
        }
    }
}
