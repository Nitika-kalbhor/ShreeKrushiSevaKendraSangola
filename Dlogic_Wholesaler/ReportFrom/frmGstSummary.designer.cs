namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmGstSummary
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
            this.cmbMainCategory = new System.Windows.Forms.ComboBox();
            this.pGSTSUMMARY = new System.Windows.Forms.Panel();
            this.dgvGST = new System.Windows.Forms.DataGridView();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutPutGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.metroLabel3 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.chGst = new System.Windows.Forms.CheckBox();
            this.pCategory = new System.Windows.Forms.Panel();
            this.pbar = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.mainCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputGST5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputGST12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputGST18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputGST28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GST5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GST12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GST18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GST28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.pGSTSUMMARY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGST)).BeginInit();
            this.pCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 10);
            this.panel1.TabIndex = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMainCategory);
            this.groupBox1.Controls.Add(this.pGSTSUMMARY);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.chGst);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1191, 177);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            // 
            // cmbMainCategory
            // 
            this.cmbMainCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMainCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMainCategory.BackColor = System.Drawing.Color.White;
            this.cmbMainCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMainCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbMainCategory.FormattingEnabled = true;
            this.cmbMainCategory.IntegralHeight = false;
            this.cmbMainCategory.Items.AddRange(new object[] {
            "--निवडा--",
            "खते",
            "किटकनाशके",
            "बियाणे",
            "PGR",
            "इतर"});
            this.cmbMainCategory.Location = new System.Drawing.Point(702, 59);
            this.cmbMainCategory.Name = "cmbMainCategory";
            this.cmbMainCategory.Size = new System.Drawing.Size(210, 32);
            this.cmbMainCategory.TabIndex = 395;
            // 
            // pGSTSUMMARY
            // 
            this.pGSTSUMMARY.Controls.Add(this.dgvGST);
            this.pGSTSUMMARY.Dock = System.Windows.Forms.DockStyle.Left;
            this.pGSTSUMMARY.Font = new System.Drawing.Font("Arial Unicode MS", 10F);
            this.pGSTSUMMARY.Location = new System.Drawing.Point(3, 27);
            this.pGSTSUMMARY.Name = "pGSTSUMMARY";
            this.pGSTSUMMARY.Size = new System.Drawing.Size(556, 147);
            this.pGSTSUMMARY.TabIndex = 104;
            // 
            // dgvGST
            // 
            this.dgvGST.AllowUserToAddRows = false;
            this.dgvGST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGST.BackgroundColor = System.Drawing.Color.White;
            this.dgvGST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.total,
            this.IGST,
            this.InputGST,
            this.OutPutGST,
            this.balanceGST});
            this.dgvGST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGST.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGST.GridColor = System.Drawing.Color.Black;
            this.dgvGST.Location = new System.Drawing.Point(0, 0);
            this.dgvGST.Name = "dgvGST";
            this.dgvGST.RowHeadersVisible = false;
            this.dgvGST.Size = new System.Drawing.Size(556, 147);
            this.dgvGST.TabIndex = 0;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "";
            this.total.Name = "total";
            this.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.total.Width = 5;
            // 
            // IGST
            // 
            this.IGST.DataPropertyName = "IGST";
            this.IGST.HeaderText = "GST Rate %";
            this.IGST.Name = "IGST";
            this.IGST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IGST.Width = 94;
            // 
            // InputGST
            // 
            this.InputGST.DataPropertyName = "InputGST";
            this.InputGST.HeaderText = "Input GST खरेदी";
            this.InputGST.Name = "InputGST";
            this.InputGST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.InputGST.Width = 111;
            // 
            // OutPutGST
            // 
            this.OutPutGST.DataPropertyName = "OutPutGST";
            this.OutPutGST.HeaderText = "OutPut GST सेल";
            this.OutPutGST.Name = "OutPutGST";
            this.OutPutGST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OutPutGST.Width = 115;
            // 
            // balanceGST
            // 
            this.balanceGST.DataPropertyName = "balanceGST";
            this.balanceGST.HeaderText = "बाकी GST";
            this.balanceGST.Name = "balanceGST";
            this.balanceGST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.balanceGST.Width = 73;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(967, 120);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 35);
            this.btnExcel.TabIndex = 394;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(861, 119);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 37);
            this.btnShow.TabIndex = 389;
            this.btnShow.Text = "दाखवा";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 396;
            this.label5.Text = "प्रकारचे नांव";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(574, 133);
            this.metroLabel3.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(122, 24);
            this.metroLabel3.TabIndex = 153;
            this.metroLabel3.Text = "या तारखे परंत :-";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(702, 102);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(130, 29);
            this.dtpFromDate.TabIndex = 150;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(1073, 120);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 35);
            this.btnPrint.TabIndex = 392;
            this.btnPrint.Text = "प्रिंट";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(702, 136);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(130, 29);
            this.dtpToDate.TabIndex = 151;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(565, 99);
            this.metroLabel1.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 24);
            this.metroLabel1.TabIndex = 152;
            this.metroLabel1.Text = "या तारखे पासून :-";
            // 
            // chGst
            // 
            this.chGst.AutoSize = true;
            this.chGst.Location = new System.Drawing.Point(702, 24);
            this.chGst.Name = "chGst";
            this.chGst.Size = new System.Drawing.Size(148, 28);
            this.chGst.TabIndex = 393;
            this.chGst.Text = "GST Summary";
            this.chGst.UseVisualStyleBackColor = true;
            this.chGst.CheckedChanged += new System.EventHandler(this.chGst_CheckedChanged);
            // 
            // pCategory
            // 
            this.pCategory.Controls.Add(this.pbar);
            this.pCategory.Controls.Add(this.dgvCategory);
            this.pCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCategory.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.pCategory.Location = new System.Drawing.Point(20, 247);
            this.pCategory.Name = "pCategory";
            this.pCategory.Size = new System.Drawing.Size(1191, 297);
            this.pCategory.TabIndex = 105;
            // 
            // pbar
            // 
            this.pbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbar.Font = new System.Drawing.Font("Arial Unicode MS", 15F, System.Drawing.FontStyle.Bold);
            this.pbar.ForeColor = System.Drawing.Color.Red;
            this.pbar.Location = new System.Drawing.Point(0, 271);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(1191, 26);
            this.pbar.TabIndex = 2;
            this.pbar.Text = "Loading.............";
            this.pbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToOrderColumns = true;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mainCategory,
            this.itemName,
            this.inputGST5,
            this.inputGST12,
            this.inputGST18,
            this.inputGST28,
            this.GST5,
            this.GST12,
            this.GST18,
            this.GST28});
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategory.GridColor = System.Drawing.Color.Black;
            this.dgvCategory.Location = new System.Drawing.Point(0, 0);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.Size = new System.Drawing.Size(1191, 297);
            this.dgvCategory.TabIndex = 1;
            // 
            // mainCategory
            // 
            this.mainCategory.DataPropertyName = "mainCategory";
            this.mainCategory.HeaderText = "प्रकारचे नांव";
            this.mainCategory.Name = "mainCategory";
            this.mainCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mainCategory.Width = 82;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "वस्तूचे नांव";
            this.itemName.Name = "itemName";
            this.itemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.itemName.Width = 76;
            // 
            // inputGST5
            // 
            this.inputGST5.DataPropertyName = "inputGST5";
            this.inputGST5.HeaderText = "IGST खरेदी 5%";
            this.inputGST5.Name = "inputGST5";
            this.inputGST5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.inputGST5.Width = 109;
            // 
            // inputGST12
            // 
            this.inputGST12.DataPropertyName = "inputGST12";
            this.inputGST12.HeaderText = "IGST खरेदी 12%";
            this.inputGST12.Name = "inputGST12";
            this.inputGST12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.inputGST12.Width = 117;
            // 
            // inputGST18
            // 
            this.inputGST18.DataPropertyName = "inputGST18";
            this.inputGST18.HeaderText = "IGST खरेदी 18%";
            this.inputGST18.Name = "inputGST18";
            this.inputGST18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.inputGST18.Width = 117;
            // 
            // inputGST28
            // 
            this.inputGST28.DataPropertyName = "inputGST28";
            this.inputGST28.HeaderText = "IGST खरेदी 28%";
            this.inputGST28.Name = "inputGST28";
            this.inputGST28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.inputGST28.Width = 117;
            // 
            // GST5
            // 
            this.GST5.DataPropertyName = "GST5";
            this.GST5.HeaderText = "IGST सेल 5 %";
            this.GST5.Name = "GST5";
            this.GST5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GST5.Width = 102;
            // 
            // GST12
            // 
            this.GST12.DataPropertyName = "GST12";
            this.GST12.HeaderText = "IGST सेल 12 %";
            this.GST12.Name = "GST12";
            this.GST12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GST12.Width = 110;
            // 
            // GST18
            // 
            this.GST18.DataPropertyName = "GST18";
            this.GST18.HeaderText = "IGST सेल18 %";
            this.GST18.Name = "GST18";
            this.GST18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GST18.Width = 106;
            // 
            // GST28
            // 
            this.GST28.DataPropertyName = "GST28";
            this.GST28.HeaderText = "IGST  सेल 28 %";
            this.GST28.Name = "GST28";
            this.GST28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GST28.Width = 114;
            // 
            // frmGstSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 564);
            this.Controls.Add(this.pCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmGstSummary";
            this.Text = "GST Summary  रिपोर्ट ";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGstSummary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pGSTSUMMARY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGST)).EndInit();
            this.pCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMainCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label metroLabel3;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Panel pGSTSUMMARY;
        private System.Windows.Forms.Panel pCategory;
        private System.Windows.Forms.CheckBox chGst;
        private System.Windows.Forms.DataGridView dgvGST;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutPutGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputGST5;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputGST12;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputGST18;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputGST28;
        private System.Windows.Forms.DataGridViewTextBoxColumn GST5;
        private System.Windows.Forms.DataGridViewTextBoxColumn GST12;
        private System.Windows.Forms.DataGridViewTextBoxColumn GST18;
        private System.Windows.Forms.DataGridViewTextBoxColumn GST28;
        private System.Windows.Forms.Label pbar;
    }
}