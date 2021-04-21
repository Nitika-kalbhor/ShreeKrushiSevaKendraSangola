using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using System.Data;

namespace DataAccessLayer.providers
{
 public   class ImportExcelProvider
    {
     public static int ImportExcelForDataBase(DataTable dtImport, string Forms, int addedBy, DateTime addedOn, long financialYearID)
     {
         try
         {
                 int result = 0;           
                 #region Stock Excel Imports
             if (Forms == "स्टॉक")
             {
                 for (int k = 0; k < dtImport.Rows.Count; k++)
                 {
                     List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                     parameter.Add(new KeyValuePair<string, object>("@mainCategory", dtImport.Rows[k]["mainCategory"]));
                     parameter.Add(new KeyValuePair<string, object>("@itemName", dtImport.Rows[k]["itemName"]));
                     parameter.Add(new KeyValuePair<string, object>("@categoryName", dtImport.Rows[k]["categoryName"]));
                     parameter.Add(new KeyValuePair<string, object>("@companyName", dtImport.Rows[k]["companyName"]));
                     parameter.Add(new KeyValuePair<string, object>("@unitBy", dtImport.Rows[k]["unitBy"]));
                     parameter.Add(new KeyValuePair<string, object>("@Qty", dtImport.Rows[k]["Qty"]));
                     parameter.Add(new KeyValuePair<string, object>("@godownDetails", dtImport.Rows[k]["godownDetails"]));
                     parameter.Add(new KeyValuePair<string, object>("@HNSCode", dtImport.Rows[k]["HNSCode"].ToString()));
                     parameter.Add(new KeyValuePair<string, object>("@batchNo", dtImport.Rows[k]["batchNo"]));                   
                     if (dtImport.Rows[k]["mfgDate"].ToString() == "" || dtImport.Rows[k]["mfgDate"]== null)
                     {
                         parameter.Add(new KeyValuePair<string, object>("@mfgDate",Convert.ToDateTime(DateTime.Now)));
                     }
                     else
                     {
                         parameter.Add(new KeyValuePair<string, object>("@mfgDate", Convert.ToDateTime(dtImport.Rows[k]["mfgDate"])));
                     }
                     if (dtImport.Rows[k]["expireDate"].ToString() == "" || dtImport.Rows[k]["expireDate"] == null)
                     {
                         parameter.Add(new KeyValuePair<string, object>("@expireDate", Convert.ToDateTime(DateTime.Now)));
                     }
                     else
                     {
                         parameter.Add(new KeyValuePair<string, object>("@expireDate", Convert.ToDateTime(dtImport.Rows[k]["expireDate"])));
                     }

                     parameter.Add(new KeyValuePair<string, object>("@isExpiryApplicable", dtImport.Rows[k]["isExpiryApplicable"]));
                     if (dtImport.Rows[k]["MRP"] != null && dtImport.Rows[k]["MRP"].ToString() != string.Empty)
                     {
                         parameter.Add(new KeyValuePair<string, object>("@MRP", dtImport.Rows[k]["MRP"]));
                     }
                     else
                     {
                         parameter.Add(new KeyValuePair<string, object>("@MRP", 0));
                     }
                     if (dtImport.Rows[k]["GST"] != null && dtImport.Rows[k]["GST"].ToString() != string.Empty)
                     {
                         parameter.Add(new KeyValuePair<string, object>("@IGST", dtImport.Rows[k]["GST"]));
                         parameter.Add(new KeyValuePair<string, object>("@CGST", dtImport.Rows[k]["CGST"]));
                         parameter.Add(new KeyValuePair<string, object>("@SGST", dtImport.Rows[k]["SGST"]));
                     }
                     else
                     {
                         parameter.Add(new KeyValuePair<string, object>("@IGST", 0));
                         parameter.Add(new KeyValuePair<string, object>("@CGST", 0));
                         parameter.Add(new KeyValuePair<string, object>("@SGST",0));
                     }
                     if (dtImport.Rows[k]["purchaseRate"] != null && dtImport.Rows[k]["purchaseRate"].ToString() != string.Empty)
                     { parameter.Add(new KeyValuePair<string, object>("@purchaseRate", dtImport.Rows[k]["purchaseRate"])); }
                     else
                     { parameter.Add(new KeyValuePair<string, object>("@purchaseRate", 0)); }

                     if (dtImport.Rows[k]["salesCashRate"] != null && dtImport.Rows[k]["salesCashRate"].ToString() != string.Empty)
                     { parameter.Add(new KeyValuePair<string, object>("@salesCashRate", dtImport.Rows[k]["salesCashRate"])); }
                     else
                     { parameter.Add(new KeyValuePair<string, object>("@salesCashRate", 0)); }

                     if (dtImport.Rows[k]["salesCreditRate"] != null && dtImport.Rows[k]["salesCreditRate"].ToString() != string.Empty)
                     { parameter.Add(new KeyValuePair<string, object>("@salesCreditRate", dtImport.Rows[k]["salesCreditRate"])); }
                     else
                     {
                         if (dtImport.Rows[k]["salesCashRate"] != null && dtImport.Rows[k]["salesCashRate"].ToString() != string.Empty)
                         {
                             parameter.Add(new KeyValuePair<string, object>("@salesCreditRate", dtImport.Rows[k]["salesCashRate"]));
                         }
                         else
                         {
                             parameter.Add(new KeyValuePair<string, object>("@salesCreditRate", 0));
                         }
                     }
                     if (dtImport.Rows[k]["wholeSalesCashRate"] != null && dtImport.Rows[k]["wholeSalesCashRate"].ToString() != string.Empty)
                     { parameter.Add(new KeyValuePair<string, object>("@wholeSalesCashRate", dtImport.Rows[k]["wholeSalesCashRate"])); }
                     else
                     {
                         if (dtImport.Rows[k]["salesCashRate"] != null && dtImport.Rows[k]["salesCashRate"].ToString() != string.Empty)
                         {
                             parameter.Add(new KeyValuePair<string, object>("@wholeSalesCashRate", dtImport.Rows[k]["salesCashRate"]));
                         }
                         else
                         {
                             parameter.Add(new KeyValuePair<string, object>("@wholeSalesCashRate", 0));
                         }
                     }
                     if (dtImport.Rows[k]["wholeSalesCreditRate"] != null && dtImport.Rows[k]["wholeSalesCreditRate"].ToString() != string.Empty)
                     { parameter.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate", dtImport.Rows[k]["wholeSalesCreditRate"])); }
                     else
                     {
                         if (dtImport.Rows[k]["salesCashRate"] != null && dtImport.Rows[k]["salesCashRate"].ToString() != string.Empty)
                         {
                             parameter.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate", dtImport.Rows[k]["salesCashRate"]));
                         }
                         else
                         {
                             parameter.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate", 0));
                         }
                     }
                     parameter.Add(new KeyValuePair<string, object>("@addedBy", addedBy));
                     parameter.Add(new KeyValuePair<string, object>("@addedOn", addedOn));
                     SqlHandler sqlH = new SqlHandler();
                     result += sqlH.ExecuteNonQueryI("[dbo].[Usp_addItemDetailsForExcel]", parameter);

                 }
             }
                 #endregion Stock Excel Imports
                 #region Customer Excel Imports
             #region Cusromer Excel Imports
             if (Forms == "ग्राहक")
             {
                 for (int k = 0; k < dtImport.Rows.Count; k++)
                 {
                     List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                     parameter.Add(new KeyValuePair<string, object>("@customerId", 0));
                     parameter.Add(new KeyValuePair<string, object>("@customerName", dtImport.Rows[k]["customerName"].ToString().Trim()));
                     parameter.Add(new KeyValuePair<string, object>("@customerAddress",""));
                     parameter.Add(new KeyValuePair<string, object>("@CustomerGSTNo",""));
                     parameter.Add(new KeyValuePair<string, object>("@isCustomerRetailer", "Customer"));
                     parameter.Add(new KeyValuePair<string, object>("@DOB", DateTime.Now));
                     parameter.Add(new KeyValuePair<string, object>("@genderId", "Male"));
                     parameter.Add(new KeyValuePair<string, object>("@villageId", 0));
                     parameter.Add(new KeyValuePair<string, object>("@customerMobileNo", ""));
                     parameter.Add(new KeyValuePair<string, object>("@MobileTwo", ""));
                     parameter.Add(new KeyValuePair<string, object>("@MobileThree", ""));
                     parameter.Add(new KeyValuePair<string, object>("@emailId", ""));
                     parameter.Add(new KeyValuePair<string, object>("@contactPerson", ""));
                     parameter.Add(new KeyValuePair<string, object>("@contactNo", ""));
                     parameter.Add(new KeyValuePair<string, object>("@isCreditDebit", "नावे रक्कम"));
                     parameter.Add(new KeyValuePair<string, object>("@openigBalanace", 0));
                     parameter.Add(new KeyValuePair<string, object>("@OtherNote", ""));
                     parameter.Add(new KeyValuePair<string, object>("@adharNo", ""));
                     double drAmount = 0, crAmount = 0;
                     if (dtImport.Rows[k]["isCreditDebit"].ToString() == "जमा रक्कम")
                     {
                         drAmount = Convert.ToDouble(dtImport.Rows[k]["DR"]);
                         crAmount = 0;

                     }
                     if (dtImport.Rows[k]["isCreditDebit"].ToString() == "नावे रक्कम")
                     {
                         crAmount = Convert.ToDouble(dtImport.Rows[k]["DR"]);
                         drAmount = 0;
                     }
                     parameter.Add(new KeyValuePair<string, object>("@billDate", DateTime.Now));
                     parameter.Add(new KeyValuePair<string, object>("@crAmount", crAmount));
                     parameter.Add(new KeyValuePair<string, object>("@drAmount", drAmount));
                     parameter.Add(new KeyValuePair<string, object>("@isActive", 1));
                     parameter.Add(new KeyValuePair<string, object>("@addedBy", addedBy));
                     parameter.Add(new KeyValuePair<string, object>("@addedOn", addedOn));
                     parameter.Add(new KeyValuePair<string, object>("@discount", 0));
                     parameter.Add(new KeyValuePair<string, object>("@limitationAmount", 0));
                     parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", financialYearID));
                     SqlHandler sqlH = new SqlHandler();
                     result += sqlH.ExecuteNonQueryI("[dbo].[Usp_addCustomerDetails]", parameter);
                 }
             }
             #endregion Cusromer Excel Imports
             #endregion Customer Excel Imports

             #region 
             if (Forms == "व्यापारी")
             {
                 for (int k = 0; k < dtImport.Rows.Count; k++)
                 {
                     List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                     parameter.Add(new KeyValuePair<string, object>("@dealerId", 0));
                     parameter.Add(new KeyValuePair<string, object>("@dealerName", dtImport.Rows[k]["dealerName"]));
                     parameter.Add(new KeyValuePair<string, object>("@dealerFirmName", dtImport.Rows[k]["dealerName"]));
                     parameter.Add(new KeyValuePair<string, object>("@dealerAddress", dtImport.Rows[k]["dealerAddress"]));
                     parameter.Add(new KeyValuePair<string, object>("@dealerFirmAddress", ""));
                     parameter.Add(new KeyValuePair<string, object>("@DOB", DateTime.Now));
                     parameter.Add(new KeyValuePair<string, object>("@genderId", 1));
                     parameter.Add(new KeyValuePair<string, object>("@emailId", ""));
                     parameter.Add(new KeyValuePair<string, object>("@dealerContactNo", dtImport.Rows[k]["dealerContactNo"]));
                     parameter.Add(new KeyValuePair<string, object>("@GSTNo", ""));
                     parameter.Add(new KeyValuePair<string, object>("@officeNo", ""));
                     parameter.Add(new KeyValuePair<string, object>("@openigBalanace", dtImport.Rows[k]["DR"]));
                     parameter.Add(new KeyValuePair<string, object>("@isCreditDebit", dtImport.Rows[k]["isCreditDebit"]));
                     parameter.Add(new KeyValuePair<string, object>("@isCustomer", false));
                     double drAmount = 0, crAmount = 0;
                     if (dtImport.Rows[k]["isCreditDebit"].ToString() == "जमा रक्कम")
                     {
                         crAmount = 0;
                         drAmount = Convert.ToDouble(dtImport.Rows[k]["DR"]);

                     }
                     if (dtImport.Rows[k]["isCreditDebit"].ToString() == "नावे रक्कम")
                     {
                         crAmount = Convert.ToDouble(dtImport.Rows[k]["DR"]);
                         drAmount = 0;
                     }
                     parameter.Add(new KeyValuePair<string, object>("@billDate", DateTime.Now));
                     parameter.Add(new KeyValuePair<string, object>("@crAmount", crAmount));
                     parameter.Add(new KeyValuePair<string, object>("@drAmount", drAmount));
                     parameter.Add(new KeyValuePair<string, object>("@naration", "OP"));
                     parameter.Add(new KeyValuePair<string, object>("@isActive", 1));
                     parameter.Add(new KeyValuePair<string, object>("@addedBy", addedBy));
                     parameter.Add(new KeyValuePair<string, object>("@addedOn",addedOn));
                     parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", financialYearID));
                     SqlHandler sqlH = new SqlHandler();
                     result += sqlH.ExecuteNonQueryI("[dbo].[Usp_adddealerDetails]", parameter);
                 }
             }
             #endregion
             return result;
         }
         catch (Exception ex)
         {
             throw ex;
         }
     }
    }
}
