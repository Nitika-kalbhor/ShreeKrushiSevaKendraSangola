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
using DataAccessLayer.controller;
using DataAccessLayer.models;
using Dlogic_Wholesaler.ReportFrom;
using System.Configuration;
using Dlogic_Wholesaler.Forms;
using Dlogic_Wholesaler.TempReportFroms;

namespace Dlogic_Wholesaler.TempFroms
{
    public partial class FrmTempSaleReturnTemp : MetroForm
    {
        public FrmTempSaleReturnTemp()
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
        private void frmSaleInvoive_Load(object sender, EventArgs e)
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
                dgvItemName.Hide();
               // rbCash.Checked = true;
                cmbIGST.SelectedIndex = 0;
                dgvSaleItems.Enabled = false;
               // dtpChallenDate.Value = Utility.firstDate;
                dtpChallenDate.MinDate = dtpFromChallanDate.MinDate = dtpToChallanDate.MinDate = Utility.firstDate;
                dtpChallenDate.MaxDate = dtpFromChallanDate.MaxDate = dtpToChallanDate.MaxDate = Utility.lastDate;
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
                cmbCustomerName.Enabled = true;
                txtCustAddress.Enabled = true;
                txtmobile.Enabled = true;
                BindComboBoxgetCustomerName();
                cmbPaymentType.SelectedIndex = 0;
                txtInvoiceNo.Text = salesReturnDetailsTempController.getMaxIdSaleRetrunInvoiceId(Utility.FinancilaYearId).ToString();
                dgvItemName.Hide();
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                grbSaleInvice.Visible = false;
                dtpFromChallanDate.Enabled = false;
                dtpToChallanDate.Enabled = false;
              //  rbCash.Checked = true;
                rbMarathi.Checked = true;
                dgvSaleItems.Enabled = false;
                lblCustomerGSTNo.Visible = false;
                txtGSTNo.Visible = false;
                //chkholeSale.Checked = false;
                cmbCustomerName.Focus();
                txtStateCode.Text = "27";
                cmbIGST.Text = "Maharashtra";
                cmbCustomerRetailer.SelectedIndex = 0;
                lblCreditAmount.Text = "0";
                isDelete = false;
                dgvSaleItems.Enabled = true;
                btnSave.Text = "जतन करा";
                saleReturnId = 0;
                IGST5 = 0; IGST12 = 0; IGST18 = 0; IGST28 = 0;
                if (dtpChallenDate.Value < Utility.firstDate || dtpChallenDate.Value > Utility.lastDate)
                {
                    dtpChallenDate.Value = Utility.firstDate;
                }
               // dtpChallenDate.Value = Utility.firstDate;
                dtpChallenDate.MinDate = dtpFromChallanDate.MinDate = dtpToChallanDate.MinDate = Utility.firstDate;
                dtpChallenDate.MaxDate = dtpFromChallanDate.MaxDate = dtpToChallanDate.MaxDate = Utility.lastDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    dgvSaleItems.CurrentRow.Cells["itemId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["salesReturnItemDetailsId"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["companyId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["categoryId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["batchNo"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["IGST"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["CGST"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["SGST"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["StockId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["Quantity"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["unitBy"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["Rate"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["discount"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = null;
                    dgvItemName.Hide();
                    return;
                }
                string value = null;
                if (dgvSaleItems.CurrentCell.ColumnIndex == 5)
                {
                    value = dgvSaleItems.CurrentRow.Cells["itemName"].Value.ToString();
                }
                else
                {
                    if (dgvSaleItems.CurrentCell.ColumnIndex == 7 || dgvSaleItems.CurrentCell.ColumnIndex == 9 || dgvSaleItems.CurrentCell.ColumnIndex == 10 || dgvSaleItems.CurrentCell.ColumnIndex == 12 || dgvSaleItems.CurrentCell.ColumnIndex == 14 || dgvSaleItems.CurrentCell.ColumnIndex == 16
                        || dgvSaleItems.CurrentCell.ColumnIndex == 17)
                    {
                        if (dgvSaleItems.CurrentRow.Cells["Quantity"].Value != null && dgvSaleItems.CurrentRow.Cells["Rate"].Value != null &&
                            dgvSaleItems.CurrentRow.Cells["IGST"].Value != null && dgvSaleItems.CurrentRow.Cells["SGST"].Value != null
                            && dgvSaleItems.CurrentRow.Cells["CGST"].Value != null && dgvSaleItems.CurrentRow.Cells["discount"].Value != null)
                        {
                            dgvSaleItems.CurrentRow.Cells["Quantity"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString());
                            // dgvSaleItems.CurrentRow.Cells["unitBy"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["unitBy"].Value.ToString());
                            dgvSaleItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString());
                            dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString());
                            dgvSaleItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString());
                            dgvSaleItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString());
                            dgvSaleItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString());
                            dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()), 2);
                            dgvItemName.Hide();
                            double purRate = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()));
                            if (cmbIGST.SelectedItem.ToString() != "Maharashtra")
                            {
                                dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString())) * purRate / 100), 2);

                            }
                            else
                            {
                                dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100), 2);
                                dgvSaleItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                                dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()))), 2);
                                dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString())), 2);

                            }

                            dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round((Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()))), 2);
                        }
                        else
                        {
                            dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = 0;
                        }
                    }
                }
                if (value != null)
                {
                    DataTable dtitem = null;
                    bool isWholeSale = false;
                    if (chkholeSale.Checked == true)
                    {
                        isWholeSale = true;
                    }
                    else
                    {
                        isWholeSale = false;
                    }
                    if (rbCash.Checked == true)
                    {
                        dtitem = salesReturnDetailsTempController.getStockInSaleReturnItemDetails(value, "cash", isWholeSale);
                    }
                    if (rbCredit.Checked == true)
                    {
                        dtitem = salesReturnDetailsTempController.getStockInSaleReturnItemDetails(value, "credit", isWholeSale);
                    }
                    if (dtitem.Rows.Count > 0)
                    {
                        dgvItemName.DataSource = dtitem;
                        dgvItemName.Columns[0].Visible = false;
                        dgvItemName.Columns[1].Width = 500;
                        dgvItemName.ClearSelection();
                        this.dgvItemName.CellBorderStyle = DataGridViewCellBorderStyle.None;
                        dgvItemName.Show();
                        //dgvItemName.CurrentCell = dgvItemName.Rows[0].Cells[1];
                    }

                }
                else
                {


                }
                //if (dgvSaleItems.CurrentRow.Cells["Quantity"].Value != null)
                //{
                //    if (dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString() != "0")
                //    {
                //        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString());
                //        dgvItemName.Hide();
                //        double discount = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["discount"].Value) * (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())) / 100);
                //        double purRate = (Convert.ToDouble(Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Quantity"].Value) * Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Rate"].Value) - discount));
                //        double vats = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["vat"].Value) * purRate / 100);
                //        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + vats).ToString();
                //    }
                //    else
                //    {
                //        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = "0";
                //    }
                //}

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
                    if (dgvSaleItems.Rows[i].Cells["totalAmount"].Value != null)
                    {
                        sum += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["totalAmount"].Value.ToString());
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
                txtNetAmount.Text = Math.Round(Convert.ToDouble(sum),2).ToString();
                string netamount = txtNetAmount.Text;
                if (rbCash.Checked == true)
                {
                    txtPaidAmount.Text = txtNetAmount.Text;
                    txtBalanceAmount.Text = "0";
                }
                if (rbCredit.Checked == true)
                {
                    if (txtNetAmount.Text != string.Empty && txtPaidAmount.Text != string.Empty)
                    {
                        txtBalanceAmount.Text = (Convert.ToDouble(Utility.ParseValue(txtNetAmount.Text)) - Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text))).ToString();
                    }
                    else
                    {
                        txtBalanceAmount.Text = netamount;
                    }
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
                    if (dgvSaleItems.CurrentRow.Cells["itemId"].Value == null)
                    {
                        dgvItemName.Focus();
                        dgvItemName.CurrentCell = dgvItemName.CurrentRow.Cells["itemName"];
                        dgvItemName.CurrentCell.Selected = true;
                    }
                    else
                    {
                        if (dgvSaleItems.CurrentRow.Cells["itemName"].Value != null)
                        {
                            if (row == dgvSaleItems.RowCount)
                            {
                                dgvSaleItems.Rows.Add();
                                dgvSaleItems.CurrentCell = dgvSaleItems[col + 5, row];
                            }
                            else if (dgvSaleItems.CurrentCell.ColumnIndex == 9)
                            {
                                dgvSaleItems.CurrentCell = dgvSaleItems[col + 2, row];
                            }
                            else
                            {
                                dgvSaleItems.CurrentCell = dgvSaleItems[col, row];
                            }
                        }
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
        Int32 rowToDelete;
        public int rowIndex = 0;
        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

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
        public double currentStock = 0;
        protected void getDataFronCurentRow(int rowIndex)
        {
            try
            {
                dgvItemName.Hide();
                DataGridViewRow row = this.dgvItemName.Rows[rowIndex];
                if (row.Cells != null)
                {
                    long StockId = Convert.ToInt64(dgvItemName.CurrentRow.Cells["itemId"].Value);
                    DataTable dt = itemDetailsController.getStockInItemDetailsbyStockId(StockId);

                    foreach (DataGridViewRow rows in dgvSaleItems.Rows)
                    {
                        if (rows.Cells["itemId"].Value != null && rows.Cells["companyId"].Value != null && rows.Cells["categoryId"].Value != null && rows.Cells["batchNo"].Value != null && rows.Cells["itemName"].Value != null)
                        {
                            if (rows.Cells["itemId"].Value.ToString().Equals(dt.Rows[0]["itemId"].ToString()) && rows.Cells["companyId"].Value.ToString().Equals(dt.Rows[0]["companyId"].ToString()) && rows.Cells["categoryId"].Value.ToString().Equals(dt.Rows[0]["categoryId"].ToString()) && rows.Cells["batchNo"].Value.ToString().Equals(dt.Rows[0]["batchNo"].ToString()) && rows.Cells["itemName"].Value.ToString().Equals(dt.Rows[0]["itemName"].ToString()))
                            {
                                MessageBox.Show("कृपया लिस्ट मध्ये माहिती आधीच उपलब्ध आहे !", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dgvSaleItems.Focus();
                                return;
                            }
                        }
                    }

                    dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dt.Rows[0]["itemId"]);
                    dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dt.Rows[0]["StockId"]);
                    dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dt.Rows[0]["categoryId"]);
                    dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dt.Rows[0]["companyId"]);
                    dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dt.Rows[0]["batchNo"]);
                    dgvSaleItems.CurrentRow.Cells["itemName"].Value = dt.Rows[0]["itemName"].ToString();
                    dgvSaleItems.CurrentRow.Cells["salesReturnItemDetailsId"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["Quantity"].Value = 1;
                    dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dt.Rows[0]["unitBy"].ToString();

                    if (rbCash.Checked == true)
                    {
                        dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dt.Rows[0]["salesCashRate"].ToString());
                    }
                    if (rbCredit.Checked == true)
                    {
                        dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dt.Rows[0]["salesCreditRate"].ToString());
                    }
                    dgvSaleItems.CurrentRow.Cells["discount"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["IGST"].Value = Math.Round(Utility.ParseValue(dt.Rows[0]["IGST"].ToString()), 2);
                    dgvSaleItems.CurrentRow.Cells["CGST"].Value = Math.Round(Utility.ParseValue(dt.Rows[0]["CGST"].ToString()), 2);
                    dgvSaleItems.CurrentRow.Cells["SGST"].Value = Math.Round(Utility.ParseValue(dt.Rows[0]["SGST"].ToString()), 2);

                    dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()));

                    // double discount = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["discount"].Value) * (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Rate"].Value)) / 100);
                    double purRate = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())));
                    // dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["SGST"].Value) * purRate / 100);
                    // dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["CGST"].Value) * purRate / 100);
                    //dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["IGST"].Value) * purRate / 100);


                    if (cmbIGST.SelectedItem.ToString() != "Maharashtra")
                    {
                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["IGST"].ToString()) * purRate / 100), 2);
                    }
                    else
                    {
                        dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["CGST"].ToString()) * purRate / 100), 2);
                        dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["SGST"].ToString()) * purRate / 100), 2);
                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString()), 2);
                    }

                    dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()))).ToString();
                    subtot();
                    //  dgvSaleItems.Focus();
                    dgvSaleItems.CurrentCell = dgvSaleItems.CurrentRow.Cells["Quantity"];
                    dgvSaleItems.BeginEdit(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvItemName_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int rowIndex = e.RowIndex;
                    getDataFronCurentRow(rowIndex);
                    rbMarathi.Checked = true;
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void dgvItemName_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

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

        private void dgvItemName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        int rowIndex = dgvItemName.CurrentCell.OwningRow.Index;
                        getDataFronCurentRow(rowIndex);
                        rbMarathi.Checked = true;
                    }
                    catch (Exception ae)
                    {
                        MessageBox.Show(ae.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmItemDetails frm = new frmItemDetails();
                frm.ShowDialog();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
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
                    lblChequeNo.Text = "     संदर्भक्रमांक ";
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
                    lblChequeNo.Text = "     संदर्भक्रमांक ";
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
                    lblChequeNo.Text = "     संदर्भक्रमांक ";
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
                    lblChequeNo.Text = "     संदर्भक्रमांक ";
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
                    lblChequeNo.Text = "चेक /डीडी क्रमांक";
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
                if (cmbCustomerName.Text == string.Empty || cmbCustomerName.SelectedValue == null)
                {
                    MessageBox.Show("कृपया ग्राहकाचे नाव भरा किवा निवडा..");
                    cmbCustomerName.Focus();
                    return;
                }
                for (int i = 0; i < dgvSaleItems.Rows.Count; i++)
                {
                    if (dgvSaleItems.Rows[i].Cells[5].Value == null)
                    {
                        MessageBox.Show("कृपया लिस्ट मध्ये वस्तूचे नाव भरा..");
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[5];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[6].Value == null)
                    {

                        MessageBox.Show("कृपया लिस्ट मध्ये बॅच नंबर भरा");
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[6];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[7].Value == null)
                    {
                        MessageBox.Show("कृपया लिस्ट मध्ये नग भरा");
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[7];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[8].Value == null)
                    {
                        dgvSaleItems.Rows[i].Cells[8].Value = "नग";
                    }
                    if (dgvSaleItems.Rows[i].Cells[9].Value == null)
                    {
                        MessageBox.Show("कृपया लिस्ट मध्ये दर भरा");
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[9];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[10].Value == null)
                    {
                        MessageBox.Show("कृपया लिस्ट मध्ये IGST (%) भरा");
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[10];
                        return;
                    }
                    //if (dgvSaleItems.Rows[i].Cells[9].Value == null )
                    //{
                    //    MessageBox.Show("कृपया लिस्ट मध्ये Tax(कर)% भरा");
                    //    dgvSaleItems.Focus();
                    //    dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[9];
                    //    return;
                    //}


                    if (dgvSaleItems.Rows[i].Cells[17].Value == null || Convert.ToDouble(dgvSaleItems.Rows[i].Cells[17].Value) == 0)
                    {
                        MessageBox.Show("कृपया लिस्ट मध्ये एकूण रक्कम भरा.");
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[17];
                        return;
                    }
                }
                if (cmbPaymentType.Text.Equals("Cheque"))
                {
                    if (cmbBank.Text.Equals("") || cmbBank.Text.Equals("0"))
                    {
                        MessageBox.Show("कृपया बँकचे नाव भरा...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbBank.Focus();
                        return;
                    }
                    else if (txtchqDDNo.Text.Equals("") || txtchqDDNo.Text.Equals("0"))
                    {
                        MessageBox.Show("कृपया चेक / डी.डी. क्रमांक  भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtchqDDNo.Focus();
                        return;
                    }
                }
                if (cmbPaymentType.Text.Equals("Card Payment"))
                {
                    if (cmbBank.Text.Equals("") || cmbBank.Text.Equals("0"))
                    {
                        MessageBox.Show("कृपया बँकचे नाव भरा...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbBank.Focus();
                        return;
                    }
                    else if (txtchqDDNo.Text.Equals("") || txtchqDDNo.Text.Equals("0"))
                    {
                        MessageBox.Show("कृपया चेक / डी.डी. क्रमांक  भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtchqDDNo.Focus();
                        return;
                    }
                }
                if (cmbPaymentType.Text.Equals("") || cmbPaymentType.Text.Equals("0"))
                {

                    MessageBox.Show("कृपया Payment प्रकार निवडा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbPaymentType.Focus();
                    return;
                }
                /// long customerId = 0;
                if (txtPaidAmount.Text == string.Empty)
                {
                    txtPaidAmount.Text = "0";
                }
                if (rbtnCredit.Checked == true)
                {
                    if (cmbCustomerName.Text == string.Empty || cmbCustomerName.Text == "-- Select --")
                    {
                        MessageBox.Show("कृपया ग्राहकाचे नाव निवडा..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbCustomerName.Focus();
                        return;
                    }
                    if (txtPaidAmount.Text == string.Empty)
                    {
                        MessageBox.Show("कृपया द्यावयाची रक्कम भरा", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPaidAmount.Focus();
                        return;
                    }
                }

                SalesReturnDetails purch = new SalesReturnDetails();
                string customerName1 = cmbCustomerName.Text.Trim();
                if (cmbCustomerName.SelectedValue == null)
                {
                    customerDetails customers = new customerDetails();
                    customers.customerId = 0;
                    customers.customerName = cmbCustomerName.Text.Trim();
                    customers.customerAddress = txtCustAddress.Text.Trim();
                    if (txtMobileNo.Text == "")
                    {
                        customers.customerMobileNo = "";
                    }
                    else
                    {
                        customers.customerMobileNo = Utility.ParseValueI(txtMobileNo.Text).ToString();
                    }
                    customers.DOB = DateTime.Now;
                    customers.genderId = "1";
                    customers.villageId = Convert.ToInt32(0);
                    customers.emailId = "";
                    customers.addedBy = Utility.LoginID;
                    customers.addedOn = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                    customers.CustomerGSTNo = txtGSTNo.Text.Trim();
                    customers.openigBalanace = Utility.ParseValue("0");
                    customers.fromDate = DateTime.Now;
                    customers.isCreditDebit = "";
                    // int s = customerController.addCustomerDetails(customers);
                    BindComboBoxgetCustomerName();
                    cmbCustomerName.Text = customerName1;
                    /// customerId = SaleDetailsController.getcustomerMaxId();
                    purch.customerId = Convert.ToInt64(cmbCustomerName.SelectedValue);
                }
                else
                {
                    purch.customerId = Convert.ToInt64(cmbCustomerName.SelectedValue);
                }

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
                            MessageBox.Show("कृपया लिस्ट मध्ये पूर्ण माहिती भरा");
                            return;
                        }

                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtSaleItems.Rows.Add(dRow);
                }

                purch.SaleRetrunItemTable = dtSaleItems;
                purch.salesReturnDate = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                if (txtSaleBillNo.Text == string.Empty)
                {
                    MessageBox.Show("कृपया विक्री बिल क्रमांक भरा.");
                    txtSaleBillNo.Focus();
                    return;
                }
                else
                {
                    purch.saleInvoiceNo = txtSaleBillNo.Text.Trim();
                }
                purch.saleDate = Convert.ToDateTime(dtpSaleIvoiceDate.Value.ToShortDateString());
                if (isDelete == false)
                {
                    purch.salesReturnInvoiceId = salesReturnDetailsTempController.getMaxIdSaleRetrunInvoiceId(Utility.FinancilaYearId).ToString();
                }
                else
                {
                    purch.salesReturnInvoiceId = txtInvoiceNo.Text;
                }
                purch.financialYearID = Utility.FinancilaYearId;
                // txtInvoiceNo.Text = salesReturnDetailsTempController.getMaxIdSaleRetrunInvoiceId().ToString();
                if (rbCash.Checked == true)
                {
                    purch.salesType = "Cash";
                }
                if (rbCredit.Checked == true)
                {
                    purch.salesType = "Credit";
                }
                purch.paymentType = cmbPaymentType.Text;
                purch.paidAmount = Utility.ParseValue(txtPaidAmount.Text);
                purch.totalbillAmount = Utility.ParseValue(txtNetAmount.Text);
                if (cmbPaymentType.Text == "Cash")
                {
                    purch.chequeDate = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                }
                else
                {
                    purch.chequeDate = Convert.ToDateTime(dtpchedate.Value.ToShortDateString());
                }
                purch.bankName = cmbBank.Text;
                purch.state = cmbIGST.Text;
                purch.stateCode = txtStateCode.Text;
                purch.isCustomerRetailer = cmbCustomerRetailer.Text;
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
                    purch.addedOn= Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                    PusrchaseSaleAccount purchase = new PusrchaseSaleAccount();
                    purchase.RoundOff = Convert.ToDouble(txtRoundOff.Text);
                    purchase.Hamali = Convert.ToDouble(0);
                    purchase.discount = Convert.ToDouble(0);
                    purchase.billId = Convert.ToInt64(purch.salesReturnInvoiceId);
                    purchase.stateCode = txtStateCode.Text;
                    purchase.issalePurchase = "sale";
                    purchase.Igst5 = IGST5;
                    purchase.Igst12 = IGST12;
                    purchase.Igst18 = IGST18;
                    purchase.Igst28 = IGST28;
                    purchase.salePurchaseAccount = Math.Round(Convert.ToDouble(txtNetAmount.Text) - (IGST5 + IGST12 + IGST18 + IGST28), 2);

                    int ks = salesReturnDetailsTempController.addSalesRetrunDetails(purch);
                if (ks > 0)
                {
                    if (purch.isDelete == false)
                    {
                        MessageBox.Show("माहिती यशस्वीरित्या भरली गेली", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("माहिती यशस्वीरित्या डिलीट केली गेली", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCash.Checked == true)
                {
                    lblBakiAmount.Enabled = false;
                    lblPaidAmount.Enabled = false;
                    txtPaidAmount.Enabled = false;
                    txtBalanceAmount.Enabled = false;
                    subtot();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbtnCredit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCredit.Checked == true)
                {
                    lblBakiAmount.Enabled = true;
                    lblPaidAmount.Enabled = true;
                    txtPaidAmount.Enabled = true;
                    txtBalanceAmount.Enabled = true;
                    subtot();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double checkpaidamount = 0;
                double checkbillamount = 0;
                string netamount = txtNetAmount.Text;
                if (rbCash.Checked == true)
                {
                    txtPaidAmount.Text = txtNetAmount.Text;
                    txtBalanceAmount.Text = "0";

                }
                if (rbCredit.Checked == true)
                {
                    if (txtNetAmount.Text != string.Empty && txtPaidAmount.Text != string.Empty)
                    {
                        checkpaidamount = Utility.ParseValue(txtPaidAmount.Text);
                        checkbillamount = Utility.ParseValue(txtNetAmount.Text);
                        if (checkbillamount < checkpaidamount)
                        {
                            MessageBox.Show("कृपया एकूण रक्कम तपासा ..");
                            txtPaidAmount.Text = "";
                            txtNetAmount.Text = checkbillamount.ToString();
                            txtBalanceAmount.Text = checkbillamount.ToString();
                        }
                        else
                        {
                            txtBalanceAmount.Text = (Convert.ToDouble(Utility.ParseValue(txtNetAmount.Text)+Convert.ToDouble(txtRoundOff.Text)) - Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text))).ToString();
                        }
                    }
                    else
                    {
                        txtBalanceAmount.Text = netamount;
                        txtPaidAmount.Text = "";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSaleInvoive_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.Insert)
                {
                    frmItemDetails frm = new frmItemDetails();
                    frm.ShowDialog();
                }
                if (e.KeyCode == Keys.Home)
                {
                    try
                    {
                        Utility.ClearSpace(this);
                        Utility.enableFields(this);
                        btnSave.Enabled = true;
                        BindComboBoxgetCustomerName();
                        cmbPaymentType.SelectedIndex = 0;
                        txtInvoiceNo.Text = SaleDetailsController.getMaxIdSaleInvoiceId(Utility.FinancilaYearId).ToString();
                        dgvItemName.Hide();
                        dgvSaleItems.Rows.Clear();
                        dgvSaleItems.Rows.Add();
                        rbCash.Checked = true;
                        rbMarathi.Checked = true;
                        dgvSaleItems.Enabled = true;
                        cmbCustomerName.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerDetails frm = new frmCustomerDetails();
            frm.ShowDialog();
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
                        txtMobileNo.Text = info.Rows[0]["customerMobileNo"].ToString();
                        txtCustAddress.Text = info.Rows[0]["customerAddress"].ToString();
                        txtGSTNo.Text = info.Rows[0]["CustomerGSTNo"].ToString();
                        lblCreditAmount.Text = Math.Round(accountDetailsController.GetDueAmount(id, "customer", Utility.FinancilaYearId,Convert.ToDateTime(dtpChallenDate.Value))).ToString();
                    }
                }
                else
                {
                    //  txtmobile.Text = "";
                    txtaddress.Text = "";
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
        public static string SaleID = "";
        public void bill()
        {
            //try
            //{
            //    SaleID = txtInvoiceNo.Text;
            //    DataTable dtSale = ReportController.getSaleInvoice(txtInvoiceNo.Text);
            //    frmSaleBill rp = new frmSaleBill();
            //    string path = ConfigurationManager.AppSettings["Path"];
            //    LocalReport rrd = new LocalReport();
            //    if (rbMarathi.Checked == true)
            //    {
            //        rp.reportViewer1.LocalReport.ReportPath = path + @"\saleBill.rdlc";
            //    }
            //    if (rbEnglish.Checked == true)
            //    {
            //        rp.reportViewer1.LocalReport.ReportPath = path + @"\saleBillEnglish.rdlc";
            //    }
            //    ReportDataSource datasource = new ReportDataSource("Sale", dtSale);
            //    rp.reportViewer1.LocalReport.DataSources.Clear();
            //    rp.reportViewer1.LocalReport.DataSources.Add(datasource);
            //    rp.reportViewer1.RefreshReport();
            //    rp.Refresh();
            //    rp.ShowDialog();



            //}
            //catch (Exception ae)
            //{
            //    throw ae;
            //}
        }

        private void rbMarathi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtmobile.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtmobile.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtPaidAmount.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtPaidAmount.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
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
                if (dgvSaleItems.CurrentCell.ColumnIndex == 6 || dgvSaleItems.CurrentCell.ColumnIndex == 8 || dgvSaleItems.CurrentCell.ColumnIndex == 9 || dgvSaleItems.CurrentCell.ColumnIndex == 10 || dgvSaleItems.CurrentCell.ColumnIndex == 12 || dgvSaleItems.CurrentCell.ColumnIndex == 14) //Desired Column
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

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMobileNo.Text != string.Empty)
                {

                    DataTable dt = customerController.getAccountNameSerachMobileNo(Utility.ParseValueI(txtmobile.Text).ToString());
                    if (dt.Rows.Count > 0)
                    {
                        cmbCustomerName.Text = dt.Rows[0]["customerName"].ToString();
                    }
                    else
                    {
                        //if (cmbCustomerName.Text == "")
                        //{
                        //    BindComboBoxgetCustomerName();
                        //}

                    }
                }
                else
                {

                    BindComboBoxgetCustomerName();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPaidAmount_Leave(object sender, EventArgs e)
        {

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
                }
                else
                {
                    dgvSaleItems.Columns["IGST"].Visible = false;
                    dgvSaleItems.Columns["IGSTAmt"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            frmCustomerDetails frm = new frmCustomerDetails();
            frm.ShowDialog();
        }

        private void lblCreditAmount_Click(object sender, EventArgs e)
        {
            try
            {
                new frmAccountWiseUdhari(Convert.ToInt64(cmbCustomerName.SelectedValue), cmbCustomerName.Text, "AllcustomerWise").ShowDialog();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void chkholeSale_CheckedChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (chkholeSale.Checked == true)
            //    {
            //        lblCustomerGSTNo.Visible = true;
            //        txtGSTNo.Visible = true;
            //    }
            //    else
            //    {
            //        lblCustomerGSTNo.Visible = false;
            //        txtGSTNo.Visible = false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void FrmSaleReturn_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.B && e.Alt)
                {
                    FrmSaleReturnBook frm = new FrmSaleReturnBook();
                    frm.ShowDialog();
                }
                if (e.KeyCode == Keys.N && e.Alt)
                {
                    btnnew_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && e.Alt)
                {
                    btnSave_Click(sender,e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnklblSaleReturnBook_Click(object sender, EventArgs e)
        {
            FrmTempSaleReturnBook frm = new FrmTempSaleReturnBook();
            frm.ShowDialog();
        }

        private void txtNetAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtNetAmount.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtNetAmount.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCustomerRetailer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = customerController.getCustomerRetailerDetails(cmbCustomerRetailer.Text);
                Utility.BindComboBoxEmptyDataSelect(cmbCustomerName, dt, "customerId", "customerName");


                if (cmbCustomerRetailer.SelectedIndex == 0)
                {
                    lblCustomerGSTNo.Visible = false;
                    txtGSTNo.Visible = false;
                }
                else
                {
                    lblCustomerGSTNo.Visible = true;
                    txtGSTNo.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void deleteRowToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                grbSaleInvice.Visible = true;
                dtpFromChallanDate.Enabled = true;
                dtpToChallanDate.Enabled = true;
                DataTable dtSaleInvoice = salesReturnDetailsTempController.getSaleReturnIvoiceList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);
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
                DataTable dtSaleInvoice = salesReturnDetailsTempController.getSaleReturnIvoiceList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);
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
                long salesInvoiceId = 0;
                if (e.RowIndex >= 0)
                {
                    salesInvoiceId = Convert.ToInt64(dgvSaleInvoice.CurrentRow.Cells["salesReturnId"].Value);
                }
                BindData(salesInvoiceId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindData(long salesInvoiceId)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                btnSave.Text = "डिलीट";
                grbSaleInvice.Visible = false;
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                dgvSaleItems.Enabled = true;
                isDelete = true;
                IGST5 = 0; IGST12 = 0; IGST18 = 0; IGST28 = 0;
                DataTable dtSaleChallen = salesReturnDetailsTempController.getsaleReturnDetails(salesInvoiceId, Utility.FinancilaYearId);
                saleReturnId = Convert.ToInt64(dtSaleChallen.Rows[0]["salesReturnId"].ToString());
                txtInvoiceNo.Text = dtSaleChallen.Rows[0]["salesReturnInvoiceId"].ToString();
                dtpChallenDate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["salesReturnDate"].ToString());
                cmbCustomerRetailer.Text = Convert.ToString(dtSaleChallen.Rows[0]["isCustomerRetailer"]);
                BindComboBoxgetCustomerName();
                cmbCustomerName.Text = dtSaleChallen.Rows[0]["customerName"].ToString();
                txtaddress.Text = dtSaleChallen.Rows[0]["customerAddress"].ToString();
                txtmobile.Text = dtSaleChallen.Rows[0]["customerMobileNo"].ToString();
                cmbPaymentType.Text = dtSaleChallen.Rows[0]["paymentType"].ToString();
                cmbBank.Text = dtSaleChallen.Rows[0]["bankName"].ToString();
                txtchqDDNo.Text = dtSaleChallen.Rows[0]["chequeNo_refNo"].ToString();
                cmbGST.Text = dtSaleChallen.Rows[0]["state"].ToString();
                txtStateCode.Text = dtSaleChallen.Rows[0]["stateCode"].ToString();
                dtpchedate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["chequeDate"].ToString());
                cmbCustomerName.Enabled = false;
                txtCustAddress.Enabled = false;
                txtmobile.Enabled = false;
                if (dtSaleChallen.Rows[0]["salesType"].ToString() == "Cash")
                {
                    rbtnCash.Checked = true;
                }
                if (dtSaleChallen.Rows[0]["salesType"].ToString() == "Credit")
                {
                    rbtnCredit.Checked = true;
                }

                txtNetAmount.Text = dtSaleChallen.Rows[0]["totalbillAmount"].ToString();
                txtPaidAmount.Text = dtSaleChallen.Rows[0]["paidAmount"].ToString();
                txtSaleBillNo.Text = dtSaleChallen.Rows[0]["saleInvoiceNo"].ToString();
                dtpSaleIvoiceDate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["saleDate"]);
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                foreach (DataRow dr in dtSaleChallen.Rows)
                {
                    dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                    dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dr["StockId"]);
                    dgvSaleItems.CurrentRow.Cells["salesReturnItemDetailsId"].Value = Convert.ToInt32(dr["salesReturnItemDetailsId"]);
                    dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                    dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                    dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                    dgvSaleItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                    dgvSaleItems.CurrentRow.Cells["Quantity"].Value = Convert.ToDouble(dr["quantity"]);
                    dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                    dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dr["perQtysalePrice"].ToString());
                    dgvSaleItems.CurrentRow.Cells["discount"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["IGST"].Value = Math.Round(Utility.ParseValue(dr["IGST"].ToString()), 2);
                    dgvSaleItems.CurrentRow.Cells["CGST"].Value = Math.Round(Utility.ParseValue(dr["CGST"].ToString()), 2);
                    dgvSaleItems.CurrentRow.Cells["SGST"].Value = Math.Round(Utility.ParseValue(dr["SGST"].ToString()), 2);

                    dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()));

                    double purRate = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())));
                   
                        dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dr["CGST"].ToString()) * purRate / 100), 2);
                        dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dr["SGST"].ToString()) * purRate / 100), 2);
                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString()), 2);
                  
                    dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()))).ToString();

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
                            dgvSaleItems.CurrentCell = dgvSaleItems[col + 8, row];
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

        private void txtNetAmount_TextChanged(object sender, EventArgs e)
        {
            try
                {
                    if (txtNetAmount.Text.ToString() != String.Empty)
                    {
                        double netAmt = Math.Round(Convert.ToDouble(txtNetAmount.Text), 2);
                        txtRoundOff.Text = (Math.Round(Math.Round(Convert.ToDouble(txtNetAmount.Text), 0) - netAmt, 2)).ToString();
                       // txtDiscount.Text = "0";
                        //  txtTotalAmount.Text = Math.Round(Convert.ToDouble(txtNetAmount.Text), 0).ToString();
                        //txtDiscount_TextChanged(sender, e);
                    }
                    else
                    {
                        txtPaidAmount.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           
        }

        private void txtRoundOff_TextChanged(object sender, EventArgs e)
        {
            if(txtRoundOff.Text!=string.Empty)
            {
                if(rbCash.Checked==true)
                {
                    txtPaidAmount.Text = Math.Round(Convert.ToDouble(txtNetAmount.Text) + Convert.ToDouble(txtRoundOff.Text),2).ToString();
                }
                if(rbCredit.Checked==true)
                {
                    txtPaidAmount.Text = "0";
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnklblSaleReturnBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmTempSaleReturnBook frm = new FrmTempSaleReturnBook();
            frm.ShowDialog();
        }
    }
}
