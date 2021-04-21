using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
  public  class accountReoprtProvider
    {
      public static DataTable  getProfitAndLoss(DateTime fromDate,DateTime toDate)
      {
          try
          {
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
              parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
              SqlHandler sqlH = new SqlHandler();
              DataTable dtProfitAndLoss = sqlH.ExecuteAsDataTable("[dbo].[Usp_getProfitLoss]", parameter);
              return dtProfitAndLoss;
          }
          catch(Exception ae)
          {
              throw ae;
          }
      }

      public  static DataTable getTrailBalance(DateTime fromDate, DateTime toDate)
      {
          try
          {
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
              parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
              SqlHandler sqlH = new SqlHandler();
              DataTable dtTrailBalance = sqlH.ExecuteAsDataTable("[dbo].[Usp_getTrailbalance]",parameter);
              return dtTrailBalance;
          }
          catch(Exception ae)
          {
              throw ae;
          }
      }
      public static DataSet getBalanceSheet(DateTime fromDate, DateTime toDate)
      {
          try
          {
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
              parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
              SqlHandler sqlH=new SqlHandler();
              DataSet dtBalanceSheet = sqlH.ExecuteAsDataSet("[dbo].[Usp_getBalanceSheet]", parameter);
              return dtBalanceSheet;
          }
          catch(Exception ae)
          {
              throw ae;
          }
      }

      internal static DataSet getExpenses(DateTime fromDate, DateTime toDate)
      {
          try
          {
              List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
              parameter.Add(new KeyValuePair<string, object>("@fromDate", fromDate));
              parameter.Add(new KeyValuePair<string, object>("@toDate", toDate));
              SqlHandler sqlH = new SqlHandler();
              DataSet dtExpenses = sqlH.ExecuteAsDataSet("[dbo].[Usp_getExpensesForP&L]", parameter);
              return dtExpenses;
          }
          catch (Exception ae)
          {
              throw ae;
          }
      }
    }
}
