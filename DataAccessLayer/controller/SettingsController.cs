using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataAccessLayer.providers;
namespace DataAccessLayer.controller
{
public    class SettingsController
{
    public static DataTable getSettings()
    {
        try
        {
            DataTable dtChallanList = new DataTable();

            dtChallanList = SettingsProvider.getSettings();
            return dtChallanList;
        }
        catch (Exception ae)
        {
            throw ae;
        }
    }
    }
}
