using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
   public class gstR1Provider
    {
       public static DataSet getGSTR1Report(DateTime fromDate,DateTime toDate,long financialYearID,string opration)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               parameter.Add(new KeyValuePair<string, object>("@Operation", opration));
               SqlHandler sqlH = new SqlHandler();
               DataSet dsGSTR1 = sqlH.ExecuteAsDataSet("[dbo].[Usp_getGSTR1Report]", parameter);
               return dsGSTR1;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
    }
}
