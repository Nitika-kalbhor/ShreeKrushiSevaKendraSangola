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
   public class itemDetailsController
    {
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
        public static ItemDetails getItemDetailsById(long itemId)
        {
            try
            {


                ItemDetails listi = itemDetailsProvider.getItemDetailsById(itemId);
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
    }
}
