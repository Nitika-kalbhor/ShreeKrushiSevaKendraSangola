using DataAccessLayer.controller;
using DataAccessLayer.models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dlogic_Wholesaler.Forms
{
    public partial class frmAccountSubGroup : MetroForm
    {
        public frmAccountSubGroup()
        {
            InitializeComponent();
        }
        public long accountSubGrpId = 0;
        public bool isUpDate = false;
        public bool isDelete = false;
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
                }
            }
            catch(Exception ae)
            {
                MessageBox.Show("Error!", ae.ToString());
            }
        }
        public void BindComboBoxaccountType()
        {
            DataTable dtvillageId = accountGroupController.getaccountType();
            Utility.BindComboBoxDataSelect(cmbaccoutType, dtvillageId, "accountTypeId", "accountType");
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Account Sub-Group";
                    label1.Text = "Account Type:";
                    label3.Text = "Account Group:";
                    label2.Text = "Account Group SubGroup:";
                    btnNew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    btnUpdate.Text = "Update";
                    btnDelete.Text = "Delete";
                    dgvAccountGroup.Columns[2].HeaderText = "Account Group SubGroup";
                    dgvAccountGroup.Columns[3].HeaderText = "Account Group Type";
                    dgvAccountGroup.Columns[4].HeaderText = "Account Group";
                   

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmAccountSubGroup_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                BindComboBoxaccountType();
                 getallAccountGroups();
                 Lang();

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
                if(cmbaccoutType.SelectedIndex==0)
                {
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Account Group...!");
                    }
                    else
                    {
                        MessageBox.Show("कृपया खाते गट निवडा ...!");
                    }
                    cmbaccoutType.Focus();
                    return;
                }
                if (cmbAccountGroup.SelectedIndex == 0)
                {                    
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Account Group Type...!");
                    }
                    else
                    {
                        MessageBox.Show("कृपया खाते गट प्रकार निवडा");
                    }
                    cmbAccountGroup.Focus();
                    return;
                }
                if (txtAccountGroup.Text==string.Empty)
                {
                  
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Account Group SubGroup...!");
                    }
                    else
                    {
                        MessageBox.Show("कृपया खाते गट प्रकार भरा");
                    }
                    txtAccountGroup.Focus();
                    return;
                }
                AccountSubGroup accountSubGroup = new AccountSubGroup();
                accountSubGroup.accountSubGroupId = accountSubGrpId;
                accountSubGroup.accountGroupId = Convert.ToInt64(cmbAccountGroup.SelectedValue);
                accountSubGroup.accountSubGroupName = txtAccountGroup.Text.Trim();
                accountSubGroup.isDelete = isDelete;
                accountSubGroup.isUpDate = isUpDate;
                int i = accountGroupController.addAccountSubGroup(accountSubGroup);
                if(i>0)
                {
                    if (isDelete == false && isUpDate == false)
                    {
                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Record Saved Successfully ...!");
                        }
                        else
                        {
                            MessageBox.Show("सदर नोंद यशस्वीरीत्या साठवली गेली आहे.");
                        }
                    }
                    if (isDelete == false && isUpDate == true)
                    {                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Record Updated Successfully ...!");
                        }
                        else
                        {
                            MessageBox.Show("सदर नोंद यशस्वीरीत्या अपडेट केली गेली आहे.");
                        }
                    }
                    if (isDelete == true && isUpDate == false)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Record Deleted Successfully ...!");
                        }
                        else
                        {
                            MessageBox.Show("सदर नोंद यशस्वीरीत्या डिलीट केली गेली आहे.");
                        }
                    }
                    btnNew_Click(sender,e);
                }
                if(i==-1)
                {
                    if (isDelete != false)
                    {                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Record alredy exists ...!");
                        }
                        else
                        {
                            MessageBox.Show("सदर नोंद उपलब्ध आहे.");
                        }
                    }
                }
            }
            catch(Exception ae)
            {
                MessageBox.Show("Error"+ae.ToString());
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
                isUpDate = false;
                isDelete = false;
                accountSubGrpId = 0;
                BindComboBoxaccountType();
               getallAccountGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getallAccountGroups()
        {
            try
            {
                DataTable dt = accountGroupController.getAccountSubGroupDetails(0);
                dgvAccountGroup.DataSource = dt;
            }
            catch(Exception ae)
            {
                MessageBox.Show("Error"+ae.ToString());
            }
        }

        private void dgvAccountGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row=this.dgvAccountGroup.Rows[e.RowIndex];
                if(row.Cells!=null)
                {
                    accountSubGrpId = Convert.ToInt64(row.Cells["accountSubGroupId"].Value.ToString());
                    cmbaccoutType.Text = row.Cells["accountType"].Value.ToString();
                    cmbAccountGroup.Text = row.Cells["accountGroup"].Value.ToString();
                    txtAccountGroup.Text = row.Cells["accountSubGroupName"].Value.ToString();
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
               isUpDate = true;
               isDelete = false;
               btnSave.Enabled = false;
               btnSave_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            isUpDate = false;
            isDelete = true;
            btnSave.Enabled = false;
            btnSave_Click(sender, e);
        }

        private void frmAccountSubGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Alt)
            {
                btnNew_Click(sender, e);
            }
            if (e.KeyCode == Keys.S && e.Alt)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
