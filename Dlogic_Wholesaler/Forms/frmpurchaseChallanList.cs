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
    public partial class frmpurchaseChallanList : MetroForm 
    {
        public frmpurchaseChallanList()
        {
            InitializeComponent();
        }
        // add a delegate
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
                    dgvSaleChallan.Columns[2].HeaderText = "Dealer Firm Name";
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
        public void BindComboBoxgetDealerName()
        {
            DataTable dtgetDealerName = DealerController.getDealerDetails();
            Utility.BindComboBoxDataSelect(cmbDealerName, dtgetDealerName, "dealerId", "dealerFirmName");
        }
        private void frmSaleChallanList_Load(object sender, EventArgs e)
        {
            BindComboBoxgetDealerName();
           
            dtpFromChallanDate.MinDate = Utility.firstDate;
            dtpFromChallanDate.MaxDate = Utility.lastDate;
            dtpToChallanDate.MinDate = Utility.firstDate;
            dtpToChallanDate.MaxDate = Utility.lastDate;
         
            dtpFromChallanDate.Value = Utility.firstDate;
            dtpToChallanDate.Value = Utility.lastDate;
            Lang();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDealerName.SelectedIndex == 0)
                {
                    
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("Please selet dealer name");
                    }
                    else
                    {
                        MessageBox.Show("कृपया व्यापारी नाव निवडा.");
                    }
                    cmbDealerName.Focus();
                    return;

                }
                else
                {
                    DataTable dtChallaneList = purchaseDetailsController.getChallenList(Convert.ToInt64(cmbDealerName.SelectedValue),Convert.ToDateTime(dtpFromChallanDate.Value.ToShortDateString()),Convert.ToDateTime(dtpToChallanDate.Value.ToShortDateString()),Utility.FinancilaYearId);
                    dgvSaleChallan.DataSource = dtChallaneList;
                   
                    dgvSaleChallan.ReadOnly = false;
                    dgvSaleChallan.Columns[0].ReadOnly=true;
                    dgvSaleChallan.Columns[1].ReadOnly = true;
                    dgvSaleChallan.Columns[2].ReadOnly = true;
                    dgvSaleChallan.Columns[3].ReadOnly = true;
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }

        private void btnGenrateInvoice_Click(object sender, EventArgs e)
        {
            DataTable PurchaseChallan= new DataTable();
            foreach (DataGridViewColumn col in dgvSaleChallan.Columns)
            {
                PurchaseChallan.Columns.Add(col.Name);
            }

            for (int i = 0; i < dgvSaleChallan.Rows.Count; i++)
            {
                DataRow dRow = PurchaseChallan.NewRow();
                if (Convert.ToBoolean(dgvSaleChallan.Rows[i].Cells[5].Value) == true)
                {
                    dRow[0] = dgvSaleChallan.Rows[i].Cells[0].Value;
                    dRow[1] = dgvSaleChallan.Rows[i].Cells[1].Value;
                    dRow[2] = dgvSaleChallan.Rows[i].Cells[2].Value;
                    dRow[3] = dgvSaleChallan.Rows[i].Cells[3].Value;
                    dRow[4] = dgvSaleChallan.Rows[i].Cells[4].Value;
                    dRow[5] = dgvSaleChallan.Rows[i].Cells[5].Value;
                    PurchaseChallan.Rows.Add(dRow);
                }
               
            }

            // instance the event args and pass it each value
            IdentityUpdateEventArgs args = new IdentityUpdateEventArgs(PurchaseChallan);

            // raise the event with the updated arguments
            IdentityUpdated(this, args);
            this.Dispose();
        }
    }
}
