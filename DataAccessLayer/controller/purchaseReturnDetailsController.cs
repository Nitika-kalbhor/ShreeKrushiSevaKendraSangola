using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using DataAccessLayer.providers;
using System.Data;

namespace DataAccessLayer.controller
{
 public   class purchaseReturnDetailsController
    {
     public static int addPurchaseReturnDetails(PurchaseReutrnDetails Purchase,PusrchaseSaleAccount p)
     {
         try
         {
             int i = purchaseReturnDetailsProvider.addPurchaseReturnDetails(Purchase,p);
             return i;
         }
         catch (Exception ex)
         {

             throw ex;
         }
     }
     public static DataTable getPurchaseReturnList(DateTime fromDate, DateTime toDate, long FinancialYearID)
     {
         try
         {
             DataTable dt = purchaseReturnDetailsProvider.getPurchaseReturnList(fromDate, toDate, FinancialYearID);
             return dt;
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
             DataTable dtPurchaseReturn = purchaseReturnDetailsProvider.getPurchaseReturnIvoiceDetails(purchaseReturnId, FinancialYearID);
             return dtPurchaseReturn;
         }
         catch (Exception ae)
         {
             throw ae;
         }
     }
    }
}
