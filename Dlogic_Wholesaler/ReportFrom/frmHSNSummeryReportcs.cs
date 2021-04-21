using DataAccessLayer.controller;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class frmHSNSummeryReportcs : MetroForm
    {
        public frmHSNSummeryReportcs()
        {
            InitializeComponent();
        }

        private void frmHSNSummeryReportcs_Load(object sender, EventArgs e)
        {
            dgvHNSSummery.DataSource = null;
            gttDate();
        }
        private void gttDate()
        {
            try
            {
                System.Data.DataSet dateCurrentDt = gstR1Controller.getGSTR1Report(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()),Utility.FinancilaYearId, "dateCurrent");
                dtpFromDate.Value = Convert.ToDateTime(dateCurrentDt.Tables[0].Rows[0]["fromDate"]);
                dtpToDate.Value = Convert.ToDateTime(dateCurrentDt.Tables[0].Rows[0]["toDate"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try {
                DataTable hsncode = hnsSummaryController.getHSNSummaryDetails(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()));
                dgvHNSSummery.DataSource=hsncode;
                dgvHNSSummery.ClearSelection();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                //Create Excel Sheets
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);
                DataTable dtAccount = new DataTable();
                foreach (DataGridViewColumn col in dgvHNSSummery.Columns)
                {
                    dtAccount.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvHNSSummery.Rows)
                {
                    DataRow dRow = dtAccount.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtAccount.Rows.Add(dRow);
                }

                dtAccount.TableName = "HSN Summery";
                xlWorksheet.Name = dtAccount.TableName;

                for (int j = 1; j < dtAccount.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = dtAccount.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < dtAccount.Rows.Count; k++)
                {
                    for (int l = 0; l < dtAccount.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        dtAccount.Rows[k].ItemArray[l].ToString();
                    }
                }
                ExcelApp.Columns.AutoFit();

                ((Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.ActiveWorkbook.Sheets[ExcelApp.ActiveWorkbook.Sheets.Count]).Delete();
                ExcelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmHSNSummeryReportcs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                try
                {

                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
