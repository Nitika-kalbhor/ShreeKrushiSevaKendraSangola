using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccessLayer.models
{
    public class dealerDetails: commonModels
    {
        public long dealerId { get; set; }
        public string dealerName { get; set; }
        public string dealerFirmName { get; set; }
        public string dealerAddress { get; set; }
        public string dealerFirmAddress { get; set; }
        public string dealerContactNo { get; set; }
        public string GSTNo { get; set; }
         public string officeNo { get; set; }
        public DateTime DOB { get; set; }
        public int genderId { get; set; }
        public string Gender { get; set; }
        public string emailId { get; set; }
        public bool isCustomer { get; set; }


        public long FinancialYearID { get; set; }
    }
}
