using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccessLayer.models
{
   public class ErrorLog
    {
     public long  errorLogId{get;set;}
        public DateTime  errorDate{get;set;}
        public string  cantrollerName{get;set;}
        public string methodName { get; set; }

        public string exception { get; set; }
           
           
           
           
    }
}
