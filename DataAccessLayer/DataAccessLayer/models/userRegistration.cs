using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.models
{
    public class userRegistration: commonModels
    {
        public int userRegistrationId { get; set; }      
        public string fullName { get; set; }
        public string address { get; set; }
        public DateTime DOB { get; set; }
        public int genderId { get; set; }
        public string mobileNo { get; set; }      
        public string emailId { get; set; }
        public Byte userImage { get; set; }

        /// <summary>
        /// /  Tbl_UserDetails Mobels 
        /// </summary>
        public int userDetailsId { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userRollId { get; set; }


    }
}
