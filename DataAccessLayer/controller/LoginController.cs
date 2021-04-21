using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using DataAccessLayer.providers;
using System.Data;

namespace DataAccessLayer.controller
{
 public   class LoginController
    {
     public static DataSet getLogin(string userName, string Password, long financialYearId)
        {
            try
            {
                DataSet i = loginProvider.getLogin(userName, Password,financialYearId);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getFinancialYear(long financialYear)
        {
            try
            {
                return loginProvider.getFinancialYear( financialYear);
            }
         catch(Exception ae)
            {
                throw ae;
            }
        }
    }
}
