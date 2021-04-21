namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmAccountLedgerByArea
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
            this.btnSms = new System.Windows.Forms.Button();
            this.btnExcelReport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.cmbVillageArea = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccountLedger = new System.Windows.Forms.DataGridView();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1037, 10);
            this.panel1.TabIndex = 101;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSms);
            this.groupBox1.Controls.Add(this.btnExcelReport);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.cmbVillageArea);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 77);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            // 
            // btnSms
            // 
            this.btnSms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnSms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSms.ForeColor = System.Drawing.Color.Black;
            this.btnSms.Location = new System.Drawing.Point(877, 26);
            this.btnSms.Name = "btnSms";
            this.btnSms.Size = new System.Drawing.Size(100, 29);
            this.btnSms.TabIndex = 394;
            this.btnSms.Text = "SMS";
            this.btnSms.UseVisualStyleBackColor = false;
            this.btnSms.Visible = false;
            this.btnSms.Click += new System.EventHandler(this.btnSms_Click);
            // 
            // btnExcelReport
            // 
            this.btnExcelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnExcelReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelReport.ForeColor = System.Drawing.Color.Black;
            this.btnExcelReport.Location = new System.Drawing.Point(693, 26);
            this.btnExcelReport.Name = "btnExcelReport";
            this.btnExcelReport.Size = new System.Drawing.Size(159, 29);
            this.btnExcelReport.TabIndex = 393;
            this.btnExcelReport.Text = "Excel Report";
            this.btnExcelReport.UseVisualStyleBackColor = false;
            this.btnExcelReport.Click += new System.EventHandler(this.btnExcelReport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(587, 26);
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
            this.btnShow.Location = new System.Drawing.Point(467, 26);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 29);
            this.btnShow.TabIndex = 389;
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
            this.metroLabel2.Location = new System.Drawing.Point(15, 31);
            this.metroLabel2.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 24);
            this.metroLabel2.TabIndex = 149;
            this.metroLabel2.Text = "गावाचे नाव :";
            // 
            // cmbVillageArea
            // 
            this.cmbVillageArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVillageArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVillageArea.BackColor = System.Drawing.Color.White;
            this.cmbVillageArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVillageArea.ForeColor = System.Drawing.Color.Black;
            this.cmbVillageArea.FormattingEnabled = true;
            this.cmbVillageArea.Location = new System.Drawing.Point(157, 27);
            this.cmbVillageArea.Name = "cmbVillageArea";
            this.cmbVillageArea.Size = new System.Drawing.Size(267, 32);
            this.cmbVillageArea.TabIndex = 0;
            this.cmbVillageArea.SelectedIndexChanged += new System.EventHandler(this.cmbVillageArea_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAccountLedger);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.groupBox2.Location = new System.Drawing.Point(20, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 436);
            this.groupBox2.TabIndex = 103;
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
            this.dgvAccountLedger.Size = new System.Drawing.Size(1031, 406);
            this.dgvAccountLedger.TabIndex = 0;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(342, 15);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(241, 33);
            this.lblHerader.TabIndex = 361;
            this.lblHerader.Text = " गावानुसार  खाते  उधारी";
            // 
            // frmAccountLedgerByArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 603);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmAccountLedgerByArea";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmAccountLedgerByArea_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccountLedgerByArea_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountLedger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.ComboBox cmbVillageArea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAccountLedger;
        private System.Windows.Forms.Button btnExcelReport;
        private System.Windows.Forms.Button btnSms;
        private System.Windows.Forms.Label lblHerader;
    }
}