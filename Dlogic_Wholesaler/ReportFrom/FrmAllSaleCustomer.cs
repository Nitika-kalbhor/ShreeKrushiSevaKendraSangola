using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dlogic_Wholesaler.Forms;
using DataAccessLayer.controller;
using DataAccessLayer.models;
using MetroFramework.Forms;
using Dlogic_Wholesaler.ReportFrom;
using System.Configuration;
using Dlogic_Wholesaler.CrystalReport;
using CrystalDecisions.CrystalReports.Engine;
using System.Globalization;
namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class FrmAllSaleCustomer :  MetroForm
    {
     
        public FrmAllSaleCustomer()
        {
            InitializeComponent();
            cmbMainCategory.Text = "All";
        
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Sale Book";
                    metroLabel3.Text = "To Date:";
                    metroLabel1.Text = "From Date:";
                    btnExcelConvert.Text = "Exel Report";
                    chkholeSale.Text = "Wholesale";
                    rbtnCash.Text = "Cash";
                    rbtnCredit.Text = "Credit";
                    button1.Text = "Print Bill";                   
                    btnnew.Text = "Show";               
                 
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
                bool isWholeSale=false;
                if(chkholeSale.Checked==true)
                {
                    isWholeSale = true;
                }
                else
                {
                    isWholeSale = false;
                }
                dgvSaleBook.DataSource = null;
                string opration = "";
                if (cmbMainCategory.Text == "All" && rbtnCash.Checked == false && rbtnCredit.Checked == false)
                {
                    opration = "All";
                }
                if (cmbMainCategory.Text == "All" &&( rbtnCash.Checked == true || rbtnCredit.Checked == true))
                {
                    opration = "AllCashCredit";
                }
                if (cmbMainCategory.Text == "बियाणे" && rbtnCash.Checked == false && rbtnCredit.Checked == false)
                {
                    opration = "बियाणे";
                }
                if (cmbMainCategory.Text == "बियाणे" && (rbtnCash.Checked == true || rbtnCredit.Checked == true))
                {
                    opration = "SeedCashCredit";
                }
                if (cmbMainCategory.Text == "किटकनाशके" && rbtnCash.Checked == false && rbtnCredit.Checked == false)
                {
                    opration = "किटकनाशके";
                }
                if (cmbMainCategory.Text == "किटकनाशके" && (rbtnCash.Checked == true || rbtnCredit.Checked == true))
                {
                    opration = "PestCashCredit";
                }
                if (cmbMainCategory.Text == "खते" && rbtnCash.Checked == false && rbtnCredit.Checked == false)
                {
                    opration = "खते";
                }
                if (cmbMainCategory.Text == "खते" && (rbtnCash.Checked == true || rbtnCredit.Checked == true))
                {
                    opration = "FertCashCredit";
                }
                if (cmbMainCategory.Text == "PGR" && rbtnCash.Checked == false && rbtnCredit.Checked == false)
                {
                    opration = "PGR";
                }
                if (cmbMainCategory.Text == "PGR" && (rbtnCash.Checked == true || rbtnCredit.Checked == true))
                {
                    opration = "PGRCashCredit";
                }
                string cashCredit = "";
                if(rbtnCash.Checked == true)
                {
                    cashCredit = "Cash";
                }
                if (rbtnCredit.Checked == true)
                {
                    cashCredit = "Credit";
                }
                DataTable lstSaleBill = saleReportController.AllSaleCustomerBill(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, opration, cashCredit, isWholeSale);
                if (lstSaleBill.Rows.Count > 0)
                {
                    AddAutoIncrementColumn(lstSaleBill);
                   // DataTable dtSaleBook = SubTot(lstSaleBill);
                   // BindData(dtSaleBook);
                    BindNewData(lstSaleBill);
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
        public void AddAutoIncrementColumn(DataTable dt)
        {
            try { 
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
            try { 
            Double totaltaxAmount = 0.0, totaldiscount = 0.0, toGSTAmt0 = 0.0, totalCGSTAmt2_5 = 0.0, totalSGSTAmt2_5 = 0.0,
                    totalCGSTAmt6 = 0.0, totalSGSTAmt6 = 0.0, totalCGSTAmt9 = 0.0, totalSGSTAmt9 = 0.0, totalCGSTAmt14 = 0.0,
                    totalSGSTAmt14 = 0.0, totalAmt = 0.0,totalroundOff=0.0,totalAllDiscount=0.0;
            for(int i=0;i<lstSaleBill.Rows.Count;i++)
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
                totalroundOff += Convert.ToDouble(lstSaleBill.Rows[i]["roundOff"].ToString()); ;
                totalAllDiscount += Convert.ToDouble(lstSaleBill.Rows[i]["hamali"].ToString()); ;
            }
            DataRow dr = lstSaleBill.NewRow();
            dr["SerialNo"] = "";
            dr["customerName"] = "एकूण रक्कम";
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
            dr["roundOff"] = Math.Round(totalroundOff, 2);
            dr["hamali"] = Math.Round(totalAllDiscount, 2);
            lstSaleBill.Rows.Add(dr);
            return lstSaleBill;
            }
            catch (Exception ea)
            {
                throw ea;
            }
        }
        public void  BindData(DataTable dtTable)
        {
             try
            {
                dgvSaleBook.DataSource = null;
                dgvSaleBook.AutoGenerateColumns = false;
                dgvSaleBook.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvSaleBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSaleBook.Font = new Font("Arial Unicode MS", 12);
                dgvSaleBook.EnableHeadersVisualStyles = false;
                dgvSaleBook.ColumnCount = 20;
                if (Utility.Langn == "English")
                {
                    dgvSaleBook.Columns[0].HeaderText = "Serial No";
                    dgvSaleBook.Columns[1].HeaderText = "Bill No";
                    dgvSaleBook.Columns[2].HeaderText = "Place of Supplier";
                    dgvSaleBook.Columns[3].HeaderText = "Customer Name";
                    dgvSaleBook.Columns[4].HeaderText = "Date";
                    dgvSaleBook.Columns[5].HeaderText = "Taxable Amount";
                    dgvSaleBook.Columns[6].HeaderText = "Discount";
                    dgvSaleBook.Columns[7].HeaderText = "GST(0%) Amt";
                    dgvSaleBook.Columns[8].HeaderText = "CGST(2.5%) Amt";
                    dgvSaleBook.Columns[9].HeaderText = "SGST(2.5%) Amt";
                    dgvSaleBook.Columns[10].HeaderText = "CGST(6%) Amt";
                    dgvSaleBook.Columns[11].HeaderText = "SGST(6%) Amt";
                    dgvSaleBook.Columns[12].HeaderText = "CGST(9%) Amt";
                    dgvSaleBook.Columns[13].HeaderText = "SGST(9%) Amt";
                    dgvSaleBook.Columns[14].HeaderText = "CGST(14%) Amt";
                    dgvSaleBook.Columns[15].HeaderText = "SGST(14%) Amt";
                    dgvSaleBook.Columns[16].HeaderText = "Total Amount";
                    dgvSaleBook.Columns[17].HeaderText = "Round Off";
                    dgvSaleBook.Columns[18].HeaderText = "Hamali";
                }
                else
                {
                    dgvSaleBook.Columns[0].HeaderText = "अ. क्र.";
                    dgvSaleBook.Columns[1].HeaderText = "बिल नं";
                    dgvSaleBook.Columns[2].HeaderText = "खरेदी राज्य";
                    dgvSaleBook.Columns[3].HeaderText = "ग्राहकाचे नाव";
                    dgvSaleBook.Columns[4].HeaderText = "दिनांक";
                    dgvSaleBook.Columns[5].HeaderText = "कर रक्कम";
                    dgvSaleBook.Columns[6].HeaderText = "सवलत";
                    dgvSaleBook.Columns[7].HeaderText = "GST(0%) रक्कम";
                    dgvSaleBook.Columns[8].HeaderText = "CGST(2.5%) रक्कम";
                    dgvSaleBook.Columns[9].HeaderText = "SGST(2.5%) रक्कम";
                    dgvSaleBook.Columns[10].HeaderText = "CGST(6%) रक्कम";
                    dgvSaleBook.Columns[11].HeaderText = "SGST(6%) रक्कम";
                    dgvSaleBook.Columns[12].HeaderText = "CGST(9%) रक्कम";
                    dgvSaleBook.Columns[13].HeaderText = "SGST(9%) रक्कम";
                    dgvSaleBook.Columns[14].HeaderText = "CGST(14%) रक्कम";
                    dgvSaleBook.Columns[15].HeaderText = "SGST(14%) रक्कम";
                    dgvSaleBook.Columns[16].HeaderText = "एकूण रक्कम";
                    dgvSaleBook.Columns[17].HeaderText = "Round Off";
                    dgvSaleBook.Columns[18].HeaderText = "हमाली व इतर";

                }
                dgvSaleBook.Columns[0].Name = "SerialNo";                
                dgvSaleBook.Columns[0].DataPropertyName = "SerialNo";
                dgvSaleBook.Columns[0].Width = 50;

                dgvSaleBook.Columns[1].Name = "salesInvoiceId";             
                dgvSaleBook.Columns[1].DataPropertyName = "salesInvoiceId";
                dgvSaleBook.Columns[1].Width = 100;

                dgvSaleBook.Columns[2].Name = "placeofsupplier";              
                dgvSaleBook.Columns[2].DataPropertyName = "placeofsupplier";
                dgvSaleBook.Columns[2].Width = 200;

                dgvSaleBook.Columns[3].Name = "customerName";              
                dgvSaleBook.Columns[3].DataPropertyName = "customerName";
                dgvSaleBook.Columns[3].Width = 200;

                dgvSaleBook.Columns[4].Name = "salesDate";               
                dgvSaleBook.Columns[4].DataPropertyName = "salesDate";
                dgvSaleBook.Columns[4].Width = 100;

                dgvSaleBook.Columns[5].Name = "TaxableAmount";               
                dgvSaleBook.Columns[5].DataPropertyName = "TaxableAmount";
                dgvSaleBook.Columns[5].Width = 150;

                dgvSaleBook.Columns[6].Name = "discount";
                dgvSaleBook.Columns[6].DataPropertyName = "discount";
                dgvSaleBook.Columns[6].Width = 60;
                dgvSaleBook.Columns[6].Visible = false;

                dgvSaleBook.Columns[7].Name = "IGSTAmt0";               
                dgvSaleBook.Columns[7].DataPropertyName = "IGSTAmt0";
                dgvSaleBook.Columns[7].Width = 100;
                dgvSaleBook.Columns[7].Visible = false;

                dgvSaleBook.Columns[8].Name = "CGSTAmt2_5";              
                dgvSaleBook.Columns[8].DataPropertyName = "CGSTAmt2_5";
                dgvSaleBook.Columns[8].Width = 100;

                dgvSaleBook.Columns[9].Name = "SGSTAmt2_5";              
                dgvSaleBook.Columns[9].DataPropertyName = "SGSTAmt2_5";
                dgvSaleBook.Columns[9].Width = 100;

                dgvSaleBook.Columns[10].Name = "CGSTAmt6";             
                dgvSaleBook.Columns[10].DataPropertyName = "CGSTAmt6";
                dgvSaleBook.Columns[10].Width = 100;

                dgvSaleBook.Columns[11].Name = "SGSTAmt6";               
                dgvSaleBook.Columns[11].DataPropertyName = "SGSTAmt6";
                dgvSaleBook.Columns[11].Width = 100;

                dgvSaleBook.Columns[12].Name = "CGSTAmt9";             
                dgvSaleBook.Columns[12].DataPropertyName = "CGSTAmt9";
                dgvSaleBook.Columns[12].Width = 100;

                dgvSaleBook.Columns[13].Name = "SGSTAmt9";              
                dgvSaleBook.Columns[13].DataPropertyName = "SGSTAmt9";
                dgvSaleBook.Columns[13].Width = 100;

                dgvSaleBook.Columns[14].Name = "CGSTAmt14";               
                dgvSaleBook.Columns[14].DataPropertyName = "CGSTAmt14";
                dgvSaleBook.Columns[14].Width = 100;
                dgvSaleBook.Columns[14].Visible = false;

                dgvSaleBook.Columns[15].Name = "SGSTAmt14";               
                dgvSaleBook.Columns[15].DataPropertyName = "SGSTAmt14";
                dgvSaleBook.Columns[15].Width = 100;
                dgvSaleBook.Columns[15].Visible = false;

                dgvSaleBook.Columns[16].Name = "TotalAmt";              
                dgvSaleBook.Columns[16].DataPropertyName = "TotalAmt";
                dgvSaleBook.Columns[16].Width = 150;

                dgvSaleBook.Columns[17].Name = "roundOff";               
                dgvSaleBook.Columns[17].DataPropertyName = "roundOff";
                dgvSaleBook.Columns[17].Width = 150;

                dgvSaleBook.Columns[18].Name = "hamali";                
                dgvSaleBook.Columns[18].DataPropertyName = "hamali";

                dgvSaleBook.Columns[19].Name = "saleID";
                dgvSaleBook.Columns[19].HeaderText = "saleID";
                dgvSaleBook.Columns[19].DataPropertyName = "saleID";
            //    dgvSaleBook.Columns[19].Visible = false;
                dgvSaleBook.DataSource = dtTable;
                dgvSaleBook.Rows[dgvSaleBook.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                dgvSaleBook.Rows[dgvSaleBook.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                dgvSaleBook.ClearSelection();
                foreach (DataGridViewColumn column in dgvSaleBook.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }

        }

        public void BindNewData(DataTable dtTable)
        {
            try
            {
                dgvSaleBook.DataSource = null;
                dgvSaleBook.AutoGenerateColumns = false;
                dgvSaleBook.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvSaleBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSaleBook.Font = new Font("Arial Unicode MS", 12);
                dgvSaleBook.EnableHeadersVisualStyles = false;
                dgvSaleBook.ColumnCount = 29;
               
                dgvSaleBook.Columns[0].Name = "SerialNo";
                dgvSaleBook.Columns[0].HeaderText = "Serial No";
                dgvSaleBook.Columns[0].DataPropertyName = "SerialNo";
                dgvSaleBook.Columns[0].Width = 50;

                dgvSaleBook.Columns[1].Name = "salesInvoiceId";
                dgvSaleBook.Columns[1].HeaderText = "Bill No";
                dgvSaleBook.Columns[1].DataPropertyName = "Bill No";
                dgvSaleBook.Columns[1].Width = 100;

                dgvSaleBook.Columns[2].Name = "salesDate";
                dgvSaleBook.Columns[2].HeaderText = "Date";
                dgvSaleBook.Columns[2].DataPropertyName = "Date";
                dgvSaleBook.Columns[2].Width = 100;

                dgvSaleBook.Columns[3].Name = "customerName";
                dgvSaleBook.Columns[3].HeaderText = "Party";
                dgvSaleBook.Columns[3].DataPropertyName = "Party";
                dgvSaleBook.Columns[3].Width = 200;

                dgvSaleBook.Columns[4].Name = "placeofsupplier";
                dgvSaleBook.Columns[4].HeaderText = "Place of supply";
                dgvSaleBook.Columns[4].DataPropertyName = "Place of supply";
                dgvSaleBook.Columns[4].Width = 200;

                dgvSaleBook.Columns[5].Name = "GST No";
                dgvSaleBook.Columns[5].HeaderText = "GST No";
                dgvSaleBook.Columns[5].DataPropertyName = "GST No";
                dgvSaleBook.Columns[5].Width = 100;

                dgvSaleBook.Columns[6].Name = "Bill Amt";
                dgvSaleBook.Columns[6].HeaderText = "Bill Amt";
                dgvSaleBook.Columns[6].DataPropertyName = "Bill Amt";
                dgvSaleBook.Columns[6].Width = 150;             

               
                dgvSaleBook.Columns[7].Name = "discount";
                dgvSaleBook.Columns[7].HeaderText = "discount";
                dgvSaleBook.Columns[7].DataPropertyName = "discount";
                dgvSaleBook.Columns[7].Width = 60;
               // dgvSaleBook.Columns[7].Visible = false;

                dgvSaleBook.Columns[8].Name = "0% Amt";
                dgvSaleBook.Columns[8].HeaderText = "0% Amt";
                dgvSaleBook.Columns[8].DataPropertyName = "0% Amt";

                dgvSaleBook.Columns[9].Name = "5% Taxable Amt";
                dgvSaleBook.Columns[9].HeaderText = "5% Taxable Amt";
                dgvSaleBook.Columns[9].DataPropertyName = "5% Taxable Amt";
                dgvSaleBook.Columns[9].Width = 100;
                //dgvSaleBook.Columns[8].Visible = false;

                dgvSaleBook.Columns[10].Name = "IGST 5%";
                dgvSaleBook.Columns[10].HeaderText = "IGST 5%";
                dgvSaleBook.Columns[10].DataPropertyName = "IGST 5%";
                dgvSaleBook.Columns[10].Width = 100;

                dgvSaleBook.Columns[11].Name = "CGST 2.5%";
                dgvSaleBook.Columns[11].HeaderText = "CGST 2.5%";
                dgvSaleBook.Columns[11].DataPropertyName = "CGST 2.5%";
                dgvSaleBook.Columns[11].Width = 100;

                dgvSaleBook.Columns[12].Name = "SGST 2.5%";
                dgvSaleBook.Columns[12].HeaderText = "SGST 2.5%";
                dgvSaleBook.Columns[12].DataPropertyName = "SGST 2.5%";
                dgvSaleBook.Columns[12].Width = 100;

                dgvSaleBook.Columns[13].Name = "12% Taxable Amt";
                dgvSaleBook.Columns[13].HeaderText = "12% Taxable Amt";
                dgvSaleBook.Columns[13].DataPropertyName = "12% Taxable Amt";
                dgvSaleBook.Columns[13].Width = 100;

                dgvSaleBook.Columns[14].Name = "IGST 12%";
                dgvSaleBook.Columns[14].HeaderText = "IGST 12%";
                dgvSaleBook.Columns[14].DataPropertyName = "IGST 12%";
                dgvSaleBook.Columns[14].Width = 100;

                dgvSaleBook.Columns[15].Name = "CGST 6%";
                dgvSaleBook.Columns[15].HeaderText = "CGST 6%";
                dgvSaleBook.Columns[15].DataPropertyName = "CGST 6%";
                dgvSaleBook.Columns[15].Width = 100;

                dgvSaleBook.Columns[16].Name = "SGST 6%";
                dgvSaleBook.Columns[16].HeaderText = "SGST 6%";
                dgvSaleBook.Columns[16].DataPropertyName = "SGST 6%";
                dgvSaleBook.Columns[16].Width = 100;
               // dgvSaleBook.Columns[15].Visible = false;

                dgvSaleBook.Columns[17].Name = "18% Taxable Amt";
                dgvSaleBook.Columns[17].HeaderText = "18% Taxable Amt";
                dgvSaleBook.Columns[17].DataPropertyName = "18% Taxable Amt";
                dgvSaleBook.Columns[17].Width = 100;
               // dgvSaleBook.Columns[16].Visible = false;

                dgvSaleBook.Columns[18].Name = "IGST 18%";
                dgvSaleBook.Columns[18].HeaderText = "IGST 18%";
                dgvSaleBook.Columns[18].DataPropertyName = "IGST 18%";
                dgvSaleBook.Columns[18].Width = 150;

                dgvSaleBook.Columns[19].Name = "CGST 9%";
                dgvSaleBook.Columns[19].HeaderText = "CGST 9%";
                dgvSaleBook.Columns[19].DataPropertyName = "CGST 9%";
                dgvSaleBook.Columns[19].Width = 150;

                dgvSaleBook.Columns[20].Name = "SGST 9%";
                dgvSaleBook.Columns[20].HeaderText = "SGST 9%";
                dgvSaleBook.Columns[20].DataPropertyName = "SGST 9%";

                dgvSaleBook.Columns[21].Name = "28% Taxable Amt";
                dgvSaleBook.Columns[21].HeaderText = "28% Taxable Amt";
                dgvSaleBook.Columns[21].DataPropertyName = "28% Taxable Amt";

                dgvSaleBook.Columns[22].Name = "IGST 28%";
                dgvSaleBook.Columns[22].HeaderText = "IGST 28%";
                dgvSaleBook.Columns[22].DataPropertyName = "IGST 28%";

                dgvSaleBook.Columns[23].Name = "CGST 14%";
                dgvSaleBook.Columns[23].HeaderText = "CGST 14%";
                dgvSaleBook.Columns[23].DataPropertyName = "CGST 14%";

                dgvSaleBook.Columns[24].Name = "SGST 14%";
                dgvSaleBook.Columns[24].HeaderText = "SGST 14%";
                dgvSaleBook.Columns[24].DataPropertyName = "SGST 14%";

                dgvSaleBook.Columns[25].Name = "Total Taxable Amt";
                dgvSaleBook.Columns[25].HeaderText = "Total Taxable Amt";
                dgvSaleBook.Columns[25].DataPropertyName = "Total Taxable Amt";

                dgvSaleBook.Columns[26].Name = "Total Tax Amt";
                dgvSaleBook.Columns[26].HeaderText = "Total Tax Amt";
                dgvSaleBook.Columns[26].DataPropertyName = "Total Tax Amt";

                dgvSaleBook.Columns[27].Name = "Total Invoice Amt";
                dgvSaleBook.Columns[27].HeaderText = "Total Invoice Amt";
                dgvSaleBook.Columns[27].DataPropertyName = "Total Invoice Amt";

                dgvSaleBook.Columns[28].Name = "saleId";
                dgvSaleBook.Columns[28].HeaderText = "saleId";
                dgvSaleBook.Columns[28].DataPropertyName = "saleId";
                   dgvSaleBook.Columns[28].Visible = false;
                dgvSaleBook.DataSource = dtTable;
                dgvSaleBook.Rows[dgvSaleBook.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                dgvSaleBook.Rows[dgvSaleBook.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                dgvSaleBook.ClearSelection();
                foreach (DataGridViewColumn column in dgvSaleBook.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnExcelConvert_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);



                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                //Create Excel Sheets
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);
                System.Data.DataTable dat = (System.Data.DataTable)(dgvSaleBook.DataSource);
                dat.TableName = "Sale Book";
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

        private void dgvSaleBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            if(e.RowIndex>=0)
            {
                if (dgvSaleBook.CurrentRow.Cells["saleId"].Value != null)
                {
                    if (Utility.isSingleMultipalPrint == false)
                    {
                        billWithGSTSlot(Convert.ToString(dgvSaleBook.CurrentRow.Cells["saleId"].Value));
                    }
                    if (Utility.isSingleMultipalPrint == true)
                    {
                        billWithSeparate(Convert.ToString(dgvSaleBook.CurrentRow.Cells["saleId"].Value));
                    }
             
                }
            }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void billWithGSTSlot(string SaleID)
        {
            try
            {
                System.Globalization.RegionInfo objRegInfo = new RegionInfo("en-IN");
                string syb = objRegInfo.CurrencySymbol;
              
                DataTable dtSale = new DataTable();
                bool isWholeSale = false;
                if (chkholeSale.Checked == true)
                {
                    isWholeSale = true;
                    dtSale = ReportController.getWholeSaleInvoice(SaleID, Utility.FinancilaYearId);
                }
                else
                {
                    isWholeSale = false;
                    dtSale = ReportController.getSaleInvoice(SaleID, Utility.FinancilaYearId);
                }
                DataTable dtSaleByHSNCode = ReportController.getSaleInvoiceByHSNCode(SaleID, Utility.FinancilaYearId);
                string amountInWord = ""; //Utility.NumberToWordMarathi(Convert.ToInt64(dtSale.Rows[0]["netBillAmount"].ToString()));
                //dtSale.Columns.Add(new DataColumn("amountInWord", typeof(string)));
                //foreach (DataRow dr in dtSale.Rows)
                //{
                //    dr["amountInWord"] = amountInWord + " " + "रुपये /- फक्त.";
                //}
                //RptCustomerBill rpt = new RptCustomerBill();
                //RptSaleBill frm = new RptSaleBill();
                //rpt.Database.Tables[0].SetDataSource(dtSale);
                //rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                ////  rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                //string outstanding = Math.Round(accountDetailsController.GetDueAmount(Convert.ToInt64(dtSale.Rows[0]["customerId"]), "customer", Utility.FinancilaYearId), 2).ToString();
                //rpt.SetParameterValue(0, outstanding);
                //rpt.SetParameterValue(1, isWholeSale);
                //frm.crystalReportViewer1.ReportSource = rpt;
                //frm.Refresh();
                //frm.crystalReportViewer1.Refresh();
                //frm.ShowDialog();

                if (Utility.isEnglishBill)
                {
                    if (chkholeSale.Checked == true)
                    {
                        amountInWord = Utility.NumberToWord(Convert.ToInt64(dtSale.Rows[0]["netBillAmount"].ToString())) + " " + "Rs. /Only.";
                        dtSale.Columns.Add(new DataColumn("amountInWord", typeof(string)));

                        foreach (DataRow dr in dtSale.Rows)
                        {
                            dr["amountInWord"] = amountInWord;
                        }
                      //  RptCustomerBillEnglishWholsale rpt = new RptCustomerBillEnglishWholsale();
                        RptCustomerBillEnglishNew rpt = new RptCustomerBillEnglishNew();
                        RptSaleBill frm = new RptSaleBill();

                        //rpt.SetDataSource(dtSale);
                        rpt.Database.Tables[0].SetDataSource(dtSale);
                        rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);

                        //  rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                       // string outstanding = Math.Round(accountDetailsController.GetDueAmount(Convert.ToInt64(dtSale.Rows[0]["customerId"]), "customer", Utility.FinancilaYearId, Convert.ToDateTime(dtpChallenDate.Value)), 2).ToString();
                        string outstanding = Math.Round(accountDetailsController.GetDueAmount(Convert.ToInt64(dtSale.Rows[0]["customerId"]), "customer", Utility.FinancilaYearId, Convert.ToDateTime(dtSale.Rows[0]["salesDate"])), 2).ToString();
                        rpt.SetParameterValue(0, outstanding);
                        rpt.SetParameterValue(1, isWholeSale);
                        if (Utility.isPeview)
                        {
                            frm.crystalReportViewer1.ReportSource = rpt;

                            frm.Refresh();
                            frm.crystalReportViewer1.Refresh();
                            frm.ShowDialog();
                        }
                        else
                        {
                            rpt.PrintToPrinter(2, true, 0, 0);
                        }
                    }
                    else
                    {
                        amountInWord = Utility.NumberToWord(Convert.ToInt64(dtSale.Rows[0]["netBillAmount"].ToString())) + " " + "Rs. /Only.";
                        dtSale.Columns.Add(new DataColumn("amountInWord", typeof(string)));

                        foreach (DataRow dr in dtSale.Rows)
                        {
                            dr["amountInWord"] = amountInWord;
                        }
                      //  RptCustomerBillEnglish rpt = new RptCustomerBillEnglish();
                        RptCustomerBillEnglishNew rpt = new RptCustomerBillEnglishNew();
                        RptSaleBill frm = new RptSaleBill();

                        //rpt.SetDataSource(dtSale);
                        rpt.Database.Tables[0].SetDataSource(dtSale);
                        rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);

                        //  rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                        string outstanding = Math.Round(accountDetailsController.GetDueAmount(Convert.ToInt64(dtSale.Rows[0]["customerId"]), "customer", Utility.FinancilaYearId, Convert.ToDateTime(dtSale.Rows[0]["salesDate"])), 2).ToString();
                        rpt.SetParameterValue(0, outstanding);
                        rpt.SetParameterValue(1, isWholeSale);
                        if (Utility.isPeview)
                        {
                            frm.crystalReportViewer1.ReportSource = rpt;

                            frm.Refresh();
                            frm.crystalReportViewer1.Refresh();
                            frm.ShowDialog();
                        }
                        else
                        {
                            rpt.PrintToPrinter(2, true, 0, 0);
                        }
                    }
                }
                else
                {
                    amountInWord = Utility.NumberToWordMarathi(Convert.ToInt64(dtSale.Rows[0]["netBillAmount"].ToString())) + " " + "रुपये /- फक्त.";
                    dtSale.Columns.Add(new DataColumn("amountInWord", typeof(string)));

                    foreach (DataRow dr in dtSale.Rows)
                    {
                        dr["amountInWord"] = amountInWord;
                    }
                    RptCustomerBill rpt = new RptCustomerBill();
                    RptSaleBill frm = new RptSaleBill();

                    //rpt.SetDataSource(dtSale);
                    rpt.Database.Tables[0].SetDataSource(dtSale);
                    rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);

                    //  rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                    string outstanding = Math.Round(accountDetailsController.GetDueAmount(Convert.ToInt64(dtSale.Rows[0]["customerId"]), "customer", Utility.FinancilaYearId, Convert.ToDateTime(dtSale.Rows[0]["salesDate"])), 2).ToString();
                    rpt.SetParameterValue(0, outstanding);
                    rpt.SetParameterValue(1, isWholeSale);
                    if (Utility.isPeview)
                    {
                        frm.crystalReportViewer1.ReportSource = rpt;

                        frm.Refresh();
                        frm.crystalReportViewer1.Refresh();
                        frm.ShowDialog();
                    }
                    else
                    {
                        rpt.PrintToPrinter(2, true, 0, 0);
                    }
                }
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public void billWithSeparate(string SaleID)
        {
            try
            {
                System.Globalization.RegionInfo objRegInfo = new RegionInfo("en-IN");
                string syb = objRegInfo.CurrencySymbol;
                DataTable dtSale, dtSaleSeed, dtSalePestiside, dtSaleFertilizesr, dtPGROther, dtSaleByHSNCode;
                bool isWholeSale = false;
                if (chkholeSale.Checked == false)
                {
                    dtSale = ReportController.getcheckSaleInvoice(SaleID, Utility.FinancilaYearId);
                    dtSaleSeed = ReportController.getSaleSeedInvoice(SaleID, Utility.FinancilaYearId);
                    dtSalePestiside = ReportController.getSaleInsectisideInvoice(SaleID, Utility.FinancilaYearId);
                    dtSaleFertilizesr = ReportController.getSaleFerTilizerInvoice(SaleID, Utility.FinancilaYearId);
                    dtPGROther = ReportController.getPGROtherInvoice(SaleID, Utility.FinancilaYearId);
                    dtSaleByHSNCode = ReportController.getSaleInvoiceByHSNCode(SaleID, Utility.FinancilaYearId);
                    isWholeSale = false;
                }
                else
                {
                    dtSale = ReportController.getcheckWholeSaleInvoice(SaleID, Utility.FinancilaYearId);
                    dtSaleSeed = ReportController.getWholeSaleSeedInvoice(SaleID, Utility.FinancilaYearId);
                    dtSalePestiside = ReportController.getWholeSaleInsectisideInvoice(SaleID, Utility.FinancilaYearId);
                    dtSaleFertilizesr = ReportController.getWholeSaleFerTilizerInvoice(SaleID, Utility.FinancilaYearId);
                    dtPGROther = ReportController.getWholePGROtherInvoice(SaleID, Utility.FinancilaYearId);
                    dtSaleByHSNCode = ReportController.getWholeSaleInvoiceByHSNCode(SaleID, Utility.FinancilaYearId);
                    isWholeSale = true;
                }
                string outstanding = Math.Round(accountDetailsController.GetDueAmount(Convert.ToInt64(dtSale.Rows[0]["customerId"]), "customer", Utility.FinancilaYearId, Convert.ToDateTime(dtSale.Rows[0]["salesDate"])), 2).ToString();

                if (dtSaleSeed.Rows.Count > 0)
                {
                    long netBillAmt = Convert.ToInt64(Math.Round(Convert.ToDouble(dtSaleSeed.Compute("sum(TotalAmt)", string.Empty)), 0));
                    string amountInWord = Utility.NumberToWordMarathi(netBillAmt);
                    dtSaleSeed.Columns.Add(new DataColumn("amountInWord", typeof(string)));
                    foreach (DataRow dr in dtSaleSeed.Rows)
                    {
                        dr["amountInWord"] = amountInWord + " " + "रुपये /- फक्त.";
                    }
                    crptSeednvoice rpt = new crptSeednvoice();
                    RptSaleBill frm = new RptSaleBill();
                    rpt.Database.Tables[0].SetDataSource(dtSaleSeed);
                    rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                    //  rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                    rpt.SetParameterValue(0, outstanding);
                    rpt.SetParameterValue(1, isWholeSale);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.Refresh();
                    frm.crystalReportViewer1.Refresh();
                    frm.ShowDialog();
                }
                if (dtSalePestiside.Rows.Count > 0)
                {
                    long netBillAmt = Convert.ToInt64(Math.Round(Convert.ToDouble(dtSalePestiside.Compute("sum(TotalAmt)", string.Empty)), 0));
                    string amountInsectInWord = Utility.NumberToWordMarathi(netBillAmt);
                    dtSalePestiside.Columns.Add(new DataColumn("amountInWord", typeof(string)));
                    foreach (DataRow dr in dtSalePestiside.Rows)
                    {
                        dr["amountInWord"] = amountInsectInWord + " " + "रुपये /- फक्त.";
                    }
                    crptInsectisideInvoice rpt = new crptInsectisideInvoice();
                    RptSaleBill frm = new RptSaleBill();
                    rpt.Database.Tables[0].SetDataSource(dtSalePestiside);
                    rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                    //  rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                    rpt.SetParameterValue(0, outstanding);
                    rpt.SetParameterValue(1, isWholeSale);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.Refresh();
                    frm.crystalReportViewer1.Refresh();
                    frm.ShowDialog();
                }
                if (dtSaleFertilizesr.Rows.Count > 0)
                {
                    long netBillAmt = Convert.ToInt64(Math.Round(Convert.ToDouble(dtSaleFertilizesr.Compute("sum(TotalAmt)", string.Empty)) + Convert.ToDouble(dtSaleFertilizesr.Rows[0]["hamali"].ToString()), 0));
                    string amountFerInWord = Utility.NumberToWordMarathi(netBillAmt);
                    dtSaleFertilizesr.Columns.Add(new DataColumn("amountInWord", typeof(string)));
                    foreach (DataRow dr in dtSaleFertilizesr.Rows)
                    {
                        dr["amountInWord"] = amountFerInWord + " " + "रुपये /- फक्त.";
                    }
                    crptFertilizesInvoice rpt = new crptFertilizesInvoice();
                    RptSaleBill frm = new RptSaleBill();
                    rpt.Database.Tables[0].SetDataSource(dtSaleFertilizesr);
                    rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                    //  rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                    rpt.SetParameterValue(0, outstanding);
                    rpt.SetParameterValue(1, isWholeSale);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.Refresh();
                    frm.crystalReportViewer1.Refresh();
                    frm.ShowDialog();
                }
                if (dtPGROther.Rows.Count > 0)
                {
                    long netBillAmt = Convert.ToInt64(Math.Round(Convert.ToDouble(dtPGROther.Compute("sum(TotalAmt)", string.Empty)), 0));
                    string amountFerInWord = Utility.NumberToWordMarathi(netBillAmt);
                    dtPGROther.Columns.Add(new DataColumn("amountInWord", typeof(string)));
                    foreach (DataRow dr in dtPGROther.Rows)
                    {
                        dr["amountInWord"] = amountFerInWord + " " + "रुपये /- फक्त.";
                    }
                    crptPGROther rpt = new crptPGROther();
                    RptSaleBill frm = new RptSaleBill();
                    rpt.Database.Tables[0].SetDataSource(dtPGROther);
                    rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                    //  rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                    rpt.SetParameterValue(0, outstanding);
                    rpt.SetParameterValue(1, isWholeSale);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.Refresh();
                    frm.crystalReportViewer1.Refresh();
                    frm.ShowDialog();
                }

            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtSale;
            try
            {
                bool isWholeSale = false;
                if(chkholeSale.Checked==true)
                {
                    isWholeSale = true;
                }
                else
                {
                    isWholeSale = false;
                }
                string opration = "";
                if (cmbMainCategory.Text == "All" && rbtnCash.Checked == false && rbtnCredit.Checked == false)
                {
                    opration = "All";
                }
                if (cmbMainCategory.Text == "All" && (rbtnCash.Checked == true || rbtnCredit.Checked == true))
                {
                    opration = "AllCashCredit";
                }
                if (cmbMainCategory.Text == "बियाणे" && rbtnCash.Checked == false && rbtnCredit.Checked == false)
                {
                    opration = "बियाणे";
                }
                if (cmbMainCategory.Text == "बियाणे" && (rbtnCash.Checked == true || rbtnCredit.Checked == true))
                {
                    opration = "SeedCashCredit";
                }
                if (cmbMainCategory.Text == "किटकनाशके" && rbtnCash.Checked == false && rbtnCredit.Checked == false)
                {
                    opration = "किटकनाशके";
                }
                if (cmbMainCategory.Text == "किटकनाशके" && (rbtnCash.Checked == true || rbtnCredit.Checked == true))
                {
                    opration = "PestCashCredit";
                }
                if (cmbMainCategory.Text == "खते" && rbtnCash.Checked == false && rbtnCredit.Checked == false)
                {
                    opration = "खते";
                }
                if (cmbMainCategory.Text == "खते" && (rbtnCash.Checked == true || rbtnCredit.Checked == true))
                {
                    opration = "FertCashCredit";
                }
                if (cmbMainCategory.Text == "PGR" && rbtnCash.Checked == false && rbtnCredit.Checked == false)
                {
                    opration = "PGR";
                }
                if (cmbMainCategory.Text == "PGR" && (rbtnCash.Checked == true || rbtnCredit.Checked == true))
                {
                    opration = "PGRCashCredit";
                }
                string cashCredit = "";
                if (rbtnCash.Checked == true)
                {
                    cashCredit = "Cash";
                }
                if (rbtnCredit.Checked == true)
                {
                    cashCredit = "Credit";
                }
                DataTable dt = saleReportController.AllSaleCustomerBill(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, opration, cashCredit,isWholeSale);

                string folderPath = "";
                FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
                if (directchoosedlg.ShowDialog() == DialogResult.OK)
                {
                    folderPath = directchoosedlg.SelectedPath;
                }
                else
                {
                    return;
                }
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    string salesInvoiceId = dt.Rows[i]["saleId"].ToString();
                    if (chkholeSale.Checked)
                    {
                        isWholeSale = true;
                         dtSale = ReportController.getWholeSaleInvoice(salesInvoiceId, Utility.FinancilaYearId);
                    }
                    else
                    {
                        isWholeSale = false;
                         dtSale = ReportController.getSaleInvoice(salesInvoiceId, Utility.FinancilaYearId);
                    }
                    
                       // DataTable dtSale = ReportController.getSaleInvoice(salesInvoiceId, Utility.FinancilaYearId);
                    
                    ReportDocument cryRpt = new ReportDocument();

                    RptCustomerBill rpt = new RptCustomerBill();
                    string outstanding = Math.Round(accountDetailsController.GetDueAmount(Convert.ToInt64(dtSale.Rows[0]["customerId"]), "customer", Utility.FinancilaYearId,Convert.ToDateTime(dtSale.Rows[0]["salesDate"])), 2).ToString();
                   rpt.SetParameterValue(0, outstanding);
                    rpt.SetParameterValue(1, isWholeSale);
                   // rpt.SetDataSource(dtSale);
                    rpt.Database.Tables[0].SetDataSource(dtSale);
                    rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
              
                    
                    string fileName = @"\" +salesInvoiceId + "_Bill.pdf";
                    rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, folderPath + fileName);
                   
                }
                MessageBox.Show("Exported Successful");
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        private void FrmAllSaleCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void FrmAllSaleCustomer_Load(object sender, EventArgs e)
        {
           
            rbtnCash.Checked = false;
            rbtnCredit.Checked = false;
            dtpFromDate.Value = Utility.firstDate;
            dtpToDate.Value = Utility.lastDate;
            dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
            Lang();
        }

      

        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCash.Checked == true)
            {
                rbtnCredit.Checked = false;
              //  rdbAll.Checked = false;
            }
            dgvSaleBook.DataSource = null;
        }

        private void rbtnCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCash.Checked == true)
            {
                rbtnCredit.Checked = false;
               // rdbAll.Checked = false;
            }
            dgvSaleBook.DataSource = null;
        }

        private void dgvSaleBook_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void cmbMainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbtnCash.Checked = false;
            rbtnCredit.Checked = false;
        }
    }
}
