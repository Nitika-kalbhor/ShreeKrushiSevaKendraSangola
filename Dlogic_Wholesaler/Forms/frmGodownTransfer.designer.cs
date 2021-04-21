namespace Dlogic_Wholesaler.Forms
{
    partial class frmGodownTransfer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbtoGodown = new System.Windows.Forms.ComboBox();
            this.cmbFromGodown = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlgodownSearch = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pnlUpdateTransfer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvGownTransferList = new System.Windows.Forms.DataGridView();
            this.FinancialYearID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godownTransferId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godownTransferDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromGodownTransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toGodownTransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtpToChallanDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFromChallanDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnSaleInvoiceList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvGodownTransfer = new System.Windows.Forms.DataGridView();
            this.stockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godownTransfertemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFD_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockIdTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHerader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlgodownSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlUpdateTransfer.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGownTransferList)).BeginInit();
            this.pnlDate.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodownTransfer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtInvoice);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.cmbtoGodown);
            this.panel1.Controls.Add(this.cmbFromGodown);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(20, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 106);
            this.panel1.TabIndex = 243;
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(133, 18);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(188, 29);
            this.txtInvoice.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(459, 18);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(234, 29);
            this.dtpDate.TabIndex = 1;
            // 
            // cmbtoGodown
            // 
            this.cmbtoGodown.FormattingEnabled = true;
            this.cmbtoGodown.Location = new System.Drawing.Point(459, 59);
            this.cmbtoGodown.Name = "cmbtoGodown";
            this.cmbtoGodown.Size = new System.Drawing.Size(234, 29);
            this.cmbtoGodown.TabIndex = 4;
            // 
            // cmbFromGodown
            // 
            this.cmbFromGodown.FormattingEnabled = true;
            this.cmbFromGodown.Location = new System.Drawing.Point(134, 59);
            this.cmbFromGodown.Name = "cmbFromGodown";
            this.cmbFromGodown.Size = new System.Drawing.Size(188, 29);
            this.cmbFromGodown.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(699, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(188, 29);
            this.txtId.TabIndex = 2;
            this.txtId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "To गोडाऊन :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "From गोडाऊन :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "दिनांक :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "क्र.:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(242)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(20, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1103, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 242;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlgodownSearch);
            this.panel2.Controls.Add(this.pnlBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.panel2.Location = new System.Drawing.Point(20, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 168);
            this.panel2.TabIndex = 244;
            // 
            // pnlgodownSearch
            // 
            this.pnlgodownSearch.Controls.Add(this.dgvList);
            this.pnlgodownSearch.Controls.Add(this.pnlUpdateTransfer);
            this.pnlgodownSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlgodownSearch.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold);
            this.pnlgodownSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlgodownSearch.Name = "pnlgodownSearch";
            this.pnlgodownSearch.Size = new System.Drawing.Size(661, 168);
            this.pnlgodownSearch.TabIndex = 2;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.ColumnHeadersVisible = false;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvList.GridColor = System.Drawing.Color.Black;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(661, 168);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // pnlUpdateTransfer
            // 
            this.pnlUpdateTransfer.Controls.Add(this.panel4);
            this.pnlUpdateTransfer.Controls.Add(this.pnlDate);
            this.pnlUpdateTransfer.Location = new System.Drawing.Point(3, 6);
            this.pnlUpdateTransfer.Name = "pnlUpdateTransfer";
            this.pnlUpdateTransfer.Size = new System.Drawing.Size(571, 159);
            this.pnlUpdateTransfer.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvGownTransferList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Arial Unicode MS", 10F);
            this.panel4.Location = new System.Drawing.Point(0, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(571, 110);
            this.panel4.TabIndex = 1;
            // 
            // dgvGownTransferList
            // 
            this.dgvGownTransferList.AllowUserToAddRows = false;
            this.dgvGownTransferList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGownTransferList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGownTransferList.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvGownTransferList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGownTransferList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FinancialYearID,
            this.godownTransferId,
            this.invoiceId,
            this.godownTransferDate,
            this.fromGodownTransfer,
            this.toGodownTransfer});
            this.dgvGownTransferList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGownTransferList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGownTransferList.GridColor = System.Drawing.Color.Black;
            this.dgvGownTransferList.Location = new System.Drawing.Point(0, 0);
            this.dgvGownTransferList.Name = "dgvGownTransferList";
            this.dgvGownTransferList.RowHeadersVisible = false;
            this.dgvGownTransferList.Size = new System.Drawing.Size(571, 110);
            this.dgvGownTransferList.TabIndex = 1;
            this.dgvGownTransferList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGownTransferList_CellClick);
            // 
            // FinancialYearID
            // 
            this.FinancialYearID.DataPropertyName = "FinancialYearID";
            this.FinancialYearID.HeaderText = "FinancialYearID";
            this.FinancialYearID.Name = "FinancialYearID";
            this.FinancialYearID.Visible = false;
            // 
            // godownTransferId
            // 
            this.godownTransferId.DataPropertyName = "godownTransferId";
            this.godownTransferId.HeaderText = "ID";
            this.godownTransferId.Name = "godownTransferId";
            this.godownTransferId.Visible = false;
            // 
            // invoiceId
            // 
            this.invoiceId.DataPropertyName = "invoiceId";
            this.invoiceId.HeaderText = "Invoice Id";
            this.invoiceId.Name = "invoiceId";
            // 
            // godownTransferDate
            // 
            this.godownTransferDate.DataPropertyName = "godownTransferDate";
            dataGridViewCellStyle2.Format = "dd-MM-yyyy";
            this.godownTransferDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.godownTransferDate.HeaderText = "दिनांक";
            this.godownTransferDate.Name = "godownTransferDate";
            // 
            // fromGodownTransfer
            // 
            this.fromGodownTransfer.DataPropertyName = "fromGodownTransfer";
            this.fromGodownTransfer.HeaderText = "From गोडाऊन";
            this.fromGodownTransfer.Name = "fromGodownTransfer";
            // 
            // toGodownTransfer
            // 
            this.toGodownTransfer.DataPropertyName = "toGodownTransfer";
            this.toGodownTransfer.HeaderText = "to गोडाऊन";
            this.toGodownTransfer.Name = "toGodownTransfer";
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.btnShow);
            this.pnlDate.Controls.Add(this.dtpToChallanDate);
            this.pnlDate.Controls.Add(this.label5);
            this.pnlDate.Controls.Add(this.dtpFromChallanDate);
            this.pnlDate.Controls.Add(this.label6);
            this.pnlDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDate.Location = new System.Drawing.Point(0, 0);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(571, 49);
            this.pnlDate.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(440, 13);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(91, 34);
            this.btnShow.TabIndex = 350;
            this.btnShow.Text = "दाखवा ";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtpToChallanDate
            // 
            this.dtpToChallanDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToChallanDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToChallanDate.Location = new System.Drawing.Point(306, 14);
            this.dtpToChallanDate.Name = "dtpToChallanDate";
            this.dtpToChallanDate.Size = new System.Drawing.Size(112, 29);
            this.dtpToChallanDate.TabIndex = 349;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 348;
            this.label5.Text = "ते दिनांक:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpFromChallanDate
            // 
            this.dtpFromChallanDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromChallanDate.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromChallanDate.Location = new System.Drawing.Point(117, 14);
            this.dtpFromChallanDate.Name = "dtpFromChallanDate";
            this.dtpFromChallanDate.Size = new System.Drawing.Size(116, 29);
            this.dtpFromChallanDate.TabIndex = 347;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 346;
            this.label6.Text = "पासून दिनांक:";
            // 
            // pnlBtn
            // 
            this.pnlBtn.Controls.Add(this.btnSaleInvoiceList);
            this.pnlBtn.Controls.Add(this.btnDelete);
            this.pnlBtn.Controls.Add(this.btnnew);
            this.pnlBtn.Controls.Add(this.btnSave);
            this.pnlBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBtn.Location = new System.Drawing.Point(661, 0);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(442, 168);
            this.pnlBtn.TabIndex = 0;
            // 
            // btnSaleInvoiceList
            // 
            this.btnSaleInvoiceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnSaleInvoiceList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSaleInvoiceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleInvoiceList.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleInvoiceList.ForeColor = System.Drawing.Color.White;
            this.btnSaleInvoiceList.Location = new System.Drawing.Point(335, 121);
            this.btnSaleInvoiceList.Name = "btnSaleInvoiceList";
            this.btnSaleInvoiceList.Size = new System.Drawing.Size(104, 34);
            this.btnSaleInvoiceList.TabIndex = 2;
            this.btnSaleInvoiceList.Text = "बिल यादी ";
            this.btnSaleInvoiceList.UseVisualStyleBackColor = false;
            this.btnSaleInvoiceList.Click += new System.EventHandler(this.btnSaleInvoiceList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(243, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(9, 121);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(113, 34);
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
            this.btnSave.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(124, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "जतन (Alt+S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvGodownTransfer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.panel3.Location = new System.Drawing.Point(20, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1103, 155);
            this.panel3.TabIndex = 245;
            // 
            // dgvGodownTransfer
            // 
            this.dgvGodownTransfer.AllowUserToAddRows = false;
            this.dgvGodownTransfer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGodownTransfer.BackgroundColor = System.Drawing.Color.White;
            this.dgvGodownTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGodownTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockId,
            this.itemId,
            this.companyId,
            this.categoryId,
            this.productCode,
            this.godownTransfertemId,
            this.ItemName,
            this.batchNo,
            this.unitBy,
            this.MFD_Date,
            this.expireDate,
            this.Quantity,
            this.stockIdTo});
            this.dgvGodownTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGodownTransfer.GridColor = System.Drawing.Color.Black;
            this.dgvGodownTransfer.Location = new System.Drawing.Point(0, 0);
            this.dgvGodownTransfer.Name = "dgvGodownTransfer";
            this.dgvGodownTransfer.RowHeadersVisible = false;
            this.dgvGodownTransfer.Size = new System.Drawing.Size(1103, 155);
            this.dgvGodownTransfer.TabIndex = 0;
            this.dgvGodownTransfer.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGodownTransfer_CellMouseUp);
            this.dgvGodownTransfer.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvGodownTransfer_CurrentCellDirtyStateChanged);
            this.dgvGodownTransfer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvGodownTransfer_KeyDown);
            // 
            // stockId
            // 
            this.stockId.HeaderText = "stockId";
            this.stockId.Name = "stockId";
            this.stockId.Visible = false;
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
            // categoryId
            // 
            this.categoryId.HeaderText = "categoryId";
            this.categoryId.Name = "categoryId";
            this.categoryId.Visible = false;
            // 
            // productCode
            // 
            this.productCode.HeaderText = "productCode";
            this.productCode.Name = "productCode";
            this.productCode.Visible = false;
            // 
            // godownTransfertemId
            // 
            this.godownTransfertemId.HeaderText = "godownTransfertemId";
            this.godownTransfertemId.Name = "godownTransfertemId";
            this.godownTransfertemId.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.HeaderText = "वस्तूचे नांव";
            this.ItemName.Name = "ItemName";
            // 
            // batchNo
            // 
            this.batchNo.HeaderText = "बॅच नं";
            this.batchNo.Name = "batchNo";
            this.batchNo.ReadOnly = true;
            // 
            // unitBy
            // 
            this.unitBy.HeaderText = "unitBy";
            this.unitBy.Name = "unitBy";
            this.unitBy.ReadOnly = true;
            // 
            // MFD_Date
            // 
            this.MFD_Date.HeaderText = "MFG दिनांक";
            this.MFD_Date.Name = "MFD_Date";
            this.MFD_Date.ReadOnly = true;
            this.MFD_Date.Width = 150;
            // 
            // expireDate
            // 
            this.expireDate.HeaderText = "एक्स दिनांक";
            this.expireDate.Name = "expireDate";
            this.expireDate.ReadOnly = true;
            this.expireDate.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "नग";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 188;
            // 
            // stockIdTo
            // 
            this.stockIdTo.HeaderText = "stockIdTo";
            this.stockIdTo.Name = "stockIdTo";
            this.stockIdTo.ReadOnly = true;
            this.stockIdTo.Visible = false;
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
            // lblHerader
            // 
            this.lblHerader.AutoSize = true;
            this.lblHerader.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerader.Location = new System.Drawing.Point(17, 7);
            this.lblHerader.Name = "lblHerader";
            this.lblHerader.Size = new System.Drawing.Size(178, 33);
            this.lblHerader.TabIndex = 349;
            this.lblHerader.Text = " गोडाऊन  ट्रान्स्फर";
            // 
            // frmGodownTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 519);
            this.Controls.Add(this.lblHerader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "frmGodownTransfer";
            this.Load += new System.EventHandler(this.frmGodownTransfer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGodownTransfer_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlgodownSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlUpdateTransfer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGownTransferList)).EndInit();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.pnlBtn.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodownTransfer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbtoGodown;
        private System.Windows.Forms.ComboBox cmbFromGodown;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel pnlUpdateTransfer;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.DataGridView dgvGodownTransfer;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.DataGridView dgvGownTransferList;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dtpToChallanDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFromChallanDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlgodownSearch;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnSaleInvoiceList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn godownTransfertemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFD_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIdTo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinancialYearID;
        private System.Windows.Forms.DataGridViewTextBoxColumn godownTransferId;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn godownTransferDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromGodownTransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn toGodownTransfer;
        private System.Windows.Forms.Label lblHerader;
    }
}