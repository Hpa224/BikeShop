namespace BikeShop.Forms
{
    partial class frmProductMaintenance
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            cboCategory = new ComboBox();
            lblSeverity = new Label();
            dgvInventory = new DataGridView();
            colProductID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colProductNumber = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            pnlDetails = new Panel();
            txtSize = new TextBox();
            lblSize = new Label();
            txtColor = new TextBox();
            lblColor = new Label();
            cboCategory2 = new ComboBox();
            txtListPrice = new TextBox();
            txtStandardCost = new TextBox();
            txtProductNumber = new TextBox();
            txtProductName = new TextBox();
            lblListPrice = new Label();
            lblStandardCost = new Label();
            lblCategory = new Label();
            lblProductNumber = new Label();
            lblProductName = new Label();
            lblBikeDetails = new Label();
            btnBack = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(31, 78, 121);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(538, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 30);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(345, 47);
            txtSearch.MaxLength = 100;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search product name...";
            txtSearch.Size = new Size(187, 31);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(271, 52);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 23);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(105, 49);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(155, 31);
            cboCategory.TabIndex = 0;
            // 
            // lblSeverity
            // 
            lblSeverity.AutoSize = true;
            lblSeverity.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeverity.Location = new Point(12, 52);
            lblSeverity.Name = "lblSeverity";
            lblSeverity.Size = new Size(86, 23);
            lblSeverity.TabIndex = 10;
            lblSeverity.Text = "Category:";
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.ColumnHeadersHeight = 26;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { colProductID, colName, colProductNumber, colCategory, colPrice });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(189, 215, 238);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.GridColor = Color.FromArgb(217, 217, 217);
            dgvInventory.Location = new Point(12, 113);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(469, 294);
            dgvInventory.TabIndex = 36;
            dgvInventory.CellClick += dgvInventory_CellClick;
            dgvInventory.CellContentClick += dgvInventory_CellContentClick;
            // 
            // colProductID
            // 
            colProductID.DataPropertyName = "ProductId";
            colProductID.FillWeight = 50F;
            colProductID.HeaderText = "ID";
            colProductID.Name = "colProductID";
            colProductID.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colProductNumber
            // 
            colProductNumber.DataPropertyName = "ProductNumber";
            colProductNumber.HeaderText = "Product No.";
            colProductNumber.Name = "colProductNumber";
            colProductNumber.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "ListPrice";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            colPrice.DefaultCellStyle = dataGridViewCellStyle2;
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(201, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 32);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(46, 125, 60);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(105, 413);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 32);
            btnUpdate.TabIndex = 38;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(31, 78, 121);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(9, 413);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 32);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlDetails
            // 
            pnlDetails.Controls.Add(txtSize);
            pnlDetails.Controls.Add(lblSize);
            pnlDetails.Controls.Add(txtColor);
            pnlDetails.Controls.Add(lblColor);
            pnlDetails.Controls.Add(cboCategory2);
            pnlDetails.Controls.Add(txtListPrice);
            pnlDetails.Controls.Add(txtStandardCost);
            pnlDetails.Controls.Add(txtProductNumber);
            pnlDetails.Controls.Add(txtProductName);
            pnlDetails.Controls.Add(lblListPrice);
            pnlDetails.Controls.Add(lblStandardCost);
            pnlDetails.Controls.Add(lblCategory);
            pnlDetails.Controls.Add(lblProductNumber);
            pnlDetails.Controls.Add(lblProductName);
            pnlDetails.Location = new Point(487, 113);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(310, 294);
            pnlDetails.TabIndex = 40;
            // 
            // txtSize
            // 
            txtSize.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSize.Location = new Point(155, 244);
            txtSize.MaxLength = 5;
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(146, 31);
            txtSize.TabIndex = 53;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(102, 252);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(47, 23);
            lblSize.TabIndex = 52;
            lblSize.Text = "Size:";
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColor.Location = new Point(155, 207);
            txtColor.MaxLength = 15;
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(146, 31);
            txtColor.TabIndex = 51;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(92, 215);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(57, 23);
            lblColor.TabIndex = 50;
            lblColor.Text = "Color:";
            // 
            // cboCategory2
            // 
            cboCategory2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategory2.FormattingEnabled = true;
            cboCategory2.Location = new Point(155, 99);
            cboCategory2.Name = "cboCategory2";
            cboCategory2.Size = new Size(146, 31);
            cboCategory2.TabIndex = 41;
            // 
            // txtListPrice
            // 
            txtListPrice.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtListPrice.Location = new Point(155, 170);
            txtListPrice.MaxLength = 15;
            txtListPrice.Name = "txtListPrice";
            txtListPrice.Size = new Size(146, 31);
            txtListPrice.TabIndex = 49;
            txtListPrice.TextChanged += txtListPrice_TextChanged;
            // 
            // txtStandardCost
            // 
            txtStandardCost.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStandardCost.Location = new Point(155, 136);
            txtStandardCost.MaxLength = 10;
            txtStandardCost.Name = "txtStandardCost";
            txtStandardCost.Size = new Size(146, 31);
            txtStandardCost.TabIndex = 48;
            // 
            // txtProductNumber
            // 
            txtProductNumber.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductNumber.Location = new Point(155, 62);
            txtProductNumber.MaxLength = 25;
            txtProductNumber.Name = "txtProductNumber";
            txtProductNumber.Size = new Size(146, 31);
            txtProductNumber.TabIndex = 47;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(155, 17);
            txtProductName.MaxLength = 50;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(146, 31);
            txtProductName.TabIndex = 41;
            // 
            // lblListPrice
            // 
            lblListPrice.AutoSize = true;
            lblListPrice.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListPrice.Location = new Point(62, 178);
            lblListPrice.Name = "lblListPrice";
            lblListPrice.Size = new Size(87, 23);
            lblListPrice.TabIndex = 46;
            lblListPrice.Text = "List Price:";
            // 
            // lblStandardCost
            // 
            lblStandardCost.AutoSize = true;
            lblStandardCost.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStandardCost.Location = new Point(24, 144);
            lblStandardCost.Name = "lblStandardCost";
            lblStandardCost.Size = new Size(125, 23);
            lblStandardCost.TabIndex = 45;
            lblStandardCost.Text = "Standard Cost:";
            lblStandardCost.Click += label3_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(63, 107);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(86, 23);
            lblCategory.TabIndex = 44;
            lblCategory.Text = "Category:";
            // 
            // lblProductNumber
            // 
            lblProductNumber.AutoSize = true;
            lblProductNumber.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductNumber.Location = new Point(6, 70);
            lblProductNumber.Name = "lblProductNumber";
            lblProductNumber.Size = new Size(146, 23);
            lblProductNumber.TabIndex = 43;
            lblProductNumber.Text = "Product Number:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(24, 25);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(128, 23);
            lblProductName.TabIndex = 42;
            lblProductName.Text = "Product Name:";
            // 
            // lblBikeDetails
            // 
            lblBikeDetails.AutoSize = true;
            lblBikeDetails.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBikeDetails.ForeColor = Color.FromArgb(31, 78, 121);
            lblBikeDetails.Location = new Point(654, 84);
            lblBikeDetails.Name = "lblBikeDetails";
            lblBikeDetails.Size = new Size(143, 26);
            lblBikeDetails.TabIndex = 41;
            lblBikeDetails.Text = "Product Details";
            lblBikeDetails.Click += lblBikeDetails_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(712, 413);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 30);
            btnBack.TabIndex = 41;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(487, 413);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 30);
            btnClear.TabIndex = 42;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // frmProductMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(pnlDetails);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvInventory);
            Controls.Add(cboCategory);
            Controls.Add(lblSeverity);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblBikeDetails);
            MaximizeBox = false;
            Name = "frmProductMaintenance";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Product Maintenance";
            Load += frmProductMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private ComboBox cboCategory;
        private Label lblSeverity;
        private DataGridView dgvInventory;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Panel pnlDetails;
        private Label lblListPrice;
        private Label lblStandardCost;
        private Label lblCategory;
        private Label lblProductNumber;
        private Label lblProductName;
        private Label lblBikeDetails;
        private ComboBox cboCategory2;
        private TextBox txtListPrice;
        private TextBox txtProductNumber;
        private TextBox txtProductName;
        private TextBox txtStandardCost;
        private Button btnBack;
        private TextBox txtColor;
        private Label lblColor;
        private TextBox txtSize;
        private Label lblSize;
        private Button btnClear;
        private DataGridViewTextBoxColumn colProductID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colProductNumber;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
    }
}