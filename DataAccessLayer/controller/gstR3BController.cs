using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
    public class gstR3BController
    {
        public static DataSet getGSTR3BReport(DateTime fromDate, DateTime toDate, long financialYearID, string opration)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = gstR3BProvider.getGSTR3BReport(fromDate, toDate, financialYearID, opration);
                return ds;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getOrgDetails()
        {
            try
            {
                DataTable ds = new DataTable();

                ds = gstR3BProvider.getOrgDetails();
                return ds;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
    }
}
