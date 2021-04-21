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
    public partial class frmStockOut : MetroForm
    {
        public frmStockOut()
        {
            InitializeComponent();
        }
        long StockOutID = 0;bool isDelete=false;
        private bool isUpdate = false;
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Stock Out";
                    metroLabel2.Text = "Stock Out No:";
                    metroLabel1.Text = "Date:";
                    lblNetBill.Text = "Total Amount:";
                    lblPaidAmount.Text = "Round Off:";
                    lblBakiAmount.Text = "Remaining Amt:";
                    label1.Text = "Naration:";
                    btnDelete.Text = "Delete";
                    btnChallanList.Text = "Stock Out List";
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    label2.Text = "From Date:";
                    label3.Text = "To Date:";
                    btnShow.Text = "Show";

                    dgvPurchaseItems.Columns[5].HeaderText = "Naration";                
                    dgvPurchaseItems.Columns[6].HeaderText = "Batch No";
                    dgvPurchaseItems.Columns[7].HeaderText = "Quantity";
                    dgvPurchaseItems.Columns[8].HeaderText = "Unit By";
                     dgvPurchaseItems.Columns[9].HeaderText = "Free Quantity";
                     dgvPurchaseItems.Columns[10].HeaderText = "Purchase Rate";
                    dgvPurchaseItems.Columns[11].HeaderText = "Sale Rate";
                    dgvPurchaseItems.Columns[12].HeaderText = "GST(%)";
                    dgvPurchaseItems.Columns[13].HeaderText = "GSTAmt";
                    dgvPurchaseItems.Columns[14].HeaderText = "CGST(%)";
                    dgvPurchaseItems.Columns[15].HeaderText = "CGST Amt";
                    dgvPurchaseItems.Columns[16].HeaderText = "SGST(%)";
                    dgvPurchaseItems.Columns[17].HeaderText = "SGSTAmt";
                    dgvPurchaseItems.Columns[18].HeaderText = "Discount";
                    dgvPurchaseItems.Columns[19].HeaderText = "Total Amount";

                    dgvSaleChallan.Columns[0].HeaderText = "StockIn No.";
                    dgvSaleChallan.Columns[1].HeaderText = "Date";
                    dgvSaleChallan.Columns[2].HeaderText = "Amount";
                    dgvSaleChallan.Columns[3].HeaderText = "Naration";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmStockOut_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                grbItemList.Visible = false;
                grbChallanList.Visible = false;
                dgvItemName.Hide();
                dgvPurchaseItems.Enabled = false;
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                isUpdate = false;
                Lang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
          long salesInvoiceId = 0;
        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                txtInvoiceNo.Text = stockOutController.getMaxStockOutId(Utility.FinancilaYearId).ToString();
                grbItemList.Visible = false;
                dgvItemName.Hide();
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                dgvPurchaseItems.Enabled = true;
                grbChallanList.Visible = false;
                isDelete = false;
                isUpdate = false;
                dtpChallenDate.MinDate = dtpFromChallanDate.MinDate = dtpToChallanDate.MinDate = Utility.firstDate;
                dtpChallenDate.MaxDate = dtpFromChallanDate.MaxDate = dtpToChallanDate.MaxDate = Utility.lastDate;
                dtpFromChallanDate.Value = Utility.firstDate;
                dtpToChallanDate.Value = Utility.lastDate;
                StockOutID = 0;
                dgvSaleChallan.DataSource = stockOutController.getStockOutList(dtpFromChallanDate.Value, dtpToChallanDate.Value,Utility.FinancilaYearId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvSaleItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPurchaseItems.IsCurrentCellDirty)
            {
                dgvPurchaseItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
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
            if (dgvPurchaseItems.CurrentRow.Cells["itemName"].Value == null)
            {
                dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["stockOutItemID"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = null;
                //Rate  dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["StockId"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["discount"].Value = null;
                dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = null;
                dgvItemName.Hide();
                return;
            }
            string value = null;
            if (dgvPurchaseItems.CurrentCell.ColumnIndex == 5)
            {
                value = dgvPurchaseItems.CurrentRow.Cells["itemName"].Value.ToString();
            }
            else
            {
                if (dgvPurchaseItems.CurrentCell.ColumnIndex == 4 || dgvPurchaseItems.CurrentCell.ColumnIndex == 6 || dgvPurchaseItems.CurrentCell.ColumnIndex == 5 || dgvPurchaseItems.CurrentCell.ColumnIndex == 5 || dgvPurchaseItems.CurrentCell.ColumnIndex == 7 || dgvPurchaseItems.CurrentCell.ColumnIndex == 8 || dgvPurchaseItems.CurrentCell.ColumnIndex == 9 || dgvPurchaseItems.CurrentCell.ColumnIndex == 10|| dgvPurchaseItems.CurrentCell.ColumnIndex == 11 || dgvPurchaseItems.CurrentCell.ColumnIndex == 18)                                                                                                                                                                                                               
                   
                {
                    if (dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value != null && dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value != null && dgvPurchaseItems.CurrentRow.Cells["discount"].Value != null
                        && dgvPurchaseItems.CurrentRow.Cells["IGST"].Value != null && dgvPurchaseItems.CurrentRow.Cells["CGST"].Value != null && dgvPurchaseItems.CurrentRow.Cells["SGST"].Value != null)
                    {
                      //  dgvPurchaseItems.CurrentRow.Cells["HNSCode"].Value = dgvPurchaseItems.CurrentRow.Cells["HNSCode"].Value.ToString();
                        dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value.ToString();
                        dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value.ToString());
                         dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value =dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value.ToString();
                        dgvPurchaseItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString());
                        dgvItemName.Hide();
                        double purRate = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString()));
                            dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100);
                            dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())));
                            dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())) * 2);
                            dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString())));
                            dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());

                            // double discount = (Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["discount"].Value) * (Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value) * Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value)) / 100);

                        // dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value) * purRate / 100);
                            dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString())));
                    }
                    else
                    {
                        dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = 0;
                    }
                }
            }
            if (value != null)
            {
                DataTable dtitem = null;
                    dtitem = TempSaleDetailsController.getTempStockInItemDetails(value);
                if (dtitem.Rows.Count > 0)
                {
                    dgvItemName.DataSource = dtitem;
                    dgvItemName.Columns[0].Visible = false;
                    dgvItemName.Columns[1].Width = 500;
                    dgvItemName.ClearSelection();
                    this.dgvItemName.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    grbItemList.Visible = true;
                    dgvItemName.Show();
                    grbChallanList.Visible = false;
                    dgvPurchaseItems.DataSource=null;
                }

            }
            else
            {


            }
            subtot();

        }
        private void dgvSaleItems_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    int col = dgvPurchaseItems.CurrentCell.ColumnIndex;
                    int row = dgvPurchaseItems.CurrentCell.RowIndex;
                    if (col < dgvPurchaseItems.ColumnCount - 2)
                    {
                        col++;
                    }
                    else
                    {
                        col = 0;
                        row++;
                    }
                    if (dgvPurchaseItems.CurrentRow.Cells["itemId"].Value == null)
                    {
                        dgvItemName.Focus();
                        dgvItemName.CurrentCell = dgvItemName.CurrentRow.Cells["itemName"];
                        dgvItemName.CurrentCell.Selected = true;
                    }
                    else
                    {
                        if (dgvPurchaseItems.CurrentRow.Cells["itemName"].Value != null)
                        {
                            if (row == dgvPurchaseItems.RowCount)
                            {
                                dgvPurchaseItems.Rows.Add();
                                dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 5, row];

                            }
                            else if (dgvPurchaseItems.CurrentCell.ColumnIndex == 9)
                            {
                                dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 1, row];
                            }
                            else if (dgvPurchaseItems.CurrentCell.ColumnIndex == 11)
                            {
                                dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 7, row];
                            }
                            else
                            {
                                dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col, row];
                            }
                        }
                    }
                    e.Handled = true;
                }
                if ((e.KeyCode == Keys.F10 && e.Shift))
                {

                }
            }
            catch(Exception ex)
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
                    if (dgvPurchaseItems.CurrentRow.Cells["itemId"].Value != null)
                    {
                        stockOutController.deleteStockOutRow(Convert.ToInt64(txtInvoiceNo.Text), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["stockOutItemID"].Value), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["itemId"].Value), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["categoryId"].Value), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["companyId"].Value), Convert.ToString(dgvPurchaseItems.Rows[rowIndex].Cells["batchNo"].Value),
                                                              Utility.ParseValue(dgvPurchaseItems.Rows[rowIndex].Cells["Quantity"].Value.ToString()));
                    }
                }
                rowToDelete = dgvPurchaseItems.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                dgvPurchaseItems.Rows.RemoveAt(rowToDelete);
                dgvPurchaseItems.ClearSelection();
                if (dgvPurchaseItems.Rows.Count == 0)
                {
                    dgvPurchaseItems.Rows.Add();
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
            if (e.Button == MouseButtons.Right)
            {
                this.dgvPurchaseItems.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.contextMenuStrip1.Show(this.dgvPurchaseItems, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void bindSaleItem(long StockId)
        {
            try
            {
                DataTable dt = itemDetailsController.getStockInItemDetailsbyStockId(StockId);
                foreach (DataGridViewRow rows in dgvPurchaseItems.Rows)
                {
                    if (rows.Cells["itemId"].Value != null && rows.Cells["companyId"].Value != null && rows.Cells["categoryId"].Value != null && rows.Cells["batchNo"].Value != null && rows.Cells["itemName"].Value != null)
                    {
                        if (rows.Cells["itemId"].Value.ToString().Equals(dt.Rows[0]["itemId"].ToString()) && rows.Cells["companyId"].Value.ToString().Equals(dt.Rows[0]["companyId"].ToString()) && rows.Cells["categoryId"].Value.ToString().Equals(dt.Rows[0]["categoryId"].ToString()) && rows.Cells["batchNo"].Value.ToString().Equals(dt.Rows[0]["batchNo"].ToString()) && rows.Cells["itemName"].Value.ToString().Equals(dt.Rows[0]["itemName"].ToString()))
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("This details already available in list !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("कृपया माहिती लिस्ट मध्ये आधीच उपलब्ध आहे !", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            dgvPurchaseItems.Focus();
                            return;
                        }
                    }
                }
                dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dt.Rows[0]["itemId"]);
                dgvPurchaseItems.CurrentRow.Cells["stockOutItemID"].Value = Convert.ToInt64(0);
                dgvPurchaseItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dt.Rows[0]["StockId"]);
                dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dt.Rows[0]["categoryId"]);
                dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dt.Rows[0]["companyId"]);
                dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dt.Rows[0]["batchNo"]);
                dgvPurchaseItems.CurrentRow.Cells["itemName"].Value = dt.Rows[0]["itemName"].ToString();
              //  dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = dt.Rows[0]["HNSCode"].ToString();
                dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = 1;
                dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = 0;
                dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = dt.Rows[0]["unitBy"].ToString();
                dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dt.Rows[0]["salesCashRate"].ToString());
                dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dt.Rows[0]["purchaseRate"].ToString());
                dgvPurchaseItems.CurrentRow.Cells["discount"].Value = 0;
                dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dt.Rows[0]["IGST"].ToString());
                dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dt.Rows[0]["CGST"].ToString());
                dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dt.Rows[0]["SGST"].ToString());

                dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString());

                double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString())) / 100);
                double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString())));
                dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100);
                dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100);
                dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100);


                //if (cmbGST.SelectedItem.ToString() == "Other")
                //{
                //    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Convert.ToDouble(dt.Rows[0]["IGST"].ToString()) * purRate / 100);
                //}
                //else
                //{
                //    dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(dt.Rows[0]["CGST"].ToString()) * purRate / 100);
                //    dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(dt.Rows[0]["SGST"].ToString()) * purRate / 100);
                //    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value) + Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value);
                //}

                // dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value) - Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["discount"].Value)).ToString();
                subtot();
                //  dgvPurchaseItems.Focus();
                dgvPurchaseItems.CurrentCell = dgvPurchaseItems.CurrentRow.Cells["Quantity"];
                dgvPurchaseItems.BeginEdit(true);
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
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

        private void dgvItemName_KeyDown(object sender, KeyEventArgs e)
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

        private void btnNewItem_Click(object sender, EventArgs e)
        {

        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvPurchaseItems.Rows.Count; i++)
                {
                    if (dgvPurchaseItems.Rows[i].Cells[5].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Item Name in List..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये वस्तूचे नाव भरा..");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[5];
                        return;
                    }
                    //if (dgvPurchaseItems.Rows[i].Cells[5].Value == null)
                    //{
                    //    MessageBox.Show("कृपया लिस्ट  मध्ये HSN कोड भरा..");
                    //    dgvPurchaseItems.Focus();
                    //    dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[5];
                    //    return;
                    //}
                    if (dgvPurchaseItems.Rows[i].Cells[6].Value == null)
                    {

                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add Batch no.in List..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये वस्तूचा बॅच नं. भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[6];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[7].Value == null)
                    {

                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add item Quantity in List..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये वस्तूचे नग भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[7];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[9].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            dgvPurchaseItems.Rows[i].Cells[9].Value = "Qty";
                        }
                        else
                        {
                            dgvPurchaseItems.Rows[i].Cells[9].Value = "नग";
                        }
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[11].Value == null)
                    {
                      if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Rate in list..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये दर भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[11];
                        return;
                    }
                    //if (dgvPurchaseItems.Rows[i].Cells[10].Value == null)
                    //{
                    //    MessageBox.Show("कृपया list मध्ये  IGST (%) भरा..");
                    //    dgvPurchaseItems.Focus();
                    //    dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[10];
                    //    return;
                    //}
                    //if (dgvPurchaseItems.Rows[i].Cells[9].Value == null )
                    //{
                    //    MessageBox.Show("कृपया लिस्ट मध्ये Tax(कर)% भरा");
                    //    dgvPurchaseItems.Focus();
                    //    dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[9];
                    //    return;
                    //}


                    if (dgvPurchaseItems.Rows[i].Cells[19].Value == null || Utility.ParseValue(dgvPurchaseItems.Rows[i].Cells[19].Value.ToString()) == 0)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Total Amount in List..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये एकूण रक्कम भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[19];
                        return;
                    }
                }

                /// long customerId = 0;


                PurchaseDetails saleChallan = new PurchaseDetails();
                DataTable dtSaleItems = new DataTable();


                foreach (DataGridViewColumn col in dgvPurchaseItems.Columns)
                {
                    dtSaleItems.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dgvPurchaseItems.Rows)
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

                saleChallan.PurchaseItemTable = dtSaleItems;
                saleChallan.challanDate = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                if (isUpdate==false)
                {
                    saleChallan.stockOutID = 0;
                    saleChallan.stockOutInvoiceID = Convert.ToInt64(stockOutController.getMaxStockOutId(Utility.FinancilaYearId).ToString());
                }
                else
                {
                    saleChallan.stockOutInvoiceID = Convert.ToInt64(txtInvoiceNo.Text);
                    saleChallan.stockOutID = StockOutID;
                }
                StockOutID = saleChallan.stockOutID;
                saleChallan.financialYearID = Utility.FinancilaYearId;
                if (txtPaidAmount.Text == string.Empty)
                {
                    saleChallan.paidAmount = 0;
                }
                else
                {
                    saleChallan.paidAmount = Utility.ParseValue(txtPaidAmount.Text);
                }
                saleChallan.netBillAmount = Utility.ParseValue(txtNetAmount.Text);
                saleChallan.remark = txtNaration.Text;
                saleChallan.addedBy = Utility.LoginID;
                int ks = 0;
                if (isDelete == true)
                {
                    DialogResult dr = DialogResult.No;
                    if (Utility.Langn == "English")
                    {
                        dr = MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        dr = MessageBox.Show("तुम्हाला सदर नोंद डिलीट करायाचे आहे काय?", "Confirmation", MessageBoxButtons.YesNo);
                    }
                    if (dr == DialogResult.Yes)
                    {
                        saleChallan.isDelete = true;
                        ks = stockOutController.addStockOutDetails(saleChallan);
                    }
                    else if (dr == DialogResult.No)
                    {
                        //Nothing to do
                    }
                    if (ks > 0)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("This record deleted successfully ... !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("सदर नोंद यशस्वीरित्या डिलीट केले गेले आहे ... !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        btnnew_Click(sender, e);
                       
                    }
                }
                else if (isDelete == false)
                {
                    saleChallan.isDelete = false;
                    ks = stockOutController.addStockOutDetails(saleChallan);
                    if (ks > 0)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("This Record saved successfully..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("सदर नोंद यशस्वीरित्या साठवले गेले आहे..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                lblBakiAmount.Enabled = false;
                txtBalanceAmount.Enabled = false;
                subtot();
        }

        private void rbtnCredit_CheckedChanged(object sender, EventArgs e)
        {
                lblBakiAmount.Enabled = false;
                txtBalanceAmount.Enabled = false;
                subtot();
        }
        private void frmSaleInvoive_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerDetails frm = new frmCustomerDetails();
            frm.ShowDialog();
        }

       
    
        private void dgvSaleItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgvPurchaseItems.CurrentCell.ColumnIndex == 6 || dgvPurchaseItems.CurrentCell.ColumnIndex == 8 ||  dgvPurchaseItems.CurrentCell.ColumnIndex == 9 || dgvPurchaseItems.CurrentCell.ColumnIndex == 10 ||  dgvPurchaseItems.CurrentCell.ColumnIndex == 14) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void subtot()
        {
            double sum = 0;
            for (int i = 0; i < dgvPurchaseItems.Rows.Count; ++i)
            {
                if (dgvPurchaseItems.Rows[i].Cells["totalAmount"].Value != null)
                {
                    sum += Utility.ParseValue(dgvPurchaseItems.Rows[i].Cells["totalAmount"].Value.ToString());
                }
            }
             
            string netamount = txtNetAmount.Text;
            if (txtPaidAmount.Text == string.Empty)
            {
                txtNetAmount.Text = Math.Round(sum,2).ToString(); 
            }
            else
            {
                txtNetAmount.Text = Math.Round(Utility.ParseValue(txtPaidAmount.Text) + sum, 2).ToString(); 
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            subtot();
        }

        private void btnChallanList_Click(object sender, EventArgs e)
        {
            grbItemList.Visible = true;
            grbChallanList.Visible = true;
            dtpFromChallanDate.Enabled = true;
            dtpToChallanDate.Enabled = true;
            dgvSaleChallan.DataSource = stockOutController.getStockOutList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                grbItemList.Visible = true;
                grbChallanList.Visible = true;
                dtpFromChallanDate.Enabled = true;
                dtpToChallanDate.Enabled = true;
                dgvSaleChallan.DataSource = stockOutController.getStockOutList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);
            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void dgvSaleChallan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long SalesChallanBillId = 0;
            if(e.RowIndex >= 0)
            {
                SalesChallanBillId = Convert.ToInt64(dgvSaleChallan.CurrentRow.Cells["stockOutID1"].Value);
            }
            BindData(SalesChallanBillId);
        }
        public void BindData(long SalesChallanBillId)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                grbChallanList.Visible = false;
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                dgvPurchaseItems.Enabled = true;
                btnDelete.Enabled = true;
                isDelete = false;
                isUpdate = true;
                DataTable dtSaleChallen = stockOutController.getStockOutDetails(SalesChallanBillId,Utility.FinancilaYearId);
                txtInvoiceNo.Text = dtSaleChallen.Rows[0]["StockOutInvoiceID"].ToString();
                StockOutID = Convert.ToInt64(dtSaleChallen.Rows[0]["stockOutID"].ToString());
                dtpChallenDate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["stockOutDate"].ToString());
                txtPaidAmount.Text = dtSaleChallen.Rows[0]["roundOff"].ToString();
                txtNetAmount.Text = dtSaleChallen.Rows[0]["totalAmount"].ToString();
                txtNaration.Text = dtSaleChallen.Rows[0]["remark"].ToString();
                foreach (DataRow dr in dtSaleChallen.Rows)
                {
                    dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                    dgvPurchaseItems.CurrentRow.Cells["stockOutItemID"].Value = Convert.ToInt64(dr["stockOutItemID"]);
                    dgvPurchaseItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(0);
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                    dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                    dgvPurchaseItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["itemName"].ReadOnly = true;
                 //   dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = dr["OutQuantity"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = dr["freeQuantity"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = dr["rate"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = 0;

                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString());

                    double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString())) / 100);
                    double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString())));
                    dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100);
                    dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100);
                    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100);


                    //if (cmbGST.SelectedItem.ToString() == "Other")
                    //{
                    //    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Convert.ToDouble(dr["IGST"].ToString()) * purRate / 100);
                    //}
                    //else
                    //{
                    //    dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(dr["CGST"].ToString()) * purRate / 100);
                    //    dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(dr["SGST"].ToString()) * purRate / 100);
                    //    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value) + Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value);
                    //}

                    // dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value) - Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["discount"].Value)).ToString();
                    subtot();
                    //  dgvPurchaseItems.Focus();
                    dgvPurchaseItems.CurrentCell = dgvPurchaseItems.CurrentRow.Cells["Quantity"];
                    dgvPurchaseItems.BeginEdit(true);
                    int col = dgvPurchaseItems.CurrentCell.ColumnIndex;
                    int row = dgvPurchaseItems.CurrentCell.RowIndex;
                    col = 0;
                    row++;
                    if (dgvPurchaseItems.Rows.Count < dtSaleChallen.Rows.Count)
                    {
                        if (row == dgvPurchaseItems.RowCount)
                        {
                            dgvPurchaseItems.Rows.Add();
                            dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 4, row];
                        }
                    }
                }
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            isDelete = true;
            btnSave_Click(sender,e);

        }

        private void frmStockOut_KeyDown(object sender, KeyEventArgs e)
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
                if (e.KeyCode == Keys.N && e.Alt)
                {
                    btnnew_Click(sender, e);
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

        private void txtBalanceAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtBalanceAmount.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtBalanceAmount.Text.IndexOf('.') > -1)
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

        private void txtPaidAmount_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
   
}
