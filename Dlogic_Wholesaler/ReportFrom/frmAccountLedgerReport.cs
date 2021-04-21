using DataAccessLayer.controller;
using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Dlogic_Wholesaler.CrystalReport;
using Dlogic_Wholesaler.ReportFroms;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;

namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class frmAccountLedgerReport : MetroForm
    {
        BackgroundWorker bgw = new BackgroundWorker();
        public frmAccountLedgerReport() 
        {
            InitializeComponent();
        }

        int type = 0;
        bool summary = false;
        long salesmanId = 0;
        public void getAccountNamePaymentDue()
        {
            
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Account Pending Amount Report";
                    chkOther.Text = "Other Accounts";
                    rbCustomer.Text = "Customer";
                    rbDealer.Text = "Dealer";
                    chkSummery.Text = "Summery";
                    metroLabel2.Text = "Account Name:";
                    metroLabel1.Text = "From Date:";
                    metroLabel3.Text = "To Date:";
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
        public void BindComboBoxgetSalesmanName()
        {
            DataTable dt = SalesManDetailsController.getSalesmanDetails();
            Utility.BindComboBoxDataSelect(cmbSalesman, dt, "SalesmanId", "SalesmanName");
        }
        public void BindCustomerGrid(DataTable dtAccountLedger)
        {
            try
            {
                dgvAccountLedger.DataSource = null;
                dgvAccountLedger.AutoGenerateColumns = false;
                dgvAccountLedger.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvAccountLedger.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvAccountLedger.Font = new Font("Arial Unicode MS", 11);
                dgvAccountLedger.EnableHeadersVisualStyles = false;
                if ( Convert.ToInt32(cmbAccountName.SelectedValue) != 0)
                {
                    if (Utility.Langn == "English")
                    {
                        dgvAccountLedger.Columns[0].HeaderText = "Date";
                        dgvAccountLedger.Columns[1].HeaderText = "Naration";
                    }
                    else
                    {
                        dgvAccountLedger.Columns[0].HeaderText = "दिनांक";
                        dgvAccountLedger.Columns[1].HeaderText = "तपशील";
                    }
                    dgvAccountLedger.ColumnCount = 4;
                    dgvAccountLedger.Columns[0].Name = "transactionDate";                  
                    dgvAccountLedger.Columns[0].DataPropertyName = "transactionDate";
                    dgvAccountLedger.Columns[0].Width = 150;

                    dgvAccountLedger.Columns[1].Name = "naration";                   
                    dgvAccountLedger.Columns[1].DataPropertyName = "naration";
                    dgvAccountLedger.Columns[1].Width = 400;
                    if (type == 1)
                    {
                        if (Utility.Langn == "English")
                        {
                            dgvAccountLedger.Columns[2].HeaderText = "CR.Amount";
                            dgvAccountLedger.Columns[3].HeaderText = "DR.Amount";
                        }
                        else
                        {
                            dgvAccountLedger.Columns[2].HeaderText = "जमा रक्कम";
                            dgvAccountLedger.Columns[3].HeaderText = "नावे रक्कम";
                        }
                        dgvAccountLedger.Columns[2].Name = "drAmount";                      
                        dgvAccountLedger.Columns[2].DataPropertyName = "drAmount";
                        dgvAccountLedger.Columns[2].Width = 150;

                        dgvAccountLedger.Columns[3].Name = "crAmount";                        
                        dgvAccountLedger.Columns[3].DataPropertyName = "crAmount";
                        dgvAccountLedger.Columns[3].Width = 150;
                        dgvAccountLedger.Columns[3].Visible = true;
                    }
                    if (type == 2)
                    {
                        if (Utility.Langn == "English")
                        {
                            dgvAccountLedger.Columns[2].HeaderText = "DR.Amount";
                            dgvAccountLedger.Columns[3].HeaderText = "CR.Amount";
                        }
                        else
                        {
                            dgvAccountLedger.Columns[2].HeaderText = "नावे रक्कम";
                            dgvAccountLedger.Columns[3].HeaderText = "जमा रक्कम";
                        }
                        dgvAccountLedger.Columns[2].Name = "crAmount";                      
                        dgvAccountLedger.Columns[2].DataPropertyName = "crAmount";
                        dgvAccountLedger.Columns[2].Width = 150;

                        dgvAccountLedger.Columns[3].Name = "drAmount";                      
                        dgvAccountLedger.Columns[3].DataPropertyName = "drAmount";
                        dgvAccountLedger.Columns[3].Width = 150;
                        dgvAccountLedger.Columns[3].Visible = true;

                    }
                    if (type == 3)
                    {
                        if (Utility.Langn == "English")
                        {
                            dgvAccountLedger.Columns[2].HeaderText = "DR.Amount";
                            dgvAccountLedger.Columns[3].HeaderText = "CR.Amount";
                        }
                        else
                        {
                            dgvAccountLedger.Columns[2].HeaderText = "नावे रक्कम";
                            dgvAccountLedger.Columns[3].HeaderText = "जमा रक्कम";
                        }
                        dgvAccountLedger.Columns[2].Name = "crAmount";                       
                        dgvAccountLedger.Columns[2].DataPropertyName = "crAmount";
                        dgvAccountLedger.Columns[2].Width = 150;

                        dgvAccountLedger.Columns[3].Name = "drAmount";                       
                        dgvAccountLedger.Columns[3].DataPropertyName = "drAmount";
                        dgvAccountLedger.Columns[3].Width = 150;
                        dgvAccountLedger.Columns[3].Visible = true;

                    }     
                    dgvAccountLedger.DataSource = dtAccountLedger;
                }
                else
                {
                    dgvAccountLedger.ColumnCount = 5;
                    if (Utility.Langn == "English")
                    {
                        dgvAccountLedger.Columns[0].HeaderText = "Account Name";
                    }
                    else
                    {
                        dgvAccountLedger.Columns[0].HeaderText = "खात्याचे नांव";
                    }

                    dgvAccountLedger.Columns[0].Name = "accountName";                   
                    dgvAccountLedger.Columns[0].DataPropertyName = "accountName";
                    dgvAccountLedger.Columns[0].Width = 400;
                    if (type == 1)
                    {
                        if (Utility.Langn == "English")
                        {
                            dgvAccountLedger.Columns[1].HeaderText = "CR.Amount";
                            dgvAccountLedger.Columns[2].HeaderText = "DR.Amount";
                            dgvAccountLedger.Columns[3].HeaderText = "Date";
                            dgvAccountLedger.Columns[4].HeaderText = "Due Amount";
                        }
                        else
                        {
                            dgvAccountLedger.Columns[1].HeaderText = "जमा रक्कम";
                            dgvAccountLedger.Columns[2].HeaderText = "नावे रक्कम";
                            dgvAccountLedger.Columns[3].HeaderText = "दिनांक";
                            dgvAccountLedger.Columns[4].HeaderText = "बाकी रक्कम";
                        }
                        dgvAccountLedger.Columns[1].Name = "drAmount";                     
                        dgvAccountLedger.Columns[1].DataPropertyName = "drAmount";
                        dgvAccountLedger.Columns[1].Width = 150;

                        dgvAccountLedger.Columns[2].Name = "crAmount";                      
                        dgvAccountLedger.Columns[2].DataPropertyName = "crAmount";
                        dgvAccountLedger.Columns[2].Width = 150;

                        dgvAccountLedger.Columns[3].Name = "transactionDate";                       
                        dgvAccountLedger.Columns[3].DataPropertyName = "transactionDate";
                        dgvAccountLedger.Columns[3].Visible = false;

                        dgvAccountLedger.Columns[4].Name = "dueAmount";                        
                        dgvAccountLedger.Columns[4].DataPropertyName = "dueAmount";
                        dgvAccountLedger.Columns[4].Visible = true;
                    }
                    if (type == 2)
                    {
                        if (Utility.Langn == "English")
                        {
                            dgvAccountLedger.Columns[1].HeaderText = "CR.Amount";
                            dgvAccountLedger.Columns[2].HeaderText = "DR.Amount";
                            dgvAccountLedger.Columns[3].HeaderText = "Date";
                            dgvAccountLedger.Columns[4].HeaderText = "Due Amount";
                        }
                        else
                        {
                            dgvAccountLedger.Columns[1].HeaderText = "जमा रक्कम";
                            dgvAccountLedger.Columns[2].HeaderText = "नावे रक्कम";
                            dgvAccountLedger.Columns[3].HeaderText = "दिनांक";
                            dgvAccountLedger.Columns[4].HeaderText = "बाकी रक्कम";
                        }
                        dgvAccountLedger.Columns[1].Name = "drAmount";
                       dgvAccountLedger.Columns[1].DataPropertyName = "drAmount";
                        dgvAccountLedger.Columns[1].Width = 150;

                        dgvAccountLedger.Columns[2].Name = "crAmount";
                       dgvAccountLedger.Columns[2].DataPropertyName = "crAmount";
                        dgvAccountLedger.Columns[2].Width = 150;

                        dgvAccountLedger.Columns[3].Name = "transactionDate";                      
                        dgvAccountLedger.Columns[3].DataPropertyName = "transactionDate";
                        dgvAccountLedger.Columns[3].Visible = false;

                        dgvAccountLedger.Columns[4].Name = "dueAmount";                       
                        dgvAccountLedger.Columns[4].DataPropertyName = "dueAmount";
                        dgvAccountLedger.Columns[4].Visible = true;

                    }
                    if (type == 3)
                    {
                        if (Utility.Langn == "English")
                        {
                            dgvAccountLedger.Columns[1].HeaderText = "CR.Amount";
                            dgvAccountLedger.Columns[2].HeaderText = "DR.Amount";
                            dgvAccountLedger.Columns[3].HeaderText = "Date";
                            dgvAccountLedger.Columns[4].HeaderText = "Naration";
                        }
                        else
                        {
                            dgvAccountLedger.Columns[1].HeaderText = "जमा रक्कम";
                            dgvAccountLedger.Columns[2].HeaderText = "नावे रक्कम";
                            dgvAccountLedger.Columns[3].HeaderText = "दिनांक";
                            dgvAccountLedger.Columns[4].HeaderText = "तपशील";
                        }
                        dgvAccountLedger.Columns[1].Name = "drAmount";                     
                        dgvAccountLedger.Columns[1].DataPropertyName = "drAmount";
                        dgvAccountLedger.Columns[1].Width = 150;

                        dgvAccountLedger.Columns[2].Name = "crAmount";                    
                        dgvAccountLedger.Columns[2].DataPropertyName = "crAmount";
                        dgvAccountLedger.Columns[2].Width = 150;

                        dgvAccountLedger.Columns[3].Name = "transactionDate";                       
                        dgvAccountLedger.Columns[3].DataPropertyName = "transactionDate";
                        dgvAccountLedger.Columns[3].Visible = false;

                        dgvAccountLedger.Columns[4].Name = "naration";                      
                        dgvAccountLedger.Columns[4].DataPropertyName = "naration";
                        dgvAccountLedger.Columns[4].Visible = false;

                    }
                    dgvAccountLedger.DataSource = dtAccountLedger;
                }
                if (Convert.ToInt32(cmbAccountName.SelectedValue) != 0 || cmbAccountName.SelectedIndex != 0)
                {
                    dgvAccountLedger.Rows[dgvAccountLedger.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                    dgvAccountLedger.Rows[dgvAccountLedger.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Black;

                    dgvAccountLedger.Rows[dgvAccountLedger.Rows.Count - 2].DefaultCellStyle.BackColor = Color.RosyBrown;
                    dgvAccountLedger.Rows[dgvAccountLedger.Rows.Count - 2].DefaultCellStyle.ForeColor = Color.Black;
                    //foreach (DataGridViewRow row in dgvAccountLedger.Rows)
                    //{
                    //    string RowType = row.Cells["naration"].Value.ToString();
                    //    if (RowType == "एकून रक्कम")
                    //    {
                    //        row.DefaultCellStyle.BackColor = Color.Yellow;
                    //        row.DefaultCellStyle.ForeColor = Color.Black;
                    //        row.DefaultCellStyle.Font = new Font("Arial Unicode MS", 14);
                    //    }
                    //    if (RowType == "बाकी रक्कम(Cr)" || RowType == "बाकी रक्कम(Dr)")
                    //    {
                    //        row.DefaultCellStyle.BackColor = Color.RosyBrown;
                    //        row.DefaultCellStyle.ForeColor = Color.Black;
                    //        row.DefaultCellStyle.Font = new Font("Arial Unicode MS", 14);
                    //    }
                    //}
                }
                else
                {
                    if ((rbCustomer.Checked == true || rbDealer.Checked == true)&& (dgvAccountLedger.Rows.Count>1))
                    {
                        dgvAccountLedger.Rows[dgvAccountLedger.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                        dgvAccountLedger.Rows[dgvAccountLedger.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Black;

                        dgvAccountLedger.Rows[dgvAccountLedger.Rows.Count - 2].DefaultCellStyle.BackColor = Color.RosyBrown;
                        dgvAccountLedger.Rows[dgvAccountLedger.Rows.Count - 2].DefaultCellStyle.ForeColor = Color.Black;
                        //foreach (DataGridViewRow row in dgvAccountLedger.Rows)
                        //{
                        //    string RowType = row.Cells["accountName"].Value.ToString();
                        //    if (RowType == "एकूण रक्कम")
                        //    {
                        //        row.DefaultCellStyle.BackColor = Color.Yellow;
                        //        row.DefaultCellStyle.ForeColor = Color.Black;
                        //        row.DefaultCellStyle.Font = new Font("Arial Unicode MS", 14);
                        //    }
                        //    if (RowType == "बाकी रक्कम(Cr)" || RowType == "बाकी रक्कम(Dr)")
                        //    {
                        //        row.DefaultCellStyle.BackColor = Color.RosyBrown;
                        //        row.DefaultCellStyle.ForeColor = Color.Black;
                        //        row.DefaultCellStyle.Font = new Font("Arial Unicode MS", 14);

                        //    }
                        //}

                    }
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbCustomer.Checked == false && rbDealer.Checked == false && chkOther.Checked==false)
                {
                    
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select Customer Or Dealer or Other accounts..");
                    }
                    else
                    {
                        MessageBox.Show("कृपया ग्राहक किंवा व्यापारी किंवा इतर खाती निवडा..");
                    }
                    return;
                }
                if (cmbAccountName.SelectedValue == null || Convert.ToInt32(cmbAccountName.SelectedValue) == 0)
                {
                    int type = 0;
                    if (rbCustomer.Checked == true)
                    {
                        type = 0;
                    }
                    if(rbDealer.Checked==true)
                    {
                        type = 3;
                    }
                    if (chkOther.Checked == true)
                    {
                        type = 4;
                    }
                 
                    if(chkSummery.Checked==true)
                    {
                        summary = true;
                    }
                    else
                    {
                        summary = false;
                    }
                    if(Convert.ToInt32(cmbSalesman.SelectedValue) != 0)
                    {
                        salesmanId =Convert.ToInt32(cmbSalesman.SelectedValue);
                    }
                    else
                    {
                        salesmanId = 0;
                    }
                    DataTable dtAccountLedgerReport = accountLedgerReportController.getAccountLedgerDetails(Convert.ToInt64(cmbAccountName.SelectedValue), Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), type, Utility.FinancilaYearId, summary,salesmanId);
                    if (dtAccountLedgerReport.Rows.Count > 0)
                    {
                        var query = from accountTable in dtAccountLedgerReport.AsEnumerable()
                                    where accountTable.Field<Decimal>("crAmount") > 0
                                     || accountTable.Field<Decimal>("drAmount") > 0
                                    select accountTable;
                        if (query.Count() > 0)
                        {
                            dtAccountLedgerReport = query.CopyToDataTable<DataRow>();
                            double crAmount = 0; double drAmount = 0; double dueAmount = 0;
                            for (int i = 0; i < dtAccountLedgerReport.Rows.Count; ++i)
                            {
                                crAmount += Convert.ToDouble(dtAccountLedgerReport.Rows[i]["crAmount"]);
                                drAmount += Convert.ToDouble(dtAccountLedgerReport.Rows[i]["drAmount"]);
                                dueAmount += Convert.ToDouble(dtAccountLedgerReport.Rows[i]["dueAmount"]);

                            }
                            DataRow dr = dtAccountLedgerReport.NewRow();
                           
                            if (Utility.Langn == "English")
                            {
                                dr["accountName"] = "Total Amt";
                            }
                            else
                            {
                                dr["accountName"] = "एकूण रक्कम";
                            }
                            dr["crAmount"] = crAmount;
                            dr["drAmount"] = drAmount;
                            dr["dueAmount"] = dueAmount;
                            dtAccountLedgerReport.Rows.Add(dr);
                            //DataRow dr1 = dtAccountLedgerReport.NewRow();
                            //double due = 0;
                            //if (type == 0)
                            //{
                            //    due = drAmount - crAmount;
                            //}
                            //if (type == 3)
                            //{
                            //    due = crAmount - drAmount;
                            //}
                            //if (due < 0)
                            //{
                            //    due = (-due);
                            //    //  dr1["transactionDate"] = "";
                              
                            //    if (Utility.Langn == "English")
                            //    {
                            //        dr1["accountName"] = "Remaining Amt(Dr)";
                            //    }
                            //    else
                            //    {
                            //        dr1["accountName"] = "बाकी रक्कम(Dr)";
                            //    }

                            //    dr1["crAmount"] = due;
                            //    dr1["drAmount"] = 0;
                            //}
                            //else
                            //{
                            //    //  dr1["transactionDate"] = "";
                              
                            //    if (Utility.Langn == "English")
                            //    {
                            //        dr1["accountName"] = "Remaining Amt(Cr)";
                            //    }
                            //    else
                            //    {
                            //        dr1["accountName"] = "बाकी रक्कम(Cr)";
                            //    }

                            //    dr1["crAmount"] = due;
                            //    dr1["drAmount"] = 0;
                            //}
                            //dtAccountLedgerReport.Rows.Add(dr1);
                            BindCustomerGrid(dtAccountLedgerReport);
                            // mpPro.Hide();
                        }
                    }
                }
                else  
                {
                    if (chkSummery.Checked == true)
                    {
                        summary = true;
                    }
                    else
                    {
                        summary = false;
                    }
                    DataTable dtAccountLedgerReport = accountLedgerReportController.getAccountLedgerDetails(Convert.ToInt64(cmbAccountName.SelectedValue), Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), 1, Utility.FinancilaYearId, summary,salesmanId);
                    if (dtAccountLedgerReport.Rows.Count > 0)
                    {
                        //var query = from accountTable in dtAccountLedgerReport.AsEnumerable()
                        //            where accountTable.Field<Double>("crAmount") > 0
                        //             || accountTable.Field<Double>("drAmount") > 0
                        //            select accountTable;
                        //if (query.Count() > 0)
                        //{
                          //  dtAccountLedgerReport = query.CopyToDataTable<DataRow>();
                            double crAmount = 0; double drAmount = 0;
                            for (int i = 0; i < dtAccountLedgerReport.Rows.Count; ++i)
                            {
                                if (dtAccountLedgerReport.Rows[i]["crAmount"].ToString() != string.Empty)
                                {
                                    crAmount += Convert.ToDouble(dtAccountLedgerReport.Rows[i]["crAmount"]);
                                }
                                if (dtAccountLedgerReport.Rows[i]["drAmount"].ToString() != string.Empty)
                                {
                                    drAmount += Convert.ToDouble(dtAccountLedgerReport.Rows[i]["drAmount"]);
                                }

                            }
                            DataRow dr = dtAccountLedgerReport.NewRow();
                            dr["transactionDate"] = "";
                           
                            if (Utility.Langn == "English")
                            {
                                dr["naration"] = "Total Amt";
                            }
                            else
                            {
                                dr["naration"] = "एकून रक्कम";
                            }

                            dr["crAmount"] = crAmount.ToString();
                            dr["drAmount"] = drAmount.ToString();
                            dtAccountLedgerReport.Rows.Add(dr);
                            DataRow dr1 = dtAccountLedgerReport.NewRow();
                            double due = 0;
                            if (type == 1)
                            {
                                due = drAmount - crAmount;
                            }
                            if (type == 2)
                            {
                                due = crAmount - drAmount;
                            }
                            if (due < 0)
                            {
                                due = (-due);
                                dr1["transactionDate"] = "";
                               
                                if (Utility.Langn == "English")
                                {
                                    dr1["naration"] = "Remaining Amt(Dr)";
                                }
                                else
                                {
                                    dr1["naration"] = "बाकी रक्कम(Dr)";
                                }

                                dr1["crAmount"] = due.ToString();
                                dr1["drAmount"] = 0;
                            }
                            else
                            {
                                dr1["transactionDate"] = "";                               
                                if (Utility.Langn == "English")
                                {
                                    dr1["naration"] = "Remaining Amt(Cr)";
                                }
                                else
                                {
                                    dr1["naration"] = "बाकी रक्कम(Cr)";
                                }

                                dr1["crAmount"] = due;
                                dr1["drAmount"] = 0;
                            }
                            dtAccountLedgerReport.Rows.Add(dr1);
                            BindCustomerGrid(dtAccountLedgerReport);
                        }
                        else
                        {
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Information Not present" + dtpFromDate.Value + "To" + dtpToDate.Value, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("माहिती नाही आहे" + dtpFromDate.Value + "ते" + dtpToDate.Value, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            dgvAccountLedger.DataSource = null;
                        }

                    }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            finally
            {
                dgvAccountLedger.ClearSelection();
            }
        }
        private void frmAccountLedgerReport_Load(object sender, EventArgs e)
        {
            try
            {
               dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
               dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
               dtpFromDate.Value = Utility.firstDate;
               dtpToDate.Value = Utility.lastDate;
               Lang();
            }
            catch
            {
            }
        }
        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCustomer.Checked)
                {
                    rbDealer.Checked = false;
                    chkOther.Checked = false;
                    type = 1;
                    DataTable dtaccountName = accountLedgerReportController.getAccountNamePaymentDue(type);
                    Utility.BindComboBoxDataSelect(cmbAccountName, dtaccountName, "accountId", "accountName");
                    DataTable dtAccountLedgerReport = null;
                    BindCustomerGrid(dtAccountLedgerReport);
                    cmbSalesman.Visible = true;
                    lblsalesman.Visible = true;
                    BindComboBoxgetSalesmanName();
                    
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void rbDealer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbDealer.Checked)
                {
                    rbCustomer.Checked = false;
                    chkOther.Checked = false;
                    type = 2;
                    DataTable dtaccountName = accountLedgerReportController.getAccountNamePaymentDue(type);
                    Utility.BindComboBoxDataSelect(cmbAccountName, dtaccountName, "accountId", "accountName");
                    DataTable dtAccountLedgerReport = null;
                    BindCustomerGrid(dtAccountLedgerReport);
                    cmbSalesman.Visible = false;
                    lblsalesman.Visible = false;
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dgvAccountLedger_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int type = 0;
            if(rbCustomer.Checked==true)
            {
               type = 1;
            }
            if(rbDealer.Checked==true)
            {
                type = 2;
            }
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCustomer.Checked = false && rbDealer.Checked == false)
                {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please select customer or dealer..");
                    }
                    else
                    {
                        MessageBox.Show("कृपया ग्राहक किंवा व्यापारी निवडा..");
                    }
                    return;
                }
                dtpToDate.MinDate = dtpFromDate.Value;
                if (Convert.ToInt64(cmbAccountName.SelectedValue) != 0)
                {
                    DataTable dtAccountLedgerReport = accountLedgerReportController.getAccountLedgerDetails(Convert.ToInt64(cmbAccountName.SelectedValue), Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), 1, Utility.FinancilaYearId, summary, salesmanId);
                    if (dtAccountLedgerReport.Rows.Count > 0)
                    {
                        var query = from accountTable in dtAccountLedgerReport.AsEnumerable()
                                    where accountTable.Field<Double>("crAmount") > 0
                                     || accountTable.Field<Double>("drAmount") > 0
                                    select accountTable;
                        if (query.Count() > 0)
                        {
                            dtAccountLedgerReport = query.CopyToDataTable<DataRow>();
                            double crAmount = 0; double drAmount = 0;
                            for (int i = 0; i < dtAccountLedgerReport.Rows.Count; ++i)
                            {
                                crAmount += Convert.ToDouble(dtAccountLedgerReport.Rows[i]["crAmount"]);
                                drAmount += Convert.ToDouble(dtAccountLedgerReport.Rows[i]["drAmount"]);

                            }
                            DataRow dr = dtAccountLedgerReport.NewRow();
                            dr["transactionDate"] = "";                         
                            if (Utility.Langn == "English")
                            {
                                dr["naration"] = "Total Amount";
                            }
                            else
                            {
                                dr["naration"] = "एकून रक्कम";
                            }
                            //dr["orjName"] = "";
                            //dr["orjId"] = 0;
                            dr["crAmount"] = crAmount;
                            dr["drAmount"] = drAmount;
                            dtAccountLedgerReport.Rows.Add(dr);
                            DataRow dr1 = dtAccountLedgerReport.NewRow();
                            double due = 0;
                            if (type == 1)
                            {
                                due = drAmount - crAmount;
                            }
                            if (type == 2)
                            {
                                due = crAmount - drAmount;
                            }
                            if (due < 0)
                            {
                                due = (-due);
                                dr1["transactionDate"] = "";
                            
                                if (Utility.Langn == "English")
                                {
                                    dr1["naration"] = "Remaining Amt(Dr)";
                                }
                                else
                                {
                                    dr1["naration"] = "बाकी रक्कम(Dr)";
                                }
                                //dr1["orjName"] = "";
                                //dr1["orjId"] = 0;
                                dr1["crAmount"] = due;
                                dr1["drAmount"] = 0;
                            }
                            else
                            {
                                dr1["transactionDate"] = "";                               
                                if (Utility.Langn == "English")
                                {
                                    dr1["naration"] = "Remaining Amt(Cr)";
                                }
                                else
                                {
                                    dr1["naration"] = "बाकी रक्कम(Cr)";
                                }
                                //dr1["orjName"] = "";
                                //dr1["orjId"] = 0;
                                dr1["crAmount"] = due;
                                dr1["drAmount"] = 0;
                            }
                            dtAccountLedgerReport.Rows.Add(dr1);




                            BindCustomerGrid(dtAccountLedgerReport);
                            // mpPro.Hide();
                        }
                        else
                        {
                           
                            if (Utility.Langn == "English")
                            {
                                MessageBox.Show("Information Not present" + dtpFromDate.Value + "To" + dtpToDate.Value, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("माहिती नाही आहे" + dtpFromDate.Value + "ते" + dtpToDate.Value, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            dgvAccountLedger.DataSource = null;
                            //mpPro.Hide();
                        }
                    }

                }
                else
                {
                    int type = 0;
                    if (rbCustomer.Checked == true)
                    {
                        type = 0;
                    }
                    else
                    {
                        type = 3;
                    }
                    if(chkSummery.Checked==true)
                    {
                        summary = true;
                    }
                    else
                    {
                        summary = false;
                    }
                    DataTable dtAccountLedgerReport = accountLedgerReportController.getAccountLedgerDetails(Convert.ToInt64(cmbAccountName.SelectedValue), Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), type, Utility.FinancilaYearId, summary,salesmanId);
                    if (dtAccountLedgerReport.Rows.Count > 0)
                    {
                        var query = from accountTable in dtAccountLedgerReport.AsEnumerable()
                                    where accountTable.Field<Double>("crAmount") > 0
                                     || accountTable.Field<Double>("drAmount") > 0
                                    select accountTable;
                        if (query.Count() > 0)
                        {
                            dtAccountLedgerReport = query.CopyToDataTable<DataRow>();
                            double crAmount = 0; double drAmount = 0; double dueAmount = 0;
                            for (int i = 0; i < dtAccountLedgerReport.Rows.Count; ++i)
                            {
                                crAmount += Math.Round(Convert.ToDouble(dtAccountLedgerReport.Rows[i]["crAmount"]));
                                drAmount += Math.Round(Convert.ToDouble(dtAccountLedgerReport.Rows[i]["drAmount"]));
                                dueAmount += Math.Round(Convert.ToDouble(dtAccountLedgerReport.Rows[i]["dueAmount"]));

                            }
                            DataRow dr = dtAccountLedgerReport.NewRow();


                            dr["accountName"] = "";
                            dr["crAmount"] = crAmount;
                            dr["drAmount"] = drAmount;
                            dr["dueAmount"] = dueAmount;
                            dtAccountLedgerReport.Rows.Add(dr);
                            BindCustomerGrid(dtAccountLedgerReport);
                            // mpPro.Hide();
                        }
                    }
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void frmAccountLedgerReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                //DataTable dt = (DataTable)dgvAccountLedger.DataSource;
                //bool isinduvisualCustomer = false;
                //if (cmbAccountName.SelectedIndex == 0)
                //{
                //    isinduvisualCustomer = false;
                //}
                //else
                //{
                //    isinduvisualCustomer = true;
                //}
                //Report rp = new Report();
                //crpAccountLedger crReportDocument = new crpAccountLedger();
                ////crReportDocument.SetDataSource(dt);
                //crReportDocument.Database.Tables[0].SetDataSource(dt);
                //crReportDocument.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                //crReportDocument.SetParameterValue(0, isinduvisualCustomer);
                //rp.crystalReportViewer1.ReportSource = crReportDocument;
                //rp.crystalReportViewer1.ReportSource = crReportDocument;
                //rp.crystalReportViewer1.Refresh();
                //rp.Refresh();
                //rp.Show();

                if (dgvAccountLedger.Rows.Count > 0)
                {
                 DataTable dt = (dgvAccountLedger.DataSource as DataTable).Copy();
               // DataTable dt = (DataTable)dgvAccountLedger.DataSource;
                bool isinduvisualCustomer = false;
                if (cmbAccountName.SelectedIndex == 0)
                {
                    isinduvisualCustomer = false;
                }
                else
                {
                    isinduvisualCustomer = true;
                }
                
                    if (dt.Rows.Count > 0)
                    {
                        frmRptAccountLedger rpt = new frmRptAccountLedger();
                        rpt.rptAccountLedger.LocalReport.DataSources.Clear();
                        rpt.rptAccountLedger.ProcessingMode = ProcessingMode.Local;
                        ReportDataSource datasource = new ReportDataSource("DSBillingInfo", Utility.dtGenericBillInfo);
                        ReportDataSource datasource1 = new ReportDataSource("DSAccountLedger", dt);
                        rpt.rptAccountLedger.LocalReport.ReportEmbeddedResource = "Dlogic_Wholesaler.RDLCReport.rptAccountLedger.rdlc";
                        rpt.rptAccountLedger.LocalReport.DataSources.Add(datasource);
                        rpt.rptAccountLedger.LocalReport.DataSources.Add(datasource1);
                        ReportParameter[] parmeters = new ReportParameter[1];
                        parmeters[0] = new ReportParameter("isinduvisualCustomer", isinduvisualCustomer.ToString());
                        rpt.rptAccountLedger.LocalReport.SetParameters(parmeters);
                        if (isinduvisualCustomer)
                        {
                            rpt.Text = cmbAccountName.Text;
                        }
                        else
                        {
                            rpt.Text = "Account Ledger Report";
                        }
                      
                        rpt.rptAccountLedger.RefreshReport();
                        rpt.Show();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbAccountName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSalesman.SelectedIndex > 0)
            {
                cmbSalesman.SelectedIndex = 0;
            }
        }

        private void chkOther_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOther.Checked==true)
            {
                rbCustomer.Checked = false;
                rbDealer.Checked = false;
                type = 3;
                DataTable dtaccountName = accountLedgerReportController.getAccountNamePaymentDue(type);
                Utility.BindComboBoxDataSelect(cmbAccountName, dtaccountName, "accountId", "accountName");
                DataTable dtAccountLedgerReport = null;
                BindCustomerGrid(dtAccountLedgerReport);
            }
        }

        private void chkSummery_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbSalesman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAccountName.SelectedIndex > 0)
            {
                cmbAccountName.SelectedIndex = 0;
            }
        }
    }
}
