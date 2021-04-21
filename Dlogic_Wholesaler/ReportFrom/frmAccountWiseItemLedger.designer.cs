namespace Dlogic_Wholesaler.ReportFroms
{
    partial class frmAccountWiseItemLedger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMainCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnExcel = new System.Windows.Forms.Button();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.cmbAccountName = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.rbDealer = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAccountStatement = new System.Windows.Forms.DataGridView();
            this.chkSaleReturn = new System.Windows.Forms.CheckBox();
            this.chkPurchaseReturn = new System.Windows.Forms.CheckBox();
            this.chbSale = new System.Windows.Forms.CheckBox();
            this.lblHerader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(20, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1221, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 79;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbMainCategory);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpToDate);
            this.groupBox2.Controls.Add(this.dtpFromDate);
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.cmbAccountName);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F);
            this.groupBox2.Location = new System.Drawing.Point(20, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1221, 93);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            // 
            // cmbMainCategory
            // 
            this.cmbMainCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMainCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMainCategory.BackColor = System.Drawing.Color.White;
            this.cmbMainCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMainCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbMainCategory.FormattingEnabled = true;
            this.cmbMainCategory.IntegralHeight = false;
            this.cmbMainCategory.Items.AddRange(new object[] {
            "All",
            "खते",
            "किटकनाशके",
            "बियाणे",
            "PGR"});
            this.cmbMainCategory.Location = new System.Drawing.Point(156, 17);
            this.cmbMainCategory.Name = "cmbMainCategory";
            this.cmbMainCategory.Size = new System.Drawing.Size(210, 32);
            this.cmbMainCategory.TabIndex = 399;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 400;
            this.label5.Text = "प्रकारचे नांव";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 398;
            this.label2.Text = "या तारखे पर्यंत";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 397;
            this.label1.Text = "या तारखे पासून";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(844, 46);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(119, 29);
            this.dtpToDate.TabIndex = 396;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(586, 45);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(137, 29);
            this.dtpFromDate.TabIndex = 395;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(1097, 41);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(108, 34);
            this.btnExcel.TabIndex = 394;
            this.btnExcel.Text = "Excel Export";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(6, 57);
            this.metroLabel2.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 25);
            this.metroLabel2.TabIndex = 392;
            this.metroLabel2.Text = "खात्याचे नांव";
            // 
            // cmbAccountName
            // 
            this.cmbAccountName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccountName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccountName.BackColor = System.Drawing.Color.White;
            this.cmbAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountName.ForeColor = System.Drawing.Color.Black;
            this.cmbAccountName.FormattingEnabled = true;
            this.cmbAccountName.Location = new System.Drawing.Point(156, 55);
            this.cmbAccountName.Name = "cmbAccountName";
            this.cmbAccountName.Size = new System.Drawing.Size(288, 32);
            this.cmbAccountName.TabIndex = 391;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(983, 41);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 36);
            this.btnShow.TabIndex = 390;
            this.btnShow.Text = "दाखवा";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rbDealer
            // 
            this.rbDealer.AutoSize = true;
            this.rbDealer.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDealer.Location = new System.Drawing.Point(715, 25);
            this.rbDealer.Name = "rbDealer";
            this.rbDealer.Size = new System.Drawing.Size(86, 29);
            this.rbDealer.TabIndex = 393;
            this.rbDealer.TabStop = true;
            this.rbDealer.Text = "व्यापारी";
            this.rbDealer.UseVisualStyleBackColor = true;
            this.rbDealer.CheckedChanged += new System.EventHandler(this.rbDealer_CheckedChanged);
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCustomer.Location = new System.Drawing.Point(599, 25);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(70, 29);
            this.rbCustomer.TabIndex = 392;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "ग्राहक";
            this.rbCustomer.UseVisualStyleBackColor = true;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.rbCustomer_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAccountStatement);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(20, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1221, 388);
            this.groupBox1.TabIndex = 394;
            this.groupBox1.TabStop = false;
            // 
            // dgvAccountStatement
            // 
            this.dgvAccountStatement.AllowUserToAddRows = false;
            this.dgvAccountStatement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAccountStatement.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountStatement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccountStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountStatement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccountStatement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccountStatement.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccountStatement.EnableHeadersVisualStyles = false;
            this.dgvAccountStatement.GridColor = System.Drawing.Color.Maroon;
            this.dgvAccountStatement.Location = new System.Drawing.Point(3, 29);
            this.dgvAccountStatement.Name = "dgvAccountStatement";
            this.dgvAccountStatement.RowHeadersVisible = false;
            this.dgvAccountStatement.RowTemplate.Height = 25;
            this.dgvAccountStatement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountStatement.Size = new System.Drawing.Size(1215, 356);
            this.dgvAccountStatement.TabIndex = 0;
            this.dgvAccountStatement.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAccountStatement_CellFormatting);
            // 
            // chkSaleReturn
            // 
            this.chkSaleReturn.AutoSize = true;
            this.chkSaleReturn.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F);
            this.chkSaleReturn.Location = new System.Drawing.Point(833, 25);
            this.chkSaleReturn.Name = "chkSaleReturn";
            this.chkSaleReturn.Size = new System.Drawing.Size(102, 29);
            this.chkSaleReturn.TabIndex = 395;
            this.chkSaleReturn.Text = "सेल  रिटर्न";
            this.chkSaleReturn.UseVisualStyleBackColor = true;
            this.chkSaleReturn.CheckedChanged += new System.EventHandler(this.chkSaleReturn_CheckedChanged);
            // 
            // chkPurchaseReturn
            // 
            this.chkPurchaseReturn.AutoSize = true;
            this.chkPurchaseReturn.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F);
            this.chkPurchaseReturn.Location = new System.Drawing.Point(957, 25);
            this.chkPurchaseReturn.Name = "chkPurchaseReturn";
            this.chkPurchaseReturn.Size = new System.Drawing.Size(122, 29);
            this.chkPurchaseReturn.TabIndex = 396;
            this.chkPurchaseReturn.Text = "परचेस  रिटर्न";
            this.chkPurchaseReturn.UseVisualStyleBackColor = true;
            this.chkPurchaseReturn.CheckedChanged += new System.EventHandler(this.chkPurchaseReturn_CheckedChanged);
            // 
            // chbSale
            // 
            this.chbSale.AutoSize = true;
            this.chbSale.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F);
            this.chbSale.Location = new System.Drawing.Point(417, 25);
            this.chbSale.Name = "chbSale";
            this.chbSale.Size = new System.Drawing.Size(142, 29);
            this.chbSale.TabIndex = 397;
            this.chbSale.Text = "सेल  सवलत(%)";
            this.chbSale.UseVisualStyleBackColor = true;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(23, 20);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(290, 33);
            this.lblHerader.TabIndex = 358;
            this.lblHerader.Text = "खाते नुसार बिल(पार्टी स्टेटमेंट )";
            // 
            // frmAccountWiseItemLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 571);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.chbSale);
            this.Controls.Add(this.chkPurchaseReturn);
            this.Controls.Add(this.chkSaleReturn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbDealer);
            this.Controls.Add(this.rbCustomer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox3);
            this.KeyPreview = true;
            this.Name = "frmAccountWiseItemLedger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAccountWiseItemLedger_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccountWiseItemLedger_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountStatement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rbDealer;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.ComboBox cmbAccountName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAccountStatement;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.CheckBox chkSaleReturn;
        private System.Windows.Forms.CheckBox chkPurchaseReturn;
        private System.Windows.Forms.CheckBox chbSale;
        private System.Windows.Forms.ComboBox cmbMainCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHerader;
    }
}