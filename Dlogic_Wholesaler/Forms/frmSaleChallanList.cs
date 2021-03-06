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

namespace Dlogic_Wholesaler.Forms
{
    public partial class frmSaleChallanList : MetroForm
    {
        public frmSaleChallanList()
        {
            InitializeComponent();
        }
        public delegate void IdentityUpdateHandler(object sender, IdentityUpdateEventArgs e);

        // add an event of the delegate type
        public event IdentityUpdateHandler IdentityUpdated;

        public class IdentityUpdateEventArgs : System.EventArgs
        {
            // add local member variable to hold text
            private DataTable mdt;

            // class constructor
            public IdentityUpdateEventArgs(DataTable sdt)           
            {
                this.mdt = sdt;

            }

            // Properties - Accessible by the listener

            public DataTable dt
            {
                get
                {
                    return mdt;
                }
            }


        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Purchase Chalan";

                    label2.Text = "From Date:";
                    label3.Text = "To Date:";
                    btnShow.Text = "Show";
                    btnGenrateInvoice.Text = "Generate Bill";

                    dgvSaleChallan.Columns[0].HeaderText = "Chalan No.";
                    dgvSaleChallan.Columns[2].HeaderText = "Customer Name";
                    dgvSaleChallan.Columns[3].HeaderText = "Chalan Date";
                    dgvSaleChallan.Columns[4].HeaderText = "Amount";
                    dgvSaleChallan.Columns[5].HeaderText = "Is Invoice";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public void BindComboBoxgetCustomerName()
        {
            DataTable dtCustomerName = customerController.getCustomerDetails();
            Utility.BindComboBoxEmptyDataSelect(cmbCustomerName, dtCustomerName, "customerId", "customerName");
        }
        private void frmSaleChallanList_Load(object sender, EventArgs e)
        {
            BindComboBoxgetCustomerName();
            dtpFromChallanDate.MinDate = dtpToChallanDate.MinDate = Utility.firstDate;
            dtpFromChallanDate.MaxDate = dtpToChallanDate.MaxDate = Utility.lastDate;
            dtpFromChallanDate.Value = Utility.firstDate;
            dtpToChallanDate.Value = Utility.lastDate;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomerName.SelectedIndex == 0)
                {
                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please Select customer name");
                    }
                    else
                    {
                        MessageBox.Show("कृपया ग्राहक  निवडा");
                    }
                    cmbCustomerName.Focus();
                    return;
                }
                else
                {
                    DataTable dtChallaneList = SaleDetailsController.getChallenList(Convert.ToInt64(cmbCustomerName.SelectedValue), Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()), Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);
                    dgvSaleChallan.DataSource = dtChallaneList; 
                    dgvSaleChallan.ReadOnly = false;
                    dgvSaleChallan.Columns[0].ReadOnly = true;
                    dgvSaleChallan.Columns[1].ReadOnly = true;
                    dgvSaleChallan.Columns[2].ReadOnly = true;
                    dgvSaleChallan.Columns[3].ReadOnly = true;
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void btnGenrateInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable saleChallan = new DataTable();
                foreach (DataGridViewColumn col in dgvSaleChallan.Columns)
                {
                    saleChallan.Columns.Add(col.Name);
                } 
                if (cmbCustomerName.Text == string.Empty)
                {
                    
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please select customer name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("कृपया ग्राहकाचे नाव निवडा.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmbCustomerName.Focus();
                    return;
                }
                for (int i = 0; i < dgvSaleChallan.Rows.Count; i++)
                {
                    DataRow dRow = saleChallan.NewRow();
                    if (Convert.ToBoolean(dgvSaleChallan.Rows[i].Cells["isConvert"].Value) == true)
                    {
                        dRow[0] = dgvSaleChallan.Rows[i].Cells[0].Value;
                        dRow[1] = dgvSaleChallan.Rows[i].Cells[1].Value;
                        dRow[2] = dgvSaleChallan.Rows[i].Cells[2].Value;
                        dRow[3] = dgvSaleChallan.Rows[i].Cells[3].Value;
                        dRow[4] = dgvSaleChallan.Rows[i].Cells[4].Value;
                        dRow[5] = dgvSaleChallan.Rows[i].Cells[5].Value;
                        saleChallan.Rows.Add(dRow);
                    }
                }
                // instance the event args and pass it each value
                IdentityUpdateEventArgs args = new IdentityUpdateEventArgs(saleChallan);

                // raise the event with the updated arguments
                IdentityUpdated(this, args);
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
