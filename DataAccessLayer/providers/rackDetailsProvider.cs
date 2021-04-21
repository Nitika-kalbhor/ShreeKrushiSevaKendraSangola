using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using System.Data;

namespace DataAccessLayer.providers
{
   public class rackDetailsProvider
    {
        public static int addRackDetails(int rackDetailId, int warehouseId,int roomId,string rackName,string rackNo)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@rackDetailId", rackDetailId));
                parameter.Add(new KeyValuePair<string, object>("@warehouseId", warehouseId));
                parameter.Add(new KeyValuePair<string, object>("@roomId", roomId));
                parameter.Add(new KeyValuePair<string, object>("@rackName", rackName));
                parameter.Add(new KeyValuePair<string, object>("@rackNo", rackNo));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.Now));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addRackDetails]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable  getRackDetails()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getRackDetails]");
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

        public static int DeleteIsActiveRackDetails(long rackDetailId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@rackDetailId", rackDetailId));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.Now));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_DeleteIsActiveRackDetails]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

        public static DataTable getRackSelfBySearch(int roomId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@roomId", roomId));
                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getRackSelfBySearch]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
    }
}
