using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using DataAccessLayer.providers;
using System.Data;

namespace DataAccessLayer.controller
{
    public class rackDetailsController
    {
        public static int addRackDetails(int rackDetailId, int warehouseId, int roomId, string rackName, string rackNo)
        {
            try
            {
                int i = rackDetailsProvider.addRackDetails(rackDetailId, warehouseId, roomId, rackName, rackNo);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getRackDetails()
        {
            try
            {
                DataTable listi = rackDetailsProvider.getRackDetails();
                return listi;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public static DataTable  getRackSelfBySearch(int roomId)
        {
            try
            {
                DataTable listi = rackDetailsProvider.getRackSelfBySearch(roomId);
                return listi;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int DeleteIsActiveRackDetails(long rackDetailId)
        {
            try
            {
                int i = rackDetailsProvider.DeleteIsActiveRackDetails(rackDetailId);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}