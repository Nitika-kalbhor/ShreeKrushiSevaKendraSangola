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
using Dlogic_Wholesaler.TempReportFroms;
namespace Dlogic_Wholesaler.TempFroms
{
    public partial class frmTempPurchaseReturn : MetroForm
    {
        public frmTempPurchaseReturn()
        {
            InitializeComponent();
        }
        private bool isDelete = false;
        private  long purchaseReutrnId = 0;
        public void BindComboBoxgetDealerName()
        {

            DataTable dtgetDealerName = DealerController.getDealerDetails();
            Utility.BindComboBoxDataSelect(cmbDealerName, dtgetDealerName, "dealerId", "dealerFirmName");


        }

        private void frmPurchaseReturn_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                btnSave.Text = "जतन करा";
                purchaseReutrnId = 0;
                BindComboBoxgetDealerName();
                dgvPurchaseItems.ReadOnly = false;
                dgvPurchaseItems.Rows.Add(); 
                dgvItemName.Hide();
                isDelete = false;
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
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                btnSave.Text = "जतन करा";
                btnDelete.Enabled = false;
                isDelete = false;
                purchaseReutrnId = 0; 
                BindComboBoxgetDealerName();          
                txtInvoiceNo.Text =TempPurchaseDetailsController.getMaxIdPurchaseReturnInvoiceId(Utility.FinancilaYearId).ToString();
                cmbPaymentType.SelectedIndex = 0;
               // cmbGST.SelectedIndex = 0;
                grbChallanList.Visible = false;
                dgvItemName.Hide();
                dgvPurchaseItems.Enabled = true;
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                cmbDealerName.Focus();
                cmbGST.Text = "Maharashtra";
                txtStateCode.Text = "27";
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
                if (dgvPurchaseItems.CurrentRow.Cells["itemName"].Value == null)
                {
                    dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["purchaseReutrnItemDetailId"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = null;
                    dgvItemName.Hide();
                    return;
                }
                string value = null;
                if (dgvPurchaseItems.CurrentCell.ColumnIndex == 5)
                {
                    value = dgvPurchaseItems.CurrentRow.Cells["itemName"].Value.ToString();
                }
                else
                {
                    if (dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value != null && dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value != null &&
                        dgvPurchaseItems.CurrentRow.Cells["discount"].Value != null && dgvPurchaseItems.CurrentRow.Cells["IGST"].Value != null && dgvPurchaseItems.CurrentRow.Cells["CGST"].Value != null && dgvPurchaseItems.CurrentRow.Cells["SGST"].Value != null)
                    {
                        dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()));
                        dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()));
                        dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value.ToString()));
                        dgvPurchaseItems.CurrentRow.Cells["purchaseReutrnItemDetailId"].Value = 0;
                        dgvPurchaseItems.CurrentRow.Cells["discount"].Value = Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()));
                        dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()));
                        dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()));
                        dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString()));
                        dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                        dgvItemName.Hide();
                        // double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())) / 100);
                        double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())));
                        if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                        {
                            dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())) * purRate / 100);
                            dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())) / 2);
                            dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())));
                            dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100);
                            dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString())));
                        }
                        else
                        {
                            dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100);
                            dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())));
                            dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()))) + (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString())));
                            dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString())));
                            dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());

                        }
                        dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString())).ToString();

                    }
                    else
                    {
                        dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = 0;
                    }
                }
                if (value != null)
                {
                    DataTable dtitem = TempPurchaseDetailsController.getStockInItemDetails(value);
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
              
                
            }
            txtNetAmount.Text =Math.Round(Convert.ToDouble(sum),0).ToString();
            try
            {
                if (txtNetAmount.Text.ToString() != String.Empty)
                {
                    double netAmt = Math.Round(Convert.ToDouble(txtNetAmount.Text), 2);
                    txtRoundOff.Text = ((Math.Round(Math.Round(Convert.ToDouble(txtNetAmount.Text), 0) - netAmt, 2))).ToString();

                    txtNetAmount.Text = Math.Round(sum, 0).ToString();
                }
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
                if (e.KeyData == Keys.Enter)
                {
                    int col = dgvPurchaseItems.CurrentCell.ColumnIndex;
                    int row = dgvPurchaseItems.CurrentCell.RowIndex;
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
                                dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 5, row];
                            }
                            else if (dgvPurchaseItems.CurrentCell.ColumnIndex == 11)
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
                if ((e.KeyCode == Keys.F10 && e.Shift))
                {

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
                            if (rows.Cells["itemId"].Value.ToString().Equals(dt.Rows[0]["itemId"].ToString()) && rows.Cells["companyId"].Value.ToString().Equals(dt.Rows[0]["companyId"].ToString()) && rows.Cells["categoryId"].Value.ToString().Equals(dt.Rows[0]["categoryId"].ToString()) && rows.Cells["batchNo"].Value.ToString().Equals(dt.Rows[0]["batchNo"].ToString()) && rows.Cells["itemName"].Value.ToString().Equals(dt.Rows[0]["itemName"].ToString()))
                            {
                                MessageBox.Show("कृपया माहिती लिस्ट मध्ये आधीच उपलब्ध आहे !", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dgvPurchaseItems.Focus();
                                return;
                            }
                        }
                    }
                    dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dt.Rows[0]["itemId"]);
                    dgvPurchaseItems.CurrentRow.Cells["stockId"].Value = Convert.ToInt64(dt.Rows[0]["StockId"]);
                    dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dt.Rows[0]["companyId"]);
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToString(dt.Rows[0]["categoryId"]);
                    dgvPurchaseItems.CurrentRow.Cells["itemName"].Value = dt.Rows[0]["itemName"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = dt.Rows[0]["batchNo"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = 1;
                    dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = dt.Rows[0]["unitBy"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["purchaseReutrnItemDetailId"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Convert.ToString(dt.Rows[0]["purchaseRate"]);
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Convert.ToString(dt.Rows[0]["salesCashRate"]);
                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(Convert.ToString(dt.Rows[0]["IGST"]));
                    dgvPurchaseItems.CurrentRow.Cells["CGST"].Value =Utility.ParseValue(Convert.ToString(dt.Rows[0]["CGST"]));
                    dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(Convert.ToString(dt.Rows[0]["SGST"]));
                  //  dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                    //    double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())) / 100);
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
                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString())).ToString();
                    subtot();

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
                if (txtNetAmount.Text != string.Empty && txtPaidAmount.Text != string.Empty)
                {
                    double dueAmount = Convert.ToDouble(Utility.ParseValue(txtNetAmount.Text)) - Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text));
                    txtBalanceAmount.Text = dueAmount.ToString();
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
        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BindBank();
                if (cmbPaymentType.SelectedItem.ToString() == "Cash")
                {
                    lblBankName.Visible = false;
                    lblChequeNo.Visible = false;
                    cmbBank.Visible = false;
                    txtchqDDNo.Visible = false;
                    txtchqDDNo.Text = "";

                    label33.Visible = false;
                    dtpchedate.Visible = false;

                }

                if (cmbPaymentType.SelectedItem.ToString() == "Card Payment")
                {
                    lblBankName.Visible = true;
                    lblChequeNo.Visible = true;

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

                    txtchqDDNo.Text = "";
                    label33.Visible = false;
                    dtpchedate.Visible = false;
                }
                if (cmbPaymentType.SelectedItem.ToString() == "RTGS")
                {
                    lblBankName.Visible = true;
                    lblChequeNo.Visible = true;


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

                    txtchqDDNo.Text = "";
                    label33.Visible = true;
                    dtpchedate.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDealerName.Text == string.Empty || cmbDealerName.SelectedValue == null)
                {
                    MessageBox.Show("कृपया व्यापारीचे नाव निवडा", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbDealerName.Focus();
                    return;
                }
                for (int i = 0; i < dgvPurchaseItems.Rows.Count; i++)
                {
                    if (dgvPurchaseItems.Rows[i].Cells[4].Value == null)
                    {
                        MessageBox.Show("कृपया वस्तूचे नाव भरा...");
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[4];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[5].Value == null)
                    {
                        MessageBox.Show("कृपया बॅच नंबर भरा...");
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[5];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[6].Value == null)
                    {
                        MessageBox.Show("कृपया नग भरा...");
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[6];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[8].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells[8].Value = "Qty";
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[9].Value == null)
                    {
                        MessageBox.Show("कृपया खरेदी किंमत भरा..");
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[9];
                        return;
                    }

                    if (dgvPurchaseItems.Rows[i].Cells[10].Value == null)
                    {
                        MessageBox.Show("कृपया विक्री किंमत भरा");
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[10];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[11].Value == null)
                    {
                        MessageBox.Show("कृपया IGST भरा");
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[11];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[13].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells[13].Value = 0;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[15].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells[15].Value = 0;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[17].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells[17].Value = 0;
                    }
                    
                    if (dgvPurchaseItems.Rows[i].Cells[18].Value == null)
                    {
                        MessageBox.Show("कृपया पूर्ण रक्कम भरा");
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[18];
                        return;
                    }
                }
                if (cmbPaymentType.Text.Equals("Cheque"))
                {
                    if (cmbBank.Text.Equals("") || cmbBank.Text.Equals("0"))
                    {

                        MessageBox.Show("कृपया बँक चे नाव भरा..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbBank.Focus();
                        return;
                    }
                    else if (txtchqDDNo.Text.Equals("") || txtchqDDNo.Text.Equals("0"))
                    {

                        MessageBox.Show("कृपया चेक / डी.डी. क्रमांक  भरा..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtchqDDNo.Focus();
                        return;

                    }
                }
                if (cmbPaymentType.Text.Equals("Card Payment"))
                {
                    if (cmbBank.Text.Equals("") || cmbBank.Text.Equals("0"))
                    {

                        MessageBox.Show("कृपया बँक चे नाव भरा...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbBank.Focus();
                        return;

                    }
                    else if (txtchqDDNo.Text.Equals("") || txtchqDDNo.Text.Equals("0"))
                    {

                        MessageBox.Show("कृपया चेक क्रमांक  भरा..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtchqDDNo.Focus();
                        return;



                    }
                }
                if (cmbPaymentType.Text.Equals("") || cmbPaymentType.Text.Equals("0"))
                {

                    MessageBox.Show("कृपया Payment प्रकार निवडा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbPaymentType.Focus();
                    return;


                }
                if (cmbDealerName.SelectedValue == null || cmbDealerName.Text == string.Empty || cmbDealerName.Text == "-- निवडा --")
                {
                    MessageBox.Show("कृपया व्यापार्याचे नाव भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbDealerName.Focus();
                    return;
                }
                if (txtPaidAmount.Text == string.Empty)
                {
                    MessageBox.Show("कृपया एकूण रक्कम भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPaidAmount.Focus();
                    return;
                }
                if(txtPurchaseBillNo.Text==string.Empty)
                {
                    MessageBox.Show("कृपया खरेदी बिल नं भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPurchaseBillNo.Focus();
                    return;
                }
               
                PurchaseReutrnDetails purch = new PurchaseReutrnDetails();
                purch.dealerId = Convert.ToInt64(cmbDealerName.SelectedValue);
                purch.challanDate = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                if (isDelete == false)
                {
                    purch.purchaseReutrnInvoiceId = TempPurchaseDetailsController.getMaxIdPurchaseReturnInvoiceId(Utility.FinancilaYearId).ToString();
                }
                else
                {
                    purch.purchaseReutrnInvoiceId = txtInvoiceNo.Text;
                }
                purch.purchaseReutrnId = purchaseReutrnId;
                purch.remark = "";
                purch.paymentType = cmbPaymentType.Text;
                purch.purchaseInvoiceNo = txtPurchaseBillNo.Text.Trim();
                purch.purchaseDate = Convert.ToDateTime(dtpPurchaseDate.Value.ToShortDateString());
                DataTable PurchaseRetrunInvoice = new DataTable();


                foreach (DataGridViewColumn col in dgvPurchaseItems.Columns)
                {
                    PurchaseRetrunInvoice.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dgvPurchaseItems.Rows)
                {
                    DataRow dRow = PurchaseRetrunInvoice.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null)
                        {

                            MessageBox.Show("कृपया लिस्ट मध्ये माहिती भरा");

                            return;
                        }

                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    PurchaseRetrunInvoice.Rows.Add(dRow);
                }
                purch.PurchaseRetrunItemTable = PurchaseRetrunInvoice;
                purch.paidAmount = Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text));
                purch.netBillAmount = Convert.ToDouble(Utility.ParseValue(txtNetAmount.Text));
                purch.chequeDate = dtpchedate.Value;
                purch.bankName = cmbBank.Text;
                purch.state = cmbGST.Text;
                purch.stateCode = txtStateCode.Text;
                if (cmbBank.SelectedIndex > 0)
                {
                    purch.bankId = Convert.ToInt32(cmbBank.SelectedValue);
                }
                else
                {
                    purch.bankId = 0;
                }
                purch.FinancialYearID = Utility.FinancilaYearId;
                purch.chequeNo_refNo = txtchqDDNo.Text;
                purch.addedBy = Utility.LoginID;
                purch.isDelete = isDelete;
                PusrchaseSaleAccount PurchsSale = new PusrchaseSaleAccount();
                PurchsSale.RoundOff = Convert.ToDouble(Utility.ParseValue( txtRoundOff.Text));
                PurchsSale.discount = 0;
                PurchsSale.Hamali = 0;
                PurchsSale.billId = Convert.ToInt64(purch.purchaseReutrnInvoiceId);
                PurchsSale.Igst5 = SumOfPurch.Igst5;
                PurchsSale.Igst12 = SumOfPurch.Igst12;
                PurchsSale.Igst18 = SumOfPurch.Igst18;
                PurchsSale.Igst28 = SumOfPurch.Igst28;
                PurchsSale.salePurchaseAccount = Math.Round((purch.netBillAmount) - (PurchsSale.Igst5 + PurchsSale.Igst12 + PurchsSale.Igst18 + PurchsSale.Igst28),2);// Convert.ToDouble(PurchaseInvoice.Compute("Sum(TaxableAmount)", string.Empty));
                PurchsSale.issalePurchase = "PurchaseRetrun";
                PurchsSale.stateCode = txtStateCode.Text.Trim();
                int l = TempPurchaseReturnDetailsController.addPurchaseReturnDetails(purch);
                if (l > 0)
                {
                    if (isDelete == false)
                    {
                        MessageBox.Show("माहिती यशस्वीरित्या साठवली गेली !", "माहिती", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if(isDelete==true)
                    {
                        MessageBox.Show("माहिती यशस्वीरित्या डिलीट केली गेली !", "माहिती", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    btnnew_Click(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvPurchaseItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
                if (dgvPurchaseItems.CurrentCell.ColumnIndex == 10 || dgvPurchaseItems.CurrentCell.ColumnIndex == 12 ||
                    dgvPurchaseItems.CurrentCell.ColumnIndex == 13 || dgvPurchaseItems.CurrentCell.ColumnIndex == 14) //Desired Column
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
                if (cmbDealerName.SelectedIndex != 0)
                {
                    dgvPurchaseItems.Enabled = true;
                }
                else
                {
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
        private void dgvPurchaseItems_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isDelete == true)
            {

            }
            else
            {
                rowToDelete = dgvPurchaseItems.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                dgvPurchaseItems.Rows.RemoveAt(rowToDelete);
                dgvPurchaseItems.ClearSelection();
            }

        }

        private void dgvPurchaseItems_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvPurchaseItems.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.contextMenuStrip1.Show(this.dgvPurchaseItems, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
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

        private void dgvItemName_KeyDown(object sender, KeyEventArgs e)
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
                }
                else
                {
                    dgvPurchaseItems.Columns["IGST"].Visible = false;
                    dgvPurchaseItems.Columns["IGSTAmt"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmPurchaseReturn_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.P && e.Alt)
                {
                    FrmAllPurchaseRetrun frm = new FrmAllPurchaseRetrun();
                    frm.ShowDialog();
                }
                if (e.KeyCode == Keys.N && e.Alt)
                {
                    btnnew_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && e.Alt)
                {
                    btnnew_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void lnklblPurchaseReturnBook_Click(object sender, EventArgs e)
        {
            FrmTempPurchaseRetrunBook frm = new FrmTempPurchaseRetrunBook();
            frm.ShowDialog();
        }

        private void txtStateCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void dgvSaleChallan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                if (e.RowIndex >= 0)
                {
                   
                    purchaseReutrnId = Convert.ToInt64(dgvSaleChallan.CurrentRow.Cells["purchaseId1"].Value);
                }
                DataTable dtSaleChallen = TempPurchaseReturnDetailsController.getPurchaseReturnIvoiceDetails(purchaseReutrnId,Utility.FinancilaYearId);
                if (dtSaleChallen.Rows.Count > 0)
                {
                    BindData(dtSaleChallen);
                }
            }
            catch (Exception ex)
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
                txtInvoiceNo.Text = dtSaleChallen.Rows[0]["purchaseReutrnInvoiceId"].ToString();
                dtpChallenDate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["purchaseReutrnDate"].ToString());
                cmbDealerName.Text = dtSaleChallen.Rows[0]["dealerFirmName"].ToString();
                txtmobile.Text = dtSaleChallen.Rows[0]["dealerContactNo"].ToString();
                cmbGST.Text = dtSaleChallen.Rows[0]["state"].ToString();
                txtStateCode.Text = dtSaleChallen.Rows[0]["stateCode"].ToString();               
                cmbPaymentType.Text = dtSaleChallen.Rows[0]["paymentType"].ToString();
                cmbBank.Text = dtSaleChallen.Rows[0]["bankName"].ToString();
                txtchqDDNo.Text = dtSaleChallen.Rows[0]["chequeNo_refNo"].ToString();
                dtpchedate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["chequeDate"].ToString());
                txtNetAmount.Text = dtSaleChallen.Rows[0]["netBillAmount"].ToString();
                txtPaidAmount.Text = dtSaleChallen.Rows[0]["paidAmount"].ToString();
                txtPurchaseBillNo.Text = dtSaleChallen.Rows[0]["purchaseInvoiceNo"].ToString();
                foreach (DataRow dr in dtSaleChallen.Rows)
                {
                    dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                    dgvPurchaseItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dr["StockId"]);
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                    dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseReutrnItemDetailId"].Value = Convert.ToInt32(dr["purchaseReutrnItemDetailId"]);
                   // dgvPurchaseItems.CurrentRow.Cells["purchaseChalanId"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                    dgvPurchaseItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                  //  dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                   // dgvPurchaseItems.CurrentRow.Cells["rackNo"].Value = dr["rackNo"].ToString();
                    //dgvPurchaseItems.CurrentRow.Cells["productCode"].Value = dr["productCode"].ToString();
                    //dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                   // dgvPurchaseItems.CurrentRow.Cells["MRP"].Value = dr["MRP"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = dr["Quantity"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                   // dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value = dr["MFD_Date"].ToString();
                   // dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value = dr["expireDate"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = dr["discount"].ToString();
                   // dgvPurchaseItems.CurrentRow.Cells["discountPer"].Value = dr["discountPer"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dr["IGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dr["CGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dr["SGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = Utility.ParseValue(dr["freeQuantity"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dr["salesCashRate"].ToString());
                    //dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dr["purchaseRate"].ToString()) + ((Utility.ParseValue(dr["purchaseRate"].ToString()) + Utility.ParseValue(dr["IGST"].ToString())) / 100), 2);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dr["purchaseRate"].ToString());
                    //double Discount = ((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discountPer"].Value.ToString()) / 100)) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString());
                    //if (Discount > 0)
                    //{
                    //    dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) - Discount;
                    //}
                    //else
                    //{
                    //    dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                    //} dgvPurchaseItems.CurrentRow.Cells["TaxableAmount"].Value = Math.Round((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value.ToString())) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString()), 2);
                    ////  dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());

                    //double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value)) / 100);
                    double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())));
                    dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100);
                    dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100);
                    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100);


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
                            dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 5, row];
                        }
                    }
                }
                subtot();
                dgvPurchaseItems.Enabled = false;
                btnSave.Text = "डिलीट";
                isDelete = true;
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            grbChallanList.Visible = true;
            dtpFromChallanDate.Enabled = true;
            dtpToChallanDate.Enabled = true;
            dgvSaleChallan.DataSource = TempPurchaseReturnDetailsController.getPurchaseReturnList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           
            grbChallanList.Visible = true;
            dtpFromChallanDate.Enabled = true;
            dtpToChallanDate.Enabled = true;
            dgvSaleChallan.DataSource = TempPurchaseReturnDetailsController.getPurchaseReturnList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);

        }
    }
}
