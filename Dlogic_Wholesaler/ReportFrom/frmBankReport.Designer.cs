namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmBankReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFrmDate = new System.Windows.Forms.Label();
            this.dtpTodate = new System.Windows.Forms.DateTimePicker();
            this.dtpfrmDate = new System.Windows.Forms.DateTimePicker();
            this.btneExcelReport = new System.Windows.Forms.Button();
            this.dgvBankDeposite = new System.Windows.Forms.DataGridView();
            this.bankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankDeposite)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 10);
            this.panel1.TabIndex = 104;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPayment);
            this.groupBox1.Controls.Add(this.cmbBank);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.lblToDate);
            this.groupBox1.Controls.Add(this.lblFrmDate);
            this.groupBox1.Controls.Add(this.dtpTodate);
            this.groupBox1.Controls.Add(this.dtpfrmDate);
            this.groupBox1.Controls.Add(this.btneExcelReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 88);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblPayment.Location = new System.Drawing.Point(124, 14);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(28, 20);
            this.lblPayment.TabIndex = 139;
            this.lblPayment.Text = "बँक";
            // 
            // cmbBank
            // 
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Items.AddRange(new object[] {
            "--Select--",
            "Cash",
            "Card Payment",
            "Cheque",
            "IMPS & NEFT & RTGS"});
            this.cmbBank.Location = new System.Drawing.Point(6, 44);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(355, 28);
            this.cmbBank.TabIndex = 138;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(755, 39);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(96, 35);
            this.btnShow.TabIndex = 130;
            this.btnShow.Text = "दाखवा ";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblToDate.Location = new System.Drawing.Point(609, 19);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(63, 20);
            this.lblToDate.TabIndex = 129;
            this.lblToDate.Text = "ते दिनांक ";
            // 
            // lblFrmDate
            // 
            this.lblFrmDate.AutoSize = true;
            this.lblFrmDate.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.lblFrmDate.Location = new System.Drawing.Point(400, 19);
            this.lblFrmDate.Name = "lblFrmDate";
            this.lblFrmDate.Size = new System.Drawing.Size(86, 20);
            this.lblFrmDate.TabIndex = 128;
            this.lblFrmDate.Text = "पासून दिनांक ";
            // 
            // dtpTodate
            // 
            this.dtpTodate.CustomFormat = "dd-MM-yyyy";
            this.dtpTodate.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.dtpTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTodate.Location = new System.Drawing.Point(583, 45);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Size = new System.Drawing.Size(154, 29);
            this.dtpTodate.TabIndex = 127;
            // 
            // dtpfrmDate
            // 
            this.dtpfrmDate.CustomFormat = "dd-MM-yyyy";
            this.dtpfrmDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.dtpfrmDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfrmDate.Location = new System.Drawing.Point(367, 45);
            this.dtpfrmDate.Name = "dtpfrmDate";
            this.dtpfrmDate.Size = new System.Drawing.Size(180, 29);
            this.dtpfrmDate.TabIndex = 126;
            // 
            // btneExcelReport
            // 
            this.btneExcelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btneExcelReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btneExcelReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneExcelReport.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold);
            this.btneExcelReport.ForeColor = System.Drawing.Color.White;
            this.btneExcelReport.Location = new System.Drawing.Point(857, 39);
            this.btneExcelReport.Name = "btneExcelReport";
            this.btneExcelReport.Size = new System.Drawing.Size(140, 35);
            this.btneExcelReport.TabIndex = 28;
            this.btneExcelReport.Text = "Excel रिपोर्ट ";
            this.btneExcelReport.UseVisualStyleBackColor = false;
            this.btneExcelReport.Click += new System.EventHandler(this.btneExcelReport_Click);
            // 
            // dgvBankDeposite
            // 
            this.dgvBankDeposite.AllowUserToAddRows = false;
            this.dgvBankDeposite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBankDeposite.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBankDeposite.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBankDeposite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBankDeposite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankDeposite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bankName,
            this.date,
            this.naration,
            this.drAmount,
            this.crAmount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBankDeposite.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBankDeposite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBankDeposite.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBankDeposite.EnableHeadersVisualStyles = false;
            this.dgvBankDeposite.GridColor = System.Drawing.Color.Maroon;
            this.dgvBankDeposite.Location = new System.Drawing.Point(20, 158);
            this.dgvBankDeposite.Name = "dgvBankDeposite";
            this.dgvBankDeposite.RowHeadersVisible = false;
            this.dgvBankDeposite.RowTemplate.Height = 25;
            this.dgvBankDeposite.Size = new System.Drawing.Size(1176, 370);
            this.dgvBankDeposite.TabIndex = 110;
            // 
            // bankName
            // 
            this.bankName.DataPropertyName = "AccountName";
            this.bankName.FillWeight = 113.6364F;
            this.bankName.HeaderText = "बँक ";
            this.bankName.Name = "bankName";
            this.bankName.Width = 62;
            // 
            // date
            // 
            this.date.DataPropertyName = "transactionDate";
            this.date.FillWeight = 41.20929F;
            this.date.HeaderText = "दिनांक";
            this.date.Name = "date";
            this.date.Width = 79;
            // 
            // naration
            // 
            this.naration.DataPropertyName = "naration";
            this.naration.FillWeight = 232.1379F;
            this.naration.HeaderText = "तपशील";
            this.naration.Name = "naration";
            this.naration.Width = 85;
            // 
            // drAmount
            // 
            this.drAmount.DataPropertyName = "drAmount";
            dataGridViewCellStyle2.Format = "N2";
            this.drAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.drAmount.FillWeight = 53.36168F;
            this.drAmount.HeaderText = "नावे(WithDraw)";
            this.drAmount.Name = "drAmount";
            this.drAmount.Width = 150;
            // 
            // crAmount
            // 
            this.crAmount.DataPropertyName = "crAmount";
            dataGridViewCellStyle3.Format = "N2";
            this.crAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.crAmount.FillWeight = 59.65473F;
            this.crAmount.HeaderText = "जमा(Deposit)";
            this.crAmount.Name = "crAmount";
            this.crAmount.Width = 137;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(41, 15);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(106, 33);
            this.lblHerader.TabIndex = 365;
            this.lblHerader.Text = "बँक रिपोर्ट";
            // 
            // frmBankReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 548);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.dgvBankDeposite);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmBankReport";
            this.Load += new System.EventHandler(this.frmBankReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBankReport_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankDeposite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFrmDate;
        private System.Windows.Forms.DateTimePicker dtpTodate;
        private System.Windows.Forms.DateTimePicker dtpfrmDate;
        private System.Windows.Forms.Button btneExcelReport;
        private System.Windows.Forms.DataGridView dgvBankDeposite;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn naration;
        private System.Windows.Forms.DataGridViewTextBoxColumn drAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn crAmount;
        private System.Windows.Forms.Label lblHerader;
    }
}