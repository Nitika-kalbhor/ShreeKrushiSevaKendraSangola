using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.providers;
using DataAccessLayer.models;
using System.Data;

namespace DataAccessLayer.controller
{
 public   class employeeController
    {
        public static int addEmployeeDetails(employeeDetails emp)
        {
            try
            {
                int i = employeeProvider.addEmployeeDetails(emp);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getEmployeeDetails()
        {
            try
            {
                DataTable i = employeeProvider.getEmployeeDetails();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int DeleteIsActiveEmployee(long employeeId)
        {
            try
            {
                int i = employeeProvider.DeleteIsActiveEmployee(employeeId);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
