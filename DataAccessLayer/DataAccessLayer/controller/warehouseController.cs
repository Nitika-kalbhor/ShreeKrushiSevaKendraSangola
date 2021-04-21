using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.models;
using DataAccessLayer.providers;
using System.Data;

namespace DataAccessLayer.controller
{
 public   class warehouseController
    {
        public static int addWarehousesDetails(Warehouse Warehouses)
        {
            try
            {
                int i = warehouseProvider.addWarehousesDetails(Warehouses);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int DeleteWareHouse(int warehouseId)
        {
            try
            {
                int i = warehouseProvider.DeleteWareHouse(warehouseId);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static DataTable getWarehouseDetails()
        {
            try
            {
                DataTable list = warehouseProvider.getWarehouseDetails();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public class roomDetailsController
    {
        public static int addRoomDetails(int roomId, string roomNo, int warehouseId)
        {
            try
            {
                int i = roomDetailsProvider.addRoomDetails(roomId, roomNo, warehouseId);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getRoomDetails()
        {
            try
            {
                DataTable list = roomDetailsProvider.getRoomDetails();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getRoomBySerach(int warehouseId)
        {
            try
            {
                DataTable list = roomDetailsProvider.getRoomBySerach(warehouseId);
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
