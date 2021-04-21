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
using MetroFramework.Forms;
using MetroFramework.Fonts;

namespace Dlogic_Wholesaler.Forms
{
    public partial class frmAccountDetails : MetroForm
    {
        public frmAccountDetails()
        {
            InitializeComponent();
        }
        public static int accountId = 0;
        public void BindComboBoxaccountType()
        {
            DataTable dtvillageId = accountGroupController.getaccountType();
            Utility.BindComboBoxDataSelect(cmbaccoutType, dtvillageId, "accountTypeId", "accountType");
        }

        public void dgvAccountDetailsForAccountGroup()
        {
            DataTable dt = accountDetailsController.getAccountDetailsForAccountGroup();
            dgvAccountDetailsGroup.DataSource = dt;

            dgvAccountDetailsGroup.AutoGenerateColumns = false;
            dgvAccountDetailsGroup.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvAccountDetailsGroup.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAccountDetailsGroup.Font = new Font("Tahoma", 11);

            dgvAccountDetailsGroup.EnableHeadersVisualStyles = false;
        }

        private void cmbaccoutType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbaccoutType.SelectedIndex != 0)
                {
                    DataTable dtvillageId = accountGroupController.getAccountGroupById(Convert.ToInt32(cmbaccoutType.SelectedValue));
                    Utility.BindComboBoxDataSelect(cmbAccountGroup, dtvillageId, "accountGroupId", "accountGroup");
                    cmbAccountGroup.Enabled = true;
                }
                else
                {
                    cmbAccountGroup.Enabled = false;
                    cmbAccountGroup.SelectedIndex = -1;
                    cmbAccountName.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbAccountGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAccountGroup.SelectedIndex > 0)
                {
                    DataTable dtAccountSubGroup = accountGroupController.getAccountSubGroupDetails(Convert.ToInt32(cmbAccountGroup.SelectedValue));
                   // DataTable dtvillageId = accountGroupController.getAccountNameById(Convert.ToInt32(cmbAccountGroup.SelectedValue));
                    Utility.BindComboBoxDataSelect(cmbAccountSupGroup, dtAccountSubGroup, "accountSubGroupId", "accountSubGroupName");
                    cmbAccountSupGroup.Enabled = true;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Account Details";
                    metroLabel1.Text = "Account Type:";
                    metroLabel3.Text = "Account Group:";
                    label2.Text = "Account SubGroup:";// "Account Group SubGroup:";
                    metroLabel2.Text = "Account Name:";
                    label5.Text = "Mobile No:";
                    label3.Text = "GST No:";
                    metroLabel4.Text = "Customer/Bank:";
                    lblaccountNo.Text = "Account No:";
                    label4.Text = "Openig Balanace:";
                    metroLabel5.Text = "Cr/Dr";
                    btnNew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    btnUpdate.Text = "Update";
                    btnDelete.Text = "Delete";

                    label1.Text = "Account Name:";

                    dgvAccountDetailsGroup.Columns[1].HeaderText = "Account Name";
                    dgvAccountDetailsGroup.Columns[2].HeaderText = "Mobile No";
                    dgvAccountDetailsGroup.Columns[3].HeaderText = "Account Type";
                    dgvAccountDetailsGroup.Columns[4].HeaderText = "Account Group";
                    dgvAccountDetailsGroup.Columns[5].HeaderText = "IsBank";
              }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void frmAccountDetails_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                BindComboBoxaccountType();
                Lang();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                BindComboBoxaccountType();
                cmbAccountName.Enabled = false;
                cmbIsCustomerDealer.SelectedIndex = 0;
                cmbCreditDebit.SelectedIndex = 0;
                dgvAccountDetailsForAccountGroup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbIsCustomerDealer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbIsCustomerDealer.Text == "बँक")
                {
                    lblaccountNo.Visible = true;
                    txtAccountNo.Visible = true;
                }
                else
                {
                    lblaccountNo.Visible = false;
                    txtAccountNo.Visible = false;
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
                if (cmbaccoutType.SelectedIndex == 0)
                {
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Account Type ...!");
                    }
                    else
                    {
                        MessageBox.Show("कृपया खाते प्रकार निवडा...!");
                    }
                
                    cmbaccoutType.Focus();
                    return;
                }
                if (cmbAccountGroup.SelectedIndex == 0)
                {                  
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Account Group...!");
                    }
                    else
                    {
                        MessageBox.Show("कृपया खाते गट निवडा ...!");
                    }
                    cmbAccountGroup.Focus();
                    return;
                }
                if (cmbAccountSupGroup.SelectedIndex == 0)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Account Group Subgroup...!");
                    }
                    else
                    {
                        MessageBox.Show("कृपया खाते गट उपप्रकार  निवडा ...!");
                    }
                    cmbAccountGroup.Focus();
                    return;
                }
                if (cmbAccountName.Text == string.Empty || cmbAccountName.Text == "-- Select --")
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Account Name ...!");
                    }
                    else
                    {
                        MessageBox.Show("कृपया खाते नाव निवडा ...!");
                    }
                    cmbAccountName.Focus();
                    return;
                }
                if (cmbIsCustomerDealer.Text == "बँक")
                {
                    if (txtAccountNo.Text == string.Empty)
                    {
                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Select Bank Name ...!");
                        }
                        else
                        {
                            MessageBox.Show("कृपया बँक नाव निवडा ..!");
                        }
                        txtAccountNo.Focus();
                        return;
                    }

                }
                AccountDetails account = new AccountDetails();
                if (txtAmount.Text == "")
                {
                    txtAmount.Text = "0";
                }
                if (cmbIsCustomerDealer.SelectedIndex == 0 || cmbIsCustomerDealer.Text == "--निवडा--")
                {
                    account.isCustomerSupplier = "";
                }
                else
                {
                    account.isCustomerSupplier = cmbIsCustomerDealer.Text;
                }
                account.accountTypeId = Convert.ToInt32(cmbaccoutType.SelectedValue);
                account.accountGroupId = Convert.ToInt32(cmbAccountGroup.SelectedValue);
                account.accountSubGroupId = Convert.ToInt32(cmbAccountSupGroup.SelectedValue);
                account.accountName = cmbAccountName.Text;
                account.accountGSTNO = txtGSTNo.Text.Trim();
                account.MobileNo = txtMobileNo.Text.Trim();
                account.accountNo = txtAccountNo.Text;
                account.addedOn = Utility.firstDate;
                account.openigBalanace = Utility.ParseValue(txtAmount.Text);
                account.isCreditDebit = cmbCreditDebit.Text;
                account.FinancialYearID = Utility.FinancilaYearId;
                if (cmbIsCustomerDealer.Text == "बँक")
                {
                    account.isActive = true;
                }
                else
                {
                    account.isActive = false;
                }

                int i = accountDetailsController.addAcountDetails(account);
                if (i > 0)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Record Saved Successfully ...!");
                    }
                    else
                    {
                        MessageBox.Show("माहिती यशस्वीरित्या भरली गेली ...!");
                    }
                    Utility.ClearSpace(this);
                    Utility.enableFields(this);
                    btnSave.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    BindComboBoxaccountType();
                    cmbAccountName.Enabled = false;
                    cmbIsCustomerDealer.SelectedIndex = 0;
                    cmbCreditDebit.SelectedIndex = 0;
                    dgvAccountDetailsForAccountGroup();

                }
                if (i < 0)
                {
                  //  MessageBox.Show("खाते प्रकार आणि खाते गट  आधीच यादी मध्ये आहे     !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Account Type and Account Group Already Present ...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("खाते प्रकार आणि खाते गट आधीच उपलब्ध आहे ...!", "माहिती", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAccountDetails_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.F1)
                {
                    frmAccountGroup frm = new frmAccountGroup();
                    frm.ShowDialog();
                }
                if(e.KeyCode==Keys.N && e.Alt)
                {
                    btnNew_Click(sender,e);
                }
                if (e.KeyCode == Keys.S && e.Alt)
                {
                    btnSave_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAccountGroup_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccountGroup frm = new frmAccountGroup();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void txtAccountNameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                ((DataTable)dgvAccountDetailsGroup.DataSource).DefaultView.RowFilter = string.Format("AccountName like '%{0}%'", txtAccountNameSearch.Text.Trim().Replace("'", "''"));
    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbAccountSupGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (cmbAccountSupGroup.SelectedIndex != 0)
                    {
                      //  DataTable dtAccountSubGroup = accountGroupController.getAccountSubGroupDetails(Convert.ToInt32(cmbAccountGroup.SelectedValue));
                        DataTable dtvillageId = accountGroupController.getAccountNameBySubGroupId(Convert.ToInt64(cmbAccountSupGroup.SelectedValue));
                        Utility.BindComboBoxEmptyDataSelect(cmbAccountName, dtvillageId, "accountId", "accountName");
                        cmbAccountName.Enabled = true;
                    }
                    else
                    {
                        cmbAccountName.Enabled = false;
                        cmbAccountName.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception ae)
            {
                MessageBox.Show("Error!" + ae.ToString());
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Utility.SingleDecimal(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccountSubGroup frm = new frmAccountSubGroup();
                frm.ShowDialog();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
