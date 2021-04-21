using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.models
{
   public class AccountDetails:commonModels
    {
       public int accountId { get; set; }
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
    }
}
