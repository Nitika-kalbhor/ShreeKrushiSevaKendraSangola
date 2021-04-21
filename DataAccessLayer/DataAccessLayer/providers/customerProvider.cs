using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.models;
using System.Data;

namespace DataAccessLayer.providers
{
    public class customerProvider
    {
        public static int addCustomerDetails(customerDetails customer)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@customerId", customer.customerId));
                parameter.Add(new KeyValuePair<string, object>("@customerName", customer.customerName));
                parameter.Add(new KeyValuePair<string, object>("@customerAddress", customer.customerAddress));
                parameter.Add(new KeyValuePair<string, object>("@DOB", customer.DOB));
                parameter.Add(new KeyValuePair<string, object>("@genderId", customer.genderId));
                parameter.Add(new KeyValuePair<string, object>("@villageId", customer.villageId));
                parameter.Add(new KeyValuePair<string, object>("@customerMobileNo", customer.customerMobileNo));
                parameter.Add(new KeyValuePair<string, object>("@alterNateCustomerMobileNo", customer.alterNateCustomerMobileNo));
                parameter.Add(new KeyValuePair<string, object>("@emailId", customer.emailId));
                parameter.Add(new KeyValuePair<string, object>("@contactPerson", customer.contactPerson));
                parameter.Add(new KeyValuePair<string, object>("@contactPersonMobileNo", customer.contactPersonMobileNo));
                parameter.Add(new KeyValuePair<string, object>("@isCreditDebit", customer.isCreditDebit));
                parameter.Add(new KeyValuePair<string, object>("@openigBalanace", customer.openigBalanace));
                if (customer.isCreditDebit == "जमा रक्कम")
                {
                    customer.crAmount = customer.openigBalanace;
                    customer.drAmount = 0;
                }
                if (customer.isCreditDebit == "नावे रक्कम")
                {
                    customer.drAmount = customer.openigBalanace;
                    customer.crAmount = 0;
                }
                parameter.Add(new KeyValuePair<string, object>("@crAmount", customer.crAmount));
                parameter.Add(new KeyValuePair<string, object>("@drAmount", customer.drAmount));
                parameter.Add(new KeyValuePair<string, object>("@orjId", customer.orjId));
                parameter.Add(new KeyValuePair<string, object>("@isActive", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", customer.addedBy));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", customer.addedOn));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addCustomerDetails]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getCustomerDetails()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getCustomerDetails]");
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getCustomerDetailsForCombobox()
        {
            try
            {
                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getCustomerDetailsForCombobox]");
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

                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getGender]");
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

        public static DataTable getOrgnation()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getOrgnation]");
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }


        public static DataTable getVillageDetails()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getVillageDetails]");
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
    }
}
