using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
  public  class itemWiseSaleController
    {
      public static DataTable getItemWiseSale(long itemId, long financialYearID, bool isBatch, DateTime fromDate, DateTime toDate, int type,string CategoryName)
      {
          try
          {
              return itemWiseSaleProvider.getItemWiseSale(itemId, financialYearID, isBatch, fromDate, toDate, type, CategoryName);
          }
          catch (Exception ae)
          {
              throw ae;
          }

      }
      public static DataTable getGodownDetals()
      {
          try
          {

              return itemWiseSaleProvider.getGodownDetals();
          }
          catch (Exception ae)
          {
              throw ae;
          }
      }
      public static DataTable getStockRegisterType(string Opreation, string CategoryName,string godown)
      {
          try
          {
              return itemWiseSaleProvider.getStockRegisterType(Opreation, CategoryName, godown);
          }
          catch (Exception ae)
          {
              throw ae;
          }
      }
    }
}
