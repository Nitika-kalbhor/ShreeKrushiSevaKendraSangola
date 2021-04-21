using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using DataAccessLayer.providers;
using System.Data;

namespace DataAccessLayer.controller
{
   public class accountDetailsController
    {


       public static DataTable getAccountDetailsForAccountGroup()
       {
           try
           {
               DataTable dt = accountDetailsProvider.getAccountDetailsForAccountGroup();
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static double GetDueAmount(long accountId, string opreation,long financialYearID,DateTime fromDate)
       {

           return accountDetailsProvider.GetDueAmount(accountId, opreation, financialYearID,fromDate);
       }
       
       public static DataTable GetAccountWisePaymentDue(long accountId, string opreation, long financialYearID)
       {

           return accountDetailsProvider.GetAccountWisePaymentDue(accountId, opreation, financialYearID);
       }

       public static DataSet getSaleBillPrint(long accountId, string opreation,long financialYearID)
       {

           return accountDetailsProvider.getSaleBillPrint(accountId, opreation, financialYearID);
       }
       public static DataTable getAccountNameByMobileAndGroups(int groupId, string mobileNo)
       {
           try
           {
               DataTable i = accountDetailsProvider.getAccountNameByMobileAndGroups(groupId, mobileNo);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static int addAcountDetails(AccountDetails account)
       {
           try
           {
               int i = accountDetailsProvider.addAcountDetails(account);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static DataTable getaccountName(int accountGroupId)
       {
           try
           {
               DataTable i = accountDetailsProvider.getaccountName(accountGroupId);
               return i;
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
       public static DataTable GetAccountGroup()
       {
           try
           {

               DataTable i = accountDetailsProvider.GetAccountGroup();
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
        public static DataTable getPaymentReceiptTransaction(long financialYearID)
        {
            try
            {
                DataTable dtr = accountDetailsProvider.getPaymentReceiptTransaction(financialYearID);
                return dtr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getPaymentVoucherTransaction(long financialYearID)
        {
            try
            {
                DataTable dtv = accountDetailsProvider.getPaymentVoucherTransaction(financialYearID);
                return dtv;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static double getPaymentDueAmount(long accountId)
       {
           try
           {
                double crDrAmount = accountDetailsProvider.getPaymentDueAmount(accountId);
               return crDrAmount;
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
               long paymentVoucherId = accountDetailsProvider.getMaxIdPaymentVoucherId(financialYearID);
               return paymentVoucherId;
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
       public static int addPaymentVoucher(PaymentVoucher pamentV)
       {
           try
           {
               int i = accountDetailsProvider.addPaymentVoucher(pamentV);
               return i;
           }
           catch(Exception ex)
           {
               throw ex;
           }
       }
       public static int SaveBankTransaction(BankTransaction bankTransaction)
       {
           try
           {
               int i = accountDetailsProvider.SaveBankTransaction(bankTransaction);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static long getMaxIdPaymentReceiptId(long financialYearID)
       {
           try
           {
               long paymentReceiptId = accountDetailsProvider.getMaxIdPaymentReceiptId(financialYearID);
               return paymentReceiptId;
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
       public static int addPaymentReceipt(PaymentReceipt pamentR)
       {
           try
           {
               int i = accountDetailsProvider.addPaymentReceipt(pamentR);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static int PaymentReceiptDelete(long paymentReceiptId,long financialYearID)
       {
           try
           {
               int i = accountDetailsProvider.PaymentReceiptDelete(paymentReceiptId, financialYearID);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static int VoucherPaymentDelete(long paymentVoucherId,long financialYearID)
       {
           try
           {
               int i = accountDetailsProvider.VoucherPaymentDelete(paymentVoucherId, financialYearID);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static DataTable getExensesAccount()
       {
           try
           {
               DataTable dt = accountDetailsProvider.getExensesAccount();
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static DataTable getExpensesVoucher(long accountId,DateTime formDate,DateTime toDate,long FinancialYearID,string type)
       {
           try
           {
               DataTable dt = accountDetailsProvider.getExpensesVoucher(accountId,formDate, toDate, FinancialYearID, type);
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static DataTable  getBankAccountGroup()
       {
           try
           {
               DataTable dt = accountDetailsProvider.getBankAccountGroup();
               return dt;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getBankaccountName(int accountGroupId)
       {
            try
           {
               DataTable dt = accountDetailsProvider.getBankaccountName(accountGroupId);
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static DataTable getBankTransactionByAccount(long accountId)
       {
           try
           {
               DataTable dt = accountDetailsProvider.getBankTransactionByAccount(accountId);
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static DataTable getBankTransactionByDate(DateTime fromDate,DateTime toDate,long financialYearID)
       {
           try
           {
               DataTable dt = accountDetailsProvider.getBankTransactionByDate(fromDate, toDate, financialYearID);
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static DataTable getBankTransactionforReport(long bankId,DateTime fromDate,DateTime toDate)
       {
           try
           {
               DataTable dt = accountDetailsProvider.getBankTransactionforReport(bankId,fromDate,toDate);
               return dt;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getPaymentReceiptPrint(long paymentVoucherId, long financialYearID)
       {
           try
           {
               DataTable i = accountDetailsProvider.getPaymentReceiptPrint(paymentVoucherId, financialYearID);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getPaymentVoucherPrint(long paymentVoucherId,long financialYearID)
       {
           try
           {
               DataTable i = accountDetailsProvider.getPaymentVoucherPrint(paymentVoucherId, financialYearID);
               return i;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
    }
   public class accountGroupController
   {
       public static int addAccountgroup(int accountGroupId, int accountTypeId, string accountGroup)
       {
           try
           {
               int i = accountGroupProvider.addAccountgroup(accountGroupId, accountTypeId, accountGroup);
               return i;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public static DataTable getaccountType()
       {
           try
           {
               DataTable i = accountGroupProvider.getaccountType();
               return i;
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
       public static DataTable getAccountGroupById(int accountTypeId)
       {
           try
           {
               DataTable i = accountGroupProvider.getAccountGroupById(accountTypeId);
               return i;
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
       public static DataTable getAccountNameById(int accountGroupId)
       {
           try
           {
               DataTable i = accountGroupProvider.getAccountNameById(accountGroupId);
               return i;
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
       public static DataTable getallAccountGroups()
       {
           try
           {
               DataTable i = accountGroupProvider.getallAccountGroups();
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
               int i = accountGroupProvider.getBackup();
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
               int i = accountGroupProvider.addAccountSubGroup(accountSubGroup);
               return i;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getAccountSubGroupDetails(int accountGroupId)
       {
           try
           {
               DataTable dtAccountSubGroup = accountGroupProvider.getAccountSubGroupDetails(accountGroupId);
               return dtAccountSubGroup;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getAccountNameBySubGroupId(long accountSubGroupId)
       {
           try
           {
               DataTable dtAccountDetails = accountDetailsProvider.getAccountNameBySubGroupId(accountSubGroupId);
               return dtAccountDetails;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
   }
}
