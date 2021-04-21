namespace Dlogic_Wholesaler.Forms
{
    partial class frmVoucherPayment
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
            this.lblVimalDueAmount = new System.Windows.Forms.Label();
            this.lblRemAmount = new System.Windows.Forms.Label();
            this.dtpchedate = new System.Windows.Forms.DateTimePicker();
            this.label33 = new System.Windows.Forms.Label();
            this.txtchqDDNo = new System.Windows.Forms.TextBox();
            this.lblChequeNo = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblPaymenttype = new System.Windows.Forms.Label();
            this.cmbAccountname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNaration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpayid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPaymentVoucher = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAccountNameSerach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtVoucherId = new System.Windows.Forms.TextBox();
            this.cmbAccountGroup = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new System.Windows.Forms.Label();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkOpeningBalance = new System.Windows.Forms.CheckBox();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentVoucher)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVimalDueAmount
            // 
            this.lblVimalDueAmount.AutoSize = true;
            this.lblVimalDueAmount.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblVimalDueAmount.Location = new System.Drawing.Point(381, 203);
            this.lblVimalDueAmount.Name = "lblVimalDueAmount";
            this.lblVimalDueAmount.Size = new System.Drawing.Size(17, 20);
            this.lblVimalDueAmount.TabIndex = 368;
            this.lblVimalDueAmount.Text = "0";
            // 
            // lblRemAmount
            // 
            this.lblRemAmount.AutoSize = true;
            this.lblRemAmount.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblRemAmount.Location = new System.Drawing.Point(275, 203);
            this.lblRemAmount.Name = "lblRemAmount";
            this.lblRemAmount.Size = new System.Drawing.Size(73, 20);
            this.lblRemAmount.TabIndex = 365;
            this.lblRemAmount.Text = "बाकी रक्कम:";
            // 
            // dtpchedate
            // 
            this.dtpchedate.CustomFormat = "dd-MM-yyyy";
            this.dtpchedate.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dtpchedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpchedate.Location = new System.Drawing.Point(464, 267);
            this.dtpchedate.Name = "dtpchedate";
            this.dtpchedate.Size = new System.Drawing.Size(115, 25);
            this.dtpchedate.TabIndex = 9;
            this.dtpchedate.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.label33.Location = new System.Drawing.Point(336, 267);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(78, 20);
            this.label33.TabIndex = 362;
            this.label33.Text = "चेक दिनांक :";
            this.label33.Visible = false;
            // 
            // txtchqDDNo
            // 
            this.txtchqDDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtchqDDNo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtchqDDNo.Location = new System.Drawing.Point(466, 235);
            this.txtchqDDNo.Name = "txtchqDDNo";
            this.txtchqDDNo.Size = new System.Drawing.Size(113, 25);
            this.txtchqDDNo.TabIndex = 7;
            this.txtchqDDNo.Visible = false;
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblChequeNo.Location = new System.Drawing.Point(336, 235);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(46, 20);
            this.lblChequeNo.TabIndex = 360;
            this.lblChequeNo.Text = "चेक नं:";
            this.lblChequeNo.Visible = false;
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblBankName.Location = new System.Drawing.Point(20, 271);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(59, 20);
            this.lblBankName.TabIndex = 359;
            this.lblBankName.Text = "बँक नाव:";
            this.lblBankName.Visible = false;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPaymentType.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Card Payment",
            "Cheque",
            "Dimand Draft",
            "IMPS",
            "NEFT",
            "RTGS"});
            this.cmbPaymentType.Location = new System.Drawing.Point(120, 235);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(168, 28);
            this.cmbPaymentType.TabIndex = 6;
            this.cmbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentType_SelectedIndexChanged);
            // 
            // lblPaymenttype
            // 
            this.lblPaymenttype.AutoSize = true;
            this.lblPaymenttype.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblPaymenttype.Location = new System.Drawing.Point(5, 241);
            this.lblPaymenttype.Name = "lblPaymenttype";
            this.lblPaymenttype.Size = new System.Drawing.Size(43, 20);
            this.lblPaymenttype.TabIndex = 358;
            this.lblPaymenttype.Text = "प्रकार:";
            // 
            // cmbAccountname
            // 
            this.cmbAccountname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccountname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccountname.BackColor = System.Drawing.Color.White;
            this.cmbAccountname.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAccountname.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.cmbAccountname.ForeColor = System.Drawing.Color.Black;
            this.cmbAccountname.FormattingEnabled = true;
            this.cmbAccountname.Location = new System.Drawing.Point(120, 161);
            this.cmbAccountname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAccountname.Name = "cmbAccountname";
            this.cmbAccountname.Size = new System.Drawing.Size(249, 31);
            this.cmbAccountname.TabIndex = 3;
            this.cmbAccountname.SelectedIndexChanged += new System.EventHandler(this.cmbAccountname_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.label5.Location = new System.Drawing.Point(23, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 349;
            this.label5.Text = "तपशील :";
            // 
            // txtNaration
            // 
            this.txtNaration.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.txtNaration.Location = new System.Drawing.Point(120, 303);
            this.txtNaration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNaration.Multiline = true;
            this.txtNaration.Name = "txtNaration";
            this.txtNaration.Size = new System.Drawing.Size(273, 54);
            this.txtNaration.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.label4.Location = new System.Drawing.Point(23, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 347;
            this.label4.Text = "रक्कम:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.txtAmount.Location = new System.Drawing.Point(120, 198);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(151, 31);
            this.txtAmount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.label3.Location = new System.Drawing.Point(5, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 345;
            this.label3.Text = "खात्याचे नाव:";
            // 
            // dtpdate
            // 
            this.dtpdate.CustomFormat = "dd-MM-yyyy";
            this.dtpdate.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdate.Location = new System.Drawing.Point(375, 84);
            this.dtpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(212, 27);
            this.dtpdate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(286, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 343;
            this.label1.Text = "दिनांक :";
            // 
            // txtpayid
            // 
            this.txtpayid.BackColor = System.Drawing.Color.White;
            this.txtpayid.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtpayid.Location = new System.Drawing.Point(120, 91);
            this.txtpayid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpayid.Name = "txtpayid";
            this.txtpayid.ReadOnly = true;
            this.txtpayid.Size = new System.Drawing.Size(141, 30);
            this.txtpayid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 341;
            this.label2.Text = "क्रमांक:";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(137, 371);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(109, 34);
            this.btnnew.TabIndex = 12;
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
            this.btnSave.Location = new System.Drawing.Point(252, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 34);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "जतन (Alt+S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPaymentVoucher);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.groupBox1.Location = new System.Drawing.Point(593, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 428);
            this.groupBox1.TabIndex = 394;
            this.groupBox1.TabStop = false;
            // 
            // dgvPaymentVoucher
            // 
            this.dgvPaymentVoucher.AllowUserToAddRows = false;
            this.dgvPaymentVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentVoucher.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPaymentVoucher.Location = new System.Drawing.Point(3, 90);
            this.dgvPaymentVoucher.Name = "dgvPaymentVoucher";
            this.dgvPaymentVoucher.RowHeadersVisible = false;
            this.dgvPaymentVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentVoucher.Size = new System.Drawing.Size(588, 335);
            this.dgvPaymentVoucher.TabIndex = 1;
            this.dgvPaymentVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentVoucher_CellClick);
            this.dgvPaymentVoucher.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPaymentVoucher_CellMouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAccountNameSerach);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.txtVoucherId);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.groupBox2.Location = new System.Drawing.Point(3, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 67);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtAccountNameSerach
            // 
            this.txtAccountNameSerach.BackColor = System.Drawing.Color.White;
            this.txtAccountNameSerach.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNameSerach.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNameSerach.Location = new System.Drawing.Point(145, 18);
            this.txtAccountNameSerach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccountNameSerach.Name = "txtAccountNameSerach";
            this.txtAccountNameSerach.Size = new System.Drawing.Size(188, 29);
            this.txtAccountNameSerach.TabIndex = 0;
            this.txtAccountNameSerach.TextChanged += new System.EventHandler(this.txtAccountNameSerach_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.label7.Location = new System.Drawing.Point(353, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 347;
            this.label7.Text = "नं :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.label6.Location = new System.Drawing.Point(9, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 346;
            this.label6.Text = "खात्याचे नाव:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(459, 16);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "डिलीट";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtVoucherId
            // 
            this.txtVoucherId.BackColor = System.Drawing.Color.White;
            this.txtVoucherId.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtVoucherId.ForeColor = System.Drawing.Color.Black;
            this.txtVoucherId.Location = new System.Drawing.Point(392, 21);
            this.txtVoucherId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVoucherId.Name = "txtVoucherId";
            this.txtVoucherId.ReadOnly = true;
            this.txtVoucherId.Size = new System.Drawing.Size(61, 25);
            this.txtVoucherId.TabIndex = 159;
            // 
            // cmbAccountGroup
            // 
            this.cmbAccountGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccountGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccountGroup.BackColor = System.Drawing.Color.White;
            this.cmbAccountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAccountGroup.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.cmbAccountGroup.ForeColor = System.Drawing.Color.Black;
            this.cmbAccountGroup.FormattingEnabled = true;
            this.cmbAccountGroup.Location = new System.Drawing.Point(120, 127);
            this.cmbAccountGroup.Name = "cmbAccountGroup";
            this.cmbAccountGroup.Size = new System.Drawing.Size(249, 28);
            this.cmbAccountGroup.TabIndex = 2;
            this.cmbAccountGroup.Visible = false;
            this.cmbAccountGroup.SelectedIndexChanged += new System.EventHandler(this.cmbAccountGroup_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.metroLabel3.Location = new System.Drawing.Point(23, 129);
            this.metroLabel3.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 20);
            this.metroLabel3.TabIndex = 395;
            this.metroLabel3.Text = "खाते गट:";
            this.metroLabel3.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(422, 130);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 20);
            this.metroLabel1.TabIndex = 402;
            this.metroLabel1.Text = "मोबाईल नं:";
            this.metroLabel1.Visible = false;
            // 
            // txtmobile
            // 
            this.txtmobile.BackColor = System.Drawing.Color.White;
            this.txtmobile.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.txtmobile.ForeColor = System.Drawing.Color.Black;
            this.txtmobile.Location = new System.Drawing.Point(390, 157);
            this.txtmobile.MaxLength = 10;
            this.txtmobile.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(174, 31);
            this.txtmobile.TabIndex = 401;
            this.txtmobile.Visible = false;
            this.txtmobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmobile_KeyDown);
            // 
            // cmbBank
            // 
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBank.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold);
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(120, 269);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(213, 28);
            this.cmbBank.TabIndex = 8;
            this.cmbBank.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 30);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.deleteRowToolStripMenuItem.Text = "प्रिंट ";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // chkOpeningBalance
            // 
            this.chkOpeningBalance.AutoSize = true;
            this.chkOpeningBalance.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.chkOpeningBalance.Location = new System.Drawing.Point(442, 202);
            this.chkOpeningBalance.Name = "chkOpeningBalance";
            this.chkOpeningBalance.Size = new System.Drawing.Size(110, 24);
            this.chkOpeningBalance.TabIndex = 5;
            this.chkOpeningBalance.Text = "आरंभी शिल्लक";
            this.chkOpeningBalance.UseVisualStyleBackColor = true;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(27, 12);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(137, 36);
            this.lblHerader.TabIndex = 427;
            this.lblHerader.Text = "नावे पावती ";
            // 
            // frmVoucherPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 521);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.chkOpeningBalance);
            this.Controls.Add(this.cmbBank);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.cmbAccountGroup);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblVimalDueAmount);
            this.Controls.Add(this.lblRemAmount);
            this.Controls.Add(this.dtpchedate);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtchqDDNo);
            this.Controls.Add(this.lblChequeNo);
            this.Controls.Add(this.lblBankName);
            this.Controls.Add(this.cmbPaymentType);
            this.Controls.Add(this.lblPaymenttype);
            this.Controls.Add(this.cmbAccountname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNaration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpayid);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "frmVoucherPayment";
            this.Load += new System.EventHandler(this.frmVoucherPayment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVoucherPayment_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentVoucher)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVimalDueAmount;
        private System.Windows.Forms.Label lblRemAmount;
        private System.Windows.Forms.DateTimePicker dtpchedate;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtchqDDNo;
        private System.Windows.Forms.Label lblChequeNo;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label lblPaymenttype;
        private System.Windows.Forms.ComboBox cmbAccountname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNaration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpayid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPaymentVoucher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbAccountGroup;
        private System.Windows.Forms.Label metroLabel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtVoucherId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccountNameSerach;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkOpeningBalance;
        private System.Windows.Forms.Label lblHerader;
    }
}