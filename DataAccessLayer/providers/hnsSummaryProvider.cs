using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace DataAccessLayer.providers
{
   public  class hnsSummaryProvider
    {
       public static DataTable getHSNSummaryDetails(DateTime fromDate,DateTime toDate)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));//1
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));//1
               SqlHandler sqH = new SqlHandler();
               DataTable hsnlist = sqH.ExecuteAsDataTable("[dbo].[Usp_getHSNSummaryForSale]", parameter);
               return hsnlist;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
    }
}
