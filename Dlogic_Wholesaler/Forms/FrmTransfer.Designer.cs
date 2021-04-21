namespace Dlogic_Wholesaler.Forms
{
    partial class FrmTransfer
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
            this.rbDealer = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.pnlCustomerSuplier = new System.Windows.Forms.Panel();
            this.cmbAccountName = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWrongAccountName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHerader = new System.Windows.Forms.Label();
            this.btnSelectAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnldgv = new System.Windows.Forms.Panel();
            this.dgvCustomerDetails = new System.Windows.Forms.DataGridView();
            this.accountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // rbDealer
            // 
            this.rbDealer.AutoSize = true;
            this.rbDealer.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDealer.Location = new System.Drawing.Point(153, 99);
            this.rbDealer.Name = "rbDealer";
            this.rbDealer.Size = new System.Drawing.Size(69, 22);
            this.rbDealer.TabIndex = 391;
            this.rbDealer.TabStop = true;
            this.rbDealer.Text = "व्यापारी";
            this.rbDealer.UseVisualStyleBackColor = true;
            this.rbDealer.CheckedChanged += new System.EventHandler(this.rbDealer_CheckedChanged);
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustomer.Location = new System.Drawing.Point(39, 99);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(58, 22);
            this.rbCustomer.TabIndex = 390;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "ग्राहक";
            this.rbCustomer.UseVisualStyleBackColor = true;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.rbCustomer_CheckedChanged);
            // 
            // pnlCustomerSuplier
            // 
            this.pnlCustomerSuplier.Location = new System.Drawing.Point(23, 89);
            this.pnlCustomerSuplier.Name = "pnlCustomerSuplier";
            this.pnlCustomerSuplier.Size = new System.Drawing.Size(251, 41);
            this.pnlCustomerSuplier.TabIndex = 397;
            // 
            // cmbAccountName
            // 
            this.cmbAccountName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccountName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccountName.BackColor = System.Drawing.Color.White;
            this.cmbAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountName.ForeColor = System.Drawing.Color.Black;
            this.cmbAccountName.FormattingEnabled = true;
            this.cmbAccountName.Location = new System.Drawing.Point(154, 141);
            this.cmbAccountName.Name = "cmbAccountName";
            this.cmbAccountName.Size = new System.Drawing.Size(246, 26);
            this.cmbAccountName.TabIndex = 398;
            this.cmbAccountName.SelectedIndexChanged += new System.EventHandler(this.cmbAccountName_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(3, 145);
            this.metroLabel2.MinimumSize = new System.Drawing.Size(60, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 18);
            this.metroLabel2.TabIndex = 399;
            this.metroLabel2.Text = "बरोबर खात्याचे नांव";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 194);
            this.label1.MinimumSize = new System.Drawing.Size(60, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 400;
            this.label1.Text = "चुकीचे खात्याचे नांव";
            // 
            // cmbWrongAccountName
            // 
            this.cmbWrongAccountName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbWrongAccountName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWrongAccountName.BackColor = System.Drawing.Color.White;
            this.cmbWrongAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWrongAccountName.ForeColor = System.Drawing.Color.Black;
            this.cmbWrongAccountName.FormattingEnabled = true;
            this.cmbWrongAccountName.Location = new System.Drawing.Point(154, 190);
            this.cmbWrongAccountName.Name = "cmbWrongAccountName";
            this.cmbWrongAccountName.Size = new System.Drawing.Size(246, 26);
            this.cmbWrongAccountName.TabIndex = 401;
            this.cmbWrongAccountName.SelectedIndexChanged += new System.EventHandler(this.cmbWrongAccountName_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHerader);
            this.panel1.Controls.Add(this.btnSelectAccount);
            this.panel1.Controls.Add(this.cmbAccountName);
            this.panel1.Controls.Add(this.cmbWrongAccountName);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 517);
            this.panel1.TabIndex = 403;
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(33, 9);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(116, 36);
            this.lblHerader.TabIndex = 425;
            this.lblHerader.Text = "खाते बदल";
            // 
            // btnSelectAccount
            // 
            this.btnSelectAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnSelectAccount.FlatAppearance.BorderSize = 0;
            this.btnSelectAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAccount.Location = new System.Drawing.Point(113, 258);
            this.btnSelectAccount.Name = "btnSelectAccount";
            this.btnSelectAccount.Size = new System.Drawing.Size(109, 47);
            this.btnSelectAccount.TabIndex = 402;
            this.btnSelectAccount.Text = "निवडा";
            this.btnSelectAccount.UseVisualStyleBackColor = false;
            this.btnSelectAccount.Click += new System.EventHandler(this.btnSelectAccount_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(402, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 70);
            this.panel2.TabIndex = 404;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 445);
            this.panel3.TabIndex = 405;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(451, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 37);
            this.btnSave.TabIndex = 403;
            this.btnSave.Text = "जतन करा";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnldgv
            // 
            this.pnldgv.Controls.Add(this.dgvCustomerDetails);
            this.pnldgv.Location = new System.Drawing.Point(405, 72);
            this.pnldgv.Name = "pnldgv";
            this.pnldgv.Size = new System.Drawing.Size(435, 256);
            this.pnldgv.TabIndex = 405;
            // 
            // dgvCustomerDetails
            // 
            this.dgvCustomerDetails.AllowUserToAddRows = false;
            this.dgvCustomerDetails.AllowUserToDeleteRows = false;
            this.dgvCustomerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerDetails.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountId,
            this.accountName});
            this.dgvCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustomerDetails.EnableHeadersVisualStyles = false;
            this.dgvCustomerDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerDetails.Name = "dgvCustomerDetails";
            this.dgvCustomerDetails.RowHeadersVisible = false;
            this.dgvCustomerDetails.Size = new System.Drawing.Size(435, 256);
            this.dgvCustomerDetails.TabIndex = 0;
            // 
            // accountId
            // 
            this.accountId.HeaderText = "accountId";
            this.accountId.Name = "accountId";
            this.accountId.ReadOnly = true;
            this.accountId.Visible = false;
            // 
            // accountName
            // 
            this.accountName.HeaderText = "खाते नाव";
            this.accountName.Name = "accountName";
            this.accountName.ReadOnly = true;
            // 
            // FrmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 517);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnldgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rbCustomer);
            this.Controls.Add(this.rbDealer);
            this.Controls.Add(this.pnlCustomerSuplier);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTransfer";
            this.Load += new System.EventHandler(this.FrmTransfer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDealer;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.Panel pnlCustomerSuplier;
        private System.Windows.Forms.ComboBox cmbAccountName;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWrongAccountName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnldgv;
        private System.Windows.Forms.DataGridView dgvCustomerDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.Label lblHerader;
    }
}