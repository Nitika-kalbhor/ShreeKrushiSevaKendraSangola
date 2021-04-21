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
using Dlogic_Wholesaler.TempReportFroms;
namespace Dlogic_Wholesaler.TempFroms
{
    public partial class frmTempSaleInvoice : MetroForm
    {
        public frmTempSaleInvoice()
        {
            InitializeComponent();
        }
        public void BindComboBoxgetCustomerName()
        {
            DataTable dt = customerController.getCustomerRetailerDetails(cmbCustomerRetailer.Text);
            Utility.BindComboBoxEmptyDataSelect(cmbCustomerName, dt, "customerId", "customerName");
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lnklblSaleBook.Text = "Sale Book(Alt+B)";
                    lnklblPaymentReceipt.Text = "Payment Receipt(Alt+R)";
                    lblHerader.Text = "Sale Bill 2";
                    label4.Text = "* Entry In this Form will make changes in Stock and Accounts.";
                    label6.Text = "Contact Person";
                    //rbMarathi.Text = "Marathi Bill";
                    //rbEnglish.Text = "English Bill";
                    metroLabel2.Text = "Bill No:";
                    label18.Text = "Fer.BillNo:";
                    label20.Text = "Seed BillNo:";
                    label19.Text = "Pest.BillNo:";
                    label5.Text = "PGR.BillNo:";
                    metroLabel1.Text = "Date:";
                    label17.Text = "Customer/Retailer:";
                    lblstockInNo.Text = "Customer Name:";
                    metroLabel4.Text = "Address:";
                    metroLabel3.Text = "Mobile No:";
                    label1.Text = "RemaningAmt:";
                    label15.Text = "AadharNo:";
                    lbllimitationAmount.Text = "Limitation Amt:";
                    lblCustomerGSTNo.Text = "GST No:";
                    label8.Text = "Sale State:";
                    label7.Text = "Code:";
                    label12.Text = "Chalan No:";
                    //label22.Text = "Driver Name:";
                    //label21.Text = "Gadi No:";
                    btnNewItem.Text = "New Item(F3)";
                    chkholeSale.Text = "Wholsale";
                    rbtnCash.Text = "Cash";
                    rbtnCredit.Text = "Credit";

                    btnDelete.Text = "Delete";
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    btnSaleInvoiceList.Text = "Bill List";
                    btnConvertChallan.Text = "Convert Challan";

                    label2.Text = "From Date:";
                    label3.Text = "To Date:";
                    btnShow.Text = "Show";
                    lblPaymenttype.Text = "Payment Type:";
                    lblBankName.Text = "Bank Name:";
                    lblChequeNo.Text = "Cheque No:";
                    label33.Text = "Cheque Date:";
                    label16.Text = "Next Payment Date:";
                    lblCGST.Text = "CGST Amt:";
                    lblSGST.Text = "SGST Amt:";
                    lblNetBill.Text = "Total BillAmt:";
                    label9.Text = "RoundOff:";
                    label13.Text = "Hamali+Other:";
                    label11.Text = "Total Amount:";
                    lblPaidAmount.Text = "Paid Amount:";
                    label10.Text = "Discount:";
                    lblBakiAmount.Text = "Baki Amount:";

                    dgvSaleItems.Columns[5].HeaderText = "Naration";
                    dgvSaleItems.Columns[6].HeaderText = "HSNCode";
                    dgvSaleItems.Columns[7].HeaderText = "BatchNo";
                    dgvSaleItems.Columns[8].HeaderText = "MFG Date";
                    dgvSaleItems.Columns[9].HeaderText = "Expiry Date";
                    dgvSaleItems.Columns[10].HeaderText = "Qty";
                    dgvSaleItems.Columns[11].HeaderText = "currentStock1";
                    dgvSaleItems.Columns[12].HeaderText = "UnitBy";
                    dgvSaleItems.Columns[13].HeaderText = "Rate(With GST)";
                    dgvSaleItems.Columns[14].HeaderText = "Rate";
                    dgvSaleItems.Columns[15].HeaderText = "Discount";
                    dgvSaleItems.Columns[16].HeaderText = "GST(%)";
                    dgvSaleItems.Columns[17].HeaderText = "GSTAmt";
                    dgvSaleItems.Columns[18].HeaderText = "CGST(%)";
                    dgvSaleItems.Columns[19].HeaderText = "CGST Amt";
                    dgvSaleItems.Columns[20].HeaderText = "SGST(%)";
                    dgvSaleItems.Columns[21].HeaderText = "SGSTAmt";
                    dgvSaleItems.Columns[22].HeaderText = "Amount";


                    dgvSaleInvoice.Columns[0].HeaderText = "Bill No.";
                   // dgvSaleInvoice.Columns[1].HeaderText = "Bill No.";
                    dgvSaleInvoice.Columns[1].HeaderText = "Customer Name";
                    dgvSaleInvoice.Columns[2].HeaderText = "Date";
                    dgvSaleInvoice.Columns[3].HeaderText = "Amount";

                    dgvminimumperchase.Columns[0].HeaderText = "Item Name";
                    dgvminimumperchase.Columns[1].HeaderText = "ItemId";
                    dgvminimumperchase.Columns[2].HeaderText = "MRP";
                    dgvminimumperchase.Columns[3].HeaderText = "Purchase Rate";
                    dgvminimumperchase.Columns[4].HeaderText = "Purchase Rate(With GST)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        string challanNo = "";
        bool isConvertChalan = false;
        private bool isupdate = false;
        private double IGST5 = 0, IGST12 = 0, IGST18 = 0, IGST28 = 0;
        private void frmSaleInvoive_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
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
                btnSave.Enabled = false;
                dgvSaleItems.Rows.Add();
                BindComboBoxgetCustomerName();
                dgvItemName.Hide();
                rbtnCash.Checked = true;
                dgvSaleItems.Enabled = false;
                if (Utility.Langn == "English")
                {
                    lblCGST.Text = "CGST Amount";
                }
                else
                {
                    lblCGST.Text = "CGST रक्कम";
                }
                lblSGST.Visible = true;
                txtSGSTTotalAmount.Visible = true;
                cmbGST.Text = "Maharashtra";
                txtStateCode.Text = "27";
                isupdate = false;
                IGST5 = 0; IGST12 = 0; IGST18 = 0; IGST28 = 0;
                Lang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string isPesticideId = "";
        private string isFertilizerId = "";
        private string isSeedsId = "";
        private string isPGROther = "";

        private string InvoiceIdPesticideId = "0";
        private string InvoiceIdFertilizerId = "0";
        private string InvoiceIdSeedsId = "0";
        private string InvoiceIdPGROther = "0";
        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                isPesticideId = "";
                isFertilizerId = "";
                isSeedsId = "";
                isPGROther = "";
                InvoiceIdPesticideId = "0";
                InvoiceIdFertilizerId = "0";
                InvoiceIdSeedsId = "0";
                InvoiceIdPGROther = "0";
                btnSave.Enabled = true;
                cmbPaymentType.SelectedIndex = 0;
                txtInvoiceNo.Text = TempSaleDetailsController.getMaxIdTempSaleInvoiceId(Utility.FinancilaYearId).ToString();
                isPesticideId = "0";// SaleDetailsController.getMaxIdSalesItemDetails(1, Utility.FinancilaYearId).ToString();
                isFertilizerId = "0";//SaleDetailsController.getMaxIdSalesItemDetails(2,Utility.FinancilaYearId).ToString();
                isSeedsId = "0";//SaleDetailsController.getMaxIdSalesItemDetails(3, Utility.FinancilaYearId).ToString();
                isPGROther = "0";// SaleDetailsController.getMaxIdSalesItemDetails(4, Utility.FinancilaYearId).ToString();
                txtFertInvoiceId.Text = isFertilizerId.ToString();
                txtSeedInvoiceId.Text = isSeedsId.ToString();
                txtPestiInvoiceId.Text = isPesticideId.ToString();
                txtPGRinvoiceId.Text = isPGROther.ToString();
                dgvItemName.Hide();
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                rbtnCash.Checked = true;

                dgvSaleItems.Enabled = true;
                lblCustomerGSTNo.Visible = true;
                grbSaleInvice.Visible = false;
                txtGSTNo.Visible = true;
                cmbCustomerName.Focus();
                isDelete = false;
                isupdate = false;
                if (Utility.Langn == "English")
                {
                    lblCGST.Text = "CGST Amount";
                }
                else
                {
                    lblCGST.Text = "CGST रक्कम";
                }
                lblSGST.Visible = true;
                txtSGSTTotalAmount.Visible = true;
                BindBank();
                saleUpdateId = "";
                txtStateCode.Text = "27";
                cmbGST.Text = "Maharashtra";
                cmbCustomerRetailer.Text = "Customer";
                BindComboBoxgetCustomerName();
                lblChalanNo.Text = "";
                txtChalanNo.Text = "";
                lblBakiAmount.Enabled = true;
                isConvertChalan = false;
                btnDelete.Enabled = false;
                pnlItemName.Visible = false;
                txtHamali.Text = "";
                txtTotalAmount.Text = "";
                txtPaidAmount.Text = "";
                dgvSaleItems.Columns["itemName"].ReadOnly = false;
                dgvSaleItems.Enabled = true;
                IGST5 = 0; IGST12 = 0; IGST18 = 0; IGST28 = 0;
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
                dgvminimumperchase.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvSaleItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvSaleItems.IsCurrentCellDirty)
            {
                dgvSaleItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
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
        void tb_TextChanged(Object sender, EventArgs e)
        {
            try
            {
                if (dgvSaleItems.CurrentRow.Cells["itemName"].Value == null)
                {
                    dgvSaleItems.CurrentRow.Cells["itemId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["salesItemDetailsId"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["companyId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["categoryId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["HNSCode"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["batchNo"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["expireDate"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["IGST"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["CGST"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["SGST"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["StockId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["Quantity"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["unitBy"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["Rate"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["discount"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = false;
                    dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = false;
                    dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = false;
                    dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = false;
                    dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = "";
                    dgvItemName.Hide();
                    return;
                }
                string value = null;
                if (dgvSaleItems.CurrentCell.ColumnIndex == 5)
                {
                    value = dgvSaleItems.CurrentRow.Cells["itemName"].Value.ToString();
                }
                else
                {
                    //if (dgvSaleItems.CurrentCell.ColumnIndex == 7 || dgvSaleItems.CurrentCell.ColumnIndex == 9 || dgvSaleItems.CurrentCell.ColumnIndex == 10 || dgvSaleItems.CurrentCell.ColumnIndex == 12 || dgvSaleItems.CurrentCell.ColumnIndex == 14|| dgvSaleItems.CurrentCell.ColumnIndex == 16
                    //    || dgvSaleItems.CurrentCell.ColumnIndex == 17)
                    //{
                    if (dgvSaleItems.CurrentRow.Cells["Quantity"].Value != null && dgvSaleItems.CurrentRow.Cells["Rate"].Value != null && dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value != null && dgvSaleItems.CurrentRow.Cells["discount"].Value != null
                        && dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value != null && dgvSaleItems.CurrentRow.Cells["expireDate"].Value != null && dgvSaleItems.CurrentRow.Cells["IGST"].Value != null && dgvSaleItems.CurrentRow.Cells["CGST"].Value != null
                        && dgvSaleItems.CurrentRow.Cells["SGST"].Value != null)
                    {
                        if (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["currentStock1"].Value.ToString()) > 0)
                        {
                            if (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) > Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["currentStock1"].Value.ToString()))
                            {
                               // DialogResult dr1 = MessageBox.Show("सदर बॅच नं-" + dgvSaleItems.CurrentRow.Cells["batchNo"].Value.ToString() + "स्टॉक " + dgvSaleItems.CurrentRow.Cells["currentStock1"].Value.ToString() + "उपलब्ध आहे,तुम्हाला " + dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString() + "नग सेल करायचे आहे काय?", "Confirmation", MessageBoxButtons.YesNo);
                                DialogResult dr1 = DialogResult.No;
                                if (Utility.Langn == "English")
                                {
                                    dr1 = MessageBox.Show("Batch No.-" + dgvSaleItems.CurrentRow.Cells["batchNo"].Value.ToString() + "Stock " + dgvSaleItems.CurrentRow.Cells["currentStock1"].Value.ToString() + "Available ,do you want to sale " + dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString() + "Quantity?", "Confirmation", MessageBoxButtons.YesNo);
                                }
                                else
                                {
                                    dr1 = MessageBox.Show("सदर बॅच नं-" + dgvSaleItems.CurrentRow.Cells["batchNo"].Value.ToString() + "स्टॉक " + dgvSaleItems.CurrentRow.Cells["currentStock1"].Value.ToString() + "उपलब्ध आहे,तुम्हाला " + dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString() + "नग सेल करायचे आहे काय?", "Confirmation", MessageBoxButtons.YesNo);
                                }
                                if (dr1 == DialogResult.Yes)
                                {
                                    dgvSaleItems.CurrentRow.Cells["HNSCode"].Value = dgvSaleItems.CurrentRow.Cells["HNSCode"].Value.ToString();
                                    dgvSaleItems.CurrentRow.Cells["batchNo"].Value = dgvSaleItems.CurrentRow.Cells["batchNo"].Value.ToString();
                                    dgvSaleItems.CurrentRow.Cells["salesItemDetailsId"].Value = dgvSaleItems.CurrentRow.Cells["salesItemDetailsId"].Value;
                                    dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value = dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value.ToString();
                                    dgvSaleItems.CurrentRow.Cells["expireDate"].Value = dgvSaleItems.CurrentRow.Cells["expireDate"].Value.ToString();
                                    dgvSaleItems.CurrentRow.Cells["Quantity"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString());
                                    dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dgvSaleItems.CurrentRow.Cells["unitBy"].Value.ToString();
                                    dgvSaleItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString());
                                    // dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString());
                                    dgvSaleItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString());
                                    dgvSaleItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString());
                                    dgvSaleItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString());
                                    dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()), 0);
                                    dgvItemName.Hide();
                                    if (dgvSaleItems.CurrentCell.ColumnIndex == 13)
                                    {
                                        dgvSaleItems.CurrentRow.Cells["Rate"].Value = Math.Round(((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value.ToString()) * 100) / (100 + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()))), 2);
                                    }
                                    if (dgvSaleItems.CurrentCell.ColumnIndex == 14)
                                    {
                                        dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value = Math.Round((Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Rate"].Value) + (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) / 100)), 2);

                                    }
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

                                    if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                                    {
                                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString())) * purRate / 100), 2);
                                        dgvSaleItems.CurrentRow.Cells["CGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString())) / 2);
                                        dgvSaleItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                                        dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100), 2);
                                        dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()))), 2);
                                    }
                                    else
                                    {
                                        dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100), 2);
                                        dgvSaleItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                                        dgvSaleItems.CurrentRow.Cells["IGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * 2);
                                        dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()))), 2);
                                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString()), 2);

                                    }
                                    // dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100);
                                    dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString())), 2);
                                }
                                else
                                {
                                    if (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["currentStock1"].Value.ToString()) > 0)
                                    {
                                        dgvSaleItems.CurrentRow.Cells["Quantity"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["currentStock1"].Value.ToString());
                                    }
                                }
                            }
                            else
                            {
                                dgvSaleItems.CurrentRow.Cells["HNSCode"].Value = dgvSaleItems.CurrentRow.Cells["HNSCode"].Value.ToString();
                                dgvSaleItems.CurrentRow.Cells["batchNo"].Value = dgvSaleItems.CurrentRow.Cells["batchNo"].Value.ToString();
                                dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value = dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value.ToString();
                                dgvSaleItems.CurrentRow.Cells["expireDate"].Value = dgvSaleItems.CurrentRow.Cells["expireDate"].Value.ToString();
                                dgvSaleItems.CurrentRow.Cells["Quantity"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString());
                                dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dgvSaleItems.CurrentRow.Cells["unitBy"].Value.ToString();
                                dgvSaleItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString());
                                //   dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value = 0;
                                // dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString());
                                dgvSaleItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString());
                                dgvSaleItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString());
                                dgvSaleItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString());
                                //dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()), 2);
                                dgvItemName.Hide();
                                if (dgvSaleItems.CurrentCell.ColumnIndex == 13)
                                {
                                    dgvSaleItems.CurrentRow.Cells["Rate"].Value = Math.Round(((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value.ToString()) * 100) / (100 + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()))), 2);
                                }
                                if (dgvSaleItems.CurrentCell.ColumnIndex == 14)
                                {
                                    dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()) + (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) / 100)), 2);

                                }
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
                                if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                                {
                                    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString())) * purRate / 100), 2);
                                    dgvSaleItems.CurrentRow.Cells["CGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString())) / 2);
                                    dgvSaleItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                                    dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100), 2);
                                    dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()))), 2);
                                }
                                else
                                {
                                    dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100), 2);
                                    dgvSaleItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                                    dgvSaleItems.CurrentRow.Cells["IGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * 2);
                                    dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()))), 2);
                                    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString()), 2);

                                }
                                dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString())), 2);
                            }
                        }
                        else
                        {
                            dgvSaleItems.CurrentRow.Cells["HNSCode"].Value = dgvSaleItems.CurrentRow.Cells["HNSCode"].Value.ToString();
                            dgvSaleItems.CurrentRow.Cells["batchNo"].Value = dgvSaleItems.CurrentRow.Cells["batchNo"].Value.ToString();
                            dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value = dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value.ToString();
                            dgvSaleItems.CurrentRow.Cells["expireDate"].Value = dgvSaleItems.CurrentRow.Cells["expireDate"].Value.ToString();
                            dgvSaleItems.CurrentRow.Cells["Quantity"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString());
                            dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dgvSaleItems.CurrentRow.Cells["unitBy"].Value.ToString();
                            dgvSaleItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString());

                            dgvSaleItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString());
                            dgvSaleItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString());
                            dgvSaleItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString());
                            dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()), 0);
                            dgvItemName.Hide();
                            if (dgvSaleItems.CurrentCell.ColumnIndex == 13)
                            {
                                dgvSaleItems.CurrentRow.Cells["Rate"].Value = Math.Round(((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value.ToString()) * 100) / (100 + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()))), 2);
                            }
                            if (dgvSaleItems.CurrentCell.ColumnIndex == 14)
                            {
                                dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()) + (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) / 100)), 2);

                            }
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
                            if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                            {
                                dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString())) * purRate / 100), 2);
                                dgvSaleItems.CurrentRow.Cells["CGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString())) / 2);
                                dgvSaleItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                                dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100), 2);
                                dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()))), 2);
                            }
                            else
                            {
                                dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100), 2);
                                dgvSaleItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                                dgvSaleItems.CurrentRow.Cells["IGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * 2);
                                dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()))), 2);
                                dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString()), 2);

                            }
                            dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString())), 2);
                        }
                    }
                    else
                    {
                        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = 0;
                    }
                    //}
                }

                if (value != null)
                {
                    DataTable dtitem = null;
                    if (rbtnCash.Checked == true)
                    {
                        dtitem = TempSaleDetailsController.getTempStockInSaleItemDetails(value, "cash");
                    }
                    if (rbtnCredit.Checked == true)
                    {
                        dtitem = TempSaleDetailsController.getTempStockInSaleItemDetails(value, "credit");
                    }
                    if (dtitem.Rows.Count > 0)
                    {
                        dgvItemName.DataSource = dtitem;
                        dgvItemName.Columns[0].Visible = false;
                        dgvItemName.Columns[1].Width = 500;
                        dgvItemName.ClearSelection();
                        this.dgvItemName.CellBorderStyle = DataGridViewCellBorderStyle.None;
                        pnlItemName.Visible = true;
                        dgvItemName.Show();
                        //dgvItemName.Focus();
                        //dgvItemName.CurrentCell = dgvItemName.Rows[0].Cells[1];
                    }
                }
                else
                {

                }
                //if (dgvSaleItems.CurrentRow.Cells["Quantity"].Value != null)
                //{
                //    if (dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString() != "0")
                //    {
                //        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString());
                //        dgvItemName.Hide();
                //        double discount = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) *Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())) / 100);
                //        double purRate = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()) - discount));
                //        double vats = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["vat"].Value) * purRate / 100);
                //        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + vats).ToString();
                //    }
                //    else
                //    {
                //        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = "0";
                //    }

                //}

                subtot();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void subtot()
        {
            try
            {
                double sum = 0, SGSTTotal = 0, CGSTTotal = 0, IGSTTotal = 0;
                IGST5 = 0; IGST12 = 0; IGST18 = 0; IGST28 = 0;
                for (int i = 0; i < dgvSaleItems.Rows.Count; ++i)
                {
                    if (dgvSaleItems.Rows[i].Cells["totalAmount"].Value != null)
                    {
                        sum += Math.Round(Utility.ParseValue(dgvSaleItems.Rows[i].Cells["totalAmount"].Value.ToString()), 2);
                        SGSTTotal += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["SGSTAmt"].Value.ToString());
                        CGSTTotal += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["CGSTAmt"].Value.ToString());
                        IGSTTotal += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["IGSTAmt"].Value.ToString());

                        if (dgvSaleItems.Rows[i].Cells["IGST"].Value.ToString() == "5")
                        {
                            IGST5 += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                        }
                        if (dgvSaleItems.Rows[i].Cells["IGST"].Value.ToString() == "12")
                        {
                            IGST12 += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                        }
                        if (dgvSaleItems.Rows[i].Cells["IGST"].Value.ToString() == "18")
                        {
                            IGST18 += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                        }
                        if (dgvSaleItems.Rows[i].Cells["IGST"].Value.ToString() == "28")
                        {
                            IGST28 += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                        }
                    }
                }
                txtNetAmount.Text = Math.Round(Convert.ToDouble(sum), 2).ToString();
                if (cmbGST.Text.ToString() != "Maharashtra")
                {
                    txtCGSTTotalAmount.Text = IGSTTotal.ToString();
                }
                else
                {
                    txtSGSTTotalAmount.Text = SGSTTotal.ToString();
                    txtCGSTTotalAmount.Text = CGSTTotal.ToString();
                }
                //string netamount = txtNetAmount.Text;
                //if (rbtnCash.Checked == true)
                //{
                //    txtPaidAmount.Text = txtNetAmount.Text;
                //    txtBalanceAmount.Text = "0";
                //}
                //if (rbtnCredit.Checked == true)
                //{
                //    if (txtNetAmount.Text != string.Empty && txtPaidAmount.Text != string.Empty)
                //    {
                //        txtBalanceAmount.Text = (Convert.ToDouble(Utility.ParseValue(txtNetAmount.Text)) - Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text))).ToString();
                //    }
                //    else
                //    {
                //        txtBalanceAmount.Text = netamount;
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvSaleItems_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    int col = dgvSaleItems.CurrentCell.ColumnIndex;
                    int row = dgvSaleItems.CurrentCell.RowIndex;
                    if (dgvSaleItems.CurrentCell.ColumnIndex == 22)
                    {
                        col = 0;
                        row++;
                    }
                    else
                    {
                        if (col < dgvSaleItems.ColumnCount)
                        {
                            col++;
                        }
                        else
                        {
                            col = 0;
                            row++;
                        }
                    }
                    if (dgvSaleItems.CurrentRow.Cells["itemId"].Value == null)
                    {
                        dgvItemName.Focus();
                        dgvItemName.CurrentCell = dgvItemName.CurrentRow.Cells["itemName"];
                        dgvItemName.CurrentCell.Selected = true;
                    }
                    else
                    {
                        if (dgvSaleItems.CurrentRow.Cells["itemName"].Value != null)
                        {
                            if (row == dgvSaleItems.RowCount)
                            {
                                dgvminimumperchase.Visible = false;
                                dgvSaleItems.Rows.Add();
                                dgvSaleItems.CurrentCell = dgvSaleItems[col + 5, row];
                            }
                            else if (dgvSaleItems.CurrentCell.ColumnIndex == 10)
                            {
                                dgvSaleItems.CurrentCell = dgvSaleItems[col + 1, row];
                            }
                            else if (dgvSaleItems.CurrentCell.ColumnIndex == 14)
                            {
                                dgvSaleItems.CurrentCell = dgvSaleItems[col + 2, row];
                            }
                            else
                            {
                                dgvSaleItems.CurrentCell = dgvSaleItems[col, row];
                            }
                        }
                    }
                    e.Handled = true;
                }
                if ((e.KeyCode == Keys.F10 && e.Shift))
                {

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
            try
            {
                if (isupdate == true)
                {
                    if (dgvSaleItems.Rows[rowIndex].Cells["itemId"].Value != null)
                    {
                        SaleDetailsController.deleteSalesInvoiceRow(saleUpdateId, txtStateCode.Text.Trim(), Convert.ToInt64(dgvSaleItems.Rows[rowIndex].Cells["salesItemDetailsId"].Value)
                            , Convert.ToInt64(dgvSaleItems.Rows[rowIndex].Cells["itemId"].Value),
                            Convert.ToInt64(dgvSaleItems.Rows[rowIndex].Cells["categoryId"].Value)
                            , Convert.ToInt64(dgvSaleItems.Rows[rowIndex].Cells["companyId"].Value),
                            Convert.ToString(dgvSaleItems.Rows[rowIndex].Cells["batchNo"].Value),
                                                                     Utility.ParseValue(dgvSaleItems.Rows[rowIndex].Cells["Quantity"].Value.ToString())
                                                                      , Convert.ToInt64(dgvSaleItems.Rows[rowIndex].Cells["StockId"].Value), Utility.ParseValue(dgvSaleItems.Rows[rowIndex].Cells["IGSTAmt"].Value.ToString()), Utility.ParseValue(dgvSaleItems.Rows[rowIndex].Cells["IGST"].Value.ToString()), false);
                    }
                }
                if (Convert.ToBoolean(dgvSaleItems.Rows[rowIndex].Cells["isPesticide"].Value) != true)
                {
                    InvoiceIdFertilizerId = "0";
                }
                if (Convert.ToBoolean(dgvSaleItems.Rows[rowIndex].Cells["isFertilizer"].Value) != true)
                {
                    InvoiceIdPesticideId = "0";
                }
                if (Convert.ToBoolean(dgvSaleItems.Rows[rowIndex].Cells["isSeeds"].Value) != true)
                {
                    InvoiceIdSeedsId = "0";
                }
                if (Convert.ToBoolean(dgvSaleItems.Rows[rowIndex].Cells["isPGROthers"].Value) != true)
                {
                    InvoiceIdPGROther = "0";
                }
                rowToDelete = dgvSaleItems.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                dgvSaleItems.Rows.RemoveAt(rowToDelete);
                dgvSaleItems.ClearSelection();
                if (dgvSaleItems.Rows.Count == 0)
                {
                    dgvSaleItems.Rows.Add();
                }
                subtot();
            }
            catch (Exception esc)
            {
                MessageBox.Show(esc.Message);
            }
        }

        private void dgvSaleItems_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.dgvSaleItems.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.contextMenuStrip1.Show(this.dgvSaleItems, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
            catch (Exception esc)
            {
                MessageBox.Show(esc.Message);
            }
        }
        public double currentStock = 0;
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
                    foreach (DataGridViewRow rows in dgvSaleItems.Rows)
                    {
                        if (rows.Cells["itemId"].Value != null && rows.Cells["companyId"].Value != null && rows.Cells["categoryId"].Value != null && rows.Cells["batchNo"].Value != null && rows.Cells["itemName"].Value != null)
                        {
                            if (rows.Cells["itemId"].Value.ToString().Equals(dt.Rows[0]["itemId"].ToString()) && rows.Cells["companyId"].Value.ToString().Equals(dt.Rows[0]["companyId"].ToString()) && rows.Cells["categoryId"].Value.ToString().Equals(dt.Rows[0]["categoryId"].ToString()) && rows.Cells["batchNo"].Value.ToString().Equals(dt.Rows[0]["batchNo"].ToString()) && rows.Cells["itemName"].Value.ToString().Equals(dt.Rows[0]["itemName"].ToString()))
                            {
                                if (Utility.Langn == "English")
                                {
                                    MessageBox.Show("This Item details already present in list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("कृपया माहिती लिस्ट मध्ये आधीच उपलब्ध आहे !", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                dgvSaleItems.Focus();
                                return;
                            }
                        }
                    }


                    bool isExpire = false;
                    if (Convert.ToDouble(dt.Rows[0]["currentStock"]) <= 0)
                    {
                      //  DialogResult dr1 = MessageBox.Show("बॅच नं.:- " + Convert.ToString(dt.Rows[0]["batchNo"]) + " स्टॅाक उपलब्ध नाही, स्टॅाक 0 असताना वस्तु सेल करायची का ?", "Confirmation", MessageBoxButtons.YesNo);
                        DialogResult dr1 = DialogResult.No;
                        if (Utility.Langn == "English")
                        {
                            dr1 = MessageBox.Show("Batch No.:- " + Convert.ToString(dt.Rows[0]["batchNo"]) + " Currently this item is out of stock, Stock contains 0 then you want to sale this item ?", "Confirmation", MessageBoxButtons.YesNo);
                        }
                        else
                        {
                            dr1 = MessageBox.Show("बॅच नं.:- " + Convert.ToString(dt.Rows[0]["batchNo"]) + " स्टॅाक उपलब्ध नाही, स्टॅाक 0 असताना वस्तु सेल करायची का ?", "Confirmation", MessageBoxButtons.YesNo);
                        }
                        if (dr1 == DialogResult.Yes)
                        {
                            if (Convert.ToDateTime(dt.Rows[0]["expireDate"]) <= DateTime.UtcNow && Convert.ToBoolean(dt.Rows[0]["isExpiryApplicable"]) == true)
                            {
                                DialogResult showReport = DialogResult.No;
                                if (Utility.Langn == "English")
                                {
                                    showReport = MessageBox.Show("This item expired ,do you want to sale it?", "", MessageBoxButtons.YesNo);
                                }
                                else
                                {
                                    showReport = MessageBox.Show(" वस्तु एक्सपायर झाली आहे, विकायची आहे का ?", "", MessageBoxButtons.YesNo);
                                }
                                if (showReport == DialogResult.Yes)
                                {
                                    isExpire = true;
                                }
                                else
                                {
                                    isExpire = false;
                                }
                            }
                            else
                            {
                                isExpire = true;
                            }
                            if (isExpire == true)
                            {
                                dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dt.Rows[0]["itemId"]);
                                dgvSaleItems.CurrentRow.Cells["salesItemDetailsId"].Value = Convert.ToInt64(0);
                                dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dt.Rows[0]["StockId"]);
                                dgvSaleItems.CurrentRow.Cells["salesChallanId"].Value = 0;
                                dgvSaleItems.CurrentRow.Cells["currentStock1"].Value = Convert.ToInt32(dt.Rows[0]["currentStock"]);
                                dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dt.Rows[0]["categoryId"]);
                                dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dt.Rows[0]["companyId"]);
                                dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dt.Rows[0]["batchNo"]);
                                dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value = Convert.ToString(dt.Rows[0]["MFD_Date"]);
                                dgvSaleItems.CurrentRow.Cells["expireDate"].Value = Convert.ToString(dt.Rows[0]["expireDate"]);
                                dgvSaleItems.CurrentRow.Cells["HNSCode"].Value = Convert.ToString(dt.Rows[0]["HNSCode"]);
                                dgvSaleItems.CurrentRow.Cells["itemName"].Value = dt.Rows[0]["itemName"].ToString();
                                dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dt.Rows[0]["unitBy"].ToString();
                                //  DataTable purchRate = new DataTable();
                                //purchRate = SaleDetailsController.getminimumPurchaseRate(Convert.ToInt64(dgvSaleItems.CurrentRow.Cells["itemId"].Value), Convert.ToInt64(dgvSaleItems.CurrentRow.Cells["companyId"].Value), Convert.ToInt64(dgvSaleItems.CurrentRow.Cells["categoryId"].Value), dgvSaleItems.CurrentRow.Cells["batchNo"].Value.ToString(), dgvSaleItems.CurrentRow.Cells["UnitBy"].Value.ToString());
                                //dgvminimumperchase.Visible = true;
                                //dgvminimumperchase.DataSource = purchRate;
                                if (dt.Rows[0]["mainCategory"].ToString() == "किटकनाशके")
                                {
                                    dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = true;
                                    dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = false;
                                    dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = false;
                                    dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = false;
                                    if (isPesticideId != "0")
                                    {
                                        dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = isPesticideId;
                                        InvoiceIdPesticideId = isPesticideId;
                                    }
                                    else
                                    {
                                        dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = SaleDetailsController.getMaxIdSalesItemDetails(1, Utility.FinancilaYearId).ToString();
                                        InvoiceIdPesticideId = SaleDetailsController.getMaxIdSalesItemDetails(1, Utility.FinancilaYearId).ToString();
                                    }

                                }
                                else if (dt.Rows[0]["mainCategory"].ToString() == "खते")
                                {
                                    dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = false;
                                    dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = true;
                                    dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = false;
                                    dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = false;
                                    if (isFertilizerId != "0")
                                    {
                                        dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = isFertilizerId;
                                        InvoiceIdFertilizerId = isFertilizerId;
                                    }
                                    else
                                    {
                                        dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = SaleDetailsController.getMaxIdSalesItemDetails(2, Utility.FinancilaYearId).ToString();
                                        InvoiceIdFertilizerId = SaleDetailsController.getMaxIdSalesItemDetails(2, Utility.FinancilaYearId).ToString();
                                    }
                                }
                                else if (dt.Rows[0]["mainCategory"].ToString() == "बियाणे")
                                {
                                    dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = false;
                                    dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = false;
                                    dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = true;
                                    dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = false;
                                    if (isSeedsId != "0")
                                    {
                                        dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = isSeedsId;
                                        InvoiceIdSeedsId = isSeedsId;
                                    }
                                    else
                                    {
                                        dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = SaleDetailsController.getMaxIdSalesItemDetails(3, Utility.FinancilaYearId).ToString();
                                        InvoiceIdSeedsId = SaleDetailsController.getMaxIdSalesItemDetails(3, Utility.FinancilaYearId).ToString();
                                    }
                                }
                                else
                                {
                                    dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = false;
                                    dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = false;
                                    dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = false;
                                    dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = true;
                                    dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = isPGROther;
                                    if (isPGROther != "0")
                                    {
                                        dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = isPGROther;
                                        InvoiceIdPGROther = isPGROther;
                                    }
                                    else
                                    {
                                        dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = SaleDetailsController.getMaxIdSalesItemDetails(4, Utility.FinancilaYearId).ToString();
                                        InvoiceIdPGROther = SaleDetailsController.getMaxIdSalesItemDetails(4, Utility.FinancilaYearId).ToString();
                                    }
                                }
                                // dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = "";
                                //if (Convert.ToDateTime(dgvSaleItems.CurrentRow.Cells["expireDate"].Value) < DateTime.UtcNow)
                                //{
                                //    MessageBox.Show("वस्तु एक्सपायर झाली आहे", "", MessageBoxButtons.OK);
                                //}
                                // dgvSaleItems.CurrentRow.Cells["isExpiryApplicable"].Value = dt.Rows[0]["isExpiryApplicable"].ToString();

                                dgvSaleItems.CurrentRow.Cells["Quantity"].Value = 1;
                                dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dt.Rows[0]["unitBy"].ToString();

                                if (rbtnCash.Checked == true)
                                {
                                    dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dt.Rows[0]["salesCashRate"].ToString());
                                }
                                if (rbtnCredit.Checked == true)
                                {
                                    dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dt.Rows[0]["salesCreditRate"].ToString());
                                }
                                dgvSaleItems.CurrentRow.Cells["discount"].Value = 0;
                                // dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value = 0;
                                dgvSaleItems.CurrentRow.Cells["IGST"].Value = Math.Round(Utility.ParseValue(dt.Rows[0]["IGST"].ToString()), 2);
                                dgvSaleItems.CurrentRow.Cells["CGST"].Value = Math.Round(Utility.ParseValue(dt.Rows[0]["CGST"].ToString()), 2);
                                dgvSaleItems.CurrentRow.Cells["SGST"].Value = Math.Round(Utility.ParseValue(dt.Rows[0]["SGST"].ToString()), 2);
                                //dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()));
                                dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value = Math.Round((Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Rate"].Value) + (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Rate"].Value) * Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["IGST"].Value) / 100)), 2);
                                // dgvSaleItems.CurrentRow.Cells["Rate"].Value = Math.Round((Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value.ToString()) * Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) / 100), 2);
                                // double discount = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["discount"].Value) * (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Rate"].Value)) / 100);
                                double purRate = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())));
                                // dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["SGST"].Value) * purRate / 100);
                                // dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["CGST"].Value) * purRate / 100);
                                //dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["IGST"].Value) * purRate / 100);

                                if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                                {
                                    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["IGST"].ToString()) * purRate / 100), 2);
                                    dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["CGST"].ToString()) * purRate / 100), 2);
                                    dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["SGST"].ToString()) * purRate / 100), 2);
                                }
                                else
                                {
                                    dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["CGST"].ToString()) * purRate / 100), 2);
                                    dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["SGST"].ToString()) * purRate / 100), 2);
                                    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString()), 2);
                                }
                                dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()))).ToString();
                                subtot();
                                //  dgvSaleItems.Focus();
                                dgvSaleItems.CurrentCell = dgvSaleItems.CurrentRow.Cells["Quantity"];
                                dgvSaleItems.BeginEdit(true);
                            }
                        }
                        else if (dr1 == DialogResult.No)
                        {
                            //Nothing to do
                        }
                    }
                    else
                    {
                        if (Convert.ToDateTime(dt.Rows[0]["expireDate"]) <= DateTime.UtcNow && Convert.ToBoolean(dt.Rows[0]["isExpiryApplicable"]) == true)
                        {
                            DialogResult showReport = MessageBox.Show(/*Convert.ToString(dt.Rows[0]["itemName"]) + Convert.ToString(dt.Rows[0]["expireDate"]) + */" वस्तु एक्सपायर झाली आहे, विकायची आहे का ?", "", MessageBoxButtons.YesNo);
                            if (showReport == DialogResult.Yes)
                            {
                                isExpire = true;
                            }
                            else
                            {
                                isExpire = false;
                            }
                        }
                        else
                        {
                            isExpire = true;
                        }
                        if (isExpire == true)
                        {

                            dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dt.Rows[0]["itemId"]);
                            dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dt.Rows[0]["StockId"]);
                            dgvSaleItems.CurrentRow.Cells["salesChallanId"].Value = 0;
                            dgvSaleItems.CurrentRow.Cells["salesItemDetailsId"].Value = Convert.ToInt64(0);
                            dgvSaleItems.CurrentRow.Cells["currentStock1"].Value = Convert.ToInt32(dt.Rows[0]["currentStock"]);
                            dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dt.Rows[0]["categoryId"]);
                            dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dt.Rows[0]["companyId"]);
                            dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dt.Rows[0]["batchNo"]);
                            dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value = Convert.ToString(dt.Rows[0]["MFD_Date"]);
                            dgvSaleItems.CurrentRow.Cells["expireDate"].Value = Convert.ToString(dt.Rows[0]["expireDate"]);
                            dgvSaleItems.CurrentRow.Cells["HNSCode"].Value = Convert.ToString(dt.Rows[0]["HNSCode"]);
                            dgvSaleItems.CurrentRow.Cells["itemName"].Value = dt.Rows[0]["itemName"].ToString();
                            dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dt.Rows[0]["unitBy"].ToString();
                            //DataTable purchRate = new DataTable();
                            //purchRate = SaleDetailsController.getminimumPurchaseRate(Convert.ToInt64(dgvSaleItems.CurrentRow.Cells["itemId"].Value), Convert.ToInt64(dgvSaleItems.CurrentRow.Cells["companyId"].Value), Convert.ToInt64(dgvSaleItems.CurrentRow.Cells["categoryId"].Value), dgvSaleItems.CurrentRow.Cells["batchNo"].Value.ToString(), dgvSaleItems.CurrentRow.Cells["UnitBy"].Value.ToString());
                            //dgvminimumperchase.Visible = true;
                            //dgvminimumperchase.DataSource = purchRate;
                            if (dt.Rows[0]["mainCategory"].ToString() == "किटकनाशके")
                            {
                                dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = true;
                                dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = false;
                                dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = false;
                                dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = false;
                                if (isPesticideId != "0")
                                {
                                    dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = isPesticideId;
                                    InvoiceIdPesticideId = isPesticideId;
                                }
                                else
                                {
                                    dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = SaleDetailsController.getMaxIdSalesItemDetails(1, Utility.FinancilaYearId).ToString();
                                    InvoiceIdPesticideId = SaleDetailsController.getMaxIdSalesItemDetails(1, Utility.FinancilaYearId).ToString();
                                }
                            }
                            else if (dt.Rows[0]["mainCategory"].ToString() == "खते")
                            {
                                dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = false;
                                dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = true;
                                dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = false;
                                dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = false;

                                if (isFertilizerId != "0")
                                {
                                    dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = isFertilizerId;
                                    InvoiceIdFertilizerId = isFertilizerId;
                                }
                                else
                                {
                                    dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = SaleDetailsController.getMaxIdSalesItemDetails(2, Utility.FinancilaYearId).ToString();
                                    InvoiceIdFertilizerId = SaleDetailsController.getMaxIdSalesItemDetails(2, Utility.FinancilaYearId).ToString();
                                }
                            }
                            else if (dt.Rows[0]["mainCategory"].ToString() == "बियाणे")
                            {
                                dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = false;
                                dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = false;
                                dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = true;
                                dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = false;
                                if (isFertilizerId != "0")
                                {
                                    dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = isSeedsId;
                                    InvoiceIdSeedsId = isSeedsId;
                                }
                                else
                                {
                                    dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = SaleDetailsController.getMaxIdSalesItemDetails(3, Utility.FinancilaYearId).ToString();
                                    InvoiceIdSeedsId = SaleDetailsController.getMaxIdSalesItemDetails(3, Utility.FinancilaYearId).ToString();
                                }
                            }
                            else
                            {
                                dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = false;
                                dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = false;
                                dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = false;
                                dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = true;

                                if (isPGROther != "0")
                                {
                                    dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = isPGROther;
                                    InvoiceIdPGROther = isPGROther;
                                }
                                else
                                {
                                    dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = SaleDetailsController.getMaxIdSalesItemDetails(4, Utility.FinancilaYearId).ToString();
                                    InvoiceIdPGROther = SaleDetailsController.getMaxIdSalesItemDetails(4, Utility.FinancilaYearId).ToString();
                                }
                            }
                            //if (Convert.ToDateTime(dgvSaleItems.CurrentRow.Cells["expireDate"].Value) < DateTime.UtcNow)
                            //{
                            //    MessageBox.Show("वस्तु एक्सपायर झाली आहे", "", MessageBoxButtons.OK);
                            //}
                            // dgvSaleItems.CurrentRow.Cells["isExpiryApplicable"].Value = dt.Rows[0]["isExpiryApplicable"].ToString();

                            dgvSaleItems.CurrentRow.Cells["Quantity"].Value = 1;


                            if (rbtnCash.Checked == true)
                            {
                                dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dt.Rows[0]["salesCashRate"].ToString());
                            }
                            if (rbtnCredit.Checked == true)
                            {
                                dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dt.Rows[0]["salesCreditRate"].ToString());
                            }
                            dgvSaleItems.CurrentRow.Cells["discount"].Value = 0;
                            dgvSaleItems.CurrentRow.Cells["IGST"].Value = Math.Round(Utility.ParseValue(dt.Rows[0]["IGST"].ToString()), 2);
                            dgvSaleItems.CurrentRow.Cells["CGST"].Value = Math.Round(Utility.ParseValue(dt.Rows[0]["CGST"].ToString()), 2);
                            dgvSaleItems.CurrentRow.Cells["SGST"].Value = Math.Round(Utility.ParseValue(dt.Rows[0]["SGST"].ToString()), 2);
                            // dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()));
                            dgvSaleItems.CurrentRow.Cells["SaleRatewithGST"].Value = Math.Round((Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Rate"].Value) + (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Rate"].Value) * Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["IGST"].Value) / 100)), 2);
                            // double discount = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["discount"].Value) * (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Rate"].Value)) / 100);
                            double purRate = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())));
                            // dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["SGST"].Value) * purRate / 100);
                            // dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["CGST"].Value) * purRate / 100);
                            //dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["IGST"].Value) * purRate / 100);

                            if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                            {
                                dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["IGST"].ToString()) * purRate / 100), 2);
                                dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["CGST"].ToString()) * purRate / 100), 2);
                                dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["SGST"].ToString()) * purRate / 100), 2);
                            }
                            else
                            {
                                dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["CGST"].ToString()) * purRate / 100), 2);
                                dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["SGST"].ToString()) * purRate / 100), 2);
                                dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString()), 2);
                            }
                            dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()))).ToString();
                            subtot();
                            //  dgvSaleItems.Focus();
                            dgvSaleItems.CurrentCell = dgvSaleItems.CurrentRow.Cells["Quantity"];
                            dgvSaleItems.BeginEdit(true);
                            txtFertInvoiceId.Text = isFertilizerId.ToString();
                            txtSeedInvoiceId.Text = isSeedsId.ToString();
                            txtPestiInvoiceId.Text = isPesticideId.ToString();
                            txtPGRinvoiceId.Text = isPGROther.ToString();
                        }
                        else
                        {

                        }
                    }
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

        private void dgvItemName_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
                if (dgvSaleItems.CurrentCell.ColumnIndex == 10 ||
                    dgvSaleItems.CurrentCell.ColumnIndex == 12 ||
                    dgvSaleItems.CurrentCell.ColumnIndex == 13 ||
                    dgvSaleItems.CurrentCell.ColumnIndex == 15 ||
                    dgvSaleItems.CurrentCell.ColumnIndex == 17) //Desired Column
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmItemDetails frm = new frmItemDetails();
                frm.ShowDialog();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtpchedate.Value = DateTime.Now;
                if (cmbPaymentType.SelectedItem.ToString() == "Cash")
                {
                    lblBankName.Visible = false;
                    lblChequeNo.Visible = false;
                    txtBanknName.Visible = false;
                    cmbBank.Visible = false;
                    txtchqDDNo.Visible = false;
                    txtchqDDNo.Text = "";
                    txtBanknName.Text = "";
                    label33.Visible = false;
                    dtpchedate.Visible = false;

                }

                if (cmbPaymentType.SelectedItem.ToString() == "Card Payment")
                {
                    lblBankName.Visible = true;
                    lblChequeNo.Visible = true;
                    if (Utility.Langn == "English")
                    {
                        lblChequeNo.Text = "Refference No:";
                    }
                    else
                    {
                        lblChequeNo.Text = "संदर्भक्रमांक ";
                    }
                    txtBanknName.Text = "";
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
                    if (Utility.Langn == "English")
                    {
                        lblChequeNo.Text = "Refference No:";
                    }
                    else
                    {
                        lblChequeNo.Text = "संदर्भक्रमांक ";
                    }
                    cmbBank.Visible = true;
                    txtchqDDNo.Visible = true;
                    txtBanknName.Text = "";
                    txtchqDDNo.Text = "";
                    label33.Visible = false;
                    dtpchedate.Visible = false;
                }
                if (cmbPaymentType.SelectedItem.ToString() == "NEFT")
                {
                    lblBankName.Visible = true;
                    lblChequeNo.Visible = true;
                    if (Utility.Langn == "English")
                    {
                        lblChequeNo.Text = "Refference No:";
                    }
                    else
                    {
                        lblChequeNo.Text = "संदर्भक्रमांक ";
                    }
                    cmbBank.Visible = true;
                    txtchqDDNo.Visible = true;
                    txtBanknName.Text = "";
                    txtchqDDNo.Text = "";
                    label33.Visible = false;
                    dtpchedate.Visible = false;
                }
                if (cmbPaymentType.SelectedItem.ToString() == "RTGS")
                {
                    lblBankName.Visible = true;
                    lblChequeNo.Visible = true;
                    if (Utility.Langn == "English")
                    {
                        lblChequeNo.Text = "Refference No:";
                    }
                    else
                    {
                        lblChequeNo.Text = "संदर्भक्रमांक ";
                    }
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
                    if (Utility.Langn == "English")
                    {
                        lblChequeNo.Text = "Cheque/DD No:";
                    }
                    else
                    {
                        lblChequeNo.Text = "चेक /डीडी क्रमांक";
                    }
                    cmbBank.Visible = true;
                    txtchqDDNo.Visible = true;
                    txtBanknName.Text = "";
                    txtchqDDNo.Text = "";
                    label33.Visible = true;
                    dtpchedate.Visible = true;
                }
                BindBank();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindBank()
        {
            try
            {
                Utility.BindComboBoxDataSelect(cmbBank, accountDetailsController.GetAccountWisePaymentDue(0, "BankBind", Utility.FinancilaYearId), "accountId", "accountName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void popLimiation_Click(object sender, EventArgs e)
        {
            try
            {

                savebill(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void savebill(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvSaleItems.Rows.Count; i++)
                {
                    if (dgvSaleItems.Rows[i].Cells["itemName"].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Item Name in List..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये वस्तूचे नाव भरा..");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[4];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells["batchNo"].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Batch No. in List..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये ब्याच नंबर भरा");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[6];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells["Quantity"].Value == null)
                    {

                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Quantity in List..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये नग भरा");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[7];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells["Quantity"].Value == null)
                    {
                        dgvSaleItems.Rows[i].Cells["Quantity"].Value = "नग";
                    }
                    if (dgvSaleItems.Rows[i].Cells["Rate"].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Rate in List..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये दर भरा");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells["Rate"];
                        return;
                    }

                    else
                    {
                        dgvSaleItems.Rows[i].Cells["Rate"].Value = Utility.ParseValue(dgvSaleItems.Rows[i].Cells["Rate"].Value.ToString());
                    }
                    if (Convert.ToBoolean(dgvSaleItems.Rows[i].Cells["isPesticide"].Value) == true)
                    {

                        InvoiceIdPesticideId = dgvSaleItems.Rows[i].Cells["InvoiceNo"].Value.ToString();

                    }
                    if (Convert.ToBoolean(dgvSaleItems.Rows[i].Cells["isFertilizer"].Value) == true)
                    {
                        InvoiceIdFertilizerId = dgvSaleItems.Rows[i].Cells["InvoiceNo"].Value.ToString();
                    }
                    if (Convert.ToBoolean(dgvSaleItems.Rows[i].Cells["isSeeds"].Value) == true)
                    {
                        InvoiceIdSeedsId = dgvSaleItems.Rows[i].Cells["InvoiceNo"].Value.ToString();
                    }
                    if (Convert.ToBoolean(dgvSaleItems.Rows[i].Cells["isPGROthers"].Value) == true)
                    {
                        InvoiceIdPGROther = dgvSaleItems.Rows[i].Cells["InvoiceNo"].Value.ToString();
                    }
                    if (dgvSaleItems.Rows[i].Cells["IGST"].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add IGST (%) in List..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये IGST (%) भरा ");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells["IGST"];
                        return;
                    }
                    //if (dgvSaleItems.Rows[i].Cells[9].Value == null )
                    //{
                    //    MessageBox.Show("कृपया लिस्ट मध्ये Tax(कर)% भरा");
                    //    dgvSaleItems.Focus();
                    //    dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[9];
                    //    return;
                    //}


                    if (dgvSaleItems.Rows[i].Cells["totalAmount"].Value == null || Utility.ParseValue(dgvSaleItems.Rows[i].Cells["totalAmount"].Value.ToString()) == 0)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Total Amount in List..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये पूर्ण रक्कम भरा");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells["totalAmount"];
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
                /// long customerId = 0;

                if (rbtnCredit.Checked == true)
                {
                    if (cmbCustomerName.Text == string.Empty || cmbCustomerName.Text == "-- Select --")
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Select Customer Name ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया ग्राहकाचे नाव निवडा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cmbCustomerName.Focus();
                        return;
                    }
                    if (txtPaidAmount.Text == string.Empty)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Fill Paid Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया द्यावयाची रक्कम भरा", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        txtPaidAmount.Focus();
                        return;
                    }
                }
                if (txtHamali.Text == string.Empty)
                {
                    txtHamali.Text = "0";
                }
                SalesDetails purch = new SalesDetails();
                string customerName1 = cmbCustomerName.Text.Trim();
                if (cmbCustomerName.SelectedValue == null)
                {
                    customerDetails customers = new customerDetails();
                    customers.customerId = 0;
                    customers.customerName = cmbCustomerName.Text.Trim();
                    customers.customerAddress = txtaddress.Text.Trim();
                    customers.CustomerGSTNo = txtGSTNo.Text.Trim();
                    if (txtmobile.Text == "")
                    {
                        customers.customerMobileNo = "";
                    }
                    else
                    {
                        customers.customerMobileNo = Utility.ParseValueI(txtmobile.Text).ToString();
                    }
                    customers.DOB = DateTime.Now;
                    customers.genderId = "1";
                    customers.villageId = Convert.ToInt32(0);
                    customers.contactPerson = txtContactPerson.Text;
                    customers.contactNo = txtContactNo.Text;
                    customers.FinancialYearID = Utility.FinancilaYearId;
                    customers.emailId = "";
                    if (txtlimitationAmount.Text == string.Empty)
                    {
                        customers.limitationAmount = 0;
                    }
                    else
                    {
                        customers.limitationAmount = Utility.ParseValue(txtlimitationAmount.Text);
                    }
                    customers.addedBy = Utility.LoginID;
                    customers.addedOn = Utility.firstDate;
                    customers.openigBalanace = Utility.ParseValue("0");
                    customers.fromDate = DateTime.Now;
                    customers.isCreditDebit = "";
                    customers.isCustomerRetailer = cmbCustomerRetailer.Text;
                    customers.MobileTwo = "";
                    customers.MobileThree = "";
                    customers.OtherNote = "";
                    customers.CustomerPANNo = "";
                    customers.adharNo = txtAdharNo.Text.Trim();
                    int s = customerController.addCustomerDetails(customers);
                    BindComboBoxgetCustomerName();
                    cmbCustomerName.Text = customerName1;
                    //  customerId = SaleDetailsController.getcustomerMaxId();
                    purch.customerId = Convert.ToInt64(cmbCustomerName.SelectedValue);
                }
                else
                {
                    purch.customerId = Convert.ToInt64(cmbCustomerName.SelectedValue);
                }

                DataTable dtSaleItems = new DataTable();


                foreach (DataGridViewColumn col in dgvSaleItems.Columns)
                {
                    dtSaleItems.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dgvSaleItems.Rows)
                {
                    DataRow dRow = dtSaleItems.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null)
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Please Add Complete Details In List");
                            }
                            else
                            {
                                MessageBox.Show("कृपया लिस्ट मध्ये पूर्ण माहिती भरा");
                            }
                            return;
                        }
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtSaleItems.Rows.Add(dRow);
                }

                purch.SaleItemTable = dtSaleItems;
                purch.salesDate = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                if (isupdate == false)
                {
                    purch.salesInvoiceId = TempSaleDetailsController.getMaxIdTempSaleInvoiceId(Utility.FinancilaYearId).ToString();
                }
                else
                {
                    purch.salesInvoiceId = saleUpdateId;
                }
                purch.state = cmbGST.Text;
                purch.stateCode = txtStateCode.Text;
                if (rbtnCash.Checked == true)
                {
                    purch.salesType = "Cash";
                }
                if (rbtnCredit.Checked == true)
                {
                    purch.salesType = "Credit";
                }
                purch.paymentType = cmbPaymentType.Text;
                purch.FinancialYearID = Utility.FinancilaYearId;
                purch.paidAmount = Utility.ParseValue(txtPaidAmount.Text);
                purch.totalbillAmount = Utility.ParseValue(txtNetAmount.Text);
                purch.hamali = Utility.ParseValue(txtHamali.Text);
                purch.roundOff = Utility.ParseValue(txtRoundOff.Text);
                purch.discount = Utility.ParseValue(txtDiscount.Text);
                purch.netbillAmount = Utility.ParseValue(txtTotalAmount.Text);
                if (cmbPaymentType.Text == "Cash")
                {
                    purch.chequeDate = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                }
                else
                {
                    purch.chequeDate = Convert.ToDateTime(dtpchedate.Value.ToShortDateString());
                }
                purch.bankName = cmbBank.Text;
                purch.isRetailer = Convert.ToBoolean(cmbCustomerRetailer.SelectedIndex);
                purch.InvoiceIdFertilizer = InvoiceIdFertilizerId;
                purch.InvoiceIdPesticide = InvoiceIdPesticideId;
                purch.InvoiceIdSeeds = InvoiceIdSeedsId;
                purch.InvoiceIdPGROther = InvoiceIdPGROther;
                purch.nextPaymentdate = Convert.ToDateTime(dtpNextPaymentDetails.Value.ToShortDateString());
                if (cmbBank.SelectedIndex > 0)
                {
                    purch.bankId = Convert.ToInt32(cmbBank.SelectedValue);
                }
                else
                {
                    purch.bankId = 0;
                }
                purch.chequeNo_refNo = txtchqDDNo.Text;
                purch.addedBy = Utility.LoginID;
                purch.addedOn = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                if(purch.chalanNo==string .Empty)
                {
                    purch.chalanNo = "";
                }
                else
                {
                   // purch.chalanNo = lblChalanNo.Text;
                    purch.chalanNo = txtChalanNo.Text;
                }
                PusrchaseSaleAccount purchase = new PusrchaseSaleAccount();
                purchase.RoundOff = Utility.ParseValue(txtRoundOff.Text);
                purchase.Hamali = Utility.ParseValue(txtHamali.Text);
                purchase.discount = Utility.ParseValue(txtDiscount.Text);
                purchase.billId = Convert.ToInt64(purch.salesInvoiceId);
                purchase.stateCode = txtStateCode.Text;
                purchase.issalePurchase = "sale";
                purchase.Igst5 = IGST5;
                purchase.Igst12 = IGST12;
                purchase.Igst18 = IGST18;
                purchase.Igst28 = IGST28;
                purchase.salePurchaseAccount = Math.Round(Utility.ParseValue(txtNetAmount.Text) - 2 * Utility.ParseValue(txtCGSTTotalAmount.Text), 2);
                int ks = 0;
                if (isConvertChalan == true)
                {
                    ks = TempSaleDetailsController.addTempSalesDetailsForConvertChalan(purch);
                    if (ks > 0)
                    {
                        // DialogResult ShowReport2 = MsgBox.Show("पावतीची प्रिंट हवी आहे का....?", "पावती", MsgBox.Buttons.YesNo, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                       DialogResult ShowReport2 = DialogResult.No;
                        if (Utility.Langn == "English")
                        {
                            ShowReport2 = MessageBox.Show("Do You want to print receipt....?", "Receipt", MessageBoxButtons.YesNo);
                        }
                        else
                        {
                            ShowReport2 = MessageBox.Show("पावतीची प्रिंट हवी आहे का....?", "पावती", MessageBoxButtons.YesNo);
                        }
                        if (ShowReport2 == DialogResult.Yes)
                        {
                            //    bill();
                            //   
                            //if (Utility.isSingleMultipalPrint == false)
                            //{
                            billWithGSTSlot();
                            //}
                            //if (Utility.isSingleMultipalPrint == true)
                            //{
                            //    billWithSeparate();
                            //}
                        }
                        else
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Current Sale Chalan Saved successfully..", "Save", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("सदर बिल यशस्वीरित्या साठवले गेले आहे..", "Save", MessageBoxButtons.OK);
                            }
                        }
                        btnnew_Click(sender, e);
                    }
                }
                else
                {
                    if (isDelete == true)
                    {
                        //  DialogResult dr = MsgBox.Show("तुम्हाला सदर नोंचलन डिलीट करायाचे आहे काय?", "Confirmation", MsgBox.Buttons.YesNo, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                        DialogResult dr = DialogResult.No;
                        if (Utility.Langn == "English")
                        {
                            dr = MessageBox.Show("Do you want to delete this Chalan?", "Confirmation", MessageBoxButtons.YesNo);
                        }
                        else
                        {
                            dr = MessageBox.Show("तुम्हाला सदर बिल डिलीट करायाचे आहे काय?", "Confirmation", MessageBoxButtons.YesNo);
                        }
                        if (dr == DialogResult.Yes)
                        {
                            purch.isDelete = true;
                            ks = TempSaleDetailsController.addTempSalesDetails(purch);
                        }
                        else if (dr == DialogResult.No)
                        {
                            //Nothing to do
                        }
                        if (ks > 0)
                        {
                             if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Current Chalan deleted successfully ..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("सदर बिल यशस्वीरित्या डिलीट केले गेले आहे ..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            btnnew_Click(sender, e);
                        }
                    }
                    else
                    {
                        purch.isDelete = false;
                        ks = TempSaleDetailsController.addTempSalesDetails(purch);
                        if (ks > 0)
                        {
                            // DialogResult ShowReport = MsgBox.Show("तुम्हाला  पावतीची प्रिंट हवी आहे का....?", "पावती", MsgBox.Buttons.YesNo, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);

                            //  MessageBox.Show("Record Save Successfully... !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult ShowReport = DialogResult.No;
                            if (Utility.Langn == "English")
                            {
                                ShowReport = MessageBox.Show("Do you want to print receipt....?", "Receipt", MessageBoxButtons.YesNo);
                            }
                            else
                            {
                                ShowReport = MessageBox.Show("तुम्हाला  पावतीची प्रिंट हवी आहे का....?", "पावती", MessageBoxButtons.YesNo);
                            }
                            if (ShowReport == DialogResult.Yes)
                            {
                                //bill();
                                //if (Utility.isSingleMultipalPrint == false)
                                //{
                                billWithGSTSlot();
                                //}
                                //if (Utility.isSingleMultipalPrint == true)
                                //{
                                //    billWithSeparate();
                                //}
                            }
                            else
                            {
                                if (Utility.Langn == "English")
                                {
                                    MessageBox.Show("Current Sale Bill Saved Successfully..", "Save", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    MessageBox.Show("सदर बिल यशस्वीरित्या साठवले गेले आहे..", "Save", MessageBoxButtons.OK);
                                }
                            }
                            btnnew_Click(sender, e);
                        }
                    }
                    saleUpdateId = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void billWithGSTSlot()
        {
            try
            {
                System.Globalization.RegionInfo objRegInfo = new RegionInfo("en-IN");
                string syb = objRegInfo.CurrencySymbol;
                SaleID = txtInvoiceNo.Text;
                DataTable dtSale = TempSaleDetailsController.getSaleInvoice(SaleID, Utility.FinancilaYearId);
                DataTable dtSaleByHSNCode = TempSaleDetailsController.getSaleInvoiceByHSNCode(SaleID, Utility.FinancilaYearId);
                string amountInWord = Utility.NumberToWord(Convert.ToInt64(dtSale.Rows[0]["netBillAmount"].ToString()));
                dtSale.Columns.Add(new DataColumn("amountInWord", typeof(string)));
                foreach (DataRow dr in dtSale.Rows)
                {
                   // dr["amountInWord"] = amountInWord + " " + "रुपये /- फक्त.";
                    if (Utility.Langn == "English")
                    {
                        dr["amountInWord"] = amountInWord + " " + "Rupees /- Only.";
                    }
                    else
                    {
                        dr["amountInWord"] = amountInWord + " " + "रुपये /- फक्त.";
                    }
                }
                //  RptTempCustomerBill rpt = new RptTempCustomerBill();
                // RptTempCustomerBillEnglishNew rpt = new RptTempCustomerBillEnglishNew();
                RptTempCustomerBillEnglish rpt = new RptTempCustomerBillEnglish();
              
                RptSaleBill frm = new RptSaleBill();
                //  rpt.SetDataSource(dtSale);
                rpt.Database.Tables[0].SetDataSource(dtSale);
                rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                //  rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                string outstanding = Math.Round(accountDetailsController.GetDueAmount(Convert.ToInt64(dtSale.Rows[0]["customerId"]), "customer", Utility.FinancilaYearId, Convert.ToDateTime(dtSale.Rows[0]["salesDate"])), 2).ToString();
                rpt.SetParameterValue(0, outstanding);
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Refresh();
                frm.crystalReportViewer1.Refresh();
                frm.ShowDialog();
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public void billWithSeparate()
        {
            try
            {
                System.Globalization.RegionInfo objRegInfo = new RegionInfo("en-IN");
                string syb = objRegInfo.CurrencySymbol;
                SaleID = txtInvoiceNo.Text;
                DataTable dtSale = ReportController.getcheckSaleInvoice(SaleID, Utility.FinancilaYearId);
                DataTable dtSaleSeed = ReportController.getSaleSeedInvoice(SaleID, Utility.FinancilaYearId);
                DataTable dtSalePestiside = ReportController.getSaleInsectisideInvoice(SaleID, Utility.FinancilaYearId);
                DataTable dtSaleFertilizesr = ReportController.getSaleFerTilizerInvoice(SaleID, Utility.FinancilaYearId);
                DataTable dtPGROther = ReportController.getPGROtherInvoice(SaleID, Utility.FinancilaYearId);
                DataTable dtSaleByHSNCode = ReportController.getSaleInvoiceByHSNCode(SaleID, Utility.FinancilaYearId);
                string outstanding = Math.Round(accountDetailsController.GetDueAmount(Convert.ToInt64(dtSale.Rows[0]["customerId"]), "customer", Utility.FinancilaYearId, Convert.ToDateTime(dtSale.Rows[0]["salesDate"])), 2).ToString();

                if (dtSaleSeed.Rows.Count > 0)
                {
                    long netBillAmt = Convert.ToInt64(Math.Round(Convert.ToDouble(dtSaleSeed.Compute("sum(TotalAmt)", string.Empty)), 0));
                    string amountInWord = Utility.NumberToWordMarathi(netBillAmt);
                    dtSaleSeed.Columns.Add(new DataColumn("amountInWord", typeof(string)));
                    foreach (DataRow dr in dtSaleSeed.Rows)
                    {
                        if (Utility.Langn == "English")
                        {
                            dr["amountInWord"] = amountInWord + " " + "Rupees /- Only.";
                        }
                        else
                        {
                            dr["amountInWord"] = amountInWord + " " + "रुपये /- फक्त.";
                        }
                    }
                    crptSeednvoice rpt = new crptSeednvoice();
                    RptSaleBill frm = new RptSaleBill();
                    rpt.SetDataSource(dtSaleSeed);
                    //  rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                    rpt.SetParameterValue(0, outstanding);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.Refresh();
                    frm.crystalReportViewer1.Refresh();
                    frm.ShowDialog();
                }
                if (dtSalePestiside.Rows.Count > 0)
                {
                    long netBillAmt = Convert.ToInt64(Math.Round(Convert.ToDouble(dtSalePestiside.Compute("sum(TotalAmt)", string.Empty)), 0));
                    string amountInsectInWord = Utility.NumberToWordMarathi(netBillAmt);
                    dtSalePestiside.Columns.Add(new DataColumn("amountInWord", typeof(string)));
                    foreach (DataRow dr in dtSalePestiside.Rows)
                    {
                        //dr["amountInWord"] = amountInsectInWord + " " + "रुपये /- फक्त.";
                        if (Utility.Langn == "English")
                        {
                            dr["amountInWord"] = amountInsectInWord + " " + "Rupees /- Only.";
                        }
                        else
                        {
                            dr["amountInWord"] = amountInsectInWord + " " + "रुपये /- फक्त.";
                        }
                    }
                    crptInsectisideInvoice rpt = new crptInsectisideInvoice();
                    RptSaleBill frm = new RptSaleBill();
                    rpt.SetDataSource(dtSalePestiside);
                    //  rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                    rpt.SetParameterValue(0, outstanding);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.Refresh();
                    frm.crystalReportViewer1.Refresh();
                    frm.ShowDialog();
                }
                if (dtSaleFertilizesr.Rows.Count > 0)
                {
                    long netBillAmt = Convert.ToInt64(Math.Round(Convert.ToDouble(dtSaleFertilizesr.Compute("sum(TotalAmt)", string.Empty)) + Convert.ToDouble(dtSaleFertilizesr.Rows[0]["hamali"].ToString()), 0));
                    string amountFerInWord = Utility.NumberToWordMarathi(netBillAmt);
                    dtSaleFertilizesr.Columns.Add(new DataColumn("amountInWord", typeof(string)));
                    foreach (DataRow dr in dtSaleFertilizesr.Rows)
                    {
                       // dr["amountInWord"] = amountFerInWord + " " + "रुपये /- फक्त.";
                        if (Utility.Langn == "English")
                        {
                            dr["amountInWord"] = amountFerInWord + " " + "Rupees /- Only.";
                        }
                        else
                        {
                            dr["amountInWord"] = amountFerInWord + " " + "रुपये /- फक्त.";
                        }
                    }
                    crptFertilizesInvoice rpt = new crptFertilizesInvoice();
                    RptSaleBill frm = new RptSaleBill();
                    //rpt.SetDataSource(dtSaleFertilizesr);
                    rpt.Database.Tables[0].SetDataSource(dtSale);
                    rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                    //  rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                    rpt.SetParameterValue(0, outstanding);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.Refresh();
                    frm.crystalReportViewer1.Refresh();
                    frm.ShowDialog();
                }
                if (dtPGROther.Rows.Count > 0)
                {
                    long netBillAmt = Convert.ToInt64(Math.Round(Convert.ToDouble(dtPGROther.Compute("sum(TotalAmt)", string.Empty)), 0));
                    string amountFerInWord = Utility.NumberToWordMarathi(netBillAmt);
                    dtPGROther.Columns.Add(new DataColumn("amountInWord", typeof(string)));
                    foreach (DataRow dr in dtPGROther.Rows)
                    {
                       // dr["amountInWord"] = amountFerInWord + " " + "रुपये /- फक्त.";
                        if (Utility.Langn == "English")
                        {
                            dr["amountInWord"] = amountFerInWord + " " + "Rupees /- Only.";
                        }
                        else
                        {
                            dr["amountInWord"] = amountFerInWord + " " + "रुपये /- फक्त.";
                        }
                    }
                    crptPGROther rpt = new crptPGROther();
                    RptSaleBill frm = new RptSaleBill();
                    rpt.SetDataSource(dtPGROther);
                    //  rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                    rpt.SetParameterValue(0, outstanding);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.Refresh();
                    frm.crystalReportViewer1.Refresh();
                    frm.ShowDialog();
                }

            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnCash.Checked == true)
                {
                    lblBakiAmount.Enabled = true;
                    lblPaidAmount.Enabled = true;
                    txtPaidAmount.Enabled = true;
                    txtBalanceAmount.Enabled = true;
                    rbtnCash.BackColor = Color.Green;
                    rbtnCredit.ForeColor = Color.Black;
                    rbtnCash.ForeColor = Color.White;
                    rbtnCredit.BackColor = Color.White;
                    subtot();
                    if (txtTotalAmount.Text != string.Empty)
                    {
                        txtPaidAmount.Text = Convert.ToDouble(txtTotalAmount.Text).ToString();
                    }
                }
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
                if (rbtnCredit.Checked == true)
                {
                    lblBakiAmount.Enabled = true;
                    lblPaidAmount.Enabled = true;
                    txtPaidAmount.Enabled = true;
                    txtBalanceAmount.Enabled = true;
                    rbtnCredit.BackColor = Color.Red;
                    rbtnCredit.ForeColor = Color.White;
                    rbtnCash.BackColor = Color.White;
                    rbtnCash.ForeColor = Color.Black;
                    txtPaidAmount.Text = "0";
                    subtot();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double checkpaidamount = 0;
                double checkbillamount = 0;
                string netamount = txtTotalAmount.Text;
                if (rbtnCash.Checked == true)
                {
                    txtPaidAmount.Text = txtTotalAmount.Text;
                    txtBalanceAmount.Text = "0";
                }
                if (rbtnCredit.Checked == true)
                {
                    if (txtTotalAmount.Text != string.Empty && txtPaidAmount.Text != string.Empty)
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
                            txtTotalAmount.Text = checkbillamount.ToString();
                            txtBalanceAmount.Text = checkbillamount.ToString();
                        }
                        else
                        {
                            txtBalanceAmount.Text = (Convert.ToDouble(Utility.ParseValue(txtTotalAmount.Text)) - Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text))).ToString();
                        }
                    }
                    else
                    {
                        txtBalanceAmount.Text = netamount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSaleInvoive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F3)
            {
                frmItemDetails frm = new frmItemDetails();
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.F1)
            {
                frmCustomerDetails frm = new frmCustomerDetails();
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.S && e.Alt)
            {
                FrmAllSaleCustomer frm = new FrmAllSaleCustomer();
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.R && e.Alt)
            {
                frmVoucherRecipt frm = new frmVoucherRecipt();
                frm.ShowDialog();
            }
            if (e.KeyCode == Keys.Home)
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
            if (e.KeyCode == Keys.P && e.Alt)
            {
                try
                {
                    DataTable purchRate = new DataTable();
                    if (dgvSaleItems.CurrentRow.Cells["itemId"].Value != null)
                    {
                        purchRate = SaleDetailsController.getminimumPurchaseRate(Convert.ToInt64(dgvSaleItems.CurrentRow.Cells["itemId"].Value), Convert.ToInt64(dgvSaleItems.CurrentRow.Cells["companyId"].Value), Convert.ToInt64(dgvSaleItems.CurrentRow.Cells["categoryId"].Value), dgvSaleItems.CurrentRow.Cells["batchNo"].Value.ToString(), dgvSaleItems.CurrentRow.Cells["UnitBy"].Value.ToString());
                        dgvminimumperchase.Visible = true;
                    }
                    dgvminimumperchase.DataSource = purchRate;
                }
                catch (Exception ae)
                {

                }
            }
            if (e.KeyCode == Keys.E && e.Alt)
            {
                try
                {

                    dgvminimumperchase.Visible = false;

                }
                catch (Exception ae)
                {

                }
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerDetails frm = new frmCustomerDetails();
            frm.ShowDialog();
        }

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable cust = null;
                if (cmbCustomerName.SelectedIndex != 0)
                {
                    cust = customerController.getCustomerDetails();
                    long id = Convert.ToInt64(cmbCustomerName.SelectedValue);
                    var query = from custs in cust.AsEnumerable()
                                where custs.Field<Int64>("customerId") == id
                                select custs;
                    if (query.Count() > 0)
                    {
                        DataTable info = query.CopyToDataTable<DataRow>();
                        txtmobile.Text = info.Rows[0]["customerMobileNo"].ToString();
                        txtaddress.Text = info.Rows[0]["customerAddress"].ToString();
                        txtContactPerson.Text = info.Rows[0]["contactPerson"].ToString();
                        txtContactNo.Text = info.Rows[0]["contactNo"].ToString();
                        txtGSTNo.Text = info.Rows[0]["CustomerGSTNo"].ToString();
                        txtAdharNo.Text = info.Rows[0]["adharNo"].ToString();
                        txtlimitationAmount.Text = info.Rows[0]["limitationAmount"].ToString();
                    }
                    lblCreditAmount.Text = Math.Round(accountDetailsController.GetDueAmount(id, "customer", Utility.FinancilaYearId,Convert.ToDateTime(dtpChallenDate.Value)), 2).ToString();
                }
                else
                {
                    txtaddress.Text = txtContactPerson.Text = txtContactNo.Text = string.Empty;
                    txtmobile.Text = "";
                    lblCreditAmount.Text = "0"; txtlimitationAmount.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static string SaleID = "";

        private void rbMarathi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtmobile.Text.Length == 0)
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
            if (e.KeyChar == '.' && txtmobile.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
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
        //try
        //{
        //    e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
        //    if (dgvSaleItems.CurrentCell.ColumnIndex == 9 ||
        //        dgvSaleItems.CurrentCell.ColumnIndex == 11 ||
        //        dgvSaleItems.CurrentCell.ColumnIndex == 13 ||
        //        dgvSaleItems.CurrentCell.ColumnIndex == 15 ||
        //        dgvSaleItems.CurrentCell.ColumnIndex == 17 ||
        //        dgvSaleItems.CurrentCell.ColumnIndex == 18 ||
        //        dgvSaleItems.CurrentCell.ColumnIndex == 19) //Desired Column
        //    {
        //        TextBox tb = e.Control as TextBox;
        //        if (tb != null)
        //        {
        //            tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
        //        }
        //    }
        //}
        //catch(Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //}

        private void txtmobile_TextChanged(object sender, EventArgs e)
        {
            //if(txtmobile.Text!=string.Empty)
            //{

            //    DataTable dt = customerController.getAccountNameSerachMobileNo(Utility.ParseValueI(txtmobile.Text).ToString());
            //    if(dt.Rows.Count>0)
            //    {
            //        cmbCustomerName.Text = dt.Rows[0]["customerName"].ToString();
            //    }
            //    else
            //    {
            //        //if (cmbCustomerName.Text == "")
            //        //{
            //        //    BindComboBoxgetCustomerName();
            //        //}
            //    }
            //}
            //else
            //{
            //        BindComboBoxgetCustomerName();
            //}
        }

        private void txtPaidAmount_Leave(object sender, EventArgs e)
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
                    dgvSaleItems.Columns["IGST"].Visible = false;
                    dgvSaleItems.Columns["IGSTAmt"].Visible = false;
                    dgvSaleItems.Columns["CGST"].Visible = false;
                    dgvSaleItems.Columns["CGSTAmt"].Visible = false;
                    dgvSaleItems.Columns["SGST"].Visible = false;
                    dgvSaleItems.Columns["SGSTAmt"].Visible = false;
                    if (Utility.Langn == "English")
                    {
                        lblCGST.Text = "IGST Amount";
                    }
                    else
                    {
                        lblCGST.Text = "IGST रक्कम";
                    }
                    lblSGST.Visible = false;
                    txtSGSTTotalAmount.Visible = false;
                }
                else
                {
                    dgvSaleItems.Columns["IGST"].Visible = false;
                    dgvSaleItems.Columns["IGSTAmt"].Visible = false;
                    dgvSaleItems.Columns["CGST"].Visible = false;
                    dgvSaleItems.Columns["CGSTAmt"].Visible = false;
                    dgvSaleItems.Columns["SGST"].Visible = false;
                    dgvSaleItems.Columns["SGSTAmt"].Visible = false;
                    
                    if (Utility.Langn == "English")
                    {
                        lblCGST.Text = "CGST Amount";
                    }
                    else
                    {
                        lblCGST.Text = "CGST रक्कम";
                    }
                    lblSGST.Visible = false;
                    txtSGSTTotalAmount.Visible = false;
                }
                subtot();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSaleInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                long salesInvoiceId = 0;
                if (e.RowIndex >= 0)
                {
                    salesInvoiceId = Convert.ToInt64(dgvSaleInvoice.CurrentRow.Cells["salesInvoiceId"].Value);
                }
                BindData(salesInvoiceId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string saleUpdateId = "";

        public void BindData(long salesInvoiceId)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                grbSaleInvice.Visible = false;
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                dgvSaleItems.Enabled = true;
                btnDelete.Enabled = true;
                isDelete = false;
                isupdate = true;
                IGST5 = 0; IGST12 = 0; IGST18 = 0; IGST28 = 0;
                DataTable dtSaleChallen = TempSaleDetailsController.getTempSaleInvoice(salesInvoiceId.ToString(), Utility.FinancilaYearId);
                saleUpdateId = salesInvoiceId.ToString();
                txtInvoiceNo.Text = dtSaleChallen.Rows[0]["salesInvoiceId"].ToString();
                txtFertInvoiceId.Text = dtSaleChallen.Rows[0]["InvoiceIdFertilizer"].ToString();
                txtSeedInvoiceId.Text = dtSaleChallen.Rows[0]["InvoiceIdSeeds"].ToString();
                txtPestiInvoiceId.Text = dtSaleChallen.Rows[0]["InvoiceIdPesticide"].ToString();
                txtPGRinvoiceId.Text = dtSaleChallen.Rows[0]["InvoiceIdPGROther"].ToString();
                isFertilizerId = dtSaleChallen.Rows[0]["InvoiceIdFertilizer"].ToString();
                isSeedsId = dtSaleChallen.Rows[0]["InvoiceIdSeeds"].ToString();
                isPesticideId = dtSaleChallen.Rows[0]["InvoiceIdPesticide"].ToString();
                isPGROther = dtSaleChallen.Rows[0]["InvoiceIdPGROther"].ToString();
                dtpChallenDate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["salesDate"].ToString());
                cmbCustomerRetailer.SelectedIndex = Convert.ToInt32(dtSaleChallen.Rows[0]["isCustomerRetailer"]);
                BindComboBoxgetCustomerName();
                cmbCustomerName.Text = dtSaleChallen.Rows[0]["customerName"].ToString();
                txtaddress.Text = dtSaleChallen.Rows[0]["customerAddress"].ToString();
                txtmobile.Text = dtSaleChallen.Rows[0]["customerMobileNo"].ToString();
                cmbPaymentType.Text = dtSaleChallen.Rows[0]["paymentType"].ToString();
                txtBanknName.Text = dtSaleChallen.Rows[0]["bankName"].ToString();
                txtchqDDNo.Text = dtSaleChallen.Rows[0]["chequeNo_refNo"].ToString();
                cmbGST.Text = dtSaleChallen.Rows[0]["state"].ToString();
                txtStateCode.Text = dtSaleChallen.Rows[0]["stateCode"].ToString();
                dtpchedate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["chequeDate"].ToString());
                lblChalanNo.Text = dtSaleChallen.Rows[0]["chalanNo"].ToString();
                txtChalanNo.Text = dtSaleChallen.Rows[0]["chalanNo"].ToString();

                if (dtSaleChallen.Rows[0]["salesType"].ToString() == "Cash")
                {
                    rbtnCash.Checked = true;
                }
                if (dtSaleChallen.Rows[0]["salesType"].ToString() == "Credit")
                {
                    rbtnCredit.Checked = true;
                }
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
                    if (rbtnCash.Checked == true)
                    {
                        dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dr["perQtysalePrice"].ToString());
                    }
                    if (rbtnCredit.Checked == true)
                    {
                        dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dr["perQtysalePrice"].ToString());
                    }
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


                    if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                    {
                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dr["IGST"].ToString()) * purRate / 100);
                    }
                    else
                    {
                        dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dr["CGST"].ToString()) * purRate / 100), 2);
                        dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dr["SGST"].ToString()) * purRate / 100), 2);
                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value), 2);
                    }
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
                subtot();
                txtNetAmount.Text = dtSaleChallen.Rows[0]["TotalBillAmt"].ToString();
                txtHamali.Text = dtSaleChallen.Rows[0]["hamali"].ToString();
                txtPaidAmount.Text = dtSaleChallen.Rows[0]["paidAmount"].ToString();
                txtRoundOff.Text = dtSaleChallen.Rows[0]["roundOff"].ToString();
                txtDiscount.Text = dtSaleChallen.Rows[0]["TotalDiscount"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        bool isDelete = false;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            isDelete = true;
            savebill(sender, e);
        }

        private void btnSaleInvoiceList_Click(object sender, EventArgs e)
        {
            try
            {
                pnlItemName.Visible = false;
                grbSaleInvice.Visible = true;
                dtpFromChallanDate.Enabled = true;
                dtpToChallanDate.Enabled = true;
                dgvSaleInvoice.DataSource = TempSaleDetailsController.getTempSaleIvoiceList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtSaleInvoice = TempSaleDetailsController.getTempSaleIvoiceList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()));
                dgvSaleInvoice.DataSource = dtSaleInvoice;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblCreditAmount_Click(object sender, EventArgs e)
        {
            try
            {
                new frmAccountWiseUdhari(Convert.ToInt64(cmbCustomerName.SelectedValue), cmbCustomerName.Text, "AllcustomerWise").ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void chkholeSale_CheckedChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (chkholeSale.Checked == true)
            //    {
            //        lblCustomerGSTNo.Visible = true;
            //        txtGSTNo.Visible = true;
            //    }
            //    else
            //    {
            //        lblCustomerGSTNo.Visible = false;
            //        txtGSTNo.Visible = false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void txtNetAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNetAmount.Text.ToString() != String.Empty)
                {
                    double netAmt = Math.Round(Convert.ToDouble(txtNetAmount.Text), 2);
                    txtRoundOff.Text = Math.Round(Math.Round(Convert.ToDouble(txtNetAmount.Text), 0) - netAmt, 2).ToString();
                    txtDiscount.Text = "0";
                    //  txtTotalAmount.Text = Math.Round(Convert.ToDouble(txtNetAmount.Text), 0).ToString();
                    txtDiscount_TextChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double netamount = 0;
                if (txtNetAmount.Text != string.Empty && txtDiscount.Text != string.Empty)
                {
                    txtTotalAmount.Text = (Math.Round(Math.Round(Convert.ToDouble(txtNetAmount.Text), 0) - Convert.ToDouble(txtDiscount.Text))).ToString();

                }
                else
                {
                    txtDiscount.Text = "0";
                }
                if (rbtnCash.Checked == true)
                {
                    txtPaidAmount.Text = txtTotalAmount.Text;
                    txtBalanceAmount.Text = "0";
                }
                if (rbtnCredit.Checked == true)
                {
                    if (txtTotalAmount.Text != string.Empty && txtPaidAmount.Text != string.Empty)
                    {
                        txtBalanceAmount.Text = (Convert.ToDouble(Utility.ParseValue(txtTotalAmount.Text)) - Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text))).ToString();
                    }
                    else
                    {
                        txtBalanceAmount.Text = txtTotalAmount.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnklblSaleBook_Click(object sender, EventArgs e)
        {
            try
            {
                frmTempSaleBook frm = new frmTempSaleBook();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lnklblPaymentReceipt_Click(object sender, EventArgs e)
        {
            frmVoucherRecipt frm = new frmVoucherRecipt();
            frm.ShowDialog();
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void txtRoundOff_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtRoundOff.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtRoundOff.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtDiscount.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtDiscount.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtTotalAmount.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtTotalAmount.Text.IndexOf('.') > -1)
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
                frmTempSaleChallanList frm = new frmTempSaleChallanList();
                frm.IdentityUpdated += new frmTempSaleChallanList.IdentityUpdateHandler(IdForm_ButtonClicked);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IdForm_ButtonClicked(object sender, frmTempSaleChallanList.IdentityUpdateEventArgs e)
        {
            try
            {
                btnnew_Click(sender, e);

                DataTable dtpurchaseChallan = SaleChallanTempController.getSaleChallenDetails(0, Utility.FinancilaYearId);

                foreach (DataRow dr in e.dt.Rows)
                {
                    challanNo += "," + dr[0].ToString();
                    DataTable dts = SaleChallanTempController.getSaleChallenDetails(Convert.ToInt64(dr["SalesChallanBillId"]), Utility.FinancilaYearId);
                    dtpurchaseChallan.Merge(dts);
                }
                BindChalanData(dtpurchaseChallan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BindChalanData(DataTable dtSaleChallen)
        {
            try
            {
                if (dtSaleChallen.Rows.Count > 0)
                {
                    dtpChallenDate.Value = DateTime.Now;
                    cmbCustomerRetailer.Text = (dtSaleChallen.Rows[0]["isCustomerRetailer"]).ToString();
                    cmbCustomerName.Text = dtSaleChallen.Rows[0]["customerName"].ToString();
                    txtaddress.Text = dtSaleChallen.Rows[0]["customerAddress"].ToString();
                    txtmobile.Text = dtSaleChallen.Rows[0]["customerMobileNo"].ToString();
                    cmbPaymentType.Text = "Cash";
                    txtBanknName.Text = "";
                    lblChalanNo.Text = challanNo;
                    txtChalanNo.Text = challanNo;
                    isConvertChalan = true;
                    cmbGST.Text = dtSaleChallen.Rows[0]["salesState"].ToString();
                    txtStateCode.Text = dtSaleChallen.Rows[0]["salesStateCode"].ToString();
                    if (dtSaleChallen.Rows[0]["salesType"].ToString() == "Cash")
                    {
                        rbtnCash.Checked = true;
                    }
                    if (dtSaleChallen.Rows[0]["salesType"].ToString() == "Credit")
                    {
                        rbtnCredit.Checked = true;
                    }
                    dgvSaleItems.Columns["itemName"].ReadOnly = true;
                    foreach (DataRow dr in dtSaleChallen.Rows)
                    {
                        dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                        dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dr["StockId"]);
                        dgvSaleItems.CurrentRow.Cells["salesChallanId"].Value = Convert.ToInt64(dr["salesChallanId"]);
                        dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                        dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                        dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                        dgvSaleItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                        dgvSaleItems.CurrentRow.Cells["HNSCode"].Value = dr["HNSCode"].ToString();
                        dgvSaleItems.CurrentRow.Cells["Quantity"].Value = dr["quantity"].ToString();
                        dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                        dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value = dr["MFD_Date"].ToString();
                        dgvSaleItems.CurrentRow.Cells["expireDate"].Value = dr["expireDate"].ToString();
                        dgvSaleItems.CurrentRow.Cells["currentStock1"].Value = 0;
                        dgvSaleItems.CurrentRow.Cells["salesItemDetailsId"].Value = 0;
                        if (dr["mainCategory"].ToString() == "किटकनाशके")
                        {
                            dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = true;
                            dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = false;
                            dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = false;
                            dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = false;
                            dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = isPesticideId;
                            InvoiceIdPesticideId = isPesticideId;
                        }
                        else if (dr["mainCategory"].ToString() == "खते")
                        {
                            dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = false;
                            dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = true;
                            dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = false;
                            dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = false;
                            dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = isFertilizerId;
                            InvoiceIdFertilizerId = isFertilizerId;
                        }
                        else if (dr["mainCategory"].ToString() == "बियाणे")
                        {
                            dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = false;
                            dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = false;
                            dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = true;
                            dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = false;
                            dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = isSeedsId;
                            InvoiceIdSeedsId = isSeedsId;
                        }
                        else
                        {
                            dgvSaleItems.CurrentRow.Cells["isPesticide"].Value = false;
                            dgvSaleItems.CurrentRow.Cells["isFertilizer"].Value = false;
                            dgvSaleItems.CurrentRow.Cells["isSeeds"].Value = false;
                            dgvSaleItems.CurrentRow.Cells["isPGROthers"].Value = true;
                            dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = isPGROther;
                            InvoiceIdPGROther = isPGROther;
                        }
                        //  dgvSaleItems.CurrentRow.Cells["invoiceNo"].Value = "";

                        if (rbtnCash.Checked == true)
                        {
                            dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dr["perQtysalePrice"].ToString());
                        }
                        if (rbtnCredit.Checked == true)
                        {
                            dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dr["perQtysalePrice"].ToString());
                        }
                        dgvSaleItems.CurrentRow.Cells["discount"].Value = 0;
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
                        dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100);
                        dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100);
                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100);


                        if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                        {
                            dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dr["IGST"].ToString()) * purRate / 100);
                        }
                        else
                        {
                            dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dr["CGST"].ToString()) * purRate / 100);
                            dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dr["SGST"].ToString()) * purRate / 100);
                            dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value);
                        }
                        // dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = purRate;
                        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString())), 2).ToString();
                        // subtot();
                        //  dgvSaleItems.Focus();
                        //dgvSaleItems.CurrentCell = dgvSaleItems.CurrentRow.Cells["Quantity"];
                        //dgvSaleItems.BeginEdit(true);
                        int col = dgvSaleItems.CurrentCell.ColumnIndex;
                        int row = dgvSaleItems.CurrentCell.RowIndex;
                        col = 0;
                        row++;
                        if (dgvSaleItems.Rows.Count < dtSaleChallen.Rows.Count)
                        {
                            if (row == dgvSaleItems.RowCount)
                            {
                                dgvSaleItems.Rows.Add();
                                dgvSaleItems.CurrentCell = dgvSaleItems[col + 6, row];
                            }
                        }
                    }
                    //  dgvSaleItems.Enabled = false;
                    subtot();
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
        public string customerRetailer = "";
        private void cmbCustomerRetailer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = customerController.getCustomerRetailerDetails(cmbCustomerRetailer.Text);
                Utility.BindComboBoxEmptyDataSelect(cmbCustomerName, dt, "customerId", "customerName");
                if (cmbCustomerRetailer.SelectedIndex == 0)
                {
                    lblCustomerGSTNo.Visible = false;
                    txtGSTNo.Visible = false;
                }
                else
                {
                    lblCustomerGSTNo.Visible = true;
                    txtGSTNo.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtHamali_TextChanged(object sender, EventArgs e)
        {
            if (txtNetAmount.Text != string.Empty && txtHamali.Text != string.Empty && txtRoundOff.Text != string.Empty)
            {
                txtTotalAmount.Text = Math.Round(Convert.ToDouble(txtNetAmount.Text) + Convert.ToDouble(txtRoundOff.Text) + Utility.ParseValue(txtHamali.Text), 0).ToString();

            }
            else
            {
                txtTotalAmount.Text = Math.Round(Convert.ToDouble(txtNetAmount.Text), 0).ToString();
                txtHamali.Text = "";
            }
            if (txtPaidAmount.Text != string.Empty && txtTotalAmount.Text != string.Empty)
            {
                txtBalanceAmount.Text = Math.Round(Utility.ParseValue(txtTotalAmount.Text) - Utility.ParseValue(txtPaidAmount.Text)).ToString();
            }
            if (rbtnCash.Checked == true)
            {
                txtPaidAmount.Text = txtTotalAmount.Text.ToString().Trim();
            }
        }

        private void txtHamali_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtHamali_Leave(object sender, EventArgs e)
        {

        }
        private void dtpChallenDate_ValueChanged(object sender, EventArgs e)
        {
            //if (dtpChallenDate.Enabled == true)
            //{
            //    if (dtpChallenDate.Value < Utility.firstDate || dtpChallenDate.Value > Utility.lastDate)
            //    {
            //        MessageBox.Show("कृपया दिनांक चालू Financial Year मधील निवडा ..चालू Financial Year आहे -" + Utility.Financialyear);
            //        dtpChallenDate.Value = System.DateTime.Now;
            //    }
            //}

        }

        private void txtCGSTTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlimitationAmount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (Convert.ToInt64(cmbCustomerName.SelectedValue) > 0)
                    {
                        int i = customerController.UpdateCustomerDetails(Convert.ToInt64(cmbCustomerName.SelectedValue), Convert.ToDouble(txtlimitationAmount.Text));
                        if (i > 0)
                        {
                             if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Limitation Amount Saved Successfully..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("सदर रक्कम मर्यादा:  यशस्वीरित्या साठवले गेले आहे..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
