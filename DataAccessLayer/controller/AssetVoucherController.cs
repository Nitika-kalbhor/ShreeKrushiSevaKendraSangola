using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using DataAccessLayer.providers;
using System.Data;

namespace DataAccessLayer.controller
{
   public class AssetVoucherController
    {
       public static int addAssetVoucher(AssetVoucher account)
       {
           try
           {
               int i = AssetVoucherProvider.addAssetVoucher(account);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       public static int addExpensesVoucher(AssetVoucher account)
       {
           try
           {
               int i = AssetVoucherProvider.addExpensesVoucher(account);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       public static DataTable getAssetVoucher(long FinancialYearID)
       {
           try
           {
               DataTable i = AssetVoucherProvider.getAssetVoucher(FinancialYearID);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
    }
}
