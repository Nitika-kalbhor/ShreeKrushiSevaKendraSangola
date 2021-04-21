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
namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class FrmSaleReturnBook : MetroForm
    {
        public FrmSaleReturnBook()
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
                    lblHerader.Text = "Sale Return Book";
                    metroLabel3.Text = "To Date:";
                    metroLabel1.Text = "From Date:";
                    btnExcelConvert.Text = "Exel Report";                  
                    btnnew.Text = "Show";

                    dgvSaleItems.Columns[4].HeaderText = "Naration";
                    dgvSaleItems.Columns[5].HeaderText = "Batch No.";                   
                    dgvSaleItems.Columns[6].HeaderText = "Quantity";
                    dgvSaleItems.Columns[7].HeaderText = "Unit By";                
                    dgvSaleItems.Columns[8].HeaderText = "Rate";
                    dgvSaleItems.Columns[9].HeaderText = "GST(%)";
                    dgvSaleItems.Columns[10].HeaderText = "GST Amt";
                    dgvSaleItems.Columns[11].HeaderText = "CGST(%)";
                    dgvSaleItems.Columns[12].HeaderText = "CGST Amt";
                    dgvSaleItems.Columns[13].HeaderText = "SGST(%)";
                    dgvSaleItems.Columns[14].HeaderText = "SGST Amt";
                    dgvSaleItems.Columns[15].HeaderText = "Discount";
                    dgvSaleItems.Columns[16].HeaderText = "Total Amount";
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
                dgvSaleReturn.DataSource = null;
                DataTable lstsaleRetrun = saleReportController.SaleReturnDayBook(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()),Utility.FinancilaYearId);

                if (lstsaleRetrun.Rows.Count > 0)
                {
                    AddAutoIncrementColumn(lstsaleRetrun);
                  //  DataTable dtSaleReturnBook = SubTot(lstsaleRetrun);
                   // BindData(dtSaleReturnBook);
                    BindDataNew(lstsaleRetrun);
                    dgvSaleItems.Rows.Clear();
                    dgvSaleItems.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable SubTot(DataTable lstSaleBill)
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
                lstSaleBill.Rows.Add(dr);
                return lstSaleBill;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void BindData(DataTable dtTable)
        {
            try
            {
                dgvSaleReturn.DataSource = null;
                dgvSaleReturn.AutoGenerateColumns = false;
                dgvSaleReturn.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvSaleReturn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSaleReturn.Font = new Font("Arial Unicode MS", 12);

                dgvSaleReturn.EnableHeadersVisualStyles = false;
                dgvSaleReturn.ColumnCount = 18;

                dgvSaleReturn.Columns[0].Name = "SerialNo";
                dgvSaleReturn.Columns[0].HeaderText = "अ.क्र.";
                dgvSaleReturn.Columns[0].DataPropertyName = "SerialNo";
                dgvSaleReturn.Columns[0].Width = 50;

                dgvSaleReturn.Columns[1].Name = "salesReturnInvoiceId";
                dgvSaleReturn.Columns[1].HeaderText = "बिल नं";
                dgvSaleReturn.Columns[1].DataPropertyName = "salesReturnInvoiceId";
                dgvSaleReturn.Columns[1].Width = 50;

                dgvSaleReturn.Columns[2].Name = "placeofsupplier";
                dgvSaleReturn.Columns[2].HeaderText = "विक्री राज्य";
                dgvSaleReturn.Columns[2].DataPropertyName = "placeofsupplier";
                dgvSaleReturn.Columns[2].Width = 50;

                dgvSaleReturn.Columns[3].Name = "customerName";
                dgvSaleReturn.Columns[3].HeaderText = "ग्राहकाचे नाव";
                dgvSaleReturn.Columns[3].DataPropertyName = "customerName";
                dgvSaleReturn.Columns[3].Width = 200;

                dgvSaleReturn.Columns[4].Name = "salesReturnDate";
                dgvSaleReturn.Columns[4].HeaderText = "दिनांक";
                dgvSaleReturn.Columns[4].DataPropertyName = "salesReturnDate";
                dgvSaleReturn.Columns[4].Width = 100;

                dgvSaleReturn.Columns[5].Name = "TaxableAmount";
                dgvSaleReturn.Columns[5].HeaderText = "कर रक्कम";
                dgvSaleReturn.Columns[5].DataPropertyName = "TaxableAmount";
                dgvSaleReturn.Columns[5].Width = 150;

                dgvSaleReturn.Columns[6].Name = "discount";
                dgvSaleReturn.Columns[6].HeaderText = "सवलत";
                dgvSaleReturn.Columns[6].DataPropertyName = "discount";
                dgvSaleReturn.Columns[6].Width = 60;
                dgvSaleReturn.Columns[6].Visible = false;

                dgvSaleReturn.Columns[7].Name = "IGSTAmt0";
                dgvSaleReturn.Columns[7].HeaderText = "GST(0%) रक्कम";
                dgvSaleReturn.Columns[7].DataPropertyName = "IGSTAmt0";
                dgvSaleReturn.Columns[7].Width = 100;
                dgvSaleReturn.Columns[7].Visible = false;

                dgvSaleReturn.Columns[8].Name = "CGSTAmt2_5";
                dgvSaleReturn.Columns[8].HeaderText = "CGST(2.5%) रक्कम";
                dgvSaleReturn.Columns[8].DataPropertyName = "CGSTAmt2_5";
                dgvSaleReturn.Columns[8].Width = 100;

                dgvSaleReturn.Columns[9].Name = "CGSTAmt2_5";
                dgvSaleReturn.Columns[9].HeaderText = "SGST(2.5%) रक्कम";
                dgvSaleReturn.Columns[9].DataPropertyName = "CGSTAmt2_5";
                dgvSaleReturn.Columns[9].Width = 100;

                dgvSaleReturn.Columns[10].Name = "CGSTAmt6";
                dgvSaleReturn.Columns[10].HeaderText = "CGST(6%) रक्कम";
                dgvSaleReturn.Columns[10].DataPropertyName = "CGSTAmt6";
                dgvSaleReturn.Columns[10].Width = 100;

                dgvSaleReturn.Columns[11].Name = "SGSTAmt6";
                dgvSaleReturn.Columns[11].HeaderText = "SGST(6%) रक्कम";
                dgvSaleReturn.Columns[11].DataPropertyName = "SGSTAmt6";
                dgvSaleReturn.Columns[11].Width = 100;

                dgvSaleReturn.Columns[12].Name = "CGSTAmt9";
                dgvSaleReturn.Columns[12].HeaderText = "CGST(9%) रक्कम";
                dgvSaleReturn.Columns[12].DataPropertyName = "CGSTAmt9";
                dgvSaleReturn.Columns[12].Width = 100;

                dgvSaleReturn.Columns[13].Name = "SGSTAmt9";
                dgvSaleReturn.Columns[13].HeaderText = "SGST(9%) रक्कम";
                dgvSaleReturn.Columns[13].DataPropertyName = "SGSTAmt9";
                dgvSaleReturn.Columns[13].Width = 100;

                dgvSaleReturn.Columns[14].Name = "CGSTAmt14";
                dgvSaleReturn.Columns[14].HeaderText = "CGST(14%) रक्कम";
                dgvSaleReturn.Columns[14].DataPropertyName = "CGSTAmt14";
                dgvSaleReturn.Columns[14].Width = 100;
                dgvSaleReturn.Columns[14].Visible = false;

                dgvSaleReturn.Columns[15].Name = "SGSTAmt14";
                dgvSaleReturn.Columns[15].HeaderText = "SGST(14%) रक्कम";
                dgvSaleReturn.Columns[15].DataPropertyName = "SGSTAmt14";
                dgvSaleReturn.Columns[15].Width = 100;
                dgvSaleReturn.Columns[15].Visible = false;

                dgvSaleReturn.Columns[16].Name = "TotalAmt";
                dgvSaleReturn.Columns[16].HeaderText = "एकूण रक्कम";
                dgvSaleReturn.Columns[16].DataPropertyName = "TotalAmt";
                dgvSaleReturn.Columns[16].Width = 150;
                dgvSaleReturn.Columns[17].Name = "salesReturnId";
                 dgvSaleReturn.Columns[17].HeaderText = "salesReturnId";
                dgvSaleReturn.Columns[17].DataPropertyName = "salesReturnId";
                dgvSaleReturn.Columns[17].Visible = false;
                dgvSaleReturn.DataSource = dtTable;
                dgvSaleReturn.Rows[dgvSaleReturn.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                dgvSaleReturn.Rows[dgvSaleReturn.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                dgvSaleReturn.ClearSelection();
                foreach (DataGridViewColumn column in dgvSaleReturn.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }


            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }

        }

        public void BindDataNew(DataTable dtTable)
        {
            try
            {
                dgvSaleReturn.DataSource = null;
                dgvSaleReturn.AutoGenerateColumns = false;
                dgvSaleReturn.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvSaleReturn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSaleReturn.Font = new Font("Arial Unicode MS", 12);
                dgvSaleReturn.EnableHeadersVisualStyles = false;
                dgvSaleReturn.ColumnCount = 31;
                dgvSaleReturn.Columns[0].Name = "SerialNo";
                dgvSaleReturn.Columns[0].HeaderText = "अ. क्र.";
                dgvSaleReturn.Columns[0].DataPropertyName = "SerialNo";
                dgvSaleReturn.Columns[0].Width = 50;

                dgvSaleReturn.Columns[1].Name = "salesReturnInvoiceId";
                dgvSaleReturn.Columns[1].HeaderText = "Bill No";
                dgvSaleReturn.Columns[1].DataPropertyName = "Bill No";
                dgvSaleReturn.Columns[1].Width = 100;

                dgvSaleReturn.Columns[2].Name = "salesDate";
                dgvSaleReturn.Columns[2].HeaderText = "Date";
                dgvSaleReturn.Columns[2].DataPropertyName = "Date";
                dgvSaleReturn.Columns[2].Width = 100;

                dgvSaleReturn.Columns[3].Name = "saleInvoiceNo";
                dgvSaleReturn.Columns[3].HeaderText = "Orignal Bill No";
                dgvSaleReturn.Columns[3].DataPropertyName = "Orignal Bill No";
                dgvSaleReturn.Columns[3].Width = 100;

                dgvSaleReturn.Columns[4].Name = "Sales Date";
                dgvSaleReturn.Columns[4].HeaderText = "Sales Date";
                dgvSaleReturn.Columns[4].DataPropertyName = "Sales Date";
                dgvSaleReturn.Columns[4].Width = 100;

                dgvSaleReturn.Columns[5].Name = "customerName";
                dgvSaleReturn.Columns[5].HeaderText = "Party";
                dgvSaleReturn.Columns[5].DataPropertyName = "Party";
                dgvSaleReturn.Columns[5].Width = 200;

                dgvSaleReturn.Columns[6].Name = "placeofsupplier";
                dgvSaleReturn.Columns[6].HeaderText = "Place of supply";
                dgvSaleReturn.Columns[6].DataPropertyName = "Place of supply";
                dgvSaleReturn.Columns[6].Width = 200;

                dgvSaleReturn.Columns[7].Name = "GST No";
                dgvSaleReturn.Columns[7].HeaderText = "GST No";
                dgvSaleReturn.Columns[7].DataPropertyName = "GST No";
                dgvSaleReturn.Columns[7].Width = 100;

                dgvSaleReturn.Columns[8].Name = "Bill Amt";
                dgvSaleReturn.Columns[8].HeaderText = "Bill Amt";
                dgvSaleReturn.Columns[8].DataPropertyName = "Bill Amt";
                dgvSaleReturn.Columns[8].Width = 150;

                dgvSaleReturn.Columns[9].Name = "discount";
                dgvSaleReturn.Columns[9].HeaderText = "discount";
                dgvSaleReturn.Columns[9].DataPropertyName = "discount";
                dgvSaleReturn.Columns[9].Width = 60;
                // dgvSaleReturn.Columns[7].Visible = false;

                dgvSaleReturn.Columns[10].Name = "0% Amt";
                dgvSaleReturn.Columns[10].HeaderText = "0% Amt";
                dgvSaleReturn.Columns[10].DataPropertyName = "0% Amt";

                dgvSaleReturn.Columns[11].Name = "5% Taxable Amt";
                dgvSaleReturn.Columns[11].HeaderText = "5% Taxable Amt";
                dgvSaleReturn.Columns[11].DataPropertyName = "5% Taxable Amt";
                dgvSaleReturn.Columns[11].Width = 100;
                //dgvSaleReturn.Columns[8].Visible = false;

                dgvSaleReturn.Columns[12].Name = "IGST 5%";
                dgvSaleReturn.Columns[12].HeaderText = "IGST 5%";
                dgvSaleReturn.Columns[12].DataPropertyName = "IGST 5%";
                dgvSaleReturn.Columns[12].Width = 100;

                dgvSaleReturn.Columns[13].Name = "CGST 2.5%";
                dgvSaleReturn.Columns[13].HeaderText = "CGST 2.5%";
                dgvSaleReturn.Columns[13].DataPropertyName = "CGST 2.5%";
                dgvSaleReturn.Columns[13].Width = 100;

                dgvSaleReturn.Columns[14].Name = "SGST 2.5%";
                dgvSaleReturn.Columns[14].HeaderText = "SGST 2.5%";
                dgvSaleReturn.Columns[14].DataPropertyName = "SGST 2.5%";
                dgvSaleReturn.Columns[14].Width = 100;

                dgvSaleReturn.Columns[15].Name = "12% Taxable Amt";
                dgvSaleReturn.Columns[15].HeaderText = "12% Taxable Amt";
                dgvSaleReturn.Columns[15].DataPropertyName = "12% Taxable Amt";
                dgvSaleReturn.Columns[15].Width = 100;

                dgvSaleReturn.Columns[16].Name = "IGST 12%";
                dgvSaleReturn.Columns[16].HeaderText = "IGST 12%";
                dgvSaleReturn.Columns[16].DataPropertyName = "IGST 12%";
                dgvSaleReturn.Columns[16].Width = 100;

                dgvSaleReturn.Columns[17].Name = "CGST 6%";
                dgvSaleReturn.Columns[17].HeaderText = "CGST 6%";
                dgvSaleReturn.Columns[17].DataPropertyName = "CGST 6%";
                dgvSaleReturn.Columns[17].Width = 100;

                dgvSaleReturn.Columns[18].Name = "SGST 6%";
                dgvSaleReturn.Columns[18].HeaderText = "SGST 6%";
                dgvSaleReturn.Columns[18].DataPropertyName = "SGST 6%";
                dgvSaleReturn.Columns[18].Width = 100;
                // dgvSaleReturn.Columns[15].Visible = false;

                dgvSaleReturn.Columns[19].Name = "18% Taxable Amt";
                dgvSaleReturn.Columns[19].HeaderText = "18% Taxable Amt";
                dgvSaleReturn.Columns[19].DataPropertyName = "18% Taxable Amt";
                dgvSaleReturn.Columns[19].Width = 100;
                // dgvSaleReturn.Columns[16].Visible = false;

                dgvSaleReturn.Columns[20].Name = "IGST 18%";
                dgvSaleReturn.Columns[20].HeaderText = "IGST 18%";
                dgvSaleReturn.Columns[20].DataPropertyName = "IGST 18%";
                dgvSaleReturn.Columns[20].Width = 150;

                dgvSaleReturn.Columns[21].Name = "CGST 9%";
                dgvSaleReturn.Columns[21].HeaderText = "CGST 9%";
                dgvSaleReturn.Columns[21].DataPropertyName = "CGST 9%";
                dgvSaleReturn.Columns[21].Width = 150;

                dgvSaleReturn.Columns[22].Name = "SGST 9%";
                dgvSaleReturn.Columns[22].HeaderText = "SGST 9%";
                dgvSaleReturn.Columns[22].DataPropertyName = "SGST 9%";

                dgvSaleReturn.Columns[23].Name = "28% Taxable Amt";
                dgvSaleReturn.Columns[23].HeaderText = "28% Taxable Amt";
                dgvSaleReturn.Columns[23].DataPropertyName = "28% Taxable Amt";

                dgvSaleReturn.Columns[24].Name = "IGST 28%";
                dgvSaleReturn.Columns[24].HeaderText = "IGST 28%";
                dgvSaleReturn.Columns[24].DataPropertyName = "IGST 28%";

                dgvSaleReturn.Columns[25].Name = "CGST 14%";
                dgvSaleReturn.Columns[25].HeaderText = "CGST 14%";
                dgvSaleReturn.Columns[25].DataPropertyName = "CGST 14%";

                dgvSaleReturn.Columns[26].Name = "SGST 14%";
                dgvSaleReturn.Columns[26].HeaderText = "SGST 14%";
                dgvSaleReturn.Columns[26].DataPropertyName = "SGST 14%";

                dgvSaleReturn.Columns[27].Name = "Total Taxable Amt";
                dgvSaleReturn.Columns[27].HeaderText = "Total Taxable Amt";
                dgvSaleReturn.Columns[27].DataPropertyName = "Total Taxable Amt";

                dgvSaleReturn.Columns[28].Name = "Total Tax Amt";
                dgvSaleReturn.Columns[28].HeaderText = "Total Tax Amt";
                dgvSaleReturn.Columns[28].DataPropertyName = "Total Tax Amt";

                dgvSaleReturn.Columns[29].Name = "Total Invoice Amt";
                dgvSaleReturn.Columns[29].HeaderText = "Total Invoice Amt";
                dgvSaleReturn.Columns[29].DataPropertyName = "Total Invoice Amt";

                dgvSaleReturn.Columns[30].Name = "saleId";
                dgvSaleReturn.Columns[30].HeaderText = "saleId";
                dgvSaleReturn.Columns[30].DataPropertyName = "saleId";
                dgvSaleReturn.Columns[30].Visible = false;
                dgvSaleReturn.DataSource = dtTable;
                dgvSaleReturn.Rows[dgvSaleReturn.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                dgvSaleReturn.Rows[dgvSaleReturn.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                dgvSaleReturn.ClearSelection();
                foreach (DataGridViewColumn column in dgvSaleReturn.Columns)
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
                System.Data.DataTable dat = (System.Data.DataTable)(dgvSaleReturn.DataSource);
                dat.TableName = "Sale Return Book";
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

        private void FrmSaleReturnBook_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSaleReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSaleReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                long salesReturnId = 0;
                if (e.RowIndex >= 0)
                {
                    salesReturnId = Convert.ToInt64(dgvSaleReturn.CurrentRow.Cells["saleId"].Value);
                    dgvSaleItems.Visible = true;
                }
                DataTable dtSaleChallen = saleReportController.getsaleReturnDetails(salesReturnId,Utility.FinancilaYearId);
                 dgvSaleItems.Rows.Clear();
                 dgvSaleItems.Rows.Add();
                 foreach (DataRow dr in dtSaleChallen.Rows)
                 {
                     dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                     dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(0);
                     dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                     dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                     dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                     dgvSaleItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                     dgvSaleItems.CurrentRow.Cells["Quantity"].Value = Convert.ToDouble(dr["quantity"]);
                     dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                     dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dr["perQtysalePrice"].ToString());
                     dgvSaleItems.CurrentRow.Cells["discount"].Value = 0;
                     dgvSaleItems.CurrentRow.Cells["IGST"].Value = Math.Round(Utility.ParseValue(dr["IGST"].ToString()), 2);
                     dgvSaleItems.CurrentRow.Cells["CGST"].Value = Math.Round(Utility.ParseValue(dr["CGST"].ToString()), 2);
                     dgvSaleItems.CurrentRow.Cells["SGST"].Value = Math.Round(Utility.ParseValue(dr["SGST"].ToString()), 2);

                     dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()));

                     double purRate = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())));
                     if (dgvSaleReturn.CurrentRow.Cells["placeofsupplier"].Value.ToString() != "27-Maharashtra")
                     {
                         dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Utility.ParseValue(dr["IGST"].ToString()) * purRate / 100), 2);
                     }
                     else
                     {
                         dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dr["CGST"].ToString()) * purRate / 100), 2);
                         dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dr["SGST"].ToString()) * purRate / 100), 2);
                         dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString()), 2);
                     }
                     dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()))).ToString();

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
                             dgvSaleItems.CurrentCell = dgvSaleItems[col + 7, row];
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

        private void FrmSaleReturnBook_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Utility.firstDate;
            dtpToDate.Value = Utility.lastDate;
            dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
            Lang();
        }
    }
}
