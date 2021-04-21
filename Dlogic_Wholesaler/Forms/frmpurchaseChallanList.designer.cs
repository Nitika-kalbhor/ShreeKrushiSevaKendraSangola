namespace Dlogic_Wholesaler.Forms
{
    partial class frmpurchaseChallanList
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
            this.grbChallanList = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvSaleChallan = new System.Windows.Forms.DataGridView();
            this.purchaseChalanBillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseChalanId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealerFirmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseChalanDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netBillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isInvoice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenrateInvoice = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbDealerName = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtpToChallanDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromChallanDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHerader = new System.Windows.Forms.Label();
            this.grbChallanList.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleChallan)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 10);
            this.panel1.TabIndex = 316;
            // 
            // grbChallanList
            // 
            this.grbChallanList.Controls.Add(this.groupBox5);
            this.grbChallanList.Controls.Add(this.panel2);
            this.grbChallanList.Controls.Add(this.groupBox4);
            this.grbChallanList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChallanList.Location = new System.Drawing.Point(20, 70);
            this.grbChallanList.Name = "grbChallanList";
            this.grbChallanList.Size = new System.Drawing.Size(872, 418);
            this.grbChallanList.TabIndex = 335;
            this.grbChallanList.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvSaleChallan);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(866, 316);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // dgvSaleChallan
            // 
            this.dgvSaleChallan.AllowUserToAddRows = false;
            this.dgvSaleChallan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSaleChallan.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaleChallan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleChallan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseChalanBillId,
            this.purchaseChalanId1,
            this.dealerFirmName,
            this.purchaseChalanDate,
            this.netBillAmount,
            this.isInvoice});
            this.dgvSaleChallan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleChallan.Location = new System.Drawing.Point(3, 20);
            this.dgvSaleChallan.Name = "dgvSaleChallan";
            this.dgvSaleChallan.RowHeadersVisible = false;
            this.dgvSaleChallan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSaleChallan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSaleChallan.Size = new System.Drawing.Size(860, 293);
            this.dgvSaleChallan.TabIndex = 0;
            // 
            // purchaseChalanBillId
            // 
            this.purchaseChalanBillId.DataPropertyName = "purchaseChalanBillId";
            this.purchaseChalanBillId.HeaderText = "चलन नं.";
            this.purchaseChalanBillId.Name = "purchaseChalanBillId";
            this.purchaseChalanBillId.Width = 74;
            // 
            // purchaseChalanId1
            // 
            this.purchaseChalanId1.DataPropertyName = "purchaseChalanId";
            this.purchaseChalanId1.HeaderText = "purchaseChalanId";
            this.purchaseChalanId1.Name = "purchaseChalanId1";
            this.purchaseChalanId1.Visible = false;
            this.purchaseChalanId1.Width = 151;
            // 
            // dealerFirmName
            // 
            this.dealerFirmName.DataPropertyName = "dealerFirmName";
            this.dealerFirmName.HeaderText = "फर्म नाव";
            this.dealerFirmName.Name = "dealerFirmName";
            this.dealerFirmName.Width = 77;
            // 
            // purchaseChalanDate
            // 
            this.purchaseChalanDate.DataPropertyName = "purchaseChalanDate";
            this.purchaseChalanDate.HeaderText = "चलन दिनांक";
            this.purchaseChalanDate.Name = "purchaseChalanDate";
            this.purchaseChalanDate.Width = 96;
            // 
            // netBillAmount
            // 
            this.netBillAmount.DataPropertyName = "netBillAmount";
            this.netBillAmount.HeaderText = "रक्कम";
            this.netBillAmount.Name = "netBillAmount";
            this.netBillAmount.Width = 66;
            // 
            // isInvoice
            // 
            this.isInvoice.DataPropertyName = "isInvoice";
            this.isInvoice.HeaderText = "निवडा";
            this.isInvoice.Name = "isInvoice";
            this.isInvoice.Width = 45;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGenrateInvoice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 36);
            this.panel2.TabIndex = 3;
            // 
            // btnGenrateInvoice
            // 
            this.btnGenrateInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnGenrateInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnGenrateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenrateInvoice.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenrateInvoice.ForeColor = System.Drawing.Color.White;
            this.btnGenrateInvoice.Location = new System.Drawing.Point(290, 1);
            this.btnGenrateInvoice.Name = "btnGenrateInvoice";
            this.btnGenrateInvoice.Size = new System.Drawing.Size(201, 34);
            this.btnGenrateInvoice.TabIndex = 346;
            this.btnGenrateInvoice.Text = "बिल बनवा";
            this.btnGenrateInvoice.UseVisualStyleBackColor = false;
            this.btnGenrateInvoice.Click += new System.EventHandler(this.btnGenrateInvoice_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbDealerName);
            this.groupBox4.Controls.Add(this.btnShow);
            this.groupBox4.Controls.Add(this.dtpToChallanDate);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dtpFromChallanDate);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(866, 47);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // cmbDealerName
            // 
            this.cmbDealerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDealerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDealerName.FormattingEnabled = true;
            this.cmbDealerName.Location = new System.Drawing.Point(3, 11);
            this.cmbDealerName.Name = "cmbDealerName";
            this.cmbDealerName.Size = new System.Drawing.Size(250, 28);
            this.cmbDealerName.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(757, 8);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(91, 34);
            this.btnShow.TabIndex = 345;
            this.btnShow.Text = "दाखवा";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtpToChallanDate
            // 
            this.dtpToChallanDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToChallanDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToChallanDate.Location = new System.Drawing.Point(631, 11);
            this.dtpToChallanDate.Name = "dtpToChallanDate";
            this.dtpToChallanDate.Size = new System.Drawing.Size(116, 29);
            this.dtpToChallanDate.TabIndex = 344;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 343;
            this.label3.Text = "पर्यंत दिनांक :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpFromChallanDate
            // 
            this.dtpFromChallanDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromChallanDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromChallanDate.Location = new System.Drawing.Point(365, 11);
            this.dtpFromChallanDate.Name = "dtpFromChallanDate";
            this.dtpFromChallanDate.Size = new System.Drawing.Size(121, 29);
            this.dtpFromChallanDate.TabIndex = 342;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 341;
            this.label2.Text = "पासून दिनांक :";
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(23, 11);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(188, 36);
            this.lblHerader.TabIndex = 427;
            this.lblHerader.Text = "खरेदी चलन यादी";
            // 
            // frmpurchaseChallanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 508);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.grbChallanList);
            this.Controls.Add(this.panel1);
            this.Name = "frmpurchaseChallanList";
            this.Load += new System.EventHandler(this.frmSaleChallanList_Load);
            this.grbChallanList.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleChallan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbChallanList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dtpToChallanDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromChallanDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDealerName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvSaleChallan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGenrateInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseChalanBillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseChalanId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealerFirmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseChalanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn netBillAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isInvoice;
        private System.Windows.Forms.Label lblHerader;
    }
}