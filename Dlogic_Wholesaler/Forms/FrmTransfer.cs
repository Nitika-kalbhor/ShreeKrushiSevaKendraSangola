using DataAccessLayer.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dlogic_Wholesaler.Forms
{
    public partial class FrmTransfer : Form
    {
        public FrmTransfer()
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
                    lblHerader.Text = "Account Transfer";
                    rbCustomer.Text = "Customer";
                    rbDealer.Text = "Dealer";
                    metroLabel2.Text = "Correct Account Name:";
                    label1.Text = "Incorrect Account Name:";
                    btnSelectAccount.Text = "Select Account";
                    btnSave.Text = "Save";                
                   dgvCustomerDetails.Columns[1].HeaderText = "Account Name";                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void FrmTransfer_Load(object sender, EventArgs e)
        {
            rbCustomer.Checked = true;
            dgvCustomerDetails.Rows.Clear();
            Lang();
        }
        private void btnSelectAccount_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dgvCustomerDetails.Rows)
            {
                if (rows.Cells["accountId"].Value != null)
                {
                    if (rows.Cells["accountId"].Value.ToString().Equals(cmbWrongAccountName.SelectedValue.ToString()))
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("This details already present in list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया माहिती लिस्ट मध्ये आधीच उपलब्ध आहे !", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvCustomerDetails.Focus();
                        return;
                    }
                }
            }
            if (dgvCustomerDetails.Rows.Count == 0)
            {
                dgvCustomerDetails.Rows.Add();
            }
            else
            {
                dgvCustomerDetails.CurrentCell = dgvCustomerDetails.CurrentRow.Cells["accountName"];
                int col = dgvCustomerDetails.CurrentCell.ColumnIndex;
                int row = dgvCustomerDetails.CurrentCell.RowIndex;
                col = 0;
                row++;
                if (row == dgvCustomerDetails.RowCount)
                {
                    dgvCustomerDetails.Rows.Add();
                    dgvCustomerDetails.CurrentCell = dgvCustomerDetails[col, row];
                }
            }
            dgvCustomerDetails.CurrentRow.Cells["accountId"].Value = Convert.ToInt64(cmbWrongAccountName.SelectedValue);
            dgvCustomerDetails.CurrentRow.Cells["accountName"].Value = cmbWrongAccountName.Text.Trim();
        }
        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCustomer.Checked)
                {
                    rbDealer.Checked = false;
                 
                    DataTable dtaccountName = accountLedgerReportController.getAccountNamePaymentDue(1);
                    DataTable dtaccountName1 = accountLedgerReportController.getAccountNamePaymentDue(1);
                    Utility.BindComboBoxDataSelect(cmbAccountName, dtaccountName, "accountId", "accountName");
                    Utility.BindComboBoxDataSelect(cmbWrongAccountName, dtaccountName1, "accountId", "accountName");                                     
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
                 
                 
                    DataTable dtaccountName = accountLedgerReportController.getAccountNamePaymentDue(2);
                    DataTable dtaccountName1 = accountLedgerReportController.getAccountNamePaymentDue(2);
                    Utility.BindComboBoxDataSelect(cmbAccountName, dtaccountName, "accountId", "accountName");
                    Utility.BindComboBoxDataSelect(cmbWrongAccountName, dtaccountName1, "accountId", "accountName");
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void cmbWrongAccountName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbWrongAccountName.SelectedIndex>0)
                {
                    if(Convert.ToInt64(cmbAccountName.SelectedValue)==Convert.ToInt64(cmbWrongAccountName.SelectedValue))
                    {
                        cmbWrongAccountName.SelectedIndex = 0;
                        return;
                    }
                }
            }  
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {                
            DataTable dtCustomerAccount = new DataTable();                
            foreach (DataGridViewColumn col in dgvCustomerDetails.Columns)
            {
                dtCustomerAccount.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgvCustomerDetails.Rows)
            {
                DataRow dRow = dtCustomerAccount.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add all details in list");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये पूर्ण माहिती भरा");
                        }
                        return;
                    }
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dtCustomerAccount.Rows.Add(dRow);
            }     
            string isCustomerDealer="";
                if(rbCustomer.Checked)
                {
                    isCustomerDealer="Customer";
                }
                 if(rbDealer.Checked)
                {
                    isCustomerDealer="Dealer";
                }
                 int i = AccountTransferController.UpdateAccountTransfer(Convert.ToInt64(cmbAccountName.SelectedValue), isCustomerDealer, dtCustomerAccount);               
                 
                 if (Utility.Langn == "English")
                 {
                     MessageBox.Show("Record changed successfully");
                 }
                 else
                 {
                     MessageBox.Show("माहिती यशस्वीरीत्या बदलली गेली");
                 }
                 dgvCustomerDetails.Rows.Clear();
                 cmbAccountName.ResetText();
                 cmbWrongAccountName.ResetText();                    
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmbAccountName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAccountName.SelectedIndex > 0)
            {
                //bindWorngAccount(Convert.ToInt64(cmbAccountName.SelectedValue))
            }
        }
    }
}
