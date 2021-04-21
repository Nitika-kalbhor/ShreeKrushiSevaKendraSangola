
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

using System.Windows.Forms;
using DataAccessLayer.controller;
using System.Globalization;
using Dlogic_Wholesaler.Forms;
using System.IO;
namespace Dlogic_Wholesaler
{
    public static class Utility
    {
        #region --Global Variable --

        public static int LoginID { get; private set; }
        public static string UserName { get; private set; }
        public static string Langn { get; private set; }
        public static string Financialyear { get; set; }
        public static long FinancilaYearId{get;set;}
        public static DateTime firstDate { get; set; }
        public static DateTime lastDate { get; set; }

        public static bool isSingleMultipalPrint { get; set; }

        public static bool isPeview { get; set; }

        public static DataTable dtGenericBillInfo { get; set; }
        public static bool isEnglishBill {get;set;}

        // GlobalInt can be changed only via this method
        public static void SetLogin(int newLoginID, string newUserName, string Lang, string newFinancialyear, long newFinancilaYearId, DateTime newfirstDate, DateTime newlastDate)
        {
            LoginID = newLoginID;
            UserName = newUserName;
            Langn = Lang;
            Financialyear=newFinancialyear;
            FinancilaYearId=newFinancilaYearId;
            firstDate=newfirstDate;
            lastDate = newlastDate;
        }
        public static void SetLogin(int newLoginID, string newUserName, string newFinancialyear, long newFinancilaYearId, DateTime newfirstDate, DateTime newlastDate)
        {
            LoginID = newLoginID;
            UserName = newUserName;
            Financialyear = newFinancialyear;
            FinancilaYearId = newFinancilaYearId;
            firstDate = newfirstDate;
            lastDate = newlastDate;
        }
        public static void SetLanguage(string lang)
        {
            Langn = lang;
        }
        #endregion

