using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace DataAccessLayer.providers
{
    public class purchaseDetailsProvider
    {
        #region defination & declaration
        private static string _connectionString = SystemSetting.ConnectionString;
        #endregion
        public static int addPurchaseDetails(PurchaseDetails Purchase, PusrchaseSaleAccount purchSale)
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
               
                int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addPurchaseDetails]", parameter,Conn,trans);
                int result = 0;
                if (Purchase.isDelete == false)
                {
                    ///Save Gst Account Group Payment Due Table
                    List<KeyValuePair<string, object>> parameterGroup = new List<KeyValuePair<string, object>>();
                    parameterGroup.Add(new KeyValuePair<string, object>("@transactionId", purchSale.transactionId));
                    parameterGroup.Add(new KeyValuePair<string, object>("@billId", purchSale.billId));
                    parameterGroup.Add(new KeyValuePair<string, object>("@RoundOff", purchSale.RoundOff));
                    parameterGroup.Add(new KeyValuePair<string, object>("@discount", purchSale.discount));
                    parameterGroup.Add(new KeyValuePair<string, object>("@Hamali", purchSale.Hamali));
                    parameterGroup.Add(new KeyValuePair<string, object>("@Igst5", purchSale.Igst5));
                    parameterGroup.Add(new KeyValuePair<string, object>("@Igst12", purchSale.Igst12));
                    parameterGroup.Add(new KeyValuePair<string, object>("@Igst18", purchSale.Igst18));
                    parameterGroup.Add(new KeyValuePair<string, object>("@Igst28", purchSale.Igst28));
                    parameterGroup.Add(new KeyValuePair<string, object>("@salePurchaseAccount", purchSale.salePurchaseAccount));
                    parameterGroup.Add(new KeyValuePair<string, object>("@issalePurchase", purchSale.issalePurchase));
                    parameterGroup.Add(new KeyValuePair<string, object>("@stateCode", purchSale.stateCode));
                    parameterGroup.Add(new KeyValuePair<string, object>("@transactionDate", Purchase.challanDate));
                    parameterGroup.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));
                  
                    result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addAllPurchasesAccount]", parameterGroup,Conn,trans);
                    ///End
                    ///
                }
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
                    parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCashRate",Purchase.PurchaseItemTable.Rows[k]["salesCashRate"]));
                    parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate",Purchase.PurchaseItemTable.Rows[k]["salesCashRate"]));
                    parameter1.Add(new KeyValuePair<string, object>("@addedBy", 1));
                    parameter1.Add(new KeyValuePair<string, object>("@addedOn", Purchase.challanDate));
                    parameter1.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));
                    result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addPurchaseStockUpdate]", parameter1,Conn,trans);
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
        public static DataTable getPurchaseList(DateTime fromDate, DateTime toDate, long FinancialYearID)
        {
            try
            {
                DataTable dtChallanList = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
                SqlHandler sqlH = new SqlHandler();
                dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getPurchaseIvoiceList]", parameter);
                return dtChallanList;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getChallenList(long dealerId, DateTime fromDate, DateTime toDate, long FinancialYearID)
        {
            try
            {
                DataTable dtChallanList = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@dealerId", dealerId));
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
                SqlHandler sqlH = new SqlHandler();
                dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getPurchaseChallanListByDealer]", parameter);
                return dtChallanList;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        public static DataTable getPurchaseIvoiceDetails(long purchaseId, long FinancialYearID)
        {
            try
            {
                DataTable dtPurchaseDetails = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@purchaseId", purchaseId));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
                SqlHandler sqlH = new SqlHandler();
                dtPurchaseDetails = sqlH.ExecuteAsDataTable("[dbo].[Usp_GetpurchaseInvoiceDetails]", parameter);
                return dtPurchaseDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
       public static int deletePurchseInvoiceRow(long purchaseId,long purchaseItemDetailId, long itemID, long categoryID, long companyId
           , string batchNo, double quantity, double freeQuantity,long stockId)
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
           parameter.Add(new KeyValuePair<string, object>("@purchaseId", purchaseId));
           parameter.Add(new KeyValuePair<string, object>("@purchaseItemDetailId", purchaseItemDetailId));
           parameter.Add(new KeyValuePair<string, object>("@itemID", itemID));
           parameter.Add(new KeyValuePair<string, object>("@categoryID", categoryID));
           parameter.Add(new KeyValuePair<string, object>("@companyId", companyId));
           parameter.Add(new KeyValuePair<string, object>("@batchNo", batchNo));
           parameter.Add(new KeyValuePair<string, object>("@quantity", quantity));
           parameter.Add(new KeyValuePair<string, object>("@freeQuantity", freeQuantity));
           parameter.Add(new KeyValuePair<string, object>("@stockId", stockId));
           //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
        
           int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_deletePurchaseInvoiceItem]", parameter,Conn,trans);
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
       public static DataTable getEmptyDataTableInPurchaseItemReturn()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getEmptyDataTableInPurchaseItem]");
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

       public static DataTable getEmptyDataTableInPurchaseItem()
       {
           try
           {
               SqlHandler sqlH = new SqlHandler();
               DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getEmptyDataTableInPurchaseItem]");
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }

       } 

        public static long getMaxIdPurchaseInvoiceId()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                long purchaseInvoiceId = sqlH.ExecuteAsScalar("[dbo].[Usp_getMaxIdPurchaseInvoiceId]");
                return purchaseInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

        public static long getMaxIdPurchaseReturnInvoiceId(long FinancialYearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
                SqlHandler sqlH = new SqlHandler();
                long purchaseReutrnInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getMaxIdPurchaseReturnInvoiceId]", parameter);
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static double getPaymentDeuAmtDealer(long dealerId, long finacialYearId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@AccountId", dealerId));
                parameter.Add(new KeyValuePair<string, object>("@Opreation", "dealer"));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", finacialYearId));
                SqlHandler sqlH = new SqlHandler();
                double i = sqlH.ExecuteAsScalar("[dbo].[Usp_getPaymentDue]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        } 
        #region -- Purchase Challan --
        public static long getMaxIdPurchaseChalanId()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                long purchaseReutrnInvoiceId = sqlH.ExecuteAsScalar("[dbo].[Usp_getMaxIdPurchaseChalanId]");
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
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
               
                int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addPurchaseChalanDetails]", parameter,Conn,trans);


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
                    
                    result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addPurchaseChalanStockUpdate]", parameter1,Conn,trans);
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
        public static DataTable getChallenList(DateTime fromDate, DateTime toDate, long FinancialYearID)
        {
            try
            {
                DataTable dtChallanList = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
                SqlHandler sqlH = new SqlHandler();
                dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getPurchaseChallanList]", parameter);
                return dtChallanList;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        //use for purchase challan convert stock
        public static DataTable getSaleChallenDetails(long purchaseChalanId, long FinancialYearID)
        {
            try
            {
                DataTable dtSaleChallen = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@purchaseChalanId", purchaseChalanId));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
                SqlHandler sqlH = new SqlHandler();
                dtSaleChallen = sqlH.ExecuteAsDataTable("[dbo].[Usp_getPurchaseChallan]", parameter);
                return dtSaleChallen;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }  
      
        public static int deleteRow(long purchaseChalanId, long purchaseChalanItemDetailId, long itemID, long categoryID, long companyId, string batchNo, double quantity, long StockId)
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
            parameter.Add(new KeyValuePair<string, object>("@purchaseChalanItemDetailId", purchaseChalanItemDetailId));
            parameter.Add(new KeyValuePair<string, object>("@itemID", itemID));
            parameter.Add(new KeyValuePair<string, object>("@categoryID", categoryID));
            parameter.Add(new KeyValuePair<string, object>("@companyId", companyId));
            parameter.Add(new KeyValuePair<string, object>("@batchNo", batchNo));
            parameter.Add(new KeyValuePair<string, object>("@quantity", quantity));
            parameter.Add(new KeyValuePair<string, object>("@StockId", StockId));
            //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
           
            int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_deletePurchasechallanItem]", parameter,Conn,trans);
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
     
#endregion 
        #region -- Purchase Order --
        public static long getMaxIdPurchaseOrderId(long FinancialYearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
                SqlHandler sqlH = new SqlHandler();
                long purchaseReutrnInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getMaxIdPurchaseOrderId]", parameter);
                return purchaseReutrnInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static int addPurchaseOrderDetails(PurchaseDetails Purchase)
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
                parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.UtcNow));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));
                // parameter.Add(new KeyValuePair<string, object>("@PurchaseItemTable", Purchase.PurchaseItemTable));
               
                int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addPurchaseOrderDetails]", parameter,Conn,trans);
                int result = 0;
                for (int k = 0; k < Purchase.PurchaseItemTable.Rows.Count; k++)
                {
                    List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();

                    parameter1.Add(new KeyValuePair<string, object>("@isDelete", Purchase.isDelete));
                    parameter1.Add(new KeyValuePair<string, object>("@itemId", Purchase.PurchaseItemTable.Rows[k]["itemId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@stockId", Purchase.PurchaseItemTable.Rows[k]["stockId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@companyId", Purchase.PurchaseItemTable.Rows[k]["companyId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@categoryId", Purchase.PurchaseItemTable.Rows[k]["categoryId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@purchaseOrderBillId", Purchase.purchaseChalanId));
                    parameter1.Add(new KeyValuePair<string, object>("@Quantity", Purchase.PurchaseItemTable.Rows[k]["Quantity"]));
                    //  parameter1.Add(new KeyValuePair<string, object>("@FreeQuantity", Purchase.PurchaseItemTable.Rows[k]["freeQuantity"]));
                    parameter1.Add(new KeyValuePair<string, object>("@IGST", Purchase.PurchaseItemTable.Rows[k]["IGST"]));
                    parameter1.Add(new KeyValuePair<string, object>("@CGST", Purchase.PurchaseItemTable.Rows[k]["CGST"]));
                    parameter1.Add(new KeyValuePair<string, object>("@SGST", Purchase.PurchaseItemTable.Rows[k]["SGST"]));
                    parameter1.Add(new KeyValuePair<string, object>("@batchNo", Purchase.PurchaseItemTable.Rows[k]["batchNo"]));
                    parameter1.Add(new KeyValuePair<string, object>("@unitBy", Purchase.PurchaseItemTable.Rows[k]["unitBy"]));
                    parameter1.Add(new KeyValuePair<string, object>("@discount", Purchase.PurchaseItemTable.Rows[k]["discount"]));
                    parameter1.Add(new KeyValuePair<string, object>("@purchaseRate", Purchase.PurchaseItemTable.Rows[k]["purchaseRate"]));
                    parameter1.Add(new KeyValuePair<string, object>("@MRP", Purchase.PurchaseItemTable.Rows[k]["MRP"]));
                    parameter1.Add(new KeyValuePair<string, object>("@salesCashRate", Purchase.PurchaseItemTable.Rows[k]["salesCashRate"]));
                    parameter1.Add(new KeyValuePair<string, object>("@salesCreditRate", 0));
                    parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCashRate", 0));
                    parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate", 0));
                    parameter1.Add(new KeyValuePair<string, object>("@addedBy", 1));
                    parameter1.Add(new KeyValuePair<string, object>("@addedOn", DateTime.UtcNow));
                    parameter1.Add(new KeyValuePair<string, object>("@FinancialYearID", Purchase.FinancialYearID));
                    result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addPurchaseOrder]", parameter1,Conn,trans);
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
        public static DataTable getOrderList(DateTime fromDate, DateTime toDate, long FinancialYearID)
        {
            try
            {
                DataTable dtChallanList = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
                SqlHandler sqlH = new SqlHandler();
                dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getPurchaseOrderList]", parameter);
                return dtChallanList;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
       public static DataTable getPurchaseOrderDetails(long purchaseChalanId, long FinancialYearID)
        {
            try
            {
                DataTable dtSaleChallen = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@purchaseChalanId", purchaseChalanId));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
                SqlHandler sqlH = new SqlHandler();
                dtSaleChallen = sqlH.ExecuteAsDataTable("[dbo].[Usp_getPurchaseOrder]", parameter);
                return dtSaleChallen;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
 
        public static int deletePurchaseOrderRow(long purchaseChalanId, long itemID, long categoryID, long companyId, string batchNo, double quantity)
        {  using (var Conn = new SqlConnection(_connectionString))
            {
                SqlHandler sqlH = new SqlHandler();
                SqlTransaction trans = null;
                try
                {
                    Conn.Open();
                    trans = Conn.BeginTransaction();
            List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
            parameter.Add(new KeyValuePair<string, object>("@purchaseChalanId", purchaseChalanId));
            parameter.Add(new KeyValuePair<string, object>("@itemID", itemID));
            parameter.Add(new KeyValuePair<string, object>("@categoryID", categoryID));
            parameter.Add(new KeyValuePair<string, object>("@companyId", companyId));
            parameter.Add(new KeyValuePair<string, object>("@batchNo", batchNo));
            parameter.Add(new KeyValuePair<string, object>("@quantity", quantity));
            //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
          
            int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_deletePurchaseOrderItem]", parameter,Conn,trans);
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

        #endregion 


        public static int addPurchaseDetailsByChalanConvert(PurchaseDetails purchase, PusrchaseSaleAccount purchSale)
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
                parameter.Add(new KeyValuePair<string, object>("@purchaseId", purchase.purchaseId));
                parameter.Add(new KeyValuePair<string, object>("@purchaseInvoiceId", purchase.purchaseInvoiceId));
                parameter.Add(new KeyValuePair<string, object>("@challanDate", purchase.challanDate));
                parameter.Add(new KeyValuePair<string, object>("@dealerId", purchase.dealerId));
                parameter.Add(new KeyValuePair<string, object>("@remark", purchase.remark));
                parameter.Add(new KeyValuePair<string, object>("@netBillAmount", purchase.netBillAmount));
                parameter.Add(new KeyValuePair<string, object>("@paidAmount", purchase.paidAmount));
                parameter.Add(new KeyValuePair<string, object>("@paymentType", purchase.paymentType));
                parameter.Add(new KeyValuePair<string, object>("@isDelete", purchase.isDelete));
                parameter.Add(new KeyValuePair<string, object>("@bankName", purchase.bankName));
                parameter.Add(new KeyValuePair<string, object>("@bankId", purchase.orjId));
                parameter.Add(new KeyValuePair<string, object>("@chequeDate", purchase.chequeDate));
                parameter.Add(new KeyValuePair<string, object>("@refNo", purchase.chequeNo_refNo));
                parameter.Add(new KeyValuePair<string, object>("@state", purchase.state));
                parameter.Add(new KeyValuePair<string, object>("@stateCode", purchase.stateCode));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", purchase.addedBy));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.UtcNow));
                parameter.Add(new KeyValuePair<string, object>("@isState", purchase.isState));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", purchase.FinancialYearID));
                parameter.Add(new KeyValuePair<string, object>("@DilivaryCharges", purchase.DilivaryCharges));
                parameter.Add(new KeyValuePair<string, object>("@discountAmount", purchase.discountAmount));
                parameter.Add(new KeyValuePair<string, object>("@netBillAmtWithOutDiscount", purchase.netBillAmtWithOutDiscount));
                parameter.Add(new KeyValuePair<string, object>("@roundOff", purchase.roundOff));
                // parameter.Add(new KeyValuePair<string, object>("@PurchaseItemTable", Purchase.PurchaseItemTable));
               
                int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addPurchaseDetails]", parameter,Conn,trans);
                int result = 0;
                if (purchase.isDelete == false)
                {
                    ///Save Gst Account Group Payment Due Table
                    List<KeyValuePair<string, object>> parameterGroup = new List<KeyValuePair<string, object>>();
                    parameterGroup.Add(new KeyValuePair<string, object>("@transactionId", purchSale.transactionId));
                    parameterGroup.Add(new KeyValuePair<string, object>("@billId", purchSale.billId));
                    parameterGroup.Add(new KeyValuePair<string, object>("@RoundOff", purchSale.RoundOff));
                    parameterGroup.Add(new KeyValuePair<string, object>("@discount", purchSale.discount));
                    parameterGroup.Add(new KeyValuePair<string, object>("@Hamali", purchSale.Hamali));
                    parameterGroup.Add(new KeyValuePair<string, object>("@Igst5", purchSale.Igst5));
                    parameterGroup.Add(new KeyValuePair<string, object>("@Igst12", purchSale.Igst12));
                    parameterGroup.Add(new KeyValuePair<string, object>("@Igst18", purchSale.Igst18));
                    parameterGroup.Add(new KeyValuePair<string, object>("@Igst28", purchSale.Igst28));
                    parameterGroup.Add(new KeyValuePair<string, object>("@salePurchaseAccount", purchSale.salePurchaseAccount));
                    parameterGroup.Add(new KeyValuePair<string, object>("@issalePurchase", purchSale.issalePurchase));
                    parameterGroup.Add(new KeyValuePair<string, object>("@stateCode", purchSale.stateCode));
                    parameterGroup.Add(new KeyValuePair<string, object>("@transactionDate", purchase.challanDate));
                    parameterGroup.Add(new KeyValuePair<string, object>("@FinancialYearID", purchase.FinancialYearID));
                    result = sqlH.ExecuteNonQueryI("[dbo].[Usp_addAllPurchasesAccount]", parameterGroup);
                    ///End
                    ///
                }
                for (int k = 0; k < purchase.PurchaseItemTable.Rows.Count; k++)
                {
                    List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();
                    parameter1.Add(new KeyValuePair<string, object>("@purchaseId", purchase.purchaseId));
                    parameter1.Add(new KeyValuePair<string, object>("@purchaseInvoiceId", purchase.purchaseInvoiceId));
                    parameter1.Add(new KeyValuePair<string, object>("@isDelete", purchase.isDelete));
                    parameter1.Add(new KeyValuePair<string, object>("@purchaseChalanId", purchase.PurchaseItemTable.Rows[k]["purchaseChalanId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@itemId", purchase.PurchaseItemTable.Rows[k]["itemId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@stockId", purchase.PurchaseItemTable.Rows[k]["stockId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@companyId", purchase.PurchaseItemTable.Rows[k]["companyId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@categoryId", purchase.PurchaseItemTable.Rows[k]["categoryId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@Quantity", purchase.PurchaseItemTable.Rows[k]["Quantity"]));
                    parameter1.Add(new KeyValuePair<string, object>("@mfgDate", Convert.ToDateTime(purchase.PurchaseItemTable.Rows[k]["mfgDate"])));
                    parameter1.Add(new KeyValuePair<string, object>("@expireDate", Convert.ToDateTime(purchase.PurchaseItemTable.Rows[k]["expireDate"])));
                    parameter1.Add(new KeyValuePair<string, object>("@FreeQuantity", purchase.PurchaseItemTable.Rows[k]["freeQuantity"]));
                    parameter1.Add(new KeyValuePair<string, object>("@IGST", purchase.PurchaseItemTable.Rows[k]["IGST"]));
                    parameter1.Add(new KeyValuePair<string, object>("@CGST", purchase.PurchaseItemTable.Rows[k]["CGST"]));
                    parameter1.Add(new KeyValuePair<string, object>("@SGST", purchase.PurchaseItemTable.Rows[k]["SGST"]));
                    parameter1.Add(new KeyValuePair<string, object>("@batchNo", purchase.PurchaseItemTable.Rows[k]["batchNo"]));
                    parameter1.Add(new KeyValuePair<string, object>("@unitBy", purchase.PurchaseItemTable.Rows[k]["unitBy"]));
                    parameter1.Add(new KeyValuePair<string, object>("@discount", purchase.PurchaseItemTable.Rows[k]["discount"]));
                    parameter1.Add(new KeyValuePair<string, object>("@discountPer", purchase.PurchaseItemTable.Rows[k]["discountPer"]));
                    parameter1.Add(new KeyValuePair<string, object>("@purchaseRate", purchase.PurchaseItemTable.Rows[k]["purchaseRate"]));
                    parameter1.Add(new KeyValuePair<string, object>("@salesCashRate", purchase.PurchaseItemTable.Rows[k]["salesCashRate"]));
                    parameter1.Add(new KeyValuePair<string, object>("@productCode", purchase.PurchaseItemTable.Rows[k]["productCode"]));
                    parameter1.Add(new KeyValuePair<string, object>("@HNSCode", purchase.PurchaseItemTable.Rows[k]["HSNCode"]));
                    parameter1.Add(new KeyValuePair<string, object>("@rackNo", purchase.PurchaseItemTable.Rows[k]["rackNo"]));
                    parameter1.Add(new KeyValuePair<string, object>("@MRP", purchase.PurchaseItemTable.Rows[k]["MRP"]));
                    parameter1.Add(new KeyValuePair<string, object>("@salesCreditRate", 0));
                    parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCashRate", 0));
                    parameter1.Add(new KeyValuePair<string, object>("@wholeSalesCreditRate", 0));
                    parameter1.Add(new KeyValuePair<string, object>("@addedBy", 1));
                    parameter1.Add(new KeyValuePair<string, object>("@addedOn", DateTime.UtcNow));
                    parameter1.Add(new KeyValuePair<string, object>("@FinancialYearID", purchase.FinancialYearID));
                    
                    result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addPurchaseItemDetailsForConvertChalan]", parameter1,Conn,trans);
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

        public static bool getInvoice(string invoiceNO, long dealerID, long financialYearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@invoiceNO", invoiceNO));
                parameter.Add(new KeyValuePair<string, object>("@dealerID", dealerID));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                SqlHandler sqlH = new SqlHandler();
                Boolean isExists = false;
                isExists = sqlH.ExecuteAsScalarBool("[dbo].[Usp_getExistsingPurchaseInvoice]", parameter);
                return isExists;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static bool getpurchaseChalanNo(string invoiceNo, long dealerID, long financialYearID)
        {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@invoiceNO", invoiceNo));
               parameter.Add(new KeyValuePair<string, object>("@dealerID", dealerID));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqlH = new SqlHandler();
               Boolean isExists = false;
               isExists = sqlH.ExecuteAsScalarBool("[dbo].[Usp_getExistsingPurchaseChalanNo]", parameter);
               return isExists;
           }
            catch(Exception ex)
           {
               throw ex;
           }

        }
    }
}
