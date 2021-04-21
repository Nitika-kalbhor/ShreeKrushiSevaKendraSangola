using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer.models;
using DataAccessLayer.providers;
using System.Data;

namespace DataAccessLayer.controller
{
 public   class ImportExcelController
 {
     public static int ImportExcelForDataBase(DataTable dtImport, string Forms, int addedBy, DateTime addedOn, long financialYearID)
     {
         try
         {
            return ImportExcelProvider.ImportExcelForDataBase(dtImport, Forms, addedBy, addedOn, financialYearID);
         }
         catch (Exception ex)
         {
             throw ex;
         }
     }
    }
}
