using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using DataAccessLayer.providers;

namespace DataAccessLayer.controller
{
  public  class villageDetailsController
    {
        public static int addVillageDetails(int villageId, string villageName)
        {
            try
            {
                int i = villageDetailsProvider.addVillageDetails(villageId, villageName);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
    }
}
