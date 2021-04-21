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
namespace Dlogic_Wholesaler.TempReportFroms
{
    public partial class FrmTempPurchaseRetrunBook : MetroForm
    {
        public FrmTempPurchaseRetrunBook()
        {
            InitializeComponent();
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPurchaseReturnBook.DataSource = null;
                System.Data.DataTable lstPurchaseReturn = TempPurchaseReturnDetailsController.getPurchaseReturnList(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()),Utility.FinancilaYearId);

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
                    totalAmt += Convert.ToDouble(lstSaleBill.Rows[i]["TotalAmt"].ToString());
                }
                DataRow dr = lstSaleBill.NewRow();
                dr["SerialNo"] = " ";
                dr["dealerFirmName"] = "एकूण रक्कम";
                dr["TaxableAmount"] = Math.Round(totaltaxAmount, 2);
                dr["discount"] = Math.Round(totaldiscount, 2);
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

                dgvPurchaseReturnBook.Columns[2].Name = "dealerFirmName";
                dgvPurchaseReturnBook.Columns[2].HeaderText = "व्यापारी नाव";
                dgvPurchaseReturnBook.Columns[2].DataPropertyName = "dealerFirmName";
                dgvPurchaseReturnBook.Columns[2].Width = 200;

                dgvPurchaseReturnBook.Columns[3].Name = "purchaseReutrnDate";
                dgvPurchaseReturnBook.Columns[3].HeaderText = "दिनांक";
                dgvPurchaseReturnBook.Columns[3].DataPropertyName = "purchaseReutrnDate";
                dgvPurchaseReturnBook.Columns[3].Width = 100;

                dgvPurchaseReturnBook.Columns[4].Name = "TotalAmt";
                dgvPurchaseReturnBook.Columns[4].HeaderText = "एकूण रक्कम";
                dgvPurchaseReturnBook.Columns[4].DataPropertyName = "TotalAmt";
                dgvPurchaseReturnBook.Columns[4].Width = 150;

                dgvPurchaseReturnBook.Columns[5].Name = "purchaseReutrnId";
                dgvPurchaseReturnBook.Columns[5].HeaderText = "purchaseReutrnId";
                dgvPurchaseReturnBook.Columns[5].DataPropertyName = "purchaseReutrnId";
                dgvPurchaseReturnBook.Columns[5].Visible = false;

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
                System.Data.DataTable dtSaleChallen = TempPurchaseReturnDetailsController.getPurchaseReturnIvoiceDetails(purchaseReutrnId, Utility.FinancilaYearId);
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
                     dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()),2);
                     //    double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())) / 100);
                     double purRate = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()))),2);
                              
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
        }
    }
}
