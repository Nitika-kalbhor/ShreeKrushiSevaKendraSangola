using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.providers;
using DataAccessLayer.models;
using System.Data;

namespace DataAccessLayer.controller
{
    public class stockController
    {
        
        public static DataTable getStockDetails(int companyId, int categoryId, long itemId, string type)
        {
            try
            {
                DataTable dtStockDetails = stockRegisterProvider.getStockDetails(companyId, categoryId, itemId, type);
                return dtStockDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getAvakJavakRegisterSummery(string mainCategory, DateTime fromDate, DateTime toDate, long financialYearID)
        {
            try
            {
                DataTable dtItemDetails = stockRegisterProvider.getItemByMainCategory(mainCategory);
                long itemId = 0; int orgId = 0, categoryId = 0;
                DataTable dt = dtAvakJavakRegister();
                if (dtItemDetails.Rows.Count > 0)
                {

                    foreach (DataRow dr in dtItemDetails.Rows)
                    {
                        itemId = Convert.ToInt64(dr["stockID"]);
                        DataTable dtgetAvakJavakDate = stockRegisterProvider.getAvakJavakDate(itemId);
                        DateTime date = fromDate;
                        if (fromDate > Convert.ToDateTime(dtgetAvakJavakDate.Rows[0]["purchaseDate"]))
                        {
                            date = fromDate;
                        }
                        else
                        {
                            date = Convert.ToDateTime(dtgetAvakJavakDate.Rows[0]["purchaseDate"]);
                        }
                        DataTable dtAvakJavakOpenigStock = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "OpeningStock", financialYearID);
                        //while (date <= toDate)
                        //{
                        //foreach (DataRow dr in dtgetAvakJavakDate.Rows)
                        // {
                        // DateTime date = Convert.ToDateTime(dr["purchaseDate"]);
                        //   DataSet dtStockDetails = stockRegisterProvider.getStockgetAvakJavak(date, itemId);
                        DataTable dtAvakJavakDetails = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "AllSaleBitweenDate", financialYearID);
                        if (dtAvakJavakDetails.Rows.Count > 0)
                        {
                            //DataTable dtAvakJavak = stockRegisterProvider.getAvakJavakRegisterDetails(date, itemId);
                            DataTable dtAvakJavak = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "AllyPurchaseBitweenDate", financialYearID);
                            DataTable dtAvakJavakItemDetails = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "getItemDetails", financialYearID);
                            //if (dtAvakJavak.Rows.Count > 0)
                            //{
                            double purchaseStock = 0;
                            string dealerFirmName = "";
                            string purchaseInvoiceId = "";
                            DataRow dtr = dt.NewRow();
                            if (dtAvakJavak.Rows.Count > 0)
                            {
                                purchaseStock = Convert.ToDouble(dtAvakJavak.Rows[0]["Quantity"].ToString());
                                dealerFirmName = "-";
                                purchaseInvoiceId = "-";
                                // dealerFirmName + "-" + "????? ??-" + dtAvakJavak.Rows[0]["purchaseInvoiceId"].ToString() + "-" + "??????-" + dtAvakJavak.Rows[0]["purchaseDate"].ToString();
                                //  dtr["itemId"] = dtAvakJavak.Rows[0]["itemId"].ToString();
                            }
                            dtr["itemName"] = dtAvakJavakItemDetails.Rows[0]["itemName"].ToString();
                            dtr["categoryName"] = dtAvakJavakItemDetails.Rows[0]["categoryName"].ToString();
                            dtr["companyName"] = dtAvakJavakItemDetails.Rows[0]["companyName"].ToString();
                            dtr["batchNo"] = dtAvakJavakItemDetails.Rows[0]["batchNo"].ToString() + '-' + dtAvakJavakItemDetails.Rows[0]["expireDate"].ToString();
                            dtr["weightIn"] = dtAvakJavakItemDetails.Rows[0]["unitBy"].ToString();
                            dtr["unitBy"] = dtAvakJavakItemDetails.Rows[0]["unitBy"].ToString();
                            //if (dt.Rows.Count > 0)
                            //{
                            //    dtr["openingStock"] = Convert.ToDouble(dt.Rows[dt.Rows.Count - 1]["closingStock"].ToString());
                            //}
                            //else
                            //{
                            dtr["openingStock"] = Convert.ToDouble(dtAvakJavakOpenigStock.Rows[0]["openingStock"].ToString());// - purchaseStock + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockIn"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["purchaseReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockOut"].ToString());
                            //}
                            Double PurchQuantity = 0, SaleQuantity = 0;
                            //if (dtAvakJavakDetails.Rows[0]["PurchQuantity"].ToString() == string.Empty)
                            //{
                            //    PurchQuantity = 0 + purchaseStock;
                            //}
                            //else
                            // { 
                            PurchQuantity = purchaseStock;
                            // }
                            if (dtAvakJavakDetails.Rows[0]["SaleQuantity"].ToString() == string.Empty)
                            {
                                SaleQuantity = 0;
                            }
                            else
                            {
                                SaleQuantity = Convert.ToDouble(dtAvakJavakDetails.Rows[0]["SaleQuantity"]);
                            }
                            dtr["currentStock"] = Convert.ToDouble(dtr["openingStock"]) + PurchQuantity;//+ purchaseStock + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockIn"].ToString());
                            dtr["StockIn"] = PurchQuantity;//purchaseStock + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockIn"].ToString());
                            dtr["StockOut"] = SaleQuantity;//Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["purchaseReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockOut"].ToString());
                            dtr["closingStock"] = Convert.ToDouble(dtr["currentStock"]) - Convert.ToDouble(dtr["StockOut"]);
                            dtr["purchaseDate"] = date;
                            dtr["dealerFirmName"] = dealerFirmName;
                            dtr["purchaseInvoice"] = purchaseInvoiceId;
                            dt.Rows.Add(dtr);
                            //for (int i = 1; i < dtAvakJavak.Rows.Count; i++)
                            //{
                            //    DataRow dtr1 = dt.NewRow();
                            //    //  dtr1["itemId"] = dtAvakJavak.Rows[0]["itemId"].ToString();
                            //    dtr1["purchaseInvoice"] = "-";
                            //    dtr1["itemName"] = dtAvakJavak.Rows[i]["itemName"].ToString();
                            //    dtr1["categoryName"] = dtAvakJavak.Rows[i]["categoryName"].ToString();
                            //    dtr1["companyName"] = dtAvakJavak.Rows[i]["companyName"].ToString();
                            //    dtr1["batchNo"] = dtAvakJavak.Rows[i]["batchNo"].ToString() + '-' + dtAvakJavak.Rows[i]["expireDate"].ToString();
                            //    dtr1["openingStock"] = dt.Rows[dt.Rows.Count - 1]["closingStock"].ToString();
                            //    dtr1["currentStock"] = Convert.ToDouble(dtr1["openingStock"]) + Convert.ToDouble(dtAvakJavak.Rows[i]["Quantity"].ToString());
                            //    dtr1["StockIn"] = Convert.ToDouble(dtAvakJavak.Rows[i]["Quantity"].ToString());
                            //    dtr1["StockOut"] = 0;
                            //    dtr1["closingStock"] = Convert.ToDouble(dtr1["currentStock"]) - Convert.ToDouble(dtr1["StockOut"]);
                            //    dtr1["dealerFirmName"] = "-";
                            //    dtr1["weightIn"] = dtAvakJavak.Rows[i]["unitBy"].ToString();
                            //    dtr1["unitBy"] = dtAvakJavak.Rows[i]["unitBy"].ToString();
                            //    dtr1["purchaseDate"] = date;
                            //    dt.Rows.Add(dtr1);
                            //}
                            // }
                            //}
                        }
                    }
                }
                return dt;
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
                DataTable dtStockDetails = stockRegisterProvider.getSreachStockItem(searchText);
                return dtStockDetails;
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getItemByCategory( int categoryId)
        {
            try
            {
                DataTable dtitem = stockRegisterProvider.getItem(categoryId);
                return dtitem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getItemByCategory(int company,int categoryId)
        {
            try
            {
                DataTable dtitem = stockRegisterProvider.getItem(company,categoryId);
                return dtitem;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getIemList(string Opreation, long StockID) 
        {
            try
            {
                return stockRegisterProvider.getIemList(Opreation, StockID);
            }
            catch(Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getReorder()
        {
            try
            {
                return stockRegisterProvider.getReorder();
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getStockValuationDetails(int orgId, int categoryId, long itemId)
        {
            try
            {
                DataTable dtStockDetails = stockRegisterProvider.getStockValuationDetails(orgId, categoryId, itemId);
                return dtStockDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        public static DataTable getStcokValuetionCategory(object MainCategoryName, object companyName, object CategoryName, object itemName)
        {
            try
            {
                DataTable dtStockDetails = stockRegisterProvider.getStcokValuetionCategory(MainCategoryName, companyName, CategoryName, itemName);
                return dtStockDetails;
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
                DataTable dtStockDetails = stockRegisterProvider.getProfitValuationDetails(orgId, categoryId, itemId);
                return dtStockDetails;
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
                DataTable dtStockDetails = stockRegisterProvider.getItemLedgerDetails(orgId, categoryId, itemId, fromDate, toDate,financialYearID, Opration);
                return dtStockDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getItemLedgerDetailsByMainCategory(int orgId, int categoryId, long itemId, DateTime fromDate, DateTime toDate, long financialYearID, int Opration, string OpType)
        {
            try
            {
                DataTable dtStockDetails = stockRegisterProvider.getItemLedgerDetailsByMainCategory(orgId, categoryId, itemId, fromDate, toDate, financialYearID, Opration, OpType);
                return dtStockDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            } 
        }
        //public static DataTable getItemLedgerDetailsForStockOpeningClosing(int orgId, int categoryId, long itemId, DateTime fromDate, DateTime toDate, long financialYearID, int Opration)
        //{
        //    try
        //    {
        //        DataTable dtStockDetails = stockRegisterProvider.getItemLedgerDetailsForStockOpeningClosing(orgId, categoryId, itemId, fromDate, toDate, financialYearID, Opration);
        //        return dtStockDetails;
        //    }
        //    catch (Exception ae)
        //    {
        //        throw ae;
        //    }
        //}
        public static DataTable getAvakJavakRegister(int orgId, int categoryId, long itemId,DateTime fromDate,DateTime toDate,long financialYearID)
        {
            try
            { 
                DataTable dtgetAvakJavakDate = stockRegisterProvider.getAvakJavakDate(itemId);
                
                DataTable dt = dtAvakJavakRegister();
                if (itemId > 0)
                {
                DateTime date=fromDate;
                if (fromDate > Convert.ToDateTime(dtgetAvakJavakDate.Rows[0]["purchaseDate"]))
                {
                    date = fromDate;
                }
                else
                {
                    date = Convert.ToDateTime(dtgetAvakJavakDate.Rows[0]["purchaseDate"]);
                }
                DataTable dtAvakJavakOpenigStock = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "OpeningStock", financialYearID);
                    while (date <= toDate)
                    {
                        //foreach (DataRow dr in dtgetAvakJavakDate.Rows)
                        // {
                        // DateTime date = Convert.ToDateTime(dr["purchaseDate"]);
                     //   DataSet dtStockDetails = stockRegisterProvider.getStockgetAvakJavak(date, itemId);
                        DataTable dtAvakJavakDetails = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "OnlyOneDay", financialYearID);
                        if (dtAvakJavakDetails.Rows.Count > 0)
                        {
                            //DataTable dtAvakJavak = stockRegisterProvider.getAvakJavakRegisterDetails(date, itemId);
                            DataTable dtAvakJavak = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "OnlyOneDayPurchase", financialYearID);
                            DataTable dtAvakJavakItemDetails = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "getItemDetails", financialYearID);
                            //if (dtAvakJavak.Rows.Count > 0)
                            //{
                                double purchaseStock = 0;
                                string dealerFirmName = "";
                                string purchaseInvoiceId = "";
                                DataRow dtr = dt.NewRow();
                                if (dtAvakJavak.Rows.Count > 0)
                                {
                                    if (dtAvakJavak.Rows[0]["Quantity"]==DBNull.Value)
                                    {
                                        purchaseStock = 0;
                                    }
                                    else
                                    {
                                        purchaseStock = Convert.ToDouble(dtAvakJavak.Rows[0]["Quantity"].ToString());
                                    }
                                   
                                    dealerFirmName = dtAvakJavak.Rows[0]["dealerFirmName"].ToString();
                                    purchaseInvoiceId = dealerFirmName + "-" + "पावती नं-" + dtAvakJavak.Rows[0]["purchaseInvoiceId"].ToString() + "-" + "दिनांक-" + dtAvakJavak.Rows[0]["purchaseDate"].ToString();
                                  //  dtr["itemId"] = dtAvakJavak.Rows[0]["itemId"].ToString();
                                  }
                                  dtr["itemName"] = dtAvakJavakItemDetails.Rows[0]["itemName"].ToString();
                                  dtr["categoryName"] = dtAvakJavakItemDetails.Rows[0]["categoryName"].ToString();
                                  dtr["companyName"] = dtAvakJavakItemDetails.Rows[0]["companyName"].ToString();
                                  dtr["batchNo"] = dtAvakJavakItemDetails.Rows[0]["batchNo"].ToString() + '-' + dtAvakJavakItemDetails.Rows[0]["expireDate"].ToString();
                                  dtr["weightIn"] = dtAvakJavakItemDetails.Rows[0]["unitBy"].ToString();
                                  dtr["unitBy"] = dtAvakJavakItemDetails.Rows[0]["unitBy"].ToString(); 
                                if(dt.Rows.Count>0)
                                 {
                                     if (dt.Rows[dt.Rows.Count - 1]["closingStock"] == DBNull.Value)
                                     {
                                         dtr["openingStock"] = 0;
                                     }
                                     else
                                     {
                                         dtr["openingStock"] = Convert.ToDouble(dt.Rows[dt.Rows.Count - 1]["closingStock"].ToString());
                                     }
                                    
                                 }
                                 else
                                 {
                                     if (dtAvakJavakOpenigStock.Rows[0]["openingStock"] != DBNull.Value)
                                     {
                                         dtr["openingStock"] = Convert.ToDouble(dtAvakJavakOpenigStock.Rows[0]["openingStock"].ToString());
                                     }
                                     else
                                     {
                                         dtr["openingStock"] = 0;
                                     }// - purchaseStock + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockIn"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["purchaseReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockOut"].ToString());
                                 }
                                 Double PurchQuantity = 0, SaleQuantity = 0;
                                 if (dtAvakJavakDetails.Rows[0]["PurchQuantity"] == DBNull.Value)
                                 {
                                     PurchQuantity = 0 + purchaseStock;
                                 }
                                 else { PurchQuantity = Convert.ToDouble(dtAvakJavakDetails.Rows[0]["PurchQuantity"]) + purchaseStock; }
                                 if (dtAvakJavakDetails.Rows[0]["SaleQuantity"] == DBNull.Value)
                                 { 
                                     SaleQuantity=0;
                                 }
                                 else { SaleQuantity = Convert.ToDouble(dtAvakJavakDetails.Rows[0]["SaleQuantity"]); }
                                 dtr["currentStock"] = Convert.ToDouble(dtr["openingStock"]) + PurchQuantity;//+ purchaseStock + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockIn"].ToString());
                                     dtr["StockIn"] = PurchQuantity;//purchaseStock + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockIn"].ToString());
                                     dtr["StockOut"] = SaleQuantity;//Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["purchaseReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockOut"].ToString());
                                     dtr["closingStock"] = Convert.ToDouble(dtr["currentStock"])- Convert.ToDouble(dtr["StockOut"]);
                                dtr["purchaseDate"] = date;
                                dtr["dealerFirmName"] = dealerFirmName;
                                dtr["purchaseInvoice"] = purchaseInvoiceId;
                                dt.Rows.Add(dtr);
                               for(int i=1;i<dtAvakJavak.Rows.Count;i++)
                                {
                                    DataRow dtr1 = dt.NewRow();
                                  //  dtr1["itemId"] = dtAvakJavak.Rows[0]["itemId"].ToString();
                                    dtr1["purchaseInvoice"] = dealerFirmName + "-" + "पावती नं-" + dtAvakJavak.Rows[i]["purchaseInvoiceId"].ToString() + "-" + "दिनांक-" + dtAvakJavak.Rows[i]["purchaseDate"].ToString();
                                    dtr1["itemName"] = dtAvakJavak.Rows[i]["itemName"].ToString();
                                    dtr1["categoryName"] = dtAvakJavak.Rows[i]["categoryName"].ToString();
                                    dtr1["companyName"] = dtAvakJavak.Rows[i]["companyName"].ToString();
                                    dtr1["batchNo"] = dtAvakJavak.Rows[i]["batchNo"].ToString() + '-' + dtAvakJavak.Rows[i]["expireDate"].ToString();
                                    dtr1["openingStock"] = dt.Rows[dt.Rows.Count-1]["closingStock"].ToString();
                                    dtr1["currentStock"] = Convert.ToDouble(dtr1["openingStock"]) + Convert.ToDouble(dtAvakJavak.Rows[i]["Quantity"].ToString());
                                    dtr1["StockIn"] = Convert.ToDouble(dtAvakJavak.Rows[i]["Quantity"].ToString());
                                    dtr1["StockOut"] = 0;
                                    dtr1["closingStock"] = Convert.ToDouble(dtr1["currentStock"]) - Convert.ToDouble(dtr1["StockOut"]);
                                    dtr1["dealerFirmName"] = dtAvakJavak.Rows[i]["dealerFirmName"].ToString();
                                    dtr1["weightIn"] = dtAvakJavak.Rows[i]["unitBy"].ToString();
                                    dtr1["unitBy"] = dtAvakJavak.Rows[i]["unitBy"].ToString(); 
                                    dtr1["purchaseDate"] = date;
                                    dt.Rows.Add(dtr1);
                                }
                       // }
                            //}
                        }
                            date = date.AddDays(1);
                        
                    }
                }
                return dt;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getAvakJavakRegister(int orgId, int categoryId, long itemId, DateTime fromDate, DateTime toDate, long financialYearID, string OpType)
        {
            try
            {
                DataTable dtgetAvakJavakDate = stockRegisterProvider.getAvakJavakDate(itemId);

                DataTable dt = dtAvakJavakRegister();
                if (itemId > 0)
                {
                    DateTime date = fromDate;
                    if (dtgetAvakJavakDate.Rows.Count!=0)
                    {
                        if (fromDate > Convert.ToDateTime(dtgetAvakJavakDate.Rows[0]["purchaseDate"]))
                        {
                            date = fromDate;
                        }
                        else
                        {
                            date = Convert.ToDateTime(dtgetAvakJavakDate.Rows[0]["purchaseDate"]);
                        }
                    }
                    DataTable dtAvakJavakOpenigStock = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "OpeningStock", financialYearID);
                    while (date <= toDate)
                    {

                        DataTable dtAvakJavakDetails = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "OnlyOneDay", financialYearID);
                        if (dtAvakJavakDetails.Rows.Count > 0)
                        {
                            //DataTable dtAvakJavak = stockRegisterProvider.getAvakJavakRegisterDetails(date, itemId);
                            DataTable dtAvakJavak = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "OnlyOneDayPurchase", financialYearID);
                            DataTable dtAvakJavakItemDetails = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "getItemDetails", financialYearID);
                            //if (dtAvakJavak.Rows.Count > 0)
                            //{
                            double purchaseStock = 0;
                            string dealerFirmName = "";
                            string purchaseInvoiceId = "";
                            DataRow dtr = dt.NewRow();
                            if (dtAvakJavak.Rows.Count > 0)
                            {
                                if (dtAvakJavak.Rows[0]["Quantity"] == DBNull.Value)
                                {
                                    purchaseStock = 0;
                                }
                                else
                                {
                                    purchaseStock = Convert.ToDouble(dtAvakJavak.Rows[0]["Quantity"].ToString());
                                }

                                dealerFirmName = dtAvakJavak.Rows[0]["dealerFirmName"].ToString();
                                purchaseInvoiceId = dealerFirmName + "-" + "पावती नं-" + dtAvakJavak.Rows[0]["purchaseInvoiceId"].ToString() + "-" + "दिनांक-" + dtAvakJavak.Rows[0]["purchaseDate"].ToString();
                                //  dtr["itemId"] = dtAvakJavak.Rows[0]["itemId"].ToString();
                            }
                            dtr["itemName"] = dtAvakJavakItemDetails.Rows[0]["itemName"].ToString();
                            dtr["categoryName"] = dtAvakJavakItemDetails.Rows[0]["categoryName"].ToString();
                            dtr["companyName"] = dtAvakJavakItemDetails.Rows[0]["companyName"].ToString();
                            dtr["batchNo"] = dtAvakJavakItemDetails.Rows[0]["batchNo"].ToString() + '-' + dtAvakJavakItemDetails.Rows[0]["expireDate"].ToString();
                            dtr["weightIn"] = dtAvakJavakItemDetails.Rows[0]["unitBy"].ToString();
                            dtr["unitBy"] = dtAvakJavakItemDetails.Rows[0]["unitBy"].ToString();
                            if (dt.Rows.Count > 0)
                            {
                                if (dt.Rows[dt.Rows.Count - 1]["closingStock"] == DBNull.Value)
                                {
                                    dtr["openingStock"] = 0;
                                }
                                else
                                {
                                    dtr["openingStock"] = Convert.ToDouble(dt.Rows[dt.Rows.Count - 1]["closingStock"].ToString());
                                }

                            }
                            else
                            {
                                if (dtAvakJavakOpenigStock.Rows[0]["openingStock"] != DBNull.Value)
                                {
                                    dtr["openingStock"] = Convert.ToDouble(dtAvakJavakOpenigStock.Rows[0]["openingStock"].ToString());
                                }
                                else
                                {
                                    dtr["openingStock"] = 0;
                                }// - purchaseStock + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockIn"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["purchaseReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockOut"].ToString());
                            }
                            Double PurchQuantity = 0, SaleQuantity = 0;
                            if (dtAvakJavakDetails.Rows[0]["PurchQuantity"] == DBNull.Value)
                            {
                                PurchQuantity = 0 + purchaseStock;
                            }
                            else { PurchQuantity = Convert.ToDouble(dtAvakJavakDetails.Rows[0]["PurchQuantity"]) + purchaseStock; }
                            if (dtAvakJavakDetails.Rows[0]["SaleQuantity"] == DBNull.Value)
                            {
                                SaleQuantity = 0;
                            }
                            else { SaleQuantity = Convert.ToDouble(dtAvakJavakDetails.Rows[0]["SaleQuantity"]); }
                            dtr["currentStock"] = Convert.ToDouble(dtr["openingStock"]) + PurchQuantity;//+ purchaseStock + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockIn"].ToString());
                            dtr["StockIn"] = PurchQuantity;//purchaseStock + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockIn"].ToString());
                            dtr["StockOut"] = SaleQuantity;//Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["purchaseReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockOut"].ToString());
                            dtr["closingStock"] = Convert.ToDouble(dtr["currentStock"]) - Convert.ToDouble(dtr["StockOut"]);
                            dtr["purchaseDate"] = date;
                            dtr["dealerFirmName"] = dealerFirmName;
                            dtr["purchaseInvoice"] = purchaseInvoiceId;
                            dt.Rows.Add(dtr);
                            for (int i = 1; i < dtAvakJavak.Rows.Count; i++)
                            {
                                DataRow dtr1 = dt.NewRow();
                                //  dtr1["itemId"] = dtAvakJavak.Rows[0]["itemId"].ToString();
                                dtr1["purchaseInvoice"] = dealerFirmName + "-" + "पावती नं-" + dtAvakJavak.Rows[i]["purchaseInvoiceId"].ToString() + "-" + "दिनांक-" + dtAvakJavak.Rows[i]["purchaseDate"].ToString();
                                dtr1["itemName"] = dtAvakJavak.Rows[i]["itemName"].ToString();
                                dtr1["categoryName"] = dtAvakJavak.Rows[i]["categoryName"].ToString();
                                dtr1["companyName"] = dtAvakJavak.Rows[i]["companyName"].ToString();
                                dtr1["batchNo"] = dtAvakJavak.Rows[i]["batchNo"].ToString() + '-' + dtAvakJavak.Rows[i]["expireDate"].ToString();
                                dtr1["openingStock"] = dt.Rows[dt.Rows.Count - 1]["closingStock"].ToString();
                                dtr1["currentStock"] = Convert.ToDouble(dtr1["openingStock"]) + Convert.ToDouble(dtAvakJavak.Rows[i]["Quantity"].ToString());
                                dtr1["StockIn"] = Convert.ToDouble(dtAvakJavak.Rows[i]["Quantity"].ToString());
                                dtr1["StockOut"] = 0;
                                dtr1["closingStock"] = Convert.ToDouble(dtr1["currentStock"]) - Convert.ToDouble(dtr1["StockOut"]);
                                dtr1["dealerFirmName"] = dtAvakJavak.Rows[i]["dealerFirmName"].ToString();
                                dtr1["weightIn"] = dtAvakJavak.Rows[i]["unitBy"].ToString();
                                dtr1["unitBy"] = dtAvakJavak.Rows[i]["unitBy"].ToString();
                                dtr1["purchaseDate"] = date;
                                dt.Rows.Add(dtr1);
                            }
                            // }
                            //}
                        }
                        date = date.AddDays(1);

                    }
                }
                return dt;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getAvakJavakRegisterByMainCategory(int orgId, int categoryId, long itemId, DateTime fromDate, DateTime toDate, long financialYearID, string OpType)
        {
            try
            {
                DataTable dtgetAvakJavakDate = stockRegisterProvider.getAvakJavakDate(itemId);

                DataTable dt = dtAvakJavakRegister();
                if (itemId > 0)
                {
                    DateTime date = fromDate;
                      if (fromDate > Convert.ToDateTime(dtgetAvakJavakDate.Rows[0]["purchaseDate"]))
                        {
                            date = fromDate;
                        }
                        else
                        {
                            date = Convert.ToDateTime(dtgetAvakJavakDate.Rows[0]["purchaseDate"]);
                        }                  
                    DataTable dtAvakJavakOpenigStock = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "OpeningStock", financialYearID);
                    while (date <= toDate)
                    {

                        DataTable dtAvakJavakDetails = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "OnlyOneDay", financialYearID);
                        if (dtAvakJavakDetails.Rows.Count > 0)
                        {
                            //DataTable dtAvakJavak = stockRegisterProvider.getAvakJavakRegisterDetails(date, itemId);
                            DataTable dtAvakJavak = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "OnlyOneDayPurchase", financialYearID);
                            DataTable dtAvakJavakItemDetails = stockRegisterProvider.getAvakJavakRegister(orgId, categoryId, itemId, date, toDate, "getItemDetails", financialYearID);
                            //if (dtAvakJavak.Rows.Count > 0)
                            //{
                            double purchaseStock = 0;
                            string dealerFirmName = "";
                            string purchaseInvoiceId = "";
                            DataRow dtr = dt.NewRow();
                            if (dtAvakJavak.Rows.Count > 0)
                            {
                                if (dtAvakJavak.Rows[0]["Quantity"] == DBNull.Value)
                                {
                                    purchaseStock = 0;
                                }
                                else
                                {
                                    purchaseStock = Convert.ToDouble(dtAvakJavak.Rows[0]["Quantity"].ToString());
                                }

                                dealerFirmName = dtAvakJavak.Rows[0]["dealerFirmName"].ToString();
                                purchaseInvoiceId = dealerFirmName + "-" + "पावती नं-" + dtAvakJavak.Rows[0]["purchaseInvoiceId"].ToString() + "-" + "दिनांक-" + dtAvakJavak.Rows[0]["purchaseDate"].ToString();
                                //  dtr["itemId"] = dtAvakJavak.Rows[0]["itemId"].ToString();
                            }
                            dtr["itemName"] = dtAvakJavakItemDetails.Rows[0]["itemName"].ToString();
                            dtr["categoryName"] = dtAvakJavakItemDetails.Rows[0]["categoryName"].ToString();
                            dtr["companyName"] = dtAvakJavakItemDetails.Rows[0]["companyName"].ToString();
                            dtr["batchNo"] = dtAvakJavakItemDetails.Rows[0]["batchNo"].ToString() + '-' + dtAvakJavakItemDetails.Rows[0]["expireDate"].ToString();
                            dtr["weightIn"] = dtAvakJavakItemDetails.Rows[0]["unitBy"].ToString();
                            dtr["unitBy"] = dtAvakJavakItemDetails.Rows[0]["unitBy"].ToString();
                            if (dt.Rows.Count > 0)
                            {
                                if (dt.Rows[dt.Rows.Count - 1]["closingStock"] == DBNull.Value)
                                {
                                    dtr["openingStock"] = 0;
                                }
                                else
                                {
                                    dtr["openingStock"] = Convert.ToDouble(dt.Rows[dt.Rows.Count - 1]["closingStock"].ToString());
                                }

                            }
                            else
                            {
                                if (dtAvakJavakOpenigStock.Rows[0]["openingStock"] != DBNull.Value)
                                {
                                    dtr["openingStock"] = Convert.ToDouble(dtAvakJavakOpenigStock.Rows[0]["openingStock"].ToString());
                                }
                                else
                                {
                                    dtr["openingStock"] = 0;
                                }// - purchaseStock + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockIn"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["purchaseReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockOut"].ToString());
                            }
                            Double PurchQuantity = 0, SaleQuantity = 0;
                            if (dtAvakJavakDetails.Rows[0]["PurchQuantity"] == DBNull.Value)
                            {
                                PurchQuantity = 0 + purchaseStock;
                            }
                            else { PurchQuantity = Convert.ToDouble(dtAvakJavakDetails.Rows[0]["PurchQuantity"]) + purchaseStock; }
                            if (dtAvakJavakDetails.Rows[0]["SaleQuantity"] == DBNull.Value)
                            {
                                SaleQuantity = 0;
                            }
                            else { SaleQuantity = Convert.ToDouble(dtAvakJavakDetails.Rows[0]["SaleQuantity"]); }
                            dtr["currentStock"] = Convert.ToDouble(dtr["openingStock"]) + PurchQuantity;//+ purchaseStock + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockIn"].ToString());
                            dtr["StockIn"] = PurchQuantity;//purchaseStock + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockIn"].ToString());
                            dtr["StockOut"] = SaleQuantity;//Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["purchaseReturnStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["saleStock"].ToString()) + Convert.ToDouble(dtStockDetails.Tables[1].Rows[0]["stockOut"].ToString());
                            dtr["closingStock"] = Convert.ToDouble(dtr["currentStock"]) - Convert.ToDouble(dtr["StockOut"]);
                            dtr["purchaseDate"] = date;
                            dtr["dealerFirmName"] = dealerFirmName;
                            dtr["purchaseInvoice"] = purchaseInvoiceId;
                            dt.Rows.Add(dtr);
                            for (int i = 1; i < dtAvakJavak.Rows.Count; i++)
                            {
                                DataRow dtr1 = dt.NewRow();
                                //  dtr1["itemId"] = dtAvakJavak.Rows[0]["itemId"].ToString();
                                dtr1["purchaseInvoice"] = dealerFirmName + "-" + "पावती नं-" + dtAvakJavak.Rows[i]["purchaseInvoiceId"].ToString() + "-" + "दिनांक-" + dtAvakJavak.Rows[i]["purchaseDate"].ToString();
                                dtr1["itemName"] = dtAvakJavak.Rows[i]["itemName"].ToString();
                                dtr1["categoryName"] = dtAvakJavak.Rows[i]["categoryName"].ToString();
                                dtr1["companyName"] = dtAvakJavak.Rows[i]["companyName"].ToString();
                                dtr1["batchNo"] = dtAvakJavak.Rows[i]["batchNo"].ToString() + '-' + dtAvakJavak.Rows[i]["expireDate"].ToString();
                                dtr1["openingStock"] = dt.Rows[dt.Rows.Count - 1]["closingStock"].ToString();
                                dtr1["currentStock"] = Convert.ToDouble(dtr1["openingStock"]) + Convert.ToDouble(dtAvakJavak.Rows[i]["Quantity"].ToString());
                                dtr1["StockIn"] = Convert.ToDouble(dtAvakJavak.Rows[i]["Quantity"].ToString());
                                dtr1["StockOut"] = 0;
                                dtr1["closingStock"] = Convert.ToDouble(dtr1["currentStock"]) - Convert.ToDouble(dtr1["StockOut"]);
                                dtr1["dealerFirmName"] = dtAvakJavak.Rows[i]["dealerFirmName"].ToString();
                                dtr1["weightIn"] = dtAvakJavak.Rows[i]["unitBy"].ToString();
                                dtr1["unitBy"] = dtAvakJavak.Rows[i]["unitBy"].ToString();
                                dtr1["purchaseDate"] = date;
                                dt.Rows.Add(dtr1);
                            }
                            // }
                            //}
                        }
                        date = date.AddDays(1);

                    }
                }
                return dt;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getAvakJavakRegisterStockOpeningClosing( DateTime fromDate, DateTime toDate, long financialYearID)
        {
            try
            {
               
                DataTable dt = stockRegisterProvider.getAvakJavakRegisterStockOpeningClosing(fromDate, toDate, financialYearID);
                dt.Rows[0].Delete();
                DataTable dtAvakJavakOpenigStock = dt;
                dtAvakJavakOpenigStock.Columns.Add("openingStockWithDate", typeof(string));
                dtAvakJavakOpenigStock.Columns.Add("closingStockWithDate", typeof(string));
                for (int i = 1; i < dtAvakJavakOpenigStock.Rows.Count; i++)
                {
                    dtAvakJavakOpenigStock.Rows[i]["openingStockWithDate"] = dtAvakJavakOpenigStock.Rows[i]["OpeningStock"].ToString()+" - "+dtAvakJavakOpenigStock.Rows[i]["OpeningDate"].ToString();
                     dtAvakJavakOpenigStock.Rows[i]["closingStockWithDate"] = dtAvakJavakOpenigStock.Rows[i]["ClosingStock"].ToString()+" - "+dtAvakJavakOpenigStock.Rows[i]["ClosingDate"].ToString();                   
                }              
                return dtAvakJavakOpenigStock;
         
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getProfitRport(int orgId, long itemId, DateTime fromDate, DateTime toDate,long financialYearID, Boolean isQuation)
        {
            try
            {
                DataTable dtStockDetails = stockRegisterProvider.getProfitRport(orgId, itemId, fromDate, toDate,financialYearID, isQuation);
                return dtStockDetails;
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
                DataTable dtStockDetails = stockRegisterProvider.getItemByMainCategory(mainCategory);
                return dtStockDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getpendingChalanDetails(long accountId,DateTime fromDate,DateTime toDate,long financialYearID, int type)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = stockRegisterProvider.getpendingChalanDetails(accountId, fromDate, toDate, financialYearID,type);
                return dt;
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getOrderDetails(long accountId,DateTime fromDate,DateTime toDate,long finacialYearID,int type)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = stockRegisterProvider.getOrderDetails(accountId, fromDate, toDate,finacialYearID, type);
                return dt;
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }
        public static  DataTable dtAvakJavakRegister()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("itemId",typeof(long));
            dt.Columns.Add("itemName", typeof(string));
            dt.Columns.Add("categoryName", typeof(string));
            dt.Columns.Add("companyName", typeof(string));
            dt.Columns.Add("batchNo", typeof(string));
            dt.Columns.Add("openingStock", typeof(double));
            dt.Columns.Add("currentStock", typeof(double));
          dt.Columns.Add("StockIn", typeof(double));
          dt.Columns.Add("StockOut", typeof(double));
          dt.Columns.Add("closingStock", typeof(double));
             dt.Columns.Add("purchaseDate", typeof(DateTime));
             dt.Columns.Add("dealerFirmName", typeof(string));
             dt.Columns.Add("purchaseInvoice", typeof(string));
             dt.Columns.Add("weightIn", typeof(string));
             dt.Columns.Add("unitBy", typeof(string));
             return dt;
        }
        public static DataTable getItemLedgerSummeryDetails(DateTime fromDate, DateTime toDate, long financialYearID)
        {
            try
            {
                DataTable dtItemDetails = stockController.getItemLedgerDetails(0, 0, 0, fromDate, toDate, financialYearID, 4);

                DataTable dtAllStock = new DataTable();
                for (int i = 0; i < dtItemDetails.Rows.Count; i++)
                {
                    DataTable dtBillditals = stockController.getItemLedgerDetails(0, 0, Convert.ToInt64(dtItemDetails.Rows[i]["itemId"].ToString()), fromDate, toDate, financialYearID, 5);
                    string billNo = "";
                    if (dtBillditals.Rows.Count > 0)
                    {
                        if (dtBillditals.Rows[0]["FirstBillno"] != null && dtBillditals.Rows[1]["Lastbillno"] != null)
                        {
                            if (dtBillditals.Rows[0]["FirstBillno"].ToString() == dtBillditals.Rows[1]["Lastbillno"].ToString())
                            {
                                billNo = dtBillditals.Rows[0]["FirstBillno"].ToString();
                            }
                            else
                            {
                                billNo = dtBillditals.Rows[0]["FirstBillno"].ToString() + '-' + dtBillditals.Rows[1]["Lastbillno"].ToString();
                            }
                        }
                        else
                        {
                            billNo = "";
                        }
                    }
                    System.Data.DataTable dtOpeningStock = stockController.getAvakJavakRegister(0, 0, Convert.ToInt64(dtItemDetails.Rows[i]["itemId"].ToString()), fromDate, toDate, financialYearID);
                    dtOpeningStock.Columns.Add("BillNo", typeof(string));
                    dtOpeningStock.Rows[0]["BillNo"] = billNo;
                    dtAllStock.Merge(dtOpeningStock);
                }
                return dtAllStock;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        public static DataTable GetTempItemDetaits()
        {
            try
            {
                DataTable dt = stockRegisterProvider.GetTempItemDetaits();
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
                DataTable dtStockDetails = stockRegisterProvider.getTempItemLedgerDetails(orgId, categoryId, itemId, fromDate, toDate, financialYearID, Opration);
                return dtStockDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getItemLedgerDetailsByMainCategory(string OpType, DateTime fromDate, DateTime toDate, long financialYearID)
        {
            try
            {
                DataTable dtItemDetails = stockController.getItemLedgerDetailsByMainCategory(0, 0, 0, fromDate, toDate, financialYearID, 1, OpType);

                DataTable dtAllStock = new DataTable();
                for (int i = 0; i < dtItemDetails.Rows.Count; i++)
                {
                    DataTable dtBillditals = stockController.getItemLedgerDetailsByMainCategory(0, 0, Convert.ToInt64(dtItemDetails.Rows[i]["itemId"].ToString()), fromDate, toDate, financialYearID, 2, OpType);
                    string billNo = "";
                    if (dtBillditals.Rows.Count > 0)
                    {
                        if (dtBillditals.Rows[0]["FirstBillno"] != null && dtBillditals.Rows[1]["Lastbillno"] != null)
                        {
                            if (dtBillditals.Rows[0]["FirstBillno"].ToString() == dtBillditals.Rows[1]["Lastbillno"].ToString())
                            {
                                billNo = dtBillditals.Rows[0]["FirstBillno"].ToString();
                            }
                            else
                            {
                                billNo = dtBillditals.Rows[0]["FirstBillno"].ToString() + '-' + dtBillditals.Rows[1]["Lastbillno"].ToString();
                            }
                        }
                        else
                        {
                            billNo = "";
                        }
                    }
                    System.Data.DataTable dtOpeningStock = stockController.getAvakJavakRegisterByMainCategory(0, 0, Convert.ToInt64(dtItemDetails.Rows[i]["itemId"].ToString()), fromDate, toDate, financialYearID, OpType);
                    dtOpeningStock.Columns.Add("BillNo", typeof(string));
                    dtOpeningStock.Rows[0]["BillNo"] = billNo;
                    dtAllStock.Merge(dtOpeningStock);
                }
                return dtAllStock;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        //public static DataTable getItemLedgerDetailsForStockOpeningClosing(DateTime fromDate, DateTime toDate, long financialYearID)
        //{
        //    try
        //    {
        //        System.Data.DataTable dtOpeningStock = stockController.getAvakJavakRegisterStockOpeningClosing(fromDate, toDate, financialYearID);
        //        return dtOpeningStock;
        //        DataTable dtItemDetails = stockController.getItemLedgerDetailsForStockOpeningClosing(0, 0, 0, fromDate, toDate, financialYearID, 1);

        //        DataTable dtAllStock = new DataTable();
        //        for (int i = 0; i < dtItemDetails.Rows.Count; i++)
        //        {
        //            DataTable dtBillditals = stockController.getItemLedgerDetailsForStockOpeningClosing(0, 0, Convert.ToInt64(dtItemDetails.Rows[i]["itemId"].ToString()), fromDate, toDate, financialYearID, 2);
        //            string billNo = "";
        //            if (dtBillditals.Rows.Count > 0)
        //            {
        //                if (dtBillditals.Rows[0]["FirstBillno"] != null && dtBillditals.Rows[1]["Lastbillno"] != null)
        //                {
        //                    if (dtBillditals.Rows[0]["FirstBillno"].ToString() == dtBillditals.Rows[1]["Lastbillno"].ToString())
        //                    {
        //                        billNo = dtBillditals.Rows[0]["FirstBillno"].ToString();
        //                    }
        //                    else
        //                    {
        //                        billNo = dtBillditals.Rows[0]["FirstBillno"].ToString() + '-' + dtBillditals.Rows[1]["Lastbillno"].ToString();
        //                    }
        //                }
        //                else
        //                {
        //                    billNo = "";
        //                }
        //            }
        //            System.Data.DataTable dtOpeningStock = stockController.getAvakJavakRegisterStockOpeningClosing(0, 0, Convert.ToInt64(dtItemDetails.Rows[i]["itemId"].ToString()), fromDate, toDate, financialYearID);
        //            dtOpeningStock.Columns.Add("BillNo", typeof(string));
        //            dtOpeningStock.Rows[0]["BillNo"] = billNo;
        //            dtAllStock.Merge(dtOpeningStock);
        //        }
        //        return dtAllStock;
        //    }
        //    catch (Exception ae)
        //    {
        //        throw ae;
        //    }
        //}
    }
}
