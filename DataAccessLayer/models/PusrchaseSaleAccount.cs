using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.models
{
   public class PusrchaseSaleAccount
    {
       public long transactionId { get; set; }
       public long billId { get; set; }
       public double RoundOff { get; set; }
       public double discount { get; set; }
       public double Hamali { get; set; }
       public double Igst5 { get; set; }
       public double Igst12 { get; set; }
       public double Igst18 { get; set; }
       public double Igst28 { get; set; }
       public string stateCode { get; set; }
       public double salePurchaseAccount { get; set; }
       public string issalePurchase { get; set; }

    }
}
