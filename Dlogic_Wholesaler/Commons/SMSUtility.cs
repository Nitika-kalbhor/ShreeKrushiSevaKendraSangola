using DataAccessLayer.controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;

namespace Dlogic_Wholesaler
{
   public class SMSUtility
    {
       public  static string path = "C:/Log";
       public static string smsSentPath = "C:/Log/SMSSent.txt";
       public static string smsFailedPath = "C:/Log/SMSFailed.txt";
       public static int SMSSendFEESINSTALLMENT(string msg,string custMobNo)
       {
           int totalSent = 0;
           int totalFailed = 0;
           try
           {

                   createLogFile();
                   if (NetworkInterface.GetIsNetworkAvailable())
                   {
                       WebClient client = new WebClient();
                       string to, message;
                       to = custMobNo;
                       if (to == string.Empty || to.Length < 10)
                       {
                           File.AppendAllText(smsFailedPath, Environment.NewLine + msg + to);
                           totalFailed++;
                           return totalFailed;
                       }
                       else
                       {
                           message = msg;
                           string BaseURL1 = "http://sms.twitsms.in/api/mt/SendSMS?user=dlogic&password=dlo123gic&senderid=MHSKTI&channel=Trans&DCS=0&flashsms=0&number=" + to + "&text=" + message + "&route=14";
                           Stream response = client.OpenRead(BaseURL1);
                           client.Dispose();
                           File.AppendAllText(smsSentPath, Environment.NewLine + "Mobile No: " + to);
                           totalSent++;
                       }
                   }
                   else
                   {
                       File.AppendAllText(smsFailedPath, Environment.NewLine + "No InternetConnection Available -" + msg + "-This SMS Not Send To -" + custMobNo);
                   }
               return totalSent;
           }
           catch (Exception ex)
           {
               File.AppendAllText(smsFailedPath, Environment.NewLine + "Mobile No: " + custMobNo + ex.Message);

               throw ex;
           }
       }

       public static int SMSSendAllDue(DataTable dt, int rowIndex)
       {
           int totalSent = 0;
           int totalFailed = 0;
           try
           {

               createLogFile();
              // DataTable smsTem = TemplateController.getTemplate();
               for (int s = 0; dt.Rows.Count  > s; s++)
               {
                   if (Convert.ToDouble(dt.Rows[s]["dueAmount"].ToString()) > 0)
                   {
                       WebClient client = new WebClient();
                       string to, message;
                       to = dt.Rows[s]["customerMobileNo"].ToString();
                       if (to == string.Empty || to.Length < 10)
                       {
                           File.AppendAllText(smsFailedPath, Environment.NewLine + "Customer Name: " + dt.Rows[s]["customerName"].ToString() +
                                                                           Environment.NewLine + "Reason: No Mobile No " + to);
                           totalFailed++;
                           continue;
                       }
                       message = @"Dear customer please pay your due.-" + dt.Rows[s]["dueAmount"].ToString() + " From - MahaShakti Krushi Kendra Laxmi Takali.";
                       string BaseURL1 = "http://sms.twitsms.in/api/mt/SendSMS?user=dlogic&password=dlo123gic&senderid=MHSKTI&channel=Trans&DCS=0&flashsms=0&number=" + to + "&text=" + message + "&route=14";
                       Stream response = client.OpenRead(BaseURL1);
                       client.Dispose();
                       File.AppendAllText(smsSentPath, Environment.NewLine + "Customer Name: " + dt.Rows[s]["customerName"].ToString());
                       totalSent++;
                   }
               }
               return totalSent;
           }
           catch (Exception ex)
           {
               File.AppendAllText(smsFailedPath, Environment.NewLine + "Student Name: " + ex.Message);

               throw ex;
           }
       }
       public static void createLogFile()
       {
           try
           {
              
               if (!Directory.Exists(path))
                   Directory.CreateDirectory(path);

               if (!File.Exists(smsSentPath))
               {
                   var sFile = File.Create(smsSentPath);
                   sFile.Close();
               }
               if (!File.Exists(smsFailedPath))
               {
                   var fFile = File.Create(smsFailedPath);
                   fFile.Close();
               }
               File.AppendAllText(smsFailedPath, Environment.NewLine + Environment.NewLine +
                                                         "SMS Sent Status - " + DateTime.Now + Environment.NewLine + Environment.NewLine);

               File.AppendAllText(smsSentPath, Environment.NewLine + Environment.NewLine +
                                                              "SMS Sent Status - " + DateTime.Now + Environment.NewLine + Environment.NewLine);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
    }
}
