using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;

namespace DataAccessLayer.providers
{
  public  class villageDetailsProvider
    {
        public static int addVillageDetails(int villageId, string villageName)
        {
            try
            {
               
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@villageId", villageId));
                parameter.Add(new KeyValuePair<string, object>("@villageName", villageName));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.Now));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addVillageDetails]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
    }
}
