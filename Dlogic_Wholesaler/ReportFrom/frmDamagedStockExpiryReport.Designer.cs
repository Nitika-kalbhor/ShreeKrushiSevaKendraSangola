namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmDamagedStockExpiryReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFrmDate = new System.Windows.Forms.Label();
            this.dtpTodate = new System.Windows.Forms.DateTimePicker();
            this.dtpfrmDate = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBankDeposite = new System.Windows.Forms.DataGridView();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagedStockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFD_Date_expireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHerader = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankDeposite)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 10);
            this.panel1.TabIndex = 105;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(476, 23);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(96, 35);
            this.btnShow.TabIndex = 136;
            this.btnShow.Text = "दाखवा ";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblToDate.Location = new System.Drawing.Point(330, 3);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(63, 20);
            this.lblToDate.TabIndex = 135;
            this.lblToDate.Text = "ते दिनांक ";
            // 
            // lblFrmDate
            // 
            this.lblFrmDate.AutoSize = true;
            this.lblFrmDate.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblFrmDate.Location = new System.Drawing.Point(121, 3);
            this.lblFrmDate.Name = "lblFrmDate";
            this.lblFrmDate.Size = new System.Drawing.Size(86, 20);
            this.lblFrmDate.TabIndex = 134;
            this.lblFrmDate.Text = "पासून दिनांक ";
            // 
            // dtpTodate
            // 
            this.dtpTodate.CustomFormat = "dd-MM-yyyy";
            this.dtpTodate.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.dtpTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTodate.Location = new System.Drawing.Point(304, 29);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Size = new System.Drawing.Size(154, 29);
            this.dtpTodate.TabIndex = 133;
            // 
            // dtpfrmDate
            // 
            this.dtpfrmDate.CustomFormat = "dd-MM-yyyy";
            this.dtpfrmDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.dtpfrmDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfrmDate.Location = new System.Drawing.Point(88, 29);
            this.dtpfrmDate.Name = "dtpfrmDate";
            this.dtpfrmDate.Size = new System.Drawing.Size(180, 29);
            this.dtpfrmDate.TabIndex = 132;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(578, 23);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(81, 35);
            this.btnPrint.TabIndex = 131;
            this.btnPrint.Text = "प्रिंट";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpfrmDate);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.lblToDate);
            this.panel2.Controls.Add(this.dtpTodate);
            this.panel2.Controls.Add(this.lblFrmDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 65);
            this.panel2.TabIndex = 137;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvBankDeposite);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.panel3.Location = new System.Drawing.Point(20, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1081, 425);
            this.panel3.TabIndex = 138;
            // 
            // dgvBankDeposite
            // 
            this.dgvBankDeposite.AllowUserToAddRows = false;
            this.dgvBankDeposite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBankDeposite.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBankDeposite.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBankDeposite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBankDeposite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankDeposite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceId,
            this.damagedStockDate,
            this.itemName,
            this.MFD_Date_expireDate,
            this.Remark,
            this.Quantity,
            this.purchaseRate,
            this.Amount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBankDeposite.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBankDeposite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankDeposite.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBankDeposite.EnableHeadersVisualStyles = false;
            this.dgvBankDeposite.GridColor = System.Drawing.Color.Maroon;
            this.dgvBankDeposite.Location = new System.Drawing.Point(0, 0);
            this.dgvBankDeposite.Name = "dgvBankDeposite";
            this.dgvBankDeposite.RowHeadersVisible = false;
            this.dgvBankDeposite.RowTemplate.Height = 25;
            this.dgvBankDeposite.Size = new System.Drawing.Size(1081, 425);
            this.dgvBankDeposite.TabIndex = 111;
            // 
            // InvoiceId
            // 
            this.InvoiceId.DataPropertyName = "InvoiceId";
            this.InvoiceId.HeaderText = "नं";
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.Width = 44;
            // 
            // damagedStockDate
            // 
            this.damagedStockDate.DataPropertyName = "damagedStockDate";
            this.damagedStockDate.HeaderText = "दिनांक";
            this.damagedStockDate.Name = "damagedStockDate";
            this.damagedStockDate.Width = 74;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "वस्तूचे नांव";
            this.itemName.Name = "itemName";
            this.itemName.Width = 98;
            // 
            // MFD_Date_expireDate
            // 
            this.MFD_Date_expireDate.DataPropertyName = "MFD_Date_expireDate";
            this.MFD_Date_expireDate.HeaderText = "MFD/Exp Date";
            this.MFD_Date_expireDate.Name = "MFD_Date_expireDate";
            this.MFD_Date_expireDate.Width = 140;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "तपशील";
            this.Remark.Name = "Remark";
            this.Remark.Width = 80;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "नग";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 53;
            // 
            // purchaseRate
            // 
            this.purchaseRate.DataPropertyName = "purchaseRate";
            this.purchaseRate.HeaderText = "दर";
            this.purchaseRate.Name = "purchaseRate";
            this.purchaseRate.Width = 52;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "रक्कम";
            this.Amount.Name = "Amount";
            this.Amount.Width = 64;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(26, 10);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(201, 36);
            this.lblHerader.TabIndex = 439;
            this.lblHerader.Text = "खराब स्टॉक रिपोर्ट";
            // 
            // frmDamagedStockExpiryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 580);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDamagedStockExpiryReport";
            this.Load += new System.EventHandler(this.frmDamagedStockExpiryReport_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankDeposite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFrmDate;
        private System.Windows.Forms.DateTimePicker dtpTodate;
        private System.Windows.Forms.DateTimePicker dtpfrmDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvBankDeposite;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn damagedStockDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFD_Date_expireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label lblHerader;
    }
}