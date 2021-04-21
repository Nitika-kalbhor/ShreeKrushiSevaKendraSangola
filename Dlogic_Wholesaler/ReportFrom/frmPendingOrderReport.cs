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
    public partial class frmPendingOrderReport : MetroForm
    {
        public frmPendingOrderReport()
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
                    lblHerader.Text = "Order Report";
                    metroLabel3.Text = "To Date:";
                    metroLabel1.Text = "From Date:";
                    btnPrint.Text = "Exel Report";
                    btnShow.Text = "Show";
                    rbCustomer.Text = "Customer";
                    rbDealer.Text = "Dealer";
                    metroLabel2.Text = "Account Name";

                    dgvSaleItems.Columns[4].HeaderText = "Naration";                   
                    dgvSaleItems.Columns[5].HeaderText = "HSNCode";
                    dgvSaleItems.Columns[6].HeaderText = "Batch No";
                    dgvSaleItems.Columns[7].HeaderText = "Quantity";
                    dgvSaleItems.Columns[8].HeaderText = "Unit By";
                    dgvSaleItems.Columns[9].HeaderText = "Rate";
                    dgvSaleItems.Columns[10].HeaderText = "IGST(%)";
                    dgvSaleItems.Columns[11].HeaderText = "IGST Amt";
                    dgvSaleItems.Columns[12].HeaderText = "CGST(%)";
                    dgvSaleItems.Columns[13].HeaderText = "CGST Amt";
                    dgvSaleItems.Columns[14].HeaderText = "SGST(%)";
                    dgvSaleItems.Columns[15].HeaderText = "SGST Amt";
                    dgvSaleItems.Columns[16].HeaderText = "Discount";
                    dgvSaleItems.Columns[17].HeaderText = "Total Amount";

                    dgvPurchaseItems.Columns[4].HeaderText = "Naration";
                    dgvPurchaseItems.Columns[5].HeaderText = "Batch No.";
                    dgvPurchaseItems.Columns[6].HeaderText = "Quantity";
                    dgvPurchaseItems.Columns[7].HeaderText = "Unit By";
                    dgvPurchaseItems.Columns[8].HeaderText = "freeQuantity";
                    dgvPurchaseItems.Columns[9].HeaderText = "Pur.Rate";
                    dgvPurchaseItems.Columns[10].HeaderText = "MRP";
                    dgvPurchaseItems.Columns[11].HeaderText = "Sale Rate";                  
                    dgvPurchaseItems.Columns[12].HeaderText = "IGST(%)";
                    dgvPurchaseItems.Columns[13].HeaderText = "IGST Amt";
                    dgvPurchaseItems.Columns[14].HeaderText = "CGST(%)";
                    dgvPurchaseItems.Columns[15].HeaderText = "CGST Amt";
                    dgvPurchaseItems.Columns[16].HeaderText = "SGST(%)";
                    dgvPurchaseItems.Columns[17].HeaderText = "SGST Amt";
                    dgvPurchaseItems.Columns[18].HeaderText = "Discount";
                    dgvPurchaseItems.Columns[19].HeaderText = "Total Amount";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmPendingOrderReport_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Utility.firstDate;
            dtpToDate.Value = Utility.lastDate;
            dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
            Lang();
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
                DataTable dtAccountLedgerReport = stockController.getOrderDetails(Convert.ToInt64(cmbAccountName.SelectedValue), Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()),Utility.FinancilaYearId, type);
                dgvPandingChalan.DataSource = dtAccountLedgerReport;
                dgvPurchaseItems.Visible = false;
                dgvSaleItems.Visible = false;
                dgvSaleItems.Rows.Clear();
                dgvPurchaseItems.Rows.Clear();
                bindGrid(dtAccountLedgerReport);
            }
            catch (Exception ae)
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

                if (Utility.Langn == "English")
                {
                    dgvPandingChalan.Columns[1].HeaderText = "Order No.";
                    dgvPandingChalan.Columns[2].HeaderText = "Date";
                    dgvPandingChalan.Columns[3].HeaderText = "Customer Name";
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
                    dgvPandingChalan.Columns[1].HeaderText = "ऑर्डर नं";
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
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
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
                   // BindCustomerGrid(dtAccountLedgerReport);
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dgvPandingChalan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvPurchaseItems.Enabled = true;
                DataTable dtSaleChallen = new DataTable();
                if (rbCustomer.Checked == true)
                {
                    dtSaleChallen = SaleDetailsController.getSaleOrderDetails(Convert.ToInt64(dgvPandingChalan.CurrentRow.Cells["SalesChallanBillId"].Value),Utility.FinancilaYearId);
                    dgvPurchaseItems.Visible = false;
                    dgvSaleItems.Visible = true;
                    bindSaleItemDetails(dtSaleChallen);
                }
                if (rbDealer.Checked == true)
                {
                    dtSaleChallen = purchaseDetailsController.getPurchaseOrderDetails(Convert.ToInt64(dgvPandingChalan.CurrentRow.Cells["salesChallanId"].Value),Utility.FinancilaYearId);
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
            try
            {
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                dgvPurchaseItems.Enabled = true;
                foreach (DataRow dr in dtSaleChallen.Rows)
                {
                    dgvPurchaseItems.CurrentRow.Cells["itemId1"].Value = Convert.ToInt64(dr["itemId"]);
                    dgvPurchaseItems.CurrentRow.Cells["StockId1"].Value = Convert.ToInt64(0);
                    dgvPurchaseItems.CurrentRow.Cells["categoryId1"].Value = Convert.ToInt32(dr["categoryId"]);
                    dgvPurchaseItems.CurrentRow.Cells["companyId1"].Value = Convert.ToInt32(dr["companyId"]);
                    dgvPurchaseItems.CurrentRow.Cells["batchNo1"].Value = Convert.ToString(dr["batchNo"]);
                    dgvPurchaseItems.CurrentRow.Cells["itemName1"].Value = dr["itemName"].ToString();
                    //dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["MRP"].Value = dr["MRP"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["Quantity1"].Value = dr["Quantity"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["unitBy1"].Value = dr["unitBy"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["discount1"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["IGST1"].Value = Utility.ParseValue(dr["IGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["CGST1"].Value = Utility.ParseValue(dr["CGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["SGST1"].Value = Utility.ParseValue(dr["SGST"].ToString());
                   
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dr["salesCashRate"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dr["purchaseRate"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["totalAmount1"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity1"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());

                    double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount1"].Value.ToString()) * (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())) / 100);
                    double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity1"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())));
                    dgvPurchaseItems.CurrentRow.Cells["SGSTAmt1"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST1"].Value.ToString()) * purRate / 100);
                    dgvPurchaseItems.CurrentRow.Cells["CGSTAmt1"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST1"].Value.ToString()) * purRate / 100);
                    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt1"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST1"].Value.ToString()) * purRate / 100);

                    dgvPurchaseItems.CurrentRow.Cells["totalAmount1"].Value = Convert.ToDouble(purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt1"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount1"].Value.ToString())).ToString();
                   
                    dgvPurchaseItems.CurrentCell = dgvPurchaseItems.CurrentRow.Cells["Quantity1"];
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
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
        public void bindSaleItemDetails(DataTable dtSaleChallen)
        {
            try
            {
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                dgvSaleItems.Enabled = true;
                
                foreach (DataRow dr in dtSaleChallen.Rows)
                {
                    dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                    dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(0);
                    dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                    dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                    dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                    dgvSaleItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                    dgvSaleItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                    dgvSaleItems.CurrentRow.Cells["Quantity"].Value = dr["quantity"].ToString();
                    dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                    dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dr["perQtysalePrice"].ToString());
                    dgvSaleItems.CurrentRow.Cells["discount"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dr["IGST"].ToString());
                    dgvSaleItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dr["CGST"].ToString());
                    dgvSaleItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dr["SGST"].ToString());

                    dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()), 2);

                    double discount = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())) / 100);
                    double purRate = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())));
                    dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100), 2);
                    dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100), 2);
                    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100), 2);

                    dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = purRate;
                   
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
                            dgvSaleItems.CurrentCell = dgvSaleItems[col + 4, row];
                        }
                    }
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }
    }
}
