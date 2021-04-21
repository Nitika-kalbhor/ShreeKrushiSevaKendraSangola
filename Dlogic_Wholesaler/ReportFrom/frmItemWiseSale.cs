using DataAccessLayer.controller;
using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Dlogic_Wholesaler.CrystalReport;
using Dlogic_Wholesaler.ReportFroms;
using MetroFramework.Forms;

namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class frmItemWiseSale : MetroForm
    {
        public frmItemWiseSale()
        {
            InitializeComponent();
            BindComboBoxItemName();
            cmbMainCategory.SelectedIndex = 0;
            dtpFromDate.Value = Utility.firstDate;
            dtpToDate.Value = Utility.lastDate;
            dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
        }
        public void BindComboBoxItemName()
        {
            try
            {
                DataTable dt = itemWiseSaleController.getItemWiseSale(Convert.ToInt64(cmbItemName.SelectedValue), Utility.FinancilaYearId, chkBatch.Checked, dtpFromDate.Value, dtpToDate.Value, 0, cmbMainCategory.Text.Trim());

                Utility.BindComboBoxEmptyDataSelect(cmbItemName, dt, "itemId", "itemName");
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
                    lblHerader.Text = "Itemwise Sale Report/Sale Return Report";
                    chkBatch.Text = "Batch No";
                    metroLabel2.Text = "Item Name";
                    label5.Text = "Category Name";
                    btnShow.Text = "Show";
                    btnPrint.Text = "Print";
                    btnExcel.Text = "Exel";                   
                    metroLabel1.Text = "From Date:";
                    metroLabel3.Text = "To Date:";

                    dgvItemWiseSale.Columns[0].HeaderText = "CustomerName";
                    dgvItemWiseSale.Columns[1].HeaderText = "Address";
                    dgvItemWiseSale.Columns[2].HeaderText = "ItemName";
                    dgvItemWiseSale.Columns[3].HeaderText = "Batch No";
                    dgvItemWiseSale.Columns[4].HeaderText = "SaleQty";
                    dgvItemWiseSale.Columns[5].HeaderText = "SaleRate";
                    dgvItemWiseSale.Columns[6].HeaderText = "SaleAmt";
                    dgvItemWiseSale.Columns[7].HeaderText = "SaleReturnQty";        
                    dgvItemWiseSale.Columns[8].HeaderText = "SaleReturnRate";
                    dgvItemWiseSale.Columns[9].HeaderText = "SaleReturnAmt";
                    dgvItemWiseSale.Columns[10].HeaderText = "netQty";
                    dgvItemWiseSale.Columns[11].HeaderText = "netAmount";             
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

     private   void ExcelShow()
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
                DataTable dtExcel = itemWiseSaleController.getItemWiseSale(Convert.ToInt64(cmbItemName.SelectedValue), Utility.FinancilaYearId, chkBatch.Checked, dtpFromDate.Value, dtpToDate.Value, 1,"");
        
                if (dtExcel.Rows.Count <= 0)
                {
                    return;
                }
                if (dtExcel.Rows.Count > 0)
                {
                    object saleqty = dtExcel.Compute("Sum(saleQuantity)", string.Empty);
                    object saleAmt = dtExcel.Compute("Sum(saleAmount)", string.Empty);
                    object saleRetqty = dtExcel.Compute("Sum(saleRetquantity)", string.Empty);
                    object saleRetAmt = dtExcel.Compute("Sum(saleRetAmount)", string.Empty);
                    object netsaleqty = dtExcel.Compute("Sum(netQty)", string.Empty);
                    object netsaleAmt = dtExcel.Compute("Sum(netAmount)", string.Empty);
                    DataRow dr = dtExcel.NewRow();
                    dr["customerAddress"] = "एकूण:";
                    dr["saleQuantity"] = saleqty;
                    dr["saleAmount"] = Math.Round(Convert.ToDecimal(saleAmt), 2);
                    dr["saleRetquantity"] = saleRetqty;
                    dr["saleRetAmount"] = Math.Round(Convert.ToDecimal(saleRetAmt), 2);
                    dr["netQty"] = netsaleqty;
                    dr["netAmount"] = Math.Round(Convert.ToDecimal(netsaleAmt), 2);
                    dtExcel.Rows.Add(dr);
                }
                dtExcel.Columns["customerName"].ColumnName = "ग्राहकाचे नांव";
                dtExcel.Columns["customerAddress"].ColumnName = "पत्ता";
                dtExcel.Columns["itemName"].ColumnName = "वस्तूचे नांव";
                dtExcel.Columns["batchNo"].ColumnName = "Batch No";
                dtExcel.Columns["saleQuantity"].ColumnName = "सेल नग";
                dtExcel.Columns["perQtysalePrice"].ColumnName = "सेल दर";
               dtExcel.Columns["saleAmount"].ColumnName = "सेल रक्कम";
               dtExcel.Columns["saleRetquantity"].ColumnName = "सेल परत नग";
               dtExcel.Columns["saleRetPerQtysalePrice"].ColumnName = "सेल परत दर";
               dtExcel.Columns["saleRetAmount"].ColumnName = "सेल परत रक्कम";
               dtExcel.Columns["netQty"].ColumnName = "नेट नग";
               dtExcel.Columns["netAmount"].ColumnName = "नेट रक्कम";
               dtExcel.TableName = "Item Wise Sale";
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
   
        private void bindGrid()
        {
            try
            {
                 DataTable dt = new DataTable();
                 if (cmbMainCategory.SelectedIndex == 0)
                 {
                     dt = itemWiseSaleController.getItemWiseSale(Convert.ToInt64(cmbItemName.SelectedValue), Utility.FinancilaYearId, chkBatch.Checked, dtpFromDate.Value, dtpToDate.Value, 1,cmbMainCategory.Text.Trim());
                     dgvItemWiseSale.Columns["customerName"].Visible = true;
                     dgvItemWiseSale.Columns["customerAddress"].Visible = true;
                 }
                 else
                 {
                     dt = itemWiseSaleController.getItemWiseSale(Convert.ToInt64(cmbItemName.SelectedValue), Utility.FinancilaYearId, chkBatch.Checked, dtpFromDate.Value, dtpToDate.Value, 2, cmbMainCategory.Text.Trim());
                     dgvItemWiseSale.Columns["customerName"].Visible = false;
                     dgvItemWiseSale.Columns["customerAddress"].Visible = false;
                 }
            
            if(dt.Rows.Count>0)
            {
            object saleqty = dt.Compute("Sum(saleQuantity)", string.Empty);
            object saleAmt = dt.Compute("Sum(saleAmount)", string.Empty);
            object saleRetqty = dt.Compute("Sum(saleRetquantity)", string.Empty);
            object saleRetAmt = dt.Compute("Sum(saleRetAmount)", string.Empty);
            object netsaleqty = dt.Compute("Sum(netQty)", string.Empty);
            object netsaleAmt = dt.Compute("Sum(netAmount)", string.Empty);
            DataRow dr = dt.NewRow();
            dr["customerAddress"] = "एकूण:";
            dr["saleQuantity"] = saleqty;
            dr["saleAmount"] =Math.Round(Convert.ToDecimal( saleAmt),2);
            dr["saleRetquantity"] = saleRetqty;
            dr["saleRetAmount"] =Math.Round(Convert.ToDecimal( saleRetAmt),2);
            dr["netQty"] = netsaleqty;
            dr["netAmount"] = Math.Round(Convert.ToDecimal(netsaleAmt),2);
            dt.Rows.Add(dr);
            }
           
           dgvItemWiseSale.DataSource = dt;
           dgvItemWiseSale.ClearSelection();
           if(dgvItemWiseSale.Rows.Count>0)
           {
               dgvItemWiseSale.Rows[dgvItemWiseSale.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
               dgvItemWiseSale.Rows[dgvItemWiseSale.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 14, FontStyle.Bold);
           }
           if (cmbItemName.SelectedIndex == 0)
           {
               dgvItemWiseSale.Columns["itemName"].Visible = true;
           }
           else
           {
               dgvItemWiseSale.Columns["itemName"].Visible = false;
           }
           if (chkBatch.Checked)
           {
               dgvItemWiseSale.Columns["batchNo"].Visible = true;
           }
           else
           {
               dgvItemWiseSale.Columns["batchNo"].Visible = false;
           }
           if (cmbMainCategory.SelectedIndex == 0)
           {
             
               dgvItemWiseSale.Columns["customerName"].Visible = true;
               dgvItemWiseSale.Columns["customerAddress"].Visible = true;
           }
           else
           {
                dgvItemWiseSale.Columns["customerName"].Visible = false;
               dgvItemWiseSale.Columns["customerAddress"].Visible = false;
           }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try{
            bindGrid();
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
                ExcelShow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmItemWiseSale_Load(object sender, EventArgs e)
        {
            Lang();
        }
    }
}
