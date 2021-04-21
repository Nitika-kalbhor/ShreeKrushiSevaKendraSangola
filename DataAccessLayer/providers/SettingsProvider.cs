using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
  public  class SettingsProvider
  {
      public static DataTable getSettings()
      {
          try
          {
              DataTable dtChallanList = new DataTable();           
              SqlHandler sqlH = new SqlHandler();
              dtChallanList = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSettings]");
              return dtChallanList;
          }
          catch (Exception ae)
          {
              throw ae;
          }
      }
    }
}
