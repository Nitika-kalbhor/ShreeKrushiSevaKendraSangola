using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.models;
using System.Data;

namespace DataAccessLayer.providers
{
  public  class itemDetailsProvider
    {
        public static DataTable getItemNameBy()
        {
            
            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getItemNameBySearch]");
                return listi;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

      public  static int addItemDetails(ItemDetails itemDetail)
        {

            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemDetail.itemId));
                parameter.Add(new KeyValuePair<string, object>("@StockId", itemDetail.StockId));
                parameter.Add(new KeyValuePair<string, object>("@orjId", itemDetail.orjId));
                parameter.Add(new KeyValuePair<string, object>("@subCategoryId", itemDetail.subCategoryId));
                parameter.Add(new KeyValuePair<string, object>("@itemName", itemDetail.itemName));
                parameter.Add(new KeyValuePair<string, object>("@reorderLevel", itemDetail.reorderLevel));
                parameter.Add(new KeyValuePair<string, object>("@warehouseId", itemDetail.warehouseId));
                parameter.Add(new KeyValuePair<string, object>("@weight", itemDetail.weight));
                parameter.Add(new KeyValuePair<string, object>("@weightIn", itemDetail.weightIn));
                parameter.Add(new KeyValuePair<string, object>("@sizeNo", itemDetail.sizeNo));
                parameter.Add(new KeyValuePair<string, object>("@price", itemDetail.price));
              //  parameter.Add(new KeyValuePair<string, object>("@openingStock", itemDetail.openingStock));
                parameter.Add(new KeyValuePair<string, object>("@vat", itemDetail.vat));
                parameter.Add(new KeyValuePair<string, object>("@rackDetailsId", itemDetail.rackDetailsId));
                parameter.Add(new KeyValuePair<string, object>("@batchNo", itemDetail.batchNo));
                parameter.Add(new KeyValuePair<string, object>("@roomId", itemDetail.roomId));
                parameter.Add(new KeyValuePair<string, object>("@purchaseRate", itemDetail.purchaseRate));
                parameter.Add(new KeyValuePair<string, object>("@salesCashRate", itemDetail.salesCashRate));
                parameter.Add(new KeyValuePair<string, object>("@salesCreditRate", itemDetail.salesCreditRate));
                parameter.Add(new KeyValuePair<string, object>("@wholeSalesCashRate", itemDetail.wholeSalesCashRate));
                parameter.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate", itemDetail.wholeSalesCreditRate));
                parameter.Add(new KeyValuePair<string, object>("@isActive", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.Now));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addItemDetails]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
      public static ItemDetails getItemDetailsById(long itemId)
      {

          try
          {
              
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@itemId",itemId));
              SqlHandler sqlH = new SqlHandler();
              ItemDetails listi = sqlH.ExecuteAsObject<ItemDetails>("[dbo].[Usp_getItemDetailsById]",parameter);
              return listi;
          }
          catch (Exception ae)
          {
              throw ae;
          }

      }

      public static DataTable getStockBatchNoById(long itemId)
      {

          try
          {

              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
              SqlHandler sqlH = new SqlHandler();
                DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStockBatchNoById]", parameter);
              return listi;
          }
          catch (Exception ae)
          {
              throw ae;
          }

      }

    }
}
