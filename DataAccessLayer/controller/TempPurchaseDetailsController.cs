using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
    public class TempPurchaseDetailsController
    {

        public static bool getInvoice(string invoiceNo, long dealerId, long financialYearId)
        {
            try
            {
                bool result = TempPurchaseDetailsProvider.getInvoice(invoiceNo, dealerId, financialYearId);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getSaleChallenDetails(long purchaseChalanId, long financialYearId)
        {
            try
            {
                DataTable dtSaleChalan = TempPurchaseDetailsProvider.getSaleChallenDetails(purchaseChalanId, financialYearId);
                return dtSaleChalan;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void deleteRow(long purchaseChalanId, long purchaseChalanItemDetailId, double quantity, long StockId, long financialYearId)
        {
            try
            {
                int result = TempPurchaseDetailsProvider.deleteRow(purchaseChalanId, purchaseChalanItemDetailId, quantity, StockId, financialYearId);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getChallenList(DateTime fromDate, DateTime toDate, long financialYearId)
        {
            try
            {
                DataTable dtChalan = TempPurchaseDetailsProvider.getChallenList(fromDate, toDate, financialYearId);
                return dtChalan;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int addPurchaseChalanDetails(PurchaseDetails purch)
        {
            try
            {
                int result = TempPurchaseDetailsProvider.addPurchaseChalanDetails(purch);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static long getMaxIdPurchaseChalanId()
        {
            try
            {
                long purchChalanId = TempPurchaseDetailsProvider.getMaxIdPurchaseChalanId();
                return purchChalanId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool getpurchaseChalanNo(string invoicNo, long dealerId, long financialYearId)
        {
            try
            {
                bool result = TempPurchaseDetailsProvider.getpurchaseChalanNo(invoicNo, dealerId, financialYearId);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getStockInItemDetails(string value)
        {
            try
            {
                DataTable dtStock = TempPurchaseDetailsProvider.getStockInItemDetails(value);
                return dtStock;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getChallenList(long dealerId, DateTime fromDate, DateTime toDate, long financialYearId)
        {
            try
            {
                DataTable dtPurchaseChalan = TempPurchaseDetailsProvider.getChallenList(dealerId, fromDate, toDate, financialYearId);
                return dtPurchaseChalan;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static long getMaxIdPurchaseInvoiceId()
        {
            try
            {
                long purchaseInvoiceId = TempPurchaseDetailsProvider.getMaxIdPurchaseInvoiceId();
                return purchaseInvoiceId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int addPurchaseDetails(PurchaseDetails purchase)
        {
            try
            {
                int result = TempPurchaseDetailsProvider.addPurchaseDetails(purchase);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static double getPaymentDueAmountDealer(long dealerId, string opration, long financialYearId)
        {
            try
            {
                double dueAmount = TempPurchaseDetailsProvider.getPaymentDueAmountDealer(dealerId, opration, financialYearId);
                return dueAmount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void deletePurchseInvoiceRow(long purchaseId, long purchaseItemDetailId, double quantity, long stockId, long financialYearId)
        {
            try
            {
                int result = TempPurchaseDetailsProvider.deletePurchseInvoiceRow(purchaseId, purchaseItemDetailId, quantity, stockId, financialYearId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getPurchaseList(DateTime fromDate, DateTime toDate, long financialYearId)
        {
            try
            {
                DataTable dtPurchaselist = TempPurchaseDetailsProvider.getPurchaseList(fromDate, toDate, financialYearId);
                return dtPurchaselist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getPurchaseIvoiceDetails(long purchaseId, long financialYearId)
        {
            try
            {
                DataTable dtPurchase = TempPurchaseDetailsProvider.getPurchaseIvoiceDetails(purchaseId, financialYearId);
                return dtPurchase;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static long getMaxIdPurchaseReturnInvoiceId(long financialYearId)
        {
            try
            {
                long PurchaseReturnInoviceId = TempPurchaseDetailsProvider.getMaxIdPurchaseReturnInvoiceId(financialYearId);
                return PurchaseReturnInoviceId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable PurchaseDayBook(DateTime fromDate, DateTime toDate, string opration, long financialYearId)
        {
            try
            {
                DataTable dtPurchaseDayBook = TempPurchaseDetailsProvider.PurchaseDayBook(fromDate, toDate, opration, financialYearId);
                return dtPurchaseDayBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
