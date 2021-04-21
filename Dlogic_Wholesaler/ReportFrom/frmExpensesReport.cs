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
    public partial class frmExpensesReport : MetroForm
    {
        public frmExpensesReport()
        {
            InitializeComponent();
        }
        public static DataTable dtAccount = new DataTable();
        public static DataTable dtAllAccount = new DataTable();
        public void bindaccountName(Boolean Active_Type)
        {
            DataTable dtaccountname = accountDetailsController.getExensesAccount();
            Utility.BindComboBoxDataSelect(cmbAccount, dtaccountname, "AccountID", "AccountName");
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Expenses Report";
                    label10.Text = "From Date:";
                    label1.Text = "To Date:";
                    lblAccountName.Text = "Account Name:";
                    btneExcelReport.Text = "Excel Report";
                    btnShow.Text = "Show";
                    btnPrint.Text = "Print";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmExpensesReport_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFrom.Value = Utility.startDate(System.DateTime.Now);
                dtpTo.MaxDate = DateTime.Now;
                bindaccountName(true);
                Lang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            GetDataForGrid();
        }
        private void GetDataForGrid()
        {
            try
            {
                dtAccount = dtAllAccount;
                if (cmbAccount.SelectedIndex > 0)
                {
                    dtAccount = accountDetailsController.getExpensesVoucher(Convert.ToInt64(cmbAccount.SelectedValue),dtpFrom.Value, dtpTo.Value, Utility.FinancilaYearId, "ExpensesReportById");
                    //var query = from Account in dtAccount.AsEnumerable()
                    //            where Account.Field<DateTime>("voucherDate") >= Convert.ToDateTime(dtpFrom.Value.ToShortDateString())
                    //             && Account.Field<DateTime>("voucherDate") <= Convert.ToDateTime(dtpTo.Value.ToShortDateString())
                    //             && Account.Field<long>("accountId") == Convert.ToInt64(cmbAccount.SelectedValue)
                    //            select Account;
                    //if (query.Count() > 0)
                    //{
                    //    dtAccount = query.CopyToDataTable<DataRow>();
                    //}
                    //else
                    //{
                    //    dtAccount = null;
                    //}
                }
                else
                {

                    dtAccount = accountDetailsController.getExpensesVoucher(0,dtpFrom.Value, dtpTo.Value, Utility.FinancilaYearId, "ExpensesReport");
                    //var query = from Account in dtAccount.AsEnumerable()
                    //            where Account.Field<DateTime>("voucherDate") >= Convert.ToDateTime(dtpFrom.Value.ToShortDateString())
                    //             && Account.Field<DateTime>("voucherDate") <= Convert.ToDateTime(dtpTo.Value.ToShortDateString())
                    //            select Account;
                    //if (query.Count() > 0)
                    //{
                    //    dtAccount = query.CopyToDataTable<DataRow>();
                    //}
                    //else
                    //{
                    //    dtAccount = null;
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errror!" + ex.Message);
            }

            bindAllAccount(dtAccount);
          
        }
        public void  bindAllAccount(DataTable dtAccount)
        {
            try
            {
                if (dtAccount != null)
                {
                    decimal TotalCredit = 0,DrAmount =0,balanceAmount=0;
                    for (int i = 0; i < dtAccount.Rows.Count; ++i)
                    {
                      
                            TotalCredit += Convert.ToDecimal(dtAccount.Rows[i]["crAmount"].ToString());
                            DrAmount += Convert.ToDecimal(dtAccount.Rows[i]["drAmount"].ToString());
                            balanceAmount += Convert.ToDecimal(dtAccount.Rows[i]["balanceAmount"].ToString());
                        
                    }
                    DataRow dr = dtAccount.NewRow();                 
                    if (Utility.Langn == "English")
                    {
                        dr["naration"] = "Total Amount";
                    }
                    else
                    {
                        dr["naration"] = "एकूण रक्कम";
                    }
                    dr["crAmount"] = TotalCredit;
                    dr["drAmount"] = DrAmount;
                    dr["balanceAmount"] = balanceAmount;
                    dtAccount.Rows.Add(dr);
                    dgvAccounting.DataSource = null;
                    dgvAccounting.AutoGenerateColumns = false;
                    dgvAccounting.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    dgvAccounting.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                    dgvAccounting.Font = new Font("Tahoma", 12);

                    dgvAccounting.EnableHeadersVisualStyles = false;

                    dgvAccounting.ColumnCount = 9;
                    if (Utility.Langn == "English")
                    {
                        dgvAccounting.Columns[1].HeaderText = "Invoice No";
                        dgvAccounting.Columns[2].HeaderText = "Date";
                        dgvAccounting.Columns[3].HeaderText = "Nave Account Name";
                        dgvAccounting.Columns[4].HeaderText = "Expense Account Name";
                        dgvAccounting.Columns[5].HeaderText = "Naration";
                        dgvAccounting.Columns[6].HeaderText = "CR.Amount";
                        dgvAccounting.Columns[7].HeaderText = "DR.Amount";
                        dgvAccounting.Columns[8].HeaderText = "Balance Amt";
                    }
                    else
                    {
                        dgvAccounting.Columns[1].HeaderText = "पावती नं";
                        dgvAccounting.Columns[2].HeaderText = "दिनांक";
                        dgvAccounting.Columns[3].HeaderText = "नावे खात्याचे नांव";
                        dgvAccounting.Columns[4].HeaderText = "खर्च खात्याचे नांव";
                        dgvAccounting.Columns[5].HeaderText = "तपशील";
                        dgvAccounting.Columns[6].HeaderText = "खर्च रक्कम";
                        dgvAccounting.Columns[7].HeaderText = "दिलेली रक्कम";
                        dgvAccounting.Columns[8].HeaderText = "बाकी रक्कम";
                    }
                    dgvAccounting.Columns[0].Name = "accountId";
                    dgvAccounting.Columns[0].HeaderText = "accountId";
                    dgvAccounting.Columns[0].DataPropertyName = "accountId";
                    dgvAccounting.Columns[0].Visible = false;

                    dgvAccounting.Columns[1].Name = "InvoiceNo";                   
                    dgvAccounting.Columns[1].DataPropertyName = "InvoiceNo";
                  //  dgvAccounting.Columns[1].Width = 150;

                    dgvAccounting.Columns[2].Name = "voucherDate";                   
                    dgvAccounting.Columns[2].DataPropertyName = "voucherDate";
                    dgvAccounting.Columns[2].Width = 150;

                    dgvAccounting.Columns[3].Name = "naveAccountName";                   
                    dgvAccounting.Columns[3].DataPropertyName = "naveAccountName";
                    dgvAccounting.Columns[3].Width = 250;

                    dgvAccounting.Columns[4].Name = "jamaAccountName";                 
                    dgvAccounting.Columns[4].DataPropertyName = "jamaAccountName";
                    dgvAccounting.Columns[4].Width = 250;

                    dgvAccounting.Columns[5].Name = "naration";                 
                    dgvAccounting.Columns[5].DataPropertyName = "naration";
                   // dgvAccounting.Columns[5].Width = 250;

                    dgvAccounting.Columns[6].Name = "crAmount";                  
                    dgvAccounting.Columns[6].DataPropertyName = "crAmount";
                   // dgvAccounting.Columns[6].Width = 150;

                    dgvAccounting.Columns[7].Name = "drAmount";                 
                    dgvAccounting.Columns[7].DataPropertyName = "drAmount";

                    dgvAccounting.Columns[8].Name = "balanceAmount";                   
                    dgvAccounting.Columns[8].DataPropertyName = "balanceAmount";
                    dgvAccounting.Columns[7].Width = 250;

                    dgvAccounting.DataSource = dtAccount;
                    dgvAccounting.ClearSelection();
                   if( dgvAccounting.Rows.Count >0)
                    dgvAccounting.Rows[dgvAccounting.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                    dgvAccounting.Rows[dgvAccounting.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        //private void subtot()
        //{
        //    try
        //    {
        //        decimal TotalCredit = 0;
        //        for (int i = 0; i < dgvAccounting.Rows.Count - 1; ++i)
        //        {
        //            if (dgvAccounting.Rows[i].Cells[5].Value != null)
        //            {
        //                TotalCredit += Convert.ToDecimal(dgvAccounting.Rows[i].Cells[5].Value);
        //            }
        //        }
        //        dgvAccounting[5, dgvAccounting.Rows.Count - 1].Value = TotalCredit;
        //        // txtTotaldrAmount.Text = TotalCredit.ToString();
        //        decimal DueAmt = 0;
        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        private void btneExcelReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccounting.Rows.Count > 0)
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

                    foreach (DataGridViewColumn col in dgvAccounting.Columns)
                    {
                        dtAccount.Columns.Add(col.HeaderText);
                    }

                    foreach (DataGridViewRow row in dgvAccounting.Rows)
                    {
                        DataRow dRow = dtAccount.NewRow();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            dRow[cell.ColumnIndex] = cell.Value;
                        }
                        dtAccount.Rows.Add(dRow);
                    }
                    if (Utility.Langn == "English")
                    {
                        dtAccount.TableName = "Expenses Report";
                    }
                    else
                    {
                        dtAccount.TableName = "खर्च रिपोर्ट(Expenses Report)";
                    }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmExpensesReport_KeyDown(object sender, KeyEventArgs e)
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
