namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmNotificationReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewnotification = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btneExcelReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvNotification = new System.Windows.Forms.DataGridView();
            this.accountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 10);
            this.panel1.TabIndex = 100;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNewnotification);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dtpFrom);
            this.panel3.Controls.Add(this.dtpTo);
            this.panel3.Controls.Add(this.btnShow);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btneExcelReport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(908, 67);
            this.panel3.TabIndex = 102;
            // 
            // btnNewnotification
            // 
            this.btnNewnotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnNewnotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnNewnotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewnotification.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold);
            this.btnNewnotification.ForeColor = System.Drawing.Color.White;
            this.btnNewnotification.Location = new System.Drawing.Point(774, 16);
            this.btnNewnotification.Name = "btnNewnotification";
            this.btnNewnotification.Size = new System.Drawing.Size(131, 35);
            this.btnNewnotification.TabIndex = 120;
            this.btnNewnotification.Text = "पुढील वायदा";
            this.btnNewnotification.UseVisualStyleBackColor = false;
            this.btnNewnotification.Click += new System.EventHandler(this.BtnNewnotification_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(248, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 119;
            this.label1.Text = "या दिनांक पर्यंत";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(101, 22);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(141, 29);
            this.dtpFrom.TabIndex = 118;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(351, 22);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(141, 29);
            this.dtpTo.TabIndex = 117;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(510, 16);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(113, 35);
            this.btnShow.TabIndex = 116;
            this.btnShow.Text = "शो";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(3, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 115;
            this.label10.Text = "या दिनांक पासून";
            // 
            // btneExcelReport
            // 
            this.btneExcelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btneExcelReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btneExcelReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneExcelReport.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold);
            this.btneExcelReport.ForeColor = System.Drawing.Color.White;
            this.btneExcelReport.Location = new System.Drawing.Point(629, 16);
            this.btneExcelReport.Name = "btneExcelReport";
            this.btneExcelReport.Size = new System.Drawing.Size(139, 35);
            this.btneExcelReport.TabIndex = 114;
            this.btneExcelReport.Text = "एक्सेल रिपोर्ट";
            this.btneExcelReport.UseVisualStyleBackColor = false;
            this.btneExcelReport.Click += new System.EventHandler(this.btneExcelReport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvNotification);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(20, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 375);
            this.panel2.TabIndex = 103;
            // 
            // DgvNotification
            // 
            this.DgvNotification.AllowUserToAddRows = false;
            this.DgvNotification.AllowUserToDeleteRows = false;
            this.DgvNotification.AllowUserToResizeColumns = false;
            this.DgvNotification.AllowUserToResizeRows = false;
            this.DgvNotification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvNotification.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvNotification.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNotification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountID,
            this.accountName,
            this.address,
            this.mobileNo,
            this.cr,
            this.dr});
            this.DgvNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvNotification.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvNotification.EnableHeadersVisualStyles = false;
            this.DgvNotification.GridColor = System.Drawing.Color.Black;
            this.DgvNotification.Location = new System.Drawing.Point(0, 0);
            this.DgvNotification.Name = "DgvNotification";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvNotification.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvNotification.RowHeadersVisible = false;
            this.DgvNotification.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvNotification.Size = new System.Drawing.Size(908, 375);
            this.DgvNotification.TabIndex = 0;
            // 
            // accountID
            // 
            this.accountID.DataPropertyName = "accountID";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.accountID.DefaultCellStyle = dataGridViewCellStyle2;
            this.accountID.HeaderText = "accountID";
            this.accountID.Name = "accountID";
            this.accountID.Visible = false;
            this.accountID.Width = 89;
            // 
            // accountName
            // 
            this.accountName.DataPropertyName = "accountName";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.accountName.DefaultCellStyle = dataGridViewCellStyle3;
            this.accountName.HeaderText = "खाते नाव";
            this.accountName.Name = "accountName";
            this.accountName.Width = 88;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.address.DefaultCellStyle = dataGridViewCellStyle4;
            this.address.HeaderText = "पत्ता ";
            this.address.Name = "address";
            this.address.Width = 64;
            // 
            // mobileNo
            // 
            this.mobileNo.DataPropertyName = "mobileNo";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.mobileNo.DefaultCellStyle = dataGridViewCellStyle5;
            this.mobileNo.HeaderText = "मोबाईल नं";
            this.mobileNo.Name = "mobileNo";
            this.mobileNo.Width = 97;
            // 
            // cr
            // 
            this.cr.DataPropertyName = "cr";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.cr.DefaultCellStyle = dataGridViewCellStyle6;
            this.cr.HeaderText = "येणे बाकी ";
            this.cr.Name = "cr";
            this.cr.Width = 94;
            // 
            // dr
            // 
            this.dr.DataPropertyName = "dr";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dr.DefaultCellStyle = dataGridViewCellStyle7;
            this.dr.HeaderText = "देणे बाकी ";
            this.dr.Name = "dr";
            this.dr.Width = 93;
            // 
            // frmNotificationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmNotificationReport";
            this.Text = "उधारी  जमा सूचना ";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmNotificationReport_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNotification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView DgvNotification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btneExcelReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dr;
        private System.Windows.Forms.Button btnNewnotification;
    }
}