using DataAccessLayer.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace DataAccessLayer.providers
{
  public  class salesDetailsProvider
    {
      #region defination & declaration
      private static string _connectionString = SystemSetting.ConnectionString;
      #endregion
        public static long getMaxIdSaleInvoiceId(long financialYearID)
        {
            try
            {

                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", financialYearID));
                SqlHandler sqlH = new SqlHandler();
                long salesInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getMaxIdSaleInvoiceId]",parameter);
                return salesInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static long getWholeMaxIdSaleInvoiceId(long financialYearID)
        {
            try
            {

                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", financialYearID));
                SqlHandler sqlH = new SqlHandler();
                long salesInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getMaxIdWholeSaleInvoiceId]", parameter);
                return salesInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static long getMaxIdSalesItemDetails(int p, long financialYearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@Type", p));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", financialYearID));
                SqlHandler sqlH = new SqlHandler();
                long salesInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getMaxIdSalesItemDetails]", parameter);
                return salesInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

        public static long getWholeMaxIdSalesItemDetails(int p, long financialYearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@Type", p));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", financialYearID));
                SqlHandler sqlH = new SqlHandler();
                long salesInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getMaxIdWholeSalesItemDetails]", parameter);
                return salesInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static long getcustomerMaxId()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                long customerId = sqlH.ExecuteAsScalar("[dbo].[Usp_getcustomerMaxId]");
                return customerId;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getStockInSaleItemDetails(string value, string type, bool isWholeSale)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@txtSearch", value));
                parameter.Add(new KeyValuePair<string, object>("@type", type));
                parameter.Add(new KeyValuePair<string, object>("@isWholeSale", isWholeSale));
                SqlHandler sqlH = new SqlHandler();
                DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStockInSaleItemDetails]", parameter);
                return listi;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static int addSalesDetails(SalesDetails sale, PusrchaseSaleAccount salePurch)
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
                    parameter.Add(new KeyValuePair<string, object>("@DriverName", sale.driverName));
                    parameter.Add(new KeyValuePair<string, object>("@GadiNo", sale.gadiNo));
                    parameter.Add(new KeyValuePair<string, object>("@NewSalesInvoiceId", sale.NewsalesInvoiceId));
                    parameter.Add(new KeyValuePair<string, object>("@ChalanNo", sale.chalanNo));

                    int i = 0;
                    if (sale.isWholeSale == true)
                    {
                        i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addWholeSalesDetails]", parameter, Conn, trans);
                    }
                    else
                    {
                        i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addSalesDetails]", parameter, Conn, trans);
                    }

                    if (sale.isDelete == false)
                    {
                        List<KeyValuePair<string, object>> parameter2 = new List<KeyValuePair<string, object>>();
                        parameter2.Add(new KeyValuePair<string, object>("@transactionId", salePurch.transactionId));
                        parameter2.Add(new KeyValuePair<string, object>("@FinancialYearID", sale.FinancialYearID));
                        parameter2.Add(new KeyValuePair<string, object>("@transactionDate", sale.salesDate));
                        parameter2.Add(new KeyValuePair<string, object>("@billId", salePurch.billId));
                        parameter2.Add(new KeyValuePair<string, object>("@Hamali", salePurch.Hamali));
                        parameter2.Add(new KeyValuePair<string, object>("@RoundOff", salePurch.RoundOff));
                        parameter2.Add(new KeyValuePair<string, object>("@discount", salePurch.discount));
                        parameter2.Add(new KeyValuePair<string, object>("@Igst5", salePurch.Igst5));
                        parameter2.Add(new KeyValuePair<string, object>("@Igst12", salePurch.Igst12));
                        parameter2.Add(new KeyValuePair<string, object>("@Igst18", salePurch.Igst18));
                        parameter2.Add(new KeyValuePair<string, object>("@Igst28", salePurch.Igst28));
                        parameter2.Add(new KeyValuePair<string, object>("@salePurchaseAccount", salePurch.salePurchaseAccount));
                        parameter2.Add(new KeyValuePair<string, object>("@issalePurchase", salePurch.issalePurchase));
                        parameter2.Add(new KeyValuePair<string, object>("@stateCode", sale.stateCode));
                        SqlHandler sqlH2 = new SqlHandler();
                        int s = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addAllSalesAccount]", parameter2, Conn, trans);
                    }
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
                      
                        if (sale.isWholeSale == false)
                        {
                            result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addSaleStockUpdate]", parameter1, Conn, trans);
                        }
                        else
                        {
                            result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addWholeSaleStockUpdate]", parameter1, Conn, trans);
                        }
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
        public static DataTable getEmptySaleItem()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getEmptySaleItem]");
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
         public static DataTable getSaleIvoiceList(DateTime fromDate,DateTime toDate)
         {
            try
            {
                DataTable dtChallanList = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                SqlHandler sqlH = new SqlHandler();
                dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleIvoiceList]", parameter);
                return dtChallanList;
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
                 DataTable dtSaleInvoice = new DataTable();
                 List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                 parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salesInvoiceId));
                 parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                 SqlHandler sqlH = new SqlHandler();
                 dtSaleInvoice = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleInvoice]",parameter);
                 return dtSaleInvoice;
             }
             catch (Exception ae)
             {
                 throw ae;
             }
         }
        public static int deleteSalesInvoiceRow(string saleID,string stateCode, long salesItemDetailsId, long itemID, long categoryID, long companyId, string batchNo, double quantity, long StockId, double IGSTAmt, double IGST,bool isWholeSale)
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
                  parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", saleID));
                  parameter.Add(new KeyValuePair<string, object>("@stateCode", stateCode));
                  parameter.Add(new KeyValuePair<string, object>("@salesItemDetailsId", salesItemDetailsId));
                  parameter.Add(new KeyValuePair<string, object>("@itemID", itemID));
                  parameter.Add(new KeyValuePair<string, object>("@categoryID", categoryID));
                  parameter.Add(new KeyValuePair<string, object>("@companyId", companyId));
                  parameter.Add(new KeyValuePair<string, object>("@batchNo", batchNo));
                  parameter.Add(new KeyValuePair<string, object>("@quantity", quantity));
                  parameter.Add(new KeyValuePair<string, object>("@StockId", StockId));
                  parameter.Add(new KeyValuePair<string, object>("@IGSTAmt", IGSTAmt));
                  parameter.Add(new KeyValuePair<string, object>("@IGST", IGST));
                  //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
                  int i = 0;
                  if (isWholeSale == true)
                  {
                      i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_deleteWholeSaleInvoiceItem]", parameter,Conn,trans);
                  }
                  else
                  {
                      i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_deleteSaleInvoiceItem]", parameter,Conn,trans);
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
        public static DataTable getminimumPurchaseRate(long itemId, long companyId, long categoryId, string batchNo, string unitBy)
      {
          try
          {
              DataTable dt = new DataTable();
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
              parameter.Add(new KeyValuePair<string, object>("@companyId", companyId));
              parameter.Add(new KeyValuePair<string, object>("@categoryId", categoryId));
              parameter.Add(new KeyValuePair<string, object>("@batchNo", batchNo));
              parameter.Add(new KeyValuePair<string, object>("@unitBy", unitBy));
              SqlHandler sqlH = new SqlHandler();
              dt = sqlH.ExecuteAsDataTable("[dbo].[Usp_getMinimunPurchaseRate]", parameter);
              return dt;
          }
          catch (Exception ae)
          {
              throw ae;
          }
      }
        #region --Sales Challan-
        public static long getMaxIdSaleChallanInvoiceId(long financialYearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                SqlHandler sqlH = new SqlHandler();
                long salesChallanInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getMaxIdSaleChallanInvoiceId]",parameter);
                return salesChallanInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
      public static int addSalesChallanDetails(SalesDetails saleReturn)
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
                parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", saleReturn.salesInvoiceId));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", saleReturn.FinancialYearID));
                parameter.Add(new KeyValuePair<string, object>("@salesDate", saleReturn.salesDate));
                parameter.Add(new KeyValuePair<string, object>("@customerId", saleReturn.customerId));
                parameter.Add(new KeyValuePair<string, object>("@salesType", saleReturn.salesType));
                parameter.Add(new KeyValuePair<string, object>("@othercharges", saleReturn.paidAmount));
                parameter.Add(new KeyValuePair<string, object>("@totalbillAmount", saleReturn.totalbillAmount));
                parameter.Add(new KeyValuePair<string, object>("@isState", saleReturn.isState));
                parameter.Add(new KeyValuePair<string, object>("@isDelete", saleReturn.isDelete));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", saleReturn.addedBy));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", saleReturn.addedOn));
                parameter.Add(new KeyValuePair<string, object>("@isCustomerRetailer", saleReturn.isRetailer));
                parameter.Add(new KeyValuePair<string, object>("@state", saleReturn.state));
                parameter.Add(new KeyValuePair<string, object>("@stateCode", saleReturn.stateCode));
                //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
             
                int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addSalesChallanDetails]", parameter,Conn,trans);

                int result = 0;
                for (int k = 0; k < saleReturn.SaleItemTable.Rows.Count; k++)
                {
                    List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();
                    parameter1.Add(new KeyValuePair<string, object>("@salesinvoiceId", saleReturn.salesInvoiceId));
                    parameter1.Add(new KeyValuePair<string, object>("@financialYearID", saleReturn.FinancialYearID));
                    parameter1.Add(new KeyValuePair<string, object>("@isDelete", saleReturn.isDelete));
                    parameter1.Add(new KeyValuePair<string, object>("@salesChallanItemDetailsId", saleReturn.SaleItemTable.Rows[k]["salesChallanItemDetailsId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@itemId", saleReturn.SaleItemTable.Rows[k]["itemId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@stockId", saleReturn.SaleItemTable.Rows[k]["stockId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@companyId", saleReturn.SaleItemTable.Rows[k]["companyId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@categoryId", saleReturn.SaleItemTable.Rows[k]["categoryId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@Quantity", saleReturn.SaleItemTable.Rows[k]["Quantity"]));
                    parameter1.Add(new KeyValuePair<string, object>("@IGST", saleReturn.SaleItemTable.Rows[k]["IGST"]));
                    parameter1.Add(new KeyValuePair<string, object>("@CGST", saleReturn.SaleItemTable.Rows[k]["CGST"]));
                    parameter1.Add(new KeyValuePair<string, object>("@SGST", saleReturn.SaleItemTable.Rows[k]["SGST"]));
                    parameter1.Add(new KeyValuePair<string, object>("@batchNo", saleReturn.SaleItemTable.Rows[k]["batchNo"]));
                    parameter1.Add(new KeyValuePair<string, object>("@unitBy", saleReturn.SaleItemTable.Rows[k]["unitBy"]));
                    parameter1.Add(new KeyValuePair<string, object>("@discount", saleReturn.SaleItemTable.Rows[k]["discount"]));
                    parameter1.Add(new KeyValuePair<string, object>("@perQtysalePrice", saleReturn.SaleItemTable.Rows[k]["Rate"]));
                    parameter1.Add(new KeyValuePair<string, object>("@salePrice", saleReturn.SaleItemTable.Rows[k]["totalAmount"]));
                    parameter1.Add(new KeyValuePair<string, object>("@addedBy", saleReturn.addedBy));
                    parameter1.Add(new KeyValuePair<string, object>("@addedOn", saleReturn.addedOn));
                    result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addSaleChallanStockUpdate]", parameter1,Conn,trans);
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
      public static DataTable getChallenList(DateTime fromDate,DateTime toDate,long financialYearID)
      {
          try
          {
              DataTable dtChallanList = new DataTable();
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
              parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
              parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
              SqlHandler sqlH = new SqlHandler();
              dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleChallanList]",parameter);
              return dtChallanList;
          }
          catch(Exception ae)
          {
              throw ae;
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
              dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleChallanListByCustomer]", parameter);
              return dtChallanList;
          }
          catch (Exception ae)
          {
              throw ae;
          }
      }
      //public static DataTable getSaleChallenDetails(long SalesChallanBillId)
      //{
      //    try
      //    {
      //        DataTable dtSaleChallen=new DataTable();
      //        List<KeyValuePair<string,object>> parameter=new List<KeyValuePair<string,object>>();
      //        parameter.Add(new KeyValuePair<string, object>("@salesChallanId", SalesChallanBillId.ToString()));
      //        SqlHandler sqlH=new SqlHandler();
      //        dtSaleChallen = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSalesChallan]", parameter);
      //        return dtSaleChallen;
      //    }
      //    catch(Exception ae)
      //    {
      //        throw ae;
      //    }
      //}
      public static DataTable getSaleChallenDetails(long salesChallanId, long financialYearID)
      {
          try
          {
              DataTable dtSaleChallen = new DataTable();
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@salesChallanId", salesChallanId));
              parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
              SqlHandler sqlH = new SqlHandler();
              dtSaleChallen = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSalesChallan]", parameter);
              return dtSaleChallen;
          }
          catch (Exception ae)
          {
              throw ae;
          }
      }
      public static int deleteRow(long SalesChallanBillId,long salesChallanItemDetailsId, long itemID, long categoryID, long companyId, string batchNo
          , double quantity,long StockId)
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
          parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", SalesChallanBillId));
          parameter.Add(new KeyValuePair<string, object>("@salesChallanItemDetailsId", salesChallanItemDetailsId));
          parameter.Add(new KeyValuePair<string, object>("@itemID", itemID));
          parameter.Add(new KeyValuePair<string, object>("@categoryID", categoryID));
          parameter.Add(new KeyValuePair<string, object>("@companyId", companyId));
          parameter.Add(new KeyValuePair<string, object>("@batchNo", batchNo));
          parameter.Add(new KeyValuePair<string, object>("@quantity", quantity));
          parameter.Add(new KeyValuePair<string, object>("@stockId", StockId));
          //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
         
          int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_deleteSalechallanItem]", parameter,Conn,trans);
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
        #region - Sales Order -
      public static long getMaxIdSalesOrderId(long financialYearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                SqlHandler sqlH = new SqlHandler();
                long salesChallanInvoiceId = sqlH.ExecuteAsScalarLong("[dbo].[Usp_getMaxIdSalesOrderId]", parameter);
                return salesChallanInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
      public static int addSalesOrderDetails(SalesDetails saleReturn)
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
              parameter.Add(new KeyValuePair<string, object>("@SalesOrderBillId", saleReturn.salesInvoiceId));
              parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", saleReturn.FinancialYearID));
              parameter.Add(new KeyValuePair<string, object>("@salesDate", saleReturn.salesDate));
              parameter.Add(new KeyValuePair<string, object>("@customerId", saleReturn.customerId));
              parameter.Add(new KeyValuePair<string, object>("@salesType", saleReturn.salesType));
              parameter.Add(new KeyValuePair<string, object>("@othercharges", saleReturn.paidAmount));
              parameter.Add(new KeyValuePair<string, object>("@totalbillAmount", saleReturn.totalbillAmount));
              parameter.Add(new KeyValuePair<string, object>("@isState", saleReturn.isState));
              parameter.Add(new KeyValuePair<string, object>("@isDelete", saleReturn.isDelete));
              parameter.Add(new KeyValuePair<string, object>("@addedBy", saleReturn.addedBy));
              parameter.Add(new KeyValuePair<string, object>("@addedOn", saleReturn.addedOn));
              //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
           
              int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addSalesOrderDetails]", parameter,Conn,trans);

              int result = 0;
              for (int k = 0; k < saleReturn.SaleItemTable.Rows.Count; k++)
              {
                  List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();
                  parameter1.Add(new KeyValuePair<string, object>("@SalesOrderBillId", saleReturn.salesInvoiceId));
                  parameter1.Add(new KeyValuePair<string, object>("@FinancialYearID", saleReturn.FinancialYearID));
                  parameter1.Add(new KeyValuePair<string, object>("@isDelete", saleReturn.isDelete));
                  parameter1.Add(new KeyValuePair<string, object>("@itemId", saleReturn.SaleItemTable.Rows[k]["itemId"]));
                  parameter1.Add(new KeyValuePair<string, object>("@stockId", saleReturn.SaleItemTable.Rows[k]["stockId"]));
                  parameter1.Add(new KeyValuePair<string, object>("@companyId", saleReturn.SaleItemTable.Rows[k]["companyId"]));
                  parameter1.Add(new KeyValuePair<string, object>("@categoryId", saleReturn.SaleItemTable.Rows[k]["categoryId"]));
                  parameter1.Add(new KeyValuePair<string, object>("@Quantity", saleReturn.SaleItemTable.Rows[k]["Quantity"]));
                  parameter1.Add(new KeyValuePair<string, object>("@IGST", saleReturn.SaleItemTable.Rows[k]["IGST"]));
                  parameter1.Add(new KeyValuePair<string, object>("@CGST", saleReturn.SaleItemTable.Rows[k]["CGST"]));
                  parameter1.Add(new KeyValuePair<string, object>("@SGST", saleReturn.SaleItemTable.Rows[k]["SGST"]));
                  parameter1.Add(new KeyValuePair<string, object>("@batchNo", saleReturn.SaleItemTable.Rows[k]["batchNo"]));
                  parameter1.Add(new KeyValuePair<string, object>("@unitBy", saleReturn.SaleItemTable.Rows[k]["unitBy"]));
                  parameter1.Add(new KeyValuePair<string, object>("@discount", saleReturn.SaleItemTable.Rows[k]["discount"]));
                  parameter1.Add(new KeyValuePair<string, object>("@perQtysalePrice", saleReturn.SaleItemTable.Rows[k]["Rate"]));
                  parameter1.Add(new KeyValuePair<string, object>("@salePrice", saleReturn.SaleItemTable.Rows[k]["totalAmount"]));
                  parameter1.Add(new KeyValuePair<string, object>("@addedBy", saleReturn.addedBy));
                  parameter1.Add(new KeyValuePair<string, object>("@addedOn", saleReturn.addedOn));
                  result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addSaleOrderItem]", parameter1,Conn,trans);
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
      public static DataTable getSalesOrderList(DateTime fromDate, DateTime toDate, long financialYearID)
      {
          try
          {
              DataTable dtChallanList = new DataTable();
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
              parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
              parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
              SqlHandler sqlH = new SqlHandler();
              dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSaleOrderList]", parameter);
              return dtChallanList;
          }
          catch (Exception ae)
          {
              throw ae;
          }
      }
      public static DataTable getSaleOrderDetails(long SalesOrderBillId, long financialYearID)
      {
          try
          {
              DataTable dtSaleChallen = new DataTable();
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@SalesOrderBillId", SalesOrderBillId.ToString()));
                    parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
              SqlHandler sqlH = new SqlHandler();
              dtSaleChallen = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSalesOrder]", parameter);
              return dtSaleChallen;
          }
          catch (Exception ae)
          {
              throw ae;
          }
      }
      public static int DeletSaleOrderRow(long SalesOrderBillId, long itemID, long categoryID, long companyId, string batchNo, double quantity)
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
          parameter.Add(new KeyValuePair<string, object>("@SalesOrderBillId", SalesOrderBillId));
          parameter.Add(new KeyValuePair<string, object>("@itemID", itemID));
          parameter.Add(new KeyValuePair<string, object>("@categoryID", categoryID));
          parameter.Add(new KeyValuePair<string, object>("@companyId", companyId));
          parameter.Add(new KeyValuePair<string, object>("@batchNo", batchNo));
          parameter.Add(new KeyValuePair<string, object>("@quantity", quantity));
          //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
          
          int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_deleteSalesOrderItem]", parameter,Conn,trans);
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

      public static int addSalesDetailsForConvertChalan(SalesDetails sale, PusrchaseSaleAccount salePurch)
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
              parameter.Add(new KeyValuePair<string, object>("@DriverName", sale.driverName));
              parameter.Add(new KeyValuePair<string, object>("@GadiNo", sale.gadiNo));
              parameter.Add(new KeyValuePair<string, object>("@NewSalesInvoiceId", sale.NewsalesInvoiceId));
              parameter.Add(new KeyValuePair<string, object>("@ChalanNo", sale.chalanNo));
                      
              //  parameter.Add(new KeyValuePair<string, object>("@AddSaleItem", sale.SaleItemTable));
            //  SqlHandler sqlH = new SqlHandler();
               int i=0;
              if(sale.isWholeSale==true)
              {
                  i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addWholeSalesDetails]", parameter, Conn, trans);
              }
              else
              {
                  i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addSalesDetails]", parameter,Conn,trans);
              }
              if (sale.isDelete == false)
              {
                  List<KeyValuePair<string, object>> parameter2 = new List<KeyValuePair<string, object>>();
                  parameter2.Add(new KeyValuePair<string, object>("@transactionId", salePurch.transactionId));
                  parameter2.Add(new KeyValuePair<string, object>("@FinancialYearID", sale.FinancialYearID));
                  parameter2.Add(new KeyValuePair<string, object>("@transactionDate", sale.salesDate));
                  parameter2.Add(new KeyValuePair<string, object>("@billId", salePurch.billId));
                  parameter2.Add(new KeyValuePair<string, object>("@Hamali", salePurch.Hamali));
                  parameter2.Add(new KeyValuePair<string, object>("@RoundOff", salePurch.RoundOff));
                  parameter2.Add(new KeyValuePair<string, object>("@discount", salePurch.discount));
                  parameter2.Add(new KeyValuePair<string, object>("@Igst5", salePurch.Igst5));
                  parameter2.Add(new KeyValuePair<string, object>("@Igst12", salePurch.Igst12));
                  parameter2.Add(new KeyValuePair<string, object>("@Igst18", salePurch.Igst18));
                  parameter2.Add(new KeyValuePair<string, object>("@Igst28", salePurch.Igst28));
                  parameter2.Add(new KeyValuePair<string, object>("@salePurchaseAccount", salePurch.salePurchaseAccount));
                  parameter2.Add(new KeyValuePair<string, object>("@issalePurchase", salePurch.issalePurchase));
                  parameter2.Add(new KeyValuePair<string, object>("@stateCode", sale.stateCode));
                  int s = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addAllSalesAccount]", parameter2,Conn,trans);
              }
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
                 
                
                  int result1 = 0;
                  if (sale.isWholeSale == true)
                  {
                      result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addSaleItemDetailsForConvertChalan]", parameter1,Conn,trans);
                  }
                  else
                  {
                      result = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addSaleItemDetailsForConvertChalan]", parameter1,Conn,trans);
                  }
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
        #endregion

      public static DataTable getWholeSaleIvoiceList(DateTime fromDate, DateTime toDate)
      {
          try
          {
              DataTable dtsaleDetailsList = new DataTable();
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
              parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
              SqlHandler sqlH = new SqlHandler();
              dtsaleDetailsList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getWholeSaleIvoiceList]", parameter);
              return dtsaleDetailsList;
          }
          catch(Exception ex)
          {
              throw ex;
          }
      }

      internal static DataTable getWholeSaleInvoice(string salesInvoiceId, long financialyearID)
      {
          try
          {
              DataTable dtSalesDetails = new DataTable();
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@salesInvoiceId", salesInvoiceId));
              parameter.Add(new KeyValuePair<string, object>("@financialyearID", financialyearID));
              SqlHandler sqlH = new SqlHandler();
              dtSalesDetails = sqlH.ExecuteAsDataTable("[dbo].[Usp_getWholeSaleInvoice]", parameter);
              return dtSalesDetails;
          }
          catch(Exception ex)
          {
              throw ex;
          }
      }
      public static bool getInvoice(string invoiceNO, long customerID, long financialYearID)
      {
          try
          {
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@invoiceNO", invoiceNO));
              parameter.Add(new KeyValuePair<string, object>("@customerID", customerID));
              parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
              SqlHandler sqlH = new SqlHandler();
              Boolean isExists = false;
              isExists = sqlH.ExecuteAsScalarBool("[dbo].[Usp_getExistsingSaleInvoice]", parameter);
              return isExists;
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }
    }
}
