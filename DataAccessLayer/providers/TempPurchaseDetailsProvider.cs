using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
    public class TempPurchaseDetailsProvider
    {
        #region defination & declaration
        private static string _connectionString = SystemSetting.ConnectionString;
        #endregion
        public static bool getInvoice(string invoiceNo, long dealerId, long financialYearId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@invoiceNO", invoiceNo));
                parameter.Add(new KeyValuePair<string, object>("@dealerID", dealerId));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearId));
                SqlHandler sqlH = new SqlHandler();
                Boolean isExists = false;
                isExists = sqlH.ExecuteAsScalarBool("[dbo].[Usp_getTempExistsingPurchaseInvoice]", parameter);
                return isExists;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getSaleChallenDetails(long purchaseChalanId, long financialYearId)
        {
            try
            {
                try
                {
                    DataTable dtSaleChallen = new DataTable();
                    List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                    parameter.Add(new KeyValuePair<string, object>("@purchaseChalanId", purchaseChalanId));
                    parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", financialYearId));
                    SqlHandler sqlH = new SqlHandler();
                    dtSaleChallen = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempPurchaseChallan]", parameter);
                    return dtSaleChallen;
                }
                catch (Exception ae)
                {
                    throw ae;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int deleteRow(long purchaseChalanId, long purchaseChalanItemDetailId, double quantity, long StockId, long financialYearId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@purchaseChalanId", purchaseChalanId));
                parameter.Add(new KeyValuePair<string, object>("@purchaseChalanItemDetailId", purchaseChalanItemDetailId));
                parameter.Add(new KeyValuePair<string, object>("@quantity", quantity));
                parameter.Add(new KeyValuePair<string, object>("@StockId", StockId));
                parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));
                //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_deleteTempPurchasechallanItem]", parameter);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getChallenList(DateTime fromDate, DateTime toDate, long financialYearId)
        {
            try
            {
                try
                {
                    DataTable dtChallanList = new DataTable();
                    List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                    parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                    parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                    parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));
                    SqlHandler sqlH = new SqlHandler();
                    dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempPurchaseChallanList]", parameter);
                    return dtChallanList;
                }
                catch (Exception ae)
                {
                    throw ae;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int addPurchaseChalanDetails(PurchaseDetails Purchase)
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
                    parameter.Add(new KeyValuePair<string, object>("@purchaseChalanId", Purchase.purchaseChalanId));
                    parameter.Add(new KeyValuePair<string, object>("@purchaseChalanBillId", Purchase.purchaseInvoiceId));
                    parameter.Add(new KeyValuePair<string, object>("@purchaseChalanDate", Purchase.challanDate));
                    parameter.Add(new KeyValuePair<string, object>("@dealerId", Purchase.dealerId));
                    parameter.Add(new KeyValuePair<string, object>("@remark", Purchase.remark));
                    parameter.Add(new KeyValuePair<string, object>("@netBillAmount", Purchase.netBillAmount));
                    parameter.Add(new KeyValuePair<string, object>("@OtherCharges", Purchase.paidAmount));
                    parameter.Add(new KeyValuePair<string, object>("@isDelete", Purchase.isDelete));
                    parameter.Add(new KeyValuePair<string, object>("@addedBy", Purchase.addedBy));
                    parameter.Add(new KeyValuePair<string, object>("@addedOn", Purchase.challanDate));
                    parameter.Add(new KeyValuePair<string, object>("@state", Purchase.state));
                    parameter.Add(new KeyValuePair<string, object>("@stateCode", Purchase.stateCode));
                    parameter.Add(new KeyValuePair<string, object>("@isCustomerRetailer", Purchase.isCustomerRetailer));
                    parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));

                    // parameter.Add(new KeyValuePair<string, object>("@PurchaseItemTable", Purchase.PurchaseItemTable));

                    int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addTempPurchaseChalanDetails]", parameter, Conn, trans);


                    int result = 0;
                    for (int k = 0; k < Purchase.PurchaseItemTable.Rows.Count; k++)
                    {
                        List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();

                        parameter1.Add(new KeyValuePair<string, object>("@isDelete", Purchase.isDelete));
                        parameter1.Add(new KeyValuePair<string, object>("@purchaseChalanItemDetailId", Purchase.PurchaseItemTable.Rows[k]["purchaseChalanItemDetailId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@itemId", Purchase.PurchaseItemTable.Rows[k]["itemId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@stockId", Purchase.PurchaseItemTable.Rows[k]["stockId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@companyId", Purchase.PurchaseItemTable.Rows[k]["companyId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@categoryId", Purchase.PurchaseItemTable.Rows[k]["categoryId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@purchaseChalanId", Purchase.purchaseChalanId));
                        parameter1.Add(new KeyValuePair<string, object>("@Quantity", Purchase.PurchaseItemTable.Rows[k]["Quantity"]));
                        parameter1.Add(new KeyValuePair<string, object>("@FreeQuantity", Purchase.PurchaseItemTable.Rows[k]["freeQuantity"]));
                        parameter1.Add(new KeyValuePair<string, object>("@IGST", Purchase.PurchaseItemTable.Rows[k]["IGST"]));
                        parameter1.Add(new KeyValuePair<string, object>("@CGST", Purchase.PurchaseItemTable.Rows[k]["CGST"]));
                        parameter1.Add(new KeyValuePair<string, object>("@SGST", Purchase.PurchaseItemTable.Rows[k]["SGST"]));
                        parameter1.Add(new KeyValuePair<string, object>("@batchNo", Purchase.PurchaseItemTable.Rows[k]["batchNo"]));
                        parameter1.Add(new KeyValuePair<string, object>("@mfgDate", Convert.ToDateTime(Purchase.PurchaseItemTable.Rows[k]["mfgDate"])));
                        parameter1.Add(new KeyValuePair<string, object>("@expireDate", Convert.ToDateTime(Purchase.PurchaseItemTable.Rows[k]["expireDate"])));
                        parameter1.Add(new KeyValuePair<string, object>("@unitBy", Purchase.PurchaseItemTable.Rows[k]["unitBy"]));
                        parameter1.Add(new KeyValuePair<string, object>("@discount", Purchase.PurchaseItemTable.Rows[k]["discount"]));
                        parameter1.Add(new KeyValuePair<string, object>("@purchaseRate", Purchase.PurchaseItemTable.Rows[k]["purchaseRate"]));
                        parameter1.Add(new KeyValuePair<string, object>("@MRP", Purchase.PurchaseItemTable.Rows[k]["MRP"]));
                        parameter1.Add(new KeyValuePair<string, object>("@salesCashRate", Purchase.PurchaseItemTable.Rows[k]["salesCashRate"]));
                        parameter1.Add(new KeyValuePair<string, object>("@salesCreditRate", Purchase.PurchaseItemTable.Rows[k]["salesCashRate"]));
                        parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCashRate", Purchase.PurchaseItemTable.Rows[k]["salesCashRate"]));
                        parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate", Purchase.PurchaseItemTable.Rows[k]["salesCashRate"]));
                        parameter1.Add(new KeyValuePair<string, object>("@addedBy", 1));
                        parameter1.Add(new KeyValuePair<string, object>("@addedOn", Purchase.challanDate));
                        parameter1.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));
                        parameter1.Add(new KeyValuePair<string, object>("@godown", Purchase.PurchaseItemTable.Rows[k]["godown"]));
                        result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addTempPurchaseChalanStockUpdate]", parameter1, Conn, trans);
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

        public static long getMaxIdPurchaseChalanId()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                long purchaseReutrnInvoiceId = sqlH.ExecuteAsScalar("[dbo].[Usp_getTempMaxIdPurchaseChalanId]");
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        public static bool getpurchaseChalanNo(string invoiceNo, long dealerId, long financialYearId)
        {
            try
            {
                try
                {
                    List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                    parameter.Add(new KeyValuePair<string, object>("@invoiceNO", invoiceNo));
                    parameter.Add(new KeyValuePair<string, object>("@dealerID", dealerId));
                    parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearId));
                    SqlHandler sqlH = new SqlHandler();
                    Boolean isExists = false;
                    isExists = sqlH.ExecuteAsScalarBool("[dbo].[Usp_getExistsingPurchaseChalanNo]", parameter);
                    return isExists;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getStockInItemDetails(string value)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@txtSearch", value));
                SqlHandler sqlH = new SqlHandler();
                DataTable dtStock = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempStockInItemDetails]", parameter);
                return dtStock;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getChallenList(long dealerId, DateTime fromDate, DateTime toDate, long financialYearId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@dealerId", dealerId));
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));
                SqlHandler sqlH = new SqlHandler();
               DataTable dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempPurchaseChallanListByDealer]", parameter);
                return dtChallanList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static long getMaxIdPurchaseInvoiceId()
        {
            try
            {
               SqlHandler sqlH=new SqlHandler();
               long purchaseInvoiceId = sqlH.ExecuteAsScalar("[dbo].[Usp_getTempMaxIdPurchaseInvoiceId]");
               return purchaseInvoiceId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static double getPaymentDueAmountDealer(long dealerId,string Opreation, long financialYearId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@AccountId", dealerId));
                parameter.Add(new KeyValuePair<string, object>("@Opreation", Opreation));
                parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));
                SqlHandler sqlH = new SqlHandler();
                double i = sqlH.ExecuteAsScalar("[dbo].[Usp_getPaymentDue]", parameter);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int deletePurchseInvoiceRow(long purchaseId, long purchaseItemDetailId, double quantity, long stockId, long financialYearId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@purchaseId", purchaseId));
                parameter.Add(new KeyValuePair<string, object>("@purchaseItemDetailId", purchaseItemDetailId));
                parameter.Add(new KeyValuePair<string, object>("@quantity", quantity));
                parameter.Add(new KeyValuePair<string, object>("@stockId", stockId));
                parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));
                //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_deletePurchaseInvoiceItem]", parameter);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getPurchaseList(DateTime fromDate, DateTime toDate, long financialYearId)
        {
            try
            {
                DataTable dtChallanList = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", financialYearId));
                SqlHandler sqlH = new SqlHandler();
                dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempPurchaseIvoiceList]", parameter);
                return dtChallanList;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        public static DataTable getPurchaseIvoiceDetails(long purchaseId, long financialYearId)
        {
            try
            {
                DataTable dtPurchaseDetails = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@purchaseId", purchaseId));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", financialYearId));
                SqlHandler sqlH = new SqlHandler();
                dtPurchaseDetails = sqlH.ExecuteAsDataTable("[dbo].[Usp_GetTempPurchaseInvoiceDetails]", parameter);
                return dtPurchaseDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        public static int addPurchaseDetails(PurchaseDetails Purchase)
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
                    parameter.Add(new KeyValuePair<string, object>("@purchaseId", Purchase.purchaseId));
                    parameter.Add(new KeyValuePair<string, object>("@purchaseInvoiceId", Purchase.purchaseInvoiceId));
                    parameter.Add(new KeyValuePair<string, object>("@challanDate", Purchase.challanDate));
                    parameter.Add(new KeyValuePair<string, object>("@dealerId", Purchase.dealerId));
                    parameter.Add(new KeyValuePair<string, object>("@remark", Purchase.remark));
                    parameter.Add(new KeyValuePair<string, object>("@netBillAmount", Purchase.netBillAmount));
                    parameter.Add(new KeyValuePair<string, object>("@paidAmount", Purchase.paidAmount));
                    parameter.Add(new KeyValuePair<string, object>("@paymentType", Purchase.paymentType));
                    parameter.Add(new KeyValuePair<string, object>("@isDelete", Purchase.isDelete));
                    parameter.Add(new KeyValuePair<string, object>("@bankName", Purchase.bankName));
                    parameter.Add(new KeyValuePair<string, object>("@bankId", Purchase.orjId));
                    parameter.Add(new KeyValuePair<string, object>("@chequeDate", Purchase.chequeDate));
                    parameter.Add(new KeyValuePair<string, object>("@refNo", Purchase.chequeNo_refNo));
                    parameter.Add(new KeyValuePair<string, object>("@state", Purchase.state));
                    parameter.Add(new KeyValuePair<string, object>("@stateCode", Purchase.stateCode));
                    parameter.Add(new KeyValuePair<string, object>("@addedBy", Purchase.addedBy));
                    parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.UtcNow));
                    parameter.Add(new KeyValuePair<string, object>("@isState", Purchase.isState));
                    parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));
                    parameter.Add(new KeyValuePair<string, object>("@DilivaryCharges", Purchase.DilivaryCharges));
                    parameter.Add(new KeyValuePair<string, object>("@discountAmount", Purchase.discountAmount));
                    parameter.Add(new KeyValuePair<string, object>("@netBillAmtWithOutDiscount", Purchase.netBillAmtWithOutDiscount));
                    parameter.Add(new KeyValuePair<string, object>("@roundOff", Purchase.roundOff));
                    // parameter.Add(new KeyValuePair<string, object>("@PurchaseItemTable", Purchase.PurchaseItemTable));
                    
                    int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addTempPurchaseDetails]", parameter,Conn,trans);
                    int result = 0;

                    for (int k = 0; k < Purchase.PurchaseItemTable.Rows.Count; k++)
                    {
                        List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();
                        parameter1.Add(new KeyValuePair<string, object>("@purchaseId", Purchase.purchaseId));
                        parameter1.Add(new KeyValuePair<string, object>("@purchaseInvoiceId", Purchase.purchaseInvoiceId));
                        parameter1.Add(new KeyValuePair<string, object>("@isDelete", Purchase.isDelete));
                        parameter1.Add(new KeyValuePair<string, object>("@itemId", Purchase.PurchaseItemTable.Rows[k]["itemId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@purchaseItemDetailId", Purchase.PurchaseItemTable.Rows[k]["purchaseItemDetailId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@stockId", Purchase.PurchaseItemTable.Rows[k]["stockId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@companyId", Purchase.PurchaseItemTable.Rows[k]["companyId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@categoryId", Purchase.PurchaseItemTable.Rows[k]["categoryId"]));
                        parameter1.Add(new KeyValuePair<string, object>("@Quantity", Purchase.PurchaseItemTable.Rows[k]["Quantity"]));
                        parameter1.Add(new KeyValuePair<string, object>("@FreeQuantity", Purchase.PurchaseItemTable.Rows[k]["freeQuantity"]));
                        parameter1.Add(new KeyValuePair<string, object>("@IGST", Purchase.PurchaseItemTable.Rows[k]["IGST"]));
                        parameter1.Add(new KeyValuePair<string, object>("@CGST", Purchase.PurchaseItemTable.Rows[k]["CGST"]));
                        parameter1.Add(new KeyValuePair<string, object>("@SGST", Purchase.PurchaseItemTable.Rows[k]["SGST"]));
                        parameter1.Add(new KeyValuePair<string, object>("@batchNo", Purchase.PurchaseItemTable.Rows[k]["batchNo"]));
                        parameter1.Add(new KeyValuePair<string, object>("@unitBy", Purchase.PurchaseItemTable.Rows[k]["unitBy"]));
                        parameter1.Add(new KeyValuePair<string, object>("@mfgDate", Convert.ToDateTime(Purchase.PurchaseItemTable.Rows[k]["mfgDate"])));
                        parameter1.Add(new KeyValuePair<string, object>("@expireDate", Convert.ToDateTime(Purchase.PurchaseItemTable.Rows[k]["expireDate"])));
                        parameter1.Add(new KeyValuePair<string, object>("@discount", Purchase.PurchaseItemTable.Rows[k]["discount"]));
                        parameter1.Add(new KeyValuePair<string, object>("@discountPer", Purchase.PurchaseItemTable.Rows[k]["discountPer"]));
                        parameter1.Add(new KeyValuePair<string, object>("@purchaseRate", Purchase.PurchaseItemTable.Rows[k]["purchaseRate"]));
                        parameter1.Add(new KeyValuePair<string, object>("@salesCashRate", Purchase.PurchaseItemTable.Rows[k]["salesCashRate"]));
                        parameter1.Add(new KeyValuePair<string, object>("@productCode", Purchase.PurchaseItemTable.Rows[k]["productCode"]));
                        parameter1.Add(new KeyValuePair<string, object>("@HNSCode", Purchase.PurchaseItemTable.Rows[k]["HSNCode"]));
                        parameter1.Add(new KeyValuePair<string, object>("@rackNo", Purchase.PurchaseItemTable.Rows[k]["rackNo"]));
                        parameter1.Add(new KeyValuePair<string, object>("@MRP", Purchase.PurchaseItemTable.Rows[k]["MRP"]));
                        parameter1.Add(new KeyValuePair<string, object>("@godown", Purchase.PurchaseItemTable.Rows[k]["godown"]));
                        parameter1.Add(new KeyValuePair<string, object>("@salesCreditRate", Purchase.PurchaseItemTable.Rows[k]["salesCashRate"]));
                        parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCashRate", Purchase.PurchaseItemTable.Rows[k]["salesCashRate"]));
                        parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate", Purchase.PurchaseItemTable.Rows[k]["salesCashRate"]));
                        parameter1.Add(new KeyValuePair<string, object>("@addedBy", 1));
                        parameter1.Add(new KeyValuePair<string, object>("@addedOn", Purchase.challanDate));
                        parameter1.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));
                        parameter1.Add(new KeyValuePair<string, object>("@isChalanConvert", Purchase.isChalanConvert));
                        result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addTempPurchaseStockUpdate]", parameter1,Conn,trans);
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

        public static long getMaxIdPurchaseReturnInvoiceId(long financialYearId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));
                SqlHandler sqlH = new SqlHandler();
                long purchaseReturnInvoiceId = sqlH.ExecuteAsScalarLong("Usp_getMaxIdTempPurchaseReturnInvoiceId", parameter);
                return purchaseReturnInvoiceId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable PurchaseDayBook(DateTime fromDate, DateTime toDate, string opration, long financialYearId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@opration", opration));
                parameter.Add(new KeyValuePair<string, object>("@financialYearId", financialYearId));
                SqlHandler sqlH=new SqlHandler();
                DataTable dtPurchaseBook = sqlH.ExecuteAsDataTable("Usp_TempPurchaseBook", parameter);
                return dtPurchaseBook;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
