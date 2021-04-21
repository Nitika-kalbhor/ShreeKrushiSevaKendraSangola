using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using DataAccessLayer.models;
using DataAccessLayer.providers;

namespace DataAccessLayer.controller
{
   public class salesReturnDetailsController
    {
       public static int addSalesRetrunDetails(SalesReturnDetails sale, PusrchaseSaleAccount purchase)
        {
            try
            {
                int i = salesReturnDetailsProvider.addSalesRetrunDetails(sale, purchase);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       public static long getMaxIdSaleRetrunInvoiceId(long financialYearID)
       {
           try
           {
               long salesInvoiceId = salesReturnDetailsProvider.getMaxIdSaleRetrunInvoiceId(financialYearID);
               return salesInvoiceId;
           }
           catch (Exception ae)
           {
               throw ae;
           }

       }
        //public static long getcustomerMaxId()
        //{
        //    try
        //    {


        //        long customerId = salesDetailsProvider.getcustomerMaxId();
        //        return customerId;
        //    }
        //    catch (Exception ae)
        //    {
        //        throw ae;
        //    }

        //}
        public static DataTable getStockInSaleItemDetails(string value, string type)
        {
            try
            {
                DataTable SaleItemDetails = salesReturnDetailsProvider.getStockInSaleItemDetails(value, type);
                return SaleItemDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

        public static DataTable getStockInSaleReturnItemDetails(string value, string type, bool isWholeSale)
        {
            try
            {
                DataTable SaleItemDetails = salesReturnDetailsProvider.getStockInSaleReturnItemDetails(value, type, isWholeSale);
                return SaleItemDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getSaleReturnIvoiceList(DateTime fromDate,DateTime toDate,long financialYearID)
        {
            try
            {
                DataTable dtSaleReturnDetails = salesReturnDetailsProvider.getSaleReturnIvoiceList(fromDate, toDate, financialYearID);
                return dtSaleReturnDetails;
            }
            catch(Exception ae)
            {
                throw ae;
            }

        }
        //public static DataTable getEmptySaleItem()
        //{
        //    try
        //    {
        //        DataTable i = salesDetailsProvider.getEmptySaleItem();
        //        return i;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
