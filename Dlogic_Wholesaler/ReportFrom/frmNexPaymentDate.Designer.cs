namespace Dlogic_Wholesaler.ReportFrom
{
    partial class frmNexPaymentDate
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmbAccountname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNextPaymentDetails = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(20, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(673, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 243;
            this.pictureBox3.TabStop = false;
            // 
            // cmbAccountname
            // 
            this.cmbAccountname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAccountname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccountname.BackColor = System.Drawing.Color.White;
            this.cmbAccountname.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAccountname.Font = new System.Drawing.Font("Arial Unicode MS", 13F, System.Drawing.FontStyle.Bold);
            this.cmbAccountname.ForeColor = System.Drawing.Color.Black;
            this.cmbAccountname.FormattingEnabled = true;
            this.cmbAccountname.Location = new System.Drawing.Point(215, 90);
            this.cmbAccountname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAccountname.Name = "cmbAccountname";
            this.cmbAccountname.Size = new System.Drawing.Size(260, 31);
            this.cmbAccountname.TabIndex = 382;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label3.Location = new System.Drawing.Point(116, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 381;
            this.label3.Text = "खात्याचे नांव :";
            // 
            // dtpNextPaymentDetails
            // 
            this.dtpNextPaymentDetails.CustomFormat = "dd-MM-yyyy";
            this.dtpNextPaymentDetails.Font = new System.Drawing.Font("Arial Unicode MS", 11F);
            this.dtpNextPaymentDetails.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNextPaymentDetails.Location = new System.Drawing.Point(215, 128);
            this.dtpNextPaymentDetails.Name = "dtpNextPaymentDetails";
            this.dtpNextPaymentDetails.Size = new System.Drawing.Size(172, 27);
            this.dtpNextPaymentDetails.TabIndex = 408;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label16.Location = new System.Drawing.Point(85, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 21);
            this.label16.TabIndex = 409;
            this.label16.Text = "पुढील  जमा दिनांक:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(249, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 34);
            this.btnSave.TabIndex = 410;
            this.btnSave.Text = "जतन करा";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmNexPaymentDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 232);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpNextPaymentDetails);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbAccountname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Name = "frmNexPaymentDate";
            this.Text = "पुढील वायदा दिनांक";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmNexPaymentDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbAccountname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNextPaymentDetails;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSave;
    }
}