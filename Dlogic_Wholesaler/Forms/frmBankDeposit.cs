
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer.models;
using DataAccessLayer.controller;

namespace Dlogic_Wholesaler.Forms
{
    public partial class frmBankDeposit : MetroFramework.Forms.MetroForm
    {
        public frmBankDeposit()
        {
            InitializeComponent();
        }
        public DataTable dtmani;
        public DataTable dtmani0;
        public static long bankTransactionId1 = 0, Transaction_ID = 0;
        public bool isDelete = false;
        public void bindAccountType(Boolean Active_Type)
        {
            DataTable dtgetaccountName = accountDetailsController.getBankAccountGroup();
            Utility.BindComboBoxDataSelect(cmbAccounttype, dtgetaccountName, "accountGroupId", "accountGroup");
        }
        public void BindBankTransaction(DataTable dtBankTransaction)
        {
            try
            {
                dgvBankTransaction.DataSource = null;
                dgvBankTransaction.Font = new Font("Arial UniCode MS", 11, FontStyle.Bold);
               
                    dgvBankTransaction.AutoGenerateColumns = false;
                    dgvBankTransaction.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    dgvBankTransaction.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                    dgvBankTransaction.EnableHeadersVisualStyles = false;

                    dgvBankTransaction.ColumnCount = 16;

                    if (Utility.Langn == "English")
                    {
                        dgvBankTransaction.Columns[3].HeaderText = "Date";
                        dgvBankTransaction.Columns[4].HeaderText = "Account Name";
                        dgvBankTransaction.Columns[5].HeaderText = "Cr/Dr";
                        dgvBankTransaction.Columns[6].HeaderText = "Credit";
                        dgvBankTransaction.Columns[7].HeaderText = "Debit";
                        dgvBankTransaction.Columns[8].HeaderText = "Naration";
                        dgvBankTransaction.Columns[10].HeaderText = "Payment Type";
                        dgvBankTransaction.Columns[11].HeaderText = "Bank ";
                        dgvBankTransaction.Columns[12].HeaderText = "Cheque No";
                        dgvBankTransaction.Columns[13].HeaderText = "Cheque Date";
                        dgvBankTransaction.Columns[14].HeaderText = "Account Type";
                    }
                    else
                    {
                        dgvBankTransaction.Columns[3].HeaderText = "दिनांक";
                        dgvBankTransaction.Columns[4].HeaderText = "खाते नाव";
                        dgvBankTransaction.Columns[5].HeaderText = "जमा/नावे";
                        dgvBankTransaction.Columns[6].HeaderText = "जमा(क्रेडीट)";
                        dgvBankTransaction.Columns[7].HeaderText = "नावे(डेबिट)";
                        dgvBankTransaction.Columns[8].HeaderText = "तपशील";
                        dgvBankTransaction.Columns[10].HeaderText = "पैसे भरण्याची पद्धत";
                        dgvBankTransaction.Columns[11].HeaderText = "बँक ";
                        dgvBankTransaction.Columns[12].HeaderText = "चेक/रेफ नं";
                        dgvBankTransaction.Columns[13].HeaderText = "चेक/रेफ दिनांक";
                        dgvBankTransaction.Columns[14].HeaderText = "खाते प्रकार";
                    }
                    dgvBankTransaction.Columns[0].Name = "bankTransactionId";
                    dgvBankTransaction.Columns[0].HeaderText = "bankTransactionId";
                    dgvBankTransaction.Columns[0].DataPropertyName = "bankTransactionId";
                    dgvBankTransaction.Columns[0].Visible = false;

                    dgvBankTransaction.Columns[1].Name = "accountTypeID";
                    dgvBankTransaction.Columns[1].HeaderText = "accountTypeID";
                    dgvBankTransaction.Columns[1].DataPropertyName = "accountTypeID";
                    dgvBankTransaction.Columns[1].Visible = false;

                    dgvBankTransaction.Columns[2].Name = "accountID";
                    dgvBankTransaction.Columns[2].HeaderText = "accountID";
                    dgvBankTransaction.Columns[2].DataPropertyName = "accountID";
                    dgvBankTransaction.Columns[2].Visible = false;

                    dgvBankTransaction.Columns[3].Name = "transactionDate";                   
                    dgvBankTransaction.Columns[3].DataPropertyName = "transactionDate";

                    dgvBankTransaction.Columns[4].Name = "AccountName";                  
                    dgvBankTransaction.Columns[4].DataPropertyName = "AccountName";

                    dgvBankTransaction.Columns[5].Name = "transactionType";                  
                    dgvBankTransaction.Columns[5].DataPropertyName = "transactionType";
                    dgvBankTransaction.Columns[5].Visible = false;

                    dgvBankTransaction.Columns[6].Name = "crAmount";                   
                    dgvBankTransaction.Columns[6].DataPropertyName = "crAmount";

                    dgvBankTransaction.Columns[7].Name = "drAmount";                 
                    dgvBankTransaction.Columns[7].DataPropertyName = "drAmount";

                    dgvBankTransaction.Columns[8].Name = "naration";                 
                    dgvBankTransaction.Columns[8].DataPropertyName = "naration";

                    dgvBankTransaction.Columns[9].Name = "isCashfrom";
                    dgvBankTransaction.Columns[9].HeaderText = "isCashfrom";
                    dgvBankTransaction.Columns[9].DataPropertyName = "isCashfrom";
                    dgvBankTransaction.Columns[9].Visible = false;

                    dgvBankTransaction.Columns[10].Name = "paymentType";                  
                    dgvBankTransaction.Columns[10].DataPropertyName = "paymentType";

                    dgvBankTransaction.Columns[11].Name = "bankName";
                    dgvBankTransaction.Columns[11].DataPropertyName = "bankName";

                    dgvBankTransaction.Columns[12].Name = "chequeNo";                   
                    dgvBankTransaction.Columns[12].DataPropertyName = "chequeNo";

                    dgvBankTransaction.Columns[13].Name = "chequeDate";                  
                    dgvBankTransaction.Columns[13].DataPropertyName = "chequeDate";

                    dgvBankTransaction.Columns[14].Name = "AccountType";                  
                    dgvBankTransaction.Columns[14].DataPropertyName = "AccountType";
                    dgvBankTransaction.Columns[15].Name = "transactionId";
                    dgvBankTransaction.Columns[15].HeaderText = "transactionId";
                    dgvBankTransaction.Columns[15].DataPropertyName = "transactionId";
                    dgvBankTransaction.Columns[15].Visible = false;
                    dgvBankTransaction.DataSource = dtBankTransaction;
            }
            catch (Exception)
            {
                ////MessageBox.Show("Something went wrong in gridview");
            }
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Bank Deposit";
                    lblAccountType.Text = "Account Type:";
                    lblTransactionDate.Text = "Date:";
                    lblAccountName.Text = "Account Name:";
                    lblAmount.Text = "Amount:";
                    lblNaration.Text = "Naration:";
                    lblTransaction.Text = "Payment Type:";
                    lblBankName.Text = "Bank Name:";
                    chbCash.Text = "Shop Cash";
                    lblChequeNo.Text = "Cheque No:";
                    lblChequeDate.Text = "Cheque Date";
                    btnnew.Text = "New(Alt+N)";
                    btnsave.Text = "Save (Alt+S)";
                    btnUpdate.Text = "Update";
                    btnDelete.Text = "Delete";
                    groupBox1.Text = "Search";
                    label1.Text = "From:";
                    label2.Text = "To:";
                    btnSearch.Text = "Search";
                    groupBox2.Text = "Bank Credit/Debit Details";              
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
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                cmbtransactiontype.SelectedIndex = 0;
                chbCash.Checked = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnsave.Enabled = true;
                isDelete = false;
                bindAccountType(true);
                cmbAccounttype.Focus();
                bankTransactionId1 = 0;
                dtpFromDate.MinDate = dtpToDate.MinDate = dtpDate.MinDate = Utility.firstDate;
                dtpFromDate.MaxDate = dtpToDate.MaxDate = dtpDate.MaxDate = Utility.lastDate;
                dtpFromDate.Value = Utility.firstDate;
                dtpToDate.Value = Utility.lastDate;
                if (dtpDate.Value < Utility.firstDate || dtpDate.Value > Utility.lastDate)
                {
                    dtpDate.Value = Utility.firstDate;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAccounttype.SelectedIndex <= 0 )
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Account Type.");
                    }
                    else
                    {
                        MessageBox.Show("कृपया खाते प्रकार निवडा.");
                    }
                    cmbAccounttype.Focus();
                    return;
                }
                else if (cmbAccountName.SelectedIndex <= 0 )
                {                    
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Account Name.");
                    }
                    else
                    {
                        MessageBox.Show("कृपया खाते नाव निवडा.");
                    }
                    cmbAccountName.Focus();
                    return;
                }
                else if (cmbtransactiontype.SelectedIndex < 0)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Transaction Type.");
                    }
                    else
                    {
                        MessageBox.Show("कृपया व्यवहार प्रकार निवडा.");
                    }
                    cmbtransactiontype.Focus();
                    return;
                }
                else if(cmbPaymentType.Text!="Cash")
                {
                    if (txtBankName.Text == "")
                    {                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Select Bank Name");
                        }
                        else
                        {
                            MessageBox.Show("कृपया बँक नाव निवडा");
                        }
                        return;
                    }
                }

                else if (txtAmount.Text == "" || txtAmount.Text == "0")
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Add Amount.");
                    }
                    else
                    {
                        MessageBox.Show("कृपया रक्कम भरा.");
                    }
                    txtAmount.Focus();
                    return;
                }
                if (cmbPaymentType.Text.Equals("Cheque"))
                {
                    if (txtBankName.Text == "")
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Bank Name !", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("कृपया बँकचे नाव भरा !", "Error", MessageBoxButtons.OK);
                        }
                        txtBankName.Focus();
                        return;
                    }
                    else if (txtChequeNo.Text.Equals("") || txtChequeNo.Text.Equals("0"))
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Cheque No & DD Number !", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("कृपया चेक नंबर आणि डीडी नंबर  भरा !", "Error", MessageBoxButtons.OK);
                        }
                        txtChequeNo.Focus();
                        return;
                    }
                }
                if (cmbPaymentType.Text.Equals("Card Payment"))
                {
                    if (txtBankName.Text == "")
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Fill Bank Name !", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("कृपया बँकचे नाव भरा !", "Error", MessageBoxButtons.OK);
                        }
                        txtBankName.Focus();
                        return;
                    }
                    else if (txtChequeNo.Text.Equals("") || txtChequeNo.Text.Equals("0"))
                    {                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Card No. !", "Error", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("कृपया कार्ड नंबर  भरा !", "Error", MessageBoxButtons.OK);
                        }
                        txtChequeNo.Focus();
                        return;
                    }
                }
                if (cmbPaymentType.Text.Equals("") || cmbPaymentType.Text.Equals("0"))
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select payment Type  !", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("कृपया  पेमेंट प्रकार निवडा  !", "Error", MessageBoxButtons.OK);
                    }
                    cmbPaymentType.Focus();
                    return;
                }
                else
                {
                    BankTransaction bankTransaction = new BankTransaction();
                    bankTransaction.transactionDate = Convert.ToDateTime(dtpDate.Value.ToShortDateString());
                    bankTransaction.financialYearID = Utility.FinancilaYearId; 
                    if (cmbtransactiontype.Text == "पैसे भरणे")
                    {
                        bankTransaction.crAmount = Convert.ToDouble(txtAmount.Text);
                        bankTransaction.drAmount = 0;
                    }
                    else
                    {
                        bankTransaction.drAmount = Convert.ToDouble(txtAmount.Text);
                        bankTransaction.crAmount = 0;
                    }
                    bankTransaction.bankTransactionId = bankTransactionId1;
                    bankTransaction.naration = txtNaration.Text.ToString();
                    bankTransaction.transactionId = Transaction_ID;
                    bankTransaction.accountTypeID = Convert.ToInt32(cmbAccounttype.SelectedValue);
                    bankTransaction.accountId = Convert.ToInt64(cmbAccountName.SelectedValue);
                    bankTransaction.paymentType = cmbPaymentType.Text;
                    bankTransaction.bankName = txtBankName.Text;
                    bankTransaction.ref_No = txtChequeNo.Text;
                    if(cmbPaymentType.Text=="Cash")
                    {
                        bankTransaction.paymentDate = Convert.ToDateTime(dtpDate.Value.ToShortDateString()); 
                    }
                    else
                    {
                        bankTransaction.paymentDate = Convert.ToDateTime(dtpChequeDate.Value.ToShortDateString());
                    }
                    bankTransaction.addedBy = Utility.LoginID;
                    bankTransaction.addedOn = Convert.ToDateTime(dtpDate.Value.ToShortDateString()); 
                    bankTransaction.isCashfrom = chbCash.Checked;
                    bankTransaction.isDelete = isDelete;
                    int i = accountDetailsController.SaveBankTransaction(bankTransaction);
                    if (isDelete == true)
                    {
                        if (i > 0)
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Record Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("माहिती यशस्वीरीत्या डिलीट केली गेली.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            btnnew_Click(sender, e);
                        }
                        else
                        {
                           
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Record Does not deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("माहिती डिलीट केली गेली नाही", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        if (i > 0)
                        {                          
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Record Saved Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("माहिती यशस्वीरीत्या जतन केली गेली.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            btnnew_Click(sender, e);
                        }
                        else
                        {                           
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Record Does not Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("माहिती जतन केली गेली नाही", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch(Exception ae)
            {
                MessageBox.Show("",ae.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnsave_Click(sender, e);
        }

        private void dgvBankTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvBankTransaction.Rows[e.RowIndex];
                    if (row.Cells != null)
                    {
                        bankTransactionId1 = Convert.ToInt64(row.Cells["bankTransactionId"].Value);
                        Transaction_ID = Convert.ToInt64(row.Cells["transactionId"].Value);
                        dtpDate.Text = row.Cells["transactionDate"].Value.ToString();
                        cmbAccounttype.Text = row.Cells["AccountType"].Value.ToString();
                        cmbAccountName.Text = row.Cells["AccountName"].Value.ToString();
                           //cmbtransactiontype.Text = row.Cells["transactionType"].Value.ToString();
                        double cr = Convert.ToDouble(row.Cells["crAmount"].Value);

                        if (cr > 0)
                        {
                            cmbtransactiontype.SelectedIndex = 0;
                            txtAmount.Text = row.Cells["crAmount"].Value.ToString();
                        }
                        else
                        {
                            cmbtransactiontype.SelectedIndex = 1;
                            txtAmount.Text = row.Cells["drAmount"].Value.ToString();
                        }

                        txtNaration.Text = row.Cells["naration"].Value.ToString();
                        cmbPaymentType.Text = row.Cells["paymentType"].Value.ToString();

                        txtBankName.Text = row.Cells["bankName"].Value.ToString();
                        if(row.Cells["chequeNo"].Value!=null){
                             txtChequeNo.Text = row.Cells["chequeNo"].Value.ToString();
                        }
                        else
                        {
                            txtChequeNo.Text = "";
                        }
                       
                        dtpChequeDate.Text = row.Cells["chequeDate"].Value.ToString();

                        Utility.enableFields(this);
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnsave.Enabled = false;
                        cmbAccountName.Enabled = false;
                        cmbAccounttype.Enabled = false;
                        btnDelete.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {                    
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Contact us. Mobile No (8975317596)", ex.Message);
                    }
                    else
                    {
                        MessageBox.Show("कृपया संपर्क करा. मोबईल नंबर (8975317596)", ex.Message);
                    }
            }
        }

        private void frmBankDeposit_Load(object sender, EventArgs e)
        {
            try
            {

                // btnClose.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                Utility.ClearSpace(this);
                Utility.disableFields(this);
               dtpFromDate.MinDate=dtpToDate.MinDate= dtpDate.MinDate = Utility.firstDate;
               dtpFromDate.MaxDate = dtpToDate.MaxDate = dtpDate.MaxDate = Utility.lastDate;
               dtpFromDate.Value = Utility.firstDate;
               dtpToDate.Value = Utility.lastDate;
               Lang();
                //    Utility.SetLogin(102, "Sachin");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbAccounttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAccounttype.SelectedIndex != 0)
                {
                    DataTable dtvillageId = accountDetailsController.getBankaccountName(Convert.ToInt32(cmbAccounttype.SelectedValue));
                    Utility.BindComboBoxDataSelect(cmbAccountName, dtvillageId, "accountId", "accountName");
                    cmbAccountName.Enabled = true;
                   
                }
                else
                {
                    cmbAccountName.Enabled = false;
                    cmbAccountName.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbAccountName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                long accountID = 0;
                if (cmbAccountName.SelectedIndex > 0)
                {
                    accountID = Convert.ToInt64(cmbAccountName.SelectedValue);
                }
                else
                {
                    accountID = 0;
                }
                DataTable dtBankTransaction = accountDetailsController.getBankTransactionByAccount(accountID);
                BindBankTransaction(dtBankTransaction);
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtpChequeDate.Value = DateTime.Now;
                if (cmbPaymentType.SelectedItem.ToString() == "Cash")
                {

                    lblChequeNo.Visible = false;
                    txtChequeNo.Visible = false;
                    txtBankName.Visible = false;
                    lblBankName.Visible = false;
                    dtpChequeDate.Visible = false;
                    lblChequeDate.Visible = false;

                }
                if (cmbPaymentType.SelectedItem.ToString() == "IMPS & NEFT & RTGS")
                {

                    lblChequeNo.Visible = true;
                    txtChequeNo.Visible = true;
                    txtBankName.Visible = true;
                    lblBankName.Visible = true;
                    dtpChequeDate.Visible = true;
                    lblChequeDate.Visible = true;
                }
                if (cmbPaymentType.SelectedItem.ToString() == "Card Payment")
                {

                    lblChequeNo.Visible = true;
                    txtChequeNo.Visible = true;
                    txtBankName.Visible = true;
                    lblBankName.Visible = true;
                    dtpChequeDate.Visible = true;
                    lblChequeDate.Visible = true;

                }
                //else
                if (cmbPaymentType.SelectedItem.ToString() == "Cheque")
                {

                    lblChequeNo.Visible = true;
                    txtChequeNo.Visible = true;
                    txtBankName.Visible = true;
                    lblBankName.Visible = true;
                    dtpChequeDate.Visible = true;
                    lblChequeDate.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtBankTransaction = accountDetailsController.getBankTransactionByDate(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()),Utility.FinancilaYearId);
            BindBankTransaction(dtBankTransaction);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtAmount.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtAmount.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBankDeposit_KeyDown(object sender, KeyEventArgs e)
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
                btnsave_Click(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var delete = DialogResult.No;
            if (Utility.Langn == "English")
            {
              delete=  MessageBox.Show("Really Want to Delete This Record ??", "Exit", MessageBoxButtons.YesNo);
            }
            else
            {
              delete=  MessageBox.Show("माहिती डीलीट यची का ??", "Exit", MessageBoxButtons.YesNo);
            }
            if (delete==DialogResult.Yes)
            {
                try
                {
                    isDelete = true;
                    btnsave_Click(sender, e);
                }
                catch(Exception ec)
                { MessageBox.Show(ec.Message); }
            }
        }

        private void dgvBankTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
