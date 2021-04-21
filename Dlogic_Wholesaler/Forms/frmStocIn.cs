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
    public partial class frmStocIn : MetroForm
    {
        public frmStocIn()
        {
            InitializeComponent();
        }
        Int32 rowToDelete; bool isDelete;
        public int rowIndex = 0; long stockInID=0;
        private bool isUpdate = false;
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Stock In";
                    metroLabel2.Text = "Stock In No:";
                    metroLabel1.Text = "Date:";
                    chkIter.Text = "Other Stock In";
                    lblNetBill.Text = "Total Amount:";
                    lblPaidAmount.Text = "Round Off:";
                    lblBakiAmount.Text = "Remaining Amt:";
                    label1.Text = "Naration:";
                    btnDelete.Text = "Delete";
                    btnChallanList.Text = "Stock In List";
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";        
                    label2.Text = "From Date:";
                    label3.Text = "To Date:";
                    btnShow.Text = "Show";

                    dgvSaleItems.Columns[5].HeaderText = "Naration";
                    dgvSaleItems.Columns[6].HeaderText = "HSNCode";
                    dgvSaleItems.Columns[7].HeaderText = "Batch No";
                    dgvSaleItems.Columns[8].HeaderText = "Quantity";
                    dgvSaleItems.Columns[9].HeaderText = "Unit By";                  
                    dgvSaleItems.Columns[10].HeaderText = "Rate";
                    dgvSaleItems.Columns[11].HeaderText = "GST(%)";
                    dgvSaleItems.Columns[12].HeaderText = "GSTAmt";
                    dgvSaleItems.Columns[13].HeaderText = "CGST(%)";
                    dgvSaleItems.Columns[14].HeaderText = "CGST Amt";
                    dgvSaleItems.Columns[15].HeaderText = "SGST(%)";
                    dgvSaleItems.Columns[16].HeaderText = "SGSTAmt";
                    dgvSaleItems.Columns[17].HeaderText = "Discount";
                    dgvSaleItems.Columns[18].HeaderText = "Total Amount";
                 
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
        private void frmStocIn_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                grbItemList.Visible = false;
                grbChallanList.Visible = false;
                dgvItemName.Hide();
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                isUpdate = false;
                dtpChallenDate.MaxDate = Utility.lastDate;
                dtpChallenDate.MinDate = Utility.firstDate;
                dtpFromChallanDate.MinDate = Utility.firstDate;
                dtpFromChallanDate.MaxDate = Utility.lastDate;
                dtpToChallanDate.MinDate = Utility.firstDate;
                dtpToChallanDate.MaxDate = Utility.lastDate;
                if (dtpChallenDate.Value < Utility.firstDate || dtpChallenDate.Value > Utility.lastDate)
                {
                    dtpChallenDate.Value = Utility.firstDate;
                }
                dtpFromChallanDate.Value = Utility.firstDate;
                dtpToChallanDate.Value = Utility.lastDate;
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
                chkIter.Enabled = true;
                btnDelete.Enabled = false;
                txtInvoiceNo.Text = stockInController.getMaxStockInId().ToString();
                txtInvoiceID.Text = stockInController.getMaxStockInId(Utility.FinancilaYearId).ToString();
                grbItemList.Visible = false;
                dgvItemName.Hide();
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                dgvSaleItems.Enabled = true;
                grbChallanList.Visible = false;
                isDelete = false;
                isUpdate = false;
                stockInID = 0;
                dtpChallenDate.MaxDate = Utility.lastDate;
                dtpChallenDate.MinDate = Utility.firstDate;
                dtpFromChallanDate.MinDate = Utility.firstDate;
                dtpFromChallanDate.MaxDate = Utility.lastDate;
                dtpToChallanDate.MinDate = Utility.firstDate;
                dtpToChallanDate.MaxDate = Utility.lastDate;
                if (dtpChallenDate.Value < Utility.firstDate || dtpChallenDate.Value > Utility.lastDate)
                {
                    dtpChallenDate.Value = Utility.firstDate;
                }
                dtpFromChallanDate.Value = Utility.firstDate;
                dtpToChallanDate.Value = Utility.lastDate;
                chkIter.Checked = true;
               // dgvSaleChallan.DataSource = stockInController.getStockInList(dtpFromChallanDate.Value, dtpToChallanDate.Value);
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
                if (dtpChallenDate.Value < Utility.firstDate || dtpChallenDate.Value > Utility.lastDate)
                {
                    dtpChallenDate.Value = Utility.firstDate;
                }
                for (int i = 0; i < dgvSaleItems.Rows.Count; i++)
                {
                    if (dgvSaleItems.Rows[i].Cells[5].Value == null)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Item Name in List..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये वस्तूचे नाव भरा..");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[5];
                        return;
                    }
                    //if (dgvSaleItems.Rows[i].Cells[5].Value == null)
                    //{
                    //    MessageBox.Show("कृपया list मध्ये HSN कोड भरा..");
                    //    dgvSaleItems.Focus();
                    //    dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[5];
                    //    return;
                    //}
                    if (dgvSaleItems.Rows[i].Cells[7].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add Batch no.in List..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये वस्तूचा बॅच नं. भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[7];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells[8].Value == null)
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
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[8];
                        return;
                    }
                    else
                    {
                        dgvSaleItems.Rows[i].Cells[8].Value = Utility.ParseValue(dgvSaleItems.Rows[i].Cells[8].Value.ToString());
                    }
                    if (dgvSaleItems.Rows[i].Cells[9].Value == null)
                    {
                       
                        if (Utility.Langn == "English")
                        {
                            dgvSaleItems.Rows[i].Cells[9].Value = "Qty";
                        }
                        else
                        {
                            dgvSaleItems.Rows[i].Cells[9].Value = "नग";
                        }
                    }
                    if (dgvSaleItems.Rows[i].Cells[10].Value == null)
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
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[10];
                        return;
                    }
                    else
                    {
                        dgvSaleItems.Rows[i].Cells[10].Value = Utility.ParseValue(dgvSaleItems.Rows[i].Cells[10].Value.ToString());
                    }
                    //if (dgvSaleItems.Rows[i].Cells[10].Value == null)
                    //{
                    //    MessageBox.Show("कृपया list मध्ये  IGST (%) भरा..");
                    //    dgvSaleItems.Focus();
                    //    dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[10];
                    //    return;
                    //}
                    //if (dgvSaleItems.Rows[i].Cells[9].Value == null )
                    //{
                    //    MessageBox.Show("कृपया लिस्ट मध्ये Tax(कर)% भरा");
                    //    dgvSaleItems.Focus();
                    //    dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[9];
                    //    return;
                    //}


                    if (dgvSaleItems.Rows[i].Cells[18].Value == null)
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
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells[18];
                        return;
                    }
                }

                /// long customerId = 0;


                PurchaseDetails saleChallan = new PurchaseDetails();
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
                if(isUpdate==false)
                {
                    saleChallan.stockInID = Convert.ToInt64(stockInController.getMaxStockInId().ToString());
                    saleChallan.stockInInvoiceID = stockInController.getMaxStockInId(Utility.FinancilaYearId).ToString();
                }
                else
                {
                    saleChallan.stockInID = Convert.ToInt64(txtInvoiceNo.Text);
                    saleChallan.stockInInvoiceID = txtInvoiceID.Text.Trim();
                }
                stockInID = saleChallan.stockInID;
                if (txtPaidAmount.Text == string.Empty)
                {
                    saleChallan.paidAmount = 0;
                }
                else
                {
                    saleChallan.paidAmount = Utility.ParseValue(txtPaidAmount.Text);
                }
                saleChallan.netBillAmount = Utility.ParseValue(txtNetAmount.Text);
                if (chkIter.Checked == false)
                {
                    saleChallan.remark = txtNaration.Text;
                }else
                {
                   // saleChallan.remark = "इतर";
                    if (Utility.Langn == "English")
                    {
                        saleChallan.remark = "Other";
                    }
                    else
                    {
                        saleChallan.remark = "इतर";
                    }
                }
                saleChallan.addedBy = Utility.LoginID;
                saleChallan.FinancialYearID = Utility.FinancilaYearId;
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
                        ks = stockInController.addStockInDetails(saleChallan);
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
                    ks = stockInController.addStockInDetails(saleChallan);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            isDelete = true;
            btnSave_Click(sender, e);
        }

        private void btnChallanList_Click(object sender, EventArgs e)
        {
            try
            {
                grbItemList.Visible = true;
                grbChallanList.Visible = true;
                dtpFromChallanDate.Enabled = true;
                dtpToChallanDate.Enabled = true;
                dtpFromChallanDate.Value = Utility.firstDate;
                dtpToChallanDate.Value = Utility.lastDate;
                dgvSaleChallan.DataSource = stockInController.getStockInList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvPurchaseItems_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
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

        private void dgvPurchaseItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
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

        private void dgvPurchaseItems_KeyDown(object sender, KeyEventArgs e)
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
                            else if (dgvSaleItems.CurrentCell.ColumnIndex == 10)
                            {
                                dgvSaleItems.CurrentCell = dgvSaleItems[col + 6, row];
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
        private void dgvPurchaseItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtChallaneList = stockInController.getStockInList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);
                dgvSaleChallan.DataSource = dtChallaneList;
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void dgvSaleChallan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                long SalesChallanBillId = 0;
                if (e.RowIndex >= 0)
                {
                    SalesChallanBillId = Convert.ToInt64(dgvSaleChallan.CurrentRow.Cells["stockInID1"].Value);
                }
                BindData(SalesChallanBillId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindData(long SalesChallanBillId)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                grbChallanList.Visible = false;
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                dgvSaleItems.Enabled = true;
                btnDelete.Enabled = true;
                isDelete = false;
                isUpdate = true;
                DataTable dtSaleChallen = stockInController.getStockInDetails(SalesChallanBillId,Utility.FinancilaYearId);
                if (dtSaleChallen.Rows.Count > 0)
                {
                    txtInvoiceNo.Text = dtSaleChallen.Rows[0]["stockInID"].ToString();
                    txtInvoiceID.Text = dtSaleChallen.Rows[0]["stockInInvoiceID"].ToString();

                    dtpChallenDate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["stockInDate"]);
                    txtPaidAmount.Text = dtSaleChallen.Rows[0]["roundOff"].ToString();
                    txtNetAmount.Text = dtSaleChallen.Rows[0]["totalAmount"].ToString();
                    if (dtSaleChallen.Rows[0]["remark"].ToString() == "इतर"|| dtSaleChallen.Rows[0]["remark"].ToString() == "Other")
                    {
                        chkIter.Checked = true;
                    }
                    else
                    {
                        chkIter.Checked = false;
                    }
                    chkIter.Enabled = false;
                    txtNaration.Text = dtSaleChallen.Rows[0]["remark"].ToString();
                    foreach (DataRow dr in dtSaleChallen.Rows)
                    {
                        dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                        dgvSaleItems.CurrentRow.Cells["stockInItemID"].Value = Convert.ToInt64(dr["stockInItemID"]);
                        dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dr["stockId"]);
                        dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                        dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                        dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                        dgvSaleItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                        dgvSaleItems.CurrentRow.Cells["itemName"].ReadOnly = true;
                        dgvSaleItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                        dgvSaleItems.CurrentRow.Cells["Quantity"].Value = dr["InQuantity"].ToString();
                        dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                        dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value = dr["rate"].ToString();
                        dgvSaleItems.CurrentRow.Cells["discount"].Value = 0;
                        dgvSaleItems.CurrentRow.Cells["IGST"].Value = 0;
                        dgvSaleItems.CurrentRow.Cells["CGST"].Value = 0;
                        dgvSaleItems.CurrentRow.Cells["SGST"].Value = 0;
                        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                        double discount = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value.ToString())) / 100);
                        double purRate = (Convert.ToDouble(Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Quantity"].Value) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value.ToString())));
                        dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100);
                        dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100);
                        dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100);

                        //if (cmbGST.SelectedItem.ToString() == "Other")
                        //{
                        //    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Convert.ToDouble(dr["IGST"].ToString()) * purRate / 100);
                        //}
                        //else
                        //{
                        //    dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(dr["CGST"].ToString()) * purRate / 100);
                        //    dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(dr["SGST"].ToString()) * purRate / 100);
                        //    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value) + Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value);
                        //}

                        // dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value) - Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["discount"].Value)).ToString();
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
                                dgvSaleItems.CurrentCell = dgvSaleItems[col + 5, row];
                            }
                        }
                    }
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
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
                foreach (DataGridViewRow rows in dgvSaleItems.Rows)
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
                            dgvSaleItems.Focus();
                            return;
                        }
                    }
                }

                dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dt.Rows[0]["itemId"]);
                dgvSaleItems.CurrentRow.Cells["stockInItemID"].Value = Convert.ToInt64(0);
                dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dt.Rows[0]["StockId"]);
                dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dt.Rows[0]["categoryId"]);
                dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dt.Rows[0]["companyId"]);
                dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dt.Rows[0]["batchNo"]);
                dgvSaleItems.CurrentRow.Cells["itemName"].Value = dt.Rows[0]["itemName"].ToString();
                dgvSaleItems.CurrentRow.Cells["HSNCode"].Value = dt.Rows[0]["HNSCode"].ToString();
                dgvSaleItems.CurrentRow.Cells["Quantity"].Value = 1;
                dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dt.Rows[0]["unitBy"].ToString();
                dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dt.Rows[0]["purchaseRate"].ToString());
                dgvSaleItems.CurrentRow.Cells["discount"].Value = 0;
                dgvSaleItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dt.Rows[0]["IGST"].ToString());
                dgvSaleItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dt.Rows[0]["CGST"].ToString());
                dgvSaleItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dt.Rows[0]["SGST"].ToString());
                dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value.ToString());

                double discount = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value.ToString())) / 100);
                double purRate = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value.ToString())));
                dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100);
                dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100);
                dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100);


                //if (cmbGST.SelectedItem.ToString() == "Other")
                //{
                //    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Convert.ToDouble(dt.Rows[0]["IGST"].ToString()) * purRate / 100);
                //}
                //else
                //{
                //    dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(dt.Rows[0]["CGST"].ToString()) * purRate / 100);
                //    dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(dt.Rows[0]["SGST"].ToString()) * purRate / 100);
                //    dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value) + Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value);
                //}

               // dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value) - Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["discount"].Value)).ToString();
                subtot();
                //  dgvSaleItems.Focus();
                dgvSaleItems.CurrentCell = dgvSaleItems.CurrentRow.Cells["Quantity"];
                dgvSaleItems.BeginEdit(true);
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }

        }
        void tb_TextChanged(Object sender, EventArgs e)
        {
            if (dgvSaleItems.CurrentRow.Cells["itemName"].Value == null)
            {
                dgvSaleItems.CurrentRow.Cells["itemId"].Value = null;
                dgvSaleItems.CurrentRow.Cells["stockInItemID"].Value = null;
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
                dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value = null;
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
                dgvSaleItems.CurrentRow.Cells["stockInItemID"].Value = dgvSaleItems.CurrentRow.Cells["stockInItemID"].Value;
                if (dgvSaleItems.CurrentCell.ColumnIndex == 7 || dgvSaleItems.CurrentCell.ColumnIndex == 9 || dgvSaleItems.CurrentCell.ColumnIndex == 10 || dgvSaleItems.CurrentCell.ColumnIndex == 12 || dgvSaleItems.CurrentCell.ColumnIndex == 14 || dgvSaleItems.CurrentCell.ColumnIndex == 16
                    || dgvSaleItems.CurrentCell.ColumnIndex == 17)
                {
                    if (dgvSaleItems.CurrentRow.Cells["Quantity"].Value != null && dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value != null && dgvSaleItems.CurrentRow.Cells["discount"].Value != null
                        && dgvSaleItems.CurrentRow.Cells["IGST"].Value != null && dgvSaleItems.CurrentRow.Cells["CGST"].Value != null && dgvSaleItems.CurrentRow.Cells["SGST"].Value != null)
                    {
                        dgvSaleItems.CurrentRow.Cells["HSNCode"].Value = dgvSaleItems.CurrentRow.Cells["HSNCode"].Value.ToString();
                        dgvSaleItems.CurrentRow.Cells["batchNo"].Value = dgvSaleItems.CurrentRow.Cells["batchNo"].Value.ToString();
                        dgvSaleItems.CurrentRow.Cells["Quantity"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString());
                        dgvSaleItems.CurrentRow.Cells["unitBy"].Value =dgvSaleItems.CurrentRow.Cells["unitBy"].Value.ToString();
                        dgvSaleItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["discount"].Value.ToString());
                        dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                        dgvSaleItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString());
                        dgvSaleItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString());
                        dgvSaleItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["SGST"].Value.ToString());
                        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Quantity"].Value) * Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value);
                        dgvItemName.Hide();
                        double purRate = (Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value.ToString()));
                         dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString())) * purRate / 100);
                            dgvSaleItems.CurrentRow.Cells["CGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["IGST"].Value.ToString())) / 2);
                            dgvSaleItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())));
                            dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100);
                            dgvSaleItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGSTAmt"].Value.ToString())));
                          dgvSaleItems.CurrentRow.Cells["IGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["CGST"].Value.ToString())) * 2);
                           
                       
                        // double discount = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["discount"].Value) * (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Quantity"].Value) * Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["Rate"].Value)) / 100);

                        // dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value = (Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["IGST"].Value) * purRate / 100);
                       // dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["IGSTAmt"].Value) - Convert.ToDouble(dgvSaleItems.CurrentRow.Cells["discount"].Value));
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
                if (chkIter.Checked == false)
                {
                    dtitem = SaleDetailsController.getStockInSaleItemDetails(value, "cash", false);
                }
                else
                {
                    dtitem = TempSaleDetailsController.getTempStockInSaleItemDetails(value, "cash");                 
                }
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
                    //dgvSaleItems.DataSource = null;
                }
            }
            else
            {

            }
            subtot();
        }
        private void subtot()
        {
            double sum = 0;
            for (int i = 0; i < dgvSaleItems.Rows.Count; ++i)
            {
                if (dgvSaleItems.Rows[i].Cells["totalAmount"].Value != null)
                {
                    sum += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["totalAmount"].Value.ToString());
                }
            }

            string netamount = txtNetAmount.Text;
            if (txtPaidAmount.Text == string.Empty)
            {
                txtNetAmount.Text = Math.Round(sum, 2).ToString();
            }
            else
            {
                txtNetAmount.Text = Math.Round(Utility.ParseValue(txtPaidAmount.Text) + sum, 2).ToString();
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

        private void frmStocIn_KeyDown(object sender, KeyEventArgs e)
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
        Int32 rowToDeleted;
        private void deleteRowToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (isUpdate == true)
                {
                    if (Convert.ToInt64(dgvSaleChallan.Rows[rowIndex].Cells["stockInItemID"].Value) >0)
                    {
                        stockInController.deleteStockInRow(Convert.ToInt64(txtInvoiceNo.Text), Convert.ToInt64(dgvSaleChallan.Rows[rowIndex].Cells["stockInItemID"].Value), Convert.ToInt64(dgvSaleChallan.Rows[rowIndex].Cells["itemId"].Value), Convert.ToInt64(dgvSaleChallan.Rows[rowIndex].Cells["categoryId"].Value), Convert.ToInt64(dgvSaleChallan.Rows[rowIndex].Cells["companyId"].Value), Convert.ToString(dgvSaleChallan.Rows[rowIndex].Cells["batchNo"].Value),
                                Utility.ParseValue(dgvSaleChallan.Rows[rowIndex].Cells["Quantity"].Value.ToString()));
                    }
                }
                rowToDeleted = dgvSaleItems.Rows.GetFirstRow(DataGridViewElementStates.Selected);
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

        private void chkIter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
