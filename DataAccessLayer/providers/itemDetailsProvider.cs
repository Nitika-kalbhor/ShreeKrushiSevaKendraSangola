using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getItemName]");
                return listi;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getProductCode()
        {

            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getProductCode]");
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
                parameter.Add(new KeyValuePair<string, object>("@companyId", itemDetail.companyId));
                parameter.Add(new KeyValuePair<string, object>("@categoryId", itemDetail.categoryId));
                parameter.Add(new KeyValuePair<string, object>("@HNSCode", itemDetail.HNSCode));
                parameter.Add(new KeyValuePair<string, object>("@itemName", itemDetail.itemName));
                parameter.Add(new KeyValuePair<string, object>("@IGST", itemDetail.IGST));
                parameter.Add(new KeyValuePair<string, object>("@CGST", itemDetail.CGST));
                parameter.Add(new KeyValuePair<string, object>("@SGST", itemDetail.SGST));
                parameter.Add(new KeyValuePair<string, object>("@rackNo", itemDetail.rackNo));
                parameter.Add(new KeyValuePair<string, object>("@batchNo", itemDetail.batchNo));
                parameter.Add(new KeyValuePair<string, object>("@reorderLevel", itemDetail.reorderLevel));
                parameter.Add(new KeyValuePair<string, object>("@Qty", itemDetail.openingStock));
                parameter.Add(new KeyValuePair<string, object>("@unitBy", itemDetail.weightIn));            
                parameter.Add(new KeyValuePair<string, object>("@price", itemDetail.price));
                parameter.Add(new KeyValuePair<string, object>("@purchaseRate", itemDetail.purchaseRate));
                parameter.Add(new KeyValuePair<string, object>("@salesCashRate", itemDetail.salesCashRate));
                parameter.Add(new KeyValuePair<string, object>("@salesCreditRate", itemDetail.salesCreditRate));
                parameter.Add(new KeyValuePair<string, object>("@wholeSalesCashRate", itemDetail.wholeSalesCashRate));
                parameter.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate", itemDetail.wholeSalesCreditRate));
                parameter.Add(new KeyValuePair<string, object>("@productCode", itemDetail.productCode));
                parameter.Add(new KeyValuePair<string, object>("@mfgDate", itemDetail.MFD_Date));
                parameter.Add(new KeyValuePair<string, object>("@expireDate", itemDetail.expireDate));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", itemDetail.addedBy));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", Convert.ToDateTime(DateTime.Now.ToShortDateString())));
                parameter.Add(new KeyValuePair<string, object>("@isExpiryApplicable", itemDetail.isExpiryApplicable));
                parameter.Add(new KeyValuePair<string, object>("@mainCategory", itemDetail.mainCategory));
                parameter.Add(new KeyValuePair<string, object>("@godownDetails", itemDetail.godownDetails));

                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addItemDetails]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
      public static int UpdateItemDetails(ItemDetails itemDetails)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemDetails.itemId));
                parameter.Add(new KeyValuePair<string, object>("@StockId", itemDetails.StockId));
                parameter.Add(new KeyValuePair<string, object>("@companyId", itemDetails.companyId));
                parameter.Add(new KeyValuePair<string, object>("@categoryId", itemDetails.categoryId));
               // parameter.Add(new KeyValuePair<string, object>("@isExpiryApplicable", itemDetails.isExpiryApplicable));
                parameter.Add(new KeyValuePair<string, object>("@HNSCode", itemDetails.HNSCode));
                parameter.Add(new KeyValuePair<string, object>("@itemName", itemDetails.itemName));
                parameter.Add(new KeyValuePair<string, object>("@IGST", itemDetails.IGST));
                parameter.Add(new KeyValuePair<string, object>("@CGST", itemDetails.CGST));
                parameter.Add(new KeyValuePair<string, object>("@SGST", itemDetails.SGST));
                parameter.Add(new KeyValuePair<string, object>("@rackNo", itemDetails.rackNo));
                parameter.Add(new KeyValuePair<string, object>("@batchNo", itemDetails.batchNo));
                parameter.Add(new KeyValuePair<string, object>("@reorderLevel", itemDetails.reorderLevel));
                parameter.Add(new KeyValuePair<string, object>("@Qty", itemDetails.openingStock));
                parameter.Add(new KeyValuePair<string, object>("@unitBy", itemDetails.weightIn));
                parameter.Add(new KeyValuePair<string, object>("@price", itemDetails.price));
                parameter.Add(new KeyValuePair<string, object>("@purchaseRate", itemDetails.purchaseRate));
                parameter.Add(new KeyValuePair<string, object>("@salesCashRate", itemDetails.salesCashRate));
                parameter.Add(new KeyValuePair<string, object>("@salesCreditRate", itemDetails.salesCreditRate));
                parameter.Add(new KeyValuePair<string, object>("@wholeSalesCashRate", itemDetails.wholeSalesCashRate));
                parameter.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate", itemDetails.wholeSalesCreditRate));
                parameter.Add(new KeyValuePair<string, object>("@productCode", itemDetails.productCode));
                parameter.Add(new KeyValuePair<string, object>("@mfgDate", itemDetails.MFD_Date));
                parameter.Add(new KeyValuePair<string, object>("@expireDate", itemDetails.expireDate));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", itemDetails.addedBy));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", Convert.ToDateTime(DateTime.Now.ToShortDateString())));
                parameter.Add(new KeyValuePair<string, object>("@categoryName", itemDetails.categoryName));
                parameter.Add(new KeyValuePair<string, object>("@companyName", itemDetails.companyName));
                parameter.Add(new KeyValuePair<string, object>("@isExpiryApplicable", itemDetails.isExpiryApplicable));
                parameter.Add(new KeyValuePair<string, object>("@mainCategory", itemDetails.mainCategory));
                parameter.Add(new KeyValuePair<string, object>("@godownDetails", itemDetails.godownDetails));

                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_UpdateItemDetails]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
      public static int DeleteItemDetails(ItemDetails itemDetails)
      {
          try
          {
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@itemId", itemDetails.itemId));
              parameter.Add(new KeyValuePair<string, object>("@StockId", itemDetails.StockId));
              parameter.Add(new KeyValuePair<string, object>("@companyId", itemDetails.companyId));
              parameter.Add(new KeyValuePair<string, object>("@categoryId", itemDetails.categoryId));
              parameter.Add(new KeyValuePair<string, object>("@rackNo", itemDetails.rackNo));
              parameter.Add(new KeyValuePair<string, object>("@batchNo", itemDetails.batchNo));
              parameter.Add(new KeyValuePair<string, object>("@unitBy", itemDetails.weightIn));
              SqlHandler sqlH = new SqlHandler();
              int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_DeleteItemDetails]", parameter);
              return i;
          }
          catch (Exception ae)
          {
              throw ae;
          }
      }
      public static DataTable getItemDetailsById(long itemId)
      {

          try
          {
              
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
              SqlHandler sqlH = new SqlHandler();
              DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getItemNameByIdStockDetails]", parameter);
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

        public static DataTable getStockInItemDetails(string value)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@txtSearch", value));             
                SqlHandler sqlH = new SqlHandler();
                DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStockInItemDetails]", parameter);
                return listi;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        public static DataTable getStockInItemDetailsbyStockId(long StockId)
        {

            try
            {

                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@StockId", StockId));
                SqlHandler sqlH = new SqlHandler();
                DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStockInItemDetailsbyStockId]", parameter);
                return listi;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getPaking()
        {
            try
            {
                DataTable dtPacking = new DataTable();
                SqlHandler sqlH = new SqlHandler();
                dtPacking = sqlH.ExecuteAsDataTable("[dbo].[Usp_getPaking]");
                return dtPacking;
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }



        internal static DataTable getGodownDetails()
        {
            try
            {
                DataTable dtGoDownDetails = new DataTable();
                SqlHandler sqlH = new SqlHandler();
                dtGoDownDetails = sqlH.ExecuteAsDataTable("[dbo].[Usp_getGodownDetals]");
                return dtGoDownDetails;
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }

        internal static DataTable getStockInItemDetailsForConversion(string searchText)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@searchText", searchText));
                SqlHandler sqlH = new SqlHandler();
                DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStockInItemDetailsForConversion]", parameter);
                return listi;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
    }
}
