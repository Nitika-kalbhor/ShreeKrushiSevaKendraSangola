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
    public partial class frmCreditNote : MetroForm
    {
        public frmCreditNote()
        {
            InitializeComponent();
        }
        private bool isDelete;
        private long saleReturnId;
        private double IGST5 = 0, IGST12 = 0, IGST18 = 0, IGST28 = 0;
        public void BindComboBoxgetCustomerName()
        {
            DataTable dtCustomerName = customerController.getCustomerDetails();
            Utility.BindComboBoxEmptyDataSelect(cmbCustomerName, dtCustomerName, "customerId", "customerName");
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Credit Note";
                    metroLabel8.Text = "Credit Note No:";
                    metroLabel7.Text = "Date:";
                    label17.Text = "Customer/Retailer:";
                    lblstockInNo.Text = "Customer Name:";
                    label1.Text = "Remaining Amount:";
                    rbCash.Text = "Cash";
                    rbCredit.Text = "Credit";
                    metroLabel2.Text = "Address:";
                    label8.Text = "Purchase State:";
                    label7.Text = "Code:";
                    label4.Text = "Total Amount:";                   
                    lblPaymenttype.Text = "Payment Type:";
                    lblBankName.Text = "Bank Name:";
                    lblChequeNo.Text = "Cheque No:";
                    label33.Text = "Cheque Date:";
                    label5.Text = "Naration:";
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    button1.Text = "Bill List";
                    label2.Text = "From Date:";
                    label3.Text = "To Date:";
                    btnShow.Text = "Show";
                    label6.Text="* Entry In this Form does not affect stock,it will affects only accounts.";

                    dgvSaleItems.Columns[1].HeaderText = "Naration";
                    dgvSaleItems.Columns[2].HeaderText = "Batch No";
                    dgvSaleItems.Columns[3].HeaderText = "Quantity";
                    dgvSaleItems.Columns[4].HeaderText = "UnitBy";
                    dgvSaleItems.Columns[5].HeaderText = "Rate";
                    dgvSaleItems.Columns[6].HeaderText = "totalAmount";
                    dgvSaleItems.Columns[7].HeaderText = "GST(%)";
                    dgvSaleItems.Columns[8].HeaderText = "IGSTAmt";
                    dgvSaleItems.Columns[9].HeaderText = "CGST(%)";
                    dgvSaleItems.Columns[10].HeaderText = "CGST Amt";
                    dgvSaleItems.Columns[11].HeaderText = "SGST(%)";
                    dgvSaleItems.Columns[12].HeaderText = "SGSTAmt";
                    dgvSaleItems.Columns[13].HeaderText = "total Amount";

                    dgvSaleInvoice.Columns[0].HeaderText = "credit Note No";
                    dgvSaleInvoice.Columns[1].HeaderText = "Customer Name";
                    dgvSaleInvoice.Columns[2].HeaderText = "Date";
                    dgvSaleInvoice.Columns[3].HeaderText = "Amount";
                  }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmCreditNote_Load(object sender, EventArgs e)
        {
            try
            {

                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                dgvSaleItems.Rows.Add();
                isDelete = false;
                grbSaleInvice.Visible = false;
                dtpFromChallanDate.Enabled = false;
                dtpToChallanDate.Enabled = false;
                rbCash.Checked = true;
                dgvSaleItems.Enabled = false;
                // dtpChallenDate.Value = Utility.firstDate;
                dtpChallenDate.MinDate = dtpFromChallanDate.MinDate = dtpToChallanDate.MinDate = Utility.firstDate;
                dtpChallenDate.MaxDate = dtpFromChallanDate.MaxDate = dtpToChallanDate.MaxDate = Utility.lastDate;
                Lang();
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
                BindComboBoxgetCustomerName();
                cmbPaymentType.SelectedIndex = 0;
                txtInvoiceNo.Text = creditNoteController.getMaxIdCreditNoteId(Utility.FinancilaYearId).ToString();
              
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                grbSaleInvice.Visible = false;
                dtpFromChallanDate.Enabled = false;
                dtpToChallanDate.Enabled = false;
                rbCredit.Checked = true;
               
                dgvSaleItems.Enabled = false;
                //chkholeSale.Checked = false;
                cmbCustomerName.Focus();
                txtStateCode.Text = "27";
                cmbIGST.Text = "Maharashtra";
                cmbCustomerRetailer.SelectedIndex = 0;
                lblCreditAmount.Text = "0";
                isDelete = false;
                dgvSaleItems.Enabled = true;
                if (Utility.Langn == "English")
                {
                    btnSave.Text = "Save";
                }
                else
                {
                    btnSave.Text = "जतन करा";
                }
                saleReturnId = 0;
                IGST5 = 0; IGST12 = 0; IGST18 = 0; IGST28 = 0;
                // dtpChallenDate.Value = Utility.firstDate;
                dtpChallenDate.MinDate = dtpFromChallanDate.MinDate = dtpToChallanDate.MinDate = Utility.firstDate;
                dtpChallenDate.MaxDate = dtpFromChallanDate.MaxDate = dtpToChallanDate.MaxDate = Utility.lastDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Int32 rowToDelete;
        public int rowIndex = 0;
        private void dgvSaleItems_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.dgvSaleItems.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.contextMenuStrip1.Show(this.dgvSaleItems, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isDelete == true)
            {
            }
            else
            {
                rowToDelete = dgvSaleItems.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                dgvSaleItems.Rows.RemoveAt(rowToDelete);
                dgvSaleItems.ClearSelection();
            }
            if (dgvSaleItems.Rows.Count == 0)
            {
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
            }
            subtot();
        }

        private void dgvSaleItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvSaleItems.IsCurrentCellDirty)
            {
                dgvSaleItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
                try
                {
                    tb_TextChanged(sender, e);
                }
                catch (Exception ae)
                {
                    MessageBox.Show(ae.Message);
                }
            }
        }
        void tb_TextChanged(Object sender, EventArgs e)
        {
            try
            {
                if (dgvSaleItems.CurrentRow.Cells["itemName"].Value == null)
                {
                   
                    dgvSaleItems.CurrentRow.Cells["salesReturnItemDetailsId"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["batchNo"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["unitBy"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["Rate"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = 0;
                     dgvSaleItems.CurrentRow.Cells["IGST"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["CGST"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["SGST"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["totalAmtWithGST"].Value = 0;
                }
                else
                {
                    if (dgvSaleItems.CurrentCell.ColumnIndex == 2 || dgvSaleItems.CurrentCell.ColumnIndex == 3 || dgvSaleItems.CurrentCell.ColumnIndex == 4 || dgvSaleItems.CurrentCell.ColumnIndex == 5
                        || dgvSaleItems.CurrentCell.ColumnIndex == 7 || dgvSaleItems.CurrentCell.ColumnIndex == 9 || dgvSaleItems.CurrentCell.ColumnIndex == 11)
                    {
                        if (dgvSaleItems.CurrentRow.Cells["batchNo"].Value != null && dgvSaleItems.CurrentRow.Cells["unitBy"].Value != null && dgvSaleItems.CurrentRow.Cells["Quantity"].Value != null && dgvSaleItems.CurrentRow.Cells["Rate"].Value != null
                            && dgvSaleItems.CurrentRow.Cells["IGST"].Value != null && dgvSaleItems.CurrentRow.Cells["CGST"].Value != null && dgvSaleItems.CurrentRow.Cells["SGST"].Value != null)
                        {
                            dgvSaleItems.CurrentRow.Cells["salesReturnItemDetailsId"].Value = 0;
                            dgvSaleItems.CurrentRow.Cells["Quantity"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString());
                           dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dgvSaleItems.CurrentRow.Cells["unitBy"].Value.ToString();
                           dgvSaleItems.CurrentRow.Cells["batchNo"].Value = dgvSaleItems.CurrentRow.Cells["batchNo"].Value.ToString();
                              dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString());
                              dgvSaleItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString());
                              dgvSaleItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString());
                              dgvSaleItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString());
                            
                             dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()), 2);
                        if (cmbIGST.SelectedItem.ToString() != "Maharashtra")
                            {
                                dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString())) *Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["totalAmount"].Value) / 100), 2);
                                                        }
                            else
                            {
                                dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString()))  *Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["totalAmount"].Value) / 100), 2);
                                dgvSaleItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                                dgvSaleItems.CurrentRow.Cells["IGST"].Value = 2 * (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                                dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()))), 2);
                                dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString())), 2);

                            }

                            dgvSaleItems.CurrentRow.Cells["totalAmtWithGST"].Value = Math.Round((Convert.ToDouble(Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["totalAmount"].Value) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) )), 2);
                        }
                        else
                        {
                            dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = 0;
                            dgvSaleItems.CurrentRow.Cells["totalAmtWithGST"].Value=0;
                            dgvSaleItems.CurrentRow.Cells["IGST"].Value = 0;
                            dgvSaleItems.CurrentRow.Cells["CGST"].Value = 0;
                            dgvSaleItems.CurrentRow.Cells["SGST"].Value = 0;
                        }
                    }
                }
                subtot();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void subtot()
        {
            try
            {
                double sum = 0;
                IGST5 = 0; IGST12 = 0; IGST18 = 0; IGST28 = 0;
                for (int i = 0; i < dgvSaleItems.Rows.Count; ++i)
                {
                    if (dgvSaleItems.Rows[i].Cells["totalAmtWithGST"].Value != null)
                    {
                        sum += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["totalAmtWithGST"].Value.ToString());
                        if (dgvSaleItems.Rows[i].Cells["IGST"].Value.ToString() == "5")
                        {
                            IGST5 += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                        }
                        if (dgvSaleItems.Rows[i].Cells["IGST"].Value.ToString() == "12")
                        {
                            IGST12 += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                        }
                        if (dgvSaleItems.Rows[i].Cells["IGST"].Value.ToString() == "18")
                        {
                            IGST18 += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                        }
                        if (dgvSaleItems.Rows[i].Cells["IGST"].Value.ToString() == "28")
                        {
                            IGST28 += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["IGSTAmt"].Value.ToString());
                        }
                    }
                }
                txtNetAmount.Text = Math.Round(Convert.ToDouble(sum), 2).ToString();
                string netamount = txtNetAmount.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSaleItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
                if (dgvSaleItems.CurrentCell.ColumnIndex == 3 || dgvSaleItems.CurrentCell.ColumnIndex == 5 || dgvSaleItems.CurrentCell.ColumnIndex == 7 || dgvSaleItems.CurrentCell.ColumnIndex == 9 || dgvSaleItems.CurrentCell.ColumnIndex == 11) //Desired Column
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // allowed only numeric value  ex.10
                //if (!char.IsControl(e.KeyChar)
                //    && !char.IsDigit(e.KeyChar))
                //{
                //    e.Handled = true;
                //}

                // allowed numeric and one dot  ex. 10.23
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                     && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if (e.KeyChar == '.'
                    && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSaleItems_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    int col = dgvSaleItems.CurrentCell.ColumnIndex;
                    int row = dgvSaleItems.CurrentCell.RowIndex;
                    if (col < dgvSaleItems.ColumnCount - 1)
                    {
                        col++;
                    }
                    else
                    {
                        col = 0;
                        row++;
                    }
                            if (row == dgvSaleItems.RowCount)
                            {
                                dgvSaleItems.Rows.Add();
                                dgvSaleItems.CurrentCell = dgvSaleItems[col + 1, row];
                            }
                            else
                            {
                                dgvSaleItems.CurrentCell = dgvSaleItems[col, row];
                            }
                      
                    e.Handled = true;
                }
                if ((e.KeyCode == Keys.F10 && e.Shift))
                {

                }
            }
            catch (Exception ex)
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
                        lblChequeNo.Text = "Cheque/DD No.";
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
                if (cmbCustomerName.SelectedIndex<0)
                {                  
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Add /Select customer name");
                    }
                    else
                    {
                        MessageBox.Show("कृपया ग्राहकाचे नाव भरा किवा निवडा..");
                    }
                    cmbCustomerName.Focus();
                    return;
                }
                for (int i = 0; i < dgvSaleItems.Rows.Count; i++)
                {
                    if (dgvSaleItems.Rows[i].Cells[1].Value == null)
                    {                      
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Item Name in list");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये वस्तूचे नाव भरा..");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[1];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[2].Value == null)
                    {                      
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Batch No in list");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये बॅच नंबर भरा");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[2];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[3].Value == null)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Quantity in list");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये नग भरा");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[3];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[4].Value == null)
                    {                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Paking in list");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये पॅकींग भरा");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[3];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[5].Value == null)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add rate in list");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये दर भरा");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[3];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[6].Value == null)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add IGST(%) in list");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये IGST(%) भरा");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[6];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[7].Value == null)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add CGST(%) in list");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये CGST(%) भरा");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[7];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[6].Value == null || Convert.ToDouble(dgvSaleItems.Rows[i].Cells[6].Value) == 0)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Amount");
                        }
                        else
                        {
                            MessageBox.Show("कृपया रक्कम भरा");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[6];
                        return;
                    }
                }
                if (cmbPaymentType.Text.Equals("Cheque"))
                {
                    if (cmbBank.Text.Equals("") || cmbBank.Text.Equals("0"))
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
                if (cmbPaymentType.Text.Equals("Card Payment"))
                {
                    if (cmbBank.Text.Equals("") || cmbBank.Text.Equals("0"))
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
                if (cmbPaymentType.Text.Equals("") || cmbPaymentType.Text.Equals("0"))
                {
                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("कृपया Payment प्रकार निवडा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया Payment प्रकार निवडा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmbPaymentType.Focus();
                    return;
                }
                /// long customerId = 0;

                SalesReturnDetails purch = new SalesReturnDetails();
                    purch.customerId = Convert.ToInt64(cmbCustomerName.SelectedValue);
                DataTable dtSaleItems = new DataTable();

                foreach (DataGridViewColumn col in dgvSaleItems.Columns)
                {
                    dtSaleItems.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dgvSaleItems.Rows)
                {
                    DataRow dRow = dtSaleItems.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null)
                        {                           
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Please Fill All details in List");
                            }
                            else
                            {
                                MessageBox.Show("कृपया लिस्ट मध्ये पूर्ण माहिती भरा");
                            }
                            return;
                        }

                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtSaleItems.Rows.Add(dRow);
                }

                purch.SaleRetrunItemTable = dtSaleItems;
                purch.salesReturnDate = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                if (isDelete == false)
                {
                    purch.salesReturnInvoiceId = creditNoteController.getMaxIdCreditNoteId(Utility.FinancilaYearId).ToString();
                }
                else
                {
                    purch.salesReturnInvoiceId = txtInvoiceNo.Text;
                }
                purch.financialYearID = Utility.FinancilaYearId;
                // txtInvoiceNo.Text = salesReturnDetailsController.getMaxIdSaleRetrunInvoiceId().ToString();
                if (rbCash.Checked == true)
                {
                    purch.salesType = "Cash";
                }
                if (rbCredit.Checked == true)
                {
                    purch.salesType = "Credit";
                }
                purch.paymentType = cmbPaymentType.Text;              
                purch.totalbillAmount = Utility.ParseValue(txtNetAmount.Text);
                purch.chequeDate = dtpchedate.Value;
                purch.bankName = cmbBank.Text;
                purch.state = cmbIGST.Text;
                purch.stateCode = txtStateCode.Text;
                purch.isCustomerRetailer = cmbCustomerRetailer.Text;
                purch.naration = txtRemark.Text.Trim();
                purch.isDelete = isDelete;
                if (cmbBank.SelectedIndex > 0)
                {
                    purch.bankId = Convert.ToInt32(cmbBank.SelectedValue);
                }
                else
                {
                    purch.bankId = 0;
                }
                purch.chequeNo_refNo = txtchqDDNo.Text;
                purch.addedBy = Utility.LoginID;
                PusrchaseSaleAccount purchase = new PusrchaseSaleAccount();
                purchase.RoundOff = Convert.ToDouble(0);
                purchase.Hamali = Convert.ToDouble(0);
                purchase.discount = Convert.ToDouble(0);
                purchase.billId = Convert.ToInt64(purch.salesReturnInvoiceId);
                purchase.stateCode = txtStateCode.Text;
                purchase.issalePurchase = "CreditNote";
                purchase.Igst5 = IGST5;
                purchase.Igst12 = IGST12;
                purchase.Igst18 = IGST18;
                purchase.Igst28 = IGST28;
                purchase.salePurchaseAccount = Math.Round(Convert.ToDouble(txtNetAmount.Text) - (IGST5 + IGST12 + IGST18 + IGST28), 2);

                int ks = creditNoteController.addSalescreditNote(purch, purchase);
                if (ks > 0)
                {
                    if (purch.isDelete == false)
                    {                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("माहिती यशस्वीरित्या भरली गेली", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Record Deleted Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("माहिती यशस्वीरित्या डिलीट केली गेली", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    // bill();
                    btnnew_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                grbSaleInvice.Visible = true;
                dtpFromChallanDate.Enabled = true;
                dtpToChallanDate.Enabled = true;
                DataTable dtSaleInvoice = creditNoteController.getCreditDebitNote(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()), Utility.FinancilaYearId);
                dgvSaleInvoice.DataSource = dtSaleInvoice;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtSaleInvoice = creditNoteController.getCreditDebitNote(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()), Utility.FinancilaYearId);
                dgvSaleInvoice.DataSource = dtSaleInvoice;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSaleInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                long creditNoteId = 0;
                if (e.RowIndex >= 0)
                {
                    creditNoteId = Convert.ToInt64(dgvSaleInvoice.CurrentRow.Cells["creditNoteId"].Value);
                }
                BindData(creditNoteId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindData(long creditNoteId)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
               
                if (Utility.Langn == "English")
                {
                    btnSave.Text = "Delete";
                }
                else
                {
                    btnSave.Text = "डिलीट";
                }
                grbSaleInvice.Visible = false;
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                dgvSaleItems.Enabled = true;
                isDelete = true;
                IGST5 = 0; IGST12 = 0; IGST18 = 0; IGST28 = 0;
                DataTable dtSaleChallen = creditNoteController.getCreditDebitNoteDetails(creditNoteId, Utility.FinancilaYearId);
                saleReturnId = Convert.ToInt64(dtSaleChallen.Rows[0]["creditNoteId"].ToString());
                txtInvoiceNo.Text = dtSaleChallen.Rows[0]["creditNoteInvoiceId"].ToString();
                dtpChallenDate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["creditNoteDate"].ToString());
                cmbIGST.Text = dtSaleChallen.Rows[0]["state"].ToString();
                txtStateCode.Text = dtSaleChallen.Rows[0]["stateCode"].ToString();
                cmbCustomerRetailer.Text = Convert.ToString(dtSaleChallen.Rows[0]["isCustomerRetailer"]);
                BindComboBoxgetCustomerName();
                cmbCustomerName.Text = dtSaleChallen.Rows[0]["customerName"].ToString();
                cmbPaymentType.Text = dtSaleChallen.Rows[0]["paymentType"].ToString();
                cmbBank.Text = dtSaleChallen.Rows[0]["bankName"].ToString();
                txtchqDDNo.Text = dtSaleChallen.Rows[0]["chequeNo_refNo"].ToString();
                dtpchedate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["chequeDate"].ToString());

                if (dtSaleChallen.Rows[0]["creditNoteType"].ToString() == "Cash")
                {
                    rbCash.Checked = true;
                }
                if (dtSaleChallen.Rows[0]["creditNoteType"].ToString() == "Credit")
                {
                    rbCredit.Checked = true;
                }

                txtNetAmount.Text = dtSaleChallen.Rows[0]["creditNoteAmount"].ToString();
               
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                foreach (DataRow dr in dtSaleChallen.Rows)
                {

                    dgvSaleItems.CurrentRow.Cells["salesReturnItemDetailsId"].Value = Convert.ToInt32(dr["creditNoteDetailsId"]);
                   
                    dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                    dgvSaleItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                    dgvSaleItems.CurrentRow.Cells["Quantity"].Value = Convert.ToDouble(dr["quantity"]);
                    dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                    dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dr["perQtysalePrice"].ToString());
                    dgvSaleItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dr["IGST"].ToString());
                    dgvSaleItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dr["CGST"].ToString());
                    dgvSaleItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dr["SGST"].ToString());
                    dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()), 2);
                    if (cmbIGST.SelectedItem.ToString() != "Maharashtra")
                    {
                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString())) * Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["totalAmount"].Value) / 100), 2);
                    }
                    else
                    {
                        dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["totalAmount"].Value) / 100), 2);
                        dgvSaleItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                        dgvSaleItems.CurrentRow.Cells["IGST"].Value = 2 * (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                        dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()))), 2);
                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString())), 2);
                    }
                    dgvSaleItems.CurrentRow.Cells["totalAmtWithGST"].Value = Math.Round((Convert.ToDouble(Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["totalAmount"].Value) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()))), 2);
                    dgvSaleItems.CurrentCell = dgvSaleItems.CurrentRow.Cells["Quantity"];
                    dgvSaleItems.BeginEdit(true);
                    int col = dgvSaleItems.CurrentCell.ColumnIndex;
                    int row = dgvSaleItems.CurrentCell.RowIndex;
                    col = 0;
                    row++;
                    if (dgvSaleItems.Rows.Count < dtSaleChallen.Rows.Count)
                    {
                        if (row == dgvSaleItems.RowCount)
                        {
                            dgvSaleItems.Rows.Add();
                            dgvSaleItems.CurrentCell = dgvSaleItems[col + 1, row];
                        }
                    }
                }
                dgvSaleItems.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable cust = null;
                if (cmbCustomerName.SelectedIndex != 0)
                {
                    cust = customerController.getCustomerDetails();
                    long id = Convert.ToInt64(cmbCustomerName.SelectedValue);
                    var query = from custs in cust.AsEnumerable()
                                where custs.Field<Int64>("customerId") == id
                                select custs;
                    if (query.Count() > 0)
                    {
                        DataTable info = query.CopyToDataTable<DataRow>();
                        txtCustAddress.Text = info.Rows[0]["customerAddress"].ToString();
                        lblCreditAmount.Text = Math.Round(accountDetailsController.GetDueAmount(id, "customer", Utility.FinancilaYearId, Convert.ToDateTime(dtpChallenDate.Value))).ToString();
                    }
                }
                else
                {
                }
                if (cmbCustomerName.SelectedIndex > 0)
                {
                    dgvSaleItems.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbIGST_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbIGST.SelectedIndex >= 0)
                {
                    string stateName = cmbIGST.Text;
                    switch (stateName)
                    {
                        case "Jammu and Kashmir":
                            txtStateCode.Text = "01";
                            break;
                        case "Himachal Pradesh":
                            txtStateCode.Text = "02";
                            break;
                        case "Punjab":
                            txtStateCode.Text = "03";
                            break;
                        case "Chandigarh":
                            txtStateCode.Text = "04";
                            break;
                        case "Uttrakhand":
                            txtStateCode.Text = "05";
                            break;
                        case "Haryana":
                            txtStateCode.Text = "06";
                            break;
                        case "Delhi":
                            txtStateCode.Text = "07";
                            break;
                        case "Rajasthan":
                            txtStateCode.Text = "08";
                            break;
                        case "Uttar Pradesh":
                            txtStateCode.Text = "09";
                            break;
                        case "Bihar":
                            txtStateCode.Text = "10";
                            break;
                        case "Sikkim":
                            txtStateCode.Text = "11";
                            break;
                        case "Arunachal Pradesh":
                            txtStateCode.Text = "12";
                            break;
                        case "Nagaland":
                            txtStateCode.Text = "13";
                            break;
                        case "Manipur":
                            txtStateCode.Text = "14";
                            break;
                        case "Mizoram":
                            txtStateCode.Text = "15";
                            break;
                        case "Tripura":
                            txtStateCode.Text = "16";
                            break;
                        case "Meghalaya":
                            txtStateCode.Text = "17";
                            break;

                        case "Assam":
                            txtStateCode.Text = "18";
                            break;
                        case "West Bengal":
                            txtStateCode.Text = "19";
                            break;

                        case "Jharkhand":
                            txtStateCode.Text = "20";
                            break;
                        case "Odisha":
                            txtStateCode.Text = "21";
                            break;
                        case "Chhattisgarh":
                            txtStateCode.Text = "22";
                            break;
                        case "Madhya Pradesh":
                            txtStateCode.Text = "23";
                            break;
                        case "Gujarat":
                            txtStateCode.Text = "24";
                            break;
                        case "Daman and Diu":
                            txtStateCode.Text = "25";
                            break;
                        case "Dadra and Nagar Haveli":
                            txtStateCode.Text = "26";
                            break;
                        case "Maharashtra":
                            txtStateCode.Text = "27";
                            break;

                        case "Karnataka":
                            txtStateCode.Text = "29";
                            break;
                        case "Goa":
                            txtStateCode.Text = "30";
                            break;
                        case "Lakshdweep":
                            txtStateCode.Text = "31";
                            break;
                        case "Kerala":
                            txtStateCode.Text = "32";
                            break;
                        case "Tamil Nadu":
                            txtStateCode.Text = "33";
                            break;
                        case "Pondicherry":
                            txtStateCode.Text = "34";
                            break;

                        case "Andaman & Nicobar Islands":
                            txtStateCode.Text = "35";
                            break;
                        case "Telangana":
                            txtStateCode.Text = "36";
                            break;
                        case "Andhra Pradesh":
                            txtStateCode.Text = "37";
                            break;

                        case "Other Territory":
                            txtStateCode.Text = "97";
                            break;

                    }
                }

                if (cmbIGST.SelectedItem.ToString() != "Maharashtra")
                {
                    dgvSaleItems.Columns["IGST"].Visible = true;
                    dgvSaleItems.Columns["IGSTAmt"].Visible = true;
                    dgvSaleItems.Columns["CGST"].Visible = false;
                    dgvSaleItems.Columns["CGSTAmt"].Visible = false;
                    dgvSaleItems.Columns["SGST"].Visible = false;
                    dgvSaleItems.Columns["SGSTAmt"].Visible = false;
                }
                else
                {
                    dgvSaleItems.Columns["IGST"].Visible = false;
                    dgvSaleItems.Columns["IGSTAmt"].Visible = false;
                    dgvSaleItems.Columns["CGST"].Visible = true;
                    dgvSaleItems.Columns["CGSTAmt"].Visible = true;
                    dgvSaleItems.Columns["SGST"].Visible = true;
                    dgvSaleItems.Columns["SGSTAmt"].Visible = true;

                }
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error!" + ae.ToString());
            }
        }

        private void frmCreditNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Alt)
            {
                btnnew_Click(sender, e);
            }
            if (e.KeyCode == Keys.S && e.Alt)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
