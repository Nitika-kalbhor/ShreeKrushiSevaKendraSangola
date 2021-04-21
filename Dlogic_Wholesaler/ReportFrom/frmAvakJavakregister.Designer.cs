namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmAvakJavakregister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbsarch = new System.Windows.Forms.GroupBox();
            this.chkSummery = new System.Windows.Forms.CheckBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpfromDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.cmbMainCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOrgnation = new System.Windows.Forms.ComboBox();
            this.metroButton3 = new System.Windows.Forms.Button();
            this.lblGodown = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSummerysales = new System.Windows.Forms.DataGridView();
            this.dgvStockRegister = new System.Windows.Forms.DataGridView();
            this.lblHerader = new System.Windows.Forms.Label();
            this.gbsarch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummerysales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // gbsarch
            // 
            this.gbsarch.Controls.Add(this.chkSummery);
            this.gbsarch.Controls.Add(this.dtpToDate);
            this.gbsarch.Controls.Add(this.label1);
            this.gbsarch.Controls.Add(this.dtpfromDate);
            this.gbsarch.Controls.Add(this.metroLabel1);
            this.gbsarch.Controls.Add(this.cmbMainCategory);
            this.gbsarch.Controls.Add(this.label5);
            this.gbsarch.Controls.Add(this.cmbOrgnation);
            this.gbsarch.Controls.Add(this.metroButton3);
            this.gbsarch.Controls.Add(this.lblGodown);
            this.gbsarch.Controls.Add(this.btnExport);
            this.gbsarch.Controls.Add(this.btnPrint);
            this.gbsarch.Controls.Add(this.btnShow);
            this.gbsarch.Controls.Add(this.lblItemName);
            this.gbsarch.Controls.Add(this.cmbItemName);
            this.gbsarch.Controls.Add(this.cmbItemType);
            this.gbsarch.Controls.Add(this.lblItemType);
            this.gbsarch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbsarch.Font = new System.Drawing.Font("Arial Unicode MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsarch.Location = new System.Drawing.Point(20, 60);
            this.gbsarch.Name = "gbsarch";
            this.gbsarch.Size = new System.Drawing.Size(1103, 95);
            this.gbsarch.TabIndex = 34;
            this.gbsarch.TabStop = false;
            this.gbsarch.Text = "शोधा";
            // 
            // chkSummery
            // 
            this.chkSummery.AutoSize = true;
            this.chkSummery.Location = new System.Drawing.Point(381, 19);
            this.chkSummery.Name = "chkSummery";
            this.chkSummery.Size = new System.Drawing.Size(101, 27);
            this.chkSummery.TabIndex = 342;
            this.chkSummery.Text = "Summery";
            this.chkSummery.UseVisualStyleBackColor = true;
            this.chkSummery.CheckedChanged += new System.EventHandler(this.chkAllStock_CheckedChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(635, 53);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(122, 26);
            this.dtpToDate.TabIndex = 341;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 340;
            this.label1.Text = "ते दिनांक :";
            // 
            // dtpfromDate
            // 
            this.dtpfromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpfromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfromDate.Location = new System.Drawing.Point(635, 21);
            this.dtpfromDate.Name = "dtpfromDate";
            this.dtpfromDate.Size = new System.Drawing.Size(122, 26);
            this.dtpfromDate.TabIndex = 339;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(530, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 23);
            this.metroLabel1.TabIndex = 338;
            this.metroLabel1.Text = "पासून दिनांक :";
            // 
            // cmbMainCategory
            // 
            this.cmbMainCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMainCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMainCategory.BackColor = System.Drawing.Color.White;
            this.cmbMainCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainCategory.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMainCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbMainCategory.FormattingEnabled = true;
            this.cmbMainCategory.IntegralHeight = false;
            this.cmbMainCategory.Items.AddRange(new object[] {
            "खते",
            "किटकनाशके",
            "बियाणे",
            "PGR"});
            this.cmbMainCategory.Location = new System.Drawing.Point(163, 14);
            this.cmbMainCategory.Name = "cmbMainCategory";
            this.cmbMainCategory.Size = new System.Drawing.Size(183, 33);
            this.cmbMainCategory.TabIndex = 336;
            this.cmbMainCategory.SelectedIndexChanged += new System.EventHandler(this.cmbMainCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 19);
            this.label5.MinimumSize = new System.Drawing.Size(60, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 337;
            this.label5.Text = "प्रकारचे नाव:";
            // 
            // cmbOrgnation
            // 
            this.cmbOrgnation.FormattingEnabled = true;
            this.cmbOrgnation.ItemHeight = 23;
            this.cmbOrgnation.Location = new System.Drawing.Point(0, 48);
            this.cmbOrgnation.Name = "cmbOrgnation";
            this.cmbOrgnation.Size = new System.Drawing.Size(72, 31);
            this.cmbOrgnation.TabIndex = 247;
            this.cmbOrgnation.Text = " ";
            this.cmbOrgnation.Visible = false;
            this.cmbOrgnation.SelectedIndexChanged += new System.EventHandler(this.cmbOrgnation_SelectedIndexChanged);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.metroButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton3.ForeColor = System.Drawing.Color.Black;
            this.metroButton3.Location = new System.Drawing.Point(1022, 50);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 31);
            this.metroButton3.TabIndex = 254;
            this.metroButton3.Text = "पुसा";
            this.metroButton3.UseVisualStyleBackColor = false;
            this.metroButton3.Visible = false;
            // 
            // lblGodown
            // 
            this.lblGodown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGodown.AutoSize = true;
            this.lblGodown.Location = new System.Drawing.Point(57, 24);
            this.lblGodown.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblGodown.Name = "lblGodown";
            this.lblGodown.Size = new System.Drawing.Size(60, 23);
            this.lblGodown.TabIndex = 246;
            this.lblGodown.Text = " ";
            this.lblGodown.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(941, 50);
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
            this.btnPrint.Location = new System.Drawing.Point(854, 50);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(81, 31);
            this.btnPrint.TabIndex = 252;
            this.btnPrint.Text = "प्रिंट";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(773, 50);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 31);
            this.btnShow.TabIndex = 251;
            this.btnShow.Text = "दाखवा";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(69, 51);
            this.lblItemName.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(89, 23);
            this.lblItemName.TabIndex = 249;
            this.lblItemName.Text = "वस्तूचे नाव :";
            // 
            // cmbItemName
            // 
            this.cmbItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.ItemHeight = 23;
            this.cmbItemName.Location = new System.Drawing.Point(163, 51);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(336, 31);
            this.cmbItemName.TabIndex = 247;
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.ItemHeight = 23;
            this.cmbItemType.Location = new System.Drawing.Point(205, 51);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(170, 31);
            this.cmbItemType.TabIndex = 246;
            this.cmbItemType.Text = " ";
            this.cmbItemType.Visible = false;
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.cmbItemType_SelectedIndexChanged);
            // 
            // lblItemType
            // 
            this.lblItemType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(3, 51);
            this.lblItemType.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(60, 23);
            this.lblItemType.TabIndex = 234;
            this.lblItemType.Text = " ";
            this.lblItemType.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(20, 627);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1103, 23);
            this.progressBar1.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSummerysales);
            this.groupBox2.Controls.Add(this.dgvStockRegister);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(20, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1103, 472);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // dgvSummerysales
            // 
            this.dgvSummerysales.AllowUserToAddRows = false;
            this.dgvSummerysales.AllowUserToDeleteRows = false;
            this.dgvSummerysales.AllowUserToResizeColumns = false;
            this.dgvSummerysales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSummerysales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSummerysales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSummerysales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummerysales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSummerysales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSummerysales.GridColor = System.Drawing.Color.Black;
            this.dgvSummerysales.Location = new System.Drawing.Point(3, 16);
            this.dgvSummerysales.Name = "dgvSummerysales";
            this.dgvSummerysales.RowHeadersVisible = false;
            this.dgvSummerysales.Size = new System.Drawing.Size(1097, 453);
            this.dgvSummerysales.TabIndex = 3;
            // 
            // dgvStockRegister
            // 
            this.dgvStockRegister.AllowUserToAddRows = false;
            this.dgvStockRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStockRegister.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockRegister.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStockRegister.GridColor = System.Drawing.Color.Black;
            this.dgvStockRegister.Location = new System.Drawing.Point(3, 16);
            this.dgvStockRegister.Name = "dgvStockRegister";
            this.dgvStockRegister.RowHeadersVisible = false;
            this.dgvStockRegister.Size = new System.Drawing.Size(1097, 453);
            this.dgvStockRegister.TabIndex = 2;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(17, 21);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(349, 36);
            this.lblHerader.TabIndex = 437;
            this.lblHerader.Text = " रासायनिक खताचे विक्री रजिस्टर";
            // 
            // frmAvakJavakregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 670);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gbsarch);
            this.Name = "frmAvakJavakregister";
            this.Load += new System.EventHandler(this.frmAvakJavakregister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAvakJavakregister_KeyDown);
            this.gbsarch.ResumeLayout(false);
            this.gbsarch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummerysales)).EndInit();
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
        public System.Windows.Forms.ComboBox cmbMainCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpfromDate;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.CheckBox chkSummery;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvStockRegister;
        private System.Windows.Forms.DataGridView dgvSummerysales;
        private System.Windows.Forms.Label lblHerader;

    }
}