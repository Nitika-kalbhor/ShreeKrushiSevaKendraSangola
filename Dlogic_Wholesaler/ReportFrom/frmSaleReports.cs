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

namespace Dlogic_Wholesaler.ReportFroms
{
    public partial class frmSaleReports : MetroForm
    {
        public frmSaleReports()
        {
            InitializeComponent();
        }
        public void BindComboBoxItemNameBy()
        {
            try
            {
                DataTable dtcmbItemName = itemDetailsController.getItemNameBy();
                Utility.BindComboBoxDataSelect(cmbitemName, dtcmbItemName, "itemId", "itemName");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSaleReports_Load(object sender, EventArgs e)
        {
            try
            {
                BindComboBoxItemNameBy();
                dtpFromDate.Value = Utility.startDate(System.DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getBindDataGrid(DataTable dtSale)
        {
            dgvSale.DataSource = null;
            dgvSale.AutoGenerateColumns = false;
            dgvSale.EnableHeadersVisualStyles = false;
            dgvSale.ColumnCount = 16;

            dgvSale.Columns[0].Name = "saleInvoiceId";
            dgvSale.Columns[0].HeaderText = "बिल नं";
            dgvSale.Columns[0].DataPropertyName = "saleInvoiceId";
            dgvSale.Columns[0].Width = 80;
            dgvSale.Columns[1].Name = "saleDate";
            dgvSale.Columns[1].HeaderText = "दिनांक";
            dgvSale.Columns[1].DataPropertyName = "saleDate";
            dgvSale.Columns[2].Name = "orjName";
            dgvSale.Columns[2].HeaderText = "कंपनी नांव";
            dgvSale.Columns[2].DataPropertyName = "orjName";
            dgvSale.Columns[2].Width = 180;
            dgvSale.Columns[3].Name = "naration";
            dgvSale.Columns[3].HeaderText = "तपशील";
            dgvSale.Columns[3].DataPropertyName = "naration";
            dgvSale.Columns[3].Width = 180;

            dgvSale.Columns[4].Name = "batchNo";
            dgvSale.Columns[4].HeaderText = "बैच नंबर";
            dgvSale.Columns[4].DataPropertyName = "batchNo";
            dgvSale.Columns[4].Width = 100;


            dgvSale.Columns[5].Name = "Quantity";
            dgvSale.Columns[5].HeaderText = "नग";
            dgvSale.Columns[5].DataPropertyName = "Quantity";
          
            dgvSale.Columns[6].Name = "weightIn";
            dgvSale.Columns[6].HeaderText = "मध्ये";
            dgvSale.Columns[6].DataPropertyName = "weightIn";
            dgvSale.Columns[6].Width = 80;
            dgvSale.Columns[7].Name = "saleRate";
            dgvSale.Columns[7].HeaderText = "दर";
            dgvSale.Columns[7].DataPropertyName = "saleRate";
              dgvSale.Columns[8].Width = 120;
              dgvSale.Columns[8].Name = "discountAmount";
              dgvSale.Columns[8].HeaderText = "सवलत रक्कम";
              dgvSale.Columns[8].DataPropertyName = "discountAmount";
              dgvSale.Columns[8].Width = 100;
              dgvSale.Columns[9].Name = "IGST";
              dgvSale.Columns[9].HeaderText = "IGST(%)";
              dgvSale.Columns[9].DataPropertyName = "IGST";
              dgvSale.Columns[8].Width = 100;
              dgvSale.Columns[10].Name = "IGSTAmount";
              dgvSale.Columns[10].HeaderText = "IGST रक्कम";
              dgvSale.Columns[10].DataPropertyName = "IGSTAmount";
              dgvSale.Columns[8].Width = 100;
              dgvSale.Columns[11].Name = "CGST";
              dgvSale.Columns[11].HeaderText = "CGST(%)";
              dgvSale.Columns[11].DataPropertyName = "CGST";
              dgvSale.Columns[8].Width = 100;
              dgvSale.Columns[12].Name = "CGSTAmount";
              dgvSale.Columns[12].HeaderText = "CGST रक्कम";
              dgvSale.Columns[12].DataPropertyName = "CGSTAmount";
              dgvSale.Columns[8].Width = 100;
              dgvSale.Columns[13].Name = "SGST";
              dgvSale.Columns[13].HeaderText = "SGST(%)";
              dgvSale.Columns[13].DataPropertyName = "SGST";
              dgvSale.Columns[8].Width = 100;
              dgvSale.Columns[14].Name = "SGSTAmount";
              dgvSale.Columns[14].HeaderText = "SGST रक्कम";
              dgvSale.Columns[14].DataPropertyName = "SGSTAmount";
              dgvSale.Columns[8].Width = 100;
              dgvSale.Columns[15].Name = "totalAmount";
              dgvSale.Columns[15].HeaderText = "नेट रक्कम";
              dgvSale.Columns[15].DataPropertyName = "totalAmount";
              dgvSale.Columns[15].Width = 120;
              dgvSale.DataSource = dtSale;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = saleReportController.getSaleReports(Convert.ToInt64(cmbitemName.SelectedValue),
                    Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), chbQuation.Checked);
                getBindDataGrid(dt);
            }
            catch(Exception ac)
            {
                MessageBox.Show(ac.Message);
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
                foreach (DataGridViewColumn col in dgvSale.Columns)
                {
                    ds.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvSale.Rows)
                {
                    DataRow dRow = ds.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    ds.Rows.Add(dRow);
                }
                ds.TableName = "Sale Report";
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

        private void cmbitemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbitemName.SelectedIndex!=0)
                {
                    DataTable dt = saleReportController.getSaleReports(Convert.ToInt64(cmbitemName.SelectedValue),
                   Convert.ToDateTime( dtpFromDate.Value.ToShortDateString()),  Convert.ToDateTime( dtpToDate.Value.ToShortDateString()), chbQuation.Checked);
                    getBindDataGrid(dt);
                }
                else
                {
                    dgvSale.DataSource = null;
                }
            }
            catch (Exception ac)
            {
                MessageBox.Show(ac.Message);
            }
        }

        private void chbQuation_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbitemName.SelectedIndex != 0)
                {
                    DataTable dt = saleReportController.getSaleReports(Convert.ToInt64(cmbitemName.SelectedValue),
                    Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), chbQuation.Checked);
                    getBindDataGrid(dt);
                }
                else
                {
                    dgvSale.DataSource = null;
                }
            }
            catch (Exception ac)
            {
                MessageBox.Show(ac.Message);
            }
        }

        private void dgvSale_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvSale.Rows)
                {
                    string RowType = null;
                    RowType = row.Cells[7].Value.ToString();
                    if (RowType == "एकूण रक्कम:")
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new Font("Arial Unicode MS", 14);
                    }
                }

            }
            catch (Exception ac)
            {
                MessageBox.Show(ac.Message);
            }
        }

        private void frmSaleReports_KeyDown(object sender, KeyEventArgs e)
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
