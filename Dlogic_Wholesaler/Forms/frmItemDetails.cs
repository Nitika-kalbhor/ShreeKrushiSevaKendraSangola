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
    public partial class frmItemDetails : MetroForm
    {
       
        public frmItemDetails()
        {
            InitializeComponent();

        }
        public  long itemId = 0;
        public bool isUpdate = false;
        public void BindComboBoxgetCategory()
        {
            try
            {
                DataTable dtgenderId = categoryController.getCategory();
                Utility.BindComboBoxEmptyDataSelect(cmbCategory, dtgenderId, "categoryId", "categoryName");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindComboBoxItemName()
        {
            try
            {
                DataTable dtgenderId = itemDetailsController.getItemNameBy();
                Utility.BindComboBoxEmptyDataSelect(cmbItemName, dtgenderId, "itemId", "itemName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BimdComboBoxCompany()
        {
            try
            {
                DataTable dtgenderId = categoryController.getCompany();
                Utility.BindComboBoxEmptyDataSelect(cmbCompany, dtgenderId, "companyId", "companyName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindComboBoxWeightIn()
        {
            try
            {
                DataTable dtPaking = itemDetailsController.getPaking();
                Utility.BindComboBoxEmptyDataSelect(cmbWeightIn, dtPaking, "unitBy", "packing");
                if (dtPaking.Rows.Count > 0)
                {
                    cmbWeightIn.SelectedIndex = 0;
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      public void  BindGodownDetails()
        {
              try
            {
                DataTable dtPaking = itemDetailsController.getGodownDetails();
                Utility.BindComboBoxEmptyDataSelect(cmbGodwond, dtPaking, "godown", "godownName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmItemDetails_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.Insert)
                {
                    frmCompany frm = new frmCompany();
                    frm.Show();
                }
                if (e.KeyCode == Keys.N && e.Alt)
                {
                    btnnew_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && e.Alt)
                {
                    btnSave_Click(sender, e);
                }
                //if (e.KeyCode == Keys.Home)
                //{
                //    try
                //    {
                //        Utility.ClearSpace(this);
                //        Utility.enableFields(this);
                //        btnSave.Enabled = true;
                //        btnUpdate.Enabled = false;
                //        BindComboBoxgetCategory();
                //        BindComboBoxItemName();

                //        itemId = 0;
                //        cmbWeightIn.SelectedIndex = 0;
                //        cmbItemName.Focus();
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message);
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        #region --Lang--

        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Stock Details";
                    label9.Text = "Stock Details";
                    label5.Text = "Main Category:";
                    metroLabel8.Text = "Item Name:";
                    metroLabel2.Text = "Item Category:";
                    metroLabel1.Text = "Company Name:";
                    metroLabel14.Text = "Unit By:";
                    label7.Text = "Opening Qty:";
                    label10.Text = "Godown:";
                    metroLabel6.Text = "HSNCode:";
                    metroLabel10.Text = "Batch No:";
                    label8.Text = "Mfg Date:";
                    label4.Text = "Expiry Date:";
                    metroLabel5.Text = "Rack No:";
                    metroLabel16.Text = "MRP:";
                    metroLabel17.Text = "GST:";
                    metroLabel7.Text = "SGST:";
                    label1.Text = "CGST:";
                    label6.Text = "Purchase Rate(With GST):";
                    metroLabel15.Text = "Purchase Rate:";
                    label3.Text = "Sale Rate(with GST):";
                    metroLabel18.Text = "Sale Rate:";
                    metroLabel19.Text = "Sale Udhari Rate(with GST):";
                    metroLabel21.Text = "Cash Whole.Rate(with GST):";
                    metro.Text = "Whole.Udhari Rate(with GST):";
                    metroLabel3.Text = "Product Code:";
                    metroLabel4.Text = "Reorder:";
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    btnDelete.Text = "Delete";
                    btnItemList.Text = "Item List";
                    label2.Text = "* To Update Item Name Click on Item List Button";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmItemDetails_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    Utility.ClearSpace(this);
                    Utility.disableFields(this);
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                    Lang();
                    BindComboBoxgetCategory();
                    BimdComboBoxCompany();
                    BindComboBoxItemName();
                    BindComboBoxWeightIn();
                    itemId = 0;
                    
                    chkBxExpiry.Enabled = false;
                    cmbItemName.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                BindComboBoxgetCategory();
                BimdComboBoxCompany();
                BindComboBoxItemName();
                BindGodownDetails();
                itemId = 0;
                //cmbWeightIn.SelectedIndex = 0;
                cmbMainCategory.SelectedIndex = 0;
                cmbItemName.Focus();
                chkBxExpiry.Enabled = true;
                txtIGST.SelectedIndex = 0;
               // cmbGodwond.SelectedIndex = 1;
                chkBxExpiry.Checked = false;
                btnDelete.Visible = false;
                btnDelete.Enabled = false;
                if (Utility.Langn == "English")
                {
                    btnSave.Text = "Save";
                }
                else
                {
                    btnSave.Text = "जतन";
                }
                  StockId = 0;
                 ItemIDUpdate = 0;
                 categoryId1 = 0;
                 companyId1 = 0;
                 isDelete = false;
                 isUpdate = false;
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
                if (cmbItemName.Text == string.Empty || cmbItemName.SelectedIndex == 0)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please add or select item name.....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया वस्तूचे नाव निवडा किंवा भरा.....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cmbItemName.Focus();
                    return;
                }
                //if (txtProductCode.Text == string.Empty)
                //{
                //    MessageBox.Show("Please Product Code........!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtProductCode.Focus();
                //    return;
                //}
                if (cmbCategory.Text == string.Empty || cmbCategory.SelectedIndex == 0)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please add or select Item Category.....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कृपया वस्तूचा प्रकार निवडा किंवा भरा.....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cmbCategory.Focus();
                    return;
                }
                if (cmbCompany.Text == string.Empty || cmbCompany.SelectedIndex == 0)
                {
                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please add or select Item Company...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("कुपया वस्तूची कंपनी निवडा किंवा भरा....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cmbCompany.Focus();
                    return;
                }

                //if (txtRackNo.Text == string.Empty)
                //{
                //    MessageBox.Show("Please Insert Rack No ....!", "त्रुटी", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtRackNo.Focus();
                //    return;

                //}
               
                    //if (txtBatchNo.Text == string.Empty)
                    //{
                    //    MessageBox.Show("कृप्पया बॅच नंबर भरा ..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    txtBatchNo.Focus();
                    //    return;
                    //}
                    if (txtPurchaseRate.Text == string.Empty)
                    {

                        txtPurchaseRate.Text = "0";
                    }
                    if (txtIGST.Text == string.Empty)
                    {                       
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please add GST(%)...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("कृपया GST(%) भरा....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        txtIGST.Focus();
                        return;

                    }
                    ItemDetails obj = new ItemDetails();
                 
                    obj.itemName = cmbItemName.Text.Trim();
                    obj.mainCategory = cmbMainCategory.Text.Trim();
                    if (isUpdate == false)
                    {
                        string companyName = cmbCompany.Text.Trim();
                        string Category = cmbCategory.Text.Trim();
                        if (cmbCategory.SelectedValue ==null)
                        {
                            int s = categoryController.addCategoryDetails(Convert.ToInt32(cmbCategory.SelectedValue), cmbCategory.Text.Trim());

                            BindComboBoxgetCategory();
                            cmbCategory.Text = Category;
                            obj.categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                        }

                        else
                        {
                            obj.categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                        }

                        if (cmbCompany.SelectedValue == null)
                        {
                            int d = categoryController.addCompanyDeatials(Convert.ToInt32(cmbCategory.SelectedValue), 0, cmbCompany.Text.Trim(), Utility.LoginID);

                            BimdComboBoxCompany();
                            cmbCategory.Text = Category;
                            cmbCompany.Text = companyName;
                            obj.companyId = Convert.ToInt32(cmbCompany.SelectedValue);
                        }
                        else
                        {
                            obj.companyId = Convert.ToInt32(cmbCompany.SelectedValue);
                        }


                    }
                    else
                    {
                        obj.categoryId = categoryId1;
                        obj.companyId = companyId1;
                        obj.categoryName = cmbCategory.Text.Trim();
                        obj.companyName = cmbCompany.Text.Trim();

                    }
                    if (txtProductCode.Text == string.Empty)
                    {
                        obj.productCode = "";
                    }
                    else
                    {
                        obj.productCode = txtProductCode.Text.Trim();
                    }
                    if (txtBatchNo.Text == string.Empty) { obj.batchNo = "0"; }
                    else { obj.batchNo = txtBatchNo.Text.Trim(); }

                    if (txtReorder.Text == string.Empty) { obj.reorderLevel = 0; }
                    else
                    {
                        obj.reorderLevel = Convert.ToDouble(Utility.ParseValue(txtReorder.Text));
                    }

                    if (txtRackNo.Text == string.Empty)
                    { obj.rackNo = "0"; }
                    else { obj.rackNo = txtRackNo.Text.Trim(); }
                    if (txtHNSCode.Text == string.Empty)
                    {
                        obj.HNSCode = "0";
                    }
                    else
                    {

                        obj.HNSCode = txtHNSCode.Text.Trim();
                    }

                    if (txtQty.Text == string.Empty)
                    {
                        obj.openingStock = 0;
                    }
                    else
                    {
                        obj.openingStock = Convert.ToDouble(Utility.ParseValue(txtQty.Text));
                    }
                    if(cmbWeightIn.Text.Trim()==string.Empty)
                    {
                        
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("Please select Packing..");
                        }
                        else
                        {
                            MessageBox.Show("कृपया पॅकिंग निवडा..");
                        }
                        return;
                    }
                     obj.weightIn = cmbWeightIn.Text.Trim();
                    if (txtMRP.Text == string.Empty)
                    {
                        obj.price = 0.0;
                    }
                    else
                    {
                        obj.price = Convert.ToDouble(Utility.ParseValue(txtMRP.Text));
                    }
                    if(txtProductCode.Text==String.Empty)
                    {
                        obj.productCode = "0";
                    }
                    else
                    {
                        obj.productCode = txtProductCode.Text.Trim();
                    }
                    //  if (txtPurchaseRate.Text == string.Empty) { txtPurchaseRate.Text = "0"; }
                    obj.purchaseRate = Utility.ParseValue(txtPurchaseRate.Text);
                    if(txtCGST.Text == string.Empty||txtCGST.Text == "0.0")
                    {
                        obj.CGST = 0.0;
                        txtCGST.Text = "0.0";
                    }
                    else
                    {
                        obj.CGST = Convert.ToDouble(Utility.ParseValue(txtCGST.Text));
                    }
                    if (txtSGST.Text == string.Empty || txtCGST.Text == "0.0")
                    {
                        obj.SGST = 0.0;
                        txtSGST.Text = "0.0";
                    }
                    else
                    {
                        obj.SGST = Convert.ToDouble(Utility.ParseValue(txtSGST.Text));
                    }
                    if (txtIGST.Text == string.Empty || txtCGST.Text == "0.0")
                    {
                        obj.IGST = 0.0;
                        obj.CGST = 0.0;
                        obj.SGST = 0.0;
                    }
                    else
                    {
                        if (cmbMainCategory.Text == "इतर")
                        {
                            obj.IGST = 0;
                            obj.CGST = 0;
                            obj.SGST = 0;
                        }
                        else
                        {
                        obj.IGST = Convert.ToDouble(Utility.ParseValue( txtIGST.Text));
                        obj.CGST = Convert.ToDouble(Utility.ParseValue(txtCGST.Text));
                        obj.SGST = Convert.ToDouble(Utility.ParseValue(txtSGST.Text));
                        }
                    }
                    if (txtCashSaleRate.Text == string.Empty) 
                    { obj.salesCashRate = 0.0; }
                    else
                    {
                        obj.salesCashRate = Convert.ToDouble(Utility.ParseValue(txtCashSaleRate.Text));
                    }
                    if (txtSaleCreditRate.Text == string.Empty || Convert.ToDouble(txtSaleCreditRate.Text)==0) 
                    { 
                        obj.salesCreditRate = obj.salesCashRate;
                    }
                    else
                    {
                        obj.salesCreditRate = Convert.ToDouble(Utility.ParseValue(txtSaleCreditRate.Text));
                    }
                    if (txtCashHollSaleRate.Text == string.Empty || Convert.ToDouble(txtCashHollSaleRate.Text) == 0) { obj.wholeSalesCashRate = obj.salesCashRate; }
                    else
                    {
                        obj.wholeSalesCashRate = Convert.ToDouble(Utility.ParseValue(txtCashHollSaleRate.Text));
                    }
                    if (txtCreditHollSaleRate.Text == string.Empty || Convert.ToDouble(txtCreditHollSaleRate.Text) == 0) { obj.wholeSalesCreditRate = obj.wholeSalesCashRate; }
                    else
                    {
                        obj.wholeSalesCreditRate = Convert.ToDouble(Utility.ParseValue(txtCreditHollSaleRate.Text));
                    }
                    obj.MFD_Date = Convert.ToDateTime(dtpMfgDate.Value.ToShortDateString());
                    obj.expireDate = Convert.ToDateTime(dtpExpDate.Value.ToShortDateString());
                    obj.isExpiryApplicable = chkBxExpiry.Checked;
                    obj.godownDetails = cmbGodwond.Text;
                    obj.addedBy = Utility.LoginID;
                    int i = 0;
                    string msg = "";
                    if (isUpdate == false && isDelete==false)
                    {
                        itemId = Convert.ToInt64(cmbItemName.SelectedValue);
                        obj.itemId = itemId;
                       
                        if (Utility.Langn == "English")
                        {
                            msg = "Record Saved successfully !! ";
                        }
                        else
                        {
                            msg = "माहिती यशस्वीरित्या साठवल्या गेली !! ";
                        }
                        i = itemDetailsController.addItemDetails(obj);
                    }
                    if (isUpdate == true)
                    {
                        obj.itemId = ItemIDUpdate;
                        obj.StockId = StockId;
                       
                         if (Utility.Langn == "English")
                         {
                             msg = "Record updated successfully !! ";
                         }
                         else
                         {
                             msg = "माहिती यशस्वीरित्या उपडेट केली गेली !! ";
                         }
                        i = itemDetailsController.UpdateItemDetails(obj);
                    }
                    if (isDelete == true)
                    {
                        obj.isDelete = isDelete;
                        obj.StockId = StockId;                        
                         if (Utility.Langn == "English")
                         {
                             msg = "Record Deleted successfully !! ";
                         }
                         else
                         {
                             msg = "माहिती यशस्वीरित्या डिलीट केली गेली !! ";
                         }
                        i = itemDetailsController.DeleteItemDetails(obj);
                    }
                    if (i > 0)
                    {  
                        
                        MessageBox.Show(msg, "जतन",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        btnnew_Click(sender, e);
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    
        

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                return;
                if (cmbItemName.SelectedIndex > 0)
                {
                    itemId = Convert.ToInt64(cmbItemName.SelectedValue);
                    DataTable itemList = itemDetailsController.getItemDetailsById(itemId);
                    //cmbCategory.Text =itemList.Rows[0]["categoryName"].ToString();
                    //cmbCompany.Text = itemList.Rows[0]["companyName"].ToString();
                    //txtProductCode.Text = itemList.Rows[0]["productCode"].ToString();
                    //txtRackNo.Text = itemList.Rows[0]["rackNo"].ToString();
                    //txtHNSCode.Text = itemList.Rows[0]["HNSCode"].ToString();
                    //txtBatchNo.Text = itemList.Rows[0]["batchNo"].ToString();
                    //txtReorder.Text = itemList.Rows[0]["reorderLevel"].ToString();
                    //txtProductCode.Text = itemList.Rows[0]["productCode"].ToString();
                    //cmbWeightIn.Text = itemList.Rows[0]["unitBy"].ToString();
                    //txtQty.Text = itemList.Rows[0]["openingStock"].ToString();
                    //txtMRP.Text = itemList.Rows[0]["MRP"].ToString();
                    //txtPurchaseRate.Text = itemList.Rows[0]["purchaseRate"].ToString();
                    //txtCashSaleRate.Text = itemList.Rows[0]["salesCashRate"].ToString();
                    //txtIGST.Text = itemList.Rows[0]["IGST"].ToString();
                    //txtCGST.Text = itemList.Rows[0]["CGST"].ToString();
                    //txtSGST.Text = itemList.Rows[0]["SGST"].ToString();
                    //txtSaleCreditRate.Text = itemList.Rows[0]["salesCreditRate"].ToString();
                    //txtPurchaseRateWithGST.Text=(Math.Round(Convert.ToDouble( itemList.Rows[0]["purchaseRate"].ToString())+(Convert.ToDouble( itemList.Rows[0]["purchaseRate"].ToString())*Convert.ToDouble(itemList.Rows[0]["IGST"].ToString()))/100,2)).ToString();
                    //txtSaleWithGST.Text = (Math.Round(Convert.ToDouble(itemList.Rows[0]["salesCashRate"].ToString()) + (Convert.ToDouble(itemList.Rows[0]["salesCashRate"].ToString()) * Convert.ToDouble(itemList.Rows[0]["IGST"].ToString()))/100,2)).ToString();
                    //txtCashHollSaleRate.Text = itemList.Rows[0]["wholeSalesCashRate"].ToString();
                    //txtCreditHollSaleRate.Text = itemList.Rows[0]["wholeSalesCreditRate"].ToString();
                    //txtSaleCreditRateWithGST.Text = (Math.Round(Convert.ToDouble(itemList.Rows[0]["salesCreditRate"].ToString()) + (Convert.ToDouble(itemList.Rows[0]["salesCreditRate"].ToString()) * Convert.ToDouble(itemList.Rows[0]["IGST"].ToString())) / 100, 2)).ToString();
                    //txtSaleWholeSaleRateWithGST.Text = (Math.Round(Convert.ToDouble(itemList.Rows[0]["wholeSalesCashRate"].ToString()) + (Convert.ToDouble(itemList.Rows[0]["wholeSalesCashRate"].ToString()) * Convert.ToDouble(itemList.Rows[0]["IGST"].ToString())) / 100, 2)).ToString();
                    //txtSaleWholeSaleCreditRateWithGST.Text = (Math.Round(Convert.ToDouble(itemList.Rows[0]["wholeSalesCreditRate"].ToString()) + (Convert.ToDouble(itemList.Rows[0]["wholeSalesCreditRate"].ToString()) * Convert.ToDouble(itemList.Rows[0]["IGST"].ToString())) / 100, 2)).ToString();
               
                    //chkBxExpiry.Checked = Convert.ToBoolean(itemList.Rows[0]["isExpiryApplicable"]);
                    //cmbMainCategory.Text = itemList.Rows[0]["mainCategory"].ToString();
                    //cmbGodwond.Text = itemList.Rows[0]["godownName"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPurchaseRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtPurchaseRate.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtPurchaseRate.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtMRP_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtMRP.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtMRP.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtIGST.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtIGST.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCashSaleRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtCashSaleRate.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtCashSaleRate.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSaleCreditRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtSaleCreditRate.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtSaleCreditRate.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCashHollSaleRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtCashHollSaleRate.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtCashHollSaleRate.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCreditHollSaleRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtCreditHollSaleRate.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtCreditHollSaleRate.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtQty.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtQty.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtReorder_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtReorder.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtReorder.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCompany frm = new frmCompany();
            frm.Show();
        }

        //private void cmbColor_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (cmbproductCode.SelectionStart == 0) //This is the first character
        //    {
        //        //Now check to see if the key pressed is a space
        //        if (e.KeyValue == 32)
        //        {
        //            //Stop the key registering
        //            e.Handled = true;
        //            e.SuppressKeyPress = true;
        //        }
        //    }
        //}

        private void cmbItemName_KeyDown(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    if (cmbItemName.SelectionStart == 0) //This is the first character
            //    {
            //        //Now check to see if the key pressed is a space
            //        if (e.KeyValue == 32)
            //        {
            //            //Stop the key registering
            //            e.Handled = true;
            //            e.SuppressKeyPress = true;
            //        }
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void cmbcmbCategory_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //if (cmbCategory.SelectionStart == 0) //This is the first character
                //{
                //    //Now check to see if the key pressed is a space
                //    if (e.KeyValue == 32)
                //    {
                //        //Stop the key registering
                //        e.Handled = true;
                //        e.SuppressKeyPress = true;
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCompany_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //if (cmbCompany.SelectionStart == 0) //This is the first character
                //{
                //    //Now check to see if the key pressed is a space
                //    if (e.KeyValue == 32)
                //    {
                //        //Stop the key registering
                //        e.Handled = true;
                //        e.SuppressKeyPress = true;
                //    }
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtIGST_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double IGST = 0;
                double CGST = 0;
                double SGST = 0;
                if (txtIGST.Text != string.Empty)
                {

                    IGST = Utility.ParseValue(txtIGST.Text);
                    CGST = IGST / 2;
                    txtCGST.Text = CGST.ToString();
                    txtSGST.Text = CGST.ToString();
                    if (txtSaleWithGST.Text != string.Empty && txtIGST.Text != string.Empty)
                    {
                        txtCashSaleRate.Text = Math.Round((Utility.ParseValue(txtSaleWithGST.Text) * 100) / (100 + Utility.ParseValue(txtIGST.Text)), 2).ToString();
                    }
                    else
                    {
                        txtCashSaleRate.Text = "0";
                    }

                    if (txtPurchaseRateWithGST.Text != string.Empty && txtIGST.Text != string.Empty)
                    {
                        txtPurchaseRate.Text = Math.Round((Utility.ParseValue(txtPurchaseRateWithGST.Text) * 100) / (100 + Utility.ParseValue(txtIGST.Text)), 2).ToString();
                    }
                    else
                    {
                        txtPurchaseRate.Text = "0";
                    }
                    if(txtSaleCreditRateWithGST.Text!=string.Empty)
                    {
                        txtSaleCreditRate.Text = Math.Round((Utility.ParseValue(txtSaleCreditRateWithGST.Text) * 100) / (100 + Utility.ParseValue(txtIGST.Text)), 2).ToString();
                    }
                    else
                    {
                        txtSaleCreditRate.Text = "0";
                    }
                    if (txtSaleWholeSaleRateWithGST.Text != string.Empty)
                    {
                        txtCashHollSaleRate.Text = Math.Round((Utility.ParseValue(txtSaleWholeSaleRateWithGST.Text) * 100) / (100 + Utility.ParseValue(txtIGST.Text)), 2).ToString();
                    }
                    else
                    {
                        txtCashHollSaleRate.Text = "0";
                    }
                    if (txtSaleWholeSaleCreditRateWithGST.Text != string.Empty)
                    {
                        txtCreditHollSaleRate.Text = Math.Round((Utility.ParseValue(txtSaleWholeSaleCreditRateWithGST.Text) * 100) / (100 + Utility.ParseValue(txtIGST.Text)), 2).ToString();
                    }
                    else
                    {
                        txtCreditHollSaleRate.Text = "0";
                    }
                }
                else
                {
                    txtCGST.Text = "0";
                    txtSGST.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
     
        private void btnItemList_Click(object sender, EventArgs e)
        {
            try
            {
                //     frmItemDetails frmItemDetails = new frmItemDetails();
                // frmItemDetails.Close();
                //this.Dispose();
                btnnew_Click(sender, e);
                frmItemDetailsList frm = new frmItemDetailsList();
                frm.IdentityUpdated += new frmItemDetailsList.IdentityUpdateHandler(IdForm_ButtonClicked);
                frm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public long StockId = 0;
        public long ItemIDUpdate = 0;
        public int categoryId1 = 0;
        public int companyId1 = 0;
      
     
        private void IdForm_ButtonClicked(object sender, frmItemDetailsList.IndentityUpdateEventArgs e)
        {
            try
            {
                Utility.ClearSpace(this);
                Utility.enableFields(this);
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                BindComboBoxgetCategory();
                BimdComboBoxCompany();
                BindComboBoxItemName();
                itemId = 0;
                //cmbWeightIn.SelectedIndex = 0;
                cmbItemName.Focus();
                chkBxExpiry.Enabled = true;
                isUpdate = false;
                txtIGST.SelectedIndex = 0;
                chkBxExpiry.Checked = false;
                btnDelete.Visible = true;
                btnDelete.Enabled = true;
                StockId = 0;
                isDelete = false;
                StockId = e.StockId;
                DataTable itemList = stockController.getIemList("ItemDetailsListByStockId",StockId);
                ItemIDUpdate = Convert.ToInt64(itemList.Rows[0]["itemId"]);
                categoryId1 = Convert.ToInt32(itemList.Rows[0]["categoryId"]);
                companyId1 = Convert.ToInt32(itemList.Rows[0]["companyId"]);
                cmbItemName.Text = itemList.Rows[0]["itemName"].ToString();
                cmbCategory.Text = itemList.Rows[0]["categoryName"].ToString();
                cmbCompany.Text = itemList.Rows[0]["companyName"].ToString();
                txtProductCode.Text = itemList.Rows[0]["productCode"].ToString();
                txtRackNo.Text = itemList.Rows[0]["rackNo"].ToString();
                txtHNSCode.Text = itemList.Rows[0]["HNSCode"].ToString();
                txtBatchNo.Text = itemList.Rows[0]["batchNo"].ToString();
                txtReorder.Text = itemList.Rows[0]["reorderLevel"].ToString();
                cmbWeightIn.Text = itemList.Rows[0]["unitBy"].ToString();
                txtQty.Text = itemList.Rows[0]["openingStock"].ToString();
                txtMRP.Text = itemList.Rows[0]["MRP"].ToString();
                txtPurchaseRate.Text = itemList.Rows[0]["purchaseRate"].ToString();
                txtSaleWithGST.Text =Math.Round(Convert.ToDouble(itemList.Rows[0]["salesCashRate"]) + (Convert.ToDouble(itemList.Rows[0]["salesCashRate"]) * Convert.ToDouble(itemList.Rows[0]["IGST"])) / 100 ,2).ToString();

                txtPurchaseRateWithGST.Text = Math.Round(Convert.ToDouble(itemList.Rows[0]["purchaseRate"]) + (Convert.ToDouble(itemList.Rows[0]["purchaseRate"]) * Convert.ToDouble(itemList.Rows[0]["IGST"])) / 100, 2).ToString();
                txtIGST.Text = Convert.ToDouble(itemList.Rows[0]["IGST"]).ToString("#0.00");
                txtCGST.Text = Convert.ToDouble(itemList.Rows[0]["CGST"]).ToString();
                txtSGST.Text = Convert.ToDouble(itemList.Rows[0]["SGST"]).ToString();
                txtSaleCreditRate.Text = itemList.Rows[0]["salesCreditRate"].ToString();
                txtCashSaleRate.Text = itemList.Rows[0]["salesCashRate"].ToString();
                txtCashHollSaleRate.Text = itemList.Rows[0]["wholeSalesCashRate"].ToString();
                txtCreditHollSaleRate.Text = itemList.Rows[0]["wholeSalesCreditRate"].ToString();
                chkBxExpiry.Checked =Convert.ToBoolean( itemList.Rows[0]["isExpiryApplicable"]);
                txtSaleCreditRateWithGST.Text = (Math.Round(Convert.ToDouble(itemList.Rows[0]["salesCreditRate"].ToString()) + (Convert.ToDouble(itemList.Rows[0]["salesCreditRate"].ToString()) * Convert.ToDouble(itemList.Rows[0]["IGST"].ToString())) / 100, 2)).ToString();
                txtSaleWholeSaleRateWithGST.Text = (Math.Round(Convert.ToDouble(itemList.Rows[0]["wholeSalesCashRate"].ToString()) + (Convert.ToDouble(itemList.Rows[0]["wholeSalesCashRate"].ToString()) * Convert.ToDouble(itemList.Rows[0]["IGST"].ToString())) / 100, 2)).ToString();
                txtSaleWholeSaleCreditRateWithGST.Text = (Math.Round(Convert.ToDouble(itemList.Rows[0]["wholeSalesCreditRate"].ToString()) + (Convert.ToDouble(itemList.Rows[0]["wholeSalesCreditRate"].ToString()) * Convert.ToDouble(itemList.Rows[0]["IGST"].ToString())) / 100, 2)).ToString();
               
                dtpMfgDate.Value= Convert.ToDateTime(itemList.Rows[0]["MFD_Date"]);
                dtpExpDate.Value = Convert.ToDateTime(itemList.Rows[0]["expireDate"]);
                cmbMainCategory.Text = itemList.Rows[0]["mainCategory"].ToString();
                btnSave.Text = "अपडेट";
                isUpdate = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtSaleWithGST_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSaleWithGST.Text != string.Empty && txtIGST.Text != string.Empty)
                {
                    txtCashSaleRate.Text = Math.Round((Utility.ParseValue(txtSaleWithGST.Text) * 100)/(100 + Utility.ParseValue(txtIGST.Text)), 2).ToString();
                }
                else
                {
                    txtCashSaleRate.Text = "0";
                }
            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void txtCashSaleRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCashSaleRate.Text != string.Empty && txtIGST.Text != string.Empty)
                {
                    txtSaleWithGST.Text = Math.Round(Utility.ParseValue(txtCashSaleRate.Text)+((Utility.ParseValue(txtCashSaleRate.Text) *(Utility.ParseValue(txtIGST.Text)/ 100))), 2).ToString();
                }
                else
                {
                    txtCashSaleRate.Text = "0";
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void txtSaleWithGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtSaleWithGST.Text.Length == 0)
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
                if (e.KeyChar == '.' && txtSaleWithGST.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPurchaseRateWithGST_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPurchaseRateWithGST.Text != string.Empty && txtIGST.Text != string.Empty)
                {
                    txtPurchaseRate.Text = Math.Round((Utility.ParseValue(txtPurchaseRateWithGST.Text) * 100) / (100 + Utility.ParseValue(txtIGST.Text)), 2).ToString();
                }
                else
                {
                    txtPurchaseRate.Text = "0";
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }
        private bool isDelete = false;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = DialogResult.No;
            if (Utility.Langn == "English")
            {
                dr = MessageBox.Show("do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
            }
            else
            {
                dr = MessageBox.Show("तुम्हाला सदर माहिती डिलीट करायाचे आहे काय?", "Confirmation", MessageBoxButtons.YesNo);
            }
            if (dr == DialogResult.Yes)
            {
                isDelete = true;
                isUpdate = false;
                btnSave_Click(sender, e);
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }

        private void txtSaleCreditRateWithGST_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSaleCreditRateWithGST.Text != string.Empty && txtIGST.Text != string.Empty)
                {
                    txtSaleCreditRate.Text = Math.Round((Utility.ParseValue(txtSaleCreditRateWithGST.Text) * 100) / (100 + Utility.ParseValue(txtIGST.Text)), 2).ToString();
                }
                else
                {
                    txtSaleCreditRate.Text = txtCashSaleRate.Text;
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void txtSaleWholeSaleRateWithGST_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSaleWholeSaleRateWithGST.Text != string.Empty && txtIGST.Text != string.Empty)
                {
                    txtCashHollSaleRate.Text = Math.Round((Utility.ParseValue(txtSaleWholeSaleRateWithGST.Text) * 100) / (100 + Utility.ParseValue(txtIGST.Text)), 2).ToString();
                }
                else
                {
                    txtCashHollSaleRate.Text = txtCashSaleRate.Text; 
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void txtSaleWholeSaleCreditRateWithGST_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSaleWholeSaleCreditRateWithGST.Text != string.Empty && txtIGST.Text != string.Empty)
                {
                    txtCreditHollSaleRate.Text = Math.Round((Utility.ParseValue(txtSaleWholeSaleCreditRateWithGST.Text) * 100) / (100 + Utility.ParseValue(txtIGST.Text)), 2).ToString();
                }
                else
                {
                    txtCashSaleRate.Text = "0";
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void txtCashSaleRate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCashSaleRate.Text != string.Empty && txtIGST.Text != string.Empty)
                {
                    txtSaleWithGST.Text = Math.Round((Utility.ParseValue(txtCashSaleRate.Text) +(Utility.ParseValue(txtIGST.Text) * Utility.ParseValue(txtCashSaleRate.Text)/100)), 2).ToString();
                }
                else
                {
                    txtSaleWithGST.Text = "0";
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void txtSaleCreditRate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSaleCreditRate.Text != string.Empty && txtIGST.Text != string.Empty)
                {
                    txtSaleCreditRateWithGST.Text = Math.Round((Utility.ParseValue(txtSaleCreditRate.Text) + (Utility.ParseValue(txtIGST.Text) * Utility.ParseValue(txtSaleCreditRate.Text) / 100)), 2).ToString();
                }
                else
                {
                    txtSaleCreditRateWithGST.Text = txtSaleWithGST.Text; 
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void txtCashHollSaleRate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCashHollSaleRate.Text != string.Empty && txtIGST.Text != string.Empty)
                {
                    txtSaleWholeSaleRateWithGST.Text = Math.Round((Utility.ParseValue(txtCashHollSaleRate.Text) + (Utility.ParseValue(txtIGST.Text) * Utility.ParseValue(txtCashHollSaleRate.Text) / 100)), 2).ToString();
                }
                else
                {
                    txtSaleWithGST.Text = txtSaleWithGST.Text;
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void txtCreditHollSaleRate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCreditHollSaleRate.Text != string.Empty && txtIGST.Text != string.Empty)
                {
                    txtSaleWholeSaleCreditRateWithGST.Text = Math.Round((Utility.ParseValue(txtCreditHollSaleRate.Text) + (Utility.ParseValue(txtIGST.Text) * Utility.ParseValue(txtCreditHollSaleRate.Text) / 100)), 2).ToString();
                }
                else
                {
                    txtSaleWholeSaleCreditRateWithGST.Text = txtSaleWithGST.Text;
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void txtPurchaseRate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPurchaseRate.Text != string.Empty && txtIGST.Text != string.Empty)
                {
                    txtPurchaseRateWithGST.Text = Math.Round((Utility.ParseValue(txtPurchaseRate.Text) + (Utility.ParseValue(txtIGST.Text) * Utility.ParseValue(txtPurchaseRate.Text) / 100)), 2).ToString();
                }
                else
                {
                    txtPurchaseRateWithGST.Text = "0";
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

    }
}
