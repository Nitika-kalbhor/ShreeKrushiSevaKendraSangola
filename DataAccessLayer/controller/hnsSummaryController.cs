using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
    public  class hnsSummaryController
    {
        public static DataTable getHSNSummaryDetails(DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable i = hnsSummaryProvider.getHSNSummaryDetails(fromDate, toDate);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
    }
}
