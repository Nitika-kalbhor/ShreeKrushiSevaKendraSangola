namespace Dlogic_Wholesaler.ReportFrom_
{
    partial class frmCashBookReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvCashBook = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbsarch = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHerader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashBook)).BeginInit();
            this.gbsarch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(68, 35);
            this.metroLabel1.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 23);
            this.metroLabel1.TabIndex = 232;
            this.metroLabel1.Text = "दिनांक :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(133, 31);
            this.dtpDate.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(184, 30);
            this.dtpDate.TabIndex = 231;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(442, 29);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(81, 31);
            this.btnPrint.TabIndex = 254;
            this.btnPrint.Text = "प्रिंट";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(348, 29);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 31);
            this.btnShow.TabIndex = 253;
            this.btnShow.Text = "दाखवा";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvCashBook
            // 
            this.dgvCashBook.AllowUserToAddRows = false;
            this.dgvCashBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCashBook.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCashBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCashBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCashBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCashBook.GridColor = System.Drawing.Color.Black;
            this.dgvCashBook.Location = new System.Drawing.Point(0, 0);
            this.dgvCashBook.Name = "dgvCashBook";
            this.dgvCashBook.RowHeadersVisible = false;
            this.dgvCashBook.RowTemplate.Height = 26;
            this.dgvCashBook.Size = new System.Drawing.Size(1050, 376);
            this.dgvCashBook.TabIndex = 255;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 10);
            this.panel1.TabIndex = 256;
            // 
            // gbsarch
            // 
            this.gbsarch.Controls.Add(this.dtpDate);
            this.gbsarch.Controls.Add(this.metroLabel1);
            this.gbsarch.Controls.Add(this.btnShow);
            this.gbsarch.Controls.Add(this.btnPrint);
            this.gbsarch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbsarch.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsarch.Location = new System.Drawing.Point(20, 70);
            this.gbsarch.Name = "gbsarch";
            this.gbsarch.Size = new System.Drawing.Size(1050, 95);
            this.gbsarch.TabIndex = 257;
            this.gbsarch.TabStop = false;
            this.gbsarch.Text = "शोधा";
            this.gbsarch.Enter += new System.EventHandler(this.gbsarch_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCashBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 376);
            this.panel2.TabIndex = 258;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(23, 14);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(146, 33);
            this.lblHerader.TabIndex = 359;
            this.lblHerader.Text = "रोजमेळ रिपोर्ट";
            // 
            // frmCashBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 561);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbsarch);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmCashBookReport";
            this.Load += new System.EventHandler(this.frmCashBookReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCashBookReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashBook)).EndInit();
            this.gbsarch.ResumeLayout(false);
            this.gbsarch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvCashBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbsarch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHerader;
    }
}