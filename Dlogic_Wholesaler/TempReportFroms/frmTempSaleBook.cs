using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using DataAccessLayer.controller;
using DataAccessLayer.models;
using Dlogic_Wholesaler.ReportFrom;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using Dlogic_Wholesaler.CrystalReport;
using System.Globalization;
using Dlogic_Wholesaler.Forms;

namespace Dlogic_Wholesaler.TempReportFroms
{
    public partial class frmTempSaleBook : MetroForm
    {
        public frmTempSaleBook()
        {
            InitializeComponent();
        
        }

        private void frmTempSaleBook_Load(object sender, EventArgs e)
        {
            try
            {
                rbtnCash.Checked = false;
                rbtnCredit.Checked = false;
                rdbAll.Checked = true;
                dtpFromDate.Value = Utility.firstDate;
                dtpToDate.Value = Utility.lastDate;
                dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
                dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSaleBook.DataSource = null;
                string opration = "";

              
                if (rdbAll.Checked == true)
                {
                    opration = "All";
                }
                string cashCredit = "";
                if (rbtnCash.Checked == true)
                {
                    opration = "AllCashCredit";
                    cashCredit = "Cash";
                }
                if (rbtnCredit.Checked == true)
                {
                    opration = "AllCashCredit";
                    cashCredit = "Credit";
                }
                DataTable lstSaleBill = TempSaleDetailsController.GetTempSaleBook(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, opration, cashCredit);
                if (lstSaleBill.Rows.Count > 0)
                {
                    AddAutoIncrementColumn(lstSaleBill);
                    // DataTable dtSaleBook = SubTot(lstSaleBill);
                    // BindData(dtSaleBook);
                    BindNewData(lstSaleBill);
                }
                dgvSaleItems.Rows.Clear();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
        public void AddAutoIncrementColumn(DataTable dt)
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
        public DataTable SubTot(DataTable lstSaleBill)
        {
            try
            {
                Double totaltaxAmount = 0.0, totaldiscount = 0.0, toGSTAmt0 = 0.0, totalCGSTAmt2_5 = 0.0, totalSGSTAmt2_5 = 0.0,
                        totalCGSTAmt6 = 0.0, totalSGSTAmt6 = 0.0, totalCGSTAmt9 = 0.0, totalSGSTAmt9 = 0.0, totalCGSTAmt14 = 0.0,
                        totalSGSTAmt14 = 0.0, totalAmt = 0.0, totalroundOff = 0.0, totalAllDiscount = 0.0;
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
                    totalroundOff += Convert.ToDouble(lstSaleBill.Rows[i]["roundOff"].ToString()); ;
                    totalAllDiscount += Convert.ToDouble(lstSaleBill.Rows[i]["hamali"].ToString()); ;
                }
                DataRow dr = lstSaleBill.NewRow();
                dr["SerialNo"] = "";
                dr["customerName"] = "एकूण रक्कम";
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
                dr["roundOff"] = Math.Round(totalroundOff, 2);
                dr["hamali"] = Math.Round(totalAllDiscount, 2);
                lstSaleBill.Rows.Add(dr);
                return lstSaleBill;
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }
   

        public void BindNewData(DataTable dtTable)
        {
            try
            {
                dgvSaleBook.DataSource = null;
                dgvSaleBook.AutoGenerateColumns = false;
                dgvSaleBook.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvSaleBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSaleBook.Font = new Font("Arial Unicode MS", 12);
                dgvSaleBook.EnableHeadersVisualStyles = false;
                dgvSaleBook.ColumnCount = 11;
                dgvSaleBook.Columns[0].Name = "SerialNo";
                dgvSaleBook.Columns[0].HeaderText = "अ. क्र.";
                dgvSaleBook.Columns[0].DataPropertyName = "SerialNo";
                dgvSaleBook.Columns[0].Width = 50;

                dgvSaleBook.Columns[1].Name = "salesInvoiceId";
                dgvSaleBook.Columns[1].HeaderText = "Bill No";
                dgvSaleBook.Columns[1].DataPropertyName = "Bill No";
                dgvSaleBook.Columns[1].Width = 100;

                dgvSaleBook.Columns[2].Name = "salesDate";
                dgvSaleBook.Columns[2].HeaderText = "Date";
                dgvSaleBook.Columns[2].DataPropertyName = "Date";
                dgvSaleBook.Columns[2].Width = 100;

                dgvSaleBook.Columns[3].Name = "customerName";
                dgvSaleBook.Columns[3].HeaderText = "Party";
                dgvSaleBook.Columns[3].DataPropertyName = "Party";
                dgvSaleBook.Columns[3].Width = 200;

                dgvSaleBook.Columns[4].Name = "placeofsupplier";
                dgvSaleBook.Columns[4].HeaderText = "Place of supply";
                dgvSaleBook.Columns[4].DataPropertyName = "Place of supply";
                dgvSaleBook.Columns[4].Width = 200;

                dgvSaleBook.Columns[5].Name = "GST No";
                dgvSaleBook.Columns[5].HeaderText = "GST No";
                dgvSaleBook.Columns[5].DataPropertyName = "GST No";
                dgvSaleBook.Columns[5].Width = 100;

                dgvSaleBook.Columns[6].Name = "Bill Amt";
                dgvSaleBook.Columns[6].HeaderText = "Bill Amt";
                dgvSaleBook.Columns[6].DataPropertyName = "Bill Amt";
                dgvSaleBook.Columns[6].Width = 150;

                dgvSaleBook.Columns[7].Name = "discount";
                dgvSaleBook.Columns[7].HeaderText = "discount";
                dgvSaleBook.Columns[7].DataPropertyName = "discount";
                dgvSaleBook.Columns[7].Width = 60;
                // dgvSaleBook.Columns[7].Visible = false;

                dgvSaleBook.Columns[8].Name = "Total Invoice Amt";
                dgvSaleBook.Columns[8].HeaderText = "Total Invoice Amt";
                dgvSaleBook.Columns[8].DataPropertyName = "Total Invoice Amt";

                dgvSaleBook.Columns[9].Name = "PaidAmount";
                dgvSaleBook.Columns[9].HeaderText = "Paid Amount";
                dgvSaleBook.Columns[9].DataPropertyName = "PaidAmount";

                dgvSaleBook.Columns[10].Name = "saleId";
                dgvSaleBook.Columns[10].HeaderText = "saleId";
                dgvSaleBook.Columns[10].DataPropertyName = "saleId";
                dgvSaleBook.Columns[10].Visible = false;
                dgvSaleBook.DataSource = dtTable;
                dgvSaleBook.Rows[dgvSaleBook.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                dgvSaleBook.Rows[dgvSaleBook.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                dgvSaleBook.ClearSelection();
                foreach (DataGridViewColumn column in dgvSaleBook.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }

        }

        private void dgvSaleBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataTable dtSaleChallen = TempSaleDetailsController.getTempSaleInvoice(dgvSaleBook.CurrentRow.Cells["salesInvoiceId"].Value.ToString(), Utility.FinancilaYearId);
                    dgvSaleItems.Rows.Clear();
                    dgvSaleItems.Rows.Add();
                    foreach (DataRow dr in dtSaleChallen.Rows)
                    {
                        dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                        dgvSaleItems.CurrentRow.Cells["salesItemDetailsId"].Value = Convert.ToInt64(dr["salesItemDetailsId"]);
                        dgvSaleItems.CurrentRow.Cells["itemName"].ReadOnly = true;
                        dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dr["StockId"]);
                        dgvSaleItems.CurrentRow.Cells["salesChallanId"].Value = 0;
                        dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                        dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                        dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                        dgvSaleItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                        dgvSaleItems.CurrentRow.Cells["HNSCode"].Value = dr["HNSCode"].ToString();
                        dgvSaleItems.CurrentRow.Cells["Quantity"].Value = dr["quantity"].ToString();
                        dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                        dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value = dr["MFD_Date"].ToString();
                        dgvSaleItems.CurrentRow.Cells["expireDate"].Value = dr["expireDate"].ToString();
                        dgvSaleItems.CurrentRow.Cells["currentstock1"].Value = 0;
                        dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = Convert.ToBoolean(dr["isPesticide"]);
                        dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = Convert.ToBoolean(dr["isFertilizer"]);
                        dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = Convert.ToBoolean(dr["isSeeds"]);
                        dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = Convert.ToBoolean(dr["isPGROthers"]);
                        dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = dr["invoiceNo"].ToString();
                    
                            dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dr["perQtysalePrice"].ToString());
                      
                            
                       
                        dgvSaleItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue(dr["discount"].ToString());
                        dgvSaleItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dr["IGST"].ToString());
                        dgvSaleItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dr["CGST"].ToString());
                        dgvSaleItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dr["SGST"].ToString());

                        double Discount = ((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()) / 100));
                        double saleRateWithDiscount = 0;
                        if (Discount > 0)
                        {
                            saleRateWithDiscount = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()) - Discount;
                        }
                        else
                        {
                            saleRateWithDiscount = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString());
                        }
                        dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value = Math.Round(saleRateWithDiscount + (saleRateWithDiscount * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) / 100), 2);

                        double purRate = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * saleRateWithDiscount);
                        dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100), 2);
                        dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100), 2);
                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100), 2);



                        dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dr["CGST"].ToString()) * purRate / 100), 2);
                        dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dr["SGST"].ToString()) * purRate / 100), 2);
                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value), 2);

                        // dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = purRate;
                        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString())), 2).ToString();

                        //  dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.CurrentRow.Cells["Quantity"];
                        dgvSaleItems.BeginEdit(true);
                        int col = dgvSaleItems.CurrentCell.ColumnIndex;
                        int row = dgvSaleItems.CurrentCell.RowIndex;
                        col = 0;
                        row++;
                        if (dgvSaleItems.Rows.Count < dtSaleChallen.Rows.Count)
                        {
                            if (row == dgvSaleItems.RowCount)
                            {
                                dgvSaleItems.Rows.Add();
                                dgvSaleItems.CurrentCell = dgvSaleItems[col + 5, row];
                            }
                            else
                            {
                                dgvSaleItems.CurrentCell = dgvSaleItems[col, row];
                            }
                        }
                    }
                }
                dgvSaleItems.ClearSelection();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
             //   System.Data.DataTable dat = (System.Data.DataTable)(dgvSaleBook.DataSource);
                DataTable dat = new DataTable();


                foreach (DataGridViewColumn col in dgvSaleBook.Columns)
                {
                    dat.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvSaleBook.Rows)
                {
                    DataRow dRow = dat.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                      
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dat.Rows.Add(dRow);
                }
                dat.TableName = "Sale Book 2";
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
    }
}
