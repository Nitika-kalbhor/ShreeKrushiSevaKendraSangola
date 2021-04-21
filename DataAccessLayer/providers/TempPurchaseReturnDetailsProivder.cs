using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
  public  class TempPurchaseReturnDetailsProivder
    {
       #region defination & declaration
        private static string _connectionString = SystemSetting.ConnectionString;
        #endregion
        public static DataTable getPurchaseReturnList(DateTime fromDate, DateTime toDate, long financialYearId)
        {
           try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));
                SqlHandler sqlH = new SqlHandler();
                DataTable dtPurchaseReturnList = sqlH.ExecuteAsDataTable("Usp_getTempPurchaseReturnList", parameter);
                return dtPurchaseReturnList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getPurchaseReturnIvoiceDetails(long purchaseReutrnId, long financialYearId)
        {
          try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@purchaseReutrnId", purchaseReutrnId));
                parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));
                SqlHandler sqlH = new SqlHandler();
                DataTable dtPurchaseReturn = sqlH.ExecuteAsDataTable("Usp_getPurchaseReturnDetails", parameter);
                return dtPurchaseReturn;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public static int addPurchaseReturnDetails(PurchaseReutrnDetails Purchase)
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
                    parameter.Add(new KeyValuePair<string, object>("@purchaseReutrnInvoiceId", Purchase.purchaseReutrnInvoiceId));
                    parameter.Add(new KeyValuePair<string, object>("@purchaseReutrnId", Purchase.purchaseReutrnId));
                    parameter.Add(new KeyValuePair<string, object>("@dealerId", Purchase.dealerId));
                    parameter.Add(new KeyValuePair<string, object>("@challanDate", Purchase.challanDate));
                    parameter.Add(new KeyValuePair<string, object>("@remark", Purchase.remark));
                    parameter.Add(new KeyValuePair<string, object>("@netBillAmount", Purchase.netBillAmount));
                    parameter.Add(new KeyValuePair<string, object>("@paidAmount", Purchase.paidAmount));
                    parameter.Add(new KeyValuePair<string, object>("@paymentType", Purchase.paymentType));
                    parameter.Add(new KeyValuePair<string, object>("@bankName", Purchase.bankName));
                    parameter.Add(new KeyValuePair<string, object>("@bankId", Purchase.bankId));
                    parameter.Add(new KeyValuePair<string, object>("@chequeDate", Purchase.chequeDate));
                    parameter.Add(new KeyValuePair<string, object>("@refNo", Purchase.chequeNo_refNo));
                    parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));
                    parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.UtcNow));
                    parameter.Add(new KeyValuePair<string, object>("@state", Purchase.state));
                    parameter.Add(new KeyValuePair<string, object>("@stateCode", Purchase.stateCode));
                    parameter.Add(new KeyValuePair<string, object>("@isDelete", Purchase.isDelete));
                    parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));
                    parameter.Add(new KeyValuePair<string, object>("@purchaseInvoiceNo", Purchase.purchaseInvoiceNo));
                    parameter.Add(new KeyValuePair<string, object>("@purchaseDate", Purchase.purchaseDate));
                    int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addTempPurchaseReturnDetails]", parameter, Conn, trans);
                    int result = 0;
                    for (int k = 0; k < Purchase.PurchaseRetrunItemTable.Rows.Count; k++)
                    {
                        List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();
                        parameter1.Add(new KeyValuePair<string, object>("@purchaseReutrnInvoiceId", Purchase.purchaseReutrnInvoiceId));
                        parameter1.Add(new KeyValuePair<string, object>("@itemId", Purchase.PurchaseRetrunItemTable.Rows[k]["itemId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@purchaseReutrnItemDetailId", Purchase.PurchaseRetrunItemTable.Rows[k]["purchaseReutrnItemDetailId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@stockId", Purchase.PurchaseRetrunItemTable.Rows[k]["stockId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@companyId", Purchase.PurchaseRetrunItemTable.Rows[k]["companyId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@categoryId", Purchase.PurchaseRetrunItemTable.Rows[k]["categoryId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@Quantity", Purchase.PurchaseRetrunItemTable.Rows[k]["Quantity"]));
                        parameter1.Add(new KeyValuePair<string, object>("@FreeQuantity", Purchase.PurchaseRetrunItemTable.Rows[k]["freeQuantity"]));
                        parameter1.Add(new KeyValuePair<string, object>("@IGST", Purchase.PurchaseRetrunItemTable.Rows[k]["IGST"]));
                        parameter1.Add(new KeyValuePair<string, object>("@CGST", Purchase.PurchaseRetrunItemTable.Rows[k]["CGST"]));
                        parameter1.Add(new KeyValuePair<string, object>("@SGST", Purchase.PurchaseRetrunItemTable.Rows[k]["SGST"]));
                        parameter1.Add(new KeyValuePair<string, object>("@batchNo", Purchase.PurchaseRetrunItemTable.Rows[k]["batchNo"]));
                        parameter1.Add(new KeyValuePair<string, object>("@unitBy", Purchase.PurchaseRetrunItemTable.Rows[k]["unitBy"]));
                        parameter1.Add(new KeyValuePair<string, object>("@discount", Purchase.PurchaseRetrunItemTable.Rows[k]["discount"]));
                        parameter1.Add(new KeyValuePair<string, object>("@purchaseRate", Purchase.PurchaseRetrunItemTable.Rows[k]["purchaseRate"]));
                        parameter1.Add(new KeyValuePair<string, object>("@salesCashRate", Purchase.PurchaseRetrunItemTable.Rows[k]["salesCashRate"]));
                        parameter1.Add(new KeyValuePair<string, object>("@salesCreditRate", 0));
                        parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCashRate", 0));
                        parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate", 0));
                        parameter1.Add(new KeyValuePair<string, object>("@addedBy", 1));
                        parameter1.Add(new KeyValuePair<string, object>("@addedOn", Purchase.challanDate));
                        parameter1.Add(new KeyValuePair<string, object>("@isDelete", Purchase.isDelete));
                        parameter1.Add(new KeyValuePair<string, object>("@purchaseReutrnId", Purchase.purchaseReutrnId));
                        parameter1.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));
                        result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addTempPurchaseReturnStockUpdate]", parameter1, Conn, trans);
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
