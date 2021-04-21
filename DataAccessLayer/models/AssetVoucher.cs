using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.models
{
 public   class AssetVoucher
    {
        public long voucherAssetID { get; set; }
        public Nullable<System.DateTime> voucherDate { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<long> transactionId { get; set; }
        public Nullable<long> FinancialYearID { get; set; }
        public Nullable<long> naveAccountId { get; set; }
        public Nullable<long> jamaAccountId { get; set; }
        public Nullable<decimal> crAmount { get; set; }
        public Nullable<decimal> drAmount { get; set; }
        public Nullable<decimal> IGST { get; set; }
        public Nullable<decimal> CGST { get; set; }
        public Nullable<decimal> SGST { get; set; }
        public Nullable<decimal> IGSTAmt { get; set; }
        public Nullable<decimal> CGSTAmt { get; set; }
        public Nullable<decimal> SGSTAmt { get; set; }
        public Nullable<bool> GSTRegister { get; set; }
        public Nullable<bool> isState { get; set; }
        public Nullable<bool> isCash { get; set; }
        public string PaymentType { get; set; }

        public int bankId { get; set; }
        public string chqDDNo { get; set; }
        public Nullable<System.DateTime> chqDate { get; set; }
        public string naration { get; set; }
        public Nullable<System.DateTime> addedOn { get; set; }
        public Nullable<int> addedBy { get; set; }

        public string bankName { get; set; }

        public bool isUpdate { get; set; }
    }
}
