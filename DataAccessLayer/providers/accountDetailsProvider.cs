using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.providers
{
   public class accountDetailsProvider
   {
       #region defination & declaration
       private static string _connectionString = SystemSetting.ConnectionString;
       #endregion
       public static DataTable getAccountDetailsForAccountGroup()
       {
           try
           {
               SqlHandler sqlH = new SqlHandler();
               DataTable dt = sqlH.ExecuteAsDataTable("Usp_getAccountDetailsForAccountGroup");
               return dt;
           }
           catch(Exception ex)
           {
               throw ex;
           }
       }

       public static int addAcountDetails(AccountDetails account)
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
               parameter.Add(new KeyValuePair<string, object>("@accountTypeId", account.accountTypeId));//1
               parameter.Add(new KeyValuePair<string, object>("@accountGroupId", account.accountGroupId));//2
               parameter.Add(new KeyValuePair<string, object>("@accountSubGroupId", account.accountSubGroupId));//2
               parameter.Add(new KeyValuePair<string, object>("@accountName", account.accountName));//3
               parameter.Add(new KeyValuePair<string, object>("@isCustomerSupplier", account.isCustomerSupplier));//4
               parameter.Add(new KeyValuePair<string, object>("@isbank", account.isActive));//5
               parameter.Add(new KeyValuePair<string, object>("@accountNo", account.accountNo));//6
               parameter.Add(new KeyValuePair<string, object>("@openigBalanace", account.openigBalanace));//7
               parameter.Add(new KeyValuePair<string, object>("@isCreditDebit", account.isCreditDebit));//8
               if (account.isCreditDebit == "जमा रक्कम")
               {
                   account.crAmount = 0;
                   account.drAmount = account.openigBalanace;
                 
               }
               if (account.isCreditDebit == "नावे रक्कम")
               {
                   account.crAmount = account.openigBalanace;
                   account.drAmount = 0;
               }
               parameter.Add(new KeyValuePair<string, object>("@crAmount", account.crAmount));//9
               parameter.Add(new KeyValuePair<string, object>("@drAmount", account.drAmount));//10
               parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));//11
               parameter.Add(new KeyValuePair<string, object>("@addedOn", account.addedOn));//12
               parameter.Add(new KeyValuePair<string, object>("@accountGSTNO", account.accountGSTNO));//12
               parameter.Add(new KeyValuePair<string, object>("@MobileNo", account.MobileNo));//12
               parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", account.FinancialYearID));//12
         //      parameter.Add(new KeyValuePair<string, object>("@accountGSTNO", account.accountGSTNO));//13
             
               int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addAccountDetails]", parameter,Conn,trans);

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
       #region Payment Voucher
       /// <summary>
       /// Payment Voucher Add 
       /// </summary>
       /// <returns></returns>
       public static DataTable getaccountName(int accountGroupId)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@accountGroupId", accountGroupId));//1
               SqlHandler sqH = new SqlHandler();
               DataTable accountList = sqH.ExecuteAsDataTable("[dbo].[Usp_getaccountName]",parameter);
               return accountList;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable GetAccountGroup()
       {
           try
           {
             
               SqlHandler sqH = new SqlHandler();
               DataTable GetAccountGrouplst = sqH.ExecuteAsDataTable("[dbo].[Usp_GetAccountGroup]");
               return GetAccountGrouplst;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
        public static DataTable getPaymentReceiptTransaction(long financialyearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialyearID));
                SqlHandler sqH = new SqlHandler();
                DataTable PaymentReceiptTransaction = sqH.ExecuteAsDataTable("[dbo].[Usp_getPaymentReceiptTransaction]", parameter);
                return PaymentReceiptTransaction;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static DataTable getPaymentVoucherTransaction(long financialYearID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                SqlHandler sqH = new SqlHandler();
                DataTable PaymentVoucherTransaction = sqH.ExecuteAsDataTable("[dbo].[Usp_getPaymentVoucherTransaction]", parameter);
                return PaymentVoucherTransaction;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
        public static double getPaymentDueAmount(long accountId)
       {
           try
           {
               
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@accountId", accountId));           
               SqlHandler sqH = new SqlHandler();
                double crDrAmount= sqH.ExecuteAsScalar("[dbo].[Usp_getPaymentDueAmount]", parameter);
                return crDrAmount;
           }
           catch(Exception ex)
           {
               throw ex;
           }
       }
        public static int VoucherPaymentDelete(long paymentVoucherId, long financialYearID)
        {
            try
            {

                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@paymentVoucherId", paymentVoucherId));
                parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
                SqlHandler sqH = new SqlHandler();
                int i = sqH.ExecuteNonQueryI("[dbo].[Usp_VoucherPaymentDelete]", parameter);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static long getMaxIdPaymentVoucherId(long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqH = new SqlHandler();

               long paymentVoucherId = sqH.ExecuteAsScalarLong("[dbo].[Usp_getMaxIdPaymentVoucherId]", parameter);
               return paymentVoucherId;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static int addPaymentVoucher(PaymentVoucher pamentV)
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
               parameter.Add(new KeyValuePair<string, object>("@paymentVoucherId", pamentV.paymentVoucherId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", pamentV.financialYearID));
               parameter.Add(new KeyValuePair<string, object>("@accountId", pamentV.accountId));
               parameter.Add(new KeyValuePair<string, object>("@voucherDate", pamentV.voucherDate));              
               parameter.Add(new KeyValuePair<string, object>("@drAmount", pamentV.drAmount));           
               parameter.Add(new KeyValuePair<string, object>("@paymentType", pamentV.paymentType));
               parameter.Add(new KeyValuePair<string, object>("@bankId", pamentV.bankId));
               parameter.Add(new KeyValuePair<string, object>("@bankName", pamentV.bankName));
               parameter.Add(new KeyValuePair<string, object>("@chequeNo_refNo", pamentV.chequeNo_refNo));
               parameter.Add(new KeyValuePair<string, object>("@chequeDate", pamentV.chequeDate));
               parameter.Add(new KeyValuePair<string, object>("@naration", pamentV.naration));
               parameter.Add(new KeyValuePair<string, object>("@addedBy", pamentV.addedBy));
               parameter.Add(new KeyValuePair<string, object>("@addedOn", pamentV.addedOn));
               parameter.Add(new KeyValuePair<string, object>("@isOpeningBalance", pamentV.isOpeningBalance));
               
               int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addPaymentVoucher]", parameter,Conn,trans);

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
       public static DataTable getPaymentReceiptPrint(long paymentVoucherId, long financialYearID)
       {
           try
           {
               SqlHandler sqlH = new SqlHandler();
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@paymentReceiptId", paymentVoucherId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               DataTable PaymentList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getPaymentReceiptPrint]", parameter);
               return PaymentList;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getPaymentVoucherPrint(long paymentVoucherId, long financialYearID)
       {
           try
           {
               SqlHandler sqlH = new SqlHandler();
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@paymentReceiptId", paymentVoucherId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               DataTable PaymentList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getPaymentVoucherPrint]", parameter);
               return PaymentList;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       #endregion
       public static int SaveBankTransaction(BankTransaction bankTransaction)
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
                   parameter.Add(new KeyValuePair<string, object>("@accountTypeID", bankTransaction.accountTypeID));
                   parameter.Add(new KeyValuePair<string, object>("@accountID", bankTransaction.accountId));
                   parameter.Add(new KeyValuePair<string, object>("@financialYearID", bankTransaction.financialYearID));
                   parameter.Add(new KeyValuePair<string, object>("@transactionDate", bankTransaction.transactionDate));
                   parameter.Add(new KeyValuePair<string, object>("@crAmount", bankTransaction.crAmount));
                   parameter.Add(new KeyValuePair<string, object>("@drAmount", bankTransaction.drAmount));
                   parameter.Add(new KeyValuePair<string, object>("@naration", bankTransaction.naration));
                   parameter.Add(new KeyValuePair<string, object>("@isCashfrom", bankTransaction.isCashfrom));
                   parameter.Add(new KeyValuePair<string, object>("@PaymentType", bankTransaction.paymentType));
                   parameter.Add(new KeyValuePair<string, object>("@BankName", bankTransaction.bankName));
                   parameter.Add(new KeyValuePair<string, object>("@Ref_No", bankTransaction.ref_No));
                   parameter.Add(new KeyValuePair<string, object>("@PaymentDate", bankTransaction.paymentDate));
                   parameter.Add(new KeyValuePair<string, object>("@bankTransactionId", bankTransaction.bankTransactionId));
                   parameter.Add(new KeyValuePair<string, object>("@Transaction_ID", bankTransaction.transactionId));
                   parameter.Add(new KeyValuePair<string, object>("@Insert_By", bankTransaction.addedBy));
                   parameter.Add(new KeyValuePair<string, object>("@Insert_Date", bankTransaction.addedOn));
                   parameter.Add(new KeyValuePair<string, object>("@isDelete", bankTransaction.isDelete));
                   int i = sqlH.ExecuteNonQueryTM("[dbo].[usp_SaveUpDateBankTransaction]", parameter,Conn,trans);
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
       public static long getMaxIdPaymentReceiptId(long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqH = new SqlHandler();
               long paymentReceiptId = sqH.ExecuteAsScalarLong("[dbo].[Usp_getMaxIdPaymentReceiptId]", parameter);
               return paymentReceiptId;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static int addPaymentReceipt(PaymentReceipt pamentR)
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
               parameter.Add(new KeyValuePair<string, object>("@paymentReceiptId", pamentR.paymentReceiptId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", pamentR.financialYearID));
               parameter.Add(new KeyValuePair<string, object>("@accountId", pamentR.accountId));
               parameter.Add(new KeyValuePair<string, object>("@receiptDate", pamentR.receiptDate));
               parameter.Add(new KeyValuePair<string, object>("@crAmount", pamentR.crAmount));             
               parameter.Add(new KeyValuePair<string, object>("@paymentType", pamentR.paymentType));
               parameter.Add(new KeyValuePair<string, object>("@bankName", pamentR.bankName));
               parameter.Add(new KeyValuePair<string, object>("@bankId", pamentR.bankId));
               parameter.Add(new KeyValuePair<string, object>("@chequeNo_refNo", pamentR.chequeNo_refNo));
               parameter.Add(new KeyValuePair<string, object>("@chequeDate", pamentR.chequeDate));
               parameter.Add(new KeyValuePair<string, object>("@naration", pamentR.naration));
               parameter.Add(new KeyValuePair<string, object>("@addedBy", pamentR.addedBy));
               parameter.Add(new KeyValuePair<string, object>("@addedOn", pamentR.addedOn));
               parameter.Add(new KeyValuePair<string, object>("@isOpeningBalance", pamentR.isOpeningBalance));
               parameter.Add(new KeyValuePair<string, object>("@nextPayementDate", pamentR.nextPayementDate));
               int i = sqlH.ExecuteNonQueryTM("[dbo].[Usp_addPaymentReceipt]", parameter,Conn,trans);
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

       public static int PaymentReceiptDelete(long paymentReceiptId, long financialYearID)
       {
           try
           {

               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@paymentReceiptId", paymentReceiptId));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               SqlHandler sqH = new SqlHandler();
               int i = sqH.ExecuteNonQueryI("[dbo].[Usp_PaymentReceiptDelete]", parameter);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static DataTable getAccountNameByMobileAndGroups(int groupId,string mobileNo)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@groupId", groupId));
               parameter.Add(new KeyValuePair<string, object>("@mobileNo", mobileNo));
               SqlHandler sqH = new SqlHandler();
               DataTable accountList = sqH.ExecuteAsDataTable("[dbo].[Usp_getAccountNameByMobileAndGroups]",parameter);
               return accountList;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }


       public static double GetDueAmount(long accountId, string opreation, long financialYearID, DateTime fromDate)
       {
            List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
            parameter.Add(new KeyValuePair<string, object>("@AccountId", accountId));
            parameter.Add(new KeyValuePair<string, object>("@Opreation", opreation));
            parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
          //  parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
            return new SqlHandler().ExecuteAsScalar("[dbo].[Usp_getPaymentDue]", parameter);
       }
       public static DataTable GetAccountWisePaymentDue(long accountId, string opreation, long financialYearID)
       {
           List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
           parameter.Add(new KeyValuePair<string, object>("@AccountId", accountId));
           parameter.Add(new KeyValuePair<string, object>("@Opreation", opreation));
           parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
       //    parameter.Add(new KeyValuePair<string, object>("@fromDate", System.DateTime.Now));
           return new SqlHandler().ExecuteAsDataTable("[dbo].[Usp_getPaymentDue]", parameter);
       }
       public static DataSet getSaleBillPrint(long accountId, string opreation, long financialYearID)
       {
           List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
           parameter.Add(new KeyValuePair<string, object>("@AccountId", accountId));
           parameter.Add(new KeyValuePair<string, object>("@Opreation", opreation));
           parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
           return new SqlHandler().ExecuteAsDataSet("[dbo].[Usp_getPaymentDue]", parameter);
       }
       public static DataTable getExensesAccount()
       {
           return new SqlHandler().ExecuteAsDataTable("[dbo].[Usp_getExpensesAccount]");
       }
       public static DataTable getExpensesVoucher(long accountId,DateTime formDate, DateTime toDate, long FinancialYearID,string type)
       {
           List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
           parameter.Add(new KeyValuePair<string, object>("@accountId", accountId));
           parameter.Add(new KeyValuePair<string, object>("@fromDate", formDate));
           parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
           parameter.Add(new KeyValuePair<string, object>("@FinancialYearID", FinancialYearID));
           parameter.Add(new KeyValuePair<string, object>("@type", type));
           return new SqlHandler().ExecuteAsDataTable("[dbo].[Usp_getExpensesVoucher]", parameter);
       }
       public static DataTable getBankAccountGroup()
       {
           try
           {
               SqlHandler sqH = new SqlHandler();
               DataTable accountList = sqH.ExecuteAsDataTable("[dbo].[Usp_getBankAccountType]");
               return accountList;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getBankaccountName(int accountGroupId)
       {
           List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
           parameter.Add(new KeyValuePair<string, object>("@accountGroupId", accountGroupId));
           return new SqlHandler().ExecuteAsDataTable("[dbo].[Usp_getBankNameByAccountTypeId]", parameter);
       }
       public static DataTable getBankTransactionByAccount(long accountId)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@accountId", accountId));
               return new SqlHandler().ExecuteAsDataTable("[dbo].[Usp_GetBankTransactionByAccount]", parameter);
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getBankTransactionByDate(DateTime fromDate, DateTime toDate, long financialYearID)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
               parameter.Add(new KeyValuePair<string, object>("@financialYearID", financialYearID));
               return new SqlHandler().ExecuteAsDataTable("[dbo].[Usp_GetBankTransactionBydate]", parameter);
     
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getBankTransactionforReport(long bankId,DateTime fromDate,DateTime toDate)
       {
           try
           {
               List<KeyValuePair<string,object>> parameter=new List<KeyValuePair<string,object>>();
               parameter.Add(new KeyValuePair<string, object>("@bankId", bankId));
               parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
               parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
               SqlHandler sqlH = new SqlHandler();
               DataTable dt = sqlH.ExecuteAsDataTable("[dbo].[usp_getBankTransactionReport]", parameter);
               return dt;

           }
           catch(Exception ae)
           {
               throw ae;
           }
       }

       internal static DataTable getAccountNameBySubGroupId(long accountSubGroupId)
       {
           try
           {
               DataTable dtAccountDetails = new DataTable();
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@accountSubGroupId", accountSubGroupId));
               SqlHandler sqlH = new SqlHandler();
               dtAccountDetails = sqlH.ExecuteAsDataTable("[dbo].[Usp_getAccountDetailsBySubGroupId]",parameter);
               return dtAccountDetails;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }

       //public static double GetDueAmount(long accountId, string opreation, long financialYearID, DateTime fromDate)
       //{
       //    return 0;
       //}
   }

   public class accountGroupProvider
   {
       public static DataTable getaccountType()
       {
           try
           {

               SqlHandler sqH = new SqlHandler();
               DataTable accountList = sqH.ExecuteAsDataTable("[dbo].[usp_getAccountType]");
               return accountList;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getAccountGroupById(int accountTypeId)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@accountTypeId", accountTypeId));
               SqlHandler sqH = new SqlHandler();
               DataTable accountList = sqH.ExecuteAsDataTable("[dbo].[usp_getAccountGroupById]", parameter);
               return accountList;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getAccountNameById(int accountGroupId)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@accountGroupId", accountGroupId));
               SqlHandler sqH = new SqlHandler();
               DataTable accountList = sqH.ExecuteAsDataTable("[dbo].[usp_getAccountNameById]", parameter);
               return accountList;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getallAccountGroups()
       {
           try
           {

               SqlHandler sqH = new SqlHandler();
               DataTable accountList = sqH.ExecuteAsDataTable("[dbo].[usp_getallAccountGroups]");
               return accountList;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static int addAccountgroup(int accountGroupId, int accountTypeId, string accountGroup)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@accountGroupId", accountGroupId));
               parameter.Add(new KeyValuePair<string, object>("@accountTypeId", accountTypeId));
               parameter.Add(new KeyValuePair<string, object>("@accountGroup", accountGroup));

               SqlHandler sqlH = new SqlHandler();
               int i = sqlH.ExecuteNonQueryI("[dbo].[usp_addAccountgroup]", parameter);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static int getBackup()
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@getBackup", 1));
               SqlHandler sqlH = new SqlHandler();
               int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_getBackup]", parameter);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       public static int addAccountSubGroup(AccountSubGroup accountSubGroup)
       {
           try
           {
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@accountSubGroupId", accountSubGroup.accountSubGroupId));
               parameter.Add(new KeyValuePair<string, object>("@accountGroupId", accountSubGroup.accountGroupId));
               parameter.Add(new KeyValuePair<string, object>("@accountSubGroupName", accountSubGroup.accountSubGroupName));
               parameter.Add(new KeyValuePair<string, object>("@isUpDate", accountSubGroup.isUpDate));
               parameter.Add(new KeyValuePair<string, object>("@isDelete", accountSubGroup.isDelete));
               SqlHandler sqlH = new SqlHandler();
               int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addAccountSubGroup]", parameter);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }

       internal static DataTable getAccountSubGroupDetails(int accountGroupId)
       {
           try
           {
               DataTable dtAccountSubGroup = new DataTable();
               List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
               parameter.Add(new KeyValuePair<string, object>("@accountGroupId", accountGroupId));
               SqlHandler sqlH = new SqlHandler();
               dtAccountSubGroup = sqlH.ExecuteAsDataTable("[dbo].[Usp_getAccountSubGroup]", parameter);
               return dtAccountSubGroup;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
   }
}
