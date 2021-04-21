namespace Dlogic_Wholesaler.Forms
{
    partial class frmItemDetailsList
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.txtHNSCode = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvItemDetails = new System.Windows.Forms.DataGridView();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godownName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HNSCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHerader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(20, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1187, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 80;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtHNSCode);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 56);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.metroLabel2.Location = new System.Drawing.Point(555, 19);
            this.metroLabel2.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(297, 20);
            this.metroLabel2.TabIndex = 156;
            this.metroLabel2.Text = "* वस्तूचे नाव वर mouse double click करा.";
            // 
            // txtHNSCode
            // 
            this.txtHNSCode.BackColor = System.Drawing.Color.White;
            this.txtHNSCode.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.txtHNSCode.Location = new System.Drawing.Point(135, 16);
            this.txtHNSCode.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtHNSCode.Name = "txtHNSCode";
            this.txtHNSCode.Size = new System.Drawing.Size(257, 29);
            this.txtHNSCode.TabIndex = 155;
            this.txtHNSCode.TextChanged += new System.EventHandler(this.txtHNSCode_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(33, 19);
            this.metroLabel1.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 21);
            this.metroLabel1.TabIndex = 154;
            this.metroLabel1.Text = "वस्तूचे नाव  :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvItemDetails);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(20, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1187, 401);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            // 
            // dgvItemDetails
            // 
            this.dgvItemDetails.AllowUserToAddRows = false;
            this.dgvItemDetails.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.companyId,
            this.godownName,
            this.categoryName,
            this.companyName,
            this.itemName,
            this.batchNo,
            this.unitBy,
            this.openingStock,
            this.currentStock,
            this.reorderLevel,
            this.price,
            this.HNSCode,
            this.IGST,
            this.CGST,
            this.SGST,
            this.categoryId});
            this.dgvItemDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItemDetails.EnableHeadersVisualStyles = false;
            this.dgvItemDetails.GridColor = System.Drawing.Color.Black;
            this.dgvItemDetails.Location = new System.Drawing.Point(3, 23);
            this.dgvItemDetails.Name = "dgvItemDetails";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemDetails.RowHeadersVisible = false;
            this.dgvItemDetails.Size = new System.Drawing.Size(1181, 375);
            this.dgvItemDetails.TabIndex = 2;
            this.dgvItemDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemDetails_CellClick);
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "itemId";
            this.ItemId.HeaderText = "ItemId";
            this.ItemId.Name = "ItemId";
            this.ItemId.Visible = false;
            // 
            // companyId
            // 
            this.companyId.DataPropertyName = "companyId";
            this.companyId.HeaderText = "companyId";
            this.companyId.Name = "companyId";
            this.companyId.Visible = false;
            // 
            // godownName
            // 
            this.godownName.DataPropertyName = "godownName";
            this.godownName.HeaderText = "गोडाऊन";
            this.godownName.Name = "godownName";
            // 
            // categoryName
            // 
            this.categoryName.DataPropertyName = "categoryName";
            this.categoryName.HeaderText = "प्रकार";
            this.categoryName.Name = "categoryName";
            this.categoryName.Width = 150;
            // 
            // companyName
            // 
            this.companyName.DataPropertyName = "companyName";
            this.companyName.HeaderText = "कंपनी";
            this.companyName.Name = "companyName";
            this.companyName.Width = 150;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "वस्तूचे नाव";
            this.itemName.Name = "itemName";
            this.itemName.Width = 200;
            // 
            // batchNo
            // 
            this.batchNo.DataPropertyName = "batchNo";
            this.batchNo.HeaderText = "बॅच नं";
            this.batchNo.Name = "batchNo";
            // 
            // unitBy
            // 
            this.unitBy.DataPropertyName = "unitBy";
            this.unitBy.HeaderText = "पॅकिंग";
            this.unitBy.Name = "unitBy";
            // 
            // openingStock
            // 
            this.openingStock.DataPropertyName = "openingStock";
            this.openingStock.HeaderText = "आरंभी नग";
            this.openingStock.Name = "openingStock";
            // 
            // currentStock
            // 
            this.currentStock.DataPropertyName = "currentStock";
            this.currentStock.HeaderText = "उपलब्ध नग";
            this.currentStock.Name = "currentStock";
            // 
            // reorderLevel
            // 
            this.reorderLevel.DataPropertyName = "reorderLevel";
            this.reorderLevel.HeaderText = "रिऑर्डर नग";
            this.reorderLevel.Name = "reorderLevel";
            this.reorderLevel.Visible = false;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "दर";
            this.price.Name = "price";
            // 
            // HNSCode
            // 
            this.HNSCode.DataPropertyName = "HNSCode";
            this.HNSCode.HeaderText = "HNS कोड";
            this.HNSCode.Name = "HNSCode";
            // 
            // IGST
            // 
            this.IGST.DataPropertyName = "IGST";
            this.IGST.HeaderText = "IGST(%)";
            this.IGST.Name = "IGST";
            // 
            // CGST
            // 
            this.CGST.DataPropertyName = "CGST";
            this.CGST.HeaderText = "CGST(%)";
            this.CGST.Name = "CGST";
            // 
            // SGST
            // 
            this.SGST.DataPropertyName = "SGST";
            this.SGST.HeaderText = "SGST(%)";
            this.SGST.Name = "SGST";
            // 
            // categoryId
            // 
            this.categoryId.DataPropertyName = "categoryId";
            this.categoryId.HeaderText = "categoryId";
            this.categoryId.Name = "categoryId";
            this.categoryId.Visible = false;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(23, 8);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(126, 33);
            this.lblHerader.TabIndex = 243;
            this.lblHerader.Text = "वस्तू माहिती";
            // 
            // frmItemDetailsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 547);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.KeyPreview = true;
            this.Name = "frmItemDetailsList";
            this.Load += new System.EventHandler(this.frmItemDetailsList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmItemDetailsList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvItemDetails;
        private System.Windows.Forms.Label metroLabel2;
        public System.Windows.Forms.TextBox txtHNSCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn godownName;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn HNSCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.Label lblHerader;
    }
}