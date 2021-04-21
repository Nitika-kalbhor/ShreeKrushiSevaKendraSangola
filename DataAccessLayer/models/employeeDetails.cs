using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccessLayer.models
{
    public class employeeDetails: commonModels
    {
        public long employeeId { get; set; }
        public string employeeName { get; set; }
        public string employeeAddress { get; set; }
        public string employeeMobileNo { get; set; }
        public DateTime DOB { get; set; }
        public int genderId { get; set; }
        public string Gender { get; set; }
        public int deptId { get; set; }
        public Byte employeeImage { get; set; }
        public string emailId { get; set; }
       
    }
}
