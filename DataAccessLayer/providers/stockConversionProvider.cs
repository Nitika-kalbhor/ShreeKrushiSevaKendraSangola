using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
   public class stockConversionProvider
    {
       public static long getMaxStockconversionID(long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               long salesInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getMaxStockconversionID]", parameter);
               return salesInvoiceId;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }

       public static int addStockConversion(StockConversion stockConversion)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@stockConversionId", stockConversion.stockConversionId));
               parameter.Add(new KeyValuePair<string, object>("@stockConversionIvoiceId", stockConversion.stockConversionIvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@stockconversionDate", stockConversion.stockconversionDate));
               parameter.Add(new KeyValuePair<string, object>("@stockFromID", stockConversion.stockFromID));
               parameter.Add(new KeyValuePair<string, object>("@fromQty", stockConversion.fromQty));
               parameter.Add(new KeyValuePair<string, object>("@stockToId", stockConversion.stockToId));
               parameter.Add(new KeyValuePair<string, object>("@toQty", stockConversion.toQty));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", stockConversion.financialYearID));
               parameter.Add(new KeyValuePair<string, object>("@isDelete", stockConversion.isDelete));
               SqlHandler sqlH=new SqlHandler();
               int result = sqlH.ExecuteNonQueryI("[dbo].[Usp_addUpdateStockConversion]", parameter);
               return result;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
    }
}
