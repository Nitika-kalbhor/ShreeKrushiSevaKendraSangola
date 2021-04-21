namespace Dlogic_Wholesaler.ReportFrom
{
    partial class AllPurchaseDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnnew = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rbtnCredit = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.btnExcelConvert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPurchaseItems = new System.Windows.Forms.DataGridView();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSNCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rackNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseRateWithGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualPurchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxableAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesCashRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseChalanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseItemDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPurchaseBook = new System.Windows.Forms.DataGridView();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(830, 14);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(91, 34);
            this.btnnew.TabIndex = 306;
            this.btnnew.Text = "दाखवा";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(628, 18);
            this.metroLabel3.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(25, 19);
            this.metroLabel3.TabIndex = 156;
            this.metroLabel3.Text = "ते :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(694, 14);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(130, 29);
            this.dtpToDate.TabIndex = 155;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(355, 18);
            this.metroLabel1.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 154;
            this.metroLabel1.Text = "पासून दिनांक :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(473, 14);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(130, 29);
            this.dtpFromDate.TabIndex = 153;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbAll);
            this.groupBox2.Controls.Add(this.rbtnCredit);
            this.groupBox2.Controls.Add(this.rbtnCash);
            this.groupBox2.Controls.Add(this.btnExcelConvert);
            this.groupBox2.Controls.Add(this.btnnew);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.dtpToDate);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.dtpFromDate);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(20, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1055, 56);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAll.Location = new System.Drawing.Point(73, 18);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(47, 25);
            this.rdbAll.TabIndex = 338;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "सर्व";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // rbtnCredit
            // 
            this.rbtnCredit.AutoSize = true;
            this.rbtnCredit.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCredit.Location = new System.Drawing.Point(240, 19);
            this.rbtnCredit.Name = "rbtnCredit";
            this.rbtnCredit.Size = new System.Drawing.Size(61, 25);
            this.rbtnCredit.TabIndex = 337;
            this.rbtnCredit.TabStop = true;
            this.rbtnCredit.Text = "क्रेडीट";
            this.rbtnCredit.UseVisualStyleBackColor = true;
            this.rbtnCredit.CheckedChanged += new System.EventHandler(this.rbtnCredit_CheckedChanged);
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCash.Location = new System.Drawing.Point(156, 19);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(50, 25);
            this.rbtnCash.TabIndex = 336;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "कॅश";
            this.rbtnCash.UseVisualStyleBackColor = true;
            this.rbtnCash.CheckedChanged += new System.EventHandler(this.rbtnCash_CheckedChanged);
            // 
            // btnExcelConvert
            // 
            this.btnExcelConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnExcelConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnExcelConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelConvert.ForeColor = System.Drawing.Color.White;
            this.btnExcelConvert.Location = new System.Drawing.Point(927, 14);
            this.btnExcelConvert.Name = "btnExcelConvert";
            this.btnExcelConvert.Size = new System.Drawing.Size(122, 34);
            this.btnExcelConvert.TabIndex = 308;
            this.btnExcelConvert.Text = "Excel रिपोर्ट";
            this.btnExcelConvert.UseVisualStyleBackColor = false;
            this.btnExcelConvert.Click += new System.EventHandler(this.btnExcelConvert_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPurchaseItems);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1055, 180);
            this.groupBox3.TabIndex = 108;
            this.groupBox3.TabStop = false;
            // 
            // dgvPurchaseItems
            // 
            this.dgvPurchaseItems.AllowUserToAddRows = false;
            this.dgvPurchaseItems.AllowUserToDeleteRows = false;
            this.dgvPurchaseItems.AllowUserToResizeColumns = false;
            this.dgvPurchaseItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPurchaseItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemId,
            this.stockId,
            this.companyId,
            this.categoryId,
            this.productCode,
            this.HSNCode,
            this.rackNo,
            this.itemName,
            this.batchNo,
            this.mfgDate,
            this.expireDate,
            this.Quantity,
            this.unitBy,
            this.freeQuantity,
            this.MRP,
            this.purchaseRateWithGST,
            this.purchaseRate,
            this.discount,
            this.discountPer,
            this.ActualPurchaseRate,
            this.TaxableAmount,
            this.salesCashRate,
            this.IGST,
            this.IGSTAmt,
            this.CGST,
            this.CGSTAmt,
            this.SGST,
            this.SGSTAmt,
            this.totalAmount,
            this.purchaseChalanId,
            this.purchaseItemDetailId});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseItems.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPurchaseItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPurchaseItems.EnableHeadersVisualStyles = false;
            this.dgvPurchaseItems.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvPurchaseItems.Location = new System.Drawing.Point(3, 18);
            this.dgvPurchaseItems.Name = "dgvPurchaseItems";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPurchaseItems.RowHeadersVisible = false;
            this.dgvPurchaseItems.RowTemplate.Height = 25;
            this.dgvPurchaseItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseItems.Size = new System.Drawing.Size(1049, 159);
            this.dgvPurchaseItems.TabIndex = 2;
            this.dgvPurchaseItems.Visible = false;
            // 
            // itemId
            // 
            this.itemId.HeaderText = "itemId";
            this.itemId.Name = "itemId";
            this.itemId.Visible = false;
            // 
            // stockId
            // 
            this.stockId.HeaderText = "StockId";
            this.stockId.Name = "stockId";
            this.stockId.Visible = false;
            // 
            // companyId
            // 
            this.companyId.HeaderText = "companyId";
            this.companyId.Name = "companyId";
            this.companyId.Visible = false;
            // 
            // categoryId
            // 
            this.categoryId.HeaderText = "categoryId";
            this.categoryId.Name = "categoryId";
            this.categoryId.Visible = false;
            // 
            // productCode
            // 
            this.productCode.HeaderText = "productCode";
            this.productCode.Name = "productCode";
            this.productCode.Visible = false;
            // 
            // HSNCode
            // 
            this.HSNCode.HeaderText = "HSNCode";
            this.HSNCode.Name = "HSNCode";
            this.HSNCode.Visible = false;
            this.HSNCode.Width = 80;
            // 
            // rackNo
            // 
            this.rackNo.HeaderText = "rackNo";
            this.rackNo.Name = "rackNo";
            this.rackNo.Visible = false;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "तपशील";
            this.itemName.Name = "itemName";
            this.itemName.Width = 250;
            // 
            // batchNo
            // 
            this.batchNo.HeaderText = "बॅच नं";
            this.batchNo.Name = "batchNo";
            this.batchNo.Width = 80;
            // 
            // mfgDate
            // 
            dataGridViewCellStyle3.Format = "dd-MM-yyyy";
            this.mfgDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.mfgDate.HeaderText = "MFG दिनांक";
            this.mfgDate.Name = "mfgDate";
            // 
            // expireDate
            // 
            dataGridViewCellStyle4.Format = "dd-MM-yyyy";
            this.expireDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.expireDate.HeaderText = "एक्स दिनांक";
            this.expireDate.Name = "expireDate";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "नग";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 50;
            // 
            // unitBy
            // 
            this.unitBy.HeaderText = "पॅकींग";
            this.unitBy.Name = "unitBy";
            this.unitBy.ReadOnly = true;
            this.unitBy.ToolTipText = "QTY";
            this.unitBy.Width = 70;
            // 
            // freeQuantity
            // 
            this.freeQuantity.HeaderText = "मोफत नग";
            this.freeQuantity.Name = "freeQuantity";
            this.freeQuantity.Visible = false;
            this.freeQuantity.Width = 80;
            // 
            // MRP
            // 
            this.MRP.HeaderText = "MRP";
            this.MRP.Name = "MRP";
            this.MRP.Visible = false;
            // 
            // purchaseRateWithGST
            // 
            this.purchaseRateWithGST.HeaderText = "खरेदी दर(with GST)";
            this.purchaseRateWithGST.Name = "purchaseRateWithGST";
            this.purchaseRateWithGST.Width = 150;
            // 
            // purchaseRate
            // 
            this.purchaseRate.HeaderText = "खरीदी दर";
            this.purchaseRate.Name = "purchaseRate";
            this.purchaseRate.Width = 90;
            // 
            // discount
            // 
            this.discount.HeaderText = "सवलत";
            this.discount.Name = "discount";
            this.discount.Visible = false;
            // 
            // discountPer
            // 
            this.discountPer.HeaderText = "सवलत(%)";
            this.discountPer.Name = "discountPer";
            // 
            // ActualPurchaseRate
            // 
            this.ActualPurchaseRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ActualPurchaseRate.HeaderText = "खरेदी दर(with Discount)";
            this.ActualPurchaseRate.Name = "ActualPurchaseRate";
            this.ActualPurchaseRate.Visible = false;
            this.ActualPurchaseRate.Width = 180;
            // 
            // TaxableAmount
            // 
            this.TaxableAmount.HeaderText = "रक्कम";
            this.TaxableAmount.Name = "TaxableAmount";
            this.TaxableAmount.ReadOnly = true;
            this.TaxableAmount.Width = 80;
            // 
            // salesCashRate
            // 
            this.salesCashRate.HeaderText = "सेल दर";
            this.salesCashRate.Name = "salesCashRate";
            this.salesCashRate.Visible = false;
            // 
            // IGST
            // 
            this.IGST.HeaderText = "GST(%)";
            this.IGST.Name = "IGST";
            this.IGST.Width = 60;
            // 
            // IGSTAmt
            // 
            this.IGSTAmt.HeaderText = "GST रक्कम";
            this.IGSTAmt.Name = "IGSTAmt";
            this.IGSTAmt.ReadOnly = true;
            // 
            // CGST
            // 
            this.CGST.HeaderText = "CGST(%)";
            this.CGST.Name = "CGST";
            this.CGST.Width = 80;
            // 
            // CGSTAmt
            // 
            this.CGSTAmt.HeaderText = "CGST रक्कम";
            this.CGSTAmt.Name = "CGSTAmt";
            this.CGSTAmt.ReadOnly = true;
            // 
            // SGST
            // 
            this.SGST.HeaderText = "SGST(%)";
            this.SGST.Name = "SGST";
            this.SGST.Width = 80;
            // 
            // SGSTAmt
            // 
            this.SGSTAmt.HeaderText = "SGST रक्कम";
            this.SGSTAmt.Name = "SGSTAmt";
            this.SGSTAmt.ReadOnly = true;
            // 
            // totalAmount
            // 
            this.totalAmount.HeaderText = "एकूण रक्कम";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            // 
            // purchaseChalanId
            // 
            this.purchaseChalanId.HeaderText = "purchaseChalanId";
            this.purchaseChalanId.Name = "purchaseChalanId";
            this.purchaseChalanId.Visible = false;
            // 
            // purchaseItemDetailId
            // 
            this.purchaseItemDetailId.HeaderText = "purchaseItemDetailId";
            this.purchaseItemDetailId.Name = "purchaseItemDetailId";
            this.purchaseItemDetailId.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPurchaseBook);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 204);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            // 
            // dgvPurchaseBook
            // 
            this.dgvPurchaseBook.AllowUserToAddRows = false;
            this.dgvPurchaseBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPurchaseBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchaseBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPurchaseBook.GridColor = System.Drawing.Color.Black;
            this.dgvPurchaseBook.Location = new System.Drawing.Point(3, 20);
            this.dgvPurchaseBook.Name = "dgvPurchaseBook";
            this.dgvPurchaseBook.RowHeadersVisible = false;
            this.dgvPurchaseBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseBook.Size = new System.Drawing.Size(1049, 181);
            this.dgvPurchaseBook.TabIndex = 0;
            this.dgvPurchaseBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseBook_CellClick);
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(24, 11);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(113, 36);
            this.lblHerader.TabIndex = 431;
            this.lblHerader.Text = "खरेदी बुक";
            // 
            // AllPurchaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 520);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.Name = "AllPurchaseDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AllPurchaseDetails_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllPurchaseDetails_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnew;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcelConvert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPurchaseBook;
        private System.Windows.Forms.DataGridView dgvPurchaseItems;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rbtnCredit;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSNCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn rackNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseRateWithGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualPurchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxableAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesCashRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseChalanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseItemDetailId;
        private System.Windows.Forms.Label lblHerader;
    }
}