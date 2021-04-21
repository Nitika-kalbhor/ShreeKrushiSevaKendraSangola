namespace Dlogic_Wholesaler.Forms
{
    partial class frmDamagedStockExpiry
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAccountName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.dtpChallenDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.dgvUpdateList = new System.Windows.Forms.DataGridView();
            this.FinancialYearID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagedStockExpiryId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagedStockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtpFromChallanDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToChallanDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvItemName = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChallanList = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNaration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.lblNetBill = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSaleItems = new System.Windows.Forms.DataGridView();
            this.lblHerader = new System.Windows.Forms.Label();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagedStockExpiryItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFD_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemName)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 10);
            this.panel1.TabIndex = 318;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAccountName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtInvoice);
            this.groupBox1.Controls.Add(this.dtpChallenDate);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 65);
            this.groupBox1.TabIndex = 319;
            this.groupBox1.TabStop = false;
            // 
            // cmbAccountName
            // 
            this.cmbAccountName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccountName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccountName.FormattingEnabled = true;
            this.cmbAccountName.Location = new System.Drawing.Point(537, 20);
            this.cmbAccountName.Name = "cmbAccountName";
            this.cmbAccountName.Size = new System.Drawing.Size(237, 29);
            this.cmbAccountName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 331;
            this.label1.Text = "खात्याचे नांव :";
            // 
            // txtInvoice
            // 
            this.txtInvoice.BackColor = System.Drawing.Color.White;
            this.txtInvoice.Location = new System.Drawing.Point(80, 20);
            this.txtInvoice.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.ReadOnly = true;
            this.txtInvoice.Size = new System.Drawing.Size(117, 29);
            this.txtInvoice.TabIndex = 0;
            // 
            // dtpChallenDate
            // 
            this.dtpChallenDate.CustomFormat = "dd-MM-yyyy";
            this.dtpChallenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChallenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChallenDate.Location = new System.Drawing.Point(279, 21);
            this.dtpChallenDate.Name = "dtpChallenDate";
            this.dtpChallenDate.Size = new System.Drawing.Size(122, 26);
            this.dtpChallenDate.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(216, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 21);
            this.metroLabel1.TabIndex = 100;
            this.metroLabel1.Text = "दिनांक :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 24);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 21);
            this.metroLabel2.TabIndex = 97;
            this.metroLabel2.Text = "क्रमांक:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(20, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1065, 209);
            this.groupBox2.TabIndex = 320;
            this.groupBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grbList);
            this.panel4.Controls.Add(this.dgvItemName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(603, 190);
            this.panel4.TabIndex = 1;
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.dgvUpdateList);
            this.grbList.Controls.Add(this.btnShow);
            this.grbList.Controls.Add(this.dtpFromChallanDate);
            this.grbList.Controls.Add(this.dtpToChallanDate);
            this.grbList.Controls.Add(this.label3);
            this.grbList.Controls.Add(this.label2);
            this.grbList.Location = new System.Drawing.Point(7, 6);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(575, 179);
            this.grbList.TabIndex = 335;
            this.grbList.TabStop = false;
            this.grbList.Visible = false;
            // 
            // dgvUpdateList
            // 
            this.dgvUpdateList.AllowUserToAddRows = false;
            this.dgvUpdateList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUpdateList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUpdateList.BackgroundColor = System.Drawing.Color.White;
            this.dgvUpdateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FinancialYearID,
            this.damagedStockExpiryId1,
            this.InvoiceId,
            this.damagedStockDate,
            this.remark,
            this.Amount});
            this.dgvUpdateList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUpdateList.GridColor = System.Drawing.Color.Black;
            this.dgvUpdateList.Location = new System.Drawing.Point(20, 46);
            this.dgvUpdateList.Name = "dgvUpdateList";
            this.dgvUpdateList.RowHeadersVisible = false;
            this.dgvUpdateList.Size = new System.Drawing.Size(515, 127);
            this.dgvUpdateList.TabIndex = 0;
            this.dgvUpdateList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateList_CellClick);
            // 
            // FinancialYearID
            // 
            this.FinancialYearID.DataPropertyName = "FinancialYearID";
            this.FinancialYearID.HeaderText = "FinancialYearID";
            this.FinancialYearID.Name = "FinancialYearID";
            this.FinancialYearID.Visible = false;
            // 
            // damagedStockExpiryId1
            // 
            this.damagedStockExpiryId1.DataPropertyName = "damagedStockExpiryId";
            this.damagedStockExpiryId1.HeaderText = " नं";
            this.damagedStockExpiryId1.Name = "damagedStockExpiryId1";
            this.damagedStockExpiryId1.Visible = false;
            // 
            // InvoiceId
            // 
            this.InvoiceId.DataPropertyName = "InvoiceId";
            this.InvoiceId.HeaderText = "बिल नं";
            this.InvoiceId.Name = "InvoiceId";
            // 
            // damagedStockDate
            // 
            this.damagedStockDate.DataPropertyName = "damagedStockDate";
            this.damagedStockDate.HeaderText = "दिनांक";
            this.damagedStockDate.Name = "damagedStockDate";
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "तपशील";
            this.remark.Name = "remark";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "रक्कम";
            this.Amount.Name = "Amount";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(423, 8);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(91, 34);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "दाखवा ";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtpFromChallanDate
            // 
            this.dtpFromChallanDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromChallanDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromChallanDate.Location = new System.Drawing.Point(104, 11);
            this.dtpFromChallanDate.Name = "dtpFromChallanDate";
            this.dtpFromChallanDate.Size = new System.Drawing.Size(116, 29);
            this.dtpFromChallanDate.TabIndex = 0;
            // 
            // dtpToChallanDate
            // 
            this.dtpToChallanDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToChallanDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToChallanDate.Location = new System.Drawing.Point(294, 11);
            this.dtpToChallanDate.Name = "dtpToChallanDate";
            this.dtpToChallanDate.Size = new System.Drawing.Size(113, 29);
            this.dtpToChallanDate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 343;
            this.label3.Text = "ते दिनांक:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 341;
            this.label2.Text = "पासून दिनांक:";
            // 
            // dgvItemName
            // 
            this.dgvItemName.AllowUserToAddRows = false;
            this.dgvItemName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemName.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemName.ColumnHeadersVisible = false;
            this.dgvItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemName.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItemName.GridColor = System.Drawing.Color.Black;
            this.dgvItemName.Location = new System.Drawing.Point(0, 0);
            this.dgvItemName.Name = "dgvItemName";
            this.dgvItemName.RowHeadersVisible = false;
            this.dgvItemName.Size = new System.Drawing.Size(603, 190);
            this.dgvItemName.TabIndex = 0;
            this.dgvItemName.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemName_CellDoubleClick);
            this.dgvItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItemName_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnChallanList);
            this.panel3.Controls.Add(this.btnnew);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.txtNaration);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtNetAmount);
            this.panel3.Controls.Add(this.lblNetBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.panel3.Location = new System.Drawing.Point(606, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 190);
            this.panel3.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(253, 115);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 34);
            this.btnDelete.TabIndex = 3;
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
            this.btnChallanList.Location = new System.Drawing.Point(350, 115);
            this.btnChallanList.Name = "btnChallanList";
            this.btnChallanList.Size = new System.Drawing.Size(94, 34);
            this.btnChallanList.TabIndex = 4;
            this.btnChallanList.Text = " यादी ";
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
            this.btnnew.Location = new System.Drawing.Point(15, 115);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(91, 34);
            this.btnnew.TabIndex = 5;
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
            this.btnSave.Location = new System.Drawing.Point(114, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "जतन करा(Alt+S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNaration
            // 
            this.txtNaration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNaration.BackColor = System.Drawing.Color.White;
            this.txtNaration.Location = new System.Drawing.Point(279, 44);
            this.txtNaration.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtNaration.Multiline = true;
            this.txtNaration.Name = "txtNaration";
            this.txtNaration.Size = new System.Drawing.Size(174, 51);
            this.txtNaration.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label4.Location = new System.Drawing.Point(172, 52);
            this.label4.MinimumSize = new System.Drawing.Size(60, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 327;
            this.label4.Text = "तपशील :";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNetAmount.BackColor = System.Drawing.Color.White;
            this.txtNetAmount.Location = new System.Drawing.Point(279, 9);
            this.txtNetAmount.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(174, 29);
            this.txtNetAmount.TabIndex = 0;
            // 
            // lblNetBill
            // 
            this.lblNetBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetBill.AutoSize = true;
            this.lblNetBill.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lblNetBill.Location = new System.Drawing.Point(172, 12);
            this.lblNetBill.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblNetBill.Name = "lblNetBill";
            this.lblNetBill.Size = new System.Drawing.Size(79, 21);
            this.lblNetBill.TabIndex = 325;
            this.lblNetBill.Text = "एकूण रक्कम:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSaleItems);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 206);
            this.panel2.TabIndex = 321;
            // 
            // dgvSaleItems
            // 
            this.dgvSaleItems.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSaleItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaleItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
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
            this.damagedStockExpiryItemId,
            this.itemName,
            this.batchNo,
            this.MFD_Date,
            this.expireDate,
            this.unitBy,
            this.Quantity,
            this.purchaseRate,
            this.totalAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSaleItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleItems.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvSaleItems.Location = new System.Drawing.Point(0, 0);
            this.dgvSaleItems.Name = "dgvSaleItems";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSaleItems.RowHeadersVisible = false;
            this.dgvSaleItems.RowTemplate.Height = 25;
            this.dgvSaleItems.Size = new System.Drawing.Size(1065, 206);
            this.dgvSaleItems.TabIndex = 0;
            this.dgvSaleItems.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvSaleItems_CurrentCellDirtyStateChanged);
            this.dgvSaleItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSaleItems_KeyDown);
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(24, 6);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(241, 33);
            this.lblHerader.TabIndex = 351;
            this.lblHerader.Text = "खराब स्टॉक / एक्सपायरी";
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
            // damagedStockExpiryItemId
            // 
            this.damagedStockExpiryItemId.HeaderText = "damagedStockExpiryItemId";
            this.damagedStockExpiryItemId.Name = "damagedStockExpiryItemId";
            this.damagedStockExpiryItemId.Visible = false;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "तपशील";
            this.itemName.Name = "itemName";
            this.itemName.Width = 350;
            // 
            // batchNo
            // 
            this.batchNo.HeaderText = "बॅच नं";
            this.batchNo.Name = "batchNo";
            this.batchNo.ReadOnly = true;
            this.batchNo.Width = 110;
            // 
            // MFD_Date
            // 
            this.MFD_Date.HeaderText = "MFD_Date";
            this.MFD_Date.Name = "MFD_Date";
            this.MFD_Date.ReadOnly = true;
            this.MFD_Date.Width = 120;
            // 
            // expireDate
            // 
            this.expireDate.HeaderText = "Expire Date";
            this.expireDate.Name = "expireDate";
            this.expireDate.ReadOnly = true;
            this.expireDate.Width = 120;
            // 
            // unitBy
            // 
            this.unitBy.HeaderText = "पॅकींग";
            this.unitBy.Name = "unitBy";
            this.unitBy.ReadOnly = true;
            this.unitBy.ToolTipText = "QTY";
            this.unitBy.Width = 80;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "नग";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 70;
            // 
            // purchaseRate
            // 
            this.purchaseRate.HeaderText = "दर";
            this.purchaseRate.Name = "purchaseRate";
            // 
            // totalAmount
            // 
            this.totalAmount.HeaderText = "रक्कम";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            this.totalAmount.Width = 120;
            // 
            // frmDamagedStockExpiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 570);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmDamagedStockExpiry";
            this.Load += new System.EventHandler(this.frmDamagedStockExpiry_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDamagedStockExpiry_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemName)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.DateTimePicker dtpChallenDate;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAccountName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvItemName;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.DataGridView dgvUpdateList;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dtpToChallanDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromChallanDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label lblNetBill;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChallanList;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvSaleItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinancialYearID;
        private System.Windows.Forms.DataGridViewTextBoxColumn damagedStockExpiryId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn damagedStockDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label lblHerader;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn damagedStockExpiryItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFD_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
    }
}