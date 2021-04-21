using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DataAccessLayer.controller
{
   public class SaleDetailsController
    {
       public static long getMaxIdSaleInvoiceId(long financialYearId)
       {
           try
           {
               long salesInvoiceId = salesDetailsProvider.getMaxIdSaleInvoiceId(financialYearId);
               return salesInvoiceId;
           }
           catch (Exception ae)
           {
               throw ae;
           }

       }
       public static long getWholeMaxIdSaleInvoiceId(long financialYearId)
       {
           try
           {
               long salesInvoiceId = salesDetailsProvider.getWholeMaxIdSaleInvoiceId(financialYearId);
               return salesInvoiceId;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static long getMaxIdSalesItemDetails(int p, long financialYearID)
       {
           try
           {
               long salesInvoiceId = salesDetailsProvider.getMaxIdSalesItemDetails(p, financialYearID);
               return salesInvoiceId;
           }
           catch (Exception ae)
           {
               throw ae;
           }

       }
       public static long getWholeMaxIdSalesItemDetails(int p, long financialYearID)
       {
           try
           {
               long salesInvoiceId = salesDetailsProvider.getWholeMaxIdSalesItemDetails(p, financialYearID);
               return salesInvoiceId;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
        public static int addSalesDetails(SalesDetails sale,PusrchaseSaleAccount purchase)
        {
            try
            {
                int i = salesDetailsProvider.addSalesDetails(sale, purchase);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
     
        public static long getcustomerMaxId()
        {
            try
            {


                long customerId = salesDetailsProvider.getcustomerMaxId();
                return customerId;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getStockInSaleItemDetails(string value, string type, bool isWholeSale)
        {
            try
            {
                DataTable SaleItemDetails = salesDetailsProvider.getStockInSaleItemDetails(value, type, isWholeSale);
                return SaleItemDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getEmptySaleItem()
        {
            try
            {
                DataTable i = salesDetailsProvider.getEmptySaleItem();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       public static DataTable getSaleIvoiceList(DateTime fromDate,DateTime toDate)
        {
            try
            {
                DataTable i = salesDetailsProvider.getSaleIvoiceList(fromDate, toDate);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       public static DataTable getSaleInvoice(string salesInvoiceId, long financialYearID)
       {
           try
           {
               DataTable i = salesDetailsProvider.getSaleInvoice(salesInvoiceId, financialYearID);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static int deleteSalesInvoiceRow(string saleID,string stateCode,long salesItemDetailsId, long itemID, long categoryID, long companyId, string batchNo, double quantity,long StockId,double IGSTAmt,double IGST,bool isWholeSale)
       {
           try
           {
               int i = salesDetailsProvider.deleteSalesInvoiceRow(saleID, stateCode, salesItemDetailsId, itemID, categoryID, companyId, batchNo, quantity, StockId, IGSTAmt, IGST, isWholeSale);
               return i;
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
        #region --Sale Challan-
        public static long getMaxIdSaleChallanInvoiceId(long financilaYearID)
        {
            try
            {
                long saleChallanInvoiceId = salesDetailsProvider.getMaxIdSaleChallanInvoiceId(financilaYearID);
                return saleChallanInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static int addSalesChallanDetails(SalesDetails saleChallan)
        {
            try
            {
                int i = salesDetailsProvider.addSalesChallanDetails(saleChallan);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       //use for sale challan
       public static DataTable getChallenList(DateTime fromDate,DateTime toDate,long financialYearID)
        {
            try
            {
                DataTable i = salesDetailsProvider.getChallenList(fromDate, toDate, financialYearID);
                return i;
            }
           catch(Exception ex)
            {
                throw ex;
            }
        }
       public static DataTable getChallenList(long customerId, DateTime fromDate, DateTime toDate,long financialYearID)
       {
           try
           {
               DataTable i = salesDetailsProvider.getChallenList(customerId, fromDate, toDate, financialYearID);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static DataTable getSaleChallenDetails(long salesChallanId,long financialYearID)
       {
           try
           {
               DataTable dsSaleChallan = salesDetailsProvider.getSaleChallenDetails(salesChallanId, financialYearID);
               return dsSaleChallan;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
       public static int deleteRow(long SalesChallanBillId,long salesChallanItemDetailsId, long itemID, long categoryID, long companyId, string batchNo,double quantity,
           long StockId)
       {
           try
           {
               int i = salesDetailsProvider.deleteRow(SalesChallanBillId, salesChallanItemDetailsId, itemID, categoryID, companyId, batchNo, quantity, StockId);
               return i;
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
        #endregion
       #region --Sale Order-
       public static long getMaxIdSalesOrderId(long financialYearID)
       {
           try
           {
               long saleChallanInvoiceId = salesDetailsProvider.getMaxIdSalesOrderId(financialYearID);
               return saleChallanInvoiceId;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static int addSalesOrderDetails(SalesDetails saleChallan)
       {
           try
           {
               int i = salesDetailsProvider.addSalesOrderDetails(saleChallan);
               return i;
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
       public static DataTable getSalesOrderList(DateTime fromDate, DateTime toDate,long financialYearID)
       {
           try
           {
               DataTable i = salesDetailsProvider.getSalesOrderList(fromDate, toDate, financialYearID);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static DataTable getSaleOrderDetails(long SalesOrderBillId,long financialYearID)
       {
           try
           {
               DataTable dsSaleChallan = salesDetailsProvider.getSaleOrderDetails(SalesOrderBillId, financialYearID);
               return dsSaleChallan;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static int DeletSaleOrderRow(long SalesOrderBillId, long itemID, long categoryID, long companyId, string batchNo, double quantity)
       {
           try
           {
               int i = salesDetailsProvider.DeletSaleOrderRow(SalesOrderBillId, itemID, categoryID, companyId, batchNo, quantity);
               return i;
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
       public static int addSalesDetailsForConvertChalan(SalesDetails sale, PusrchaseSaleAccount purchase)
       {
           try
           {
               int i = salesDetailsProvider.addSalesDetailsForConvertChalan(sale, purchase);
               return i;
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
       #endregion

       public static DataTable getminimumPurchaseRate(long itemId, long companyId, long categoryId, string batchNo, string unitBy)
       {
           try
           {
               DataTable dt = new DataTable();
               dt = salesDetailsProvider.getminimumPurchaseRate(itemId, companyId, categoryId, batchNo, unitBy);
               return dt;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getWholeSaleIvoiceList(DateTime fromDate, DateTime toDate)
       {
           try
           {
               DataTable dtSaleDetailsList = new DataTable();
               dtSaleDetailsList = salesDetailsProvider.getWholeSaleIvoiceList(fromDate,toDate);
               return dtSaleDetailsList;
           }
           catch(Exception ex)
           {
               throw ex; 
           }
       }

       public static DataTable getWholeSaleInvoice(string salesInvoiceId, long financialyearID)
       {
           try
           {
               DataTable dtSalesDetails = new DataTable();
               dtSalesDetails = salesDetailsProvider.getWholeSaleInvoice(salesInvoiceId, financialyearID);
               return dtSalesDetails;
             

           }
           catch(Exception ex)
           {
               throw ex;
           }
       }
       public static bool getInvoice(string invoiceNO, long CustomerID, long financialYearID)
       {
           try
           {
               Boolean isExists = salesDetailsProvider.getInvoice(invoiceNO, CustomerID, financialYearID);
               return isExists;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
    }
}
