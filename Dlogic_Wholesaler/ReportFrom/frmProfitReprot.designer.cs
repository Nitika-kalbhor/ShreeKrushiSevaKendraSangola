namespace Dlogic_Wholesaler.ReportFroms
{
    partial class frmProfitReprot
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dgvSaleBookReport = new System.Windows.Forms.DataGridView();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesReturnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleBookReport)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 10);
            this.panel1.TabIndex = 101;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCompany);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.lblItemName);
            this.groupBox1.Controls.Add(this.cmbItemName);
            this.groupBox1.Controls.Add(this.cmbItemType);
            this.groupBox1.Controls.Add(this.lblItemType);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 112);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "WW";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.ItemHeight = 21;
            this.cmbCompany.Location = new System.Drawing.Point(120, 53);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(170, 29);
            this.cmbCompany.TabIndex = 320;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(141, 26);
            this.metroLabel1.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 21);
            this.metroLabel1.TabIndex = 319;
            this.metroLabel1.Text = "कंपनीचे नाव:";
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(498, 26);
            this.lblItemName.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(77, 21);
            this.lblItemName.TabIndex = 317;
            this.lblItemName.Text = "वस्तूचे नाव:";
            // 
            // cmbItemName
            // 
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.ItemHeight = 21;
            this.cmbItemName.Location = new System.Drawing.Point(472, 53);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(167, 29);
            this.cmbItemName.TabIndex = 316;
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.ItemHeight = 21;
            this.cmbItemType.Location = new System.Drawing.Point(296, 53);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(170, 29);
            this.cmbItemType.TabIndex = 315;
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.cmbItemType_SelectedIndexChanged);
            // 
            // lblItemType
            // 
            this.lblItemType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(310, 26);
            this.lblItemType.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(92, 21);
            this.lblItemType.TabIndex = 313;
            this.lblItemType.Text = "वस्तूचा प्रकार:";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(1034, 52);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 30);
            this.btnNew.TabIndex = 311;
            this.btnNew.Text = "पुसा";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Visible = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(921, 52);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(108, 30);
            this.btnExcel.TabIndex = 310;
            this.btnExcel.Text = "Excel Export";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Visible = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(816, 52);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 309;
            this.btnPrint.Text = "प्रिंट";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(711, 52);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 30);
            this.btnShow.TabIndex = 308;
            this.btnShow.Text = "दाखवा";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(904, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "या तारखे पर्यन्त";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "या तारखे पासून";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(1024, 17);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(119, 29);
            this.dtpToDate.TabIndex = 1;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(761, 16);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(137, 29);
            this.dtpFromDate.TabIndex = 0;
            // 
            // dgvSaleBookReport
            // 
            this.dgvSaleBookReport.AllowUserToAddRows = false;
            this.dgvSaleBookReport.AllowUserToResizeColumns = false;
            this.dgvSaleBookReport.AllowUserToResizeRows = false;
            this.dgvSaleBookReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSaleBookReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleBookReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSaleBookReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleBookReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNo,
            this.itemName,
            this.weightIn,
            this.batchNo,
            this.SaleQuantity,
            this.salesReturnQty,
            this.saleRate,
            this.purchrate,
            this.saleAmt,
            this.purchAmt,
            this.profitAmt,
            this.itemIdS});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleBookReport.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSaleBookReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleBookReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSaleBookReport.EnableHeadersVisualStyles = false;
            this.dgvSaleBookReport.GridColor = System.Drawing.Color.Maroon;
            this.dgvSaleBookReport.Location = new System.Drawing.Point(3, 16);
            this.dgvSaleBookReport.Name = "dgvSaleBookReport";
            this.dgvSaleBookReport.RowHeadersVisible = false;
            this.dgvSaleBookReport.Size = new System.Drawing.Size(1153, 466);
            this.dgvSaleBookReport.TabIndex = 0;
            // 
            // SerialNo
            // 
            this.SerialNo.DataPropertyName = "SerialNo";
            this.SerialNo.HeaderText = "अनुक्रमांक";
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.Width = 88;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "वस्तूचे नाव";
            this.itemName.Name = "itemName";
            this.itemName.Width = 95;
            // 
            // weightIn
            // 
            this.weightIn.DataPropertyName = "weightIn";
            this.weightIn.HeaderText = "पॅकिंग";
            this.weightIn.Name = "weightIn";
            this.weightIn.Width = 66;
            // 
            // batchNo
            // 
            this.batchNo.DataPropertyName = "batchNo";
            this.batchNo.HeaderText = "बॅच नं.";
            this.batchNo.Name = "batchNo";
            this.batchNo.Width = 70;
            // 
            // SaleQuantity
            // 
            this.SaleQuantity.DataPropertyName = "SaleQuantity";
            this.SaleQuantity.HeaderText = "विक्री नग";
            this.SaleQuantity.Name = "SaleQuantity";
            this.SaleQuantity.Width = 85;
            // 
            // salesReturnQty
            // 
            this.salesReturnQty.DataPropertyName = "salesReturnQty";
            this.salesReturnQty.HeaderText = "विक्री परत नग";
            this.salesReturnQty.Name = "salesReturnQty";
            this.salesReturnQty.Width = 113;
            // 
            // saleRate
            // 
            this.saleRate.DataPropertyName = "saleRate";
            this.saleRate.HeaderText = "विक्री किंमत";
            this.saleRate.Name = "saleRate";
            this.saleRate.Width = 101;
            // 
            // purchrate
            // 
            this.purchrate.DataPropertyName = "purchrate";
            this.purchrate.HeaderText = "खरेदी किंमत";
            this.purchrate.Name = "purchrate";
            this.purchrate.Width = 103;
            // 
            // saleAmt
            // 
            this.saleAmt.DataPropertyName = "saleAmt";
            this.saleAmt.HeaderText = "एकूण सेल रक्कम";
            this.saleAmt.Name = "saleAmt";
            this.saleAmt.Width = 118;
            // 
            // purchAmt
            // 
            this.purchAmt.DataPropertyName = "purchAmt";
            this.purchAmt.HeaderText = "एकूण खरेदी रक्कम";
            this.purchAmt.Name = "purchAmt";
            this.purchAmt.Width = 129;
            // 
            // profitAmt
            // 
            this.profitAmt.DataPropertyName = "profitAmt";
            this.profitAmt.HeaderText = "नफा";
            this.profitAmt.Name = "profitAmt";
            this.profitAmt.Width = 58;
            // 
            // itemIdS
            // 
            this.itemIdS.DataPropertyName = "itemId";
            this.itemIdS.HeaderText = "itemId";
            this.itemIdS.Name = "itemIdS";
            this.itemIdS.Visible = false;
            this.itemIdS.Width = 73;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSaleBookReport);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(20, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1159, 485);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(23, 10);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(127, 36);
            this.lblHerader.TabIndex = 434;
            this.lblHerader.Text = "नफा रिपोर्ट";
            // 
            // frmProfitReprot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 687);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmProfitReprot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProfitReprot_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProfitReprot_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleBookReport)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DataGridView dgvSaleBookReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesReturnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdS;
        private System.Windows.Forms.Label lblHerader;
    }
}