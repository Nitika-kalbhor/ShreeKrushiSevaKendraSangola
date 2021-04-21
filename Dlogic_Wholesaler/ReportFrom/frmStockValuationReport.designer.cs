namespace Dlogic_Wholesaler.ReportFroms
{
    partial class frmStockValuationReport
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
            this.cmbMainCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.metroButton2 = new System.Windows.Forms.Button();
            this.metroButton1 = new System.Windows.Forms.Button();
            this.metroButton3 = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.cmbOrgnation = new System.Windows.Forms.ComboBox();
            this.lblGodown = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.dgvStockRegister = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHerader = new System.Windows.Forms.Label();
            this.gbsarch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRegister)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbsarch
            // 
            this.gbsarch.Controls.Add(this.cmbMainCategory);
            this.gbsarch.Controls.Add(this.label5);
            this.gbsarch.Controls.Add(this.metroButton2);
            this.gbsarch.Controls.Add(this.metroButton1);
            this.gbsarch.Controls.Add(this.metroButton3);
            this.gbsarch.Controls.Add(this.btnShow);
            this.gbsarch.Controls.Add(this.lblItemName);
            this.gbsarch.Controls.Add(this.cmbItemName);
            this.gbsarch.Controls.Add(this.cmbItemType);
            this.gbsarch.Controls.Add(this.cmbOrgnation);
            this.gbsarch.Controls.Add(this.lblGodown);
            this.gbsarch.Controls.Add(this.lblItemType);
            this.gbsarch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbsarch.Font = new System.Drawing.Font("Arial Unicode MS", 13F);
            this.gbsarch.Location = new System.Drawing.Point(20, 60);
            this.gbsarch.Name = "gbsarch";
            this.gbsarch.Size = new System.Drawing.Size(1177, 96);
            this.gbsarch.TabIndex = 31;
            this.gbsarch.TabStop = false;
            this.gbsarch.Text = "शोधा";
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
            "सर्व",
            "खते",
            "किटकनाशके",
            "बियाणे",
            "PGR"});
            this.cmbMainCategory.Location = new System.Drawing.Point(6, 52);
            this.cmbMainCategory.Name = "cmbMainCategory";
            this.cmbMainCategory.Size = new System.Drawing.Size(186, 33);
            this.cmbMainCategory.TabIndex = 336;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 25);
            this.label5.MinimumSize = new System.Drawing.Size(60, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 337;
            this.label5.Text = "प्रकारचे नाव";
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.metroButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton2.Location = new System.Drawing.Point(1025, 47);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(87, 42);
            this.metroButton2.TabIndex = 253;
            this.metroButton2.Text = "Export";
            this.metroButton2.UseVisualStyleBackColor = false;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.metroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton1.Location = new System.Drawing.Point(938, 47);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(81, 42);
            this.metroButton1.TabIndex = 252;
            this.metroButton1.Text = "प्रिंट";
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.metroButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton3.ForeColor = System.Drawing.Color.Black;
            this.metroButton3.Location = new System.Drawing.Point(828, 47);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(81, 42);
            this.metroButton3.TabIndex = 254;
            this.metroButton3.Text = "दाखवा 1";
            this.metroButton3.UseVisualStyleBackColor = false;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(747, 47);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 42);
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
            this.lblItemName.Location = new System.Drawing.Point(583, 27);
            this.lblItemName.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(85, 24);
            this.lblItemName.TabIndex = 249;
            this.lblItemName.Text = "वस्तूचे नाव";
            // 
            // cmbItemName
            // 
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.ItemHeight = 23;
            this.cmbItemName.Location = new System.Drawing.Point(557, 54);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(167, 31);
            this.cmbItemName.TabIndex = 247;
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.ItemHeight = 23;
            this.cmbItemType.Location = new System.Drawing.Point(381, 54);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(170, 31);
            this.cmbItemType.TabIndex = 246;
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.cmbItemType_SelectedIndexChanged);
            // 
            // cmbOrgnation
            // 
            this.cmbOrgnation.FormattingEnabled = true;
            this.cmbOrgnation.ItemHeight = 23;
            this.cmbOrgnation.Location = new System.Drawing.Point(203, 54);
            this.cmbOrgnation.Name = "cmbOrgnation";
            this.cmbOrgnation.Size = new System.Drawing.Size(172, 31);
            this.cmbOrgnation.TabIndex = 245;
            this.cmbOrgnation.SelectedIndexChanged += new System.EventHandler(this.cmbOrgnation_SelectedIndexChanged);
            // 
            // lblGodown
            // 
            this.lblGodown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGodown.AutoSize = true;
            this.lblGodown.Location = new System.Drawing.Point(245, 27);
            this.lblGodown.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblGodown.Name = "lblGodown";
            this.lblGodown.Size = new System.Drawing.Size(60, 24);
            this.lblGodown.TabIndex = 225;
            this.lblGodown.Text = "कंपनी";
            // 
            // lblItemType
            // 
            this.lblItemType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(403, 27);
            this.lblItemType.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(100, 24);
            this.lblItemType.TabIndex = 234;
            this.lblItemType.Text = "वस्तूचा प्रकार";
            // 
            // dgvStockRegister
            // 
            this.dgvStockRegister.AllowUserToAddRows = false;
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
            this.dgvStockRegister.Size = new System.Drawing.Size(1171, 388);
            this.dgvStockRegister.TabIndex = 2;
            this.dgvStockRegister.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStockRegister_CellFormatting);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStockRegister);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(20, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1177, 407);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(23, 11);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(245, 36);
            this.lblHerader.TabIndex = 435;
            this.lblHerader.Text = "स्टॉक व्यालूयशन रिपोर्ट";
            // 
            // frmStockValuationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 583);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbsarch);
            this.KeyPreview = true;
            this.Name = "frmStockValuationReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStockValuationReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStockValuationReport_KeyDown);
            this.gbsarch.ResumeLayout(false);
            this.gbsarch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRegister)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbsarch;
        private System.Windows.Forms.Button metroButton3;
        private System.Windows.Forms.Button metroButton2;
        private System.Windows.Forms.Button metroButton1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.ComboBox cmbOrgnation;
        private System.Windows.Forms.Label lblGodown;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.DataGridView dgvStockRegister;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox cmbMainCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHerader;
    }
}