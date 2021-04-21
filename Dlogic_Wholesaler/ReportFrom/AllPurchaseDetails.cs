using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DataAccessLayer.controller;
using DataAccessLayer.models;
using MetroFramework.Forms;
using Dlogic_Wholesaler.ReportFrom;
using System.Configuration;
using System.Windows.Forms;
namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class AllPurchaseDetails : MetroForm
    {
        public AllPurchaseDetails()
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
                    lblHerader.Text = "Purchase Book";
                    metroLabel3.Text = "To Date:";
                    metroLabel1.Text = "From Date:";
                    btnExcelConvert.Text = "Exel Report";
                    rdbAll.Text = "All";
                    rbtnCash.Text = "Cash";
                    rbtnCredit.Text = "Credit";               
                    btnnew.Text = "Show";
                    dgvPurchaseItems.Columns[7].HeaderText = "Naration";
                    dgvPurchaseItems.Columns[8].HeaderText = "Batch No.";
                    dgvPurchaseItems.Columns[9].HeaderText = "MFG Date";
                    dgvPurchaseItems.Columns[10].HeaderText = "Expiry Date";
                    dgvPurchaseItems.Columns[11].HeaderText = "Quantity";
                    dgvPurchaseItems.Columns[12].HeaderText = "Unit By";
                    dgvPurchaseItems.Columns[13].HeaderText = "freeQuantity";
                    dgvPurchaseItems.Columns[14].HeaderText = "MRP";
                    dgvPurchaseItems.Columns[15].HeaderText = "Pur.Rate(With GST)";
                    dgvPurchaseItems.Columns[16].HeaderText = "Pur.Rate";
                    dgvPurchaseItems.Columns[17].HeaderText = "Discount";
                    dgvPurchaseItems.Columns[18].HeaderText = "Discount(%)";
                    dgvPurchaseItems.Columns[19].HeaderText = "Purchase Rate(With Discount)";
                    dgvPurchaseItems.Columns[20].HeaderText = "Amount";
                    dgvPurchaseItems.Columns[21].HeaderText = "Sale Rate";
                    dgvPurchaseItems.Columns[22].HeaderText = "GST(%)";
                    dgvPurchaseItems.Columns[23].HeaderText = "GST Amt";
                    dgvPurchaseItems.Columns[24].HeaderText = "CGST(%)";
                    dgvPurchaseItems.Columns[25].HeaderText = "CGST Amt";
                    dgvPurchaseItems.Columns[26].HeaderText = "SGST(%)";
                    dgvPurchaseItems.Columns[27].HeaderText = "SGST Amt";
                    dgvPurchaseItems.Columns[28].HeaderText = "Total Amount";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPurchaseBook.DataSource = null;
                string opration = "";
                if (rdbAll.Checked == true)
                {
                    opration = "All";
                }
                if (rbtnCash.Checked == true)
                {
                    opration = "Cash";
                }
                if (rbtnCredit.Checked == true)
                {
                    opration = "Credit";
                }
                DataTable lstSaleBill = saleReportController.PurchaseDayBook(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), opration, Utility.FinancilaYearId);
                if (lstSaleBill.Rows.Count > 0)
                {

                    AddAutoIncrementColumn(lstSaleBill);
                    //  DataTable dtSaleBook = SubTot(lstSaleBill);
                    DataRow dr = lstSaleBill.NewRow();
                    dr["Bill Amount"] = billAMt;
                    dr["0% Amt"] = taxable0;
                    dr["5% Taxable Amt"] = Taxable5;
                    dr["12% Taxable Amt"] = Taxable12;
                    dr["18% Taxable Amt"] = Taxable18;
                    dr["28% Taxable Amt"] = Taxable28;
                    dr["IGST 5%"] = IGSTAmt5;
                    dr["CGST 2.5%"] = CGSTAmt5;
                    dr["SGST 2.5%"] = SGSTAmt5;

                    dr["IGST 12%"] = IGSTAmt12;
                    dr["CGST 6%"] = CGSTAmt6;
                    dr["SGST 6%"] = SGSTAmt6;

                    dr["IGST 18%"] = IGSTAmt18;
                    dr["CGST 9%"] = CGSTAmt9;
                    dr["SGST 9%"] = SGSTAmt9;

                    dr["IGST 28%"] = IGSTAmt28;
                    dr["CGST 14%"] = CGSTAmt14;
                    dr["SGST 14%"] = SGSTAmt14;

                    dr["Total Taxable Amt"] = Math.Round(TotalTaxableAmt,2);
                    dr["Total Tax Amt"] =Math.Round( billAMt - TotalTaxableAmt);
                    dr["grossAmount"] = Math.Round(grossAmount);
                    lstSaleBill.Rows.Add(dr);
                    BindNewData(lstSaleBill);
                    dgvPurchaseItems.Rows.Clear();
                    dgvPurchaseItems.Visible = true;
                }
                else
                {
                    dgvPurchaseItems.Rows.Clear();
                    dgvPurchaseItems.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static double billAMt = 0;
        public static double taxable0 = 0;
        public static double Taxable5 = 0;
        public static double Taxable12 = 0;
        public static double Taxable18 = 0;
        public static double Taxable28 = 0;
        public static double IGSTAmt5 = 0;
        public static double CGSTAmt5 = 0;
        public static double SGSTAmt5 = 0;
        public static double IGSTAmt12 = 0;
        public static double CGSTAmt6 = 0;
        public static double SGSTAmt6 = 0;
        public static double IGSTAmt18 = 0;
        public static double CGSTAmt9 = 0;
        public static double SGSTAmt9 = 0;
        public static double IGSTAmt28 = 0;
        public static double CGSTAmt14 = 0;
        public static double SGSTAmt14 = 0;

     
        public static double TotalTaxableAmt = 0;
        public static double grossAmount = 0;
        public void AddAutoIncrementColumn(DataTable dt)
        {
            try
            {
                DataColumn column = new DataColumn("SerialNo");
                column.DataType = System.Type.GetType("System.String");
                dt.Columns.Add(column);
                long index = 0;
                billAMt = 0; taxable0 = 0;Taxable5 = 0; Taxable12 = 0; Taxable18 = 0;Taxable28 = 0;IGSTAmt5 = 0;CGSTAmt5 = 0;SGSTAmt5 = 0;IGSTAmt12 = 0;CGSTAmt6 = 0; SGSTAmt6 = 0;
                TotalTaxableAmt = 0; grossAmount = 0;
                IGSTAmt18 = 0; CGSTAmt9 = 0;SGSTAmt9 = 0;IGSTAmt28 = 0;CGSTAmt14 = 0;   SGSTAmt14 = 0;
                foreach (DataRow row in dt.Rows)
                {
                    ++index;
                    row.SetField(column, index.ToString());

                    if (row["Bill Amount"] != DBNull.Value)
                        billAMt += Convert.ToDouble(row["Bill Amount"]);
                    if (row["0% Amt"] != DBNull.Value)
                        taxable0 += Convert.ToDouble(row["0% Amt"]);
                    if (row["5% Taxable Amt"] != DBNull.Value)
                        Taxable5 += Convert.ToDouble(row["5% Taxable Amt"]);
                    if (row["12% Taxable Amt"] != DBNull.Value)
                        Taxable12 += Convert.ToDouble(row["12% Taxable Amt"]);
                    if (row["18% Taxable Amt"] != DBNull.Value)
                        Taxable18 += Convert.ToDouble(row["18% Taxable Amt"]);
                    if (row["28% Taxable Amt"] != DBNull.Value)
                        Taxable28 += Convert.ToDouble(row["28% Taxable Amt"]);

                    if (row["IGST 5%"] != DBNull.Value)
                        IGSTAmt5 += Convert.ToDouble(row["IGST 5%"]);
                    if (row["CGST 2.5%"] != DBNull.Value)
                        CGSTAmt5 += Convert.ToDouble(row["CGST 2.5%"]);
                    if (row["SGST 2.5%"] != DBNull.Value)
                        SGSTAmt5 += Convert.ToDouble(row["SGST 2.5%"]);

                    if (row["IGST 12%"] != DBNull.Value)
                        IGSTAmt12 += Convert.ToDouble(row["IGST 12%"]);
                    if (row["CGST 6%"] != DBNull.Value)
                        CGSTAmt6 += Convert.ToDouble(row["CGST 6%"]);
                    if (row["SGST 6%"] != DBNull.Value)
                        SGSTAmt6 += Convert.ToDouble(row["SGST 6%"]);

                    if (row["IGST 18%"] != DBNull.Value)
                        IGSTAmt18 += Convert.ToDouble(row["IGST 18%"]);
                    if (row["CGST 9%"] != DBNull.Value)
                        CGSTAmt9 += Convert.ToDouble(row["CGST 9%"]);
                    if (row["SGST 9%"] != DBNull.Value)
                        SGSTAmt9 += Convert.ToDouble(row["SGST 9%"]);
                    if (row["IGST 28%"] != DBNull.Value)
                        IGSTAmt28 += Convert.ToDouble(row["IGST 28%"]);
                    if (row["CGST 14%"] != DBNull.Value)
                        CGSTAmt14 += Convert.ToDouble(row["CGST 14%"]);
                    if (row["SGST 14%"] != DBNull.Value)
                        SGSTAmt14 += Convert.ToDouble(row["SGST 14%"]);

                    if (row["Total Taxable Amt"] != DBNull.Value)
                        TotalTaxableAmt += Convert.ToDouble(row["Total Taxable Amt"]);
                    if (row["grossAmount"] != DBNull.Value)
                        grossAmount += Convert.ToDouble(row["grossAmount"]);
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public DataTable SubTot(DataTable lstSaleBill)
        {
            Double totaltaxAmount = 0.0, totaldiscount = 0.0, toGSTAmt0 = 0.0, totalCGSTAmt2_5 = 0.0, totalSGSTAmt2_5 = 0.0,
                    totalCGSTAmt6 = 0.0, totalSGSTAmt6 = 0.0, totalCGSTAmt9 = 0.0, totalSGSTAmt9 = 0.0, totalCGSTAmt14 = 0.0,
                    totalSGSTAmt14 = 0.0, totalAmt = 0.0;
            for (int i = 0; i < lstSaleBill.Rows.Count; i++)
            {
                totaltaxAmount += Convert.ToDouble(lstSaleBill.Rows[i]["TaxableAmount"].ToString());
                totaldiscount += Convert.ToDouble(lstSaleBill.Rows[i]["discount"].ToString());
                toGSTAmt0 += Convert.ToDouble(lstSaleBill.Rows[i]["IGSTAmt0"].ToString());
                totalCGSTAmt2_5 += Convert.ToDouble(lstSaleBill.Rows[i]["CGSTAmt2_5"].ToString());
                totalSGSTAmt2_5 += Convert.ToDouble(lstSaleBill.Rows[i]["SGSTAmt2_5"].ToString());
                totalCGSTAmt6 += Convert.ToDouble(lstSaleBill.Rows[i]["CGSTAmt6"].ToString());
                totalSGSTAmt6 += Convert.ToDouble(lstSaleBill.Rows[i]["SGSTAmt6"].ToString());
                totalCGSTAmt9 += Convert.ToDouble(lstSaleBill.Rows[i]["CGSTAmt9"].ToString());
                totalSGSTAmt9 += Convert.ToDouble(lstSaleBill.Rows[i]["SGSTAmt9"].ToString());
                totalCGSTAmt14 += Convert.ToDouble(lstSaleBill.Rows[i]["CGSTAmt14"].ToString());
                totalSGSTAmt14 += Convert.ToDouble(lstSaleBill.Rows[i]["SGSTAmt14"].ToString());
                totalAmt += Convert.ToDouble(lstSaleBill.Rows[i]["TotalAmt"].ToString());
            }
            DataRow dr = lstSaleBill.NewRow();
            dr["SerialNo"] = " ";
            dr["dealerFirmName"] = "एकूण रक्कम";
            dr["TaxableAmount"] = Math.Round(totaltaxAmount, 2);
            dr["discount"] = Math.Round(totaldiscount, 2);
            dr["IGSTAmt0"] = Math.Round(toGSTAmt0, 2);
            dr["CGSTAmt2_5"] = Math.Round(totalCGSTAmt2_5, 2);
            dr["SGSTAmt2_5"] = Math.Round(totalSGSTAmt2_5, 2);
            dr["CGSTAmt6"] = Math.Round(totalCGSTAmt6, 2);
            dr["SGSTAmt6"] = Math.Round(totalSGSTAmt6, 2);
            dr["CGSTAmt9"] = Math.Round(totalCGSTAmt9, 2);
            dr["SGSTAmt9"] = Math.Round(totalSGSTAmt9, 2);
            dr["CGSTAmt14"] = Math.Round(totalCGSTAmt14, 2);
            dr["SGSTAmt14"] = Math.Round(totalSGSTAmt14, 2);
            dr["totalAmt"] = Math.Round(totalAmt, 2);
            dr["purchaseId"] = 0;
            lstSaleBill.Rows.Add(dr);
            return lstSaleBill;

        }
        public void BindData(DataTable dtTable)
        {
            try
            {
                dgvPurchaseBook.DataSource = null;
                dgvPurchaseBook.AutoGenerateColumns = false;
                dgvPurchaseBook.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvPurchaseBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvPurchaseBook.Font = new Font("Arial Unicode MS", 12);
                dgvPurchaseBook.EnableHeadersVisualStyles = false;
                dgvPurchaseBook.ColumnCount = 22;
                dgvPurchaseBook.Columns[0].Name = "SerialNo";
                dgvPurchaseBook.Columns[0].HeaderText = "अ.क्र.";
                dgvPurchaseBook.Columns[0].DataPropertyName = "SerialNo";
                dgvPurchaseBook.Columns[0].Width = 50;

                dgvPurchaseBook.Columns[1].Name = "purchaseInvoiceId";
                dgvPurchaseBook.Columns[1].HeaderText = "बिल नं";
                dgvPurchaseBook.Columns[1].DataPropertyName = "purchaseInvoiceId";
                dgvPurchaseBook.Columns[1].Width = 50;

                dgvPurchaseBook.Columns[2].Name = "placeofsupplier";
                dgvPurchaseBook.Columns[2].HeaderText = "खरेदी राज्य";
                dgvPurchaseBook.Columns[2].DataPropertyName = "placeofsupplier";
                dgvPurchaseBook.Columns[2].Width = 50;


                dgvPurchaseBook.Columns[3].Name = "dealerFirmName";
                dgvPurchaseBook.Columns[3].HeaderText = "व्यापारी नाव";
                dgvPurchaseBook.Columns[3].DataPropertyName = "dealerFirmName";
                dgvPurchaseBook.Columns[3].Width = 200;

                dgvPurchaseBook.Columns[4].Name = "purchaseDate";
                dgvPurchaseBook.Columns[4].HeaderText = "दिनांक";
                dgvPurchaseBook.Columns[4].DataPropertyName = "purchaseDate";
                dgvPurchaseBook.Columns[4].Width = 100;

                dgvPurchaseBook.Columns[5].Name = "TaxableAmount";
                dgvPurchaseBook.Columns[5].HeaderText = "कर रक्कम";
                dgvPurchaseBook.Columns[5].DataPropertyName = "TaxableAmount";
                dgvPurchaseBook.Columns[5].Width = 150;

                dgvPurchaseBook.Columns[6].Name = "discount";
                dgvPurchaseBook.Columns[6].HeaderText = "सवलत";
                dgvPurchaseBook.Columns[6].DataPropertyName = "discount";
                dgvPurchaseBook.Columns[6].Width = 60;
                dgvPurchaseBook.Columns[6].Visible = false;
                dgvPurchaseBook.Columns[7].Name = "IGSTAmt0";
                dgvPurchaseBook.Columns[7].HeaderText = "GST(0%) रक्कम";
                dgvPurchaseBook.Columns[7].DataPropertyName = "IGSTAmt0";
                dgvPurchaseBook.Columns[7].Width = 100;
                dgvPurchaseBook.Columns[7].Visible = false;

                dgvPurchaseBook.Columns[8].Name = "CGSTAmt2_5";
                dgvPurchaseBook.Columns[8].HeaderText = "CGST(2.5%) रक्कम";
                dgvPurchaseBook.Columns[8].DataPropertyName = "CGSTAmt2_5";
                dgvPurchaseBook.Columns[8].Width = 100;

                dgvPurchaseBook.Columns[9].Name = "CGSTAmt2_5";
                dgvPurchaseBook.Columns[9].HeaderText = "SGST(2.5%) रक्कम";
                dgvPurchaseBook.Columns[9].DataPropertyName = "CGSTAmt2_5";
                dgvPurchaseBook.Columns[9].Width = 100;

                dgvPurchaseBook.Columns[10].Name = "CGSTAmt6";
                dgvPurchaseBook.Columns[10].HeaderText = "CGST(6%) रक्कम";
                dgvPurchaseBook.Columns[10].DataPropertyName = "CGSTAmt6";
                dgvPurchaseBook.Columns[10].Width = 100;

                dgvPurchaseBook.Columns[11].Name = "SGSTAmt6";
                dgvPurchaseBook.Columns[11].HeaderText = "SGST(6%) रक्कम";
                dgvPurchaseBook.Columns[11].DataPropertyName = "SGSTAmt6";
                dgvPurchaseBook.Columns[11].Width = 100;

                dgvPurchaseBook.Columns[12].Name = "CGSTAmt9";
                dgvPurchaseBook.Columns[12].HeaderText = "CGST(9%) रक्कम";
                dgvPurchaseBook.Columns[12].DataPropertyName = "CGSTAmt9";
                dgvPurchaseBook.Columns[12].Width = 100;

                dgvPurchaseBook.Columns[13].Name = "SGSTAmt9";
                dgvPurchaseBook.Columns[13].HeaderText = "SGST(9%) रक्कम";
                dgvPurchaseBook.Columns[13].DataPropertyName = "SGSTAmt9";
                dgvPurchaseBook.Columns[13].Width = 100;

                dgvPurchaseBook.Columns[14].Name = "CGSTAmt14";
                dgvPurchaseBook.Columns[14].HeaderText = "CGST(14%) रक्कम";
                dgvPurchaseBook.Columns[14].DataPropertyName = "CGSTAmt14";
                dgvPurchaseBook.Columns[14].Width = 100;
                dgvPurchaseBook.Columns[14].Visible = false;

                dgvPurchaseBook.Columns[15].Name = "SGSTAmt14";
                dgvPurchaseBook.Columns[15].HeaderText = "SGST(14%) रक्कम";
                dgvPurchaseBook.Columns[15].DataPropertyName = "SGSTAmt14";
                dgvPurchaseBook.Columns[15].Width = 100;
                dgvPurchaseBook.Columns[15].Visible = false;

                dgvPurchaseBook.Columns[16].Name = "grossAmount";
                dgvPurchaseBook.Columns[16].HeaderText = "एकूण रक्कम";
                dgvPurchaseBook.Columns[16].DataPropertyName = "grossAmount";
                dgvPurchaseBook.Columns[16].Width = 150;

                dgvPurchaseBook.Columns[17].Name = "discountAmount";
                dgvPurchaseBook.Columns[17].HeaderText = "सवलत रक्कम";
                dgvPurchaseBook.Columns[17].DataPropertyName = "discountAmount";
                dgvPurchaseBook.Columns[17].Width = 150;

                dgvPurchaseBook.Columns[18].Name = "TotalAmt";
                dgvPurchaseBook.Columns[18].HeaderText = "बिल रक्कम";
                dgvPurchaseBook.Columns[18].DataPropertyName = "TotalAmt";
                dgvPurchaseBook.Columns[18].Width = 150;
                dgvPurchaseBook.Columns[19].Name = "roundOff";
                dgvPurchaseBook.Columns[19].HeaderText = "Round Off";
                dgvPurchaseBook.Columns[19].DataPropertyName = "roundOff";
                dgvPurchaseBook.Columns[19].Width = 150;

                dgvPurchaseBook.Columns[20].Name = "DilivaryCharges";
                dgvPurchaseBook.Columns[20].HeaderText = "Dilivary Charges";
                dgvPurchaseBook.Columns[20].DataPropertyName = "DilivaryCharges";
                dgvPurchaseBook.Columns[20].Width = 150;
                dgvPurchaseBook.Columns[21].Name = "purchaseId";
                dgvPurchaseBook.Columns[21].HeaderText = "purchaseId";
                dgvPurchaseBook.Columns[21].DataPropertyName = "purchaseId";
                dgvPurchaseBook.Columns[21].Width = 150;
                dgvPurchaseBook.Columns[21].Visible = false;

                dgvPurchaseBook.DataSource = dtTable;
                if (dgvPurchaseBook.Rows.Count > 0)
                {
                    dgvPurchaseBook.Rows[dgvPurchaseBook.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                    dgvPurchaseBook.Rows[dgvPurchaseBook.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                }
                dgvPurchaseBook.ClearSelection();
                foreach (DataGridViewColumn column in dgvPurchaseBook.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }

        }
        public void BindNewData(DataTable dtTable)
        {
            try
            {
                dgvPurchaseBook.DataSource = null;
                dgvPurchaseBook.AutoGenerateColumns = false;
                dgvPurchaseBook.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvPurchaseBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvPurchaseBook.Font = new Font("Arial Unicode MS", 12);
                dgvPurchaseBook.EnableHeadersVisualStyles = false;
                dgvPurchaseBook.ColumnCount = 29;
                dgvPurchaseBook.Columns[0].Name = "SerialNo";
                dgvPurchaseBook.Columns[0].HeaderText = "अ. क्र.";
                dgvPurchaseBook.Columns[0].DataPropertyName = "SerialNo";
                dgvPurchaseBook.Columns[0].Width = 50;

                dgvPurchaseBook.Columns[1].Name = "InvoiceNo";
                dgvPurchaseBook.Columns[1].HeaderText = "Invoice No";
                dgvPurchaseBook.Columns[1].DataPropertyName = "Invoice No";
                dgvPurchaseBook.Columns[1].Width = 100;

                dgvPurchaseBook.Columns[2].Name = "PurchaseDate";
                dgvPurchaseBook.Columns[2].HeaderText = "Purchase Date";
                dgvPurchaseBook.Columns[2].DataPropertyName = "Purchase Date";
                dgvPurchaseBook.Columns[2].Width = 100;

                dgvPurchaseBook.Columns[3].Name = "customerName";
                dgvPurchaseBook.Columns[3].HeaderText = "Party";
                dgvPurchaseBook.Columns[3].DataPropertyName = "Party";
                dgvPurchaseBook.Columns[3].Width = 200;

                dgvPurchaseBook.Columns[4].Name = "placeofsupplier";
                dgvPurchaseBook.Columns[4].HeaderText = "Place of supply";
                dgvPurchaseBook.Columns[4].DataPropertyName = "Place of supply";
                dgvPurchaseBook.Columns[4].Width = 200;

                dgvPurchaseBook.Columns[5].Name = "GST No";
                dgvPurchaseBook.Columns[5].HeaderText = "GST No";
                dgvPurchaseBook.Columns[5].DataPropertyName = "GST No";
                dgvPurchaseBook.Columns[5].Width = 100;

                dgvPurchaseBook.Columns[6].Name = "Bill Amt";
                dgvPurchaseBook.Columns[6].HeaderText = "Bill Amount";
                dgvPurchaseBook.Columns[6].DataPropertyName = "Bill Amount";
                dgvPurchaseBook.Columns[6].Width = 150;




                dgvPurchaseBook.Columns[7].Name = "discount";
                dgvPurchaseBook.Columns[7].HeaderText = "discount";
                dgvPurchaseBook.Columns[7].DataPropertyName = "discount";
                dgvPurchaseBook.Columns[7].Width = 60;
                // dgvPurchaseBook.Columns[7].Visible = false;

                dgvPurchaseBook.Columns[8].Name = "0% Amt";
                dgvPurchaseBook.Columns[8].HeaderText = "0% Amt";
                dgvPurchaseBook.Columns[8].DataPropertyName = "0% Amt";

                dgvPurchaseBook.Columns[9].Name = "5% Taxable Amt";
                dgvPurchaseBook.Columns[9].HeaderText = "5% Taxable Amt";
                dgvPurchaseBook.Columns[9].DataPropertyName = "5% Taxable Amt";
                dgvPurchaseBook.Columns[9].Width = 100;
                //dgvPurchaseBook.Columns[8].Visible = false;

                dgvPurchaseBook.Columns[10].Name = "IGST 5%";
                dgvPurchaseBook.Columns[10].HeaderText = "IGST 5%";
                dgvPurchaseBook.Columns[10].DataPropertyName = "IGST 5%";
                dgvPurchaseBook.Columns[10].Width = 100;

                dgvPurchaseBook.Columns[11].Name = "CGST 2.5%";
                dgvPurchaseBook.Columns[11].HeaderText = "CGST 2.5%";
                dgvPurchaseBook.Columns[11].DataPropertyName = "CGST 2.5%";
                dgvPurchaseBook.Columns[11].Width = 100;

                dgvPurchaseBook.Columns[12].Name = "SGST 2.5%";
                dgvPurchaseBook.Columns[12].HeaderText = "SGST 2.5%";
                dgvPurchaseBook.Columns[12].DataPropertyName = "SGST 2.5%";
                dgvPurchaseBook.Columns[12].Width = 100;

                dgvPurchaseBook.Columns[13].Name = "12% Taxable Amt";
                dgvPurchaseBook.Columns[13].HeaderText = "12% Taxable Amt";
                dgvPurchaseBook.Columns[13].DataPropertyName = "12% Taxable Amt";
                dgvPurchaseBook.Columns[13].Width = 100;

                dgvPurchaseBook.Columns[14].Name = "IGST 12%";
                dgvPurchaseBook.Columns[14].HeaderText = "IGST 12%";
                dgvPurchaseBook.Columns[14].DataPropertyName = "IGST 12%";
                dgvPurchaseBook.Columns[14].Width = 100;

                dgvPurchaseBook.Columns[15].Name = "CGST 6%";
                dgvPurchaseBook.Columns[15].HeaderText = "CGST 6%";
                dgvPurchaseBook.Columns[15].DataPropertyName = "CGST 6%";
                dgvPurchaseBook.Columns[15].Width = 100;

                dgvPurchaseBook.Columns[16].Name = "SGST 6%";
                dgvPurchaseBook.Columns[16].HeaderText = "SGST 6%";
                dgvPurchaseBook.Columns[16].DataPropertyName = "SGST 6%";
                dgvPurchaseBook.Columns[16].Width = 100;
                // dgvPurchaseBook.Columns[15].Visible = false;

                dgvPurchaseBook.Columns[17].Name = "18% Taxable Amt";
                dgvPurchaseBook.Columns[17].HeaderText = "18% Taxable Amt";
                dgvPurchaseBook.Columns[17].DataPropertyName = "18% Taxable Amt";
                dgvPurchaseBook.Columns[17].Width = 100;
                // dgvPurchaseBook.Columns[16].Visible = false;

                dgvPurchaseBook.Columns[18].Name = "IGST 18%";
                dgvPurchaseBook.Columns[18].HeaderText = "IGST 18%";
                dgvPurchaseBook.Columns[18].DataPropertyName = "IGST 18%";
                dgvPurchaseBook.Columns[18].Width = 150;

                dgvPurchaseBook.Columns[19].Name = "CGST 9%";
                dgvPurchaseBook.Columns[19].HeaderText = "CGST 9%";
                dgvPurchaseBook.Columns[19].DataPropertyName = "CGST 9%";
                dgvPurchaseBook.Columns[19].Width = 150;

                dgvPurchaseBook.Columns[20].Name = "SGST 9%";
                dgvPurchaseBook.Columns[20].HeaderText = "SGST 9%";
                dgvPurchaseBook.Columns[20].DataPropertyName = "SGST 9%";

                dgvPurchaseBook.Columns[21].Name = "28% Taxable Amt";
                dgvPurchaseBook.Columns[21].HeaderText = "28% Taxable Amt";
                dgvPurchaseBook.Columns[21].DataPropertyName = "28% Taxable Amt";

                dgvPurchaseBook.Columns[22].Name = "IGST 28%";
                dgvPurchaseBook.Columns[22].HeaderText = "IGST 28%";
                dgvPurchaseBook.Columns[22].DataPropertyName = "IGST 28%";

                dgvPurchaseBook.Columns[23].Name = "CGST 14%";
                dgvPurchaseBook.Columns[23].HeaderText = "CGST 14%";
                dgvPurchaseBook.Columns[23].DataPropertyName = "CGST 14%";

                dgvPurchaseBook.Columns[24].Name = "SGST 14%";
                dgvPurchaseBook.Columns[24].HeaderText = "SGST 14%";
                dgvPurchaseBook.Columns[24].DataPropertyName = "SGST 14%";

                dgvPurchaseBook.Columns[25].Name = "Total Taxable Amt";
                dgvPurchaseBook.Columns[25].HeaderText = "Total Taxable Amt";
                dgvPurchaseBook.Columns[25].DataPropertyName = "Total Taxable Amt";

                dgvPurchaseBook.Columns[26].Name = "Total Tax Amt";
                dgvPurchaseBook.Columns[26].HeaderText = "Total Tax Amt";
                dgvPurchaseBook.Columns[26].DataPropertyName = "Total Tax Amt";

                dgvPurchaseBook.Columns[27].Name = "Total Invoice Amt";
                dgvPurchaseBook.Columns[27].HeaderText = "Total Invoice Amt";
                dgvPurchaseBook.Columns[27].DataPropertyName = "Total Invoice Amt";

                dgvPurchaseBook.Columns[28].Name = "purchaseId";
                dgvPurchaseBook.Columns[28].HeaderText = "purchaseId";
                dgvPurchaseBook.Columns[28].DataPropertyName = "purchaseId";
                dgvPurchaseBook.Columns[28].Visible = false;
                dgvPurchaseBook.DataSource = dtTable;
                dgvPurchaseBook.Rows[dgvPurchaseBook.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                dgvPurchaseBook.Rows[dgvPurchaseBook.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                dgvPurchaseBook.ClearSelection();
                foreach (DataGridViewColumn column in dgvPurchaseBook.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }

        }
        private void btnExcelConvert_Click(object sender, EventArgs e)
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
                System.Data.DataTable dat = (System.Data.DataTable)(dgvPurchaseBook.DataSource);
                dat.TableName = "purchase Book";
                xlWorksheet.Name = dat.TableName;

                for (int j = 1; j < dat.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = dat.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < dat.Rows.Count; k++)
                {
                    for (int l = 0; l < dat.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        dat.Rows[k].ItemArray[l].ToString();
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

        private void AllPurchaseDetails_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPurchaseBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                long purchaseId = 0;
                if (e.RowIndex >= 0)
                {

                    purchaseId = Convert.ToInt64(dgvPurchaseBook.CurrentRow.Cells["purchaseId"].Value);
                }
                DataTable dtSaleChallen = purchaseDetailsController.getPurchaseIvoiceDetails(purchaseId, Utility.FinancilaYearId);
                dgvPurchaseItems.Rows.Clear();
                dgvPurchaseItems.Rows.Add();
                foreach (DataRow dr in dtSaleChallen.Rows)
                {
                    dgvPurchaseItems.CurrentRow.Cells["itemId"].Value = Convert.ToInt64(dr["itemId"]);
                    dgvPurchaseItems.CurrentRow.Cells["StockId"].Value = Convert.ToInt64(0);
                    dgvPurchaseItems.CurrentRow.Cells["categoryId"].Value = Convert.ToInt32(dr["categoryId"]);
                    dgvPurchaseItems.CurrentRow.Cells["companyId"].Value = Convert.ToInt32(dr["companyId"]);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseItemDetailId"].Value = Convert.ToInt32(dr["purchaseItemDetailId"]);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseChalanId"].Value = 0;
                    dgvPurchaseItems.CurrentRow.Cells["batchNo"].Value = Convert.ToString(dr["batchNo"]);
                    dgvPurchaseItems.CurrentRow.Cells["itemName"].Value = dr["itemName"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["rackNo"].Value = dr["rackNo"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["productCode"].Value = dr["productCode"].ToString();
                    //dgvPurchaseItems.CurrentRow.Cells["HSNCode"].Value = dr["HNSCode"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["MRP"].Value = dr["MRP"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value = dr["Quantity"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["unitBy"].Value = dr["unitBy"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["mfgDate"].Value = dr["MFD_Date"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["expireDate"].Value = dr["expireDate"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["discount"].Value = dr["discount"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["discountPer"].Value = dr["discountPer"].ToString();
                    dgvPurchaseItems.CurrentRow.Cells["IGST"].Value = Utility.ParseValue(dr["IGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["CGST"].Value = Utility.ParseValue(dr["CGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["SGST"].Value = Utility.ParseValue(dr["SGST"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value = Utility.ParseValue(dr["freeQuantity"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["salesCashRate"].Value = Utility.ParseValue(dr["salesCashRate"].ToString());
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRateWithGST"].Value = Math.Round(Utility.ParseValue(dr["purchaseRate"].ToString()) + ((Utility.ParseValue(dr["purchaseRate"].ToString()) * Utility.ParseValue(dr["IGST"].ToString())) / 100), 2);
                    dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value = Utility.ParseValue(dr["purchaseRate"].ToString());
                    double Discount = ((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discountPer"].Value.ToString()) / 100)) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString());
                    if (Discount > 0)
                    {
                        dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString()) - Discount;
                    }
                    else
                    {
                        dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());
                    } dgvPurchaseItems.CurrentRow.Cells["TaxableAmount"].Value = Math.Round((Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) - Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["freeQuantity"].Value.ToString())) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString()), 2);
                    //  dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value.ToString());

                    //double discount = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["discount"].Value.ToString()) * (Convert.ToDouble(dgvPurchaseItems.CurrentRow.Cells["purchaseRate"].Value)) / 100);
                    double purRate = (Convert.ToDouble(Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["Quantity"].Value.ToString()) * Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["ActualPurchaseRate"].Value.ToString())));
                    dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGST"].Value.ToString()) * purRate / 100);
                    dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGST"].Value.ToString()) * purRate / 100);
                    dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGST"].Value.ToString()) * purRate / 100);


                    if (dgvPurchaseBook.CurrentRow.Cells["placeofsupplier"].Value.ToString() != "27-Maharashtra")
                    {
                        dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = (Utility.ParseValue(dr["IGST"].ToString()) * purRate / 100);
                    }
                    else
                    {
                        dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value = (Utility.ParseValue(dr["CGST"].ToString()) * purRate / 100);
                        dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value = (Utility.ParseValue(dr["SGST"].ToString()) * purRate / 100);
                        dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value = Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["CGSTAmt"].Value.ToString()) + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["SGSTAmt"].Value.ToString());
                    }

                    dgvPurchaseItems.CurrentRow.Cells["totalAmount"].Value = Convert.ToDouble(purRate + Utility.ParseValue(dgvPurchaseItems.CurrentRow.Cells["IGSTAmt"].Value.ToString())).ToString();

                    //  dgvPurchaseItems.Focus();
                    //   dgvPurchaseItems.CurrentCell = dgvPurchaseItems.CurrentRow.Cells["Quantity"];
                    dgvPurchaseItems.BeginEdit(true);
                    int col = dgvPurchaseItems.CurrentCell.ColumnIndex;
                    int row = dgvPurchaseItems.CurrentCell.RowIndex;
                    col = 0;
                    row++;
                    if (dgvPurchaseItems.Rows.Count < dtSaleChallen.Rows.Count)
                    {
                        if (row == dgvPurchaseItems.RowCount)
                        {
                            dgvPurchaseItems.Rows.Add();
                            dgvPurchaseItems.CurrentCell = dgvPurchaseItems[col + 7, row];
                        }
                    }
                }
                dgvPurchaseItems.ClearSelection();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAll.Checked == true)
            {
                rbtnCash.Checked = false;
                rbtnCredit.Checked = false;
            }
            dgvPurchaseBook.DataSource = null;
        }

        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCash.Checked == true)
            {
                rbtnCredit.Checked = false;
                rdbAll.Checked = false;
            }
            dgvPurchaseBook.DataSource = null;
        }

        private void rbtnCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCash.Checked == true)
            {
                rbtnCredit.Checked = false;
                rdbAll.Checked = false;
            }
            dgvPurchaseBook.DataSource = null;
        }

        private void AllPurchaseDetails_Load(object sender, EventArgs e)
        {
            rdbAll.Checked = true;
            rbtnCash.Checked = false;
            rbtnCredit.Checked = false;

            dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
            dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpFromDate.Value = Utility.firstDate;
            dtpToDate.Value = Utility.lastDate;
            Lang();
        }
    }
}
