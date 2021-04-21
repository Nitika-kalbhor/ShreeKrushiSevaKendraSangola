using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccessLayer.providers
{
    class jobCardProvider
    {
        //get jobCard Details For Binding jobCard
        public static List<bindJobCard> getjobCardDetails()
        {
            try
            {
                SqlHandler sqlH = new SqlHandler();
                List<bindJobCard> i = sqlH.ExecuteAsList<bindJobCard>("[dbo].[Usp_getjobCardDetails]");
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
      //get Max JobCard No From Table
        public static long getMaxJobCardID()
        {
            try
            {
                SqlHandler sqlH = new SqlHandler();
                long JobCardID = sqlH.ExecuteAsObject<long>("[dbo].[Usp_getMaxJobID]");
                if(JobCardID >=0)
                {
                    JobCardID++;
                }
                return JobCardID;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        //get jobCard Details For Binding jobCard
        public static int addJobCardInfo(JobCard jobCard)
        {
            //try
            //{
            //    List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
            //    parameter.Add(new KeyValuePair<string, object>("@jobCardId", jobCard.jobCardId));
            //    parameter.Add(new KeyValuePair<string, object>("@jobCardName", jobCard.jobCardNo));
            //    parameter.Add(new KeyValuePair<string, object>("@jobCardAddress", jobCard.jobCardAddress));
            //    parameter.Add(new KeyValuePair<string, object>("@DOB", jobCard.DOB));
            //    parameter.Add(new KeyValuePair<string, object>("@genderId", jobCard.genderId));
            //    parameter.Add(new KeyValuePair<string, object>("@villageId", jobCard.villageId));
            //    parameter.Add(new KeyValuePair<string, object>("@jobCardMobileNo", jobCard.jobCardMobileNo));
            //    parameter.Add(new KeyValuePair<string, object>("@alterNatejobCardMobileNo", jobCard.alterNatejobCardMobileNo));
            //    parameter.Add(new KeyValuePair<string, object>("@emailId", jobCard.emailId));
            //    parameter.Add(new KeyValuePair<string, object>("@contactPerson", jobCard.contactPerson));
            //    parameter.Add(new KeyValuePair<string, object>("@contactPersonMobileNo", jobCard.contactPersonMobileNo));
            //    parameter.Add(new KeyValuePair<string, object>("@isCreditDebit", jobCard.isCreditDebit));
            //    parameter.Add(new KeyValuePair<string, object>("@openigBalanace", jobCard.openigBalanace));
            //    if (jobCard.isCreditDebit == "जमा रक्कम")
            //    {
            //        jobCard.crAmount = jobCard.openigBalanace;
            //        jobCard.drAmount = 0;
            //    }
            //    if (jobCard.isCreditDebit == "नावे रक्कम")
            //    {
            //        jobCard.drAmount = jobCard.openigBalanace;
            //        jobCard.crAmount = 0;
            //    }
            //    parameter.Add(new KeyValuePair<string, object>("@crAmount", jobCard.crAmount));
            //    parameter.Add(new KeyValuePair<string, object>("@drAmount", jobCard.drAmount));
            //    parameter.Add(new KeyValuePair<string, object>("@orjId", jobCard.orjId));
            //    parameter.Add(new KeyValuePair<string, object>("@isActive", 1));
            //    parameter.Add(new KeyValuePair<string, object>("@addedBy", jobCard.addedBy));
            //    parameter.Add(new KeyValuePair<string, object>("@addedOn", jobCard.addedOn));
            //    SqlHandler sqlH = new SqlHandler();
            //    int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addjobCardDetails]", parameter);
             return 1;
            //}
            //catch (Exception ae)
            //{
            //    throw ae;
            //}
        }
    }
}
