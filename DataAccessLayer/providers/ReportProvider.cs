using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using System.Data;


namespace DataAccessLayer.providers
{
   public class ReportProvider
    {
       public static DataTable getServer()
       {
           try
           {

               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getServer]");
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }

       }
       public static DataTable getSaleInvoice(string salesInvoiceId, long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salesInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleBillPrint]", parameter);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }

       }
       //public static DataTable getSaleInvoiceByChalan(string salesInvoiceId, long financialYearID)
       //{
       //    try
       //    {
       //        List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
       //        parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salesInvoiceId));
       //        parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
       //        SqlHandler sqlH = new SqlHandler();
       //        DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleBillPrintByChalan]", parameter);
       //        return i;
       //    }
       //    catch (Exception ae)
       //    {
       //        throw ae;
       //    }

       //}
       public static DataTable getSaleInvoiceByHSNCode(string salesInvoiceId, long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salesInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleBillSlotByHSNCode]", parameter);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getcheckSaleInvoice(string salesInvoiceId, long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salesInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getcheckSaleBillPrint]", parameter);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getSaleSeedInvoice(string salesInvoiceId, long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salesInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleSeedBillPrint]", parameter);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getSaleFerTilizerInvoice(string salesInvoiceId, long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salesInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleFerTiliezerBillPrint]", parameter);
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
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salesInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleInsectisideBillPrint]", parameter);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       internal static DataTable getPGROtherInvoice(string SaleID, long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", SaleID));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable dtPGROther = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSalePGROtherBillPrint]",parameter);
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
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", SaleID));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getWholeSaleBillPrint]", parameter);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getcheckWholeSaleInvoice(string salesInvoiceId, long financialYearID)
       {
           List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
           parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salesInvoiceId));
           parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
           SqlHandler sqlH = new SqlHandler();
           DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getcheckWholeSaleBillPrint]", parameter);
           return i;
       }

       public static DataTable getWholeSaleSeedInvoice(string SaleID, long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", SaleID));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getWholeSaleSeedBillPrint]", parameter);
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
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", SaleID));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getWholeSaleInsectisideBillPrint]", parameter);
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
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", SaleID));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getWholeSaleFerTiliezerBillPrint]", parameter);
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
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", SaleID));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getWholeSalePGROtherBillPrint]", parameter);
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
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", SaleID));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getWholeSaleBillSlotByHSNCode]", parameter);
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
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@purchaseReutrnInvoiceId", purchaseReutrnInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getPurchaseReturnInvoicePrint]", parameter);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
    }
    public class dayBookReportProvider
    {
        public static DataSet DayBookReport(DateTime fromDate, DateTime toDate)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));//2
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));//3
                SqlHandler sqlH = new SqlHandler();
                DataSet lists = sqlH.ExecuteAsDataSet("[dbo].[Usp_DayBookReport]", parameter);
                return lists;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
    }
}
