using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.models
{
  public  class damagedStockExpiry
    {
        public long damagedStockExpiryId { get; set; }
        public DateTime damagedStockDate { get; set; }
        public long transactionId { get; set; }
        public long InvoiceId { get; set; }
        public long accountId { get; set; }
        public long FinancialYearID { get; set; }
        public bool isDelete { get; set; }
        public bool isUpdate { get; set; }
       
        public string Remark { get; set; }
        public double Amount { get; set; }
        public DataTable dtItems { get; set; }
        public int addedBy { get; set; }
        public DateTime addedOn { get; set; }
    }
}
