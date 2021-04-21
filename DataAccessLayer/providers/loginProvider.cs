using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DataAccessLayer.providers
{
 public   class loginProvider
    {

     public static DataSet getLogin(string userName, string Password, long financialYearId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@userName", userName));
                parameter.Add(new KeyValuePair<string, object>("@Password", Password));
                parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));
                SqlHandler sqlH = new SqlHandler();
                DataSet i = sqlH.ExecuteAsDataSet("[dbo].[Usp_getLogin]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

        public static DataTable getFinancialYear(long financialYear)
        {
            try
            {
                DataTable dtFinancialYear = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearId", financialYear));
                SqlHandler sqlH = new SqlHandler();
                dtFinancialYear = sqlH.ExecuteAsDataTable("[dbo].[Usp_getFinancialYear]", parameter);
                return dtFinancialYear;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
    }
}