        public static void disableFields(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var textBox = c as TextBox;
                var comboBox = c as ComboBox;
                var datePicker = c as DateTimePicker;
                var checkBox = c as CheckBox;
                var textArea = c as RichTextBox;
               
                if (textBox != null)
                    (textBox).Enabled = false;

                if (comboBox != null)
                    comboBox.Enabled = false;
                if (datePicker != null)
                {
                    datePicker.Enabled = false;
                }
                if (checkBox != null)
                    checkBox.Enabled = false;
                if (textArea != null)
                    textArea.Enabled = false;
              
                    disableFields(c);
            }
        }
        public static void enableFields(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var textBox = c as TextBox;
                var comboBox = c as ComboBox;
                var datePicker = c as DateTimePicker;
                var checkBox = c as CheckBox;
                var textArea = c as RichTextBox;
                if (textBox != null)
                    (textBox).Enabled = true;
                if (comboBox != null)
                    comboBox.Enabled = true;
                if (datePicker != null)
                {
                    datePicker.Enabled = true;
                }
                if (checkBox != null)
                    checkBox.Enabled = true;
                if (textArea != null)
                    textArea.Enabled = true;
                if (c.HasChildren)
                    enableFields(c);
            }
        }
        public static void ClearSpace(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var textBox = c as TextBox;
                var comboBox = c as ComboBox;
                var datePicker = c as DateTimePicker;
                if (textBox != null)
                    (textBox).Clear();
                if (comboBox != null)
                    comboBox.Text = "";
                if (datePicker != null)
                {
                    datePicker.Text = "";
                }
                if (c.HasChildren)
                    ClearSpace(c);
            }
        }

        #region --Bind Combobox --

        public static void BindComboBoxData(ComboBox ComboBoxname, DataTable dt, string valueid, string valuedisplay)
        {

            DataRow DataRW;
            DataTable DataTB = new DataTable();
            ComboBoxname.DataSource = null;

            if (dt.Columns.Count > 0)
                DataTB = dt;
            else
            {
                DataTB.Columns.Add(valueid, typeof(string));
                DataTB.Columns.Add(valuedisplay, typeof(string));
            }

            DataRW = DataTB.NewRow();
            if (DataTB.Rows.Count != 0)
            {
                // string planstr = valueid + " " + valuedisplay;
                ComboBoxname.DataSource = DataTB.DefaultView;
                ComboBoxname.DataSource = DataTB.AsDataView();
                ComboBoxname.ValueMember = valueid;
                ComboBoxname.DisplayMember = valuedisplay;
            }
            else
                ComboBoxname.DataSource = null;
        }

        public static void BindComboBoxDataSelect(ComboBox ComboBoxname, DataTable dt, string valueid, string valuedisplay)
        {
            try
            {
                DataRow DataRW;
                DataTable DataTB = new DataTable();
                ComboBoxname.DataSource = null;

                if (dt.Columns.Count > 0)
                    DataTB = dt;
                else
                {
                    DataTB.Columns.Add(valueid, typeof(string));
                    DataTB.Columns.Add(valuedisplay, typeof(string));
                }

                DataRW = DataTB.NewRow();
                if (DataTB.Rows.Count != 0)
                {
                    DataRW[valueid] = "0";
                    DataRW[valuedisplay] = "-- Select --";
                    DataTB.Rows.InsertAt(DataRW, 0);
                    // string planstr = valueid + " " + valuedisplay;
                    //  ComboBoxname.DataSource = DataTB.DefaultView;
                    ComboBoxname.DataSource = DataTB.AsDataView();
                    ComboBoxname.ValueMember = valueid;
                    ComboBoxname.DisplayMember = valuedisplay;

                }
                else

                    ComboBoxname.DataSource = null;
            }
            catch
            {
                throw;
            }
        }
        public static void BindComboBoxEmptyDataSelect(ComboBox ComboBoxname, DataTable dt, string valueid, string valuedisplay)
        {
            try
            {
                DataRow DataRW;
                DataTable DataTB = new DataTable();
                ComboBoxname.DataSource = null;

                if (dt.Columns.Count > 0)
                    DataTB = dt;
                else
                {
                    DataTB.Columns.Add(valueid, typeof(string));
                    DataTB.Columns.Add(valuedisplay, typeof(string));
                }

                DataRW = DataTB.NewRow();
                if (DataTB.Rows.Count != 0)
                {
                    DataRW[valueid] = "0";
                    DataRW[valuedisplay] =string.Empty;
                    DataTB.Rows.InsertAt(DataRW, 0);
                    // string planstr = valueid + " " + valuedisplay;
                    //  ComboBoxname.DataSource = DataTB.DefaultView;
                    ComboBoxname.DataSource = DataTB.AsDataView();
                    ComboBoxname.ValueMember = valueid;
                    ComboBoxname.DisplayMember = valuedisplay;

                }
                else

                    ComboBoxname.DataSource = null;
            }
            catch
            {
                throw;
            }
        }
        public static void BindComboBoxDataSingalSelect(ComboBox ComboBoxname, DataTable dt,  string valuedisplay)
        {
            try
            {
                DataRow DataRW;
                DataTable DataTB = new DataTable();
                ComboBoxname.DataSource = null;

                if (dt.Columns.Count > 0)
                    DataTB = dt;
                else
                {
                  
                    DataTB.Columns.Add(valuedisplay, typeof(string));
                }

                DataRW = DataTB.NewRow();
                if (DataTB.Rows.Count != 0)
                {
                    
                    DataRW[valuedisplay] = "-- Select --";
                    DataTB.Rows.InsertAt(DataRW, 0);
                    // string planstr = valueid + " " + valuedisplay;
                    //  ComboBoxname.DataSource = DataTB.DefaultView;
                    ComboBoxname.DataSource = DataTB.AsDataView();                 
                    ComboBoxname.DisplayMember = valuedisplay;

                }
                else

                    ComboBoxname.DataSource = null;
            }
            catch
            {
                throw;
            }
        }
        public static void BindComboBoxDataForSelectAll(ComboBox ComboBoxname, DataTable dt, string valueid, string valuedisplay)
        {
            try
            {
                DataRow DataRW;
                DataTable DataTB = new DataTable();
                ComboBoxname.DataSource = null;

                if (dt.Columns.Count > 0)
                    DataTB = dt;
                else
                {
                    DataTB.Columns.Add(valueid, typeof(string));
                    DataTB.Columns.Add(valuedisplay, typeof(string));
                }

                DataRW = DataTB.NewRow();
                if (DataTB.Rows.Count != 0)
                {
                    DataRW[valueid] = "0";
                    DataRW[valuedisplay] = "-- Select All --";
                    DataTB.Rows.InsertAt(DataRW, 0);
                    // string planstr = valueid + " " + valuedisplay;
                    //  ComboBoxname.DataSource = DataTB.DefaultView;
                    ComboBoxname.DataSource = DataTB.AsDataView();
                    ComboBoxname.ValueMember = valueid;
                    ComboBoxname.DisplayMember = valuedisplay;

                }
                else

                    ComboBoxname.DataSource = null;
            }
            catch
            {
                throw;
            }
        }
        public static void BindComboBoxWithEmptyDataSelect(ComboBox ComboBoxname, DataTable dt, string valueid, string valuedisplay)
        {
            try
            {
                DataRow DataRW;
                DataTable DataTB = new DataTable();
                ComboBoxname.DataSource = null;

                if (dt.Columns.Count > 0)
                    DataTB = dt;
                else
                {
                    DataTB.Columns.Add(valueid, typeof(string));
                    DataTB.Columns.Add(valuedisplay, typeof(string));
                }

                DataRW = DataTB.NewRow();
                if (DataTB.Rows.Count != 0)
                {
                   
                    // string planstr = valueid + " " + valuedisplay;
                    //  ComboBoxname.DataSource = DataTB.DefaultView;
                    ComboBoxname.DataSource = DataTB.AsDataView();
                    ComboBoxname.ValueMember = valueid;
                    ComboBoxname.DisplayMember = valuedisplay;

                }
                else

                    ComboBoxname.DataSource = null;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region List To DataTable
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
        #endregion

        #region --ListBoxBind--

        public static void BindCheckedListBoxData(CheckedListBox CheckedListBoxname, DataTable dt, string ColumName)
        {
            int i = 0;

            CheckedListBoxname.DataSource = null;
            CheckedListBoxname.Items.Clear();
            while (dt.Rows.Count > i)
            {
                CheckedListBoxname.Items.Add(dt.Rows[i][ColumName].ToString());
                i++;
            }
        }

        #endregion
        public static double ParseValue(string value)
        {
            return double.Parse(string.Join("",
                value.Select(c => "+-.".Contains(c)
                   ? "" + c : "" + char.GetNumericValue(c)).ToArray()),
                NumberFormatInfo.InvariantInfo);
        }

        public static long ParseValueI(string value)
        {
            return long.Parse(string.Join("",
                value.Select(c => "+-.".Contains(c)
                   ? "" + c : "" + char.GetNumericValue(c)).ToArray()),
                NumberFormatInfo.InvariantInfo);
        }
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "0123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        public static DateTime startDate(DateTime date)
        {
            string startDate;
            if(date.Month<4)
            {
                startDate = "01" + "/" + "04" + "/" + (date.Year - 1).ToString();
                return (Convert.ToDateTime(startDate));
            }
            else
            {
                startDate = "01" + "/" + "04" + "/" + (date.Year).ToString();
                return (Convert.ToDateTime(startDate));
            }
        }
        //public Utility()
        //{
        //    // TODO: Complete member initialization
        //}
        public static string NumberToWord(long Number)
        {
            try
            {
                if (Number == 0)
                {
                    return "Zero";
                }
                if (Number < 0)
                {
                    return "Minus" + NumberToWord(Math.Abs(Number));
                }
                string words = "";
                if ((Number / 100000) > 0)
                {
                    words += NumberToWord(Number / 100000) + " " + "Lakhs ";
                    Number %= 100000;

                }
                if ((Number / 1000) > 0)
                {
                    words += NumberToWord(Number / 1000) + " " + "Thousands ";
                    Number %= 1000;
                }
                if ((Number / 100) > 0)
                {
                    words += NumberToWord(Number / 100) + " " + "Hundred ";
                    Number %= 100;
                }
                //if ((Number / 10) > 0)
                //{
                //    words += NumberToWord(Number / 10) + "Rupees";
                //    Number %= 10;
                //}
                if (Number > 0)
                {
                    if (words != "")
                    {
                        words += " " + "And ";
                    }
                    var unitsMap = new[] 
                {
                    "Zero","One ","Two ","Three ","Four ","Five ","Six ","Seven ","Eigth ","Nine ","Ten ","Eleven ","Twelve ","Thirteen ","Fourteen ","Fifteen ","Sixteen ","Seventeen ","Eighteen ","Nineteen "
                };
                    var tenMap = new[] 
                {
                    "Zero","Ten","Twenty","Thirty","Fourty","Fifty","Sixty","Seventy","Eighty","Ninety"
                };
                    if (Number < 20)
                    {
                        words += " " + unitsMap[Number];
                    }
                    else
                    {
                        words += tenMap[Number / 10];
                        if ((Number % 10) > 0)
                        {
                            words += " " + unitsMap[Number % 10];
                        }
                    }
                }
                return words;
            }
            catch
            { throw; }
        }
        public static string NumberToWordMarathi(long Number)
        {
            try
            {
                if (Number == 0)
                {
                    return "झिरो";
                }
                if (Number < 0)
                {
                    return "Minus" + NumberToWordMarathi(Math.Abs(Number));
                }
                string words = "";
                if ((Number / 100000) > 0)
                {
                    words += NumberToWordMarathi(Number / 100000) + " " + "लाख ";
                    Number %= 100000;

                }
                if ((Number / 1000) > 0)
                {
                    words += NumberToWordMarathi(Number / 1000) + " " + "हजार ";
                    Number %= 1000;
                }
                if ((Number / 100) > 0)
                {
                    if ((Number / 100)==9)
                    {
                        words += " " + "नऊशे ";
                    }
                    if ((Number / 100) == 8)
                    {
                        words += " " + "आठशे ";
                    }
                    if ((Number / 100) == 7)
                    {
                        words += " " + "सातशे ";
                    }
                    if ((Number / 100) == 6)
                    {
                        words += " " + "साहशे ";
                    }
                    if ((Number / 100) == 5)
                    {
                        words += " " + "पाचशे ";
                    }
                    if ((Number / 100) == 4)
                    {
                        words += " " + "चारशे ";
                    }
                    if ((Number / 100) == 3)
                    {
                        words += " " + "तीनशे ";
                    }
                    if ((Number / 100) == 2)
                    {
                        words += " " + "दोनशे ";
                    }
                    if ((Number / 100) == 1 && (Number % 100)==0)
                    {
                        words += " " + "शंभर";
                        
                    }
                    else
                    {
                         if ((Number / 100) == 1)
                         {
                             words += " " + "एकशे";
                         }
                    }
                  //  words += NumberToWordMarathi(Number / 900) + " " + "नऊशे ";
                    Number %= 100;
                }
                //if ((Number / 10) > 0)
                //{
                //    words += NumberToWord(Number / 10) + "रुपय";
                //    Number %= 10;
                //}
                if (Number > 0)
                {
                    if (words != "")
                    {
                        words += " ";
                    }

                    var unitsMap = new[] 
                {
                                      
                    "शून्य","एक ","दोन ","तीन ","चार ","पाच ","सहा ","सात ","आठ ","नऊ ","दहा ","अकरा ","बारा ","तेरा ","चौदा ","पंधरा ","सोहळा ","सतरा ","आठरा ","एकोणीस " ,
                    "वीस","एकवीस","बावीस","तेवीस","चोवीस","पंचवीस","सव्वीस","सत्तावीस","अठ्ठावीस","एकोणतीस","तीस","एकतीस","बत्तीस","तेहेतीस","चौतीस","पस्तीस","छत्तीस","सदतीस","अडतीस","एकोणचाळीस",
                    "चाळीस","एक्केचाळीस","बेचाळीस","त्रेचाळीस","चव्वेचाळीस","पंचेचाळीस","सेहेचाळीस","सत्तेचाळीस","अठ्ठेचाळीस","एकोणपन्नास","पन्नास","एक्कावन्न",
                    "बावन्न","त्रेपन्न","चोपन्न","पंचावन्न","छप्पन्न","सत्तावन्न","अठ्ठावन्न","एकोणसाठ","साठ","एकसष्ठ","बासष्ठ","त्रेसष्ठ","चौसष्ठ","पासष्ठ","सहासष्ठ","सदुसष्ठ","अडुसष्ठ","एकोणसत्तर","सत्तर","एक्काहत्तर","बाहत्तर",
                    "त्र्याहत्तर","चौर्‍याहत्तर","पंच्याहत्तर","शहात्तर","सत्याहत्तर","अठ्ठ्याहत्तर","एकोण ऐंशी","ऐंशी","एक्क्याऐंशी","ब्याऐंशी","त्र्याऐंशी","चौऱ्याऐंशी","पंच्याऐंशी","शहाऐंशी","सत्त्याऐंशी","अठ्ठ्याऐंशी","एकोणनव्वद","नव्वद",
                    "एक्क्याण्णव","ब्याण्णव","त्र्याण्णव","चौऱ्याण्णव","पंच्याण्णव","शहाण्णव","सत्त्याण्णव","अठ्ठ्याण्णव","नव्व्याण्णव"

                };
                    var tenMap = new[] 
                {
                    "झिरो","दहा","वीस","तीस","चाळीस","पन्नास","साठ","सतर","ऐशी","नव्वद"
                };

                    if (Number < 100)
                    {
                        words += " " + unitsMap[Number];
                    }
                    else
                    {
                        words += tenMap[Number / 10];
                        if ((Number % 10) > 0)
                        {
                            words += "  " + unitsMap[Number % 10];
                        }
                    }

                }
                return words;
            }
            catch
            { throw; }
        }

        //set server name run time
        //public static ConnectionInfo crystalreport()
        //{
        //    //define
        //    try
        //    {
        //        ConnectionInfo crConnectionInfo = new ConnectionInfo();

        //        //click
        //        string servername = "", database = "",UserId="",password="";

        //        DataTable dtserver = ReportController.getServer();
        //      if(dtserver.Rows.Count>0)
        //      {
        //          servername=dtserver.Rows[0].["servername"];
        //            database=dtserver.Rows[0].["database"];
        //            UserId=dtserver.Rows[0].["UserId"];
        //            password=dtserver.Rows[0].["password"];
        //      }
               
               

        //        //Setup the connection information structure to log on to the data source for the //report. If using ODBC, this should be the DSN. If using OLEDB, etc, this should be //the physical server name
        //        crConnectionInfo.ServerName = servername;
        //        // If you are connecting to Oracle there is no DatabaseName. Use an empty string i.e. crConnectionInfo.DatabaseName = "";
        //        crConnectionInfo.DatabaseName = database;
        //        //crConnectionInfo.UserID = "sa";
        //        //crConnectionInfo.Password = "a";
        //        crConnectionInfo.IntegratedSecurity = true;
        //        return crConnectionInfo;
        //    }
        //    catch (Exception ae)
        //    {
        //        throw ae;
        //        MessageBox.Show(ae.ToString());
        //    }
        //}

        //***************************************************************************************************************************************************
        //
        //
        //                  Business Calculation part
        //
        //
        //****************************************************************************************************************************************************

        public static void SingleDecimal(System.Object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        public static void ShowAccountForm()
        {
            try
            {
                new frmAccountDetails().ShowDialog();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //DataGrid to DataTable
        public static DataTable dataGridToDataTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {

                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }
    }
}
