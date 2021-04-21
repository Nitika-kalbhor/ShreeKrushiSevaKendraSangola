namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmItemLegderReport
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
            this.lblItemType = new System.Windows.Forms.Label();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGodown = new System.Windows.Forms.Label();
            this.dtpfromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbOrgnation = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cnkSummery = new System.Windows.Forms.CheckBox();
            this.metroButton3 = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
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
            this.gbsarch.Controls.Add(this.lblDate);
            this.gbsarch.Controls.Add(this.dtpDate);
            this.gbsarch.Controls.Add(this.cnkSummery);
            this.gbsarch.Controls.Add(this.metroButton3);
            this.gbsarch.Controls.Add(this.btnExport);
            this.gbsarch.Controls.Add(this.btnPrint);
            this.gbsarch.Controls.Add(this.btnShow);
            this.gbsarch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbsarch.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsarch.Location = new System.Drawing.Point(20, 60);
            this.gbsarch.Name = "gbsarch";
            this.gbsarch.Size = new System.Drawing.Size(1197, 115);
            this.gbsarch.TabIndex = 33;
            this.gbsarch.TabStop = false;
            // 
            // pnlItemLeger
            // 
            this.pnlItemLeger.Controls.Add(this.lblItemType);
            this.pnlItemLeger.Controls.Add(this.cmbItemType);
            this.pnlItemLeger.Controls.Add(this.cmbItemName);
            this.pnlItemLeger.Controls.Add(this.lblItemName);
            this.pnlItemLeger.Controls.Add(this.dtpToDate);
            this.pnlItemLeger.Controls.Add(this.label1);
            this.pnlItemLeger.Controls.Add(this.lblGodown);
            this.pnlItemLeger.Controls.Add(this.dtpfromDate);
            this.pnlItemLeger.Controls.Add(this.cmbOrgnation);
            this.pnlItemLeger.Controls.Add(this.metroLabel1);
            this.pnlItemLeger.Location = new System.Drawing.Point(6, 14);
            this.pnlItemLeger.Name = "pnlItemLeger";
            this.pnlItemLeger.Size = new System.Drawing.Size(558, 95);
            this.pnlItemLeger.TabIndex = 349;
            // 
            // lblItemType
            // 
            this.lblItemType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(177, 4);
            this.lblItemType.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(82, 20);
            this.lblItemType.TabIndex = 234;
            this.lblItemType.Text = "वस्तूचा प्रकार";
            // 
            // cmbItemType
            // 
            this.cmbItemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbItemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.ItemHeight = 20;
            this.cmbItemType.Location = new System.Drawing.Point(181, 30);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(142, 28);
            this.cmbItemType.TabIndex = 246;
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.cmbItemType_SelectedIndexChanged);
            // 
            // cmbItemName
            // 
            this.cmbItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.ItemHeight = 20;
            this.cmbItemName.Location = new System.Drawing.Point(324, 30);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(167, 28);
            this.cmbItemName.TabIndex = 247;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(354, 4);
            this.lblItemName.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(70, 20);
            this.lblItemName.TabIndex = 249;
            this.lblItemName.Text = "वस्तूचे नाव";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(310, 64);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(122, 26);
            this.dtpToDate.TabIndex = 345;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 344;
            this.label1.Text = "ते दिनांक :";
            // 
            // lblGodown
            // 
            this.lblGodown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGodown.AutoSize = true;
            this.lblGodown.Location = new System.Drawing.Point(62, 4);
            this.lblGodown.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblGodown.Name = "lblGodown";
            this.lblGodown.Size = new System.Drawing.Size(60, 20);
            this.lblGodown.TabIndex = 246;
            this.lblGodown.Text = "कंपनी";
            // 
            // dtpfromDate
            // 
            this.dtpfromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpfromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfromDate.Location = new System.Drawing.Point(109, 64);
            this.dtpfromDate.Name = "dtpfromDate";
            this.dtpfromDate.Size = new System.Drawing.Size(122, 26);
            this.dtpfromDate.TabIndex = 343;
            // 
            // cmbOrgnation
            // 
            this.cmbOrgnation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOrgnation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOrgnation.FormattingEnabled = true;
            this.cmbOrgnation.ItemHeight = 20;
            this.cmbOrgnation.Location = new System.Drawing.Point(11, 30);
            this.cmbOrgnation.Name = "cmbOrgnation";
            this.cmbOrgnation.Size = new System.Drawing.Size(164, 28);
            this.cmbOrgnation.TabIndex = 247;
            this.cmbOrgnation.SelectedIndexChanged += new System.EventHandler(this.cmbOrgnation_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 20);
            this.metroLabel1.TabIndex = 342;
            this.metroLabel1.Text = "पासून दिनांक :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(598, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 20);
            this.lblDate.TabIndex = 348;
            this.lblDate.Text = "दिनांक :";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(662, 46);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(122, 26);
            this.dtpDate.TabIndex = 347;
            // 
            // cnkSummery
            // 
            this.cnkSummery.AutoSize = true;
            this.cnkSummery.Location = new System.Drawing.Point(662, 18);
            this.cnkSummery.Name = "cnkSummery";
            this.cnkSummery.Size = new System.Drawing.Size(115, 24);
            this.cnkSummery.TabIndex = 346;
            this.cnkSummery.Text = "एकूण साठा नोंद";
            this.cnkSummery.UseVisualStyleBackColor = true;
            this.cnkSummery.CheckedChanged += new System.EventHandler(this.cnkSummery_CheckedChanged);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.metroButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton3.ForeColor = System.Drawing.Color.Black;
            this.metroButton3.Location = new System.Drawing.Point(846, 78);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 31);
            this.metroButton3.TabIndex = 254;
            this.metroButton3.Text = "पुसा";
            this.metroButton3.UseVisualStyleBackColor = false;
            this.metroButton3.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(678, 78);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 31);
            this.btnExport.TabIndex = 253;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(759, 78);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(81, 31);
            this.btnPrint.TabIndex = 252;
            this.btnPrint.Text = "प्रिंट";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(586, 78);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 31);
            this.btnShow.TabIndex = 251;
            this.btnShow.Text = "दाखवा";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStockRegister);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(20, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1197, 396);
            this.groupBox2.TabIndex = 34;
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
            this.dgvStockRegister.Size = new System.Drawing.Size(1191, 377);
            this.dgvStockRegister.TabIndex = 2;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(20, 21);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(192, 36);
            this.lblHerader.TabIndex = 436;
            this.lblHerader.Text = "वस्तू लेजर रिपोर्ट ";
            // 
            // frmItemLegderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 591);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbsarch);
            this.KeyPreview = true;
            this.Name = "frmItemLegderReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmItemLegderReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmItemLegderReport_KeyDown);
            this.gbsarch.ResumeLayout(false);
            this.gbsarch.PerformLayout();
            this.pnlItemLeger.ResumeLayout(false);
            this.pnlItemLeger.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbsarch;
        private System.Windows.Forms.ComboBox cmbOrgnation;
        private System.Windows.Forms.Button metroButton3;
        private System.Windows.Forms.Label lblGodown;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvStockRegister;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpfromDate;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox cnkSummery;
        private System.Windows.Forms.Panel pnlItemLeger;
        private System.Windows.Forms.Label lblHerader;
    }
}