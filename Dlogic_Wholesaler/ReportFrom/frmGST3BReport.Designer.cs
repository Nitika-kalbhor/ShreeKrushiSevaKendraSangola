namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmGST3BReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcelGST3B = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btneExcelReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvOutwardSupplies = new System.Windows.Forms.DataGridView();
            this.NatureofSupplies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTaxablevalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntegratedTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentralTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateUTTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEligibleITC = new System.Windows.Forms.DataGridView();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntegratedTax1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentralTax1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateUTTax1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cess1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutwardSupplies)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEligibleITC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 10);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "GST- 3B  Report";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcelGST3B);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btneExcelReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1083, 113);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  ";
            // 
            // btnExcelGST3B
            // 
            this.btnExcelGST3B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnExcelGST3B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnExcelGST3B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelGST3B.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.btnExcelGST3B.ForeColor = System.Drawing.Color.White;
            this.btnExcelGST3B.Location = new System.Drawing.Point(644, 22);
            this.btnExcelGST3B.Name = "btnExcelGST3B";
            this.btnExcelGST3B.Size = new System.Drawing.Size(201, 35);
            this.btnExcelGST3B.TabIndex = 113;
            this.btnExcelGST3B.Text = "GST 3B Excel";
            this.btnExcelGST3B.UseVisualStyleBackColor = false;
            this.btnExcelGST3B.Click += new System.EventHandler(this.btnExcelGST3B_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(152, 27);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(161, 29);
            this.dtpFrom.TabIndex = 112;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(457, 27);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(169, 29);
            this.dtpTo.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label2.Location = new System.Drawing.Point(334, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 110;
            this.label2.Text = "या दिनांक पर्यत";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(373, 62);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(113, 35);
            this.btnShow.TabIndex = 108;
            this.btnShow.Text = "शो";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label10.Location = new System.Drawing.Point(13, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 21);
            this.label10.TabIndex = 30;
            this.label10.Text = "या दिनांक पासून";
            // 
            // btneExcelReport
            // 
            this.btneExcelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btneExcelReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btneExcelReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneExcelReport.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.btneExcelReport.ForeColor = System.Drawing.Color.White;
            this.btneExcelReport.Location = new System.Drawing.Point(644, 63);
            this.btneExcelReport.Name = "btneExcelReport";
            this.btneExcelReport.Size = new System.Drawing.Size(201, 35);
            this.btneExcelReport.TabIndex = 28;
            this.btneExcelReport.Text = "GST 3B एक्सेल रिपोर्ट";
            this.btneExcelReport.UseVisualStyleBackColor = false;
            this.btneExcelReport.Click += new System.EventHandler(this.btneExcelReport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(20, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 348);
            this.panel2.TabIndex = 105;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvOutwardSupplies);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1075, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Outward Supplies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvOutwardSupplies
            // 
            this.dgvOutwardSupplies.AllowUserToAddRows = false;
            this.dgvOutwardSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOutwardSupplies.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOutwardSupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOutwardSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutwardSupplies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NatureofSupplies,
            this.TotalTaxablevalue,
            this.IntegratedTax,
            this.CentralTax,
            this.StateUTTax,
            this.Cess});
            this.dgvOutwardSupplies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutwardSupplies.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOutwardSupplies.EnableHeadersVisualStyles = false;
            this.dgvOutwardSupplies.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvOutwardSupplies.Location = new System.Drawing.Point(3, 3);
            this.dgvOutwardSupplies.Name = "dgvOutwardSupplies";
            this.dgvOutwardSupplies.RowHeadersVisible = false;
            this.dgvOutwardSupplies.RowTemplate.Height = 25;
            this.dgvOutwardSupplies.Size = new System.Drawing.Size(1069, 309);
            this.dgvOutwardSupplies.TabIndex = 6;
            // 
            // NatureofSupplies
            // 
            this.NatureofSupplies.DataPropertyName = "NatureofSupplies";
            this.NatureofSupplies.HeaderText = "Nature of Supplies";
            this.NatureofSupplies.Name = "NatureofSupplies";
            this.NatureofSupplies.Width = 141;
            // 
            // TotalTaxablevalue
            // 
            this.TotalTaxablevalue.DataPropertyName = "TotalTaxablevalue";
            this.TotalTaxablevalue.HeaderText = "Total Taxable value";
            this.TotalTaxablevalue.Name = "TotalTaxablevalue";
            this.TotalTaxablevalue.Width = 147;
            // 
            // IntegratedTax
            // 
            this.IntegratedTax.DataPropertyName = "IntegratedTax";
            this.IntegratedTax.HeaderText = "Integrated Tax";
            this.IntegratedTax.Name = "IntegratedTax";
            this.IntegratedTax.Width = 116;
            // 
            // CentralTax
            // 
            this.CentralTax.DataPropertyName = "CentralTax";
            this.CentralTax.HeaderText = "Central Tax";
            this.CentralTax.Name = "CentralTax";
            this.CentralTax.Width = 101;
            // 
            // StateUTTax
            // 
            this.StateUTTax.DataPropertyName = "StateUTTax";
            this.StateUTTax.HeaderText = "StateUT Tax";
            this.StateUTTax.Name = "StateUTTax";
            this.StateUTTax.Width = 107;
            // 
            // Cess
            // 
            this.Cess.DataPropertyName = "Cess";
            this.Cess.HeaderText = "Cess";
            this.Cess.Name = "Cess";
            this.Cess.Width = 69;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEligibleITC);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1075, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eligible ITC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEligibleITC
            // 
            this.dgvEligibleITC.AllowUserToAddRows = false;
            this.dgvEligibleITC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEligibleITC.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEligibleITC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEligibleITC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEligibleITC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Details,
            this.IntegratedTax1,
            this.CentralTax1,
            this.StateUTTax1,
            this.Cess1});
            this.dgvEligibleITC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEligibleITC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEligibleITC.EnableHeadersVisualStyles = false;
            this.dgvEligibleITC.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEligibleITC.Location = new System.Drawing.Point(3, 3);
            this.dgvEligibleITC.Name = "dgvEligibleITC";
            this.dgvEligibleITC.RowHeadersVisible = false;
            this.dgvEligibleITC.RowTemplate.Height = 25;
            this.dgvEligibleITC.Size = new System.Drawing.Size(1069, 309);
            this.dgvEligibleITC.TabIndex = 6;
            // 
            // Details
            // 
            this.Details.DataPropertyName = "Details";
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.Width = 79;
            // 
            // IntegratedTax1
            // 
            this.IntegratedTax1.DataPropertyName = "IntegratedTax";
            this.IntegratedTax1.HeaderText = "Integrated Tax";
            this.IntegratedTax1.Name = "IntegratedTax1";
            this.IntegratedTax1.Width = 127;
            // 
            // CentralTax1
            // 
            this.CentralTax1.DataPropertyName = "CentralTax";
            this.CentralTax1.HeaderText = "Central Tax";
            this.CentralTax1.Name = "CentralTax1";
            this.CentralTax1.Width = 110;
            // 
            // StateUTTax1
            // 
            this.StateUTTax1.DataPropertyName = "StateUTTax";
            this.StateUTTax1.HeaderText = "State UT Tax";
            this.StateUTTax1.Name = "StateUTTax1";
            this.StateUTTax1.Width = 121;
            // 
            // Cess1
            // 
            this.Cess1.DataPropertyName = "Cess";
            this.Cess1.HeaderText = "Cess";
            this.Cess1.Name = "Cess1";
            this.Cess1.Width = 69;
            // 
            // frmGST3BReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1123, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGST3BReport";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 24);
            this.Load += new System.EventHandler(this.frmGST3BReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutwardSupplies)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEligibleITC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btneExcelReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvOutwardSupplies;
        private System.Windows.Forms.DataGridView dgvEligibleITC;
        private System.Windows.Forms.Button btnExcelGST3B;
        private System.Windows.Forms.DataGridViewTextBoxColumn NatureofSupplies;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTaxablevalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntegratedTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentralTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateUTTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntegratedTax1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentralTax1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateUTTax1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cess1;
    }
}