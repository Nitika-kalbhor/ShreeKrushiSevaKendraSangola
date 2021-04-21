using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using DataAccessLayer.controller;
using DataAccessLayer.models;
using Dlogic_Wholesaler.ReportFrom;
using System.Configuration;

using Dlogic_Wholesaler.Forms;

namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class RptSaleBill : MetroForm
    {
        public RptSaleBill()
        {
            InitializeComponent();
        }

        private void RptSaleBill_Load(object sender, EventArgs e)
        {
            //DataTable dtSale = ReportController.getSaleInvoice(frmSaleInvoive.SaleID);
            //ReportDataSource datasource = new ReportDataSource("Sale", dtSale);
            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(datasource);
            //this.reportViewer1.RefreshReport();
         
        }

        private void RptSaleBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        
    }
}
