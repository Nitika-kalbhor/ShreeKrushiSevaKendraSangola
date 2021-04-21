using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using DataAccessLayer.controller;
using DataAccessLayer.models;
namespace Dlogic_Wholesaler.Forms
{
    public partial class frmExpenses : MetroForm
    {
        public frmExpenses()
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
                    lblHerader.Text = "Expenses Details";
                    label3.Text = "Date:";
                    label1.Text = "Bill No:";
                    label2.Text = "Nave Account Name:";
                    label11.Text = "Account SubGroup:";
                    label4.Text = "Jama Account Name:";
                    label5.Text = "Debit Amount:";
                    label6.Text = "GST(%):";
                    chbGSTRegister.Text = "GST Register";
                    cnkState.Text = "Other State";
                    label7.Text = "CGST Amt:";
                    label8.Text = "SGST Amt:";
                    chbCash.Text = "Is Cash/Bank";
                    label10.Text = "Paid Amount:";
                    lblPaymenttype.Text = "Payment Type:";
                    lblBankName.Text = "Bank Name:";
                    lblChequeNo.Text = "Cheque No:";
                    label33.Text = "Cheque Date:";
                    label9.Text = "Naration:";
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";                

                    dgvExpenses.Columns[4].HeaderText = "InvoiceNo";
                    dgvExpenses.Columns[5].HeaderText = "Date";
                    dgvExpenses.Columns[6].HeaderText = "Nave Account";
                    dgvExpenses.Columns[7].HeaderText = "accountSubGroupName";
                    dgvExpenses.Columns[8].HeaderText = "Jama Account";
                    dgvExpenses.Columns[9].HeaderText = "CR.Amount";
                    dgvExpenses.Columns[10].HeaderText = "DR.Amount";
                    dgvExpenses.Columns[11].HeaderText = "Naration";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void frmExpenses_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                cmbPaymentType.SelectedIndex = 0;
                txtIGST.SelectedIndex = 0;
                transactionId1 = 0; voucherAssetID1 = 0;
                isUpdate = false;
               
                if (Utility.Langn == "English")
                {
                    btnSave.Text = "Save";
                }
                else
                {
                    btnSave.Text = "जतन";
                }
                dtpDate.MaxDate = Utility.lastDate;
                dtpDate.MinDate = Utility.firstDate;
                Lang();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpchedate.Value = DateTime.Now;
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
                if (Utility.Langn == "English")
                {
                    lblChequeNo.Text = "Refference No.";
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
            if (cmbPaymentType.SelectedItem.ToString() == "IMPS")
            {
                lblBankName.Visible = true;
                lblChequeNo.Visible = true;
                if (Utility.Langn == "English")
                {
                    lblChequeNo.Text = "Refference No.";
                }
                else
                {
                    lblChequeNo.Text = "संदर्भक्रमांक ";
                }

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
                if (Utility.Langn == "English")
                {
                    lblChequeNo.Text = "Refference No.";
                }
                else
                {
                    lblChequeNo.Text = "संदर्भक्रमांक ";
                }
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
                if (Utility.Langn == "English")
                {
                    lblChequeNo.Text = "Refference No.";
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
                    lblChequeNo.Text = "चेक /डीडी क्रमांक:";
                }

              

                cmbBank.Visible = true;
                txtchqDDNo.Visible = true;

                txtchqDDNo.Text = "";
                label33.Visible = true;
                dtpchedate.Visible = true;
            }
            BindBank();
        }
        private void BindBank()
        {
            Utility.BindComboBoxDataSelect(cmbBank, accountDetailsController.GetAccountWisePaymentDue(0, "BankBind", Utility.FinancilaYearId), "accountId", "accountName");
        }

