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
using System.Text.RegularExpressions;

namespace Dlogic_Wholesaler.Forms
{
    public partial class frmGodownTransfer : MetroForm
    {
        public frmGodownTransfer()
        {
            InitializeComponent();
        }
        bool isUpdate, isDelete = false;
        public string godownTransferId1 = "";

        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Godown Transfer";
                    label1.Text = "No:";
                    label2.Text = "Date:";
                    label3.Text = "From Godown:";
                    label4.Text = "To Godown:";                    
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    btnSaleInvoiceList.Text = "Bill List";
                    btnDelete.Text = "Delete";
                    label6.Text = "From Date:";
                    label5.Text = "To Date:";
                    btnShow.Text = "Show";
                    dgvGodownTransfer.Columns[6].HeaderText = "Item Name";
                    dgvGodownTransfer.Columns[7].HeaderText = "Batch No";
                    dgvGodownTransfer.Columns[8].HeaderText = "Unit By ";
                    dgvGodownTransfer.Columns[9].HeaderText = "MFD Date";
                    dgvGodownTransfer.Columns[10].HeaderText = "Expiry Date";
                    dgvGodownTransfer.Columns[11].HeaderText = "Quantity";

                    dgvGownTransferList.Columns[2].HeaderText = "Invoice Id";
                    dgvGownTransferList.Columns[3].HeaderText = "Date";
                    dgvGownTransferList.Columns[4].HeaderText = "From Godown";
                    dgvGownTransferList.Columns[5].HeaderText = "To Godown";
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmGodownTransfer_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                btnSave.Enabled = true;
                btnDelete.Enabled = false;        
                pnlUpdateTransfer.Visible = false;
                dgvList.Visible = false;
                 isUpdate= isDelete = false;
                 Lang();
                 dgvGodownTransfer.Rows.Clear();
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
                panel1.Enabled = true;             
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                pnlUpdateTransfer.Visible = false;
                dgvList.Visible = false;
                isUpdate= isDelete = false;
               if (Utility.Langn == "English")
                {
                    btnSave.Text = "Save";
                }
                else
                {
                    btnSave.Text = "जतन";
                }
                pnlgodownSearch.Visible = false;
                dtpDate.MaxDate = Utility.lastDate;
                dtpDate.MinDate = Utility.firstDate;
                godownTransferId1 = SaleDetailsController.getMaxIdSalesItemDetails(5, Utility.FinancilaYearId).ToString();
                txtInvoice.Text = SaleDetailsController.getMaxIdSalesItemDetails(6, Utility.FinancilaYearId).ToString();
                txtId.Text = godownTransferId1;
                dgvGodownTransfer.Rows.Clear();
                dgvGodownTransfer.Rows.Add();
                dgvGodownTransfer.Columns["itemName"].ReadOnly = false;
                BindFromGodownDetails();
                pnlUpdateTransfer.Visible = false;
                BindToGodownDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvGodownTransfer_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try{
            if (dgvGodownTransfer.IsCurrentCellDirty)
            {
                dgvGodownTransfer.CommitEdit(DataGridViewDataErrorContexts.Commit);
                try
                {
                    tb_TextChanged(sender, e);
                }
                catch (Exception ae)
                {
                    MessageBox.Show(ae.Message);
                }
            } }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindFromGodownDetails()
        {
            try
            {
                DataTable dtPaking = itemDetailsController.getGodownDetails();
                Utility.BindComboBoxEmptyDataSelect(cmbFromGodown, dtPaking, "godown", "godownName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindToGodownDetails()
        {
            try
            {
                DataTable dtPaking = itemDetailsController.getGodownDetails();
                Utility.BindComboBoxEmptyDataSelect(cmbtoGodown, dtPaking, "godown", "godownName");
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
                if (dgvGodownTransfer.CurrentRow.Cells["itemName"].Value == null)
                {
                    dgvGodownTransfer.CurrentRow.Cells["stockId"].Value = null;
                    dgvGodownTransfer.CurrentRow.Cells["itemId"].Value = null;
                    dgvGodownTransfer.CurrentRow.Cells["batchNo"].Value = null;
                    dgvGodownTransfer.CurrentRow.Cells["unitBy"].Value = null;
                    dgvGodownTransfer.CurrentRow.Cells["stockIdTo"].Value = 0;
                    dgvGodownTransfer.CurrentRow.Cells["companyId"].Value = null;
                    dgvGodownTransfer.CurrentRow.Cells["categoryId"].Value = null;
                    dgvGodownTransfer.CurrentRow.Cells["productCode"].Value = null;
                    dgvGodownTransfer.CurrentRow.Cells["Quantity"].Value = null;
                    dgvGodownTransfer.CurrentRow.Cells["MFD_Date"].Value = null;
                    dgvGodownTransfer.CurrentRow.Cells["expireDate"].Value = null;
                    dgvGodownTransfer.CurrentRow.Cells["godownTransfertemId"].Value = 0;
                    dgvGownTransferList.Hide();
                    return;
                }
                string value = null;
                if (dgvGodownTransfer.CurrentCell.ColumnIndex == 6)
                {
                    value = dgvGodownTransfer.CurrentRow.Cells["itemName"].Value.ToString();
                }
                else
                {
                    if (dgvGodownTransfer.CurrentRow.Cells["Quantity"].Value != null)
                    {
                        dgvGodownTransfer.CurrentRow.Cells["Quantity"].Value = Utility.ParseValue(dgvGodownTransfer.CurrentRow.Cells["Quantity"].Value.ToString());
                    }
                }
                if (value != null)
                {


                    DataTable dtitem = null;
                    dtitem = godownTransferController.getStockInGodownTransferSearch(value, "",cmbFromGodown.Text.Trim());                   
                    if (dtitem.Rows.Count > 0)
                    {
                        dgvList.DataSource = dtitem;
                        dgvList.Columns[0].Visible = false;
                        dgvList.Columns[1].Width = 500;
                        dgvList.ClearSelection();
                        this.dgvList.CellBorderStyle = DataGridViewCellBorderStyle.None;
                        pnlgodownSearch.Visible = true;
                        dgvList.Show();
                        //dgvItemName.Focus();
                        //dgvItemName.CurrentCell = dgvItemName.Rows[0].Cells[1];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
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
        protected void getDataFronCurentRow(int rowIndex)
        {
            try
            {
                dgvList.Hide();
                long StockId = Convert.ToInt64(dgvList.Rows[rowIndex].Cells["itemId"].Value);
                DataTable dt = itemDetailsController.getStockInItemDetailsbyStockId(StockId);
                if(dt.Rows.Count>0)
                {
                    dgvGodownTransfer.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dt.Rows[0]["itemId"]);

                    dgvGodownTransfer.CurrentRow.Cells["stockId"].Value = Convert.ToInt64(dt.Rows[0]["stockId"]);
                    dgvGodownTransfer.CurrentRow.Cells["categoryId"].Value = Convert.ToInt64(dt.Rows[0]["categoryId"]);
                    dgvGodownTransfer.CurrentRow.Cells["companyId"].Value = Convert.ToInt64(dt.Rows[0]["companyId"]);
                    dgvGodownTransfer.CurrentRow.Cells["productCode"].Value = (dt.Rows[0]["productCode"]).ToString();
                    dgvGodownTransfer.CurrentRow.Cells["itemName"].Value = (dt.Rows[0]["itemName"]).ToString();
                    dgvGodownTransfer.CurrentRow.Cells["batchNo"].Value = (dt.Rows[0]["batchNo"]).ToString();
                    dgvGodownTransfer.CurrentRow.Cells["MFD_Date"].Value = (dt.Rows[0]["MFD_Date"]).ToString();
                    dgvGodownTransfer.CurrentRow.Cells["expireDate"].Value =dt.Rows[0]["expireDate"].ToString();
                    dgvGodownTransfer.CurrentRow.Cells["unitBy"].Value = dt.Rows[0]["unitBy"].ToString();
                    dgvGodownTransfer.CurrentRow.Cells["Quantity"].Value = 0;
                    dgvGodownTransfer.CurrentRow.Cells["stockIdTo"].Value = 0;
                    dgvGodownTransfer.CurrentRow.Cells["godownTransfertemId"].Value = 0;
                    dgvGodownTransfer.CurrentCell = dgvGodownTransfer.CurrentRow.Cells["Quantity"];
                    dgvGodownTransfer.BeginEdit(true);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       public int rowIndex = 0;
        Int32 rowToDelete;
        private void dgvGodownTransfer_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try{
                if(isUpdate==false && isDelete==false)
                if (e.Button == MouseButtons.Right)
                {
                    this.dgvGodownTransfer.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.contextMenuStrip1.Show(this.dgvGodownTransfer, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
               }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rowToDelete = dgvGodownTransfer.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                dgvGodownTransfer.Rows.RemoveAt(rowToDelete);
                dgvGodownTransfer.ClearSelection();
                if (dgvGodownTransfer.Rows.Count == 0)
                {
                    dgvGodownTransfer.Rows.Add();
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
                if (cmbFromGodown.SelectedIndex == 0 || cmbFromGodown.SelectedValue == null)
                {
                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please select From Godown...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया From गोडाऊन निवडा...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cmbFromGodown.Focus(); return;
                }
                if (cmbtoGodown.SelectedIndex == 0 || cmbtoGodown.SelectedValue == null)
                {                  
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please select To Godown...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया To गोडाऊन निवडा...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cmbtoGodown.Focus(); return;
                }
                if (cmbFromGodown.Text.Trim() == cmbtoGodown.Text.Trim())
                {
                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Change To Godown...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया To गोडाऊन बदला...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cmbtoGodown.Focus(); return;
                }
                for (int c = 0; c < dgvGodownTransfer.Rows.Count; c++)
                {
                    if (dgvGodownTransfer.Rows[c].Cells["itemName"].Value == null)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add Item Name in list..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये वस्तूचे नाव भरा..");
                        }
                        dgvGodownTransfer.Focus();
                        dgvGodownTransfer.CurrentCell = dgvGodownTransfer.Rows[c].Cells["itemName"];
                        return;
                    }
                    if (dgvGodownTransfer.Rows[c].Cells["Quantity"].Value == null ||Convert.ToDouble(dgvGodownTransfer.Rows[c].Cells["Quantity"].Value)==0)
                    {
                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add Quantity in list..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया लिस्ट मध्ये वस्तूचे नाव भरा..");
                        }
                        dgvGodownTransfer.Focus();
                        dgvGodownTransfer.CurrentCell = dgvGodownTransfer.Rows[c].Cells["Quantity"];
                        return;
                    }
                }
               
                godownTransfer gm = new godownTransfer();
                if (isUpdate == false && isDelete==false)
                {
                    gm.godownTransferId=SaleDetailsController.getMaxIdSalesItemDetails(5, Utility.FinancilaYearId);
                    gm.invoiceId = SaleDetailsController.getMaxIdSalesItemDetails(6, Utility.FinancilaYearId);
                }
                else
                {
                    gm.godownTransferId = Convert.ToInt64(txtId.Text);
                    gm.invoiceId = Convert.ToInt64(txtInvoice.Text);
                }
                gm.godownTransferDate = dtpDate.Value;
                gm.fromGodownTransfer = cmbFromGodown.Text.Trim();
                gm.toGodownTransfer = cmbtoGodown.Text.Trim();
                gm.isDelete = isDelete;
                gm.isUpdate = isUpdate;
                DataTable dtSaleItems = new DataTable();
                foreach (DataGridViewColumn col in dgvGodownTransfer.Columns)
                {
                    dtSaleItems.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dgvGodownTransfer.Rows)
                {
                    DataRow dRow = dtSaleItems.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null)
                        {                           
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Please add all details in list");
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
                gm.dtItems = dtSaleItems;
                gm.FinancialYearID = Utility.FinancilaYearId;
                gm.addedBy = 1;
                gm.addedOn = dtpDate.Value;
                
                int i = 0;
                string msg = "";
                if (isDelete == false)
                {               
                  if (Utility.Langn == "English")
                    {
                        msg = "Record Saved successfully !! ";
                    }
                    else
                    {
                        msg = "माहिती यशस्वीरित्या साठवल्या गेली !! ";
                    }
                     i = godownTransferController.addGodownTransfer(gm);
                }
                if (isDelete == true)
                {               
                   if (Utility.Langn == "English")
                    {
                        msg = "Record Deleted successfully!! ";
                    }
                    else
                    {
                        msg = "माहिती यशस्वीरित्या   डिलीट  झाली आहे!! ";
                    }
                    i = godownTransferController.addGodownTransfer(gm);
                }
                if (i > 0)
                {

                    MessageBox.Show(msg, "जतन", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnnew_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvGodownTransfer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (isUpdate == false && isDelete == false)
                if (e.KeyData == Keys.Enter)
                {
                    int col = dgvGodownTransfer.CurrentCell.ColumnIndex;
                    int row = dgvGodownTransfer.CurrentCell.RowIndex;
                    if (dgvGodownTransfer.CurrentCell.ColumnIndex == 11)
                    {
                        col = 0;
                        row++;
                    }
                    else
                    {
                        if (col < dgvGodownTransfer.ColumnCount)
                        {
                            col++;
                        }
                        else
                        {
                            col = 0;
                            row++;
                        }
                    }
                    if (dgvGodownTransfer.CurrentRow.Cells["itemId"].Value == null)
                    {
                        dgvList.Focus();
                        dgvList.CurrentCell = dgvList.CurrentRow.Cells["itemName"];
                        dgvList.CurrentCell.Selected = true;
                    }
                    else
                    {
                        if (dgvGodownTransfer.CurrentRow.Cells["itemName"].Value != null)
                        {
                            if (row == dgvGodownTransfer.RowCount)
                            {
                                dgvGodownTransfer.Rows.Add();
                                dgvGodownTransfer.CurrentCell = dgvGodownTransfer[col + 6, row];
                            }                           
                            else
                            {
                                dgvGodownTransfer.CurrentCell = dgvGodownTransfer[col, row];
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

        private void btnSaleInvoiceList_Click(object sender, EventArgs e)
        {
            try
            {
                pnlgodownSearch.Visible = true;
                pnlUpdateTransfer.Visible = true;
                dgvGownTransferList.Show();
                dgvList.Hide();
                dtpFromChallanDate.Enabled = true;
                dtpToChallanDate.Enabled = true;
                dgvGownTransferList.DataSource = godownTransferController.getGodowntransferList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()),
                    Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()), "GodowntransferList", Utility.FinancilaYearId, 0);

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
                pnlgodownSearch.Visible = true;
                pnlUpdateTransfer.Visible = true;
                dgvGownTransferList.Show();
                dgvList.Hide();
                dtpFromChallanDate.Enabled = true;
                dtpToChallanDate.Enabled = true;
                dgvGownTransferList.DataSource = godownTransferController.getGodowntransferList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()),
                    Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()), "GodowntransferList", Utility.FinancilaYearId, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvGownTransferList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                long godownTransferId12 = 0;
                if (e.RowIndex >= 0)
                {
                    godownTransferId12 = Convert.ToInt64(dgvGownTransferList.CurrentRow.Cells["godownTransferId"].Value);
                }
                BindData(godownTransferId12);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindData(long godownTransferId12)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                BindFromGodownDetails();            
                BindToGodownDetails();
                btnSave.Enabled = true;
                pnlgodownSearch.Visible = false;
                pnlUpdateTransfer.Visible = false;
                dgvGodownTransfer.Rows.Clear();
                dgvGodownTransfer.Rows.Add();
                dgvGodownTransfer.Enabled = true;
                btnDelete.Enabled = true;
                panel1.Enabled = false;
                isDelete = false;
                isUpdate = true;
                DataTable dtGodown = godownTransferController.getGodowntransferList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()),
                  Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()), "GodowntransferById", Utility.FinancilaYearId, godownTransferId12);
                if (dtGodown.Rows.Count > 0)
                {
                    godownTransferId1 = godownTransferId12.ToString();
                    txtInvoice.Text = dtGodown.Rows[0]["invoiceId"].ToString();
                    txtId.Text = godownTransferId1;
                    dtpDate.Value = Convert.ToDateTime(dtGodown.Rows[0]["godownTransferDate"]);
                    cmbFromGodown.Text = dtGodown.Rows[0]["fromGodownTransfer"].ToString();
                    cmbtoGodown.Text = dtGodown.Rows[0]["toGodownTransfer"].ToString();
                    foreach (DataRow dr in dtGodown.Rows)
                    {
                        dgvGodownTransfer.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                        dgvGodownTransfer.CurrentRow.Cells["stockId"].Value = Convert.ToInt64(dr["stockIdFrom"]);
                        dgvGodownTransfer.CurrentRow.Cells["categoryId"].Value = Convert.ToInt64(dr["categoryId"]);
                        dgvGodownTransfer.CurrentRow.Cells["companyId"].Value = Convert.ToInt64(dr["companyId"]);
                        dgvGodownTransfer.CurrentRow.Cells["productCode"].Value = (dr["productCode"]).ToString();
                        dgvGodownTransfer.CurrentRow.Cells["itemName"].Value = (dr["itemName"]).ToString();
                        dgvGodownTransfer.CurrentRow.Cells["itemName"].ReadOnly = true;
                        dgvGodownTransfer.CurrentRow.Cells["batchNo"].Value = (dr["batchNo"]).ToString();
                        dgvGodownTransfer.CurrentRow.Cells["MFD_Date"].Value = (dr["MFGDate"]).ToString();
                        dgvGodownTransfer.CurrentRow.Cells["expireDate"].Value = dr["exprireDate"].ToString();
                        dgvGodownTransfer.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                        dgvGodownTransfer.CurrentRow.Cells["Quantity"].Value = dr["Quantity"].ToString();
                        dgvGodownTransfer.CurrentRow.Cells["stockIdTo"].Value = dr["stockIdTo"].ToString();
                        dgvGodownTransfer.CurrentRow.Cells["godownTransfertemId"].Value = dr["godownTransfertemId"].ToString();
                        int col = dgvGodownTransfer.CurrentCell.ColumnIndex;
                        int row = dgvGodownTransfer.CurrentCell.RowIndex;
                        col = 0;
                        row++;
                        if (dgvGodownTransfer.Rows.Count < dtGodown.Rows.Count)
                        {
                            if (row == dgvGodownTransfer.RowCount)
                            {
                                dgvGodownTransfer.Rows.Add();
                                dgvGodownTransfer.CurrentCell = dgvGodownTransfer[col + 6, row];
                            }
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
                isDelete = true;
                isUpdate = false;
                btnSave_Click(sender, e);
            } 
            catch (Exception ex)
            {
               
            }
        }

        private void frmGodownTransfer_KeyDown(object sender, KeyEventArgs e)
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
