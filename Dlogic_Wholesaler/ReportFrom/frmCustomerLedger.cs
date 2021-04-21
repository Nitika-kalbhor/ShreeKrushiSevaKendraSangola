
using Dlogic_Wholesaler.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;

namespace Dlogic_Wholesaler.Forms
{
    public partial class frmCustomerLedger : MetroForm
    {
        public frmCustomerLedger()
        {
            InitializeComponent();
        }
        public static System.Data.DataTable dtAccount = new System.Data.DataTable();
        public static System.Data.DataTable dtAllAccount = new System.Data.DataTable();
        public static System.Data.DataTable dtFormLoad = new System.Data.DataTable();
        Int32 rowToDelete;
        public int rowIndex = 0;
        public void bindAllAccount(System.Data.DataTable dtAccountInfo)
        {
            try
            {
                dgvCustomerLedger.Font = new System.Drawing.Font("Tahoma", 12);
                    dgvCustomerLedger.DataSource = null;
                    dgvCustomerLedger.AutoGenerateColumns = false;
                    dgvCustomerLedger.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    dgvCustomerLedger.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvCustomerLedger.EnableHeadersVisualStyles = false;

                    dgvCustomerLedger.ColumnCount = 7;
                    dgvCustomerLedger.Columns[0].Name = "AccountName";
                    dgvCustomerLedger.Columns[0].HeaderText = "ग्राहकचे नांव";
                    dgvCustomerLedger.Columns[0].DataPropertyName = "AccountName";
                    dgvCustomerLedger.Columns[0].Width = 250;

                    dgvCustomerLedger.Columns[1].Width = 250;
                    dgvCustomerLedger.Columns[1].Name = "Cust_Addr";
                    dgvCustomerLedger.Columns[1].HeaderText = "पत्ता";
                    dgvCustomerLedger.Columns[1].DataPropertyName = "Cust_Addr";
                    //   dgvCustomerLedger.Columns[].Width = 250;

                    dgvCustomerLedger.Columns[2].Name = "MobNo";
                    dgvCustomerLedger.Columns[2].HeaderText = "मोबाईल नं";
                    dgvCustomerLedger.Columns[2].DataPropertyName = "MobNo";
                    dgvCustomerLedger.Columns[2].Width = 150;

                    dgvCustomerLedger.Columns[3].Name = "orjName";
                    dgvCustomerLedger.Columns[3].HeaderText = "कंपनीचे नाव";
                    dgvCustomerLedger.Columns[3].DataPropertyName = "orjName";
                    dgvCustomerLedger.Columns[3].Width = 150;

                    dgvCustomerLedger.Columns[3].Name = "TotalAmount";
                    dgvCustomerLedger.Columns[3].HeaderText = "एकूण  रक्कम";
                    dgvCustomerLedger.Columns[3].DataPropertyName = "TotalAmount";
                    dgvCustomerLedger.Columns[3].Width = 150;

                    dgvCustomerLedger.Columns[4].Name = "PaidAmount";
                    dgvCustomerLedger.Columns[4].HeaderText = "एकूण जमा रक्कम";
                    dgvCustomerLedger.Columns[4].DataPropertyName = "PaidAmount";
                    dgvCustomerLedger.Columns[4].Width = 150;


                    dgvCustomerLedger.Columns[5].Width = 150;
                    dgvCustomerLedger.Columns[5].Name = "dueAmount";
                    dgvCustomerLedger.Columns[5].HeaderText = "एकूण बाकी रक्कम";
                    dgvCustomerLedger.Columns[5].DataPropertyName = "dueAmount";

                    dgvCustomerLedger.Columns[6].Name = "AccountID";
                    dgvCustomerLedger.Columns[6].HeaderText = "AccountID";
                    dgvCustomerLedger.Columns[6].DataPropertyName = "AccountID";
                    dgvCustomerLedger.Columns[6].Visible = false;
                    BindingSource _source = new BindingSource();
                    _source.DataSource = dtAccountInfo;
                    dgvCustomerLedger.DataSource = _source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GeCusromerAddress()
        {
            //System.Data.DataTable GeCusromerAddress = new JewelleryBL().GetCusromerAddress();
          //  Utility.BindComboBoxDataSelect(cmbSeachName, GeCusromerAddress, "id", "Cust_Addr");
        }
        void Lang()
        {
            try
            {
                 all.Text = "All"; all.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    label3.Text = "Customer Name"; label3.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    label10.Text = "Address"; label10.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    label2.Text = "Or"; label2.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    label1.Text = "Mobile No"; label1.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    label4.Text = "Customer Ledger Report"; label4.Font = new System.Drawing.Font("Tahoma", 15);
                    btnShow.Text = "Show"; btnShow.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                    btneExcelReport.Text = "Excel Report"; btneExcelReport.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                  

             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmCustomerLedger_Load(object sender, EventArgs e)
        {
            try
            {
               //Lang();
               // GeCusromerAddress();
               // if(FrmIndex.english=="Marathi")
               // {
               //     btneExcelReport.Text = "एक्सेल रिपोर्ट";
               //     btneExcelReport.Font = new System.Drawing.Font("Tahoma", 12, FontStyle.Bold);
               // }
               // dtAllAccount = new JewelleryBL().Usp_getCustomerLadger();
               // dtAccount = new JewelleryBL().Usp_getCustomerLadger();

                //var query = from accountTable in dtAllAccount.AsEnumerable()
                //            where accountTable.Field<Double>("dueAmount") >= 0
                            
                //                select accountTable;
                //  if (query.Count() > 0)
                //  {
                //      dtAllAccount = query.CopyToDataTable<DataRow>();
                //  }
              //  All.Checked = true;
                double PaidAmount = 0; double TotalAmount = 0; double dueAmount = 0;
                for (int i = 0; i < dtAllAccount.Rows.Count; ++i)
                {
                    PaidAmount += Convert.ToDouble(dtAllAccount.Rows[i]["PaidAmount"]);
                    TotalAmount += Convert.ToDouble(dtAllAccount.Rows[i]["TotalAmount"]);
                    dueAmount += Convert.ToDouble(dtAllAccount.Rows[i]["dueAmount"]);

                }
                DataRow dr = dtAllAccount.NewRow();
                dr["MobNo"] = "एकून रक्कम";
                dr["TotalAmount"] = TotalAmount;
                dr["PaidAmount"] = PaidAmount;
                dr["dueAmount"] = dueAmount;
                dtAllAccount.Rows.Add(dr);
                dtFormLoad = dtAllAccount;
                dtAccount = dtAllAccount;
                bindAllAccount(dtAllAccount); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCustomerLedger_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvCustomerLedger.Rows)
                {
                    string RowType = row.Cells["MobNo"].Value.ToString();


                    if (RowType == "एकून रक्कम")
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 14, FontStyle.Bold);
                    }


                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
        private void btneExcelReport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

               
                
                    Sheets xlSheets = null;
                    Worksheet xlWorksheet = null;
                    //Create Excel Sheets
                    xlSheets = ExcelApp.Sheets;
                    xlWorksheet = (Worksheet)xlSheets.Add(xlSheets[1],
                                   Type.Missing, Type.Missing, Type.Missing);

                    dtAccount.TableName = "खाते उधारी(Account Ledger)";
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
                
                ((Worksheet)ExcelApp.ActiveWorkbook.Sheets[ExcelApp.ActiveWorkbook.Sheets.Count]).Delete();
                ExcelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSeachName_TextChanged(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dgvCustomerLedger.Rows)
            //{
            //    string s = row.Cells[1].Value.ToString();

            //    if (!s.StartsWith(txtSeachName.Text, true, null))
            //    {
            //        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvCustomerLedger.DataSource];
            //        currencyManager1.SuspendBinding();
            //        row.Visible = false;
            //        currencyManager1.ResumeBinding();
            //        dgvCustomerLedger.Visible = true;
            //    }
            //    else
            //        row.Visible = true;
            //}
            //if (txtSeachName.Text == string.Empty)
            //    {
            //        bindAllAccount(dtFormLoad);
            //    }
          
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
              
              //  new JewelleryBL().Usp_getCustomerLadger();
                dtAccount = new System.Data.DataTable();
                    var query = from Account in dtAccount.AsEnumerable()
                                where Account.Field<String>("Cust_Addr") == cmbSeachName.Text ||
                                Account.Field<String>("MobNo") == txtSeachName.Text
                                select Account;
                    if (query.Count() > 0)
                    {
                        dtAccount = query.CopyToDataTable<DataRow>();
                        double PaidAmount = 0; double TotalAmount = 0; double dueAmount = 0;
                        for (int i = 0; i < dtAccount.Rows.Count; ++i)
                        {
                            PaidAmount += Convert.ToDouble(dtAccount.Rows[i]["PaidAmount"]);
                            TotalAmount += Convert.ToDouble(dtAccount.Rows[i]["TotalAmount"]);
                            dueAmount += Convert.ToDouble(dtAccount.Rows[i]["dueAmount"]);

                        }
                        DataRow dr = dtAccount.NewRow();
                        dr["MobNo"] = "एकून रक्कम";
                        dr["TotalAmount"] = TotalAmount;
                        dr["PaidAmount"] = PaidAmount;
                        dr["dueAmount"] = dueAmount;
                        dtAccount.Rows.Add(dr);

                        bindAllAccount(dtAccount);
                    }
                    else
                    {
                        dtAccount = null;
                        bindAllAccount(dtAccount);
                    }

                    all.Checked = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCustomerLedger_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }

        private void all_CheckedChanged(object sender, EventArgs e)
        {
            if(all.Checked==true)
            {
                frmCustomerLedger_Load(sender, e);
            }
        }

        private void txtcustomer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (txtcustomer.Text == string.Empty)
                //{
                //    bindAllAccount(dtFormLoad);
                //}
                foreach (DataGridViewRow row in dgvCustomerLedger.Rows)
                {
                    string s = row.Cells[0].Value.ToString();

                    if (!s.StartsWith(txtcustomer.Text, true, null))
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvCustomerLedger.DataSource];
                        currencyManager1.SuspendBinding();
                        row.Visible = false;
                        currencyManager1.ResumeBinding();
                        dgvCustomerLedger.Visible = true;
                    }
                    else
                        row.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCustomerLedger_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.dgvCustomerLedger.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.contextMenuStrip1.Show(this.dgvCustomerLedger, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rowToDelete = dgvCustomerLedger.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            long accountid = Convert.ToInt64(dgvCustomerLedger.Rows[rowIndex].Cells["AccountID"].Value);
           DialogResult ShowReport = MessageBox.Show("तु्म्हाला डिलीट करायचं आहेका ....?", "खाते", MessageBoxButtons.YesNo);          
             if (ShowReport == DialogResult.Yes)
             {
                 //new JewelleryBL().Usp_DeleteAccountCustomer(accountid);
                 int s = 0;
               if (s > 0)
               {
                   MessageBox.Show("रेकॉर्ड  यशस्वीरित्या डिलीट झाले....!");
                   dgvCustomerLedger.Rows.RemoveAt(rowToDelete);
                   dgvCustomerLedger.ClearSelection();
               }
               else
               {
                   MessageBox.Show("हा रेकॉर्ड   डिलीट  केला जाणार नाही कारण बिला मध्ये वापरलेले आहे ....!");
               }
             }
             else
             {
                 ShowReport = DialogResult.No;
             }
           
          

        }
    }
}
