using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dlogic_Wholesaler.Forms;
using DataAccessLayer.controller;
using DataAccessLayer.models;
using MetroFramework.Forms;
using Dlogic_Wholesaler.ReportFrom;
using System.Configuration;
using Microsoft.Office.Interop.Excel;
namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class FrmAllPurchaseRetrun : MetroForm
    {
        public FrmAllPurchaseRetrun()
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
                    lblHerader.Text = "Purchase Return Book";
                    metroLabel3.Text = "To Date:";
                    metroLabel1.Text = "From Date:";
                    btnExcelConvert.Text = "Exel Report";
                    btnnew.Text = "Show";

                    dgvPurchaseItems.Columns[4].HeaderText = "Naration";
                    dgvPurchaseItems.Columns[5].HeaderText = "Batch No.";
                    dgvPurchaseItems.Columns[6].HeaderText = "Quantity";
                    dgvPurchaseItems.Columns[7].HeaderText = "freeQuantity";
                    dgvPurchaseItems.Columns[8].HeaderText = "Unit By";
                    dgvPurchaseItems.Columns[9].HeaderText = "Purchase Rate";
                    dgvPurchaseItems.Columns[10].HeaderText = "Sale Rate";
                    dgvPurchaseItems.Columns[11].HeaderText = "GST(%)";
                    dgvPurchaseItems.Columns[12].HeaderText = "GST Amt";
                    dgvPurchaseItems.Columns[13].HeaderText = "CGST(%)";
                    dgvPurchaseItems.Columns[14].HeaderText = "CGST Amt";
                    dgvPurchaseItems.Columns[15].HeaderText = "SGST(%)";
                    dgvPurchaseItems.Columns[16].HeaderText = "SGST Amt";
                    dgvPurchaseItems.Columns[17].HeaderText = "Discount";
                    dgvPurchaseItems.Columns[18].HeaderText = "Total Amount";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPurchaseReturnBook.DataSource = null;
                System.Data.DataTable lstPurchaseReturn = saleReportController.PurchaseReturnDayBook(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()),Utility.FinancilaYearId);

                if (lstPurchaseReturn.Rows.Count > 0)
                {
                    AddAutoIncrementColumn(lstPurchaseReturn);
                    System.Data.DataTable dtPurchaseReturnBook = SubTot(lstPurchaseReturn);
                    BindData(dtPurchaseReturnBook);
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
        public void AddAutoIncrementColumn(System.Data.DataTable dt)
        {
            try
            {
                DataColumn column = new DataColumn("SerialNo");
                column.DataType = System.Type.GetType("System.String");
                dt.Columns.Add(column);
                long index = 0;
                foreach (DataRow row in dt.Rows)
                {
                    ++index;
                    row.SetField(column, index.ToString());
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
        public System.Data.DataTable SubTot(System.Data.DataTable lstSaleBill)
        {
            try
            {
                Double totaltaxAmount = 0.0, totaldiscount = 0.0, toGSTAmt0 = 0.0, totalCGSTAmt2_5 = 0.0, totalSGSTAmt2_5 = 0.0,
                        totalCGSTAmt6 = 0.0, totalSGSTAmt6 = 0.0, totalCGSTAmt9 = 0.0, totalSGSTAmt9 = 0.0, totalCGSTAmt14 = 0.0,
                        totalSGSTAmt14 = 0.0, totalAmt = 0.0;
                for (int i = 0; i < lstSaleBill.Rows.Count; i++)
                {
                    totaltaxAmount += Convert.ToDouble(lstSaleBill.Rows[i]["TaxableAmount"].ToString());
                    totaldiscount += Convert.ToDouble(lstSaleBill.Rows[i]["discount"].ToString());
                    toGSTAmt0 += Convert.ToDouble(lstSaleBill.Rows[i]["IGSTAmt0"].ToString());
                    totalCGSTAmt2_5 += Convert.ToDouble(lstSaleBill.Rows[i]["CGSTAmt2_5"].ToString());
                    totalSGSTAmt2_5 += Convert.ToDouble(lstSaleBill.Rows[i]["SGSTAmt2_5"].ToString());
                    totalCGSTAmt6 += Convert.ToDouble(lstSaleBill.Rows[i]["CGSTAmt6"].ToString());
                    totalSGSTAmt6 += Convert.ToDouble(lstSaleBill.Rows[i]["SGSTAmt6"].ToString());
                    totalCGSTAmt9 += Convert.ToDouble(lstSaleBill.Rows[i]["CGSTAmt9"].ToString());
                    totalSGSTAmt9 += Convert.ToDouble(lstSaleBill.Rows[i]["SGSTAmt9"].ToString());
                    totalCGSTAmt14 += Convert.ToDouble(lstSaleBill.Rows[i]["CGSTAmt14"].ToString());
                    totalSGSTAmt14 += Convert.ToDouble(lstSaleBill.Rows[i]["SGSTAmt14"].ToString());
                    totalAmt += Convert.ToDouble(lstSaleBill.Rows[i]["TotalAmt"].ToString());
                }
                DataRow dr = lstSaleBill.NewRow();
                dr["SerialNo"] = " ";
                dr["dealerFirmName"] = "एकूण रक्कम";
                dr["TaxableAmount"] = Math.Round(totaltaxAmount, 2);
                dr["discount"] = Math.Round(totaldiscount, 2);
                dr["IGSTAmt0"] = Math.Round(toGSTAmt0, 2);
                dr["CGSTAmt2_5"] = Math.Round(totalCGSTAmt2_5, 2);
                dr["SGSTAmt2_5"] = Math.Round(totalSGSTAmt2_5, 2);
                dr["CGSTAmt6"] = Math.Round(totalCGSTAmt6, 2);
                dr["SGSTAmt6"] = Math.Round(totalSGSTAmt6, 2);
                dr["CGSTAmt9"] = Math.Round(totalCGSTAmt9, 2);
                dr["SGSTAmt9"] = Math.Round(totalSGSTAmt9, 2);
                dr["CGSTAmt14"] = Math.Round(totalCGSTAmt14, 2);
                dr["SGSTAmt14"] = Math.Round(totalSGSTAmt14, 2);
                dr["totalAmt"] = Math.Round(totalAmt, 2);
                lstSaleBill.Rows.Add(dr);
                return lstSaleBill;
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }
        public void BindData(System.Data.DataTable dtTable)
        {
            try
            {
                dgvPurchaseReturnBook.DataSource = null;
                dgvPurchaseReturnBook.AutoGenerateColumns = false;
                dgvPurchaseReturnBook.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvPurchaseReturnBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvPurchaseReturnBook.Font = new System.Drawing.Font("Arial Unicode MS", 12);
                dgvPurchaseReturnBook.EnableHeadersVisualStyles = false;
                dgvPurchaseReturnBook.ColumnCount = 18;

                dgvPurchaseReturnBook.Columns[0].Name = "SerialNo";
                dgvPurchaseReturnBook.Columns[0].HeaderText = "अ.क्र";
                dgvPurchaseReturnBook.Columns[0].DataPropertyName = "SerialNo";
                dgvPurchaseReturnBook.Columns[0].Width = 50;

                dgvPurchaseReturnBook.Columns[1].Name = "purchaseReutrnInvoiceId";
                dgvPurchaseReturnBook.Columns[1].HeaderText = "बिल नं";
                dgvPurchaseReturnBook.Columns[1].DataPropertyName = "purchaseReutrnInvoiceId";
                dgvPurchaseReturnBook.Columns[1].Width = 50;

                dgvPurchaseReturnBook.Columns[2].Name = "placeofsupplier";
                dgvPurchaseReturnBook.Columns[2].HeaderText = "खरेदी राज्य";
                dgvPurchaseReturnBook.Columns[2].DataPropertyName = "placeofsupplier";
                dgvPurchaseReturnBook.Columns[2].Width = 50;


                dgvPurchaseReturnBook.Columns[3].Name = "dealerFirmName";
                dgvPurchaseReturnBook.Columns[3].HeaderText = "व्यापारी नाव";
                dgvPurchaseReturnBook.Columns[3].DataPropertyName = "dealerFirmName";
                dgvPurchaseReturnBook.Columns[3].Width = 200;

                dgvPurchaseReturnBook.Columns[4].Name = "purchaseReutrnDate";
                dgvPurchaseReturnBook.Columns[4].HeaderText = "दिनांक";
                dgvPurchaseReturnBook.Columns[4].DataPropertyName = "purchaseReutrnDate";
                dgvPurchaseReturnBook.Columns[4].Width = 100;

                dgvPurchaseReturnBook.Columns[5].Name = "TaxableAmount";
                dgvPurchaseReturnBook.Columns[5].HeaderText = "कर रक्कम";
                dgvPurchaseReturnBook.Columns[5].DataPropertyName = "TaxableAmount";
                dgvPurchaseReturnBook.Columns[5].Width = 150;

                dgvPurchaseReturnBook.Columns[6].Name = "discount";
                dgvPurchaseReturnBook.Columns[6].HeaderText = "सवलत";
                dgvPurchaseReturnBook.Columns[6].DataPropertyName = "discount";
                dgvPurchaseReturnBook.Columns[6].Width = 60;
                dgvPurchaseReturnBook.Columns[6].Visible = false;

                dgvPurchaseReturnBook.Columns[7].Name = "IGSTAmt0";
                dgvPurchaseReturnBook.Columns[7].HeaderText = "GST(0%) रक्कम";
                dgvPurchaseReturnBook.Columns[7].DataPropertyName = "IGSTAmt0";
                dgvPurchaseReturnBook.Columns[7].Width = 100;
                dgvPurchaseReturnBook.Columns[7].Visible = false;

                dgvPurchaseReturnBook.Columns[8].Name = "CGSTAmt2_5";
                dgvPurchaseReturnBook.Columns[8].HeaderText = "CGST(2.5%) रक्कम";
                dgvPurchaseReturnBook.Columns[8].DataPropertyName = "CGSTAmt2_5";
                dgvPurchaseReturnBook.Columns[8].Width = 100;

                dgvPurchaseReturnBook.Columns[9].Name = "CGSTAmt2_5";
                dgvPurchaseReturnBook.Columns[9].HeaderText = "SGST(2.5%) रक्कम";
                dgvPurchaseReturnBook.Columns[9].DataPropertyName = "CGSTAmt2_5";
                dgvPurchaseReturnBook.Columns[9].Width = 100;

                dgvPurchaseReturnBook.Columns[10].Name = "CGSTAmt6";
                dgvPurchaseReturnBook.Columns[10].HeaderText = "CGST(6%) रक्कम";
                dgvPurchaseReturnBook.Columns[10].DataPropertyName = "CGSTAmt6";
                dgvPurchaseReturnBook.Columns[10].Width = 100;

                dgvPurchaseReturnBook.Columns[11].Name = "SGSTAmt6";
                dgvPurchaseReturnBook.Columns[11].HeaderText = "SGST(6%) रक्कम";
                dgvPurchaseReturnBook.Columns[11].DataPropertyName = "SGSTAmt6";
                dgvPurchaseReturnBook.Columns[11].Width = 100;

                dgvPurchaseReturnBook.Columns[12].Name = "CGSTAmt9";
                dgvPurchaseReturnBook.Columns[12].HeaderText = "CGST(9%) रक्कम";
                dgvPurchaseReturnBook.Columns[12].DataPropertyName = "CGSTAmt9";
                dgvPurchaseReturnBook.Columns[12].Width = 100;

                dgvPurchaseReturnBook.Columns[13].Name = "SGSTAmt9";
                dgvPurchaseReturnBook.Columns[13].HeaderText = "SGST(9%) रक्कम";
                dgvPurchaseReturnBook.Columns[13].DataPropertyName = "SGSTAmt9";
                dgvPurchaseReturnBook.Columns[13].Width = 100;

                dgvPurchaseReturnBook.Columns[14].Name = "CGSTAmt14";
                dgvPurchaseReturnBook.Columns[14].HeaderText = "CGST(14%) रक्कम";
                dgvPurchaseReturnBook.Columns[14].DataPropertyName = "CGSTAmt14";
                dgvPurchaseReturnBook.Columns[14].Width = 100;
                dgvPurchaseReturnBook.Columns[14].Visible = false;

                dgvPurchaseReturnBook.Columns[15].Name = "SGSTAmt14";
                dgvPurchaseReturnBook.Columns[15].HeaderText = "SGST(14%) रक्कम";
                dgvPurchaseReturnBook.Columns[15].DataPropertyName = "SGSTAmt14";
                dgvPurchaseReturnBook.Columns[15].Width = 100;
                dgvPurchaseReturnBook.Columns[15].Visible = false;

                dgvPurchaseReturnBook.Columns[16].Name = "TotalAmt";
                dgvPurchaseReturnBook.Columns[16].HeaderText = "एकूण रक्कम";
                dgvPurchaseReturnBook.Columns[16].DataPropertyName = "TotalAmt";
                dgvPurchaseReturnBook.Columns[16].Width = 150;

                dgvPurchaseReturnBook.Columns[17].Name = "purchaseReutrnId";
                dgvPurchaseReturnBook.Columns[17].HeaderText = "purchaseReutrnId";
                dgvPurchaseReturnBook.Columns[17].DataPropertyName = "purchaseReutrnId";
                dgvPurchaseReturnBook.Columns[17].Visible = false;

                dgvPurchaseReturnBook.DataSource = dtTable;
                dgvPurchaseReturnBook.Rows[dgvPurchaseReturnBook.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                dgvPurchaseReturnBook.Rows[dgvPurchaseReturnBook.Rows.Count - 1].DefaultCellStyle.Font = new System.Drawing.Font("Arial Unicode MS", 12, FontStyle.Bold);
                dgvPurchaseReturnBook.ClearSelection();
                foreach (DataGridViewColumn column in dgvPurchaseReturnBook.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }
        private void btnExcelConvert_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);



                Sheets xlSheets = null;
                Worksheet xlWorksheet = null;
                //Create Excel Sheets
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);
                System.Data.DataTable dat = (System.Data.DataTable)(dgvPurchaseReturnBook.DataSource);
                dat.TableName = "purchaseReturn Details";
                xlWorksheet.Name = dat.TableName;

                for (int j = 1; j < dat.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = dat.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < dat.Rows.Count; k++)
                {
                    for (int l = 0; l < dat.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        dat.Rows[k].ItemArray[l].ToString();
                    }
                }
                ExcelApp.Columns.AutoFit();

                ((Worksheet)ExcelApp.ActiveWorkbook.Sheets[ExcelApp.ActiveWorkbook.Sheets.Count]).Delete();
                ExcelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmAllPurchaseRetrun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvPurchaseReturnBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                long purchaseReutrnId = 0;
                if (e.RowIndex >= 0)
                {
                    purchaseReutrnId = Convert.ToInt64(dgvPurchaseReturnBook.CurrentRow.Cells["purchaseReutrnId"].Value);
                    dgvPurchaseItems.Visible = true;
                }
                System.Data.DataTable dtSaleChallen = saleReportController.getpurchaseReturnDetails(purchaseReutrnId,Utility.FinancilaYearId);
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                 foreach (DataRow dr in dtSaleChallen.Rows)
                 {
                     dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                     dgvPurchaseItems.CurrentRow.Cells["stockId"].Value = Convert.ToInt64(0);
                     dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                     dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToString(dr["categoryId"]);
                     dgvPurchaseItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                     dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = dr["batchNo"].ToString();
                     dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = Convert.ToDouble(dr["Quantity"]);
                     dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                     dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = 0;
                     dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Convert.ToString(dr["purchaseRate"]);
                     dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Convert.ToString(dr["salesCashRate"]);
                     dgvPurchaseItems.CurrentRow.Cells["discount"].Value = 0;
                     dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Convert.ToString(dr["IGST"]);
                     dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Convert.ToString(dr["CGST"]);
                     dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Convert.ToString(dr["SGST"]);
                     dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()),2);
                     //    double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())) / 100);
                     double purRate = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()))),2);
                         dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dr["CGST"].ToString()) * purRate / 100),2);
                         dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dr["SGST"].ToString()) * purRate / 100),2);
                         dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString()),2);
                    
                     dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString())),2).ToString();
                     dgvPurchaseItems.CurrentCell = dgvPurchaseItems.CurrentRow.Cells["Quantity"];
                     dgvPurchaseItems.BeginEdit(true);
                     int col = dgvPurchaseItems.CurrentCell.ColumnIndex;
                     int row = dgvPurchaseItems.CurrentCell.RowIndex;
                     col = 0;
                     row++;
                     if (dgvPurchaseItems.Rows.Count < dtSaleChallen.Rows.Count)
                     {
                         if (row == dgvPurchaseItems.RowCount)
                         {
                             dgvPurchaseItems.Rows.Add();
                             dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 7, row];
                         }
                     }
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmAllPurchaseRetrun_Load(object sender, EventArgs e)
        {
            dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
            dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpFromDate.Value = Utility.firstDate;
            dtpToDate.Value = Utility.lastDate;
            Lang();
        }
    }
}
