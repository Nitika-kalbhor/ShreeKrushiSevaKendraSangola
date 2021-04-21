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
    public partial class frmGstSummary : MetroForm
    {
        public frmGstSummary()
        {
            InitializeComponent();
            cmbMainCategory.SelectedIndex = 0;
            dtpFromDate.Value = Utility.firstDate;
            dtpToDate.Value = Utility.lastDate;
            dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
           
        }
        // On worker thread so do our thing!
     
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                pbar.Visible = true;
                bindGSTSummary();
                bindGrid();
                pbar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   
        private void bindGSTSummary()
        {
            try
            {
                DataTable dt = gstSummaryController.getGSTSummary(dtpFromDate.Value, dtpToDate.Value, "GSTSUMMARY", cmbMainCategory.Text.Trim());
                if (dt.Rows.Count>0)
                {
                    object PGST = dt.Compute("SUM(InputGST)", string.Empty);
                    object GST = dt.Compute("SUM(OutPutGST)", string.Empty);
                  
                    DataRow dr = dt.NewRow();
                    dr["total"] = "Total:";
                    dr["InputGST"] =  Math.Round(Convert.ToDecimal(PGST),2);
                    dr["OutPutGST"] =  Math.Round(Convert.ToDecimal(GST),2);
                    dr["balanceGST"] = Math.Round(Convert.ToDecimal(GST) - Convert.ToDecimal(PGST),2);
                    dt.Rows.Add(dr);
                }
                dgvGST.DataSource = dt;
                dgvGST.ClearSelection();
                if (dgvGST.Rows.Count > 0)
                {
                    dgvGST.Rows[dgvGST.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                    dgvGST.Rows[dgvGST.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                }

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
                if (chGst.Checked == false)
                {
                    if (cmbMainCategory.SelectedIndex == 0)
                    {
                        dt = gstSummaryController.getGSTSummary(dtpFromDate.Value, dtpToDate.Value, "AllGST", cmbMainCategory.Text.Trim());
                    }
                    else
                    {
                        dt = gstSummaryController.getGSTSummary(dtpFromDate.Value, dtpToDate.Value, "OnlyMainCategory", cmbMainCategory.Text.Trim());
                    }
                   
                  
                    dgvCategory.Columns["itemName"].Visible = true;
                }
                else
                {
                    dt = gstSummaryController.getGSTSummary(dtpFromDate.Value, dtpToDate.Value, "CategorySummary", cmbMainCategory.Text.Trim());
                  
                    dgvCategory.Columns["itemName"].Visible = false;
                }
                if (dt.Rows.Count > 0)
                {
                    object inputGST51 = dt.Compute("SUM(inputGST5)", string.Empty);
                    object inputGST121 = dt.Compute("SUM(inputGST12)", string.Empty);
                    object inputGST181 = dt.Compute("SUM(inputGST18)", string.Empty);
                    object inputGST281 = dt.Compute("SUM(inputGST28)", string.Empty);

                    object GST51 = dt.Compute("SUM(GST5)", string.Empty);
                    object GST121 = dt.Compute("SUM(GST12)", string.Empty);
                    object GST181 = dt.Compute("SUM(GST18)", string.Empty);
                    object GST281 = dt.Compute("SUM(GST28)", string.Empty);

                    DataRow dr = dt.NewRow();
                    dr["mainCategory"] = "Total:";
                    dr["inputGST5"] = Math.Round(Convert.ToDecimal(inputGST51), 2);
                    dr["inputGST12"] = Math.Round(Convert.ToDecimal(inputGST121), 2); //inputGST121;
                    dr["inputGST18"] = Math.Round(Convert.ToDecimal(inputGST181), 2); //inputGST181;
                    dr["inputGST28"] = Math.Round(Convert.ToDecimal(inputGST281), 2); //inputGST281;
                    dr["GST5"] = Math.Round(Convert.ToDecimal(GST51), 2); //GST51;
                    dr["GST12"] = Math.Round(Convert.ToDecimal(GST121), 2); //GST121;
                    dr["GST18"] = Math.Round(Convert.ToDecimal(GST181), 2); //GST181;
                    dr["GST28"] = Math.Round(Convert.ToDecimal(GST281), 2); //GST281;

                    dt.Rows.Add(dr);
                }
                dgvCategory.DataSource = dt;

                dgvCategory.ClearSelection();
                if (dgvCategory.Rows.Count > 0)
                {
                   
                    dgvCategory.Rows[dgvCategory.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                    dgvCategory.Rows[dgvCategory.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 14, FontStyle.Bold);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chGst_CheckedChanged(object sender, EventArgs e)
        {
            try{
                pbar.Visible = true;
                if(chGst.Checked)
                {
                    cmbMainCategory.Enabled = false;
                 
                }
                else
                {
                    cmbMainCategory.Enabled = true;
                }
                cmbMainCategory.SelectedIndex = 0;
                bindGrid();
                pbar.Visible = false;
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmGstSummary_Load(object sender, EventArgs e)
        {
            try
            {
               
                pbar.Visible = true;
                bindGSTSummary();
                bindGrid();
                pbar.Visible = false;
               
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
               
                pbar.Visible = true;
               
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                // Loop over DataTables in DataSet.
                DataSet ds = new DataSet();
                DataTable dtGST = new DataTable();
                foreach (DataGridViewColumn col in dgvGST.Columns)
                {
                    dtGST.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvGST.Rows)
                {
                    DataRow dRow = dtGST.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtGST.Rows.Add(dRow);
                }
                DataTable dtCate = new DataTable();
                foreach (DataGridViewColumn col in dgvCategory.Columns)
                {
                    dtCate.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvCategory.Rows)
                {
                    DataRow dRow = dtCate.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtCate.Rows.Add(dRow);
                }
                ds.Tables.Add(dtGST);
                ds.Tables.Add(dtCate);
                DataTableCollection collection = ds.Tables;

                for (int i = collection.Count; i > 0; i--)
                {
                    Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                    //Create Excel Sheets
                    xlSheets = ExcelApp.Sheets;
                    xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                                   Type.Missing, Type.Missing, Type.Missing);

                    System.Data.DataTable table = collection[i - 1];
                    xlWorksheet.Name = table.TableName;

                    for (int j = 1; j < table.Columns.Count + 1; j++)
                    {
                        ExcelApp.Cells[1, j] = table.Columns[j - 1].ColumnName;
                    }

                    // Storing Each row and column value to excel sheet
                    for (int k = 0; k < table.Rows.Count; k++)
                    {
                        for (int l = 0; l < table.Columns.Count; l++)
                        {
                            ExcelApp.Cells[k + 2, l + 1] =
                            table.Rows[k].ItemArray[l].ToString();
                        }
                    }
                    ExcelApp.Columns.AutoFit();
                }
                ((Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.ActiveWorkbook.Sheets[ExcelApp.ActiveWorkbook.Sheets.Count]).Delete();
                ExcelApp.Visible = true;
                pbar.Visible = false;
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
