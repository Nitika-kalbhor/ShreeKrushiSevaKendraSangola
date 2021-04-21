using DataAccessLayer.controller;
using DataAccessLayer.models;
using Dlogic_Wholesaler.CrystalReport;
using Dlogic_Wholesaler.ReportFrom;
using Dlogic_Wholesaler.TempFroms;
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
    public partial class frmSaleChallan : MetroForm
    {
        public frmSaleChallan()
        {
            InitializeComponent();
        }
        long salesInvoiceId = 0;
        private bool isUpdate = false;
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Sale Chalan";
                    metroLabel2.Text = "Bill No:";
                    metroLabel1.Text = "Date:";
                    lblstockInNo.Text = "Customer Name:";
                    metroLabel3.Text = "Mobile No:";
                    metroLabel4.Text = "Address:";
                    label4.Text = "* Entry In this Form will make change In Stock Details.";
                    chkholeSale.Text = "Wholsale";
                    rbtnCash.Text = "Cash";
                    rbtnCredit.Text = "Credit";     
                    label1.Text = "Other Amt:";
                    label8.Text = "Sale State:";
                    label7.Text = "Code:";
                    label17.Text = "Customer/Retailer:";
                    lblNetBill.Text = "Total Amount:";
                    lblCustomerGSTNo.Text = "GST No:";
                    lblBakiAmount.Text = "Pending Amount:";
                    btnDelete.Text = "Delete";
                    btnChallanList.Text = "Sale Chalan List";
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    label2.Text = "From Date:";
                    label3.Text = "To Date:";
                    btnShow.Text = "Show";               
                    
                    dgvSaleItems.Columns[4].HeaderText = "Naration";
                    dgvSaleItems.Columns[5].HeaderText = "HSNCode";
                    dgvSaleItems.Columns[6].HeaderText = "BatchNo";
                    dgvSaleItems.Columns[7].HeaderText = "Qty";
                    dgvSaleItems.Columns[8].HeaderText = "UnitBy";
                    dgvSaleItems.Columns[9].HeaderText = "Rate";
                    dgvSaleItems.Columns[10].HeaderText = "GST(%)";
                    dgvSaleItems.Columns[11].HeaderText = "GSTAmt";
                    dgvSaleItems.Columns[12].HeaderText = "CGST(%)";
                    dgvSaleItems.Columns[13].HeaderText = "CGST Amt";
                    dgvSaleItems.Columns[14].HeaderText = "SGST(%)";
                    dgvSaleItems.Columns[15].HeaderText = "SGSTAmt";
                    dgvSaleItems.Columns[16].HeaderText = "Discount";
                    dgvSaleItems.Columns[17].HeaderText = "Amount";
                    dgvSaleItems.Columns[18].HeaderText = "salesChallanItemDetailsId";
                  
                    dgvSaleChallan.Columns[0].HeaderText = "Chalan No.";
                    dgvSaleChallan.Columns[1].HeaderText = "Customer Name";
                    dgvSaleChallan.Columns[2].HeaderText = "Date";
                    dgvSaleChallan.Columns[3].HeaderText = "Amount";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmSaleChallan_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                dgvSaleItems.Rows.Add();
                isUpdate = false;
                //BindComboBoxgetCustomerName();
                dgvItemName.Hide();
                rbtnCash.Checked = true;
                cmbGST.SelectedIndex = 0;
                dgvSaleItems.Enabled = false;
                dtpChallenDate.MinDate = Utility.firstDate;
                dtpChallenDate.MaxDate = Utility.lastDate;
                dtpFromChallanDate.MinDate = dtpToChallanDate.MinDate = Utility.firstDate;
                dtpFromChallanDate.MaxDate = dtpToChallanDate.MaxDate = Utility.lastDate;
                Lang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BindComboBoxgetCustomerName()
        {
            DataTable dtCustomerName = customerController.getCustomerDetails();
            Utility.BindComboBoxEmptyDataSelect(cmbCustomerName, dtCustomerName, "customerId", "customerName");
        }

      
        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                dtpChallenDate.MinDate = Utility.firstDate;
                dtpChallenDate.MaxDate = Utility.lastDate;
                dtpFromChallanDate.MinDate = dtpToChallanDate.MinDate = Utility.firstDate;
                dtpFromChallanDate.MaxDate = dtpToChallanDate.MaxDate = Utility.lastDate;
                //BindComboBoxgetCustomerName();
                btnDelete.Enabled = false;
                txtInvoiceNo.Text = SaleDetailsController.getMaxIdSaleChallanInvoiceId(Utility.FinancilaYearId).ToString();
                grbItemName.Visible = false;
                dgvItemName.Hide();
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                rbtnCash.Checked = true;
                dgvSaleItems.Enabled = false;
                salesInvoiceId = 0;
                cmbCustomerName.Focus();
                grbChallanList.Visible = false;
                lblCustomerGSTNo.Visible = false;
                txtGSTNo.Visible = false;
                chkholeSale.Checked = false;
                isDelete = false;
                isUpdate = false;
                cmbGST.Text = "Maharashtra";
                cmbCustomerRetailer.Text = "Customer";
                txtStateCode.Text = "27";
                dgvSaleChallan.DataSource = SaleDetailsController.getChallenList(dtpFromChallanDate.Value, dtpToChallanDate.Value,Utility.FinancilaYearId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvSaleItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void tb_TextChanged(Object sender, EventArgs e)
        {
            try
            {
                if (dgvSaleItems.CurrentRow.Cells["itemName"].Value == null)
                {
                    dgvSaleItems.CurrentRow.Cells["itemId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["salesChallanItemDetailsId"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["companyId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["categoryId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["HSNCode"].Value = null;
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
                if (dgvSaleItems.CurrentCell.ColumnIndex == 4)
                {
                    value = dgvSaleItems.CurrentRow.Cells["itemName"].Value.ToString();
                }
                else
                {
                    if (dgvSaleItems.CurrentCell.ColumnIndex == 7 || dgvSaleItems.CurrentCell.ColumnIndex == 9 || dgvSaleItems.CurrentCell.ColumnIndex == 10 || dgvSaleItems.CurrentCell.ColumnIndex == 12 || dgvSaleItems.CurrentCell.ColumnIndex == 14 || dgvSaleItems.CurrentCell.ColumnIndex == 16
                        || dgvSaleItems.CurrentCell.ColumnIndex == 17)
                    {
                        if (dgvSaleItems.CurrentRow.Cells["Quantity"].Value != null && dgvSaleItems.CurrentRow.Cells["Rate"].Value != null && dgvSaleItems.CurrentRow.Cells["discount"].Value != null
                            && dgvSaleItems.CurrentRow.Cells["IGST"].Value != null && dgvSaleItems.CurrentRow.Cells["CGST"].Value != null && dgvSaleItems.CurrentRow.Cells["SGST"].Value != null)
                        {
                            // dgvSaleItems.CurrentRow.Cells["HNSCode"].Value = dgvSaleItems.CurrentRow.Cells["HNSCode"].Value.ToString();
                            // dgvSaleItems.CurrentRow.Cells["batchNo"].Value = dgvSaleItems.CurrentRow.Cells["batchNo"].Value.ToString();
                            dgvSaleItems.CurrentRow.Cells["Quantity"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString());
                            // dgvSaleItems.CurrentRow.Cells["unitBy"].Value =dgvSaleItems.CurrentRow.Cells["unitBy"].Value.ToString();
                            dgvSaleItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString());
                            dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString());
                            dgvSaleItems.CurrentRow.Cells["IGST"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()), 2);
                            dgvSaleItems.CurrentRow.Cells["CGST"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString()),2);
                            dgvSaleItems.CurrentRow.Cells["SGST"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString()),2);
                            dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()),2);
                            dgvItemName.Hide();
                            double purRate = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()));
                            if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                            {
                                dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString())) * purRate / 100),2);
                                dgvSaleItems.CurrentRow.Cells["CGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString())) / 2);
                                dgvSaleItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                                dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100),2);
                                dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()))),2);
                            }
                            else
                            {
                                dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100),2);
                                dgvSaleItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                                dgvSaleItems.CurrentRow.Cells["IGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * 2);
                                dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()))),2);
                                dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString()),2);

                            }
                            // double discount = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())) / 100);

                            // dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100);
                            dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString())));
                        }
                        else
                        {
                            dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = 0;
                        }
                    }
                }
                if (value != null)
                {
                    bool isWholeSale = false;
                    if (chkholeSale.Checked == true)
                    {
                        isWholeSale = true;
                    }
                    else
                    {
                        isWholeSale = false;
                    }
                    DataTable dtitem = null;
                    if (rbtnCash.Checked == true)
                    {
                        dtitem = SaleDetailsController.getStockInSaleItemDetails(value, "cash",isWholeSale);
                    }
                    if (rbtnCredit.Checked == true)
                    {
                        dtitem = SaleDetailsController.getStockInSaleItemDetails(value, "credit", isWholeSale);
                    }
                    if (dtitem.Rows.Count > 0)
                    {
                        dgvItemName.DataSource = dtitem;
                        dgvItemName.Columns[0].Visible = false;
                        dgvItemName.Columns[1].Width = 500;
                        dgvItemName.ClearSelection();
                        this.dgvItemName.CellBorderStyle = DataGridViewCellBorderStyle.None;
                        grbItemName.Visible = true;
                        dgvItemName.Show();
                        grbChallanList.Visible = false;
                        //dgvSaleChallan.DataSource = null;
                    }

                }
                else
                {


                }
                subtot();
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
                    if (col < dgvSaleItems.ColumnCount - 2)
                    {
                        col++;
                    }
                    else
                    {
                        col = 0;
                        row++;
                    } if (dgvSaleItems.CurrentRow.Cells["itemId"].Value == null)
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
                                dgvSaleItems.CurrentCell = dgvSaleItems[col + 4, row];
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
            try
            {
                if (isUpdate == true)
                {
                    if (dgvSaleItems.CurrentRow.Cells["itemId"].Value != null)
                    {
                        SaleDetailsController.deleteRow(Convert.ToInt64(txtInvoiceNo.Text),
                            Convert.ToInt64(dgvSaleItems.Rows[rowIndex].Cells["salesChallanItemDetailsId"].Value),
                            Convert.ToInt64(dgvSaleItems.Rows[rowIndex].Cells["itemId"].Value), 
                            Convert.ToInt64(dgvSaleItems.Rows[rowIndex].Cells["categoryId"].Value), 
                            Convert.ToInt64(dgvSaleItems.Rows[rowIndex].Cells["companyId"].Value),
                            Convert.ToString(dgvSaleItems.Rows[rowIndex].Cells["batchNo"].Value),
                         Utility.ParseValue(dgvSaleItems.Rows[rowIndex].Cells["Quantity"].Value.ToString())
                         , Convert.ToInt64(dgvSaleItems.Rows[rowIndex].Cells["StockId"].Value));
                    }
                }
                rowToDelete = dgvSaleItems.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                dgvSaleItems.Rows.RemoveAt(rowToDelete);
                dgvSaleItems.ClearSelection();
                if (dgvSaleItems.Rows.Count == 0)
                {
                    dgvSaleItems.Rows.Clear();
                    dgvSaleItems.Rows.Add();
                }
                subtot();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            catch(Exception ex)
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
                    bindSaleItem(StockId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void bindSaleItem(long StockId)
        {
            try
            {
                DataTable dt = itemDetailsController.getStockInItemDetailsbyStockId(StockId);
                foreach (DataGridViewRow rows in dgvSaleItems.Rows)
                {
                    if (rows.Cells["itemId"].Value != null && rows.Cells["companyId"].Value != null && rows.Cells["categoryId"].Value != null && rows.Cells["batchNo"].Value != null && rows.Cells["itemName"].Value != null)
                    {
                        if (rows.Cells["itemId"].Value.ToString().Equals(dt.Rows[0]["itemId"].ToString()) && rows.Cells["companyId"].Value.ToString().Equals(dt.Rows[0]["companyId"].ToString()) && rows.Cells["categoryId"].Value.ToString().Equals(dt.Rows[0]["categoryId"].ToString()) && rows.Cells["batchNo"].Value.ToString().Equals(dt.Rows[0]["batchNo"].ToString()) && rows.Cells["itemName"].Value.ToString().Equals(dt.Rows[0]["itemName"].ToString()))
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("This Details are available already in list !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("कृपया माहिती लिस्ट मध्ये आधीच उपलब्ध आहे !", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                             dgvSaleItems.Focus();
                            return;
                        }
                    }
                }
                dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dt.Rows[0]["itemId"]);
                dgvSaleItems.CurrentRow.Cells["salesChallanItemDetailsId"].Value = Convert.ToInt64(0);
                dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dt.Rows[0]["StockId"]);
                dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dt.Rows[0]["categoryId"]);
                dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dt.Rows[0]["companyId"]);
                dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dt.Rows[0]["batchNo"]);
                dgvSaleItems.CurrentRow.Cells["itemName"].Value = dt.Rows[0]["itemName"].ToString();
                dgvSaleItems.CurrentRow.Cells["HSNCode"].Value = dt.Rows[0]["HNSCode"].ToString();
                dgvSaleItems.CurrentRow.Cells["Quantity"].Value = 1;
                dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dt.Rows[0]["unitBy"].ToString();

                if (rbtnCash.Checked == true)
                {
                    dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dt.Rows[0]["salesCashRate"].ToString());
                }
                if (rbtnCredit.Checked == true)
                {
                    dgvSaleItems.CurrentRow.Cells["Rate"].Value = Utility.ParseValue(dt.Rows[0]["salesCreditRate"].ToString());
                }
                dgvSaleItems.CurrentRow.Cells["discount"].Value = 0;
                dgvSaleItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dt.Rows[0]["IGST"].ToString());
                dgvSaleItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dt.Rows[0]["CGST"].ToString());
                dgvSaleItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dt.Rows[0]["SGST"].ToString());

                dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()),2);

                double discount = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())) / 100);
                double purRate = (Convert.ToDouble(Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Quantity"].Value) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())));
                dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100),2);
                dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100),2);
                dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100),2);


                //if (cmbGST.SelectedItem.ToString() == "Other")
                //{
                //    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dt.Rows[0]["IGST"].ToString()) * purRate / 100);
                //}
                //else
                //{
                //    dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dt.Rows[0]["CGST"].ToString()) * purRate / 100);
                //    dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dt.Rows[0]["SGST"].ToString()) * purRate / 100);
                //    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());
                //}

                dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString())),2).ToString();
                subtot();
                //  dgvSaleItems.Focus();
                dgvSaleItems.CurrentCell = dgvSaleItems.CurrentRow.Cells["Quantity"];
                dgvSaleItems.BeginEdit(true);
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
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

        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomerName.Text == string.Empty || cmbCustomerName.SelectedValue == null)
                {
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Add Customer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया ग्राहकाचे नाव भरा", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmbCustomerName.Focus();
                    return;
                }
                for (int i = 0; i < dgvSaleItems.Rows.Count; i++)
                {
                    if (dgvSaleItems.Rows[i].Cells[4].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Item Name in List..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये वस्तूचे नाव भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[4];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[5].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add HSNCode in List..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये HSN कोड भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[5];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[6].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add Batch no.in List..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये वस्तूचा बॉच नं. भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[6];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[7].Value == null)
                    {

                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add item Quantity in List..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये वस्तूचे नग भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Rate in list..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये दर भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[9];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[10].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add IGST (%) in List..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये  IGST (%) भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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


                    if (dgvSaleItems.Rows[i].Cells[16].Value == null || Utility.ParseValue(dgvSaleItems.Rows[i].Cells[17].Value.ToString()) == 0)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Total Amount in List..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये एकूण रक्कम भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[17];
                        return;
                    }
                }
              
                /// long customerId = 0;

                if (rbtnCredit.Checked == true)
                {
                    if (cmbCustomerName.Text == string.Empty || cmbCustomerName.Text == "-- Select --")
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Customer Name..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया ग्राहकाचे नाव भरा..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cmbCustomerName.Focus();
                        return;
                    }
                    //if (txtPaidAmount.Text == string.Empty)
                    //{
                    //    MessageBox.Show("कृपया  नाव भरा..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    txtPaidAmount.Focus();
                    //    return;
                    //}
                }

                SalesDetails saleChallan = new SalesDetails();
                string customerName1 = cmbCustomerName.Text.Trim();
                if (cmbCustomerName.SelectedValue == null)
                {
                    customerDetails customers = new customerDetails();
                    customers.customerId = 0;
                    customers.customerName = cmbCustomerName.Text.Trim();
                    customers.customerAddress = txtaddress.Text.Trim();
                    if (txtmobile.Text == "")
                    {
                        customers.customerMobileNo = "";
                    }
                    else
                    {
                        customers.customerMobileNo = Utility.ParseValueI(txtmobile.Text).ToString();
                    }
                    customers.DOB = DateTime.Now;
                    customers.genderId = "1";
                    customers.villageId = Convert.ToInt32(0);
                    customers.emailId = "";
                    customers.addedBy = 1;
                    customers.addedOn = DateTime.Now;
                    customers.openigBalanace = Utility.ParseValue("0");
                    customers.CustomerGSTNo = txtGSTNo.Text.Trim();
                    customers.fromDate = DateTime.Now;
                    customers.isCreditDebit = "";
                    int s = customerController.addCustomerDetails(customers);
                    //BindComboBoxgetCustomerName();
                    cmbCustomerName.Text = customerName1;
                    //  customerId = SaleDetailsController.getcustomerMaxId();
                    saleChallan.customerId = Convert.ToInt64(cmbCustomerName.SelectedValue);
                }
                else
                {
                    saleChallan.customerId = Convert.ToInt64(cmbCustomerName.SelectedValue);
                }

                DataTable dtSaleItems = new DataTable();
                saleChallan.FinancialYearID = Utility.FinancilaYearId;

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
                                MessageBox.Show("Please Fill all details in list");
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

                saleChallan.SaleItemTable = dtSaleItems;
                saleChallan.salesDate = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                saleChallan.isState=isState;
                if (isUpdate == false)
                {
                    saleChallan.salesInvoiceId = SaleDetailsController.getMaxIdSaleChallanInvoiceId(Utility.FinancilaYearId).ToString();
                }
                else
                {
                    saleChallan.salesInvoiceId = txtInvoiceNo.Text.ToString();
                }
                salesInvoiceId = Convert.ToInt64(saleChallan.salesInvoiceId);
                salesInvoiceId = Convert.ToInt64(saleChallan.salesInvoiceId); 
                saleChallan.isRetailer = Convert.ToBoolean(cmbCustomerRetailer.SelectedIndex);
                saleChallan.state = cmbGST.Text;
                saleChallan.stateCode = txtStateCode.Text;

                if (rbtnCash.Checked == true)
                {
                    saleChallan.salesType = "Cash";
                }
                if (rbtnCredit.Checked == true)
                {
                    saleChallan.salesType = "Credit";
                }
                if (txtPaidAmount.Text==string.Empty)
                {
                    saleChallan.paidAmount=0;
                }
                else
                {
                    saleChallan.paidAmount = Utility.ParseValue(txtPaidAmount.Text);
                }
                saleChallan.totalbillAmount = Utility.ParseValue(txtNetAmount.Text);
                saleChallan.addedBy = Utility.LoginID;
                saleChallan.addedOn = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                int ks = 0;
                if(isDelete==true)
                {
                    DialogResult dr = DialogResult.No;
                    if (Utility.Langn == "English")
                    {
                        dr = MessageBox.Show("Do you want to delete this chalan ?", "Confirmation", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        dr = MessageBox.Show("तुम्हाला सदर चलन डिलीट करायाचे आहे काय ?", "Confirmation", MessageBoxButtons.YesNo);
                    }
                    if (dr == DialogResult.Yes)
                    {
                        saleChallan.isDelete = true;
                        ks = SaleDetailsController.addSalesChallanDetails(saleChallan);
                    }
                    else if (dr == DialogResult.No)
                    {
                        //Nothing to do
                    }
                    if(ks>0)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("This chalan deleted successfully... !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("सदर चलन यशस्वीरित्या डिलीट केले गेले आहे ... !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        btnnew_Click(sender, e);
                    }
                }
                else if (isDelete == false)
                {
                    saleChallan.isDelete = false;
                    ks = SaleDetailsController.addSalesChallanDetails(saleChallan);
                    if (ks > 0)
                    {

                        DialogResult dr = DialogResult.No;
                        if (Utility.Langn == "English")
                        {
                            dr = MessageBox.Show("Do you want to print this bill?", "Print", MessageBoxButtons.YesNo);
                        }
                        else
                        {
                            dr = MessageBox.Show("बिलाची प्रिंट पाहिजे का ?", "प्रिंट", MessageBoxButtons.YesNo);
                        }
                        if (dr == DialogResult.Yes)
                        {
                            bill();
                        }
                        else
                        {                           
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Chalan saved successfully..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("सदर चलन यशस्वीरित्या साठवले गेले आहे..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        btnnew_Click(sender, e);
                    }
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
                if (rbtnCash.Checked == true)
                {
                    lblBakiAmount.Enabled = false;
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
                if (rbtnCash.Checked == true)
                {
                    lblBakiAmount.Enabled = false;
                    txtBalanceAmount.Enabled = false;
                    subtot();
                }
            }
            catch(Exception ex)
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
                if (e.KeyCode == Keys.F1)
                {
                    frmItemDetails frm = new frmItemDetails();
                    frm.ShowDialog();
                }
                if (e.KeyCode == Keys.Home)
                {
                    try
                    {
                        btnnew_Click(sender, e);
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
                if (e.KeyCode == Keys.T && e.Alt)
                {
                    frmTempSaleChallan frm = new frmTempSaleChallan();
                    frm.ShowDialog();
                }
            }
            catch(Exception ex)
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
                        txtmobile.Text = info.Rows[0]["customerMobileNo"].ToString();
                        txtaddress.Text = info.Rows[0]["customerAddress"].ToString();
                        txtGSTNo.Text = info.Rows[0]["CustomerGSTNo"].ToString();
                    }
                }
                else
                {
                    //  txtmobile.Text = "";
                    txtaddress.Text = "";
                }
                if(cmbCustomerName.SelectedIndex > 0)
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
            try
            {
                SaleID = txtInvoiceNo.Text;
                DataTable dtSale = SaleDetailsController.getSaleChallenDetails(Convert.ToInt64(salesInvoiceId),Utility.FinancilaYearId);
                crSaleChalan rpt = new crSaleChalan();
                RptSaleBill frm = new RptSaleBill();
                //rpt.SetDataSource(dtSale);
                rpt.Database.Tables[0].SetDataSource(dtSale);
                rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                if (Utility.isPeview)
                {
                    frm.crystalReportViewer1.ReportSource = rpt;

                    frm.Refresh();
                    frm.crystalReportViewer1.Refresh();
                    frm.ShowDialog();
                }
                else
                {
                    rpt.PrintToPrinter(2, true, 0, 0);
                }
                //frm.crystalReportViewer1.ReportSource = rpt;
                //frm.Refresh();
                //frm.crystalReportViewer1.Refresh();
                //frm.ShowDialog();
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
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
        private void dgvSaleItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
                if (dgvSaleItems.CurrentCell.ColumnIndex == 6 || dgvSaleItems.CurrentCell.ColumnIndex == 8 || dgvSaleItems.CurrentCell.ColumnIndex == 9 || dgvSaleItems.CurrentCell.ColumnIndex == 10 || dgvSaleItems.CurrentCell.ColumnIndex == 14) //Desired Column
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtmobile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtmobile.Text != string.Empty)
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
                   // BindComboBoxgetCustomerName();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        bool isState = false;
        private void cmbGST_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbGST.SelectedIndex >= 0)
                {
                    string stateName = cmbGST.Text;
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
                if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                {
                    dgvSaleItems.Columns["IGST"].Visible = true;
                    dgvSaleItems.Columns["IGSTAmt"].Visible = true;
                    dgvSaleItems.Columns["CGST"].Visible = false;
                    dgvSaleItems.Columns["CGSTAmt"].Visible = false;
                    dgvSaleItems.Columns["SGST"].Visible = false;
                    dgvSaleItems.Columns["SGSTAmt"].Visible = false;
                    isState = false;
                }
                else
                {
                    dgvSaleItems.Columns["IGST"].Visible = false;
                    dgvSaleItems.Columns["IGSTAmt"].Visible = false;
                    dgvSaleItems.Columns["CGST"].Visible = true;
                    dgvSaleItems.Columns["CGSTAmt"].Visible = true;
                    dgvSaleItems.Columns["SGST"].Visible = true;
                    dgvSaleItems.Columns["SGSTAmt"].Visible = true;
                    isState = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void subtot()
        {
            double sum = 0;
            for (int i = 0; i < dgvSaleItems.Rows.Count; ++i)
            {
                if (dgvSaleItems.Rows[i].Cells["totalAmount"].Value != null)
                {
                    sum += Math.Round(Utility.ParseValue(dgvSaleItems.Rows[i].Cells["totalAmount"].Value.ToString()),2);
                }
            }
             
            string netamount = txtNetAmount.Text;
            if (txtPaidAmount.Text == string.Empty)
            {
                txtNetAmount.Text = Math.Round(sum).ToString(); 
            }
            else
            {
                txtNetAmount.Text = Math.Round(Utility.ParseValue(txtPaidAmount.Text) + sum).ToString(); 
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            subtot();
        }

        private void btnChallanList_Click(object sender, EventArgs e)
        {
            try
            {
                grbItemName.Visible = true;
                grbChallanList.Visible = true;
                dtpFromChallanDate.Enabled = true;
                dtpToChallanDate.Enabled = true;
                dgvSaleChallan.DataSource = SaleDetailsController.getChallenList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()),Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtChallaneList = SaleDetailsController.getChallenList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);
                dgvSaleChallan.DataSource = dtChallaneList;
            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void dgvSaleChallan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                long salesChallanId = 0;
                if (e.RowIndex >= 0)
                {
                    salesChallanId = Convert.ToInt64(dgvSaleChallan.CurrentRow.Cells["SalesChallanBillId"].Value);
                }
                BindData(salesChallanId);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindData(long salesChallanId)
        {
            try
            {
                if (dgvSaleItems.Rows.Count > 0)
                {
                    Utility.ClearSpace(this);
                    Utility.enableFields(this);
                    btnSave.Enabled = true;
                 //   BindComboBoxgetCustomerName();
                    grbChallanList.Visible = false;
                    dgvSaleItems.Rows.Clear();
                    dgvSaleItems.Rows.Add();
                    dgvSaleItems.Enabled = true;
                    btnDelete.Enabled = true;
                    isDelete = false;
                    isUpdate = true;
                    DataTable dtSaleChallen = SaleDetailsController.getSaleChallenDetails(salesChallanId,Utility.FinancilaYearId);
                    txtInvoiceNo.Text = dtSaleChallen.Rows[0]["SalesChallanBillId"].ToString();
                    cmbCustomerRetailer.SelectedIndex = Convert.ToInt32(dtSaleChallen.Rows[0]["isCustomerRetailer"]);
                    dtpChallenDate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["SalesChallanDate"].ToString());
                    cmbCustomerName.Text = dtSaleChallen.Rows[0]["customerName"].ToString();
                    txtaddress.Text = dtSaleChallen.Rows[0]["customerAddress"].ToString();
                    txtmobile.Text = dtSaleChallen.Rows[0]["customerMobileNo"].ToString();
                    txtGSTNo.Text = dtSaleChallen.Rows[0]["CustomerGSTNo"].ToString();
                    cmbGST.Text = dtSaleChallen.Rows[0]["salesState"].ToString();
                    txtStateCode.Text = dtSaleChallen.Rows[0]["salesStateCode"].ToString();

                    if (dtSaleChallen.Rows[0]["salesType"].ToString() == "Cash")
                    {
                        rbtnCash.Checked = true;
                    }
                    if (dtSaleChallen.Rows[0]["salesType"].ToString() == "Credit")
                    {
                        rbtnCredit.Checked = true;
                    }
                    if (Convert.ToBoolean(dtSaleChallen.Rows[0]["isState"].ToString()) == true)
                    {
                        cmbGST.Text = "Maharashtra";
                    }
                    //else
                    //{
                    //    cmbGST.Text = "Other";
                    //}
                   //txtPaidAmount.Text = dtSaleChallen.Rows[0]["customerMobileNo"].ToString();
                    txtPaidAmount.Text = dtSaleChallen.Rows[0]["othercharges"].ToString();
                    txtNetAmount.Text = Math.Round(Utility.ParseValue(dtSaleChallen.Rows[0]["totalSalesChallanAmount"].ToString())).ToString();
                    foreach (DataRow dr in dtSaleChallen.Rows)
                    {
                        dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                        dgvSaleItems.CurrentRow.Cells["salesChallanItemDetailsId"].Value = Convert.ToInt64(dr["salesChallanItemDetailsId"]);
                        dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dr["StockId"]);
                        dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                        dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                        dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                        dgvSaleItems.CurrentRow.Cells["itemName"].ReadOnly = true;
                        dgvSaleItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                        dgvSaleItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                        dgvSaleItems.CurrentRow.Cells["Quantity"].Value = dr["quantity"].ToString();
                        dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();

                        if (rbtnCash.Checked == true)
                        {
                            dgvSaleItems.CurrentRow.Cells["Rate"].Value = Math.Round(Utility.ParseValue(dr["perQtysalePrice"].ToString()),2);
                        }
                        if (rbtnCredit.Checked == true)
                        {
                            dgvSaleItems.CurrentRow.Cells["Rate"].Value = Math.Round(Utility.ParseValue(dr["perQtysalePrice"].ToString()),2);
                        }
                        dgvSaleItems.CurrentRow.Cells["discount"].Value = 0;
                        dgvSaleItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dr["IGST"].ToString());
                        dgvSaleItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dr["CGST"].ToString());
                        dgvSaleItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dr["SGST"].ToString());

                        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString()),2);

                        double discount = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())) / 100);
                        double purRate = Math.Round(Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Rate"].Value.ToString())),2);
                        dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100),2);
                        dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100),2);
                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round((Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100),2);


                        //if (cmbGST.SelectedItem.ToString() == "Other")
                        //{
                        //    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dr["IGST"].ToString()) * purRate / 100);
                        //}
                        //else
                        //{
                        //    dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dr["CGST"].ToString()) * purRate / 100);
                        //    dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dr["SGST"].ToString()) * purRate / 100);
                        //    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());
                        //}

                        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString())),2).ToString();
                        subtot();
                        //  dgvSaleItems.Focus();
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
                                dgvSaleItems.CurrentCell = dgvSaleItems[col + 4, row];
                            }
                        }
                    }
                }
            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
        bool isDelete = false;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                isDelete = true;
                btnSave_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
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
    }
}
