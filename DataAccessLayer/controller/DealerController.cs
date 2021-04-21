using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DataAccessLayer.controller
{
  public class DealerController
    {
         public static int addDealerDetails(dealerDetails dealer)
        {
            try
            {
                int i = dealerProvider.addDealerDetails(dealer);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int deleteDealerDetails(long dealerId,int userId)
        {
            try
            {
                int i = dealerProvider.deleteDealerDetails(dealerId, userId);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getDealerDetails()
        {
            try
            {
                DataTable i = dealerProvider.getDealerDetails();
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getDealerNameByMobileNo(string MobileNo)
        {
            try
            {
                DataTable i = dealerProvider.getDealerNameByMobileNo(MobileNo);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
