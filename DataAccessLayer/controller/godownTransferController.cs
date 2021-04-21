using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DataAccessLayer.controller
{
 public   class godownTransferController
    {
     public static DataTable getStockInGodownTransferSearch(string value, string type, string godownName)
     {
         try
         {

             DataTable listi = godownTransferProvider.getStockInGodownTransferSearch(value, type, godownName);
             return listi;
         }
         catch (Exception ae)
         {
             throw ae;
         }
     }
     public static DataTable getGodowntransferList(DateTime fromDate, DateTime toDate, string type, long FinancialYearID, long godownTransferId)
     {
         try
         {
             DataTable listi = godownTransferProvider.getGodowntransferList(fromDate, toDate, type, FinancialYearID, godownTransferId);
             return listi;
         }
         catch (Exception ae)
         {
             throw ae;
         }
     }
     public static int addGodownTransfer(models.godownTransfer gm)
     {
         try
         {

             int listi = godownTransferProvider.addGodownTransfer(gm);
             return listi;
         }
         catch (Exception ae)
         {
             throw ae;
         }
     }
    }
}
