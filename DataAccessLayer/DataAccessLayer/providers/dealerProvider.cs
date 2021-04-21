using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.providers
{
    public class dealerProvider
    {
        public static  int addDealerDetails(dealerDetails dealerDetails)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@dealerId", dealerDetails.dealerId));
                parameter.Add(new KeyValuePair<string, object>("@dealerName", dealerDetails.dealerName));
                parameter.Add(new KeyValuePair<string, object>("@dealerFirmName", dealerDetails.dealerFirmName));
                parameter.Add(new KeyValuePair<string, object>("@dealerAddress", dealerDetails.dealerAddress));
                parameter.Add(new KeyValuePair<string, object>("@dealerFirmAddress", dealerDetails.dealerFirmAddress));
                parameter.Add(new KeyValuePair<string, object>("@DOB", dealerDetails.DOB));
                parameter.Add(new KeyValuePair<string, object>("@genderId", dealerDetails.genderId));
                parameter.Add(new KeyValuePair<string, object>("@emailId", dealerDetails.emailId));
                parameter.Add(new KeyValuePair<string, object>("@dealerContactNo", dealerDetails.dealerContactNo));
                parameter.Add(new KeyValuePair<string, object>("@officeNo", dealerDetails.officeNo));
                parameter.Add(new KeyValuePair<string, object>("@openigBalanace", dealerDetails.openigBalance));
                parameter.Add(new KeyValuePair<string, object>("@isCreditDebit", dealerDetails.CreditDebit));
                if(dealerDetails.CreditDebit== "जमा रक्कम")
                {
                    dealerDetails.crAmount = dealerDetails.openigBalance;
                    dealerDetails.drAmount =0;
                }
                if (dealerDetails.CreditDebit == "नावे रक्कम")
                {
                    dealerDetails.crAmount =0;
                    dealerDetails.drAmount = dealerDetails.openigBalance;
                }
                parameter.Add(new KeyValuePair<string, object>("@crAmount", dealerDetails.crAmount));
                parameter.Add(new KeyValuePair<string, object>("@drAmount", dealerDetails.drAmount));
                parameter.Add(new KeyValuePair<string, object>("@isActive", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", dealerDetails.addedBy));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", dealerDetails.addedOn));
                parameter.Add(new KeyValuePair<string, object>("@orjId",1));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_adddealerDetails]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static int deleteDealerDetails(long dealerId,int userId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@dealerId",dealerId));
                parameter.Add(new KeyValuePair<string, object>("@updatedOn", DateTime.UtcNow));
                parameter.Add(new KeyValuePair<string, object>("@updatedBy", userId));
                parameter.Add(new KeyValuePair<string, object>("@isActive", 0));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_adddealerDetails]", parameter);
                return i;
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getDealerDetails()
        {
            try
            {
              
                SqlHandler sqH = new SqlHandler();
                DataTable dealerDetailsList = sqH.ExecuteAsDataTable("[dbo].[Usp_GetDealerDetails]");
                return dealerDetailsList;
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }
    }
}
