using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using DataAccessLayer.providers;
using System.Data;

namespace DataAccessLayer.controller
{
   public class itemDetailsController
    {
        public static DataTable getStockInItemDetails(string value)
        {
            try
            {
                DataTable listi = itemDetailsProvider.getStockInItemDetails(value);
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
                DataTable listi = itemDetailsProvider.getStockInItemDetailsbyStockId(StockId);
                return listi;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getItemNameBy()
        {

            try
            {


                DataTable listi = itemDetailsProvider.getItemNameBy();
                return listi;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable ProductCode()
        {
            try
            {
                DataTable listi = itemDetailsProvider.getProductCode();
                return listi;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static int addItemDetails(ItemDetails itemDetail)
        {
            try
            {
                int i = itemDetailsProvider.addItemDetails(itemDetail);
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
                DataTable listi = itemDetailsProvider.getItemDetailsById(itemId);
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


                DataTable listi = itemDetailsProvider.getStockBatchNoById(itemId);
                return listi;
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
                int i = itemDetailsProvider.UpdateItemDetails(itemDetails);
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
                int i = itemDetailsProvider.DeleteItemDetails(itemDetails);
                return i;
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
               DataTable dtPacking = itemDetailsProvider.getPaking();
               return dtPacking;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getGodownDetails()
       {
           try
           {
               DataTable dtGodownDetails = itemDetailsProvider.getGodownDetails();
               return dtGodownDetails;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }

       public static int ImportExcelForDataBase(DataTable dt, long p)
       {
           throw new NotImplementedException();
       }

       public static DataTable getStockInItemDetailsForConversion(string searchText)
       {
           try
           {


               DataTable listi = itemDetailsProvider.getStockInItemDetailsForConversion(searchText);
               return listi;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
    }
}
