using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer.providers
{
    class BillingInfo
    {

        public static DataTable getBill()
        {
            SqlDataAdapter da;
            DataTable table = new DataTable();
            using (var con = new SqlConnection(SystemSetting.ConnectionString))
            using (var cmd = new SqlCommand("Usp_BillingInfo", con))
            using (da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                da.Fill(table);
                return table;
            }

        }
    }
}