        private void BindNaveAccountName()
        {
            try
            {
                DataTable dtvillageId = accountGroupController.getAccountNameBySubGroupId(Convert.ToInt64(12));
                Utility.BindComboBoxEmptyDataSelect(cmbNaveAccountName, dtvillageId, "accountId", "accountName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BindAccountSupGroup()
        {
            try
            {
                DataTable dtAccountSubGroup = accountGroupController.getAccountSubGroupDetails(Convert.ToInt32(8));
                // DataTable dtvillageId = accountGroupController.getAccountNameById(Convert.ToInt32(cmbAccountGroup.SelectedValue));
                Utility.BindComboBoxDataSelect(cmbAccountSupGroup, dtAccountSubGroup, "accountSubGroupId", "accountSubGroupName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BindDataGridView()
        {
            try
            {
                dgvExpenses.DataSource = accountDetailsController.getExpensesVoucher(0,DateTime.Now ,DateTime.Now ,Utility.FinancilaYearId,"Expenses");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                cmbPaymentType.SelectedIndex = 0;
                txtIGST.SelectedIndex = 0;
                BindNaveAccountName();
                BindAccountSupGroup();
                BindDataGridView();
                transactionId1 = 0; voucherAssetID1 = 0;
                isUpdate = false;                
                if (Utility.Langn == "English")
                {
                    btnSave.Text = "Save";
                }
                else
                {
                    btnSave.Text = "जतन";
                }
                if (dtpDate.Value < Utility.firstDate || dtpDate.Value > Utility.lastDate)
                {
                    dtpDate.Value = Utility.firstDate;
                }
                dtpDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CalculaterSum()
        {
            try
            {
                if (chbGSTRegister.Checked == true)
                {
                    if (txtIGST.SelectedIndex > 0)
                    {
                        if (txtCrAmount.Text != string.Empty)
                        {
                            double GSTAmount = Utility.ParseValue(txtCrAmount.Text) - (Utility.ParseValue(txtCrAmount.Text) * 100 / (100 + Utility.ParseValue(txtIGST.Text)));

                            txtCGSTAmt.Text = Math.Round(GSTAmount / 2, 2).ToString();
                            txtSGSTAmt.Text = Math.Round(GSTAmount / 2, 2).ToString();
                        }
                        else
                        {
                            txtCGSTAmt.Text = "0";
                            txtSGSTAmt.Text = "0";
                        }
                    }
                    else
                    {
                        txtCGSTAmt.Text = "0";
                        txtSGSTAmt.Text = "0";
                    }
                }
                else
                {
                    txtCGSTAmt.Text = "0";
                    txtSGSTAmt.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbCash.Checked == false)
                {
                    if (cmbNaveAccountName.SelectedIndex == 0 || cmbNaveAccountName.SelectedValue == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please select nave account name ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया नावे  खात्याचे नांव निवडा ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cmbNaveAccountName.Focus();
                        return;
                    }
                }
                else
                {
                    if(txtCrAmount.Text!=txtDrAmount.Text)
                    {
                        if (cmbNaveAccountName.SelectedIndex == 0 || cmbNaveAccountName.SelectedValue == null)
                        {                           
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Please select nave account name ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("कृपया नावे  खात्याचे नांव निवडा ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            cmbNaveAccountName.Focus();
                            return;
                        }
                    }
                }
                if (cmbAccountSupGroup.SelectedIndex == 0 || cmbAccountSupGroup.SelectedValue == null)
                {                  
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please select account subGroup ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया खाते गट उपप्रकार निवडा ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmbAccountSupGroup.Focus();
                    return;
                }
                if (cmbJamaAccountName.SelectedIndex == 0 || cmbJamaAccountName.SelectedValue == null)
                {
                    
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please select jama account name...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया  जमा खात्याचे नांव  निवडा ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmbJamaAccountName.Focus();
                    return;
                }
                if (txtCrAmount.Text.Trim() == string.Empty || txtCrAmount.Text.Trim() == "0")
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please add nave amount ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया नावे  रक्कम भरा ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtCrAmount.Focus();
                    return;
                }
                if (chbCash.Checked == true)
                {
                    if (txtDrAmount.Text.Trim() == string.Empty || txtDrAmount.Text.Trim() == "0")
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add jama amount ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया जमा  रक्कम भरा:- ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        txtDrAmount.Focus();
                        return;
                    }
                }
                AssetVoucher asset = new AssetVoucher();
                asset.voucherAssetID = voucherAssetID1;
                asset.transactionId = transactionId1;
                asset.FinancialYearID = Utility.FinancilaYearId;
                if (txtInvoice.Text == string.Empty)
                {
                    asset.InvoiceNo = "0";
                }
                else
                {
                    asset.InvoiceNo = txtInvoice.Text.Trim();
                }
                asset.voucherDate = dtpDate.Value;
                asset.naveAccountId = Convert.ToInt64(cmbNaveAccountName.SelectedValue);
                asset.jamaAccountId = Convert.ToInt64(cmbJamaAccountName.SelectedValue);
                asset.crAmount = Convert.ToDecimal(Utility.ParseValue(txtCrAmount.Text));
                if (txtDrAmount.Text == string.Empty)
                {
                    asset.drAmount = 0;
                }
                else
                {
                    asset.drAmount = Convert.ToDecimal(Utility.ParseValue(txtDrAmount.Text));
                }
                asset.GSTRegister = chbGSTRegister.Checked;
                asset.isState = cnkState.Checked;
                asset.isCash = chbCash.Checked;
                if (cmbPaymentType.SelectedIndex == 0)
                {
                    asset.bankId = 0;
                }
                else
                {
                    asset.bankId = Convert.ToInt32(cmbBank.SelectedValue);
                }
                asset.bankName = cmbBank.Text.Trim();
                asset.naration = txtNaration.Text.Trim();
                asset.PaymentType = cmbPaymentType.Text.Trim();
                asset.chqDDNo = txtchqDDNo.Text.Trim();
                asset.chqDate = dtpchedate.Value;
                asset.isUpdate = isUpdate;
                asset.addedBy = Utility.LoginID;
                if (chbGSTRegister.Checked == true)
                {
                    if (txtIGST.SelectedIndex > 0)
                    {
                        asset.IGST = Convert.ToDecimal(Utility.ParseValue(txtIGST.Text.Trim()));
                        asset.CGST = Convert.ToDecimal(Utility.ParseValue(txtIGST.Text.Trim())) / 2;
                        asset.SGST = Convert.ToDecimal(Utility.ParseValue(txtIGST.Text.Trim())) / 2;
                    }
                    else
                    {
                        asset.IGST = 0;
                        asset.CGST = 0;
                        asset.SGST = 0;
                    }
                    if (txtCGSTAmt.Text == string.Empty)
                    {
                        txtCGSTAmt.Text = "0";
                    }
                    if (txtCGSTAmt.Text == string.Empty)
                    {
                        txtSGSTAmt.Text = "0";
                    }
                    asset.CGSTAmt = Convert.ToDecimal(Utility.ParseValue(txtCGSTAmt.Text.Trim()));
                    asset.SGSTAmt = Convert.ToDecimal(Utility.ParseValue(txtSGSTAmt.Text.Trim()));
                    asset.IGSTAmt = asset.CGSTAmt + asset.SGSTAmt;
                }
                else
                {
                    asset.IGST = 0;
                    asset.CGST = 0;
                    asset.SGST = 0;
                    asset.CGSTAmt = 0;
                    asset.SGSTAmt = 0;
                    asset.IGSTAmt = 0;

                }
                int s = AssetVoucherController.addExpensesVoucher(asset);
                if (s > 0)
                {                  
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("This record saved successfully..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("सदर माहिती यशस्वीरित्या साठवले गेले आहे..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    btnnew_Click(sender, e);
                }
                else
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("This record can not be saved successfully..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("सदर माहिती यशस्वीरित्या साठवले गेले नाही आहे ..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAccountSupGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAccountSupGroup.SelectedIndex > 0)
                {
                    //  DataTable dtAccountSubGroup = accountGroupController.getAccountSubGroupDetails(Convert.ToInt32(cmbAccountGroup.SelectedValue));
                    DataTable dtvillageId = accountGroupController.getAccountNameBySubGroupId(Convert.ToInt64(cmbAccountSupGroup.SelectedValue));
                    Utility.BindComboBoxEmptyDataSelect(cmbJamaAccountName, dtvillageId, "accountId", "accountName");
                    cmbJamaAccountName.Enabled = true;
                }
                else
                {
                    cmbJamaAccountName.Enabled = false;
                    cmbJamaAccountName.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCrAmount_TextChanged(object sender, EventArgs e)
        {

            try
            {
                CalculaterSum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCrAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Utility.SingleDecimal(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private long transactionId1 = 0, voucherAssetID1 = 0;
        private bool isUpdate = false;
        private void dgvExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    dtpDate.Value = Convert.ToDateTime(dgvExpenses.Rows[e.RowIndex].Cells["voucherDate"].Value);
                    voucherAssetID1 = Convert.ToInt64(dgvExpenses.Rows[e.RowIndex].Cells["voucherAssetID"].Value);
                    transactionId1 = Convert.ToInt64(dgvExpenses.Rows[e.RowIndex].Cells["transactionId"].Value);
                    txtInvoice.Text = Convert.ToString(dgvExpenses.Rows[e.RowIndex].Cells["InvoiceNo"].Value);
                    cmbNaveAccountName.Text = Convert.ToString(dgvExpenses.Rows[e.RowIndex].Cells["naveAccountName"].Value);
                    cmbAccountSupGroup.Text = Convert.ToString(dgvExpenses.Rows[e.RowIndex].Cells["accountSubGroupName"].Value);
                    cmbJamaAccountName.Text = Convert.ToString(dgvExpenses.Rows[e.RowIndex].Cells["jamaAccountName"].Value);
                    txtCrAmount.Text = Convert.ToString(dgvExpenses.Rows[e.RowIndex].Cells["crAmount"].Value);
                    txtDrAmount.Text = Convert.ToString(dgvExpenses.Rows[e.RowIndex].Cells["drAmount"].Value);
                    txtIGST.Text = Convert.ToString(dgvExpenses.Rows[e.RowIndex].Cells["IGST"].Value);
                    txtCGSTAmt.Text = Convert.ToString(dgvExpenses.Rows[e.RowIndex].Cells["CGSTAmt"].Value);
                    txtSGSTAmt.Text = Convert.ToString(dgvExpenses.Rows[e.RowIndex].Cells["SGSTAmt"].Value);
                    chbGSTRegister.Checked = Convert.ToBoolean(dgvExpenses.Rows[e.RowIndex].Cells["GSTRegister"].Value);
                    cnkState.Checked = Convert.ToBoolean(dgvExpenses.Rows[e.RowIndex].Cells["isState"].Value);
                    chbCash.Checked = Convert.ToBoolean(dgvExpenses.Rows[e.RowIndex].Cells["isCash"].Value);
                    cmbPaymentType.Text = Convert.ToString(dgvExpenses.Rows[e.RowIndex].Cells["PaymentType"].Value);
                    txtchqDDNo.Text = Convert.ToString(dgvExpenses.Rows[e.RowIndex].Cells["chqDDNo"].Value);
                    cmbBank.Text = Convert.ToString(dgvExpenses.Rows[e.RowIndex].Cells["chqDDNo"].Value);
                    dtpchedate.Value = Convert.ToDateTime(dgvExpenses.Rows[e.RowIndex].Cells["chqDate"].Value);
                    txtNaration.Text = Convert.ToString(dgvExpenses.Rows[e.RowIndex].Cells["naration"].Value);
                    Utility.disableFields(this);
                    isUpdate = true;                  
                    if (Utility.Langn == "English")
                    {
                        btnSave.Text = "Delete";
                    }
                    else
                    {
                        btnSave.Text = "डिलीट";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.ShowAccountForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmExpenses_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
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

        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
