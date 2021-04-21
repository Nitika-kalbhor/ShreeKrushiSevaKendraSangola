using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using System.Data;

namespace DataAccessLayer.providers
{
  public  class AssetVoucherProvider
    {
        public static int addAssetVoucher(AssetVoucher account)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@voucherAssetID", account.voucherAssetID));//1
                parameter.Add(new KeyValuePair<string, object>("@InvoiceNo", account.InvoiceNo));//2
                parameter.Add(new KeyValuePair<string, object>("@voucherDate", account.voucherDate));//3
                parameter.Add(new KeyValuePair<string, object>("@transactionId", account.transactionId));//4
                parameter.Add(new KeyValuePair<string, object>("@naveAccountId", account.naveAccountId));//5
                parameter.Add(new KeyValuePair<string, object>("@jamaAccountId", account.jamaAccountId));//6
                parameter.Add(new KeyValuePair<string, object>("@IGST", account.IGST));//7
                parameter.Add(new KeyValuePair<string, object>("@CGST", account.CGST));//8
                parameter.Add(new KeyValuePair<string, object>("@SGST", account.SGST));//9
                parameter.Add(new KeyValuePair<string, object>("@IGSTAmt", account.IGSTAmt));//10
                parameter.Add(new KeyValuePair<string, object>("@CGSTAmt", account.CGSTAmt));//10
                parameter.Add(new KeyValuePair<string, object>("@SGSTAmt", account.SGSTAmt));//11            
                parameter.Add(new KeyValuePair<string, object>("@crAmount", account.crAmount));//12
                parameter.Add(new KeyValuePair<string, object>("@drAmount", account.drAmount));//13
                parameter.Add(new KeyValuePair<string, object>("@GSTRegister", account.GSTRegister));//14
                parameter.Add(new KeyValuePair<string, object>("@isState", account.isState));//15
                parameter.Add(new KeyValuePair<string, object>("@isCash", account.isCash));//16
                parameter.Add(new KeyValuePair<string, object>("@PaymentType", account.PaymentType));//17
                parameter.Add(new KeyValuePair<string, object>("@chqDate", account.chqDate));//18
                parameter.Add(new KeyValuePair<string, object>("@chqDDNo", account.chqDDNo));//19
                parameter.Add(new KeyValuePair<string, object>("@naration", account.naration));//20
                parameter.Add(new KeyValuePair<string, object>("@bankId", account.bankId));//21
                parameter.Add(new KeyValuePair<string, object>("@bankName", account.bankName));//21
                parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));//22
                parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.Now));//23
                parameter.Add(new KeyValuePair<string, object>("@isUpdate", account.isUpdate));//24
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", account.FinancialYearID));//25           
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addAssetVoucher]", parameter);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getAssetVoucher(long FinancialYearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));//1

                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getAssetVoucher]", parameter);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// addExpensesVoucher Data Insert table 
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static int addExpensesVoucher(AssetVoucher account)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@voucherExpensesID", account.voucherAssetID));//1
                parameter.Add(new KeyValuePair<string, object>("@InvoiceNo", account.InvoiceNo));//2
                parameter.Add(new KeyValuePair<string, object>("@ExpensesDate", account.voucherDate));//3
                parameter.Add(new KeyValuePair<string, object>("@transactionId", account.transactionId));//4
                parameter.Add(new KeyValuePair<string, object>("@naveAccountId", account.naveAccountId));//5
                parameter.Add(new KeyValuePair<string, object>("@jamaAccountId", account.jamaAccountId));//6
                parameter.Add(new KeyValuePair<string, object>("@IGST", account.IGST));//7
                parameter.Add(new KeyValuePair<string, object>("@CGST", account.CGST));//8
                parameter.Add(new KeyValuePair<string, object>("@SGST", account.SGST));//9
                parameter.Add(new KeyValuePair<string, object>("@IGSTAmt", account.IGSTAmt));//10
                parameter.Add(new KeyValuePair<string, object>("@CGSTAmt", account.CGSTAmt));//10
                parameter.Add(new KeyValuePair<string, object>("@SGSTAmt", account.SGSTAmt));//11            
                parameter.Add(new KeyValuePair<string, object>("@crAmount", account.crAmount));//12
                parameter.Add(new KeyValuePair<string, object>("@drAmount", account.drAmount));//13
                parameter.Add(new KeyValuePair<string, object>("@GSTRegister", account.GSTRegister));//14
                parameter.Add(new KeyValuePair<string, object>("@isState", account.isState));//15
                parameter.Add(new KeyValuePair<string, object>("@isCash", account.isCash));//16
                parameter.Add(new KeyValuePair<string, object>("@PaymentType", account.PaymentType));//17
                parameter.Add(new KeyValuePair<string, object>("@chqDate", account.chqDate));//18
                parameter.Add(new KeyValuePair<string, object>("@chqDDNo", account.chqDDNo));//19
                parameter.Add(new KeyValuePair<string, object>("@naration", account.naration));//20
                parameter.Add(new KeyValuePair<string, object>("@bankId", account.bankId));//21
                parameter.Add(new KeyValuePair<string, object>("@bankName", account.bankName));//21
                parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));//22
                parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.Now));//23
                parameter.Add(new KeyValuePair<string, object>("@isUpdate", account.isUpdate));//24
                parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", account.FinancialYearID));//25     
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addExpensesVoucher]", parameter);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
