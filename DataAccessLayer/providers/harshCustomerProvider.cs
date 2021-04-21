using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;

namespace DataAccessLayer.providers
{
  public  class harshCustomerProvider
    {
      public static int addCustomerDetails(harshCustomer customer)
      {
          try
          {
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@customerId", customer.customerId));
              parameter.Add(new KeyValuePair<string, object>("@customerName", customer.customerName));
              parameter.Add(new KeyValuePair<string, object>("@address", customer.address));
              parameter.Add(new KeyValuePair<string, object>("@dateofbirth", customer.dateofbirth));
              parameter.Add(new KeyValuePair<string, object>("@date", customer.date));
              parameter.Add(new KeyValuePair<string, object>("@mobileNo", customer.mobileNo));
              parameter.Add(new KeyValuePair<string, object>("@pinCode", customer.pinCode));
              parameter.Add(new KeyValuePair<string, object>("@city", customer.city));
              parameter.Add(new KeyValuePair<string, object>("@country", customer.country));          
            
          
              SqlHandler sqlH = new SqlHandler();
              int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addCustomerDetails]", parameter);
              return i;
          }
          catch (Exception ae)
          {
              throw ae;
          }

      }
    }
}
