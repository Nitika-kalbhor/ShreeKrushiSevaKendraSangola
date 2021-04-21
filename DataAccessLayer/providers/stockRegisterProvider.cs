using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DataAccessLayer.providers
{
    public class stockRegisterProvider
    {
        public static DataTable getItemList(long StockID, string Operation)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@StockID", StockID));
                parameter.Add(new KeyValuePair<string, object>("@Operation", Operation));

                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getItemDetailsList]", parameter);
                return dtItem;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getStockDetails(int companyId, int categoryId, long itemId, string type)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@companyId", companyId));
                parameter.Add(new KeyValuePair<string, object>("@categoryId", categoryId));
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                parameter.Add(new KeyValuePair<string, object>("@type", type));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStcokRegister]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getItem(int categoryId)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@categoryId", categoryId));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getItemDetailsByCategory]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getItem(int company,int categoryId)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@company", company));
                parameter.Add(new KeyValuePair<string, object>("@categoryId", categoryId));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getItemDetailsByCompanyCategory]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getIemList(string Opreation,long StockID)
        {
            try
            {
                DataTable dtItemDetails = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@Opreation", Opreation));
                parameter.Add(new KeyValuePair<string, object>("@StockID", StockID));
                SqlHandler sqlH = new SqlHandler();
                dtItemDetails = sqlH.ExecuteAsDataTable("[dbo].[Usp_getItemDetailsList]", parameter);
                return dtItemDetails;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getReorder()
        {
            try
            {
                DataTable dtReoder = new DataTable();
                SqlHandler sqlH = new SqlHandler();
                dtReoder = sqlH.ExecuteAsDataTable("[dbo].[Usp_getReorderLevel]");
                return dtReoder;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getItemledger(int wearHouseId, int categoryId, long itemId, string batchNo, DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@wearHouseId", wearHouseId));
                parameter.Add(new KeyValuePair<string, object>("@categoryId", categoryId));
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                parameter.Add(new KeyValuePair<string, object>("@batchNo", batchNo));
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getItemledger]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getStockValuationDetails(int orgId, int categoryId, long itemId)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStcokValuetionProfitValuation]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getStcokValuetionCategory(object MainCategoryName, object companyName, object CategoryName ,object itemName)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@MainCategoryName", MainCategoryName));
                parameter.Add(new KeyValuePair<string, object>("@companyName", companyName));
                parameter.Add(new KeyValuePair<string, object>("@CategoryName", CategoryName));
                parameter.Add(new KeyValuePair<string, object>("@itemName", itemName));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStcokValuetionCategory]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getProfitValuationDetails(int orgId, int categoryId, long itemId)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStcokValuetionProfitValuation]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getItemLedgerDetails(int orgId, int categoryId, long itemId, DateTime fromDate, DateTime toDate,long financialYearID, int Opration)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@Opration", Opration));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getItemLadgerDetails]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getItemLedgerDetailsByMainCategory(int orgId, int categoryId, long itemId, DateTime fromDate, DateTime toDate, long financialYearID, int Opration,string OpType)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                parameter.Add(new KeyValuePair<string, object>("@categoryId", categoryId));
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@Opration", Opration));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                parameter.Add(new KeyValuePair<string, object>("@OpType", OpType));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[USP_GetItemLedgerDetailsByMainCategory]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getItemLedgerDetailsForStockOpeningClosing(int orgId, int categoryId, long itemId, DateTime fromDate, DateTime toDate, long financialYearID, int Opration)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                parameter.Add(new KeyValuePair<string, object>("@categoryId", categoryId));
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@Opration", Opration));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
              //   parameter.Add(new KeyValuePair<string, object>("@OpType", OpType));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[USP_GetItemLedgerForStockOpeningClosing]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }       
        public static DataTable getAvakJavakRegister(int orgId, int categoryId, long itemId,DateTime fromDate,DateTime todate,string opration,long financialYearID)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", todate));
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                parameter.Add(new KeyValuePair<string, object>("@Opration", opration));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));

                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_StockAvakjavakRegister]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getAvakJavakRegisterStockOpeningClosing( DateTime fromDate, DateTime todate, long financialYearID)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", todate));           
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));

                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_StockAvakjavakRegisterStockOpeningClosing]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getProfitRport(int orjId, long itemId, DateTime fromDate, DateTime toDate,long financialYearID, Boolean isQuation)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@orjId", orjId));
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                parameter.Add(new KeyValuePair<string, object>("@isQuation", isQuation));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_ProfitReport]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getSreachStockItem(string searchText)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@searchText", searchText));
               
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStcokRegisterBySearch]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataSet getStockgetAvakJavak(DateTime date,long itemId)
        {
            try
            {
                DataSet dtItem = new DataSet();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@date", date));
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataSet("[dbo].[Usp_getStockAvakJavak]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getAvakJavakRegisterDetails(DateTime date,long itemId)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@date", date));
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStockAvakJavakDetails]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getAvakJavakDate( long itemId)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getAvakJavakDate]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getAvakJavakDateByMainCategory(long itemId, string OpType)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                parameter.Add(new KeyValuePair<string, object>("@OpType", OpType));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getAvakJavakDateByMainCategory]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
          public static DataTable getItemByMainCategory(string mainCategory)
        {
            try
            {
                DataTable dtItem = new DataTable();
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@mainCategory", mainCategory));
                SqlHandler sqlH = new SqlHandler();
                dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getitemDetailsByMainCategory]", parameter);
                return dtItem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
          public static DataTable getpendingChalanDetails(long accountId, DateTime fromDate, DateTime toDate,long financialYearID, int type)
          {
              try
              {
                  DataTable dtpendingChalan = new DataTable();
                  List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                  parameter.Add(new KeyValuePair<string, object>("@accountId", accountId));
                  parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                  parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                  parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                  parameter.Add(new KeyValuePair<string, object>("@type", type));
                  SqlHandler sqlH = new SqlHandler();
                  dtpendingChalan = sqlH.ExecuteAsDataTable("[dbo].[Usp_getPendingChalan]",parameter);
                  return dtpendingChalan;
              }
              catch(Exception ae)
              {
                  throw ae;
              }
          }
          public static DataTable getOrderDetails(long accountId, DateTime fromDate, DateTime toDate,long finacialYearID, int type)
          {
              try
              {
                  try
                  {
                      DataTable dtpendingChalan = new DataTable();
                      List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                      parameter.Add(new KeyValuePair<string, object>("@accountId", accountId));
                      parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                      parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                      parameter.Add(new KeyValuePair<string, object>("@type", type));
                      parameter.Add(new KeyValuePair<string, object>("@finacialYearID", finacialYearID));
                      SqlHandler sqlH = new SqlHandler();
                      dtpendingChalan = sqlH.ExecuteAsDataTable("[dbo].[Usp_getAllOrderDetails]", parameter);
                      return dtpendingChalan;
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

          internal static DataTable GetTempItemDetaits()
          {
              try
              {
                  DataTable dt = new DataTable();
                  SqlHandler sqlH = new SqlHandler();
                  dt = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempItemsDetails]");
                  return dt;
              }
              catch (Exception ex)
              {
                  throw ex;
              }
          }

          public static DataTable getTempItemLedgerDetails(int orgId, int categoryId, long itemId, DateTime fromDate, DateTime toDate, long financialYearID, int Opration)
          {
              try
              {
                  DataTable dtItem = new DataTable();
                  List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                  parameter.Add(new KeyValuePair<string, object>("@itemId", itemId));
                  parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                  parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                  parameter.Add(new KeyValuePair<string, object>("@Opration", Opration));
                  parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                  SqlHandler sqlH = new SqlHandler();
                  dtItem = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTempItemLadgerDetails]", parameter);
                  return dtItem;
              }
              catch (Exception ae)
              {
                  throw ae;
              }
          }
    }
}
