using DataAccessLayer.controller;
using DataAccessLayer.models;
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
    public partial class frmPurchaseChalan : MetroForm
    {
        public frmPurchaseChalan()
        {
            InitializeComponent();
        }
        public void BindComboBoxgetDealerName()
        {
            DataTable dtgetDealerName = DealerController.getDealerDetails();
            Utility.BindComboBoxDataSelect(cmbDealerName, dtgetDealerName, "dealerId", "dealerFirmName");
        }
         Int32 rowToDelete;
        public int rowIndex = 0;
        long purchaseChalanId = 0;
         bool isDelete=false;
         bool isupDate = false;
         #region --Lang--
         public void Lang()
         {
             try
             {
                 if (Utility.Langn == "English")
                 {
                     lblHerader.Text = "Purchase Chalan";
                     metroLabel2.Text = "Chalan No:";
                     metroLabel1.Text = "Date:";
                     lblstockInNo.Text = "Dealer Name:";
                     metroLabel3.Text = "Mobile No:";
                     label4.Text = "* Entry In this Form will make change In Stock Details.";
                     label1.Text = "Challan No:";
                     label8.Text = "Purchase State:";
                     label7.Text = "Code:";
                     label17.Text = "Customer/Retailer:";
                     lblNetBill.Text = "Total Amount:";
                     lblPaidAmount.Text = "Paid Amount:";
                     lblBakiAmount.Text = "Pending Amount:";
                     btnDelete.Text = "Delete";
                     btnChallanList.Text = "Chalan List";
                     btnnew.Text = "New(Alt+N)";
                     btnSave.Text = "Save (Alt+S)";
                     label2.Text = "From Date:";
                     label3.Text = "To Date:";
                     btnShow.Text = "Show";
                     label1.Text = "* Please fill MFG Date And Expiry Date in dd/MM/yyyy format eg.31/08/2018";                               
                     button1.Text = "New Item(F3)";
                  
                     dgvPurchaseItems.Columns[4].HeaderText = "Naration";
                     dgvPurchaseItems.Columns[5].HeaderText = "BatchNo";
                     dgvPurchaseItems.Columns[6].HeaderText = "MFG Date";
                     dgvPurchaseItems.Columns[7].HeaderText = "Expiry Date";
                     dgvPurchaseItems.Columns[8].HeaderText = "Qty";
                     dgvPurchaseItems.Columns[9].HeaderText = "UnitBy";
                     dgvPurchaseItems.Columns[10].HeaderText = "freeQuantity";                                     
                     dgvPurchaseItems.Columns[11].HeaderText = "Pur.Rate(With GST)";
                     dgvPurchaseItems.Columns[12].HeaderText = "Pur.Rate";
                     dgvPurchaseItems.Columns[13].HeaderText = "MRP";                
                     dgvPurchaseItems.Columns[14].HeaderText = "SaleRate(GST)";
                     dgvPurchaseItems.Columns[15].HeaderText = "Sale Rate";
                     dgvPurchaseItems.Columns[16].HeaderText = "GST(%)";
                     dgvPurchaseItems.Columns[17].HeaderText = "GSTAmt";
                     dgvPurchaseItems.Columns[18].HeaderText = "CGST(%)";
                     dgvPurchaseItems.Columns[19].HeaderText = "CGST Amt";
                     dgvPurchaseItems.Columns[20].HeaderText = "SGST(%)";
                     dgvPurchaseItems.Columns[21].HeaderText = "SGSTAmt";
                     dgvPurchaseItems.Columns[22].HeaderText = "Discount";
                     dgvPurchaseItems.Columns[23].HeaderText = "Amount";
                     dgvPurchaseItems.Columns[24].HeaderText = "purchaseChalanId";
                     dgvPurchaseItems.Columns[25].HeaderText = "Godown";

                     dgvSaleChallan.Columns[0].HeaderText = "Chalan No.";
                     dgvSaleChallan.Columns[2].HeaderText = "Dealer Name";
                     dgvSaleChallan.Columns[3].HeaderText = "Date";
                     dgvSaleChallan.Columns[4].HeaderText = "Amount";
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }
         #endregion
        private void frmPurchaseChalan_Load(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.disableFields(this);

                btnSave.Enabled = false;
                dgvPurchaseItems.Rows.Add();
                // dgvPurchaseItems.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
                //  dgvPurchaseItems.RowHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
                BindComboBoxgetDealerName();
                dgvItemName.Hide();
                cmbGST.SelectedIndex = 0;
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
  
        private void cmbDealerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDealerName.SelectedIndex > 0)
                {
                    dgvPurchaseItems.Enabled = true;
                  
                    if (txtInvoiceNo.Text == string.Empty)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Purchase Chalan No.");
                        }
                        else
                        {
                            MessageBox.Show("कृपया खरेदी चलन नं भरा.");
                        }
                        txtInvoiceNo.Focus();
                        return;
                    }
                    else
                    {
                        if (isupDate == false &&  isDelete==false)
                        {
                            Boolean isExists = purchaseDetailsController.getpurchaseChalanNo(txtInvoiceNo.Text, Convert.ToInt64(cmbDealerName.SelectedValue), Utility.FinancilaYearId);
                            if (isExists == true)
                            {                               
                                if (Utility.Langn == "English")
                                {
                                    MessageBox.Show("This Purchase chalan is already saved.");
                                }
                                else
                                {
                                    MessageBox.Show("सदर खरेदी चलन भरले गेले आहे.");
                                }
                                dgvPurchaseItems.Enabled = false;
                                txtInvoiceNo.Focus();
                            }
                            else
                            {
                                dgvPurchaseItems.Enabled = true;
                            }
                        }
                    }
                }
                else
                {
                  
                    dgvPurchaseItems.Enabled = false;
                }


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
                if (dgvPurchaseItems.CurrentCell.ColumnIndex == 8 ||
                    dgvPurchaseItems.CurrentCell.ColumnIndex == 10 ||
                    dgvPurchaseItems.CurrentCell.ColumnIndex == 11 ||
                    dgvPurchaseItems.CurrentCell.ColumnIndex == 12 ||
                    dgvPurchaseItems.CurrentCell.ColumnIndex == 13 ||
                    dgvPurchaseItems.CurrentCell.ColumnIndex == 15 ||
                    dgvPurchaseItems.CurrentCell.ColumnIndex == 17 ||
                    dgvPurchaseItems.CurrentCell.ColumnIndex == 19 ||
                    dgvPurchaseItems.CurrentCell.ColumnIndex == 20 ||
                    dgvPurchaseItems.CurrentCell.ColumnIndex == 21 ) //Desired Column
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
                    if (dgvPurchaseItems.CurrentCell.ColumnIndex==22)
                    {
                        col = col + 1;
                    }
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
                            else if (dgvPurchaseItems.CurrentCell.ColumnIndex == 13)
                            {
                                dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 2, row];
                            }
                            else if (dgvPurchaseItems.CurrentCell.ColumnIndex == 19)
                            {
                                dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 1, row];
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
                    DataTable dt = itemDetailsController.getStockInItemDetailsbyStockId(StockId);
                    foreach (DataGridViewRow rows in dgvPurchaseItems.Rows)
                    {
                        if (rows.Cells["godown"].Value != null && rows.Cells["itemId"].Value != null && rows.Cells["companyId"].Value != null && rows.Cells["categoryId"].Value != null && rows.Cells["batchNo"].Value != null && rows.Cells["itemName"].Value != null)
                        {
                            if (rows.Cells["godown"].Value.ToString().Equals(dt.Rows[0]["godownName"].ToString()) && rows.Cells["itemId"].Value.ToString().Equals(dt.Rows[0]["itemId"].ToString()) && rows.Cells["companyId"].Value.ToString().Equals(dt.Rows[0]["companyId"].ToString()) && rows.Cells["categoryId"].Value.ToString().Equals(dt.Rows[0]["categoryId"].ToString()) && rows.Cells["batchNo"].Value.ToString().Equals(dt.Rows[0]["batchNo"].ToString()) && rows.Cells["itemName"].Value.ToString().Equals(dt.Rows[0]["itemName"].ToString()))
                            {
                               
                                if (Utility.Langn == "English")
                                {
                                    MessageBox.Show("This Item Details exists in list already !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DataGridViewComboBoxCell coMBox = (DataGridViewComboBoxCell)(dgvPurchaseItems.CurrentRow.Cells["godown"]);
                    coMBox.DataSource = itemWiseSaleController.getGodownDetals();
                    coMBox.DisplayMember = "godownName";
                    coMBox.ValueMember = "godown";
                    dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dt.Rows[0]["itemId"]);
                    dgvPurchaseItems.CurrentRow.Cells["stockId"].Value = Convert.ToInt64(dt.Rows[0]["StockId"]);
                    dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dt.Rows[0]["companyId"]);
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dt.Rows[0]["categoryId"]);
                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dt.Rows[0]["batchNo"]);
                    dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value =dt.Rows[0]["MFD_Date"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value = dt.Rows[0]["expireDate"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["itemName"].Value = dt.Rows[0]["itemName"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["MRP"].Value = dt.Rows[0]["MRP"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = 1;
                    dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = dt.Rows[0]["unitBy"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dt.Rows[0]["purchaseRate"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dt.Rows[0]["purchaseRate"].ToString()) + ((Utility.ParseValue(dt.Rows[0]["purchaseRate"].ToString()) * Utility.ParseValue(dt.Rows[0]["IGST"].ToString())) / 100));
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dt.Rows[0]["salesCashRate"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["saleRateWithGST"].Value = Math.Round(Utility.ParseValue(dt.Rows[0]["salesCashRate"].ToString()) + ((Utility.ParseValue(dt.Rows[0]["salesCashRate"].ToString()) * Utility.ParseValue(dt.Rows[0]["IGST"].ToString())) / 100));
                    dgvPurchaseItems.CurrentRow.Cells["purchaseChalanItemDetailId"].Value = 0;
                    // dgvPurchaseItems.CurrentRow.Cells["salesCreditRate"].Value = 0;
                    //dgvPurchaseItems.CurrentRow.Cells["wholeSalesCashRate"].Value = 0;
                    //  dgvPurchaseItems.CurrentRow.Cells["wholeSalesCreditRate"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue("0");
                    dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dt.Rows[0]["IGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dt.Rows[0]["CGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dt.Rows[0]["SGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());

                    //   double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value) * (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value) * Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value)) / 100);
                    double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString())));

                    if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                    {
                        dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dt.Rows[0]["IGST"].ToString()) * purRate / 100);
                    }
                    else
                    {
                        dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["CGST"].ToString()) * purRate / 100),2);
                        dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = Math.Round((Utility.ParseValue(dt.Rows[0]["SGST"].ToString()) * purRate / 100),2);
                        dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString()),2);
                    }

                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = (purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString())).ToString();
                    dgvPurchaseItems.CurrentRow.Cells["godown"].Value = dt.Rows[0]["godownName"].ToString();
                    subtot();
                    dgvPurchaseItems.CurrentCell = dgvPurchaseItems.CurrentRow.Cells["Quantity"];
                    dgvPurchaseItems.BeginEdit(true);

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
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["saleRateWithGST"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value = null;
                    dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value = null;
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
                    dgvPurchaseItems.CurrentRow.Cells["purchaseChalanItemDetailId"].Value = 0;
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
                       dgvPurchaseItems.CurrentRow.Cells["discount"].Value != null && dgvPurchaseItems.CurrentRow.Cells["IGST"].Value != null && 
                       dgvPurchaseItems.CurrentRow.Cells["CGST"].Value != null &&
                       dgvPurchaseItems.CurrentRow.Cells["SGST"].Value != null && dgvPurchaseItems.CurrentRow.Cells["MRP"].Value != null &&
                       dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value != null)
                    {
                        //dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value = dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value.ToString();
                        dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value = dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value.ToString();
                        dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["discount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString());
                        dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString());
                       // dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value.ToString());
                       // dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) + (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())) / 100, 2);
                        if (dgvPurchaseItems.CurrentCell.ColumnIndex == 11)
                        {
                         
                            dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Math.Round((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value.ToString()) * 100) / (100 + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())), 2);
                        dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value =Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value.ToString()); 
                        }
                        if (dgvPurchaseItems.CurrentCell.ColumnIndex == 12)
                        {
                            dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()); 
                     
                            dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) + (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())) / 100, 2);
                        }
                        if (dgvPurchaseItems.CurrentCell.ColumnIndex == 14)
                        {

                            dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Math.Round((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["saleRateWithGST"].Value.ToString()) * 100) / (100 + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())), 2);
                            dgvPurchaseItems.CurrentRow.Cells["saleRateWithGST"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["saleRateWithGST"].Value.ToString());
                        }
                        if (dgvPurchaseItems.CurrentCell.ColumnIndex == 15)
                        {
                            dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString());

                            dgvPurchaseItems.CurrentRow.Cells["saleRateWithGST"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString()) + (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())) / 100, 2);
                        }
                           dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString())) * Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()));
                        //    double discount = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString())) * (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()))) / 100));
                        double purRate = (Convert.ToDouble(Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString())) * Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()))));

                        if (cmbGST.SelectedItem.ToString() != "Maharashtra")
                        {
                            dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())) * purRate / 100);
                            dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())) / 2);
                            dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())));
                            dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100);
                            dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString())));
                        }
                        else
                        {
                            dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())) * purRate / 100);
                            dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString())));
                            dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()))) + (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString())));
                            dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString())));
                            dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());

                        }
                        dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) + (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())) / 100, 2);
                        dgvPurchaseItems.CurrentRow.Cells["saleRateWithGST"].Value = Math.Round(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString()) + (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString())) / 100, 2);
                        dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString())) - Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()))).ToString();
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
                for (int i = 0; i < dgvPurchaseItems.Rows.Count; ++i)
                {
                    if (dgvPurchaseItems.Rows[i].Cells["totalAmount"].Value != null)
                    {
                        sum += Utility.ParseValue(dgvPurchaseItems.Rows[i].Cells["totalAmount"].Value.ToString());
                    }
                }
                txtNetAmount.Text = Convert.ToInt64(sum).ToString();
                txtPaidAmount.Text = "0";
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

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                BindComboBoxgetDealerName();
                purchaseChalanId = purchaseDetailsController.getMaxIdPurchaseChalanId();
                dgvItemName.Hide();
                grbItemList.Visible = false;
                grbChallanList.Visible = false;
                isDelete = false;
                isupDate = false;
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                cmbDealerName.Focus();
                cmbGST.Text = "Maharashtra";
                txtStateCode.Text = "27";
                cmbCustomerRetailer.Text = "Customer";
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
                dgvPurchaseItems.CurrentRow.Cells["itemName"].ReadOnly = false;
                dgvPurchaseItems.CurrentRow.Cells["godown"].ReadOnly = false;
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
                if (cmbDealerName.Text == string.Empty || cmbDealerName.SelectedValue == null)
                {
                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please add Dealer name...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया व्यापाऱ्याचे नाव भरा...", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmbDealerName.Focus();
                    return;
                }

                for (int i = 0; i < dgvPurchaseItems.Rows.Count; i++)
                {
                    if (dgvPurchaseItems.Rows[i].Cells["itemName"].Value == null)
                    {                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add item Name...");
                        }
                        else
                        {
                            MessageBox.Show("कृपया आयटम चे नाव भरा...");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells["itemName"];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[8].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells[8].Value = 0;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["batchNo"].Value == null)
                    {
                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add Batch No ");
                        }
                        else
                        {
                            MessageBox.Show("कृपया ब्याच नंबर भरा ");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells["batchNo"];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["Quantity"].Value == null)
                    {
                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Quantity");
                        }
                        else
                        {
                            MessageBox.Show("कृपया नग भरा ");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells["Quantity"];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells[7].Value == null)
                    {
                        dgvPurchaseItems.Rows[i].Cells[7].Value = "Qty";
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["purchaseRate"].Value == null)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add purchase rate ");
                        }
                        else
                        {
                            MessageBox.Show("कृपया खरेदी दर भरा ");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells["purchaseRate"];
                        return;
                    }
                    else
                    {
                        dgvPurchaseItems.Rows[i].Cells["purchaseRate"].Value = Utility.ParseValue(dgvPurchaseItems.Rows[i].Cells["purchaseRate"].Value.ToString());
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["MRP"].Value == null)
                    {
                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add MRP ");
                        }
                        else
                        {
                            MessageBox.Show("कृपया MRP भरा ");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells["MRP"];
                        return;
                    }

                    if (dgvPurchaseItems.Rows[i].Cells[11].Value == null)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please Add Sale rate");
                        }
                        else
                        {
                            MessageBox.Show("कृपया विक्री दर भरा");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[11];
                        return;
                    }

                    if (dgvPurchaseItems.Rows[i].Cells[12].Value == null)
                    {
                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add IGST ");
                        }
                        else
                        {
                            MessageBox.Show("कृपया IGST भरा ");
                        }
                        dgvPurchaseItems.Focus();
                        dgvPurchaseItems.CurrentCell = dgvPurchaseItems.Rows[i].Cells[12];
                        return;
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["mfgDate"].Value != null)
                    {
                        dgvPurchaseItems.Rows[i].Cells["mfgDate"].Value = Convert.ToDateTime(dgvPurchaseItems.Rows[i].Cells["mfgDate"].Value).ToShortDateString();
                    }
                    if (dgvPurchaseItems.Rows[i].Cells["expireDate"].Value != null)
                    {
                        dgvPurchaseItems.Rows[i].Cells["expireDate"].Value = Convert.ToDateTime(dgvPurchaseItems.Rows[i].Cells["expireDate"].Value).ToShortDateString();
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
                    if (dgvPurchaseItems.Rows[i].Cells[19].Value == null)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add amount");
                        }
                        else
                        {
                            MessageBox.Show("कृपया पूर्ण रक्कम भरा");
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
                        MessageBox.Show("Please fill Invoice No....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया बिल नंबर भरा ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtInvoiceNo.Focus();
                    return;
                }
                if (cmbDealerName.SelectedValue == null)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please add dealer name ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया व्यापार्याचे नाव भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    txtPaidAmount.Text = "0";
                    return;
                }
                PurchaseDetails purch = new PurchaseDetails();
                purch.dealerId = Convert.ToInt64(cmbDealerName.SelectedValue);
                if (isupDate == true)
                {
                    purch.purchaseChalanId = purchaseChalanId;
                }
                else
                {
                   purch.purchaseChalanId=purchaseDetailsController.getMaxIdPurchaseChalanId();
                }
                purch.challanDate = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                purch.purchaseInvoiceId = txtInvoiceNo.Text;
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
                                MessageBox.Show("Please fill all details in list");
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
                if (txtPaidAmount.Text == string.Empty)
                {
                    txtPaidAmount.Text = "0";
                    purch.paidAmount = Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text));
                }
                else
                {
                    purch.paidAmount = Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text));
                }
                purch.netBillAmount = Convert.ToDouble(Utility.ParseValue(txtNetAmount.Text));
                purch.FinancialYearID = Utility.FinancilaYearId;
                purch.chequeDate = Convert.ToDateTime(dtpChallenDate.Value.ToShortDateString());
                purch.addedBy = Utility.LoginID;
                purch.state = cmbGST.Text;
                purch.stateCode = txtStateCode.Text;
                purch.isCustomerRetailer = Convert.ToBoolean(cmbCustomerRetailer.SelectedIndex);

                int ks = 0;
                if (isDelete == true)
                {
                    if (Utility.Langn == "English")
                    {
                        DialogResult dr = MessageBox.Show("Do you really want to delete this chalan?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            purch.isDelete = true;
                            ks = purchaseDetailsController.addPurchaseChalanDetails(purch);
                        }
                        else if (dr == DialogResult.No)
                        {
                            //Nothing to do
                        }
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("तुम्हाला सदर चलन डिलीट करायाचे आहे काय?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            purch.isDelete = true;
                            ks = purchaseDetailsController.addPurchaseChalanDetails(purch);
                        }
                        else if (dr == DialogResult.No)
                        {
                            //Nothing to do
                        }
                    }
                  
                    if (ks > 0)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("this Chalan Deleted Successfully ... !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        purch.isDelete = false;
                        ks = purchaseDetailsController.addPurchaseChalanDetails(purch);
                        if (ks > 0)
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("This Sale Chalan Saved Successfylly..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("सदर चलन यशस्वीरित्या साठवले गेले आहे..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnSave_Click(sender,e);
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
                dgvSaleChallan.DataSource = purchaseDetailsController.getChallenList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()),Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);
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
                DataTable dtChallaneList = purchaseDetailsController.getChallenList(Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()), Utility.FinancilaYearId);
                dgvSaleChallan.DataSource = dtChallaneList;
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
       
        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isupDate == true)
                {
                    if (dgvPurchaseItems.CurrentRow.Cells["purchaseChalanItemDetailId"].Value != null)
                    {
                        purchaseDetailsController.deleteRow(purchaseChalanId, Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["purchaseChalanItemDetailId"].Value), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["itemId"].Value), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["categoryId"].Value), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["companyId"].Value), Convert.ToString(dgvPurchaseItems.Rows[rowIndex].Cells["batchNo"].Value),
                        Utility.ParseValue(dgvPurchaseItems.Rows[rowIndex].Cells["Quantity"].Value.ToString()), Convert.ToInt64(dgvPurchaseItems.Rows[rowIndex].Cells["StockId"].Value));
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvSaleChallan_Click(object sender, EventArgs e)
        {
           
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
                isDelete =false;
                isupDate = true;
                DataTable dtSaleChallen = purchaseDetailsController.getSaleChallenDetails(purchaseChalanId,Utility.FinancilaYearId);
                txtInvoiceNo.Text = dtSaleChallen.Rows[0]["purchaseChalanBillId"].ToString();
                dtpChallenDate.Value = Convert.ToDateTime(dtSaleChallen.Rows[0]["purchaseChalanDate"].ToString());
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
                cmbCustomerRetailer.SelectedIndex = Convert.ToInt32(dtSaleChallen.Rows[0]["isCustomerRetailer"]);
                cmbGST.Text = dtSaleChallen.Rows[0]["state"].ToString();
                txtStateCode.Text = dtSaleChallen.Rows[0]["stateCode"].ToString();
                foreach(DataRow dr in dtSaleChallen.Rows)
                {
                    DataGridViewComboBoxCell coMBox = (DataGridViewComboBoxCell)(dgvPurchaseItems.CurrentRow.Cells["godown"]);
                    coMBox.DataSource = itemWiseSaleController.getGodownDetals();
                    coMBox.DisplayMember = "godownName";
                    coMBox.ValueMember = "godown";
                    dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                    dgvPurchaseItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(dr["StockId"]);
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                    dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                    dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value = Convert.ToString(dr["mfgDate"]);
                    dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value = Convert.ToString(dr["expireDate"]);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseChalanItemDetailId"].Value = Convert.ToInt64(dr["purchaseChalanItemDetailId"]);
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
                      dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = Utility.ParseValue(dr["freeQuantity"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dr["salesCashRate"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["saleRateWithGST"].Value = Math.Round(Utility.ParseValue(dr["salesCashRate"].ToString()) + ((Utility.ParseValue(dr["salesCashRate"].ToString()) * Utility.ParseValue(dr["IGST"].ToString())) / 100));
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dr["purchaseRate"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dr["purchaseRate"].ToString()) + ((Utility.ParseValue(dr["purchaseRate"].ToString()) * Utility.ParseValue(dr["IGST"].ToString())) / 100));
                  //  dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString())) * Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());

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
                    //    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value) + Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value);
                    //}

                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString())) - Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()));
                    dgvPurchaseItems.CurrentRow.Cells["godown"].Value = Convert.ToString(dr["godownName"]);
                    dgvPurchaseItems.CurrentRow.Cells["godown"].ReadOnly = true;
                    //  dgvPurchaseItems.Focus();
                    dgvPurchaseItems.CurrentCell = dgvPurchaseItems.CurrentRow.Cells["Quantity"];
                    dgvPurchaseItems.BeginEdit(true);
                    int col = dgvPurchaseItems.CurrentCell.ColumnIndex;
                    int row = dgvPurchaseItems.CurrentCell.RowIndex;
                    col = 0;
                    row++;
                    if(dgvPurchaseItems.Rows.Count<dtSaleChallen.Rows.Count)
                    {
                       if(row==dgvPurchaseItems.RowCount)
                       {
                           dgvPurchaseItems.Rows.Add();
                           dgvPurchaseItems.CurrentCell=dgvPurchaseItems[col+4,row];
                       }
                    }
                }
                
                subtot();
            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
        private void txtNetAmount_TextChanged(object sender, EventArgs e)
        {
         try
            {
                double checkpaidamount = 0;
                double checkbillamount = 0;
                if (txtNetAmount.Text != string.Empty && txtPaidAmount.Text != string.Empty)
                { checkpaidamount = Utility.ParseValue(txtPaidAmount.Text);
                        checkbillamount = Utility.ParseValue(txtNetAmount.Text);
                        if (checkbillamount < checkpaidamount)
                        {                            
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Please Check Total Amount!");
                            }
                            else
                            {
                                MessageBox.Show("कृपया एकूण रक्कम तपासा !");
                            }
                            txtPaidAmount.Text = "";
                            txtNetAmount.Text = checkbillamount.ToString();
                            txtBalanceAmount.Text = checkbillamount.ToString();
                        }
                        else
                        {
                            double dueAmount = Convert.ToDouble(Utility.ParseValue(txtNetAmount.Text)) - Convert.ToDouble(Utility.ParseValue(txtPaidAmount.Text));
                            txtBalanceAmount.Text = dueAmount.ToString();
                        }
                }
                else
                {
                    txtBalanceAmount.Text = txtNetAmount.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSaleChallan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    purchaseChalanId = Convert.ToInt64(dgvSaleChallan.CurrentRow.Cells["purchaseChalanId1"].Value);
                }
                BindData(purchaseChalanId);
                btnDelete.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtmobile_TextChanged(object sender, EventArgs e)
        {

        }

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
                    dgvPurchaseItems.Columns["IGST"].Visible = true;
                    dgvPurchaseItems.Columns["IGSTAmt"].Visible = true;
                    dgvPurchaseItems.Columns["CGST"].Visible = false;
                    dgvPurchaseItems.Columns["CGSTAmt"].Visible = false;
                    dgvPurchaseItems.Columns["SGST"].Visible = false;
                    dgvPurchaseItems.Columns["SGSTAmt"].Visible = false;

                }
                else
                {
                    dgvPurchaseItems.Columns["IGST"].Visible = false;
                    dgvPurchaseItems.Columns["IGSTAmt"].Visible = false;
                    dgvPurchaseItems.Columns["CGST"].Visible = true;
                    dgvPurchaseItems.Columns["CGSTAmt"].Visible = true;
                    dgvPurchaseItems.Columns["SGST"].Visible = true;
                    dgvPurchaseItems.Columns["SGSTAmt"].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmPurchaseChalan_KeyDown(object sender, KeyEventArgs e)
        {
        
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.F2)
                {
                    frmDealerMaster frm = new frmDealerMaster();
                    frm.ShowDialog();
                }
                if (e.KeyCode == Keys.F3)
                {
                    try
                    {
                        frmItemDetails frm = new frmItemDetails();
                        frm.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.N && e.Alt)
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
                if (e.KeyCode == Keys.S && e.Alt)
                {
                    try
                    {
                        btnSave_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.T && e.Alt)
                {
                    try
                    {
                        frmTempPurchaseChalan frm = new frmTempPurchaseChalan();
                        frm.ShowDialog();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frmDealerMaster frm = new frmDealerMaster();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmItemDetails frm = new frmItemDetails();
            frm.ShowDialog();
        }

        private void txtInvoiceNo_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmbDealerName.SelectedIndex > 0 && txtInvoiceNo.Text != string.Empty)
                {
                    if (isupDate == false && isDelete==false)
                    {
                        Boolean isExists = purchaseDetailsController.getInvoice(txtInvoiceNo.Text, Convert.ToInt64(cmbDealerName.SelectedValue), Utility.FinancilaYearId);
                        if (isExists == true)
                        {
                         
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("This Purchase Chalan Saved Successfully.");
                            }
                            else
                            {
                                MessageBox.Show("सदर खरेदी चलन भरले गेले आहे.");
                            }

                            dgvPurchaseItems.Enabled = false;
                            txtInvoiceNo.Focus();
                        }
                        else
                        {
                            dgvPurchaseItems.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //private void btnConvertChallan_Click(object sender, EventArgs e)
        //{
           
        //}
    }
}
