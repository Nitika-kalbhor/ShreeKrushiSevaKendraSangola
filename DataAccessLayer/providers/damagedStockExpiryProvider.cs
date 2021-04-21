using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
   public class damagedStockExpiryProvider
    {
       public static int adddamagedStockExpiry(damagedStockExpiry damagedStock)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@damagedStockExpiryId", damagedStock.damagedStockExpiryId));
               parameter.Add(new KeyValuePair<string, object>("@damagedStockDate", damagedStock.damagedStockDate));
               parameter.Add(new KeyValuePair<string, object>("@accountId", damagedStock.accountId));
               parameter.Add(new KeyValuePair<string, object>("@InvoiceId", damagedStock.InvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@addedBy", damagedStock.addedBy));
               parameter.Add(new KeyValuePair<string, object>("@addedOn", damagedStock.addedOn));
               parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", damagedStock.FinancialYearID));
               parameter.Add(new KeyValuePair<string, object>("@Amount", damagedStock.Amount));
               parameter.Add(new KeyValuePair<string, object>("@Remark", damagedStock.Remark));
               parameter.Add(new KeyValuePair<string, object>("@isUpdate", damagedStock.isUpdate));
               parameter.Add(new KeyValuePair<string, object>("@isDelete", damagedStock.isDelete));
               parameter.Add(new KeyValuePair<string, object>("@transactionId", damagedStock.transactionId));
              
               SqlHandler sqlH = new SqlHandler();
               int listi = sqlH.ExecuteNonQueryI("[dbo].[Usp_adddamagedStockExpiry]", parameter);
               int result = 0;
               for (int k = 0; k < damagedStock.dtItems.Rows.Count; k++)
               {
                   List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();               
                   parameter1.Add(new KeyValuePair<string, object>("@FinancialYearID", damagedStock.FinancialYearID));
                   parameter1.Add(new KeyValuePair<string, object>("@StockId", damagedStock.dtItems.Rows[k]["StockId"]));        
                   parameter1.Add(new KeyValuePair<string, object>("@itemId", damagedStock.dtItems.Rows[k]["itemId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@categoryId", damagedStock.dtItems.Rows[k]["categoryId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@companyId", damagedStock.dtItems.Rows[k]["companyId"]));                            
                   parameter1.Add(new KeyValuePair<string, object>("@batchNo", damagedStock.dtItems.Rows[k]["batchNo"]));
                   parameter1.Add(new KeyValuePair<string, object>("@MFD_Date", damagedStock.dtItems.Rows[k]["MFD_Date"]));
                   parameter1.Add(new KeyValuePair<string, object>("@expireDate", damagedStock.dtItems.Rows[k]["expireDate"]));
                   parameter1.Add(new KeyValuePair<string, object>("@Quantity", damagedStock.dtItems.Rows[k]["Quantity"]));
                   parameter1.Add(new KeyValuePair<string, object>("@unitBy", damagedStock.dtItems.Rows[k]["unitBy"]));
                   parameter1.Add(new KeyValuePair<string, object>("@damagedStockExpiryItemId", damagedStock.dtItems.Rows[k]["damagedStockExpiryItemId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@purchaseRate", damagedStock.dtItems.Rows[k]["purchaseRate"]));
                   parameter1.Add(new KeyValuePair<string, object>("@Amount", damagedStock.dtItems.Rows[k]["totalAmount"]));
                //   parameter1.Add(new KeyValuePair<string, object>("@isUpdate", damagedStock.isUpdate));
                   parameter1.Add(new KeyValuePair<string, object>("@isDelete", damagedStock.isDelete));           
                   parameter1.Add(new KeyValuePair<string, object>("@invoiceId", damagedStock.InvoiceId));
                   result = +sqlH.ExecuteNonQueryI("[dbo].[Usp_adddamagedStockExpiryItem]", parameter1);
               }
               return listi + result;
           }
           catch (Exception ae)
           {
               throw ae;
           }//8999501263
       }
    }
}
