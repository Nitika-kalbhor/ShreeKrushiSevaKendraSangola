using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using DataAccessLayer.providers;
using System.Data;

namespace DataAccessLayer.controller
{
public class accountLedgerReportController
    {
    public static DataTable getAccountLedgerDetails(long accountId, DateTime fromDate, DateTime toDate, int type, long financialYearId, bool summary, long salesmanId)
        {
            try
            {
                return accountLedgerReportProvider.getAccountLedgerDetails(accountId, fromDate, toDate, type, financialYearId, summary,salesmanId);
               // return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getAccountNamePaymentDue(int type)
        {
            try
            {
                return accountLedgerReportProvider.getAccountNamePaymentDue(type);
               // return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    public static DataTable getAccountLedgerDetailsByVillage(long villageId)
        {
            try
            {
                return accountLedgerReportProvider.getAccountLedgerDetailsByVillage(villageId);
            }
            catch(Exception ae)
            {
                throw ae;

            }
        }
    }
}
