using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using System.Data;

namespace DataAccessLayer.providers
{
    public class godownTransferProvider
    {
        public static DataTable getStockInGodownTransferSearch(string value, string type, string godownName)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@txtSearch", value));
                parameter.Add(new KeyValuePair<string, object>("@type", type));
                parameter.Add(new KeyValuePair<string, object>("@godownName", godownName));
                SqlHandler sqlH = new SqlHandler();
                DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getStockInGodownTransferSearch]", parameter);
                return listi;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getGodowntransferList(DateTime fromDate, DateTime toDate, string type, long FinancialYearID ,long godownTransferId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
                parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
                parameter.Add(new KeyValuePair<string, object>("@type", type));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
                parameter.Add(new KeyValuePair<string, object>("@godownTransferId", godownTransferId));
           
                SqlHandler sqlH = new SqlHandler();
                DataTable listi = sqlH.ExecuteAsDataTable("[dbo].[Usp_getGodowntransferList]", parameter);
                return listi;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static int addGodownTransfer(godownTransfer gm)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@godownTransferId", gm.godownTransferId));
                parameter.Add(new KeyValuePair<string, object>("@godownTransferDate", gm.godownTransferDate));
                parameter.Add(new KeyValuePair<string, object>("@fromGodownTransfer", gm.fromGodownTransfer));
                parameter.Add(new KeyValuePair<string, object>("@toGodownTransfer", gm.toGodownTransfer));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", gm.addedBy));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", gm.addedOn));
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", gm.FinancialYearID));
                parameter.Add(new KeyValuePair<string, object>("@isUpdate", gm.isUpdate));
                parameter.Add(new KeyValuePair<string, object>("@isDelete", gm.isDelete));
                parameter.Add(new KeyValuePair<string, object>("@invoiceId", gm.invoiceId));
                SqlHandler sqlH = new SqlHandler();
                int listi = sqlH.ExecuteNonQueryI("[dbo].[Usp_addGodownTransfer]", parameter);
                int result = 0;
                for (int k = 0; k < gm.dtItems.Rows.Count; k++)
                {
                    List<KeyValuePair<string, object>> parameter1 = new List<KeyValuePair<string, object>>();
                    parameter1.Add(new KeyValuePair<string, object>("@godownTransferId", gm.godownTransferId));
                    parameter1.Add(new KeyValuePair<string, object>("@FinancialYearID", gm.FinancialYearID));
                    parameter1.Add(new KeyValuePair<string, object>("@stockIdFrom", gm.dtItems.Rows[k]["stockId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@stockIdTo", gm.dtItems.Rows[k]["stockIdTo"]));
                    parameter1.Add(new KeyValuePair<string, object>("@itemId", gm.dtItems.Rows[k]["itemId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@categoryId", gm.dtItems.Rows[k]["categoryId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@companyId", gm.dtItems.Rows[k]["companyId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@productCode", gm.dtItems.Rows[k]["productCode"]));
                    parameter1.Add(new KeyValuePair<string, object>("@godownNameto", gm.toGodownTransfer));
                    parameter1.Add(new KeyValuePair<string, object>("@godownNamefrom", gm.fromGodownTransfer));
                    parameter1.Add(new KeyValuePair<string, object>("@batchNo", gm.dtItems.Rows[k]["batchNo"]));
                    parameter1.Add(new KeyValuePair<string, object>("@MFGDate", Convert.ToDateTime(gm.dtItems.Rows[k]["MFD_Date"])));
                    parameter1.Add(new KeyValuePair<string, object>("@exprireDate", Convert.ToDateTime(gm.dtItems.Rows[k]["expireDate"])));
                    parameter1.Add(new KeyValuePair<string, object>("@Quantity", gm.dtItems.Rows[k]["Quantity"]));
                    parameter1.Add(new KeyValuePair<string, object>("@unitBy", gm.dtItems.Rows[k]["unitBy"]));
                    parameter1.Add(new KeyValuePair<string, object>("@godownTransfertemId", gm.dtItems.Rows[k]["godownTransfertemId"]));
                    parameter1.Add(new KeyValuePair<string, object>("@isUpdate", gm.isUpdate));
                    parameter1.Add(new KeyValuePair<string, object>("@isDelete", gm.isDelete));
                    parameter1.Add(new KeyValuePair<string, object>("@addedBy", gm.addedBy));
                    parameter1.Add(new KeyValuePair<string, object>("@addedOn", gm.addedOn));
                    parameter1.Add(new KeyValuePair<string, object>("@invoiceId", gm.invoiceId));
                    result = +sqlH.ExecuteNonQueryI("[dbo].[Usp_addGodownTransferItem]", parameter1);
                }
                return listi + result;
            }
            catch (Exception ae)
            {
                throw ae;
            }//8999501263
        }
    }
}
