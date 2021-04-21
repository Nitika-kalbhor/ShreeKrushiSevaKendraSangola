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
    public partial class frmDamagedStockExpiryReport : MetroForm
    {
        public frmDamagedStockExpiryReport()
        {
            InitializeComponent();
        }
        DataTable reportDt = new DataTable();
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Damaged Stock Expiry Report";
                    btnShow.Text = "Show";
                    btnPrint.Text = "Print";
                    lblFrmDate.Text = "From Date:";
                    lblToDate.Text = "To Date:";

                    dgvBankDeposite.Columns[0].HeaderText = "No.";
                    dgvBankDeposite.Columns[1].HeaderText = "Date";
                    dgvBankDeposite.Columns[2].HeaderText = "Item Name";
                    dgvBankDeposite.Columns[3].HeaderText = "MFD/Exp date";
                    dgvBankDeposite.Columns[4].HeaderText = "Naration";
                    dgvBankDeposite.Columns[5].HeaderText = "Quantity";
                    dgvBankDeposite.Columns[6].HeaderText = "Rate";
                    dgvBankDeposite.Columns[7].HeaderText = "Amount";                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
               DataTable dt=    godownTransferController.getGodowntransferList(Convert.ToDateTime(dtpfrmDate.Value.ToShortDateString()),
                    Convert.ToDateTime(dtpTodate.Value.ToShortDateString()), "damagedStockReport", Utility.FinancilaYearId, 0);
                if(dt.Rows.Count>0)
                {
                    object qty = dt.Compute("SUM(Quantity)", string.Empty);
                    object Amt = dt.Compute("SUM(Amount)", string.Empty);
                    DataRow dr = dt.NewRow();

                    dr["Remark"] = "एकूण:";
                    dr["Quantity"] = qty;
                    dr["Amount"] = Amt;
                    dt.Rows.Add(dr);
                    reportDt = dt;
                    dgvBankDeposite.DataSource = dt;
                    dgvBankDeposite.Rows[dgvBankDeposite.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gold;
                    dgvBankDeposite.Rows[dgvBankDeposite.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 13, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtSaleSummery = reportDt;
                if (dtSaleSummery.Rows.Count > 0)
                {
                    Report rp = new Report();
                    cptDamagedStockExpiryReport CrReportDocument = new cptDamagedStockExpiryReport();
                 //   CrReportDocument.SetDataSource(dtSaleSummery);      
                    CrReportDocument.Database.Tables[0].SetDataSource(dtSaleSummery);
                    CrReportDocument.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                    CrReportDocument.SetParameterValue(0, dtpfrmDate.Value.ToShortDateString());
                    CrReportDocument.SetParameterValue(1, dtpTodate.Value.ToShortDateString());
                    rp.crystalReportViewer1.ReportSource = CrReportDocument;
                    rp.crystalReportViewer1.Refresh();
                    rp.Refresh();
                    rp.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDamagedStockExpiryReport_Load(object sender, EventArgs e)
        {
            Lang();
        }
    }
}
