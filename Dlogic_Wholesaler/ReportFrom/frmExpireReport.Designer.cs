namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmExpireReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btneExcelReport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvExpireReport = new System.Windows.Forms.DataGridView();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rackNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpireReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 10);
            this.panel1.TabIndex = 104;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btneExcelReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1227, 81);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(336, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "या दिनांक पर्यंत";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(158, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(141, 29);
            this.dtpFrom.TabIndex = 112;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(446, 28);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(141, 29);
            this.dtpTo.TabIndex = 111;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(623, 22);
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
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(39, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "या दिनांक पासून";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btneExcelReport
            // 
            this.btneExcelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btneExcelReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btneExcelReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneExcelReport.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold);
            this.btneExcelReport.ForeColor = System.Drawing.Color.White;
            this.btneExcelReport.Location = new System.Drawing.Point(752, 22);
            this.btneExcelReport.Name = "btneExcelReport";
            this.btneExcelReport.Size = new System.Drawing.Size(139, 35);
            this.btneExcelReport.TabIndex = 28;
            this.btneExcelReport.Text = "एक्सेल रिपोर्ट";
            this.btneExcelReport.UseVisualStyleBackColor = false;
            this.btneExcelReport.Click += new System.EventHandler(this.btneExcelReport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvExpireReport);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1227, 407);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            // 
            // dgvExpireReport
            // 
            this.dgvExpireReport.AllowUserToAddRows = false;
            this.dgvExpireReport.AllowUserToDeleteRows = false;
            this.dgvExpireReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpireReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpireReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpireReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpireReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryName,
            this.companyName,
            this.itemName,
            this.unitBy,
            this.batchNo,
            this.expireDate,
            this.currentStock,
            this.rackNo});
            this.dgvExpireReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpireReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvExpireReport.EnableHeadersVisualStyles = false;
            this.dgvExpireReport.GridColor = System.Drawing.Color.Black;
            this.dgvExpireReport.Location = new System.Drawing.Point(3, 25);
            this.dgvExpireReport.Name = "dgvExpireReport";
            this.dgvExpireReport.RowHeadersVisible = false;
            this.dgvExpireReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpireReport.Size = new System.Drawing.Size(1221, 379);
            this.dgvExpireReport.TabIndex = 84;
            // 
            // categoryName
            // 
            this.categoryName.DataPropertyName = "categoryName";
            this.categoryName.HeaderText = "प्रकार ";
            this.categoryName.Name = "categoryName";
            // 
            // companyName
            // 
            this.companyName.DataPropertyName = "companyName";
            this.companyName.HeaderText = "कंपनी";
            this.companyName.Name = "companyName";
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "वस्तूचे नाव";
            this.itemName.Name = "itemName";
            this.itemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // unitBy
            // 
            this.unitBy.DataPropertyName = "unitBy";
            this.unitBy.HeaderText = "पॅकिंग";
            this.unitBy.Name = "unitBy";
            // 
            // batchNo
            // 
            this.batchNo.DataPropertyName = "batchNo";
            this.batchNo.HeaderText = "बॅच नं";
            this.batchNo.Name = "batchNo";
            this.batchNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.batchNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // expireDate
            // 
            this.expireDate.DataPropertyName = "expireDate";
            this.expireDate.HeaderText = "एक्स दिनांक ";
            this.expireDate.Name = "expireDate";
            this.expireDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.expireDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // currentStock
            // 
            this.currentStock.DataPropertyName = "currentStock";
            this.currentStock.HeaderText = "शिल्लक नग";
            this.currentStock.Name = "currentStock";
            this.currentStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.currentStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rackNo
            // 
            this.rackNo.DataPropertyName = "rackNo";
            this.rackNo.HeaderText = "रॅक नं";
            this.rackNo.Name = "rackNo";
            this.rackNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rackNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(504, 9);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(193, 36);
            this.lblHerader.TabIndex = 432;
            this.lblHerader.Text = "एक्सपायरी रिपोर्ट";
            // 
            // frmExpireReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 578);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmExpireReport";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmExpireReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmExpireReport_KeyDown_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpireReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btneExcelReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvExpireReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn rackNo;
        private System.Windows.Forms.Label lblHerader;
    }
}