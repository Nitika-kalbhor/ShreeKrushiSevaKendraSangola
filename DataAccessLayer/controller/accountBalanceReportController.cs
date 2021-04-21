using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
   public class accountBalanceReportController
    {
       public static DataTable getProfitLoss(DateTime fromDate,DateTime toDate)
       {
           try
           {
               DataTable dtProfitLoss = new DataTable();
               dtProfitLoss = accountReoprtProvider.getProfitAndLoss(fromDate, toDate);
               DataSet Expenses = accountReoprtProvider.getExpenses(fromDate, toDate);
               DataTable dtinDirectExpenses = Expenses.Tables[0];
               Double sumOfCr = 0, sumOfDr = 0, grossProfit = 0, sumExp = 0, suminm=0;
                foreach(DataRow dr in dtProfitLoss.Rows)
                {
                    sumOfCr += Convert.ToDouble(dr["crAmount"].ToString());
                    sumOfDr += Convert.ToDouble(dr["drAmount"].ToString());
                }
                foreach (DataRow dr in dtinDirectExpenses.Rows)
                {
                    suminm += Convert.ToDouble(dr["dr"].ToString());
                }
               foreach (DataRow dr in dtinDirectExpenses.Rows)
               {
                   sumExp += Convert.ToDouble(dr["cr"].ToString());
               }
                grossProfit = sumOfDr - sumOfCr;
                DataRow dtr = dtProfitLoss.NewRow();
                dtr["crPerticular"] = "Gross Profit O/C";
                dtr["crAmount"] = Math.Round(grossProfit,2);
                dtr["drPurticular"] = "";
                dtr["drAmount"] = 0;
               dtProfitLoss.Rows.Add(dtr);
               Double TotalsumOfCr = 0, TotalsumOfDr = 0;
               foreach (DataRow dr in dtProfitLoss.Rows)
               {
                   TotalsumOfCr += Convert.ToDouble(dr["crAmount"].ToString());
                   TotalsumOfDr += Convert.ToDouble(dr["drAmount"].ToString());
               }
               DataRow dtr1 = dtProfitLoss.NewRow();
               dtr1["crPerticular"] = "";
               dtr1["crAmount"] = Math.Round(TotalsumOfCr,2);
               dtr1["drPurticular"] = "";
               dtr1["drAmount"] = Math.Round(TotalsumOfDr,2);
               dtProfitLoss.Rows.Add(dtr1);
               DataRow dtr2 = dtProfitLoss.NewRow();
               dtr2["crPerticular"] = "Net Profit";
               dtr2["crAmount"] = Math.Round(grossProfit + suminm - sumExp, 2);
               dtr2["drPurticular"] = "Gross Profit b/f";
               dtr2["drAmount"] = Math.Round(grossProfit,2);
               dtProfitLoss.Rows.Add(dtr2);
                foreach(DataRow dr in dtinDirectExpenses.Rows)
                {
                    DataRow dtr4 = dtProfitLoss.NewRow();
                    dtr4["crPerticular"] = dr["crPerticular"];
                    dtr4["crAmount"] = dr["cr"];
                    dtr4["drPurticular"] =dr["drPurticular"];
                    dtr4["drAmount"] =dr["dr"];
                    dtProfitLoss.Rows.Add(dtr4);
                }
               Double GrandTotalsumOfCr = 0, GrandTotalsumOfDr = 0;
               foreach (DataRow dr in dtProfitLoss.Rows)
               {
                   GrandTotalsumOfCr += Convert.ToDouble(dr["crAmount"].ToString());
                   GrandTotalsumOfDr += Convert.ToDouble(dr["drAmount"].ToString());
               }
               DataRow dtr5 = dtProfitLoss.NewRow();
               dtr5["crPerticular"] = "Total";
               dtr5["crAmount"] = Math.Round(grossProfit + suminm - sumExp, 2);
               dtr5["drPurticular"] = "Total";
               dtr5["drAmount"] = Math.Round(grossProfit + suminm - sumExp, 2);
               dtProfitLoss.Rows.Add(dtr5);
               return dtProfitLoss;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getProfitLossWithOutTotal(DateTime fromDate,DateTime toDate)
       {
           try
           {
               DataTable dtProfitLoss = new DataTable();
               dtProfitLoss = accountReoprtProvider.getProfitAndLoss(fromDate, toDate);
               Double sumOfCr = 0, sumOfDr = 0, grossProfit = 0;
               foreach (DataRow dr in dtProfitLoss.Rows)
               {
                   sumOfCr += Convert.ToDouble(dr["crAmount"].ToString());
                   sumOfDr += Convert.ToDouble(dr["drAmount"].ToString());
               }
               grossProfit = sumOfDr - sumOfCr;
               DataRow dtr = dtProfitLoss.NewRow();
               dtr["crPerticular"] = "Gross Profit O/C";
               dtr["crAmount"] = Math.Round(grossProfit,2);
               dtr["drPurticular"] = "";
               dtr["drAmount"] = 0;
               dtProfitLoss.Rows.Add(dtr);
               Double TotalsumOfCr = 0, TotalsumOfDr = 0;
               foreach (DataRow dr in dtProfitLoss.Rows)
               {
                   TotalsumOfCr += Convert.ToDouble(dr["crAmount"].ToString());
                   TotalsumOfDr += Convert.ToDouble(dr["drAmount"].ToString());
               }
               DataRow dtr1 = dtProfitLoss.NewRow();
               dtr1["crPerticular"] = "";
               dtr1["crAmount"] = Math.Round(TotalsumOfCr,2);
               dtr1["drPurticular"] = "";
               dtr1["drAmount"] = Math.Round(TotalsumOfDr,2);
               dtProfitLoss.Rows.Add(dtr1);
               DataRow dtr2 = dtProfitLoss.NewRow();
               dtr2["crPerticular"] = "Net Profit";
               dtr2["crAmount"] = Math.Round(grossProfit,2);
               dtr2["drPurticular"] = "Gross Profit b/f";
               dtr2["drAmount"] = Math.Round(grossProfit,2);
               dtProfitLoss.Rows.Add(dtr2);
               DataRow dtr3 = dtProfitLoss.NewRow();
               dtr3["crPerticular"] = "";
               dtr3["crAmount"] = 0;
               dtr3["drPurticular"] = "Indirect Expenses";
               dtr3["drAmount"] = 0;
               dtProfitLoss.Rows.Add(dtr3);
               return dtProfitLoss;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getTrailBalance(DateTime fromDate, DateTime toDate)
       {
           try
           {
               DataTable dtTrailBalance = accountReoprtProvider.getTrailBalance(fromDate, toDate);
               return dtTrailBalance;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public static DataTable getBalanceSheet(DateTime fromDate, DateTime toDate)
       {
           try
           {
               DataSet dtTrailBalance = accountReoprtProvider.getBalanceSheet(fromDate, toDate);
               DataTable dtProfitAndLoss = accountBalanceReportController.getProfitLoss(fromDate, toDate);
               DataRow dr = dtProfitAndLoss.AsEnumerable()
               .SingleOrDefault(r => r.Field<string>("crPerticular") == "Net Profit");
               DataTable dt = dtTrailBalance.Tables[0];
               dt.Columns.Add("AssetaccountName", typeof(string));
               dt.Columns.Add("dr", typeof(double));
               DataRow dr2 = dt.NewRow();
               dr2["LiabilitesaccountName"] = "Profit & Loss A/c";
               dr2["cr"] = dr["crAmount"];
               dr2["AssetaccountName"] = "";
               dr2["dr"] = 0;
               dt.Rows.Add(dr2);
               for (int i = 0; i < dtTrailBalance.Tables[1].Rows.Count; i++)
               {
                   DataRow dr1 = dt.NewRow();
                   if (dt.Rows.Count > i)
                   {
                       dt.Rows[i]["AssetaccountName"] = dtTrailBalance.Tables[1].Rows[i]["AssetaccountName"];
                       dt.Rows[i]["dr"] = dtTrailBalance.Tables[1].Rows[i]["dr"];
                   }
                   else
                   {
                       dr1["LiabilitesaccountName"] = "";
                       dr1["cr"] = 0;
                       dr1["AssetaccountName"] = dtTrailBalance.Tables[1].Rows[i]["AssetaccountName"];
                       dr1["dr"] = dtTrailBalance.Tables[1].Rows[i]["dr"];
                       dt.Rows.Add(dr1);
                   }

               }
               //    DataTable dt3 = MergeTables(dtTrailBalance.Tables[0], dtTrailBalance.Tables[1]);
               return dt;
           }
           catch (Exception ae)
           {
               throw ae;
           }
       }
       public  DataTable dtProfitLoss()
       {
           DataTable dtProfitLoss = new DataTable();
           dtProfitLoss.Columns.Add("crPerticular",typeof(string));
            dtProfitLoss.Columns.Add("crAmount",typeof(float));
            dtProfitLoss.Columns.Add("drPurticular",typeof(string));
            dtProfitLoss.Columns.Add("drAmount",typeof(float));
            return dtProfitLoss;
       }
    }
}
