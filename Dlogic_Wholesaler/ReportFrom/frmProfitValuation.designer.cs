namespace Dlogic_Wholesaler.ReportFroms
{
    partial class frmProfitValuation
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
            this.gbsarch.Size = new System.Drawing.Size(1307, 95);
            this.gbsarch.TabIndex = 32;
            this.gbsarch.TabStop = false;
            this.gbsarch.Text = "शोधा";
            // 
            // cmbOrgnation
            // 
            this.cmbOrgnation.FormattingEnabled = true;
            this.cmbOrgnation.ItemHeight = 23;
            this.cmbOrgnation.Location = new System.Drawing.Point(25, 51);
            this.cmbOrgnation.Name = "cmbOrgnation";
            this.cmbOrgnation.Size = new System.Drawing.Size(172, 31);
            this.cmbOrgnation.TabIndex = 247;
            this.cmbOrgnation.SelectedIndexChanged += new System.EventHandler(this.cmbOrgnation_SelectedIndexChanged);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.metroButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton3.ForeColor = System.Drawing.Color.Black;
            this.metroButton3.Location = new System.Drawing.Point(831, 51);
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
            this.lblGodown.Text = "कंपनी";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(750, 51);
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
            this.btnPrint.Location = new System.Drawing.Point(663, 51);
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
            this.btnShow.Location = new System.Drawing.Point(582, 51);
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
            this.lblItemName.Location = new System.Drawing.Point(407, 24);
            this.lblItemName.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(79, 23);
            this.lblItemName.TabIndex = 249;
            this.lblItemName.Text = "वस्तूचे नाव";
            // 
            // cmbItemName
            // 
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.ItemHeight = 23;
            this.cmbItemName.Location = new System.Drawing.Point(381, 51);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(167, 31);
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
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.cmbItemType_SelectedIndexChanged);
            // 
            // lblItemType
            // 
            this.lblItemType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(212, 24);
            this.lblItemType.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(93, 23);
            this.lblItemType.TabIndex = 234;
            this.lblItemType.Text = "वस्तूचा प्रकार";
            // 
            // dgvStockRegister
            // 
            this.dgvStockRegister.AllowUserToAddRows = false;
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
            this.dgvStockRegister.Size = new System.Drawing.Size(1301, 350);
            this.dgvStockRegister.TabIndex = 2;
            this.dgvStockRegister.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStockRegister_CellFormatting);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStockRegister);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(20, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1307, 369);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(23, 12);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(196, 36);
            this.lblHerader.TabIndex = 435;
            this.lblHerader.Text = "अंदाजे नफा रिपोर्ट";
            // 
            // frmProfitValuation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 544);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbsarch);
            this.KeyPreview = true;
            this.Name = "frmProfitValuation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProfitValuation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProfitValuation_KeyDown);
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
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.DataGridView dgvStockRegister;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.ComboBox cmbOrgnation;
        private System.Windows.Forms.Label lblGodown;
        private System.Windows.Forms.Label lblHerader;
    }
}