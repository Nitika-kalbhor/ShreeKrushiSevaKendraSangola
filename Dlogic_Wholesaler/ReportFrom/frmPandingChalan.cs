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
    public partial class frmPandingChalan : MetroForm
    {
        public frmPandingChalan()
        {
            InitializeComponent();
        }
        int type = 0;
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Chalan Report";
                    metroLabel3.Text = "To Date:";
                    metroLabel1.Text = "From Date:";
                    btnPrint.Text = "Exel Report";
                    btnShow.Text = "Show";
                    rbCustomer.Text = "Customer";
                    rbDealer.Text = "Dealer";
                    metroLabel2.Text = "Account Name";

                    dgvSaleItems.Columns[4].HeaderText = "Naration";
                    dgvSaleItems.Columns[5].HeaderText = "Unit By";
                    dgvSaleItems.Columns[6].HeaderText = "HSNCode";
                    dgvSaleItems.Columns[7].HeaderText = "Batch No";
                    dgvSaleItems.Columns[8].HeaderText = "Quantity";
                    dgvSaleItems.Columns[9].HeaderText = "Rate";
                    dgvSaleItems.Columns[10].HeaderText = "GST(%)";
                    dgvSaleItems.Columns[11].HeaderText = "GST Amt";
                    dgvSaleItems.Columns[12].HeaderText = "CGST(%)";
                    dgvSaleItems.Columns[13].HeaderText = "CGST Amt";
                    dgvSaleItems.Columns[14].HeaderText = "SGST(%)";
                    dgvSaleItems.Columns[15].HeaderText = "SGST Amt";
                    dgvSaleItems.Columns[16].HeaderText = "Discount";
                    dgvSaleItems.Columns[17].HeaderText = "Total Amount";

                   dgvPurchaseItems.Columns[4].HeaderText = "Naration";
                   dgvPurchaseItems.Columns[5].HeaderText = "Unit By";
                    dgvPurchaseItems.Columns[6].HeaderText = "Batch No.";
                    dgvPurchaseItems.Columns[7].HeaderText = "MFG Date";
                    dgvPurchaseItems.Columns[8].HeaderText = "Expiry Date";
                    dgvPurchaseItems.Columns[9].HeaderText = "Quantity";                  
                    dgvPurchaseItems.Columns[10].HeaderText = "freeQuantity";                   
                    dgvPurchaseItems.Columns[11].HeaderText = "Pur.Rate(With GST)";
                    dgvPurchaseItems.Columns[12].HeaderText = "Pur.Rate";
                    dgvPurchaseItems.Columns[13].HeaderText = "MRP";                               
                     dgvPurchaseItems.Columns[14].HeaderText = "Sale Rate";
                    dgvPurchaseItems.Columns[15].HeaderText = "GST(%)";
                    dgvPurchaseItems.Columns[16].HeaderText = "GST Amt";
                    dgvPurchaseItems.Columns[17].HeaderText = "CGST(%)";
                    dgvPurchaseItems.Columns[18].HeaderText = "CGST Amt";
                    dgvPurchaseItems.Columns[19].HeaderText = "SGST(%)";
                    dgvPurchaseItems.Columns[20].HeaderText = "SGST Amt";
                    dgvPurchaseItems.Columns[21].HeaderText = "Discount";
                    dgvPurchaseItems.Columns[22].HeaderText = "Total Amount";                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmPandingChalan_Load(object sender, EventArgs e)
        {
            dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
            dtpFromDate.Value = Utility.firstDate;
            dtpToDate.Value = Utility.lastDate;
            Lang();
        }
        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCustomer.Checked)
                {
                    rbDealer.Checked = false;
                    type = 1;
                    DataTable dtaccountName = accountLedgerReportController.getAccountNamePaymentDue(type);
                    Utility.BindComboBoxDataSelect(cmbAccountName, dtaccountName, "accountId", "accountName");
                    DataTable dtAccountLedgerReport = null;
                    dgvPurchaseItems.Visible = false;
                    dgvSaleItems.Visible = false;
                    dgvSaleItems.Rows.Clear();
                    dgvPurchaseItems.Rows.Clear();
                   // BindCustomerGrid(dtAccountLedgerReport);
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void rbDealer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbDealer.Checked)
                {
                    rbCustomer.Checked = false;
                    type = 2;
                    DataTable dtaccountName = accountLedgerReportController.getAccountNamePaymentDue(type);
                    Utility.BindComboBoxDataSelect(cmbAccountName, dtaccountName, "accountId", "accountName");
                    DataTable dtAccountLedgerReport = null;
                    dgvPurchaseItems.Visible = false;
                    dgvSaleItems.Visible = false;
                    dgvSaleItems.Rows.Clear();
                    dgvPurchaseItems.Rows.Clear();
                 //   BindCustomerGrid(dtAccountLedgerReport);
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void frmPandingChalan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbCustomer.Checked == false && rbDealer.Checked == false)
                {
                    MessageBox.Show("कृपया ग्राहक किंवा व्यापारी निवडा..");
                    return;
                }
                int type = 0;
                if (rbCustomer.Checked == true)
                {
                    type = 1;
                }
                else
                {
                    type = 2;
                }
                DataTable dtAccountLedgerReport = stockController.getpendingChalanDetails(Convert.ToInt64(cmbAccountName.SelectedValue), Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()),Utility.FinancilaYearId, type);
               // dgvPandingChalan.DataSource = dtAccountLedgerReport;
                dgvPurchaseItems.Visible = false;
                dgvSaleItems.Visible = false;
                dgvSaleItems.Rows.Clear();
                dgvPurchaseItems.Rows.Clear();
                bindGrid(dtAccountLedgerReport);
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }
        public void bindGrid(DataTable dtAccountLedgerReport)
        {
            try
            {
                 dgvPandingChalan.DataSource = null;
                dgvPandingChalan.AutoGenerateColumns = false;
                dgvPandingChalan.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvPandingChalan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvPandingChalan.Font = new Font("Arial Unicode MS", 11);
                dgvPandingChalan.EnableHeadersVisualStyles = false;
                dgvPandingChalan.ColumnCount = 6;

                if(Utility.Langn=="English")
                {
                    dgvPandingChalan.Columns[1].HeaderText = "Chalan No.";
                    dgvPandingChalan.Columns[2].HeaderText = "Date";                   
                    dgvPandingChalan.Columns[4].HeaderText = "Total Amount";
                    dgvPandingChalan.Columns[5].HeaderText = "Other Charges";
                    if (rbCustomer.Checked == true)
                    {
                        dgvPandingChalan.Columns[3].HeaderText = "Customer Name";
                    }
                    if (rbDealer.Checked == true)
                    {
                        dgvPandingChalan.Columns[3].HeaderText = "Dealer Name";
                    }
                }
                else
                {
                    dgvPandingChalan.Columns[1].HeaderText = "चलन नं";
                    dgvPandingChalan.Columns[2].HeaderText = "दिनांक";
                    dgvPandingChalan.Columns[3].HeaderText = "ग्राहकाचे नाव";
                    dgvPandingChalan.Columns[4].HeaderText = "एकूण रक्कम";
                    dgvPandingChalan.Columns[5].HeaderText = "इतर रक्कम";
                    if (rbCustomer.Checked == true)
                    {
                        dgvPandingChalan.Columns[3].HeaderText = "ग्राहकाचे नाव";
                    }
                    if (rbDealer.Checked == true)
                    {
                        dgvPandingChalan.Columns[3].HeaderText = "व्यापाऱ्याचे नाव";
                    }
                }

                dgvPandingChalan.Columns[0].Name = "salesChallanId";
                dgvPandingChalan.Columns[0].HeaderText = "salesChallanId";
                dgvPandingChalan.Columns[0].DataPropertyName = "salesChallanId";
                dgvPandingChalan.Columns[0].Width = 400;
                dgvPandingChalan.Columns[0].Visible = false;

                   dgvPandingChalan.Columns[1].Name = "SalesChallanBillId";                
                    dgvPandingChalan.Columns[1].DataPropertyName = "SalesChallanBillId";
                    dgvPandingChalan.Columns[1].Width = 150;

                   dgvPandingChalan.Columns[2].Name = "SalesChallanDate";                   
                    dgvPandingChalan.Columns[2].DataPropertyName = "SalesChallanDate";
                    dgvPandingChalan.Columns[2].Width = 150;

                   dgvPandingChalan.Columns[3].Name = "customerName";                    
                    dgvPandingChalan.Columns[3].DataPropertyName = "customerName";
                    dgvPandingChalan.Columns[3].Width = 300;

                   dgvPandingChalan.Columns[4].Name = "totalSalesChallanAmount";                   
                    dgvPandingChalan.Columns[4].DataPropertyName = "totalSalesChallanAmount";
                    dgvPandingChalan.Columns[4].Width = 200;

                   dgvPandingChalan.Columns[5].Name = "othercharges";                   
                    dgvPandingChalan.Columns[5].DataPropertyName = "othercharges";
                    dgvPandingChalan.Columns[5].Width = 200;
              
                 dgvPandingChalan.DataSource = dtAccountLedgerReport;

            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void dgvPandingChalan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {
                dgvPurchaseItems.Enabled = true;
                  DataTable dtSaleChallen=new DataTable();
                if (rbCustomer.Checked == true)
                {
                    dtSaleChallen = SaleDetailsController.getSaleChallenDetails(Convert.ToInt64(dgvPandingChalan.CurrentRow.Cells["SalesChallanBillId"].Value), Utility.FinancilaYearId);
                    dgvPurchaseItems.Visible = false;
                    dgvSaleItems.Visible = true;
                    bindSaleItemDetails(dtSaleChallen);
                }
                if (rbDealer.Checked == true)
                {
                    dtSaleChallen = purchaseDetailsController.getSaleChallenDetails(Convert.ToInt64(dgvPandingChalan.CurrentRow.Cells["salesChallanId"].Value),Utility.FinancilaYearId);
                    dgvPurchaseItems.Visible = true;
                    dgvSaleItems.Visible = false;
                    bindPurchaseItemDetails(dtSaleChallen);
                }
                dgvPurchaseItems.ClearSelection();
                dgvSaleItems.ClearSelection();
            }
        }
        public void bindPurchaseItemDetails(DataTable dtSaleChallen)
        {
            dgvPurchaseItems.Rows.Clear();
            dgvPurchaseItems.Rows.Add();
            foreach (DataRow dr in dtSaleChallen.Rows)
            {
                dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                dgvPurchaseItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(0);
                dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value = Convert.ToString(dr["mfgDate"]);
                dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value = Convert.ToString(dr["expireDate"]);
                dgvPurchaseItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                //dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                dgvPurchaseItems.CurrentRow.Cells["MRP"].Value = dr["MRP"].ToString();
                dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = dr["Quantity"].ToString();
                dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                dgvPurchaseItems.CurrentRow.Cells["discount"].Value = 0;
                dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dr["IGST"].ToString());
                dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dr["CGST"].ToString());
                dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dr["SGST"].ToString());
                dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = Utility.ParseValue(dr["freeQuantity"].ToString());
                dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dr["salesCashRate"].ToString());

                dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dr["purchaseRate"].ToString());
                dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dr["purchaseRate"].ToString()) + ((Utility.ParseValue(dr["purchaseRate"].ToString()) * Utility.ParseValue(dr["IGST"].ToString())) / 100));
                dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString())) * Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());

                double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())) / 100);
                double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())));
                dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100);
                dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100);
                dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100);
                dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString())) - Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()));
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
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 4, row];
                    }
                }
            }
        }
        public void bindSaleItemDetails(DataTable dtSaleChallen)
        {
            dgvSaleItems.Rows.Clear();
            dgvSaleItems.Rows.Add();
            dgvSaleItems.Enabled = true;
            foreach (DataRow dr in dtSaleChallen.Rows)
            {
                dgvSaleItems.CurrentRow.Cells["itemId1"].Value = Convert.ToInt64(dr["itemId"]);
                dgvSaleItems.CurrentRow.Cells["StockId1"].Value = Convert.ToInt64(0);
                dgvSaleItems.CurrentRow.Cells["categoryId1"].Value = Convert.ToInt32(dr["categoryId"]);
                dgvSaleItems.CurrentRow.Cells["companyId1"].Value = Convert.ToInt32(dr["companyId"]);
                dgvSaleItems.CurrentRow.Cells["batchNo1"].Value = Convert.ToString(dr["batchNo"]);
                dgvSaleItems.CurrentRow.Cells["itemName1"].Value = dr["itemName"].ToString();
                dgvSaleItems.CurrentRow.Cells["HSNCode1"].Value = dr["HNSCode"].ToString();
                dgvSaleItems.CurrentRow.Cells["Quantity1"].Value = dr["quantity"].ToString();
                dgvSaleItems.CurrentRow.Cells["unitBy1"].Value = dr["unitBy"].ToString();
                dgvSaleItems.CurrentRow.Cells["Rate1"].Value = Math.Round(Utility.ParseValue(dr["perQtysalePrice"].ToString()), 2);
                dgvSaleItems.CurrentRow.Cells["discount1"].Value = 0;
                dgvSaleItems.CurrentRow.Cells["IGST1"].Value = Utility.ParseValue(dr["IGST"].ToString());
                dgvSaleItems.CurrentRow.Cells["CGST1"].Value = Utility.ParseValue(dr["CGST"].ToString());
                dgvSaleItems.CurrentRow.Cells["SGST1"].Value = Utility.ParseValue(dr["SGST"].ToString());

                dgvSaleItems.CurrentRow.Cells["totalAmount1"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity1"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate1"].Value.ToString()), 2);

                double discount = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount1"].Value.ToString()) * (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate1"].Value.ToString())) / 100);
                double purRate = Math.Round(Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity1"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate1"].Value.ToString())), 2);
                dgvSaleItems.CurrentRow.Cells["SGSTAmt1"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST1"].Value.ToString()) * purRate / 100), 2);
                dgvSaleItems.CurrentRow.Cells["CGSTAmt1"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST1"].Value.ToString()) * purRate / 100), 2);
                dgvSaleItems.CurrentRow.Cells["IGSTAmt1"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST1"].Value.ToString()) * purRate / 100), 2);

                dgvSaleItems.CurrentRow.Cells["totalAmount1"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt1"].Value.ToString()) - Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount1"].Value.ToString())), 2).ToString();

                dgvSaleItems.CurrentCell = dgvSaleItems.CurrentRow.Cells["Quantity1"];
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
                        dgvSaleItems.CurrentCell = dgvSaleItems[col + 4, row];
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                // Loop over DataTables in DataSet.
                System.Data.DataTable ds = new DataTable();
                foreach (DataGridViewColumn col in dgvPandingChalan.Columns)
                {
                    ds.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvPandingChalan.Rows)
                {
                    DataRow dRow = ds.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    ds.Rows.Add(dRow);
                }
                ds.Columns.Remove("salesChallanId");
                if(rbDealer.Checked==true)
                {
                    ds.TableName = "PendingPurchaseChalan";
                }
                if (rbCustomer.Checked == true)
                {
                    ds.TableName = "PendingSaleChalan";
                }
                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                //Create Excel Sheets
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);

                xlWorksheet.Name = ds.TableName;

                for (int j = 1; j < ds.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = ds.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < ds.Rows.Count; k++)
                {
                    for (int l = 0; l < ds.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        ds.Rows[k].ItemArray[l].ToString();
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
