using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.models
{
 public  class SalesmanDetails:commonModels
    {
        public long SalesmanId { get; set; }
        public string SalesmanName { get; set; }    
        public DateTime DOB { get; set; }
        public string GenderId { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public int isDelete { get; set; }              
    }   
}
