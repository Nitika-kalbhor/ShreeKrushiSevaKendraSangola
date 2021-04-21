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
    public partial class frmNotificationReport : MetroForm
    {
        public frmNotificationReport()
        {
            InitializeComponent();
        }

        private void frmNotificationReport_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNotofication = notificationController.getNotification(Convert.ToDateTime(dtpFrom.Value.ToShortDateString()), Convert.ToDateTime(dtpTo.Value.ToShortDateString()));
                if (dtNotofication.Rows.Count > 0)
                    DgvNotification.DataSource = dtNotofication;
                DgvNotification.ClearSelection();
            }
            catch(Exception ae)
            {
                MessageBox.Show("Error!", ae.ToString());
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNotofication = notificationController.getNotification(Convert.ToDateTime(dtpFrom.Value.ToShortDateString()), Convert.ToDateTime(dtpTo.Value.ToShortDateString()));
                if (dtNotofication.Rows.Count > 0)
                    DgvNotification.DataSource = dtNotofication;
                DgvNotification.ClearSelection();
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error!", ae.ToString());
            }
        }

        private void btneExcelReport_Click(object sender, EventArgs e)
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
                foreach (DataGridViewColumn col in DgvNotification.Columns)
                {
                    dtAccount.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in DgvNotification.Rows)
                {
                    DataRow dRow = dtAccount.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtAccount.Rows.Add(dRow);
                }

                dtAccount.TableName = "नोटीफिकेशन रिपोर्ट";
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

        private void BtnNewnotification_Click(object sender, EventArgs e)
        {
            frmNexPaymentDate frm = new frmNexPaymentDate();
            frm.ShowDialog();
        }
    }
}
