namespace Dlogic_Wholesaler.Forms
{
    partial class frmStockOut
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.dtpChallenDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvPurchaseItems = new System.Windows.Forms.DataGridView();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOutItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesCashRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNaration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChallanList = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.txtBalanceAmount = new System.Windows.Forms.TextBox();
            this.lblNetBill = new System.Windows.Forms.Label();
            this.lblBakiAmount = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.grbItemList = new System.Windows.Forms.GroupBox();
            this.grbChallanList = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvSaleChallan = new System.Windows.Forms.DataGridView();
            this.StockOutID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalesChallanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtpToChallanDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromChallanDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvItemName = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItems)).BeginInit();
            this.panel5.SuspendLayout();
            this.grbItemList.SuspendLayout();
            this.grbChallanList.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleChallan)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemName)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 10);
            this.panel1.TabIndex = 318;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInvoiceNo);
            this.groupBox1.Controls.Add(this.dtpChallenDate);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 70);
            this.groupBox1.TabIndex = 319;
            this.groupBox1.TabStop = false;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BackColor = System.Drawing.Color.White;
            this.txtInvoiceNo.Location = new System.Drawing.Point(145, 19);
            this.txtInvoiceNo.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(174, 29);
            this.txtInvoiceNo.TabIndex = 329;
            // 
            // dtpChallenDate
            // 
            this.dtpChallenDate.CustomFormat = "dd-MM-yyyy";
            this.dtpChallenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChallenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChallenDate.Location = new System.Drawing.Point(428, 21);
            this.dtpChallenDate.Name = "dtpChallenDate";
            this.dtpChallenDate.Size = new System.Drawing.Size(122, 26);
            this.dtpChallenDate.TabIndex = 101;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(344, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 21);
            this.metroLabel1.TabIndex = 100;
            this.metroLabel1.Text = "दिनांक :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 21);
            this.metroLabel2.TabIndex = 97;
            this.metroLabel2.Text = "स्टॉक ऑऊट नं :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.groupBox2.Location = new System.Drawing.Point(20, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(986, 233);
            this.groupBox2.TabIndex = 320;
            this.groupBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvPurchaseItems);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(980, 205);
            this.panel4.TabIndex = 13;
            // 
            // dgvPurchaseItems
            // 
            this.dgvPurchaseItems.AllowUserToAddRows = false;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPurchaseItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPurchaseItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPurchaseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemId,
            this.stockOutItemID,
            this.stockId,
            this.companyId,
            this.categoryId,
            this.itemName,
            this.batchNo,
            this.Quantity,
            this.unitBy,
            this.freeQuantity,
            this.purchaseRate,
            this.salesCashRate,
            this.IGST,
            this.IGSTAmt,
            this.CGST,
            this.CGSTAmt,
            this.SGST,
            this.SGSTAmt,
            this.discount,
            this.totalAmount});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseItems.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPurchaseItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseItems.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvPurchaseItems.Location = new System.Drawing.Point(0, 0);
            this.dgvPurchaseItems.Name = "dgvPurchaseItems";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPurchaseItems.RowHeadersVisible = false;
            this.dgvPurchaseItems.RowTemplate.Height = 25;
            this.dgvPurchaseItems.Size = new System.Drawing.Size(980, 205);
            this.dgvPurchaseItems.TabIndex = 1;
            this.dgvPurchaseItems.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSaleItems_CellMouseUp);
            this.dgvPurchaseItems.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvSaleItems_CurrentCellDirtyStateChanged);
            this.dgvPurchaseItems.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSaleItems_EditingControlShowing);
            this.dgvPurchaseItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSaleItems_KeyDown);
            // 
            // itemId
            // 
            this.itemId.HeaderText = "itemId";
            this.itemId.Name = "itemId";
            this.itemId.Visible = false;
            // 
            // stockOutItemID
            // 
            this.stockOutItemID.HeaderText = "stockOutItemID";
            this.stockOutItemID.Name = "stockOutItemID";
            this.stockOutItemID.Visible = false;
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
            // itemName
            // 
            this.itemName.FillWeight = 43.59277F;
            this.itemName.HeaderText = "तपशील";
            this.itemName.Name = "itemName";
            this.itemName.Width = 300;
            // 
            // batchNo
            // 
            this.batchNo.FillWeight = 18.14502F;
            this.batchNo.HeaderText = "बॅच नं";
            this.batchNo.Name = "batchNo";
            this.batchNo.ReadOnly = true;
            this.batchNo.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 16.85268F;
            this.Quantity.HeaderText = "नग";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 116;
            // 
            // unitBy
            // 
            this.unitBy.FillWeight = 15.69261F;
            this.unitBy.HeaderText = "पॅकींग";
            this.unitBy.Name = "unitBy";
            this.unitBy.ToolTipText = "QTY";
            this.unitBy.Width = 108;
            // 
            // freeQuantity
            // 
            this.freeQuantity.FillWeight = 14.65128F;
            this.freeQuantity.HeaderText = "मोफत नग";
            this.freeQuantity.Name = "freeQuantity";
            this.freeQuantity.Width = 101;
            // 
            // purchaseRate
            // 
            this.purchaseRate.HeaderText = "खरीदी दर";
            this.purchaseRate.Name = "purchaseRate";
            this.purchaseRate.Visible = false;
            // 
            // salesCashRate
            // 
            this.salesCashRate.FillWeight = 13.71654F;
            this.salesCashRate.HeaderText = "सेल दर";
            this.salesCashRate.Name = "salesCashRate";
            this.salesCashRate.Width = 94;
            // 
            // IGST
            // 
            this.IGST.HeaderText = "IGST(%)";
            this.IGST.Name = "IGST";
            this.IGST.Visible = false;
            // 
            // IGSTAmt
            // 
            this.IGSTAmt.HeaderText = "IGST रक्कम";
            this.IGSTAmt.Name = "IGSTAmt";
            this.IGSTAmt.Visible = false;
            this.IGSTAmt.Width = 90;
            // 
            // CGST
            // 
            this.CGST.HeaderText = "CGST(%)";
            this.CGST.Name = "CGST";
            this.CGST.Visible = false;
            // 
            // CGSTAmt
            // 
            this.CGSTAmt.HeaderText = "CGST रक्कम";
            this.CGSTAmt.Name = "CGSTAmt";
            this.CGSTAmt.Visible = false;
            this.CGSTAmt.Width = 90;
            // 
            // SGST
            // 
            this.SGST.HeaderText = "SGST(%)";
            this.SGST.Name = "SGST";
            this.SGST.Visible = false;
            // 
            // SGSTAmt
            // 
            this.SGSTAmt.HeaderText = "SGST रक्कम";
            this.SGSTAmt.Name = "SGSTAmt";
            this.SGSTAmt.Visible = false;
            this.SGSTAmt.Width = 90;
            // 
            // discount
            // 
            this.discount.HeaderText = "सवलत";
            this.discount.Name = "discount";
            this.discount.Visible = false;
            // 
            // totalAmount
            // 
            this.totalAmount.FillWeight = 19.31621F;
            this.totalAmount.HeaderText = "रक्कम";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtNaration);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnChallanList);
            this.panel5.Controls.Add(this.btnnew);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.txtNetAmount);
            this.panel5.Controls.Add(this.txtBalanceAmount);
            this.panel5.Controls.Add(this.lblNetBill);
            this.panel5.Controls.Add(this.lblBakiAmount);
            this.panel5.Controls.Add(this.txtPaidAmount);
            this.panel5.Controls.Add(this.lblPaidAmount);
            this.panel5.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.panel5.Location = new System.Drawing.Point(583, 373);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(423, 221);
            this.panel5.TabIndex = 321;
            // 
            // txtNaration
            // 
            this.txtNaration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNaration.BackColor = System.Drawing.Color.White;
            this.txtNaration.Location = new System.Drawing.Point(235, 114);
            this.txtNaration.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtNaration.Multiline = true;
            this.txtNaration.Name = "txtNaration";
            this.txtNaration.Size = new System.Drawing.Size(174, 55);
            this.txtNaration.TabIndex = 322;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label1.Location = new System.Drawing.Point(118, 117);
            this.label1.MinimumSize = new System.Drawing.Size(60, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 323;
            this.label1.Text = "तपशील :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(204, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 34);
            this.btnDelete.TabIndex = 321;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChallanList
            // 
            this.btnChallanList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnChallanList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnChallanList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChallanList.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChallanList.ForeColor = System.Drawing.Color.White;
            this.btnChallanList.Location = new System.Drawing.Point(296, 176);
            this.btnChallanList.Name = "btnChallanList";
            this.btnChallanList.Size = new System.Drawing.Size(124, 34);
            this.btnChallanList.TabIndex = 320;
            this.btnChallanList.Text = "स्टॉक ऑऊट यादी ";
            this.btnChallanList.UseVisualStyleBackColor = false;
            this.btnChallanList.Click += new System.EventHandler(this.btnChallanList_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(5, 176);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(102, 34);
            this.btnnew.TabIndex = 316;
            this.btnnew.Text = "नवीन(Alt+N)";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(113, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 34);
            this.btnSave.TabIndex = 315;
            this.btnSave.Text = "जतन(Alt+S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNetAmount.BackColor = System.Drawing.Color.White;
            this.txtNetAmount.Location = new System.Drawing.Point(235, 9);
            this.txtNetAmount.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(174, 29);
            this.txtNetAmount.TabIndex = 295;
            this.txtNetAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNetAmount_KeyPress);
            // 
            // txtBalanceAmount
            // 
            this.txtBalanceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBalanceAmount.BackColor = System.Drawing.Color.White;
            this.txtBalanceAmount.Location = new System.Drawing.Point(235, 77);
            this.txtBalanceAmount.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.ReadOnly = true;
            this.txtBalanceAmount.Size = new System.Drawing.Size(174, 29);
            this.txtBalanceAmount.TabIndex = 301;
            this.txtBalanceAmount.Visible = false;
            this.txtBalanceAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalanceAmount_KeyPress);
            // 
            // lblNetBill
            // 
            this.lblNetBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetBill.AutoSize = true;
            this.lblNetBill.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lblNetBill.Location = new System.Drawing.Point(118, 12);
            this.lblNetBill.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblNetBill.Name = "lblNetBill";
            this.lblNetBill.Size = new System.Drawing.Size(79, 21);
            this.lblNetBill.TabIndex = 296;
            this.lblNetBill.Text = "एकूण रक्कम:";
            // 
            // lblBakiAmount
            // 
            this.lblBakiAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBakiAmount.AutoSize = true;
            this.lblBakiAmount.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lblBakiAmount.Location = new System.Drawing.Point(118, 81);
            this.lblBakiAmount.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblBakiAmount.Name = "lblBakiAmount";
            this.lblBakiAmount.Size = new System.Drawing.Size(81, 21);
            this.lblBakiAmount.TabIndex = 302;
            this.lblBakiAmount.Text = "बाकी रक्कम :";
            this.lblBakiAmount.Visible = false;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaidAmount.BackColor = System.Drawing.Color.White;
            this.txtPaidAmount.Location = new System.Drawing.Point(235, 42);
            this.txtPaidAmount.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(174, 29);
            this.txtPaidAmount.TabIndex = 299;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged_1);
            this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidAmount_KeyPress);
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lblPaidAmount.Location = new System.Drawing.Point(118, 46);
            this.lblPaidAmount.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(90, 21);
            this.lblPaidAmount.TabIndex = 300;
            this.lblPaidAmount.Text = "Round Off :";
            // 
            // grbItemList
            // 
            this.grbItemList.Controls.Add(this.grbChallanList);
            this.grbItemList.Controls.Add(this.dgvItemName);
            this.grbItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbItemList.Location = new System.Drawing.Point(20, 373);
            this.grbItemList.Name = "grbItemList";
            this.grbItemList.Size = new System.Drawing.Size(563, 221);
            this.grbItemList.TabIndex = 322;
            this.grbItemList.TabStop = false;
            // 
            // grbChallanList
            // 
            this.grbChallanList.Controls.Add(this.groupBox5);
            this.grbChallanList.Controls.Add(this.groupBox4);
            this.grbChallanList.Location = new System.Drawing.Point(19, 19);
            this.grbChallanList.Name = "grbChallanList";
            this.grbChallanList.Size = new System.Drawing.Size(532, 179);
            this.grbChallanList.TabIndex = 334;
            this.grbChallanList.TabStop = false;
            this.grbChallanList.Text = " ";
            this.grbChallanList.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvSaleChallan);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(526, 113);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // dgvSaleChallan
            // 
            this.dgvSaleChallan.AllowUserToAddRows = false;
            this.dgvSaleChallan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaleChallan.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaleChallan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleChallan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockOutID1,
            this.stockOutDate,
            this.totalAmount1,
            this.totalSalesChallanAmount});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleChallan.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvSaleChallan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleChallan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSaleChallan.Location = new System.Drawing.Point(3, 16);
            this.dgvSaleChallan.Name = "dgvSaleChallan";
            this.dgvSaleChallan.RowHeadersVisible = false;
            this.dgvSaleChallan.Size = new System.Drawing.Size(520, 94);
            this.dgvSaleChallan.TabIndex = 0;
            this.dgvSaleChallan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleChallan_CellClick);
            // 
            // StockOutID1
            // 
            this.StockOutID1.DataPropertyName = "StockOutID";
            this.StockOutID1.HeaderText = "स्टॉक ऑऊट नं";
            this.StockOutID1.Name = "StockOutID1";
            // 
            // stockOutDate
            // 
            this.stockOutDate.DataPropertyName = "stockOutDate";
            this.stockOutDate.HeaderText = "दिनांक ";
            this.stockOutDate.Name = "stockOutDate";
            // 
            // totalAmount1
            // 
            this.totalAmount1.DataPropertyName = "totalAmount";
            this.totalAmount1.HeaderText = "रक्कम";
            this.totalAmount1.Name = "totalAmount1";
            // 
            // totalSalesChallanAmount
            // 
            this.totalSalesChallanAmount.DataPropertyName = "totalSalesChallanAmount";
            this.totalSalesChallanAmount.HeaderText = "तपशील";
            this.totalSalesChallanAmount.Name = "totalSalesChallanAmount";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnShow);
            this.groupBox4.Controls.Add(this.dtpToChallanDate);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dtpFromChallanDate);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 47);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(419, 7);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(91, 34);
            this.btnShow.TabIndex = 345;
            this.btnShow.Text = "दाखवा ";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtpToChallanDate
            // 
            this.dtpToChallanDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToChallanDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToChallanDate.Location = new System.Drawing.Point(302, 12);
            this.dtpToChallanDate.Name = "dtpToChallanDate";
            this.dtpToChallanDate.Size = new System.Drawing.Size(102, 29);
            this.dtpToChallanDate.TabIndex = 344;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 343;
            this.label3.Text = "ते दिनांक:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpFromChallanDate
            // 
            this.dtpFromChallanDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromChallanDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromChallanDate.Location = new System.Drawing.Point(113, 12);
            this.dtpFromChallanDate.Name = "dtpFromChallanDate";
            this.dtpFromChallanDate.Size = new System.Drawing.Size(116, 29);
            this.dtpFromChallanDate.TabIndex = 342;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 341;
            this.label2.Text = "पासून दिनांक:";
            // 
            // dgvItemName
            // 
            this.dgvItemName.AllowUserToAddRows = false;
            this.dgvItemName.AllowUserToDeleteRows = false;
            this.dgvItemName.AllowUserToResizeColumns = false;
            this.dgvItemName.AllowUserToResizeRows = false;
            this.dgvItemName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemName.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemName.ColumnHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemName.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemName.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItemName.Location = new System.Drawing.Point(3, 16);
            this.dgvItemName.Name = "dgvItemName";
            this.dgvItemName.RowHeadersVisible = false;
            this.dgvItemName.Size = new System.Drawing.Size(557, 202);
            this.dgvItemName.TabIndex = 332;
            this.dgvItemName.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemName_CellDoubleClick);
            this.dgvItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItemName_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 26);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.deleteRowToolStripMenuItem.Text = "DeleteRow";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(18, 5);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(133, 36);
            this.lblHerader.TabIndex = 429;
            this.lblHerader.Text = "स्टॉक ऑऊट";
            // 
            // frmStockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 614);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.grbItemList);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmStockOut";
            this.Load += new System.EventHandler(this.frmStockOut_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStockOut_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItems)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.grbItemList.ResumeLayout(false);
            this.grbChallanList.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleChallan)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemName)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.DateTimePicker dtpChallenDate;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvPurchaseItems;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChallanList;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.TextBox txtBalanceAmount;
        private System.Windows.Forms.Label lblNetBill;
        private System.Windows.Forms.Label lblBakiAmount;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.GroupBox grbItemList;
        private System.Windows.Forms.GroupBox grbChallanList;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvSaleChallan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dtpToChallanDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromChallanDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvItemName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNaration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockOutID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalesChallanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOutItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesCashRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
        private System.Windows.Forms.Label lblHerader;
    }
}