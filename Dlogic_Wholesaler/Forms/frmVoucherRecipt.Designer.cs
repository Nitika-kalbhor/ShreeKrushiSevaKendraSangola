namespace Dlogic_Wholesaler.Forms
{
    partial class frmVoucherRecipt
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
            this.btnnew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDueAmount = new System.Windows.Forms.Label();
            this.lblRemAmt = new System.Windows.Forms.Label();
            this.dtpchedate = new System.Windows.Forms.DateTimePicker();
            this.label33 = new System.Windows.Forms.Label();
            this.txtchqDDNo = new System.Windows.Forms.TextBox();
            this.lblChequeNo = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPaymentReciept = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtVoucherId = new System.Windows.Forms.TextBox();
            this.cmbAccountGroup = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new System.Windows.Forms.Label();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkOpeningBalance = new System.Windows.Forms.CheckBox();
            this.dtpNextPaymentDetails = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentReciept)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(110, 438);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(135, 34);
            this.btnnew.TabIndex = 13;
            this.btnnew.Text = "नवीन(Alt+N)";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(257, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "जतन करा(Alt+S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDueAmount
            // 
            this.lblDueAmount.AutoSize = true;
            this.lblDueAmount.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold);
            this.lblDueAmount.Location = new System.Drawing.Point(389, 182);
            this.lblDueAmount.Name = "lblDueAmount";
            this.lblDueAmount.Size = new System.Drawing.Size(24, 25);
            this.lblDueAmount.TabIndex = 390;
            this.lblDueAmount.Text = "0";
            // 
            // lblRemAmt
            // 
            this.lblRemAmt.AutoSize = true;
            this.lblRemAmt.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lblRemAmt.Location = new System.Drawing.Point(267, 182);
            this.lblRemAmt.Name = "lblRemAmt";
            this.lblRemAmt.Size = new System.Drawing.Size(81, 21);
            this.lblRemAmt.TabIndex = 389;
            this.lblRemAmt.Text = "बाकी रक्कम :";
            // 
            // dtpchedate
            // 
            this.dtpchedate.CustomFormat = "dd-MM-yyyy";
            this.dtpchedate.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.dtpchedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpchedate.Location = new System.Drawing.Point(474, 250);
            this.dtpchedate.Name = "dtpchedate";
            this.dtpchedate.Size = new System.Drawing.Size(115, 27);
            this.dtpchedate.TabIndex = 9;
            this.dtpchedate.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label33.Location = new System.Drawing.Point(355, 251);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(79, 21);
            this.label33.TabIndex = 388;
            this.label33.Text = "चेक दिनांक:";
            this.label33.Visible = false;
            // 
            // txtchqDDNo
            // 
            this.txtchqDDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtchqDDNo.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.txtchqDDNo.Location = new System.Drawing.Point(476, 218);
            this.txtchqDDNo.Name = "txtchqDDNo";
            this.txtchqDDNo.Size = new System.Drawing.Size(113, 27);
            this.txtchqDDNo.TabIndex = 7;
            this.txtchqDDNo.Visible = false;
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lblChequeNo.Location = new System.Drawing.Point(355, 220);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(49, 21);
            this.lblChequeNo.TabIndex = 386;
            this.lblChequeNo.Text = "चेक नं:";
            this.lblChequeNo.Visible = false;
            // 
            // cmbBank
            // 
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.cmbBank.Location = new System.Drawing.Point(126, 248);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(230, 28);
            this.cmbBank.TabIndex = 8;
            this.cmbBank.Visible = false;
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.Location = new System.Drawing.Point(4, 254);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(72, 21);
            this.lblBankName.TabIndex = 385;
            this.lblBankName.Text = "बँकचे नाव:";
            this.lblBankName.Visible = false;
            this.lblBankName.Click += new System.EventHandler(this.lblBankName_Click);
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPaymentType.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold);
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Card Payment",
            "Cheque",
            "Dimand Draft",
            "IMPS",
            "NEFT",
            "RTGS"});
            this.cmbPaymentType.Location = new System.Drawing.Point(126, 214);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(193, 28);
            this.cmbPaymentType.TabIndex = 6;
            this.cmbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentType_SelectedIndexChanged);
            // 
            // lblPaymenttype
            // 
            this.lblPaymenttype.AutoSize = true;
            this.lblPaymenttype.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lblPaymenttype.Location = new System.Drawing.Point(4, 217);
            this.lblPaymenttype.Name = "lblPaymenttype";
            this.lblPaymenttype.Size = new System.Drawing.Size(51, 21);
            this.lblPaymenttype.TabIndex = 384;
            this.lblPaymenttype.Text = "प्रकार :";
            this.lblPaymenttype.Click += new System.EventHandler(this.lblPaymenttype_Click);
            // 
            // cmbAccountname
            // 
            this.cmbAccountname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccountname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccountname.BackColor = System.Drawing.Color.White;
            this.cmbAccountname.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAccountname.Font = new System.Drawing.Font("Arial Unicode MS", 13F, System.Drawing.FontStyle.Bold);
            this.cmbAccountname.ForeColor = System.Drawing.Color.Black;
            this.cmbAccountname.FormattingEnabled = true;
            this.cmbAccountname.Location = new System.Drawing.Point(126, 142);
            this.cmbAccountname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAccountname.Name = "cmbAccountname";
            this.cmbAccountname.Size = new System.Drawing.Size(260, 31);
            this.cmbAccountname.TabIndex = 3;
            this.cmbAccountname.SelectedIndexChanged += new System.EventHandler(this.cmbAccountname_SelectedIndexChanged);
            this.cmbAccountname.Click += new System.EventHandler(this.cmbAccountname_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label5.Location = new System.Drawing.Point(4, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 379;
            this.label5.Text = "तपशील  :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNaration
            // 
            this.txtNaration.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.txtNaration.Location = new System.Drawing.Point(126, 282);
            this.txtNaration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNaration.Multiline = true;
            this.txtNaration.Name = "txtNaration";
            this.txtNaration.Size = new System.Drawing.Size(297, 54);
            this.txtNaration.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label4.Location = new System.Drawing.Point(4, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 377;
            this.label4.Text = "रक्कम  :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.txtAmount.Location = new System.Drawing.Point(126, 179);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(139, 29);
            this.txtAmount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label3.Location = new System.Drawing.Point(4, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 375;
            this.label3.Text = "खात्याचे नाव:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpdate
            // 
            this.dtpdate.CustomFormat = "dd-MM-yyyy";
            this.dtpdate.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdate.Location = new System.Drawing.Point(354, 68);
            this.dtpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(212, 29);
            this.dtpdate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label1.Location = new System.Drawing.Point(259, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 373;
            this.label1.Text = "दिनांक  :";
            // 
            // txtpayid
            // 
            this.txtpayid.BackColor = System.Drawing.Color.White;
            this.txtpayid.Font = new System.Drawing.Font("Arial Unicode MS", 14F);
            this.txtpayid.Location = new System.Drawing.Point(126, 64);
            this.txtpayid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpayid.Name = "txtpayid";
            this.txtpayid.ReadOnly = true;
            this.txtpayid.Size = new System.Drawing.Size(122, 33);
            this.txtpayid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label2.Location = new System.Drawing.Point(4, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 371;
            this.label2.Text = "क्रमांक :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPaymentReciept);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.groupBox1.Location = new System.Drawing.Point(594, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 428);
            this.groupBox1.TabIndex = 393;
            this.groupBox1.TabStop = false;
            // 
            // dgvPaymentReciept
            // 
            this.dgvPaymentReciept.AllowUserToAddRows = false;
            this.dgvPaymentReciept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentReciept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentReciept.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPaymentReciept.Location = new System.Drawing.Point(3, 92);
            this.dgvPaymentReciept.Name = "dgvPaymentReciept";
            this.dgvPaymentReciept.RowHeadersVisible = false;
            this.dgvPaymentReciept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentReciept.Size = new System.Drawing.Size(664, 333);
            this.dgvPaymentReciept.TabIndex = 1;
            this.dgvPaymentReciept.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentReciept_CellClick);
            this.dgvPaymentReciept.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPaymentReciept_CellMouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAccountName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.txtVoucherId);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.groupBox2.Location = new System.Drawing.Point(3, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 67);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtAccountName
            // 
            this.txtAccountName.BackColor = System.Drawing.Color.White;
            this.txtAccountName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.ForeColor = System.Drawing.Color.Black;
            this.txtAccountName.Location = new System.Drawing.Point(146, 20);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(189, 29);
            this.txtAccountName.TabIndex = 0;
            this.txtAccountName.TextChanged += new System.EventHandler(this.txtAccountName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label7.Location = new System.Drawing.Point(376, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 401;
            this.label7.Text = "क्रमांक :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 400;
            this.label6.Text = "खात्याचे नाव:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(509, 18);
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
            this.txtVoucherId.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.txtVoucherId.ForeColor = System.Drawing.Color.Black;
            this.txtVoucherId.Location = new System.Drawing.Point(442, 23);
            this.txtVoucherId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVoucherId.Name = "txtVoucherId";
            this.txtVoucherId.ReadOnly = true;
            this.txtVoucherId.Size = new System.Drawing.Size(61, 27);
            this.txtVoucherId.TabIndex = 398;
            // 
            // cmbAccountGroup
            // 
            this.cmbAccountGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccountGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccountGroup.BackColor = System.Drawing.Color.White;
            this.cmbAccountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAccountGroup.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountGroup.ForeColor = System.Drawing.Color.Black;
            this.cmbAccountGroup.FormattingEnabled = true;
            this.cmbAccountGroup.Location = new System.Drawing.Point(126, 103);
            this.cmbAccountGroup.Name = "cmbAccountGroup";
            this.cmbAccountGroup.Size = new System.Drawing.Size(260, 33);
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
            this.metroLabel3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.metroLabel3.Location = new System.Drawing.Point(4, 102);
            this.metroLabel3.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 21);
            this.metroLabel3.TabIndex = 397;
            this.metroLabel3.Text = "खाते गट :";
            this.metroLabel3.Visible = false;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // txtmobile
            // 
            this.txtmobile.BackColor = System.Drawing.Color.White;
            this.txtmobile.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtmobile.ForeColor = System.Drawing.Color.Black;
            this.txtmobile.Location = new System.Drawing.Point(416, 129);
            this.txtmobile.MaxLength = 10;
            this.txtmobile.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(156, 33);
            this.txtmobile.TabIndex = 399;
            this.txtmobile.Visible = false;
            this.txtmobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmobile_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.metroLabel1.Location = new System.Drawing.Point(442, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 21);
            this.metroLabel1.TabIndex = 400;
            this.metroLabel1.Text = "मोबाईल नं";
            this.metroLabel1.Visible = false;
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
            this.chkOpeningBalance.Location = new System.Drawing.Point(446, 182);
            this.chkOpeningBalance.Name = "chkOpeningBalance";
            this.chkOpeningBalance.Size = new System.Drawing.Size(110, 24);
            this.chkOpeningBalance.TabIndex = 5;
            this.chkOpeningBalance.Text = "आरंभी शिल्लक";
            this.chkOpeningBalance.UseVisualStyleBackColor = true;
            // 
            // dtpNextPaymentDetails
            // 
            this.dtpNextPaymentDetails.CustomFormat = "dd-MM-yyyy";
            this.dtpNextPaymentDetails.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.dtpNextPaymentDetails.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNextPaymentDetails.Location = new System.Drawing.Point(152, 343);
            this.dtpNextPaymentDetails.Name = "dtpNextPaymentDetails";
            this.dtpNextPaymentDetails.Size = new System.Drawing.Size(172, 27);
            this.dtpNextPaymentDetails.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label16.Location = new System.Drawing.Point(4, 347);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 21);
            this.label16.TabIndex = 407;
            this.label16.Text = "पुढील  जमा दिनांक:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(54, 8);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(133, 36);
            this.lblHerader.TabIndex = 428;
            this.lblHerader.Text = "जमा पावती";
            // 
            // frmVoucherRecipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 521);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.dtpNextPaymentDetails);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chkOpeningBalance);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.cmbAccountGroup);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDueAmount);
            this.Controls.Add(this.lblRemAmt);
            this.Controls.Add(this.dtpchedate);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtchqDDNo);
            this.Controls.Add(this.lblChequeNo);
            this.Controls.Add(this.cmbBank);
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
            this.Name = "frmVoucherRecipt";
            this.Load += new System.EventHandler(this.frmVoucherRecipt_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVoucherRecipt_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentReciept)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDueAmount;
        private System.Windows.Forms.Label lblRemAmt;
        private System.Windows.Forms.DateTimePicker dtpchedate;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtchqDDNo;
        private System.Windows.Forms.Label lblChequeNo;
        private System.Windows.Forms.ComboBox cmbBank;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPaymentReciept;
        private System.Windows.Forms.ComboBox cmbAccountGroup;
        private System.Windows.Forms.Label metroLabel3;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtVoucherId;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkOpeningBalance;
        private System.Windows.Forms.DateTimePicker dtpNextPaymentDetails;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblHerader;
    }
}