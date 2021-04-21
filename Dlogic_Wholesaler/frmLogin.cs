using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dlogic_Wholesaler.Forms;
using DataAccessLayer.controller;
using DataAccessLayer.models;
using MetroFramework.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Dlogic_Wholesaler.CrystalReport;
using System.Configuration;


namespace Dlogic_Wholesaler
{
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static int LoginID = 0;
        public static string UserName = "";
        public static string Financialyear="";
        public static long FinancilaYearId=0;
        public static DateTime firstDate;
        public static DateTime lastDate;
        public static DataTable value;
        public static DataTable billInfoDt;
        public static string Lang = "";

        private void btnNewItem_Click(object sender, EventArgs e)
        {
           

            try {
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Please Enter UserName..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    txtUserName.Text = "";
                    txtpwd.Text = "";
                }
                else if (txtpwd.Text == "")
                {
                    MessageBox.Show("Please Enter Password..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    txtUserName.Text = "";
                    txtpwd.Text = "";
                }
                else if(cmbLanguage.SelectedIndex<0)
                {
                    MessageBox.Show("Please Select Language", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbLanguage.Focus();
                }
                else
                {

                    Utility.dtGenericBillInfo = billInfoDt;//.AsEnumerable().Where(x => x.Field<string>("ShopNameCity") == "सुवर्णमाया कृषी उद्योग,मायणी").CopyToDataTable(); 
                       // == Convert.ToInt32(cmbBillInfo.SelectedValue)).CopyToDataTable();
                    if(Utility.dtGenericBillInfo.Rows.Count<=0)
                    {
                        MessageBox.Show("Sorry can't get you logged in");
                        return;
                    }
                    DataSet ds = LoginController.getLogin(txtUserName.Text, txtpwd.Text, Convert.ToInt64(cmbFinancialyear.SelectedValue));
                    DataTable dtSetting = SettingsController.getSettings();
                    if(ds.Tables[0].Rows.Count>0)
                    {
                        LoginID = Convert.ToInt32(ds.Tables[0].Rows[0]["userDetailsId"]);
                        UserName = Convert.ToString(ds.Tables[0].Rows[0]["userPassword"]);
                        Financialyear = Convert.ToString(ds.Tables[1].Rows[0]["FinancialYear"]);
                        FinancilaYearId = Convert.ToInt64(ds.Tables[1].Rows[0]["FinancialYearId"]);
                        firstDate = Convert.ToDateTime(ds.Tables[1].Rows[0]["FinancialYearStartDate"]);
                        lastDate = Convert.ToDateTime(ds.Tables[1].Rows[0]["FinancialYearEndDate"]);
                        Lang = Convert.ToString(cmbLanguage.SelectedItem);
                        
                        
                        if (dtSetting.Rows.Count > 0)
                        {
                            Utility.isSingleMultipalPrint = Convert.ToBoolean(dtSetting.Rows[0]["isSingleMultipalPrint"]);
                        }
                        else
                        {
                            Utility.isSingleMultipalPrint = false;
                        }
                        if (dtSetting.Rows.Count > 1)
                        {
                            Utility.isPeview = Convert.ToBoolean(dtSetting.Rows[1]["isSingleMultipalPrint"]);
                        }
                        else
                        {
                            Utility.isPeview = true;
                        }
                        Utility.isEnglishBill = Convert.ToBoolean(ConfigurationManager.AppSettings["isEnglishBill"].ToString());
                        Utility.SetLogin(LoginID, UserName,Lang,Financialyear, FinancilaYearId, firstDate, lastDate);
                        frmNewIndex frm = new frmNewIndex();
                        frm.Show();
                        this.Hide();
                        int i = accountGroupController.getBackup();
                    }
                    else
                    {
                        MessageBox.Show("Please check Username or Password...!");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public  void BindFinincialYear(long financialYear)
        {
            DataTable dt = LoginController.getFinancialYear(financialYear);
            Utility.BindComboBoxData(cmbFinancialyear, dt, "FinancialYearId", "FinancialYear");

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
                        
            DataTable  dt  = BillController.getBill();
            billInfoDt = dt.Copy();
            Utility.BindComboBoxData(cmbBillInfo, dt, "ID", "ShopNameCity");
            cmbLanguage.SelectedIndex = 0;

            
 
            txtUserName.Focus();
            BindFinincialYear(0);

        }

        

      
    }
}
