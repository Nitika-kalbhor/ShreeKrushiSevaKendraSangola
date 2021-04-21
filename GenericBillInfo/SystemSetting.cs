using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBillInfo
{
    public static class SystemSetting
    {

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();


    }
}
