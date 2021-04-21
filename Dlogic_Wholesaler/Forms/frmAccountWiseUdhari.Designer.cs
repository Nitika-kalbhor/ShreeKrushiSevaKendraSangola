namespace Dlogic_Wholesaler.Forms
{
    partial class frmAccountWiseUdhari
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.transactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.panel1.Location = new System.Drawing.Point(20, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 11);
            this.panel1.TabIndex = 100;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Arial Unicode MS", 18F);
            this.lblAccountName.Location = new System.Drawing.Point(372, 21);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(170, 33);
            this.lblAccountName.TabIndex = 101;
            this.lblAccountName.Text = "Account Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtAccountName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 88);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lblName.Location = new System.Drawing.Point(423, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "नांव";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Arial Unicode MS", 14F);
            this.txtAccountName.Location = new System.Drawing.Point(341, 49);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(245, 33);
            this.txtAccountName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAccount);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.groupBox2.Location = new System.Drawing.Point(20, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(962, 391);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionId,
            this.transactionDate,
            this.naration,
            this.crAmount,
            this.drAmount});
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccount.EnableHeadersVisualStyles = false;
            this.dgvAccount.GridColor = System.Drawing.Color.DarkRed;
            this.dgvAccount.Location = new System.Drawing.Point(3, 25);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersVisible = false;
            this.dgvAccount.RowTemplate.Height = 26;
            this.dgvAccount.Size = new System.Drawing.Size(956, 363);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            this.dgvAccount.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAccount_CellFormatting);
            // 
            // transactionId
            // 
            this.transactionId.DataPropertyName = "transactionId";
            this.transactionId.HeaderText = "transactionId";
            this.transactionId.Name = "transactionId";
            this.transactionId.Visible = false;
            // 
            // transactionDate
            // 
            this.transactionDate.DataPropertyName = "transactionDate";
            this.transactionDate.HeaderText = "दिनांक";
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Width = 160;
            // 
            // naration
            // 
            this.naration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.naration.DataPropertyName = "naration";
            this.naration.HeaderText = "तपशील";
            this.naration.Name = "naration";
            // 
            // crAmount
            // 
            this.crAmount.DataPropertyName = "crAmount";
            dataGridViewCellStyle2.Format = "N2";
            this.crAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.crAmount.HeaderText = "नावे रक्कम";
            this.crAmount.Name = "crAmount";
            this.crAmount.Width = 200;
            // 
            // drAmount
            // 
            this.drAmount.DataPropertyName = "drAmount";
            dataGridViewCellStyle3.Format = "N2";
            this.drAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.drAmount.HeaderText = "जमा रक्कम";
            this.drAmount.Name = "drAmount";
            this.drAmount.Width = 200;
            // 
            // frmAccountWiseUdhari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 8F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAccountWiseUdhari";
            this.Padding = new System.Windows.Forms.Padding(20, 69, 20, 23);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccountWiseUdhari_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn naration;
        private System.Windows.Forms.DataGridViewTextBoxColumn crAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn drAmount;
    }
}