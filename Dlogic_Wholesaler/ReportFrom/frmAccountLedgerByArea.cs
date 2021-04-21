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
    public partial class frmAccountLedgerByArea : MetroForm
    {
        public frmAccountLedgerByArea()
        {
            InitializeComponent();
        }
        public void BindComboBoxVillageDetails()
        {

            DataTable dtvillageId = customerController.getVillageDetails();
            Utility.BindComboBoxEmptyDataSelect(cmbVillageArea, dtvillageId, "villageId", "villageName");
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Villagewise Account Pending Report";
                    metroLabel2.Text = "Village Name:";                  
                    btnSms.Text = "SMS";
                    btnExcelReport.Text = "Excel Report";
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
        private void frmAccountLedgerByArea_Load(object sender, EventArgs e)
        {
            BindComboBoxVillageDetails();
            Lang();
        }

        private void cmbVillageArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            long villageId=0;
            if(cmbVillageArea.SelectedIndex==0)
            {
                villageId=0;
            }
            else
            {
                villageId=Convert.ToInt64(cmbVillageArea.SelectedValue);
            }
                   DataTable dtPaymentDue = accountLedgerReportController.getAccountLedgerDetailsByVillage(villageId);
                   if (dtPaymentDue.Rows.Count > 0)
                   {
                       BindAreaWisePaymentDue(dtPaymentDue);
                   }
         
           // dgvAccountLedger.DataSource = dtPaymentDue;
            }
            catch(Exception ae)
            {
                if (Utility.Langn == "English")
                {
                    MessageBox.Show("While showing record error occurs..");
                }
                else
                {
                    MessageBox.Show("रेकोर्ड दाखवण्यास त्रुटी येत आहे..");
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
            long villageId=0;
            if(cmbVillageArea.SelectedIndex==0)
            {
                villageId=0;
            }
            else
            {
                villageId=Convert.ToInt64(cmbVillageArea.SelectedValue);
            }
            DataTable dtPaymentDue = accountLedgerReportController.getAccountLedgerDetailsByVillage(villageId);
            if (dtPaymentDue.Rows.Count > 0)
            {
                BindAreaWisePaymentDue(dtPaymentDue);
            }
          //  dgvAccountLedger.DataSource = dtPaymentDue;
            }
            catch(Exception ae)
            {
                if (Utility.Langn == "English")
                {
                    MessageBox.Show("While showing record error occurs..");
                }
                else
                {
                    MessageBox.Show("रेकोर्ड दाखवण्यास त्रुटी येत आहे..");
                }
            }
        }
        public void BindAreaWisePaymentDue(DataTable dtPaymentDue)
        {
            Double totalCrAmount = 0, totalDrAmount = 0, TotalDue = 0;
            totalCrAmount = Math.Round(Convert.ToDouble(dtPaymentDue.Compute("sum(crAmount)", "")), 2);
            totalDrAmount = Math.Round(Convert.ToDouble(dtPaymentDue.Compute("sum(drAmount)", "")), 2);
            TotalDue = Math.Round(Convert.ToDouble(dtPaymentDue.Compute("sum(dueAmount)", "")), 2);
            DataRow dr = dtPaymentDue.NewRow();
          
            if (Utility.Langn == "English")
            {
                dr["customerMobileNo"] = "Total";
            }
            else
            {
                dr["customerMobileNo"] = "एकूण";
            }
            dr["crAmount"] = totalCrAmount;
            dr["drAmount"] = totalDrAmount;
            dr["dueAmount"] = TotalDue;
            dtPaymentDue.Rows.Add(dr);
            dgvAccountLedger.DataSource = null;
            dgvAccountLedger.AutoGenerateColumns = false;
            dgvAccountLedger.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvAccountLedger.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAccountLedger.Font = new Font("Arial Unicode MS", 11);
            dgvAccountLedger.EnableHeadersVisualStyles = false;
            dgvAccountLedger.ColumnCount = 6;
            if (Utility.Langn == "English")
            {
                dgvAccountLedger.Columns[0].HeaderText = "Village Name";
                dgvAccountLedger.Columns[1].HeaderText = "Customer Name";
                dgvAccountLedger.Columns[2].HeaderText = "Mobile No.";
                dgvAccountLedger.Columns[3].HeaderText = "Total Amount";
                dgvAccountLedger.Columns[4].HeaderText = "CR.Amount";
                dgvAccountLedger.Columns[5].HeaderText = "Due Amount";
            }
            else
            {
                dgvAccountLedger.Columns[0].HeaderText = "गावाचे नाव";
                dgvAccountLedger.Columns[1].HeaderText = "ग्राहकाचे नाव";
                dgvAccountLedger.Columns[2].HeaderText = "मोबाईल नं";
                dgvAccountLedger.Columns[3].HeaderText = "एकूण रक्कम";
                dgvAccountLedger.Columns[4].HeaderText = "जमा रक्कम";
                dgvAccountLedger.Columns[5].HeaderText = "बाकी रक्कम";
            }
            dgvAccountLedger.Columns[0].Name = "villageName";          
            dgvAccountLedger.Columns[0].DataPropertyName = "villageName";
            dgvAccountLedger.Columns[0].Width = 150;

            dgvAccountLedger.Columns[1].Name = "customerName";         
            dgvAccountLedger.Columns[1].DataPropertyName = "customerName";
            dgvAccountLedger.Columns[1].Width = 150;

            dgvAccountLedger.Columns[2].Name = "customerMobileNo";          
            dgvAccountLedger.Columns[2].DataPropertyName = "customerMobileNo";
            dgvAccountLedger.Columns[2].Width = 150;

            dgvAccountLedger.Columns[3].Name = "crAmount";         
            dgvAccountLedger.Columns[3].DataPropertyName = "crAmount";
            dgvAccountLedger.Columns[3].Width = 150;

            dgvAccountLedger.Columns[4].Name = "drAmount";           
            dgvAccountLedger.Columns[4].DataPropertyName = "drAmount";
            dgvAccountLedger.Columns[4].Width = 150;

            dgvAccountLedger.Columns[5].Name = "dueAmount";          
            dgvAccountLedger.Columns[5].DataPropertyName = "dueAmount";
            dgvAccountLedger.Columns[5].Width = 150;
            dgvAccountLedger.DataSource = dtPaymentDue;
            dgvAccountLedger.Rows[dgvAccountLedger.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
            dgvAccountLedger.Rows[dgvAccountLedger.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Black;
            dgvAccountLedger.Rows[dgvAccountLedger.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS",12,FontStyle.Bold);
        }

        private void btnExcelReport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                // Loop over DataTables in DataSet.
                System.Data.DataTable ds = new DataTable();
                foreach (DataGridViewColumn col in dgvAccountLedger.Columns)
                {
                    ds.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvAccountLedger.Rows)
                {
                    DataRow dRow = ds.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    ds.Rows.Add(dRow);
                }              
                if (Utility.Langn == "English")
                {
                    ds.TableName = "Villagewise Account Report";
                }
                else
                {
                    ds.TableName = "गावानुसार खाते उधारी रिपोर्ट";
                }
                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                //Create Excel Sheets
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);

                xlWorksheet.Name = ds.TableName;

                for (int j = 1; j < ds.Columns.Count + 1; j++)
                {
                    ExcelApp.Cells[1, j] = ds.Columns[j - 1].ColumnName;
                }

                // Storing Each row and column value to excel sheet
                for (int k = 0; k < ds.Rows.Count; k++)
                {
                    for (int l = 0; l < ds.Columns.Count; l++)
                    {
                        ExcelApp.Cells[k + 2, l + 1] =
                        ds.Rows[k].ItemArray[l].ToString();
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

        private void frmAccountLedgerByArea_KeyDown(object sender, KeyEventArgs e)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgvAccountLedger.DataSource;
                Report rpt = new Report();
                crptAccountLedgerByArea crReportDocument = new crptAccountLedgerByArea();
               // crReportDocument.SetDataSource(dt);
                crReportDocument.Database.Tables[0].SetDataSource(dt);
                crReportDocument.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                rpt.crystalReportViewer1.ReportSource = crReportDocument;
                rpt.crystalReportViewer1.Refresh();
                rpt.Refresh();
                rpt.Show();
            }
            catch (Exception ae)
            {               
                if (Utility.Langn == "English")
                {
                    MessageBox.Show("While opening report error occurs" + ae.ToString());
                }
                else
                {
                    MessageBox.Show("रिपोर्ट उघडण्यास त्रुटी येत आहे" + ae.ToString());
                }
            }
        }
        private void btnSms_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Cursor.Current = Cursors.WaitCursor;
            //    DataTable dtAccountLedger = Utility.dataGridToDataTable(dgvAccountLedger);
            //    dtAccountLedger.Rows.RemoveAt(dtAccountLedger.Rows.Count - 1);
            //   int i= SMSUtility.SMSSendAllDue(dtAccountLedger, 0);
            //   MessageBox.Show(i+"- send out of sms-"+dtAccountLedger.Rows.Count);
            //    Cursor.Current = Cursors.Default;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
    }
}
