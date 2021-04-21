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
using Dlogic_Wholesaler.CrystalReport;

namespace Dlogic_Wholesaler.ReportFroms
{
    public partial class frmStockValuationReport : MetroForm
    {
        int orgId = 0, categoryId = 0; long itemId = 0; double amount = 0, saleAmount=0;
        
        public frmStockValuationReport()
        {
            InitializeComponent();
        }
        public void BindComboBoxgetOrgnation()
        {
            DataTable dtgenderId = categoryController.getCompany();
            Utility.BindComboBoxEmptyDataSelect(cmbOrgnation, dtgenderId, "companyId", "companyName");
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Stock Valuation Report";
                    gbsarch.Text = "Search";
                    lblItemType.Text = "Item Type:";
                    lblItemName.Text = "Item Name:";
                    label5.Text = "Category Name:";
                    lblGodown.Text = "Company:";
                    btnShow.Text = "Show";
                    metroButton3.Text = "Show 1";
                    metroButton1.Text = "Print";
                    metroButton2.Text = "Export";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmStockValuationReport_Load(object sender, EventArgs e)
        {
            BindComboBoxgetOrgnation();
            Lang();
        }

        private void cmbOrgnation_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.DataTable dtItemDetails = new System.Data.DataTable();
            if (cmbOrgnation.SelectedIndex > 0)
            {
                dtItemDetails = categoryController.getCategoryDetails(Convert.ToInt32(cmbOrgnation.SelectedValue));
            }
            else
            {
                dtItemDetails = new System.Data.DataTable();
            }
            Utility.BindComboBoxDataSelect(cmbItemType, dtItemDetails, "categoryId", "categoryName");
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dtItemDetails = new System.Data.DataTable();
                if (cmbItemType.SelectedIndex == 0)
                {
                    lblItemName.Visible = false;
                    //    lblBatchNo.Visible = false;
                    cmbItemName.Visible = false;
                    //  cmbBatchNo.Visible = false;
                    dtItemDetails = new System.Data.DataTable();
                }
                else
                {
                    if (cmbItemType.SelectedIndex > 0)
                    {
                        dtItemDetails = stockController.getItemByCategory(Convert.ToInt32(cmbOrgnation.SelectedValue), Convert.ToInt32(cmbItemType.SelectedValue));
                        cmbItemName.Visible = true;
                        lblItemName.Visible = true;
                    }
                }
                Utility.BindComboBoxDataSelect(cmbItemName, dtItemDetails, "itemId", "itemName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                orgId = 0;
                cmbMainCategory.SelectedIndex = 0;
               
                    if (cmbOrgnation.SelectedIndex > 0)
                    {
                        if (cmbItemType.SelectedIndex == 0)
                        {
                            MessageBox.Show("कृपया प्रकार निवडा.");
                            cmbItemType.Focus();
                            return;
                        }
                        else
                        {
                            if (cmbItemType.SelectedIndex > 0)
                            {
                                if (cmbItemName.SelectedIndex == 0)
                                {
                                    MessageBox.Show("कृपया वस्तूचे नाव निवडा.");
                                    cmbItemName.Focus();
                                    return;
                                }
                            }
                        }
                    }
                    if (cmbItemName.SelectedIndex > 0)
                    {
                        itemId = Convert.ToInt64(cmbItemName.SelectedValue);
                    }
                    else
                    {
                        itemId = 0;
                    }
                    System.Data.DataTable dtStocktable = stockController.getStockValuationDetails(orgId, categoryId, itemId);
                    amount = 0; saleAmount = 0;
                    for (int i = 0; i < dtStocktable.Rows.Count; ++i)
                    {
                        amount += Convert.ToDouble(dtStocktable.Rows[i]["MRPValuation"]);
                        saleAmount += Convert.ToDouble(dtStocktable.Rows[i]["SalesValuation"]);
                    }
                    DataRow dr = dtStocktable.NewRow();

                    //  dr["orjName"] = "एकून रक्कम";
                    dr["itemName"] = "एकूण रक्कम";
                    dr["batchNo"] = "";
                    dr["currentStock"] = 0;
                    dr["MRP"] = 0;
                    dr["MRPValuation"] = amount;
                    dr["salesCashRate"] = 0;
                    dr["SalesValuation"] = saleAmount;
                    dtStocktable.Rows.Add(dr);
                    bindGrid(dtStocktable);
            }
            catch(Exception ae)
            {
                MessageBox.Show("Error:-" + ae.ToString());
            }
        }
        public void bindGrid(DataTable dtStockValueation)
        {
            try
            {
                dgvStockRegister.DataSource = null;


                dgvStockRegister.AutoGenerateColumns = false;
                dgvStockRegister.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvStockRegister.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvStockRegister.ColumnCount = 8;
                dgvStockRegister.Font = new Font("Tahoma", 11);

                dgvStockRegister.EnableHeadersVisualStyles = false;
                //dgvStockRegister.Columns[1].Name = "orjName";
                //dgvStockRegister.Columns[1].HeaderText = "कंपनीचे नांव";
                //dgvStockRegister.Columns[1].DataPropertyName = "orjName";
                //dgvStockRegister.Columns[1].Width = 180;

                if (Utility.Langn == "English")
                {
                    dgvStockRegister.Columns[0].HeaderText = "Item Name";
                    dgvStockRegister.Columns[1].HeaderText = "Unit By";
                    dgvStockRegister.Columns[2].HeaderText = "Batch No";
                    dgvStockRegister.Columns[3].HeaderText = "Current Stock";
                    dgvStockRegister.Columns[5].HeaderText = "MRP";
                    dgvStockRegister.Columns[6].HeaderText = "MRP Valuation";
                    dgvStockRegister.Columns[4].HeaderText = "Sale Rate";
                    dgvStockRegister.Columns[7].HeaderText = "Sale Valuation";
                }
                else
                {
                    dgvStockRegister.Columns[0].HeaderText = "वस्तूचे नाव";
                    dgvStockRegister.Columns[1].HeaderText = "पॅकिंग";
                    dgvStockRegister.Columns[2].HeaderText = "बॅच न";
                    dgvStockRegister.Columns[3].HeaderText = "उपलब्ध स्टॉक";
                    dgvStockRegister.Columns[5].HeaderText = "एम.र.पी";
                    dgvStockRegister.Columns[6].HeaderText = "एम.र.पी व्याल्युयशन";
                    dgvStockRegister.Columns[4].HeaderText = "सेल दर";
                    dgvStockRegister.Columns[7].HeaderText = "सेल व्याल्युयशन";
                }
                dgvStockRegister.Columns[0].Name = "itemName";                
                dgvStockRegister.Columns[0].DataPropertyName = "itemName";
                dgvStockRegister.Columns[0].Width = 350;

                dgvStockRegister.Columns[1].Name = "unitBy";               
                dgvStockRegister.Columns[1].DataPropertyName = "unitBy";
                dgvStockRegister.Columns[1].Width = 100;

                dgvStockRegister.Columns[2].Name = "batchNo";               
                dgvStockRegister.Columns[2].DataPropertyName = "batchNo";
                dgvStockRegister.Columns[2].Width = 100;

                dgvStockRegister.Columns[3].Name = "currentStock";              
                dgvStockRegister.Columns[3].DataPropertyName = "currentStock";
                dgvStockRegister.Columns[3].Width = 140;

                dgvStockRegister.Columns[5].Name = "MRP";                
                dgvStockRegister.Columns[5].DataPropertyName = "MRP";
                dgvStockRegister.Columns[5].Width = 120;
               
                dgvStockRegister.Columns[6].Name = "MRPValuation";               
                dgvStockRegister.Columns[6].DataPropertyName = "MRPValuation";
                dgvStockRegister.Columns[6].Width = 180;

                dgvStockRegister.Columns[4].Name = "salesCashRate";               
                dgvStockRegister.Columns[4].DataPropertyName = "salesCashRate";
                dgvStockRegister.Columns[4].Width = 120;

                dgvStockRegister.Columns[7].Name = "SalesValuation";
                dgvStockRegister.Columns[7].DataPropertyName = "SalesValuation";
                dgvStockRegister.Columns[7].Width = 180; 
                dgvStockRegister.DataSource = dtStockValueation;
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error", ae.ToString());
            }
        }

