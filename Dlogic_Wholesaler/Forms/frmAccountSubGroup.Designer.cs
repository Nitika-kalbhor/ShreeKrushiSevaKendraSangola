namespace Dlogic_Wholesaler.Forms
{
    partial class frmAccountSubGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAccountGroup = new System.Windows.Forms.DataGridView();
            this.accountSubGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountSubGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSubCategory = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAccountGroup = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountGroup = new System.Windows.Forms.TextBox();
            this.cmbaccoutType = new System.Windows.Forms.ComboBox();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountGroup)).BeginInit();
            this.grpSubCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 10);
            this.panel1.TabIndex = 343;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAccountGroup);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 241);
            this.groupBox1.TabIndex = 345;
            this.groupBox1.TabStop = false;
            // 
            // dgvAccountGroup
            // 
            this.dgvAccountGroup.AllowUserToAddRows = false;
            this.dgvAccountGroup.AllowUserToDeleteRows = false;
            this.dgvAccountGroup.AllowUserToResizeColumns = false;
            this.dgvAccountGroup.AllowUserToResizeRows = false;
            this.dgvAccountGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAccountGroup.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAccountGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountSubGroupId,
            this.accountGroupId,
            this.accountType,
            this.accountGroup,
            this.accountSubGroupName,
            this.accountTypeId});
            this.dgvAccountGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccountGroup.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccountGroup.EnableHeadersVisualStyles = false;
            this.dgvAccountGroup.GridColor = System.Drawing.Color.Black;
            this.dgvAccountGroup.Location = new System.Drawing.Point(3, 20);
            this.dgvAccountGroup.Name = "dgvAccountGroup";
            this.dgvAccountGroup.RowHeadersVisible = false;
            this.dgvAccountGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountGroup.Size = new System.Drawing.Size(905, 218);
            this.dgvAccountGroup.TabIndex = 0;
            this.dgvAccountGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountGroup_CellClick);
            // 
            // accountSubGroupId
            // 
            this.accountSubGroupId.DataPropertyName = "accountSubGroupId";
            this.accountSubGroupId.HeaderText = "accountSubGroupId";
            this.accountSubGroupId.Name = "accountSubGroupId";
            this.accountSubGroupId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.accountSubGroupId.Visible = false;
            // 
            // accountGroupId
            // 
            this.accountGroupId.DataPropertyName = "accountGroupId";
            this.accountGroupId.HeaderText = "accountGroupId";
            this.accountGroupId.Name = "accountGroupId";
            this.accountGroupId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.accountGroupId.Visible = false;
            // 
            // accountType
            // 
            this.accountType.DataPropertyName = "accountType";
            this.accountType.HeaderText = "खाते गट";
            this.accountType.Name = "accountType";
            this.accountType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.accountType.Width = 56;
            // 
            // accountGroup
            // 
            this.accountGroup.DataPropertyName = "accountGroup";
            this.accountGroup.HeaderText = "खाते गट प्रकार";
            this.accountGroup.Name = "accountGroup";
            this.accountGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.accountGroup.Width = 88;
            // 
            // accountSubGroupName
            // 
            this.accountSubGroupName.DataPropertyName = "accountSubGroupName";
            this.accountSubGroupName.HeaderText = "खाते गट उपप्रकार";
            this.accountSubGroupName.Name = "accountSubGroupName";
            this.accountSubGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.accountSubGroupName.Width = 105;
            // 
            // accountTypeId
            // 
            this.accountTypeId.DataPropertyName = "accountTypeId";
            this.accountTypeId.HeaderText = "accountTypeId";
            this.accountTypeId.Name = "accountTypeId";
            this.accountTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.accountTypeId.Visible = false;
            // 
            // grpSubCategory
            // 
            this.grpSubCategory.Controls.Add(this.label3);
            this.grpSubCategory.Controls.Add(this.cmbAccountGroup);
            this.grpSubCategory.Controls.Add(this.btnNew);
            this.grpSubCategory.Controls.Add(this.btnUpdate);
            this.grpSubCategory.Controls.Add(this.btnSave);
            this.grpSubCategory.Controls.Add(this.btnDelete);
            this.grpSubCategory.Controls.Add(this.label2);
            this.grpSubCategory.Controls.Add(this.label1);
            this.grpSubCategory.Controls.Add(this.txtAccountGroup);
            this.grpSubCategory.Controls.Add(this.cmbaccoutType);
            this.grpSubCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSubCategory.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSubCategory.Location = new System.Drawing.Point(20, 70);
            this.grpSubCategory.Name = "grpSubCategory";
            this.grpSubCategory.Size = new System.Drawing.Size(911, 215);
            this.grpSubCategory.TabIndex = 344;
            this.grpSubCategory.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(125, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 121;
            this.label3.Text = "खाते गट प्रकार :";
            // 
            // cmbAccountGroup
            // 
            this.cmbAccountGroup.BackColor = System.Drawing.Color.White;
            this.cmbAccountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountGroup.ForeColor = System.Drawing.Color.Black;
            this.cmbAccountGroup.FormattingEnabled = true;
            this.cmbAccountGroup.Location = new System.Drawing.Point(320, 70);
            this.cmbAccountGroup.Name = "cmbAccountGroup";
            this.cmbAccountGroup.Size = new System.Drawing.Size(227, 32);
            this.cmbAccountGroup.TabIndex = 120;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(152, 171);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(127, 34);
            this.btnNew.TabIndex = 119;
            this.btnNew.Text = "नवीन(Alt+N)";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(427, 171);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 34);
            this.btnUpdate.TabIndex = 116;
            this.btnUpdate.Text = "अपडेट";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(291, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 34);
            this.btnSave.TabIndex = 118;
            this.btnSave.Text = "जतन करा(Alt+S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(524, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 34);
            this.btnDelete.TabIndex = 117;
            this.btnDelete.Text = "डिलीट";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(125, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "खाते गट उप प्रकार :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(125, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "खाते प्रकार :";
            // 
            // txtAccountGroup
            // 
            this.txtAccountGroup.BackColor = System.Drawing.Color.White;
            this.txtAccountGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountGroup.ForeColor = System.Drawing.Color.Black;
            this.txtAccountGroup.Location = new System.Drawing.Point(320, 109);
            this.txtAccountGroup.Name = "txtAccountGroup";
            this.txtAccountGroup.Size = new System.Drawing.Size(227, 29);
            this.txtAccountGroup.TabIndex = 1;
            // 
            // cmbaccoutType
            // 
            this.cmbaccoutType.BackColor = System.Drawing.Color.White;
            this.cmbaccoutType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbaccoutType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbaccoutType.ForeColor = System.Drawing.Color.Black;
            this.cmbaccoutType.FormattingEnabled = true;
            this.cmbaccoutType.Location = new System.Drawing.Point(320, 32);
            this.cmbaccoutType.Name = "cmbaccoutType";
            this.cmbaccoutType.Size = new System.Drawing.Size(227, 32);
            this.cmbaccoutType.TabIndex = 0;
            this.cmbaccoutType.SelectedIndexChanged += new System.EventHandler(this.cmbaccoutType_SelectedIndexChanged);
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(348, 13);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(147, 33);
            this.lblHerader.TabIndex = 346;
            this.lblHerader.Text = "खाते उपप्रकार ";
            // 
            // frmAccountSubGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 546);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSubCategory);
            this.Controls.Add(this.panel1);
            this.Name = "frmAccountSubGroup";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmAccountSubGroup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccountSubGroup_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountGroup)).EndInit();
            this.grpSubCategory.ResumeLayout(false);
            this.grpSubCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAccountGroup;
        private System.Windows.Forms.GroupBox grpSubCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAccountGroup;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountGroup;
        private System.Windows.Forms.ComboBox cmbaccoutType;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountSubGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountSubGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeId;
        private System.Windows.Forms.Label lblHerader;
    }
}