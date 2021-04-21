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
    public partial class frmVoucherRecipt : MetroForm
    {
        public frmVoucherRecipt()
        {
            InitializeComponent();
        }
        public void BindComboBoxgetaccountName()
        {
            DataTable dtgetaccountName = accountDetailsController.GetAccountGroup();
            Utility.BindComboBoxDataSelect(cmbAccountGroup, dtgetaccountName, "accountGroupId", "accountGroup");
        }
        public void getPaymentReceiptTransaction()
        {
            try
            {

                dgvPaymentReciept.DataSource = null;
                DataTable lstgetCompanyDetails = accountDetailsController.getPaymentReceiptTransaction(Utility.FinancilaYearId);

                dgvPaymentReciept.AutoGenerateColumns = false;
                dgvPaymentReciept.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvPaymentReciept.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvPaymentReciept.Font = new Font("Tahoma", 12);

                dgvPaymentReciept.EnableHeadersVisualStyles = false;

                dgvPaymentReciept.ColumnCount = 7;

                dgvPaymentReciept.Columns[0].Name = "accountId";
                dgvPaymentReciept.Columns[0].HeaderText = "accountId";
                dgvPaymentReciept.Columns[0].DataPropertyName = "accountId";
                dgvPaymentReciept.Columns[0].Visible = false;

                dgvPaymentReciept.Columns[1].Name = "paymentReceiptId";
                dgvPaymentReciept.Columns[1].HeaderText = "paymentReceiptId";
                dgvPaymentReciept.Columns[1].DataPropertyName = "paymentReceiptId";
                dgvPaymentReciept.Columns[1].Visible = false;

                dgvPaymentReciept.Columns[2].Name = "paymentRecieptInvoiceID";
                dgvPaymentReciept.Columns[2].HeaderText = "paymentRecieptInvoiceID";
                dgvPaymentReciept.Columns[2].DataPropertyName = "paymentRecieptInvoiceID";
                dgvPaymentReciept.Columns[2].Visible = false;

                if (Utility.Langn == "English")
                {
                    dgvPaymentReciept.Columns[3].Name = "receiptDate";
                    dgvPaymentReciept.Columns[3].HeaderText = "Date";
                    dgvPaymentReciept.Columns[3].DataPropertyName = "receiptDate";

                    dgvPaymentReciept.Columns[4].Name = "accountName";
                    dgvPaymentReciept.Columns[4].HeaderText = "Account Name";
                    dgvPaymentReciept.Columns[4].DataPropertyName = "accountName";
                    dgvPaymentReciept.Columns[4].Width = 250;
                    dgvPaymentReciept.Columns[5].Name = "crAmount";
                    dgvPaymentReciept.Columns[5].HeaderText = "CR.Amount";
                    dgvPaymentReciept.Columns[5].DataPropertyName = "crAmount";

                    dgvPaymentReciept.Columns[6].Name = "naration";
                    dgvPaymentReciept.Columns[6].HeaderText = "Naration";
                    dgvPaymentReciept.Columns[6].DataPropertyName = "naration";
                    dgvPaymentReciept.Columns[6].Width = 250;
                }
                else
                {
                    dgvPaymentReciept.Columns[3].Name = "receiptDate";
                    dgvPaymentReciept.Columns[3].HeaderText = "दिनांक";
                    dgvPaymentReciept.Columns[3].DataPropertyName = "receiptDate";

                    dgvPaymentReciept.Columns[4].Name = "accountName";
                    dgvPaymentReciept.Columns[4].HeaderText = "खात्याचे नांव";
                    dgvPaymentReciept.Columns[4].DataPropertyName = "accountName";
                    dgvPaymentReciept.Columns[4].Width = 250;
                    dgvPaymentReciept.Columns[5].Name = "crAmount";
                    dgvPaymentReciept.Columns[5].HeaderText = "जमा रक्कम";
                    dgvPaymentReciept.Columns[5].DataPropertyName = "crAmount";

                    dgvPaymentReciept.Columns[6].Name = "naration";
                    dgvPaymentReciept.Columns[6].HeaderText = "तपशील";
                    dgvPaymentReciept.Columns[6].DataPropertyName = "naration";
                    dgvPaymentReciept.Columns[6].Width = 250;
                }
            
                dgvPaymentReciept.DataSource = lstgetCompanyDetails;
                dgvPaymentReciept.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public double drAmount = 0;
        private void cmbAccountname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAccountname.SelectedIndex > 0)
            {
                double crDrAmount = accountDetailsController.getPaymentDueAmount(Convert.ToInt64(cmbAccountname.SelectedValue));
                lblDueAmount.Text = Math.Round(crDrAmount).ToString();
                if (crDrAmount < 0)
                {                   
                    if (Utility.Langn == "English")
                    {
                        lblRemAmt.Text = "Cr Amount:";
                    }
                    else
                    {
                        lblRemAmt.Text = "देणे(Cr):";
                    }
                    lblDueAmount.Text = Math.Round((-crDrAmount)).ToString();
                }
                else
                {                   
                    if (Utility.Langn == "English")
                    {
                        lblRemAmt.Text = "Dr Amount:";
                    }
                    else
                    {
                        lblRemAmt.Text = "येणे(Dr):";
                    }
                }


            }
            else
            {
                lblDueAmount.Text = "0";

            }
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Payment Receipt";
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
                    lblRemAmt.Text = "Remaining Amt:";
                    lblChequeNo.Text = "Cheque No:";
                    label33.Text = "Cheque Date:";
                    label7.Text = "No:";
                    label16.Text = "Next payment Date:";
                     label6.Text = "Account Name:";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmVoucherRecipt_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                BindComboBoxgetaccountName();
                getPaymentReceiptTransaction();
                dtpdate.MinDate = Utility.firstDate;
                dtpdate.MaxDate = Utility.lastDate;
                Lang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                BindComboBoxgetaccountName();
                getPaymentReceiptTransaction();
                txtpayid.Text = accountDetailsController.getMaxIdPaymentReceiptId(Utility.FinancilaYearId).ToString();
                cmbPaymentType.SelectedIndex = 0;
                lblDueAmount.Text = "0";
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
                //if ( cmbAccountGroup.SelectedIndex == 0)
                //{
                //    MessageBox.Show("कृपया खाते गट निवडा..!");
                //    cmbAccountGroup.Focus();
                //    return;
                //}
                if (cmbAccountname.SelectedIndex == 0 || cmbAccountname.SelectedValue==null)
                {                  
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Account Name ...!");
                    }
                    else
                    {
                        MessageBox.Show("कृपया खाते नाव निवडा ...!");
                    }
                    cmbAccountname.Focus();
                    return;
                }
                if (txtAmount.Text == string.Empty)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Add Amount");
                    }
                    else
                    {
                        MessageBox.Show("कृपया रक्कम भरा");
                    }
                    return;
                }

                if (cmbPaymentType.SelectedIndex > 0)
                {
                    if (cmbBank.Text.Equals("") || cmbBank.SelectedIndex == 0)
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
                PaymentReceipt paymentV = new PaymentReceipt();
                paymentV.paymentReceiptId = Convert.ToInt64(accountDetailsController.getMaxIdPaymentReceiptId(Utility.FinancilaYearId).ToString());
                paymentV.financialYearID = Utility.FinancilaYearId;
                paymentV.accountId = Convert.ToInt64(cmbAccountname.SelectedValue);
                paymentV.crAmount = Utility.ParseValue(txtAmount.Text);
                paymentV.receiptDate = Convert.ToDateTime(dtpdate.Value.ToShortDateString());
                paymentV.paymentType = cmbPaymentType.Text;
                paymentV.nextPayementDate = Convert.ToDateTime(dtpNextPaymentDetails.Value.ToShortDateString());
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
                if(cmbPaymentType.Text=="Cash")
                {
                    paymentV.chequeDate = Convert.ToDateTime(dtpNextPaymentDetails.Value.ToShortDateString());
                }
                else
                {
                    paymentV.chequeDate = Convert.ToDateTime(dtpchedate.Value.ToShortDateString());
                }
                paymentV.naration = txtNaration.Text;
                paymentV.addedBy = Utility.LoginID;
                paymentV.addedOn = Convert.ToDateTime(dtpNextPaymentDetails.Value.ToShortDateString());
                if(chkOpeningBalance.Checked==true)
                {
                    paymentV.isOpeningBalance = true;
                }
                else
                {
                    paymentV.isOpeningBalance = false;
                }
                int i = accountDetailsController.addPaymentReceipt(paymentV);
                if (i > 0)
                {
                    
                    if (Utility.Langn == "English")
                    {
                        DialogResult ShowReport = MessageBox.Show("Do you want to print Receipt....?", "Receipt", MessageBoxButtons.YesNo);
                        if (ShowReport == DialogResult.Yes)
                        {
                            paymentReceipt(paymentV.paymentReceiptId, Utility.FinancilaYearId);
                        }
                        else
                        {
                            MessageBox.Show("This Record saved Successfully..");
                        }
                    }
                    else
                    {
                        DialogResult ShowReport = MessageBox.Show("तुम्हाला  पावतीची प्रिंट हवी आहे का....?", "पावती", MessageBoxButtons.YesNo);
                        if (ShowReport == DialogResult.Yes)
                        {
                            paymentReceipt(paymentV.paymentReceiptId, Utility.FinancilaYearId);
                        }
                        else
                        {
                            MessageBox.Show("सदर नोंद यशस्वीरित्या  साठवली गेली  आहे..");                          
                        }
                    }
                  
                    Utility.ClearSpace(this);
                    Utility.enableFields(this);
                    BindComboBoxgetaccountName();
                    getPaymentReceiptTransaction();
                    txtpayid.Text = accountDetailsController.getMaxIdPaymentReceiptId(Utility.FinancilaYearId).ToString();
                    cmbPaymentType.SelectedIndex = 0;
                    lblDueAmount.Text = "0";
                    chkOpeningBalance.Checked = false;
                  

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void paymentReceipt(long paymentVoucherId,long financialYearID)
        {
            try
            {
                DataTable dt = accountDetailsController.getPaymentReceiptPrint(paymentVoucherId, financialYearID);
                string AmountInWord = Utility.NumberToWordMarathi(Convert.ToInt64(dt.Rows[0]["crAmount"].ToString()))+" "+"रुपये /- फक्त.";
                double crDrAmount = Math.Round(accountDetailsController.getPaymentDueAmount(Convert.ToInt64(dt.Rows[0]["accountId"])), 2);
                crptPaymentReceipt rpt = new crptPaymentReceipt();
                RptSaleBill frm = new RptSaleBill();
               // rpt.SetDataSource(dt);
                rpt.Database.Tables[0].SetDataSource(dt);
                rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                rpt.SetParameterValue(0, crDrAmount.ToString());
                rpt.SetParameterValue(1, AmountInWord);
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Refresh();
                frm.crystalReportViewer1.Refresh();
                frm.ShowDialog();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private void frmVoucherRecipt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Alt)
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

        private void cmbAccountGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
              
            //    if (cmbAccountGroup.SelectedIndex != 0)
            //    {
            //        DataTable dtvillageId = accountDetailsController.getaccountName(Convert.ToInt32(cmbAccountGroup.SelectedValue));
            //        Utility.BindComboBoxEmptyDataSelect(cmbAccountname, dtvillageId, "accountId", "accountName");
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
            //    lblDueAmount.Text = "0";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dgvPaymentReciept_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvPaymentReciept.Rows[e.RowIndex];
                    if (row.Cells != null)
                    {
                        Utility.ClearSpace(this);
                        txtVoucherId.Text = row.Cells["paymentRecieptInvoiceID"].Value.ToString();
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
                    DialogResult ShowReport = MessageBox.Show("Do You Want to Delete record?", "Delete", MessageBoxButtons.YesNo);
                  if (ShowReport == DialogResult.Yes)
                    {

                        int ia = accountDetailsController.PaymentReceiptDelete(Convert.ToInt64(txtVoucherId.Text), Utility.FinancilaYearId);
                        if (ia > 0)
                        {
                            MessageBox.Show("Record deleted successfully..!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);                           
                        }
                        else
                        {
                            MessageBox.Show(" This record Can't delete !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);                            
                        }
                    }
                    else
                    {
                        ShowReport = DialogResult.No;
                    }
                }
                else
                {
                    DialogResult ShowReport = DialogResult.No;
                    ShowReport = MessageBox.Show("माहिती डिलीट करायची का?", "डिलीट", MessageBoxButtons.YesNo);                   
                    if (ShowReport == DialogResult.Yes)
                    {

                        int ia = accountDetailsController.PaymentReceiptDelete(Convert.ToInt64(txtVoucherId.Text), Utility.FinancilaYearId);
                        if (ia > 0)
                        {
                            MessageBox.Show("सदर माहिती पुसल्या गेली..!", "डिलीट", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }
                        else
                        {
                            MessageBox.Show(" सदर माहिती पुसल्या गेली नाही !", "डिलीट", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                getPaymentReceiptTransaction();
                txtpayid.Text = accountDetailsController.getMaxIdPaymentReceiptId(Utility.FinancilaYearId).ToString();
                cmbPaymentType.SelectedIndex = 0;
            }
            else
            {
                if (Utility.Langn == "English")
                {
                    MessageBox.Show("Please Select Account Group..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("कृपया खाते गट निवडा..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                BindComboBoxgetaccountName();
                getPaymentReceiptTransaction();
                txtpayid.Text = accountDetailsController.getMaxIdPaymentReceiptId(Utility.FinancilaYearId).ToString();
                cmbPaymentType.SelectedIndex = 0;
            }
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
                    //if (cmbAccountGroup.SelectedIndex != 0)
                    //{
                    //    DataTable dtvillageId = accountDetailsController.getaccountName(Convert.ToInt32(cmbAccountGroup.SelectedValue));
                    //    Utility.BindComboBoxDataSelect(cmbAccountname, dtvillageId, "accountId", "accountName");
                    //    cmbAccountname.Enabled = true;
                    //    txtmobile.Enabled = true;
                    //}
                    //else
                    //{
                    //    BindComboBoxgetaccountName();
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void txtmobile_TextChanged(object sender, EventArgs e)
        {
            //if (txtmobile.Text != string.Empty && cmbAccountGroup.SelectedIndex!=0)
            //{
            //    DataTable dt = accountDetailsController.getAccountNameByMobileAndGroups(Convert
            //        .ToInt32(cmbAccountGroup.SelectedValue),Utility.ParseValueI(txtmobile.Text).ToString());
            //    if (dt.Rows.Count > 0)
            //    {
            //        cmbAccountname.Text = dt.Rows[0]["accountName"].ToString();
            //    }
                
            //}
            //else
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
            //        BindComboBoxgetaccountName();
            //    }
            //}
        }

        private void txtAccountName_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPaymentReciept.Rows)
            {
                string s = row.Cells[4].Value.ToString();

                if (!s.StartsWith(txtAccountName.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvPaymentReciept.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                    dgvPaymentReciept.Visible = true;
                }
                else
                    row.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                    lblChequeNo.Text = "चेक /डीडी क्रमांक";
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

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long paymentRecieptId = Convert.ToInt64(dgvPaymentReciept.Rows[rowIndex].Cells["paymentRecieptInvoiceID"].Value.ToString());
            paymentReceipt(paymentRecieptId,Utility.FinancilaYearId);
        }
        int rowIndex = 0;
        private void dgvPaymentReciept_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvPaymentReciept.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.contextMenuStrip1.Show(this.dgvPaymentReciept, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblPaymenttype_Click(object sender, EventArgs e)
        {

        }

        private void lblBankName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
