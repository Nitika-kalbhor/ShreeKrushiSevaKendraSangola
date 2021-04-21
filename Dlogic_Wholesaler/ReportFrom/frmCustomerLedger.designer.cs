namespace Dlogic_Wholesaler.Forms
{
    partial class frmCustomerLedger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerLedger));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSeachName = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSeachName = new System.Windows.Forms.TextBox();
            this.btneExcelReport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCustomerLedger = new System.Windows.Forms.DataGridView();
            this.all = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerLedger)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 10);
            this.panel1.TabIndex = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSeachName);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSeachName);
            this.groupBox1.Controls.Add(this.btneExcelReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1242, 69);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 111;
            this.label2.Text = "किंवा";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 110;
            this.label1.Text = "मोबाईल नं";
            // 
            // cmbSeachName
            // 
            this.cmbSeachName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSeachName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSeachName.BackColor = System.Drawing.Color.White;
            this.cmbSeachName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeachName.ForeColor = System.Drawing.Color.Black;
            this.cmbSeachName.FormattingEnabled = true;
            this.cmbSeachName.Location = new System.Drawing.Point(84, 22);
            this.cmbSeachName.Name = "cmbSeachName";
            this.cmbSeachName.Size = new System.Drawing.Size(293, 32);
            this.cmbSeachName.TabIndex = 109;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(815, 14);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(113, 35);
            this.btnShow.TabIndex = 108;
            this.btnShow.Text = "शो";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "पत्ता :";
            // 
            // txtSeachName
            // 
            this.txtSeachName.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachName.Location = new System.Drawing.Point(566, 19);
            this.txtSeachName.MaxLength = 10;
            this.txtSeachName.Name = "txtSeachName";
            this.txtSeachName.Size = new System.Drawing.Size(206, 32);
            this.txtSeachName.TabIndex = 29;
            this.txtSeachName.TextChanged += new System.EventHandler(this.txtSeachName_TextChanged);
            // 
            // btneExcelReport
            // 
            this.btneExcelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btneExcelReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btneExcelReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneExcelReport.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btneExcelReport.ForeColor = System.Drawing.Color.White;
            this.btneExcelReport.Location = new System.Drawing.Point(934, 14);
            this.btneExcelReport.Name = "btneExcelReport";
            this.btneExcelReport.Size = new System.Drawing.Size(144, 35);
            this.btneExcelReport.TabIndex = 28;
            this.btneExcelReport.Text = "एक्सेल रिपोर्ट";
            this.btneExcelReport.UseVisualStyleBackColor = false;
            this.btneExcelReport.Click += new System.EventHandler(this.btneExcelReport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCustomerLedger);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(20, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1242, 392);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            // 
            // dgvCustomerLedger
            // 
            this.dgvCustomerLedger.AllowUserToAddRows = false;
            this.dgvCustomerLedger.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerLedger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerLedger.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustomerLedger.GridColor = System.Drawing.Color.Maroon;
            this.dgvCustomerLedger.Location = new System.Drawing.Point(3, 16);
            this.dgvCustomerLedger.Name = "dgvCustomerLedger";
            this.dgvCustomerLedger.RowHeadersVisible = false;
            this.dgvCustomerLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerLedger.Size = new System.Drawing.Size(1236, 373);
            this.dgvCustomerLedger.TabIndex = 0;
            this.dgvCustomerLedger.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCustomerLedger_CellFormatting);
            this.dgvCustomerLedger.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCustomerLedger_CellMouseUp);
            // 
            // all
            // 
            this.all.AutoSize = true;
            this.all.Checked = true;
            this.all.CheckState = System.Windows.Forms.CheckState.Checked;
            this.all.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all.Location = new System.Drawing.Point(92, 26);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(95, 28);
            this.all.TabIndex = 103;
            this.all.Text = "सर्व उधारी";
            this.all.UseVisualStyleBackColor = true;
            this.all.CheckedChanged += new System.EventHandler(this.all_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 112;
            this.label3.Text = "ग्राहक नांव";
            // 
            // txtcustomer
            // 
            this.txtcustomer.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomer.Location = new System.Drawing.Point(320, 23);
            this.txtcustomer.MaxLength = 10;
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(206, 32);
            this.txtcustomer.TabIndex = 111;
            this.txtcustomer.TextChanged += new System.EventHandler(this.txtcustomer_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 26);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.deleteRowToolStripMenuItem.Text = "DeleteRow";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(558, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 36);
            this.label4.TabIndex = 113;
            this.label4.Text = "ग्राहक उधारी रिपोर्ट";
            // 
            // frmCustomerLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 551);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.all);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCustomerLedger";
          
            this.Load += new System.EventHandler(this.frmCustomerLedger_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCustomerLedger_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerLedger)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCustomerLedger;
        private System.Windows.Forms.Button btneExcelReport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSeachName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cmbSeachName;
        private System.Windows.Forms.CheckBox all;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}