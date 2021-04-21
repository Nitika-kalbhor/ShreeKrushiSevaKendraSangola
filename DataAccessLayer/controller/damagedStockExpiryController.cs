using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
  public  class damagedStockExpiryController
    {
      public static int adddamagedStockExpiry(damagedStockExpiry damagedStock)
      {
          try
          {
              int i = 0;
              i = damagedStockExpiryProvider.adddamagedStockExpiry(damagedStock);
              return i;
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }

    }
}
