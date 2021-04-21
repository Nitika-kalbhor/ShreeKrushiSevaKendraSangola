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

using CrystalDecisions.CrystalReports.Engine;
using Dlogic_Wholesaler.CrystalReport;
using System.Globalization;
namespace Dlogic_Wholesaler.Forms
{
    public partial class frmAccountWiseUdhari : MetroForm
    {
        string Opreation = "";
     
        public frmAccountWiseUdhari(long Id ,string Name,string Type)
        {
            InitializeComponent();

            dgvAccount.DataSource = accountDetailsController.GetAccountWisePaymentDue(Id, Type, Utility.FinancilaYearId);
            txtAccountName.Text = Name;
            if(Type=="AllcustomerWise")
            {
                lblAccountName.Text = "ग्राहकाची उधारी";
                lblName.Text = "ग्राहकाचे नांव";
              
            }
            Opreation = Type;
        }

        private void dgvAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try {
                foreach (DataGridViewRow row in dgvAccount.Rows)
                {
                    if (row.Cells["naration"].Value != null)
                    {
                        string RowType = row.Cells["naration"].Value.ToString();


                        if (RowType == "एकूण रक्कम")
                        {
                            row.DefaultCellStyle.BackColor = Color.Wheat;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            row.DefaultCellStyle.Font = new Font("Arial Unicode MS", 14);
                        }
                        if (RowType == "बाकी रक्कम")
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            row.DefaultCellStyle.Font = new Font("Arial Unicode MS", 14);

                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAccountWiseUdhari_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (Opreation == "AllcustomerWise")
                    {
                        if (Convert.ToDouble(dgvAccount.CurrentRow.Cells["crAmount"].Value) > 0)
                        {
                            if (Convert.ToInt64(dgvAccount.CurrentRow.Cells["transactionId"].Value) > 0)
                            {

                                bill(accountDetailsController.getSaleBillPrint(Convert.ToInt64(dgvAccount.CurrentRow.Cells["transactionId"].Value), "SaleBill",Utility.FinancilaYearId));
                            }
                        }
                    }

                }
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        public void bill(DataSet dt)
        {
            try
            {

                System.Globalization.RegionInfo objRegInfo = new RegionInfo("en-IN");
                string syb = objRegInfo.CurrencySymbol;
                
                DataTable dtSale =dt.Tables[0];
              //  DataTable dtSaleByHSNCode = dt.Tables[1];
                string amountInWord = Utility.NumberToWordMarathi(Convert.ToInt64(dtSale.Rows[0]["netBillAmount"].ToString()));
                dtSale.Columns.Add(new DataColumn("amountInWord", typeof(string)));
                foreach (DataRow dr in dtSale.Rows)
                {
                    dr["amountInWord"] =  amountInWord +" " + "रुपये /- फक्त."; ;
                }
                RptCustomerBill rpt = new RptCustomerBill();
                RptSaleBill frm = new RptSaleBill();
                rpt.Database.Tables[0].SetDataSource(dtSale);
                rpt.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
             //   rpt.Subreports[0].SetDataSource(dtSaleByHSNCode);
                string outstanding = Math.Round(accountDetailsController.GetDueAmount(Convert.ToInt64(dtSale.Rows[0]["customerId"]), "customer", Utility.FinancilaYearId, Convert.ToDateTime(dtSale.Rows[0]["salesDate"])), 2).ToString();
                bool isWholeSale = Convert.ToInt32(dtSale.Rows[0]["isWholeSale"].ToString())==1?true:false;
                rpt.SetParameterValue(0, outstanding);
                rpt.SetParameterValue(1, isWholeSale);
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Refresh();
                frm.crystalReportViewer1.Refresh();
                frm.ShowDialog();
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
    }
}
