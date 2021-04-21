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
    public partial class frmExpireReport : MetroForm
    {
        public frmExpireReport()
        {
            InitializeComponent();
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Expiry Report";
                    label1.Text = "To Date:";
                    label10.Text = "From Date:";
                    btneExcelReport.Text = "Exel Report";
                    btnShow.Text = "Show";

                    dgvExpireReport.Columns[0].HeaderText = "Category Name";
                    dgvExpireReport.Columns[1].HeaderText = "Company";
                    dgvExpireReport.Columns[2].HeaderText = "Item Name";
                    dgvExpireReport.Columns[3].HeaderText = "unitBy";
                    dgvExpireReport.Columns[4].HeaderText = "Batch No";
                    dgvExpireReport.Columns[5].HeaderText = "Expire Date";
                    dgvExpireReport.Columns[6].HeaderText = "Current Stock";
                    dgvExpireReport.Columns[7].HeaderText = "Rack No";                  

                  }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtExpire = expireReportController.getExpireReport(Convert.ToDateTime(dtpFrom.Value.ToShortDateString()), Convert.ToDateTime(dtpTo.Value.ToShortDateString()));
                dgvExpireReport.DataSource=dtExpire;
                dgvExpireReport.ClearSelection();
            }
            catch(Exception ae)
            {
                MessageBox.Show("डाटा दाखवण्यास त्रुटी येत आहे"+ae.ToString());
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
                foreach (DataGridViewColumn col in dgvExpireReport.Columns)
                {
                    dtAccount.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvExpireReport.Rows)
                {
                    DataRow dRow = dtAccount.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtAccount.Rows.Add(dRow);
                }

                dtAccount.TableName = "एक्सपायरी  रिपोर्ट";
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

        private void frmExpireReport_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void frmExpireReport_KeyDown_1(object sender, KeyEventArgs e)
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

        private void frmExpireReport_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = Utility.startDate(System.DateTime.Now);
            Lang();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
