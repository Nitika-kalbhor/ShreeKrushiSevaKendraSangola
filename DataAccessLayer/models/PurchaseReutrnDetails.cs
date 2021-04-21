using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DataAccessLayer.models
{
 public   class PurchaseReutrnDetails:TransactionDetails
    {
     public long purchaseReutrnId { get; set; }
        public string purchaseReutrnInvoiceId { get; set; }
        public DateTime purchaseReutrnDate { get; set; }
        public long dealerId { get; set; }
        public double netBillAmount { get; set; }
        public double paidAmount { get; set; }
        public string remark { get; set; }
        public string challanNo { get; set; }
        public DateTime challanDate { get; set; }
        public string isCashCredit { get; set; }
        public DataTable PurchaseRetrunItemTable { get; set; }

        public int bankId { get; set; }

        public string stateCode { get; set; }

        public string state { get; set; }
        public bool isDelete { get; set; }

        public long FinancialYearID { get; set; }
        public string purchaseInvoiceNo { get; set; }
        public DateTime purchaseDate { get; set; }
    }
}
