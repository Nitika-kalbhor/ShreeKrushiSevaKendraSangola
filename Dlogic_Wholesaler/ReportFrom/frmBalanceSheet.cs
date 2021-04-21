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
    public partial class frmBalanceSheet : MetroForm
    {
        public frmBalanceSheet()
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
                    lblHerader.Text = "Balance Sheet";
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

        private void frmBalanceSheet_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Utility.startDate(DateTime.Now);
            Lang();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = accountBalanceReportController.getBalanceSheet(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()));
               
                if (dt.Rows.Count > 0)
                {
                    object drs = dt.Compute("Sum(cr)", string.Empty);
                    object crs = dt.Compute("Sum(dr)", string.Empty);
                   
                     dt.Rows[dt.Rows.Count - 1]["LiabilitesaccountName"] = "Diff Between Opening Balance";
                     dt.Rows[dt.Rows.Count - 1]["cr"] = Math.Round(Convert.ToDouble(crs) - Convert.ToDouble(drs),2);
                     object drs1 = dt.Compute("Sum(cr)", string.Empty);
                     object crs1 = dt.Compute("Sum(dr)", string.Empty);
                     txtDrtotal.Text = drs1.ToString();
                     txtCrAmount.Text = crs1.ToString();
                }
                dgvTrailBalance.DataSource = dt;
                dgvTrailBalance.ClearSelection();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtBalanceSheet = (DataTable)dgvTrailBalance.DataSource;
                if(dtBalanceSheet.Rows.Count>0)
                {
                    Report rpt = new Report();
                    crptBalanaceSheet crReportDocument = new crptBalanaceSheet();
                  //  crReportDocument.SetDataSource(dtBalanceSheet);
                    crReportDocument.Database.Tables[0].SetDataSource(dtBalanceSheet);
                    crReportDocument.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                    crReportDocument.SetParameterValue(0,dtpFromDate.Value.ToShortDateString());
                    crReportDocument.SetParameterValue(1,dtpToDate.Value.ToShortDateString());
                    rpt.crystalReportViewer1.ReportSource = crReportDocument;
                    rpt.crystalReportViewer1.Refresh();
                    rpt.Refresh();
                    rpt.ShowDialog();
                }
            }
            catch(Exception ae)
            {
                throw ae;
             }
        }
    }
}
