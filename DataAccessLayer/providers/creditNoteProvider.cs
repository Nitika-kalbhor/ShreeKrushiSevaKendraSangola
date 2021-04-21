using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
   public static class creditNoteProvider
    {
       #region defination & declaration
       private static string _connectionString = SystemSetting.ConnectionString;
       #endregion
       public static long getMaxIdCreditNoteId(long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               long salesRetrunInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getMaxCreditNoteInvoiceID]", parameter);
               return salesRetrunInvoiceId;
           }
           catch (Exception ae)
           {
               throw ae;
           }

       }

       public static int addSalescreditNote(SalesReturnDetails creditNote,PusrchaseSaleAccount sale)
       {
             using (var Conn = new SqlConnection(_connectionString))
            {
                SqlHandler sqlH = new SqlHandler();
                SqlTransaction trans = null;
                try
                {
                    Conn.Open();
                    trans = Conn.BeginTransaction();
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@creditNoteId", creditNote.salesReturnId));
               parameter.Add(new KeyValuePair<string, object>("@creditNoteInvoiceId", creditNote.salesReturnInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", creditNote.financialYearID));
               parameter.Add(new KeyValuePair<string, object>("@creditNoteDate", creditNote.salesReturnDate));
               parameter.Add(new KeyValuePair<string, object>("@state", creditNote.state));
               parameter.Add(new KeyValuePair<string, object>("@stateCode", creditNote.stateCode));
               parameter.Add(new KeyValuePair<string, object>("@customerId", creditNote.customerId));
               parameter.Add(new KeyValuePair<string, object>("@creditNoteType", creditNote.salesType));
               parameter.Add(new KeyValuePair<string, object>("@creditNoteAmount", creditNote.totalbillAmount));
               parameter.Add(new KeyValuePair<string, object>("@naration", creditNote.naration));
               parameter.Add(new KeyValuePair<string, object>("@paymentType", creditNote.paymentType));
               parameter.Add(new KeyValuePair<string, object>("@bankName", creditNote.bankName));
               parameter.Add(new KeyValuePair<string, object>("@bankId", creditNote.bankId));
               parameter.Add(new KeyValuePair<string, object>("@chequeDate", creditNote.chequeDate));
               parameter.Add(new KeyValuePair<string, object>("@refNo", creditNote.chequeNo_refNo));
               parameter.Add(new KeyValuePair<string, object>("@isCustomerRetailer", creditNote.isCustomerRetailer));
               parameter.Add(new KeyValuePair<string, object>("@isDelete", creditNote.isDelete));
               //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", creditNote.SaleItemTable));
               
               int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addCreditNoteMaster]", parameter,Conn,trans);
               if (creditNote.isDelete == false)
               {
                   List<KeyValuePair<string, object>> parameter2 = new List<KeyValuePair<string, object>>();
                   parameter2.Add(new KeyValuePair<string, object>("@transactionId", sale.transactionId));
                   parameter2.Add(new KeyValuePair<string, object>("@financialYearID", creditNote.financialYearID));
                   parameter2.Add(new KeyValuePair<string, object>("@transactionDate", creditNote.salesReturnDate));
                   parameter2.Add(new KeyValuePair<string, object>("@billId", sale.billId));
                   parameter2.Add(new KeyValuePair<string, object>("@Hamali", sale.Hamali));
                   parameter2.Add(new KeyValuePair<string, object>("@RoundOff", sale.RoundOff));
                   parameter2.Add(new KeyValuePair<string, object>("@discount", sale.discount));
                   parameter2.Add(new KeyValuePair<string, object>("@Igst5", sale.Igst5));
                   parameter2.Add(new KeyValuePair<string, object>("@Igst12", sale.Igst12));
                   parameter2.Add(new KeyValuePair<string, object>("@Igst18", sale.Igst18));
                   parameter2.Add(new KeyValuePair<string, object>("@Igst28", sale.Igst28));
                   parameter2.Add(new KeyValuePair<string, object>("@salePurchaseAccount", sale.salePurchaseAccount));
                   parameter2.Add(new KeyValuePair<string, object>("@issalePurchase", sale.issalePurchase));
                   parameter2.Add(new KeyValuePair<string, object>("@stateCode", sale.stateCode));
                   int s = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addAllCreditNoteAccount]", parameter2,Conn,trans);
               }
               int result = 0;
               for (int k = 0; k < creditNote.SaleRetrunItemTable.Rows.Count; k++)
               {
                   List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();
                   parameter1.Add(new KeyValuePair<string, object>("@creditNoteId", creditNote.salesReturnId));
                   parameter1.Add(new KeyValuePair<string, object>("@creditNoteInvoiceId", creditNote.salesReturnInvoiceId));
                   parameter1.Add(new KeyValuePair<string, object>("@financialYearID", creditNote.financialYearID));
                   parameter1.Add(new KeyValuePair<string, object>("@creditNoteDetailsId", creditNote.SaleRetrunItemTable.Rows[k]["salesReturnItemDetailsId"]));//4
                   parameter1.Add(new KeyValuePair<string, object>("@itemName", creditNote.SaleRetrunItemTable.Rows[k]["itemName"]));//8
                   parameter1.Add(new KeyValuePair<string, object>("@quantity", creditNote.SaleRetrunItemTable.Rows[k]["Quantity"]));//8
                   parameter1.Add(new KeyValuePair<string, object>("@batchNo", creditNote.SaleRetrunItemTable.Rows[k]["batchNo"]));//12
                   parameter1.Add(new KeyValuePair<string, object>("@unitBy", creditNote.SaleRetrunItemTable.Rows[k]["unitBy"]));//13
                   parameter1.Add(new KeyValuePair<string, object>("@rate", creditNote.SaleRetrunItemTable.Rows[k]["Rate"]));//5
                   parameter1.Add(new KeyValuePair<string, object>("@IGST", creditNote.SaleRetrunItemTable.Rows[k]["IGST"]));//16
                   parameter1.Add(new KeyValuePair<string, object>("@CGST", creditNote.SaleRetrunItemTable.Rows[k]["CGST"]));//16
                   parameter1.Add(new KeyValuePair<string, object>("@SGST", creditNote.SaleRetrunItemTable.Rows[k]["SGST"]));//16
                   parameter1.Add(new KeyValuePair<string, object>("@totalAmount", creditNote.SaleRetrunItemTable.Rows[k]["totalAmount"]));//16
                   parameter1.Add(new KeyValuePair<string, object>("@totalAmtWithGST", creditNote.SaleRetrunItemTable.Rows[k]["totalAmtWithGST"]));//16
                   parameter1.Add(new KeyValuePair<string, object>("@isDelete", creditNote.isDelete));//19
                   result = sqlH.ExecuteNonQueryTM("Usp_addCreditNoteDetails", parameter1,Conn,trans);
               }
               trans.Commit();
               return i;
                }
                catch (Exception ex)
                {
                    if (trans != null) trans.Rollback();
                    throw ex;
                }
                finally { Conn.Close(); }
            }
       }

       internal static DataTable getCreditDebitNote(DateTime fromDate, DateTime toDate, long financialYearId)
       {
           try
           {
               try
               {
                   List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                   parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                   parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                   parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearId));
                   SqlHandler sqlH = new SqlHandler();
                   DataTable dtCreditNoteDetails = sqlH.ExecuteAsDataTable("[dbo].[Usp_getCreditDebitNoteList]", parameter);
                   return dtCreditNoteDetails;
               }
               catch (Exception ae)
               {
                   throw ae;
               }
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }

       internal static DataTable getCreditDebitNote(long creditNoteId, long financialYearID)
       {
           try
           {
               try
               {
                   List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                   parameter.Add(new KeyValuePair<string, object>("@creditNoteId", creditNoteId));
                   parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                   SqlHandler sqlH = new SqlHandler();
                   DataTable dtCreditNoteDetails = sqlH.ExecuteAsDataTable("[dbo].[Usp_getCreditDebitNoteDetails]", parameter);
                   return dtCreditNoteDetails;
               }
               catch (Exception ae)
               {
                   throw ae;
               }
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
    }
}
