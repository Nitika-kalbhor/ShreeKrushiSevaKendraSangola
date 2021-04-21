using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessLayer.providers;
namespace DataAccessLayer.controller
{
    public class gstSummaryController
    {
        public static DataTable getGSTSummary(DateTime fromDate, DateTime toDate, string type, string categoryName)
        {
            try
            {
                return gstSummaryProvider.getGSTSummary(fromDate, toDate, type, categoryName);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
