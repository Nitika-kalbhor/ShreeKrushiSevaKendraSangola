using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccessLayer.models
{
   public  class customerDetails:commonModels
    {
        public long customerId { get; set; }
        public long SalesmanId { get; set; }
        public string salesmanName { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public int villageId { get; set; }
        public string villageName { get; set; }
        public DateTime DOB { get; set; }
        public string genderId { get; set; }
        public string Gender { get; set; }
        public string customerMobileNo { get; set; }
        public string OtherNote { get; set; }
        public string emailId { get; set; }
        public string contactPerson { get; set; }
        public string contactNo { get; set; }
        public string CustomerGSTNo { get; set; }
        public string CustomerPANNo { get; set; }
        public string isCustomerRetailer { get; set; }
        public string MobileTwo { get; set; }
        public string MobileThree { get; set; }
        public string adharNo { get; set; }
        double _discount = 0;
        public double discount
        {

            get
            {
                return this._discount;
            }
            set
            {
                this._discount = value;
            }
        }
        double _limitationAmount = 0;
        public double limitationAmount
        {

            get
            {
                return this._limitationAmount;
            }
            set
            {
                this._limitationAmount = value;
            }
        }

        public long FinancialYearID { get; set; }
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
    public class harshCustomer
    {
        public long customerId { get; set; }
        public string customerName { get; set; }
        public string mobileNo { get; set; }
        public DateTime dateofbirth { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string pinCode { get; set; }
        public DateTime date { get; set; }
        public string country { get; set; }
        
    }
}
