namespace Dlogic_Wholesaler.TempReportFroms
{
    partial class FrmTempSaleReturnBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcelConvert = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSaleItems = new System.Windows.Forms.DataGridView();
            this.dgvSaleReturn = new System.Windows.Forms.DataGridView();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcelConvert);
            this.groupBox2.Controls.Add(this.btnnew);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.dtpToDate);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.dtpFromDate);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(20, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1330, 56);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            // 
            // btnExcelConvert
            // 
            this.btnExcelConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnExcelConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnExcelConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelConvert.ForeColor = System.Drawing.Color.White;
            this.btnExcelConvert.Location = new System.Drawing.Point(673, 14);
            this.btnExcelConvert.Name = "btnExcelConvert";
            this.btnExcelConvert.Size = new System.Drawing.Size(122, 34);
            this.btnExcelConvert.TabIndex = 309;
            this.btnExcelConvert.Text = "Excel रिपोर्ट";
            this.btnExcelConvert.UseVisualStyleBackColor = false;
            this.btnExcelConvert.Click += new System.EventHandler(this.btnExcelConvert_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(549, 14);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(91, 34);
            this.btnnew.TabIndex = 306;
            this.btnnew.Text = "दाखवा";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(328, 19);
            this.metroLabel3.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(31, 19);
            this.metroLabel3.TabIndex = 156;
            this.metroLabel3.Text = "ते :-";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(394, 14);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(130, 29);
            this.dtpToDate.TabIndex = 155;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(81, 18);
            this.metroLabel1.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 154;
            this.metroLabel1.Text = "पासून दिनांक  :-";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(186, 14);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(130, 29);
            this.dtpFromDate.TabIndex = 153;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSaleItems);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1330, 180);
            this.groupBox3.TabIndex = 109;
            this.groupBox3.TabStop = false;
            // 
            // dgvSaleItems
            // 
            this.dgvSaleItems.AllowUserToAddRows = false;
            this.dgvSaleItems.AllowUserToDeleteRows = false;
            this.dgvSaleItems.AllowUserToResizeColumns = false;
            this.dgvSaleItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSaleItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemId,
            this.companyId,
            this.StockId,
            this.categoryId,
            this.itemName,
            this.batchNo,
            this.Quantity,
            this.unitBy,
            this.Rate,
            this.IGST,
            this.IGSTAmt,
            this.CGST,
            this.CGSTAmt,
            this.SGST,
            this.SGSTAmt,
            this.discount,
            this.totalAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSaleItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSaleItems.EnableHeadersVisualStyles = false;
            this.dgvSaleItems.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvSaleItems.Location = new System.Drawing.Point(3, 18);
            this.dgvSaleItems.Name = "dgvSaleItems";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSaleItems.RowHeadersVisible = false;
            this.dgvSaleItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleItems.Size = new System.Drawing.Size(1324, 159);
            this.dgvSaleItems.TabIndex = 5;
            this.dgvSaleItems.Visible = false;
            // 
            // dgvSaleReturn
            // 
            this.dgvSaleReturn.AllowUserToAddRows = false;
            this.dgvSaleReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaleReturn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSaleReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleReturn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSaleReturn.GridColor = System.Drawing.Color.Black;
            this.dgvSaleReturn.Location = new System.Drawing.Point(20, 116);
            this.dgvSaleReturn.Name = "dgvSaleReturn";
            this.dgvSaleReturn.RowHeadersVisible = false;
            this.dgvSaleReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleReturn.Size = new System.Drawing.Size(1330, 321);
            this.dgvSaleReturn.TabIndex = 110;
            this.dgvSaleReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleReturn_CellClick);
            // 
            // itemId
            // 
            this.itemId.HeaderText = "itemId";
            this.itemId.Name = "itemId";
            this.itemId.Visible = false;
            // 
            // companyId
            // 
            this.companyId.HeaderText = "companyId";
            this.companyId.Name = "companyId";
            this.companyId.Visible = false;
            // 
            // StockId
            // 
            this.StockId.HeaderText = "StockId";
            this.StockId.Name = "StockId";
            this.StockId.Visible = false;
            // 
            // categoryId
            // 
            this.categoryId.HeaderText = "categoryId";
            this.categoryId.Name = "categoryId";
            this.categoryId.Visible = false;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "तपशील";
            this.itemName.Name = "itemName";
            this.itemName.Width = 300;
            // 
            // batchNo
            // 
            this.batchNo.HeaderText = "बॅच नं";
            this.batchNo.Name = "batchNo";
            this.batchNo.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "नग";
            this.Quantity.Name = "Quantity";
            // 
            // unitBy
            // 
            this.unitBy.HeaderText = "पॅकींग";
            this.unitBy.Name = "unitBy";
            this.unitBy.ReadOnly = true;
            this.unitBy.ToolTipText = "QTY";
            // 
            // Rate
            // 
            this.Rate.HeaderText = "दर";
            this.Rate.Name = "Rate";
            this.Rate.Width = 150;
            // 
            // IGST
            // 
            this.IGST.HeaderText = "GST(%)";
            this.IGST.Name = "IGST";
            this.IGST.Visible = false;
            // 
            // IGSTAmt
            // 
            this.IGSTAmt.HeaderText = "GST रक्कम";
            this.IGSTAmt.Name = "IGSTAmt";
            this.IGSTAmt.Visible = false;
            // 
            // CGST
            // 
            this.CGST.HeaderText = "CGST(%)";
            this.CGST.Name = "CGST";
            this.CGST.Visible = false;
            // 
            // CGSTAmt
            // 
            this.CGSTAmt.HeaderText = "CGST रक्कम";
            this.CGSTAmt.Name = "CGSTAmt";
            this.CGSTAmt.Visible = false;
            // 
            // SGST
            // 
            this.SGST.HeaderText = "SGST(%)";
            this.SGST.Name = "SGST";
            this.SGST.Visible = false;
            // 
            // SGSTAmt
            // 
            this.SGSTAmt.HeaderText = "SGST रक्कम";
            this.SGSTAmt.Name = "SGSTAmt";
            this.SGSTAmt.Visible = false;
            // 
            // discount
            // 
            this.discount.HeaderText = "सवलत";
            this.discount.Name = "discount";
            this.discount.Visible = false;
            // 
            // totalAmount
            // 
            this.totalAmount.HeaderText = "रक्कम";
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            // 
            // FrmTempSaleReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 637);
            this.Controls.Add(this.dgvSaleReturn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.Name = "FrmTempSaleReturnBook";
            this.Text = "विक्री परत बुक 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSaleReturnBook_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSaleReturnBook_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnnew;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Button btnExcelConvert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSaleReturn;
        private System.Windows.Forms.DataGridView dgvSaleItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
    }
}