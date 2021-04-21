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
using Dlogic_Wholesaler.TempFroms;
namespace Dlogic_Wholesaler.Forms
{
    public partial class frmPurchaseInvoice : MetroForm
    {
        public frmPurchaseInvoice()
        {
            InitializeComponent();
        }
        long purchaseId = 0;
        bool isDelete = false;
       

        private void frmPurchaseInvoice_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.F3)
            {
                try
                {
                    frmItemDetails frm = new frmItemDetails();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    frmDealerMaster frm = new frmDealerMaster();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (e.KeyCode == Keys.P && e.Alt)
            {
                AllPurchaseDetails frm = new AllPurchaseDetails();
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.V && e.Alt)
            {
                frmVoucherPayment frm = new frmVoucherPayment();
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.N && e.Alt)
            {
                try
                {
                    btnnew_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (e.KeyCode == Keys.N && e.Alt)
            {
                try
                {
                    btnnew_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (e.KeyData == Keys.L && e.Control)
            {
                dgvItemName.Focus();
                dgvItemName.CurrentCell = dgvItemName.CurrentRow.Cells[1];
            }
            if (e.KeyCode == Keys.T && e.Alt)
            {
                frmTempPurchaseInvoice frm = new frmTempPurchaseInvoice();
                frm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmItemDetails frm = new frmItemDetails();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindComboBoxgetDealerName()
        {
            DataTable dtgetDealerName = DealerController.getDealerDetails();
            Utility.BindComboBoxDataSelect(cmbDealerName, dtgetDealerName, "dealerId", "dealerFirmName");
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Purchase Bill details";
                    metroLabel2.Text = "Bill No:";
                    metroLabel1.Text = "Date:";
                    lblstockInNo.Text = "Dealer Name:";
                    metroLabel3.Text = "Mobile No:";
                    label4.Text = "Pending Amt:";
                    label1.Text = "Challan No:";
                    label6.Text = "Loan Amount:";
                    label8.Text = "Purchase State:";
                    label7.Text = "Code:";
                    lblNetBill.Text = "Total Amount:";
                    lblPaidAmount.Text = "Paid Amount:";
                    lblBakiAmount.Text = "Pending Amount:";
                    btnDelete.Text = "Delete";
                    btnChallanList.Text = "Purchase Order List";
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    btnConvertChallan.Text = "Convert Challan";
                    label2.Text = "From Date:";
                    label3.Text = "To Date:";
                    btnShow.Text = "Show";
                    label8.Text = "Please fill MFG Date And Expiry Date in dd/MM/yyyy format eg.31/08/2018";
                    lnklblPurchaseBook.Text = "Purchase Book(Alt+P)";
                    lnklblVoucherPayment.Text = "Voucher Payment(Alt+V)";
                    lblPaymenttype.Text = "Payment Type";
                    lblBankName.Text = "Bank Name:";
                    lblChequeNo.Text = "Cheque No:";
                    label33.Text = "Cheque Date:";
                    lblBakiAmount.Text = "Pending Amt:";
                    label7.Text = "Purchase Amt:";
                    label5.Text = "RoundOff:";
                    lbldiscount.Text = "Discount Rs:";
                    lblNetBill.Text = "Total Amt:";
                    lblPaidAmount.Text = "Paid Amt:";

                    dgvPurchaseItems.Columns[7].HeaderText = "Naration";
                    dgvPurchaseItems.Columns[8].HeaderText = "Batch No";
                    dgvPurchaseItems.Columns[9].HeaderText = "MFG Date";
                    dgvPurchaseItems.Columns[10].HeaderText = "Expiry Date";
                    dgvPurchaseItems.Columns[11].HeaderText = "Qty";
                    dgvPurchaseItems.Columns[12].HeaderText = "Unit By";
                    dgvPurchaseItems.Columns[13].HeaderText = "freeQuantity";
                    dgvPurchaseItems.Columns[14].HeaderText = "MRP";
                    dgvPurchaseItems.Columns[15].HeaderText = "Pur.Rate(With GST)";
                    dgvPurchaseItems.Columns[16].HeaderText = "Pur.Rate";
                    dgvPurchaseItems.Columns[17].HeaderText = "Discount";
                    dgvPurchaseItems.Columns[18].HeaderText = "Discount(%)";
                    dgvPurchaseItems.Columns[19].HeaderText = "Pur.Rate(with disc.)";
                    dgvPurchaseItems.Columns[20].HeaderText = "Amount";
                    dgvPurchaseItems.Columns[21].HeaderText = "SaleRate(GST)";
                    dgvPurchaseItems.Columns[22].HeaderText = "Sale Rate";
                    dgvPurchaseItems.Columns[23].HeaderText = "GST(%)";
                    dgvPurchaseItems.Columns[24].HeaderText = "GSTAmt";
                    dgvPurchaseItems.Columns[25].HeaderText = "CGST(%)";
                    dgvPurchaseItems.Columns[26].HeaderText = "CGST Amt";
                    dgvPurchaseItems.Columns[27].HeaderText = "SGST(%)";
                    dgvPurchaseItems.Columns[28].HeaderText = "SGSTAmt";
                    dgvPurchaseItems.Columns[29].HeaderText = "Total Amount";
                    dgvPurchaseItems.Columns[30].HeaderText = "purchaseChalanId";
                    dgvPurchaseItems.Columns[31].HeaderText = "purchaseItemDetailId";
                    dgvPurchaseItems.Columns[32].HeaderText = "Godown";
                  
                    dgvSaleChallan.Columns[0].HeaderText = "Bill No.";
                    dgvSaleChallan.Columns[2].HeaderText = "Dealer Name";
                    dgvSaleChallan.Columns[3].HeaderText = "Date";
                    dgvSaleChallan.Columns[4].HeaderText = "Amount";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void frmPurchaseInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);

                btnSave.Enabled = false;
                btnChallanList.Enabled = false;
                btnConvertChallan.Enabled = false;
                btnDelete.Enabled = false;
                dgvPurchaseItems.Rows.Add();
                // dgvPurchaseItems.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
                //  dgvPurchaseItems.RowHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
                BindComboBoxgetDealerName();
                dgvItemName.Hide();
                dtpChallenDate.MaxDate = Utility.lastDate;
                dtpChallenDate.MinDate = Utility.firstDate;
                dtpFromChallanDate.MinDate = Utility.firstDate;
                dtpFromChallanDate.MaxDate = Utility.lastDate;
                dtpToChallanDate.MinDate = Utility.firstDate;
                dtpToChallanDate.MaxDate = Utility.lastDate;
                if (dtpChallenDate.Value < Utility.firstDate || dtpChallenDate.Value > Utility.lastDate)
                {
                    dtpChallenDate.Value = Utility.firstDate;
                }
                dtpFromChallanDate.Value = Utility.firstDate;
                dtpToChallanDate.Value = Utility.lastDate;
                Lang();
                // cmbGST.SelectedIndex = 0;
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
                grbChallanList.Visible = false;
                grbItemList.Visible = false;
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                btnChallanList.Enabled = true;
                btnConvertChallan.Enabled = true;
                btnDelete.Enabled = true;
                BindComboBoxgetDealerName();
                cmbPaymentType.SelectedIndex = 0;
                purchaseId = purchaseDetailsController.getMaxIdPurchaseInvoiceId();
                isDelete = false;
                //  txtInvoiceNo.Text = purchaseDetailsController.getMaxIdPurchaseInvoiceId().ToString();
                dgvItemName.Hide();
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                cmbDeleveryCharge.SelectedIndex = 0;
                BindBank();
                isUpdateDelete = 0;
                cmbGST.Text = "Maharashtra";
                txtStateCode.Text = "27";
                lblChalanNo.Text = "-";
                //txtPaidAmount.Text = "0";
                isConvertCallan = false;
                rbtnCredit.Checked = true;
                rbtnCash.Checked = false;
                dtpChallenDate.MaxDate = Utility.lastDate;
                dtpChallenDate.MinDate = Utility.firstDate;
                dtpFromChallanDate.MinDate = Utility.firstDate;
                dtpFromChallanDate.MaxDate = Utility.lastDate;
                dtpToChallanDate.MinDate = Utility.firstDate;
                dtpToChallanDate.MaxDate = Utility.lastDate;
                if (dtpChallenDate.Value < Utility.firstDate || dtpChallenDate.Value > Utility.lastDate)
                {
                    dtpChallenDate.Value = Utility.firstDate;
                }
                dtpFromChallanDate.Value = Utility.firstDate;
                dtpToChallanDate.Value = Utility.lastDate;
                ////  dtpDate = new DateTimePicker();
                //  dtpDate.Format = DateTimePickerFormat.Short;
                // dtpDate.Visible = false;
                //  dtpDate.Width = 100;
                //  dtpDate.ValueChanged+=this.dtpDate_ValueChanged;
                //  dgvPurchaseItems.CellBeginEdit+=this.dgvPurchaseItems_CellBeginEdit;
                //  dgvPurchaseItems.CellEndEdit += this.dgvPurchaseItems_CellEndEdit;
                dgvPurchaseItems.Columns["itemName"].ReadOnly = false;
                dgvPurchaseItems.CurrentRow.Cells["godown"].ReadOnly = false;
                dgvPurchaseItems.Enabled = false;
                txtInvoiceNo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPurchaseItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPurchaseItems.IsCurrentCellDirty)
                {
                    dgvPurchaseItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    try
                    {
                        tb_TextChanged(sender, e);
                    }
                    catch (Exception ae)
                    {
                        MessageBox.Show(ae.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void tb_TextChanged(Object sender, EventArgs e)
        {
            try
            {
                grbChallanList.Visible = false;
                grbItemList.Visible = true;
                if (dgvPurchaseItems.CurrentRow.Cells["itemName"].Value == null)
                {
                    dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["discountPer"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["saleRateWithGst"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["MRP"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["rackNo"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["productCode"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["TaxableAmount"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["purchaseItemDetailId"].Value = 0;
                    dgvItemName.Hide();
                    return;
                }
                string value = null;
             
                if (dgvPurchaseItems.CurrentCell.ColumnIndex == 7)
                {
                    value = dgvPurchaseItems.CurrentRow.Cells["itemName"].Value.ToString();
                }
                else
                {
                    if (dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value != null && dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value != null && dgvPurchaseItems.CurrentRow.Cells["discountPer"].Value != null &&
                       dgvPurchaseItems.CurrentRow.Cells["discount"].Value != null && dgvPurchaseItems.CurrentRow.Cells["IGST"].Value != null
                       && dgvPurchaseItems.CurrentRow.Cells["CGST"].Value != null &&
                       dgvPurchaseItems.CurrentRow.Cells["SGST"].Value != null && dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value != null && dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value != null && dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value != null &&
                       dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value != null && dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value != null)
                    {
                        dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value.ToString();
                        dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value = dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value.ToString();
                        dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value = dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value.ToString();
                        dgvPurchaseItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["discountPer"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discountPer"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value.ToString());
                       
                        if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                        {
                            dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString());
                            dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) / 2;
                            dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) / 2;
                          //  dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value.ToString())*100)/(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) +100), 2);
                        }
                        else
                        {
                            dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString());
                            dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString());
                            dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString());
                           // dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value.ToString()) * 100) / (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) + 100), 2);

                        }
                        if (dgvPurchaseItems.CurrentCell.ColumnIndex == 16)
                        {
                           dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value= Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                            dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) + (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())/100), 2);

                        }
                        if (dgvPurchaseItems.CurrentCell.ColumnIndex == 15)
                        {
                            dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value.ToString());
                            dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value.ToString()) * 100 / (100 + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())), 2);
                        }
                        dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) + (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) / 100), 2);
                        dgvPurchaseItems.CurrentRow.Cells["MRP"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["MRP"].Value.ToString());
                        double Discount = ((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discountPer"].Value.ToString()) / 100)) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString());
                        if (Discount > 0)
                        {
                            dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) - Discount;
                        }
                        else
                        {
                            dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                        }
                        dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString()) + (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) / 100), 2);
                        if (dgvPurchaseItems.CurrentCell.ColumnIndex == 22)
                        {
                            dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString());
                            dgvPurchaseItems.CurrentRow.Cells["saleRateWithGst"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString()) + (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) / 100), 2);

                        }
                        if (dgvPurchaseItems.CurrentCell.ColumnIndex == 21)
                        {
                            dgvPurchaseItems.CurrentRow.Cells["saleRateWithGst"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["saleRateWithGst"].Value.ToString());
                            dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["saleRateWithGst"].Value.ToString()) * 100 / (100 + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())), 2);
                        }
                        dgvPurchaseItems.CurrentRow.Cells["saleRateWithGst"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString()) + (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) / 100), 2);
                    
                      //  dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["TaxableAmount"].Value = Math.Round((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value.ToString())) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString()), 2);
                        dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value.ToString();
                        dgvPurchaseItems.CurrentRow.Cells["rackNo"].Value = dgvPurchaseItems.CurrentRow.Cells["rackNo"].Value.ToString();
                        dgvPurchaseItems.CurrentRow.Cells["productCode"].Value = dgvPurchaseItems.CurrentRow.Cells["productCode"].Value.ToString();
                      //  dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString())) * Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()));
                        //    double discount = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString())) * (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()))) / 100));
                        double purRate = (Convert.ToDouble(Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString())) * Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString()))));
                        
                        if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                        {
                            dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())) * purRate / 100),2);
                            dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())) / 2);
                            dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())));
                            dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100),2);
                            dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()))),2);
                        }
                        else
                        {
                            dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100),2);
                            dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())));
                            dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()))) + (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString())));
                            dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()))),2);
                            dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());

                        }
                        dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()))),2).ToString();
                        dgvItemName.Hide(); 
                    }
                    else
                    {
                        dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = 0;
                    }
                }
                if (value != null)
                {
                    DataTable dtitem = itemDetailsController.getStockInItemDetails(value);
                    if (dtitem.Rows.Count > 0)
                    {
                        dgvItemName.DataSource = dtitem;
                        dgvItemName.Columns[0].Visible = false;
                        dgvItemName.Columns[1].Width = 500;
                        dgvItemName.ClearSelection();
                        this.dgvItemName.CellBorderStyle = DataGridViewCellBorderStyle.None;
                        dgvItemName.Show();

                    }

                }
                else
                {
                }
                subtot();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private PusrchaseSaleAccount SumOfPurch = new PusrchaseSaleAccount();
        private void subtot()
        {
            try
            {
            double sum = 0;
          
            SumOfPurch = new PusrchaseSaleAccount();
            for (int i = 0; i < dgvPurchaseItems.Rows.Count; ++i)
            {
                if (dgvPurchaseItems.Rows[i].Cells["totalAmount"].Value != null)
                {
                    sum += Utility.ParseValue(dgvPurchaseItems.Rows[i].Cells["totalAmount"].Value.ToString());
                }
                if (dgvPurchaseItems.Rows[i].Cells["IGST"].Value != null)
                {
                    if (dgvPurchaseItems.Rows[i].Cells["IGST"].Value.ToString() == "5")
                    {
                        SumOfPurch.Igst5 += Utility.ParseValue(dgvPurchaseItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["IGST"].Value.ToString() == "12")
                    {
                        SumOfPurch.Igst12 += Utility.ParseValue(dgvPurchaseItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["IGST"].Value.ToString() == "18")
                    {
                        SumOfPurch.Igst18 += Utility.ParseValue(dgvPurchaseItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["IGST"].Value.ToString() == "28")
                    {
                        SumOfPurch.Igst28 += Utility.ParseValue(dgvPurchaseItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                    }
                }
                if (dgvPurchaseItems.Rows[i].Cells["TaxableAmount"].Value!= null)
                {
                    SumOfPurch.salePurchaseAccount += Utility.ParseValue(dgvPurchaseItems.Rows[i].Cells["TaxableAmount"].Value.ToString());
                }
            }
            txtTaxAmount.Text = SumOfPurch.salePurchaseAccount.ToString();
            txtNetAmount.Text = Math.Round(sum,2).ToString();
            try
            {
                if (txtNetAmount.Text.ToString() != String.Empty)
                {
                    txtpurchaseAmt.Text = Math.Round(sum, 2).ToString();
                    double netAmt = Math.Round(Convert.ToDouble(txtNetAmount.Text), 2);
                    txtRoundOff.Text = ((Math.Round(Math.Round(Convert.ToDouble(txtNetAmount.Text), 0) - netAmt, 2))).ToString();

                    txtNetAmount.Text = Math.Round(sum, 0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            PaidAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        private void dgvPurchaseItems_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (isConvertCallan == false)
                {
                    if (e.KeyData == Keys.Enter)
                    {
                        int col = dgvPurchaseItems.CurrentCell.ColumnIndex;
                        int row = dgvPurchaseItems.CurrentCell.RowIndex;
                        if (dgvPurchaseItems.CurrentCell.ColumnIndex == 28)
                        {
                            col = dgvPurchaseItems.CurrentCell.ColumnIndex + 2;
                        }
                        if (col < dgvPurchaseItems.ColumnCount - 1)
                        {
                            col++;
                        }
                        else
                        {
                            col = 0;
                            row++;
                        }
                        if (dgvPurchaseItems.CurrentRow.Cells["itemId"].Value == null)
                        {
                            dgvItemName.Focus();
                            dgvItemName.CurrentCell = dgvItemName.CurrentRow.Cells["itemName"];
                            dgvItemName.CurrentCell.Selected = true;
                        }
                        else
                        {
                            if (dgvPurchaseItems.CurrentRow.Cells["itemName"].Value != null)
                            {
                                if (row == dgvPurchaseItems.RowCount)
                                {
                                    dgvPurchaseItems.Rows.Add();
                                    dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 7, row];
                                }
                                else if (dgvPurchaseItems.CurrentCell.ColumnIndex == 20)
                                {
                                    dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 2, row];
                                }

                                else
                                {
                                    dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col, row];
                                }
                            }
                        }
                        e.Handled = true;
                    }
                    if (e.KeyData == Keys.Alt)
                    {
                        dgvItemName.Focus();
                        dgvItemName.CurrentCell = dgvItemName.CurrentRow.Cells[1];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected void getDataFronCurentRow(int rowIndex)
        {
            try
            {
                dgvItemName.Hide();
                DataGridViewRow row = this.dgvItemName.Rows[rowIndex];
                if (row.Cells != null)
                {
                    long StockId = Convert.ToInt64(dgvItemName.CurrentRow.Cells["itemId"].Value);
                    DataTable dt = itemDetailsController.getStockInItemDetailsbyStockId(StockId);
                    foreach (DataGridViewRow rows in dgvPurchaseItems.Rows)
                    {
                        if (rows.Cells["itemId"].Value != null && rows.Cells["companyId"].Value != null && rows.Cells["categoryId"].Value != null && rows.Cells["batchNo"].Value != null && rows.Cells["itemName"].Value != null)
                        {
                            if (rows.Cells["itemId"].Value.ToString().Equals(dt.Rows[0]["itemId"].ToString()) && 
                                rows.Cells["companyId"].Value.ToString().Equals(dt.Rows[0]["companyId"].ToString()) &&
                                rows.Cells["categoryId"].Value.ToString().Equals(dt.Rows[0]["categoryId"].ToString()) &&
                                rows.Cells["batchNo"].Value.ToString().Equals(dt.Rows[0]["batchNo"].ToString()) &&
                                rows.Cells["itemName"].Value.ToString().Equals(dt.Rows[0]["itemName"].ToString()) &&
                                rows.Cells["godown"].Value.ToString().Equals(dt.Rows[0]["godownName"].ToString()))
                            {
                               
                                if (Utility.Langn == "English")
                                {
                                    MessageBox.Show("This information already present in list !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("कृपया माहिती लिस्ट मध्ये आधीच उपलब्ध आहे !", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                dgvPurchaseItems.Focus();
                                return;
                            }
                        }
                    }
                    DataGridViewComboBoxCell ContactCombo = (DataGridViewComboBoxCell)(dgvPurchaseItems.CurrentRow.Cells["godown"]);
                    ContactCombo.DataSource = itemDetailsController.getGodownDetails();
                    ContactCombo.ValueMember = "godown";
                    ContactCombo.DisplayMember = "godownName";
                    dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dt.Rows[0]["itemId"]);
                    dgvPurchaseItems.CurrentRow.Cells["stockId"].Value = Convert.ToInt64(dt.Rows[0]["StockId"]);
                    dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dt.Rows[0]["companyId"]);
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dt.Rows[0]["categoryId"]);
                    //added two cols
                    dgvPurchaseItems.CurrentRow.Cells["purchaseChalanId"].Value = Convert.ToInt32(0);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseItemDetailId"].Value = Convert.ToInt64(0);
                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dt.Rows[0]["batchNo"]);
                    dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = Convert.ToString(dt.Rows[0]["HNSCode"]);
                    dgvPurchaseItems.CurrentRow.Cells["rackNo"].Value = Convert.ToString(dt.Rows[0]["rackNo"]);
                    dgvPurchaseItems.CurrentRow.Cells["productCode"].Value = Convert.ToString(dt.Rows[0]["productCode"]);
                    dgvPurchaseItems.CurrentRow.Cells["itemName"].Value = dt.Rows[0]["itemName"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = 1;
                    dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value = dt.Rows[0]["MFD_Date"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value = dt.Rows[0]["expireDate"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = dt.Rows[0]["unitBy"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dt.Rows[0]["purchaseRate"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dt.Rows[0]["purchaseRate"].ToString())+(((Utility.ParseValue(dt.Rows[0]["purchaseRate"].ToString())*Utility.ParseValue(dt.Rows[0]["IGST"].ToString()))/100)),2);
                    dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value = Utility.ParseValue(dt.Rows[0]["purchaseRate"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["saleRateWithGst"].Value = Math.Round(Utility.ParseValue(dt.Rows[0]["salesCashRate"].ToString()) + (((Utility.ParseValue(dt.Rows[0]["salesCashRate"].ToString()) * Utility.ParseValue(dt.Rows[0]["IGST"].ToString())) / 100)), 2);
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dt.Rows[0]["salesCashRate"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["MRP"].Value = Utility.ParseValue(dt.Rows[0]["MRP"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["TaxableAmount"].Value = Math.Round((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value.ToString())) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString()), 2);
                    // dgvPurchaseItems.CurrentRow.Cells["salesCreditRate"].Value = 0;
                    //dgvPurchaseItems.CurrentRow.Cells["wholeSalesCashRate"].Value = 0;
                    //  dgvPurchaseItems.CurrentRow.Cells["wholeSalesCreditRate"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue("0");
                    dgvPurchaseItems.CurrentRow.Cells["discountPer"].Value = Utility.ParseValue("0");
                    dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dt.Rows[0]["IGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dt.Rows[0]["CGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dt.Rows[0]["SGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                    
                   
                    //   double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())) / 100);
                    double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())));

                    if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                    {
                        dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dt.Rows[0]["IGST"].ToString()) * purRate / 100);
                    }
                    else
                    {
                        dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dt.Rows[0]["CGST"].ToString()) * purRate / 100);
                        dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dt.Rows[0]["SGST"].ToString()) * purRate / 100);
                        dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());
                    }

                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = (purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString())).ToString();
                    dgvPurchaseItems.CurrentRow.Cells["godown"].Value = dt.Rows[0]["godownName"].ToString();
                    subtot();
                    dgvPurchaseItems.CurrentCell = dgvPurchaseItems.CurrentRow.Cells["Quantity"];
                    dgvPurchaseItems.BeginEdit(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvItemName_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int rowIndex = e.RowIndex;
                    getDataFronCurentRow(rowIndex);
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double checkpaidamount = 0;
                double checkbillamount = 0;
                if (txtNetAmount.Text != string.Empty && txtPaidAmount.Text != string.Empty)
                {
                    checkpaidamount = Utility.ParseValue(txtPaidAmount.Text);
                    checkbillamount = Utility.ParseValue(txtNetAmount.Text);
                    if (checkbillamount < checkpaidamount)
                    {                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Check total amount.");
                        }
                        else
                        {
                            MessageBox.Show("कृपया पूर्ण रक्कम तपासा ..!");
                        }
                        txtPaidAmount.Text = "";
                        txtNetAmount.Text = checkbillamount.ToString();
                        txtBalanceAmount.Text = checkbillamount.ToString();
                    }
                    else
                    {
                        double dueAmount = Convert.ToDouble(Utility.ParseValue(txtNetAmount.Text)) - Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text));
                        txtBalanceAmount.Text = dueAmount.ToString();
                    }
                }
                else
                {
                    txtBalanceAmount.Text = txtNetAmount.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindBank()
        {
            Utility.BindComboBoxDataSelect(cmbBank, accountDetailsController.GetAccountWisePaymentDue(0, "BankBind", Utility.FinancilaYearId), "accountId", "accountName");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbDealerName.Text == string.Empty || cmbDealerName.SelectedValue == null)
                {                    
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Dealer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया व्यापारीचे नाव निवडा", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmbDealerName.Focus();
                    return;
                }
                for (int i = 0; i < dgvPurchaseItems.Rows.Count; i++)
                {
                    if (dgvPurchaseItems.Rows[i].Cells["itemName"].Value == null)
                    {
                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Item Name..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया वस्तुचे नाव भरा ...!");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells["itemName"];
                        return;
                    }
                    //if (dgvPurchaseItems.Rows[i].Cells[8].Value == null)
                    //{

                    //    MessageBox.Show("कृपया लिस्ट मध्ये नग भरा");
                    //    dgvPurchaseItems.Focus();
                    //    dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[8];
                    //    return;
                    //}
                    if (dgvPurchaseItems.Rows[i].Cells["batchNo"].Value == null)
                    {
                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add Batch no...");
                        }
                        else
                        {
                            MessageBox.Show("कृपया बॅच नंबर भरा ..!");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells["batchNo"];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["Quantity"].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add item Quantity..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया वस्तूचे नग भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells["Quantity"];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["unitBy"].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells["unitBy"].Value = "Qty";
                    }

                    if (dgvPurchaseItems.Rows[i].Cells["purchaseRate"].Value == null)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Purchase Rate..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया खरेदी किंमत भरा ..");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells["purchaseRate"];
                        return;
                    }
                    else
                    {
                        dgvPurchaseItems.Rows[i].Cells["purchaseRate"].Value = Utility.ParseValue(dgvPurchaseItems.Rows[i].Cells["purchaseRate"].Value.ToString());
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["salesCashRate"].Value == null)
                    {                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Sale Rate..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया विक्री किंमत भरा ..");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells["salesCashRate"];
                        return;
                    }

                    if (dgvPurchaseItems.Rows[i].Cells["IGST"].Value == null)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add IGST..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया IGST भरा ..");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells["IGST"];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["mfgDate"].Value != null)
                    {
                        dgvPurchaseItems.Rows[i].Cells["mfgDate"].Value = Convert.ToDateTime(dgvPurchaseItems.Rows[i].Cells["mfgDate"].Value, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat).ToShortDateString();
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["expireDate"].Value != null)
                    {
                        dgvPurchaseItems.Rows[i].Cells["expireDate"].Value = Convert.ToDateTime(dgvPurchaseItems.Rows[i].Cells["expireDate"].Value, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat).ToShortDateString();
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["freeQuantity"].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells["freeQuantity"].Value = 0;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["MRP"].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells["MRP"].Value = 0;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["IGST"].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells["IGST"].Value = 0;
                    }
                    else
                    {
                        dgvPurchaseItems.Rows[i].Cells["IGST"].Value = Convert.ToDouble(dgvPurchaseItems.Rows[i].Cells["IGST"].Value).ToString();
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["IGSTAmt"].Value != null)
                    {
                        dgvPurchaseItems.Rows[i].Cells["IGSTAmt"].Value = Convert.ToDouble(dgvPurchaseItems.Rows[i].Cells["IGSTAmt"].Value);
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["totalAmount"].Value == null || Convert.ToDouble(dgvPurchaseItems.Rows[i].Cells["totalAmount"].Value) == 0)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Total Amount..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया पूर्ण रक्कम भरा ..");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells["totalAmount"];
                        return;
                    }
                }
                if (cmbPaymentType.Text.Equals("Cheque"))
                {
                    if (cmbBank.Text.Equals("") || cmbBank.SelectedIndex.Equals(0))
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Fill Bank Name...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया बँकचे नाव भरा...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cmbBank.Focus();
                        return;
                    }
                    else if (txtchqDDNo.Text.Equals("") || txtchqDDNo.Text.Equals("0"))
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Fill Cheque / DD No...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया चेक / डी.डी. क्रमांक  भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        txtchqDDNo.Focus();
                        return;

                    }
                }
                if (cmbPaymentType.Text.Equals("Card Payment"))
                {
                    if (cmbBank.Text.Equals("") || cmbBank.Text.Equals("0"))
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Fill Bank Name...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया बँकचे नाव भरा...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cmbBank.Focus();
                        return;

                    }
                    else if (txtchqDDNo.Text.Equals("") || txtchqDDNo.Text.Equals("0"))
                    {

                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Fill Cheque / DD No...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया चेक / डी.डी. क्रमांक  भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        txtchqDDNo.Focus();
                        return;



                    }
                }
                if (cmbPaymentType.Text.Equals("") || cmbPaymentType.Text.Equals("0"))
                {
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Payment Type ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया Payment प्रकार निवडा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmbPaymentType.Focus();
                    return;


                }
                if (txtInvoiceNo.Text == string.Empty)
                {
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Fill Bill No..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया बिल क्रमांक  भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtInvoiceNo.Focus();
                    return;

                }
                if (cmbDealerName.SelectedValue == null)
                {
                  
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Dealer Name ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया व्यापार्याचे नाव भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmbPaymentType.Focus();
                    // dealerDetails dealer = new dealerDetails();
                    //dealer.de
                    //DealerController.addDealerDetails(dealer);
                    return;
                }

                if (txtPaidAmount.Text == string.Empty)
                {
                    txtPaidAmount.Text = "0";
                }

                PurchaseDetails purch = new PurchaseDetails();
                purch.dealerId = Convert.ToInt64(cmbDealerName.SelectedValue);
                purch.challanDate = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                purch.purchaseInvoiceId = txtInvoiceNo.Text;
                if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                {
                    purch.isState = false;
                }
                else
                {
                    purch.isState = true;
                }
                purch.remark = "";
                purch.paymentType = cmbPaymentType.Text;
                if(txtDilivaryharges.Text==string.Empty)
                {
                    txtDilivaryharges.Text="0";
                }
                if (cmbDeleveryCharge.SelectedIndex == 0)
                {
                    purch.DilivaryCharges = Utility.ParseValue(txtDilivaryharges.Text);
                }
                else
                {
                    purch.DilivaryCharges = -Utility.ParseValue(txtDilivaryharges.Text);
                }
                // DataGridView to Convert Table Payment Type table 
                DataTable PurchaseInvoice = new DataTable();


                foreach (DataGridViewColumn col in dgvPurchaseItems.Columns)
                {
                    PurchaseInvoice.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dgvPurchaseItems.Rows)
                {
                    DataRow dRow = PurchaseInvoice.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null)
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Please Fill all details in list");
                            }
                            else
                            {
                                MessageBox.Show("कृपया लिस्ट मध्ये पूर्ण माहिती भरा");
                            }

                            return;
                        }

                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    PurchaseInvoice.Rows.Add(dRow);
                }

                purch.PurchaseItemTable = PurchaseInvoice;
                if (isUpdateDelete == 1)
                {
                    purch.purchaseId = purchaseId;
                }
                else
                {
                    purch.purchaseId = purchaseDetailsController.getMaxIdPurchaseInvoiceId();
                }
                if (txtPaidAmount.Text == string.Empty)
                {
                    txtPaidAmount.Text = "0";
                    purch.paidAmount = Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text));
                }
                else
                {
                    purch.paidAmount = Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text));
                }
                purch.FinancialYearID = Utility.FinancilaYearId;
                purch.netBillAmount = Convert.ToDouble(Utility.ParseValue(txtNetAmount.Text));
                if (txtRoundOff.Text == string.Empty)
                {
                    txtRoundOff.Text = "0";
                }
                else
                {
                    purch.roundOff = Convert.ToDouble(Utility.ParseValue(txtRoundOff.Text));
                }
                if (txtdiscount.Text==string.Empty)
                {
                    txtdiscount.Text = "0";
                }

                purch.discountAmount = Convert.ToDouble(Utility.ParseValue(txtdiscount.Text));
                purch.netBillAmtWithOutDiscount = Convert.ToDouble(Utility.ParseValue(txtNetAmount.Text) + Utility.ParseValue(txtdiscount.Text));
                purch.state = cmbGST.Text;
                purch.stateCode = txtStateCode.Text.ToString();
                if (cmbPaymentType.Text != "Cash")
                {
                    purch.chequeDate = dtpchedate.Value;
                }
                else
                {
                    purch.chequeDate = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                }
                purch.bankName = cmbBank.Text;
                if (cmbBank.SelectedIndex > 0)
                {
                    purch.orjId = Convert.ToInt32(cmbBank.SelectedValue);
                }
                else
                {
                    purch.orjId = 0;
                }
                purch.chequeNo_refNo = txtchqDDNo.Text;
                purch.addedBy = Utility.LoginID;

                PusrchaseSaleAccount PurchsSale = new PusrchaseSaleAccount();
                PurchsSale.RoundOff = Utility.ParseValue(txtRoundOff.Text);
                if (txtdiscount.Text == string.Empty)
                {
                    txtdiscount.Text = "0";
                }
                PurchsSale.discount = Utility.ParseValue(txtdiscount.Text); 
                if (txtDilivaryharges.Text == string.Empty)
                {
                    txtDilivaryharges.Text = "0";
                }
                if (cmbDeleveryCharge.SelectedIndex == 0)
                {
                    PurchsSale.Hamali = Utility.ParseValue(txtDilivaryharges.Text);
                }
                else
                {
                     PurchsSale.Hamali = -Utility.ParseValue(txtDilivaryharges.Text);
                }
                PurchsSale.billId = purch.purchaseId;
                PurchsSale.Igst5 = SumOfPurch.Igst5;
                PurchsSale.Igst12 = SumOfPurch.Igst12;
                PurchsSale.Igst18 = SumOfPurch.Igst18;
                PurchsSale.Igst28 = SumOfPurch.Igst28;
                PurchsSale.salePurchaseAccount = SumOfPurch.salePurchaseAccount;// Convert.ToDouble(PurchaseInvoice.Compute("Sum(TaxableAmount)", string.Empty));
                PurchsSale.issalePurchase = "Purchase";
                PurchsSale.stateCode = txtStateCode.Text.Trim();
                int ks = 0;
                if (isConvertCallan == true)
                {
                    ks = purchaseDetailsController.addPurchaseDetailsByChalanConvert(purch, PurchsSale);
                    if (ks > 0)
                    {       // challan save
                       if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Current Sale Bill Saved successfully..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("सदर बिल यशस्वीरित्या साठवले गेले आहे..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        btnnew_Click(sender, e);
                    }
                    else
                    {                      
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Current Sale Bill Does not saved successfully..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("सदर बिल साठवले गेले नाही..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    if (isDelete == true)
                    {
                        DialogResult dr =DialogResult.No;
                        if (Utility.Langn == "English")
                        {
                            dr = MessageBox.Show("Do you want to delete this Bill?", "Confirmation", MessageBoxButtons.YesNo);
                        }
                        else
                        {
                            dr = MessageBox.Show("तुम्हाला सदर बिल डिलीट करायाचे आहे काय?", "Confirmation", MessageBoxButtons.YesNo);
                        }
                        if (dr == DialogResult.Yes)
                        {
                            purch.isDelete = true;
                            ks = purchaseDetailsController.addPurchaseDetails(purch, PurchsSale);
                        }
                        else if (dr == DialogResult.No)
                        {
                            //Nothing to do
                        }
                        if (ks > 0)
                        {
                           
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Current bill deleted successfully ..!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("सदर बिल यशस्वीरित्या डिलीट केले गेले आहे ..!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            btnnew_Click(sender,e);
                        }
                    }
                    else if (isDelete == false)
                    {
                        purch.isDelete = false;
                        ks = purchaseDetailsController.addPurchaseDetails(purch, PurchsSale);
                        if (ks > 0)
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Current Sale Bill Saved Successfully..", "Save", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("सदर बिल यशस्वीरित्या साठवले गेले आहे..", "Save", MessageBoxButtons.OK);
                            }
                            btnnew_Click(sender, e);
                        }
                       
                    }
                   
                }
                BindBank();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frmDealerMaster frm = new frmDealerMaster();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindBank();
            if (cmbPaymentType.SelectedItem.ToString() == "Cash")
            {
                lblBankName.Visible = false;
                lblChequeNo.Visible = false;
                cmbBank.Visible = false;
                txtchqDDNo.Visible = false;
                txtchqDDNo.Text = "";
                cmbBank.Text = "";
                label33.Visible = false;
                dtpchedate.Visible = false;

            }

            if (cmbPaymentType.SelectedItem.ToString() == "Card Payment")
            {
                lblBankName.Visible = true;
                lblChequeNo.Visible = true;
                cmbBank.Text = "";
                txtchqDDNo.Text = "";
                cmbBank.Visible = true;
                txtchqDDNo.Visible = true;
                label33.Visible = false;
                dtpchedate.Visible = false;
            }
            if (cmbPaymentType.SelectedItem.ToString() == "IMPS")
            {
                lblBankName.Visible = true;
                lblChequeNo.Visible = true;
                cmbBank.Visible = true;
                txtchqDDNo.Visible = true;
                cmbBank.Text = "";
                txtchqDDNo.Text = "";
                label33.Visible = false;
                dtpchedate.Visible = false;
            }
            if (cmbPaymentType.SelectedItem.ToString() == "NEFT")
            {
                lblBankName.Visible = true;
                lblChequeNo.Visible = true;
                cmbBank.Visible = true;
                txtchqDDNo.Visible = true;
                cmbBank.Text = "";
                txtchqDDNo.Text = "";
                label33.Visible = false;
                dtpchedate.Visible = false;
            }
            if (cmbPaymentType.SelectedItem.ToString() == "RTGS")
            {
                lblBankName.Visible = true;
                lblChequeNo.Visible = true;

                cmbBank.Text = "";
                txtchqDDNo.Text = "";
                cmbBank.Visible = true;
                txtchqDDNo.Visible = true;
                label33.Visible = false;
                dtpchedate.Visible = false;
            }
            //else
            if (cmbPaymentType.SelectedItem.ToString() == "Cheque" || cmbPaymentType.SelectedItem.ToString() == "Dimand Draft")
            {
                lblBankName.Visible = true;
                lblChequeNo.Visible = true;
                cmbBank.Visible = true;
                txtchqDDNo.Visible = true;
                cmbBank.Text = "";
                txtchqDDNo.Text = "";
                label33.Visible = true;
                dtpchedate.Visible = true;
            }
        }

        private void dgvPurchaseItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
                if (
                     dgvPurchaseItems.CurrentCell.ColumnIndex == 14 || dgvPurchaseItems.CurrentCell.ColumnIndex == 11
                    || dgvPurchaseItems.CurrentCell.ColumnIndex == 12 || dgvPurchaseItems.CurrentCell.ColumnIndex == 15
                    || dgvPurchaseItems.CurrentCell.ColumnIndex == 13 || dgvPurchaseItems.CurrentCell.ColumnIndex == 16) //Desired Column
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allowed only numeric value  ex.10
            //if (!char.IsControl(e.KeyChar)
            //    && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}

            // allowed numeric and one dot  ex. 10.23
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void cmbDealerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDealerName.SelectedIndex > 0)
                {
                    dgvPurchaseItems.Enabled = true;
                    lblCreditAmount.Text = Math.Round(purchaseDetailsController.getPaymentDeuAmtDealer(Convert.ToInt64(cmbDealerName.SelectedValue),Utility.FinancilaYearId), 2).ToString();
                    if(txtInvoiceNo.Text==string.Empty)
                    {
                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please fill Purchase bill No. !");
                        }
                        else
                        {
                            MessageBox.Show("कृपया खरेदी बिल नं भरा.");
                        }
                        txtInvoiceNo.Focus();
                        return;
                    }
                    else
                    {
                         if (isUpdateDelete == 0)
                         {
                             Boolean isExists = purchaseDetailsController.getInvoice(txtInvoiceNo.Text,Convert.ToInt64(cmbDealerName.SelectedValue),Utility.FinancilaYearId);
                             if(isExists==true)
                             {
                                 
                                 if (Utility.Langn == "English")
                                 {
                                     MessageBox.Show("This Purchase Bill already Saved.");
                                 }
                                 else
                                 {
                                     MessageBox.Show("सदर खरेदी बिल भरले गेले आहे.");
                                 }
                                 dgvPurchaseItems.Enabled = false;
                                 txtInvoiceNo.Focus();
                             }
                             else
                             {
                                 dgvPurchaseItems.Enabled = true;
                             }
                         }
                    }
                }
                else
                {
                    lblCreditAmount.Text = "0";
                    dgvPurchaseItems.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Int32 rowToDelete;
        public int rowIndex = 0;

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isUpdateDelete == 1)
            {
                if (dgvPurchaseItems.CurrentRow.Cells["itemId"].Value != null)
                {
                    purchaseDetailsController.deletePurchseInvoiceRow(purchaseId, Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["purchaseItemDetailId"].Value), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["itemId"].Value), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["categoryId"].Value),
                        Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["companyId"].Value), Convert.ToString(dgvPurchaseItems.Rows[rowIndex].Cells["batchNo"].Value),
                  Utility.ParseValue(dgvPurchaseItems.Rows[rowIndex].Cells["Quantity"].Value.ToString()), Utility.ParseValue(dgvPurchaseItems.Rows[rowIndex].Cells["freeQuantity"].Value.ToString()), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["StockId"].Value));
                }
              // ;
                }
            rowToDelete = dgvPurchaseItems.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            dgvPurchaseItems.Rows.RemoveAt(rowToDelete);
            dgvPurchaseItems.ClearSelection();
            if (dgvPurchaseItems.Rows.Count == 0)
            {
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
            }
            subtot();
        }

       
        private void dgvPurchaseItems_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                this.dgvPurchaseItems.ClearSelection();
                this.dgvPurchaseItems.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.contextMenuStrip1.Show(this.dgvPurchaseItems, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void dgvItemName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        int rowIndex = dgvItemName.CurrentCell.OwningRow.Index;
                        getDataFronCurentRow(rowIndex);
                    }
                    catch (Exception ae)
                    {
                        MessageBox.Show(ae.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPaidAmount_Click(object sender, EventArgs e)
        {
            try
            {
                PaidAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void PaidAmount()
        {
            try
            {
               
                if (rbtnCash.Checked == true)
                {
                    if (txtdiscount.Text != string.Empty && txtDilivaryharges.Text != string.Empty && txtpurchaseAmt.Text != string.Empty)
                    {
                        if (cmbDeleveryCharge.SelectedIndex == 0)
                        {
                            txtNetAmount.Text = (Math.Round(Utility.ParseValue(txtpurchaseAmt.Text), 0) + Utility.ParseValue(txtDilivaryharges.Text) - Utility.ParseValue(txtdiscount.Text)).ToString();
                        }
                        else
                        {
                            txtNetAmount.Text = (Math.Round(Utility.ParseValue(txtpurchaseAmt.Text), 0) - Utility.ParseValue(txtDilivaryharges.Text) - Utility.ParseValue(txtdiscount.Text)).ToString();
                        }
                        }
                    else
                    {
                        if (txtpurchaseAmt.Text != string.Empty)
                        txtNetAmount.Text = Math.Round(Utility.ParseValue(txtpurchaseAmt.Text), 0).ToString();
                    }
                    txtPaidAmount.Text = txtNetAmount.Text;
                    txtBalanceAmount.Text = "0";
                }
                else
                {
                    double checkpaidamount = 0;
                    double checkbillamount = 0;
                    if (txtdiscount.Text != string.Empty && txtDilivaryharges.Text != string.Empty && txtpurchaseAmt.Text != string.Empty)
                    {
                        if (cmbDeleveryCharge.SelectedIndex == 0)
                        {
                            txtNetAmount.Text = (Math.Round(Utility.ParseValue(txtpurchaseAmt.Text), 0) + Utility.ParseValue(txtDilivaryharges.Text) - Utility.ParseValue(txtdiscount.Text)).ToString();
                        }
                        else
                        {
                            txtNetAmount.Text = (Math.Round(Utility.ParseValue(txtpurchaseAmt.Text), 0) - Utility.ParseValue(txtDilivaryharges.Text) - Utility.ParseValue(txtdiscount.Text)).ToString();
                        }
                    }
                    else
                    {
                        if (txtpurchaseAmt.Text != string.Empty)
                        txtNetAmount.Text = Math.Round(Utility.ParseValue(txtpurchaseAmt.Text), 0).ToString();
                    }
                    string netamount = txtNetAmount.Text;
                    if (txtNetAmount.Text != string.Empty && txtPaidAmount.Text != string.Empty)
                    {
                        checkpaidamount = Utility.ParseValue(txtPaidAmount.Text);
                        checkbillamount = Utility.ParseValue(txtNetAmount.Text);
                        if (checkbillamount < checkpaidamount)
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Please Check Total Amount !");
                            }
                            else
                            {
                                MessageBox.Show("कृपया एकूण रक्कम तपासा !");
                            }

                            txtPaidAmount.Text = "";
                            txtNetAmount.Text = checkbillamount.ToString();
                            txtBalanceAmount.Text = checkbillamount.ToString();
                        }
                        else
                        {
                            txtBalanceAmount.Text = (Convert.ToDouble(Utility.ParseValue(txtNetAmount.Text)) - Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text))).ToString();
                        }
                    }
                    else
                    {
                        txtBalanceAmount.Text = netamount;
                    }
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPaidAmount.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtPaidAmount.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtmobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbGST_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbGST.SelectedIndex >= 0)
                {
                    string stateName = cmbGST.Text;
                    switch (stateName)
                    {
                        case "Jammu and Kashmir":
                            txtStateCode.Text = "01";
                            break;
                        case "Himachal Pradesh":
                            txtStateCode.Text = "02";
                            break;
                        case "Punjab":
                            txtStateCode.Text = "03";
                            break;
                        case "Chandigarh":
                            txtStateCode.Text = "04";
                            break;
                        case "Uttrakhand":
                            txtStateCode.Text = "05";
                            break;
                        case "Haryana":
                            txtStateCode.Text = "06";
                            break;
                        case "Delhi":
                            txtStateCode.Text = "07";
                            break;
                        case "Rajasthan":
                            txtStateCode.Text = "08";
                            break;
                        case "Uttar Pradesh":
                            txtStateCode.Text = "09";
                            break;
                        case "Bihar":
                            txtStateCode.Text = "10";
                            break;
                        case "Sikkim":
                            txtStateCode.Text = "11";
                            break;
                        case "Arunachal Pradesh":
                            txtStateCode.Text = "12";
                            break;
                        case "Nagaland":
                            txtStateCode.Text = "13";
                            break;
                        case "Manipur":
                            txtStateCode.Text = "14";
                            break;
                        case "Mizoram":
                            txtStateCode.Text = "15";
                            break;
                        case "Tripura":
                            txtStateCode.Text = "16";
                            break;
                        case "Meghalaya":
                            txtStateCode.Text = "17";
                            break;

                        case "Assam":
                            txtStateCode.Text = "18";
                            break;
                        case "West Bengal":
                            txtStateCode.Text = "19";
                            break;

                        case "Jharkhand":
                            txtStateCode.Text = "20";
                            break;
                        case "Odisha":
                            txtStateCode.Text = "21";
                            break;
                        case "Chhattisgarh":
                            txtStateCode.Text = "22";
                            break;
                        case "Madhya Pradesh":
                            txtStateCode.Text = "23";
                            break;
                        case "Gujarat":
                            txtStateCode.Text = "24";
                            break;
                        case "Daman and Diu":
                            txtStateCode.Text = "25";
                            break;
                        case "Dadra and Nagar Haveli":
                            txtStateCode.Text = "26";
                            break;
                        case "Maharashtra":
                            txtStateCode.Text = "27";
                            break;

                        case "Karnataka":
                            txtStateCode.Text = "29";
                            break;
                        case "Goa":
                            txtStateCode.Text = "30";
                            break;
                        case "Lakshdweep":
                            txtStateCode.Text = "31";
                            break;
                        case "Kerala":
                            txtStateCode.Text = "32";
                            break;
                        case "Tamil Nadu":
                            txtStateCode.Text = "33";
                            break;
                        case "Pondicherry":
                            txtStateCode.Text = "34";
                            break;

                        case "Andaman & Nicobar Islands":
                            txtStateCode.Text = "35";
                            break;
                        case "Telangana":
                            txtStateCode.Text = "36";
                            break;
                        case "Andhra Pradesh":
                            txtStateCode.Text = "37";
                            break;

                        case "Other Territory":
                            txtStateCode.Text = "97";
                            break;

                    }
                }
                if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                {
                    dgvPurchaseItems.Columns["IGST"].Visible = true;
                    dgvPurchaseItems.Columns["IGSTAmt"].Visible = true;
                    dgvPurchaseItems.Columns["CGST"].Visible = false;
                    dgvPurchaseItems.Columns["CGSTAmt"].Visible = false;
                    dgvPurchaseItems.Columns["SGST"].Visible = false;
                    dgvPurchaseItems.Columns["SGSTAmt"].Visible = false;

                }
                else
                {
                    dgvPurchaseItems.Columns["IGST"].Visible = false;
                    dgvPurchaseItems.Columns["IGSTAmt"].Visible = false;
                    dgvPurchaseItems.Columns["CGST"].Visible = true;
                    dgvPurchaseItems.Columns["CGSTAmt"].Visible = true;
                    dgvPurchaseItems.Columns["SGST"].Visible = true;
                    dgvPurchaseItems.Columns["SGSTAmt"].Visible = true;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void txtInvoiceNo_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnChallanList_Click(object sender, EventArgs e)
        {
            grbItemList.Visible = true;
            grbChallanList.Visible = true;
            dtpFromChallanDate.Enabled = true;
            dtpToChallanDate.Enabled = true;
            dtpFromChallanDate.Value = Utility.firstDate;
            dtpToChallanDate.Value = Utility.lastDate;
            dgvSaleChallan.DataSource = purchaseDetailsController.getPurchaseList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            isDelete = true;
            btnSave_Click(sender, e);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            grbItemList.Visible = true;
            grbChallanList.Visible = true;
            dtpFromChallanDate.Enabled = true;
            dtpToChallanDate.Enabled = true;
            dgvSaleChallan.DataSource = purchaseDetailsController.getPurchaseList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);

        }
        public int isUpdateDelete = 0;
        private void dgvSaleChallan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    isUpdateDelete = 1;
                    purchaseId = Convert.ToInt64(dgvSaleChallan.Rows[e.RowIndex].Cells["purchaseId1"].Value);
                }
                DataTable dtSaleChallen = purchaseDetailsController.getPurchaseIvoiceDetails(purchaseId,Utility.FinancilaYearId);
                if (dtSaleChallen.Rows.Count > 0)
                {
                    BindData(dtSaleChallen);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindData(DataTable dtSaleChallen)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                BindComboBoxgetDealerName();
                grbChallanList.Visible = false;
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                dgvPurchaseItems.Enabled = true;
                btnDelete.Enabled = true;
                isDelete = false;
                
                txtInvoiceNo.Text = dtSaleChallen.Rows[0]["purchaseInvoiceId"].ToString();
                dtpChallenDate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["purchaseDate"].ToString());
                cmbDealerName.Text = dtSaleChallen.Rows[0]["dealerFirmName"].ToString();
                txtmobile.Text = dtSaleChallen.Rows[0]["dealerContactNo"].ToString();
                cmbGST.Text = dtSaleChallen.Rows[0]["state"].ToString();
                txtStateCode.Text = dtSaleChallen.Rows[0]["stateCode"].ToString();
                if (Convert.ToBoolean(dtSaleChallen.Rows[0]["isState"].ToString()) == true)
                {
                    cmbGST.Text = "Maharashtra";
                }

                cmbPaymentType.Text = dtSaleChallen.Rows[0]["paymentType"].ToString();
                cmbBank.Text = dtSaleChallen.Rows[0]["bankName"].ToString();
                txtchqDDNo.Text = dtSaleChallen.Rows[0]["chequeNo_refNo"].ToString();
                dtpchedate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["chequeDate"].ToString());
                if (Convert.ToDouble(dtSaleChallen.Rows[0]["netBillAmount"].ToString()) != Convert.ToDouble(dtSaleChallen.Rows[0]["paidAmount"].ToString()))
                {
                    rbtnCredit.Checked = true;
                    rbtnCash.Checked = false;
                }
                else
                {
                    rbtnCash.Checked = true;
                    rbtnCredit.Checked = false;
                }
                txtNetAmount.Text = dtSaleChallen.Rows[0]["netBillAmount"].ToString();
                txtPaidAmount.Text = dtSaleChallen.Rows[0]["paidAmount"].ToString();
                if (Convert.ToDouble(dtSaleChallen.Rows[0]["DilivaryCharges"].ToString()) < 0)
                {
                    txtDilivaryharges.Text = Math.Abs(Convert.ToDouble(dtSaleChallen.Rows[0]["DilivaryCharges"].ToString())).ToString();
                    cmbDeleveryCharge.SelectedIndex = 1;
                }
                else
                {
                    txtDilivaryharges.Text = dtSaleChallen.Rows[0]["DilivaryCharges"].ToString();
                    cmbDeleveryCharge.SelectedIndex = 0;
                }
                txtdiscount.Text = dtSaleChallen.Rows[0]["discountAmount"].ToString();
              
                foreach (DataRow dr in dtSaleChallen.Rows)
                {
                    DataGridViewComboBoxCell ContactCombo = (DataGridViewComboBoxCell)(dgvPurchaseItems.CurrentRow.Cells["godown"]);
                    ContactCombo.DataSource = itemDetailsController.getGodownDetails();
                    ContactCombo.ValueMember = "godown";
                    ContactCombo.DisplayMember = "godownName";
                    dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                    dgvPurchaseItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dr["StockId"]);
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                    dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseItemDetailId"].Value = Convert.ToInt32(dr["purchaseItemDetailId"]);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseChalanId"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                    dgvPurchaseItems.CurrentRow.Cells["itemName"].ReadOnly = true;
                   
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
                    dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dr["IGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dr["CGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dr["SGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = Utility.ParseValue(dr["freeQuantity"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dr["salesCashRate"].ToString());
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
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString()) + ((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString()) * Utility.ParseValue(dr["IGST"].ToString())) / 100), 2);
                    dgvPurchaseItems.CurrentRow.Cells["saleRateWithGst"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString()) + ((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString()) * Utility.ParseValue(dr["IGST"].ToString())) / 100), 2);
                    //double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value)) / 100);
                    double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString())));
                    dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100),2);
                    dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100),2);
                    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100),2);


                    if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                    {
                        dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dr["IGST"].ToString()) * purRate / 100);
                    }
                    else
                    {
                        dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dr["CGST"].ToString()) * purRate / 100);
                        dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dr["SGST"].ToString()) * purRate / 100);
                        dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());
                    }

                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString())).ToString();
                    dgvPurchaseItems.CurrentRow.Cells["godown"].Value = dr["godownName"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["godown"].ReadOnly = true;
                    //  dgvPurchaseItems.Focus();
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
                subtot();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void lnklblPurchaseBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnklblVoucherPayment_Click(object sender, EventArgs e)
        {
            frmVoucherPayment frm = new frmVoucherPayment();
            frm.ShowDialog();
        }

        private void lnklblPurchaseBook_Click(object sender, EventArgs e)
        {
            AllPurchaseDetails frm = new AllPurchaseDetails();
            frm.ShowDialog();
        }

        private void txtNetAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtNetAmount.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;
                    }
                }
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && txtNetAmount.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPaidAmount_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtPaidAmount.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;
                    }
                }
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && txtPaidAmount.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConvertChallan_Click(object sender, EventArgs e)
        {
            try
            {
                frmpurchaseChallanList frm = new frmpurchaseChallanList();
                // Add an event handler to update this form
                // when the ID form is updated (when IdentityUpdated fires).
                frm.IdentityUpdated += new frmpurchaseChallanList.IdentityUpdateHandler(IdForm_ButtonClicked);
                frm.ShowDialog();
                //grbItemList.Visible = true;
                //grbChallanList.Visible = true;
                //dtpFromChallanDate.Enabled = true;
                //dtpToChallanDate.Enabled = true;
                //dgvSaleChallan.DataSource = purchaseDetailsController.getChallenList(dtpFromChallanDate.Value, dtpToChallanDate.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string challanNo = "";
        bool isConvertCallan = false;
        private void IdForm_ButtonClicked(object sender, frmpurchaseChallanList.IdentityUpdateEventArgs e)
        {
            try
            {
                DataTable dtpurchaseChallan = purchaseDetailsController.getSaleChallenDetails(0,Utility.FinancilaYearId);

                foreach (DataRow dr in e.dt.Rows)
                {
                    challanNo += "," + dr[0].ToString();
                    DataTable dts = purchaseDetailsController.getSaleChallenDetails(Convert.ToInt64(dr[4]),Utility.FinancilaYearId);
                    dtpurchaseChallan.Merge(dts);
                }
                if (dtpurchaseChallan.Rows.Count > 0)
                {
                    BindChalanData(dtpurchaseChallan);
                }
                else
                {
                    return;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void BindChalanData(DataTable dtSaleChallen)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                isConvertCallan = true;
                BindComboBoxgetDealerName();
                grbChallanList.Visible = false;
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                dgvPurchaseItems.Enabled = true;
                btnDelete.Enabled = false;
                isDelete = false;
                purchaseId = purchaseDetailsController.getMaxIdPurchaseInvoiceId();
                txtInvoiceNo.Text = "";
                dtpChallenDate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["purchaseChalanDate"]);
                cmbDealerName.Text = dtSaleChallen.Rows[0]["dealerFirmName"].ToString();
                txtmobile.Text = dtSaleChallen.Rows[0]["dealerContactNo"].ToString();
                cmbGST.Text = dtSaleChallen.Rows[0]["state"].ToString();
                txtStateCode.Text = dtSaleChallen.Rows[0]["stateCode"].ToString();
                cmbPaymentType.Text = "Cash";
                //  cmbBank.Text = dtSaleChallen.Rows[0]["bankName"].ToString();
                //   txtchqDDNo.Text = dtSaleChallen.Rows[0]["chequeNo_refNo"].ToString();
                //   dtpChallenDate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["chequeDate"].ToString());
                // txtNetAmount.Text = dtSaleChallen.Rows[0]["netBillAmount"].ToString();
                //  txtPaidAmount.Text = dtSaleChallen.Rows[0]["paidAmount"].ToString();
                //string purchseChalan = "";
                foreach (DataRow dr in dtSaleChallen.Rows)
                {
                    DataGridViewComboBoxCell ContactCombo = (DataGridViewComboBoxCell)(dgvPurchaseItems.CurrentRow.Cells["godown"]);
                    ContactCombo.DataSource = itemDetailsController.getGodownDetails();
                    ContactCombo.ValueMember = "godown";
                    ContactCombo.DisplayMember = "godownName";
                    dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                    dgvPurchaseItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dr["StockId"]);
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                    dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseChalanId"].Value = Convert.ToInt64(dr["purchaseChalanId"]);
                    
                    dgvPurchaseItems.CurrentRow.Cells["purchaseItemDetailId"].Value = 0;

                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                    dgvPurchaseItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["rackNo"].Value = dr["rackNo"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["productCode"].Value = dr["productCode"].ToString();
                    
                    dgvPurchaseItems.CurrentRow.Cells["MRP"].Value = dr["MRP"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = dr["Quantity"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();

                    dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value = dr["mfgDate"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value = dr["expireDate"].ToString();

                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = dr["discount"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["discountPer"].Value = dr["discountPer"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dr["IGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dr["CGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dr["SGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = Utility.ParseValue(dr["freeQuantity"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dr["salesCashRate"].ToString());

                    dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value = Utility.ParseValue(dr["purchaseRate"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value =Math.Round( Utility.ParseValue(dr["purchaseRate"].ToString()) + ((Utility.ParseValue(dr["purchaseRate"].ToString()) * Utility.ParseValue(dr["IGST"].ToString())) / 100),2);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = (Convert.ToDouble(dr["purchaseRate"].ToString()) * 100) / (100 - Convert.ToDouble(dr["discountPer"].ToString()));
                    dgvPurchaseItems.CurrentRow.Cells["TaxableAmount"].Value = Math.Round((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value.ToString())) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString()), 2);
                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString()), 2);

                    double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value)) / 100);
                    double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString())));
                    dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100);
                    dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100);
                    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100);


                    if (cmbGST.Text != "Maharashtra")
                    {
                        dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dr["CGST"].ToString()) * purRate / 100);
                        dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dr["SGST"].ToString()) * purRate / 100);
                        dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());

                    }
                    else
                    {
                        dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dr["CGST"].ToString()) * purRate / 100);
                        dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dr["SGST"].ToString()) * purRate / 100);
                        dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());
                    }
                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString())), 2).ToString();
                    dgvPurchaseItems.CurrentRow.Cells["godown"].Value = dr["godownName"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["godown"].ReadOnly = true;
                    dgvPurchaseItems.CurrentRow.Cells["itemName"].ReadOnly = true;
                    //  dgvPurchaseItems.Focus();
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
                            dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 8, row];
                        }
                    }
                }
              
                lblChalanNo.Text = challanNo;
                subtot();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNetAmount_TextChanged(object sender, EventArgs e)
        {
            //if(txtNetAmount.Text!=string.Empty&&txtDilivaryharges.Text!=string.Empty)
            //{
            //    txtNetAmount.Text = (Utility.ParseValue(txtNetAmount.Text) + Utility.ParseValue(txtDilivaryharges.Text)).ToString();
            //    PaidAmount();
            //}
        }

        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            try{
               txtPaidAmount.Text= txtNetAmount.Text;
               rbtnCash.BackColor = Color.Green;
               rbtnCredit.ForeColor = Color.Black;
               rbtnCash.ForeColor = Color.White;
               rbtnCredit.BackColor = Color.White;
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbtnCredit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtPaidAmount.Text = "0";
                rbtnCredit.BackColor = Color.Red;
                rbtnCredit.ForeColor = Color.White;
                rbtnCash.BackColor = Color.White;
                rbtnCash.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDilivaryharges_TextChanged(object sender, EventArgs e)
        {  
            try{

                PaidAmount();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtpurchaseAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDilivaryharges.Text==string.Empty)
                {
                    txtDilivaryharges.Text = "0";
                }
                PaidAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtdiscount.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;
                    }
                }
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && txtdiscount.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDilivaryharges_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtDilivaryharges.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;
                    }
                }
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && txtDilivaryharges.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbDealerName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode==Keys.Enter)
                {
                    if (cmbDealerName.SelectedIndex > 0)
                    {
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.CurrentRow.Cells["itemName"];
                        dgvPurchaseItems.BeginEdit(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtInvoiceNo_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmbDealerName.SelectedIndex > 0 && txtInvoiceNo.Text!=string.Empty)
                {
                         if (isUpdateDelete == 0)
                         {
                             Boolean isExists = purchaseDetailsController.getInvoice(txtInvoiceNo.Text,Convert.ToInt64(cmbDealerName.SelectedValue),Utility.FinancilaYearId);
                             if(isExists==true)
                             {
                                
                                 if (Utility.Langn == "English")
                                 {
                                     MessageBox.Show("This Purchase bill saved successfully !");
                                 }
                                 else
                                 {
                                     MessageBox.Show("सदर खरेदी बिल भरले गेले आहे.");
                                 }
                                 dgvPurchaseItems.Enabled = false;
                                 txtInvoiceNo.Focus();
                             }
                             else
                             {
                                 dgvPurchaseItems.Enabled = true;
                             }
                         }
                    }
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
              
        }

        private void dgvPurchaseItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

        //private void dgvPurchaseItems_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        //{
        //    try
        //    {
        //        if((dgvPurchaseItems.Focused) &&( dgvPurchaseItems.CurrentCell.ColumnIndex==9))
        //        {
        //            dtpDate.Location = dgvPurchaseItems.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
        //            dtpDate.Visible = true;
        //            if (dgvPurchaseItems.CurrentCell.Value != DBNull.Value && dgvPurchaseItems.CurrentCell.Value.ToString()!="")
        //            {
        //                dtpDate.Value = DateTime.Today; 
        //            }
        //            else
        //            {
        //                dtpDate.Value = DateTime.Today;
        //            }
        //        }
        //        else
        //        {
        //            dtpDate.Visible = false;
        //        }
        //    }
        //    catch (Exception ae)
        //    {
        //        MessageBox.Show(ae.ToString());
        //    }
        //}

        //private void dgvPurchaseItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        if ((dgvPurchaseItems.Focused) && (dgvPurchaseItems.CurrentCell.ColumnIndex == 9))
        //        {
        //           //dtpDate.Value = (DateTime)dgvPurchaseItems.CurrentCell.Value;
        //            dgvPurchaseItems.CurrentCell.Value = dtpDate.Value.Date;
        //        }
        //    }
        //    catch (Exception ae)
        //    {
        //        MessageBox.Show(ae.ToString());
        //    }
        //}
        //private void dtpDate_ValueChanged(object sender,EventArgs e)
        //{
        //    try
        //    {
        //        dgvPurchaseItems.CurrentCell.Value = dtpDate.Text;
        //    }
        //    catch (Exception ae)
        //    {
        //        MessageBox.Show(ae.ToString());
        //    }
        //}
    //}
}
