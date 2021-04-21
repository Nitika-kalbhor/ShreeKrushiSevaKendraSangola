using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
   public class expireReportProvider
    {
       public static DataTable getExpireReport(DateTime fromDate,DateTime toDate)
       {
           try
           {
               DataTable dtExpire = new DataTable();
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
               SqlHandler sqlH = new SqlHandler();
               dtExpire = sqlH.ExecuteAsDataTable("[dbo].[Usp_getExpireReport]",parameter);
               return dtExpire;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
    }
}
