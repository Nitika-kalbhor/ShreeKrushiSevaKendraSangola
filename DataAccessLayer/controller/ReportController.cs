using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using DataAccessLayer.providers;
using System.Data;

namespace DataAccessLayer.controller
{
 public   class ReportController
    {
     public static DataTable getServer()
     {
         try
         {
             DataTable i = ReportProvider.getServer();
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
             DataTable i = ReportProvider.getSaleInvoice(salesInvoiceId, financialYearID);
             return i;
         }
         catch (Exception ex)
         {

             throw ex;
         }
     }
     //public static DataTable getSaleInvoiceByChalan(string salesInvoiceId, long financialYearID)
     //{
     //    try
     //    {
     //        DataTable i = ReportProvider.getSaleInvoiceByChalan(salesInvoiceId, financialYearID);
     //        return i;
     //    }
     //    catch (Exception ex)
     //    {

     //        throw ex;
     //    }
     //}
     public static DataTable getSaleInvoiceByHSNCode(string salesInvoiceId, long financialYearID)
     {
         try
         {
             DataTable i = ReportProvider.getSaleInvoiceByHSNCode(salesInvoiceId, financialYearID);
             return i;
         }
         catch (Exception ex)
         {
             throw ex;
         }
     }
     public static DataTable getcheckSaleInvoice(string salesInvoiceId, long financialYearID)
     {
         try
         {
             DataTable i = ReportProvider.getcheckSaleInvoice(salesInvoiceId, financialYearID);
             return i;
         }
         catch (Exception ex)
         {
             throw ex;
         }
     }
     public static DataTable getSaleSeedInvoice(string salesInvoiceId, long financialYearID)
     {
         try
         {
             DataTable i = ReportProvider.getSaleSeedInvoice(salesInvoiceId, financialYearID);
             return i;
         }
         catch(Exception ae)
         {
             throw ae;
         }
     }

     public static DataTable getSaleFerTilizerInvoice(string salesInvoiceId, long financialYearID)
     {
         try
         {
             DataTable i = ReportProvider.getSaleFerTilizerInvoice(salesInvoiceId, financialYearID);
             return i;
         }
         catch (Exception ae)
         {
             throw ae;
         }
     }

     public static DataTable getSaleInsectisideInvoice(string salesInvoiceId, long financialYearID)
     {
         try
         {
             DataTable i = ReportProvider.getSaleInsectisideInvoice(salesInvoiceId, financialYearID);
             return i;
         }
         catch (Exception ae)
         {
             throw ae;
         }
     }

     public static DataTable getPGROtherInvoice(string SaleID, long financialYearID)
     {
         try
         {
             DataTable dtPGROther = ReportProvider.getPGROtherInvoice(SaleID, financialYearID);
             return dtPGROther;
         }
         catch(Exception ae)
         {
             throw ae;
         }
     }

     public static DataTable getWholeSaleInvoice(string SaleID, long financialYearID)
     {
         try
         {
             DataTable i = ReportProvider.getWholeSaleInvoice(SaleID, financialYearID);
             return i;
         }
         catch (Exception ex)
         {

             throw ex;
         }
     }

     public static DataTable getcheckWholeSaleInvoice(string salesInvoiceId, long financialYearID)
     {
         try
         {
             DataTable i = ReportProvider.getcheckWholeSaleInvoice(salesInvoiceId, financialYearID);
             return i;
         }
         catch (Exception ex)
         {
             throw ex;
         }
     }

     public static DataTable getWholeSaleSeedInvoice(string SaleID, long financialYearID)
     {
         try
         {
             DataTable i = ReportProvider.getWholeSaleSeedInvoice(SaleID, financialYearID);
             return i;
         }
         catch (Exception ae)
         {
             throw ae;
         }
     }

     public static DataTable getWholeSaleInsectisideInvoice(string SaleID, long financialYearID)
     {
         try
         {
             DataTable i = ReportProvider.getWholeSaleInsectisideInvoice(SaleID, financialYearID);
             return i;
         }
         catch (Exception ae)
         {
             throw ae;
         }
     }

     public static DataTable getWholeSaleFerTilizerInvoice(string SaleID, long financialYearID)
     {
         try
         {
             DataTable i = ReportProvider.getWholeSaleFerTilizerInvoice(SaleID, financialYearID);
             return i;
         }
         catch (Exception ae)
         {
             throw ae;
         }
     }

     public static DataTable getWholePGROtherInvoice(string SaleID, long financialYearID)
     {
         try
         {
             DataTable i = ReportProvider.getWholePGROtherInvoice(SaleID, financialYearID);
             return i;
         }
         catch (Exception ae)
         {
             throw ae;
         }
     }

     public static DataTable getWholeSaleInvoiceByHSNCode(string SaleID, long financialYearID)
     {
         try
         {
             DataTable i = ReportProvider.getWholeSaleInvoiceByHSNCode(SaleID, financialYearID);
             return i;
         }
         catch (Exception ae)
         {
             throw ae;
         }
     }

     public static DataTable getPurchaseReturn(string purchaseReutrnInvoiceId, long financialYearId)
     {
         try
         {
             DataTable dt = ReportProvider.getPurchaseReturn(purchaseReutrnInvoiceId, financialYearId);
             return dt;
         }
         catch (Exception ex)
         {
             throw ex;
         }
     }
    }

    public class dayBookReportController
    {
        public static DataSet ds = null;
        public static DataSet DayBookReport(DateTime fromDate, DateTime toDate)
        {
            try
            {

                DataSet lists = dayBookReportProvider.DayBookReport(fromDate, toDate);
                return lists;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
    }
}
