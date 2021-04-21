using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DataAccessLayer.controller
{
    public class accountReportController
    {
        public static DataTable getcashBookReports(DateTime transactionDate)
        {
            try
            {
                DataTable dtCashBook = new DataTable();
                DataTable dt = new DataTable();
                dt = cashbookProvider.getcashBookReports(transactionDate);

                return dt;
            }
            catch (Exception ae)
            {
                throw ae;
            }
           
        }
      public static DataTable getDayBookReports(DateTime fromDate,DateTime toDate)
      {
          try{
                  DataTable dtCashBook = new DataTable();
                DataTable dt = new DataTable();
                dt = cashbookProvider.getDayBookReports(fromDate, toDate); 
                return dt;
          }
          catch(Exception ae)
          {
              throw ae;
          }
      }
    }
}
