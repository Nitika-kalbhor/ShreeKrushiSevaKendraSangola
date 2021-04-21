using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
   public class gstR2Controller
    {
      public static DataSet getGSTR2Report(DateTime fromDate,DateTime toDate,long financialYearID,string opration)
       {
           try
           {
               DataSet ds = new DataSet();
               ds = gstR2Provider.gstR2getGSTR2Report(fromDate, toDate, financialYearID,opration);
               return ds;
           }
          catch(Exception ae)
           {
               throw ae;
           }
       }
    }
}
