using DataAccessLayer.controller;
using Dlogic_Wholesaler.TempReportFroms;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class frmItemLegderReport : MetroForm
    {
        int orgId = 0, categoryId = 0; long itemId = 0;
        double MRPValuation = 0, SaleValuation = 0, PurchaseValuation = 0, profit = 0;
        public frmItemLegderReport()
        {
            InitializeComponent();
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Item Ledger Report";
                    lblItemType.Text = "Item Type";
                    lblItemName.Text = "Item Name";
                    lblGodown.Text = "Company";
                    btnShow.Text = "Show";
                    btnPrint.Text = "Print";
                    metroButton3.Text = "Clear";
                    btnExport.Text = "Export";
                    metroLabel1.Text = "From Date:";
                    label1.Text = "To Date:";
                    lblDate.Text = "Date";
                    cnkSummery.Text = "Total Stock Entry";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public void BindComboBoxgetOrgnation()
        {
            DataTable dtgenderId = categoryController.getCompany();
            Utility.BindComboBoxEmptyDataSelect(cmbOrgnation, dtgenderId, "companyId", "companyName");
        }
        private void frmItemLegderReport_Load(object sender, EventArgs e)
        {
            BindComboBoxgetOrgnation();
            dtpfromDate.Value = Utility.firstDate;
            dtpToDate.Value = Utility.lastDate;
            dtpfromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpfromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
            dtpDate.Visible = false;
            lblDate.Visible = false;
            Lang();
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
                Utility.BindComboBoxDataSelect(cmbItemName, dtItemDetails, "StockId", "itemName");
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
                if (cnkSummery.Checked == false)
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
                    System.Data.DataTable dtStocktable = stockController.getItemLedgerDetails(orgId, categoryId, itemId, Convert.ToDateTime(dtpfromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, 1);
                    System.Data.DataTable dtOpeningStock = stockController.getItemLedgerDetails(orgId, categoryId, itemId, Convert.ToDateTime(dtpfromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, 3);
                    bindGrid(dtStocktable, dtOpeningStock);
                }
              if (cnkSummery.Checked == true)
              {
                  System.Data.DataTable dtStocktable = stockController.getItemLedgerSummeryDetails( Convert.ToDateTime(dtpDate.Value.ToShortDateString()), Convert.ToDateTime(dtpDate.Value.ToShortDateString()), Utility.FinancilaYearId);
               //   var data = await GetDataAsync();
                  if (dtStocktable.Rows.Count > 0)
                  {
                      bindGrid(dtStocktable);
                  }
                  else
                  {
                      dgvStockRegister.DataSource = null;
                      MessageBox.Show("सदर दिनांक मध्ये विक्री झाली नाही");
                  }
              }
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error:-" + ae.ToString());
            }
        }
        //public async Task<DataTable> GetDataAsync()
        //{
        //    DataTable dt = new DataTable();
        //    await Task.Run(() => {dt= stockController.getItemLedgerSummeryDetails(Convert.ToDateTime(dtpDate.Value.ToShortDateString()), Convert.ToDateTime(dtpDate.Value.ToShortDateString()), Utility.FinancilaYearId); });
        //    return dt;
        //}
        public  DataTable dtAvakJavakRegister()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("purchaseInvoiceId", typeof(string));
            dt.Columns.Add("purchaseDate", typeof(DateTime));
            dt.Columns.Add("dealerFirmName", typeof(string));
            dt.Columns.Add("transactionType", typeof(string));
            dt.Columns.Add("itemName", typeof(string));
            dt.Columns.Add("StockIn", typeof(string));
            dt.Columns.Add("StockOut", typeof(string));         
            return dt;
        }
        public void bindGrid(DataTable dtStockValueation, DataTable dtOpeningStock)
        {
            try
            {
              
                dgvStockRegister.DataSource = null;
                dgvStockRegister.AutoGenerateColumns = false;
                dgvStockRegister.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvStockRegister.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvStockRegister.ColumnCount = 8;
                dgvStockRegister.Font = new Font("Arial Unicode MS", 12);

                dgvStockRegister.EnableHeadersVisualStyles = false;

                if (Utility.Langn == "English")
                {
                    dgvStockRegister.Columns[0].HeaderText = "Bill No";
                    dgvStockRegister.Columns[1].HeaderText = "Date";
                    dgvStockRegister.Columns[2].HeaderText = "Naration";
                    dgvStockRegister.Columns[3].HeaderText = "Transaction Type";
                    dgvStockRegister.Columns[4].HeaderText = "Item Name";
                    dgvStockRegister.Columns[5].HeaderText = "Stock In";
                    dgvStockRegister.Columns[6].HeaderText = "Stock Out";
                    dgvStockRegister.Columns[7].HeaderText = "Godown";
                }
                else
                {
                    dgvStockRegister.Columns[0].HeaderText = "बिल न";
                    dgvStockRegister.Columns[1].HeaderText = "दिनांक";
                    dgvStockRegister.Columns[2].HeaderText = "तपशील";
                    dgvStockRegister.Columns[3].HeaderText = "व्यवहार";
                    dgvStockRegister.Columns[4].HeaderText = "वस्तूचे नाव";
                    dgvStockRegister.Columns[5].HeaderText = "स्टॉक इन";
                    dgvStockRegister.Columns[6].HeaderText = "स्टॉक ऑउट";
                    dgvStockRegister.Columns[7].HeaderText = "गोडाऊन";
                }
                dgvStockRegister.Columns[0].Name = "purchaseInvoiceId";             
                dgvStockRegister.Columns[0].DataPropertyName = "purchaseInvoiceId";
                dgvStockRegister.Columns[0].Width = 100;

                dgvStockRegister.Columns[1].Name = "purchaseDate";               
                dgvStockRegister.Columns[1].DataPropertyName = "purchaseDate";
                dgvStockRegister.Columns[1].Width = 100;

                dgvStockRegister.Columns[2].Name = "dealerFirmName";
                dgvStockRegister.Columns[2].DataPropertyName = "dealerFirmName";
                dgvStockRegister.Columns[2].Width = 200;

                dgvStockRegister.Columns[3].Name = "transactionType";               
                dgvStockRegister.Columns[3].DataPropertyName = "transactionType";
                dgvStockRegister.Columns[3].Width = 150;

                dgvStockRegister.Columns[4].Name = "itemName";              
                dgvStockRegister.Columns[4].DataPropertyName = "itemName";
                dgvStockRegister.Columns[4].Width = 450;

                dgvStockRegister.Columns[5].Name = "StockIn";               
                dgvStockRegister.Columns[5].DataPropertyName = "StockIn";
                dgvStockRegister.Columns[5].Width = 150;

                dgvStockRegister.Columns[6].Name = "StockOut";              
                dgvStockRegister.Columns[6].DataPropertyName = "StockOut";
                dgvStockRegister.Columns[6].Width = 150;

                dgvStockRegister.Columns[7].Name = "godownName";             
                dgvStockRegister.Columns[7].DataPropertyName = "godownName";
                dgvStockRegister.Columns[7].Width = 150;

                double StockIns = 0, StockOuts = 0;
                for (int i = 0; i < dtStockValueation.Rows.Count; i++)
                {
                    if (dtStockValueation.Rows[i]["StockIn"].ToString() != string.Empty)
                    {
                        StockIns += Convert.ToDouble(dtStockValueation.Rows[i]["StockIn"]);
                    }
                    if (dtStockValueation.Rows[i]["StockOut"].ToString() != string.Empty)
                    {
                        StockOuts += Convert.ToDouble(dtStockValueation.Rows[i]["StockOut"]);
                    }
                }
                DataRow dr = dtStockValueation.NewRow();
                if (Utility.Langn == "English")
                {
                    dr["itemName"] = "Total";
                }
                else
                {
                    dr["itemName"] = "एकूण";
                }
                dr["StockIn"] = StockIns.ToString();
                dr["StockOut"] = StockOuts.ToString();
                dtStockValueation.Rows.Add(dr);
                if (dtOpeningStock.Rows.Count > 0)
                {
                DataRow dr1 = dtStockValueation.NewRow();
               
                if (Utility.Langn == "English")
                {
                    dr1["itemName"] = "Remaining Stock";
                }
                else
                {
                    dr1["itemName"] = "शिल्लक साठा";
                }
                dr1["StockIn"] = (Convert.ToDouble(dtOpeningStock.Rows[0]["StockIn"]) + StockIns) - StockOuts;
                    dtStockValueation.Rows.Add(dr1);
                }
                DataTable dts = dtAvakJavakRegister();
                dts.Merge(dtOpeningStock);
                dts.Merge(dtStockValueation);
                dgvStockRegister.DataSource = dts;
                if(dgvStockRegister.Rows.Count>0)
                {
                    dgvStockRegister.Rows[0].DefaultCellStyle.BackColor = Color.Gold;                   
                    dgvStockRegister.Rows[0].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12,FontStyle.Bold);
                    dgvStockRegister.Rows[dgvStockRegister.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gold;
                    dgvStockRegister.Rows[dgvStockRegister.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                    dgvStockRegister.Rows[dgvStockRegister.Rows.Count - 2].DefaultCellStyle.BackColor = Color.LightPink;
                    dgvStockRegister.Rows[dgvStockRegister.Rows.Count - 2].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error", ae.ToString());
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
                dgvStockRegister.ColumnCount = 13;
                dgvStockRegister.Font = new Font("Arial Unicode MS", 12);
                dgvStockRegister.EnableHeadersVisualStyles = false;
                if (Utility.Langn == "English")
                {
                    dgvStockRegister.Columns[0].HeaderText = "Date";
                    dgvStockRegister.Columns[1].HeaderText = "Category";
                    dgvStockRegister.Columns[2].HeaderText = "Company";
                    dgvStockRegister.Columns[3].HeaderText = "Item Name";
                    dgvStockRegister.Columns[4].HeaderText = "Unit By";
                    dgvStockRegister.Columns[5].HeaderText = "Batch No Expiry Date";
                    dgvStockRegister.Columns[6].HeaderText = "Opening Stock";
                    dgvStockRegister.Columns[7].HeaderText = "Stock In";
                    dgvStockRegister.Columns[8].HeaderText = "Current Stock";
                    dgvStockRegister.Columns[9].HeaderText = "Stock Out";
                    dgvStockRegister.Columns[10].HeaderText = "closing Stock";
                    dgvStockRegister.Columns[11].HeaderText = "Bill No";
                    dgvStockRegister.Columns[12].HeaderText = "Dealer Name Bill No Date";
                }
                else
                {
                    dgvStockRegister.Columns[0].HeaderText = "दिनांक";
                    dgvStockRegister.Columns[1].HeaderText = "प्रकार";
                    dgvStockRegister.Columns[2].HeaderText = "कंपनी";
                    dgvStockRegister.Columns[3].HeaderText = "वस्तूचे  नाव";
                    dgvStockRegister.Columns[4].HeaderText = "unitBy";
                    dgvStockRegister.Columns[5].HeaderText = "बॅच नंबर उत्पदन अंतिम मुदत दिनांक";
                    dgvStockRegister.Columns[6].HeaderText = "आरंभीची शिल्लक";
                    dgvStockRegister.Columns[7].HeaderText = "दिवसातील आलेला माल";
                    dgvStockRegister.Columns[8].HeaderText = "एकूण साठा";
                    dgvStockRegister.Columns[9].HeaderText = "दिवसातील विक्री";
                    dgvStockRegister.Columns[10].HeaderText = "अखेर शिल्लक";
                    dgvStockRegister.Columns[11].HeaderText = "पहिल्या व शेवटच्या बिलाचा नं";
                    dgvStockRegister.Columns[12].HeaderText = "पुरवठादाराचे नाव बिल नं दिनांक";
                }
                dgvStockRegister.Columns[0].Name = "purchaseDate";               
                dgvStockRegister.Columns[0].DataPropertyName = "purchaseDate";
                dgvStockRegister.Columns[0].Width = 100;
                dgvStockRegister.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvStockRegister.Columns[1].Name = "categoryName";
                dgvStockRegister.Columns[1].DataPropertyName = "categoryName";
                dgvStockRegister.Columns[1].Width = 100;

                dgvStockRegister.Columns[2].Name = "companyName";               
                dgvStockRegister.Columns[2].DataPropertyName = "companyName";
                dgvStockRegister.Columns[2].Width = 100;

                dgvStockRegister.Columns[3].Name = "itemName";               
                dgvStockRegister.Columns[3].DataPropertyName = "itemName";
                dgvStockRegister.Columns[3].Width = 100;

                dgvStockRegister.Columns[4].Name = "unitBy";               
                dgvStockRegister.Columns[4].DataPropertyName = "unitBy";
                dgvStockRegister.Columns[4].Width = 100;

                dgvStockRegister.Columns[5].Name = "batchNo";              
                dgvStockRegister.Columns[5].DataPropertyName = "batchNo";
                dgvStockRegister.Columns[5].Width = 180;

                dgvStockRegister.Columns[6].Name = "openingStock";            
                dgvStockRegister.Columns[6].DataPropertyName = "openingStock";
                dgvStockRegister.Columns[6].Width = 100;

                dgvStockRegister.Columns[7].Name = "StockIn";               
                dgvStockRegister.Columns[7].DataPropertyName = "StockIn";
                dgvStockRegister.Columns[7].Width = 100;

                dgvStockRegister.Columns[8].Name = "currentStock";              
                dgvStockRegister.Columns[8].DataPropertyName = "currentStock";
                dgvStockRegister.Columns[8].Width = 100;

                dgvStockRegister.Columns[9].Name = "StockOut";               
                dgvStockRegister.Columns[9].DataPropertyName = "StockOut";
                dgvStockRegister.Columns[9].Width = 100;

                dgvStockRegister.Columns[10].Name = "closingStock";               
                dgvStockRegister.Columns[10].DataPropertyName = "closingStock";
                dgvStockRegister.Columns[10].Width = 100;

                dgvStockRegister.Columns[11].Name = "BillNo";              
                dgvStockRegister.Columns[11].DataPropertyName = "BillNo";
                dgvStockRegister.Columns[11].Width = 120;

                dgvStockRegister.Columns[12].Name = "purchaseInvoice";               
                dgvStockRegister.Columns[12].DataPropertyName = "purchaseInvoice";
                dgvStockRegister.Columns[12].Width = 180;
               
                dgvStockRegister.DataSource = dtStockValueation;
                // pThread.Abort();
                // sqlThread.Abort();
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error", ae.ToString());
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
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
                ds.Columns.Remove("प्रकार");
                ds.Columns.Remove("कंपनी");
                ds.Columns.Remove("बॅच नंबर उत्पदन अंतिम मुदत दिनांक");
                ds.TableName = "Item Ledger Report";
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

        private void frmItemLegderReport_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.T && e.Alt)
            {
                try
                {
                    frmTempItemLegderReport frm = new frmTempItemLegderReport();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void cnkSummery_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cnkSummery.Checked == true)
                {
                    pnlItemLeger.Visible = false;
                    dtpDate.Visible = true;
                    lblDate.Visible = true;
                    dgvStockRegister.DataSource = null;
                }
                else
                {
                    pnlItemLeger.Visible = true;
                    dtpDate.Visible = false;
                    lblDate.Visible = false;
                    dgvStockRegister.DataSource = null;
                }
            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
           
        }
    }
}
