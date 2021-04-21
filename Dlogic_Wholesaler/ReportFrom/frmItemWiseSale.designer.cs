namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmItemWiseSale
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMainCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.chkBatch = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.metroLabel3 = new System.Windows.Forms.Label();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.pCenter = new System.Windows.Forms.Panel();
            this.dgvItemWiseSale = new System.Windows.Forms.DataGridView();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perQtysalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleRetquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleRetPerQtysalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleRetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemWiseSale)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 10);
            this.panel1.TabIndex = 101;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMainCategory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.chkBatch);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.cmbItemName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1191, 100);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
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
            "--निवडा--",
            "खते",
            "किटकनाशके",
            "बियाणे",
            "PGR"});
            this.cmbMainCategory.Location = new System.Drawing.Point(74, 52);
            this.cmbMainCategory.Name = "cmbMainCategory";
            this.cmbMainCategory.Size = new System.Drawing.Size(210, 32);
            this.cmbMainCategory.TabIndex = 395;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 396;
            this.label5.Text = "प्रकारचे नाव";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(905, 61);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 35);
            this.btnExcel.TabIndex = 394;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // chkBatch
            // 
            this.chkBatch.AutoSize = true;
            this.chkBatch.Location = new System.Drawing.Point(439, 20);
            this.chkBatch.Name = "chkBatch";
            this.chkBatch.Size = new System.Drawing.Size(103, 28);
            this.chkBatch.TabIndex = 393;
            this.chkBatch.Text = "Batch No";
            this.chkBatch.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(1011, 61);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 35);
            this.btnPrint.TabIndex = 392;
            this.btnPrint.Text = "प्रिंट";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(905, 22);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 37);
            this.btnShow.TabIndex = 389;
            this.btnShow.Text = "दाखवा";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(619, 64);
            this.metroLabel3.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 24);
            this.metroLabel3.TabIndex = 153;
            this.metroLabel3.Text = "या तारखे परंत :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(616, 30);
            this.metroLabel1.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 24);
            this.metroLabel1.TabIndex = 152;
            this.metroLabel1.Text = "या तारखे पासून :";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(753, 64);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(130, 29);
            this.dtpToDate.TabIndex = 151;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(753, 30);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(130, 29);
            this.dtpFromDate.TabIndex = 150;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(297, 22);
            this.metroLabel2.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 24);
            this.metroLabel2.TabIndex = 149;
            this.metroLabel2.Text = "वस्तूचे नाव";
            // 
            // cmbItemName
            // 
            this.cmbItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemName.BackColor = System.Drawing.Color.White;
            this.cmbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemName.ForeColor = System.Drawing.Color.Black;
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(294, 52);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(306, 32);
            this.cmbItemName.TabIndex = 0;
            // 
            // pCenter
            // 
            this.pCenter.Controls.Add(this.dgvItemWiseSale);
            this.pCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCenter.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCenter.Location = new System.Drawing.Point(20, 170);
            this.pCenter.Name = "pCenter";
            this.pCenter.Size = new System.Drawing.Size(1191, 374);
            this.pCenter.TabIndex = 103;
            // 
            // dgvItemWiseSale
            // 
            this.dgvItemWiseSale.AllowUserToAddRows = false;
            this.dgvItemWiseSale.AllowUserToDeleteRows = false;
            this.dgvItemWiseSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemWiseSale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItemWiseSale.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemWiseSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemWiseSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.customerAddress,
            this.itemName,
            this.batchNo,
            this.saleQuantity,
            this.perQtysalePrice,
            this.saleAmount,
            this.saleRetquantity,
            this.saleRetPerQtysalePrice,
            this.saleRetAmount,
            this.netQty,
            this.netAmount});
            this.dgvItemWiseSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemWiseSale.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItemWiseSale.GridColor = System.Drawing.Color.Black;
            this.dgvItemWiseSale.Location = new System.Drawing.Point(0, 0);
            this.dgvItemWiseSale.Name = "dgvItemWiseSale";
            this.dgvItemWiseSale.RowHeadersVisible = false;
            this.dgvItemWiseSale.Size = new System.Drawing.Size(1191, 374);
            this.dgvItemWiseSale.TabIndex = 0;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "ग्राहकाचे नांव";
            this.customerName.Name = "customerName";
            this.customerName.Width = 112;
            // 
            // customerAddress
            // 
            this.customerAddress.DataPropertyName = "customerAddress";
            this.customerAddress.HeaderText = "पत्ता";
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Width = 60;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "वस्तूचे नांव";
            this.itemName.Name = "itemName";
            this.itemName.Width = 98;
            // 
            // batchNo
            // 
            this.batchNo.DataPropertyName = "batchNo";
            this.batchNo.HeaderText = "Batch No";
            this.batchNo.Name = "batchNo";
            this.batchNo.Width = 101;
            // 
            // saleQuantity
            // 
            this.saleQuantity.DataPropertyName = "saleQuantity";
            this.saleQuantity.HeaderText = "सेल नग";
            this.saleQuantity.Name = "saleQuantity";
            this.saleQuantity.Width = 78;
            // 
            // perQtysalePrice
            // 
            this.perQtysalePrice.DataPropertyName = "perQtysalePrice";
            this.perQtysalePrice.HeaderText = "सेल दर";
            this.perQtysalePrice.Name = "perQtysalePrice";
            this.perQtysalePrice.Width = 77;
            // 
            // saleAmount
            // 
            this.saleAmount.DataPropertyName = "saleAmount";
            this.saleAmount.HeaderText = "सेल रक्कम";
            this.saleAmount.Name = "saleAmount";
            this.saleAmount.Width = 89;
            // 
            // saleRetquantity
            // 
            this.saleRetquantity.DataPropertyName = "saleRetquantity";
            this.saleRetquantity.HeaderText = "सेल परत नग";
            this.saleRetquantity.Name = "saleRetquantity";
            this.saleRetquantity.Width = 108;
            // 
            // saleRetPerQtysalePrice
            // 
            this.saleRetPerQtysalePrice.DataPropertyName = "saleRetPerQtysalePrice";
            this.saleRetPerQtysalePrice.HeaderText = "सेल परत दर";
            this.saleRetPerQtysalePrice.Name = "saleRetPerQtysalePrice";
            this.saleRetPerQtysalePrice.Width = 107;
            // 
            // saleRetAmount
            // 
            this.saleRetAmount.DataPropertyName = "saleRetAmount";
            this.saleRetAmount.HeaderText = "सेल परत रक्कम";
            this.saleRetAmount.Name = "saleRetAmount";
            this.saleRetAmount.Width = 119;
            // 
            // netQty
            // 
            this.netQty.DataPropertyName = "netQty";
            this.netQty.HeaderText = "नेट नग";
            this.netQty.Name = "netQty";
            this.netQty.Width = 74;
            // 
            // netAmount
            // 
            this.netAmount.DataPropertyName = "netAmount";
            this.netAmount.HeaderText = "नेट रक्कम";
            this.netAmount.Name = "netAmount";
            this.netAmount.Width = 85;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(14, 11);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(343, 36);
            this.lblHerader.TabIndex = 438;
            this.lblHerader.Text = "वस्तू नुसार सेल / सेल परत रिपोर्ट";
            // 
            // frmItemWiseSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 564);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.pCenter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmItemWiseSale";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmItemWiseSale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemWiseSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label metroLabel3;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.CheckBox chkBatch;
        private System.Windows.Forms.Panel pCenter;
        private System.Windows.Forms.DataGridView dgvItemWiseSale;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn perQtysalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleRetquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleRetPerQtysalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleRetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn netQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAmount;
        private System.Windows.Forms.ComboBox cmbMainCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHerader;
    }
}