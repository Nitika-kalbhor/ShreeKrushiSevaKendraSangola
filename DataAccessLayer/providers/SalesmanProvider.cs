using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
 public   class SalesmanProvider
    {
     public static int addSalesmanDetails(SalesmanDetails salesm)
            {
                try
                {
                    List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                    parameter.Add(new KeyValuePair<string, object>("@SalesmanId", salesm.SalesmanId));
                    parameter.Add(new KeyValuePair<string, object>("@SalesmanName", salesm.SalesmanName));
                    parameter.Add(new KeyValuePair<string, object>("@Address", salesm.Address));
                    parameter.Add(new KeyValuePair<string, object>("@DOB", salesm.DOB));
                    parameter.Add(new KeyValuePair<string, object>("@GenderId", salesm.GenderId));
                    parameter.Add(new KeyValuePair<string, object>("@MobileNo", salesm.MobileNo));
                    parameter.Add(new KeyValuePair<string, object>("@EmailId", salesm.EmailId));
                    parameter.Add(new KeyValuePair<string, object>("@addedBy", salesm.addedBy));
                    parameter.Add(new KeyValuePair<string, object>("@addedOn", salesm.addedOn));
                    parameter.Add(new KeyValuePair<string, object>("@isDelete", salesm.isDelete));                  
                    SqlHandler sqlH = new SqlHandler();
                    int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addSalesmanDetails]", parameter);
                    return i;
                }
                catch (Exception ae)
                {
                    throw ae;
                }

            }
     public static DataTable getSalesmanDetails()
     {
         try
         {

             SqlHandler sqlH = new SqlHandler();
             DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSalesmanDetails]");
             return i;
         }
         catch (Exception ae)
         {
             throw ae;
         }

     }
     //public static int UpdateSalesmanDetails(long customerId, double limitationAmount)
     //{
     //    try
     //    {
     //        List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
     //        parameter.Add(new KeyValuePair<string, object>("@customerId", customerId));
     //        parameter.Add(new KeyValuePair<string, object>("@limitationAmount", limitationAmount));
     //        SqlHandler sqlH = new SqlHandler();
     //        int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_UpdateCustomerDetails]", parameter);
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
     //        List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
     //        parameter.Add(new KeyValuePair<string, object>("@isCustomerRetailer", isCustomerRetailer));
     //        SqlHandler sqlH = new SqlHandler();
     //        DataTable dt = sqlH.ExecuteAsDataTable("Usp_getCustomerRetailerDetails", parameter);
     //        return dt;
     //    }
     //    catch (Exception ex)
     //    {
     //        throw ex;
     //    }
     //}    
        
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
    }
}
