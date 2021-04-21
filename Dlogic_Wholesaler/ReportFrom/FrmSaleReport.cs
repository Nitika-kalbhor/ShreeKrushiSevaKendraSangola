using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer.controller;
using DataAccessLayer.models;
using MetroFramework.Forms;
using MetroFramework.Fonts;

namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class FrmSaleReport : MetroForm
    {
        public FrmSaleReport()
        {
            InitializeComponent();
            BindComboBoxgetCustomerName();
            dtpFromDate.Value = Utility.firstDate;
            dtpToDate.Value = Utility.lastDate;            
            dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;                   
        }
       int customerId=0;
       #region --Lang--
       public void Lang()
       {
           try
           {
               if (Utility.Langn == "English")
               {
                   lblHerader.Text = "Sale Report";
                   metroLabel2.Text = "Customer Name:";
                   lblFromDate.Text = "From Date:";
                   lblToDate.Text = "To Date:";
                   btnShow.Text = "Show";
                   btnExel.Text = "Exel";


                   dgvSaleReport.Columns[0].HeaderText = "Invoice No";
                   dgvSaleReport.Columns[1].HeaderText = "Date";
                   dgvSaleReport.Columns[2].HeaderText = "Customer Name";
                   dgvSaleReport.Columns[3].HeaderText = "Address";
                   dgvSaleReport.Columns[4].HeaderText = "Item Name";
                   dgvSaleReport.Columns[5].HeaderText = "Unit By";
                   dgvSaleReport.Columns[6].HeaderText = "Quantity";
                   dgvSaleReport.Columns[7].HeaderText = "Sale Price";
                   dgvSaleReport.Columns[8].HeaderText = "Total Sale Amt";                   
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }
       #endregion
        public void BindComboBoxgetCustomerName()
        {
            DataTable dt = customerController.getCustomerRetailerDetails("Customer");
            Utility.BindComboBoxEmptyDataSelect(cmbCustomerName, dt, "customerId", "customerName");
        }
        private void FrmSaleReport_Load(object sender, EventArgs e)
        {
            try
            {
                Lang();
                //BindComboBoxgetCustomerName();
                //dtpFromDate.Value = Utility.firstDate;
                //dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
                //dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
                //dtpToDate.Value = Utility.lastDate;                
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
                //if (cmbCustomerName.SelectedIndex == 0)
                //{
                //    MessageBox.Show("कृपया ग्राहकाचे नाव निवडा");
                //    cmbCustomerName.Focus();
                //    return;
                //}
                DataTable dtsaleReport = new DataTable();
                if (cmbCustomerName.SelectedIndex > 0)
                {
                    customerId = Convert.ToInt32(cmbCustomerName.SelectedValue);
                    dtsaleReport = saleReportController.OneDaySaleReport(customerId, Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, 1);
                    dgvSaleReport.Columns["customerName"].Visible = false;
                }
                else
                {
                    customerId = 0;
                    dtsaleReport = saleReportController.OneDaySaleReport(customerId, Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, 2);
                    dgvSaleReport.Columns["customerName"].Visible = true;
                }

               
               dgvSaleReport.DataSource = dtsaleReport;
              

                if (dtsaleReport.Rows.Count > 0)
                {                    
                    DataTable dtSaleBook = SubTot(dtsaleReport);
                    BindData(dtSaleBook);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void BindData(DataTable dtTable)
        {
            try
            {
                dgvSaleReport.DataSource = dtTable ;              
                 dgvSaleReport.AutoGenerateColumns = false;
                dgvSaleReport.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvSaleReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSaleReport.Font = new Font("Arial Unicode MS", 12);
                dgvSaleReport.EnableHeadersVisualStyles = false;

                dgvSaleReport.Rows[dgvSaleReport.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                dgvSaleReport.Rows[dgvSaleReport.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                dgvSaleReport.ClearSelection();
                foreach (DataGridViewColumn column in dgvSaleReport.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable SubTot(DataTable lstSaleBill)
        {
            try
            {
                Double SaleQty = 0.0, totalSaleAmt = 0;
                for (int i = 0; i < lstSaleBill.Rows.Count; i++)
                {

                    SaleQty += Convert.ToDouble(lstSaleBill.Rows[i]["quantity"].ToString());               
                    totalSaleAmt += Convert.ToDouble(lstSaleBill.Rows[i]["TotalBillAmt"].ToString());
                }
                DataRow dr = lstSaleBill.NewRow();

                dr["unitBy"] = "एकूण रक्कम";
                dr["quantity"] = Math.Round(SaleQty, 2);
                dr["TotalBillAmt"] = Math.Round(totalSaleAmt, 2);

                lstSaleBill.Rows.Add(dr);
                return lstSaleBill;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnExel_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelShow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ExcelShow()
        {
         try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                //Create Excel Sheets
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);
                DataTable dtExcel = new DataTable();
                if (cmbCustomerName.SelectedIndex > 0)
                {
                     dtExcel = saleReportController.OneDaySaleReport(cmbCustomerName.SelectedIndex, Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, 1);
                }
                else
                {
                    dtExcel = saleReportController.OneDaySaleReport(cmbCustomerName.SelectedIndex, Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, 2);
                }            
                     
                if (dtExcel.Rows.Count <= 0)
                {
                    return;
                }
                if (dtExcel.Rows.Count > 0)
                {
                    object qty = dtExcel.Compute("Sum(quantity)", string.Empty);
                    object saleAmt = dtExcel.Compute("Sum(TotalBillAmt)", string.Empty);                  
                    DataRow dr = dtExcel.NewRow();
                    dr["unitBy"] = "एकूण:";
                    dr["quantity"] = qty;
                    dr["TotalBillAmt"] = Math.Round(Convert.ToDecimal(saleAmt), 2);
                  
                    dtExcel.Rows.Add(dr);
                }
                if (Utility.Langn == "English")
                {
                    dtExcel.Columns["invoiceNo"].ColumnName = "Invoice No.";
                    dtExcel.Columns["salesDate"].ColumnName = "Date";
                    dtExcel.Columns["customerName"].ColumnName = "Customer Name";
                    dtExcel.Columns["customerAddress"].ColumnName = "Customer Address";
                    dtExcel.Columns["itemName"].ColumnName = "Item Name";
                    dtExcel.Columns["unitBy"].ColumnName = "Unit By";
                    dtExcel.Columns["quantity"].ColumnName = "Quantity";
                    dtExcel.Columns["perQtysalePrice"].ColumnName = "Sale Price";
                    dtExcel.Columns["TotalBillAmt"].ColumnName = "Total Sale Amt";
                }
                else
                {
                    dtExcel.Columns["invoiceNo"].ColumnName = "बिल नं.";
                    dtExcel.Columns["salesDate"].ColumnName = "दिनांक";
                    dtExcel.Columns["customerName"].ColumnName = "ग्राहकाचे नाव";
                    dtExcel.Columns["customerAddress"].ColumnName = "ग्राहकाचा पत्ता";
                    dtExcel.Columns["itemName"].ColumnName = "वस्तूचे नाव";
                    dtExcel.Columns["unitBy"].ColumnName = "पॅकिंग";
                    dtExcel.Columns["quantity"].ColumnName = "नग";
                    dtExcel.Columns["perQtysalePrice"].ColumnName = "विक्री रक्कम";
                    dtExcel.Columns["TotalBillAmt"].ColumnName = "एकूण सेल रक्कम";
                }
             
               dtExcel.TableName = "One Day Sale Report";
                xlWorksheet.Name =dtExcel.TableName;

                for (int j = 1; j <dtExcel.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] =dtExcel.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k <dtExcel.Rows.Count; k++)
                {
                    for (int l = 0; l <dtExcel.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                       dtExcel.Rows[k].ItemArray[l].ToString();
                    }
                }
                ExcelApp.Columns.AutoFit();

                ((Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.ActiveWorkbook.Sheets[ExcelApp.ActiveWorkbook.Sheets.Count]).Delete();
                ExcelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       }
    }
}
