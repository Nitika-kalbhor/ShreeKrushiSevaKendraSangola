using DataAccessLayer.controller;
using DataAccessLayer.models;
using Dlogic_Wholesaler.CrystalReport;
using Dlogic_Wholesaler.ReportFrom;
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
    public partial class frmPurchasseOrder : MetroFramework.Forms.MetroForm
    {
        public frmPurchasseOrder()
        {
            InitializeComponent();
        }
        private bool isUpDate = false;
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Purchase Order";
                    metroLabel2.Text = "Bill No:";
                    metroLabel1.Text = "Date:";
                    lblstockInNo.Text = "Dealer Name:";
                    metroLabel3.Text = "Mobile No:";
                    btnNewItem.Text = "New Item";
                    lblNetBill.Text = "Total Amount:";
                    lblPaidAmount.Text = "Paid Amount:";
                    lblBakiAmount.Text = "Pending Amount:";
                    btnDelete.Text = "Delete";
                    btnChallanList.Text = "Purchase Order List";                   
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";                  
                    label2.Text = "From Date:";
                    label3.Text = "To Date:";
                    btnShow.Text = "Show";

                    dgvPurchaseItems.Columns[4].HeaderText = "Naration";
                    dgvPurchaseItems.Columns[5].HeaderText = "Batch No";
                    dgvPurchaseItems.Columns[6].HeaderText = "Quantity";
                    dgvPurchaseItems.Columns[7].HeaderText = "Unit By";
                    dgvPurchaseItems.Columns[8].HeaderText = "freeQuantity";
                    dgvPurchaseItems.Columns[9].HeaderText = "Pur.Rate";
                    dgvPurchaseItems.Columns[10].HeaderText = "MRP";
                    dgvPurchaseItems.Columns[19].HeaderText = "Amount";
                 
                    dgvSaleChallan.Columns[0].HeaderText = "Order No.";
                    dgvSaleChallan.Columns[1].HeaderText = "Dealer Name";
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
        private void frmPurchasseOrder_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);
                isUpDate = false;
                btnSave.Enabled = false;
                dgvPurchaseItems.Rows.Add();
                // dgvPurchaseItems.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
                //  dgvPurchaseItems.RowHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
                BindComboBoxgetDealerName();
                dgvItemName.Hide();
                dgvPurchaseItems.Enabled = false;
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
        public void BindComboBoxgetDealerName()
        {
            DataTable dtgetDealerName = DealerController.getDealerDetails();
            Utility.BindComboBoxDataSelect(cmbDealerName, dtgetDealerName, "dealerId", "dealerFirmName");
        }
        Int32 rowToDelete;
        public int rowIndex = 0;
        long purchaseChalanId = 0;
        bool isDelete = false;
        private void dgvPurchaseItems_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.dgvPurchaseItems.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.contextMenuStrip1.Show(this.dgvPurchaseItems, e.Location);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPurchaseItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
                if (dgvPurchaseItems.CurrentCell.ColumnIndex == 6 ||
                    dgvPurchaseItems.CurrentCell.ColumnIndex == 9 ||
                    dgvPurchaseItems.CurrentCell.ColumnIndex == 10 ||
                    dgvPurchaseItems.CurrentCell.ColumnIndex == 19  ) //Desired Column
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

        private void dgvPurchaseItems_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    int col = dgvPurchaseItems.CurrentCell.ColumnIndex;
                    int row = dgvPurchaseItems.CurrentCell.RowIndex;
                    if (col < dgvPurchaseItems.ColumnCount - 1)
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
                                dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 4, row];
                            }
                            else if (dgvPurchaseItems.CurrentCell.ColumnIndex == 7)
                            {
                                dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 1, row];
                            }
                            else if (dgvPurchaseItems.CurrentCell.ColumnIndex == 10)
                            {
                                dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 8, row];
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
        void tb_TextChanged(Object sender, EventArgs e)
        {
            try
            {
                if (dgvPurchaseItems.CurrentRow.Cells["itemName"].Value == null)
                {
                    dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = null;
                    //  dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = null;
                    //dgvPurchaseItems.CurrentRow.Cells["wholeSalesCreditRate"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["MRP"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = null;
                    dgvItemName.Hide();
                    return;
                }
                string value = null;
                if (dgvPurchaseItems.CurrentCell.ColumnIndex == 4)
                {
                    value = dgvPurchaseItems.CurrentRow.Cells["itemName"].Value.ToString();
                }
                else
                {
                    if (dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value != null && dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value != null &&
                       dgvPurchaseItems.CurrentRow.Cells["discount"].Value != null && dgvPurchaseItems.CurrentRow.Cells["IGST"].Value != null
                       && dgvPurchaseItems.CurrentRow.Cells["CGST"].Value != null &&
                       dgvPurchaseItems.CurrentRow.Cells["SGST"].Value != null && dgvPurchaseItems.CurrentRow.Cells["MRP"].Value != null &&
                       dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value != null)
                    {
                        //dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString());
                        //   dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());

                        dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString())) * Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())),2);
                        //    double discount = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString())) * (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()))) / 100));
                        double purRate = (Convert.ToDouble(Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString())) * Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()))));

                        //if (cmbGST.SelectedItem.ToString() == "Other")
                        //{
                        //    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())) * purRate / 100);
                        //    dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())) / 2);
                        //    dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())));
                        //    dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100);
                        //    dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString())));
                        //}
                        //else
                        //{
                        dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100);
                        dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())));
                        dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()))) + (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString())));
                        dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString())));
                        dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());

                        //  }
                        dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Convert.ToDouble(purRate + Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString())) - Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()))),2).ToString();
                        dgvItemName.Hide();
                    }
                    else
                    {
                        dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = 0;
                    }
                }
                if (value != null)
                {
                    DataTable dtitem = itemDetailsController.getStockInItemDetails(value);
                    if (dtitem.Rows.Count > 0)
                    {
                        grbItemList.Visible = true;
                        grbChallanList.Visible = false;
                        dgvItemName.DataSource = dtitem;
                        dgvItemName.Columns[0].Visible = false;
                        dgvItemName.Columns[1].Width = 500;
                        dgvItemName.ClearSelection();
                        this.dgvItemName.CellBorderStyle = DataGridViewCellBorderStyle.None;
                        dgvItemName.Show();
                    }
                }
                else
                {

                }
                subtot();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
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
            txtNetAmount.Text = Convert.ToInt64(sum).ToString();
        }
        private void dgvItemName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                   int rowIndex = dgvItemName.CurrentCell.OwningRow.Index;
                   getDataFronCurentRow(rowIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected void getDataFronCurentRow(int rowIndex)
        {
            dgvItemName.Hide();
            DataGridViewRow row = this.dgvItemName.Rows[rowIndex];
            if (row.Cells != null)
            {
                long StockId = Convert.ToInt64(dgvItemName.CurrentRow.Cells["itemId"].Value);
                DataTable dt = itemDetailsController.getStockInItemDetailsbyStockId(StockId);

                foreach (DataGridViewRow rows in dgvPurchaseItems.Rows)
                {
                    if (rows.Cells["itemId"].Value != null && rows.Cells["companyId"].Value != null && rows.Cells["categoryId"].Value != null && rows.Cells["batchNo"].Value != null && rows.Cells["itemName"].Value != null)
                    {
                        if (rows.Cells["itemId"].Value.ToString().Equals(dt.Rows[0]["itemId"].ToString()) && rows.Cells["companyId"].Value.ToString().Equals(dt.Rows[0]["companyId"].ToString()) && rows.Cells["categoryId"].Value.ToString().Equals(dt.Rows[0]["categoryId"].ToString()) && rows.Cells["batchNo"].Value.ToString().Equals(dt.Rows[0]["batchNo"].ToString()) && rows.Cells["itemName"].Value.ToString().Equals(dt.Rows[0]["itemName"].ToString()))
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("This details already present in list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dgvPurchaseItems.CurrentRow.Cells["stockId"].Value = Convert.ToInt64(dt.Rows[0]["StockId"]);
                dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dt.Rows[0]["companyId"]);
                dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dt.Rows[0]["categoryId"]);
                dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dt.Rows[0]["batchNo"]);
                dgvPurchaseItems.CurrentRow.Cells["itemName"].Value = dt.Rows[0]["itemName"].ToString();
                dgvPurchaseItems.CurrentRow.Cells["MRP"].Value = dt.Rows[0]["MRP"].ToString();
                dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = 1;
                dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = dt.Rows[0]["unitBy"].ToString();
                dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = 0;
                dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dt.Rows[0]["purchaseRate"].ToString());
                dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dt.Rows[0]["salesCashRate"].ToString());
                //dgvPurchaseItems.CurrentRow.Cells["salesCreditRate"].Value = 0;
                //dgvPurchaseItems.CurrentRow.Cells["wholeSalesCashRate"].Value = 0;
                //dgvPurchaseItems.CurrentRow.Cells["wholeSalesCreditRate"].Value = 0;
                dgvPurchaseItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue("0");
                dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dt.Rows[0]["IGST"].ToString());
                dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dt.Rows[0]["CGST"].ToString());
                dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dt.Rows[0]["SGST"].ToString());
                dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()),2);

                //   double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())) / 100);
                double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())));

                //if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                //{
                //    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dt.Rows[0]["IGST"].ToString()) * purRate / 100);
                //}
                //else
                //{
                dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dt.Rows[0]["CGST"].ToString()) * purRate / 100);
                dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dt.Rows[0]["SGST"].ToString()) * purRate / 100);
                dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());
              //  }
                dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Math.Round((purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString())),2).ToString();
                subtot();
                dgvPurchaseItems.CurrentCell = dgvPurchaseItems.CurrentRow.Cells["Quantity"];
                dgvPurchaseItems.BeginEdit(true);
            }
        }
        private void dgvSaleChallan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    purchaseChalanId = Convert.ToInt64(dgvSaleChallan.CurrentRow.Cells["purchaseOrderBillId"].Value);
                }
                BindData(purchaseChalanId);
            }
            catch(Exception ex)
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
                BindComboBoxgetDealerName();
                grbChallanList.Visible = false;
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                dgvPurchaseItems.Enabled = true;
                btnDelete.Enabled = true;
                isDelete = false;
                isUpDate = true;
                DataTable dtSaleChallen = purchaseDetailsController.getPurchaseOrderDetails(purchaseChalanId, Utility.FinancilaYearId);
                if (dtSaleChallen.Rows.Count > 0)
                {
                    txtInvoiceNo.Text = dtSaleChallen.Rows[0]["purchaseOrderBillId"].ToString();
                    dtpChallenDate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["purchaseOrderDate"].ToString());
                    cmbDealerName.Text = dtSaleChallen.Rows[0]["dealerFirmName"].ToString();

                    txtmobile.Text = dtSaleChallen.Rows[0]["dealerContactNo"].ToString();

                    //if (Convert.ToBoolean(dtSaleChallen.Rows[0]["isState"].ToString()) == true)
                    //{
                    //    cmbGST.Text = "Maharashtra";
                    //}
                    //else
                    //{
                    //    cmbGST.Text = "Other";
                    //}
                    // txtPaidAmount.Text = dtSaleChallen.Rows[0]["customerMobileNo"].ToString();
                    txtPaidAmount.Text = dtSaleChallen.Rows[0]["OtherCharges"].ToString();
                    txtNetAmount.Text = dtSaleChallen.Rows[0]["netBillAmount"].ToString();
                    foreach (DataRow dr in dtSaleChallen.Rows)
                    {
                        dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                        dgvPurchaseItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(0);
                        dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                        dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                        dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                        dgvPurchaseItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                        dgvPurchaseItems.CurrentRow.Cells["itemName"].ReadOnly = true;
                        //dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                        dgvPurchaseItems.CurrentRow.Cells["MRP"].Value = dr["MRP"].ToString();
                        dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = dr["Quantity"].ToString();
                        dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                        dgvPurchaseItems.CurrentRow.Cells["discount"].Value = 0;
                        dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dr["IGST"].ToString());
                        dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dr["CGST"].ToString());
                        dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dr["SGST"].ToString());
                        //  dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = Utility.ParseValue(dr["freeQuantity"].ToString());
                        dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dr["salesCashRate"].ToString());
                        dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dr["purchaseRate"].ToString());
                        dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());

                        double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())) / 100);
                        double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())));
                        dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100);
                        dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100);
                        dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100);

                        //if (cmbGST.SelectedItem.ToString() == "Other")
                        //{
                        //    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dr["IGST"].ToString()) * purRate / 100);
                        //}
                        //else
                        //{
                        //    dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dr["CGST"].ToString()) * purRate / 100);
                        //    dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dr["SGST"].ToString()) * purRate / 100);
                        //    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());
                        //}

                        dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString())).ToString();
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
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                dgvPurchaseItems.Enabled = false;
                BindComboBoxgetDealerName();
                purchaseChalanId = purchaseDetailsController.getMaxIdPurchaseOrderId(Utility.FinancilaYearId);
                txtInvoiceNo.Text = purchaseDetailsController.getMaxIdPurchaseOrderId(Utility.FinancilaYearId).ToString();
                dgvItemName.Hide();
                grbItemList.Visible = false;
                grbChallanList.Visible = false;
                isDelete = false;
                isUpDate = false;
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                cmbDealerName.Focus();
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
                if (cmbDealerName.Text == string.Empty || cmbDealerName.SelectedValue == null)
                {
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Dealer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया व्यापारीचे नाव निवडा", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmbDealerName.Focus();
                    return;
                }
                for (int i = 0; i < dgvPurchaseItems.Rows.Count; i++)
                {
                    if (dgvPurchaseItems.Rows[i].Cells[4].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Item Name..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया वस्तुचे नाव भरा ...!");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[4];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[8].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells[8].Value = 0;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[5].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add Batch no...");
                        }
                        else
                        {
                            MessageBox.Show("कृपया बॅच नंबर भरा ..!");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[5];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[6].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add item Quantity..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("कृपया वस्तूचे नग भरा..", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[6];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[7].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells[7].Value = "Qty";
                    }

                    if (dgvPurchaseItems.Rows[i].Cells[9].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Purchase Rate..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया खरेदी किंमत भरा ..");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[9];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[10].Value == null)
                    {                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add MRP..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया  MRP किंमत भरा");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[10];
                        return;
                    }

                    if (dgvPurchaseItems.Rows[i].Cells[11].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Sale Rate..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया विक्री किंमत भरा ..");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[11];
                        return;
                    }

                    if (dgvPurchaseItems.Rows[i].Cells[12].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add IGST..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया IGST भरा ..");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[12];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[13].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells[13].Value = 0;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[14].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells[14].Value = 0;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[15].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells[15].Value = 0;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[17].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells[17].Value = 0;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[17].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells[18].Value = 0;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[18].Value == null)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Total Amount..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया पूर्ण रक्कम भरा ..");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[19];
                        return;
                    }
                }

                if (txtInvoiceNo.Text == string.Empty)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Add Bill No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया बिल क्रमांक  भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtInvoiceNo.Focus();
                    return;
                }
                if (cmbDealerName.SelectedValue == null)
                {
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Dealer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया व्यापारीचे नाव निवडा", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmbDealerName.Focus();
                    // dealerDetails dealer = new dealerDetails();
                    //dealer.de
                    //DealerController.addDealerDetails(dealer);
                    return;
                }

                if (txtPaidAmount.Text == string.Empty)
                {
                    //MessageBox.Show("Please Insert Paid Amt...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtPaidAmount.Focus();
                    //return;
                }
                PurchaseDetails purch = new PurchaseDetails();
                purch.dealerId = Convert.ToInt64(cmbDealerName.SelectedValue);
                purch.challanDate = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                if (isUpDate == false)
                {
                    purch.purchaseChalanId = purchaseDetailsController.getMaxIdPurchaseOrderId(Utility.FinancilaYearId);
                    purch.purchaseInvoiceId = purchaseDetailsController.getMaxIdPurchaseOrderId(Utility.FinancilaYearId).ToString();
                }
                else
                {
                    purch.purchaseInvoiceId = txtInvoiceNo.Text;
                    purch.purchaseChalanId = purchaseChalanId;
                }
                purch.remark = "";

                // DataGridView to Convert Table Payment Type table 
                DataTable PurchaseInvoice = new DataTable();
                foreach (DataGridViewColumn col in dgvPurchaseItems.Columns)
                {
                    PurchaseInvoice.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dgvPurchaseItems.Rows)
                {
                    DataRow dRow = PurchaseInvoice.NewRow();
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
                    PurchaseInvoice.Rows.Add(dRow);
                }

                purch.PurchaseItemTable = PurchaseInvoice;
                purch.paidAmount = Utility.ParseValue("0");
                purch.netBillAmount =Convert.ToDouble(Utility.ParseValue(txtNetAmount.Text));
                purch.chequeDate = DateTime.Now;
                purch.addedBy = Utility.LoginID;
                purch.FinancialYearID = Utility.FinancilaYearId;
                int ks = 0;
                if (isDelete == true)
                {
                    DialogResult dr = DialogResult.No;
                    if (Utility.Langn == "English")
                    {
                        dr = MessageBox.Show("Do you want to delete this order?", "Confirmation", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        dr = MessageBox.Show("तुम्हाला सदर Order Delete करायाचे आहे काय?", "Confirmation", MessageBoxButtons.YesNo);
                    }
                    if (dr == DialogResult.Yes)
                    {
                        purch.isDelete = true;
                        ks = purchaseDetailsController.addPurchaseOrderDetails(purch);
                    }
                    else if (dr == DialogResult.No)
                    {
                        //Nothing to do
                    }
                    if (ks > 0)
                    {                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Current Record deleted successfully..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("रेकोर्ड यशस्वीरित्या डिलीट केला गेला !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        btnnew_Click(sender,e);
                    }
                }
                else if (isDelete == false)
                {
                    purch.isDelete = false;
                    ks = purchaseDetailsController.addPurchaseOrderDetails(purch);
                    if (ks > 0)
                    {
                        DialogResult ShowReport2 = DialogResult.No;
                    if (Utility.Langn == "English")
                    {
                        ShowReport2 = MessageBox.Show("Do you want to print receipt...?", "receipt", MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        ShowReport2 = MessageBox.Show("पावतीची प्रिंट हवी आहे का....?", "पावती", MessageBoxButtons.YesNo);
                    }
                    if (ShowReport2 == DialogResult.Yes)
                    {
                     

                        bill();
                    }
                    else
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Current Details Saved successfully..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("सदर माहिती यशस्वीरित्या साठवले गेले आहे..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dgvSaleChallan.DataSource = purchaseDetailsController.getOrderList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()),Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);
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
                DataTable dtChallaneList = purchaseDetailsController.getOrderList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()), Utility.FinancilaYearId);
                dgvSaleChallan.DataSource = dtChallaneList;
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(isUpDate==true)
                {
                    purchaseDetailsController.deletePurchaseOrderRow(Convert.ToInt64(txtInvoiceNo.Text), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["itemId"].Value), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["categoryId"].Value), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["companyId"].Value), Convert.ToString(dgvPurchaseItems.Rows[rowIndex].Cells["batchNo"].Value), rowToDelete = dgvPurchaseItems.Rows.GetFirstRow(DataGridViewElementStates.Selected));
                    dgvPurchaseItems.Rows.RemoveAt(rowToDelete);
                    dgvPurchaseItems.ClearSelection();
                }
                else
                {
                    rowToDelete = dgvPurchaseItems.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    dgvPurchaseItems.Rows.RemoveAt(rowToDelete);
                    dgvPurchaseItems.ClearSelection();
                }
                if (dgvPurchaseItems.Rows.Count == 0)
                {
                    dgvPurchaseItems.Rows.Add();
                }
                subtot();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
        public void bill()
        {
            try
            {
              //  purchaseChalanId = Convert.ToInt64(txtInvoiceNo.Text);
                DataTable dtSaleChallen = purchaseDetailsController.getPurchaseOrderDetails(purchaseChalanId,Utility.FinancilaYearId);
                crPurchaseOrder rpt = new crPurchaseOrder();
                RptSaleBill frm = new RptSaleBill();
               // rpt.SetDataSource(dtSaleChallen);
                rpt.Database.Tables[0].SetDataSource(dtSaleChallen);
                rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Refresh();
                frm.crystalReportViewer1.Refresh();
                frm.ShowDialog();
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        private void frmPurchasseOrder_KeyDown(object sender, KeyEventArgs e)
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
                throw ex;
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

        private void cmbDealerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbDealerName.SelectedIndex > 0)
                dgvPurchaseItems.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                frmDealerMaster frm = new frmDealerMaster();
                frm.ShowDialog();
            }
            catch(Exception ex)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
