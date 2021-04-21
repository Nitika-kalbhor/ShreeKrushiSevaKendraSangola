using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using DataAccessLayer.controller;
using System.Threading;
using Dlogic_Wholesaler.ReportFrom;

namespace Dlogic_Wholesaler.Forms
{
    public partial class UCfrmHome : UserControl
    {
        public UCfrmHome()
        {
            InitializeComponent();
            timer1.Start();
            //  getReorderDetail();
        }
        private Thread thread;
        private void txtSreachch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSreachch.Text != string.Empty)
                {
                    DataTable dtStocktable = stockController.getSreachStockItem(txtSreachch.Text.ToString());
                    getStockDetails(dtStocktable);
                }
                else
                {
                    DataTable dtStocktable = stockController.getStockDetails(0, 0, 0, "AllStock");
                    getStockDetails(dtStocktable);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //public void getReorderDetail()
        //{
        //    dgvReorder.DataSource = null;
        //    //  DataTable lstcustomerDetails = customerController.getCustomerDetails();
        //    dgvReorder.AutoGenerateColumns = false;
        //    dgvReorder.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
        //    dgvReorder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    dgvReorder.Font = new Font("Arial Unicode MS", 12);

        //    dgvReorder.EnableHeadersVisualStyles = false;

        //    dgvReorder.ColumnCount = 5;

        //    dgvReorder.Columns[0].Name = "categoryName";
        //    dgvReorder.Columns[0].HeaderText = "प्रकार";
        //    dgvReorder.Columns[0].DataPropertyName = "categoryName";


        //    dgvReorder.Columns[1].Name = "companyName";
        //    dgvReorder.Columns[1].HeaderText = "कंपनी";
        //    dgvReorder.Columns[1].DataPropertyName = "companyName";
        //    //   dgvStockRegister.Columns[1].Width = 400;

        //    dgvReorder.Columns[2].Name = "itemName";
        //    dgvReorder.Columns[2].HeaderText = "वस्तूचे नांव";
        //    dgvReorder.Columns[2].DataPropertyName = "itemName";
        //    dgvReorder.Columns[2].Width = 200;

        //    dgvReorder.Columns[3].Name = "currentStock";
        //    dgvReorder.Columns[3].HeaderText = "उपलब्ध नग";
        //    dgvReorder.Columns[3].DataPropertyName = "currentStock";
        //    dgvReorder.Columns[3].Width = 100;

        //    dgvReorder.Columns[4].Name = "reorderLevel";
        //    dgvReorder.Columns[4].HeaderText = "रि-ऑर्डर लेवल";
        //    dgvReorder.Columns[4].DataPropertyName = "reorderLevel";
        //    dgvReorder.Columns[4].Width = 100;
        //    dgvReorder.DataSource = stockController.getReorder().DefaultView;
        //}
        public void getStockDetails(DataTable dtStocktables)
        {
            try
            {
                dgvStockRegister.DataSource = null;
                //  DataTable lstcustomerDetails = customerController.getCustomerDetails();
                dgvStockRegister.AutoGenerateColumns = false;
                dgvStockRegister.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvStockRegister.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvStockRegister.Font = new Font("Arial Unicode MS", 9);

                dgvStockRegister.EnableHeadersVisualStyles = false;

                dgvStockRegister.ColumnCount = 19;

                if (Utility.Langn == "English")
                {
                    dgvStockRegister.Columns[0].HeaderText = "Godown";
                    dgvStockRegister.Columns[1].HeaderText = "MainCategory";
                    dgvStockRegister.Columns[2].HeaderText = "CategoryName";
                    dgvStockRegister.Columns[3].HeaderText = "Company";
                    dgvStockRegister.Columns[4].HeaderText = "Item Name";
                    dgvStockRegister.Columns[5].HeaderText = "weightIn";
                    dgvStockRegister.Columns[6].HeaderText = "Sale Rate(With GST)";
                    dgvStockRegister.Columns[7].HeaderText = "Batch No";
                    dgvStockRegister.Columns[8].HeaderText = "MFG Date";
                    dgvStockRegister.Columns[9].HeaderText = "Expiry Date";
                    dgvStockRegister.Columns[10].HeaderText = "Rack No";
                    dgvStockRegister.Columns[12].HeaderText = "Opening Stock";
                    dgvStockRegister.Columns[13].HeaderText = "Current Stock";
                    dgvStockRegister.Columns[14].HeaderText = "Purchase Stock";
                    dgvStockRegister.Columns[15].HeaderText = "Purchase Return Stock";
                    dgvStockRegister.Columns[16].HeaderText = "Sale Stock";
                    dgvStockRegister.Columns[17].HeaderText = "Sale Return Stock";
                    dgvStockRegister.Columns[18].HeaderText = "Purchase Rate";
                }
                else
                {
                    dgvStockRegister.Columns[0].HeaderText = "गोडाऊन";
                    dgvStockRegister.Columns[1].HeaderText = "प्रकार";
                    dgvStockRegister.Columns[2].HeaderText = "उप-प्रकार";
                    dgvStockRegister.Columns[3].HeaderText = "कंपनी";
                    dgvStockRegister.Columns[4].HeaderText = "वस्तूचे नांव";
                    dgvStockRegister.Columns[5].HeaderText = "पॅकिंग";
                    dgvStockRegister.Columns[6].HeaderText = "विक्री दर(With GST)";
                    dgvStockRegister.Columns[7].HeaderText = "बॅच नं";
                    dgvStockRegister.Columns[8].HeaderText = "MFG दिनांक";
                    dgvStockRegister.Columns[9].HeaderText = "एक्स दिनांक";
                    dgvStockRegister.Columns[10].HeaderText = "रॅक नं";
                    dgvStockRegister.Columns[12].HeaderText = "आरंभी नग";
                    dgvStockRegister.Columns[13].HeaderText = "उपलब्ध नग";
                    dgvStockRegister.Columns[14].HeaderText = "खरेदी नग";
                    dgvStockRegister.Columns[15].HeaderText = "खरेदी परत नग";
                    dgvStockRegister.Columns[16].HeaderText = "सेल नग";
                    dgvStockRegister.Columns[17].HeaderText = "सेल परत नग";
                    dgvStockRegister.Columns[18].HeaderText = "खरेदी दर";
                }

                dgvStockRegister.Columns[0].Name = "godownName";               
                dgvStockRegister.Columns[0].DataPropertyName = "godownName";

                dgvStockRegister.Columns[1].Name = "mainCategory";               
                dgvStockRegister.Columns[1].DataPropertyName = "mainCategory";

                dgvStockRegister.Columns[2].Name = "categoryName";               
                dgvStockRegister.Columns[2].DataPropertyName = "categoryName";


                dgvStockRegister.Columns[3].Name = "companyName";               
                dgvStockRegister.Columns[3].DataPropertyName = "companyName";
                dgvStockRegister.Columns[3].Width = 150;
                //   dgvStockRegister.Columns[1].Width = 400;

                dgvStockRegister.Columns[4].Name = "itemName";               
                dgvStockRegister.Columns[4].DataPropertyName = "itemName";
                dgvStockRegister.Columns[4].Width = 150;

                dgvStockRegister.Columns[5].Name = "weightIn";               
                dgvStockRegister.Columns[5].DataPropertyName = "weightIn";
                dgvStockRegister.Columns[5].Width = 80;

                dgvStockRegister.Columns[6].Name = "finalPrice";               
                dgvStockRegister.Columns[6].DataPropertyName = "finalPrice";
                dgvStockRegister.Columns[6].Width = 100;

                dgvStockRegister.Columns[7].Name = "batchNo";               
                dgvStockRegister.Columns[7].DataPropertyName = "batchNo";
                dgvStockRegister.Columns[7].Width = 80;

                dgvStockRegister.Columns[8].Name = "MFD_Date";              
                dgvStockRegister.Columns[8].DataPropertyName = "MFD_Date";
                dgvStockRegister.Columns[8].Width = 100;

                dgvStockRegister.Columns[9].Name = "expireDate";              
                dgvStockRegister.Columns[9].DataPropertyName = "expireDate";
                dgvStockRegister.Columns[9].Width = 100;

                dgvStockRegister.Columns[10].Name = "rackNo";               
                dgvStockRegister.Columns[10].DataPropertyName = "rackNo";
                dgvStockRegister.Columns[10].Width = 150;
                dgvStockRegister.Columns[10].Visible = false;

                dgvStockRegister.Columns[11].Name = "color";
                dgvStockRegister.Columns[11].HeaderText = "Color";
                dgvStockRegister.Columns[11].DataPropertyName = "color";
                dgvStockRegister.Columns[11].Visible = false;

                dgvStockRegister.Columns[12].Name = "openingStock";               
                dgvStockRegister.Columns[12].DataPropertyName = "openingStock";
                dgvStockRegister.Columns[12].Visible = false;

                dgvStockRegister.Columns[13].Name = "currentStock";               
                dgvStockRegister.Columns[13].DataPropertyName = "currentStock";

                dgvStockRegister.Columns[14].Name = "purchaseStock";                
                dgvStockRegister.Columns[14].DataPropertyName = "purchaseStock";
                dgvStockRegister.Columns[14].Visible = false;

                dgvStockRegister.Columns[15].Name = "purchaseReturnStock";              
                dgvStockRegister.Columns[15].DataPropertyName = "purchaseReturnStock";
                dgvStockRegister.Columns[15].Visible = false;

                dgvStockRegister.Columns[16].Name = "saleStock";               
                dgvStockRegister.Columns[16].DataPropertyName = "saleStock";
                dgvStockRegister.Columns[16].Visible = false;

                dgvStockRegister.Columns[17].Name = "saleReturnStock";                
                dgvStockRegister.Columns[17].DataPropertyName = "saleReturnStock";
                dgvStockRegister.Columns[17].Visible = false;

                dgvStockRegister.Columns[18].Name = "purchaseRate";               
                dgvStockRegister.Columns[18].DataPropertyName = "purchaseRate";
                //  dgvStockRegister.Columns[16].Visible = false;
                dgvStockRegister.DataSource = dtStocktables;


            }
            catch (Exception)
            {
                ////MessageBox.Show("Something went wrong in gridview");
            }

        }

        private void UCfrmHome_KeyDown(object sender, KeyEventArgs e)
        {

        }
        bool ltr = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
               if(label1.Right<-100)
               {
                   label1.Left = label1.Right + 1217;
               }
               else
               {
                   label1.Left -= 2;
               }
            }
            catch (Exception ae)
            {

            }
        }
        private void UCfrmHome_Load(object sender, EventArgs e)
        {

            DataTable dtExpire = expireReportController.getExpireReport(Convert.ToDateTime(DateTime.Now.ToShortDateString()), Convert.ToDateTime(DateTime.Now.AddMonths(3).ToShortDateString()));
            string expiryProduct = "";
            if (dtExpire.Rows.Count > 0)
                foreach (DataRow dr in dtExpire.Rows)
                {
                    expiryProduct += "   " + dr["companyName"] + '-' + dr["itemName"] + '-' + dr["unitBy"] + "-Batch-" + dr["batchNo"] + "-Exp. Date-" + dr["expireDate"] + '-' + dr["currentStock"]+"-Qty";
                }
            label1.Text = expiryProduct;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UCfrmHome_Load(sender, e);
        }
        public string timmer2="0";
        private void timer2_Tick(object sender, EventArgs e)
        {
                timer1.Start();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmExpireReport frm = new frmExpireReport();
            frm.ShowDialog();
        }
    }
      
}
