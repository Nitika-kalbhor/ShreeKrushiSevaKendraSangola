using DataAccessLayer.controller;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class frmNexPaymentDate : MetroForm
    {
        public frmNexPaymentDate()
        {
            InitializeComponent();
        }

        private void frmNexPaymentDate_Load(object sender, EventArgs e)
        {
             BindComboBoxgetaccountName();
        }
        public void BindComboBoxgetaccountName()
        {
            try
            {
                DataTable dtvillageId = accountDetailsController.getaccountName(Convert.ToInt32(0));
                Utility.BindComboBoxEmptyDataSelect(cmbAccountname, dtvillageId, "accountId", "accountName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbAccountname.SelectedIndex <= 0)
            {
                MessageBox.Show("कृपया खाते निवडा.");
                return;
            }
            int result = notificationController.AddNewNotification(Convert.ToInt64(cmbAccountname.SelectedValue), Convert.ToDateTime(dtpNextPaymentDetails.Value));
            if (result >= 1)
            {
                MessageBox.Show("सदर माहिती यशस्वीरीत्या साठवली गेली आहे.");
            }
            else
            {
                MessageBox.Show("माहिती साठविण्यास त्रुटी येत आहे.");
            }
            BindComboBoxgetaccountName();
        }
    }
}
