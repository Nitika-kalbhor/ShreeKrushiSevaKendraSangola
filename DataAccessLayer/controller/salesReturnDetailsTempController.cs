using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
    public class salesReturnDetailsTempController
    {
        public static int addSalesRetrunDetails(SalesReturnDetails sale)
        {
            try
            {
                int i = salesReturnDetailsTempProvider.addSalesRetrunDetails(sale);
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
                long salesInvoiceId = salesReturnDetailsTempProvider.getMaxIdSaleRetrunInvoiceId(financialYearID);
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
                DataTable SaleItemDetails = salesReturnDetailsTempProvider.getStockInSaleItemDetails(value, type);
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
                DataTable SaleItemDetails = salesReturnDetailsTempProvider.getStockInSaleReturnItemDetails(value, type, isWholeSale);
                return SaleItemDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getSaleReturnIvoiceList(DateTime fromDate, DateTime toDate, long financialYearID)
        {
            try
            {
                DataTable dtSaleReturnDetails = salesReturnDetailsTempProvider.getSaleReturnIvoiceList(fromDate, toDate, financialYearID);
                return dtSaleReturnDetails;
            }
            catch (Exception ae)
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

        public static DataTable getsaleReturnDetails(long saleReturnId, long financialYearID)
        {
            try
            {
                DataTable dtsaleReturnDetails = salesReturnDetailsTempProvider.getsaleReturnDetails(saleReturnId, financialYearID);
                return dtsaleReturnDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        public static DataTable SaleReturnDayBook(DateTime fromDate, DateTime toDate, long financialYearId)
        {
            try
            {
                DataTable dtsaleReturnDetails = salesReturnDetailsTempProvider.SaleReturnDayBook(fromDate, toDate, financialYearId);
                return dtsaleReturnDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
