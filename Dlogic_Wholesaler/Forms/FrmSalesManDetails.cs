using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Fonts;
using DataAccessLayer.controller;
using DataAccessLayer.models;


namespace Dlogic_Wholesaler.Forms
{
    public partial class FrmSalesManDetails : MetroForm
    {
        public FrmSalesManDetails()
        {
            InitializeComponent();
        }
        #region  Veriable
        public static long salesmanId = 0;
        #endregion
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Salesman Details";
                    label9.Text = "Salesman Details";
                    label2.Text = "Salesman Name:";
                    label8.Text = "DOB:";
                    label13.Text = "Gender:";
                    label7.Text = "Mobile No:";
                    label6.Text = "Email ID:";
                    label1.Text = "Address:";
                   btnnew.Text = "New(Alt+N)";
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
        private void SalesManDetails_Load(object sender, EventArgs e)
        {
            Lang();
          }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                BindSalesmanGrid();
                BindComboBoxgetGender();
                salesmanId = 0;
                txtSalesmanName.Focus();
                cmbGender.SelectedIndex = 1;             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindComboBoxgetGender()
        {

            DataTable dtgenderId = customerController.getGender();
            Utility.BindComboBoxDataSelect(cmbGender, dtgenderId, "genderId", "Gender");
        }
        public void BindSalesmanGrid()
        {
            try
            {
                grdSalesmanDetails.DataSource = null;
                DataTable lstsalesmanDetails = SalesManDetailsController.getSalesmanDetails();
                grdSalesmanDetails.AutoGenerateColumns = false;
                grdSalesmanDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                grdSalesmanDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                grdSalesmanDetails.Font = new Font("Tahoma", 11);

                grdSalesmanDetails.EnableHeadersVisualStyles = false;

                grdSalesmanDetails.ColumnCount = 7;
                if (Utility.Langn == "English")
                {
                    grdSalesmanDetails.Columns[0].Name = "SalesmanId";
                    grdSalesmanDetails.Columns[0].HeaderText = "SalesmanId";
                    grdSalesmanDetails.Columns[0].DataPropertyName = "SalesmanId";
                    grdSalesmanDetails.Columns[0].Visible = false;

                    grdSalesmanDetails.Columns[1].Name = "SalesmanName";
                    grdSalesmanDetails.Columns[1].HeaderText = "Salesman Name";
                    grdSalesmanDetails.Columns[1].DataPropertyName = "SalesmanName";

                    grdSalesmanDetails.Columns[2].Name = "Address";
                    grdSalesmanDetails.Columns[2].HeaderText = "Address";
                    grdSalesmanDetails.Columns[2].DataPropertyName = "Address";

                    grdSalesmanDetails.Columns[3].Name = "MobileNo";
                    grdSalesmanDetails.Columns[3].HeaderText = "MobileNo";
                    grdSalesmanDetails.Columns[3].DataPropertyName = "MobileNo";

                    grdSalesmanDetails.Columns[4].Name = "GenderId";
                    grdSalesmanDetails.Columns[4].HeaderText = "Gender";
                    grdSalesmanDetails.Columns[4].DataPropertyName = "GenderId";

                    grdSalesmanDetails.Columns[5].Name = "DOB";
                    grdSalesmanDetails.Columns[5].HeaderText = "DOB";
                    grdSalesmanDetails.Columns[5].DataPropertyName = "DOB";
                    grdSalesmanDetails.Columns[5].DefaultCellStyle.Format = "dd-MM-yyyy";

                    grdSalesmanDetails.Columns[6].Name = "EmailId";
                    grdSalesmanDetails.Columns[6].HeaderText = "EmailId";
                    grdSalesmanDetails.Columns[6].DataPropertyName = "EmailId";
                }
                else
                {
                    grdSalesmanDetails.Columns[0].Name = "SalesmanId";
                    grdSalesmanDetails.Columns[0].HeaderText = "SalesmanId";
                    grdSalesmanDetails.Columns[0].DataPropertyName = "SalesmanId";
                    grdSalesmanDetails.Columns[0].Visible = false;

                    grdSalesmanDetails.Columns[1].Name = "SalesmanName";
                    grdSalesmanDetails.Columns[1].HeaderText = "ग्राहकाचे नाव";
                    grdSalesmanDetails.Columns[1].DataPropertyName = "SalesmanName";

                    grdSalesmanDetails.Columns[2].Name = "Address";
                    grdSalesmanDetails.Columns[2].HeaderText = "पत्ता";
                    grdSalesmanDetails.Columns[2].DataPropertyName = "Address";

                    grdSalesmanDetails.Columns[3].Name = "customerMobileNo";
                    grdSalesmanDetails.Columns[3].HeaderText = "मोबाईल क्र.";
                    grdSalesmanDetails.Columns[3].DataPropertyName = "customerMobileNo";

                    grdSalesmanDetails.Columns[4].Name = "GenderId";
                    grdSalesmanDetails.Columns[4].HeaderText = "लिंग";
                    grdSalesmanDetails.Columns[4].DataPropertyName = "GenderId";

                    grdSalesmanDetails.Columns[5].Name = "DOB";
                    grdSalesmanDetails.Columns[5].HeaderText = "जन्मदिनांक";
                    grdSalesmanDetails.Columns[5].DataPropertyName = "DOB";
                    grdSalesmanDetails.Columns[5].DefaultCellStyle.Format = "dd-MM-yyyy";

                    grdSalesmanDetails.Columns[6].Name = "EmailId";
                    grdSalesmanDetails.Columns[6].HeaderText = "ई-मेल";
                    grdSalesmanDetails.Columns[6].DataPropertyName = "EmailId";                           
                }
                grdSalesmanDetails.DataSource = lstsalesmanDetails;

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
                SalesmanDetails sales = new SalesmanDetails();
                if (txtSalesmanName.Text == string.Empty)
                {
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Add Salesman name ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया सेल्समन नाव भरा ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtSalesmanName.Focus();
                    return;
                }
                sales.SalesmanId = salesmanId;
                sales.SalesmanName = txtSalesmanName.Text.Trim();
                sales.Address = txtAdd1.Text.Trim();
                if (txtMobileNo.Text == string.Empty)
                {
                    sales.MobileNo = "";
                }
                else
                {
                    sales.MobileNo = Utility.ParseValueI(txtMobileNo.Text).ToString();
                }

                sales.DOB = dtpDOB.Value;
                sales.GenderId = cmbGender.Text;
                sales.EmailId = txtEmailID.Text.Trim();
                sales.addedOn = Utility.firstDate;
                sales.addedBy = Utility.LoginID;
                sales.isDelete = 0;
               if(sales.SalesmanId > 0)
                {
                    DialogResult ShowReport = DialogResult.No;
                    if (Utility.Langn == "English")
                    {
                        ShowReport = MessageBox.Show("Do you want to update....?", "", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        ShowReport = MessageBox.Show("तु्म्हाला अपडेट करायचं का ....?", "", MessageBoxButtons.YesNo);
                    }
                    if (ShowReport == DialogResult.Yes)
                    {
                        int i = SalesManDetailsController.addSalesmanDetails(sales);
                        if (i > 0)
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Information updated successfully ..!", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("माहिती यशस्वीरित्या अपडेट केली गेली ..!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            btnnew_Click(sender, e);
                        }
                        if (i < 0)
                        {

                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Customer Name already exists in list..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("सेल्समनचे नाव आधीच उपलब्ध आहे ..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                    }
                    else
                    {
                        ShowReport = DialogResult.No;

                        btnnew_Click(sender, e);

                    }
                }
                else
                {
                    int i = SalesManDetailsController.addSalesmanDetails(sales);
                    if (i > 0)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Information saved successfully ..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("माहिती यशस्वीरित्या साठवली गेली ..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        btnnew_Click(sender, e);
                    }
                    if (i < 0)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Customer Name already exists in list..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("सेल्समनचे नाव आधीच उपलब्ध आहे ..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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
            try
            {
                if (salesmanId == 0)
                {
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Salesman from list..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया लिस्ट मधून सेल्समन निवडा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    return;
                }
                SalesmanDetails sales = new SalesmanDetails();
                sales.SalesmanId = salesmanId;
                sales.SalesmanName = txtSalesmanName.Text.Trim();
                sales.Address = txtAdd1.Text.Trim();
                if (txtMobileNo.Text == string.Empty)
                {
                    sales.MobileNo = "";
                }
                else
                {
                    sales.MobileNo = Utility.ParseValueI(txtMobileNo.Text).ToString();
                }

                sales.DOB = dtpDOB.Value;
                sales.GenderId = cmbGender.Text;
                sales.EmailId = txtEmailID.Text.Trim();
                sales.addedOn = Utility.firstDate;
                sales.addedBy = Utility.LoginID;
                sales.isDelete = 1;
                DialogResult ShowReport = DialogResult.No;
                if (Utility.Langn == "English")
                {
                    ShowReport = MessageBox.Show("Do you want to delete this Record..?", "Delete", MessageBoxButtons.YesNo);
                }
                else
                {
                    ShowReport = MessageBox.Show("माहिती डिलीट करायची का ..?", "डिलीट", MessageBoxButtons.YesNo);
                }
                if (ShowReport == DialogResult.Yes)
                {
                    int i = SalesManDetailsController.addSalesmanDetails(sales);
                    if (i > 0)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Deleted Record Successfully ..!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("माहिती डिलीट झाली ..!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        btnnew_Click(sender, e);
                    }
                    else
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please You can't delete this salesman " , "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("कृपया हा सेल्समन डिलीट करता येत नाही " ,"Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return;
                    }
                }
                else
                {
                    ShowReport = DialogResult.No;
                   
                    btnnew_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdSalesmanDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.grdSalesmanDetails.Rows[e.RowIndex];

                    if (row.Cells != null)
                    {
                        salesmanId = Convert.ToInt32(row.Cells["SalesmanId"].Value);
                        txtSalesmanName.Text = row.Cells["SalesmanName"].Value.ToString();
                        txtAdd1.Text = row.Cells["Address"].Value.ToString();                       
                        dtpDOB.Text = row.Cells["DOB"].Value.ToString();
                        cmbGender.SelectedText = row.Cells["GenderId"].Value.ToString();
                        txtMobileNo.Text = row.Cells["MobileNo"].Value.ToString();
                        txtEmailID.Text = row.Cells["EmailId"].Value.ToString();
                        cmbGender.Text = row.Cells["GenderId"].Value.ToString();                      
                        Utility.enableFields(this);
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnSave.Enabled = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
