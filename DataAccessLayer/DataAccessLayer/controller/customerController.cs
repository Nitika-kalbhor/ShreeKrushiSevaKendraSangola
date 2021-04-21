using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
