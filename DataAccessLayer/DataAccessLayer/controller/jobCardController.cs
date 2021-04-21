using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.controller
{
   public class jobCardController
    {
        public static DataTable getCustomerDetailsForCombobox()
        {
            try
            {
                DataTable i = customerProvider.getCustomerDetailsForCombobox();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //get Max JobCard No From Table
        public static long getMaxJobCardID()
        {
            try
            {
                long i = jobCardProvider.getMaxJobCardID();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int addJobCardInfo(JobCard jobCard)
        {
            try
            {
                int i = jobCardProvider.addJobCardInfo(jobCard);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
