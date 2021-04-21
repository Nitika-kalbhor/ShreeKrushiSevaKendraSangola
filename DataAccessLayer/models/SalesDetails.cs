using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DataAccessLayer.models
{
   public class SalesDetails:TransactionDetails
    {
        public long salesId { get; set; }
        public string salesInvoiceId { get; set; }
      
        public long stockInID { get; set; }
        public long FinancialYearID { get; set; }
        public DateTime salesDate { get; set; }
        public long customerId { get; set; }
        public double totalbillAmount { get; set; }
        public double paidAmount { get; set; }
        public double previousAmount { get; set; }
        public double roundOff { get; set; }
        public double discount { get; set; }
        public double netbillAmount { get; set; }
       // public string challanNo { get; set; }
      //  public DateTime challanDate { get; set; }
        public string salesType { get; set; }
       
        public bool isState { get; set; }
        public bool isDelete { get; set; }
        public DataTable SaleItemTable { get; set; }

        public int bankId { get; set; }

        public bool isRetailer { get; set; }
        public string state { get; set; }
        public string stateCode { get; set; }
        public double hamali { get; set; }

        public string InvoiceIdPesticide { get; set; }

        public string InvoiceIdFertilizer { get; set; }

        public string InvoiceIdSeeds { get; set; }
        public string InvoiceIdPGROther { get; set; }
        public bool isWholeSale { get; set; }
        public DateTime nextPaymentdate { get; set; }
        public string driverName { get; set; }
        public string gadiNo { get; set; }
        public string NewsalesInvoiceId { get; set; }
        public string chalanNo { get; set; }
    }
}
