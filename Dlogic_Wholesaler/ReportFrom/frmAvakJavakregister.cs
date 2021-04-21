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
using System.Threading;
using System.Windows.Forms;

namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class frmAvakJavakregister : MetroForm
    {
        int orgId = 0, categoryId = 0; long itemId = 0;
        double MRPValuation = 0, SaleValuation = 0, PurchaseValuation = 0, profit = 0;
        private bool isProcessRunning = false;
        private Thread pThread, sqlThread;
        private MethodInvoker progBarDeligate, progBarDeligateReset, runMethodDelegate;
        private string probarLock = "myProbarLock";
        private string methodLock = "myMethodLock";
        public frmAvakJavakregister()
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
                    lblHerader.Text = "Aavak Javak Register";
                    lblItemType.Text = "Item Type";
                    lblItemName.Text = "Item Name";
                    lblGodown.Text = "Company";
                    btnShow.Text = "Show";
                    btnPrint.Text = "Print";
                    metroButton3.Text = "Clear";
                    btnExport.Text = "Export";
                    metroLabel1.Text = "From Date:";
                    label1.Text = "To Date:";
                    gbsarch.Text = "Search";
                    label5.Text = "Category Name";
                    chkSummery.Text = "Summary";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public void BindComboBoxgetOrgnation()
        {
            DataTable dtgenderId = categoryController.getCompany();
            Utility.BindComboBoxEmptyDataSelect(cmbOrgnation, dtgenderId, "companyId", "companyName");
        }
        private void frmAvakJavakregister_Load(object sender, EventArgs e)
        {
            BindComboBoxgetOrgnation();
          //  bindItemDetals();
            cmbMainCategory.SelectedIndex = 0;
            chkSummery.Checked = false;
            bindGrid(stockController.getAvakJavakRegister(0,0,0,dtpfromDate.Value,dtpToDate.Value,Utility.FinancilaYearId));
            dtpfromDate.Value = Utility.firstDate;
            dtpfromDate.MinDate = dtpToDate.MinDate = Utility.firstDate;
            dtpfromDate.MaxDate = dtpToDate.MaxDate = Utility.lastDate;
            Lang();
            //progressBar1.Step = 1;
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = 60;
            //progBarDeligate = new MethodInvoker(progressBar1.PerformStep);
            //progBarDeligateReset = new MethodInvoker(resetProgressBar);
            //runMethodDelegate = new MethodInvoker(bindAvakJavakRegister);
            //ThreadStart toP = new ThreadStart(mooveProgress);
            //pThread = new Thread(toP);
            //ThreadStart toM = new ThreadStart(getData);
            //sqlThread = new Thread(toM);
        }

        private void cmbOrgnation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dtItemDetails = new System.Data.DataTable();
                if (cmbOrgnation.SelectedIndex > 0)
                {
                    dtItemDetails = categoryController.getCategoryDetails(Convert.ToInt32(cmbOrgnation.SelectedValue));
                }
                else
                {
                    dtItemDetails = categoryController.getCategoryDetails(0);
                }
                Utility.BindComboBoxDataSelect(cmbItemType, dtItemDetails, "categoryId", "categoryName");
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dtItemDetails = new System.Data.DataTable();
                if (cmbItemType.SelectedIndex == 0)
                {
                    lblItemName.Visible = false;
                    //    lblBatchNo.Visible = false;
                    cmbItemName.Visible = false;
                    //  cmbBatchNo.Visible = false;
                    dtItemDetails =  stockController.getItemByCategory(0,0);
                }
                else
                {
                    if (cmbItemType.SelectedIndex > 0)
                    {
                        dtItemDetails = stockController.getItemByCategory(Convert.ToInt32(cmbOrgnation.SelectedValue), Convert.ToInt32(cmbItemType.SelectedValue));
                        cmbItemName.Visible = true;
                        lblItemName.Visible = true;
                    }
                }
             //   Utility.BindComboBoxDataSelect(cmbItemName, dtItemDetails, "StockId", "itemName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void bindItemDetals()
        {
           // DataTable dtItemDetails = stockController.getItemByCategory(0, 0);
          //  Utility.BindComboBoxDataSelect(cmbItemName, dtItemDetails, "StockId", "itemName");
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                //orgId = 0;
                //if (cmbOrgnation.SelectedIndex > 0)
                //{
                //    if (cmbItemType.SelectedIndex == 0)
                //    {
                //        MessageBox.Show("कृपया प्रकार निवडा.");
                //        cmbItemType.Focus();
                //        return;
                //    }
                //    else
                //    {
                //        if (cmbItemType.SelectedIndex > 0)
                //        {
                //            if (cmbItemName.SelectedIndex == 0)
                //            {
                //                MessageBox.Show("कृपया वस्तूचे नाव निवडा.");
                //                cmbItemName.Focus();
                //                return;
                //            }
                //        }
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("कृपया कंपनी  निवडा.");
                //}
                bindAvakJavakRegister();
               // mooveProgress();
                //pThread.Start();
               // sqlThread.Start();
               
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error:-" + ae.ToString());
            }
        }
        public void bindGrid(DataTable dtStockValueation)
        {
            try
            {
               
                dgvStockRegister.DataSource = null;
                dgvStockRegister.AutoGenerateColumns = false;
                dgvStockRegister.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvStockRegister.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvStockRegister.ColumnCount = 11;
                dgvStockRegister.Font = new Font("Arial Unicode MS", 11);
                dgvStockRegister.EnableHeadersVisualStyles = false;

                if (Utility.Langn == "English")
                {
                    dgvStockRegister.Columns[0].HeaderText = "Date";
                    dgvStockRegister.Columns[1].HeaderText = "Seeds Name";
                    dgvStockRegister.Columns[2].HeaderText = "Seeds Category";
                    dgvStockRegister.Columns[3].HeaderText = "Received From Dealer And Company";
                    dgvStockRegister.Columns[4].HeaderText = "Batch No Expiry Date";
                    dgvStockRegister.Columns[5].HeaderText = "Daywise StockIn";
                    dgvStockRegister.Columns[6].HeaderText = "Opening Stock";
                    dgvStockRegister.Columns[7].HeaderText = "Current Stock";
                    dgvStockRegister.Columns[8].HeaderText = "Stock Out";
                    dgvStockRegister.Columns[9].HeaderText = "closing Stock";
                }
                else
                {
                    dgvStockRegister.Columns[0].HeaderText = "दिनांक";
                    dgvStockRegister.Columns[1].HeaderText = "बियाणाचे नाव";
                    dgvStockRegister.Columns[2].HeaderText = "बियाणाचा प्रकार";
                    dgvStockRegister.Columns[3].HeaderText = "कोणाकडून आले व कंपनी";
                    dgvStockRegister.Columns[4].HeaderText = "बॅच नंबर उत्पदन अंतिम मुदत दिनांक";
                    dgvStockRegister.Columns[5].HeaderText = "दिवसातील आवक";
                    dgvStockRegister.Columns[6].HeaderText = "सुरुवातीचा शिल्लक साठा";
                    dgvStockRegister.Columns[7].HeaderText = "एकूण साठा";
                    dgvStockRegister.Columns[8].HeaderText = "दिवसातील विक्री";
                    dgvStockRegister.Columns[9].HeaderText = "शिल्लक साठा";
                }
                dgvStockRegister.Columns[0].Name = "purchaseDate";              
                dgvStockRegister.Columns[0].DataPropertyName = "purchaseDate";
              //  dgvStockRegister.Columns[0].Width = 100;
                dgvStockRegister.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvStockRegister.Columns[1].Name = "itemName";               
                dgvStockRegister.Columns[1].DataPropertyName = "itemName";
                //dgvStockRegister.Columns[1].Width = 100;

                dgvStockRegister.Columns[2].Name = "categoryName";             
                dgvStockRegister.Columns[2].DataPropertyName = "categoryName";
                //dgvStockRegister.Columns[2].Width = 100;

                dgvStockRegister.Columns[3].Name = "dealerFirmName";             
                dgvStockRegister.Columns[3].DataPropertyName = "dealerFirmName";
                //dgvStockRegister.Columns[3].Width = 180;

                dgvStockRegister.Columns[4].Name = "batchNo";               
                dgvStockRegister.Columns[4].DataPropertyName = "batchNo";
                //dgvStockRegister.Columns[4].Width = 180;

                dgvStockRegister.Columns[5].Name = "StockIn";              
                dgvStockRegister.Columns[5].DataPropertyName = "StockIn";
                //dgvStockRegister.Columns[5].Width = 250;

                dgvStockRegister.Columns[6].Name = "openingStock";              
                dgvStockRegister.Columns[6].DataPropertyName = "openingStock";
                //dgvStockRegister.Columns[6].Width = 200;

                dgvStockRegister.Columns[7].Name = "currentStock";              
                dgvStockRegister.Columns[7].DataPropertyName = "currentStock";
                //dgvStockRegister.Columns[7].Width = 300;

                dgvStockRegister.Columns[8].Name = "StockOut";               
                dgvStockRegister.Columns[8].DataPropertyName = "StockOut";
                //dgvStockRegister.Columns[8].Width = 180;

                dgvStockRegister.Columns[9].Name = "closingStock";                
                dgvStockRegister.Columns[9].DataPropertyName = "closingStock";
                //dgvStockRegister.Columns[9].Width = 180;
                dgvStockRegister.Columns[10].Name = "unitBy";
                dgvStockRegister.Columns[10].HeaderText = "unitBy";
                dgvStockRegister.Columns[10].DataPropertyName = "unitBy";
                dgvStockRegister.Columns[10].Visible = false;
                if(cmbMainCategory.Text=="खते")
                {
                    if (Utility.Langn == "English")
                    {
                        dgvStockRegister.Columns[3].HeaderText = "Received From Dealer And Company";
                        dgvStockRegister.Columns[5].HeaderText = "Daywise StockIn";
                    }
                    else
                    {
                        dgvStockRegister.Columns[3].HeaderText = "कोणाकडून आले व कंपनी";
                        dgvStockRegister.Columns[5].HeaderText = "दिवसातील आवक";
                    }
                   
                    dgvStockRegister.Columns[4].Visible = false;
                    dgvStockRegister.Columns[1].Visible = false;
                    dgvStockRegister.Columns[2].Visible = false;

                }
                if (cmbMainCategory.Text == "किटकनाशके")
                {
                    if (Utility.Langn == "English")
                    {
                        dgvStockRegister.Columns[3].HeaderText = "Pestiside Purchase From who that person name and Receipt No & Date";
                        dgvStockRegister.Columns[5].HeaderText = "Purchase Stock";
                    }
                    else
                    {
                        dgvStockRegister.Columns[3].HeaderText = "किटकनाशक कोणाकडून खरेदी केले त्याचे नाव व पावती क्र. व दिनांक";
                        dgvStockRegister.Columns[5].HeaderText = "खरेदी केलेला साठा";
                    }
                   
                    dgvStockRegister.Columns[3].Name = "purchaseInvoice";
                    dgvStockRegister.Columns[3].DataPropertyName = "purchaseInvoice";
                  //  dgvStockRegister.Columns[3].Width = 180;                   
                    dgvStockRegister.Columns[4].Visible = true;
                    dgvStockRegister.Columns[1].Visible = false;
                    dgvStockRegister.Columns[2].Visible = false;
                }
                if (cmbMainCategory.Text == "बियाणे")
                {
                    if (Utility.Langn == "English")
                    {
                        dgvStockRegister.Columns[3].HeaderText = "Received From";
                        dgvStockRegister.Columns[5].HeaderText = "How Much Received";
                    }
                    else
                    {
                        dgvStockRegister.Columns[3].HeaderText = "कोणाकडून आले";
                        dgvStockRegister.Columns[5].HeaderText = "किती आले";
                    }
                  
                    dgvStockRegister.Columns[4].Visible = false;
                    dgvStockRegister.Columns[1].Visible = true;
                    dgvStockRegister.Columns[2].Visible = true;
                }
                dgvStockRegister.DataSource = dtStockValueation;
               // pThread.Abort();
               // sqlThread.Abort();
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error", ae.ToString());
            }
        }

        public void bindSummeryGrid(DataTable dtSummery)
        {
            try
            {
                dgvSummerysales.DataSource = null;
                dgvSummerysales.AutoGenerateColumns = false;
                dgvSummerysales.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvSummerysales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSummerysales.ColumnCount = 10;
                dgvSummerysales.Font = new Font("Arial Unicode MS", 11);
                dgvSummerysales.EnableHeadersVisualStyles = false;

                if (Utility.Langn == "English")
                {
                    dgvSummerysales.Columns[0].HeaderText = "Company Name";
                    dgvSummerysales.Columns[1].HeaderText = "Item Name";
                    dgvSummerysales.Columns[2].HeaderText = "Unit By";
                    dgvSummerysales.Columns[3].HeaderText = "Category";
                    dgvSummerysales.Columns[4].HeaderText = "Batch No";
                    dgvSummerysales.Columns[5].HeaderText = "Daywise StockIn";
                    dgvSummerysales.Columns[6].HeaderText = "Opening Stock";
                    dgvSummerysales.Columns[7].HeaderText = "Current Stock";
                    dgvSummerysales.Columns[8].HeaderText = "Stock Out";
                    dgvSummerysales.Columns[9].HeaderText = "closing Stock";
                }
                else
                {
                    dgvSummerysales.Columns[0].HeaderText = "कंपनी";
                    dgvSummerysales.Columns[1].HeaderText = "वस्तूचे नाव";
                    dgvSummerysales.Columns[2].HeaderText = "पॅकिंग";
                    dgvSummerysales.Columns[3].HeaderText = "प्रकार";
                    dgvSummerysales.Columns[4].HeaderText = "बॅच नंबर";
                    dgvSummerysales.Columns[5].HeaderText = "दिवसातील आवक";
                    dgvSummerysales.Columns[6].HeaderText = "सुरुवातीचा शिल्लक साठा";
                    dgvSummerysales.Columns[7].HeaderText = "एकूण साठा";
                    dgvSummerysales.Columns[8].HeaderText = "दिवसातील विक्री";
                    dgvSummerysales.Columns[9].HeaderText = "शिल्लक साठा";
                }
                dgvSummerysales.Columns[0].Name = "companyName";              
                dgvSummerysales.Columns[0].DataPropertyName = "companyName";
                //dgvSummerysales.Columns[0].Width = 100;

                dgvSummerysales.Columns[1].Name = "itemName";              
                dgvSummerysales.Columns[1].DataPropertyName = "itemName";
                //dgvSummerysales.Columns[1].Width = 100;

                dgvSummerysales.Columns[2].Name = "unitBy";             
                dgvSummerysales.Columns[2].DataPropertyName = "unitBy";
              //  dgvStockRegister.Columns[2].Width = 100;

                dgvSummerysales.Columns[3].Name = "categoryName";               
                dgvSummerysales.Columns[3].DataPropertyName = "categoryName";
                //dgvSummerysales.Columns[3].Width = 100;
                dgvSummerysales.Columns[3].Visible = false;              

                dgvSummerysales.Columns[4].Name = "batchNo";              
                dgvSummerysales.Columns[4].DataPropertyName = "batchNo";
                //dgvSummerysales.Columns[4].Width = 180;

                dgvSummerysales.Columns[5].Name = "StockIn";               
                dgvSummerysales.Columns[5].DataPropertyName = "StockIn";
                //dgvSummerysales.Columns[5].Width = 250;

                dgvSummerysales.Columns[6].Name = "openingStock";
                dgvSummerysales.Columns[6].DataPropertyName = "openingStock";
                //dgvSummerysales.Columns[6].Width = 200;

                dgvSummerysales.Columns[7].Name = "currentStock";
                dgvSummerysales.Columns[7].DataPropertyName = "currentStock";
                //dgvSummerysales.Columns[7].Width = 300;

                dgvSummerysales.Columns[8].Name = "StockOut";
                dgvSummerysales.Columns[8].DataPropertyName = "StockOut";
                //dgvSummerysales.Columns[8].Width = 180;

                dgvSummerysales.Columns[9].Name = "closingStock";
               dgvSummerysales.Columns[9].DataPropertyName = "closingStock";
                //dgvSummerysales.Columns[9].Width = 180;

                dgvSummerysales.DataSource = dtSummery;
                // pThread.Abort();
                // sqlThread.Abort();
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error", ae.ToString());
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable ds = new System.Data.DataTable();
                Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);


                Microsoft.Office.Interop.Excel.Sheets xlSheets = null;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = null;
                //Create Excel Sheets
                xlSheets = ExcelApp.Sheets;
                xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlSheets.Add(xlSheets[1],
                               Type.Missing, Type.Missing, Type.Missing);
                if (chkSummery.Checked == false)
                {
                    foreach (DataGridViewColumn col in dgvStockRegister.Columns)
                    {
                        ds.Columns.Add(col.HeaderText);
                    }

                    foreach (DataGridViewRow row in dgvStockRegister.Rows)
                    {
                        DataRow dRow = ds.NewRow();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            dRow[cell.ColumnIndex] = cell.Value;
                        }
                        ds.Rows.Add(dRow);
                    }
                    if (cmbMainCategory.Text == "खते")
                    {
                        ds.Columns[3].ColumnName = "कोणाकडून आले व कंपनी";
                        ds.Columns[5].ColumnName = "दिवसातील आवक";
                        ds.Columns.Remove("बॅच नंबर उत्पदन अंतिम मुदत दिनांक");
                        ds.Columns.Remove("बियाणाचे नाव");
                        ds.Columns.Remove("बियाणाचा प्रकार");
                        ds.TableName = "खते रजिस्टर";
                    }
                    if (cmbMainCategory.Text == "किटकनाशके")
                    {
                        ds.Columns[3].ColumnName = "किटकनाशक कोणाकडून खरेदी केले त्याचे नाव व पावती क्र. व दिनांक";
                        ds.Columns[5].ColumnName = "खरेदी केलेला साठा";
                        ds.Columns.Remove("बियाणाचे नाव");
                        ds.Columns.Remove("बियाणाचा प्रकार");
                        ds.TableName = "किटकनाशके रजिस्टर";
                    }
                    if (cmbMainCategory.Text == "बियाणे")
                    {
                        ds.Columns[3].ColumnName = "कोणाकडून आले";
                        ds.Columns[5].ColumnName = "किती आले";
                        ds.Columns.Remove("बॅच नंबर उत्पदन अंतिम मुदत दिनांक");
                        ds.TableName = "बियाणे रजिस्टर";
                    }
                }
                else
                {
                    foreach (DataGridViewColumn col in dgvSummerysales.Columns)
                    {
                        ds.Columns.Add(col.HeaderText);
                    }

                    foreach (DataGridViewRow row in dgvSummerysales.Rows)
                    {
                        DataRow dRow = ds.NewRow();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            dRow[cell.ColumnIndex] = cell.Value;
                        }
                        ds.Rows.Add(dRow);
                    }
                    ds.TableName = "विक्री रजिस्टर";
                }
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
            catch (Exception ac)
            {
                MessageBox.Show(ac.Message);
            }
        }

        private void frmAvakJavakregister_KeyDown(object sender, KeyEventArgs e)
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

                if (chkSummery.Checked == false)
                {
                    if (dgvStockRegister.DataSource != null)
                    {
                        DataTable dt = (DataTable)dgvStockRegister.DataSource;
                        if (dt.Rows.Count > 0)
                        {
                            Report rp = new Report();
                            if (cmbMainCategory.Text == "खते")
                            {
                                crptAvakJavakRegister crReportDocument = new crptAvakJavakRegister();
                             //   crReportDocument.SetDataSource(dt);
                                crReportDocument.Database.Tables[0].SetDataSource(dt);
                                crReportDocument.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                                rp.crystalReportViewer1.ReportSource = crReportDocument;
                                rp.crystalReportViewer1.ReportSource = crReportDocument;
                            }
                            if (cmbMainCategory.Text == "किटकनाशके")
                            {
                                crptpestisideAvakJavakRegister crReportDocument = new crptpestisideAvakJavakRegister();
                                //crReportDocument.SetDataSource(dt);
                                crReportDocument.Database.Tables[0].SetDataSource(dt);
                                crReportDocument.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                                rp.crystalReportViewer1.ReportSource = crReportDocument;
                                rp.crystalReportViewer1.ReportSource = crReportDocument;
                            }
                            if (cmbMainCategory.Text == "बियाणे")
                            {
                                crptSeedRegisterrpt crReportDocument = new crptSeedRegisterrpt();
                               // crReportDocument.SetDataSource(dt);
                                crReportDocument.Database.Tables[0].SetDataSource(dt);
                                crReportDocument.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                                rp.crystalReportViewer1.ReportSource = crReportDocument;
                                rp.crystalReportViewer1.ReportSource = crReportDocument;
                            }
                            rp.crystalReportViewer1.Refresh();
                            rp.Refresh();
                            rp.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("सदर माहिती उपलब्ध नाही..");
                    }
                }
                     else
                    {
                        if(dgvSummerysales.DataSource!=null)
                        {
                           
                            DataTable dtSaleSummery = (DataTable)dgvSummerysales.DataSource;
                            if(dtSaleSummery.Rows.Count>0)
                            {
                                Report rp = new Report();
                                crptSaleSummeryRegister CrReportDocument = new crptSaleSummeryRegister();
                               // CrReportDocument.SetDataSource(dtSaleSummery);
                                CrReportDocument.Database.Tables[0].SetDataSource(dtSaleSummery);
                                CrReportDocument.Database.Tables[1].SetDataSource(Utility.dtGenericBillInfo);
                                CrReportDocument.SetParameterValue(0, cmbMainCategory.Text);
                                CrReportDocument.SetParameterValue(1, dtpfromDate.Value.ToShortDateString());
                                CrReportDocument.SetParameterValue(2, dtpToDate.Value.ToShortDateString());
                                rp.crystalReportViewer1.ReportSource = CrReportDocument;
                                rp.crystalReportViewer1.Refresh();
                                rp.Refresh();
                                rp.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("सदर माहिती उपलब्ध नाही..");
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbMainCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMainCategory.Text!=string.Empty)
            {
                DataTable dtItemDetails = stockController.getItemByMainCategory(cmbMainCategory.Text);
                Utility.BindComboBoxDataSelect(cmbItemName, dtItemDetails, "stockId", "itemName");
                if (chkSummery.Checked == false)
                {
                    bindGrid(stockController.getAvakJavakRegister(0, 0, 0, Convert.ToDateTime(dtpfromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId));
                }
                else
                {
                    bindSummeryGrid(stockController.getAvakJavakRegister(0, 0, 0, Convert.ToDateTime(dtpfromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId));
                }
            }
        }

        private void chkAllStock_CheckedChanged(object sender, EventArgs e)
        {
            bindGrid(stockController.getAvakJavakRegister(0, 0, 0, Convert.ToDateTime(dtpfromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId));
        }
        private void mooveProgress()
        {
            for(int h=0;h<1;h++)
            {
                Monitor.Enter(probarLock);
                for(int i=0;i<1;i++)
                {
                    if (progressBar1.InvokeRequired)
                    {
                        Invoke(progBarDeligate);
                    }
                    else
                    {
                        progressBar1.PerformStep();
                    }
                    // Thread.Sleep(60000);
                }
                if(progressBar1.InvokeRequired)
                {
                    Invoke(progBarDeligateReset, null);
                }
                else
                {
                    resetProgressBar();
                }
                Monitor.Exit(probarLock);
            }
        }
        private void getData()
        {
            for(int i=0;i<1;i++)
            {
                Monitor.Enter(methodLock);
                Invoke(runMethodDelegate, null);
                Monitor.Exit(methodLock);
                Thread.Sleep(100);
            }
        }
        private void resetProgressBar()
        {
            progressBar1.Value = progressBar1.Minimum;
        }
        public void bindAvakJavakRegister()
        {
            System.Data.DataTable dtStocktable = new DataTable();
            DataTable dtstock = new DataTable();
            if (chkSummery.Checked == false)
            {
                if (cmbItemName.SelectedIndex > 0)
                {
                    itemId = Convert.ToInt64(cmbItemName.SelectedValue);
                }
                else
                {
                    MessageBox.Show("कृपया वस्तू निवडा.");
                    // itemId = 0;
                }
                dtStocktable = stockController.getAvakJavakRegister(orgId, categoryId, itemId, Convert.ToDateTime(dtpfromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId);
            }
            else
            {
                dtStocktable = stockController.getAvakJavakRegisterSummery(cmbMainCategory.Text, Convert.ToDateTime(dtpfromDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToDate.Value.ToShortDateString()), Utility.FinancilaYearId);
      
            }
            dtstock = dtStocktable;
            if (chkSummery.Checked == false)
            {
                bindGrid(dtstock);
                 dgvStockRegister.Visible=true;
                dgvSummerysales.Visible=false;
            }
            else
            {
                bindSummeryGrid(dtstock);
                dgvStockRegister.Visible = false;
                dgvSummerysales.Visible = true;
            }

        }
    }
}
