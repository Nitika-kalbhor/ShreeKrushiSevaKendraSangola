using DataAccessLayer.controller;
using DataAccessLayer.models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Dlogic_Wholesaler.CrystalReport;

namespace Dlogic_Wholesaler.ReportFroms
{
    public partial class frmCustomerLadger : MetroForm
    {
        public long customerIds = 0;
        public frmCustomerLadger(long customerId, string customerName)
        {
            try
            {
                InitializeComponent();
                customerIds = customerId;
                textBox1.Text = customerName;
                dgvAccountLedger.DataSource = accountLedgerReportController.getAccountLedgerDetails(customerId, DateTime.Now, DateTime.Now, 2,Utility.FinancilaYearId,false,0);
                dgvAccountLedger.Columns["जमा रक्कम(CR)"].DefaultCellStyle.Format = "N2";
                dgvAccountLedger.Columns["नावे रक्कम(DR)"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCustomerLadger_Load(object sender, EventArgs e)
        {
            //DataTable dtAccountLedgerReport = accountLedgerReportController.getAccountLedgerDetails(customerId, DateTime.Now, DateTime.Now, 2);
        }

        private void frmCustomerLadger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
