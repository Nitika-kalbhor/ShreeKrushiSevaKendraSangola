using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataAccessLayer.providers
{
 public   class gstSummaryProvider
    {
        public static DataTable getGSTSummary(DateTime fromDate, DateTime toDate, string type, string categoryName)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@type", type));
                parameter.Add(new KeyValuePair<string, object>("@categoryName", categoryName));
            
                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getGSTSummary]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
    }
}
