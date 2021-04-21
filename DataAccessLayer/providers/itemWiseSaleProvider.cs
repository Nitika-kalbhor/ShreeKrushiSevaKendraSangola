using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using DataAccessLayer.providers;
using System.Data;

namespace DataAccessLayer.providers
{
   public class itemWiseSaleProvider
    {
       public static DataTable getItemWiseSale(long itemId, long financialYearID, bool isBatch, DateTime fromDate, DateTime toDate, int type, string CategoryName)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               parameter.Add(new KeyValuePair<string, object>("@isBatch", isBatch));
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
               parameter.Add(new KeyValuePair<string, object>("@type", type));
               parameter.Add(new KeyValuePair<string, object>("@CategoryName", CategoryName));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getItemWiseSale]", parameter);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }

       }

       public static DataTable getStockRegisterType(string Opreation, string CategoryName, string godown)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@Opreation", Opreation));
               parameter.Add(new KeyValuePair<string, object>("@CategoryName", CategoryName));
               parameter.Add(new KeyValuePair<string, object>("@godown", godown));       
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("Usp_getStockRegisterType", parameter);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getGodownDetals()
       {
           try
           {
               
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getGodownDetals]");
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
    }
}
