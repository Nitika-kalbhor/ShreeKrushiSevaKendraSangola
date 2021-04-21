using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace DataAccessLayer.models
{
    public class SalesReturnDetails : TransactionDetails
    {
        public long salesReturnId { get; set; }
        public long financialYearID { get; set; }
        public string salesReturnInvoiceId { get; set; }
        public DateTime salesReturnDate { get; set; }
        public long customerId { get; set; }
        public double totalbillAmount { get; set; }
        public double paidAmount { get; set; }
        public double previousAmount { get; set; }
        // public string challanNo { get; set; }
        //  public DateTime challanDate { get; set; }
        public string salesType { get; set; }
        public DataTable SaleRetrunItemTable { get; set; }

        public string stateCode { get; set; }

        public string state { get; set; }

        public string isCustomerRetailer { get; set; }
        public bool isDelete { get; set; }
        public string saleInvoiceNo { get; set; }
        public DateTime saleDate { get; set; }
    }
}
