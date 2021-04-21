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
    public partial class frmDamagedStockExpiry : MetroForm
    {
        public frmDamagedStockExpiry()
        {
            InitializeComponent();
        }

        private void frmDamagedStockExpiry_Load(object sender, EventArgs e)
        {
         
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = false;
                grbList.Visible = false;
                dgvItemName.Hide();
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                isUpdate = false;
                isDelete = false;
                Lang();
                dtpChallenDate.MaxDate = Utility.lastDate;
                dtpChallenDate.MinDate = Utility.firstDate;
                if (dtpChallenDate.Value < Utility.firstDate || dtpChallenDate.Value > Utility.lastDate)
                {
                    dtpChallenDate.Value = Utility.firstDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool isUpdate { get; set; }

        public bool isDelete { get; set; }
        public void bindaccountName(Boolean Active_Type)
        {
            DataTable dtaccountname = accountDetailsController.getExensesAccount();
            Utility.BindComboBoxDataSelect(cmbAccountName, dtaccountname, "AccountID", "AccountName");
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Damaged Stock/Expiry";
                    metroLabel2.Text = "No:";
                    metroLabel1.Text = "Date:";
                    label1.Text = "Account Name:";
                    label1.Text = "Conversion Qty:";
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    btnChallanList.Text = "List";
                    btnDelete.Text = "Delete";
                    lblNetBill.Text = "Total Amount:";
                    label4.Text = "Naration:";
                    label2.Text = "From Date:";
                    label3.Text = "To Date:";
                    btnShow.Text = "Show";
                    dgvSaleItems.Columns[5].HeaderText = "Naration";
                    dgvSaleItems.Columns[6].HeaderText = "Batch No";
                    dgvSaleItems.Columns[7].HeaderText = "MFD Date";
                    dgvSaleItems.Columns[8].HeaderText = "Expiry Date";
                    dgvSaleItems.Columns[9].HeaderText = "UnitBy";
                    dgvSaleItems.Columns[10].HeaderText = "Quantity";
                    dgvSaleItems.Columns[11].HeaderText = "Rate";
                    dgvSaleItems.Columns[12].HeaderText = "Amount";

                    dgvUpdateList.Columns[2].HeaderText = "Invoice Id";
                    dgvUpdateList.Columns[3].HeaderText = "Date";
                    dgvUpdateList.Columns[4].HeaderText = "Remark";
                    dgvUpdateList.Columns[5].HeaderText = "Amount";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                grbList.Visible = false;
                dgvItemName.Hide();
                dgvSaleItems.Rows.Clear();
                dgvSaleItems.Rows.Add();
                isUpdate = false;
                isDelete = false;
                dtpChallenDate.MaxDate = Utility.lastDate;
                dtpChallenDate.MinDate = Utility.firstDate;
                if (dtpChallenDate.Value < Utility.firstDate || dtpChallenDate.Value > Utility.lastDate)
                {
                    dtpChallenDate.Value = Utility.firstDate;
                }
                dtpFromChallanDate.MinDate = Utility.firstDate;
                dtpFromChallanDate.MaxDate = Utility.lastDate;
                dtpToChallanDate.MinDate = Utility.firstDate;
                dtpToChallanDate.MaxDate = Utility.lastDate;
                dtpFromChallanDate.Value = Utility.firstDate;
                dtpToChallanDate.Value = Utility.lastDate;
                txtInvoice.Text = SaleDetailsController.getMaxIdSalesItemDetails(7, Utility.FinancilaYearId).ToString();
                bindaccountName(true);
                damagedStockExpiryId = 0; transactionId = 0;
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

        private void tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvSaleItems.CurrentRow.Cells["itemName"].Value == null)
                {
                    dgvSaleItems.CurrentRow.Cells["itemId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["damagedStockExpiryItemId"].Value = 0;
                    dgvSaleItems.CurrentRow.Cells["companyId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["categoryId"].Value = null;               
                    dgvSaleItems.CurrentRow.Cells["batchNo"].Value = null;               
                    dgvSaleItems.CurrentRow.Cells["StockId"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["Quantity"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["unitBy"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value = null;
                    dgvSaleItems.CurrentRow.Cells["expireDate"].Value = null;
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
                    if(dgvSaleItems.CurrentRow.Cells["Quantity"].Value != null && dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value != null)
                    {
                        dgvSaleItems.CurrentRow.Cells["Quantity"].Value=Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString());
                        dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value.ToString());

                        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                    }
                    else
                    {
                        dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = 0;
                    }
                }
                if (value != null)
                {
                    DataTable dtitem = null;
                    dtitem = itemDetailsController.getStockInItemDetails(value);
                    if (dtitem.Rows.Count > 0)
                    {
                        dgvItemName.DataSource = dtitem;
                        dgvItemName.Columns[0].Visible = false;
                        //dgvItemName.Columns[1].Width = 500;
                        dgvItemName.ClearSelection();
                        this.dgvItemName.CellBorderStyle = DataGridViewCellBorderStyle.None;
                      
                        dgvItemName.Show();
                        grbList.Visible = false;
                      //  dgvSaleItems.DataSource = null;
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
                for (int i = 0; i < dgvSaleItems.Rows.Count; ++i)
                {
                    if (dgvSaleItems.Rows[i].Cells["totalAmount"].Value != null)
                    {
                        sum += Utility.ParseValue(dgvSaleItems.Rows[i].Cells["totalAmount"].Value.ToString());
                    }
                }
                txtNetAmount.Text = sum.ToString();
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
                    if (col < dgvSaleItems.ColumnCount)
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
                             else
                            {
                                dgvSaleItems.CurrentCell = dgvSaleItems[col, row];
                            }
                        }
                    }
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
                if (e.KeyData == Keys.Enter)
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

        private void getDataFronCurentRow(int rowIndex)
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

        private void bindSaleItem(long StockId)
        {
            try
            {
                dgvItemName.Hide();
                DataTable dt = itemDetailsController.getStockInItemDetailsbyStockId(StockId);
                dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dt.Rows[0]["itemId"]);
                dgvSaleItems.CurrentRow.Cells["damagedStockExpiryItemId"].Value = 0;
              
                dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dt.Rows[0]["StockId"]);
                dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dt.Rows[0]["categoryId"]);
                dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dt.Rows[0]["companyId"]);
                dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dt.Rows[0]["batchNo"]);
                dgvSaleItems.CurrentRow.Cells["itemName"].Value = dt.Rows[0]["itemName"].ToString();
                dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value = dt.Rows[0]["MFD_Date"].ToString();
                dgvSaleItems.CurrentRow.Cells["expireDate"].Value = dt.Rows[0]["expireDate"].ToString();
                dgvSaleItems.CurrentRow.Cells["Quantity"].Value = 1;
                dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dt.Rows[0]["unitBy"].ToString();
                dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dt.Rows[0]["purchaseRate"].ToString());
              
                dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                subtot();             
                dgvSaleItems.CurrentCell = dgvSaleItems.CurrentRow.Cells["Quantity"];
                dgvSaleItems.BeginEdit(true);
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
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < dgvSaleItems.Rows.Count; i++)
                {
                    if (dgvSaleItems.Rows[i].Cells["itemName"].Value == null)
                    {                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add Item Name in list ...!");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये वस्तूचे नाव भरा..");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells["itemName"];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells["Quantity"].Value == null)
                    {                      
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Quantity in list ...!");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये नग भरा..");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells["Quantity"];
                        return;
                    }
                    if (dgvSaleItems.Rows[i].Cells["purchaseRate"].Value == null)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add Rate in list ...!");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट  मध्ये दर भरा..");
                        }
                        dgvSaleItems.Focus();
                        dgvSaleItems.CurrentCell = dgvSaleItems.Rows[i].Cells["purchaseRate"];
                        return;
                    }
                }
                damagedStockExpiry sale = new damagedStockExpiry();
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
                                MessageBox.Show("Please Add all details in list");
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
                sale.dtItems = dtSaleItems;
                sale.damagedStockDate = dtpChallenDate.Value;
                if(isUpdate==false)
                {
                    sale.damagedStockExpiryId = 0;                   
                    sale.InvoiceId = SaleDetailsController.getMaxIdSalesItemDetails(7, Utility.FinancilaYearId);
                }
                else
                {
                    sale.damagedStockExpiryId = damagedStockExpiryId;
                    sale.InvoiceId = Convert.ToInt64(txtInvoice.Text);
                }
                sale.transactionId = transactionId;
                sale.Amount = Utility.ParseValue(txtNetAmount.Text);
                sale.Remark = txtNaration.Text;
                sale.addedBy = Utility.LoginID;
                sale.accountId = Convert.ToInt64(cmbAccountName.SelectedValue);
                sale.isDelete = isDelete;
                sale.isUpdate = isUpdate;
                sale.FinancialYearID = Utility.FinancilaYearId;
                sale.addedOn = dtpChallenDate.Value;
                sale.transactionId = 0;
                int s = damagedStockExpiryController.adddamagedStockExpiry(sale);
                if(s>0)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("This record saved successfully..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("सदर नोंद यशस्वीरित्या साठवले गेले आहे..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    btnnew_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public long damagedStockExpiryId = 0;

        private void btnChallanList_Click(object sender, EventArgs e)
        {
            try
            {
                grbList.Visible = true;
                dgvUpdateList.Show(); dtpFromChallanDate.Enabled = true;
                dtpToChallanDate.Enabled = true;
                dtpFromChallanDate.Value = Utility.firstDate;
                dtpToChallanDate.Value = Utility.lastDate;
                dgvUpdateList.DataSource = godownTransferController.getGodowntransferList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()),
                   Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()), "damagedStockExpiry", Utility.FinancilaYearId, 0);
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
                dgvUpdateList.DataSource = godownTransferController.getGodowntransferList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()),
                  Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()), "damagedStockExpiry", Utility.FinancilaYearId, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUpdateList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long SalesChallanBillId = 0;
            if (e.RowIndex >= 0)
            {
                SalesChallanBillId = Convert.ToInt64(dgvUpdateList.CurrentRow.Cells["damagedStockExpiryId1"].Value);
            }
            BindData(SalesChallanBillId);
        }

        private void BindData(long SalesChallanBillId)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                grbList.Visible = false;
                dgvSaleItems.Rows.Clear();
                bindaccountName(true);
                dgvSaleItems.Rows.Add();
                dgvSaleItems.Enabled = true;
                btnDelete.Enabled = true;
                isDelete = false;
                isUpdate = true;
             DataTable dt=   godownTransferController.getGodowntransferList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()),
                   Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()), "damagedStockById", Utility.FinancilaYearId, SalesChallanBillId);
             if (dt.Rows.Count > 0)
             {
                 txtInvoice.Text = Convert.ToString(dt.Rows[0]["InvoiceId"]);
                 damagedStockExpiryId = SalesChallanBillId;
                 cmbAccountName.SelectedValue = Convert.ToInt64(dt.Rows[0]["accountId"]);
              transactionId=   Convert.ToInt64(dt.Rows[0]["transactionId"]);
                 dtpChallenDate.Value = Convert.ToDateTime(dt.Rows[0]["damagedStockDate"]);
                 foreach (DataRow dr in dt.Rows)
                 {
                     dgvSaleItems.CurrentRow.Cells["damagedStockExpiryItemId"].Value = Convert.ToInt64(dr["damagedStockExpiryItemId"]);
                     dgvSaleItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                     dgvSaleItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dr["StockId"]);
                     dgvSaleItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                     dgvSaleItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                     dgvSaleItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                     dgvSaleItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                     dgvSaleItems.CurrentRow.Cells["itemName"].ReadOnly = true;
                     dgvSaleItems.CurrentRow.Cells["Quantity"].Value = dr["Quantity"].ToString();
                     dgvSaleItems.CurrentRow.Cells["MFD_Date"].Value = Convert.ToDateTime(dr["MFD_Date"]).ToShortDateString();
                     dgvSaleItems.CurrentRow.Cells["expireDate"].Value = Convert.ToDateTime(dr["expireDate"]).ToShortDateString();// dr["expireDate"].ToString();
                     dgvSaleItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                     dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value = dr["purchaseRate"].ToString();
                     dgvSaleItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvSaleItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                   
                 }
                 txtNetAmount.Text = dt.Rows[0]["Amount"].ToString();
                 txtNaration.Text = dt.Rows[0]["Remark"].ToString();
             }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public long transactionId = 0;

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

        private void frmDamagedStockExpiry_KeyDown(object sender, KeyEventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
