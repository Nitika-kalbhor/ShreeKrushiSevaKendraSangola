namespace Dlogic_Wholesaler.Forms
{
    partial class frmBankDeposit
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbAccountName = new System.Windows.Forms.ComboBox();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.chbCash = new System.Windows.Forms.CheckBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.txtNaration = new System.Windows.Forms.TextBox();
            this.dtpChequeDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbAccounttype = new System.Windows.Forms.ComboBox();
            this.lblNaration = new System.Windows.Forms.Label();
            this.lblChequeDate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.lblChequeNo = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbtransactiontype = new System.Windows.Forms.ComboBox();
            this.lblBankName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBankTransaction = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHerader = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankTransaction)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 10);
            this.panel1.TabIndex = 342;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbAccountName);
            this.panel3.Controls.Add(this.cmbPaymentType);
            this.panel3.Controls.Add(this.chbCash);
            this.panel3.Controls.Add(this.lblAccountType);
            this.panel3.Controls.Add(this.txtNaration);
            this.panel3.Controls.Add(this.dtpChequeDate);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.cmbAccounttype);
            this.panel3.Controls.Add(this.lblNaration);
            this.panel3.Controls.Add(this.lblChequeDate);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.lblAccountName);
            this.panel3.Controls.Add(this.dtpDate);
            this.panel3.Controls.Add(this.txtChequeNo);
            this.panel3.Controls.Add(this.btnnew);
            this.panel3.Controls.Add(this.lblTransactionDate);
            this.panel3.Controls.Add(this.lblChequeNo);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Controls.Add(this.lblTransaction);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.txtBankName);
            this.panel3.Controls.Add(this.lblAmount);
            this.panel3.Controls.Add(this.cmbtransactiontype);
            this.panel3.Controls.Add(this.lblBankName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(20, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 436);
            this.panel3.TabIndex = 0;
            // 
            // cmbAccountName
            // 
            this.cmbAccountName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccountName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccountName.BackColor = System.Drawing.Color.White;
            this.cmbAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAccountName.ForeColor = System.Drawing.Color.Black;
            this.cmbAccountName.FormattingEnabled = true;
            this.cmbAccountName.Location = new System.Drawing.Point(153, 88);
            this.cmbAccountName.Margin = new System.Windows.Forms.Padding(5);
            this.cmbAccountName.Name = "cmbAccountName";
            this.cmbAccountName.Size = new System.Drawing.Size(305, 28);
            this.cmbAccountName.TabIndex = 2;
            this.cmbAccountName.SelectedIndexChanged += new System.EventHandler(this.cmbAccountName_SelectedIndexChanged);
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.BackColor = System.Drawing.Color.White;
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbPaymentType.ForeColor = System.Drawing.Color.Black;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Card Payment",
            "Cheque",
            "IMPS & NEFT & RTGS"});
            this.cmbPaymentType.Location = new System.Drawing.Point(153, 213);
            this.cmbPaymentType.Margin = new System.Windows.Forms.Padding(5);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(184, 28);
            this.cmbPaymentType.TabIndex = 6;
            this.cmbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentType_SelectedIndexChanged);
            // 
            // chbCash
            // 
            this.chbCash.AutoSize = true;
            this.chbCash.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCash.Location = new System.Drawing.Point(348, 207);
            this.chbCash.Margin = new System.Windows.Forms.Padding(5);
            this.chbCash.Name = "chbCash";
            this.chbCash.Size = new System.Drawing.Size(110, 29);
            this.chbCash.TabIndex = 7;
            this.chbCash.Text = "दुकान रक्कम";
            this.chbCash.UseVisualStyleBackColor = true;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(24, 55);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(83, 18);
            this.lblAccountType.TabIndex = 348;
            this.lblAccountType.Text = "खाते प्रकार  :";
            // 
            // txtNaration
            // 
            this.txtNaration.BackColor = System.Drawing.Color.White;
            this.txtNaration.Font = new System.Drawing.Font("Arial Unicode MS", 14F);
            this.txtNaration.ForeColor = System.Drawing.Color.Black;
            this.txtNaration.Location = new System.Drawing.Point(153, 167);
            this.txtNaration.Margin = new System.Windows.Forms.Padding(5);
            this.txtNaration.MaxLength = 600;
            this.txtNaration.MinimumSize = new System.Drawing.Size(81, 4);
            this.txtNaration.Name = "txtNaration";
            this.txtNaration.Size = new System.Drawing.Size(305, 33);
            this.txtNaration.TabIndex = 5;
            // 
            // dtpChequeDate
            // 
            this.dtpChequeDate.CustomFormat = "dd-MM-yyyy";
            this.dtpChequeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChequeDate.Location = new System.Drawing.Point(153, 337);
            this.dtpChequeDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpChequeDate.Name = "dtpChequeDate";
            this.dtpChequeDate.Size = new System.Drawing.Size(184, 26);
            this.dtpChequeDate.TabIndex = 10;
            this.dtpChequeDate.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(284, 388);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 39);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "अपडेट";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbAccounttype
            // 
            this.cmbAccounttype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccounttype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccounttype.BackColor = System.Drawing.Color.White;
            this.cmbAccounttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccounttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAccounttype.ForeColor = System.Drawing.Color.Black;
            this.cmbAccounttype.FormattingEnabled = true;
            this.cmbAccounttype.Location = new System.Drawing.Point(153, 50);
            this.cmbAccounttype.Margin = new System.Windows.Forms.Padding(5);
            this.cmbAccounttype.Name = "cmbAccounttype";
            this.cmbAccounttype.Size = new System.Drawing.Size(305, 28);
            this.cmbAccounttype.TabIndex = 1;
            this.cmbAccounttype.SelectedIndexChanged += new System.EventHandler(this.cmbAccounttype_SelectedIndexChanged);
            // 
            // lblNaration
            // 
            this.lblNaration.AutoSize = true;
            this.lblNaration.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaration.Location = new System.Drawing.Point(24, 174);
            this.lblNaration.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNaration.Name = "lblNaration";
            this.lblNaration.Size = new System.Drawing.Size(60, 18);
            this.lblNaration.TabIndex = 358;
            this.lblNaration.Text = "तपशील :";
            // 
            // lblChequeDate
            // 
            this.lblChequeDate.AutoSize = true;
            this.lblChequeDate.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeDate.Location = new System.Drawing.Point(24, 342);
            this.lblChequeDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChequeDate.Name = "lblChequeDate";
            this.lblChequeDate.Size = new System.Drawing.Size(112, 18);
            this.lblChequeDate.TabIndex = 370;
            this.lblChequeDate.Text = "चेक/रेफ  दिनांक  :";
            this.lblChequeDate.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(380, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 39);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "डिलीट";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(24, 93);
            this.lblAccountName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(76, 18);
            this.lblAccountName.TabIndex = 350;
            this.lblAccountName.Text = "खाते नाव  :";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(153, 14);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(201, 26);
            this.dtpDate.TabIndex = 0;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.BackColor = System.Drawing.Color.White;
            this.txtChequeNo.Font = new System.Drawing.Font("Arial Unicode MS", 14F);
            this.txtChequeNo.ForeColor = System.Drawing.Color.Black;
            this.txtChequeNo.Location = new System.Drawing.Point(153, 294);
            this.txtChequeNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtChequeNo.MaxLength = 500;
            this.txtChequeNo.MinimumSize = new System.Drawing.Size(81, 4);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(184, 33);
            this.txtChequeNo.TabIndex = 9;
            this.txtChequeNo.Visible = false;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(9, 388);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(125, 39);
            this.btnnew.TabIndex = 14;
            this.btnnew.Text = "नवीन(Alt+N)";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionDate.Location = new System.Drawing.Point(24, 19);
            this.lblTransactionDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(60, 18);
            this.lblTransactionDate.TabIndex = 355;
            this.lblTransactionDate.Text = " दिनांक :";
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeNo.Location = new System.Drawing.Point(24, 301);
            this.lblChequeNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(79, 18);
            this.lblChequeNo.TabIndex = 369;
            this.lblChequeNo.Text = "चेक /रेफ नं :";
            this.lblChequeNo.Visible = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(132, 388);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(146, 39);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "जतन करा(Alt+S)";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.Location = new System.Drawing.Point(24, 217);
            this.lblTransaction.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(126, 18);
            this.lblTransaction.TabIndex = 352;
            this.lblTransaction.Text = "पैसे भरण्याची पद्धत :";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.Font = new System.Drawing.Font("Arial Unicode MS", 14F);
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.Location = new System.Drawing.Point(153, 126);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5);
            this.txtAmount.MaxLength = 30;
            this.txtAmount.MinimumSize = new System.Drawing.Size(81, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(143, 33);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtBankName
            // 
            this.txtBankName.BackColor = System.Drawing.Color.White;
            this.txtBankName.Font = new System.Drawing.Font("Arial Unicode MS", 14F);
            this.txtBankName.ForeColor = System.Drawing.Color.Black;
            this.txtBankName.Location = new System.Drawing.Point(153, 251);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(5);
            this.txtBankName.MaxLength = 500;
            this.txtBankName.MinimumSize = new System.Drawing.Size(81, 4);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(184, 33);
            this.txtBankName.TabIndex = 8;
            this.txtBankName.Visible = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(24, 133);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(44, 18);
            this.lblAmount.TabIndex = 354;
            this.lblAmount.Text = "रक्कम :";
            // 
            // cmbtransactiontype
            // 
            this.cmbtransactiontype.BackColor = System.Drawing.Color.White;
            this.cmbtransactiontype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtransactiontype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbtransactiontype.ForeColor = System.Drawing.Color.Black;
            this.cmbtransactiontype.FormattingEnabled = true;
            this.cmbtransactiontype.Items.AddRange(new object[] {
            "पैसे भरणे",
            "पैसे काढणे"});
            this.cmbtransactiontype.Location = new System.Drawing.Point(302, 129);
            this.cmbtransactiontype.Margin = new System.Windows.Forms.Padding(5);
            this.cmbtransactiontype.Name = "cmbtransactiontype";
            this.cmbtransactiontype.Size = new System.Drawing.Size(156, 28);
            this.cmbtransactiontype.TabIndex = 4;
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.Location = new System.Drawing.Point(24, 257);
            this.lblBankName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(65, 18);
            this.lblBankName.TabIndex = 367;
            this.lblBankName.Text = "बँक नाव :";
            this.lblBankName.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBankTransaction);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(492, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 362);
            this.groupBox2.TabIndex = 375;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "बँक जमा /नावे माहिती ";
            // 
            // dgvBankTransaction
            // 
            this.dgvBankTransaction.AllowUserToAddRows = false;
            this.dgvBankTransaction.BackgroundColor = System.Drawing.Color.White;
            this.dgvBankTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankTransaction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBankTransaction.Location = new System.Drawing.Point(3, 16);
            this.dgvBankTransaction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBankTransaction.Name = "dgvBankTransaction";
            this.dgvBankTransaction.RowHeadersVisible = false;
            this.dgvBankTransaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvBankTransaction.Size = new System.Drawing.Size(711, 343);
            this.dgvBankTransaction.TabIndex = 360;
            this.dgvBankTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBankTransaction_CellClick);
            this.dgvBankTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBankTransaction_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(492, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 74);
            this.groupBox1.TabIndex = 374;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "शोधा";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(367, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "शोधा";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(244, 31);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(104, 26);
            this.dtpToDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 359;
            this.label2.Text = "ते :";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(74, 31);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(111, 26);
            this.dtpFromDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 357;
            this.label1.Text = "पासून  :";
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(486, 12);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(117, 36);
            this.lblHerader.TabIndex = 421;
            this.lblHerader.Text = "बँक भरणा";
            // 
            // frmBankDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 526);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmBankDeposit";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmBankDeposit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBankDeposit_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankTransaction)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbAccountName;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.CheckBox chbCash;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.TextBox txtNaration;
        private System.Windows.Forms.DateTimePicker dtpChequeDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbAccounttype;
        private System.Windows.Forms.Label lblNaration;
        private System.Windows.Forms.Label lblChequeDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.Label lblChequeNo;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbtransactiontype;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBankTransaction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHerader;
    }
}