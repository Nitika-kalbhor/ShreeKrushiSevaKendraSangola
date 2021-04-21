using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccessLayer.models
{
   public class AccountDetails:commonModels
    {
       public long accountId { get; set; }
       public string accountName { get; set; }
       public int accountTypeId { get; set; }
       public string accountType { get; set; }
       public int accountGroupId { get; set; }
       public string accountGroup { get; set; }
       public long refId { get; set; }
       public double openigBalanace { get; set; }
       public string isCreditDebit { get; set; }
       public float closingBalance { get; set; }
       public string isCBCreditDebit { get; set; }
       public string accountNo { get; set; }
       public string isCustomerSupplier { get; set; }
       public string accountGSTNO { get; set; }

       public string MobileNo { get; set; }

       public long FinancialYearID { get; set; }
    }

    public class OrjAccountAmount
    {
        public double drAmountVimal { get; set; }
        public double drAmountShree { get; set; }
        public double drAmountSai { get; set; }
        public double drAmountSarvesh { get; set; }
    }

    public class PaymentVoucher
    {
        public long paymentVoucherId { get; set; }
        public long financialYearID { get; set; }
        public DateTime voucherDate { get; set; }
        public long accountId { get; set; }
        public string accountName { get; set; }
        public double drAmount { get; set; }      
        public string paymentType { get; set; }
        public string bankName { get; set; }
        public string chequeNo_refNo { get; set; }
        public DateTime chequeDate { get; set; }
        public string naration { get; set; }
        public long addedBy { get; set; }
        public DateTime addedOn { get; set; }

        public bool isOpeningBalance { get; set; }
        public int bankId { get; set; }
    }

    public class PaymentReceipt
    {
        public long paymentReceiptId { get; set; }
        public long financialYearID { get; set; }
        public DateTime receiptDate { get; set; }
        public long accountId { get; set; }
        public string accountName { get; set; }
        public double crAmount { get; set; }     
        public string paymentType { get; set; }
        public string bankName { get; set; }
        public string chequeNo_refNo { get; set; }
        public DateTime chequeDate { get; set; }
        public string naration { get; set; }
        public long addedBy { get; set; }
        public DateTime addedOn { get; set; }


        public int bankId { get; set; }
        public bool isOpeningBalance { get; set; }
        public DateTime nextPayementDate { get; set; }
    }
    public class AccountSubGroup
    {
        public long accountSubGroupId { get; set;}
        public long accountGroupId { get; set;}
        public string accountSubGroupName { get; set;}
        public bool isUpDate {get;set;}
        public bool isDelete { get; set; }
    }
}
