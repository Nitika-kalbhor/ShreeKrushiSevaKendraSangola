using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.models
{
   public  class StockConversion
    {
       public long stockConversionId { get; set; }
       public string stockConversionIvoiceId { get; set; }
       public DateTime stockconversionDate { get; set; }
       public long stockFromID { get; set; }
       public double fromQty { get; set; }
       public long stockToId { get; set; }
       public double toQty { get; set; }
       public long financialYearID { get; set; }
       public bool isDelete { get; set; }
    }
}
