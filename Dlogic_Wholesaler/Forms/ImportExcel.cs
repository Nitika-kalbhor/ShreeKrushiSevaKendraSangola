using DataAccessLayer.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Dlogic_Wholesaler.Forms
{
    public partial class ImportExcel : MetroForm
    {
        public ImportExcel()
        {
            InitializeComponent();
            cmbForms.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
               
                DataTable dt = new DataTable("dataTable");

                dt.Reset();
                Microsoft.Office.Interop.Excel.Workbook ExWorkbook;
                Microsoft.Office.Interop.Excel.Worksheet ExWorksheet;
                Microsoft.Office.Interop.Excel.Range ExRange;
                Microsoft.Office.Interop.Excel.Application ExObj = new Microsoft.Office.Interop.Excel.Application();

                openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK) // Test result.
                {
                    Cursor.Current = Cursors.WaitCursor;
                    txtPath.Text = openFileDialog1.FileName;
                    ExWorkbook = ExObj.Workbooks.Open(txtPath.Text, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                    ExWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)ExWorkbook.Sheets.get_Item(1);
                    ExRange = ExWorksheet.UsedRange;

                    for (int Cnum = 1; Cnum <= ExRange.Columns.Count; Cnum++)
                    {
                        dt.Columns.Add(new DataColumn((ExRange.Cells[1, Cnum] as Microsoft.Office.Interop.Excel.Range).Value2.ToString()));
                    }
                    dt.AcceptChanges();
                    for (int Rnum = 2; Rnum <= ExRange.Rows.Count; Rnum++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int Cnum = 1; Cnum <= ExRange.Columns.Count; Cnum++)
                        {
                                if ((ExRange.Cells[Rnum, Cnum] as Microsoft.Office.Interop.Excel.Range).Value2 != null)
                                {
                                    dr[Cnum - 1] = (ExRange.Cells[Rnum, Cnum] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                                }
                        }
                        dt.Rows.Add(dr);
                        dt.AcceptChanges();
                       
                    }
                    ExWorkbook.Close(true, Missing.Value, Missing.Value);
                    ExObj.Quit();
                    //System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("Excel");
                    //foreach (System.Diagnostics.Process p in process)
                    //{
                    //    if (!string.IsNullOrEmpty(p.ProcessName))
                    //    {
                    //        try
                    //        {
                    //            p.Kill();
                    //        }
                    //        catch { }
                    //    }
                    //}
                   dataGridView1.DataSource= dt;
                   Cursor.Current = Cursors.Default;
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdatedata_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbForms.SelectedIndex<=0 || cmbForms.Text=="")
                {
                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please select form...!");
                    }
                    else
                    {
                        MessageBox.Show("कृपया फॉर्म निवडा...!");
                    }
                    cmbForms.Focus();
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                DataTable dt = ((DataTable)dataGridView1.DataSource);
                int result = ImportExcelController.ImportExcelForDataBase(dt, cmbForms.Text.Trim(), 1, Convert.ToDateTime(DateTime.Now.ToShortDateString()), Utility.FinancilaYearId);
                if (result > 0)
                {
                    MessageBox.Show(result.ToString(), "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                }
                else
                {

                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
