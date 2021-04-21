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
using DataAccessLayer.models;
using DataAccessLayer.controller;
using Dlogic_Wholesaler.ReportFrom;
using Dlogic_Wholesaler.CrystalReport;

namespace Dlogic_Wholesaler.Forms
{
    public partial class frmVoucherPayment : MetroForm
    {
        public frmVoucherPayment()
        {
            InitializeComponent();
        }
        public void BindComboBoxgetaccountName()
        {
            DataTable dtgetaccountName = accountDetailsController.GetAccountGroup();
            Utility.BindComboBoxDataSelect(cmbAccountGroup, dtgetaccountName, "accountGroupId", "accountGroup");
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Payment Voucher";                   
                    metroLabel3.Text = "Account Group:";
                    label3.Text = "Account Name:";
                    label2.Text = "No:";
                    metroLabel1.Text = "Mobile No:";
                    label4.Text = "Amount:";               
                    lblPaymenttype.Text = "Payment Type:";                   
                    lblBankName.Text = "Bank Name:";
                    label5.Text = "Naration:";
                    label1.Text = "Date:";
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";                    
                    btnDelete.Text = "Delete";
                    chkOpeningBalance.Text = "Opening Balance";
                    lblRemAmount.Text = "Remaining Amt:";
                    lblChequeNo.Text = "Cheque No:";
                    label33.Text = "Cheque Date:";
                    label7.Text = "No:";
                    label6.Text = "Account Name:";               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public void getPaymentVoucherTransaction()
        {
            try
            {

                dgvPaymentVoucher.DataSource = null;
                DataTable lstgetCompanyDetails = accountDetailsController.getPaymentVoucherTransaction(Utility.FinancilaYearId);

                dgvPaymentVoucher.AutoGenerateColumns = false;
                dgvPaymentVoucher.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvPaymentVoucher.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvPaymentVoucher.Font = new Font("Tahoma", 12);

                dgvPaymentVoucher.EnableHeadersVisualStyles = false;

                dgvPaymentVoucher.ColumnCount = 7;

                dgvPaymentVoucher.Columns[0].Name = "accountId";
                dgvPaymentVoucher.Columns[0].HeaderText = "accountId";
                dgvPaymentVoucher.Columns[0].DataPropertyName = "accountId";
                dgvPaymentVoucher.Columns[0].Visible = false;

                dgvPaymentVoucher.Columns[1].Name = "paymentVoucherId";
                dgvPaymentVoucher.Columns[1].HeaderText = "paymentVoucherId";
                dgvPaymentVoucher.Columns[1].DataPropertyName = "paymentVoucherId";
                dgvPaymentVoucher.Columns[1].Visible = false;

                dgvPaymentVoucher.Columns[2].Name = "paymentVoucherInvoiceID";
                dgvPaymentVoucher.Columns[2].HeaderText = "paymentVoucherInvoiceID";
                dgvPaymentVoucher.Columns[2].DataPropertyName = "paymentVoucherInvoiceID";
                dgvPaymentVoucher.Columns[2].Visible = false;
                if (Utility.Langn == "English")
                {
                    dgvPaymentVoucher.Columns[3].Name = "voucherDate";
                    dgvPaymentVoucher.Columns[3].HeaderText = "Date";
                    dgvPaymentVoucher.Columns[3].DataPropertyName = "voucherDate";

                    dgvPaymentVoucher.Columns[4].Width = 250;

                    dgvPaymentVoucher.Columns[4].Name = "accountName";
                    dgvPaymentVoucher.Columns[4].HeaderText = "Account Name";
                    dgvPaymentVoucher.Columns[4].DataPropertyName = "accountName";

                    dgvPaymentVoucher.Columns[5].Name = "drAmount";
                    dgvPaymentVoucher.Columns[5].HeaderText = "DR.Amount";
                    dgvPaymentVoucher.Columns[5].DataPropertyName = "drAmount";

                    dgvPaymentVoucher.Columns[6].Name = "naration";
                    dgvPaymentVoucher.Columns[6].HeaderText = "Naration";
                    dgvPaymentVoucher.Columns[6].DataPropertyName = "naration";
                    dgvPaymentVoucher.Columns[6].Width = 250;
                }
                else
                {
                    dgvPaymentVoucher.Columns[3].Name = "voucherDate";
                    dgvPaymentVoucher.Columns[3].HeaderText = "दिनांक";
                    dgvPaymentVoucher.Columns[3].DataPropertyName = "voucherDate";

                    dgvPaymentVoucher.Columns[4].Width = 250;

                    dgvPaymentVoucher.Columns[4].Name = "accountName";
                    dgvPaymentVoucher.Columns[4].HeaderText = "खात्याचे नांव";
                    dgvPaymentVoucher.Columns[4].DataPropertyName = "accountName";

                    dgvPaymentVoucher.Columns[5].Name = "drAmount";
                    dgvPaymentVoucher.Columns[5].HeaderText = "नावे रक्कम";
                    dgvPaymentVoucher.Columns[5].DataPropertyName = "drAmount";

                    dgvPaymentVoucher.Columns[6].Name = "naration";
                    dgvPaymentVoucher.Columns[6].HeaderText = "तपशील";
                    dgvPaymentVoucher.Columns[6].DataPropertyName = "naration";
                    dgvPaymentVoucher.Columns[6].Width = 250;
                }

              
                dgvPaymentVoucher.DataSource = lstgetCompanyDetails;
                dgvPaymentVoucher.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmVoucherPayment_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                BindComboBoxgetaccountName();
                getPaymentVoucherTransaction();
                dtpdate.MinDate = Utility.firstDate;
                dtpdate.MaxDate = Utility.lastDate;
                Lang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public double drAmount = 0;
        private void cmbAccountname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAccountname.SelectedIndex != 0)
            {
                double crDrAmount = accountDetailsController.getPaymentDueAmount(Convert.ToInt64(cmbAccountname.SelectedValue));
                lblVimalDueAmount.Text = Math.Round(crDrAmount).ToString();            
                if (crDrAmount < 0)
                {                 
                    if (Utility.Langn == "English")
                    {
                        lblRemAmount.Text = "Cr Amount:";
                    }
                    else
                    {
                        lblRemAmount.Text = "देणे(Cr):-";
                    }
                    lblVimalDueAmount.Text = Math.Round((-crDrAmount)).ToString();
                }
                else
                {                   
                    if (Utility.Langn == "English")
                    {
                        lblRemAmount.Text = "Dr Amount:";
                    }
                    else
                    {
                        lblRemAmount.Text = "येणे(Dr):-";
                    }
                }
            }
            else
            {
                lblVimalDueAmount.Text = "0";
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                BindComboBoxgetaccountName();
                getPaymentVoucherTransaction();
                txtpayid.Text = accountDetailsController.getMaxIdPaymentVoucherId(Utility.FinancilaYearId).ToString();
                cmbPaymentType.SelectedIndex = 0;
                chkOpeningBalance.Checked = false;
                if (dtpdate.Value < Utility.firstDate || dtpdate.Value > Utility.lastDate)
                {
                    dtpdate.Value = Utility.firstDate;
                }
                accountNameBind();

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
                #region Validation
                //if (cmbAccountGroup.SelectedIndex == 0)
                //{
                //    MessageBox.Show("कृपया खाते गट निवडा....!", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    cmbAccountGroup.Focus();
                //    return;
                //}

                if (cmbAccountname.SelectedIndex ==0 || cmbAccountname.Text == string.Empty || cmbAccountname.SelectedValue==null)
                {                    
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Account Name ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    }
                    else
                    {
                        MessageBox.Show("कृपया खात्याचे नांव निवडा....!", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmbAccountname.Focus();
                    return;
                }
                if (txtAmount.Text == string.Empty )
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Add Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया  रक्कम भरा....!", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtAmount.Focus();
                    return;
                }

                if (cmbPaymentType.SelectedIndex >0)
                {
                    if (cmbBank.Text.Equals("") || cmbBank.SelectedIndex==0)                    
                    {

                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add bank Name...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया बँकचे नाव  भरा...!", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cmbBank.Focus();
                        return;
                    }
                    else if (txtchqDDNo.Text.Equals("") || txtchqDDNo.Text.Equals("0"))
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Cheque/DD Number...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया चेक / डीडी/रेफ  नंबर भरा...!", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        txtchqDDNo.Focus();
                        return;
                    }
                }
               
                #endregion
                PaymentVoucher paymentV = new PaymentVoucher();
                paymentV.paymentVoucherId = Convert.ToInt64(accountDetailsController.getMaxIdPaymentVoucherId(Utility.FinancilaYearId).ToString());
                paymentV.financialYearID = Utility.FinancilaYearId;
                paymentV.accountId = Convert.ToInt64(cmbAccountname.SelectedValue);
                paymentV.drAmount = Utility.ParseValue(txtAmount.Text);
                paymentV.voucherDate = Convert.ToDateTime(dtpdate.Value.ToShortDateString());                           
                paymentV.paymentType = cmbPaymentType.Text;
               
                if (cmbBank.SelectedIndex > 0)
                {
                    paymentV.bankId = Convert.ToInt32(cmbBank.SelectedValue);
                    paymentV.bankName = cmbBank.Text;
                }
                else
                {
                    paymentV.bankId = 0;
                    paymentV.bankName = "";
                }
                paymentV.chequeNo_refNo = txtchqDDNo.Text;
                if (cmbPaymentType.Text == "Cash")
                {
                    paymentV.chequeDate = Convert.ToDateTime(dtpdate.Value.ToShortDateString());   
                }
                else
                {
                    paymentV.chequeDate = Convert.ToDateTime(dtpchedate.Value.ToShortDateString());
                }
                paymentV.naration = txtNaration.Text;
                paymentV.addedBy = Utility.LoginID;
                paymentV.addedOn = Convert.ToDateTime(dtpdate.Value.ToShortDateString());   
                if(chkOpeningBalance.Checked==true)
                {
                    paymentV.isOpeningBalance = true;
                }
                else
                {
                    paymentV.isOpeningBalance = false;
                }
                int i = accountDetailsController.addPaymentVoucher(paymentV);
                if (i > 0)
                {
                   
                    if (Utility.Langn == "English")
                    {
                        DialogResult ShowReport = MessageBox.Show("Do you want to print Receipt....?", "Receipt", MessageBoxButtons.YesNo);
                        if (ShowReport == DialogResult.Yes)
                        {
                            paymentVoucher(paymentV.paymentVoucherId);
                        }
                        else
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("This Record saved Successfully..");
                            }
                            else
                            {
                                MessageBox.Show("सदर नोंद यशस्वीरित्या  साठवली गेली  आहे..");
                            }
                        }
                    }
                    else
                    {
                        DialogResult ShowReport = MessageBox.Show("तुम्हाला  पावतीची प्रिंट हवी आहे का....?", "पावती", MessageBoxButtons.YesNo);
                        if (ShowReport == DialogResult.Yes)
                        {
                            paymentVoucher(paymentV.paymentVoucherId);
                        }
                        else
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("This Record saved Successfully..");
                            }
                            else
                            {
                                MessageBox.Show("सदर नोंद यशस्वीरित्या  साठवली गेली  आहे..");
                            }
                        }
                    }
                   
