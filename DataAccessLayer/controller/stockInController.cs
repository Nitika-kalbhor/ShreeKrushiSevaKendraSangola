using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DataAccessLayer.controller
{
    public class stockInController
    {
        public static int addStockInDetails(PurchaseDetails purchaseChalan)
        {
            try
            {
                int purchaseReutrnInvoiceId = StockInProvider.addStockInDetails(purchaseChalan);
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static long getMaxStockInId()
        {
            try
            {
                long purchaseReutrnInvoiceId = StockInProvider.getMaxStockInId();
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static long getMaxStockInId(long FinancilaYearId)
        {
            try
            {
                long purchaseReutrnInvoiceId = StockInProvider.getMaxStockInId(FinancilaYearId);
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getStockInList(DateTime fromDate, DateTime toDate, long FinancialYearID)
        {
            try
            {
                DataTable i = StockInProvider.getStockInList(fromDate, toDate, FinancialYearID);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getStockInDetails(long SalesChallanBillId, long FinancialYearID)
        {
            try
            {
                DataTable dsSaleChallan = StockInProvider.getStockInDetails(SalesChallanBillId, FinancialYearID);
                return dsSaleChallan;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static int deleteStockInRow(long SalesChallanBillId, long stockInItemID, long itemID, long categoryID, long companyId, string batchNo, double quantity)
        {
            try
            {
                int i = StockInProvider.deleteStockInRow(SalesChallanBillId, stockInItemID, itemID, categoryID, companyId, batchNo, quantity);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
