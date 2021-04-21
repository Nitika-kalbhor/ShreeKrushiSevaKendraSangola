namespace Dlogic_Wholesaler.ReportFrom
{
    partial class FrmStockOpeningClosingReport
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
            this.gbsarch = new System.Windows.Forms.GroupBox();
            this.pnlItemLeger = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStockRegister = new System.Windows.Forms.DataGridView();
            this.lblHerader = new System.Windows.Forms.Label();
            this.gbsarch.SuspendLayout();
            this.pnlItemLeger.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // gbsarch
            // 
            this.gbsarch.Controls.Add(this.pnlItemLeger);
            this.gbsarch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbsarch.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsarch.Location = new System.Drawing.Point(20, 60);
            this.gbsarch.Name = "gbsarch";
            this.gbsarch.Size = new System.Drawing.Size(1000, 115);
            this.gbsarch.TabIndex = 36;
            this.gbsarch.TabStop = false;
            // 
            // pnlItemLeger
            // 
            this.pnlItemLeger.Controls.Add(this.label1);
            this.pnlItemLeger.Controls.Add(this.dtpFromDate);
            this.pnlItemLeger.Controls.Add(this.btnPrint);
            this.pnlItemLeger.Controls.Add(this.lblDate);
            this.pnlItemLeger.Controls.Add(this.dtpToDate);
            this.pnlItemLeger.Controls.Add(this.btnShow);
            this.pnlItemLeger.Controls.Add(this.btnExel);
            this.pnlItemLeger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItemLeger.Location = new System.Drawing.Point(3, 24);
            this.pnlItemLeger.Name = "pnlItemLeger";
            this.pnlItemLeger.Size = new System.Drawing.Size(994, 88);
            this.pnlItemLeger.TabIndex = 349;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 351;
            this.label1.Text = "पासून दिनांक :";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(185, 30);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(122, 29);
            this.dtpFromDate.TabIndex = 350;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(798, 28);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(81, 31);
            this.btnPrint.TabIndex = 349;
            this.btnPrint.Text = "प्रिंट";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(322, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 21);
            this.lblDate.TabIndex = 348;
            this.lblDate.Text = "ते दिनांक :";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(409, 30);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(122, 29);
            this.dtpToDate.TabIndex = 347;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(557, 28);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 31);
            this.btnShow.TabIndex = 251;
            this.btnShow.Text = "दाखवा";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExel
            // 
            this.btnExel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnExel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExel.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExel.Location = new System.Drawing.Point(676, 28);
            this.btnExel.Name = "btnExel";
            this.btnExel.Size = new System.Drawing.Size(75, 31);
            this.btnExel.TabIndex = 253;
            this.btnExel.Text = "Exel";
            this.btnExel.UseVisualStyleBackColor = false;
            this.btnExel.Click += new System.EventHandler(this.btnExel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStockRegister);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(20, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 352);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // dgvStockRegister
            // 
            this.dgvStockRegister.AllowUserToAddRows = false;
            this.dgvStockRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStockRegister.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStockRegister.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockRegister.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStockRegister.GridColor = System.Drawing.Color.Black;
            this.dgvStockRegister.Location = new System.Drawing.Point(3, 16);
            this.dgvStockRegister.Name = "dgvStockRegister";
            this.dgvStockRegister.RowHeadersVisible = false;
            this.dgvStockRegister.Size = new System.Drawing.Size(994, 333);
            this.dgvStockRegister.TabIndex = 2;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(23, 9);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(352, 36);
            this.lblHerader.TabIndex = 440;
            this.lblHerader.Text = "स्टॉक आरंभी अखेर शिल्लक रिपोर्ट";
            // 
            // FrmStockOpeningClosingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 547);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbsarch);
            this.Name = "FrmStockOpeningClosingReport";
            this.gbsarch.ResumeLayout(false);
            this.pnlItemLeger.ResumeLayout(false);
            this.pnlItemLeger.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbsarch;
        private System.Windows.Forms.Panel pnlItemLeger;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvStockRegister;
        private System.Windows.Forms.Label lblHerader;
    }
}