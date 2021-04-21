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
    public partial class frmCustomerDetails : MetroForm
    {
        public frmCustomerDetails()
        {
            InitializeComponent();
        }
        #region  Veriable
        public static long customerId = 0;
        #endregion
        #region --- Methods-----
        /// <summary>
        /// Get BindCustomerGrid Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public void BindCustomerGrid()
        {
            try
            {
                grdCustomerDetails.DataSource = null;
                DataTable lstcustomerDetails = customerController.getCustomerDetails();
                grdCustomerDetails.AutoGenerateColumns = false;
                grdCustomerDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                grdCustomerDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                grdCustomerDetails.Font = new Font("Tahoma", 11);

                grdCustomerDetails.EnableHeadersVisualStyles = false;

                grdCustomerDetails.ColumnCount = 22;
                if (Utility.Langn == "English")
                {
                    grdCustomerDetails.Columns[0].Name = "customerId";
                    grdCustomerDetails.Columns[0].HeaderText = "customerId";
                    grdCustomerDetails.Columns[0].DataPropertyName = "customerId";
                    grdCustomerDetails.Columns[0].Visible = false;

                    grdCustomerDetails.Columns[1].Name = "customerName";
                    grdCustomerDetails.Columns[1].HeaderText = "Customer Name";
                    grdCustomerDetails.Columns[1].DataPropertyName = "customerName";


                    grdCustomerDetails.Columns[2].Name = "isCustomerRetailer";
                    grdCustomerDetails.Columns[2].HeaderText = "Customer/Retailer";
                    grdCustomerDetails.Columns[2].DataPropertyName = "isCustomerRetailer";

                    grdCustomerDetails.Columns[3].Name = "villageName";
                    grdCustomerDetails.Columns[3].HeaderText = "Village";
                    grdCustomerDetails.Columns[3].DataPropertyName = "villageName";

                    grdCustomerDetails.Columns[4].Name = "customerAddress";
                    grdCustomerDetails.Columns[4].HeaderText = "Address";
                    grdCustomerDetails.Columns[4].DataPropertyName = "customerAddress";

                    grdCustomerDetails.Columns[5].Name = "customerMobileNo";
                    grdCustomerDetails.Columns[5].HeaderText = "Mobile No";
                    grdCustomerDetails.Columns[5].DataPropertyName = "customerMobileNo";

                    grdCustomerDetails.Columns[6].Name = "MobileTwo";
                    grdCustomerDetails.Columns[6].HeaderText = "Mobile No.2";
                    grdCustomerDetails.Columns[6].DataPropertyName = "MobileTwo";

                    grdCustomerDetails.Columns[7].Name = "MobileThree";
                    grdCustomerDetails.Columns[7].HeaderText = "Mobile No.3";
                    grdCustomerDetails.Columns[7].DataPropertyName = "MobileThree";

                    grdCustomerDetails.Columns[8].Name = "genderId";
                    grdCustomerDetails.Columns[8].HeaderText = "Gender";
                    grdCustomerDetails.Columns[8].DataPropertyName = "genderId";

                    grdCustomerDetails.Columns[9].Name = "DOB";
                    grdCustomerDetails.Columns[9].HeaderText = "DOB";
                    grdCustomerDetails.Columns[9].DataPropertyName = "DOB";
                    grdCustomerDetails.Columns[9].DefaultCellStyle.Format = "dd-MM-yyyy";

                    grdCustomerDetails.Columns[10].Name = "emailId";
                    grdCustomerDetails.Columns[10].HeaderText = "EmailId";
                    grdCustomerDetails.Columns[10].DataPropertyName = "emailId";

                    grdCustomerDetails.Columns[11].Name = "CustomerGSTNo";
                    grdCustomerDetails.Columns[11].HeaderText = "GST No";
                    grdCustomerDetails.Columns[11].DataPropertyName = "CustomerGSTNo";

                    grdCustomerDetails.Columns[12].Name = "adharNo";
                    grdCustomerDetails.Columns[12].HeaderText = "AdharCard No";
                    grdCustomerDetails.Columns[12].DataPropertyName = "adharNo";

                    grdCustomerDetails.Columns[13].Name = "Pan_No";
                    grdCustomerDetails.Columns[13].HeaderText = "PANCard No";
                    grdCustomerDetails.Columns[13].DataPropertyName = "Pan_No";

                    grdCustomerDetails.Columns[14].Name = "contactPerson";
                    grdCustomerDetails.Columns[14].HeaderText = "Contact Person ";
                    grdCustomerDetails.Columns[14].DataPropertyName = "contactPerson";

                    grdCustomerDetails.Columns[15].Name = "openigBalanace";
                    grdCustomerDetails.Columns[15].HeaderText = "Openig Balanace";
                    grdCustomerDetails.Columns[15].DataPropertyName = "openigBalanace";

                    grdCustomerDetails.Columns[16].Name = "isCreditDebit";
                    grdCustomerDetails.Columns[16].HeaderText = "Credit/Debit";
                    grdCustomerDetails.Columns[16].DataPropertyName = "isCreditDebit";

                    grdCustomerDetails.Columns[17].Name = "contactNo";
                    grdCustomerDetails.Columns[17].HeaderText = "Contact Person No";
                    grdCustomerDetails.Columns[17].DataPropertyName = "contactNo";

                    grdCustomerDetails.Columns[18].Name = "OtherNote";
                    grdCustomerDetails.Columns[18].HeaderText = "Naration";
                    grdCustomerDetails.Columns[18].DataPropertyName = "OtherNote";

                    grdCustomerDetails.Columns[19].Name = "discount";
                    grdCustomerDetails.Columns[19].HeaderText = "Discount (%)";
                    grdCustomerDetails.Columns[19].DataPropertyName = "discount";

                    grdCustomerDetails.Columns[20].Name = "limitationAmount";
                    grdCustomerDetails.Columns[20].HeaderText = "limitation Amt";
                    grdCustomerDetails.Columns[20].DataPropertyName = "limitationAmount";

                    grdCustomerDetails.Columns[21].Name = "SalesmanName";
                    grdCustomerDetails.Columns[21].HeaderText = "Salesman Name";
                    grdCustomerDetails.Columns[21].DataPropertyName = "SalesmanName";
                }
                else
                {
                    grdCustomerDetails.Columns[0].Name = "customerId";
                    grdCustomerDetails.Columns[0].HeaderText = "customerId";
                    grdCustomerDetails.Columns[0].DataPropertyName = "customerId";
                    grdCustomerDetails.Columns[0].Visible = false;

                    grdCustomerDetails.Columns[1].Name = "customerName";
                    grdCustomerDetails.Columns[1].HeaderText = "ग्राहकाचे नाव";
                    grdCustomerDetails.Columns[1].DataPropertyName = "customerName";


                    grdCustomerDetails.Columns[2].Name = "isCustomerRetailer";
                    grdCustomerDetails.Columns[2].HeaderText = "ग्राहक/किरकोळ विक्रेता";
                    grdCustomerDetails.Columns[2].DataPropertyName = "isCustomerRetailer";

                    grdCustomerDetails.Columns[3].Name = "villageName";
                    grdCustomerDetails.Columns[3].HeaderText = "गाव";
                    grdCustomerDetails.Columns[3].DataPropertyName = "villageName";

                    grdCustomerDetails.Columns[4].Name = "customerAddress";
                    grdCustomerDetails.Columns[4].HeaderText = "पत्ता";
                    grdCustomerDetails.Columns[4].DataPropertyName = "customerAddress";

                    grdCustomerDetails.Columns[5].Name = "customerMobileNo";
                    grdCustomerDetails.Columns[5].HeaderText = "मोबाईल क्र.";
                    grdCustomerDetails.Columns[5].DataPropertyName = "customerMobileNo";

                    grdCustomerDetails.Columns[6].Name = "MobileTwo";
                    grdCustomerDetails.Columns[6].HeaderText = "मोबाईल क्र.2";
                    grdCustomerDetails.Columns[6].DataPropertyName = "MobileTwo";

                    grdCustomerDetails.Columns[7].Name = "MobileThree";
                    grdCustomerDetails.Columns[7].HeaderText = "मोबाईल क्र.3";
                    grdCustomerDetails.Columns[7].DataPropertyName = "MobileThree";

                    grdCustomerDetails.Columns[8].Name = "genderId";
                    grdCustomerDetails.Columns[8].HeaderText = "लिंग";
                    grdCustomerDetails.Columns[8].DataPropertyName = "genderId";

                    grdCustomerDetails.Columns[9].Name = "DOB";
                    grdCustomerDetails.Columns[9].HeaderText = "जन्मदिनांक";
                    grdCustomerDetails.Columns[9].DataPropertyName = "DOB";
                    grdCustomerDetails.Columns[9].DefaultCellStyle.Format = "dd-MM-yyyy";

                    grdCustomerDetails.Columns[10].Name = "emailId";
                    grdCustomerDetails.Columns[10].HeaderText = "ई-मेल";
                    grdCustomerDetails.Columns[10].DataPropertyName = "emailId";

                    grdCustomerDetails.Columns[11].Name = "CustomerGSTNo";
                    grdCustomerDetails.Columns[11].HeaderText = "GST No";
                    grdCustomerDetails.Columns[11].DataPropertyName = "CustomerGSTNo";

                    grdCustomerDetails.Columns[12].Name = "adharNo";
                    grdCustomerDetails.Columns[12].HeaderText = "आधार क्र";
                    grdCustomerDetails.Columns[12].DataPropertyName = "adharNo";

                    grdCustomerDetails.Columns[13].Name = "Pan_No";
                    grdCustomerDetails.Columns[13].HeaderText = "PANCard No";
                    grdCustomerDetails.Columns[13].DataPropertyName = "Pan_No";

                    grdCustomerDetails.Columns[14].Name = "contactPerson";
                    grdCustomerDetails.Columns[14].HeaderText = "संपर्क व्यक्ती";
                    grdCustomerDetails.Columns[14].DataPropertyName = "contactPerson";

                    grdCustomerDetails.Columns[15].Name = "openigBalanace";
                    grdCustomerDetails.Columns[15].HeaderText = "आरंभी शिल्लक";
                    grdCustomerDetails.Columns[15].DataPropertyName = "openigBalanace";

                    grdCustomerDetails.Columns[16].Name = "isCreditDebit";
                    grdCustomerDetails.Columns[16].HeaderText = "नावे/जमा";
                    grdCustomerDetails.Columns[16].DataPropertyName = "isCreditDebit";

                    grdCustomerDetails.Columns[17].Name = "contactNo";
                    grdCustomerDetails.Columns[17].HeaderText = "संपर्क मोबाईल नं.";
                    grdCustomerDetails.Columns[17].DataPropertyName = "contactNo";

                    grdCustomerDetails.Columns[18].Name = "OtherNote";
                    grdCustomerDetails.Columns[18].HeaderText = "तपशील";
                    grdCustomerDetails.Columns[18].DataPropertyName = "OtherNote";

                    grdCustomerDetails.Columns[19].Name = "discount";
                    grdCustomerDetails.Columns[19].HeaderText = "सवलत (%)";
                    grdCustomerDetails.Columns[19].DataPropertyName = "discount";

                    grdCustomerDetails.Columns[20].Name = "limitationAmount";
                    grdCustomerDetails.Columns[20].HeaderText = "रक्कम मर्यादा";
                    grdCustomerDetails.Columns[20].DataPropertyName = "limitationAmount";

                    grdCustomerDetails.Columns[21].Name = "SalesmanName";
                    grdCustomerDetails.Columns[21].HeaderText = "सेल्समनचे नाव";
                    grdCustomerDetails.Columns[21].DataPropertyName = "SalesmanName";
                }


                grdCustomerDetails.DataSource = lstcustomerDetails;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// bind Gender
        /// </summary>
        public void BindComboBoxgetGender()
        {

            DataTable dtgenderId = customerController.getGender();
            Utility.BindComboBoxDataSelect(cmbGender, dtgenderId, "genderId", "Gender");
        }
        /// <summary>
        /// Bind Village
        /// </summary>
        public void BindComboBoxVillageDetails()
        {

            DataTable dtvillageId = customerController.getVillageDetails();
            Utility.BindComboBoxEmptyDataSelect(cmbVillage, dtvillageId, "villageId", "villageName");
        }

        #endregion

        #region --Lang--

        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                     lblHerader.Text = "Customer Details";
                    label9.Text = "Customer Details";
                    label2.Text = "Customer Name:";
                    lblsalesman.Text = "Salesman Name:";
                    label8.Text = "DOB:";
                    label13.Text = "Gender:";
                    label7.Text = "Mobile No:";
                    label18.Text = "Mobile No2:";
                    label19.Text = "Mobile No3:";
                    label6.Text = "Email ID:";
                    label16.Text = "GST No:";
                    label11.Text = "Village:";
                    label1.Text = "Address:";
                    label20.Text = "Aadhar No:";
                    label4.Text = "Opening Qty:";
                    label5.Text = "Date:";
                    label12.Text = "Naration:";
                    label14.Text = "Contact Person:";
                    label15.Text = "Contact Person No:";
                    lblDiscount.Text = "Discount:";
                    lbllimitationAmount.Text = "Limitation Amount:";
                    label17.Text = "Customer/Retailer:";
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    btnUpdate.Text = "Update";
                    btnDelete.Text = "Delete";
                    label3.Text = "Customer Name:";
                    label10.Text = "Mobile No:";
                    btneExcelReport.Text = "Exel Report";                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(3, 3);
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                Lang();
                BindCustomerGrid();
                txtSeachName.Enabled = true;
                txtSearchMob.Enabled = true;
                BindComboBoxgetGender();
                BindComboBoxVillageDetails();            
                cmbCreditDebit.SelectedIndex = 0;
                cmbCustomerRetailer.SelectedIndex = 0;
                BindComboBoxgetSalesmanName();
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
                btnDelete.Enabled = false;
                BindCustomerGrid();
                BindComboBoxgetGender();
                BindComboBoxVillageDetails();
                cmbCreditDebit.SelectedIndex = 0;
                customerId = 0;
                txtCustomerName.Focus();
                cmbGender.SelectedIndex = 1;
                cmbCustomerRetailer.SelectedIndex = 0;
                BindComboBoxgetSalesmanName();
               
                //     cmbOrgnation.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindComboBoxgetSalesmanName()
        {
            DataTable dt = SalesManDetailsController.getSalesmanDetails();
           Utility.BindComboBoxEmptyDataSelect(cmbSalesmanName, dt, "SalesmanId", "SalesmanName");
        }

        private void frmCustomerDetails_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                customerDetails customers = new customerDetails();             
                if (txtCustomerName.Text == string.Empty)
                {                  
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Add Customer name ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया ग्राहकाचे नाव भरा ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtCustomerName.Focus();
                    return;
                }
                if (cmbVillage.SelectedIndex == 0)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show(" Please add or select village name ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(" कृपया गावाचे नाव भरा किंवा निवडा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cmbVillage.Focus();
                    return;
                }          
                if(cmbCustomerRetailer.Text == "")
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Customer /Retailer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया ग्राहक/ कीरकोळ विक्रेता निवडा !", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cmbCustomerRetailer.Focus();
                    return;
                }

                if (txtOpeningBalance.Text == string.Empty)
                {
                    txtOpeningBalance.Text = "0";
                }
               
                customers.customerId = customerId;
                customers.customerName = txtCustomerName.Text.Trim();
                customers.SalesmanId = Convert.ToInt64(cmbSalesmanName.SelectedValue);
                customers.CustomerGSTNo = txtGSTNo.Text.Trim();
                customers.CustomerPANNo = txtpancardno.Text.Trim();
                customers.isCustomerRetailer = cmbCustomerRetailer.SelectedItem.ToString();
                customers.customerAddress = txtAdd1.Text.Trim();
                if (txtMobileNo.Text == string.Empty)
                {
                    customers.customerMobileNo = "";
                }
                else
                {
                    customers.customerMobileNo = Utility.ParseValueI(txtMobileNo.Text).ToString();
                }

                if (txtMobileTwo.Text == string.Empty)
                {
                    customers.MobileTwo = "";
                }
                else
                {
                    customers.MobileTwo = Utility.ParseValueI(txtMobileTwo.Text).ToString();
                }

                if (txtMobileThree.Text == string.Empty)
                {
                    customers.MobileThree = "";
                }
                else
                {
                    customers.MobileThree = Utility.ParseValueI(txtMobileThree.Text).ToString();
                }


                customers.DOB = dtpDOB.Value;
                customers.genderId = cmbGender.Text;
                string vi = cmbVillage.Text;
                if (cmbVillage.SelectedValue == null)
                {
                    int i = villageDetailsController.addVillageDetails(0, cmbVillage.Text);
                    BindComboBoxVillageDetails();
                    cmbVillage.Text = vi;
                }
               
                    customers.villageId = Convert.ToInt32(cmbVillage.SelectedValue);
               
                customers.emailId = txtEmailID.Text.Trim();
                customers.OtherNote = txtOtherIformation.Text.Trim();
                customers.addedOn =Utility.firstDate;
                if (txtDiscount.Text == string.Empty)
                {
                    customers.discount = 0.0;
                }
                else
                {
                    customers.discount = Utility.ParseValue(txtDiscount.Text);
                }
                if (txtlimitationAmount.Text == string.Empty)
                {
                    customers.limitationAmount = 0.0;
                }
                else
                {
                    customers.limitationAmount = Utility.ParseValue(txtlimitationAmount.Text);
                }
                if (txtOpeningBalance.Text == string.Empty)
                {
                    customers.openigBalanace = 0;
                }
                else
                {
                    customers.openigBalanace = Utility.ParseValue(txtOpeningBalance.Text);
                }
                customers.fromDate = dateBill.Value;
                customers.isCreditDebit = cmbCreditDebit.Text;
                customers.contactPerson = txtContactPerson.Text;
                customers.contactNo = txtContactPersonMobileno.Text;
                customers.adharNo = txtAdharNo.Text.Trim();
                customers.addedBy = Utility.LoginID;
                customers.FinancialYearID = Utility.FinancilaYearId;
                if (customers.customerId > 0)
                {
                    DialogResult ShowReport = DialogResult.No;
                    if (Utility.Langn == "English")
                    {
                        ShowReport=MessageBox.Show("Do you want to update....?", "", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                      ShowReport=  MessageBox.Show("तु्म्हाला अपडेट करायचं का ....?", "", MessageBoxButtons.YesNo);
                    }
                    if (ShowReport == DialogResult.Yes)
                    {   
                        int i = customerController.addCustomerDetails(customers);
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
                                MessageBox.Show("ग्राहकाचे नाव आधीच उपलब्ध आहे ..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    int i = customerController.addCustomerDetails(customers);
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
                            MessageBox.Show("ग्राहकाचे नाव आधीच उपलब्ध आहे ..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdCustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.grdCustomerDetails.Rows[e.RowIndex];
                 
                    if (row.Cells != null)
                    {
                        customerId = Convert.ToInt32(row.Cells["customerId"].Value);
                        txtCustomerName.Text = row.Cells["customerName"].Value.ToString();
                        txtAdd1.Text = row.Cells["customerAddress"].Value.ToString();
                        cmbVillage.Text = row.Cells["villageName"].Value.ToString();
                        dtpDOB.Text = row.Cells["DOB"].Value.ToString();
                        cmbGender.SelectedText = row.Cells["genderId"].Value.ToString();
                        txtMobileNo.Text = row.Cells["customerMobileNo"].Value.ToString();
                        txtMobileTwo.Text = row.Cells["MobileTwo"].Value.ToString();
                        txtMobileThree.Text = row.Cells["MobileThree"].Value.ToString(); 
                        txtEmailID.Text = row.Cells["emailId"].Value.ToString();
                        txtGSTNo.Text = row.Cells["CustomerGSTNo"].Value.ToString();
                        cmbCustomerRetailer.Text =row.Cells["isCustomerRetailer"].Value.ToString();
                        cmbGender.Text = row.Cells["genderId"].Value.ToString();
                        txtContactPerson.Text = row.Cells["contactPerson"].Value.ToString();
                        txtContactPersonMobileno.Text = row.Cells["contactNo"].Value.ToString();
                        txtOpeningBalance.Text = row.Cells["openigBalanace"].Value.ToString();
                        cmbCreditDebit.Text = row.Cells["isCreditDebit"].Value.ToString();
                        txtOtherIformation.Text = row.Cells["OtherNote"].Value.ToString();
                        txtAdharNo.Text = row.Cells["adharNo"].Value.ToString();
                        txtDiscount.Text = row.Cells["discount"].Value.ToString();
                        txtlimitationAmount.Text = row.Cells["limitationAmount"].Value.ToString();
                        cmbSalesmanName.Text = row.Cells["SalesmanName"].Value.ToString();
                        txtpancardno.Text = row.Cells["Pan_No"].Value.ToString();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerId == 0)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select customer from list..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया लिस्ट मधून ग्राहक निवडा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    return;
                }
                DialogResult ShowReport = DialogResult.No;
                if (Utility.Langn == "English")
                {
                    ShowReport=  MessageBox.Show("Do you want to delete this Record..?", "Delete", MessageBoxButtons.YesNo);
                }
                else
                {
                    ShowReport = MessageBox.Show("माहिती डिलीट करायची का ..?", "डिलीट", MessageBoxButtons.YesNo);
                }
                if (ShowReport == DialogResult.Yes)
                {
                    int i = customerController.isActiveCustomer(customerId);
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
                            MessageBox.Show("Please You can't delete this customer " + Environment.NewLine + "Because bill or receipt is exists under this customer ..!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("कृपया हा ग्राहाक डिलीट करता येत नाही " + Environment.NewLine + " कराण बिल  किंवा पावती आहे ..!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return;
                    }
                }
                else
                {
                    ShowReport = DialogResult.No;
                    //Utility.ClearSpace(this);
                    //Utility.enableFields(this);
                    //btnDelete.Enabled = false;
                    //btnUpdate.Enabled = false;
                    //btnSave.Enabled = true;
                    //BindCustomerGrid();
                    //BindComboBoxgetGender();
                    //BindComboBoxVillageDetails();
                    //cmbCreditDebit.SelectedIndex = 0;
                    btnnew_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSeachName_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdCustomerDetails.Rows)
            {
                string s = row.Cells[1].Value.ToString();

                if (!s.StartsWith(txtSeachName.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[grdCustomerDetails.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                    grdCustomerDetails.Visible = true;
                }
                else
                    row.Visible = true;
            }
        }

        private void txtSearchMob_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdCustomerDetails.Rows)
            {
                string s = row.Cells["customerMobileNo"].Value.ToString();

                if (!s.StartsWith(txtSearchMob.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[grdCustomerDetails.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                    grdCustomerDetails.Visible = true;
                }
                else
                    row.Visible = true;
            }
        }

        private void frmCustomerDetails_KeyDown(object sender, KeyEventArgs e)
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
                    btnSave_Click(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            //if (txtCustomerName.SelectionStart == 0) //This is the first character
            //{
            //    //Now check to see if the key pressed is a space
            //    if (e.KeyValue == 32)
            //    {
            //        //Stop the key registering
            //        e.Handled = true;
            //        e.SuppressKeyPress = true;
            //    }
            //}
        }

        private void txtMobileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtMobileNo.SelectionStart == 0) //This is the first character
            {
                //Now check to see if the key pressed is a space
                if (e.KeyValue == 32)
                {
                    //Stop the key registering
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void txtEmailID_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtEmailID.SelectionStart == 0) //This is the first character
            {
                //Now check to see if the key pressed is a space
                if (e.KeyValue == 32)
                {
                    //Stop the key registering
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void cmbVillage_KeyDown(object sender, KeyEventArgs e)
        {
            if (cmbVillage.SelectionStart == 0) //This is the first character
            {
                //Now check to see if the key pressed is a space
                if (e.KeyValue == 32)
                {
                    //Stop the key registering
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void txtOpeningBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtOpeningBalance.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtOpeningBalance.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtOpeningBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtOpeningBalance.SelectionStart == 0) //This is the first character
            {
                //Now check to see if the key pressed is a space
                if (e.KeyValue == 32)
                {
                    //Stop the key registering
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void txtOpeningBalance_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtOpeningBalance.Text != string.Empty)
            //    {
            //        long i = Convert.ToInt64(txtOpeningBalance.Text);
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btneExcelReport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                //Create Excel Sheets
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);
                DataTable dtAccount = (DataTable)grdCustomerDetails.DataSource;              
                dtAccount.Columns["customerName"].ColumnName = "ग्राहकाचे नाव";
                //dtAccount.Columns["isCustomerRetailer"].ColumnName = "ग्राहक/किररकोळ विक्रेता";
                dtAccount.Columns["villageName"].ColumnName = "गाव";
               // dtAccount.Columns["customerAddress"].ColumnName = "पत्ता";
                dtAccount.Columns["customerMobileNo"].ColumnName = "मोबाईल क्र.";
                dtAccount.Columns["MobileTwo"].ColumnName = "मोबाईल क्र.2";
              //  dtAccount.Columns["MobileThree"].ColumnName = "मोबाईल क्र.3";
              //  dtAccount.Columns["genderId"].ColumnName = "लिंग";
                //dtAccount.Columns["DOB"].ColumnName = "जन्मदिनांक";
               // dtAccount.Columns["emailId"].ColumnName = "ई-मेल";
                dtAccount.Columns["CustomerGSTNo"].ColumnName = "GST No";
                dtAccount.Columns["contactPerson"].ColumnName = "संपर्क व्यक्ती";
                dtAccount.Columns["contactNo"].ColumnName = "संपर्क मोबाईल नं.";
                dtAccount.Columns.Remove("customerId");
                dtAccount.Columns.Remove("villageId");
                dtAccount.Columns.Remove("isActive");
                dtAccount.Columns.Remove("addedBy");
                dtAccount.Columns.Remove("addedOn");
                dtAccount.Columns.Remove("updateBy");
                dtAccount.Columns.Remove("updateDate");
                dtAccount.Columns.Remove("OtherNote");
                dtAccount.Columns.Remove("DOB");
                dtAccount.Columns.Remove("isCustomerRetailer");
                dtAccount.Columns.Remove("customerAddress");
                dtAccount.Columns.Remove("genderId");
                dtAccount.Columns.Remove("emailId");
                dtAccount.Columns.Remove("MobileThree");
                dtAccount.TableName = "Customer Report";
                xlWorksheet.Name = dtAccount.TableName;

                for (int j = 1; j < dtAccount.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = dtAccount.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < dtAccount.Rows.Count; k++)
                {
                    for (int l = 0; l < dtAccount.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        dtAccount.Rows[k].ItemArray[l].ToString();
                    }
                }
                ExcelApp.Columns.AutoFit();

                ((Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.ActiveWorkbook.Sheets[ExcelApp.ActiveWorkbook.Sheets.Count]).Delete();
                ExcelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdCustomerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
