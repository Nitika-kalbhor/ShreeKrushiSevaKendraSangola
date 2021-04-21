using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using System.Data;

namespace DataAccessLayer.providers
{
 public   class employeeProvider
    {
        public static int addEmployeeDetails(employeeDetails emp)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@employeeId", emp.employeeId));
                parameter.Add(new KeyValuePair<string, object>("@employeeName", emp.employeeName));
                parameter.Add(new KeyValuePair<string, object>("@employeeAddress", emp.employeeAddress));
                parameter.Add(new KeyValuePair<string, object>("@DOB", emp.DOB));
                parameter.Add(new KeyValuePair<string, object>("@genderId", emp.genderId));
                parameter.Add(new KeyValuePair<string, object>("@employeeMobileNo", emp.employeeMobileNo));
                parameter.Add(new KeyValuePair<string, object>("@emailId", emp.emailId));
                parameter.Add(new KeyValuePair<string, object>("@isCreditDebit", emp.CreditDebit));
                parameter.Add(new KeyValuePair<string, object>("@openigBalanace", emp.openigBalanace));
                parameter.Add(new KeyValuePair<string, object>("@orjId", emp.orjId));
                if (emp.CreditDebit == "जमा रक्कम")
                {
                    emp.crAmount = emp.openigBalanace;
                    emp.drAmount = 0;
                }
                if (emp.CreditDebit == "नावे रक्कम")
                {
                    emp.drAmount = emp.openigBalanace;
                    emp.crAmount = 0;
                }
                parameter.Add(new KeyValuePair<string, object>("@crAmount", emp.crAmount));
                parameter.Add(new KeyValuePair<string, object>("@drAmount", emp.drAmount));
             
             
                parameter.Add(new KeyValuePair<string, object>("@addedBy", emp.addedBy));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", emp.addedOn));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addEmployeeDetails]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

        public static DataTable getEmployeeDetails()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable lists = sqlH.ExecuteAsDataTable("[dbo].[Usp_getEmployeeDetails]");
                return lists;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

        public static int DeleteIsActiveEmployee(long employeeId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@employeeId", employeeId));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.Now));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_DeleteIsActiveEmployee]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
    }
}
