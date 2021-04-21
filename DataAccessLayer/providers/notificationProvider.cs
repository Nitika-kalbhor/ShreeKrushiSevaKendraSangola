using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
   public class notificationProvider
    {
        internal static DataTable getNotification(DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable dtnotification = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                SqlHandler sqlH = new SqlHandler();
                dtnotification = sqlH.ExecuteAsDataTable("[dbo].[Usp_getCreditNotification]", parameter);
                return dtnotification;
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }

        internal static int AddNewNotification(long accountId, DateTime nexDate)
        {
            try
            {
                int result = 0;
                List<KeyValuePair<string, object>> paramater = new List<KeyValuePair<string, object>>();
                paramater.Add(new KeyValuePair<string, object>("@accountId", accountId));
                paramater.Add(new KeyValuePair<string, object>("@date", nexDate));
                SqlHandler sqlH = new SqlHandler();
                result = sqlH.ExecuteNonQueryI("Usp_AddNotification", paramater);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
