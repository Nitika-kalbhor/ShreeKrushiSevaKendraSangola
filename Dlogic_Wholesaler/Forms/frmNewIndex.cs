using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using MetroFramework.Forms;
using Dlogic_Wholesaler.Forms;
using Dlogic_Wholesaler.ReportFrom;
using Dlogic_Wholesaler.ReportFrom_;
using Dlogic_Wholesaler.ReportFroms;
using DataAccessLayer.controller;
using System.Net.Mail;
using System.IO.Compression;
using System.IO;
using Dlogic_Wholesaler.ReportForms;

namespace Dlogic_Wholesaler.Forms
{
    public partial class frmNewIndex : MetroForm
    {
        public frmNewIndex()
        {
            InitializeComponent();
        }
        static frmNewIndex _instance;
        public static string english = "";
        public static string marathi = "";
        public static frmNewIndex Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmNewIndex();
                }
                return _instance;
            }
        }
        #region --Lang--

        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    rbtMasterTab.Text = "Master"; //rbtMasterTab.Font = new Font("Arial Unicode MS", 13, FontStyle.Bold);
                    rpnlCustomer.Text = "Customer Details(F1)";
                    rpnlDealer.Text = "Dealer Details(F2)";
                    rpnlItemDetails.Text = "Stock Details(F3)";
                    rpnlCompany.Text = "Company(F4)";
                    rbVillageDetails.Text = "Village Details";
                    rbpGodown.Text = "Godown";
                    rbpStockLoose.Text = "Stock Conversion";
                    rbpDamagedStock.Text = "Damaged Stock Expiry";
                    rbExcelUpload.Text = "Exel Upload";
                    rbplSalesman.Text = "Salesman Details";

                    rtabAccount.Text = "Account";
                    rbpAccountGroup.Text = "Account Group";
                    rbpAccountSubGroup.Text = "Account SubGroup";
                    rbpAccountDetails.Text = "Account Details";
                    rbpExpenses.Text = "Expense Details(Ctrl+E)";
                    rbpBankTransaction.Text = "Bank Transaction(Ctrl+B)";
                    rbtnAssetVoucher.Text = "Asset Voucher";
                    rbpCreditNote.Text = "Credit Note(Alt+C)";
                    rbpDebitNote.Text = "Debit Note(Alt+D)";
                    rbpAccountTransfer.Text = "account Transfer";

                    rpReport.Text = "Report";
                    rbpDayBook.Text = "day Book";
                    rbpSaleBook.Text = "Sale Book";
                    rbpPurchaseBook.Text = "Purchase Book";
                    rbpSaleReturnBook.Text = "Sale Return Book";
                    rbpPurchaseReturnBook.Text = "Purchase Return Book";
                    rbpChalanReport.Text = "Chalan Report";
                    rbpOrderReport.Text = "Order Report";
                    rbpExpireReport.Text = "Expiry Report";
                    rbpReOrderReport.Text = "Re-Order Report";
                    rbpHSN.Text = "HSN-Summary Report";
                    pnlsalereport.Text = "Sale Report";

                    rbpStockReport.Text = "Stock Report";
                    rbpProfitReport.Text = "Profit Report";
                    rbpStockValuation.Text = "Stock Valuation";
                    rbpProfitValuation.Text = "Profit Valuation";
                    rbnItemLegder.Text = "Item Ledger";
                    rbpAavakJavakRegister.Text = "Aavak Javak";
                    rbpItemWiseSaleReport.Text = "Itemwise Sale";
                    rbpDamagedStockReport.Text = "Damaged Stock";
                    singleItemLedgerReport.Text = "Single Day ItemLedger";
                    rbpOpeningClosingReport.Text = "Stock Opening Closing";

                    rtAccountReport.Text = "Account Report";
                    rbpPartyItemReport.Text = "Party Item Report";
                    rbpCashBookReport.Text = "CashBook Report";
                    rbpAccountPendingAmountReport.Text = "Pending Amount Report";
                    rbAccountLedgerVillageWise.Text = "AccountLedger By Area";
                    rbpExpenssReport.Text = "Expenss Report";
                    rbBankReport.Text = "Bank Report";
                    rbpProfitLossReport.Text = "Profit Loss Report";
                    rbpTrialBalanceReport.Text = "Trail Balance";
                    rbpBalanceSheet.Text = "Balance Sheet";

                    rbtGSTR1.Text = "GST Report";
                    btnPurchaseOrder.Text = "Purchase Order(F5)";
                    btnPurchaseBill.Text = "Purchase Bill(F6)";
                    btnPurchaseChalan.Text = "Purchase Chalan(F7)";
                    btnPurchaseReturn.Text = "Purchase Return(F8)";
                    btnSaleInvoice.Text = "Sale Bill(F9)";
                    btnSaleReturn.Text = "Sale Return(F10)";
                    btnSalechalan.Text = "Sale Chalan(F11)";
                    btnSaleOrder.Text = " Sale Order (Alt+F11) ";
                    btnVoucherPayment.Text = "Voucher (Alt+F8)";
                    btnVoucherReceipt.Text = "Receipt (Alt+F9)";
                    btnExpenses.Text = "Expenses(Alt+F10)";
                    btnBankDeposit.Text = "Bank Deposit(Alt+F12)";
                    btnStock.Text = "Stock (F12)";
                    btnStockIn.Text = "Stock In";
                    btnStockOut.Text = "Stock Out";
                }      
                else
                {
                    rbtMasterTab.Text = "मास्तर नोदणी";
                    rpnlCustomer.Text = "ग्राहक माहिती (F1)";
                    rpnlDealer.Text = "व्यापारी माहिती(F2)";
                    rpnlItemDetails.Text = "स्टॉक माहिती(F3)";
                    rpnlCompany.Text = "कंपनी (F4)";
                    rbVillageDetails.Text = "गाव माहिती";
                    rbpGodown.Text = "गोडाऊन";
                    rbpStockLoose.Text = "स्टॉक  लूज";
                    rbpDamagedStock.Text = "खराब स्टॉक";
                    rbExcelUpload.Text = "एक्सेल अपलोड";
                    rbplSalesman.Text = "सेल्समन माहिती";

                    rtabAccount.Text = "खाते माहिती";
                    rbpAccountGroup.Text = "खाते गट नोंदणी";
                    rbpAccountSubGroup.Text = "खाते गट उपप्रकार";
                    rbpAccountDetails.Text = "खाते  नोंदणी";
                    rbpExpenses.Text = "खर्च नोंद (Ctrl+E))";
                    rbpBankTransaction.Text = "बँक भरणा(Ctrl+B)";
                    rbtnAssetVoucher.Text = "मालमत्ता वाऊचर";
                    rbpCreditNote.Text = " क्रेडिट  नोट(Alt+C)";
                    rbpDebitNote.Text = "डेबिट नोट(Alt+D)";
                    rbpAccountTransfer.Text = "खाते बदल";

                    rpReport.Text = "रिपोर्ट";
                    rbpDayBook.Text = "डे बुक";
                    rbpSaleBook.Text = "सेल बुक";
                    rbpPurchaseBook.Text = "खरेदी बुक";
                    rbpSaleReturnBook.Text = "सेल परत बुक";
                    rbpPurchaseReturnBook.Text = " खरेदी परत बुक";
                    rbpChalanReport.Text = "चलन रिपोर्ट";
                    rbpOrderReport.Text = "ऑर्डर रिपोर्ट";
                    rbpExpireReport.Text = "एक्सपायरी रिपोर्ट";
                    rbpReOrderReport.Text = "रि-ऑर्डर रिपोर्ट";
                    rbpHSN.Text = "HSN Summary Report";
                    pnlsalereport.Text = "सेल रिपोर्ट";

                    rbpStockReport.Text = "स्टॉक रिपोर्ट";
                    rbpProfitReport.Text = "नफा रिपोर्ट";
                    rbpStockValuation.Text = "स्टॉक व्यालूयशन रिपोर्ट";
                    rbpProfitValuation.Text = "अंदाजे नफा रिपोर्ट";
                    rbnItemLegder.Text = "वस्तू लेजर रिपोर्ट";
                    rbpAavakJavakRegister.Text = "विक्री रजिस्टर";
                    rbpItemWiseSaleReport.Text = "वस्तू नुसार सेल रिपोर्ट";
                    rbpDamagedStockReport.Text = "खराब स्टॉक रिपोर्ट";
                    singleItemLedgerReport.Text = "वन डे वस्तू लेजर रिपोर्ट";
                    rbpOpeningClosingReport.Text = "स्टॉक आरंभी अखेर शिल्लक रिपोर्ट";

                    rtAccountReport.Text = "खाते रिपोर्ट";
                    rbpPartyItemReport.Text = "पार्टी आयटम रिपोर्ट";
                    rbpCashBookReport.Text = "कॅश बुक रिपोर्ट";
                    rbpAccountPendingAmountReport.Text = "खाते उधारी  रिपोर्ट";
                    rbAccountLedgerVillageWise.Text = "गावानुसार खाते उधारी";
                    rbpExpenssReport.Text = "खर्च रिपोर्ट";
                    rbBankReport.Text = "बँक रिपोर्ट";
                    rbpProfitLossReport.Text = "नफा तोटा रिपोर्ट";
                    rbpTrialBalanceReport.Text = "Trail Balance";
                    rbpBalanceSheet.Text = "Balance Sheet";

                    rbtGSTR1.Text = "GST रिपोर्ट";
                    btnPurchaseOrder.Text = "खरेदी  ऑर्डर(F5)";
                    btnPurchaseBill.Text = "खरेदी बिल (F6)";
                    btnPurchaseChalan.Text = "खरेदी  चलन(F7)";
                    btnPurchaseReturn.Text = "खरेदी परत(F8)";
                    btnSaleInvoice.Text = "सेल बिल (F9)";
                    btnSaleReturn.Text = "सेल परत(F10)";
                    btnSalechalan.Text = "सेल चलन(F11)";
                    btnSaleOrder.Text = "सेल ऑर्डर/कोटेशन       (Alt+F11)";
                    btnVoucherPayment.Text = "नावे पावती (Alt+F8)";
                    btnVoucherReceipt.Text = "जमा पावती(Alt+F9)";
                    btnExpenses.Text = "खर्च नोंद (Alt+F10)";
                    btnBankDeposit.Text = "बँक भरणा(Alt+F12)";
                    btnStock.Text = "स्टॉक  (F12)";
                    btnStockIn.Text = "स्टॉक इन";
                    btnStockOut.Text = "स्टॉक ऑऊट";
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void rpnlCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomerDetails frmc = new frmCustomerDetails();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rpnlDealer_Click(object sender, EventArgs e)
        {
            try
            {
                frmDealerMaster frmc = new frmDealerMaster();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                frmItemDetails frmc = new frmItemDetails();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmNewIndex_KeyDown(object sender, KeyEventArgs e)
        {
            try
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
                if (e.KeyCode == Keys.F1)
                {
                    try
                    {
                        frmCustomerDetails frmc = new frmCustomerDetails();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F2)
                {
                    try
                    {
                        frmDealerMaster frmc = new frmDealerMaster();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F3)
                {
                    try
                    {
                        frmItemDetails frmc = new frmItemDetails();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F4)
                {
                    try
                    {
                        frmCompany frmc = new frmCompany();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F5)
                {
                    try
                    {
                        btnPurchaseOrder_Click(sender, e);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F6)
                {
                    try
                    {
                        frmPurchaseInvoice frmc = new frmPurchaseInvoice();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F7)
                {
                    try
                    {
                        btnPurchaseChalan_Click(sender, e);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F8)
                {
                    try
                    {
                        frmPurchaseReturn frmc = new frmPurchaseReturn();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F8 && e.Alt)
                {
                    try
                    {
                        frmVoucherPayment frmc = new frmVoucherPayment();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F9 && e.Alt)
                {
                    try
                    {
                        frmVoucherRecipt frmc = new frmVoucherRecipt();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (e.KeyCode == Keys.F9)
                {
                    try
                    {
                        frmSaleInvoive frmc = new frmSaleInvoive();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F10)
                {
                    try
                    {
                        FrmSaleReturn frmc = new FrmSaleReturn();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F11)
                {
                    try
                    {
                        frmSaleChallan frmc = new frmSaleChallan();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F11 && e.Alt)
                {
                    try
                    {
                        frmSalesOrder frmc = new frmSalesOrder();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F12)
                {
                    try
                    {
                        frmStockRegister frmc = new frmStockRegister();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.E && e.Control)
                {
                    try
                    {
                        frmExpenses frmc = new frmExpenses();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.B && e.Control)
                {
                    try
                    {
                        frmBankDeposit frmc = new frmBankDeposit();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (e.KeyCode == Keys.C && e.Alt)
                {
                    try
                    {
                        frmCreditNote frmc = new frmCreditNote();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.D && e.Alt)
                {
                    try
                    {
                        debitNotecs frmc = new debitNotecs();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F10 && e.Alt)
                {
                    try
                    {
                        frmExpenses frmc = new frmExpenses();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (e.KeyCode == Keys.F12 && e.Alt)
                {
                    try
                    {
                        frmBankDeposit frmc = new frmBankDeposit();
                        frmc.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rpnlCompany_Click(object sender, EventArgs e)
        {
            try
            {
                frmCompany frmc = new frmCompany();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmPurchaseInvoice frmc = new frmPurchaseInvoice();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPurchaseReturn_Click(object sender, EventArgs e)
        {
            try
            {
                frmPurchaseReturn frmc = new frmPurchaseReturn();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frmVoucherPayment frmc = new frmVoucherPayment();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                frmVoucherRecipt frmc = new frmVoucherRecipt();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                frmSaleInvoive frmc = new frmSaleInvoive();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                frmStockRegister frmc = new frmStockRegister();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccountGroup frmc = new frmAccountGroup();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ribbonPanel2_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccountDetails frmc = new frmAccountDetails();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ribbonPanel3_Click(object sender, EventArgs e)
        {
            try
            {
               DateBookReport frmc = new DateBookReport();
               // FrmAllSaleCustomer frmc = new FrmAllSaleCustomer();
               frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                    lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
            lbldate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void frmNewIndex_FormClosing(object sender, FormClosingEventArgs e)
        {
            int i = accountGroupController.getBackup();
            MessageBox.Show("BackUp SuccesssFully Saved..");
            Application.Exit();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSaleReturn frmc = new FrmSaleReturn();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ribbonPanel4_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAllSaleCustomer frmc = new FrmAllSaleCustomer();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ribbonPanel5_Click(object sender, EventArgs e)
        {
            try
            {
                AllPurchaseDetails frmc = new AllPurchaseDetails();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ribbonPanel6_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSaleReturnBook frmc = new FrmSaleReturnBook();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ribbonPanel7_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAllPurchaseRetrun frmc = new FrmAllPurchaseRetrun();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSalechalan_Click(object sender, EventArgs e)
        {
            try
            {
                frmSaleChallan frm = new frmSaleChallan();
                frm.ShowDialog();
            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void btnSaleOrder_Click(object sender, EventArgs e)
        {
            try
            {
                frmSalesOrder frm = new frmSalesOrder();
                frm.ShowDialog();
            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void ribbonPanel8_Click(object sender, EventArgs e)
        {
            frmReOrderReport frm = new frmReOrderReport();
            frm.ShowDialog();
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            frmPurchasseOrder frm = new frmPurchasseOrder();
            frm.ShowDialog();
        }

        private void btnPurchaseChalan_Click(object sender, EventArgs e)
        {
            frmPurchaseChalan frm = new frmPurchaseChalan();
            frm.ShowDialog();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            frmStocIn frm = new frmStocIn();
            frm.ShowDialog();
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            frmStockOut frm = new frmStockOut();
            frm.ShowDialog();
        }

        private void ribbonPanel9_Click(object sender, EventArgs e)
        {
            frmAccountLedgerReport frm = new frmAccountLedgerReport();
            frm.ShowDialog();
        }

        private void ribbonPanel10_Click(object sender, EventArgs e)
        {
            frmCashBookReport frm = new frmCashBookReport();
            frm.ShowDialog();
        }

        private void ribbonPanel11_Click(object sender, EventArgs e)
        {
            frmAccountWiseItemLedger frm = new frmAccountWiseItemLedger();
            frm.ShowDialog();
        }

        private void ribbonPanel12_Click(object sender, EventArgs e)
        {
            frmProfitReprot frm = new frmProfitReprot();
            frm.ShowDialog();
        }

        private void ribbonPanel13_Click(object sender, EventArgs e)
        {
            frmStockValuationReport frm = new frmStockValuationReport();
            frm.ShowDialog();
        }

        private void ribbonPanel14_Click(object sender, EventArgs e)
        {
            frmProfitValuation frm = new frmProfitValuation();
            frm.ShowDialog();
        }

        private void ribbonPanel15_Click(object sender, EventArgs e)
        {
            frmAccountWiseItemLedger frm = new frmAccountWiseItemLedger();
            frm.ShowDialog();
        }

        private void ribbonPanel16_Click(object sender, EventArgs e)
        {
            frmCashBookReport frm = new frmCashBookReport();
            frm.ShowDialog();
        }

        private void ribbonPanel17_Click(object sender, EventArgs e)
        {
            frmAccountLedgerReport frm = new frmAccountLedgerReport();
            frm.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                frmNotificationReport frm = new frmNotificationReport();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmNewIndex_Load(object sender, EventArgs e)
        {
         //   mlBack.Visible = false;

            companyName.Text = Utility.dtGenericBillInfo.Rows[0]["ShopNameCity"].ToString();
            cmbLanguagea.SelectedItem = Utility.Langn;
            _instance = this;
            UCfrmHome uc = new UCfrmHome();
            uc.Dock = DockStyle.Fill; 
            Lang();
            label2.Text = Utility.Financialyear;
            mplRenderBody.Controls.Add(uc);
        }

        private void rbVillageDetails_Click(object sender, EventArgs e)
        {
            frmVilegeArea frm = new frmVilegeArea();
            frm.ShowDialog();
        }

        private void rbpOffBackup_Click(object sender, EventArgs e)
        {
            try
            {
                int i = accountGroupController.getBackup();
                    MessageBox.Show("BackUp SuccesssFully Saved..");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbPOnlineBack_Click(object sender, EventArgs e)
        {
            
            //try
            //{
            //    int i = accountGroupController.getBackup();
            //    string fromDirectory = @"E:\SiddheshawerHardwareDbBackUp";
            //    string todaysDate = DateTime.Now.ToString("dd_MMM_yyyy");
            //    string toDirectory = @"E:\SiddheshawerHardwareDbBackUp" + "/" + todaysDate + "_backup.zip";
            //  //  ZipFile.CreateFromDirectory(fromDirectory, toDirectory, CompressionLevel.Optimal, false);
            //        //Write the current date to the text file
            //   // System.IO.Compression.ZipFile.CreateFromDirectory(fromDirectory, toDirectory);
            //     //StreamWriter writer = new StreamWriter(runningDirectory + "\\BackupDate.txt"); //open the file for writing.
            //     //  writer.Write(DateTime.Now.ToString("dd MMM yyyy")); //write the current date to the file. change this with your date or something.
            //     //  writer.Close(); //remember to close the file again.
            //     //  writer.Dispose(); //remember to dispose it from the memory.
            //        MailMessage mail = new MailMessage();
            //        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            //        mail.From = new MailAddress("dlogichardware@gmail.com");
            //        mail.To.Add("dlogichardware@gmail.com");
            //        mail.Subject = "Test Mail";
            //        mail.Body = "This is for testing SMTP mail from GMAIL";
            //        string filename = @"E:\SiddheshawerHardwareDbBackUp\Dlogic_HardWare.bak";
            //        mail.Attachments.Add(new Attachment(filename));
            //        SmtpServer.Port = 587;
            //        SmtpServer.Credentials = new System.Net.NetworkCredential("dlogichardware", "Dl@12345");
            //        SmtpServer.EnableSsl = true;

            //        SmtpServer.Send(mail);
            //        MessageBox.Show("BackUp  SuccesssFully Saved Online..");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void rbnItemLegder_Click(object sender, EventArgs e)
        {
            frmItemLegderReport frm = new frmItemLegderReport();
            frm.ShowDialog();
        }

        private void rbAccountLedgerVillageWise_Click(object sender, EventArgs e)
        {
            frmAccountLedgerByArea frm = new frmAccountLedgerByArea();
            frm.ShowDialog();
        }

        private void rbpExpenses_Click(object sender, EventArgs e)
        {
            frmExpenses frm = new frmExpenses();
            frm.ShowDialog();
        }

        private void ribbonPanel9_Click_1(object sender, EventArgs e)
        {
            frmExpensesReport frm = new frmExpensesReport();
            frm.ShowDialog();
        }

        private void rbpBankTransaction_Click(object sender, EventArgs e)
        {
            frmBankDeposit frm = new frmBankDeposit();
            frm.ShowDialog();
        }

        private void rbBankReport_Click(object sender, EventArgs e)
        {
            frmBankReport frm = new frmBankReport();
            frm.ShowDialog();
        }

        private void rbpHSN_Click(object sender, EventArgs e)
        {
            frmHSNSummeryReportcs frm = new frmHSNSummeryReportcs();
            frm.ShowDialog();
        }

        private void rbpExpireReport_Click(object sender, EventArgs e)
        {
            frmExpireReport frm = new frmExpireReport();
            frm.ShowDialog();
        }

        private void rpanBtnGstR1_Click(object sender, EventArgs e)
        {
            frmGSTR1Reprot frm = new frmGSTR1Reprot();
            frm.ShowDialog();
            
          }

        private void ribbonButton28_Click(object sender, EventArgs e)
        {
            frmAvakJavakregister frm = new frmAvakJavakregister();
            frm.ShowDialog();
        }

        private void ribbonPanel11_Click_1(object sender, EventArgs e)
        {
            frmPandingChalan frm = new frmPandingChalan();
            frm.ShowDialog();
        }

        private void ribbonPanel18_Click(object sender, EventArgs e)
        {
            frmPendingOrderReport frm = new frmPendingOrderReport();
            frm.ShowDialog();
        }

        private void ribbonPanel19_Click(object sender, EventArgs e)
        {
            GSTR2Report frm = new GSTR2Report();
            frm.ShowDialog();
        }

        private void ribbonPanel20_Click(object sender, EventArgs e)
        {
            frmTradingProfitAdnLossAccountReport frm = new frmTradingProfitAdnLossAccountReport();
            frm.ShowDialog();
        }

        private void ribbonPanel21_Click(object sender, EventArgs e)
        {
            frmTrailBalanceReport frm = new frmTrailBalanceReport();
            frm.ShowDialog();
        }

        private void ribbonPanel22_Click(object sender, EventArgs e)
        {
            frmBalanceSheet frm = new frmBalanceSheet();
            frm.ShowDialog();
        }

        private void ribbonPanel23_Click(object sender, EventArgs e)
        {
            frmAccountSubGroup frm = new frmAccountSubGroup();
            frm.ShowDialog();
        }

        private void rbtnAssetVoucher_Click(object sender, EventArgs e)
        {
            try
            {
                frmAssetVoucher frm = new frmAssetVoucher();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonPanel25_Click(object sender, EventArgs e)
        {
            try
            {
                frmGstSummary frm = new frmGstSummary();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonButton37_Click(object sender, EventArgs e)
        {
            try
            {
                frmItemWiseSale frm = new frmItemWiseSale();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonPanel26_Click(object sender, EventArgs e)
        {
            try
            {
                frmGodownTransfer frm = new frmGodownTransfer();
                frm.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonPanel27_Click(object sender, EventArgs e)
        {
            try
            {
                frmStockConversion frm = new frmStockConversion();
                frm.ShowDialog();
            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonPanel28_Click(object sender, EventArgs e)
        {
            try
            {
                frmDamagedStockExpiry frm = new frmDamagedStockExpiry();
                frm.ShowDialog();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonPanel29_Click(object sender, EventArgs e)
        {
            try
            {
                frmDamagedStockExpiryReport frm = new frmDamagedStockExpiryReport();
                frm.ShowDialog();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonPanel30_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreditNote frm = new frmCreditNote();
                frm.ShowDialog();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonPanel31_Click(object sender, EventArgs e)
        {
            try
            {
                debitNotecs frm = new debitNotecs();
                frm.ShowDialog();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbpGST3B_Click(object sender, EventArgs e)
        {
            try
            {
                frmGST3BReport frm = new frmGST3BReport();
                frm.ShowDialog();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbpAccountTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTransfer frm = new FrmTransfer();
                frm.ShowDialog();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mplRenderBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbExcelUpload_Click(object sender, EventArgs e)
        {
            try
            {
                ImportExcel frm = new ImportExcel();
                frm.ShowDialog();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            try
            {
                frmExpenses frmc = new frmExpenses();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBankDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                frmBankDeposit frmc = new frmBankDeposit();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlsalereport_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSaleReport frmc = new FrmSaleReport();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void singleItemLedgerReport_Click(object sender, EventArgs e)
        {
            try
            {
                frmSingleDayItemLedgerReport frmc = new frmSingleDayItemLedgerReport();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void rbnStockOpeningClosingrpt_Click(object sender, EventArgs e)
        {
            try
            {
                FrmStockOpeningClosingReport frmc = new FrmStockOpeningClosingReport();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        

        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Language = Convert.ToString(cmbLanguagea.SelectedItem);
                Utility.SetLanguage(Language);
                Lang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
       }

        private void rbplSalesman_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSalesManDetails frmc = new FrmSalesManDetails();
                frmc.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }
    }
}
