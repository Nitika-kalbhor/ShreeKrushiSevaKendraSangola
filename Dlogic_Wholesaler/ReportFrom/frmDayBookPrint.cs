using DataAccessLayer.controller;
using Microsoft.Reporting.WinForms;
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
    public partial class frmDayBookPrint : Form
    {
        public DateTime fromDate, toDate;
        public frmDayBookPrint(DateTime dtFromDate, DateTime dtToDate)
        {
            fromDate = dtFromDate;
            toDate = dtToDate;
            InitializeComponent();
        }

        private void frmDayBookPrint_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = dayBookReportController.DayBookReport(fromDate, toDate);
                DataTable dt = subtot();
                ReportDataSource datasoure = new ReportDataSource("dtPurchaseDetails", ds.Tables[0]);
                ReportDataSource datasoure1 = new ReportDataSource("dtPurchaseReturn", ds.Tables[1]);
                ReportDataSource datasoure2 = new ReportDataSource("dtSaleDetails", ds.Tables[2]);
                ReportDataSource datasoure3 = new ReportDataSource("dtSaleReturnDetails", ds.Tables[5]);
                ReportDataSource datasoure4 = new ReportDataSource("dtPurchaseReciept", ds.Tables[3]);
                ReportDataSource datasoure5 = new ReportDataSource("dtPurchaseVoucher", ds.Tables[4]);
                ReportDataSource datasoure6 = new ReportDataSource("dtPayRec", ds.Tables[6]);
                ReportDataSource datasoure7 = new ReportDataSource("dtTotal", dt);
                this.rv.LocalReport.DataSources.Clear();
                this.rv.LocalReport.DataSources.Add(datasoure);
                this.rv.LocalReport.DataSources.Add(datasoure1);
                this.rv.LocalReport.DataSources.Add(datasoure2);
                this.rv.LocalReport.DataSources.Add(datasoure3);
                this.rv.LocalReport.DataSources.Add(datasoure4);
                this.rv.LocalReport.DataSources.Add(datasoure5);
                this.rv.LocalReport.DataSources.Add(datasoure6);
                this.rv.LocalReport.DataSources.Add(datasoure7);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("fromDate", fromDate.ToShortDateString());
                parameters[1] = new ReportParameter("toDate", toDate.ToShortDateString());
                this.rv.LocalReport.SetParameters(parameters);
                this.rv.RefreshReport();
            }
            catch(Exception ae)
            {
                MessageBox.Show("Error!"+ae.ToString());
            }
            this.rv.RefreshReport();
        }
        public DataTable subtot()
        {
            try
            {
                double totPAmount = 0, totRPAmount = 0, totSPAmount = 0;
                double totAmount = 0, totRAmount = 0, totSAmount = 0;
                double totSRAmount = 0, TotSCAmount = 0, TotalPAmount = 0;
                double totalCash = 0, totalCredit = 0, GrandCredit = 0, GrandDebit = 0;
                DataSet ds = dayBookReportController.DayBookReport(fromDate, toDate);
                for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
                {
                    totAmount += Convert.ToDouble(ds.Tables[0].Rows[i]["netBillAmount"].ToString());
                    totPAmount += Convert.ToDouble(ds.Tables[0].Rows[i]["paidAmount"].ToString());
                }
                for (int i = 0; i < ds.Tables[1].Rows.Count; ++i)
                {
                    totRAmount += Convert.ToDouble(ds.Tables[1].Rows[i]["netBillAmount"].ToString());
                    totRPAmount += Convert.ToDouble(ds.Tables[1].Rows[i]["paidAmount"].ToString());
                }
                for (int i = 0; i < ds.Tables[2].Rows.Count; ++i)
                {
                    totSAmount += Convert.ToDouble(ds.Tables[2].Rows[i]["totalbillAmount"].ToString());
                    totSPAmount += Convert.ToDouble(ds.Tables[2].Rows[i]["paidAmount"].ToString());
                }
                for (int i = 0; i < ds.Tables[5].Rows.Count; ++i)
                {
                    totSRAmount += Convert.ToDouble(ds.Tables[5].Rows[i]["totalbillAmount"].ToString());
                    TotalPAmount += Convert.ToDouble(ds.Tables[5].Rows[i]["paidAmount"].ToString());
                }
                for (int i = 0; i < ds.Tables[6].Rows.Count; ++i)
                {
                    if (ds.Tables[6].Rows[i]["paymentType"].ToString() == "Cash")
                    {
                        GrandCredit += Convert.ToDouble(ds.Tables[6].Rows[i]["crAmount"].ToString());
                        GrandDebit += Convert.ToDouble(ds.Tables[6].Rows[i]["drAmount"].ToString());
                    }
                }
                double DuePurchSum = totAmount - totPAmount;
                double DuePurchReturnSum = totRAmount - totRPAmount;
                double DueSaleSum = totSAmount - totSPAmount;
                System.Data.DataTable dt = dtPayRect();
                DataRow dr = dt.NewRow();
                dr["SaleCash"] = totSPAmount;
                dr["SaleCredit"] = DueSaleSum;
                dr["SaleReturnCash"] = TotalPAmount;
                dr["SaleReturnCredit"] = totSRAmount - TotalPAmount;
                dr["PurchaseCash"] = totPAmount;
                dr["PurchaseCredit"] = DuePurchSum;
                dr["PurchaseReturnCash"] = totRPAmount;
                dr["PurchaseReturnCredit"] = DuePurchReturnSum;
                dr["TotalCash"] = totRPAmount + totSPAmount + GrandCredit;
                dr["TotalCredit"] = totPAmount + totSRAmount + GrandDebit;
                dr["Total"] = (totRPAmount + totSPAmount + GrandCredit) - (totPAmount + totSRAmount + GrandDebit);
                dt.Rows.Add(dr);
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable dtPayRect()
        {
            DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("SaleCash", typeof(double));
            dt.Columns.Add("SaleCredit", typeof(double));
            dt.Columns.Add("SaleReturnCash", typeof(double));
            dt.Columns.Add("SaleReturnCredit", typeof(double));
            dt.Columns.Add("PurchaseCash", typeof(double));
            dt.Columns.Add("PurchaseCredit", typeof(double));
            dt.Columns.Add("PurchaseReturnCash", typeof(double));
            dt.Columns.Add("PurchaseReturnCredit", typeof(double));
            dt.Columns.Add("TotalCash", typeof(double));
            dt.Columns.Add("TotalCredit", typeof(double));
            dt.Columns.Add("Total", typeof(double));
            return dt;

        }
    }
}
