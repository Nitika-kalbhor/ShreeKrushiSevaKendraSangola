using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
    public class notificationController
    {
        public static DataTable getNotification(DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable dtNotofication = notificationProvider.getNotification(fromDate, toDate);
                return dtNotofication;
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }

        public static int AddNewNotification(long accountId, DateTime nexDate)
        {
            int result = notificationProvider.AddNewNotification(accountId, nexDate);
            return result;
        }
    }
}
