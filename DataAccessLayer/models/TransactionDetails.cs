using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccessLayer.models
{
  public  class TransactionDetails:commonModels
    {
      /// <summary>
        /// TransactionDetails Table Models
      /// </summary>
        public long transactionId { get; set; }
        public DateTime transactionDate { get; set; }
        public double crAmount { get; set; }
        public double drAmount { get; set; }
        public string paymentType { get; set; }
        public string bankName { get; set; }
        public string chequeNo_refNo { get; set; }
        public DateTime chequeDate { get; set; }
        public double deduction { get; set; }
        public string naration { get; set; }
        public long accountId { get; set; }
        public int bankId { get; set; }
        public string accountName { get; set; }

      /// <summary>
        /// paymentVoucher Table Models
      /// </summary>
        public long paymentVoucherId { get; set; }
        public DateTime voucherDate { get; set; }
      /// <summary>
        /// Payment Receipt Table Models
      /// </summary>
        public long paymentReceiptId { get; set; }
        public DateTime receiptDate { get; set; }
      /// <summary>
      /// Payment Due Table Models
      /// </summary>
        public long payDueId { get; set; }
    }
}
