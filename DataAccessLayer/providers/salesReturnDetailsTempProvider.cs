using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
    public class salesReturnDetailsTempProvider
    {
        #region defination & declaration
        private static string _connectionString = SystemSetting.ConnectionString;
        #endregion
        public static long getMaxIdSaleRetrunInvoiceId(long financialYearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                SqlHandler sqlH = new SqlHandler();
                long salesRetrunInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getMaxIdSaleReturnInvoiceIdTemp]", parameter);
                return salesRetrunInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        //public static long getcustomerMaxId()
        //{
        //    try
        //    {

        //        SqlHandler sqlH = new SqlHandler();
        //        long customerId = sqlH.ExecuteAsScalar("[dbo].[Usp_getcustomerMaxId]");
        //        return customerId;
        //    }
        //    catch (Exception ae)
        //    {
        //        throw ae;
        //    }

        //}
        public static DataTable getStockInSaleItemDetails(string value, string type)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@txtSearch", value));
                parameter.Add(new KeyValuePair<string, object>("@type", type));
                SqlHandler sqlH = new SqlHandler();
                DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStockInSaleItemDetailsTemp]", parameter);
                return listi;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }


        public static DataTable getStockInSaleReturnItemDetails(string value, string type, bool isWholeSale)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@txtSearch", value));
                parameter.Add(new KeyValuePair<string, object>("@type", type));
                parameter.Add(new KeyValuePair<string, object>("@isWholeSale", isWholeSale));
                SqlHandler sqlH = new SqlHandler();
                DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStockInSaleReturnItemDetailsTemp]", parameter);
                return listi;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        //public static DataTable getEmptySaleItem()
        //{
        //    try
        //    {

        //        SqlHandler sqlH = new SqlHandler();
        //        DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getEmptySaleItem]");
        //        return i;
        //    }
        //    catch (Exception ae)
        //    {
        //        throw ae;
        //    }

        //}

        public static int addSalesRetrunDetails(SalesReturnDetails sale)
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
                parameter.Add(new KeyValuePair<string, object>("@salesReturnId", sale.salesReturnId));
                parameter.Add(new KeyValuePair<string, object>("@salesReturnInvoiceId", sale.salesReturnInvoiceId));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", sale.financialYearID));
                parameter.Add(new KeyValuePair<string, object>("@salesReturnDate", sale.salesReturnDate));
                parameter.Add(new KeyValuePair<string, object>("@customerId", sale.customerId));
                parameter.Add(new KeyValuePair<string, object>("@salesType", sale.salesType));
                parameter.Add(new KeyValuePair<string, object>("@totalbillAmount", sale.totalbillAmount));
                parameter.Add(new KeyValuePair<string, object>("@paidAmount", sale.paidAmount));
                parameter.Add(new KeyValuePair<string, object>("@paymentType", sale.paymentType));
                parameter.Add(new KeyValuePair<string, object>("@bankName", sale.bankName));
                parameter.Add(new KeyValuePair<string, object>("@bankId", sale.bankId));
                parameter.Add(new KeyValuePair<string, object>("@chequeDate", sale.chequeDate));
                parameter.Add(new KeyValuePair<string, object>("@refNo", sale.chequeNo_refNo));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", sale.addedBy));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", sale.addedOn));
                parameter.Add(new KeyValuePair<string, object>("@state", sale.state));
                parameter.Add(new KeyValuePair<string, object>("@stateCode", sale.stateCode));
                parameter.Add(new KeyValuePair<string, object>("@isCustomerRetailer", sale.isCustomerRetailer));
                parameter.Add(new KeyValuePair<string, object>("@isDelete", sale.isDelete));
                parameter.Add(new KeyValuePair<string, object>("@saleInvoiceNo", sale.saleInvoiceNo));
                parameter.Add(new KeyValuePair<string, object>("@saleDate", sale.saleDate));

                //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
               
                int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addSalesReturnDetailsTemp]", parameter,Conn,trans);
                int result = 0;
                for (int k = 0; k < sale.SaleRetrunItemTable.Rows.Count; k++)
                {
                    List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();
                    parameter1.Add(new KeyValuePair<string, object>("@salesReturnInvoiceId", sale.salesReturnInvoiceId));//1
                    parameter1.Add(new KeyValuePair<string, object>("@financialYearID", sale.financialYearID));//2
                    parameter1.Add(new KeyValuePair<string, object>("@itemId", sale.SaleRetrunItemTable.Rows[k]["itemId"]));//3
                    parameter1.Add(new KeyValuePair<string, object>("@salesReturnItemDetailsId", sale.SaleRetrunItemTable.Rows[k]["salesReturnItemDetailsId"]));//4
                    parameter1.Add(new KeyValuePair<string, object>("@stockId", sale.SaleRetrunItemTable.Rows[k]["stockId"]));//5
                    parameter1.Add(new KeyValuePair<string, object>("@companyId", sale.SaleRetrunItemTable.Rows[k]["companyId"]));//6
                    parameter1.Add(new KeyValuePair<string, object>("@categoryId", sale.SaleRetrunItemTable.Rows[k]["categoryId"]));//7
                    parameter1.Add(new KeyValuePair<string, object>("@Quantity", sale.SaleRetrunItemTable.Rows[k]["Quantity"]));//8
                    parameter1.Add(new KeyValuePair<string, object>("@IGST", sale.SaleRetrunItemTable.Rows[k]["IGST"]));//9
                    parameter1.Add(new KeyValuePair<string, object>("@CGST", sale.SaleRetrunItemTable.Rows[k]["CGST"]));//10
                    parameter1.Add(new KeyValuePair<string, object>("@SGST", sale.SaleRetrunItemTable.Rows[k]["SGST"]));//11
                    parameter1.Add(new KeyValuePair<string, object>("@batchNo", sale.SaleRetrunItemTable.Rows[k]["batchNo"]));//12
                    parameter1.Add(new KeyValuePair<string, object>("@unitBy", sale.SaleRetrunItemTable.Rows[k]["unitBy"]));//13
                    parameter1.Add(new KeyValuePair<string, object>("@discount", sale.SaleRetrunItemTable.Rows[k]["discount"]));//14
                    parameter1.Add(new KeyValuePair<string, object>("@perQtysalePrice", sale.SaleRetrunItemTable.Rows[k]["Rate"]));//5
                    parameter1.Add(new KeyValuePair<string, object>("@salePrice", sale.SaleRetrunItemTable.Rows[k]["totalAmount"]));//16
                    parameter1.Add(new KeyValuePair<string, object>("@addedBy", sale.addedBy));//17
                    parameter1.Add(new KeyValuePair<string, object>("@addedOn", sale.addedOn));//18
                    parameter1.Add(new KeyValuePair<string, object>("@isDelete", sale.isDelete));//19
                    
                    result = sqlH.ExecuteNonQueryTM("Usp_addSaleReturnStockUpdateTemp", parameter1,Conn,trans);
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
        public static DataTable getSaleReturnIvoiceList(DateTime fromDate, DateTime toDate, long financialYearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                SqlHandler sqlH = new SqlHandler();
                DataTable dtSaleReturnDetails = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleReturnDetailsListTemp]", parameter);
                return dtSaleReturnDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }


        public static DataTable getsaleReturnDetails(long saleReturnId, long financialYearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@saleReturnId", saleReturnId));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                SqlHandler sqlH = new SqlHandler();
                DataTable dtsalereturnDetails = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleReturnDetailsTemp]", parameter);
                return dtsalereturnDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        public static DataTable SaleReturnDayBook(DateTime fromDate, DateTime toDate, long financialYearId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));
                SqlHandler sqlH = new SqlHandler();
                DataTable dtsalereturnDetails = sqlH.ExecuteAsDataTable("[dbo].[Usp_SaleReturnBookTemp]", parameter);
                return dtsalereturnDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static long getMaxIdPurchaseInvoiceId()
        {
            throw new NotImplementedException();
        }
    }
}
