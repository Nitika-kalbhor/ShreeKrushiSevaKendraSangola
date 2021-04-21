using DataAccessLayer.controller;
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
    public partial class frmDayBookNew : MetroFramework.Forms.MetroForm
    {
        public frmDayBookNew()
        {
            InitializeComponent();
        }

        private void frmDayBookNew_Load(object sender, EventArgs e)
        {
            try
            {
                BindEmployeeGrid();
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public void BindEmployeeGrid()
        {
            try
            {
                dgvCashBook.DataSource = null;
                DataTable dtCashbook = accountReportController.getDayBookReports(Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()));

                dgvCashBook.AutoGenerateColumns = false;
                dgvCashBook.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvCashBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvCashBook.Font = new Font("Arial Unicode MS", 13);

                dgvCashBook.EnableHeadersVisualStyles = false;
                dgvCashBook.ColumnCount = 5;
                dgvCashBook.Columns[0].Name = "accountId";
                dgvCashBook.Columns[0].HeaderText = "accountId";
                dgvCashBook.Columns[0].DataPropertyName = "accountId";
                dgvCashBook.Columns[0].Visible = false;

                dgvCashBook.Columns[1].Name = "transactionDate";
                dgvCashBook.Columns[1].HeaderText = "दिनांक";
                dgvCashBook.Columns[1].DataPropertyName = "transactionDate";
                dgvCashBook.Columns[1].Width = 150;

                dgvCashBook.Columns[2].Name = "naration";
                dgvCashBook.Columns[2].HeaderText = "तपशील";
                dgvCashBook.Columns[2].DataPropertyName = "naration";
                dgvCashBook.Columns[2].Width = 450;

                dgvCashBook.Columns[3].Name = "crAmount";
                dgvCashBook.Columns[3].HeaderText = "नावे रक्कम";
                dgvCashBook.Columns[3].DataPropertyName = "crAmount";
                dgvCashBook.Columns[3].Width = 150;

                dgvCashBook.Columns[4].Name = "drAmount";
                dgvCashBook.Columns[4].HeaderText = "जमा रक्कम";
                dgvCashBook.Columns[4].DataPropertyName = "drAmount";
                dgvCashBook.Columns[4].Width = 150;

                dgvCashBook.DataSource = dtCashbook;


            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }

        }
        private void frmDayBookNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BindEmployeeGrid();
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BindEmployeeGrid();
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
    }
}
