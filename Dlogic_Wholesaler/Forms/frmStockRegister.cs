using DataAccessLayer.controller;
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
    public partial class frmStockRegister : MetroForm
    {
        public frmStockRegister()
        {
            InitializeComponent();
            cmbMainCategory.SelectedIndex = 0;
        }
      bool  isLoad=false;
        public void BindComboBoxgetCategory()
        {
            DataTable dtgenderId = categoryController.getCategory();
            Utility.BindComboBoxDataSelect(cmbCategory, dtgenderId, "categoryId", "categoryName");
        }
        public void BindComboBoxItemName()
        {
            DataTable dtgenderId = itemDetailsController.getItemNameBy();
            Utility.BindComboBoxDataSelect(cmbItemName, dtgenderId, "itemId", "itemName");
        }
        public void BindGoDown()
        {

            DataTable dtgenderId = itemWiseSaleController.getGodownDetals();
            Utility.BindComboBoxDataSelect(cmbGoDown, dtgenderId, "godown", "godownName");
        }
          private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (cmbCategory.SelectedIndex != 0)
                //{
                //    cmbCompany.Enabled = true;
                //    DataTable dtgenderId = categoryController.getCategoryByCompany(Convert.ToInt32(cmbCategory.SelectedValue));
                //    Utility.BindComboBoxDataSelect(cmbCompany, dtgenderId, "companyId", "companyName");

                //}
                //else
                //{
                //    cmbCompany.Enabled = false;
                //    cmbCompany.SelectedIndex = -1;

                //}
               // BindComboBoxItemName();
            }
            catch (Exception)
            {

            }
        }
      private  void BindLoad()
        {
            try
            {
                if (cmbMainCategory.SelectedIndex == 0 && cmbGoDown.SelectedIndex==0)
                {
                    BindComboBoxgetCategory();
                    BindComboBoxItemName();
                    DataTable dtStocktable = itemWiseSaleController.getStockRegisterType("AllStock", cmbMainCategory.Text.Trim(),cmbGoDown.Text.Trim()); //stockController.getStockDetails(0, 0, 0, "AllStock");

                     getStockDetails(dtStocktable);
                   
                }
                else if (cmbMainCategory.SelectedIndex > 0 && cmbGoDown.SelectedIndex == 0)
                {

                    DataTable dtRe = itemWiseSaleController.getStockRegisterType("CategoryName", cmbMainCategory.Text.Trim(), cmbGoDown.Text.Trim());
                    getStockDetails(dtRe);
                  
                }
                else if (cmbMainCategory.SelectedIndex ==0 && cmbGoDown.SelectedIndex > 0)
                {

                    DataTable dtRe = itemWiseSaleController.getStockRegisterType("AllStockGoDown", cmbMainCategory.Text.Trim(), cmbGoDown.Text.Trim());
                    getStockDetails(dtRe);

                }
                else if (cmbMainCategory.SelectedIndex > 0 && cmbGoDown.SelectedIndex > 0)
                {

                    DataTable dtRe = itemWiseSaleController.getStockRegisterType("AllStockGoDownCategoryName", cmbMainCategory.Text.Trim(), cmbGoDown.Text.Trim());
                    getStockDetails(dtRe);

                }
                double sumQty = 0;
                for (int i = 0; i < dgvStockRegister.Rows.Count; i++)
                {
                    if (dgvStockRegister.Rows[i].Cells["currentStock"].Value != DBNull.Value)
                    {
                        sumQty += Utility.ParseValue(dgvStockRegister.Rows[i].Cells["currentStock"].Value.ToString());
                    }
                }
                txtSumQty.Text = Math.Round(Convert.ToDouble(sumQty)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
      #region --Lang--
      public void Lang()
      {
          try
          {
              if (Utility.Langn == "English")
              {
                  lblHerader.Text = "Stock Details";
                  label3.Text = "Other:";
                  label2.Text = "Company:";
                //  gbsarch.Text = "Show";
                  label6.Text = "Godown:";
                  label5.Text = "Category Name:";
                  label1.Text = "Search";
                  btnNewItem.Text = "Show";
                  btnExcel.Text = "Exel";
                  label4.Text = "Total Available Qty:";                 
              }
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message);
          }
      }
      #endregion
        private void frmStockRegister_Load(object sender, EventArgs e)
        {
            try
            {
                Lang();
                BindGoDown();
                BindLoad();
                isLoad = true;                
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getStockDetails(DataTable dtStocktables)
        {
            try
            {
                dgvStockRegister.DataSource = null;
              //  DataTable lstcustomerDetails = customerController.getCustomerDetails();
                dgvStockRegister.AutoGenerateColumns = false;
                dgvStockRegister.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvStockRegister.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvStockRegister.Font = new Font("Arial Unicode MS", 12);

                dgvStockRegister.EnableHeadersVisualStyles = false;

                dgvStockRegister.ColumnCount = 21;
                if (Utility.Langn == "English")
                {
                     dgvStockRegister.Columns[0].HeaderText = "Godown";
                      dgvStockRegister.Columns[1].HeaderText = "Category";
                    dgvStockRegister.Columns[2].HeaderText = "Company";
                     dgvStockRegister.Columns[3].HeaderText = "Item Name";
                      dgvStockRegister.Columns[4].HeaderText = "Unit By";
                      dgvStockRegister.Columns[5].HeaderText = "Batch No";
                     dgvStockRegister.Columns[6].HeaderText = "Rack No";
                     dgvStockRegister.Columns[7].HeaderText = "HSNCode";
                      dgvStockRegister.Columns[8].HeaderText = "MFG Date";
                       dgvStockRegister.Columns[9].HeaderText = "Expiry Date";
                       dgvStockRegister.Columns[11].HeaderText = "Opening Stock";
                       dgvStockRegister.Columns[12].HeaderText = "Current Stock";
                       dgvStockRegister.Columns[13].HeaderText = "purchase Stock";
                       dgvStockRegister.Columns[14].HeaderText = "Purchase Return Stock";
                     dgvStockRegister.Columns[15].HeaderText = "Sale Stock";
                      dgvStockRegister.Columns[16].HeaderText = "Sale Return Stock";
                     dgvStockRegister.Columns[18].HeaderText = "Stock In";
                      dgvStockRegister.Columns[19].HeaderText = "Stock Out";
                      dgvStockRegister.Columns[20].HeaderText = "damaged Stock";

                }
                else{
                    dgvStockRegister.Columns[0].HeaderText = "गोडाउन";
                    dgvStockRegister.Columns[1].HeaderText = "प्रकार";
                    dgvStockRegister.Columns[2].HeaderText = "कंपनी";
                    dgvStockRegister.Columns[3].HeaderText = "वस्तूचे नांव";
                    dgvStockRegister.Columns[4].HeaderText = "पॅकिंग";
                    dgvStockRegister.Columns[5].HeaderText = "बॅच नं";
                    dgvStockRegister.Columns[6].HeaderText = "रॅक नं";
                    dgvStockRegister.Columns[7].HeaderText = "HSN कोड";
                    dgvStockRegister.Columns[8].HeaderText = "MFG दिनांक";
                    dgvStockRegister.Columns[9].HeaderText = "एक्स दिनांक";
                    dgvStockRegister.Columns[11].HeaderText = "आरंभी नग";
                    dgvStockRegister.Columns[12].HeaderText = "उपलब्ध नग";
                    dgvStockRegister.Columns[13].HeaderText = "खरेदी नग";
                    dgvStockRegister.Columns[14].HeaderText = "खरेदी परत नग";
                    dgvStockRegister.Columns[15].HeaderText = "सेल नग";
                    dgvStockRegister.Columns[16].HeaderText = "सेल परत नग";
                    dgvStockRegister.Columns[18].HeaderText = "स्टॉक इन";
                    dgvStockRegister.Columns[19].HeaderText = "स्टॉक आउट";
                    dgvStockRegister.Columns[20].HeaderText = "खराब स्टॉकआउट";
                }
                dgvStockRegister.Columns[0].Name = "godownName";               
                dgvStockRegister.Columns[0].DataPropertyName = "godownName";
                dgvStockRegister.Columns[0].Width = 100;

                dgvStockRegister.Columns[1].Name = "categoryName";              
                dgvStockRegister.Columns[1].DataPropertyName = "categoryName";
                dgvStockRegister.Columns[1].Width = 100;

                dgvStockRegister.Columns[2].Name = "companyName";                
                dgvStockRegister.Columns[2].DataPropertyName = "companyName";
                dgvStockRegister.Columns[2].Width = 300;

                dgvStockRegister.Columns[3].Name = "itemName";               
                dgvStockRegister.Columns[3].DataPropertyName = "itemName";
                dgvStockRegister.Columns[3].Width = 300;

                dgvStockRegister.Columns[4].Name = "weightIn";              
                dgvStockRegister.Columns[4].DataPropertyName = "weightIn";
                dgvStockRegister.Columns[4].Width = 100;             

                dgvStockRegister.Columns[5].Name = "batchNo";              
                dgvStockRegister.Columns[5].DataPropertyName = "batchNo";
                dgvStockRegister.Columns[5].Width = 150;

                dgvStockRegister.Columns[6].Name = "rackNo";               
                dgvStockRegister.Columns[6].DataPropertyName = "";
                dgvStockRegister.Columns[6].Width = 150;
                dgvStockRegister.Columns[6].Visible = false;

                dgvStockRegister.Columns[7].Name = "HNSCode";               
                dgvStockRegister.Columns[7].DataPropertyName = "HNSCode";
                dgvStockRegister.Columns[7].Width = 150;

                dgvStockRegister.Columns[8].Name = "MFD_Date";              
                dgvStockRegister.Columns[8].DataPropertyName = "MFD_Date";
                dgvStockRegister.Columns[8].Width = 150;

                dgvStockRegister.Columns[9].Name = "expireDate";
             
                dgvStockRegister.Columns[9].DataPropertyName = "expireDate";
                dgvStockRegister.Columns[9].Width = 150;

                dgvStockRegister.Columns[10].Name = "color";
                dgvStockRegister.Columns[10].HeaderText = "Color";
                dgvStockRegister.Columns[10].DataPropertyName = "color";
                dgvStockRegister.Columns[10].Visible = false;

                dgvStockRegister.Columns[11].Name = "openingStock";               
                dgvStockRegister.Columns[11].DataPropertyName = "openingStock";

                dgvStockRegister.Columns[12].Name = "currentStock";             
                dgvStockRegister.Columns[12].DataPropertyName = "currentStock";

                dgvStockRegister.Columns[13].Name = "purchaseStock";                            
                dgvStockRegister.Columns[13].DataPropertyName = "purchaseStock";

                dgvStockRegister.Columns[14].Name = "purchaseReturnStock";             
                dgvStockRegister.Columns[14].DataPropertyName = "purchaseReturnStock";

                dgvStockRegister.Columns[15].Name = "saleStock";               
                dgvStockRegister.Columns[15].DataPropertyName = "saleStock";

                dgvStockRegister.Columns[16].Name = "saleReturnStock";              
                dgvStockRegister.Columns[16].DataPropertyName = "saleReturnStock";

                dgvStockRegister.Columns[17].Name = "purchaseRate";
                dgvStockRegister.Columns[17].HeaderText = "Purchase Rate";
                dgvStockRegister.Columns[17].DataPropertyName = "purchaseRate";
                dgvStockRegister.Columns[17].Visible = false;

                dgvStockRegister.Columns[18].Name = "stockIn";               
                dgvStockRegister.Columns[18].DataPropertyName = "stockIn";

                dgvStockRegister.Columns[19].Name = "stockOut";              
                dgvStockRegister.Columns[19].DataPropertyName = "stockOut";

                dgvStockRegister.Columns[20].Name = "damagedStockExpiry";              
                dgvStockRegister.Columns[20].DataPropertyName = "damagedStockExpiry";
                
                dgvStockRegister.DataSource = dtStocktables;
                         
            }
            catch (Exception)
            {
                ////MessageBox.Show("Something went wrong in gridview");
            }

        }

        private void frmStockRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.T && e.Alt)
            {
                getTempStockDetails();
            }
        }

        private void getTempStockDetails()
        {
            try
            {
                BindComboBoxgetCategory();
                BindComboBoxItemName();
                DataTable dtStocktable = itemWiseSaleController.getStockRegisterType("TempStock", cmbMainCategory.Text.Trim(), cmbGoDown.Text.Trim()); //stockController.getStockDetails(0, 0, 0, "AllStock");

                getStockDetails(dtStocktable);
                double sumQty = 0;
                for (int i = 0; i < dgvStockRegister.Rows.Count; i++)
                {
                    if (dgvStockRegister.Rows[i].Cells["currentStock"].Value != DBNull.Value)
                    {
                        sumQty += Utility.ParseValue(dgvStockRegister.Rows[i].Cells["currentStock"].Value.ToString());
                    }
                }
                txtSumQty.Text = Math.Round(Convert.ToDouble(sumQty)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable ds = new System.Data.DataTable();
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);


                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                //Create Excel Sheets
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);
                foreach (DataGridViewColumn col in dgvStockRegister.Columns)
                {
                    ds.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvStockRegister.Rows)
                {
                    DataRow dRow = ds.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    ds.Rows.Add(dRow);
                }
                ds.TableName = "Stock Register";
                xlWorksheet.Name = ds.TableName;

                for (int j = 1; j < ds.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = ds.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < ds.Rows.Count; k++)
                {
                    for (int l = 0; l < ds.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        ds.Rows[k].ItemArray[l].ToString();
                    }
                }
                ExcelApp.Columns.AutoFit();
                ((Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.ActiveWorkbook.Sheets[ExcelApp.ActiveWorkbook.Sheets.Count]).Delete();
                ExcelApp.Visible = true;
            }
            catch (Exception ac)
            {
                MessageBox.Show(ac.Message);
            }
        }

        private void txtSreachch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtSreachch.Text!=string.Empty)
                {
                    DataTable dtStocktable = stockController.getSreachStockItem(txtSreachch.Text.ToString());
                    getStockDetails(dtStocktable);
                    double sumQty = 0;
                    for (int i = 0; i < dgvStockRegister.Rows.Count; i++)
                    {
                        if (dgvStockRegister.Rows[i].Cells["currentStock"].Value != DBNull.Value)
                        {
                            sumQty += Utility.ParseValue(dgvStockRegister.Rows[i].Cells["currentStock"].Value.ToString());
                        }
                    }
                    txtSumQty.Text = Math.Round(Convert.ToDouble(sumQty)).ToString();
                }
                else
                {
                    BindLoad();
                }

              

            //      foreach (DataGridViewRow row in dgvStockRegister.Rows)
            //{

            //    if (row.Cells[3].Value != null)
            //    {
            //        string s = row.Cells[3].Value.ToString();

            //        if (!s.StartsWith(txtSreachch.Text, true, null))
            //        {
            //            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvStockRegister.DataSource];
            //            currencyManager1.SuspendBinding();
            //            row.Visible = false;
            //            currencyManager1.ResumeBinding();
            //            dgvStockRegister.Visible = true;
            //        }
            //        else
            //            row.Visible = true;
            //    }
            //}
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvStockRegister.Rows)
                {

                    if (row.Cells[2].Value != null)
                    {
                        string s = row.Cells[1].Value.ToString();

                        if (!s.StartsWith(textBox1.Text, true, null))
                        {
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvStockRegister.DataSource];
                            currencyManager1.SuspendBinding();
                            row.Visible = false;
                            currencyManager1.ResumeBinding();
                            dgvStockRegister.Visible = true;
                        }
                        else
                            row.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvStockRegister.Rows)
                {

                    if (row.Cells[2].Value != null)
                    {
                        string s = row.Cells[2].Value.ToString();

                        if (!s.StartsWith(txtProductCode.Text, true, null))
                        {
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvStockRegister.DataSource];
                            currencyManager1.SuspendBinding();
                            row.Visible = false;
                            currencyManager1.ResumeBinding();
                            dgvStockRegister.Visible = true;
                        }
                        else
                            row.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbMainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
                if (isLoad)
                {
                    BindLoad();
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbGoDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (isLoad)
                {
                    BindLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
