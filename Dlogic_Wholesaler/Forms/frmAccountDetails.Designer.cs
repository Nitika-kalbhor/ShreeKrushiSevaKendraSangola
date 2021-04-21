namespace Dlogic_Wholesaler.Forms
{
    partial class frmAccountDetails
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
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.metroLabel3 = new System.Windows.Forms.Label();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.lblaccountNo = new System.Windows.Forms.Label();
            this.metroLabel4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroLabel5 = new System.Windows.Forms.Label();
            this.cmbaccoutType = new System.Windows.Forms.ComboBox();
            this.cmbAccountGroup = new System.Windows.Forms.ComboBox();
            this.cmbAccountName = new System.Windows.Forms.ComboBox();
            this.cmbIsCustomerDealer = new System.Windows.Forms.ComboBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbCreditDebit = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddAccountGroup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGSTNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAccountSupGroup = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvAccountDetailsGroup = new System.Windows.Forms.DataGridView();
            this.accountId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAccountNameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDetailsGroup)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 13);
            this.panel1.TabIndex = 101;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.metroLabel2.Location = new System.Drawing.Point(34, 200);
            this.metroLabel2.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 21);
            this.metroLabel2.TabIndex = 151;
            this.metroLabel2.Text = "खात्याचे  नाव:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.metroLabel3.Location = new System.Drawing.Point(34, 116);
            this.metroLabel3.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 21);
            this.metroLabel3.TabIndex = 150;
            this.metroLabel3.Text = "खाते गट:";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.metroLabel1.Location = new System.Drawing.Point(34, 77);
            this.metroLabel1.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 21);
            this.metroLabel1.TabIndex = 149;
            this.metroLabel1.Text = "खाते प्रकार:";
            // 
            // lblaccountNo
            // 
            this.lblaccountNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblaccountNo.AutoSize = true;
            this.lblaccountNo.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lblaccountNo.Location = new System.Drawing.Point(34, 369);
            this.lblaccountNo.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblaccountNo.Name = "lblaccountNo";
            this.lblaccountNo.Size = new System.Drawing.Size(60, 21);
            this.lblaccountNo.TabIndex = 157;
            this.lblaccountNo.Text = "खाते नं :";
            this.lblaccountNo.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.metroLabel4.Location = new System.Drawing.Point(34, 328);
            this.metroLabel4.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 21);
            this.metroLabel4.TabIndex = 156;
            this.metroLabel4.Text = "कर्मचारी/बँक:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label4.Location = new System.Drawing.Point(34, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 342;
            this.label4.Text = "आरंभी शिल्लक:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Font = new System.Drawing.Font("Arial Unicode MS", 14F);
            this.metroLabel5.Location = new System.Drawing.Point(517, 406);
            this.metroLabel5.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 25);
            this.metroLabel5.TabIndex = 341;
            this.metroLabel5.Text = "नावे/जमा";
            // 
            // cmbaccoutType
            // 
            this.cmbaccoutType.BackColor = System.Drawing.Color.White;
            this.cmbaccoutType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbaccoutType.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbaccoutType.ForeColor = System.Drawing.Color.Black;
            this.cmbaccoutType.FormattingEnabled = true;
            this.cmbaccoutType.Location = new System.Drawing.Point(176, 71);
            this.cmbaccoutType.Name = "cmbaccoutType";
            this.cmbaccoutType.Size = new System.Drawing.Size(230, 33);
            this.cmbaccoutType.TabIndex = 0;
            this.cmbaccoutType.SelectedIndexChanged += new System.EventHandler(this.cmbaccoutType_SelectedIndexChanged);
            // 
            // cmbAccountGroup
            // 
            this.cmbAccountGroup.BackColor = System.Drawing.Color.White;
            this.cmbAccountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAccountGroup.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountGroup.ForeColor = System.Drawing.Color.Black;
            this.cmbAccountGroup.FormattingEnabled = true;
            this.cmbAccountGroup.Location = new System.Drawing.Point(176, 111);
            this.cmbAccountGroup.Name = "cmbAccountGroup";
            this.cmbAccountGroup.Size = new System.Drawing.Size(230, 33);
            this.cmbAccountGroup.TabIndex = 1;
            this.cmbAccountGroup.SelectedIndexChanged += new System.EventHandler(this.cmbAccountGroup_SelectedIndexChanged);
            // 
            // cmbAccountName
            // 
            this.cmbAccountName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccountName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccountName.BackColor = System.Drawing.Color.White;
            this.cmbAccountName.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountName.ForeColor = System.Drawing.Color.Black;
            this.cmbAccountName.FormattingEnabled = true;
            this.cmbAccountName.Location = new System.Drawing.Point(176, 194);
            this.cmbAccountName.Name = "cmbAccountName";
            this.cmbAccountName.Size = new System.Drawing.Size(325, 33);
            this.cmbAccountName.TabIndex = 3;
            // 
            // cmbIsCustomerDealer
            // 
            this.cmbIsCustomerDealer.BackColor = System.Drawing.Color.White;
            this.cmbIsCustomerDealer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsCustomerDealer.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIsCustomerDealer.ForeColor = System.Drawing.Color.Black;
            this.cmbIsCustomerDealer.FormattingEnabled = true;
            this.cmbIsCustomerDealer.Items.AddRange(new object[] {
            "--निवडा--",
            "ग्रहाक",
            "व्यापारी",
            "कर्मचारी",
            "बँक"});
            this.cmbIsCustomerDealer.Location = new System.Drawing.Point(176, 323);
            this.cmbIsCustomerDealer.Name = "cmbIsCustomerDealer";
            this.cmbIsCustomerDealer.Size = new System.Drawing.Size(230, 33);
            this.cmbIsCustomerDealer.TabIndex = 6;
            this.cmbIsCustomerDealer.SelectedIndexChanged += new System.EventHandler(this.cmbIsCustomerDealer_SelectedIndexChanged);
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BackColor = System.Drawing.Color.White;
            this.txtAccountNo.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNo.Location = new System.Drawing.Point(176, 363);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(230, 33);
            this.txtAccountNo.TabIndex = 7;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.Location = new System.Drawing.Point(176, 403);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(230, 33);
            this.txtAmount.TabIndex = 8;
            // 
            // cmbCreditDebit
            // 
            this.cmbCreditDebit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreditDebit.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreditDebit.FormattingEnabled = true;
            this.cmbCreditDebit.Items.AddRange(new object[] {
            "जमा रक्कम",
            "नावे रक्कम"});
            this.cmbCreditDebit.Location = new System.Drawing.Point(412, 403);
            this.cmbCreditDebit.Name = "cmbCreditDebit";
            this.cmbCreditDebit.Size = new System.Drawing.Size(99, 33);
            this.cmbCreditDebit.TabIndex = 9;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(33, 445);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 39);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "नवीन (Alt+N)";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(315, 445);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 39);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "अपडेट";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(162, 445);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 39);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "जतन करा(Alt+S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(412, 445);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 39);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "डिलीट";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            // 
            // btnAddAccountGroup
            // 
            this.btnAddAccountGroup.BackColor = System.Drawing.Color.Green;
            this.btnAddAccountGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnAddAccountGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccountGroup.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccountGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddAccountGroup.Location = new System.Drawing.Point(412, 113);
            this.btnAddAccountGroup.Name = "btnAddAccountGroup";
            this.btnAddAccountGroup.Size = new System.Drawing.Size(36, 31);
            this.btnAddAccountGroup.TabIndex = 354;
            this.btnAddAccountGroup.Text = "N";
            this.btnAddAccountGroup.UseVisualStyleBackColor = false;
            this.btnAddAccountGroup.Click += new System.EventHandler(this.btnAddAccountGroup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMobileNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGSTNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbAccountSupGroup);
            this.groupBox1.Controls.Add(this.cmbAccountName);
            this.groupBox1.Controls.Add(this.btnAddAccountGroup);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblaccountNo);
            this.groupBox1.Controls.Add(this.cmbCreditDebit);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Controls.Add(this.cmbaccoutType);
            this.groupBox1.Controls.Add(this.cmbIsCustomerDealer);
            this.groupBox1.Controls.Add(this.cmbAccountGroup);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(20, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 532);
            this.groupBox1.TabIndex = 355;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(412, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 31);
            this.button1.TabIndex = 360;
            this.button1.Text = "N";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label5.Location = new System.Drawing.Point(34, 239);
            this.label5.MinimumSize = new System.Drawing.Size(60, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 359;
            this.label5.Text = "मोबाईल नं : ";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BackColor = System.Drawing.Color.White;
            this.txtMobileNo.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.ForeColor = System.Drawing.Color.Black;
            this.txtMobileNo.Location = new System.Drawing.Point(176, 233);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(230, 33);
            this.txtMobileNo.TabIndex = 4;
            this.txtMobileNo.Text = " ";
            this.txtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNo_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label3.Location = new System.Drawing.Point(34, 280);
            this.label3.MinimumSize = new System.Drawing.Size(60, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 357;
            this.label3.Text = " GST No :";
            // 
            // txtGSTNo
            // 
            this.txtGSTNo.BackColor = System.Drawing.Color.White;
            this.txtGSTNo.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGSTNo.ForeColor = System.Drawing.Color.Black;
            this.txtGSTNo.Location = new System.Drawing.Point(176, 274);
            this.txtGSTNo.Name = "txtGSTNo";
            this.txtGSTNo.Size = new System.Drawing.Size(230, 33);
            this.txtGSTNo.TabIndex = 5;
            this.txtGSTNo.Text = " ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label2.Location = new System.Drawing.Point(11, 156);
            this.label2.MinimumSize = new System.Drawing.Size(60, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 355;
            this.label2.Text = "खाते गट उपप्रकार:";
            // 
            // cmbAccountSupGroup
            // 
            this.cmbAccountSupGroup.BackColor = System.Drawing.Color.White;
            this.cmbAccountSupGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountSupGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAccountSupGroup.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountSupGroup.ForeColor = System.Drawing.Color.Black;
            this.cmbAccountSupGroup.FormattingEnabled = true;
            this.cmbAccountSupGroup.Location = new System.Drawing.Point(176, 150);
            this.cmbAccountSupGroup.Name = "cmbAccountSupGroup";
            this.cmbAccountSupGroup.Size = new System.Drawing.Size(230, 33);
            this.cmbAccountSupGroup.TabIndex = 2;
            this.cmbAccountSupGroup.SelectedIndexChanged += new System.EventHandler(this.cmbAccountSupGroup_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(618, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 532);
            this.groupBox2.TabIndex = 356;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvAccountDetailsGroup);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(665, 404);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " ";
            // 
            // dgvAccountDetailsGroup
            // 
            this.dgvAccountDetailsGroup.AllowUserToAddRows = false;
            this.dgvAccountDetailsGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountDetailsGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountId1,
            this.accountName,
            this.MobileNo,
            this.accountType,
            this.accountGroup,
            this.isBank});
            this.dgvAccountDetailsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccountDetailsGroup.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccountDetailsGroup.Location = new System.Drawing.Point(3, 21);
            this.dgvAccountDetailsGroup.Name = "dgvAccountDetailsGroup";
            this.dgvAccountDetailsGroup.RowHeadersVisible = false;
            this.dgvAccountDetailsGroup.Size = new System.Drawing.Size(659, 380);
            this.dgvAccountDetailsGroup.TabIndex = 0;
            // 
            // accountId1
            // 
            this.accountId1.DataPropertyName = "accountId";
            this.accountId1.HeaderText = "accountId";
            this.accountId1.Name = "accountId1";
            this.accountId1.Visible = false;
            // 
            // accountName
            // 
            this.accountName.DataPropertyName = "accountName";
            this.accountName.HeaderText = "खातेदाराचे नाव";
            this.accountName.Name = "accountName";
            this.accountName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.accountName.Width = 165;
            // 
            // MobileNo
            // 
            this.MobileNo.DataPropertyName = "MobileNo";
            this.MobileNo.HeaderText = "मोबाईल नं";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // accountType
            // 
            this.accountType.DataPropertyName = "accountType";
            this.accountType.HeaderText = "खाते प्रकार";
            this.accountType.Name = "accountType";
            this.accountType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.accountType.Width = 164;
            // 
            // accountGroup
            // 
            this.accountGroup.DataPropertyName = "accountGroup";
            this.accountGroup.HeaderText = "खाते गट";
            this.accountGroup.Name = "accountGroup";
            this.accountGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.accountGroup.Width = 161;
            // 
            // isBank
            // 
            this.isBank.DataPropertyName = "isBank";
            this.isBank.HeaderText = "कर्मचारी/बँक";
            this.isBank.Name = "isBank";
            this.isBank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.isBank.Width = 166;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAccountNameSearch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txtAccountNameSearch
            // 
            this.txtAccountNameSearch.BackColor = System.Drawing.Color.White;
            this.txtAccountNameSearch.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNameSearch.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNameSearch.Location = new System.Drawing.Point(174, 40);
            this.txtAccountNameSearch.Name = "txtAccountNameSearch";
            this.txtAccountNameSearch.Size = new System.Drawing.Size(230, 33);
            this.txtAccountNameSearch.TabIndex = 348;
            this.txtAccountNameSearch.TextChanged += new System.EventHandler(this.txtAccountNameSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.MinimumSize = new System.Drawing.Size(60, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 152;
            this.label1.Text = "खात्याचे  नाव:";
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(14, 12);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(135, 33);
            this.lblHerader.TabIndex = 357;
            this.lblHerader.Text = " खाते माहिती";
            // 
            // frmAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 637);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F);
            this.KeyPreview = true;
            this.Name = "frmAccountDetails";
            this.Padding = new System.Windows.Forms.Padding(20, 69, 20, 23);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAccountDetails_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccountDetails_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDetailsGroup)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.Label metroLabel3;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.Label lblaccountNo;
        private System.Windows.Forms.Label metroLabel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label metroLabel5;
        private System.Windows.Forms.ComboBox cmbaccoutType;
        private System.Windows.Forms.ComboBox cmbAccountGroup;
        private System.Windows.Forms.ComboBox cmbAccountName;
        private System.Windows.Forms.ComboBox cmbIsCustomerDealer;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbCreditDebit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddAccountGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAccountDetailsGroup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAccountNameSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAccountSupGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGSTNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn isBank;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHerader;
    }
}