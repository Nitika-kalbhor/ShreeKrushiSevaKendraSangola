using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.providers;
using DataAccessLayer.models;
using System.Data;

namespace DataAccessLayer.controller
{
 public   class customerController
    {
        public static int addCustomerDetails(customerDetails customer)
        {
            try
            {
                int i = customerProvider.addCustomerDetails(customer);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int UpdateCustomerDetails(long id ,double limation )
        {
            try
            {
                int i = customerProvider.UpdateCustomerDetails(id, limation);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable getCustomerRetailerDetails(string isCustomerRetailer)
        {
            try
            {
                DataTable dt = customerProvider.getCustomerRetailerDetails(isCustomerRetailer);
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static int isActiveCustomer(long customerId)
        {
            try
            {
                int i = customerProvider.isActiveCustomer(customerId);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getAccountNameSerachMobileNo(string MobileNo)
        {
            try
            {
                DataTable i = customerProvider.getAccountNameSerachMobileNo(MobileNo);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
             }

        }
        public static DataTable getGender()
        {
            try
            {
                DataTable i = customerProvider.getGender();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getOrgnation()
        {
            try
            {
                DataTable i = customerProvider.getOrgnation();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable getVillageDetails()
        {
            try
            {
                DataTable i = customerProvider.getVillageDetails();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable getCustomerDetails()
        {
            try
            {
                DataTable i = customerProvider.getCustomerDetails();

                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
