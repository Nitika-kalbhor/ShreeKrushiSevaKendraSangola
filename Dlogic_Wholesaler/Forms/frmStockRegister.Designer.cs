namespace Dlogic_Wholesaler.Forms
{
    partial class frmStockRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbsarch = new System.Windows.Forms.GroupBox();
            this.cmbGoDown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMainCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSumQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSreachch = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStockRegister = new System.Windows.Forms.DataGridView();
            this.lblHerader = new System.Windows.Forms.Label();
            this.gbsarch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // gbsarch
            // 
            this.gbsarch.Controls.Add(this.cmbGoDown);
            this.gbsarch.Controls.Add(this.label6);
            this.gbsarch.Controls.Add(this.cmbMainCategory);
            this.gbsarch.Controls.Add(this.label5);
            this.gbsarch.Controls.Add(this.label4);
            this.gbsarch.Controls.Add(this.txtSumQty);
            this.gbsarch.Controls.Add(this.label1);
            this.gbsarch.Controls.Add(this.txtSreachch);
            this.gbsarch.Controls.Add(this.btnExcel);
            this.gbsarch.Controls.Add(this.btnNewItem);
            this.gbsarch.Controls.Add(this.lblItemName);
            this.gbsarch.Controls.Add(this.lblBatchNo);
            this.gbsarch.Controls.Add(this.lblItemType);
            this.gbsarch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbsarch.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.gbsarch.Location = new System.Drawing.Point(20, 60);
            this.gbsarch.Name = "gbsarch";
            this.gbsarch.Size = new System.Drawing.Size(1210, 95);
            this.gbsarch.TabIndex = 31;
            this.gbsarch.TabStop = false;
            // 
            // cmbGoDown
            // 
            this.cmbGoDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGoDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGoDown.BackColor = System.Drawing.Color.White;
            this.cmbGoDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGoDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGoDown.ForeColor = System.Drawing.Color.Black;
            this.cmbGoDown.FormattingEnabled = true;
            this.cmbGoDown.IntegralHeight = false;
            this.cmbGoDown.Items.AddRange(new object[] {
            "--निवडा--",
            "खते",
            "किटकनाशके",
            "बियाणे"});
            this.cmbGoDown.Location = new System.Drawing.Point(30, 45);
            this.cmbGoDown.Name = "cmbGoDown";
            this.cmbGoDown.Size = new System.Drawing.Size(210, 32);
            this.cmbGoDown.TabIndex = 332;
            this.cmbGoDown.SelectedIndexChanged += new System.EventHandler(this.cmbGoDown_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 333;
            this.label6.Text = "गोडाउन";
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
            "PGR"});
            this.cmbMainCategory.Location = new System.Drawing.Point(256, 45);
            this.cmbMainCategory.Name = "cmbMainCategory";
            this.cmbMainCategory.Size = new System.Drawing.Size(210, 32);
            this.cmbMainCategory.TabIndex = 329;
            this.cmbMainCategory.SelectedIndexChanged += new System.EventHandler(this.cmbMainCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 331;
            this.label5.Text = "प्रकारचे नाव:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(927, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 330;
            this.label4.Text = "एकूण उपलब्ध नग :";
            // 
            // txtSumQty
            // 
            this.txtSumQty.BackColor = System.Drawing.Color.Yellow;
            this.txtSumQty.ForeColor = System.Drawing.Color.Black;
            this.txtSumQty.Location = new System.Drawing.Point(1072, 42);
            this.txtSumQty.Name = "txtSumQty";
            this.txtSumQty.Size = new System.Drawing.Size(137, 29);
            this.txtSumQty.TabIndex = 329;
            this.txtSumQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 324;
            this.label1.Text = "शोधा";
            // 
            // txtSreachch
            // 
            this.txtSreachch.Location = new System.Drawing.Point(498, 47);
            this.txtSreachch.Name = "txtSreachch";
            this.txtSreachch.Size = new System.Drawing.Size(205, 29);
            this.txtSreachch.TabIndex = 323;
            this.txtSreachch.TextChanged += new System.EventHandler(this.txtSreachch_TextChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(811, 39);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(114, 34);
            this.btnExcel.TabIndex = 322;
            this.btnExcel.Text = "एक्सेल";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnNewItem
            // 
            this.btnNewItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNewItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewItem.ForeColor = System.Drawing.Color.White;
            this.btnNewItem.Location = new System.Drawing.Point(726, 40);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(79, 34);
            this.btnNewItem.TabIndex = 318;
            this.btnNewItem.Text = "दाखवा";
            this.btnNewItem.UseVisualStyleBackColor = false;
            this.btnNewItem.Visible = false;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(872, -24);
            this.lblItemName.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(73, 21);
            this.lblItemName.TabIndex = 249;
            this.lblItemName.Text = "वस्तूचे नांव";
            this.lblItemName.Visible = false;
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.Location = new System.Drawing.Point(623, -24);
            this.lblBatchNo.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(82, 21);
            this.lblBatchNo.TabIndex = 250;
            this.lblBatchNo.Text = "कंपनीचे नांव";
            this.lblBatchNo.Visible = false;
            // 
            // lblItemType
            // 
            this.lblItemType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(441, -24);
            this.lblItemType.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(60, 21);
            this.lblItemType.TabIndex = 234;
            this.lblItemType.Text = "प्रकार";
            this.lblItemType.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(761, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 328;
            this.label3.Text = "इतर";
            this.label3.Visible = false;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(731, 39);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(150, 20);
            this.txtProductCode.TabIndex = 327;
            this.txtProductCode.Visible = false;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(918, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 326;
            this.label2.Text = "कंपनी";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(888, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 325;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbCompany
            // 
            this.cmbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCompany.BackColor = System.Drawing.Color.White;
            this.cmbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.ForeColor = System.Drawing.Color.Black;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.IntegralHeight = false;
            this.cmbCompany.Location = new System.Drawing.Point(322, 24);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(63, 32);
            this.cmbCompany.TabIndex = 321;
            this.cmbCompany.Visible = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategory.BackColor = System.Drawing.Color.White;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.IntegralHeight = false;
            this.cmbCategory.Items.AddRange(new object[] {
            "--निवडा--",
            "खते",
            "किटकनाशके",
            "बियाणे"});
            this.cmbCategory.Location = new System.Drawing.Point(430, 22);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(210, 32);
            this.cmbCategory.TabIndex = 320;
            this.cmbCategory.Visible = false;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbItemName
            // 
            this.cmbItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemName.BackColor = System.Drawing.Color.White;
            this.cmbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemName.ForeColor = System.Drawing.Color.Black;
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.IntegralHeight = false;
            this.cmbItemName.Location = new System.Drawing.Point(391, 25);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(33, 32);
            this.cmbItemName.TabIndex = 319;
            this.cmbItemName.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStockRegister);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(20, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1210, 412);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // dgvStockRegister
            // 
            this.dgvStockRegister.AllowUserToAddRows = false;
            this.dgvStockRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStockRegister.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStockRegister.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStockRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockRegister.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStockRegister.GridColor = System.Drawing.Color.Black;
            this.dgvStockRegister.Location = new System.Drawing.Point(3, 16);
            this.dgvStockRegister.Name = "dgvStockRegister";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockRegister.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStockRegister.RowHeadersVisible = false;
            this.dgvStockRegister.Size = new System.Drawing.Size(1204, 393);
            this.dgvStockRegister.TabIndex = 2;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(23, 10);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(150, 36);
            this.lblHerader.TabIndex = 428;
            this.lblHerader.Text = "स्टॉक माहिती";
            // 
            // frmStockRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 587);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbsarch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.cmbItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbCategory);
            this.KeyPreview = true;
            this.Name = "frmStockRegister";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStockRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStockRegister_KeyDown);
            this.gbsarch.ResumeLayout(false);
            this.gbsarch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbsarch;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvStockRegister;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.ComboBox cmbCategory;
        internal System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TextBox txtSreachch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtSumQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMainCategory;
        private System.Windows.Forms.ComboBox cmbGoDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHerader;
    }
}