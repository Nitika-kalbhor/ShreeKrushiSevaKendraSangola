using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using System.Data;

namespace DataAccessLayer.providers
{
 public   class accountLedgerReportProvider
    {

     public static DataTable getAccountLedgerDetails(long accountId, DateTime fromDate, DateTime toDate, int type, long financialYearId, bool summary, long salesmanId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@accountId", accountId));//1
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));//2
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));//3
                parameter.Add(new KeyValuePair<string, object>("@type", type));//4
                parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));//
                parameter.Add(new KeyValuePair<string, object>("@summary", summary));//5
                parameter.Add(new KeyValuePair<string, object>("@salesmanId", salesmanId));//5
                SqlHandler sqH = new SqlHandler();
                DataTable AccountLedgerDetailsList = sqH.ExecuteAsDataTable("[dbo].[Usp_getAccountLedgerDetails]", parameter);
                return AccountLedgerDetailsList;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getAccountNamePaymentDue(int type)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@type", type));//1
                SqlHandler sqH = new SqlHandler();
                DataTable AccountNameList = sqH.ExecuteAsDataTable("[dbo].[Usp_getAccountNamePaymentDue]",parameter);
                return AccountNameList;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
     public static DataTable getAccountLedgerDetailsByVillage(long villageId)
        {
         try
         {
             List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
             parameter.Add(new KeyValuePair<string, object>("@villageId", villageId));
             DataTable dtAccountLedger = new DataTable();
             SqlHandler sqlH = new SqlHandler();
             dtAccountLedger = sqlH.ExecuteAsDataTable("[dbo].[Usp_getAccountLedgerDetailsByVillage]", parameter);
             return dtAccountLedger;
         }
         catch(Exception ae)
         {
             throw ae;
         }
        }
    }
}
