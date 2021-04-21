using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
   public class gstR1Controller
    {
       public static DataSet getGSTR1Report(DateTime fromDate,DateTime toDate,long financialYearID,string opration)
       {
           try
           {
               DataSet dtGSTR1 = gstR1Provider.getGSTR1Report(fromDate, toDate,financialYearID, opration);
               return dtGSTR1;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
    }
}
