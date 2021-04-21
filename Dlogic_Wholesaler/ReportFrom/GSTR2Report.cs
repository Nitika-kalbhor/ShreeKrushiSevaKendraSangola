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

namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class GSTR2Report : MetroForm
    {
        public GSTR2Report()
        {
            InitializeComponent();
        }

        private void GSTR2Report_Load(object sender, EventArgs e)
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

        private void btneExcelReport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                System.Data.DataSet ds = new DataSet();
                ds = gstR2Controller.getGSTR2Report(Convert.ToDateTime(dtpFrom.Value.ToShortDateString()), Convert.ToDateTime(dtpTo.Value.ToShortDateString()),Utility.FinancilaYearId, "GSTR2");
                DataTableCollection collection = ds.Tables;
                ds.Tables[0].TableName = "b2b";
                ds.Tables[0].Columns["GSTINofSupplier"].ColumnName = "GSTIN of Supplier";
                ds.Tables[0].Columns["InvoiceNumber"].ColumnName = "Invoice Number";
                ds.Tables[0].Columns["Invoicedate"].ColumnName = "Invoice date";
                ds.Tables[0].Columns["InvoiceValue"].ColumnName = "Invoice Value";
                ds.Tables[0].Columns["PlaceOfSupply"].ColumnName = "Place Of Supply";
                ds.Tables[0].Columns["ReverseCharge"].ColumnName = "Reverse Charge";
                ds.Tables[0].Columns["InvoiceType"].ColumnName = "Invoice Type";
                ds.Tables[0].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[0].Columns["TaxableValue"].ColumnName = "Taxable Value";
                ds.Tables[0].Columns["IntegratedTaxPaid"].ColumnName = "Integrated Tax Paid";
                ds.Tables[0].Columns["CentralTaxPaid"].ColumnName = "Central Tax Paid";
                ds.Tables[0].Columns["StateUTTaxPaid"].ColumnName = "State/UT Tax Paid";
                ds.Tables[0].Columns["CessPaid"].ColumnName = "Cess Paid";
                ds.Tables[0].Columns["EligibilityForITC"].ColumnName = "Eligibility For ITC";
                ds.Tables[0].Columns["AvailedITCIntegratedTax"].ColumnName = "Availed ITC Integrated Tax";
                ds.Tables[0].Columns["AvailedITCCentralTax"].ColumnName = "Availed ITC Central Tax";
                ds.Tables[0].Columns["AvailedITCStateUTTax"].ColumnName = "Availed ITC State/UT Tax";
                ds.Tables[0].Columns["AvailedITCCess"].ColumnName = "Availed ITC Cess"; 


                ds.Tables[1].TableName = "b2bur";

                ds.Tables[1].Columns["SupplierName"].ColumnName = "Supplier Name";
                ds.Tables[1].Columns["InvoiceNumber"].ColumnName = "Invoice Number";
                ds.Tables[1].Columns["Invoicedate"].ColumnName = "Invoice date";
                ds.Tables[1].Columns["InvoiceValue"].ColumnName = "Invoice Value";
                ds.Tables[1].Columns["PlaceOfSupply"].ColumnName = "Place Of Supply";
                ds.Tables[1].Columns["SupplyType"].ColumnName = "Supply Type";
                ds.Tables[1].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[1].Columns["TaxableValue"].ColumnName = "Taxable Value";
                ds.Tables[1].Columns["IntegratedTaxPaid"].ColumnName = "Integrated Tax Paid";
                ds.Tables[1].Columns["CentralTaxPaid"].ColumnName = "Central Tax Paid";
                ds.Tables[1].Columns["StateUTTaxPaid"].ColumnName = "State/UT Tax Paid";
                ds.Tables[1].Columns["CessPaid"].ColumnName = "Cess Paid";
                ds.Tables[1].Columns["EligibilityForITC"].ColumnName = "Eligibility For ITC";
                ds.Tables[1].Columns["AvailedITCIntegratedTax"].ColumnName = "Availed ITC Integrated Tax";
                ds.Tables[1].Columns["AvailedITCCentralTax"].ColumnName = "Availed ITC Central Tax";
                ds.Tables[1].Columns["AvailedITCStateUTTax"].ColumnName = "Availed ITC State/UT Tax";
                ds.Tables[1].Columns["AvailedITCCess"].ColumnName = "Availed ITC Cess"; 



                ds.Tables[2].TableName = "imps";
                ds.Tables[2].Columns["InvoiceNumberofRegRecipient"].ColumnName = "Invoice Number of Reg Recipient";
                ds.Tables[2].Columns["InvoiceDate"].ColumnName = "Invoice Date";
                ds.Tables[2].Columns["InvoiceValue"].ColumnName = "Invoice Value";
                ds.Tables[2].Columns["PlaceOfSupply"].ColumnName = "Place Of Supply";
                ds.Tables[2].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[2].Columns["TaxableValue"].ColumnName = "Taxable Value";
                ds.Tables[2].Columns["IntegratedTaxPaid"].ColumnName = "Integrated Tax Paid";
                ds.Tables[2].Columns["CessPaid"].ColumnName = "Cess Paid";
                ds.Tables[2].Columns["EligibilityForITC"].ColumnName = "Eligibility For ITC";
                ds.Tables[2].Columns["AvailedITCIntegratedTax"].ColumnName = "Availed ITC Integrated Tax";
                ds.Tables[2].Columns["AvailedITCCess"].ColumnName = "Availed ITC Cess";

                ds.Tables[3].TableName = "impg";
                ds.Tables[3].Columns["PortCode"].ColumnName = "Port Code";
                ds.Tables[3].Columns["BillOfEntryNumber"].ColumnName = "Bill Of Entry Number";
                ds.Tables[3].Columns["BillOfEntryDate"].ColumnName = "Bill Of Entry Date";
                ds.Tables[3].Columns["BillOfEntryValue"].ColumnName = "Bill Of Entry Value";
                ds.Tables[3].Columns["Documenttype"].ColumnName = "Document type";
                ds.Tables[3].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[3].Columns["TaxableValue"].ColumnName = "Taxable Value";
                ds.Tables[3].Columns["IntegratedTaxPaid"].ColumnName = "Integrated Tax Paid";
                ds.Tables[3].Columns["CessPaid"].ColumnName = "Cess Paid";
                ds.Tables[3].Columns["EligibilityForITC"].ColumnName = "Eligibility For ITC";
                ds.Tables[3].Columns["AvailedITCIntegratedTax"].ColumnName = "Availed ITC Integrated Tax";
                ds.Tables[3].Columns["AvailedITCCess"].ColumnName = "Availed ITC Cess";

                ds.Tables[4].TableName = "cdnr";
                ds.Tables[4].Columns["GSTINofSupplier"].ColumnName = "GSTIN of Supplier";
                ds.Tables[4].Columns["NoteRefundVoucherNumber"].ColumnName = "Note/Refund Voucher Number";
                ds.Tables[4].Columns["NoteRefundVoucherdate"].ColumnName = "Note/Refund Voucher date";
                ds.Tables[4].Columns["InvoiceAdvancePaymentVoucherNumber"].ColumnName = "Invoice/Advance Payment Voucher Number";
                ds.Tables[4].Columns["InvoiceAdvancePaymentVoucherdate"].ColumnName = "Invoice/Advance Payment Voucher date";
                ds.Tables[4].Columns["PreGST"].ColumnName = "Pre GST";
                ds.Tables[4].Columns["DocumentType"].ColumnName = "Document Type";
                ds.Tables[4].Columns["ReasonForIssuingdocument"].ColumnName = "Reason For Issuing document";
                ds.Tables[4].Columns["SupplyType"].ColumnName = "Supply Type";
                ds.Tables[4].Columns["NoteRefundVoucherValue"].ColumnName = "Note/Refund Voucher Value";
                ds.Tables[4].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[4].Columns["TaxableValue"].ColumnName = "Taxable Value";
                ds.Tables[4].Columns["IntegratedTaxPaid"].ColumnName = "Integrated Tax Paid";
                ds.Tables[4].Columns["CentralTaxPaid"].ColumnName = "Central Tax Paid";
                ds.Tables[4].Columns["StateUTTaxPaid"].ColumnName = "State/UT Tax Paid";
                ds.Tables[4].Columns["CessPaid"].ColumnName = "Cess Paid";
                ds.Tables[4].Columns["EligibilityForITC"].ColumnName = "Eligibility For ITC";
                ds.Tables[4].Columns["AvailedITCIntegratedTax"].ColumnName = "Availed ITC Integrated Tax";
                ds.Tables[4].Columns["AvailedITCCentralTax"].ColumnName = "Availed ITC Central Tax";
                ds.Tables[4].Columns["AvailedITCStateUTTax"].ColumnName = "Availed ITC State/UT Tax";
                ds.Tables[4].Columns["AvailedITCCess"].ColumnName = "Availed ITC Cess";

                ds.Tables[5].TableName = "cndur";
                ds.Tables[5].Columns["NoteRefundVoucherNumber"].ColumnName = "Note/Voucher Number";
                ds.Tables[5].Columns["NoteRefundVoucherdate"].ColumnName = "Note/Voucher date";
                ds.Tables[5].Columns["InvoiceAdvancePaymentVoucherNumber"].ColumnName = "Invoice/Advance Payment Voucher number";
                ds.Tables[5].Columns["InvoiceAdvancePaymentVoucherdate"].ColumnName = "Invoice/Advance Payment Voucher date";
                ds.Tables[5].Columns["PreGST"].ColumnName = "Pre GST";
                ds.Tables[5].Columns["DocumentType"].ColumnName = "Document Type";
                ds.Tables[5].Columns["ReasonForIssuingdocument"].ColumnName = "Reason For Issuing document";
                ds.Tables[5].Columns["SupplyType"].ColumnName = "Supply Type";
                ds.Tables[5].Columns["InvoiceType"].ColumnName = "Invoice Type";
                ds.Tables[5].Columns["NoteRefundVoucherValue"].ColumnName = "Note/Voucher Value";
                ds.Tables[5].Columns["Rate"].ColumnName = "Rate";
                ds.Tables[5].Columns["TaxableValue"].ColumnName = "Taxable Value";
                ds.Tables[5].Columns["IntegratedTaxPaid"].ColumnName = "Integrated Tax Paid";
                ds.Tables[5].Columns["CentralTaxPaid"].ColumnName = "Central Tax Paid";
                ds.Tables[5].Columns["StateUTTaxPaid"].ColumnName = "State/UT Tax Paid";
                ds.Tables[5].Columns["CessPaid"].ColumnName = "Cess Paid";
                ds.Tables[5].Columns["EligibilityForITC"].ColumnName = "Eligibility For ITC";
                ds.Tables[5].Columns["AvailedITCIntegratedTax"].ColumnName = "Availed ITC Integrated Tax";
                ds.Tables[5].Columns["AvailedITCCentralTax"].ColumnName = "Availed ITC Central Tax";
                ds.Tables[5].Columns["AvailedITCStateUTTax"].ColumnName = "Availed ITC State/UT Tax";
                ds.Tables[5].Columns["AvailedITCCess"].ColumnName = "Availed ITC Cess";

                ds.Tables[6].TableName = "at";
                ds.Tables[6].Columns["PlaceOfSupply"].ColumnName = "Place Of Supply";
                ds.Tables[6].Columns["SupplyType"].ColumnName = "Supply Type";
                ds.Tables[6].Columns["GrossAdvancePaid"].ColumnName = "Gross Advance Paid";
                ds.Tables[6].Columns["CessAmount"].ColumnName = "Cess Amount";
               

                ds.Tables[7].TableName = "atadj";
                ds.Tables[7].Columns["PlaceOfSupply"].ColumnName = "Place Of Supply";
                ds.Tables[7].Columns["SupplyType"].ColumnName = "Supply Type";
                ds.Tables[7].Columns["GrossAdvancePaidtobeAdjusted"].ColumnName = "Gross Advance Paid to be Adjusted";
                ds.Tables[7].Columns["CessAdjusted"].ColumnName = "Cess Adjusted";

          
                ds.Tables[8].TableName = "exemp";
                ds.Tables[8].Columns["Description"].ColumnName = "Description";
                ds.Tables[8].Columns["Compositiontaxableperson"].ColumnName = "Composition taxable person";
                ds.Tables[8].Columns["NilRatedSupplies"].ColumnName = "Nil Rated Supplies";
                ds.Tables[8].Columns["Exempted"].ColumnName = "Exempted (other than nil rated/non GST supply)";
                ds.Tables[8].Columns["NonGSTsupplies"].ColumnName = "Non-GST supplies";

                ds.Tables[9].TableName = "itcr";
                ds.Tables[9].Columns["DescriptionforreversalofITC"].ColumnName = "Description for reversal of ITC";
                ds.Tables[9].Columns["Tobeaddedorreducedfromoutputliability"].ColumnName = "To be added or reduced from output liability";
                ds.Tables[9].Columns["ITCIntegratedTaxAmount"].ColumnName = "ITC Integrated Tax Amount";
                ds.Tables[9].Columns["ITCCentralTaxAmount"].ColumnName = "ITC Central Tax Amount";
                ds.Tables[9].Columns["ITCStateUTTaxAmount"].ColumnName = "ITC State/UT Tax Amount";
                ds.Tables[9].Columns["ITCCessAmount"].ColumnName = "ITC Cess Amount";

                ds.Tables[10].TableName = "hsnsum";
                ds.Tables[10].Columns["HSN"].ColumnName = "HSN";
                ds.Tables[10].Columns["Description"].ColumnName = "Description";
                ds.Tables[10].Columns["UQC"].ColumnName = "UQC";
                ds.Tables[10].Columns["TotalQuantity"].ColumnName = "Total Quantity";
                ds.Tables[10].Columns["TotalValue"].ColumnName = "Total Value";
                ds.Tables[10].Columns["TaxableValue"].ColumnName = "Taxable Value";
                ds.Tables[10].Columns["IntegratedTaxAmount"].ColumnName = "Integrated Tax Amount";
                ds.Tables[10].Columns["CentralTaxAmount"].ColumnName = "Central Tax Amount";
                ds.Tables[10].Columns["StateUTTaxAmount"].ColumnName = "State/UT Tax Amount";
                ds.Tables[10].Columns["CessAmount"].ColumnName = "Cess Amount";
                

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

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataSet gstR2DS = gstR2Controller.getGSTR2Report(Convert.ToDateTime(dtpFrom.Value.ToShortDateString()), Convert.ToDateTime(dtpTo.Value.ToShortDateString()),Utility.FinancilaYearId, "GSTR2");
                dgvB2B.DataSource = gstR2DS.Tables[0];
                dgvB2CL.DataSource = gstR2DS.Tables[1];
                dgvB2Cs.DataSource = gstR2DS.Tables[2];
                 dgvcndr.DataSource = gstR2DS.Tables[3];
                 dgvcndnur.DataSource = gstR2DS.Tables[4];
                 dgvExp.DataSource = gstR2DS.Tables[5];
                 dgvAt.DataSource = gstR2DS.Tables[6];
                 dgvAtadj.DataSource = gstR2DS.Tables[7];
                 dgvExemp.DataSource = gstR2DS.Tables[8];
                 dgvSummaryForHSN.DataSource = gstR2DS.Tables[9];
                 dgvHsn.DataSource = gstR2DS.Tables[10];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void gttDate()
        {
            try
            {
                System.Data.DataSet dateCurrentDt = gstR2Controller.getGSTR2Report(Convert.ToDateTime(dtpFrom.Value.ToShortDateString()), Convert.ToDateTime(dtpTo.Value.ToShortDateString()),Utility.FinancilaYearId,"dateCurrent");
                dtpFrom.Value = Convert.ToDateTime(dateCurrentDt.Tables[0].Rows[0]["fromDate"]);
                dtpTo.Value = Convert.ToDateTime(dateCurrentDt.Tables[0].Rows[0]["toDate"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
