using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
   public class TempSaleDetailsProvider
    {
        #region defination & declaration
        private static string _connectionString = SystemSetting.ConnectionString;
        #endregion
       public static long getMaxIdTempSaleInvoiceId(long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               long salesInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getMaxIdTempSaleInvoiceId]", parameter);
               return salesInvoiceId;
           }
           catch (Exception ae)
           {
               throw ae;
           }

       }
   
       public static int addTempSalesDetails(SalesDetails sale)
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
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", sale.salesInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", sale.FinancialYearID));
               parameter.Add(new KeyValuePair<string, object>("@salesDate", sale.salesDate));
               parameter.Add(new KeyValuePair<string, object>("@customerId", sale.customerId));
               parameter.Add(new KeyValuePair<string, object>("@salesType", sale.salesType));
               parameter.Add(new KeyValuePair<string, object>("@totalbillAmount", sale.totalbillAmount));
               parameter.Add(new KeyValuePair<string, object>("@paidAmount", sale.paidAmount));
               parameter.Add(new KeyValuePair<string, object>("@roundOff", sale.roundOff));
               parameter.Add(new KeyValuePair<string, object>("@discount", sale.discount));
               parameter.Add(new KeyValuePair<string, object>("@netbillAmount", sale.netbillAmount));
               parameter.Add(new KeyValuePair<string, object>("@paymentType", sale.paymentType));
               parameter.Add(new KeyValuePair<string, object>("@bankName", sale.bankName));
               parameter.Add(new KeyValuePair<string, object>("@bankId", sale.bankId));
               parameter.Add(new KeyValuePair<string, object>("@chequeDate", sale.chequeDate));
               parameter.Add(new KeyValuePair<string, object>("@refNo", sale.chequeNo_refNo));
               parameter.Add(new KeyValuePair<string, object>("@state", sale.state));
               parameter.Add(new KeyValuePair<string, object>("@stateCode", sale.stateCode));
               parameter.Add(new KeyValuePair<string, object>("@addedBy", sale.addedBy));
               parameter.Add(new KeyValuePair<string, object>("@isDelete", sale.isDelete));
               parameter.Add(new KeyValuePair<string, object>("@addedOn", sale.addedOn));
               parameter.Add(new KeyValuePair<string, object>("@isCustomerRetailer", sale.isRetailer));
               parameter.Add(new KeyValuePair<string, object>("@hamali", sale.hamali));
               parameter.Add(new KeyValuePair<string, object>("@InvoiceIdPesticide", sale.InvoiceIdPesticide));
               parameter.Add(new KeyValuePair<string, object>("@InvoiceIdFertilizer", sale.InvoiceIdFertilizer));
               parameter.Add(new KeyValuePair<string, object>("@InvoiceIdSeeds", sale.InvoiceIdSeeds));
               parameter.Add(new KeyValuePair<string, object>("@InvoiceIdPGROther", sale.InvoiceIdPGROther));
               parameter.Add(new KeyValuePair<string, object>("@nextPaymentdate", sale.nextPaymentdate));
               parameter.Add(new KeyValuePair<string, object>("@ChalanNo", sale.chalanNo));
            
               int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addTempSalesDetails]", parameter,Conn,trans);            
               int result = 0;
               for (int k = 0; k < sale.SaleItemTable.Rows.Count; k++)
               {
                   List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();
                   parameter1.Add(new KeyValuePair<string, object>("@salesinvoiceId", sale.salesInvoiceId));
                   parameter1.Add(new KeyValuePair<string, object>("@FinancialYearID", sale.FinancialYearID));
                   parameter1.Add(new KeyValuePair<string, object>("@itemId", sale.SaleItemTable.Rows[k]["itemId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@salesItemDetailsId", sale.SaleItemTable.Rows[k]["salesItemDetailsId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@stockId", sale.SaleItemTable.Rows[k]["stockId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@companyId", sale.SaleItemTable.Rows[k]["companyId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@categoryId", sale.SaleItemTable.Rows[k]["categoryId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@Quantity", sale.SaleItemTable.Rows[k]["Quantity"]));
                   parameter1.Add(new KeyValuePair<string, object>("@IGST", sale.SaleItemTable.Rows[k]["IGST"]));
                   parameter1.Add(new KeyValuePair<string, object>("@CGST", sale.SaleItemTable.Rows[k]["CGST"]));
                   parameter1.Add(new KeyValuePair<string, object>("@SGST", sale.SaleItemTable.Rows[k]["SGST"]));
                   parameter1.Add(new KeyValuePair<string, object>("@batchNo", sale.SaleItemTable.Rows[k]["batchNo"]));
                   parameter1.Add(new KeyValuePair<string, object>("@unitBy", sale.SaleItemTable.Rows[k]["unitBy"]));
                   parameter1.Add(new KeyValuePair<string, object>("@MFD_Date", Convert.ToDateTime(sale.SaleItemTable.Rows[k]["MFD_Date"])));
                   parameter1.Add(new KeyValuePair<string, object>("@expireDate", Convert.ToDateTime(sale.SaleItemTable.Rows[k]["expireDate"])));
                   parameter1.Add(new KeyValuePair<string, object>("@discount", sale.SaleItemTable.Rows[k]["discount"]));
                   parameter1.Add(new KeyValuePair<string, object>("@perQtysalePrice", sale.SaleItemTable.Rows[k]["Rate"]));
                   parameter1.Add(new KeyValuePair<string, object>("@salePrice", sale.SaleItemTable.Rows[k]["totalAmount"]));
                   parameter1.Add(new KeyValuePair<string, object>("@addedBy", sale.addedBy));
                   parameter1.Add(new KeyValuePair<string, object>("@isDelete", sale.isDelete));
                   parameter1.Add(new KeyValuePair<string, object>("@addedOn", sale.addedOn));
                   parameter1.Add(new KeyValuePair<string, object>("@isPesticide", sale.SaleItemTable.Rows[k]["isPesticide"]));
                   parameter1.Add(new KeyValuePair<string, object>("@isFertilizer", sale.SaleItemTable.Rows[k]["isFertilizer"]));
                   parameter1.Add(new KeyValuePair<string, object>("@isSeeds", sale.SaleItemTable.Rows[k]["isSeeds"]));
                   parameter1.Add(new KeyValuePair<string, object>("@isPGROthers", sale.SaleItemTable.Rows[k]["isPGROthers"]));
                   parameter1.Add(new KeyValuePair<string, object>("@InvoiceNo", sale.SaleItemTable.Rows[k]["InvoiceNo"]));
                   parameter1.Add(new KeyValuePair<string, object>("@convertFromChalan", false));
                   result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addTempSaleStockUpdate]", parameter1,Conn,trans);
               }
               trans.Commit();
               return result;
                }
                catch (Exception ex)
                {
                    if (trans != null) trans.Rollback();
                    throw ex;
                }
                finally { Conn.Close(); }
            }
       }

       public static DataTable getTempStockInSaleItemDetails(string value, string type)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@txtSearch", value));
               parameter.Add(new KeyValuePair<string, object>("@type", type));
               SqlHandler sqlH = new SqlHandler();
               DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempStockInSaleItemDetails]", parameter);
               return listi;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getTempSaleIvoiceList(DateTime fromDate, DateTime toDate)
       {
           try
           {
               DataTable dtChallanList = new DataTable();
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
               SqlHandler sqlH = new SqlHandler();
               dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempSaleIvoiceList]", parameter);
               return dtChallanList;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getTempSaleInvoice(string salesInvoiceId, long financialYearID)
       {
           try
           {
               DataTable dtSaleInvoice = new DataTable();
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salesInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               dtSaleInvoice = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempSaleInvoice]", parameter);
               return dtSaleInvoice;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getSaleInvoice(string salesInvoiceId, long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salesInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempSaleBillPrint]", parameter);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }

       }
       public static DataTable getSaleInvoiceByHSNCode(string salesInvoiceId, long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salesInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempSaleBillSlotByHSNCode]", parameter);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable GetTempSaleBook(DateTime fromDate, DateTime toDate, long financialYearID, string opration, string cashCredit)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));//1
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));//2
               parameter.Add(new KeyValuePair<string, object>("@opration", opration));//3
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));//
               parameter.Add(new KeyValuePair<string, object>("@cashCredit", cashCredit));//4
               SqlHandler sqlH = new SqlHandler();
               // DataTable lists = sqlH.ExecuteAsDataTable("[dbo].[Usp_SaleBookbyGSTSlab]", parameter);
               DataTable lists = sqlH.ExecuteAsDataTable("[dbo].[Usp_TempSaleBookbyGSTNew]", parameter);
               return lists;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getTempStockInItemDetails(string value)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@txtSearch", value));
               SqlHandler sqlH = new SqlHandler();
               DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempStockInItemDetails]", parameter);
               return listi;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }


       public static int addTempSalesDetailsForConvertChalan(SalesDetails salechalan)
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
               parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salechalan.salesInvoiceId));
               parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", salechalan.FinancialYearID));
               parameter.Add(new KeyValuePair<string, object>("@salesDate", salechalan.salesDate));
               parameter.Add(new KeyValuePair<string, object>("@customerId", salechalan.customerId));
               parameter.Add(new KeyValuePair<string, object>("@salesType", salechalan.salesType));
               parameter.Add(new KeyValuePair<string, object>("@totalbillAmount", salechalan.totalbillAmount));
               parameter.Add(new KeyValuePair<string, object>("@paidAmount", salechalan.paidAmount));
               parameter.Add(new KeyValuePair<string, object>("@roundOff", salechalan.roundOff));
               parameter.Add(new KeyValuePair<string, object>("@discount", salechalan.discount));
               parameter.Add(new KeyValuePair<string, object>("@netbillAmount", salechalan.netbillAmount));
               parameter.Add(new KeyValuePair<string, object>("@paymentType", salechalan.paymentType));
               parameter.Add(new KeyValuePair<string, object>("@bankName", salechalan.bankName));
               parameter.Add(new KeyValuePair<string, object>("@bankId", salechalan.bankId));
               parameter.Add(new KeyValuePair<string, object>("@chequeDate", salechalan.chequeDate));
               parameter.Add(new KeyValuePair<string, object>("@refNo", salechalan.chequeNo_refNo));
               parameter.Add(new KeyValuePair<string, object>("@state", salechalan.state));
               parameter.Add(new KeyValuePair<string, object>("@stateCode", salechalan.stateCode));
               parameter.Add(new KeyValuePair<string, object>("@addedBy", salechalan.addedBy));
               parameter.Add(new KeyValuePair<string, object>("@isDelete", salechalan.isDelete));
               parameter.Add(new KeyValuePair<string, object>("@addedOn", salechalan.addedOn));
               parameter.Add(new KeyValuePair<string, object>("@isCustomerRetailer", salechalan.isRetailer));
               parameter.Add(new KeyValuePair<string, object>("@hamali", salechalan.hamali));
               parameter.Add(new KeyValuePair<string, object>("@InvoiceIdPesticide", salechalan.InvoiceIdPesticide));
               parameter.Add(new KeyValuePair<string, object>("@InvoiceIdFertilizer", salechalan.InvoiceIdFertilizer));
               parameter.Add(new KeyValuePair<string, object>("@InvoiceIdSeeds", salechalan.InvoiceIdSeeds));
               parameter.Add(new KeyValuePair<string, object>("@InvoiceIdPGROther", salechalan.InvoiceIdPGROther));
               parameter.Add(new KeyValuePair<string, object>("@nextPaymentdate", salechalan.nextPaymentdate));
               parameter.Add(new KeyValuePair<string, object>("@ChalanNo", salechalan.chalanNo));
               //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
              
               int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addTempSalesDetails]", parameter,Conn,trans);
               int result = 0;
               for (int k = 0; k < salechalan.SaleItemTable.Rows.Count; k++)
               {
                   List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();
                   parameter1.Add(new KeyValuePair<string, object>("@salesinvoiceId", salechalan.salesInvoiceId));
                   parameter1.Add(new KeyValuePair<string, object>("@FinancialYearID", salechalan.FinancialYearID));
                   parameter1.Add(new KeyValuePair<string, object>("@itemId", salechalan.SaleItemTable.Rows[k]["itemId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@salesItemDetailsId", salechalan.SaleItemTable.Rows[k]["salesItemDetailsId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@stockId", salechalan.SaleItemTable.Rows[k]["stockId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@companyId", salechalan.SaleItemTable.Rows[k]["companyId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@categoryId", salechalan.SaleItemTable.Rows[k]["categoryId"]));
                   parameter1.Add(new KeyValuePair<string, object>("@Quantity", salechalan.SaleItemTable.Rows[k]["Quantity"]));
                   parameter1.Add(new KeyValuePair<string, object>("@IGST", salechalan.SaleItemTable.Rows[k]["IGST"]));
                   parameter1.Add(new KeyValuePair<string, object>("@CGST", salechalan.SaleItemTable.Rows[k]["CGST"]));
                   parameter1.Add(new KeyValuePair<string, object>("@SGST", salechalan.SaleItemTable.Rows[k]["SGST"]));
                   parameter1.Add(new KeyValuePair<string, object>("@batchNo", salechalan.SaleItemTable.Rows[k]["batchNo"]));
                   parameter1.Add(new KeyValuePair<string, object>("@unitBy", salechalan.SaleItemTable.Rows[k]["unitBy"]));
                   parameter1.Add(new KeyValuePair<string, object>("@MFD_Date", Convert.ToDateTime(salechalan.SaleItemTable.Rows[k]["MFD_Date"])));
                   parameter1.Add(new KeyValuePair<string, object>("@expireDate", Convert.ToDateTime(salechalan.SaleItemTable.Rows[k]["expireDate"])));
                   parameter1.Add(new KeyValuePair<string, object>("@discount", salechalan.SaleItemTable.Rows[k]["discount"]));
                   parameter1.Add(new KeyValuePair<string, object>("@perQtysalePrice", salechalan.SaleItemTable.Rows[k]["Rate"]));
                   parameter1.Add(new KeyValuePair<string, object>("@salePrice", salechalan.SaleItemTable.Rows[k]["totalAmount"]));
                   parameter1.Add(new KeyValuePair<string, object>("@addedBy", salechalan.addedBy));
                   parameter1.Add(new KeyValuePair<string, object>("@isDelete", salechalan.isDelete));
                   parameter1.Add(new KeyValuePair<string, object>("@addedOn", salechalan.addedOn));
                   parameter1.Add(new KeyValuePair<string, object>("@isPesticide", salechalan.SaleItemTable.Rows[k]["isPesticide"]));
                   parameter1.Add(new KeyValuePair<string, object>("@isFertilizer", salechalan.SaleItemTable.Rows[k]["isFertilizer"]));
                   parameter1.Add(new KeyValuePair<string, object>("@isSeeds", salechalan.SaleItemTable.Rows[k]["isSeeds"]));
                   parameter1.Add(new KeyValuePair<string, object>("@isPGROthers", salechalan.SaleItemTable.Rows[k]["isPGROthers"]));
                   parameter1.Add(new KeyValuePair<string, object>("@InvoiceNo", salechalan.SaleItemTable.Rows[k]["InvoiceNo"]));
                   parameter1.Add(new KeyValuePair<string, object>("@convertFromChalan", true));
                   result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addTempSaleStockUpdate]", parameter1,Conn,trans);
               }

               trans.Commit();
                    return result;
                }
                catch (Exception ex)
                {
                    if (trans != null) trans.Rollback();
                    throw ex;
                }
                finally { Conn.Close(); }
            }
       }
    }
}
