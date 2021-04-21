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
    public partial class frmCompany : MetroForm
    {
        public frmCompany()
        {
            InitializeComponent();
        }
        #region  Veriable
        public static int companyId = 0;
        #endregion
        #region --- Methods-----
        /// <summary>
        /// Get BindCustomerGrid Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public void BinDealerGrid()
        {
            try
            {

                dgvCompany.DataSource = null;
                DataTable lstgetCompanyDetails = categoryController.getCompanyDetails();

                dgvCompany.AutoGenerateColumns = false;
                dgvCompany.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvCompany.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvCompany.Font = new Font("Tahoma", 11);

                dgvCompany.EnableHeadersVisualStyles = false;

                dgvCompany.ColumnCount = 4;
                if (Utility.Langn == "English")
                {
                    dgvCompany.Columns[0].Name = "companyId";
                    dgvCompany.Columns[0].HeaderText = "companyId";
                    dgvCompany.Columns[0].DataPropertyName = "companyId";
                    dgvCompany.Columns[0].Visible = false;

                    dgvCompany.Columns[1].Name = "categoryId";
                    dgvCompany.Columns[1].HeaderText = "categoryId";
                    dgvCompany.Columns[1].DataPropertyName = "categoryId";
                    dgvCompany.Columns[1].Visible = false;

                    dgvCompany.Columns[2].Name = "categoryName";
                    dgvCompany.Columns[2].HeaderText = "Category Name";
                    dgvCompany.Columns[2].DataPropertyName = "categoryName";
                    dgvCompany.Columns[2].Width = 100;

                    dgvCompany.Columns[3].Name = "companyName";
                    dgvCompany.Columns[3].HeaderText = "Company Name";
                    dgvCompany.Columns[3].DataPropertyName = "companyName";
                    dgvCompany.Columns[3].Width = 200;
                }
                else
                {
                    dgvCompany.Columns[0].Name = "companyId";
                    dgvCompany.Columns[0].HeaderText = "companyId";
                    dgvCompany.Columns[0].DataPropertyName = "companyId";
                    dgvCompany.Columns[0].Visible = false;

                    dgvCompany.Columns[1].Name = "categoryId";
                    dgvCompany.Columns[1].HeaderText = "categoryId";
                    dgvCompany.Columns[1].DataPropertyName = "categoryId";
                    dgvCompany.Columns[1].Visible = false;

                    dgvCompany.Columns[2].Name = "categoryName";
                    dgvCompany.Columns[2].HeaderText = "प्रकारचे नाव";
                    dgvCompany.Columns[2].DataPropertyName = "categoryName";
                    dgvCompany.Columns[2].Width = 100;

                    dgvCompany.Columns[3].Name = "companyName";
                    dgvCompany.Columns[3].HeaderText = "कंपनीचे नाव";
                    dgvCompany.Columns[3].DataPropertyName = "companyName";
                    dgvCompany.Columns[3].Width = 200;
                }

                dgvCompany.DataSource = lstgetCompanyDetails;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// bind Gender
        /// </summary>
        public void BindComboBoxgetCategory()
        {

            DataTable dtgenderId = categoryController.getCategory();
            Utility.BindComboBoxDataSelect(cmbCategory, dtgenderId, "categoryId", "categoryName");
        }
        /// <summary>
        /// Bind Village
        /// </summary>

        #endregion

        #region --Lang--

        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Company Details";
                    label1.Text = "Company Details";
                    metroLabel1.Text = "Category Name:";
                    metroLabel3.Text = "Company Name:";                  
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    btnUpdate.Text = "Update";                  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void frmCompany_Load(object sender, EventArgs e)
        {
            try
            {   
                this.Location = new Point(3, 3);
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                Lang();
                BindComboBoxgetCategory();
                BinDealerGrid();
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
                btnUpdate.Enabled = false;
                companyId = 0;
                BindComboBoxgetCategory();
                BinDealerGrid();

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
              
                if (cmbCategory.SelectedIndex == 0)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Category ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया प्रकार निवडा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cmbCategory.Focus();
                    return;
                }
                if (txtSubCategory.Text == string.Empty)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Add Company Name..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया कंपनी चे नाव भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtSubCategory.Focus();
                    return;
                }
                int categoryId = 0;
                string categoryName = cmbCategory.Text;
                 int companyIds = companyId;
                 if (cmbCategory.SelectedValue == null)
                 {
                     int s = categoryController.addCategoryDetails(0, cmbCategory.Text);
                     BindComboBoxgetCategory();
                     cmbCategory.Text = categoryName;
                     categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                 }
                 else
                 {
                     categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                 }
             //   int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                string companyName = txtSubCategory.Text;


                if (companyIds > 0)
                {
                    DialogResult ShowReport = DialogResult.No;
                    if (Utility.Langn == "English")
                    {
                       ShowReport= MessageBox.Show("Do you Want to update this Record ....?", "", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                     ShowReport=  MessageBox.Show("माहिती अपडेट करायची का ....?", "", MessageBoxButtons.YesNo);
                    }
                    if (ShowReport == DialogResult.Yes)
                    {
                        int i = categoryController.addCompanyDeatials(categoryId, companyIds, companyName,Utility.LoginID);
                        if (i > 0)
                        {                           
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Record Saved Successfully ..");
                            }
                            else
                            {
                                MessageBox.Show("रेकॉर्ड  यशस्वीरित्या भरले ..");
                            }
                            Utility.ClearSpace(this);
                            Utility.enableFields(this);
                            btnUpdate.Enabled = false;
                            BindComboBoxgetCategory();
                            companyId = 0;
                            BinDealerGrid();
                        }
                        if (i < 0)
                        {
                           
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Category & Company Name Already Exists ..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("प्रकार आणि कंपनी चे नाव आधीच उपलब्ध आहेत ..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                    }
                    else
                    {
                        ShowReport = DialogResult.No;
                        Utility.ClearSpace(this);
                        Utility.enableFields(this);
                        btnUpdate.Enabled = false;
                        BindComboBoxgetCategory();
                        companyId = 0;
                        BinDealerGrid();
                    }
                }
                else
                {
                    int i = categoryController.addCompanyDeatials(categoryId, companyIds, companyName, Utility.LoginID);
                    if (i > 0)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Record Saved Successfully ..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("माहिती यशस्वीरित्या साठवली गेली ..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Utility.ClearSpace(this);
                        Utility.enableFields(this);
                        btnUpdate.Enabled = false;
                        BindComboBoxgetCategory();
                        companyId = 0;
                        BinDealerGrid();


                        //   cmbOrgnation.SelectedIndex = 0;
                    }
                    if (i < 0)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Company Name already Exists..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("कंपनी चे नाव आधीच उपलब्ध आहे ..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvCompany.Rows[e.RowIndex];
                    if (row.Cells != null)
                    {
                        companyId = Convert.ToInt32(row.Cells["companyId"].Value);
                        cmbCategory.Text = row.Cells["categoryName"].Value.ToString();
                        txtSubCategory.Text = row.Cells["companyName"].Value.ToString();
                      
                     
                        Utility.enableFields(this);
                        btnUpdate.Enabled = true;
                        btnSave.Enabled = false;
                        cmbCategory.Enabled = false;

                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                try
                {
                  
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
