using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessLayer.providers;

namespace DataAccessLayer.controller
{
     public class saleReportController
    {
         public static DataTable AllSaleCustomerBill(DateTime fromDate, DateTime toDate, long financialYearID, string opration, string cashCredit, bool isWholeSale)
         {
             try 
             {
                 DataTable dt = SaleReportProvider.AllSaleCustomerBill(fromDate, toDate, financialYearID, opration, cashCredit, isWholeSale);
                 return dt;
             }
             catch (Exception ex) 
             {
                 
                 throw ex;
             }
         }
         public static DataTable PurchaseDayBook(DateTime fromDate, DateTime toDate, string opration, long FinancialYearID)
         {
             try
             {
                 DataTable dt = SaleReportProvider.PurchaseDayBook(fromDate, toDate, opration, FinancialYearID);
                 return dt;
             }
             catch (Exception ex)
             {

                 throw ex;
             }
         }
         public static DataTable PurchaseReturnDayBook(DateTime fromDate, DateTime toDate, long FinancialYearID)
         {
             try
             {
                 DataTable dt = SaleReportProvider.PurchaseReturnDayBook(fromDate, toDate, FinancialYearID);
                 return dt;
             }
             catch (Exception ex)
             {

                 throw ex;
             }
         }
         public static DataTable SaleReturnDayBook(DateTime fromDate, DateTime toDate,long finacialYearID)
         {
             try
             {
                 DataTable dt = SaleReportProvider.SaleReturnDayBook(fromDate, toDate, finacialYearID);
                 return dt;
             }
             catch (Exception ex)
             {

                 throw ex;
             }
         }
         public static DataTable getSaleReports(long itemId, DateTime toDate, DateTime fromDate, Boolean isQaution)
         {
             try
             {
                 DataTable i = SaleReportProvider.getSaleReports(itemId, fromDate, toDate, isQaution);
                 return i;

             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
         public static DataTable getAccountStatement(long accountName, DateTime fromdate, DateTime toDate, long financialYearID, int rbC, string MainCategoryName)
         {
             try
             {
                 DataTable dtAccountS = getAccountStatementTable();
                 if (rbC == 1)
                 {
                     if (MainCategoryName == "All")
                     {
                         dtAccountS = SaleReportProvider.getAccountStatement(accountName, "AllSaleBill", 0, fromdate, toDate, financialYearID, false, MainCategoryName);
                     }
                     if (MainCategoryName == "खते")
                     {
                         dtAccountS = SaleReportProvider.getAccountStatement(accountName, "SaleFertilizer", 0, fromdate, toDate, financialYearID, false, MainCategoryName);
                     }

                     if (MainCategoryName == "किटकनाशके")
                     {
                         dtAccountS = SaleReportProvider.getAccountStatement(accountName, "SalePesticide", 0, fromdate, toDate, financialYearID, false, MainCategoryName);
                     }
                     if (MainCategoryName == "बियाणे")
                     {
                         dtAccountS = SaleReportProvider.getAccountStatement(accountName, "SaleSeeds", 0, fromdate, toDate, financialYearID, false, MainCategoryName);
                     }
                     if (MainCategoryName == "PGR" || MainCategoryName == "इतर")
                     {
                         dtAccountS = SaleReportProvider.getAccountStatement(accountName, "SaleisPGROther", 0, fromdate, toDate, financialYearID, false, MainCategoryName);
                     }
                 }
                 if (rbC == 2)
                 {
                     #region Purchase Items Bill
                     dtAccountS = SaleReportProvider.getAccountStatement(accountName, "AllPurchaseBill", 0, fromdate, toDate, financialYearID, false, MainCategoryName);

                     #endregion
                 }
                 if (rbC == 3)
                 {
                     dtAccountS = SaleReportProvider.getAccountStatement(accountName, "AllSaleReturnBill", 0, fromdate, toDate, financialYearID, false, MainCategoryName);
                 }
                 if (rbC == 4)
                 {
                     dtAccountS = SaleReportProvider.getAccountStatement(accountName, "AllPurchaseReturnBill", 0, fromdate, toDate, financialYearID, false, MainCategoryName);
                 }
                 if (rbC == 5)
                 {
                     if (MainCategoryName == "All")
                     {
                         dtAccountS = SaleReportProvider.getAccountStatement(accountName, "AllSaleBillDiscount", 0, fromdate, toDate, financialYearID, false, MainCategoryName);
                     }
                     if (MainCategoryName == "खते")
                     {
                         dtAccountS = SaleReportProvider.getAccountStatement(accountName, "SaleDisFertilizer", 0, fromdate, toDate, financialYearID, false, MainCategoryName);
                     }

                     if (MainCategoryName == "किटकनाशके")
                     {
                         dtAccountS = SaleReportProvider.getAccountStatement(accountName, "SaleDisPesticide", 0, fromdate, toDate, financialYearID, false, MainCategoryName);
                     }
                     if (MainCategoryName == "बियाणे")
                     {
                         dtAccountS = SaleReportProvider.getAccountStatement(accountName, "SaleDisSeeds", 0, fromdate, toDate, financialYearID, false, MainCategoryName);
                     }
                     if (MainCategoryName == "PGR" || MainCategoryName == "इतर")
                     {
                         dtAccountS = SaleReportProvider.getAccountStatement(accountName, "SaleDisisPGROther", 0, fromdate, toDate, financialYearID, false, MainCategoryName);
                     }

                 }
                 return dtAccountS;

             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
         public static DataTable getsaleReturnDetails(long saleReturnId,long financialYearID)
         {
             try
             {
                 DataTable dtsaleReturnDetails = SaleReportProvider.getsaleReturnDetails(saleReturnId, financialYearID);
                 return dtsaleReturnDetails;
                 
             }
             catch(Exception ae)
             {
                 throw ae;
             }
         }
         public static DataTable getpurchaseReturnDetails(long purchaseReutrnId, long FinancialYearID)
         {
             try
             {
                 DataTable dtpurchaseReturnDetails = SaleReportProvider.getpurchaseReturnDetails(purchaseReutrnId, FinancialYearID);
                 return dtpurchaseReturnDetails;
             }
             catch (Exception ae)
             {
                 throw ae;
             }
         }
         public static DataTable getAccountStatementTable()
         {

             DataTable dtAccountStatementTable = new DataTable();
             dtAccountStatementTable.Columns.Add("itemName", typeof(string));
             dtAccountStatementTable.Columns.Add("HNSCode", typeof(string));
             dtAccountStatementTable.Columns.Add("batchNo", typeof(string));
             dtAccountStatementTable.Columns.Add("Quantity", typeof(string));
             dtAccountStatementTable.Columns.Add("freeQuantity", typeof(string));
             dtAccountStatementTable.Columns.Add("weightIn", typeof(string));
             dtAccountStatementTable.Columns.Add("IGST", typeof(string));
             dtAccountStatementTable.Columns.Add("IGSTAmt", typeof(string));
             dtAccountStatementTable.Columns.Add("CGST", typeof(string));
             dtAccountStatementTable.Columns.Add("CGSTAmt", typeof(string));
             dtAccountStatementTable.Columns.Add("SGST", typeof(string));
             dtAccountStatementTable.Columns.Add("SGSTAmt", typeof(string));
             dtAccountStatementTable.Columns.Add("discount", typeof(string));
             dtAccountStatementTable.Columns.Add("saleRate", typeof(string));
             dtAccountStatementTable.Columns.Add("totalAmount", typeof(string));
             dtAccountStatementTable.Columns.Add("billNo", typeof(string));
             return dtAccountStatementTable;

         }
         public static DataTable OneDaySaleReport(long CustomerId,DateTime fromDate, DateTime toDate, long financialYearID,int Operation)
         {
             try
             {
                 DataTable dt = SaleReportProvider.OneDaySaleReport(CustomerId, fromDate, toDate, financialYearID, Operation);
                 return dt;
             }
             catch (Exception ex)
             {

                 throw ex;
             }
         }
    }
}
