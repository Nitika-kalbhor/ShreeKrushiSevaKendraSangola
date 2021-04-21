namespace Dlogic_Wholesaler.Forms
{
    partial class frmStockConversion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.dtpChallenDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.lblstockInNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvItem1 = new System.Windows.Forms.DataGridView();
            this.lblToGodown = new System.Windows.Forms.Label();
            this.lblToCurrentStock = new System.Windows.Forms.Label();
            this.lblTobatch = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvItemName = new System.Windows.Forms.DataGridView();
            this.lblGodown = new System.Windows.Forms.Label();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConvertChallan = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToStock = new System.Windows.Forms.TextBox();
            this.txtToQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblHerader = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemName)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 18);
            this.panel1.TabIndex = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtInvoiceNo);
            this.groupBox1.Controls.Add(this.dtpChallenDate);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(965, 95);
            this.groupBox1.TabIndex = 317;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(90, 27);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 20);
            this.metroLabel2.TabIndex = 97;
            this.metroLabel2.Text = "लूज  नं :";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BackColor = System.Drawing.Color.White;
            this.txtInvoiceNo.ForeColor = System.Drawing.Color.Black;
            this.txtInvoiceNo.Location = new System.Drawing.Point(203, 24);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInvoiceNo.MinimumSize = new System.Drawing.Size(73, 4);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(248, 27);
            this.txtInvoiceNo.TabIndex = 1;
            // 
            // dtpChallenDate
            // 
            this.dtpChallenDate.CustomFormat = "dd-MM-yyyy";
            this.dtpChallenDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChallenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChallenDate.Location = new System.Drawing.Point(558, 27);
            this.dtpChallenDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpChallenDate.Name = "dtpChallenDate";
            this.dtpChallenDate.Size = new System.Drawing.Size(181, 29);
            this.dtpChallenDate.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(496, 31);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 20);
            this.metroLabel1.TabIndex = 100;
            this.metroLabel1.Text = "दिनांक :";
            // 
            // lblstockInNo
            // 
            this.lblstockInNo.AutoSize = true;
            this.lblstockInNo.Location = new System.Drawing.Point(42, 15);
            this.lblstockInNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstockInNo.Name = "lblstockInNo";
            this.lblstockInNo.Size = new System.Drawing.Size(81, 21);
            this.lblstockInNo.TabIndex = 319;
            this.lblstockInNo.Text = "वस्तूचे नांव :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(90, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 321;
            this.label1.Text = "लूज  नग  :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.txtQuantity.ForeColor = System.Drawing.Color.Green;
            this.txtQuantity.Location = new System.Drawing.Point(547, 11);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.MinimumSize = new System.Drawing.Size(73, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(239, 29);
            this.txtQuantity.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvItem1);
            this.panel2.Controls.Add(this.lblToGodown);
            this.panel2.Controls.Add(this.lblToCurrentStock);
            this.panel2.Controls.Add(this.lblTobatch);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dgvItemName);
            this.panel2.Controls.Add(this.lblGodown);
            this.panel2.Controls.Add(this.lblCurrentStock);
            this.panel2.Controls.Add(this.lblBatchNo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnConvertChallan);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnnew);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtToStock);
            this.panel2.Controls.Add(this.txtToQuantity);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtItemName);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblstockInNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(30, 210);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 313);
            this.panel2.TabIndex = 322;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvItem1
            // 
            this.dgvItem1.AllowUserToAddRows = false;
            this.dgvItem1.AllowUserToDeleteRows = false;
            this.dgvItem1.AllowUserToResizeColumns = false;
            this.dgvItem1.AllowUserToResizeRows = false;
            this.dgvItem1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItem1.BackgroundColor = System.Drawing.Color.White;
            this.dgvItem1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem1.ColumnHeadersVisible = false;
            this.dgvItem1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItem1.Location = new System.Drawing.Point(46, 146);
            this.dgvItem1.Name = "dgvItem1";
            this.dgvItem1.RowHeadersVisible = false;
            this.dgvItem1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem1.Size = new System.Drawing.Size(552, 100);
            this.dgvItem1.TabIndex = 354;
            this.dgvItem1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem1_CellClick);
            this.dgvItem1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem1_CellDoubleClick);
            // 
            // lblToGodown
            // 
            this.lblToGodown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToGodown.AutoSize = true;
            this.lblToGodown.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToGodown.Location = new System.Drawing.Point(460, 177);
            this.lblToGodown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToGodown.MinimumSize = new System.Drawing.Size(90, 0);
            this.lblToGodown.Name = "lblToGodown";
            this.lblToGodown.Size = new System.Drawing.Size(90, 21);
            this.lblToGodown.TabIndex = 353;
            // 
            // lblToCurrentStock
            // 
            this.lblToCurrentStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToCurrentStock.AutoSize = true;
            this.lblToCurrentStock.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToCurrentStock.Location = new System.Drawing.Point(705, 177);
            this.lblToCurrentStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToCurrentStock.MinimumSize = new System.Drawing.Size(90, 0);
            this.lblToCurrentStock.Name = "lblToCurrentStock";
            this.lblToCurrentStock.Size = new System.Drawing.Size(90, 21);
            this.lblToCurrentStock.TabIndex = 352;
            // 
            // lblTobatch
            // 
            this.lblTobatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTobatch.AutoSize = true;
            this.lblTobatch.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTobatch.Location = new System.Drawing.Point(175, 177);
            this.lblTobatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTobatch.MinimumSize = new System.Drawing.Size(90, 0);
            this.lblTobatch.Name = "lblTobatch";
            this.lblTobatch.Size = new System.Drawing.Size(90, 21);
            this.lblTobatch.TabIndex = 351;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(601, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.MinimumSize = new System.Drawing.Size(90, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 350;
            this.label8.Text = "उपलब्ध नग :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(361, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.MinimumSize = new System.Drawing.Size(90, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 349;
            this.label9.Text = "गोडऊन :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 177);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.MinimumSize = new System.Drawing.Size(90, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 348;
            this.label10.Text = "बॅच नं  :";
            // 
            // dgvItemName
            // 
            this.dgvItemName.AllowUserToAddRows = false;
            this.dgvItemName.AllowUserToDeleteRows = false;
            this.dgvItemName.AllowUserToResizeColumns = false;
            this.dgvItemName.AllowUserToResizeRows = false;
            this.dgvItemName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemName.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemName.ColumnHeadersVisible = false;
            this.dgvItemName.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItemName.Location = new System.Drawing.Point(46, 39);
            this.dgvItemName.Name = "dgvItemName";
            this.dgvItemName.RowHeadersVisible = false;
            this.dgvItemName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemName.Size = new System.Drawing.Size(552, 207);
            this.dgvItemName.TabIndex = 324;
            this.dgvItemName.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemName_CellDoubleClick);
            this.dgvItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItemName_CellDoubleClick);
            // 
            // lblGodown
            // 
            this.lblGodown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGodown.AutoSize = true;
            this.lblGodown.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGodown.Location = new System.Drawing.Point(476, 58);
            this.lblGodown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGodown.MinimumSize = new System.Drawing.Size(90, 0);
            this.lblGodown.Name = "lblGodown";
            this.lblGodown.Size = new System.Drawing.Size(90, 21);
            this.lblGodown.TabIndex = 341;
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStock.Location = new System.Drawing.Point(705, 58);
            this.lblCurrentStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentStock.MinimumSize = new System.Drawing.Size(90, 0);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(90, 21);
            this.lblCurrentStock.TabIndex = 340;
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchNo.Location = new System.Drawing.Point(191, 58);
            this.lblBatchNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatchNo.MinimumSize = new System.Drawing.Size(90, 0);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(90, 21);
            this.lblBatchNo.TabIndex = 339;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(601, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.MinimumSize = new System.Drawing.Size(90, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 338;
            this.label4.Text = "उपलब्ध नग :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.MinimumSize = new System.Drawing.Size(90, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 337;
            this.label3.Text = "गोडऊन :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MinimumSize = new System.Drawing.Size(90, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 336;
            this.label2.Text = "बॅच नं  :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(809, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 335;
            this.button1.Text = "नवीन आयटम (F3)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConvertChallan
            // 
            this.btnConvertChallan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnConvertChallan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnConvertChallan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertChallan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertChallan.ForeColor = System.Drawing.Color.White;
            this.btnConvertChallan.Location = new System.Drawing.Point(480, 270);
            this.btnConvertChallan.Name = "btnConvertChallan";
            this.btnConvertChallan.Size = new System.Drawing.Size(138, 34);
            this.btnConvertChallan.TabIndex = 333;
            this.btnConvertChallan.Text = "यादी";
            this.btnConvertChallan.UseVisualStyleBackColor = false;
            this.btnConvertChallan.Click += new System.EventHandler(this.btnConvertChallan_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(386, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 34);
            this.btnDelete.TabIndex = 334;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(145, 270);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(120, 34);
            this.btnnew.TabIndex = 332;
            this.btnnew.Text = "नवीन(Alt+N)";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(271, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "जतन(Alt+S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.MinimumSize = new System.Drawing.Size(90, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 330;
            this.label5.Text = "लूज  नग  :";
            // 
            // txtToStock
            // 
            this.txtToStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToStock.BackColor = System.Drawing.Color.White;
            this.txtToStock.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.txtToStock.ForeColor = System.Drawing.Color.Green;
            this.txtToStock.Location = new System.Drawing.Point(144, 118);
            this.txtToStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToStock.MinimumSize = new System.Drawing.Size(73, 4);
            this.txtToStock.Name = "txtToStock";
            this.txtToStock.Size = new System.Drawing.Size(239, 29);
            this.txtToStock.TabIndex = 5;
            this.txtToStock.TextChanged += new System.EventHandler(this.txtToStock_TextChanged);
            this.txtToStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToStock_KeyDown);
            // 
            // txtToQuantity
            // 
            this.txtToQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToQuantity.BackColor = System.Drawing.Color.White;
            this.txtToQuantity.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.txtToQuantity.ForeColor = System.Drawing.Color.Green;
            this.txtToQuantity.Location = new System.Drawing.Point(553, 118);
            this.txtToQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToQuantity.MinimumSize = new System.Drawing.Size(73, 4);
            this.txtToQuantity.Name = "txtToQuantity";
            this.txtToQuantity.Size = new System.Drawing.Size(239, 29);
            this.txtToQuantity.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 21);
            this.label11.TabIndex = 325;
            this.label11.Text = "वस्तूचे नांव :";
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.txtItemName.ForeColor = System.Drawing.Color.Green;
            this.txtItemName.Location = new System.Drawing.Point(144, 11);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemName.MinimumSize = new System.Drawing.Size(73, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(239, 29);
            this.txtItemName.TabIndex = 3;
            this.txtItemName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyDown);
            // 
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(33, 13);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(115, 33);
            this.lblHerader.TabIndex = 350;
            this.lblHerader.Text = " स्टॉक लूज ";
            // 
            // frmStockConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 555);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStockConversion";
            this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmStockConversion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStockConversion_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.DateTimePicker dtpChallenDate;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.Label lblstockInNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.DataGridView dgvItemName;
        private System.Windows.Forms.TextBox txtToStock;
        private System.Windows.Forms.TextBox txtToQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConvertChallan;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblGodown;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvItem1;
        private System.Windows.Forms.Label lblToGodown;
        private System.Windows.Forms.Label lblToCurrentStock;
        private System.Windows.Forms.Label lblTobatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHerader;
    }
}