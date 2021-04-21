using System;
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
    public partial class FrmStockOpeningClosingReport : MetroForm
    {
        public FrmStockOpeningClosingReport()
        {
            InitializeComponent();
            Lang();
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Stock Opening Closing Report";
                    btnShow.Text = "Show";
                    btnPrint.Text = "Print";
                    btnExel.Text = "Exel";
                    label1.Text = "From Date:";
                    lblDate.Text = "To Date:";                   
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
                System.Data.DataTable dtOpeningStock = stockController.getAvakJavakRegisterStockOpeningClosing(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId);
               //System.Data.DataTable dtClosingStock = stockController.getItemLedgerDetailsForStockOpeningClosing(Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId);
               // dtOpeningStock.Merge(dtClosingStock);
                //   var data = await GetDataAsync();
                if (dtOpeningStock.Rows.Count > 0)
                {
                    bindGrid(dtOpeningStock);
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
                dgvStockRegister.ColumnCount =10;
                dgvStockRegister.Font = new Font("Arial Unicode MS", 10);
                dgvStockRegister.EnableHeadersVisualStyles = false;
                if (Utility.Langn == "English")
                { }
                else
                {

                }

                dgvStockRegister.Columns[0].Name = "categoryName";
                dgvStockRegister.Columns[0].HeaderText = "प्रकार";
                dgvStockRegister.Columns[0].DataPropertyName = "categoryName";
                dgvStockRegister.Columns[0].Width = 80;
             
                dgvStockRegister.Columns[1].Name = "itemName";
                dgvStockRegister.Columns[1].HeaderText = "वस्तूचे  नाव";
                dgvStockRegister.Columns[1].DataPropertyName = "itemName";
                dgvStockRegister.Columns[1].Width = 50;

                dgvStockRegister.Columns[2].Name = "companyName";
                dgvStockRegister.Columns[2].HeaderText = "कंपनी";
                dgvStockRegister.Columns[2].DataPropertyName = "companyName";
                dgvStockRegister.Columns[2].Width = 50;

                dgvStockRegister.Columns[3].Name = "unitBy";
                dgvStockRegister.Columns[3].HeaderText = "unitBy";
                dgvStockRegister.Columns[3].DataPropertyName = "unitBy";
                dgvStockRegister.Columns[3].Width = 50;

                dgvStockRegister.Columns[4].Name = "batchNo";
                dgvStockRegister.Columns[4].HeaderText = "बॅच नंबर";
                dgvStockRegister.Columns[4].DataPropertyName = "batchNo";
                dgvStockRegister.Columns[4].Width = 50;

                dgvStockRegister.Columns[5].Name = "purchaseRate";
                dgvStockRegister.Columns[5].HeaderText = "खरेदी दर";
                dgvStockRegister.Columns[5].DataPropertyName = "purchaseRate";
                dgvStockRegister.Columns[5].Width = 50;

                dgvStockRegister.Columns[6].Name = "openingStock";
                dgvStockRegister.Columns[6].HeaderText = "आरंभीची शिल्लक आरंभी दिनांक";
                dgvStockRegister.Columns[6].DataPropertyName = "openingStockWithDate";
                dgvStockRegister.Columns[6].Width = 70;

                dgvStockRegister.Columns[7].Name = "currentStock";
                dgvStockRegister.Columns[7].HeaderText = "आरंभी एकूण खरेदी दर";
                dgvStockRegister.Columns[7].DataPropertyName = "TotalOpeningPurchaseRate";
                dgvStockRegister.Columns[7].Width = 70;
              
                dgvStockRegister.Columns[8].Name = "closingStock";
                dgvStockRegister.Columns[8].HeaderText = "अखेर शिल्लक अखेर दिनांक";
                dgvStockRegister.Columns[8].DataPropertyName = "closingStockWithDate";
                dgvStockRegister.Columns[8].Width = 70;

                dgvStockRegister.Columns[9].Name = "closingStock";
                dgvStockRegister.Columns[9].HeaderText = "अखेर एकूण खरेदी दर";
                dgvStockRegister.Columns[9].DataPropertyName = "TotalClosingPurchaseRate";
                dgvStockRegister.Columns[9].Width = 70;             
          
                dgvStockRegister.DataSource = dtStockValueation;
                // pThread.Abort();
                // sqlThread.Abort();
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error", ae.ToString());
            }
        }

        private void btnExel_Click(object sender, System.EventArgs e)
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
    }
}
