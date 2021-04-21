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

namespace Dlogic_Wholesaler.ReportFroms
{
    public partial class frmProfitReprot : MetroForm
    {
        public frmProfitReprot()
        {
            InitializeComponent();
        }
        int orgId = 0, categoryId = 0; long itemId = 0; double amount = 0;
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Profit Report";
                    metroLabel1.Text = "Company Name:";
                    lblItemType.Text = "Item Type:";
                    lblItemName.Text = "Item Name:";
                    label1.Text = "From Date:";
                    label2.Text = "To Date:";
                    btnShow.Text = "Show";
                    btnExcel.Text = "Exel";
                    btnPrint.Text = "Print";
                    btnNew.Text = "Clear";                  

                    dgvSaleBookReport.Columns[0].HeaderText = "Serial No";
                    dgvSaleBookReport.Columns[1].HeaderText = "Item Name";
                    dgvSaleBookReport.Columns[2].HeaderText = "Unit By";
                    dgvSaleBookReport.Columns[3].HeaderText = "Batch No";
                    dgvSaleBookReport.Columns[4].HeaderText = "Sale Qty";
                    dgvSaleBookReport.Columns[5].HeaderText = "Sale Return Qty";
                    dgvSaleBookReport.Columns[6].HeaderText = "Sale Rate";
                    dgvSaleBookReport.Columns[7].HeaderText = "Purchase Rate";
                    dgvSaleBookReport.Columns[8].HeaderText = "Total Sale Amt";
                    dgvSaleBookReport.Columns[9].HeaderText = "Total Pur.Amt";
                    dgvSaleBookReport.Columns[10].HeaderText = "profit Amt";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
         public void  BindData(DataTable dtTable)
        {
            try
            {
                //dgvSaleBookReport.DataSource = null;
                dgvSaleBookReport.AutoGenerateColumns = false;
                dgvSaleBookReport.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvSaleBookReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSaleBookReport.Font = new Font("Arial Unicode MS", 12);
                dgvSaleBookReport.EnableHeadersVisualStyles = false;

                dgvSaleBookReport.Rows[dgvSaleBookReport.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                dgvSaleBookReport.Rows[dgvSaleBookReport.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                dgvSaleBookReport.ClearSelection();
                foreach (DataGridViewColumn column in dgvSaleBookReport.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BimdComboBoxCompany()
        {
            DataTable dtgenderId = categoryController.getCompany();
            Utility.BindComboBoxEmptyDataSelect(cmbCompany, dtgenderId, "companyId", "companyName");
        }
        private void frmProfitReprot_Load(object sender, EventArgs e)
        {
            BimdComboBoxCompany();
            dtpFromDate.Value =Utility.firstDate;
            dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
            dtpToDate.Value = Utility.lastDate;
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
                        dtItemDetails = stockController.getItemByCategory(Convert.ToInt32(cmbCompany.SelectedValue),Convert.ToInt32(cmbItemType.SelectedValue));
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
                    if (cmbCompany.SelectedIndex > 0)
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

                System.Data.DataTable dtStocktable = stockController.getProfitRport(orgId, itemId, Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()),Utility.FinancilaYearId, false);
                dgvSaleBookReport.DataSource = dtStocktable;

                if (dtStocktable.Rows.Count > 0)
                {
                    AddAutoIncrementColumn(dtStocktable);
                    DataTable dtSaleBook = SubTot(dtStocktable);
                    BindData(dtSaleBook);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void frmProfitReprot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                // Loop over DataTables in DataSet.
                System.Data.DataTable ds = new DataTable();
                foreach (DataGridViewColumn col in dgvSaleBookReport.Columns)
                {
                    ds.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvSaleBookReport.Rows)
                {
                    DataRow dRow = ds.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    ds.Rows.Add(dRow);
                }
                ds.TableName = "नफा रिपोर्ट";
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            System.Data.DataTable dtItemDetails=new System.Data.DataTable();
            if(cmbCompany.SelectedIndex > 0)
            {
                dtItemDetails = categoryController.getCategoryDetails(Convert.ToInt32(cmbCompany.SelectedValue));
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

        public void AddAutoIncrementColumn(DataTable dt)
        {
            try
            {
                DataColumn column = new DataColumn("SerialNo");
                column.DataType = System.Type.GetType("System.String");
                dt.Columns.Add(column);
                long index = 0;
                foreach (DataRow row in dt.Rows)
                {
                    ++index;
                    row.SetField(column, index.ToString());
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        public DataTable SubTot(DataTable lstSaleBill)
        {
            try
            {
                Double SaleQty = 0.0, totolSaleReturnQty = 0.0, totalpurchAmt = 0.0, totalSaleReturnAmt=0.0,totalSaleAmt=0;
                for (int i = 0; i < lstSaleBill.Rows.Count; i++)
                {

                    SaleQty += Convert.ToDouble(lstSaleBill.Rows[i]["SaleQuantity"].ToString());
                    totolSaleReturnQty += Convert.ToDouble(lstSaleBill.Rows[i]["salesReturnQty"].ToString());

                    totalpurchAmt += Convert.ToDouble(lstSaleBill.Rows[i]["purchAmt"].ToString());
                    totalSaleReturnAmt += Convert.ToDouble(lstSaleBill.Rows[i]["profitAmt"].ToString());
                    totalSaleAmt += Convert.ToDouble(lstSaleBill.Rows[i]["saleAmt"].ToString());
                }
                DataRow dr = lstSaleBill.NewRow();

                dr["batchNo"] = "एकूण रक्कम";
                dr["SaleQuantity"] = Math.Round(SaleQty, 2);
                dr["salesReturnQty"] = Math.Round(totolSaleReturnQty, 2);
                dr["purchAmt"] = Math.Round(totalpurchAmt, 2);
                dr["saleAmt"] = Math.Round(totalSaleAmt, 2);
                dr["profitAmt"] = Math.Round(totalSaleReturnAmt, 2);

                lstSaleBill.Rows.Add(dr);
                return lstSaleBill;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
