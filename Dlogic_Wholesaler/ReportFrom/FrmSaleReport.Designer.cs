namespace Dlogic_Wholesaler.ReportFrom
{
    partial class FrmSaleReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnExel = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.gbSaleReport = new System.Windows.Forms.GroupBox();
            this.dgvSaleReport = new System.Windows.Forms.DataGridView();
            this.invoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perQtysalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBillAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHerader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gb.SuspendLayout();
            this.gbSaleReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(20, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1085, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 80;
            this.pictureBox3.TabStop = false;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.lblToDate);
            this.gb.Controls.Add(this.dtpToDate);
            this.gb.Controls.Add(this.lblFromDate);
            this.gb.Controls.Add(this.dtpFromDate);
            this.gb.Controls.Add(this.btnExel);
            this.gb.Controls.Add(this.btnShow);
            this.gb.Controls.Add(this.metroLabel2);
            this.gb.Controls.Add(this.cmbCustomerName);
            this.gb.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb.Location = new System.Drawing.Point(20, 70);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(1085, 86);
            this.gb.TabIndex = 81;
            this.gb.TabStop = false;
            // 
            // lblToDate
            // 
            this.lblToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(353, 58);
            this.lblToDate.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(104, 21);
            this.lblToDate.TabIndex = 402;
            this.lblToDate.Text = "या तारखे पर्यंत:-";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(493, 53);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(130, 26);
            this.dtpToDate.TabIndex = 401;
            // 
            // lblFromDate
            // 
            this.lblFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(344, 20);
            this.lblFromDate.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(108, 21);
            this.lblFromDate.TabIndex = 400;
            this.lblFromDate.Text = "या तारखे पासून :";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(493, 18);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(130, 26);
            this.dtpFromDate.TabIndex = 399;
            // 
            // btnExel
            // 
            this.btnExel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnExel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExel.ForeColor = System.Drawing.Color.Black;
            this.btnExel.Location = new System.Drawing.Point(763, 50);
            this.btnExel.Name = "btnExel";
            this.btnExel.Size = new System.Drawing.Size(100, 29);
            this.btnExel.TabIndex = 397;
            this.btnExel.Text = "Exel";
            this.btnExel.UseVisualStyleBackColor = false;
            this.btnExel.Click += new System.EventHandler(this.btnExel_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(657, 50);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 29);
            this.btnShow.TabIndex = 396;
            this.btnShow.Text = "दाखवा";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 21);
            this.metroLabel2.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 21);
            this.metroLabel2.TabIndex = 395;
            this.metroLabel2.Text = "ग्राहकाचे नाव :";
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomerName.BackColor = System.Drawing.Color.White;
            this.cmbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomerName.ForeColor = System.Drawing.Color.Black;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(10, 47);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(267, 32);
            this.cmbCustomerName.TabIndex = 394;
            // 
            // gbSaleReport
            // 
            this.gbSaleReport.Controls.Add(this.dgvSaleReport);
            this.gbSaleReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSaleReport.Location = new System.Drawing.Point(20, 156);
            this.gbSaleReport.Name = "gbSaleReport";
            this.gbSaleReport.Size = new System.Drawing.Size(1085, 382);
            this.gbSaleReport.TabIndex = 82;
            this.gbSaleReport.TabStop = false;
            // 
            // dgvSaleReport
            // 
            this.dgvSaleReport.AllowUserToAddRows = false;
            this.dgvSaleReport.AllowUserToResizeColumns = false;
            this.dgvSaleReport.AllowUserToResizeRows = false;
            this.dgvSaleReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaleReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSaleReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNo,
            this.salesDate,
            this.customerName,
            this.customerAddress,
            this.itemName,
            this.unitBy,
            this.quantity,
            this.perQtysalePrice,
            this.TotalBillAmt});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleReport.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSaleReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSaleReport.EnableHeadersVisualStyles = false;
            this.dgvSaleReport.GridColor = System.Drawing.Color.Maroon;
            this.dgvSaleReport.Location = new System.Drawing.Point(3, 16);
            this.dgvSaleReport.Name = "dgvSaleReport";
            this.dgvSaleReport.RowHeadersVisible = false;
            this.dgvSaleReport.Size = new System.Drawing.Size(1079, 363);
            this.dgvSaleReport.TabIndex = 1;
            // 
            // invoiceNo
            // 
            this.invoiceNo.DataPropertyName = "invoiceNo";
            this.invoiceNo.HeaderText = "बिल नं.";
            this.invoiceNo.Name = "invoiceNo";
            // 
            // salesDate
            // 
            this.salesDate.DataPropertyName = "salesDate";
            this.salesDate.HeaderText = "दिनांक";
            this.salesDate.Name = "salesDate";
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "ग्राहकाचे नाव";
            this.customerName.Name = "customerName";
            // 
            // customerAddress
            // 
            this.customerAddress.DataPropertyName = "customerAddress";
            this.customerAddress.HeaderText = "Address";
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Visible = false;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "वस्तूचे नाव";
            this.itemName.Name = "itemName";
            // 
            // unitBy
            // 
            this.unitBy.DataPropertyName = "unitBy";
            this.unitBy.HeaderText = "Unit By";
            this.unitBy.Name = "unitBy";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "नग";
            this.quantity.Name = "quantity";
            // 
            // perQtysalePrice
            // 
            this.perQtysalePrice.DataPropertyName = "perQtysalePrice";
            this.perQtysalePrice.HeaderText = "विक्री किंमत";
            this.perQtysalePrice.Name = "perQtysalePrice";
            // 
            // TotalBillAmt
            // 
            this.TotalBillAmt.DataPropertyName = "TotalBillAmt";
            this.TotalBillAmt.HeaderText = "एकूण सेल रक्कम";
            this.TotalBillAmt.Name = "TotalBillAmt";
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(23, 10);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(118, 36);
            this.lblHerader.TabIndex = 433;
            this.lblHerader.Text = "सेल रिपोर्ट";
            // 
            // FrmSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 558);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.gbSaleReport);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FrmSaleReport";
            this.Load += new System.EventHandler(this.FrmSaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.gbSaleReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button btnExel;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.GroupBox gbSaleReport;
        private System.Windows.Forms.DataGridView dgvSaleReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn perQtysalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBillAmt;
        private System.Windows.Forms.Label lblHerader;
    }
}