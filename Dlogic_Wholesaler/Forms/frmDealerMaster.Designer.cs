namespace Dlogic_Wholesaler.Forms
{
    partial class frmDealerMaster
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
            this.btnnew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dateBill = new System.Windows.Forms.DateTimePicker();
            this.cmbCreditDebit = new System.Windows.Forms.ComboBox();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.dgvCompany = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSeachName = new System.Windows.Forms.TextBox();
            this.txtSearchMob = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtDealerFirmAddress = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOtherIformation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtdealerName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btneExcelReport = new System.Windows.Forms.Button();
            this.metroLabel13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCustomer = new System.Windows.Forms.CheckBox();
            this.txtGSTNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtDealerAddress = new System.Windows.Forms.TextBox();
            this.lblNaration = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.txtOfficeNo = new System.Windows.Forms.TextBox();
            this.lblOpening = new System.Windows.Forms.Label();
            this.metroLabel10 = new System.Windows.Forms.Label();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.metroLabel7 = new System.Windows.Forms.Label();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.metroLabel4 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.txtDealerFirmName = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblHerader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(6, 474);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(114, 34);
            this.btnnew.TabIndex = 115;
            this.btnnew.Text = "नवीन (Alt+N)";
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
            this.btnSave.Location = new System.Drawing.Point(126, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "जतन करा(Alt+S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(363, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 34);
            this.btnDelete.TabIndex = 113;
            this.btnDelete.Text = "डिलीट";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dateBill
            // 
            this.dateBill.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBill.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBill.Location = new System.Drawing.Point(164, 403);
            this.dateBill.Name = "dateBill";
            this.dateBill.Size = new System.Drawing.Size(182, 27);
            this.dateBill.TabIndex = 11;
            // 
            // cmbCreditDebit
            // 
            this.cmbCreditDebit.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCreditDebit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreditDebit.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCreditDebit.FormattingEnabled = true;
            this.cmbCreditDebit.Items.AddRange(new object[] {
            "नावे रक्कम",
            "जमा रक्कम"});
            this.cmbCreditDebit.Location = new System.Drawing.Point(287, 371);
            this.cmbCreditDebit.Name = "cmbCreditDebit";
            this.cmbCreditDebit.Size = new System.Drawing.Size(127, 29);
            this.cmbCreditDebit.TabIndex = 10;
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.BackColor = System.Drawing.Color.White;
            this.txtOpeningBalance.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpeningBalance.ForeColor = System.Drawing.Color.Black;
            this.txtOpeningBalance.Location = new System.Drawing.Point(164, 371);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(118, 29);
            this.txtOpeningBalance.TabIndex = 9;
            this.txtOpeningBalance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOpeningBalance_KeyDown);
            this.txtOpeningBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpeningBalance_KeyPress);
            // 
            // dgvCompany
            // 
            this.dgvCompany.AllowUserToAddRows = false;
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompany.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompany.Location = new System.Drawing.Point(3, 20);
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.RowHeadersVisible = false;
            this.dgvCompany.Size = new System.Drawing.Size(646, 420);
            this.dgvCompany.TabIndex = 2;
            this.dgvCompany.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompany_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(261, 474);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 34);
            this.btnUpdate.TabIndex = 112;
            this.btnUpdate.Text = "अपडेट";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSeachName
            // 
            this.txtSeachName.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachName.Location = new System.Drawing.Point(6, 21);
            this.txtSeachName.Name = "txtSeachName";
            this.txtSeachName.Size = new System.Drawing.Size(189, 27);
            this.txtSeachName.TabIndex = 15;
            this.txtSeachName.TextChanged += new System.EventHandler(this.txtSeachName_TextChanged);
            // 
            // txtSearchMob
            // 
            this.txtSearchMob.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMob.Location = new System.Drawing.Point(201, 23);
            this.txtSearchMob.MaxLength = 10;
            this.txtSearchMob.Name = "txtSearchMob";
            this.txtSearchMob.Size = new System.Drawing.Size(217, 27);
            this.txtSearchMob.TabIndex = 16;
            this.txtSearchMob.TextChanged += new System.EventHandler(this.txtSearchMob_TextChanged);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(164, 188);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(269, 27);
            this.dtpDOB.TabIndex = 4;
            // 
            // txtDealerFirmAddress
            // 
            this.txtDealerFirmAddress.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerFirmAddress.Location = new System.Drawing.Point(164, 84);
            this.txtDealerFirmAddress.Multiline = true;
            this.txtDealerFirmAddress.Name = "txtDealerFirmAddress";
            this.txtDealerFirmAddress.Size = new System.Drawing.Size(269, 39);
            this.txtDealerFirmAddress.TabIndex = 1;
            this.txtDealerFirmAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDealerFirmAddress_KeyDown);
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.SystemColors.Window;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "--Select--",
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(164, 248);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(269, 28);
            this.cmbGender.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(266, -3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 117;
            this.label10.Text = "मोबाईल नं";
            // 
            // txtOtherIformation
            // 
            this.txtOtherIformation.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherIformation.ForeColor = System.Drawing.Color.Black;
            this.txtOtherIformation.Location = new System.Drawing.Point(164, 433);
            this.txtOtherIformation.Multiline = true;
            this.txtOtherIformation.Name = "txtOtherIformation";
            this.txtOtherIformation.Size = new System.Drawing.Size(250, 34);
            this.txtOtherIformation.TabIndex = 12;
            this.txtOtherIformation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOtherIformation_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.label9.Location = new System.Drawing.Point(136, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 26);
            this.label9.TabIndex = 92;
            this.label9.Text = " व्यापारीची माहिती ";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BackColor = System.Drawing.Color.White;
            this.txtMobileNo.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.ForeColor = System.Drawing.Color.Black;
            this.txtMobileNo.Location = new System.Drawing.Point(164, 311);
            this.txtMobileNo.MaxLength = 10;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(269, 27);
            this.txtMobileNo.TabIndex = 7;
            this.txtMobileNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobileNo_KeyDown);
            this.txtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNo_KeyPress);
            // 
            // txtdealerName
            // 
            this.txtdealerName.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdealerName.Location = new System.Drawing.Point(164, 156);
            this.txtdealerName.Name = "txtdealerName";
            this.txtdealerName.Size = new System.Drawing.Size(269, 29);
            this.txtdealerName.TabIndex = 3;
            this.txtdealerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdealerName_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCompany);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Arial Unicode MS", 9.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(652, 443);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btneExcelReport);
            this.groupBox3.Controls.Add(this.metroLabel13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtSeachName);
            this.groupBox3.Controls.Add(this.txtSearchMob);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Arial Unicode MS", 9.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(652, 62);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btneExcelReport
            // 
            this.btneExcelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btneExcelReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btneExcelReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneExcelReport.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold);
            this.btneExcelReport.ForeColor = System.Drawing.Color.White;
            this.btneExcelReport.Location = new System.Drawing.Point(440, 16);
            this.btneExcelReport.Name = "btneExcelReport";
            this.btneExcelReport.Size = new System.Drawing.Size(148, 35);
            this.btneExcelReport.TabIndex = 125;
            this.btneExcelReport.Text = "Excel रिपोर्ट ";
            this.btneExcelReport.UseVisualStyleBackColor = false;
            this.btneExcelReport.Click += new System.EventHandler(this.btneExcelReport_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(41, 0);
            this.metroLabel13.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(102, 18);
            this.metroLabel13.TabIndex = 124;
            this.metroLabel13.Text = "व्यापारी फर्म नांव : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(522, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 524);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCustomer);
            this.groupBox1.Controls.Add(this.txtGSTNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.txtDealerAddress);
            this.groupBox1.Controls.Add(this.lblNaration);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.txtEmailId);
            this.groupBox1.Controls.Add(this.txtOfficeNo);
            this.groupBox1.Controls.Add(this.lblOpening);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.lblEmailId);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.lblMobileNo);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtDealerFirmName);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.dateBill);
            this.groupBox1.Controls.Add(this.cmbCreditDebit);
            this.groupBox1.Controls.Add(this.txtOpeningBalance);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.txtDealerFirmAddress);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.txtOtherIformation);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMobileNo);
            this.groupBox1.Controls.Add(this.txtdealerName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 524);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // chkCustomer
            // 
            this.chkCustomer.AutoSize = true;
            this.chkCustomer.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.chkCustomer.Location = new System.Drawing.Point(363, 128);
            this.chkCustomer.Name = "chkCustomer";
            this.chkCustomer.Size = new System.Drawing.Size(60, 24);
            this.chkCustomer.TabIndex = 406;
            this.chkCustomer.Text = "ग्राहक";
            this.chkCustomer.UseVisualStyleBackColor = true;
            // 
            // txtGSTNo
            // 
            this.txtGSTNo.BackColor = System.Drawing.Color.White;
            this.txtGSTNo.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGSTNo.ForeColor = System.Drawing.Color.Black;
            this.txtGSTNo.Location = new System.Drawing.Point(164, 218);
            this.txtGSTNo.MaxLength = 0;
            this.txtGSTNo.Name = "txtGSTNo";
            this.txtGSTNo.Size = new System.Drawing.Size(269, 27);
            this.txtGSTNo.TabIndex = 136;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.label1.Location = new System.Drawing.Point(31, 221);
            this.label1.MinimumSize = new System.Drawing.Size(60, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 137;
            this.label1.Text = "GST No. :";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblAddress.Location = new System.Drawing.Point(31, 282);
            this.lblAddress.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 20);
            this.lblAddress.TabIndex = 135;
            this.lblAddress.Text = "पत्ता :";
            // 
            // txtDealerAddress
            // 
            this.txtDealerAddress.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerAddress.Location = new System.Drawing.Point(164, 279);
            this.txtDealerAddress.Name = "txtDealerAddress";
            this.txtDealerAddress.Size = new System.Drawing.Size(269, 29);
            this.txtDealerAddress.TabIndex = 6;
            this.txtDealerAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDealerAddress_KeyDown);
            // 
            // lblNaration
            // 
            this.lblNaration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNaration.AutoSize = true;
            this.lblNaration.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaration.Location = new System.Drawing.Point(31, 436);
            this.lblNaration.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblNaration.Name = "lblNaration";
            this.lblNaration.Size = new System.Drawing.Size(60, 20);
            this.lblNaration.TabIndex = 133;
            this.lblNaration.Text = "तपशील :";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblDate.Location = new System.Drawing.Point(31, 404);
            this.lblDate.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 20);
            this.lblDate.TabIndex = 132;
            this.lblDate.Text = "दिनांक :";
            // 
            // txtEmailId
            // 
            this.txtEmailId.BackColor = System.Drawing.Color.White;
            this.txtEmailId.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailId.ForeColor = System.Drawing.Color.Black;
            this.txtEmailId.Location = new System.Drawing.Point(164, 341);
            this.txtEmailId.MaxLength = 100000;
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(269, 27);
            this.txtEmailId.TabIndex = 8;
            this.txtEmailId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmailId_KeyDown);
            // 
            // txtOfficeNo
            // 
            this.txtOfficeNo.BackColor = System.Drawing.Color.White;
            this.txtOfficeNo.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfficeNo.ForeColor = System.Drawing.Color.Black;
            this.txtOfficeNo.Location = new System.Drawing.Point(164, 126);
            this.txtOfficeNo.MaxLength = 10;
            this.txtOfficeNo.Name = "txtOfficeNo";
            this.txtOfficeNo.Size = new System.Drawing.Size(151, 27);
            this.txtOfficeNo.TabIndex = 2;
            this.txtOfficeNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOfficeNo_KeyDown);
            // 
            // lblOpening
            // 
            this.lblOpening.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOpening.AutoSize = true;
            this.lblOpening.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblOpening.Location = new System.Drawing.Point(31, 372);
            this.lblOpening.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblOpening.Name = "lblOpening";
            this.lblOpening.Size = new System.Drawing.Size(99, 20);
            this.lblOpening.TabIndex = 129;
            this.lblOpening.Text = "आरभी शिल्लक :";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.metroLabel10.Location = new System.Drawing.Point(11, 92);
            this.metroLabel10.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(112, 20);
            this.metroLabel10.TabIndex = 128;
            this.metroLabel10.Text = "व्यापारी फर्म पत्ता :";
            // 
            // lblEmailId
            // 
            this.lblEmailId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblEmailId.Location = new System.Drawing.Point(31, 344);
            this.lblEmailId.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(82, 20);
            this.lblEmailId.TabIndex = 127;
            this.lblEmailId.Text = "ईमेलआयडी :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.metroLabel7.Location = new System.Drawing.Point(31, 126);
            this.metroLabel7.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(60, 20);
            this.metroLabel7.TabIndex = 126;
            this.metroLabel7.Text = "फोन नं :";
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblMobileNo.Location = new System.Drawing.Point(31, 314);
            this.lblMobileNo.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(77, 20);
            this.lblMobileNo.TabIndex = 125;
            this.lblMobileNo.Text = "मोबाईल नं :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.metroLabel4.Location = new System.Drawing.Point(21, 57);
            this.metroLabel4.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 20);
            this.metroLabel4.TabIndex = 123;
            this.metroLabel4.Text = "व्यापारी फर्म नांव :";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblGender.Location = new System.Drawing.Point(31, 250);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(41, 20);
            this.lblGender.TabIndex = 122;
            this.lblGender.Text = "लिंग :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.metroLabel1.Location = new System.Drawing.Point(31, 189);
            this.metroLabel1.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 20);
            this.metroLabel1.TabIndex = 121;
            this.metroLabel1.Text = "DOB :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.metroLabel2.Location = new System.Drawing.Point(26, 157);
            this.metroLabel2.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 20);
            this.metroLabel2.TabIndex = 120;
            this.metroLabel2.Text = "व्यापारीचे नांव :";
            // 
            // txtDealerFirmName
            // 
            this.txtDealerFirmName.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerFirmName.Location = new System.Drawing.Point(164, 52);
            this.txtDealerFirmName.Name = "txtDealerFirmName";
            this.txtDealerFirmName.Size = new System.Drawing.Size(269, 29);
            this.txtDealerFirmName.TabIndex = 0;
            this.txtDealerFirmName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDealerFirmName_KeyDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.pictureBox3.Location = new System.Drawing.Point(16, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(473, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 102;
            this.pictureBox3.TabStop = false;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(20, 6);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(199, 33);
            this.lblHerader.TabIndex = 243;
            this.lblHerader.Text = " व्यापारीची माहिती ";
            // 
            // frmDealerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 604);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmDealerMaster";
            this.Load += new System.EventHandler(this.frmDealerMaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDealerMaster_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dateBill;
        private System.Windows.Forms.ComboBox cmbCreditDebit;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.DataGridView dgvCompany;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSeachName;
        private System.Windows.Forms.TextBox txtSearchMob;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtDealerFirmAddress;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOtherIformation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtdealerName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDealerFirmName;
        private System.Windows.Forms.Label lblOpening;
        private System.Windows.Forms.Label metroLabel10;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label metroLabel7;
        private System.Windows.Forms.Label lblMobileNo;
        private System.Windows.Forms.Label metroLabel4;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.TextBox txtOfficeNo;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.Label lblNaration;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDealerAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label metroLabel13;
        private System.Windows.Forms.TextBox txtGSTNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneExcelReport;
        private System.Windows.Forms.CheckBox chkCustomer;
        private System.Windows.Forms.Label lblHerader;
    }
}