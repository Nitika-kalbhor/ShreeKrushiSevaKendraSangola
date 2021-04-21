using DataAccessLayer.controller;
using DataAccessLayer.models;
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
    public partial class frmStockConversion : MetroForm
    {
        public frmStockConversion()
        {
            InitializeComponent();
        }
        long stockconversionId = 0;
        long stockConversionInvoiceID = 0;
        long stockFromID=0;
        long stockToId=0;
        bool isDelete = false;
        private void frmStockConversion_Load(object sender, EventArgs e)
        {
            dgvItemName.Hide();
            dgvItem1.Hide();
            Utility.ClearSpace(this);
            Utility.disableFields(this);

            btnSave.Enabled = false;
          
            // dgvPurchaseItems.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            //  dgvPurchaseItems.RowHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
           
            dgvItemName.Hide();
            dtpChallenDate.MaxDate = Utility.lastDate;
            dtpChallenDate.MinDate = Utility.firstDate;
            dtpChallenDate.MinDate = Utility.firstDate;
            //dtpFromChallanDate.MaxDate = Utility.lastDate;
            //dtpToChallanDate.MinDate = Utility.firstDate;
            //dtpToChallanDate.MaxDate = Utility.lastDate;
            if (dtpChallenDate.Value < Utility.firstDate || dtpChallenDate.Value > Utility.lastDate)
            {
                dtpChallenDate.Value = Utility.firstDate;
            }
            Lang();
            //dtpFromChallanDate.Value = Utility.firstDate;
            //dtpToChallanDate.Value = Utility.lastDate;
        }
        #region --Lang--
        public void Lang()
        {
            try
            {
                if (Utility.Langn == "English")
                {
                    lblHerader.Text = "Stock Conversion";
                    metroLabel2.Text = "Conversion No:";
                    metroLabel1.Text = "Date:";
                    lblstockInNo.Text = "Item Name:";
                    label1.Text = "Conversion Qty:";
                    button1.Text = "New Item(F3)";
                    btnnew.Text = "New(Alt+N)";
                    btnSave.Text = "Save (Alt+S)";
                    btnConvertChallan.Text = "List";
                    btnDelete.Text = "Delete";
                    label4.Text = "Available Qty:";
                    label8.Text = "Available Qty";
                    label11.Text = "Item Name:";
                    label2.Text = "Batch No.";
                    label3.Text = "Godown:";
                    label10.Text = "Batch No.";
                    label9.Text = "Godown:";
                    label5.Text = "Conversion Qty:";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        private void btnnew_Click(object sender, EventArgs e)
        {
          
            Utility.ClearSpace(this);
            Utility.enableFields(this);
            btnSave.Enabled = true;
            lblBatchNo.Text = "";
            lblCurrentStock.Text = "";
            lblGodown.Text = "";
            lblTobatch.Text = "";
            lblToGodown.Text = "";
            lblToCurrentStock.Text = "";
            stockFromID = 0;
             stockToId = 0;
             dgvItemName.Hide();
             dgvItem1.Hide();
            stockConversionInvoiceID = stockConversionController.getMaxStockConversionId(Utility.FinancilaYearId);
            txtInvoiceNo.Text = stockConversionInvoiceID.ToString();
             isDelete = false;
            dtpChallenDate.MaxDate = Utility.lastDate;
            dtpChallenDate.MinDate = Utility.firstDate;
         
            if (dtpChallenDate.Value < Utility.firstDate || dtpChallenDate.Value > Utility.lastDate)
            {
                dtpChallenDate.Value = Utility.firstDate;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtItemName.Text != string.Empty)
            {
                DataTable dtitem = itemDetailsController.getStockInItemDetailsForConversion(txtItemName.Text);
                if (dtitem.Rows.Count > 0)
                {
                    dgvItemName.DataSource = dtitem;
                    dgvItemName.Columns[0].Visible = false;
                    dgvItemName.Columns[1].Width = 500;
                    dgvItemName.ClearSelection();
                    this.dgvItemName.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    dgvItemName.Show();
                }
            }
            else
            {
                dgvItemName.Hide();
            }
        }

        private void dgvItemName_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int rowIndex = e.RowIndex;
                    getDataFronCurentRow(rowIndex);
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void dgvItemName_CellDoubleClick(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        int rowIndex = dgvItemName.CurrentCell.OwningRow.Index;
                        getDataFronCurentRow(rowIndex);
                    }
                    catch (Exception ae)
                    {
                        MessageBox.Show(ae.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected void getDataFronCurentRow(int rowIndex)
        {
            try
            {
                 dgvItemName.Hide();
                 dgvItem1.Hide();
                 long StockId=0;
                 DataGridViewRow row = new DataGridViewRow();
                if(dgvItemName.Rows.Count>0)
                {
                     row = this.dgvItemName.Rows[rowIndex];
                    StockId = Convert.ToInt64(dgvItemName.CurrentRow.Cells["itemId"].Value);
                    DataTable dt = itemDetailsController.getStockInItemDetailsbyStockId(StockId);
                    txtItemName.Text = dt.Rows[0]["itemName"].ToString() + '-' + dt.Rows[0]["unitBy"].ToString();
                    lblBatchNo.Text = dt.Rows[0]["batchNo"].ToString();
                    lblGodown.Text = dt.Rows[0]["godownName"].ToString();
                    lblCurrentStock.Text = dt.Rows[0]["currentStock"].ToString();
                    stockFromID = StockId;
                    dgvItemName.DataSource = null;
                }
                if (dgvItem1.Rows.Count > 0)
                {
                    row = this.dgvItem1.Rows[rowIndex];
                    StockId = Convert.ToInt64(dgvItem1.CurrentRow.Cells["itemId"].Value);
                    DataTable dt = itemDetailsController.getStockInItemDetailsbyStockId(StockId);
                    txtToStock.Text = dt.Rows[0]["itemName"].ToString() + '-' + dt.Rows[0]["unitBy"].ToString();
                    lblTobatch.Text = dt.Rows[0]["batchNo"].ToString();
                    lblToGodown.Text = dt.Rows[0]["godownName"].ToString();
                    lblToCurrentStock.Text = dt.Rows[0]["currentStock"].ToString();
                    stockToId = StockId;
                    dgvItem1.DataSource = null;
                }
                if (row.Cells != null)
                {
                   
                }
            }
            catch(Exception ae)
            {
                MessageBox.Show("Error!", ae.ToString());
            }
        }

        private void txtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvItemName.Rows.Count>0)
            {
                dgvItemName.Focus();
                dgvItemName.CurrentCell = dgvItemName.CurrentRow.Cells["itemName"];
                dgvItemName.CurrentCell.Selected = true;
            }
        }

        private void txtToStock_TextChanged(object sender, EventArgs e)
        {
            if (txtToStock.Text != string.Empty)
            {
                DataTable dtitem = itemDetailsController.getStockInItemDetailsForConversion(txtToStock.Text);
                if (dtitem.Rows.Count > 0)
                {
                    dgvItem1.DataSource = dtitem;
                    dgvItem1.Columns[0].Visible = false;
                    dgvItem1.Columns[1].Width = 500;
                    dgvItem1.ClearSelection();
                    this.dgvItem1.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    dgvItem1.Show();
                }
            }
            else
            {
                dgvItem1.Hide();
            }
        }

        private void txtToStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvItem1.Rows.Count > 0)
            {
                dgvItem1.Focus();
                dgvItem1.CurrentCell = dgvItem1.CurrentRow.Cells["itemName"];
                dgvItem1.CurrentCell.Selected = true;
            }
        }

        private void dgvItem1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int rowIndex = e.RowIndex;
                    getDataFronCurentRow(rowIndex);
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void dgvItem1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        int rowIndex = dgvItem1.CurrentCell.OwningRow.Index;
                        getDataFronCurentRow(rowIndex);
                    }
                    catch (Exception ae)
                    {
                        MessageBox.Show(ae.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnConvertChallan_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            try{
            if(txtItemName.Text.Trim()==string.Empty)
            {
              
                if (Utility.Langn == "English")
                {
                    MessageBox.Show("Please Add item name.");
                }
                else
                {
                    MessageBox.Show("कृपया वस्तूचे नाव भरा.");
                }
                txtItemName.Focus();
                return;
            }
            if (txtQuantity.Text.Trim() == string.Empty)
            {
               
                if (Utility.Langn == "English")
                {
                    MessageBox.Show("Please add Quantity");
                }
                else
                {
                    MessageBox.Show("कृपया वस्तूचे नग भरा.");
                }
                txtItemName.Focus();
                return;
            }
            if (txtToStock.Text.Trim() == string.Empty)
            {
                if (Utility.Langn == "English")
                {
                    MessageBox.Show("Please Add To Stock.");
                }
                else
                {
                    MessageBox.Show("कृपया वस्तूचे नाव भरा.");
                }
                txtToStock.Focus();
                return;
            }
            if (txtToQuantity.Text.Trim() == string.Empty)
            {
                
                if (Utility.Langn == "English")
                {
                    MessageBox.Show("Please  add item quantity");
                }
                else
                {
                    MessageBox.Show("कृपया वस्तूचे नग भरा.");
                }
                txtToQuantity.Focus();
                return;
            }
            else
            {
                StockConversion stoConversion = new StockConversion();
                if(isDelete==true)
                {
                    stoConversion.stockConversionId=stockconversionId;
                }
                else
                {
                    stoConversion.stockConversionId=0;
                }
                stoConversion.stockConversionIvoiceId=txtInvoiceNo.Text.Trim();
                stoConversion.stockconversionDate = Convert.ToDateTime(dtpChallenDate.Value.ToLongDateString());
                stoConversion.stockFromID=stockFromID;
                stoConversion.stockToId=stockToId;
                stoConversion.fromQty=Utility.ParseValue(txtQuantity.Text.Trim());
                stoConversion.toQty=Utility.ParseValue(txtToQuantity.Text.Trim());
                stoConversion.financialYearID = Utility.FinancilaYearId;
                int result = stockConversionController.addStockConversion(stoConversion);
                if(result > 0)
                {
                    if(isDelete==true)
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("This record deleted successfully ... !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("सदर नोंद यशस्वीरित्या डिलीट केले गेले आहे ... !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (Utility.Langn == "English")
                        {
                            MessageBox.Show("This Record saved successfully..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("सदर नोंद यशस्वीरित्या साठवले गेले आहे..!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    btnnew_Click(sender, e);
                }
            }
            }
                catch(Exception ae)
            {                   
                    if (Utility.Langn == "English")
                    {
                        MessageBox.Show("While Saving this record error occurs");
                    }
                    else
                    {
                        MessageBox.Show("सदर रेकोर्ड साठवण्यास त्रुटी येत आहे");
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmItemDetails frm = new frmItemDetails();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvItem1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmStockConversion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.N && e.Alt)
                {
                    btnnew_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && e.Alt)
                {
                    btnSave_Click(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //if(Convert.ToInt64(cmbItemName.SelectedValue) > 0)
        //        {
        //            DataTable dt = itemDetailsController.getStockInItemDetailsbyStockId(Convert.ToInt64(cmbItemName.SelectedValue));
        //       if(dt.Rows.Count>0)
        //      {
        //          
        //        }
        // }
    }
}
