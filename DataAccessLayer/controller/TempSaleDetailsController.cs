using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
  public  class TempSaleDetailsController
  {
      public static DataTable getSaleInvoice(string salesInvoiceId, long financialYearID)
      {
          try
          {
              DataTable i = TempSaleDetailsProvider.getSaleInvoice(salesInvoiceId, financialYearID);
              return i;
          }
          catch (Exception ex)
          {

              throw ex;
          }
      }
      public static DataTable getSaleInvoiceByHSNCode(string salesInvoiceId, long financialYearID)
      {
          try
          {
              DataTable i = TempSaleDetailsProvider.getSaleInvoiceByHSNCode(salesInvoiceId, financialYearID);
              return i;
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }
      public static DataTable getTempSaleIvoiceList(DateTime fromDate, DateTime toDate)
      {
          try
          {
              DataTable i = TempSaleDetailsProvider.getTempSaleIvoiceList(fromDate, toDate);
              return i;
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }
      public static DataTable getTempSaleInvoice(string salesInvoiceId, long financialYearID)
      {
          try
          {
              DataTable i = TempSaleDetailsProvider.getTempSaleInvoice(salesInvoiceId, financialYearID);
              return i;
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }
      public static long getMaxIdTempSaleInvoiceId(long financialYearId)
      {
          try
          {
              long salesInvoiceId = TempSaleDetailsProvider.getMaxIdTempSaleInvoiceId(financialYearId);
              return salesInvoiceId;
          }
          catch (Exception ae)
          {
              throw ae;
          }

      }
      public static int addTempSalesDetails(SalesDetails sale)
      {
          try
          {
              int i = TempSaleDetailsProvider.addTempSalesDetails(sale);
              return i;
          }
          catch (Exception ex)
          {

              throw ex;
          }
      }
      public static DataTable getTempStockInItemDetails(string value)
      {
          try
          {
              DataTable listi = TempSaleDetailsProvider.getTempStockInItemDetails(value);
              return listi;
          }
          catch (Exception ae)
          {
              throw ae;
          }
      }
      public static DataTable getTempStockInSaleItemDetails(string value, string type)
      {
          try
          {
              DataTable SaleItemDetails = TempSaleDetailsProvider.getTempStockInSaleItemDetails(value, type);
              return SaleItemDetails;
          }
          catch (Exception ae)
          {
              throw ae;
          }

      }
      public static DataTable GetTempSaleBook(DateTime fromDate, DateTime toDate, long financialYearID, string opration, string cashCredit)
      {
          try
          {
              DataTable saleBookdt = TempSaleDetailsProvider.GetTempSaleBook(fromDate, toDate, financialYearID, opration, cashCredit);
              return saleBookdt;
          }
          catch (Exception ae)
          {
              throw ae;
          }
      }

      public static int addTempSalesDetailsForConvertChalan(SalesDetails salechalan)
      {
          try
          {
              int result = TempSaleDetailsProvider.addTempSalesDetailsForConvertChalan(salechalan);
              return result;
          }
          catch (Exception ae)
          {
              throw ae;
          }
      }
  }
}
