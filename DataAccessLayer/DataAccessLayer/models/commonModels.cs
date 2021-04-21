using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.models
{
  public  class commonModels
    {
      public int orjId { get; set; }
      public string orjName { get; set; }
        public Boolean isActive { get; set; }
        public int addedBy { get; set; }
        public DateTime addedOn { get; set; }
        public int updateBy { get; set; }
        public DateTime updateDate { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public double openigBalance { get; set; }
        public double crAmount { get; set; }
        public double drAmount { get; set; }
        public string CreditDebit { get; set;}

        public double openigBalanace { get; set; }
      //  public double crAmount { get; set; }
      //  public double drAmount { get; set; }
        public string isCreditDebit { get; set; }

    }
    public class Orgnation
    {
        public int orjId { get; set; }
        public string orjName { get; set; }
    }
}
