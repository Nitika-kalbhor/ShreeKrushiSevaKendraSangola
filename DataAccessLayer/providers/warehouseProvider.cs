using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using System.Data;

namespace DataAccessLayer.providers
{
  public  class warehouseProvider
    {
        public static int addWarehousesDetails(Warehouse warehouses)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@warehouseId", warehouses.warehouseId));
                parameter.Add(new KeyValuePair<string, object>("@warehouseName", warehouses.warehouseName));
                parameter.Add(new KeyValuePair<string, object>("@location", warehouses.location));
                parameter.Add(new KeyValuePair<string, object>("@contactNo", warehouses.contactNo));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", warehouses.addedBy));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", warehouses.addedOn));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addWarehouse]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

        public static int DeleteWareHouse(int warehouseId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@warehouseId", warehouseId));
               
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_DeleteWareHouse]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

        public static DataTable getWarehouseDetails()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getWarehouseDetails]");
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
    }

    public class roomDetailsProvider
    {
        public static int addRoomDetails(int roomId,string roomNo,int warehouseId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@roomId", roomId));
                parameter.Add(new KeyValuePair<string, object>("@roomNo", roomNo));
                parameter.Add(new KeyValuePair<string, object>("@warehouseId", warehouseId));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedOn",DateTime.Now));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addRoomDetails]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

        public static DataTable getRoomDetails()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getRoomDetails]");
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable  getRoomBySerach(int warehouseId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@warehouseId", warehouseId));
                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getRoomBySerach]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
    }
}
