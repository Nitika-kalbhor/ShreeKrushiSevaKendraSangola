using DataAccessLayer.controller;
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
using Dlogic_Wholesaler.ReportFroms;

namespace Dlogic_Wholesaler.ReportFrom_
{
    public partial class frmCashBookReport : MetroForm
    {
        public frmCashBookReport()
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
                    lblHerader.Text = "Cash Book";
                    gbsarch.Text = "Search";
                    metroLabel1.Text = "Date:";
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

        public void BindEmployeeGrid()
        {
            try
            {
                dgvCashBook.DataSource = null;
                DataTable dtCashbook = accountReportController.getcashBookReports(Convert.ToDateTime(dtpDate.Value.ToShortDateString()));

                dgvCashBook.AutoGenerateColumns = false;
                dgvCashBook.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvCashBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvCashBook.Font = new Font("Arial Unicode MS", 13);

                dgvCashBook.EnableHeadersVisualStyles = false;

                dgvCashBook.ColumnCount = 5;
                if (Utility.Langn == "English")
                {
                    dgvCashBook.Columns[0].HeaderText = "accountId";
                    dgvCashBook.Columns[1].HeaderText = "Date";
                    dgvCashBook.Columns[2].HeaderText = "Naration";
                    dgvCashBook.Columns[3].HeaderText = "DR.Amount";
                    dgvCashBook.Columns[4].HeaderText = "CR.Amount";
                }
                else
                {
                    dgvCashBook.Columns[0].HeaderText = "accountId";
                    dgvCashBook.Columns[1].HeaderText = "दिनांक";
                    dgvCashBook.Columns[2].HeaderText = "तपशील";
                    dgvCashBook.Columns[3].HeaderText = "नावे रक्कम";
                    dgvCashBook.Columns[4].HeaderText = "जमा रक्कम";
                }

                dgvCashBook.Columns[0].Name = "accountId";             
                dgvCashBook.Columns[0].DataPropertyName = "accountId";
                dgvCashBook.Columns[0].Visible = false;

                dgvCashBook.Columns[1].Name = "transactionDate";               
                dgvCashBook.Columns[1].DataPropertyName = "transactionDate";
                dgvCashBook.Columns[1].Width = 150;

                dgvCashBook.Columns[2].Name = "naration";               
                dgvCashBook.Columns[2].DataPropertyName = "naration";
                dgvCashBook.Columns[2].Width = 450;

                dgvCashBook.Columns[3].Name = "crAmount";             
                dgvCashBook.Columns[3].DataPropertyName = "crAmount";
                dgvCashBook.Columns[3].Width = 150;

                dgvCashBook.Columns[4].Name = "drAmount";               
                dgvCashBook.Columns[4].DataPropertyName = "drAmount";
                dgvCashBook.Columns[4].Width = 150;

                dgvCashBook.DataSource = dtCashbook;
                if (dgvCashBook.Rows.Count > 0)
                {
                    dgvCashBook.Rows[0].DefaultCellStyle.BackColor = Color.Gold;
                    dgvCashBook.Rows[0].DefaultCellStyle.Font = new Font("Arial Unicode MS", 13);

                    dgvCashBook.Rows[dgvCashBook.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                    dgvCashBook.Rows[dgvCashBook.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 13);
                }

            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }

        }
        private void frmCashBookReport_Load(object sender, EventArgs e)
        {
            try
            {
                BindEmployeeGrid();
                Lang();
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
        try {
                BindEmployeeGrid();
            }
            catch(Exception ae)
            {
                throw ae;
            }

        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BindEmployeeGrid();
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }

        private void frmCashBookReport_KeyDown(object sender, KeyEventArgs e)
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
                DataTable dt = (DataTable)dgvCashBook.DataSource;
                Report rp = new Report();
                crpCashReports crReportDocument = new crpCashReports();
                crReportDocument.SetDataSource(dt);
              //  crReportDocument.Database.Tables[0].SetDataSource(dt);
                //crReportDocument.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                rp.crystalReportViewer1.ReportSource = crReportDocument;
                rp.crystalReportViewer1.Refresh();
                rp.Refresh();
                rp.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gbsarch_Enter(object sender, EventArgs e)
        {

        }
    }
}
