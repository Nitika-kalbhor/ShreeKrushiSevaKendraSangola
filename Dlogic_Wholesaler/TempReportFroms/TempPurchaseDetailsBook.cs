using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DataAccessLayer.controller;
using DataAccessLayer.models;
using MetroFramework.Forms;
using Dlogic_Wholesaler.ReportFrom;
using System.Configuration;
using System.Windows.Forms;
namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class TempPurchaseDetailsBook : MetroForm
    {
        public TempPurchaseDetailsBook()
        {
            InitializeComponent();
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPurchaseBook.DataSource = null;
                string opration = "";
                if (rdbAll.Checked == true)
                {
                    opration = "All";
                }
                if (rbtnCash.Checked == true)
                {
                    opration = "Cash";
                }
                if (rbtnCredit.Checked == true)
                {
                    opration = "Credit";
                }
                DataTable lstSaleBill = TempPurchaseDetailsController.PurchaseDayBook(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), opration, Utility.FinancilaYearId);
                if (lstSaleBill.Rows.Count > 0)
                {

                    AddAutoIncrementColumn(lstSaleBill);
                    //  DataTable dtSaleBook = SubTot(lstSaleBill);
                    DataRow dr = lstSaleBill.NewRow();
                    dr["Bill Amount"] = billAMt;
                    dr["Total Taxable Amt"] = Math.Round(TotalTaxableAmt,2);
                    dr["Total Tax Amt"] =Math.Round( billAMt - TotalTaxableAmt);
                    dr["grossAmount"] = Math.Round(grossAmount);
                    lstSaleBill.Rows.Add(dr);
                    BindNewData(lstSaleBill);
                    dgvPurchaseItems.Rows.Clear();
                    dgvPurchaseItems.Visible = true;
                }
                else
                {
                    dgvPurchaseItems.Rows.Clear();
                    dgvPurchaseItems.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static double billAMt = 0;
        public static double taxable0 = 0;
        public static double Taxable5 = 0;
        public static double Taxable12 = 0;
        public static double Taxable18 = 0;
        public static double Taxable28 = 0;
        public static double IGSTAmt5 = 0;
        public static double CGSTAmt5 = 0;
        public static double SGSTAmt5 = 0;
        public static double IGSTAmt12 = 0;
        public static double CGSTAmt6 = 0;
        public static double SGSTAmt6 = 0;
        public static double IGSTAmt18 = 0;
        public static double CGSTAmt9 = 0;
        public static double SGSTAmt9 = 0;
        public static double IGSTAmt28 = 0;
        public static double CGSTAmt14 = 0;
        public static double SGSTAmt14 = 0;

     
        public static double TotalTaxableAmt = 0;
        public static double grossAmount = 0;
        public void AddAutoIncrementColumn(DataTable dt)
        {
            try
            {
                DataColumn column = new DataColumn("SerialNo");
                column.DataType = System.Type.GetType("System.String");
                dt.Columns.Add(column);
                long index = 0;
                billAMt = 0; taxable0 = 0;Taxable5 = 0; Taxable12 = 0; Taxable18 = 0;Taxable28 = 0;IGSTAmt5 = 0;CGSTAmt5 = 0;SGSTAmt5 = 0;IGSTAmt12 = 0;CGSTAmt6 = 0; SGSTAmt6 = 0;
                TotalTaxableAmt = 0; grossAmount = 0;
                IGSTAmt18 = 0; CGSTAmt9 = 0;SGSTAmt9 = 0;IGSTAmt28 = 0;CGSTAmt14 = 0;   SGSTAmt14 = 0;
                foreach (DataRow row in dt.Rows)
                {
                    ++index;
                    row.SetField(column, index.ToString());

                    if (row["Bill Amount"] != DBNull.Value)
                        billAMt += Convert.ToDouble(row["Bill Amount"]);
                    if (row["Total Taxable Amt"] != DBNull.Value)
                        TotalTaxableAmt += Convert.ToDouble(row["Total Taxable Amt"]);
                    if (row["grossAmount"] != DBNull.Value)
                        grossAmount += Convert.ToDouble(row["grossAmount"]);
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public DataTable SubTot(DataTable lstSaleBill)
        {
            Double totaltaxAmount = 0.0, totaldiscount = 0.0, totalAmt = 0.0;
            for (int i = 0; i < lstSaleBill.Rows.Count; i++)
            {
                totaltaxAmount += Convert.ToDouble(lstSaleBill.Rows[i]["TaxableAmount"].ToString());
                totaldiscount += Convert.ToDouble(lstSaleBill.Rows[i]["discount"].ToString());
              
                totalAmt += Convert.ToDouble(lstSaleBill.Rows[i]["TotalAmt"].ToString());
            }
            DataRow dr = lstSaleBill.NewRow();
            dr["SerialNo"] = " ";
            dr["dealerFirmName"] = "एकूण रक्कम";
            dr["TaxableAmount"] = Math.Round(totaltaxAmount, 2);
            dr["discount"] = Math.Round(totaldiscount, 2);
            dr["totalAmt"] = Math.Round(totalAmt, 2);
            dr["purchaseId"] = 0;
            lstSaleBill.Rows.Add(dr);
            return lstSaleBill;

        }
     
        public void BindNewData(DataTable dtTable)
        {
            try
            {
                dgvPurchaseBook.DataSource = null;
                dgvPurchaseBook.AutoGenerateColumns = false;
                dgvPurchaseBook.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvPurchaseBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvPurchaseBook.Font = new Font("Arial Unicode MS", 12);
                dgvPurchaseBook.EnableHeadersVisualStyles = false;
                dgvPurchaseBook.ColumnCount = 9;
                dgvPurchaseBook.Columns[0].Name = "SerialNo";
                dgvPurchaseBook.Columns[0].HeaderText = "अ. क्र.";
                dgvPurchaseBook.Columns[0].DataPropertyName = "SerialNo";
                dgvPurchaseBook.Columns[0].Width = 50;

                dgvPurchaseBook.Columns[1].Name = "InvoiceNo";
                dgvPurchaseBook.Columns[1].HeaderText = "Invoice No";
                dgvPurchaseBook.Columns[1].DataPropertyName = "Invoice No";
                dgvPurchaseBook.Columns[1].Width = 100;

                dgvPurchaseBook.Columns[2].Name = "PurchaseDate";
                dgvPurchaseBook.Columns[2].HeaderText = "Purchase Date";
                dgvPurchaseBook.Columns[2].DataPropertyName = "Purchase Date";
                dgvPurchaseBook.Columns[2].Width = 100;

                dgvPurchaseBook.Columns[3].Name = "customerName";
                dgvPurchaseBook.Columns[3].HeaderText = "Party";
                dgvPurchaseBook.Columns[3].DataPropertyName = "Party";
                dgvPurchaseBook.Columns[3].Width = 200;

                dgvPurchaseBook.Columns[4].Name = "placeofsupplier";
                dgvPurchaseBook.Columns[4].HeaderText = "Place of supply";
                dgvPurchaseBook.Columns[4].DataPropertyName = "Place of supply";
                dgvPurchaseBook.Columns[4].Width = 200;

                dgvPurchaseBook.Columns[5].Name = "Bill Amt";
                dgvPurchaseBook.Columns[5].HeaderText = "Bill Amount";
                dgvPurchaseBook.Columns[5].DataPropertyName = "Bill Amount";
                dgvPurchaseBook.Columns[5].Width = 150;

                dgvPurchaseBook.Columns[6].Name = "discount";
                dgvPurchaseBook.Columns[6].HeaderText = "discount";
                dgvPurchaseBook.Columns[6].DataPropertyName = "discount";
                dgvPurchaseBook.Columns[6].Width = 60;
                // dgvPurchaseBook.Columns[7].Visible = false;

                dgvPurchaseBook.Columns[7].Name = "Total Invoice Amt";
                dgvPurchaseBook.Columns[7].HeaderText = "Total Invoice Amt";
                dgvPurchaseBook.Columns[7].DataPropertyName = "Total Invoice Amt";

                dgvPurchaseBook.Columns[8].Name = "purchaseId";
                dgvPurchaseBook.Columns[8].HeaderText = "purchaseId";
                dgvPurchaseBook.Columns[8].DataPropertyName = "purchaseId";
                dgvPurchaseBook.Columns[8].Visible = false;
                dgvPurchaseBook.DataSource = dtTable;
                dgvPurchaseBook.Rows[dgvPurchaseBook.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                dgvPurchaseBook.Rows[dgvPurchaseBook.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                dgvPurchaseBook.ClearSelection();
                foreach (DataGridViewColumn column in dgvPurchaseBook.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }

        }
        private void btnExcelConvert_Click(object sender, EventArgs e)
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
                System.Data.DataTable dat = (System.Data.DataTable)(dgvPurchaseBook.DataSource);
                dat.TableName = "purchase Book";
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

                ((Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.ActiveWorkbook.Sheets[ExcelApp.ActiveWorkbook.Sheets.Count]).Delete();
                ExcelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AllPurchaseDetails_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPurchaseBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                long purchaseId = 0;
                if (e.RowIndex >= 0)
                {

                    purchaseId = Convert.ToInt64(dgvPurchaseBook.CurrentRow.Cells["purchaseId"].Value);
                }
                DataTable dtSaleChallen = TempPurchaseDetailsController.getPurchaseIvoiceDetails(purchaseId, Utility.FinancilaYearId);
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                foreach (DataRow dr in dtSaleChallen.Rows)
                {
                    dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                    dgvPurchaseItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(0);
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                    dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseItemDetailId"].Value = Convert.ToInt32(dr["purchaseItemDetailId"]);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseChalanId"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                    dgvPurchaseItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["rackNo"].Value = dr["rackNo"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["productCode"].Value = dr["productCode"].ToString();
                    //dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["MRP"].Value = dr["MRP"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = dr["Quantity"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value = dr["MFD_Date"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value = dr["expireDate"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = dr["discount"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["discountPer"].Value = dr["discountPer"].ToString();
                     dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = Utility.ParseValue(dr["freeQuantity"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dr["salesCashRate"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dr["purchaseRate"].ToString()) + ((Utility.ParseValue(dr["purchaseRate"].ToString()) * Utility.ParseValue(dr["IGST"].ToString())) / 100), 2);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dr["purchaseRate"].ToString());
                    double Discount = ((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discountPer"].Value.ToString()) / 100)) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString());
                    if (Discount > 0)
                    {
                        dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) - Discount;
                    }
                    else
                    {
                        dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                    } dgvPurchaseItems.CurrentRow.Cells["TaxableAmount"].Value = Math.Round((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value.ToString())) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString()), 2);
                    //  dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());

                    //double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value)) / 100);
                    double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString())));
                    
                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString())).ToString();

                    //  dgvPurchaseItems.Focus();
                    //   dgvPurchaseItems.CurrentCell = dgvPurchaseItems.CurrentRow.Cells["Quantity"];
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
                dgvPurchaseItems.ClearSelection();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAll.Checked == true)
            {
                rbtnCash.Checked = false;
                rbtnCredit.Checked = false;
            }
            dgvPurchaseBook.DataSource = null;
        }

        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCash.Checked == true)
            {
                rbtnCredit.Checked = false;
                rdbAll.Checked = false;
            }
            dgvPurchaseBook.DataSource = null;
        }

        private void rbtnCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCash.Checked == true)
            {
                rbtnCredit.Checked = false;
                rdbAll.Checked = false;
            }
            dgvPurchaseBook.DataSource = null;
        }

        private void AllPurchaseDetails_Load(object sender, EventArgs e)
        {
            rdbAll.Checked = true;
            rbtnCash.Checked = false;
            rbtnCredit.Checked = false;

            dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
            dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpFromDate.Value = Utility.firstDate;
            dtpToDate.Value = Utility.lastDate;
        }

        private void dgvPurchaseBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
