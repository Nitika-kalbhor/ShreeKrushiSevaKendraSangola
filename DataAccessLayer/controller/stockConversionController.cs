using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessLayer.providers;
using DataAccessLayer.models;

namespace DataAccessLayer.controller
{
   public class stockConversionController
    {
       public static long getMaxStockConversionId(long financialYearID)
       {
           try
           {
               long StockConversionId = stockConversionProvider.getMaxStockconversionID(financialYearID);
               return StockConversionId;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
       public static int addStockConversion(StockConversion stockConversion)
       {
           try
           {
               int result = 0;
               result = stockConversionProvider.addStockConversion(stockConversion);
               return result;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
    }
}
