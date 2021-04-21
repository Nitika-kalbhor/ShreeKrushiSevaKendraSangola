using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DataAccessLayer.controller
{
    public class purchaseDetailsController
    {
        public static int addPurchaseDetails(PurchaseDetails Purchase,PusrchaseSaleAccount purchSale)
        {
            try
            {
                int i = purchaseDetailsProvider.addPurchaseDetails(Purchase, purchSale);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int addPurchaseDetailsByChalanConvert(PurchaseDetails purchase, PusrchaseSaleAccount purchSale)
        {
            try
            {
                int i = purchaseDetailsProvider.addPurchaseDetailsByChalanConvert(purchase, purchSale);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getEmptyDataTableInPurchaseItemReturn()
        {
            try
            {
                DataTable i = purchaseDetailsProvider.getEmptyDataTableInPurchaseItemReturn();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getEmptyDataTableInPurchaseItem()
        {
            try
            {
                DataTable i = purchaseDetailsProvider.getEmptyDataTableInPurchaseItem();
                return i;
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
                long purchaseInvoiceId = purchaseDetailsProvider.getMaxIdPurchaseInvoiceId();
                return purchaseInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        
        public static DataTable getPurchaseList(DateTime fromDate, DateTime toDate,long financialYearID)
        {
            try
            {
                DataTable i = purchaseDetailsProvider.getPurchaseList(fromDate, toDate, financialYearID);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getPurchaseIvoiceDetails(long purchaseId,long financialYearID)
        {
            try
            {
                DataTable dsPurchase = purchaseDetailsProvider.getPurchaseIvoiceDetails(purchaseId, financialYearID);
                  return dsPurchase;
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }
         public static int deletePurchseInvoiceRow(long purchaseId,long purchaseItemDetailId, long itemID, long categoryID, 
             long companyId, string batchNo, double quantity,double freeQuantity ,long stockId)
        {
            try
            {
                int i = purchaseDetailsProvider.deletePurchseInvoiceRow(purchaseId, purchaseItemDetailId, itemID, categoryID, companyId, batchNo, quantity, freeQuantity, stockId);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
         public static long getMaxIdPurchaseReturnInvoiceId(long FinancialYearID)
         {
             try
             {
                 long purchaseReutrnInvoiceId = purchaseDetailsProvider.getMaxIdPurchaseReturnInvoiceId(FinancialYearID);
                 return purchaseReutrnInvoiceId;
             }
             catch (Exception ae)
             {
                 throw ae;
             }

         }
        public static double getPaymentDeuAmtDealer(long dealerId,long finacialYearId)
        {
            try
            {
                double i = purchaseDetailsProvider.getPaymentDeuAmtDealer(dealerId, finacialYearId);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #region -- Purchase Chalan -
        public static int addPurchaseChalanDetails(PurchaseDetails purchaseChalan)
        {
            try
            {
                int purchaseReutrnInvoiceId = purchaseDetailsProvider.addPurchaseChalanDetails(purchaseChalan);
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static long getMaxIdPurchaseChalanId()
        {
            try
            {
                long purchaseReutrnInvoiceId = purchaseDetailsProvider.getMaxIdPurchaseChalanId();
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        //use for purchase challan
        public static DataTable getChallenList(DateTime fromDate, DateTime toDate, long FinancialYearID)
        {
            try
            {
                DataTable i = purchaseDetailsProvider.getChallenList(fromDate, toDate, FinancialYearID);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getChallenList(long dealerId, DateTime fromDate, DateTime toDate, long FinancialYearID)
        {
            try
            {
                DataTable i = purchaseDetailsProvider.getChallenList(dealerId, fromDate, toDate, FinancialYearID);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getSaleChallenDetails(long purchaseChalanId, long FinancialYearID)
        {
            try
            {
                DataTable dsSaleChallan = purchaseDetailsProvider.getSaleChallenDetails(purchaseChalanId, FinancialYearID);
                return dsSaleChallan;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static int deleteRow(long SalesChallanBillId,long purchaseChalanItemDetailId, long itemID, long categoryID, long companyId, string batchNo, double quantity,long StockId)
        {
            try
            {
                int i = purchaseDetailsProvider.deleteRow(SalesChallanBillId, purchaseChalanItemDetailId, itemID, categoryID, companyId, batchNo, quantity, StockId);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    
        #endregion
        #region -- Purchase Order --
        public static int addPurchaseOrderDetails(PurchaseDetails purchaseChalan)
        {
            try
            {
                int purchaseReutrnInvoiceId = purchaseDetailsProvider.addPurchaseOrderDetails(purchaseChalan);
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static long getMaxIdPurchaseOrderId(long FinancialYearID)
        {
            try
            {
                long purchaseReutrnInvoiceId = purchaseDetailsProvider.getMaxIdPurchaseOrderId(FinancialYearID);
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getOrderList(DateTime fromDate, DateTime toDate, long FinancialYearID)
        {
            try
            {
                DataTable i = purchaseDetailsProvider.getOrderList(fromDate, toDate, FinancialYearID);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getPurchaseOrderDetails(long purchaseOrderId, long FinancialYearID)
        {
            try
            {
                DataTable dsSaleChallan = purchaseDetailsProvider.getPurchaseOrderDetails(purchaseOrderId, FinancialYearID);
                return dsSaleChallan;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static int deletePurchaseOrderRow(long purchaseOrderId, long itemID, long categoryID, long companyId, string batchNo, double quantity)
        {
            try
            {
                int i = purchaseDetailsProvider.deletePurchaseOrderRow(purchaseOrderId, itemID, categoryID, companyId, batchNo, quantity);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    
        #endregion

        public static bool getInvoice(string invoiceNO, long dealerID, long financialYearID)
        {
            try
            {
                Boolean isExists = purchaseDetailsProvider.getInvoice(invoiceNO,dealerID,financialYearID);
                return isExists;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static bool getpurchaseChalanNo(string invoiceNo, long dealerID, long financialYearID)
        {
            try
            {
                Boolean isExists = purchaseDetailsProvider.getpurchaseChalanNo(invoiceNo, dealerID, financialYearID);
                return isExists;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
