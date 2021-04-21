using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace DataAccessLayer.providers
{
    public class StockInProvider
    {
        #region defination & declaration
        private static string _connectionString = SystemSetting.ConnectionString;
        #endregion
        public static long getMaxStockInId()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                long purchaseReutrnInvoiceId = sqlH.ExecuteAsScalar("[dbo].[Usp_getMaxStockInId]");
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static long getMaxStockInId(long FinancialYearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
                SqlHandler sqlH = new SqlHandler();
                long purchaseReutrnInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getMaxStockInInvoiceId]", parameter);
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static int addStockInDetails(PurchaseDetails Purchase)
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
                parameter.Add(new KeyValuePair<string, object>("@stockInID", Purchase.stockInID));
                parameter.Add(new KeyValuePair<string, object>("@stockInInvoiceID", Purchase.stockInInvoiceID));
                parameter.Add(new KeyValuePair<string, object>("@purchaseChalanDate", Purchase.challanDate));
                parameter.Add(new KeyValuePair<string, object>("@remark", Purchase.remark));
                parameter.Add(new KeyValuePair<string, object>("@netBillAmount", Purchase.netBillAmount));
                parameter.Add(new KeyValuePair<string, object>("@OtherCharges", Purchase.paidAmount));
                parameter.Add(new KeyValuePair<string, object>("@isDelete", Purchase.isDelete));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));

              
                int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addStockInDetails]", parameter,Conn,trans);


                int result = 0;
                for (int k = 0; k < Purchase.PurchaseItemTable.Rows.Count; k++)
                {
                    List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();

                    parameter1.Add(new KeyValuePair<string, object>("@isDelete", Purchase.isDelete));
                    parameter1.Add(new KeyValuePair<string, object>("@stockInItemID", Purchase.PurchaseItemTable.Rows[k]["stockInItemID"]));
                    parameter1.Add(new KeyValuePair<string, object>("@itemId", Purchase.PurchaseItemTable.Rows[k]["itemId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@stockId", Purchase.PurchaseItemTable.Rows[k]["stockId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@companyId", Purchase.PurchaseItemTable.Rows[k]["companyId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@categoryId", Purchase.PurchaseItemTable.Rows[k]["categoryId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@stockInID", Purchase.stockInID));
                    parameter1.Add(new KeyValuePair<string, object>("@Quantity", Purchase.PurchaseItemTable.Rows[k]["Quantity"]));
                    parameter1.Add(new KeyValuePair<string, object>("@FreeQuantity", 0));
                    parameter1.Add(new KeyValuePair<string, object>("@IGST", Purchase.PurchaseItemTable.Rows[k]["IGST"]));
                    parameter1.Add(new KeyValuePair<string, object>("@CGST", Purchase.PurchaseItemTable.Rows[k]["CGST"]));
                    parameter1.Add(new KeyValuePair<string, object>("@SGST", Purchase.PurchaseItemTable.Rows[k]["SGST"]));
                    parameter1.Add(new KeyValuePair<string, object>("@batchNo", Purchase.PurchaseItemTable.Rows[k]["batchNo"]));
                    parameter1.Add(new KeyValuePair<string, object>("@unitBy", Purchase.PurchaseItemTable.Rows[k]["unitBy"]));
                    parameter1.Add(new KeyValuePair<string, object>("@discount", Purchase.PurchaseItemTable.Rows[k]["discount"]));
                    parameter1.Add(new KeyValuePair<string, object>("@purchaseRate", Purchase.PurchaseItemTable.Rows[k]["purchaseRate"]));
                    parameter1.Add(new KeyValuePair<string, object>("@MRP", 0));
                    parameter1.Add(new KeyValuePair<string, object>("@salesCashRate", 0));
                    parameter1.Add(new KeyValuePair<string, object>("@salesCreditRate", 0));
                    parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCashRate", 0));
                    parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate", 0));
                    parameter1.Add(new KeyValuePair<string, object>("@addedBy", 1));
                    parameter1.Add(new KeyValuePair<string, object>("@addedOn", Purchase.challanDate));
                    parameter1.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));
                    parameter1.Add(new KeyValuePair<string, object>("@purchaseChalanDate", Purchase.challanDate));
                    result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addStockInDetailsStockUpdate]", parameter1,Conn,trans);
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
        public static DataTable getStockInList(DateTime fromDate, DateTime toDate, long FinancialYearID)
        {
            try
            {
                DataTable dtChallanList = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
                SqlHandler sqlH = new SqlHandler();
                dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStockInList]", parameter);
                return dtChallanList;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getStockInDetails(long purchaseChalanId, long FinancialYearID)
        {
            
                DataTable dtSaleChallen = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@purchaseChalanId", purchaseChalanId));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
                SqlHandler sqlH = new SqlHandler();
                dtSaleChallen = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStockInDetails]", parameter);
                return dtSaleChallen;
               
        }
        public static int deleteStockInRow(long purchaseChalanId, long stockInItemID, long itemID, long categoryID, long companyId, string batchNo, double quantity)
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
            parameter.Add(new KeyValuePair<string, object>("@purchaseChalanId", purchaseChalanId));
            parameter.Add(new KeyValuePair<string, object>("@stockInItemID", stockInItemID));
            parameter.Add(new KeyValuePair<string, object>("@itemID", itemID));
            parameter.Add(new KeyValuePair<string, object>("@categoryID", categoryID));
            parameter.Add(new KeyValuePair<string, object>("@companyId", companyId));
            parameter.Add(new KeyValuePair<string, object>("@batchNo", batchNo));
            parameter.Add(new KeyValuePair<string, object>("@quantity", quantity));
            //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
           
            int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_deleteStockInRow]", parameter,Conn,trans);
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
        public static int deleteStockInItemRow(long stockInId, long itemID, long categoryID, long companyId, string batchNo, double quantity)
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
            parameter.Add(new KeyValuePair<string, object>("@stockInId", stockInId));
            parameter.Add(new KeyValuePair<string, object>("@itemID", itemID));
            parameter.Add(new KeyValuePair<string, object>("@categoryID", categoryID));
            parameter.Add(new KeyValuePair<string, object>("@companyId", companyId));
            parameter.Add(new KeyValuePair<string, object>("@batchNo", batchNo));
            parameter.Add(new KeyValuePair<string, object>("@quantity", quantity));
            int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_deleteStockInItem]", parameter,Conn,trans);
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
    }
}
