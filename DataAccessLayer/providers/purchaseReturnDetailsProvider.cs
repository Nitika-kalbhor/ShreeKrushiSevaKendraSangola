using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace DataAccessLayer.providers
{
   public class purchaseReturnDetailsProvider
    {
       #region defination & declaration
       private static string _connectionString = SystemSetting.ConnectionString;
       #endregion
       public static int addPurchaseReturnDetails(PurchaseReutrnDetails Purchase, PusrchaseSaleAccount purch)
       {
         using (var Conn = new SqlConnection(_connectionString))
            {
                SqlHandler sqlH = new SqlHandler();
                SqlTransaction trans = null;
                try
                {
                    Conn.Open();
                    trans = Conn.BeginTransaction();
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@purchaseReutrnInvoiceId", Purchase.purchaseReutrnInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@purchaseReutrnId", Purchase.purchaseReutrnId));
               parameter.Add(new KeyValuePair<string, object>("@dealerId", Purchase.dealerId));
               parameter.Add(new KeyValuePair<string, object>("@challanDate", Purchase.challanDate));
               parameter.Add(new KeyValuePair<string, object>("@remark", Purchase.remark));
               parameter.Add(new KeyValuePair<string, object>("@netBillAmount", Purchase.netBillAmount));
               parameter.Add(new KeyValuePair<string, object>("@paidAmount", Purchase.paidAmount));
               parameter.Add(new KeyValuePair<string, object>("@paymentType", Purchase.paymentType));
               parameter.Add(new KeyValuePair<string, object>("@bankName", Purchase.bankName));
               parameter.Add(new KeyValuePair<string, object>("@bankId", Purchase.bankId));
               parameter.Add(new KeyValuePair<string, object>("@chequeDate", Purchase.chequeDate));
               parameter.Add(new KeyValuePair<string, object>("@refNo", Purchase.chequeNo_refNo));
               parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));
               parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.UtcNow));
               parameter.Add(new KeyValuePair<string, object>("@state", Purchase.state));
               parameter.Add(new KeyValuePair<string, object>("@stateCode", Purchase.stateCode));
               parameter.Add(new KeyValuePair<string, object>("@isDelete", Purchase.isDelete));
               parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));
               parameter.Add(new KeyValuePair<string, object>("@purchaseInvoiceNo", Purchase.purchaseInvoiceNo));
               parameter.Add(new KeyValuePair<string, object>("@purchaseDate", Purchase.purchaseDate));
             
               int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addPurchaseReturnDetails]", parameter,Conn,trans);
               int result = 0;
               if (Purchase.isDelete == false)
               {
                   ///Save Gst Account Group Payment Due Table
                   List<KeyValuePair<string, object>> parameterGroup = new List<KeyValuePair<string, object>>();
                   parameterGroup.Add(new KeyValuePair<string, object>("@transactionId", purch.transactionId));
                   parameterGroup.Add(new KeyValuePair<string, object>("@billId", purch.billId));
                   parameterGroup.Add(new KeyValuePair<string, object>("@RoundOff", purch.RoundOff));
                   parameterGroup.Add(new KeyValuePair<string, object>("@discount", purch.discount));
                   parameterGroup.Add(new KeyValuePair<string, object>("@Hamali", purch.Hamali));
                   parameterGroup.Add(new KeyValuePair<string, object>("@Igst5", purch.Igst5));
                   parameterGroup.Add(new KeyValuePair<string, object>("@Igst12", purch.Igst12));
                   parameterGroup.Add(new KeyValuePair<string, object>("@Igst18", purch.Igst18));
                   parameterGroup.Add(new KeyValuePair<string, object>("@Igst28", purch.Igst28));
                   parameterGroup.Add(new KeyValuePair<string, object>("@salePurchaseAccount", purch.salePurchaseAccount));
                   parameterGroup.Add(new KeyValuePair<string, object>("@issalePurchase", purch.issalePurchase));
                   parameterGroup.Add(new KeyValuePair<string, object>("@stateCode", purch.stateCode));
                   parameterGroup.Add(new KeyValuePair<string, object>("@transactionDate", Purchase.challanDate));
                   parameterGroup.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));
                   result = sqlH.ExecuteNonQueryI("[dbo].[Usp_addAllPurchasesReturnAccount]", parameterGroup);
                   ///End
                   ///
               }
               for (int k = 0; k < Purchase.PurchaseRetrunItemTable.Rows.Count; k++)
               {
                   List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();
                   parameter1.Add(new KeyValuePair<string, object>("@purchaseReutrnInvoiceId", Purchase.purchaseReutrnInvoiceId));
                   parameter1.Add(new KeyValuePair<string, object>("@itemId", Purchase.PurchaseRetrunItemTable.Rows[k]["itemId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@purchaseReutrnItemDetailId", Purchase.PurchaseRetrunItemTable.Rows[k]["purchaseReutrnItemDetailId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@stockId", Purchase.PurchaseRetrunItemTable.Rows[k]["stockId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@companyId", Purchase.PurchaseRetrunItemTable.Rows[k]["companyId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@categoryId", Purchase.PurchaseRetrunItemTable.Rows[k]["categoryId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@Quantity", Purchase.PurchaseRetrunItemTable.Rows[k]["Quantity"]));
                   parameter1.Add(new KeyValuePair<string, object>("@FreeQuantity", Purchase.PurchaseRetrunItemTable.Rows[k]["freeQuantity"]));
                   parameter1.Add(new KeyValuePair<string, object>("@IGST", Purchase.PurchaseRetrunItemTable.Rows[k]["IGST"]));
                   parameter1.Add(new KeyValuePair<string, object>("@CGST", Purchase.PurchaseRetrunItemTable.Rows[k]["CGST"]));
                   parameter1.Add(new KeyValuePair<string, object>("@SGST", Purchase.PurchaseRetrunItemTable.Rows[k]["SGST"]));
                   parameter1.Add(new KeyValuePair<string, object>("@batchNo", Purchase.PurchaseRetrunItemTable.Rows[k]["batchNo"]));
                   parameter1.Add(new KeyValuePair<string, object>("@unitBy", Purchase.PurchaseRetrunItemTable.Rows[k]["unitBy"]));
                   parameter1.Add(new KeyValuePair<string, object>("@discount", Purchase.PurchaseRetrunItemTable.Rows[k]["discount"]));

                   parameter1.Add(new KeyValuePair<string, object>("@purchaseRate", Purchase.PurchaseRetrunItemTable.Rows[k]["purchaseRate"]));
                   parameter1.Add(new KeyValuePair<string, object>("@salesCashRate", Purchase.PurchaseRetrunItemTable.Rows[k]["salesCashRate"]));
                   parameter1.Add(new KeyValuePair<string, object>("@salesCreditRate", 0));
                   parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCashRate", 0));
                   parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate", 0));
                   parameter1.Add(new KeyValuePair<string, object>("@addedBy", 1));
                   parameter1.Add(new KeyValuePair<string, object>("@addedOn", Purchase.challanDate));
                   parameter1.Add(new KeyValuePair<string, object>("@isDelete", Purchase.isDelete));
                   parameter1.Add(new KeyValuePair<string, object>("@purchaseReutrnId", Purchase.purchaseReutrnId));
                   parameter1.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));
                   //parameter1.Add(new KeyValuePair<string, object>("@state", Purchase.PurchaseRetrunItemTable.Rows[k]["state"]));
                   //parameter1.Add(new KeyValuePair<string, object>("@stateCode", Purchase.PurchaseRetrunItemTable.Rows[k]["stateCode"]));
                  
                   result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addPurchaseReturnStockUpdate]", parameter1,Conn,trans);
               }

               trans.Commit();
               return i;
                }
                catch (Exception ex)
                {
                    if (trans != null) trans.Rollback();
                    throw ex;
                }
                finally { Conn.Close(); }
            }
       }
       public static DataTable getPurchaseReturnList(DateTime fromDate, DateTime toDate, long FinancialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
               parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable dtPurchaseReturn = sqlH.ExecuteAsDataTable("[dbo].[Usp_getPurchaseReturnList]", parameter);
               return dtPurchaseReturn;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getPurchaseReturnIvoiceDetails(long purchaseReturnId, long FinancialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@purchaseReutrnId", purchaseReturnId));
               parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable dtpurchaseReturn = sqlH.ExecuteAsDataTable("[dbo].[Usp_getPurchaseReturnDetails]", parameter);
               return dtpurchaseReturn;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
    }
}
