using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.models
{
   public class customerDetails:commonModels
    {
        public long customerId { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public int villageId { get; set; }
        public string villageName { get; set; }
        public DateTime DOB { get; set; }
        public int genderId { get; set; }
        public string Gender { get; set; }
        public string customerMobileNo { get; set; }
        public string alterNateCustomerMobileNo { get; set; }
        public string emailId { get; set; }
        public string contactPerson { get; set; }
        public string contactPersonMobileNo { get; set; }
    }

    public class Genders
    {
        public int genderId { get; set; }
        public string Gender { get; set; }
    }

    public class VillageDetails
    {
        public int villageId { get; set; }
        public string villageName { get; set; }
        public Boolean isActive { get; set; }
        public int addedBy { get; set; }
        public DateTime addedOn { get; set; }
        public int updateBy { get; set; }
        public DateTime updateDate { get; set; }
    }
    public class bindCustCombo
    {
        public long customerId { get; set; }
        public string customerName { get; set; }
    }
}
