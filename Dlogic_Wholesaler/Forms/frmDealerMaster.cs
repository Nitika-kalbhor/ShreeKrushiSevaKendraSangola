using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using MetroFramework.Forms;
using System.Windows.Forms;
using DataAccessLayer.controller;
using DataAccessLayer.models;

namespace Dlogic_Wholesaler.Forms
{
    public partial class frmDealerMaster : MetroForm
    {
        public frmDealerMaster()
        {
            InitializeComponent();
        }
        #region Variables      
        #endregion
        #region Initializetion
        dealerDetails delear = new dealerDetails();
        public static int dealerId = 0;
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
                DataTable lstdealerDetails = DealerController.getDealerDetails();

                dgvCompany.AutoGenerateColumns = false;
                dgvCompany.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvCompany.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvCompany.Font = new Font("Tahoma", 11);

                dgvCompany.EnableHeadersVisualStyles = false;

                dgvCompany.ColumnCount = 14;
                if (Utility.Langn == "English")
                {
                    dgvCompany.Columns[0].Name = "dealerId";
                    dgvCompany.Columns[0].HeaderText = "dealerId";
                    dgvCompany.Columns[0].DataPropertyName = "dealerId";
                    dgvCompany.Columns[0].Visible = false;

                    dgvCompany.Columns[1].Name = "dealerFirmNames";
                    dgvCompany.Columns[1].HeaderText = "Dealer Firm Name";
                    dgvCompany.Columns[1].DataPropertyName = "dealerFirmNames";
                    dgvCompany.Columns[1].Width = 200;

                    dgvCompany.Columns[2].Name = "dealerFirmAddress";
                    dgvCompany.Columns[2].HeaderText = "Firm Address";
                    dgvCompany.Columns[2].DataPropertyName = "dealerFirmAddress";
                    dgvCompany.Columns[2].Width = 200;

                    dgvCompany.Columns[3].Name = "officeNo";
                    dgvCompany.Columns[3].HeaderText = "Office No.";
                    dgvCompany.Columns[3].DataPropertyName = "officeNo";

                    dgvCompany.Columns[4].Name = "dealerName";
                    dgvCompany.Columns[4].HeaderText = "Dealer Name";
                    dgvCompany.Columns[4].DataPropertyName = "dealerName";

                    dgvCompany.Columns[5].Name = "dealerAddress";
                    dgvCompany.Columns[5].HeaderText = "Dealer Address";
                    dgvCompany.Columns[5].DataPropertyName = "dealerAddress";

                    dgvCompany.Columns[6].Name = "dealerContactNo";
                    dgvCompany.Columns[6].HeaderText = "Mobile No.";
                    dgvCompany.Columns[6].DataPropertyName = "dealerContactNo";

                    dgvCompany.Columns[7].Name = "GSTNo";
                    dgvCompany.Columns[7].HeaderText = "GST No";
                    dgvCompany.Columns[7].DataPropertyName = "GSTNo";

                    dgvCompany.Columns[8].Name = "DOB";
                    dgvCompany.Columns[8].HeaderText = "DOB";
                    dgvCompany.Columns[8].DataPropertyName = "DOB";
                    dgvCompany.Columns[8].DefaultCellStyle.Format = "dd-MM-yyyy";

                    dgvCompany.Columns[9].Name = "Gender";
                    dgvCompany.Columns[9].HeaderText = "Gender";
                    dgvCompany.Columns[9].DataPropertyName = "Gender";

                    dgvCompany.Columns[10].Name = "emailId";
                    dgvCompany.Columns[10].HeaderText = "EmailId";
                    dgvCompany.Columns[10].DataPropertyName = "emailId";

                    dgvCompany.Columns[11].Name = "openigBalanace";
                    dgvCompany.Columns[11].HeaderText = "Openig Balanace";
                    dgvCompany.Columns[11].DataPropertyName = "openigBalanace";

                    dgvCompany.Columns[12].Name = "isCreditDebit";
                    dgvCompany.Columns[12].HeaderText = "Credit/Debit";
                    dgvCompany.Columns[12].DataPropertyName = "isCreditDebit";

                    dgvCompany.Columns[13].Name = "isCustomer";
                    dgvCompany.Columns[13].HeaderText = "isCustomer";
                    dgvCompany.Columns[13].DataPropertyName = "isCustomer";
                    dgvCompany.Columns[13].Visible = false;
                 }
                else
                {
                    dgvCompany.Columns[0].Name = "dealerId";
                    dgvCompany.Columns[0].HeaderText = "dealerId";
                    dgvCompany.Columns[0].DataPropertyName = "dealerId";
                    dgvCompany.Columns[0].Visible = false;

                    dgvCompany.Columns[1].Name = "dealerFirmNames";
                    dgvCompany.Columns[1].HeaderText = "व्यापारी फर्म नांव";
                    dgvCompany.Columns[1].DataPropertyName = "dealerFirmNames";
                    dgvCompany.Columns[1].Width = 200;

                    dgvCompany.Columns[2].Name = "dealerFirmAddress";
                    dgvCompany.Columns[2].HeaderText = "दुकान पत्ता";
                    dgvCompany.Columns[2].DataPropertyName = "dealerFirmAddress";
                    dgvCompany.Columns[2].Width = 200;

                    dgvCompany.Columns[3].Name = "officeNo";
                    dgvCompany.Columns[3].HeaderText = "फोन नं.";
                    dgvCompany.Columns[3].DataPropertyName = "officeNo";

                    dgvCompany.Columns[4].Name = "dealerName";
                    dgvCompany.Columns[4].HeaderText = "व्यापाऱ्याचा नाव";
                    dgvCompany.Columns[4].DataPropertyName = "dealerName";

                    dgvCompany.Columns[5].Name = "dealerAddress";
                    dgvCompany.Columns[5].HeaderText = "व्यापाऱ्याचा पत्ता";
                    dgvCompany.Columns[5].DataPropertyName = "dealerAddress";

                    dgvCompany.Columns[6].Name = "dealerContactNo";
                    dgvCompany.Columns[6].HeaderText = "मोबाईल क्र.";
                    dgvCompany.Columns[6].DataPropertyName = "dealerContactNo";

                    dgvCompany.Columns[7].Name = "GSTNo";
                    dgvCompany.Columns[7].HeaderText = "GST No";
                    dgvCompany.Columns[7].DataPropertyName = "GSTNo";

                    dgvCompany.Columns[8].Name = "DOB";
                    dgvCompany.Columns[8].HeaderText = "जन्मदिनांक";
                    dgvCompany.Columns[8].DataPropertyName = "DOB";
                    dgvCompany.Columns[8].DefaultCellStyle.Format = "dd-MM-yyyy";

                    dgvCompany.Columns[9].Name = "Gender";
                    dgvCompany.Columns[9].HeaderText = "लिंग";
                    dgvCompany.Columns[9].DataPropertyName = "Gender";

                    dgvCompany.Columns[10].Name = "emailId";
                    dgvCompany.Columns[10].HeaderText = "ई-मेल";
                    dgvCompany.Columns[10].DataPropertyName = "emailId";

                    dgvCompany.Columns[11].Name = "openigBalanace";
                    dgvCompany.Columns[11].HeaderText = "आरंभी शिल्लक";
                    dgvCompany.Columns[11].DataPropertyName = "openigBalanace";

                    dgvCompany.Columns[12].Name = "isCreditDebit";
                    dgvCompany.Columns[12].HeaderText = "नावे/जमा";
                    dgvCompany.Columns[12].DataPropertyName = "isCreditDebit";

                    dgvCompany.Columns[13].Name = "isCustomer";
                    dgvCompany.Columns[13].HeaderText = "isCustomer";
                    dgvCompany.Columns[13].DataPropertyName = "isCustomer";
                    dgvCompany.Columns[13].Visible = false;
                   
                }
                dgvCompany.DataSource = lstdealerDetails;


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
            cmbGender.SelectedIndex = 1;
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
                    lblHerader.Text = "Dealer Details";
                    label9.Text = "Dealer Details";
                    metroLabel4.Text = "Dealer Firm Name:";
                    metroLabel10.Text = "Dealer Firm Address:";
                    metroLabel7.Text = "Mobile No:";
                    metroLabel2.Text = "Dealer Name:";
                    metroLabel1.Text = "DOB:";
                    label1.Text = "GST No:";
                    lblGender.Text = "Gender:";
                    lblAddress.Text = "Address:";
                    lblMobileNo.Text = "Mobile No:";
                    lblEmailId.Text = "Email ID:";
                    lblOpening.Text = "Opening Amt:";
                    lblDate.Text = "Date:";
                    lblNaration.Text = "Naration:";
                    chkCustomer.Text = "Customer:";
                    metroLabel13.Text = "Dealer Firm Name:";
                    label10.Text = "Mobile No:";
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    btnUpdate.Text = "Update";
                    btnDelete.Text = "Delete";
                    btneExcelReport.Text = "Exel Report";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmDealerMaster_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(3, 3);
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                txtSeachName.Enabled = true;
                txtSearchMob.Enabled = true;
                BinDealerGrid();
                Lang();
                BindComboBoxgetGender();            
                cmbCreditDebit.SelectedIndex = 0;

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
                BinDealerGrid();
                BindComboBoxgetGender();
                cmbCreditDebit.SelectedIndex = 0;
                dealerId = 0;
                txtDealerFirmName.Focus();
              
