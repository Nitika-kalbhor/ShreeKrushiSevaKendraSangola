using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
   public class expireReportController
    {
       public static DataTable getExpireReport(DateTime fromDate,DateTime toDate)
       {
           try
           {
               DataTable dtExpire = expireReportProvider.getExpireReport(fromDate, toDate);
               return dtExpire;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
    }
}
