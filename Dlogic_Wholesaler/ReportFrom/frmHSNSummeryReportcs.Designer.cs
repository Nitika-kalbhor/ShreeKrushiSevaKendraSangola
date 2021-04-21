namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmHSNSummeryReportcs
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvHNSSummery = new System.Windows.Forms.DataGridView();
            this.HSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UQC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxableValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntegratedTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentralTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateUTTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CessAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHNSSummery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpToDate);
            this.groupBox2.Controls.Add(this.dtpFromDate);
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F);
            this.groupBox2.Location = new System.Drawing.Point(20, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1198, 56);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 398;
            this.label2.Text = "To Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 397;
            this.label1.Text = "From Date :";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(431, 20);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(119, 29);
            this.dtpToDate.TabIndex = 396;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(168, 19);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(137, 29);
            this.dtpFromDate.TabIndex = 395;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(960, 16);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(108, 34);
            this.btnExcel.TabIndex = 394;
            this.btnExcel.Text = "Excel Export";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(833, 16);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 36);
            this.btnShow.TabIndex = 390;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvHNSSummery
            // 
            this.dgvHNSSummery.AllowUserToAddRows = false;
            this.dgvHNSSummery.AllowUserToDeleteRows = false;
            this.dgvHNSSummery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHNSSummery.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHNSSummery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHNSSummery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHNSSummery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HSN,
            this.Description,
            this.UQC,
            this.TotalQuantity,
            this.TotalValue,
            this.TaxableValue,
            this.IntegratedTaxAmount,
            this.CentralTaxAmount,
            this.StateUTTaxAmount,
            this.CessAmount});
            this.dgvHNSSummery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHNSSummery.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHNSSummery.EnableHeadersVisualStyles = false;
            this.dgvHNSSummery.GridColor = System.Drawing.Color.Black;
            this.dgvHNSSummery.Location = new System.Drawing.Point(20, 126);
            this.dgvHNSSummery.Name = "dgvHNSSummery";
            this.dgvHNSSummery.RowHeadersVisible = false;
            this.dgvHNSSummery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHNSSummery.Size = new System.Drawing.Size(1198, 389);
            this.dgvHNSSummery.TabIndex = 83;
            // 
            // HSN
            // 
            this.HSN.DataPropertyName = "HSN";
            this.HSN.HeaderText = "HSN";
            this.HSN.Name = "HSN";
            this.HSN.Width = 63;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 109;
            // 
            // UQC
            // 
            this.UQC.DataPropertyName = "UQC";
            this.UQC.HeaderText = "UQC";
            this.UQC.Name = "UQC";
            this.UQC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UQC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UQC.Width = 45;
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.DataPropertyName = "TotalQuantity";
            this.TotalQuantity.HeaderText = "Total Quantity";
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TotalQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TotalQuantity.Width = 99;
            // 
            // TotalValue
            // 
            this.TotalValue.DataPropertyName = "TotalValue";
            this.TotalValue.HeaderText = "Total Value";
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TotalValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TotalValue.Width = 82;
            // 
            // TaxableValue
            // 
            this.TaxableValue.DataPropertyName = "TaxableValue";
            this.TaxableValue.HeaderText = "Taxable Value";
            this.TaxableValue.Name = "TaxableValue";
            this.TaxableValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TaxableValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TaxableValue.Width = 99;
            // 
            // IntegratedTaxAmount
            // 
            this.IntegratedTaxAmount.DataPropertyName = "IntegratedTaxAmount";
            this.IntegratedTaxAmount.HeaderText = "Integrated Tax Amount";
            this.IntegratedTaxAmount.Name = "IntegratedTaxAmount";
            this.IntegratedTaxAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IntegratedTaxAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IntegratedTaxAmount.Width = 104;
            // 
            // CentralTaxAmount
            // 
            this.CentralTaxAmount.DataPropertyName = "CentralTaxAmount";
            this.CentralTaxAmount.HeaderText = "Central Tax Amount";
            this.CentralTaxAmount.Name = "CentralTaxAmount";
            this.CentralTaxAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CentralTaxAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CentralTaxAmount.Width = 133;
            // 
            // StateUTTaxAmount
            // 
            this.StateUTTaxAmount.DataPropertyName = "StateUTTaxAmount";
            this.StateUTTaxAmount.HeaderText = "State/UT Tax Amount";
            this.StateUTTaxAmount.Name = "StateUTTaxAmount";
            this.StateUTTaxAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StateUTTaxAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StateUTTaxAmount.Width = 98;
            // 
            // CessAmount
            // 
            this.CessAmount.DataPropertyName = "CessAmount";
            this.CessAmount.HeaderText = "Cess Amount";
            this.CessAmount.Name = "CessAmount";
            this.CessAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CessAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CessAmount.Width = 94;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(20, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1198, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 80;
            this.pictureBox3.TabStop = false;
            // 
            // frmHSNSummeryReportcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 535);
            this.Controls.Add(this.dgvHNSSummery);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox3);
            this.KeyPreview = true;
            this.Name = "frmHSNSummeryReportcs";
            this.Text = "HSN Summery Report";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmHSNSummeryReportcs_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHSNSummeryReportcs_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHNSSummery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvHNSSummery;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UQC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxableValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntegratedTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentralTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateUTTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CessAmount;
    }
}