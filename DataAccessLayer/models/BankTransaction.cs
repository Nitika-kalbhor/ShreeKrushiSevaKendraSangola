using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.models
{
   public class BankTransaction:AccountDetails
    {
        public long bankTransactionId { get; set; }
        public long financialYearID{get;set;}
        public int accountTypeID { get; set; }
        public DateTime transactionDate { get; set; }
        public double crAmount { get; set; }
        public double drAmount { get; set; }
        public bool isCashfrom { get; set; }
        public string naration { get; set; }
        public long transactionId { get; set; }
        public string paymentType { get; set; }
        public string bankName { get; set; }
        public string ref_No { get; set; }
        public DateTime paymentDate { get; set; }
        public bool isDelete { get; set; }


    }
}
