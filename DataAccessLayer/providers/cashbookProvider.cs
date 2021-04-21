using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DataAccessLayer.providers
{
  public   class cashbookProvider
    {
        public static DataTable getcashBookReports(DateTime transactionDate)
        {
            try
            {

                DataTable dtCashBook = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@date", transactionDate));
                SqlHandler sqlH = new SqlHandler();
                dtCashBook = sqlH.ExecuteAsDataTable("[dbo].[Usp_getCashbook]", parameter);
                return dtCashBook;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getDayBookReports(DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable dtCashBook = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                SqlHandler sqlH = new SqlHandler();
                dtCashBook = sqlH.ExecuteAsDataTable("[dbo].[Usp_getDayBookNew]", parameter);
                return dtCashBook;
            }
            catch(Exception ae)
            {
                throw ae;
            }


        }
        }
}
