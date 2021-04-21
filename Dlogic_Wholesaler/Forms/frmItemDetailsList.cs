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
    public partial class frmItemDetailsList : MetroForm
    {
        public delegate void IdentityUpdateHandler(object sender, IndentityUpdateEventArgs e);
        public event IdentityUpdateHandler IdentityUpdated;
        public frmItemDetailsList()
        {
            InitializeComponent();
        }

        public class IndentityUpdateEventArgs : System.EventArgs
        {
            private long mStockId;
            public IndentityUpdateEventArgs(long sStockId)
            {
                this.mStockId = sStockId;
            }
            public long StockId
            {
                get
                {
                    return mStockId;
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
                    lblHerader.Text = "Item Details";
                    metroLabel1.Text = "Item Name:";
                    metroLabel2.Text = " * Double Click mouse on Item Name";
                    dgvItemDetails.Columns["godownName"].HeaderText = "Godown";
                    dgvItemDetails.Columns["companyName"].HeaderText = "Company";
                    dgvItemDetails.Columns["categoryName"].HeaderText = "Category ";
                    dgvItemDetails.Columns["itemName"].HeaderText = "Item Name";
                    dgvItemDetails.Columns["unitBy"].HeaderText = "Unit By";
                    dgvItemDetails.Columns["batchNo"].HeaderText = "Batch No.";
                    dgvItemDetails.Columns["price"].HeaderText = "Rate";
                     dgvItemDetails.Columns["openingStock"].HeaderText = "Opening Quantity";
                     dgvItemDetails.Columns["currentStock"].HeaderText = "Available Quantity";
                     dgvItemDetails.Columns["StockId"].HeaderText = "StockId";
                     dgvItemDetails.Columns["productCode"].HeaderText = "Product Code";
                     dgvItemDetails.Columns["rackNo"].HeaderText = "Rack No";
                     dgvItemDetails.Columns["HNSCode"].HeaderText = "HSNCode";
                    dgvItemDetails.Columns["MRP"].HeaderText = "MRP";
                    dgvItemDetails.Columns["IGST"].HeaderText = "IGST(%)";
                    dgvItemDetails.Columns["CGST"].HeaderText = "CGST(%)";
                    dgvItemDetails.Columns["SGST"].HeaderText = "SGST(%)";                  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public void getItemDetails()
        {
            DataTable dt = stockController.getIemList("getItemDetailsList", 0);
            dgvItemDetails.DataSource = dt;
        }
        private void frmItemDetailsList_Load(object sender, EventArgs e)
        {
            getItemDetails();
            Lang();
        }
        //  public bool isUpdate = false;

        private void frmItemDetailsList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtHNSCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvItemDetails.Rows)
                {
                    string s = row.Cells["itemName"].Value.ToString();

                    if (!s.StartsWith(txtHNSCode.Text, true, null))
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvItemDetails.DataSource];
                        currencyManager1.SuspendBinding();
                        row.Visible = false;
                        currencyManager1.ResumeBinding();
                        dgvItemDetails.Visible = true;
                    }
                    else
                        row.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvItemDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvItemDetails.Rows[e.RowIndex];

                    if (row.Cells != null)
                    {
                        long SID = Convert.ToInt64(row.Cells["StockId"].Value.ToString());

                        IndentityUpdateEventArgs args = new IndentityUpdateEventArgs(SID);

                        IdentityUpdated(this, args);
                        this.Dispose();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
