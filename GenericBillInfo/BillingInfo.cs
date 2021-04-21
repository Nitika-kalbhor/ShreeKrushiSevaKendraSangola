using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GenericBillInfo
{
    public partial class BillingInfo : Form
    {
        public BillingInfo()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void lblWBiyane_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNyayalin_Click(object sender, EventArgs e)
        {

        }

        private void lblKhate_Click(object sender, EventArgs e)
        {

        }

        private void lblBiyane_Click(object sender, EventArgs e)
        {

        }

        private void lblKitnashke_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSignature_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.lblShopNameCity = new System.Windows.Forms.Label();
            this.lblTaluka = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lbblMobileNo = new System.Windows.Forms.Label();
            this.lblGstNo = new System.Windows.Forms.Label();
            this.lblKhate = new System.Windows.Forms.Label();
            this.lblBiyane = new System.Windows.Forms.Label();
            this.lblKitaknaske = new System.Windows.Forms.Label();
            this.lblWKhate = new System.Windows.Forms.Label();
            this.lblWBiyane = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtTaluka = new System.Windows.Forms.TextBox();
            this.txtShopAndCity = new System.Windows.Forms.TextBox();
            this.txtWBiyane = new System.Windows.Forms.TextBox();
            this.txtWKirtaknashke = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.txtIfsc = new System.Windows.Forms.TextBox();
            this.txtWKhate = new System.Windows.Forms.TextBox();
            this.txtNyayalin = new System.Windows.Forms.TextBox();
            this.txtKitaknashke = new System.Windows.Forms.TextBox();
            this.txtBiyane = new System.Windows.Forms.TextBox();
            this.txtKhate = new System.Windows.Forms.TextBox();
            this.txtGst = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNyayalin = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.lblIfsc = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBillingDet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShopNameCity
            // 
            this.lblShopNameCity.AutoSize = true;
            this.lblShopNameCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopNameCity.Location = new System.Drawing.Point(16, 21);
            this.lblShopNameCity.Name = "lblShopNameCity";
            this.lblShopNameCity.Size = new System.Drawing.Size(124, 16);
            this.lblShopNameCity.TabIndex = 0;
            this.lblShopNameCity.Text = "SHOP AND CITY";
            // 
            // lblTaluka
            // 
            this.lblTaluka.AutoSize = true;
            this.lblTaluka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaluka.Location = new System.Drawing.Point(16, 72);
            this.lblTaluka.Name = "lblTaluka";
            this.lblTaluka.Size = new System.Drawing.Size(66, 16);
            this.lblTaluka.TabIndex = 1;
            this.lblTaluka.Text = "TALUKA";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(16, 128);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(82, 16);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "PRODUCT";
            // 
            // lbblMobileNo
            // 
            this.lbblMobileNo.AutoSize = true;
            this.lbblMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbblMobileNo.Location = new System.Drawing.Point(16, 213);
            this.lbblMobileNo.Name = "lbblMobileNo";
            this.lbblMobileNo.Size = new System.Drawing.Size(93, 16);
            this.lbblMobileNo.TabIndex = 3;
            this.lbblMobileNo.Text = "MOBILE_NO";
            // 
            // lblGstNo
            // 
            this.lblGstNo.AutoSize = true;
            this.lblGstNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGstNo.Location = new System.Drawing.Point(16, 259);
            this.lblGstNo.Name = "lblGstNo";
            this.lblGstNo.Size = new System.Drawing.Size(69, 16);
            this.lblGstNo.TabIndex = 4;
            this.lblGstNo.Text = "GST_NO";
            // 
            // lblKhate
            // 
            this.lblKhate.AutoSize = true;
            this.lblKhate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhate.Location = new System.Drawing.Point(21, 285);
            this.lblKhate.Name = "lblKhate";
            this.lblKhate.Size = new System.Drawing.Size(58, 16);
            this.lblKhate.TabIndex = 5;
            this.lblKhate.Text = "KHATE";
            // 
            // lblBiyane
            // 
            this.lblBiyane.AutoSize = true;
            this.lblBiyane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiyane.Location = new System.Drawing.Point(16, 318);
            this.lblBiyane.Name = "lblBiyane";
            this.lblBiyane.Size = new System.Drawing.Size(63, 16);
            this.lblBiyane.TabIndex = 6;
            this.lblBiyane.Text = "BIYANE";
            // 
            // lblKitaknaske
            // 
            this.lblKitaknaske.AutoSize = true;
            this.lblKitaknaske.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitaknaske.Location = new System.Drawing.Point(16, 341);
            this.lblKitaknaske.Name = "lblKitaknaske";
            this.lblKitaknaske.Size = new System.Drawing.Size(100, 16);
            this.lblKitaknaske.TabIndex = 7;
            this.lblKitaknaske.Text = "KITAKNASKE";
            // 
            // lblWKhate
            // 
            this.lblWKhate.AutoSize = true;
            this.lblWKhate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWKhate.Location = new System.Drawing.Point(366, 102);
            this.lblWKhate.Name = "lblWKhate";
            this.lblWKhate.Size = new System.Drawing.Size(80, 16);
            this.lblWKhate.TabIndex = 8;
            this.lblWKhate.Text = "W_KHATE";
            // 
            // lblWBiyane
            // 
            this.lblWBiyane.AutoSize = true;
            this.lblWBiyane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWBiyane.Location = new System.Drawing.Point(366, 28);
            this.lblWBiyane.Name = "lblWBiyane";
            this.lblWBiyane.Size = new System.Drawing.Size(85, 16);
            this.lblWBiyane.TabIndex = 15;
            this.lblWBiyane.Text = "W_BIYANE";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.Location = new System.Drawing.Point(366, 229);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(71, 16);
            this.lblBranch.TabIndex = 15;
            this.lblBranch.Text = "BRANCH";
            this.lblBranch.Click += new System.EventHandler(this.label17_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(366, 372);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(100, 16);
            this.lblCustomerName.TabIndex = 15;
            this.lblCustomerName.Text = "CUST_NAME";
            this.lblCustomerName.Click += new System.EventHandler(this.label17_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBank);
            this.panel1.Controls.Add(this.txtProduct);
            this.panel1.Controls.Add(this.txtTaluka);
            this.panel1.Controls.Add(this.txtShopAndCity);
            this.panel1.Controls.Add(this.txtWBiyane);
            this.panel1.Controls.Add(this.txtWKirtaknashke);
            this.panel1.Controls.Add(this.txtBranch);
            this.panel1.Controls.Add(this.txtCustName);
            this.panel1.Controls.Add(this.txtSignature);
            this.panel1.Controls.Add(this.txtIfsc);
            this.panel1.Controls.Add(this.txtWKhate);
            this.panel1.Controls.Add(this.txtNyayalin);
            this.panel1.Controls.Add(this.txtKitaknashke);
            this.panel1.Controls.Add(this.txtBiyane);
            this.panel1.Controls.Add(this.txtKhate);
            this.panel1.Controls.Add(this.txtGst);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblShopNameCity);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.lblTaluka);
            this.panel1.Controls.Add(this.lblNyayalin);
            this.panel1.Controls.Add(this.lblSignature);
            this.panel1.Controls.Add(this.lblIfsc);
            this.panel1.Controls.Add(this.lblBranch);
            this.panel1.Controls.Add(this.lblProduct);
            this.panel1.Controls.Add(this.lblBank);
            this.panel1.Controls.Add(this.lbblMobileNo);
            this.panel1.Controls.Add(this.lblWBiyane);
            this.panel1.Controls.Add(this.lblGstNo);
            this.panel1.Controls.Add(this.lblKhate);
            this.panel1.Controls.Add(this.lblBiyane);
            this.panel1.Controls.Add(this.lblKitaknaske);
            this.panel1.Controls.Add(this.lblWKhate);
            this.panel1.Location = new System.Drawing.Point(5, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 415);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(505, 136);
            this.txtBank.Multiline = true;
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(155, 65);
            this.txtBank.TabIndex = 23;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(146, 145);
            this.txtProduct.Multiline = true;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(155, 56);
            this.txtProduct.TabIndex = 19;
            // 
            // txtTaluka
            // 
            this.txtTaluka.Location = new System.Drawing.Point(146, 82);
            this.txtTaluka.Multiline = true;
            this.txtTaluka.Name = "txtTaluka";
            this.txtTaluka.Size = new System.Drawing.Size(155, 56);
            this.txtTaluka.TabIndex = 19;
            // 
            // txtShopAndCity
            // 
            this.txtShopAndCity.Location = new System.Drawing.Point(146, 20);
            this.txtShopAndCity.Multiline = true;
            this.txtShopAndCity.Name = "txtShopAndCity";
            this.txtShopAndCity.Size = new System.Drawing.Size(155, 56);
            this.txtShopAndCity.TabIndex = 19;
            // 
            // txtWBiyane
            // 
            this.txtWBiyane.Location = new System.Drawing.Point(505, 27);
            this.txtWBiyane.Name = "txtWBiyane";
            this.txtWBiyane.Size = new System.Drawing.Size(155, 20);
            this.txtWBiyane.TabIndex = 16;
            // 
            // txtWKirtaknashke
            // 
            this.txtWKirtaknashke.Location = new System.Drawing.Point(505, 71);
            this.txtWKirtaknashke.Name = "txtWKirtaknashke";
            this.txtWKirtaknashke.Size = new System.Drawing.Size(155, 20);
            this.txtWKirtaknashke.TabIndex = 16;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(505, 213);
            this.txtBranch.Multiline = true;
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(155, 62);
            this.txtBranch.TabIndex = 16;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(505, 366);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(155, 20);
            this.txtCustName.TabIndex = 16;
            // 
            // txtSignature
            // 
            this.txtSignature.Location = new System.Drawing.Point(505, 317);
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.Size = new System.Drawing.Size(155, 20);
            this.txtSignature.TabIndex = 16;
            // 
            // txtIfsc
            // 
            this.txtIfsc.Location = new System.Drawing.Point(505, 285);
            this.txtIfsc.Name = "txtIfsc";
            this.txtIfsc.Size = new System.Drawing.Size(155, 20);
            this.txtIfsc.TabIndex = 16;
            // 
            // txtWKhate
            // 
            this.txtWKhate.Location = new System.Drawing.Point(505, 101);
            this.txtWKhate.Name = "txtWKhate";
            this.txtWKhate.Size = new System.Drawing.Size(155, 20);
            this.txtWKhate.TabIndex = 16;
            // 
            // txtNyayalin
            // 
            this.txtNyayalin.Location = new System.Drawing.Point(146, 371);
            this.txtNyayalin.Multiline = true;
            this.txtNyayalin.Name = "txtNyayalin";
            this.txtNyayalin.Size = new System.Drawing.Size(196, 20);
            this.txtNyayalin.TabIndex = 16;
            // 
            // txtKitaknashke
            // 
            this.txtKitaknashke.Location = new System.Drawing.Point(146, 340);
            this.txtKitaknashke.Name = "txtKitaknashke";
            this.txtKitaknashke.Size = new System.Drawing.Size(155, 20);
            this.txtKitaknashke.TabIndex = 16;
            // 
            // txtBiyane
            // 
            this.txtBiyane.Location = new System.Drawing.Point(146, 314);
            this.txtBiyane.Name = "txtBiyane";
            this.txtBiyane.Size = new System.Drawing.Size(155, 20);
            this.txtBiyane.TabIndex = 16;
            // 
            // txtKhate
            // 
            this.txtKhate.Location = new System.Drawing.Point(146, 284);
            this.txtKhate.Name = "txtKhate";
            this.txtKhate.Size = new System.Drawing.Size(155, 20);
            this.txtKhate.TabIndex = 16;
            // 
            // txtGst
            // 
            this.txtGst.Location = new System.Drawing.Point(146, 258);
            this.txtGst.Name = "txtGst";
            this.txtGst.Size = new System.Drawing.Size(155, 20);
            this.txtGst.TabIndex = 16;
            this.txtGst.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(146, 207);
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(155, 38);
            this.txtMobile.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "W_KITAKNASHKE";
            this.label2.Click += new System.EventHandler(this.label17_Click);
            // 
            // lblNyayalin
            // 
            this.lblNyayalin.AutoSize = true;
            this.lblNyayalin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyayalin.Location = new System.Drawing.Point(16, 374);
            this.lblNyayalin.Name = "lblNyayalin";
            this.lblNyayalin.Size = new System.Drawing.Size(82, 16);
            this.lblNyayalin.TabIndex = 15;
            this.lblNyayalin.Text = "NYAYALIN";
            this.lblNyayalin.Click += new System.EventHandler(this.label17_Click);
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.Location = new System.Drawing.Point(366, 327);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(96, 16);
            this.lblSignature.TabIndex = 15;
            this.lblSignature.Text = "SIGNATURE";
            this.lblSignature.Click += new System.EventHandler(this.label17_Click);
            // 
            // lblIfsc
            // 
            this.lblIfsc.AutoSize = true;
            this.lblIfsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIfsc.Location = new System.Drawing.Point(366, 286);
            this.lblIfsc.Name = "lblIfsc";
            this.lblIfsc.Size = new System.Drawing.Size(41, 16);
            this.lblIfsc.TabIndex = 15;
            this.lblIfsc.Text = "IFSC";
            this.lblIfsc.Click += new System.EventHandler(this.label17_Click);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.Location = new System.Drawing.Point(366, 140);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(48, 16);
            this.lblBank.TabIndex = 15;
            this.lblBank.Text = "BANK";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblBillingDet);
            this.panel2.Location = new System.Drawing.Point(5, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 75);
            this.panel2.TabIndex = 0;
            // 
            // lblBillingDet
            // 
            this.lblBillingDet.AutoSize = true;
            this.lblBillingDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingDet.Location = new System.Drawing.Point(268, 27);
            this.lblBillingDet.Name = "lblBillingDet";
            this.lblBillingDet.Size = new System.Drawing.Size(157, 25);
            this.lblBillingDet.TabIndex = 0;
            this.lblBillingDet.Text = "Billing Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "SHOP AND CITY";
            // 
            // BillingInfo
            // 
            this.ClientSize = new System.Drawing.Size(685, 581);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BillingInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillingInfo_FormClosing);
            this.Load += new System.EventHandler(this.BillingInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void BillingInfo_Load(object sender, EventArgs e)
        {
         label1.Text = Guid.NewGuid().ToString();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        string cons = SystemSetting.ConnectionString;
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(txtBank.Text=="")
            {
                MessageBox.Show("Enter Bank");
                txtBank.Focus();
                return;

            }
            if (txtBiyane.Text == "")
            {
                MessageBox.Show("Enter Biyane");
                txtBank.Focus();
                return;

            }
            if (txtBranch.Text== "")
            {
                MessageBox.Show("Enter Branch");
                txtBank.Focus();
                return;

            }
            if (txtCustName.Text == "")
            {
                MessageBox.Show("Enter Customer Name");
                txtBank.Focus();
                return;

            }
            if (txtGst.Text == "")
            {
                MessageBox.Show("Enter GST");
                txtGst.Focus();
                return;

            }
            if (txtIfsc.Text == "")
            {
                MessageBox.Show("Enter IFSC");
                txtIfsc.Focus();
                return;

            }
            if (txtKhate.Text == "")
            {
                MessageBox.Show("Enter Khate");
                txtKhate.Focus();
                return;

            }
            if (txtKitaknashke.Text == "")
            {
                MessageBox.Show("Enter Kitaknashke");
                txtKitaknashke.Focus();
                return;

            }
            if (txtMobile.Text == "")
            {
                MessageBox.Show("Enter Mobile");
                txtMobile.Focus();
                return;

            }
            if (txtNyayalin.Text == "")
            {
                MessageBox.Show("Enter Nyayalin");
                txtNyayalin.Focus();
                return;

            }
            if (txtProduct.Text == "")
            {
                MessageBox.Show("Enter Product");
                txtProduct.Focus();
                return;

            }
            if (txtShopAndCity.Text == "")
            {
                MessageBox.Show("Enter ShopAndCity");
                txtShopAndCity.Focus();
                return;

            }
            if (txtSignature.Text=="")
            {
                MessageBox.Show("Enter Signature");
                txtSignature.Focus();
                return;

            }
            if (txtTaluka.Text == "")
            {
                MessageBox.Show("Enter Taluka");
                txtTaluka.Focus();
                return;

            }
            if (txtWBiyane.Text == "")
            {
                MessageBox.Show("Enter Biyane");
                txtWBiyane.Focus();
                return;

            }
            if (txtWKhate.Text == "")
            {
                MessageBox.Show("Enter Wholesale Khate");
                txtWKhate.Focus();
                return;

            }
            if (txtWKirtaknashke.Text == "")
            {
                MessageBox.Show("Enter Wholesale Khate");
                txtWKirtaknashke.Focus();
                return;
            }
            

            Billing.ShopNameCity = txtShopAndCity.Text.Trim();
            Billing.Taluka = txtTaluka.Text.Trim();
            Billing.Product = txtProduct.Text.Trim();
            Billing.Mobile = txtMobile.Text.Trim();
            Billing.GST = txtGst.Text.Trim();
            Billing.Khate = txtKhate.Text.Trim();
            Billing.Biyane = txtBiyane.Text.Trim();
            Billing.Kitaknashke = txtKitaknashke.Text.Trim();
            Billing.Nyayalin = txtNyayalin.Text.Trim();
            Billing.WKhate = txtKhate.Text.Trim();
            Billing.WBiyane = txtBiyane.Text.Trim();
            Billing.WKitaknashke = txtKitaknashke.Text.Trim();
            Billing.Bank=txtBranch.Text.Trim();
            Billing.Branch = txtBranch.Text.Trim();
            Billing.Ifsc = txtIfsc.Text.Trim();
            Billing.Signature = txtSignature.Text.Trim();
            Billing.CustName = txtCustName.Text.Trim();

            SqlConnection cons1 = new SqlConnection(cons);
            SqlCommand cmd = new SqlCommand("Usp_BillinData", cons1);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ShopNameCity", Billing.ShopNameCity);
            cmd.Parameters.AddWithValue("@ZillaTaluka", Billing.Taluka);

            cmd.Parameters.AddWithValue("@Product", Billing.Product);

            cmd.Parameters.AddWithValue("@Mobile_No", Billing.Mobile);

            cmd.Parameters.AddWithValue("@Nyayalin", Billing.Nyayalin);

            cmd.Parameters.AddWithValue("@Khate_Parvana", Billing.Khate);
            cmd.Parameters.AddWithValue("@Biyane_Parvana", Billing.Biyane);
            cmd.Parameters.AddWithValue("@Kitnashke_Parvana", Billing.Kitaknashke);
            cmd.Parameters.AddWithValue("@Wholesale_Khate_Parvana1", Billing.WKhate);
            cmd.Parameters.AddWithValue("@Wholesale_Biyane_Parvana1", Billing.Biyane);
            cmd.Parameters.AddWithValue("@Wholesale_Kitnashke_Parvana1", Billing.Kitaknashke);
            cmd.Parameters.AddWithValue("@Gst_No", Billing.GST);
            cmd.Parameters.AddWithValue("@Bank_Name", Billing.Bank);
            cmd.Parameters.AddWithValue("@Branch_Name", Billing.Branch);
            cmd.Parameters.AddWithValue("@Ifsc", Billing.Ifsc);
            cmd.Parameters.AddWithValue("@Signature", Billing.Signature);
            cmd.Parameters.AddWithValue("@Cust_Name", Billing.CustName);
          //  cmd.Parameters.AddWithValue("@ShopNameCity", Billing.ShopNameCity);

            cons1.Open();
            cmd.ExecuteNonQuery();
            cons1.Close();
            MessageBox.Show("Inserted Successfully");
            Utility.ClearSpace(this);


            // sql = "insert into Tbl_BillingInformation(ShopNameCity,ZillaTaluka,Product,Mobile_No,Nyayalin,Khate_Parvana,Biyane_Parvana,KitakNashke_Parvana,Wholesale_Kit) values "
        }
        BillingData z = new BillingData();
        private void BillingInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            z.Refresh();
        }
    }
}
