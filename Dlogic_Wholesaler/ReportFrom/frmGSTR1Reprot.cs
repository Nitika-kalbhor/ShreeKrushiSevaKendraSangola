using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using DataAccessLayer.controller;

namespace Dlogic_Wholesaler.ReportForms
{
    public partial class frmGSTR1Reprot : MetroForm
    {
        public frmGSTR1Reprot()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataSet gstR1DS = gstR1Controller.getGSTR1Report(Convert.ToDateTime(dtpFrom.Value.ToShortDateString()), Convert.ToDateTime(dtpTo.Value.ToShortDateString()),Utility.FinancilaYearId, "GSTR1");
               dgvB2B.DataSource= gstR1DS.Tables[0];
              dgvB2CL.DataSource = gstR1DS.Tables[1];
               dgvB2Cs.DataSource = gstR1DS.Tables[2];
               dgvcndr.DataSource = gstR1DS.Tables[3];
               dgvcndnur.DataSource = gstR1DS.Tables[4];
               dgvExp.DataSource=gstR1DS.Tables[5];
                dgvAt.DataSource=gstR1DS.Tables[6];
                dgvAtadj.DataSource=gstR1DS.Tables[7];
                dgvExemp.DataSource = gstR1DS.Tables[8];
               dgvSummaryForHSN.DataSource = gstR1DS.Tables[9];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void gttDate()
        {
            try
            {
                System.Data.DataSet dateCurrentDt = gstR1Controller.getGSTR1Report(Convert.ToDateTime(dtpFrom.Value.ToShortDateString()), Convert.ToDateTime(dtpTo.Value.ToShortDateString()),Utility.FinancilaYearId, "dateCurrent");
                dtpFrom.Value = Convert.ToDateTime(dateCurrentDt.Tables[0].Rows[0]["fromDate"]);
                dtpTo.Value = Convert.ToDateTime(dateCurrentDt.Tables[0].Rows[0]["toDate"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmGSTR1Reprot_Load(object sender, EventArgs e)
        {
             try
            {
                gttDate();
                btnShow_Click(sender, e);
            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        private void btnExcelB2CS_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);              
                DataTable dtAccount =new DataTable();

                foreach (DataGridViewColumn col in dgvB2Cs.Columns)
                {
                    dtAccount.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvB2Cs.Rows)
                {
                    DataRow dRow = dtAccount.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                     
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtAccount.Rows.Add(dRow);
                }
               
                dtAccount.TableName = "b2cs";
                xlWorksheet.Name = dtAccount.TableName;

                for (int j = 1; j < dtAccount.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = dtAccount.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < dtAccount.Rows.Count; k++)
                {
                    for (int l = 0; l < dtAccount.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        dtAccount.Rows[k].ItemArray[l].ToString();
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
        private void btnExcelB2CL_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);
                DataTable dtAccount = new DataTable();

                foreach (DataGridViewColumn col in dgvB2CL.Columns)
                {
                    dtAccount.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvB2CL.Rows)
                {
                    DataRow dRow = dtAccount.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtAccount.Rows.Add(dRow);
                }

                dtAccount.TableName = "b2cl";
                xlWorksheet.Name = dtAccount.TableName;

                for (int j = 1; j < dtAccount.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = dtAccount.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < dtAccount.Rows.Count; k++)
                {
                    for (int l = 0; l < dtAccount.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        dtAccount.Rows[k].ItemArray[l].ToString();
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

        private void btnExcelB2B_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);
                DataTable dtAccount = new DataTable();

                foreach (DataGridViewColumn col in dgvB2B.Columns)
                {
                    dtAccount.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvB2B.Rows)
                {
                    DataRow dRow = dtAccount.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtAccount.Rows.Add(dRow);
                }

                dtAccount.TableName = "b2b";
                xlWorksheet.Name = dtAccount.TableName;

                for (int j = 1; j < dtAccount.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = dtAccount.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < dtAccount.Rows.Count; k++)
                {
                    for (int l = 0; l < dtAccount.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        dtAccount.Rows[k].ItemArray[l].ToString();
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


        private void btnExcelHsn_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);
                DataTable dtAccount = new DataTable();

                foreach (DataGridViewColumn col in dgvSummaryForHSN.Columns)
                {
                    dtAccount.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvSummaryForHSN.Rows)
                {
                    DataRow dRow = dtAccount.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtAccount.Rows.Add(dRow);
                }

                dtAccount.TableName = "hsn";
                xlWorksheet.Name = dtAccount.TableName;

                for (int j = 1; j < dtAccount.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = dtAccount.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < dtAccount.Rows.Count; k++)
                {
                    for (int l = 0; l < dtAccount.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        dtAccount.Rows[k].ItemArray[l].ToString();
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

        private void btneExcelReport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                System.Data.DataSet ds = new DataSet();
               ds = gstR1Controller.getGSTR1Report(Convert.ToDateTime(dtpFrom.Value.ToShortDateString()), Convert.ToDateTime(dtpTo.Value.ToShortDateString()),Utility.FinancilaYearId, "GSTR1");
                DataTableCollection collection = ds.Tables;
                ds.Tables[0].TableName = "b2b";
                ds.Tables[0].Columns["GSTIN_UINofRecipient"].ColumnName = "GSTIN/UIN of Recipient";
                ds.Tables[0].Columns["InvoiceNumber"].ColumnName = "Invoice Number";
                ds.Tables[0].Columns["Invoicedate"].ColumnName = "Invoice date";
                ds.Tables[0].Columns["InvoiceValue"].ColumnName = "Invoice Value";
                ds.Tables[0].Columns["PlaceOfSupply"].ColumnName = "Place Of Supply";
                ds.Tables[0].Columns["ReverseCharge"].ColumnName = "Reverse Charge";
                ds.Tables[0].Columns["InvoiceType"].ColumnName = "Invoice Type";
                ds.Tables[0].Columns["E_CommerceGSTIN"].ColumnName = "E-Commerce GSTIN";
                ds.Tables[0].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[0].Columns["TaxableValue"].ColumnName = "Taxable Value";
                ds.Tables[0].Columns["CessAmount"].ColumnName = "Cess Amount";


                ds.Tables[1].TableName = "b2cl";
              
                ds.Tables[1].Columns["InvoiceNumber"].ColumnName = "Invoice Number";
                ds.Tables[1].Columns["Invoicedate"].ColumnName = "Invoice date";
                ds.Tables[1].Columns["InvoiceValue"].ColumnName = "Invoice Value";
                ds.Tables[1].Columns["PlaceOfSupply"].ColumnName = "Place Of Supply";               
                ds.Tables[1].Columns["E_CommerceGSTIN"].ColumnName = "E-Commerce GSTIN";
                ds.Tables[1].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[1].Columns["TaxableValue"].ColumnName = "Taxable Value";
                ds.Tables[1].Columns["CessAmount"].ColumnName = "Cess Amount";



                ds.Tables[2].TableName = "b2cs";
                ds.Tables[2].Columns["Type"].ColumnName = "Type";
                ds.Tables[2].Columns["PlaceOfSupply"].ColumnName = "Place Of Supply";              
                ds.Tables[2].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[2].Columns["TaxableValue"].ColumnName = "Taxable Value";
                ds.Tables[2].Columns["CessAmount"].ColumnName = "Cess Amount";
                ds.Tables[2].Columns["E_CommerceGSTIN"].ColumnName = "E-Commerce GSTIN";

                ds.Tables[3].TableName = "cndr";
                ds.Tables[3].Columns["GSTIN_UINofRecipient"].ColumnName = "GSTIN/UIN of Recipient";
                ds.Tables[3].Columns["Invoice_AdvanceReceiptNumber"].ColumnName = "Invoice/Advance Receipt Number";
                ds.Tables[3].Columns["Invoice_AdvanceReceiptdate"].ColumnName = "Invoice/Advance Receipt date";
                ds.Tables[3].Columns["Note_RefundVoucherNumber"].ColumnName = "Note/Refund Voucher Number";
                ds.Tables[3].Columns["Note_RefundVoucherdate"].ColumnName = "Note/Refund Voucher date";
                ds.Tables[3].Columns["DocumentType"].ColumnName = "Document Type";
                ds.Tables[3].Columns["ReasonForIssuingdocument"].ColumnName = "Reason For Issuing document";
                ds.Tables[3].Columns["PlaceOfSupply"].ColumnName = "Place Of Supply";
                ds.Tables[3].Columns["Note_RefundVoucherValue"].ColumnName = "Note/Refund Voucher Value";
                ds.Tables[3].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[3].Columns["TaxableValue"].ColumnName = "Taxable Value";
                ds.Tables[3].Columns["CessAmount"].ColumnName = "Cess Amount";
                ds.Tables[3].Columns["PreGST"].ColumnName = "Pre GST";

                ds.Tables[4].TableName = "cndur";
                ds.Tables[4].Columns["URType"].ColumnName = "UR Type";
                ds.Tables[4].Columns["Note_RefundVoucherNumber"].ColumnName = "Note/Refund Voucher Number";
                ds.Tables[4].Columns["Note_RefundVoucherdate"].ColumnName = "Note/Refund Voucher date";
                ds.Tables[4].Columns["DocumentType"].ColumnName = "Document Type";
                ds.Tables[4].Columns["Invoice_AdvanceReceiptNumber"].ColumnName = "Invoice/Advance Receipt Number";
                ds.Tables[4].Columns["Invoice_AdvanceReceiptdate"].ColumnName = "Invoice/Advance Receipt date";
                ds.Tables[4].Columns["ReasonForIssuingdocument"].ColumnName = "Reason For Issuing document";
                ds.Tables[4].Columns["PlaceOfSupply"].ColumnName = "Place Of Supply";
                ds.Tables[4].Columns["Note_RefundVoucherValue"].ColumnName = "Note/Refund Voucher Value";
                ds.Tables[4].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[4].Columns["TaxableValue"].ColumnName = "Taxable Value";
                ds.Tables[4].Columns["CessAmount"].ColumnName = "Cess Amount";
                ds.Tables[4].Columns["PreGST"].ColumnName = "Pre GST";

                ds.Tables[5].TableName = "exp";
                ds.Tables[5].Columns["ExportType"].ColumnName = "Export Type";
                ds.Tables[5].Columns["InvoiceNumber"].ColumnName = "Invoice Number";
                ds.Tables[5].Columns["Invoicedate"].ColumnName = "Invoice date";
                ds.Tables[5].Columns["InvoiceValue"].ColumnName = "Invoice Value";
                ds.Tables[5].Columns["PortCode"].ColumnName = "Port Code";
                ds.Tables[5].Columns["ShippingBillNumber"].ColumnName = "Shipping Bill Number";
                ds.Tables[5].Columns["ShippingBillDate"].ColumnName = "Shipping Bill Date";
                ds.Tables[5].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[5].Columns["TaxableValue"].ColumnName = "Taxable Value";

                ds.Tables[6].TableName = "at";
                ds.Tables[6].Columns["PlaceOfSupply"].ColumnName = "Place Of Supply";
                ds.Tables[6].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[6].Columns["GrossAdvanceReceived"].ColumnName = "Gross Advance Received";
                ds.Tables[6].Columns["CessAmount"].ColumnName = "Cess Amount";

                ds.Tables[7].TableName = "atadj";
                ds.Tables[7].Columns["PlaceOfSupply"].ColumnName = "Place Of Supply";
                ds.Tables[7].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[7].Columns["GrossAdvanceAdjusted"].ColumnName = "Gross Advance Adjusted";
                ds.Tables[7].Columns["CessAmount"].ColumnName = "Cess Amount";

                ds.Tables[8].TableName = "exemp";
                ds.Tables[8].Columns["Description"].ColumnName = "Description";
                ds.Tables[8].Columns["NilRatedSupplies"].ColumnName = "Nil Rated Supplies";
                ds.Tables[8].Columns["Exempted"].ColumnName = "Exempted (other than nil rated/non GST supply )";
                ds.Tables[8].Columns["NonGSTsupplies"].ColumnName = "Non-GST supplies";

                ds.Tables[9].TableName = "hsn";
                ds.Tables[9].Columns["HSNCode"].ColumnName = "HSN";
                ds.Tables[9].Columns["Description"].ColumnName = "Description";
                ds.Tables[9].Columns["UQC"].ColumnName = "UQC";
                ds.Tables[9].Columns["TotalQuantity"].ColumnName = "Total Quantity";
                ds.Tables[9].Columns["TaxableValue"].ColumnName = "Taxable Value";
                ds.Tables[9].Columns["IntegratedTaxAmount"].ColumnName = "Integrated Tax Amount";
                ds.Tables[9].Columns["CentralTaxAmount"].ColumnName = "Central Tax Amount";
                ds.Tables[9].Columns["State_UTTaxAmount"].ColumnName = "State/UT Tax Amount";
                ds.Tables[9].Columns["CessAmount"].ColumnName = "Cess Amount";
              
        
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabcdnr_Click(object sender, EventArgs e)
        {

        }

        private void btncndr_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);
                DataTable dtAccount = new DataTable();

                foreach (DataGridViewColumn col in dgvcndr.Columns)
                {
                    dtAccount.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvcndr.Rows)
                {
                    DataRow dRow = dtAccount.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtAccount.Rows.Add(dRow);
                }

                dtAccount.TableName = "cndr";
                xlWorksheet.Name = dtAccount.TableName;

                for (int j = 1; j < dtAccount.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = dtAccount.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < dtAccount.Rows.Count; k++)
                {
                    for (int l = 0; l < dtAccount.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        dtAccount.Rows[k].ItemArray[l].ToString();
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

        private void btncndur_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);
                DataTable dtAccount = new DataTable();

                foreach (DataGridViewColumn col in dgvcndnur.Columns)
                {
                    dtAccount.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvcndnur.Rows)
                {
                    DataRow dRow = dtAccount.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtAccount.Rows.Add(dRow);
                }

                dtAccount.TableName = "cndur";
                xlWorksheet.Name = dtAccount.TableName;

                for (int j = 1; j < dtAccount.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = dtAccount.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < dtAccount.Rows.Count; k++)
                {
                    for (int l = 0; l < dtAccount.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        dtAccount.Rows[k].ItemArray[l].ToString();
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

        private void frmGSTR1Reprot_KeyDown(object sender, KeyEventArgs e)
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
