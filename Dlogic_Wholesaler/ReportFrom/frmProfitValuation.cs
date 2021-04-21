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
    public partial class frmProfitValuation : MetroForm
    {
        public frmProfitValuation()
        {
            InitializeComponent();
        }
        int orgId = 0, categoryId = 0; long itemId = 0;
        double MRPValuation = 0, SaleValuation = 0, PurchaseValuation = 0, profit=0;
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
                    lblHerader.Text = "Profit Valuation Report";
                    gbsarch.Text = "Search";
                    lblItemType.Text = "Item Type:";
                    lblItemName.Text = "Item Name:";
                    lblGodown.Text = "Company:";
                    btnShow.Text = "Show";
                     btnPrint.Text = "Print";
                    metroButton3.Text = "Clear";
                    btnExport.Text = "Export";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmProfitValuation_Load(object sender, EventArgs e)
        {
            BindComboBoxgetOrgnation();
            Lang();
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
                System.Data.DataTable dtStocktable = stockController.getProfitValuationDetails(orgId, categoryId, itemId);
                MRPValuation = 0;
                for (int i = 0; i < dtStocktable.Rows.Count; ++i)
                {
                    MRPValuation += Convert.ToDouble(dtStocktable.Rows[i]["MRPValuation"]);
                    SaleValuation += Convert.ToDouble(dtStocktable.Rows[i]["SalesValuation"]);
                    PurchaseValuation += Convert.ToDouble(dtStocktable.Rows[i]["purchaseValuation"]);

                }
                DataRow dr = dtStocktable.NewRow();

                //  dr["orjName"] = "एकून रक्कम";
                dr["itemName"] = "एकूण रक्कम";
                dr["batchNo"] = "";
                dr["currentStock"] = 0;
                dr["MRP"] = 0;
                dr["MRPValuation"] = MRPValuation;
                dr["SalesValuation"] = SaleValuation;
                dr["purchaseValuation"] = PurchaseValuation;
                dr["MRPProfitEstimation"] = MRPValuation - PurchaseValuation;
                dr["SalesProfitEstimation"] = SaleValuation - PurchaseValuation;
                dtStocktable.Rows.Add(dr);
                bindGrid(dtStocktable);
            }
            catch (Exception ae)
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
                dgvStockRegister.ColumnCount =12;
                dgvStockRegister.Font = new Font("Arial Unicode MS", 9);

                dgvStockRegister.EnableHeadersVisualStyles = false;

                if (Utility.Langn == "English")
                {
                    dgvStockRegister.Columns[0].HeaderText = "Item Name";
                    dgvStockRegister.Columns[1].HeaderText = "Unit By";
                    dgvStockRegister.Columns[2].HeaderText = "Batch No";
                    dgvStockRegister.Columns[3].HeaderText = "Current Stock";
                    dgvStockRegister.Columns[4].HeaderText = "MRP";
                    dgvStockRegister.Columns[5].HeaderText = "MRP Valuation";
                    dgvStockRegister.Columns[6].HeaderText = "Sale Rate";
                    dgvStockRegister.Columns[7].HeaderText = "Sale Valuation";
                    dgvStockRegister.Columns[8].HeaderText = "Purchase Rate";
                    dgvStockRegister.Columns[9].HeaderText = "Purchase Valuation";
                    dgvStockRegister.Columns[10].HeaderText = "Profit Estimation(By MRP)";
                    dgvStockRegister.Columns[11].HeaderText = "Profit Estimation(By SaleRate)";
                }
                else
                {
                    dgvStockRegister.Columns[0].HeaderText = "वस्तूचे नाव";
                    dgvStockRegister.Columns[1].HeaderText = "पॅकिंग";
                    dgvStockRegister.Columns[2].HeaderText = "बॅच न";
                    dgvStockRegister.Columns[3].HeaderText = "उपलब्ध स्टॉक";
                    dgvStockRegister.Columns[4].HeaderText = "एम.र.पी";
                    dgvStockRegister.Columns[5].HeaderText = "एम.र.पी व्याल्युयशन";
                    dgvStockRegister.Columns[6].HeaderText = "सेल दर";
                    dgvStockRegister.Columns[7].HeaderText = "सेल व्याल्युयशन";
                    dgvStockRegister.Columns[8].HeaderText = "खरेदी दर";
                    dgvStockRegister.Columns[9].HeaderText = "एकूण खरेदी रक्कम";
                    dgvStockRegister.Columns[10].HeaderText = "अंदाजे नफा(एम.र.पी नुसार)";
                    dgvStockRegister.Columns[11].HeaderText = "अंदाजे नफा(विक्री दरा नुसार)";
                }
                dgvStockRegister.Columns[0].Name = "itemName";
                dgvStockRegister.Columns[0].DataPropertyName = "itemName";
                dgvStockRegister.Columns[0].Width = 300;

                dgvStockRegister.Columns[1].Name = "unitBy";
                dgvStockRegister.Columns[1].DataPropertyName = "unitBy";
                dgvStockRegister.Columns[1].Width = 80;

                dgvStockRegister.Columns[2].Name = "batchNo";
                dgvStockRegister.Columns[2].DataPropertyName = "batchNo";
                dgvStockRegister.Columns[2].Width = 80;

                dgvStockRegister.Columns[3].Name = "currentStock";
                dgvStockRegister.Columns[3].DataPropertyName = "currentStock";
                dgvStockRegister.Columns[3].Width = 100;

                dgvStockRegister.Columns[4].Name = "MRP";
                dgvStockRegister.Columns[4].DataPropertyName = "MRP";
                dgvStockRegister.Columns[4].Width = 80;

                dgvStockRegister.Columns[5].Name = "MRPValuation";
                dgvStockRegister.Columns[5].DataPropertyName = "MRPValuation";
                dgvStockRegister.Columns[5].Width = 100; ;

                dgvStockRegister.Columns[6].Name = "salesCashRate";              
                dgvStockRegister.Columns[6].DataPropertyName = "salesCashRate";
                dgvStockRegister.Columns[6].Width = 80;

                dgvStockRegister.Columns[7].Name = "SalesValuation";              
                dgvStockRegister.Columns[7].DataPropertyName = "SalesValuation";
                dgvStockRegister.Columns[7].Width = 100;

                dgvStockRegister.Columns[8].Name = "purchaseRate";               
                dgvStockRegister.Columns[8].DataPropertyName = "purchaseRate";
                dgvStockRegister.Columns[8].Width = 80;

                dgvStockRegister.Columns[9].Name = "purchaseValuation";              
                dgvStockRegister.Columns[9].DataPropertyName = "purchaseValuation";
                dgvStockRegister.Columns[9].Width = 100;

                dgvStockRegister.Columns[10].Name = "MRPProfitEstimation";               
                dgvStockRegister.Columns[10].DataPropertyName = "MRPProfitEstimation";
                dgvStockRegister.Columns[10].Width = 100;

                dgvStockRegister.Columns[11].Name = "SalesProfitEstimation";              
                dgvStockRegister.Columns[11].DataPropertyName = "SalesProfitEstimation";
                dgvStockRegister.Columns[11].Width = 120; 

                dgvStockRegister.DataSource = dtStockValueation;
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error", ae.ToString());
            }
        }

        private void cmbOrgnation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
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
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
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
                    row.DefaultCellStyle.Font = new System.Drawing.Font("Arial Unicode MS", 9, FontStyle.Bold);
                }


            }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = stockController.getProfitValuationDetails(orgId, categoryId, itemId);
                Report rp = new Report();
                crpProfitValuation crReportDocument = new crpProfitValuation();
               // crReportDocument.SetDataSource(dt);
                crReportDocument.Database.Tables[0].SetDataSource(dt);
                crReportDocument.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                rp.crystalReportViewer1.ReportSource = crReportDocument;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                // Loop over DataTables in DataSet.
                System.Data.DataTable ds = new DataTable();
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
                ds.TableName = "अंदाजे नफा रिपोर्ट";
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

        private void frmProfitValuation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                try
                {

                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
