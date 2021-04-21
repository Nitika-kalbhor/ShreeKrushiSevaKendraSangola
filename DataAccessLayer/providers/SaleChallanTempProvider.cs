using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
    public class SaleChallanTempProvider
    {
        #region defination & declaration
        private static string _connectionString = SystemSetting.ConnectionString;
        #endregion
        public static System.Data.DataTable getChallenList(DateTime fromDate, DateTime toDate, long financialYearId)
        {
            try
            {
                DataTable dtChallanList = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearId));
                SqlHandler sqlH = new SqlHandler();
                dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempSaleChallanList]", parameter);
                return dtChallanList;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static long getMaxIdSaleChallanInvoiceId(long financialYearId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearId));
                SqlHandler sqlH = new SqlHandler();
                long salesChallanInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getTempMaxIdSaleChallanInvoiceId]", parameter);
                return salesChallanInvoiceId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int deleteRow(long financialYearId, long saleChallenId, long salesChallanItemDetailsId, long StockId, double Quantity)
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
                    parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", saleChallenId));
                    parameter.Add(new KeyValuePair<string, object>("@salesChallanItemDetailsId", salesChallanItemDetailsId));
                    parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));
                    parameter.Add(new KeyValuePair<string, object>("@categoryID", StockId));
                    parameter.Add(new KeyValuePair<string, object>("@companyId", Quantity));
                    int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_TempdeleteSalechallanItem]", parameter, Conn, trans);
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

        public static int addSalesChallanDetails(SalesDetails saleChallan)
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
                    parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", saleChallan.salesInvoiceId));
                    parameter.Add(new KeyValuePair<string, object>("@financialYearID", saleChallan.FinancialYearID));
                    parameter.Add(new KeyValuePair<string, object>("@salesDate", saleChallan.salesDate));
                    parameter.Add(new KeyValuePair<string, object>("@customerId", saleChallan.customerId));
                    parameter.Add(new KeyValuePair<string, object>("@salesType", saleChallan.salesType));
                    parameter.Add(new KeyValuePair<string, object>("@othercharges", saleChallan.paidAmount));
                    parameter.Add(new KeyValuePair<string, object>("@totalbillAmount", saleChallan.totalbillAmount));
                    parameter.Add(new KeyValuePair<string, object>("@isState", saleChallan.isState));
                    parameter.Add(new KeyValuePair<string, object>("@isDelete", saleChallan.isDelete));
                    parameter.Add(new KeyValuePair<string, object>("@addedBy", saleChallan.addedBy));
                    parameter.Add(new KeyValuePair<string, object>("@addedOn", saleChallan.addedOn));
                    parameter.Add(new KeyValuePair<string, object>("@isCustomerRetailer", saleChallan.isRetailer));
                    parameter.Add(new KeyValuePair<string, object>("@state", saleChallan.state));
                    parameter.Add(new KeyValuePair<string, object>("@stateCode", saleChallan.stateCode));
                    //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));

                    int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addTempSalesChallanDetails]", parameter,Conn,trans);

                    int result = 0;
                    for (int k = 0; k < saleChallan.SaleItemTable.Rows.Count; k++)
                    {
                        List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();
                        parameter1.Add(new KeyValuePair<string, object>("@salesinvoiceId", saleChallan.salesInvoiceId));
                        parameter1.Add(new KeyValuePair<string, object>("@financialYearID", saleChallan.FinancialYearID));
                        parameter1.Add(new KeyValuePair<string, object>("@isDelete", saleChallan.isDelete));
                        parameter1.Add(new KeyValuePair<string, object>("@salesChallanItemDetailsId", saleChallan.SaleItemTable.Rows[k]["salesChallanItemDetailsId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@itemId", saleChallan.SaleItemTable.Rows[k]["itemId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@stockId", saleChallan.SaleItemTable.Rows[k]["stockId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@companyId", saleChallan.SaleItemTable.Rows[k]["companyId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@categoryId", saleChallan.SaleItemTable.Rows[k]["categoryId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@Quantity", saleChallan.SaleItemTable.Rows[k]["Quantity"]));
                        parameter1.Add(new KeyValuePair<string, object>("@IGST", saleChallan.SaleItemTable.Rows[k]["IGST"]));
                        parameter1.Add(new KeyValuePair<string, object>("@CGST", saleChallan.SaleItemTable.Rows[k]["CGST"]));
                        parameter1.Add(new KeyValuePair<string, object>("@SGST", saleChallan.SaleItemTable.Rows[k]["SGST"]));
                        parameter1.Add(new KeyValuePair<string, object>("@batchNo", saleChallan.SaleItemTable.Rows[k]["batchNo"]));
                        parameter1.Add(new KeyValuePair<string, object>("@unitBy", saleChallan.SaleItemTable.Rows[k]["unitBy"]));
                        parameter1.Add(new KeyValuePair<string, object>("@discount", saleChallan.SaleItemTable.Rows[k]["discount"]));
                        parameter1.Add(new KeyValuePair<string, object>("@perQtysalePrice", saleChallan.SaleItemTable.Rows[k]["Rate"]));
                        parameter1.Add(new KeyValuePair<string, object>("@salePrice", saleChallan.SaleItemTable.Rows[k]["totalAmount"]));
                        parameter1.Add(new KeyValuePair<string, object>("@addedBy", saleChallan.addedBy));
                        parameter1.Add(new KeyValuePair<string, object>("@addedOn", saleChallan.addedOn));
                        result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addTempSaleChallanStockUpdate]", parameter1,Conn,trans);
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

        public static System.Data.DataTable getSaleChallenDetails(long salesChallanId, long financialYearId)
        {
            try
            {
                DataTable dtSaleChallen = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@salesChallanId", salesChallanId));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearId));
                SqlHandler sqlH = new SqlHandler();
                dtSaleChallen = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempSalesChallan]", parameter);
                return dtSaleChallen;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getChallenList(long customerId, DateTime fromDate, DateTime toDate, long financialYearID)
        {
            try
            {
                DataTable dtChallanList = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@customerId", customerId));
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                SqlHandler sqlH = new SqlHandler();
                dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempSaleChallanListByCustomer]", parameter);
                return dtChallanList;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
    }
}
