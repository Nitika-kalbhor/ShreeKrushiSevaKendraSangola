namespace Dlogic_Wholesaler.TempReportFroms
{
    partial class frmTempSaleBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rbtnCredit = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.btnExcelConvert = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSaleBook = new System.Windows.Forms.DataGridView();
            this.dgvSaleItems = new System.Windows.Forms.DataGridView();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesChallanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HNSCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFD_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStock1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleRatewithGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesItemDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPesticide = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isFertilizer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isSeeds = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isPGROthers = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.invoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox2.Size = new System.Drawing.Size(1082, 56);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAll.Location = new System.Drawing.Point(92, 18);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(47, 25);
            this.rdbAll.TabIndex = 338;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "सर्व";
            this.rdbAll.UseVisualStyleBackColor = true;
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
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCash.Location = new System.Drawing.Point(172, 19);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(50, 25);
            this.rbtnCash.TabIndex = 336;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "कॅश";
            this.rbtnCash.UseVisualStyleBackColor = true;
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
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 156;
            this.metroLabel3.Text = "ते :-";
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
            this.metroLabel1.Location = new System.Drawing.Point(363, 18);
            this.metroLabel1.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 154;
            this.metroLabel1.Text = "पासून दिनांक :-";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSaleItems);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1082, 180);
            this.groupBox3.TabIndex = 109;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSaleBook);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 236);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            // 
            // dgvSaleBook
            // 
            this.dgvSaleBook.AllowUserToAddRows = false;
            this.dgvSaleBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSaleBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaleBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSaleBook.GridColor = System.Drawing.Color.Black;
            this.dgvSaleBook.Location = new System.Drawing.Point(3, 20);
            this.dgvSaleBook.Name = "dgvSaleBook";
            this.dgvSaleBook.RowHeadersVisible = false;
            this.dgvSaleBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleBook.Size = new System.Drawing.Size(1076, 213);
            this.dgvSaleBook.TabIndex = 0;
            this.dgvSaleBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleBook_CellClick);
            // 
            // dgvSaleItems
            // 
            this.dgvSaleItems.AllowUserToAddRows = false;
            this.dgvSaleItems.AllowUserToResizeColumns = false;
            this.dgvSaleItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSaleItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemId,
            this.companyId,
            this.StockId,
            this.categoryId,
            this.salesChallanId,
            this.itemName,
            this.HNSCode,
            this.batchNo,
            this.MFD_Date,
            this.expireDate,
            this.Quantity,
            this.currentStock1,
            this.unitBy,
            this.SaleRatewithGST,
            this.Rate,
            this.discount,
            this.IGST,
            this.IGSTAmt,
            this.CGST,
            this.CGSTAmt,
            this.SGST,
            this.SGSTAmt,
            this.totalAmount,
            this.salesItemDetailsId,
            this.isPesticide,
            this.isFertilizer,
            this.isSeeds,
            this.isPGROthers,
            this.invoiceNo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSaleItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSaleItems.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvSaleItems.Location = new System.Drawing.Point(3, 23);
            this.dgvSaleItems.Name = "dgvSaleItems";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSaleItems.RowHeadersVisible = false;
            this.dgvSaleItems.RowTemplate.Height = 25;
            this.dgvSaleItems.Size = new System.Drawing.Size(1076, 154);
            this.dgvSaleItems.TabIndex = 5;
            // 
            // itemId
            // 
            this.itemId.HeaderText = "itemId";
            this.itemId.Name = "itemId";
            this.itemId.Visible = false;
            // 
            // companyId
            // 
            this.companyId.HeaderText = "companyId";
            this.companyId.Name = "companyId";
            this.companyId.Visible = false;
            // 
            // StockId
            // 
            this.StockId.HeaderText = "StockId";
            this.StockId.Name = "StockId";
            this.StockId.Visible = false;
            // 
            // categoryId
            // 
            this.categoryId.HeaderText = "categoryId";
            this.categoryId.Name = "categoryId";
            this.categoryId.Visible = false;
            // 
            // salesChallanId
            // 
            this.salesChallanId.HeaderText = "salesChallanId";
            this.salesChallanId.Name = "salesChallanId";
            this.salesChallanId.Visible = false;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "तपशील";
            this.itemName.Name = "itemName";
            this.itemName.Width = 250;
            // 
            // HNSCode
            // 
            this.HNSCode.HeaderText = "HSN कोड";
            this.HNSCode.Name = "HNSCode";
            this.HNSCode.ReadOnly = true;
            // 
            // batchNo
            // 
            this.batchNo.HeaderText = "बॅच नं";
            this.batchNo.Name = "batchNo";
            this.batchNo.ReadOnly = true;
            this.batchNo.Width = 80;
            // 
            // MFD_Date
            // 
            this.MFD_Date.HeaderText = "MFG दिनांक";
            this.MFD_Date.Name = "MFD_Date";
            this.MFD_Date.ReadOnly = true;
            this.MFD_Date.Visible = false;
            // 
            // expireDate
            // 
            this.expireDate.HeaderText = "एक्स दिनांक";
            this.expireDate.Name = "expireDate";
            this.expireDate.ReadOnly = true;
            this.expireDate.Visible = false;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "नग";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 60;
            // 
            // currentStock1
            // 
            this.currentStock1.HeaderText = "currentStock";
            this.currentStock1.Name = "currentStock1";
            this.currentStock1.Visible = false;
            // 
            // unitBy
            // 
            this.unitBy.HeaderText = "पॅकींग";
            this.unitBy.Name = "unitBy";
            this.unitBy.ReadOnly = true;
            this.unitBy.ToolTipText = "QTY";
            this.unitBy.Width = 80;
            // 
            // SaleRatewithGST
            // 
            this.SaleRatewithGST.HeaderText = "दर (with GST)";
            this.SaleRatewithGST.Name = "SaleRatewithGST";
            this.SaleRatewithGST.Visible = false;
            this.SaleRatewithGST.Width = 120;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "दर";
            this.Rate.Name = "Rate";
            this.Rate.Width = 80;
            // 
            // discount
            // 
            this.discount.HeaderText = "सवलत(%)";
            this.discount.Name = "discount";
            this.discount.Width = 80;
            // 
            // IGST
            // 
            this.IGST.HeaderText = "GST(%)";
            this.IGST.Name = "IGST";
            this.IGST.Visible = false;
            this.IGST.Width = 80;
            // 
            // IGSTAmt
            // 
            this.IGSTAmt.HeaderText = "GST रक्कम";
            this.IGSTAmt.Name = "IGSTAmt";
            this.IGSTAmt.ReadOnly = true;
            this.IGSTAmt.Visible = false;
            // 
            // CGST
            // 
            this.CGST.HeaderText = "CGST(%)";
            this.CGST.Name = "CGST";
            this.CGST.Visible = false;
            this.CGST.Width = 80;
            // 
            // CGSTAmt
            // 
            this.CGSTAmt.HeaderText = "CGST रक्कम";
            this.CGSTAmt.Name = "CGSTAmt";
            this.CGSTAmt.ReadOnly = true;
            this.CGSTAmt.Visible = false;
            // 
            // SGST
            // 
            this.SGST.HeaderText = "SGST(%)";
            this.SGST.Name = "SGST";
            this.SGST.Visible = false;
            this.SGST.Width = 80;
            // 
            // SGSTAmt
            // 
            this.SGSTAmt.HeaderText = "SGST रक्कम";
            this.SGSTAmt.Name = "SGSTAmt";
            this.SGSTAmt.ReadOnly = true;
            this.SGSTAmt.Visible = false;
            // 
            // totalAmount
            // 
            this.totalAmount.HeaderText = "रक्कम";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            this.totalAmount.Width = 150;
            // 
            // salesItemDetailsId
            // 
            this.salesItemDetailsId.HeaderText = "salesItemDetailsId";
            this.salesItemDetailsId.Name = "salesItemDetailsId";
            this.salesItemDetailsId.Visible = false;
            // 
            // isPesticide
            // 
            this.isPesticide.HeaderText = "isPesticide";
            this.isPesticide.Name = "isPesticide";
            this.isPesticide.Visible = false;
            // 
            // isFertilizer
            // 
            this.isFertilizer.HeaderText = "isFertilizer";
            this.isFertilizer.Name = "isFertilizer";
            this.isFertilizer.Visible = false;
            // 
            // isSeeds
            // 
            this.isSeeds.HeaderText = "isSeeds";
            this.isSeeds.Name = "isSeeds";
            this.isSeeds.Visible = false;
            // 
            // isPGROthers
            // 
            this.isPGROthers.HeaderText = "isPGROther";
            this.isPGROthers.Name = "isPGROthers";
            this.isPGROthers.Visible = false;
            // 
            // invoiceNo
            // 
            this.invoiceNo.HeaderText = "invoiceNo";
            this.invoiceNo.Name = "invoiceNo";
            this.invoiceNo.Visible = false;
            // 
            // frmTempSaleBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmTempSaleBook";
            this.Text = "सेल बुक 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTempSaleBook_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rbtnCredit;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.Button btnExcelConvert;
        private System.Windows.Forms.Button btnnew;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSaleBook;
        private System.Windows.Forms.DataGridView dgvSaleItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesChallanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HNSCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFD_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentStock1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleRatewithGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesItemDetailsId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPesticide;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFertilizer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSeeds;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPGROthers;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNo;

    }
}