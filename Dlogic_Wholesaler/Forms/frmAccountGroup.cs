using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Dlogic_Wholesaler.Forms;
using DataAccessLayer.controller;
using DataAccessLayer.models;
using MetroFramework.Forms;

namespace Dlogic_Wholesaler.Forms
{
    public partial class frmAccountGroup : MetroForm
    {
        public frmAccountGroup()
        {
            InitializeComponent();
        }
        public static int accountGroupId = 0;
        public void BindComboBoxaccountType()
        {
            DataTable dtvillageId = accountGroupController.getaccountType();
            Utility.BindComboBoxDataSelect(cmbaccoutType, dtvillageId, "accountTypeId", "accountType");
        }
        public void getallAccountGroups()
        {
            try
            {
                //  grdCategory.Font = new Font("Tahoma", 11, FontStyle.Bold);
                dgvAccountGroup.DataSource = null;
                DataTable lstsubcategory = accountGroupController.getallAccountGroups();

                dgvAccountGroup.AutoGenerateColumns = false;
                dgvAccountGroup.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvAccountGroup.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvAccountGroup.Font = new Font("Tahoma", 11);

                dgvAccountGroup.EnableHeadersVisualStyles = false;

                dgvAccountGroup.ColumnCount = 4;
                if (Utility.Langn == "English")
                {
                    dgvAccountGroup.Columns[2].HeaderText = "Account Type";
                    dgvAccountGroup.Columns[3].HeaderText = "Account Group";
                }
                else
                {
                    dgvAccountGroup.Columns[2].HeaderText = "खाते  प्रकार";
                    dgvAccountGroup.Columns[3].HeaderText = "खाते गट";
                }

                dgvAccountGroup.Columns[0].Name = "accountGroupId";
                dgvAccountGroup.Columns[0].HeaderText = "accountGroupId";
                dgvAccountGroup.Columns[0].DataPropertyName = "accountGroupId";
                dgvAccountGroup.Columns[0].Visible = false;
               
                dgvAccountGroup.Columns[1].Name = "accountTypeId";
                dgvAccountGroup.Columns[1].HeaderText = "accountTypeId";
                dgvAccountGroup.Columns[1].DataPropertyName = "accountTypeId";
                dgvAccountGroup.Columns[1].Visible = false;
               
                dgvAccountGroup.Columns[2].Name = "accountType";               
                dgvAccountGroup.Columns[2].DataPropertyName = "accountType";
                dgvAccountGroup.Columns[2].Width = 300;
               
                dgvAccountGroup.Columns[3].Name = "accountGroup";
                dgvAccountGroup.Columns[3].DataPropertyName = "accountGroup";
                dgvAccountGroup.Columns[3].Width = 300;
                
                dgvAccountGroup.DataSource = lstsubcategory;


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
                    lblHerader.Text = "Account Group Details";
                    label1.Text = "Account Type:";
                    label2.Text = "Account Group:";
                    btnNew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    btnUpdate.Text = "Update";
                    btnDelete.Text = "Delete";
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmAccountGroup_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                Lang();
                BindComboBoxaccountType();
                getallAccountGroups();

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
                getallAccountGroups();
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
                else if (txtAccountGroup.Text == "")
                {
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Account Group...!");
                    }
                    else
                    {
                        MessageBox.Show("कृपया खाते गट निवडा ...!");
                    }
                    txtAccountGroup.Focus();
                    return;
                }
                else
                {
                    int i = accountGroupController.addAccountgroup(accountGroupId, Convert.ToInt32(cmbaccoutType.SelectedValue), txtAccountGroup.Text);
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
                        accountGroupId = 0;
                        Utility.ClearSpace(this);
                        Utility.enableFields(this);
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        BindComboBoxaccountType();
                        getallAccountGroups();

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAccountGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvAccountGroup.Rows[e.RowIndex];
                    if (row.Cells != null)
                    {
                        accountGroupId = Convert.ToInt32(row.Cells["accountGroupId"].Value);
                        cmbaccoutType.Text = row.Cells["accountType"].Value.ToString();
                        txtAccountGroup.Text = row.Cells["accountGroup"].Value.ToString();
                        Utility.enableFields(this);
                        btnSave.Enabled = false;
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAccountGroup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.N && e.Alt)
                {
                    btnNew_Click(sender, e);
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

        private void grpSubCategory_Enter(object sender, EventArgs e)
        {

        }
    }
}
