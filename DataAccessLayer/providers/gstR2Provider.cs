using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
   public class gstR2Provider
    {
       public static DataSet gstR2getGSTR2Report(DateTime fromDate,DateTime toDate,long financialYearID,string operation)
       {
           try
           {
               DataSet ds = new DataSet();
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               parameter.Add(new KeyValuePair<string, object>("@Operation", operation));
               SqlHandler sqlH = new SqlHandler();
               ds = sqlH.ExecuteAsDataSet("[dbo].[Usp_getGSTR2Report]", parameter);
               return ds;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
    }
}