                 lblOpening.Enabled = true;
                 txtOpeningBalance.Enabled = true;
                 cmbCreditDebit.Enabled = true;
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
                dealerDetails deleardetails = new dealerDetails();
                if (txtDealerFirmName.Text == string.Empty)
                {                    
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please add dealer firm name ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया व्यापाऱ्याचे दुकान नाव भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtDealerFirmName.Focus();
                    return;
                }
                deleardetails.dealerFirmName = txtDealerFirmName.Text.ToString();
                if (txtdealerName.Text == string.Empty)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please add dealer name..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया व्यापाऱ्याचे नाव भरा..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtdealerName.Focus();
                    return;
                }
                deleardetails.dealerId = dealerId;
                deleardetails.dealerName = txtdealerName.Text.Trim();
                deleardetails.DOB = Convert.ToDateTime(dtpDOB.Value);
                if (cmbGender.SelectedIndex <= 0 /*|| cmbGender.SelectedText == "-- Select --"*/)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select gender ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया लिंग निवडा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cmbGender.Focus();
                    return;
                }
                deleardetails.genderId = cmbGender.SelectedIndex;
               
                //if (txtDealerAddress.Text == string.Empty)
                //{
                //    MessageBox.Show("Please Insert Shop Address.....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtDealerAddress.Focus();
                //    return;
                //}
                deleardetails.dealerAddress = txtDealerAddress.Text.ToString();
                //if (txtDealerFirmAddress.Text == string.Empty)
                //{
                //    MessageBox.Show("Please Insert Dealer Address.....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtDealerFirmAddress.Focus();
                //    return;
                //}
                deleardetails.dealerFirmAddress = txtDealerFirmAddress.Text.ToString();
                if (txtMobileNo.Text == string.Empty)
                {
                    deleardetails.dealerContactNo = "";
                }
                else
                {
                    deleardetails.dealerContactNo = Utility.ParseValueI( txtMobileNo.Text).ToString();
                }
                deleardetails.officeNo = txtOfficeNo.Text.ToString();
                if (txtOpeningBalance.Text == string.Empty)
                {
                    deleardetails.openigBalance = 0;
                }
                else
                {
                    deleardetails.openigBalance = Convert.ToDouble(Utility.ParseValue(txtOpeningBalance.Text).ToString());
                }
                deleardetails.GSTNo = txtGSTNo.Text;
                deleardetails.CreditDebit = cmbCreditDebit.Text;
                deleardetails.fromDate = dateBill.Value;
                deleardetails.emailId = txtEmailId.Text.Trim();
                deleardetails.orjName = txtOtherIformation.Text.Trim();
                deleardetails.addedBy = Utility.LoginID ;
                deleardetails.FinancialYearID = Utility.FinancilaYearId;
                deleardetails.addedOn = DateTime.Now;
                if(chkCustomer.Checked==true)
                {
                    deleardetails.isCustomer = true;
                }
                else
                {
                    deleardetails.isCustomer = false;
                }
                if (deleardetails.dealerId > 0)
                {
                    DialogResult ShowReport = DialogResult.No;
                    if (Utility.Langn == "English")
                    {
                        ShowReport = MessageBox.Show("Do you want to update this record..?", "update", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        ShowReport = MessageBox.Show("तु्म्हाला अपडेट करायचं  का ..?", "अपडेट", MessageBoxButtons.YesNo);
                    }
                    if (ShowReport == DialogResult.Yes)
                    {
                        int i = DealerController.addDealerDetails(deleardetails);
                        if (i > 0)
                        {                           
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Record saved successfully ..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("माहिती यशस्वीरित्या साठवली गेली ..!", "जतन", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            //Utility.ClearSpace(this);
                            //Utility.enableFields(this);
                            //btnSave.Enabled = false;
                            //btnUpdate.Enabled = false;
                            //btnDelete.Enabled = false;
                            //BinDealerGrid();
                            //BindComboBoxgetGender();
                            //dealerId = 0;
                            btnnew_Click(sender, e);
                            // BindComboBoxCategoryDetails();
                        }
                        if (i < 0)
                        {                          
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Dealer Firm name already exists ..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("व्यापाऱ्याच्या दुकानचे नाव आधीच उपलब्ध आहे ..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                    }
                    else
                    {
                        ShowReport = DialogResult.No;
                        //Utility.ClearSpace(this);
                        //Utility.enableFields(this);
                        //btnSave.Enabled = true;
                        //btnUpdate.Enabled = false;
                        //btnDelete.Enabled = false;
                        //BinDealerGrid();
                        //dealerId = 0;
                        btnnew_Click(sender, e);
                    }
                }
                else
                {
                    int i = DealerController.addDealerDetails(deleardetails);
                    if (i > 0)
                    {                      
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Record Saved Successfully..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("माहिती यशस्वीरित्या साठवली गेली ..!", "जतन", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //Utility.ClearSpace(this);
                        //Utility.enableFields(this);
                        //btnSave.Enabled = false;
                        //btnUpdate.Enabled = false;
                        //btnDelete.Enabled = false;
                        //BinDealerGrid();
                        //dealerId = 0;
                        btnnew_Click(sender, e);
                    }
                    if (i < 0)
                    {                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Dealer Name Already exists..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("व्यापाऱ्याचे नाव आधीच उपलब्ध आहे ..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvCompany.Rows[e.RowIndex];
                    if (row.Cells != null)
                    {
                        dealerId = Convert.ToInt32(row.Cells["dealerId"].Value);
                        txtdealerName.Text = row.Cells["dealerName"].Value.ToString();
                        txtDealerFirmName.Text = row.Cells["DealerFirmNames"].Value.ToString();
                        dtpDOB.Text = row.Cells["DOB"].Value.ToString();
                        cmbGender.Text = row.Cells["Gender"].Value.ToString();
                        txtDealerAddress.Text = row.Cells["dealerAddress"].Value.ToString();
                        txtDealerFirmAddress.Text = row.Cells["dealerFirmAddress"].Value.ToString();
                        txtOfficeNo.Text = row.Cells["officeNo"].Value.ToString();
                        txtMobileNo.Text = row.Cells["dealerContactNo"].Value.ToString();
                        txtEmailId.Text = row.Cells["emailId"].Value.ToString();
                        txtGSTNo.Text = row.Cells["GSTNo"].Value.ToString();
                        txtOpeningBalance.Text = row.Cells["openigBalanace"].Value.ToString();
                        cmbCreditDebit.Text = row.Cells["isCreditDebit"].Value.ToString();
                        if (Convert.ToBoolean(row.Cells["isCustomer"].Value.ToString()) == true)
                        {
                            chkCustomer.Checked = true;
                        }
                        else
                        {
                            chkCustomer.Checked = false;
                        }
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
                if (dealerId == 0)
                {                    
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Dealer name ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("व्यापाऱ्याचे नाव निवडा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    return;
                }
                DialogResult ShowReport = DialogResult.No;
                if (Utility.Langn == "English")
                {
                  ShowReport = MessageBox.Show("Do you want to delete this record ..?", "Delete", MessageBoxButtons.YesNo);
                }
                else
                {
                    ShowReport = MessageBox.Show("माहिती डिलीट करायची का ..?", "डिलीट", MessageBoxButtons.YesNo);
                }
                if (ShowReport == DialogResult.Yes)
                {
                    int i = DealerController.deleteDealerDetails(dealerId, 1);
                    if (i > 0)
                    {                      
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Record Deleted Successfully..!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("माहिती डिलीट केली ..!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //Utility.ClearSpace(this);
                        //Utility.enableFields(this);
                        //btnDelete.Enabled = false;
                        //btnDelete.Enabled = false;
                        //btnUpdate.Enabled = false;
                        //btnSave.Enabled = true;
                        //dealerId = 0;
                        //BinDealerGrid();
                        btnnew_Click(sender, e);
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
                    //dealerId = 0;
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
            try
            {
                foreach (DataGridViewRow row in dgvCompany.Rows)
                {
                    string s = row.Cells[1].Value.ToString();

                    if (!s.StartsWith(txtSeachName.Text, true, null))
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvCompany.DataSource];
                        currencyManager1.SuspendBinding();
                        row.Visible = false;
                        currencyManager1.ResumeBinding();
                        dgvCompany.Visible = true;
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

        private void txtSearchMob_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCompany.Rows)
            {
                string s = row.Cells["dealerContactNo"].Value.ToString();

                if (!s.StartsWith(txtSearchMob.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvCompany.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                    dgvCompany.Visible = true;
                }
                else
                    row.Visible = true;
            }
        }

        private void frmDealerMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Home)
            {
                btnnew_Click(sender, e);
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

        private void txtDealerFirmName_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDealerFirmName.SelectionStart == 0) //This is the first character
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

        private void txtDealerFirmAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDealerFirmAddress.SelectionStart == 0) //This is the first character
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

        private void txtOfficeNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtOfficeNo.SelectionStart == 0) //This is the first character
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

        private void txtdealerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtdealerName.SelectionStart == 0) //This is the first character
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

        private void txtDealerAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDealerAddress.SelectionStart == 0) //This is the first character
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

        private void txtEmailId_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtEmailId.SelectionStart == 0) //This is the first character
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

        private void txtOtherIformation_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtOtherIformation.SelectionStart == 0) //This is the first character
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

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMobileNo.Text.Length == 0)
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

        private void txtOpeningBalance_KeyPress(object sender, KeyPressEventArgs e)
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
                DataTable dtAccount = new DataTable();
                foreach (DataGridViewColumn col in dgvCompany.Columns)
                {
                    dtAccount.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvCompany.Rows)
                {
                    DataRow dRow = dtAccount.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtAccount.Rows.Add(dRow);
                }
                dtAccount.Columns.Remove("dealerId");
                dtAccount.Columns.Remove("जन्मदिनांक");
                dtAccount.Columns.Remove("लिंग");
                dtAccount.Columns.Remove("व्यापाऱ्याचा पत्ता");
                dtAccount.Columns.Remove("ई-मेल");
                dtAccount.TableName = "Dealer Report";
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
    }
}
