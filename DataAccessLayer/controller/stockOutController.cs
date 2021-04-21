using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DataAccessLayer.controller
{
 public   class stockOutController
    {
     public static int addStockOutDetails(PurchaseDetails purchaseChalan)
        {
            try
            {
                int purchaseReutrnInvoiceId = StockOutProvider.addStockOutDetails(purchaseChalan);
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
     public static long getMaxStockOutId(long financialYearID)
        {
            try
            {
                long purchaseReutrnInvoiceId = StockOutProvider.getMaxStockOutId(financialYearID);
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
     public static DataTable getStockOutList(DateTime fromDate, DateTime toDate,long financialYearID)
        {
            try
            {
                DataTable i = StockOutProvider.getStockOutList(fromDate, toDate, financialYearID);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
     public static DataTable getStockOutDetails(long SalesChallanBillId,long financialYearID)
        {
            try
            {
                DataTable dsSaleChallan = StockOutProvider.getStockOutDetails(SalesChallanBillId, financialYearID);
                return dsSaleChallan;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
     public static int deleteStockOutRow(long SalesChallanBillId,long stockOutItemID, long itemID, long categoryID, long companyId, string batchNo, double quantity)
        {
            try
            {
                int i = StockOutProvider.deleteStockOutRow(SalesChallanBillId,stockOutItemID, itemID, categoryID, companyId, batchNo, quantity);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    
    }
}
