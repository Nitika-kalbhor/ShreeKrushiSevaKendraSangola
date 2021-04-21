using System;
using DataAccessLayer.controller;
using Dlogic_Wholesaler.TempReportFroms;
using Dlogic_Wholesaler.CrystalReport;
using Dlogic_Wholesaler.ReportFroms;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class frmSingleDayItemLedgerReport : MetroForm
    {
        string OpType = "";
        public frmSingleDayItemLedgerReport()
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
                    lblHerader.Text = "Single Day Item Ledger Report";
                    lblDate.Text = "Date:";
                     lblItemType.Text = "Item type:";
                    btnShow.Text = "Show";
                    btnPrint.Text = "Print";
                    btnExel.Text = "Exel";                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void btnShow_Click(object sender, System.EventArgs e)
        {
            
            try
            {
                if(cmbItemType.SelectedIndex<0)
                {
                    MessageBox.Show("कुपया प्रकार निवडा");
                    cmbItemType.Focus();
                    return;
                }
             
                if (cmbItemType.Text == "सर्व")
                {
                    OpType = "सर्व";
                }              
                if (cmbItemType.Text == "बियाणे" )
                {
                    OpType = "बियाणे";
                }               
                if (cmbItemType.Text == "किटकनाशके")
                {
                    OpType = "किटकनाशके";
                }
              if (cmbItemType.Text == "खते" )
                {
                    OpType = "खते";
                }             
                if (cmbItemType.Text == "PGR" )
                {
                    OpType = "PGR";
                }

                System.Data.DataTable dtStocktable = stockController.getItemLedgerDetailsByMainCategory(OpType, Convert.ToDateTime(dtpDate.Value.ToShortDateString()), Convert.ToDateTime(dtpDate.Value.ToShortDateString()), Utility.FinancilaYearId);
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
                dgvStockRegister.ColumnCount = 12;
                dgvStockRegister.Font = new Font("Arial Unicode MS", 10);
                dgvStockRegister.EnableHeadersVisualStyles = false;

                if (Utility.Langn == "English")
                {                
                    dgvStockRegister.Columns[0].HeaderText = "Date";
                    dgvStockRegister.Columns[1].HeaderText = "Category";
                    dgvStockRegister.Columns[2].HeaderText = "Item Name";
                    dgvStockRegister.Columns[3].HeaderText = "Company";                 
                    dgvStockRegister.Columns[4].HeaderText = "Unit By";
                    dgvStockRegister.Columns[5].HeaderText = "Batch No Expiry Date";
                    dgvStockRegister.Columns[6].HeaderText = "Opening Stock";
                    dgvStockRegister.Columns[7].HeaderText = "Stock In";
                    dgvStockRegister.Columns[8].HeaderText = "Current Stock";
                    dgvStockRegister.Columns[9].HeaderText = "Stock Out";
                    dgvStockRegister.Columns[10].HeaderText = "closing Stock";
                    dgvStockRegister.Columns[11].HeaderText = "First & Last Bill No";
                }
                else
                {
                    dgvStockRegister.Columns[0].HeaderText = "दिनांक";
                    dgvStockRegister.Columns[1].HeaderText = "प्रकार";
                    dgvStockRegister.Columns[2].HeaderText = "वस्तूचे  नाव";
                    dgvStockRegister.Columns[3].HeaderText = "कंपनी";
                    dgvStockRegister.Columns[4].HeaderText = "unitBy";
                    dgvStockRegister.Columns[5].HeaderText = "बॅच नंबर उत्पदन अंतिम मुदत दिनांक";
                    dgvStockRegister.Columns[6].HeaderText = "आरंभीची शिल्लक";
                    dgvStockRegister.Columns[7].HeaderText = "दिवसातील आलेला माल";
                    dgvStockRegister.Columns[8].HeaderText = "एकूण साठा";
                    dgvStockRegister.Columns[9].HeaderText = "दिवसातील विक्री";
                    dgvStockRegister.Columns[10].HeaderText = "अखेर शिल्लक";
                    dgvStockRegister.Columns[11].HeaderText = "पहिल्या व शेवटच्या बिलाचा नं";
                }

                dgvStockRegister.Columns[0].Name = "purchaseDate";               
                dgvStockRegister.Columns[0].DataPropertyName = "purchaseDate";
                dgvStockRegister.Columns[0].Width = 100;
                dgvStockRegister.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvStockRegister.Columns[0].Visible = false;

                dgvStockRegister.Columns[1].Name = "categoryName";               
                dgvStockRegister.Columns[1].DataPropertyName = "categoryName";
                dgvStockRegister.Columns[1].Width = 100; 
                dgvStockRegister.Columns[1].Visible = false;

                dgvStockRegister.Columns[2].Name = "itemName";               
                dgvStockRegister.Columns[2].DataPropertyName = "itemName";
                dgvStockRegister.Columns[2].Width = 100;

                dgvStockRegister.Columns[3].Name = "companyName";            
                dgvStockRegister.Columns[3].DataPropertyName = "companyName";
                dgvStockRegister.Columns[3].Width = 100;              

                dgvStockRegister.Columns[4].Name = "unitBy";              
                dgvStockRegister.Columns[4].DataPropertyName = "unitBy";
                dgvStockRegister.Columns[4].Width = 100;

                dgvStockRegister.Columns[5].Name = "batchNo";               
                dgvStockRegister.Columns[5].DataPropertyName = "batchNo";
                dgvStockRegister.Columns[5].Width = 170;

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
                dgvStockRegister.Columns[11].Width = 100;

                //dgvStockRegister.Columns[10].Name = "purchaseInvoice";
                //dgvStockRegister.Columns[10].HeaderText = "पुरवठादाराचे नाव बिल नं दिनांक";
                //dgvStockRegister.Columns[10].DataPropertyName = "purchaseInvoice";
                //dgvStockRegister.Columns[10].Width = 180;

                dgvStockRegister.DataSource = dtStockValueation;
                // pThread.Abort();
                // sqlThread.Abort();
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error", ae.ToString());
            }
        }

        private void btnExel_Click(object sender, EventArgs e)
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
                //ds.Columns.Remove("प्रकार");
                //ds.Columns.Remove("कंपनी");
                //ds.Columns.Remove("बॅच नंबर उत्पदन अंतिम मुदत दिनांक");
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
               System.Data.DataTable dtStocktable = stockController.getItemLedgerDetailsByMainCategory(OpType, Convert.ToDateTime(dtpDate.Value.ToShortDateString()), Convert.ToDateTime(dtpDate.Value.ToShortDateString()), Utility.FinancilaYearId);
               // dtprofitAndLoss = accountBalanceReportController.getProfitLossWithOutTotal(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()));
                Report rpt = new Report();
                CrptSingleDayItemLedger crReportDocument = new CrptSingleDayItemLedger();
                //crReportDocument.SetDataSource(dtprofitAndLoss);
                crReportDocument.Database.Tables[0].SetDataSource(Utility.dtGenericBillInfo);
                crReportDocument.Database.Tables[1].SetDataSource(dtStocktable);                
                rpt.crystalReportViewer1.ReportSource = crReportDocument;
                rpt.crystalReportViewer1.Refresh();
                rpt.Refresh();
                rpt.Show();
            }
            catch (Exception ae)
            {
                MessageBox.Show("रिपोर्ट उघडण्यास त्रुटी येत आहे" + ae.ToString());
            }
        }

        private void frmSingleDayItemLedgerReport_Load(object sender, EventArgs e)
        {
            Lang();
        }
    }
}
