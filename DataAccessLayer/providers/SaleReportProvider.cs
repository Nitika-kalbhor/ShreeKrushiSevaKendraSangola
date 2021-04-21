using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace DataAccessLayer.providers
{
   public  class SaleReportProvider
    {

       public static DataTable AllSaleCustomerBill(DateTime fromDate, DateTime toDate, long financialYearID, string opration, string cashCredit,bool isWholeSale)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));//1
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));//2
               parameter.Add(new KeyValuePair<string, object>("@opration", opration));//3
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));//
               parameter.Add(new KeyValuePair<string, object>("@cashCredit", cashCredit));//4
               SqlHandler sqlH = new SqlHandler();
              // DataTable lists = sqlH.ExecuteAsDataTable("[dbo].[Usp_SaleBookbyGSTSlab]", parameter);
               DataTable lists = new DataTable();
               if (isWholeSale == false)
               {
                   lists = sqlH.ExecuteAsDataTable("[dbo].[Usp_SaleBookbyGSTNew]", parameter);
               }
               else
               {
                   lists = sqlH.ExecuteAsDataTable("[dbo].[Usp_WholeSaleBookbyGSTNew]", parameter);
               }
               return lists;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable PurchaseDayBook(DateTime fromDate, DateTime toDate, string opration, long FinancialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));//2
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));//3
               parameter.Add(new KeyValuePair<string, object>("@opration", opration));
               parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
               SqlHandler sqlH = new SqlHandler();
            
               DataTable lists = sqlH.ExecuteAsDataTable("[dbo].[Usp_PurchaseBookbyGSTSlabNew]", parameter);
               return lists;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable PurchaseReturnDayBook(DateTime fromDate, DateTime toDate, long FinancialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));//2
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));//3
               parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));//3
               SqlHandler sqlH = new SqlHandler();
              DataTable lists = sqlH.ExecuteAsDataTable("[dbo].[Usp_PurchaseReutrnBookbyGSTSlab]", parameter);
               
               return lists;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable SaleReturnDayBook(DateTime fromDate, DateTime toDate, long finacialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));//1
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));//2
               parameter.Add(new KeyValuePair<string, object>("@finacialYearID", finacialYearID));//3
               SqlHandler sqlH = new SqlHandler();
             //  DataTable lists = sqlH.ExecuteAsDataTable("[dbo].[Usp_SaleReturnBookbyGSTSlab]", parameter);
               DataTable lists = sqlH.ExecuteAsDataTable("[dbo].[Usp_SaleReturnBookbyGSTSlabNew]", parameter);
               return lists;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getSaleReports(long itemId, DateTime toDate, DateTime fromDate, Boolean isQaution)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));//1
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));//2
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));//3
               parameter.Add(new KeyValuePair<string, object>("@isQuation", isQaution));//4
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleReports]", parameter);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static DataTable getAccountStatement(long accountName, string opreation, long saleId, DateTime fromDate, DateTime toDate, long financialYearID, Boolean isQaution, string MainCategoryName)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@accountName", accountName));//1
               parameter.Add(new KeyValuePair<string, object>("@opreation", opreation));//2
               parameter.Add(new KeyValuePair<string, object>("@saleId", saleId));//3
               parameter.Add(new KeyValuePair<string, object>("@isQuation", isQaution));//4
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));//5
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));//6
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));//7
               parameter.Add(new KeyValuePair<string, object>("@MainCategoryName", MainCategoryName));//7
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getAccountStatement]", parameter);
               return i;

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
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@saleReturnId", saleReturnId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable dtsalereturnDetails = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleReturnDetails]",parameter);
               return dtsalereturnDetails;
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
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@purchaseReutrnId", purchaseReutrnId));
               parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable dtpurchaseReturnDetails = sqlH.ExecuteAsDataTable("[dbo].[Usp_getpurchaseReturnDetails]", parameter);
               return dtpurchaseReturnDetails;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       internal static DataTable OneDaySaleReport(long CustomerId, DateTime fromDate, DateTime toDate, long financialYearID,int operation)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@customerId", CustomerId));
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
               parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", financialYearID));
               parameter.Add(new KeyValuePair<string, object>("@Operation", operation));
               SqlHandler sqlH = new SqlHandler();
               DataTable lists = sqlH.ExecuteAsDataTable("[dbo].[Usp_getOneDaySaleReport]", parameter);
               return lists;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
    }
}
