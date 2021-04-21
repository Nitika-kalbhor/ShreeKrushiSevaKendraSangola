using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
    public class TempPurchaseReturnDetailsController
    {

        public static DataTable getPurchaseReturnList(DateTime fromDate, DateTime toDate, long financialYearId)
        {
            try
            {
                DataTable dtPurchaseList = TempPurchaseReturnDetailsProivder.getPurchaseReturnList(fromDate, toDate, financialYearId);
                return dtPurchaseList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getPurchaseReturnIvoiceDetails(long purchaseReutrnId, long financialYearId)
        {
            try
            {
                DataTable dtPurchaseReturn = TempPurchaseReturnDetailsProivder.getPurchaseReturnIvoiceDetails(purchaseReutrnId, financialYearId);
                return dtPurchaseReturn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int addPurchaseReturnDetails(PurchaseReutrnDetails purch)
        {
           try
            {
                int result = TempPurchaseReturnDetailsProivder.addPurchaseReturnDetails(purch);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
    }
}
