using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer.Helper;
using DataAccessLayer.providers;

namespace DataAccessLayer.controller
{
    public static class BillController
    {
        public static DataTable getBill()
        {
            DataTable dt = BillingInfo.getBill();
            return dt;
        }
       
            
        }



    }

