namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmAccountLedgerReport
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
            this.lblsalesman = new System.Windows.Forms.Label();
            this.cmbSalesman = new System.Windows.Forms.ComboBox();
            this.chkSummery = new System.Windows.Forms.CheckBox();
            this.pnlCustomerSuplier = new System.Windows.Forms.Panel();
            this.rbDealer = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.metroLabel3 = new System.Windows.Forms.Label();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.cmbAccountName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccountLedger = new System.Windows.Forms.DataGridView();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlCustomerSuplier.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 10);
            this.panel1.TabIndex = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsalesman);
            this.groupBox1.Controls.Add(this.cmbSalesman);
            this.groupBox1.Controls.Add(this.chkSummery);
            this.groupBox1.Controls.Add(this.pnlCustomerSuplier);
            this.groupBox1.Controls.Add(this.chkOther);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.cmbAccountName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1066, 129);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            // 
            // lblsalesman
            // 
            this.lblsalesman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsalesman.AutoSize = true;
            this.lblsalesman.Location = new System.Drawing.Point(10, 65);
            this.lblsalesman.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblsalesman.Name = "lblsalesman";
            this.lblsalesman.Size = new System.Drawing.Size(102, 20);
            this.lblsalesman.TabIndex = 397;
            this.lblsalesman.Text = "सेल्समनचे नाव";
            this.lblsalesman.Visible = false;
            // 
            // cmbSalesman
            // 
            this.cmbSalesman.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSalesman.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSalesman.BackColor = System.Drawing.Color.White;
            this.cmbSalesman.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalesman.ForeColor = System.Drawing.Color.Black;
            this.cmbSalesman.FormattingEnabled = true;
            this.cmbSalesman.Location = new System.Drawing.Point(6, 93);
            this.cmbSalesman.Name = "cmbSalesman";
            this.cmbSalesman.Size = new System.Drawing.Size(261, 26);
            this.cmbSalesman.TabIndex = 396;
            this.cmbSalesman.Visible = false;
            this.cmbSalesman.SelectedIndexChanged += new System.EventHandler(this.cmbSalesman_SelectedIndexChanged);
            // 
            // chkSummery
            // 
            this.chkSummery.AutoSize = true;
            this.chkSummery.Location = new System.Drawing.Point(533, 20);
            this.chkSummery.Name = "chkSummery";
            this.chkSummery.Size = new System.Drawing.Size(100, 24);
            this.chkSummery.TabIndex = 395;
            this.chkSummery.Text = "Summary";
            this.chkSummery.UseVisualStyleBackColor = true;
            this.chkSummery.CheckedChanged += new System.EventHandler(this.chkSummery_CheckedChanged);
            // 
            // pnlCustomerSuplier
            // 
            this.pnlCustomerSuplier.Controls.Add(this.rbDealer);
            this.pnlCustomerSuplier.Controls.Add(this.rbCustomer);
            this.pnlCustomerSuplier.Location = new System.Drawing.Point(0, 16);
            this.pnlCustomerSuplier.Name = "pnlCustomerSuplier";
            this.pnlCustomerSuplier.Size = new System.Drawing.Size(242, 36);
            this.pnlCustomerSuplier.TabIndex = 394;
            // 
            // rbDealer
            // 
            this.rbDealer.AutoSize = true;
            this.rbDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDealer.Location = new System.Drawing.Point(114, 6);
            this.rbDealer.Name = "rbDealer";
            this.rbDealer.Size = new System.Drawing.Size(66, 22);
            this.rbDealer.TabIndex = 391;
            this.rbDealer.TabStop = true;
            this.rbDealer.Text = "व्यापारी";
            this.rbDealer.UseVisualStyleBackColor = true;
            this.rbDealer.CheckedChanged += new System.EventHandler(this.rbDealer_CheckedChanged);
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustomer.Location = new System.Drawing.Point(5, 6);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(59, 22);
            this.rbCustomer.TabIndex = 390;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "ग्राहक";
            this.rbCustomer.UseVisualStyleBackColor = true;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.rbCustomer_CheckedChanged);
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(316, 20);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(94, 24);
            this.chkOther.TabIndex = 393;
            this.chkOther.Text = "इतर खाती";
            this.chkOther.UseVisualStyleBackColor = true;
            this.chkOther.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(954, 91);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 29);
            this.btnPrint.TabIndex = 392;
            this.btnPrint.Text = "प्रिंट";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(838, 91);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 29);
            this.btnShow.TabIndex = 389;
            this.btnShow.Text = "दाखवा";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(577, 95);
            this.metroLabel3.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 20);
            this.metroLabel3.TabIndex = 153;
            this.metroLabel3.Text = "या तारखे पर्यंत :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(567, 58);
            this.metroLabel1.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 20);
            this.metroLabel1.TabIndex = 152;
            this.metroLabel1.Text = "या तारखे पासून :";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(697, 90);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(130, 29);
            this.dtpToDate.TabIndex = 151;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(697, 55);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(130, 29);
            this.dtpFromDate.TabIndex = 150;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(280, 64);
            this.metroLabel2.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 20);
            this.metroLabel2.TabIndex = 149;
            this.metroLabel2.Text = "खात्याचे नाव";
            // 
            // cmbAccountName
            // 
            this.cmbAccountName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccountName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccountName.BackColor = System.Drawing.Color.White;
            this.cmbAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountName.ForeColor = System.Drawing.Color.Black;
            this.cmbAccountName.FormattingEnabled = true;
            this.cmbAccountName.Location = new System.Drawing.Point(281, 92);
            this.cmbAccountName.Name = "cmbAccountName";
            this.cmbAccountName.Size = new System.Drawing.Size(285, 26);
            this.cmbAccountName.TabIndex = 0;
            this.cmbAccountName.SelectedIndexChanged += new System.EventHandler(this.cmbAccountName_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAccountLedger);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.groupBox2.Location = new System.Drawing.Point(20, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1066, 384);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            // 
            // dgvAccountLedger
            // 
            this.dgvAccountLedger.AllowUserToAddRows = false;
            this.dgvAccountLedger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountLedger.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccountLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountLedger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccountLedger.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccountLedger.Location = new System.Drawing.Point(3, 27);
            this.dgvAccountLedger.Name = "dgvAccountLedger";
            this.dgvAccountLedger.RowHeadersVisible = false;
            this.dgvAccountLedger.RowTemplate.Height = 26;
            this.dgvAccountLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountLedger.Size = new System.Drawing.Size(1060, 354);
            this.dgvAccountLedger.TabIndex = 0;
            this.dgvAccountLedger.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAccountLedger_CellFormatting);
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(17, 15);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(180, 33);
            this.lblHerader.TabIndex = 360;
            this.lblHerader.Text = "खाते उधारी रिपोर्ट";
            // 
            // frmAccountLedgerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 603);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmAccountLedgerReport";
            this.Load += new System.EventHandler(this.frmAccountLedgerReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccountLedgerReport_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlCustomerSuplier.ResumeLayout(false);
            this.pnlCustomerSuplier.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountLedger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAccountLedger;
        private System.Windows.Forms.ComboBox cmbAccountName;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label metroLabel3;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rbDealer;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.Panel pnlCustomerSuplier;
        private System.Windows.Forms.CheckBox chkSummery;
        private System.Windows.Forms.Label lblHerader;
        private System.Windows.Forms.Label lblsalesman;
        private System.Windows.Forms.ComboBox cmbSalesman;
    }
}