using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.models
{
  public  class godownTransfer
    {
        public long godownTransferId { get; set; }
        public DateTime godownTransferDate { get; set; }
        public string fromGodownTransfer { get; set; }
        public string toGodownTransfer { get; set; }
        public int addedBy { get; set; }
        public DateTime addedOn { get; set; }

      
        public bool isUpdate { get; set; }
        public bool isDelete { get; set; }
        public DataTable dtItems { get; set; }
    
        public long FinancialYearID { get; set; }

        public long invoiceId { get; set; }
    }
}