        private void dgvStockRegister_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try { 
            foreach (DataGridViewRow row in dgvStockRegister.Rows)
            {
                string RowType = row.Cells["itemName"].Value.ToString();


                if (RowType == "एकूण रक्कम")
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.Font = new System.Drawing.Font("Arial Unicode MS", 14, FontStyle.Bold);
                }


            }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void frmStockValuationReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgvStockRegister.DataSource;
                Report rp = new Report();
                crpStockValuation crReportDocument = new crpStockValuation();
              //  crReportDocument.SetDataSource(dt);
                crReportDocument.Database.Tables[0].SetDataSource(dt);
              //  crReportDocument.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
              //  rp.crystalReportViewer1.ReportSource = crReportDocument;
                rp.crystalReportViewer1.ReportSource = crReportDocument;
                rp.crystalReportViewer1.Refresh();
                rp.Refresh();
                rp.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                // Loop over DataTables in DataSet.
                System.Data.DataTable ds = (System.Data.DataTable)dgvStockRegister.DataSource;
                ds.TableName = "Stock  Valuation";
                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                //Create Excel Sheets
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try{
                object MainCategoryName = DBNull.Value ,ItemNames=DBNull.Value,CategoryNs=DBNull.Value,CompanyName=DBNull.Value;
             if (cmbMainCategory.SelectedIndex > 0)
             {
                 MainCategoryName = cmbMainCategory.Text;
             }
             if (cmbOrgnation.SelectedIndex > 0)
             {
                 CompanyName = cmbOrgnation.SelectedValue;
             }
             if (cmbItemType.SelectedIndex > 0)
             {
                 CategoryNs = cmbItemType.SelectedValue;
             }
             if (cmbItemName.SelectedIndex > 0)
             {
                 ItemNames = cmbItemName.SelectedValue;
             }
             System.Data.DataTable dtStocktable = stockController.getStcokValuetionCategory(MainCategoryName, CompanyName, CategoryNs, ItemNames);
            amount = 0; saleAmount = 0;
            for (int i = 0; i < dtStocktable.Rows.Count; ++i)
            {
                amount += Convert.ToDouble(dtStocktable.Rows[i]["MRPValuation"]);
                saleAmount += Convert.ToDouble(dtStocktable.Rows[i]["SalesValuation"]);
            }
            DataRow dr = dtStocktable.NewRow();

            //  dr["orjName"] = "एकून रक्कम";
            dr["itemName"] = "एकूण रक्कम";
            dr["batchNo"] = "";
            dr["currentStock"] = 0;
            dr["MRP"] = 0;
            dr["MRPValuation"] = amount;
            dr["salesCashRate"] = 0;
            dr["SalesValuation"] = saleAmount;
            dtStocktable.Rows.Add(dr);
            bindGrid(dtStocktable);
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
