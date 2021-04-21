namespace Dlogic_Wholesaler.Forms
{
    partial class frmPurchasseOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new System.Windows.Forms.Label();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.dtpChallenDate = new System.Windows.Forms.DateTimePicker();
            this.cmbDealerName = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.lblstockInNo = new System.Windows.Forms.Label();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvPurchaseItems = new System.Windows.Forms.DataGridView();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.purchaseOrderBillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealerFirmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netBillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Size = new System.Drawing.Size(981, 11);
            this.panel1.TabIndex = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmobile);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.btnNewCustomer);
            this.groupBox1.Controls.Add(this.txtInvoiceNo);
            this.groupBox1.Controls.Add(this.btnNewItem);
            this.groupBox1.Controls.Add(this.dtpChallenDate);
            this.groupBox1.Controls.Add(this.cmbDealerName);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.lblstockInNo);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.groupBox1.Location = new System.Drawing.Point(20, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 137);
            this.groupBox1.TabIndex = 318;
            this.groupBox1.TabStop = false;
            // 
            // txtmobile
            // 
            this.txtmobile.BackColor = System.Drawing.Color.White;
            this.txtmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtmobile.ForeColor = System.Drawing.Color.Black;
            this.txtmobile.Location = new System.Drawing.Point(725, 54);
            this.txtmobile.MaxLength = 10;
            this.txtmobile.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.ReadOnly = true;
            this.txtmobile.Size = new System.Drawing.Size(174, 29);
            this.txtmobile.TabIndex = 336;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(614, 58);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 21);
            this.metroLabel3.TabIndex = 335;
            this.metroLabel3.Text = "मोबाईल नं :";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.Color.Green;
            this.btnNewCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnNewCustomer.Location = new System.Drawing.Point(568, 53);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(35, 29);
            this.btnNewCustomer.TabIndex = 330;
            this.btnNewCustomer.Text = "N";
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BackColor = System.Drawing.Color.White;
            this.txtInvoiceNo.Location = new System.Drawing.Point(145, 19);
            this.txtInvoiceNo.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(174, 29);
            this.txtInvoiceNo.TabIndex = 329;
            // 
            // btnNewItem
            // 
            this.btnNewItem.BackColor = System.Drawing.Color.Green;
            this.btnNewItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewItem.ForeColor = System.Drawing.Color.White;
            this.btnNewItem.Location = new System.Drawing.Point(13, 95);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(104, 34);
            this.btnNewItem.TabIndex = 317;
            this.btnNewItem.Text = "नवीन आयटम";
            this.btnNewItem.UseVisualStyleBackColor = false;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
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
            // cmbDealerName
            // 
            this.cmbDealerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDealerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDealerName.FormattingEnabled = true;
            this.cmbDealerName.Location = new System.Drawing.Point(145, 54);
            this.cmbDealerName.Name = "cmbDealerName";
            this.cmbDealerName.Size = new System.Drawing.Size(418, 28);
            this.cmbDealerName.TabIndex = 0;
            this.cmbDealerName.SelectedIndexChanged += new System.EventHandler(this.cmbDealerName_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(350, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 21);
            this.metroLabel1.TabIndex = 100;
            this.metroLabel1.Text = "दिनांक :";
            // 
            // lblstockInNo
            // 
            this.lblstockInNo.AutoSize = true;
            this.lblstockInNo.Location = new System.Drawing.Point(36, 54);
            this.lblstockInNo.Name = "lblstockInNo";
            this.lblstockInNo.Size = new System.Drawing.Size(99, 21);
            this.lblstockInNo.TabIndex = 96;
            this.lblstockInNo.Text = "व्यापारीचे नांव:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 21);
            this.metroLabel2.TabIndex = 97;
            this.metroLabel2.Text = "बिल नं :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.groupBox2.Location = new System.Drawing.Point(20, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(981, 233);
            this.groupBox2.TabIndex = 319;
            this.groupBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvPurchaseItems);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(975, 205);
            this.panel4.TabIndex = 13;
            // 
            // dgvPurchaseItems
            // 
            this.dgvPurchaseItems.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPurchaseItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPurchaseItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPurchaseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemId,
            this.stockId,
            this.companyId,
            this.categoryId,
            this.itemName,
            this.batchNo,
            this.Quantity,
            this.unitBy,
            this.freeQuantity,
            this.purchaseRate,
            this.MRP,
            this.salesCashRate,
            this.IGST,
            this.IGSTAmt,
            this.CGST,
            this.CGSTAmt,
            this.SGST,
            this.SGSTAmt,
            this.discount,
            this.totalAmount});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseItems.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPurchaseItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseItems.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvPurchaseItems.Location = new System.Drawing.Point(0, 0);
            this.dgvPurchaseItems.Name = "dgvPurchaseItems";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPurchaseItems.RowHeadersVisible = false;
            this.dgvPurchaseItems.RowTemplate.Height = 25;
            this.dgvPurchaseItems.Size = new System.Drawing.Size(975, 205);
            this.dgvPurchaseItems.TabIndex = 0;
            this.dgvPurchaseItems.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPurchaseItems_CellMouseUp);
            this.dgvPurchaseItems.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPurchaseItems_CurrentCellDirtyStateChanged);
            this.dgvPurchaseItems.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPurchaseItems_EditingControlShowing);
            this.dgvPurchaseItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPurchaseItems_KeyDown);
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
            // itemName
            // 
            this.itemName.HeaderText = "तपशील";
            this.itemName.Name = "itemName";
            this.itemName.Width = 300;
            // 
            // batchNo
            // 
            this.batchNo.HeaderText = "बॅच नं";
            this.batchNo.Name = "batchNo";
            this.batchNo.Visible = false;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "नग";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 80;
            // 
            // unitBy
            // 
            this.unitBy.HeaderText = "पॅकींग";
            this.unitBy.Name = "unitBy";
            this.unitBy.ReadOnly = true;
            this.unitBy.ToolTipText = "QTY";
            // 
            // freeQuantity
            // 
            this.freeQuantity.HeaderText = "मोफत नग";
            this.freeQuantity.Name = "freeQuantity";
            this.freeQuantity.Visible = false;
            this.freeQuantity.Width = 80;
            // 
            // purchaseRate
            // 
            this.purchaseRate.HeaderText = "खरीदी दर";
            this.purchaseRate.Name = "purchaseRate";
            this.purchaseRate.Width = 120;
            // 
            // MRP
            // 
            this.MRP.HeaderText = "MRP";
            this.MRP.Name = "MRP";
            this.MRP.Visible = false;
            // 
            // salesCashRate
            // 
            this.salesCashRate.HeaderText = "सेल दर";
            this.salesCashRate.Name = "salesCashRate";
            this.salesCashRate.Visible = false;
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
            // 
            // discount
            // 
            this.discount.HeaderText = "सवलत";
            this.discount.Name = "discount";
            this.discount.Visible = false;
            // 
            // totalAmount
            // 
            this.totalAmount.HeaderText = "रक्कम";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            this.totalAmount.Width = 120;
            // 
            // panel5
            // 
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
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.panel5.Location = new System.Drawing.Point(534, 441);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(467, 213);
            this.panel5.TabIndex = 320;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(194, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 34);
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
            this.btnChallanList.Location = new System.Drawing.Point(270, 153);
            this.btnChallanList.Name = "btnChallanList";
            this.btnChallanList.Size = new System.Drawing.Size(194, 34);
            this.btnChallanList.TabIndex = 320;
            this.btnChallanList.Text = "खरेदी ऑर्डर यादी ";
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
            this.btnnew.Location = new System.Drawing.Point(5, 153);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(97, 34);
            this.btnnew.TabIndex = 0;
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
            this.btnSave.Location = new System.Drawing.Point(102, 153);
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
            this.txtNetAmount.Location = new System.Drawing.Point(275, 22);
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
            this.txtBalanceAmount.Location = new System.Drawing.Point(275, 90);
            this.txtBalanceAmount.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.ReadOnly = true;
            this.txtBalanceAmount.Size = new System.Drawing.Size(174, 29);
            this.txtBalanceAmount.TabIndex = 301;
            this.txtBalanceAmount.Visible = false;
            // 
            // lblNetBill
            // 
            this.lblNetBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetBill.AutoSize = true;
            this.lblNetBill.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lblNetBill.Location = new System.Drawing.Point(158, 26);
            this.lblNetBill.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblNetBill.Name = "lblNetBill";
            this.lblNetBill.Size = new System.Drawing.Size(83, 21);
            this.lblNetBill.TabIndex = 296;
            this.lblNetBill.Text = "एकूण रक्कम :";
            // 
            // lblBakiAmount
            // 
            this.lblBakiAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBakiAmount.AutoSize = true;
            this.lblBakiAmount.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lblBakiAmount.Location = new System.Drawing.Point(160, 94);
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
            this.txtPaidAmount.Location = new System.Drawing.Point(275, 55);
            this.txtPaidAmount.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(174, 29);
            this.txtPaidAmount.TabIndex = 299;
            this.txtPaidAmount.Visible = false;
            this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidAmount_KeyPress);
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lblPaidAmount.Location = new System.Drawing.Point(164, 59);
            this.lblPaidAmount.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(77, 21);
            this.lblPaidAmount.TabIndex = 300;
            this.lblPaidAmount.Text = "जमा रक्कम :";
            this.lblPaidAmount.Visible = false;
            // 
            // grbItemList
            // 
            this.grbItemList.Controls.Add(this.grbChallanList);
            this.grbItemList.Controls.Add(this.dgvItemName);
            this.grbItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbItemList.Location = new System.Drawing.Point(20, 441);
            this.grbItemList.Name = "grbItemList";
            this.grbItemList.Size = new System.Drawing.Size(514, 213);
            this.grbItemList.TabIndex = 321;
            this.grbItemList.TabStop = false;
            // 
            // grbChallanList
            // 
            this.grbChallanList.Controls.Add(this.groupBox5);
            this.grbChallanList.Controls.Add(this.groupBox4);
            this.grbChallanList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChallanList.Location = new System.Drawing.Point(3, 16);
            this.grbChallanList.Name = "grbChallanList";
            this.grbChallanList.Size = new System.Drawing.Size(508, 194);
            this.grbChallanList.TabIndex = 334;
            this.grbChallanList.TabStop = false;
            this.grbChallanList.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvSaleChallan);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(502, 128);
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
            this.purchaseOrderBillId,
            this.dealerFirmName,
            this.purchaseOrderDate,
            this.netBillAmount});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleChallan.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSaleChallan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleChallan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSaleChallan.Location = new System.Drawing.Point(3, 16);
            this.dgvSaleChallan.Name = "dgvSaleChallan";
            this.dgvSaleChallan.RowHeadersVisible = false;
            this.dgvSaleChallan.Size = new System.Drawing.Size(496, 109);
            this.dgvSaleChallan.TabIndex = 0;
            this.dgvSaleChallan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleChallan_CellClick);
            // 
            // purchaseOrderBillId
            // 
            this.purchaseOrderBillId.DataPropertyName = "purchaseOrderBillId";
            this.purchaseOrderBillId.HeaderText = "ऑर्डर न";
            this.purchaseOrderBillId.Name = "purchaseOrderBillId";
            // 
            // dealerFirmName
            // 
            this.dealerFirmName.DataPropertyName = "dealerFirmName";
            this.dealerFirmName.HeaderText = "व्यापारी";
            this.dealerFirmName.Name = "dealerFirmName";
            // 
            // purchaseOrderDate
            // 
            this.purchaseOrderDate.DataPropertyName = "purchaseOrderDate";
            this.purchaseOrderDate.HeaderText = "चलन दिनांक ";
            this.purchaseOrderDate.Name = "purchaseOrderDate";
            // 
            // netBillAmount
            // 
            this.netBillAmount.DataPropertyName = "netBillAmount";
            this.netBillAmount.HeaderText = "रक्कम";
            this.netBillAmount.Name = "netBillAmount";
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
            this.groupBox4.Size = new System.Drawing.Size(502, 47);
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
            this.btnShow.Location = new System.Drawing.Point(419, 9);
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
            this.dtpFromChallanDate.Location = new System.Drawing.Point(102, 12);
            this.dtpFromChallanDate.Name = "dtpFromChallanDate";
            this.dtpFromChallanDate.Size = new System.Drawing.Size(116, 29);
            this.dtpFromChallanDate.TabIndex = 342;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 341;
            this.label2.Text = "पासून दिनांक:";
            // 
            // dgvItemName
            // 
            this.dgvItemName.AllowUserToAddRows = false;
            this.dgvItemName.AllowUserToResizeColumns = false;
            this.dgvItemName.AllowUserToResizeRows = false;
            this.dgvItemName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemName.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemName.ColumnHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemName.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemName.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItemName.Location = new System.Drawing.Point(3, 16);
            this.dgvItemName.Name = "dgvItemName";
            this.dgvItemName.RowHeadersVisible = false;
            this.dgvItemName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemName.Size = new System.Drawing.Size(508, 194);
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
            this.lblHerader.Location = new System.Drawing.Point(23, 7);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(133, 36);
            this.lblHerader.TabIndex = 425;
            this.lblHerader.Text = "खरेदी ऑर्डर";
            // 
            // frmPurchasseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 674);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.grbItemList);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmPurchasseOrder";
            this.Load += new System.EventHandler(this.frmPurchasseOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPurchasseOrder_KeyDown);
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
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.Label metroLabel3;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.DateTimePicker dtpChallenDate;
        private System.Windows.Forms.ComboBox cmbDealerName;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.Label lblstockInNo;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderBillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealerFirmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn netBillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRP;
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