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
    public partial class frmTradingProfitAdnLossAccountReport : MetroForm
    {
        public frmTradingProfitAdnLossAccountReport()
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
                    lblHerader.Text = "Profit Loss Report";
                    metroLabel1.Text = "From Date:";
                    metroLabel3.Text = "To Date:";
                    metroLabel2.Text = "Jama";
                   metroLabel4.Text = "Nave";                  
                    btnnew.Text = "Show";
                    btnExcelConvert.Text = "Exel Report";
                    btnPrintReport.Text = "Print Report";                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void frmTradingProfitAdnLossAccountReport_Load(object sender, EventArgs e)
        {
            dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
            dtpFromDate.Value = Utility.firstDate;
            dtpToDate.Value = Utility.lastDate;
            Lang();
        }
        public void bindData( DataTable dtProfitLoss)
        {
            try
            {
                dgvProftandLoss.DataSource = null;
                dgvProftandLoss.AutoGenerateColumns = false;
                dgvProftandLoss.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvProftandLoss.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvProftandLoss.Font = new System.Drawing.Font("Arial UniCode MS", 12);
                dgvProftandLoss.EnableHeadersVisualStyles = false;
                dgvProftandLoss.ColumnCount = 4;
                if (Utility.Langn == "English")
                {
                    dgvProftandLoss.Columns[0].HeaderText = "Naration";
                    dgvProftandLoss.Columns[1].HeaderText = "Amount";
                    dgvProftandLoss.Columns[2].HeaderText = "Naration";
                    dgvProftandLoss.Columns[3].HeaderText = "Amount";
                }
                else
                {
                    dgvProftandLoss.Columns[0].HeaderText = "तपशील";
                    dgvProftandLoss.Columns[1].HeaderText = "रक्कम";
                    dgvProftandLoss.Columns[2].HeaderText = "तपशील";
                    dgvProftandLoss.Columns[3].HeaderText = "रक्कम";
                }
                dgvProftandLoss.Columns[0].Name = "crPerticular";               
                dgvProftandLoss.Columns[0].DataPropertyName = "crPerticular";
                dgvProftandLoss.Columns[0].Width = 50;

                dgvProftandLoss.Columns[1].Name = "crAmount";              
                dgvProftandLoss.Columns[1].DataPropertyName = "crAmount";
                dgvProftandLoss.Columns[1].Width = 50;

                dgvProftandLoss.Columns[2].Name = "drPurticular";                
                dgvProftandLoss.Columns[2].DataPropertyName = "drPurticular";
                dgvProftandLoss.Columns[2].Width = 50;

                dgvProftandLoss.Columns[3].Name = "drAmount";               
                dgvProftandLoss.Columns[3].DataPropertyName = "drAmount";
                dgvProftandLoss.Columns[3].Width = 200;

                dgvProftandLoss.DataSource = dtProfitLoss;
                dgvProftandLoss.Rows[dgvProftandLoss.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                dgvProftandLoss.Rows[dgvProftandLoss.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 12, FontStyle.Bold);
                dgvProftandLoss.ClearSelection();
            }
            catch(Exception ae)
            {
               if (Utility.Langn == "English")
                {
                    MessageBox.Show("While showing Information error occurs" + ae.ToString());
                }
                else
                {
                    MessageBox.Show("माहिती दाखवण्यास त्रुटी येत आहे" + ae.ToString());
                }      
            }
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtprofitAndLoss = new DataTable();
                dtprofitAndLoss = accountBalanceReportController.getProfitLoss(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()));
                bindData(dtprofitAndLoss);
            }
            catch(Exception ae)
            {
                MessageBox.Show("", ae.ToString());
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
                System.Data.DataTable dat = (System.Data.DataTable)(dgvProftandLoss.DataSource);
                dat.TableName = "ProfitAndLossAC";
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
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtprofitAndLoss = new DataTable();
                dtprofitAndLoss = accountBalanceReportController.getProfitLossWithOutTotal(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()));
                Report rpt = new Report();
                crptProfitLoss crReportDocument = new crptProfitLoss();
                //crReportDocument.SetDataSource(dtprofitAndLoss);
                crReportDocument.Database.Tables[0].SetDataSource(dtprofitAndLoss);
                crReportDocument.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                rpt.crystalReportViewer1.ReportSource = crReportDocument;
                rpt.crystalReportViewer1.Refresh();
                rpt.Refresh();
                rpt.Show();
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
    }
}
