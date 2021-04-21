namespace Dlogic_Wholesaler.TempFroms
{
    partial class frmTempSaleChallanList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbChallanList = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvSaleChallan = new System.Windows.Forms.DataGridView();
            this.SalesChallanBillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesChallanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesChallanDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalesChallanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isConvert = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenrateInvoice = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtpToChallanDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromChallanDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(763, 10);
            this.panel1.TabIndex = 100;
            // 
            // grbChallanList
            // 
            this.grbChallanList.Controls.Add(this.groupBox5);
            this.grbChallanList.Controls.Add(this.panel2);
            this.grbChallanList.Controls.Add(this.groupBox4);
            this.grbChallanList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChallanList.Location = new System.Drawing.Point(20, 70);
            this.grbChallanList.Name = "grbChallanList";
            this.grbChallanList.Size = new System.Drawing.Size(763, 424);
            this.grbChallanList.TabIndex = 336;
            this.grbChallanList.TabStop = false;
            this.grbChallanList.Text = " ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvSaleChallan);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(757, 322);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // dgvSaleChallan
            // 
            this.dgvSaleChallan.AllowUserToAddRows = false;
            this.dgvSaleChallan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaleChallan.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaleChallan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleChallan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesChallanBillId,
            this.salesChallanId,
            this.customerName,
            this.SalesChallanDate,
            this.totalSalesChallanAmount,
            this.isConvert});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleChallan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleChallan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleChallan.Location = new System.Drawing.Point(3, 16);
            this.dgvSaleChallan.Name = "dgvSaleChallan";
            this.dgvSaleChallan.RowHeadersVisible = false;
            this.dgvSaleChallan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSaleChallan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSaleChallan.Size = new System.Drawing.Size(751, 303);
            this.dgvSaleChallan.TabIndex = 0;
            // 
            // SalesChallanBillId
            // 
            this.SalesChallanBillId.DataPropertyName = "SalesChallanBillId";
            this.SalesChallanBillId.HeaderText = "चलन न";
            this.SalesChallanBillId.Name = "SalesChallanBillId";
            // 
            // salesChallanId
            // 
            this.salesChallanId.DataPropertyName = "salesChallanId";
            this.salesChallanId.HeaderText = "salesChallanId";
            this.salesChallanId.Name = "salesChallanId";
            this.salesChallanId.Visible = false;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "ग्राहक";
            this.customerName.Name = "customerName";
            // 
            // SalesChallanDate
            // 
            this.SalesChallanDate.DataPropertyName = "SalesChallanDate";
            this.SalesChallanDate.HeaderText = "चलन दिनांक ";
            this.SalesChallanDate.Name = "SalesChallanDate";
            // 
            // totalSalesChallanAmount
            // 
            this.totalSalesChallanAmount.DataPropertyName = "totalSalesChallanAmount";
            this.totalSalesChallanAmount.HeaderText = "रक्कम";
            this.totalSalesChallanAmount.Name = "totalSalesChallanAmount";
            // 
            // isConvert
            // 
            this.isConvert.DataPropertyName = "isConvert";
            this.isConvert.HeaderText = "निवडा ";
            this.isConvert.Name = "isConvert";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGenrateInvoice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 36);
            this.panel2.TabIndex = 3;
            // 
            // btnGenrateInvoice
            // 
            this.btnGenrateInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnGenrateInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnGenrateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenrateInvoice.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenrateInvoice.ForeColor = System.Drawing.Color.White;
            this.btnGenrateInvoice.Location = new System.Drawing.Point(220, 1);
            this.btnGenrateInvoice.Name = "btnGenrateInvoice";
            this.btnGenrateInvoice.Size = new System.Drawing.Size(201, 34);
            this.btnGenrateInvoice.TabIndex = 346;
            this.btnGenrateInvoice.Text = "बिल बनवा ";
            this.btnGenrateInvoice.UseVisualStyleBackColor = false;
            this.btnGenrateInvoice.Click += new System.EventHandler(this.btnGenrateInvoice_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbCustomerName);
            this.groupBox4.Controls.Add(this.btnShow);
            this.groupBox4.Controls.Add(this.dtpToChallanDate);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dtpFromChallanDate);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(757, 47);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(6, 11);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(250, 28);
            this.cmbCustomerName.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(654, 11);
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
            this.dtpToChallanDate.Location = new System.Drawing.Point(546, 11);
            this.dtpToChallanDate.Name = "dtpToChallanDate";
            this.dtpToChallanDate.Size = new System.Drawing.Size(102, 29);
            this.dtpToChallanDate.TabIndex = 344;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 15);
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
            this.dtpFromChallanDate.Location = new System.Drawing.Point(354, 11);
            this.dtpFromChallanDate.Name = "dtpFromChallanDate";
            this.dtpFromChallanDate.Size = new System.Drawing.Size(116, 29);
            this.dtpFromChallanDate.TabIndex = 342;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 341;
            this.label2.Text = "पासून दिनांक:";
            // 
            // frmTempSaleChallanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 514);
            this.Controls.Add(this.grbChallanList);
            this.Controls.Add(this.panel1);
            this.Name = "frmTempSaleChallanList";
            this.Text = "सेल चेलन 2";
            this.Load += new System.EventHandler(this.frmSaleChallanList_Load);
            this.grbChallanList.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleChallan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbChallanList;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvSaleChallan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGenrateInvoice;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dtpToChallanDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromChallanDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesChallanBillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesChallanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesChallanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalesChallanAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isConvert;
    }
}