                    Utility.ClearSpace(this);
                    Utility.enableFields(this);
                    BindComboBoxgetaccountName();
                    getPaymentVoucherTransaction();
                    txtpayid.Text = accountDetailsController.getMaxIdPaymentVoucherId(Utility.FinancilaYearId).ToString();
                    cmbPaymentType.SelectedIndex = 0;
                    lblVimalDueAmount.Text = "0";
                    chkOpeningBalance.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void paymentVoucher(long paymentVoucherId)
        {
                try
                {
                    DataTable dt = accountDetailsController.getPaymentVoucherPrint(paymentVoucherId,Utility.FinancilaYearId);
                    string AmountInWord = null;
                    if (Utility.Langn == "English")
                    {
                        AmountInWord = Utility.NumberToWordMarathi(Convert.ToInt64(dt.Rows[0]["drAmount"].ToString())) + " " + "rupees /- Only."; ;
                    }
                    else
                    {
                        AmountInWord = Utility.NumberToWordMarathi(Convert.ToInt64(dt.Rows[0]["drAmount"].ToString())) + " " + "रुपये /- फक्त."; ;
                    }
                    double crDrAmount = Math.Round(accountDetailsController.getPaymentDueAmount(Convert.ToInt64(dt.Rows[0]["accountId"])), 2);
                    crptPaymentVoucher rpt = new crptPaymentVoucher();
                    RptSaleBill frm = new RptSaleBill();
                   // rpt.SetDataSource(dt);
                    rpt.Database.Tables[0].SetDataSource(dt);
                    rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                    rpt.SetParameterValue(0, crDrAmount.ToString());
                    rpt.SetParameterValue(1,AmountInWord);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.Refresh();
                    frm.crystalReportViewer1.Refresh();
                    frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
        private void frmVoucherPayment_KeyDown(object sender, KeyEventArgs e)
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
                btnSave_Click(sender, e);
            }
        }
        private void accountNameBind()
        {
            try
            {
                DataTable dtvillageId = accountDetailsController.getaccountName(Convert.ToInt32(0));
                Utility.BindComboBoxEmptyDataSelect(cmbAccountname, dtvillageId, "accountId", "accountName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void cmbAccountGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (cmbAccountGroup.SelectedIndex != 0)
            //    {
            //        DataTable dtvillageId = accountDetailsController.getaccountName(Convert.ToInt32(cmbAccountGroup.SelectedValue));
            //        Utility.BindComboBoxDataSelect(cmbAccountname, dtvillageId, "accountId", "accountName");
            //        cmbAccountname.Enabled = true;
            //        txtmobile.Enabled = true;
            //    }
            //    else
            //    {
            //        cmbAccountname.Enabled = false;
            //        cmbAccountname.DataSource = null;
            //        txtmobile.Text = "";
            //        txtmobile.Enabled = false;
            //    }
            //    lblVimalDueAmount.Text = "0";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dgvPaymentVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvPaymentVoucher.Rows[e.RowIndex];
                    if (row.Cells != null)
                    {
                        Utility.ClearSpace(this);
                        txtVoucherId.Text = row.Cells["paymentVoucherInvoiceID"].Value.ToString();                     
                        Utility.enableFields(this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtVoucherId.Text != "")
            {               
                if (Utility.Langn == "English")
                {
                    DialogResult ShowReport = MessageBox.Show("Do You Really Want to delete this record....?", "Receipt", MessageBoxButtons.YesNo);
                    if (ShowReport == DialogResult.Yes)
                    {

                        int ia = accountDetailsController.VoucherPaymentDelete(Convert.ToInt64(txtVoucherId.Text), Utility.FinancilaYearId);
                        if (ia > 0)
                        {
                            MessageBox.Show("This record deleted successfully. !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("this record can't delete. !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        ShowReport = DialogResult.No;
                    }
                }
                else
                {
                    DialogResult ShowReport = MessageBox.Show("तुम्हाला सदर  नोंद  डिलीट  करायची आहे  का....?", "पावती", MessageBoxButtons.YesNo);
                    if (ShowReport == DialogResult.Yes)
                    {

                        int ia = accountDetailsController.VoucherPaymentDelete(Convert.ToInt64(txtVoucherId.Text), Utility.FinancilaYearId);
                        if (ia > 0)
                        {
                            MessageBox.Show("सदर नोंद  डिलीट  झाली आहे. !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("सदर नोंद  डिलीट  झाली नाही . !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        ShowReport = DialogResult.No;
                    }
                }
               
                Utility.ClearSpace(this);
                Utility.enableFields(this);           
                btnSave.Enabled = true;
                BindComboBoxgetaccountName();
                getPaymentVoucherTransaction();
                txtpayid.Text = accountDetailsController.getMaxIdPaymentVoucherId(Utility.FinancilaYearId).ToString();
                cmbPaymentType.SelectedIndex = 0;
            }
            else
            {               
                if (Utility.Langn == "English")
                {
                    MessageBox.Show("Please Add Account Name..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("कृपया खात्याचे नाव भरा..!", "जतन", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                BindComboBoxgetaccountName();
                getPaymentVoucherTransaction();
                txtpayid.Text = accountDetailsController.getMaxIdPaymentVoucherId(Utility.FinancilaYearId).ToString();
                cmbPaymentType.SelectedIndex = 0;
            }
        }

        private void txtAccountNameSerach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvPaymentVoucher.Rows)
                {
                    string s = row.Cells[4].Value.ToString();

                    if (!s.StartsWith(txtAccountNameSerach.Text, true, null))
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvPaymentVoucher.DataSource];
                        currencyManager1.SuspendBinding();
                        row.Visible = false;
                        currencyManager1.ResumeBinding();
                        dgvPaymentVoucher.Visible = true;
                    }
                    else
                        row.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    lblChequeNo.Visible = true;
                    if (Utility.Langn == "English")
                    {
                        lblChequeNo.Text = "Refference No.";
                    }
                    else
                    {
                        lblChequeNo.Text = "संदर्भक्रमांक ";
                    }
                    lblBankName.Visible = true;
                    cmbBank.Visible = true;
                    txtchqDDNo.Visible = true;
                    txtchqDDNo.Text = "";
                    label33.Visible = false;
                    dtpchedate.Visible = false;
                }
                if (cmbPaymentType.SelectedItem.ToString() == "NEFT")
                {
                    lblChequeNo.Visible = true;
                    if (Utility.Langn == "English")
                    {
                        lblChequeNo.Text = "Refference No.";
                    }
                    else
                    {
                        lblChequeNo.Text = "संदर्भक्रमांक ";
                    }
                    lblBankName.Visible = true;
                    cmbBank.Visible = true;
                    txtchqDDNo.Visible = true;
                    txtchqDDNo.Text = "";
                    label33.Visible = false;
                    dtpchedate.Visible = false;
                }
                if (cmbPaymentType.SelectedItem.ToString() == "RTGS")
                {
                    lblChequeNo.Visible = true;
                    if (Utility.Langn == "English")
                    {
                        lblChequeNo.Text = "Refference No.";
                    }
                    else
                    {
                        lblChequeNo.Text = "संदर्भक्रमांक ";
                    }
                    lblBankName.Visible = true;
                    txtchqDDNo.Text = "";
                    cmbBank.Visible = true;
                    txtchqDDNo.Visible = true;
                    label33.Visible = false;
                    dtpchedate.Visible = false;
                }
                //else
                if (cmbPaymentType.SelectedItem.ToString() == "Cheque" || cmbPaymentType.SelectedItem.ToString() == "Dimand Draft")
                {
                    lblChequeNo.Visible = true;                  
                    if (Utility.Langn == "English")
                    {
                        lblChequeNo.Text = "Cheque/DD No:";
                    }
                    else
                    {
                        lblChequeNo.Text = "चेक /डीडी क्रमांक";
                    }
                    lblBankName.Visible = true;
                    cmbBank.Visible = true;
                    txtchqDDNo.Visible = true;
                    txtchqDDNo.Text = "";
                    label33.Visible = true;
                    dtpchedate.Visible = true;
                }
                BindBank();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindBank()
        {
            Utility.BindComboBoxDataSelect(cmbBank, accountDetailsController.GetAccountWisePaymentDue(0, "BankBind", Utility.FinancilaYearId), "accountId", "accountName");
        }
       
        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long paymentRecieptId = Convert.ToInt64(dgvPaymentVoucher.Rows[rowIndex].Cells["paymentVoucherInvoiceID"].Value.ToString());
            paymentVoucher(paymentRecieptId);
        }
        int rowIndex = 0;
        private void dgvPaymentVoucher_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.dgvPaymentVoucher.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.contextMenuStrip1.Show(this.dgvPaymentVoucher, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtmobile_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
            if (txtmobile.Text != string.Empty)
            {
                DataTable dt = accountDetailsController.getAccountNameByMobileAndGroups(Convert
                    .ToInt32(cmbAccountGroup.SelectedValue), Utility.ParseValueI(txtmobile.Text).ToString());
                if (dt.Rows.Count > 0)
                {
                    cmbAccountname.Text = dt.Rows[0]["accountName"].ToString();
                }
            }
            else
            {
                
            } }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
            
        }
    }
}
