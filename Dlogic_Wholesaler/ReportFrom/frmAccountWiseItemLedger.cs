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
using DataAccessLayer.models;
using DataAccessLayer.controller;

namespace Dlogic_Wholesaler.ReportFroms
{
    public partial class frmAccountWiseItemLedger : MetroForm
    {
        public frmAccountWiseItemLedger()
        {
            InitializeComponent();
            cmbMainCategory.SelectedIndex = 1;
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Accountwise Bill (Party Statement)";
                    chbSale.Text = "Sale Discount(%)";
                    rbCustomer.Text = "Customer";
                    rbDealer.Text = "Dealer";
                    chkSaleReturn.Text = "Sale Return";
                    chkPurchaseReturn.Text = "Purchase Return";
                    label5.Text = "Category Name:";
                    metroLabel2.Text = "Account Name:";
                    label1.Text = "From Date:";
                    label2.Text = "To Date:";
                    btnShow.Text = "Show";
                    btnExcel.Text = "Exel Report";
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable dt = new DataTable();
                if (chbSale.Checked == false)
                {
                    if (rbCustomer.Checked == true && chkPurchaseReturn.Checked == false && chkSaleReturn.Checked == false)
                    {
                        dt = saleReportController.getAccountStatement(Convert.ToInt64(cmbAccountName.SelectedValue), Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, 1, cmbMainCategory.Text.Trim());
                    }
                    if (rbDealer.Checked == true && chkPurchaseReturn.Checked == false && chkSaleReturn.Checked == false)
                    {
                        dt = saleReportController.getAccountStatement(Convert.ToInt64(cmbAccountName.SelectedValue), Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, 2, cmbMainCategory.Text.Trim());

                    }
                    if (rbCustomer.Checked == true && chkPurchaseReturn.Checked == false && chkSaleReturn.Checked == true)
                    {
                        dt = saleReportController.getAccountStatement(Convert.ToInt64(cmbAccountName.SelectedValue), Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, 3, cmbMainCategory.Text.Trim());
                    }
                    if (rbDealer.Checked == true && chkPurchaseReturn.Checked == true && chkSaleReturn.Checked == false)
                    {
                        dt = saleReportController.getAccountStatement(Convert.ToInt64(cmbAccountName.SelectedValue), Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, 4, cmbMainCategory.Text.Trim());

                    }
                }
                if(chbSale.Checked==true)
                {
                    if (rbCustomer.Checked == true && chkPurchaseReturn.Checked == false && chkSaleReturn.Checked == false)
                    {
                        dt = saleReportController.getAccountStatement(Convert.ToInt64(cmbAccountName.SelectedValue), Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId, 5,cmbMainCategory.Text.Trim());
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    DataTable dtAccountStatement = SubTot(dt);
                    bindSaleStatement(dtAccountStatement);
                }
                else
                {
                    DataTable dtAccountStatement = new DataTable();
                    bindSaleStatement(dtAccountStatement);
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public DataTable SubTot(DataTable lstSaleBill)
        {
            try
            {
                Double totalIGSTAmt = 0.0, totalCGSTAmt = 0.0, totalSGSTAmt = 0.0, totaldiscount = 0.0, totalAmount = 0.0,a=0.0,b=0.0,c=0.0,d=0.0,e=0.0;
                if (rbDealer.Checked == true && chkPurchaseReturn.Checked == false && chkSaleReturn.Checked == false)
                {
                    for (int i = 0; i < lstSaleBill.Rows.Count; i++)
                    {
                        if (lstSaleBill.Rows[i]["saleRate"].ToString() == "बिल रक्कम")
                        {

                            if (Double.TryParse(lstSaleBill.Rows[i]["totalAmount"].ToString(), out e))
                            {
                                totalAmount += Convert.ToDouble(lstSaleBill.Rows[i]["totalAmount"].ToString());
                            }
                        }
                        if (lstSaleBill.Rows[i]["saleRate"].ToString() == "एकूण रक्कम")
                        {

                            if (Double.TryParse(lstSaleBill.Rows[i]["IGSTAmt"].ToString(), out a))
                            {
                                totalIGSTAmt += Convert.ToDouble(lstSaleBill.Rows[i]["IGSTAmt"].ToString());
                            }
                            if (Double.TryParse(lstSaleBill.Rows[i]["CGSTAmt"].ToString(), out b))
                            {
                                totalCGSTAmt += Convert.ToDouble(lstSaleBill.Rows[i]["CGSTAmt"].ToString());
                            }
                            if (Double.TryParse(lstSaleBill.Rows[i]["SGSTAmt"].ToString(), out c))
                            {
                                totalSGSTAmt += Convert.ToDouble(lstSaleBill.Rows[i]["SGSTAmt"].ToString());
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < lstSaleBill.Rows.Count; i++)
                    {
                        if (lstSaleBill.Rows[i]["saleRate"].ToString() == "रक्कम")
                        {

                            if (Double.TryParse(lstSaleBill.Rows[i]["totalAmount"].ToString(), out e))
                            {
                                totalAmount += Convert.ToDouble(lstSaleBill.Rows[i]["totalAmount"].ToString());
                            }
                        }
                        if (lstSaleBill.Rows[i]["saleRate"].ToString() == "एकूण रक्कम")
                        {

                            if (Double.TryParse(lstSaleBill.Rows[i]["IGSTAmt"].ToString(), out a))
                            {
                                totalIGSTAmt += Convert.ToDouble(lstSaleBill.Rows[i]["IGSTAmt"].ToString());
                            }
                            if (Double.TryParse(lstSaleBill.Rows[i]["CGSTAmt"].ToString(), out b))
                            {
                                totalCGSTAmt += Convert.ToDouble(lstSaleBill.Rows[i]["CGSTAmt"].ToString());
                            }
                            if (Double.TryParse(lstSaleBill.Rows[i]["SGSTAmt"].ToString(), out c))
                            {
                                totalSGSTAmt += Convert.ToDouble(lstSaleBill.Rows[i]["SGSTAmt"].ToString());
                            }
                        }
                    }
                }
                DataRow dr = lstSaleBill.NewRow();
                dr["itemName"] = "Total Amount";
                dr["IGST"] = "Total IGST";
                dr["IGSTAmt"] = Math.Round(totalIGSTAmt, 2).ToString();
                dr["CGST"] = "Total CGST";
                dr["CGSTAmt"] = Math.Round(totalCGSTAmt, 2).ToString();
                dr["SGST"] = "Total SGST";
                dr["SGSTAmt"] = Math.Round(totalSGSTAmt, 2).ToString();
                dr["saleRate"] = "Total Amount";
                dr["totalAmount"] = Math.Round(totalAmount, 2).ToString();
               // dr["discount"] = Math.Round(totaldiscount, 2).ToString();
                //dr["billNo"] = "Grandtotal";
                lstSaleBill.Rows.Add(dr);
                return lstSaleBill;
            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.ToString());
                throw ae;
            }

        }
        public void bindSaleStatement(DataTable dtsale)
        {
            try
            {
                dgvAccountStatement.DataSource = null;
                dgvAccountStatement.AutoGenerateColumns = false;
                dgvAccountStatement.ColumnCount = 16;
                if (Utility.Langn == "English")
                {
                    dgvAccountStatement.Columns[0].HeaderText = "Item Name";
                    dgvAccountStatement.Columns[1].HeaderText = "Unit By";
                    dgvAccountStatement.Columns[2].HeaderText = "HSN Code";
                    dgvAccountStatement.Columns[3].HeaderText = "Batch No";
                    dgvAccountStatement.Columns[4].HeaderText = "Qty";
                    dgvAccountStatement.Columns[5].HeaderText = "Free Qty";
                    dgvAccountStatement.Columns[6].HeaderText = "Rate";
                    dgvAccountStatement.Columns[7].HeaderText = "Discount %";
                    dgvAccountStatement.Columns[9].HeaderText = "IGST Amt";
                    dgvAccountStatement.Columns[11].HeaderText = "CGST Amt";
                    dgvAccountStatement.Columns[13].HeaderText = "SGST Amt";
                    dgvAccountStatement.Columns[14].HeaderText = "Amount";
                }
                else
                {
                    dgvAccountStatement.Columns[0].HeaderText = "आयटमच नाव";
                    dgvAccountStatement.Columns[1].HeaderText = "पॅकिंग";
                    dgvAccountStatement.Columns[2].HeaderText = "HSN Code";
                    dgvAccountStatement.Columns[3].HeaderText = "बैच नंबर";
                    dgvAccountStatement.Columns[4].HeaderText = "नग";
                    dgvAccountStatement.Columns[5].HeaderText = "फ्री नग";
                    dgvAccountStatement.Columns[6].HeaderText = "दर";
                    dgvAccountStatement.Columns[7].HeaderText = "सवलत %";
                    dgvAccountStatement.Columns[9].HeaderText = "IGST रक्कम";
                    dgvAccountStatement.Columns[11].HeaderText = "CGST रक्कम";
                    dgvAccountStatement.Columns[13].HeaderText = "SGST रक्कम";
                    dgvAccountStatement.Columns[14].HeaderText = "रक्कम";
                }
                dgvAccountStatement.Columns[0].Name = "itemName";                
                dgvAccountStatement.Columns[0].DataPropertyName = "itemName";

                dgvAccountStatement.Columns[1].Name = "weightIn";              
                dgvAccountStatement.Columns[1].DataPropertyName = "weightIn";

                dgvAccountStatement.Columns[2].Name = "HNSCode";                
                dgvAccountStatement.Columns[2].DataPropertyName = "HNSCode";
                //  dgvAccountStatement.Columns[0].Width = 180;

                dgvAccountStatement.Columns[3].Name = "batchNo";               
                dgvAccountStatement.Columns[3].DataPropertyName = "batchNo";
                //     dgvAccountStatement.Columns[1].Width = 180;

                dgvAccountStatement.Columns[4].Name = "Quantity";               
                dgvAccountStatement.Columns[4].DataPropertyName = "Quantity";
                //    dgvAccountStatement.Columns[2].Width = 180;

                dgvAccountStatement.Columns[5].Name = "freeQuantity";              
                dgvAccountStatement.Columns[5].DataPropertyName = "freeQuantity";
                dgvAccountStatement.Columns[5].Visible = false;
               
                //          dgvAccountStatement.Columns[4].Width = 150;

                dgvAccountStatement.Columns[6].Name = "saleRate";               
                dgvAccountStatement.Columns[6].DataPropertyName = "saleRate";

                dgvAccountStatement.Columns[7].Name = "discountPer";              
                dgvAccountStatement.Columns[7].DataPropertyName = "discountPer";

                dgvAccountStatement.Columns[8].Name = "IGST";
                dgvAccountStatement.Columns[8].HeaderText = "IGST(%)";
                dgvAccountStatement.Columns[8].DataPropertyName = "IGST";
                dgvAccountStatement.Columns[8].Visible = false;

                dgvAccountStatement.Columns[9].Name = "IGSTAmt";               
                dgvAccountStatement.Columns[9].DataPropertyName = "IGSTAmt";
                dgvAccountStatement.Columns[9].Visible = false;

                dgvAccountStatement.Columns[10].Name = "CGST";
                dgvAccountStatement.Columns[10].HeaderText = "CGST(%)";
                dgvAccountStatement.Columns[10].DataPropertyName = "CGST";

                dgvAccountStatement.Columns[11].Name = "CGSTAmt";             
                dgvAccountStatement.Columns[11].DataPropertyName = "CGSTAmt";

                dgvAccountStatement.Columns[12].Name = "SGST";
                dgvAccountStatement.Columns[12].HeaderText = "SGST(%)";
                dgvAccountStatement.Columns[12].DataPropertyName = "SGST";

                dgvAccountStatement.Columns[13].Name = "SGSTAmt";              
                dgvAccountStatement.Columns[13].DataPropertyName = "SGSTAmt";

               
               
                dgvAccountStatement.Columns[14].Name = "totalAmount";              
                dgvAccountStatement.Columns[14].DataPropertyName = "totalAmount";

                dgvAccountStatement.Columns[15].Name = "billNo";
                dgvAccountStatement.Columns[15].HeaderText = "billNo";
                dgvAccountStatement.Columns[15].DataPropertyName = "billNo";
                dgvAccountStatement.Columns[15].Visible = false;
                    dgvAccountStatement.DataSource = dtsale;
                   dgvAccountStatement.ClearSelection();

                if(dgvAccountStatement.Rows.Count>0)
                {
                    dgvAccountStatement.Rows[dgvAccountStatement.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                    dgvAccountStatement.Rows[dgvAccountStatement.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial Unicode MS", 14, FontStyle.Bold);
                }
            }
            catch(Exception ax)
            {
                MessageBox.Show(ax.Message);
            }
        }
        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCustomer.Checked)
                {
                    rbDealer.Checked = false;
                    dgvAccountStatement.DataSource = null;
                    System.Data.DataTable dtgetDealerName = customerController.getCustomerDetails();
                    Utility.BindComboBoxDataSelect(cmbAccountName, dtgetDealerName, "customerId", "customerName");

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
                    dgvAccountStatement.DataSource = null;
                    chbSale.Checked = false;
                    System.Data.DataTable dtgetDealerName = DealerController.getDealerDetails();
                    Utility.BindComboBoxDataSelect(cmbAccountName, dtgetDealerName, "dealerId", "dealerFirmName");


                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dgvAccountStatement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            //try
            //{
            //    string RowType1 = "", RowType2 = "";
            //    foreach (DataGridViewRow row in dgvAccountStatement.Rows)
            //    {

            //        if (row.Cells["billNo"].Value != null)
            //        {
            //            RowType1 = row.Cells["billNo"].Value.ToString();
            //            RowType2 = row.Cells["billNo"].Value.ToString();
            //            if (RowType1 == "Amount")
            //            {
            //                row.DefaultCellStyle.BackColor = Color.Yellow;
            //                row.DefaultCellStyle.ForeColor = Color.Black;
            //                row.DefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
            //            }
            //            if (RowType2 == "bill12")
            //            {

            //                row.DefaultCellStyle.BackColor = Color.White;
            //                row.DefaultCellStyle.ForeColor = Color.Black;
            //                row.DefaultCellStyle.Font = new Font("Arial Unicode MS", 10);

            //            }

            //            if (RowType1 == "Grandtotal")
            //            {
            //                row.DefaultCellStyle.BackColor = Color.Wheat;
            //                row.DefaultCellStyle.ForeColor = Color.Black;
            //                row.DefaultCellStyle.Font = new Font("Arial Unicode MS", 10);
            //            }
            //        }

            //    }
            //    foreach (DataGridViewColumn column in dgvAccountStatement.Columns)
            //    {
            //        column.SortMode = DataGridViewColumnSortMode.NotSortable;
            //    }
            //}
            //catch (Exception ea)
            //{
            //    MessageBox.Show(ea.Message);
            //}
        }

        private void frmAccountWiseItemLedger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                // Loop over DataTables in DataSet.
                System.Data.DataTable ds = new DataTable();
                foreach (DataGridViewColumn col in dgvAccountStatement.Columns)
                {
                    ds.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dgvAccountStatement.Rows)
                {
                    DataRow dRow = ds.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    ds.Rows.Add(dRow);
                }
                ds.TableName = "PartyBillStatement";
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

        private void frmAccountWiseItemLedger_Load(object sender, EventArgs e)
        {
            try
            {
                rbCustomer.Checked = true;
                dtpFromDate.Value = Utility.firstDate;
                dtpFromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
                dtpFromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
                Lang();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkSaleReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSaleReturn.Checked==true)
            rbCustomer.Checked = true;
            chkPurchaseReturn.Checked = false;
            chbSale.Checked = false;
        }

        private void chkPurchaseReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPurchaseReturn.Checked == true)
                rbDealer.Checked = true;
            chkSaleReturn.Checked = false;
            chbSale.Checked = false;
        }
    }
}
