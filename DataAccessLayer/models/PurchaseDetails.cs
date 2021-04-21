using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DataAccessLayer.models
{
    public class PurchaseDetails : TransactionDetails
    {
        public long purchaseId { get; set; }
        public string purchaseInvoiceId { get; set; }
        public long FinancialYearID { get; set; }
        public long stockInID { get; set; }
        public long stockOutID { get; set; }
        public long stockOutInvoiceID { get; set; }
        public long financialYearID { get; set; }
        public long purchaseChalanId { get; set; }
        public DateTime purchaseDate { get; set; }
        public long dealerId { get; set; }
        public double netBillAmount { get; set; }
        public double paidAmount { get; set; }
        public double DilivaryCharges { get; set; }
        public string remark { get; set; }
        public string challanNo { get; set; }
        public DateTime challanDate { get; set; }
        public string isCashCredit { get; set; }
      
        public bool isDelete { get; set; }
        public bool isState { get; set; }
        public DataTable PurchaseItemTable { get; set; }
        public string state { get; set; }
        public string stateCode { get; set; }
        public Boolean isCustomerRetailer { get; set; }
         public double discountAmount { get; set; }
         public double netBillAmtWithOutDiscount { get; set; }

         public double roundOff { get; set; }
        public string stockInInvoiceID { get; set; }

        public bool isChalanConvert { get; set; }
    }
}
