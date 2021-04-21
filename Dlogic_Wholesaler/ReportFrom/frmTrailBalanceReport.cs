using DataAccessLayer.controller;
using Dlogic_Wholesaler.CrystalReport;
using Dlogic_Wholesaler.ReportFroms;
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
    public partial class frmTrailBalanceReport : MetroForm
    {
        public frmTrailBalanceReport()
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
                    lblHerader.Text = "Trail Balance Sheet";
                    label1.Text = "From Date:";
                    label2.Text = "To Date:";
                    btnExcel.Text = "Excel Report";
                    btnShow.Text = "Show";
                    btnPrint.Text = "Print";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        private void frmTrailBalanceReport_Load(object sender, EventArgs e)
        {
            dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
            dtpFromDate.Value = Utility.firstDate;
            dtpToDate.Value = Utility.lastDate;
            Lang();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTrailBalance = new DataTable();
                dtTrailBalance = accountBalanceReportController.getTrailBalance(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToString()));
                dgvTrailBalance.DataSource = dtTrailBalance;
                subTot(dtTrailBalance);
            }
            catch(Exception ae)
            {
                if (Utility.Langn == "English")
                {
                    MessageBox.Show("While showing report error occurs" + ae.ToString());
                }
                else
                {
                    MessageBox.Show("रिपोर्ट दाखवण्यास त्रुटी येत आहे" + ae.ToString());
                }              
            }
        }

        private void subTot(DataTable dtTrailBalance)
        {
            try
            {
                double drTotalAmt = 0, crTotalAmt = 0;
                if(dtTrailBalance.Rows.Count>0)
                {
                    foreach(DataRow dr in dtTrailBalance.Rows)
                    {
                        drTotalAmt +=Convert.ToDouble(dr["dr"].ToString());
                        crTotalAmt +=Convert.ToDouble(dr["cr"].ToString());
                    }
                }
                txtDrtotal.Text = Math.Round(drTotalAmt,2).ToString();
                txtCrAmount.Text = Math.Round(crTotalAmt, 2).ToString();
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtTrailbalance = (DataTable)dgvTrailBalance.DataSource;
            Report rpt = new Report();
            crptTrailbalance crReportDocument = new crptTrailbalance();
           // crReportDocument.SetDataSource(dtTrailbalance);
            crReportDocument.Database.Tables[0].SetDataSource(dtTrailbalance);
            crReportDocument.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
            crReportDocument.SetParameterValue(0,dtpFromDate.Value.ToShortDateString());
            crReportDocument.SetParameterValue(1, dtpToDate.Value.ToShortDateString());
            rpt.crystalReportViewer1.ReportSource = crReportDocument;
            rpt.crystalReportViewer1.Refresh();
            rpt.Refresh();
            rpt.Show();
        }
    }
}
