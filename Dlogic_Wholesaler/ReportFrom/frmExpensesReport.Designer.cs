namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmExpensesReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btneExcelReport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccounting = new System.Windows.Forms.DataGridView();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounting)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 10);
            this.panel1.TabIndex = 103;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAccount);
            this.groupBox1.Controls.Add(this.lblAccountName);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btneExcelReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1180, 114);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  ";
            // 
            // cmbAccount
            // 
            this.cmbAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccount.BackColor = System.Drawing.Color.White;
            this.cmbAccount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAccount.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold);
            this.cmbAccount.ForeColor = System.Drawing.Color.Black;
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(316, 22);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(272, 28);
            this.cmbAccount.TabIndex = 115;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Mangal", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccountName.Location = new System.Drawing.Point(180, 22);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(87, 29);
            this.lblAccountName.TabIndex = 114;
            this.lblAccountName.Text = "खाते नाव :";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(902, 57);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 35);
            this.btnPrint.TabIndex = 113;
            this.btnPrint.Text = "प्रिंट";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(153, 63);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(141, 29);
            this.dtpFrom.TabIndex = 112;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(441, 63);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(141, 29);
            this.dtpTo.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mangal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 110;
            this.label1.Text = "या दिनांक पर्यंत";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(618, 57);
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
            this.label10.Font = new System.Drawing.Font("Mangal", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(14, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 29);
            this.label10.TabIndex = 30;
            this.label10.Text = "या दिनांक पासून";
            // 
            // btneExcelReport
            // 
            this.btneExcelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btneExcelReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btneExcelReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneExcelReport.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold);
            this.btneExcelReport.ForeColor = System.Drawing.Color.White;
            this.btneExcelReport.Location = new System.Drawing.Point(747, 57);
            this.btneExcelReport.Name = "btneExcelReport";
            this.btneExcelReport.Size = new System.Drawing.Size(139, 35);
            this.btneExcelReport.TabIndex = 28;
            this.btneExcelReport.Text = "एक्सेल रिपोर्ट";
            this.btneExcelReport.UseVisualStyleBackColor = false;
            this.btneExcelReport.Click += new System.EventHandler(this.btneExcelReport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAccounting);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(20, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1180, 361);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            // 
            // dgvAccounting
            // 
            this.dgvAccounting.AllowUserToAddRows = false;
            this.dgvAccounting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAccounting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccounting.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccounting.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccounting.Location = new System.Drawing.Point(3, 16);
            this.dgvAccounting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAccounting.Name = "dgvAccounting";
            this.dgvAccounting.ReadOnly = true;
            this.dgvAccounting.RowHeadersVisible = false;
            this.dgvAccounting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounting.Size = new System.Drawing.Size(1174, 342);
            this.dgvAccounting.TabIndex = 37;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(406, 15);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(316, 33);
            this.lblHerader.TabIndex = 364;
            this.lblHerader.Text = "खर्च रिपोर्ट (Expenses Report)";
            // 
            // frmExpensesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 565);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmExpensesReport";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmExpensesReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmExpensesReport_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btneExcelReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAccounting;
        private System.Windows.Forms.Label lblHerader;
    }
}