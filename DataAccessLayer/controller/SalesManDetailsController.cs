using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
   public class SalesManDetailsController
    {      
        public static int addSalesmanDetails(SalesmanDetails salesm)
           {
               try
               {
                   int i = SalesmanProvider.addSalesmanDetails(salesm);
                   return i;
               }
               catch (Exception ex)
               {

                   throw ex;
               }
           }
        public static DataTable getSalesmanDetails()
        {
            try
            {
                DataTable i = SalesmanProvider.getSalesmanDetails();

                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public static int UpdateSalesmanDetails(long id, double limation)
        //{
        //    try
        //    {
        //        int i = SalesmanProvider.UpdateSalesmanDetails(id, limation);
        //        return i;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public static DataTable getCustomerRetailerDetails(string isCustomerRetailer)
        //{
        //    try
        //    {
        //        DataTable dt = customerProvider.getCustomerRetailerDetails(isCustomerRetailer);
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}         
        
         
     
    }
}
