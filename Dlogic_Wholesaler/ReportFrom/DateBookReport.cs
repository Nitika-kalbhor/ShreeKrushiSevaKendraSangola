using System;
using Dlogic_Wholesaler.ReportFrom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using DataAccessLayer.controller;
using DataAccessLayer.models;
using MetroFramework.Forms;
using MetroFramework.Fonts;
using System.Data;
using Microsoft.Office.Interop.Excel;
using Microsoft.Reporting.WinForms;
using Dlogic_Wholesaler.ReportFrom_;

namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class DateBookReport : Form
    {
       
        public DateBookReport()
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
                    lblHerader.Text = "Day Book Report";
                    metroLabel3.Text = "To Date:";
                    metroLabel1.Text = "From Date:";
                    button1.Text = "Exel Report";
                    btnPrint.Text = "Print";
                    label8.Text = "Opening Amount:";
                    label9.Text = "Current Amount:";
                    groupBox1.Text = "Purchase";
                    groupBox4.Text = "Receipt Amount Details";
                    groupBox5.Text = "Nave amount Details";
                    btnnew.Text = "Show";
                    groupBox3.Text = "Purchase Return";
                    groupBox6.Text = "Sale Details";
                    groupBox7.Text = "Total";
                    groupBox8.Text = "Sale Return Details";
                    label6.Text = "Credit";
                    label1.Text = "Cash";
                    label2.Text = "Bill Amount";
                    label3.Text = "Total Purchase:";
                    label4.Text = "Total Purchase Return:";
                    label5.Text = "Total Sale:";
                    label7.Text = "Total Sale Return:";
                    label15.Text = "Cash Jama";
                    label16.Text = "Cash Nave";
                    label14.Text = "Total:";
                    label17.Text = "Total Remaining Amt:";
                    label10.Text = "Show";

                    dgvPurchaseInvoice.Columns["purchaseDate"].HeaderText = "Date";
                    dgvPurchaseInvoice.Columns["purchaseInvoiceId"].HeaderText = "Bill No.";
                    dgvPurchaseInvoice.Columns["billType"].HeaderText = "Bill Type";
                    dgvPurchaseInvoice.Columns["dealerFirmName"].HeaderText = "Dealer Name";
                    dgvPurchaseInvoice.Columns["paidAmount"].HeaderText = "Paid Amount";
                    dgvPurchaseInvoice.Columns["netBillAmount"].HeaderText = "Bill Amount";

                    dgvPurchaseReturn.Columns["purchaseReutrnDate"].HeaderText = "Date";
                    dgvPurchaseReturn.Columns["purchaseReutrnInvoiceId"].HeaderText = "Bill No.";
                    dgvPurchaseReturn.Columns["invoiceType"].HeaderText = "Bill Type";
                    dgvPurchaseReturn.Columns["dealerFirmName1"].HeaderText = "Dealer Name";
                    dgvPurchaseReturn.Columns["paidReturnAmount"].HeaderText = "Paid Amount";
                    dgvPurchaseReturn.Columns["netBillAmount1"].HeaderText = "Bill Amount";

                    dgvSaleDetails.Columns["salesDate"].HeaderText = "Date";
                    dgvSaleDetails.Columns["salesInvoiceId"].HeaderText = "Bill No.";
                    dgvSaleDetails.Columns["saleType"].HeaderText = "Bill Type";
                    dgvSaleDetails.Columns["customerName"].HeaderText = "Customer Name";
                    dgvSaleDetails.Columns["paidSaleAmount"].HeaderText = "Paid Amount";
                    dgvSaleDetails.Columns["totalbillAmount"].HeaderText = "Bill Amount";

                    dgvSaleReturn.Columns["salesReturnDate"].HeaderText = "Date";
                    dgvSaleReturn.Columns["salesReturnInvoiceId"].HeaderText = "Bill No.";
                    dgvSaleReturn.Columns["saleType1"].HeaderText = "Bill Type";
                    dgvSaleReturn.Columns["customerName1"].HeaderText = "Customer Name";
                    dgvSaleReturn.Columns["saleReturnPaidAmount"].HeaderText = "Paid Amount";
                    dgvSaleReturn.Columns["saleReturnTotalAmount"].HeaderText = "Bill Amount";

                    dgvPaymentReceipt.Columns["receiptDate1"].HeaderText = "Date";
                    dgvPaymentReceipt.Columns["paymentReceiptDetailsId1"].HeaderText = "Receipt No";
                    dgvPaymentReceipt.Columns["accountName1"].HeaderText = "Account Name";
                    dgvPaymentReceipt.Columns["crAmount"].HeaderText = "Amount";

                    dgvPaymentVoucher.Columns["voucherDate1"].HeaderText = "Date";
                    dgvPaymentVoucher.Columns["paymentVoucherDetailsId1"].HeaderText = "Receipt No";
                    dgvPaymentVoucher.Columns["accountName"].HeaderText = "Account Name";
                    dgvPaymentVoucher.Columns["drAmount"].HeaderText = "Amount";

                    dgvPayRec.Columns[0].HeaderText = "Payment Type";
                    dgvPayRec.Columns[1].HeaderText = "CR.Amount";
                    dgvPayRec.Columns[2].HeaderText = "DR.Amount";
              
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void DateBookReport_Load(object sender, EventArgs e)
        {
            dtpToDate.MaxDate = DateTime.Now;
            dtpFromDate.MaxDate = DateTime.Now;
            dtpToDate.MinDate = dtpFromDate.Value;
            Lang();
        }
        public void subtot()
        {
            try
            {
                double totPAmount = 0, totRPAmount = 0, totSPAmount = 0;
                double totAmount = 0, totRAmount = 0, totSAmount = 0;
                double totSRAmount = 0, TotSCAmount = 0, TotalPAmount = 0;
                double totalCash = 0, totalCredit = 0, GrandCredit = 0, GrandDebit = 0;
                for (int i = 0; i < dgvPurchaseInvoice.Rows.Count; ++i)
                {
                    totAmount += Convert.ToDouble(dgvPurchaseInvoice.Rows[i].Cells["netBillAmount"].Value);
                    totPAmount += Convert.ToDouble(dgvPurchaseInvoice.Rows[i].Cells["paidAmount"].Value);
                }
                for (int i = 0; i < dgvPurchaseReturn.Rows.Count; ++i)
                {
                    totRAmount += Convert.ToDouble(dgvPurchaseReturn.Rows[i].Cells["netBillAmount1"].Value);
                    totRPAmount += Convert.ToDouble(dgvPurchaseReturn.Rows[i].Cells["paidReturnAmount"].Value);
                }
                for (int i = 0; i < dgvSaleDetails.Rows.Count; ++i)
                {
                    totSAmount += Convert.ToDouble(dgvSaleDetails.Rows[i].Cells["totalbillAmount"].Value);
                    totSPAmount += Convert.ToDouble(dgvSaleDetails.Rows[i].Cells["paidSaleAmount"].Value);
                }
                for (int i = 0; i < dgvSaleReturn.Rows.Count; ++i)
                {
                    totSRAmount += Convert.ToDouble(dgvSaleReturn.Rows[i].Cells["saleReturnPaidAmount"].Value);
                    TotalPAmount += Convert.ToDouble(dgvSaleReturn.Rows[i].Cells["saleReturnTotalAmount"].Value);
                }
                for (int i = 0; i < dgvPayRec.Rows.Count;++i)
                {
                    if (dgvPayRec.Rows[i].Cells["payType"].Value.ToString() == "Cash")
                    {
                        GrandCredit += Convert.ToDouble(dgvPayRec.Rows[i].Cells["GrandCr"].Value);
                        GrandDebit += Convert.ToDouble(dgvPayRec.Rows[i].Cells["GrandDr"].Value);
                    }
                }
                    txtPaidTotalPurchase.Text = totPAmount.ToString();
                txtPaidPurchaseReturn.Text = totRPAmount.ToString();
                txtSalePaid.Text = totSPAmount.ToString();
                txtbillAmount.Text = totAmount.ToString();
                txtRbillAmount.Text = totRAmount.ToString();
                txtSBillamount.Text = totSAmount.ToString();
                txtSaleReturnTotal.Text = totSRAmount.ToString();
                txtSaleReturnCash.Text = TotalPAmount.ToString();
                double DuePurchSum = Convert.ToDouble(txtbillAmount.Text) - (Convert.ToDouble(txtPaidTotalPurchase.Text));
                txtDueAmountP.Text = DuePurchSum.ToString();
                double DuePurchReturnSum = Convert.ToDouble(txtRbillAmount.Text) - (Convert.ToDouble(txtPaidPurchaseReturn.Text));
                txtDueAmountRP.Text = DuePurchReturnSum.ToString();
                double DueSaleSum = Convert.ToDouble(txtSBillamount.Text) - (Convert.ToDouble(txtSalePaid.Text));
                txtDueAmountS.Text = Math.Round(DueSaleSum,2).ToString();
                txtSaleReturnCredit.Text = (totSRAmount - TotalPAmount).ToString();
                txtCashCredit.Text = (totRPAmount + totSPAmount + GrandCredit).ToString();
                txtCashDebit.Text = (totPAmount + totSRAmount + GrandDebit).ToString();
                txtClosing.Text = ((totRPAmount + totSPAmount + GrandCredit) - (totPAmount + totSRAmount + GrandDebit)).ToString();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DateBookReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
     
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = dayBookReportController.DayBookReport(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()));
                dgvPurchaseInvoice.DataSource = ds.Tables[0];
                dgvPurchaseReturn.DataSource = ds.Tables[1];
                dgvSaleDetails.DataSource = ds.Tables[2];
                dgvPaymentReceipt.DataSource = ds.Tables[3];
                dgvPaymentVoucher.DataSource = ds.Tables[4];
                dgvSaleReturn.DataSource = ds.Tables[5];
                dgvPayRec.DataSource = ds.Tables[6];
                lblOpninBalance.Text = ds.Tables[7].Rows[0]["OpeningCash"].ToString();
                lblClosingBalance.Text = ds.Tables[8].Rows[0]["OpeningCash"].ToString();
                subtot();
            }
            catch(Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtpToDate.MinDate = dtpFromDate.Value;
                DataSet ds = dayBookReportController.DayBookReport(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()));
                dgvPurchaseInvoice.DataSource = ds.Tables[0];
                dgvPurchaseReturn.DataSource = ds.Tables[1];
                dgvSaleDetails.DataSource = ds.Tables[2];
                dgvPaymentReceipt.DataSource = ds.Tables[3];
                dgvPaymentVoucher.DataSource = ds.Tables[4];
                dgvSaleReturn.DataSource = ds.Tables[5];
                dgvPayRec.DataSource = ds.Tables[6];
                lblOpninBalance.Text = ds.Tables[7].Rows[0]["OpeningCash"].ToString();
                lblClosingBalance.Text = ds.Tables[8].Rows[0]["OpeningCash"].ToString();
                subtot();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                // Loop over DataTables in DataSet.
                DataSet ds = dayBookReportController.DayBookReport(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()));
                //if (Utility.Langn == "English")
                //{
                //    ds.Tables[0].TableName = "Purchase Details";
                //    ds.Tables[0].Columns["purchaseDate"].ColumnName = "Date";
                //    ds.Tables[0].Columns["purchaseInvoiceId"].ColumnName = "Bill No";
                //    ds.Tables[0].Columns["dealerFirmName"].ColumnName = "Dealer Name";
                //    ds.Tables[0].Columns["netBillAmount"].ColumnName = "Bill Amount";
                //    ds.Tables[0].Columns["paidAmount"].ColumnName = "Paid Amount";
                //    ds.Tables[1].TableName = "Purchase Return Details";
                //    ds.Tables[1].Columns["purchaseReutrnDate"].ColumnName = "Date";
                //    ds.Tables[1].Columns["purchaseReutrnInvoiceId"].ColumnName = "Bill No";
                //    ds.Tables[1].Columns["dealerFirmName"].ColumnName = "Dealer Name";
                //    ds.Tables[1].Columns["netBillAmount"].ColumnName = "Bill Amount";
                //    ds.Tables[1].Columns["paidAmount"].ColumnName = "Paid Amount";
                //    ds.Tables[2].TableName = "Sale Details";
                //    ds.Tables[2].Columns["salesDate"].ColumnName = "Date";
                //    ds.Tables[2].Columns["salesInvoiceId"].ColumnName = "Bill No";
                //    ds.Tables[2].Columns["customerName"].ColumnName = "Customer Name";
                //    ds.Tables[2].Columns["totalbillAmount"].ColumnName = "Bill Amount";
                //    ds.Tables[2].Columns["paidAmount"].ColumnName = "Paid Amount";
                //    ds.Tables[3].TableName = "जमा पावती माहिती";
                //    ds.Tables[3].Columns["receiptDate"].ColumnName = "Date";
                //    ds.Tables[3].Columns["paymentReceiptId"].ColumnName = "Receipt No";
                //    ds.Tables[3].Columns["accountName"].ColumnName = "Account Name";
                //    ds.Tables[3].Columns["crAmount"].ColumnName = "Paid Amount";

                //    ds.Tables[4].TableName = "नावे पावती माहिती";
                //    ds.Tables[4].Columns["voucherDate"].ColumnName = "Date";
                //    ds.Tables[4].Columns["paymentVoucherId"].ColumnName = "Receipt No";
                //    ds.Tables[4].Columns["accountName"].ColumnName = "Account Name";
                //    ds.Tables[4].Columns["drAmount"].ColumnName = "DR.Amount";
                //}
                //else
                //{
                    ds.Tables[0].TableName = "खरेदी माहिती";
                    ds.Tables[0].Columns["purchaseDate"].ColumnName = "दिनांक";
                    ds.Tables[0].Columns["purchaseInvoiceId"].ColumnName = "बिल नं";
                    ds.Tables[0].Columns["dealerFirmName"].ColumnName = "व्यापारीचे नांव";
                    ds.Tables[0].Columns["netBillAmount"].ColumnName = "बिल रक्कम";
                    ds.Tables[0].Columns["paidAmount"].ColumnName = "जमा रक्कम";
                    ds.Tables[1].TableName = "खरेदी परत माहिती";
                    ds.Tables[1].Columns["purchaseReutrnDate"].ColumnName = "दिनांक";
                    ds.Tables[1].Columns["purchaseReutrnInvoiceId"].ColumnName = "बिल नं";
                    ds.Tables[1].Columns["dealerFirmName"].ColumnName = "व्यापारीचे नांव";
                    ds.Tables[1].Columns["netBillAmount"].ColumnName = "बिल रक्कम";
                    ds.Tables[1].Columns["paidAmount"].ColumnName = "जमा रक्कम";
                    ds.Tables[2].TableName = "सेल माहिती";
                    ds.Tables[2].Columns["salesDate"].ColumnName = "दिनांक";
                    ds.Tables[2].Columns["salesInvoiceId"].ColumnName = "बिल नं";
                    ds.Tables[2].Columns["customerName"].ColumnName = "ग्राहकचे नांव";
                    ds.Tables[2].Columns["totalbillAmount"].ColumnName = "बिल रक्कम";
                    ds.Tables[2].Columns["paidAmount"].ColumnName = "जमा रक्कम";
                    ds.Tables[3].TableName = "जमा पावती माहिती";
                    ds.Tables[3].Columns["receiptDate"].ColumnName = "दिनांक";
                    ds.Tables[3].Columns["paymentReceiptId"].ColumnName = "जमा पावती नं";
                    ds.Tables[3].Columns["accountName"].ColumnName = "खात्याचे नांव";
                    ds.Tables[3].Columns["crAmount"].ColumnName = "जमा रक्कम";

                    ds.Tables[4].TableName = "नावे पावती माहिती";
                    ds.Tables[4].Columns["voucherDate"].ColumnName = "दिनांक";
                    ds.Tables[4].Columns["paymentVoucherId"].ColumnName = "नावे पावती नं";
                    ds.Tables[4].Columns["accountName"].ColumnName = "खात्याचे नांव";
                    ds.Tables[4].Columns["drAmount"].ColumnName = "नावे रक्कम";
              //  }
                DataTableCollection collection = ds.Tables;
                
                             for (int i = collection.Count; i > 0; i--)
                {
                    Sheets xlSheets = null;
                    Worksheet xlWorksheet = null;
                    //Create Excel Sheets
                    xlSheets = ExcelApp.Sheets;
                    xlWorksheet = (Worksheet)xlSheets.Add(xlSheets[1],
                                   Type.Missing, Type.Missing, Type.Missing);

                    System.Data.DataTable table = collection[i - 1];
                    xlWorksheet.Name = table.TableName;

                    for (int j = 1; j < table.Columns.Count + 1; j++)
                    {
                        ExcelApp.Cells[1, j] = table.Columns[j - 1].ColumnName;
                    }

                    // Storing Each row and column value to excel sheet
                    for (int k = 0; k < table.Rows.Count; k++)
                    {
                        for (int l = 0; l < table.Columns.Count; l++)
                        {
                            ExcelApp.Cells[k + 2, l + 1] =
                            table.Rows[k].ItemArray[l].ToString();
                        }
                    }
                    ExcelApp.Columns.AutoFit();
                }
                ((Worksheet)ExcelApp.ActiveWorkbook.Sheets[ExcelApp.ActiveWorkbook.Sheets.Count]).Delete();
                ExcelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }

        private void dgvPurchaseInvoice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvPurchaseInvoice.Rows)
                {
                    string RowType = row.Cells["dealerFirmName"].Value.ToString();
                    string RowType1 = row.Cells["dealerFirmName"].Value.ToString();
                    if (RowType == "एकून रक्कम")
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
                    }
                    if (RowType == "बाकी रक्कम")
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
                    }


                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dgvPurchaseReturn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvPurchaseReturn.Rows)
                {
                    string RowType = row.Cells["dealerFirmName1"].Value.ToString();
                    string RowType1 = row.Cells["dealerFirmName1"].Value.ToString();
                    if (RowType == "एकून रक्कम")
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
                    }
                    if (RowType == "बाकी रक्कम")
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
                    }


                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dgvSaleDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvSaleDetails.Rows)
                {
                    string RowType = row.Cells["customerName"].Value.ToString();
                    string RowType1 = row.Cells["customerName"].Value.ToString();
                    if (RowType == "एकून रक्कम")
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
                    }
                    if (RowType == "बाकी रक्कम")
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
                    }


                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dgvPaymentVoucher_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvPaymentVoucher.Rows)
                {
                    string RowType = row.Cells["accountName"].Value.ToString();

                    if (RowType == "एकूण रक्कम")
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
                    }
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dgvPaymentReceipt_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvPaymentReceipt.Rows)
                {
                    string RowType = row.Cells["accountName1"].Value.ToString();

                    if (RowType == "एकूण रक्कम")
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
                    }
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dgvSaleReturn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvSaleDetails.Rows)
                {
                    string RowType = row.Cells["customerName"].Value.ToString();
                    string RowType1 = row.Cells["customerName"].Value.ToString();
                    if (RowType == "एकून रक्कम")
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
                    }
                    if (RowType == "बाकी रक्कम")
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
                    }


                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmDayBookPrint rpt = new frmDayBookPrint(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()));
            rpt.ShowDialog();
            // System.Data.DataTable dt = dtPayRect();
            //DataRow dr = dt.NewRow();
            //dr["SaleCash"] = Convert.ToDouble(txtSalePaid.Text);
            //dr["SaleCredit"] = Convert.ToDouble(txtDueAmountS.Text);
            //dr["SaleReturnCash"] = Convert.ToDouble(txtSaleReturnCash.Text);
            //dr["SaleReturnCredit"] = Convert.ToDouble(txtSaleReturnCredit.Text);
            //dr["PurchaseCash"] = Convert.ToDouble(txtPaidTotalPurchase.Text);
            //dr["PurchaseCredit"] = Convert.ToDouble(txtDueAmountP.Text);
            //dr["PurchaseReturnCash"] = Convert.ToDouble(txtPaidPurchaseReturn.Text);
            //dr["PurchaseReturnCredit"] = Convert.ToDouble(txtDueAmountRP.Text);
            //dr["TotalCash"] = Convert.ToDouble(txtCashCredit.Text);
            //dr["TotalCredit"] = Convert.ToDouble(txtCashDebit.Text);
            //dr["Total"] = Convert.ToDouble(txtClosing.Text);
            //dt.Rows.Add(dr);
            //frmRDLCReport rpt=new frmRDLCReport();
            //DataSet ds = dayBookReportController.DayBookReport(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()));

            //ReportDataSource datasoure = new ReportDataSource("dtPurchaseDetails", ds.Tables[0]);
            //ReportDataSource datasoure1 = new ReportDataSource("dtPurchaseReturn", ds.Tables[1]);
            //ReportDataSource datasoure2 = new ReportDataSource("dtSaleDetails", ds.Tables[2]);
            //ReportDataSource datasoure3 = new ReportDataSource("dtSaleReturnDetails", ds.Tables[5]);
            //ReportDataSource datasoure4 = new ReportDataSource("dtPurchaseReciept", ds.Tables[3]);
            //ReportDataSource datasoure5 = new ReportDataSource("dtPurchaseVoucher", ds.Tables[4]);
            //ReportDataSource datasoure6 = new ReportDataSource("dtPayRec", ds.Tables[6]);
            //ReportDataSource datasoure7 = new ReportDataSource("dtTotal", dt);
            //rpt.reportViewer1.ProcessingMode = ProcessingMode.Local;
            //rpt.reportViewer1.LocalReport.ReportEmbeddedResource = "Dlogic_Wholesaler.CrystalReport.rptDayBook.rdlc";
            //ReportParameter[] parameters = new ReportParameter[2];
            //parameters[0] = new ReportParameter("fromDate", dtpFromDate.Value.ToString());
            //parameters[1] = new ReportParameter("toDate", dtpToDate.Value.ToString());
          
            //rpt.reportViewer1.LocalReport.SetParameters(parameters);         
            //rpt.reportViewer1.LocalReport.DataSources.Clear();
            //rpt.reportViewer1.LocalReport.DataSources.Add(datasoure);
            //rpt.reportViewer1.LocalReport.DataSources.Add(datasoure1);
            //rpt.reportViewer1.LocalReport.DataSources.Add(datasoure2);
            //rpt.reportViewer1.LocalReport.DataSources.Add(datasoure3);
            //rpt.reportViewer1.LocalReport.DataSources.Add(datasoure4);
            //rpt.reportViewer1.LocalReport.DataSources.Add(datasoure5);
            //rpt.reportViewer1.LocalReport.DataSources.Add(datasoure6);
            //rpt.reportViewer1.LocalReport.DataSources.Add(datasoure7);
            //rpt.ShowDialog();
        }
        public System.Data.DataTable dtPayRect()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
             dt.Columns.Add("SaleCash",typeof(double));
             dt.Columns.Add("SaleCredit",typeof(double));
             dt.Columns.Add("SaleReturnCash",typeof(double));
             dt.Columns.Add("SaleReturnCredit",typeof(double));
             dt.Columns.Add("PurchaseCash",typeof(double));
             dt.Columns.Add("PurchaseCredit",typeof(double));
             dt.Columns.Add("PurchaseReturnCash",typeof(double));
             dt.Columns.Add("PurchaseReturnCredit",typeof(double));
             dt.Columns.Add("TotalCash",typeof(double));
             dt.Columns.Add("TotalCredit",typeof(double));
             dt.Columns.Add("Total", typeof(double));
             return dt;

        }

        private void lblClosingBalance_Click(object sender, EventArgs e)
        {
            try
            {
                frmCashBookReport frm = new frmCashBookReport();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
