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
     // TO AUTOFORMAT THE SHEET.
namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class frmBankReport : MetroForm
    {
        public frmBankReport()
        {
            InitializeComponent();
        }
        private void BindBank()
        {
            Utility.BindComboBoxDataSelect(cmbBank, accountDetailsController.GetAccountWisePaymentDue(0, "BankBind", Utility.FinancilaYearId), "accountId", "accountName");
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Bank Report";
                    lblFrmDate.Text = "From Date";
                    lblToDate.Text = "To Date";
                    lblPayment.Text = "Bank";
                    btneExcelReport.Text = "Excel Report";
                    btnShow.Text = "Show";

                    dgvBankDeposite.Columns[0].HeaderText = "Bank";
                     dgvBankDeposite.Columns[1].HeaderText = "Date";
                    dgvBankDeposite.Columns[2].HeaderText = "Naration";
                    dgvBankDeposite.Columns[3].HeaderText = "Withdraw";
                    dgvBankDeposite.Columns[4].HeaderText = "Deposit";
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void frmBankReport_Load(object sender, EventArgs e)
        {
            BindBank();
            dtpfrmDate.Value = Utility.startDate(System.DateTime.Now);
            Lang();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                long bankId=0;
                if (cmbBank.SelectedIndex == 0)
                {
                   bankId=0;
                }
                else
                {
                    bankId=Convert.ToInt64(cmbBank.SelectedValue);
                }

                DataTable dt = accountDetailsController.getBankTransactionforReport(bankId, Convert.ToDateTime(dtpfrmDate.Value.ToShortDateString()), Convert.ToDateTime(dtpTodate.Value.ToShortDateString()));
                    // dgvBankDeposite.DataSource = dt;
             
                    subtot(dt);
                    //    }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }
        private void subtot(DataTable dt)
        {
            double TotalCrAmount = 0, TotalDramount = 0;
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                if (dt.Rows[i]["crAmount"] != null)
                {
                    TotalCrAmount += Convert.ToDouble(dt.Rows[i]["crAmount"]);
                }
                if (dt.Rows[i]["drAmount"] != null)
                {
                    TotalDramount += Convert.ToDouble(dt.Rows[i]["drAmount"]);
                }
            }
            DataRow dr = dt.NewRow();
           if (Utility.Langn == "English")
            {
                dr["naration"] = "Total Amount";
            }
            else
            {
                dr["naration"] = "एकूण रक्कम";
            }
            dr["crAmount"] = TotalCrAmount;
            dr["drAmount"] = TotalDramount;
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1["naration"] = "Closing Balance";
            dr1["crAmount"] = TotalCrAmount - TotalDramount;
            dr1["drAmount"] = 0;
            dt.Rows.Add(dr1);
            dgvBankDeposite.DataSource = dt;

            if (dgvBankDeposite.Rows.Count > 0)
            {
                dgvBankDeposite.Rows[0].DefaultCellStyle.BackColor = Color.Gold;
                dgvBankDeposite.Rows[0].DefaultCellStyle.Font = new Font("Arial Unicode MS", 13);
                dgvBankDeposite.Rows[dgvBankDeposite.Rows.Count - 2].DefaultCellStyle.BackColor = Color.LightGray;
                dgvBankDeposite.Rows[dgvBankDeposite.Rows.Count - 2].DefaultCellStyle.Font = new Font("Arial Unicode MS", 13);
                dgvBankDeposite.Rows[dgvBankDeposite.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                dgvBankDeposite.Rows[dgvBankDeposite.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 13);
            }
        }
        private void btneExcelReport_Click(object sender, EventArgs e)
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
                DataTable dtAccount = new DataTable();
                foreach (DataGridViewColumn col in dgvBankDeposite.Columns)
                {
                    dtAccount.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvBankDeposite.Rows)
                {
                    DataRow dRow = dtAccount.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtAccount.Rows.Add(dRow);
                }

                dtAccount.TableName = "Bank Report";
                xlWorksheet.Name = dtAccount.TableName;
          
                for (int j = 1; j < dtAccount.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = dtAccount.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < dtAccount.Rows.Count; k++)
                {
                    for (int l = 0; l < dtAccount.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        dtAccount.Rows[k].ItemArray[l].ToString();
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

        private void frmBankReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                try
                {

                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
      
    }
}
