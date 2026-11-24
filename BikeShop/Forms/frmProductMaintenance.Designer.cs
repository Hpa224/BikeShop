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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            cboType = new ComboBox();
            lblSeverity = new Label();
            dgvInventory = new DataGridView();
            colCustomerID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colPurchases = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel1 = new Panel();
            cboType2 = new ComboBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtModel = new TextBox();
            txtBrand = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblType = new Label();
            lvlBikeDetails = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(31, 78, 121);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(538, 43);
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
            txtSearch.Size = new Size(187, 31);
            txtSearch.TabIndex = 4;
            txtSearch.Text = "Brand or model...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(271, 50);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 23);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search:";
            // 
            // cboType
            // 
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(70, 47);
            cboType.Name = "cboType";
            cboType.Size = new Size(155, 31);
            cboType.TabIndex = 11;
            // 
            // lblSeverity
            // 
            lblSeverity.AutoSize = true;
            lblSeverity.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeverity.Location = new Point(12, 50);
            lblSeverity.Name = "lblSeverity";
            lblSeverity.Size = new Size(52, 23);
            lblSeverity.TabIndex = 10;
            lblSeverity.Text = "Type:";
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AllowUserToResizeRows = false;
            dgvInventory.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvInventory.ColumnHeadersHeight = 26;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { colCustomerID, colName, colPhone, colEmail, colPurchases });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(189, 215, 238);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle6;
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.GridColor = Color.FromArgb(217, 217, 217);
            dgvInventory.Location = new Point(12, 113);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(469, 208);
            dgvInventory.TabIndex = 36;
            // 
            // colCustomerID
            // 
            colCustomerID.HeaderText = "ID";
            colCustomerID.Name = "colCustomerID";
            colCustomerID.ReadOnly = true;
            colCustomerID.Width = 60;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 210;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 130;
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colPurchases
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPurchases.DefaultCellStyle = dataGridViewCellStyle5;
            colPurchases.HeaderText = "Purchases";
            colPurchases.Name = "colPurchases";
            colPurchases.ReadOnly = true;
            colPurchases.Width = 90;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(213, 406);
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
            btnUpdate.Location = new Point(113, 406);
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
            btnAdd.Location = new Point(13, 406);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 32);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cboType2);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtModel);
            panel1.Controls.Add(txtBrand);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblType);
            panel1.Controls.Add(lvlBikeDetails);
            panel1.Location = new Point(513, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 294);
            panel1.TabIndex = 40;
            // 
            // cboType2
            // 
            cboType2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboType2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboType2.FormattingEnabled = true;
            cboType2.Location = new Point(118, 129);
            cboType2.Name = "cboType2";
            cboType2.Size = new Size(147, 31);
            cboType2.TabIndex = 41;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(118, 200);
            txtQuantity.MaxLength = 5;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(147, 31);
            txtQuantity.TabIndex = 49;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(118, 166);
            txtPrice.MaxLength = 10;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(147, 31);
            txtPrice.TabIndex = 48;
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModel.Location = new Point(118, 92);
            txtModel.MaxLength = 100;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(147, 31);
            txtModel.TabIndex = 47;
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrand.Location = new Point(118, 52);
            txtBrand.MaxLength = 100;
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(147, 31);
            txtBrand.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 203);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 46;
            label4.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 169);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 45;
            label3.Text = "Price:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 132);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 44;
            label2.Text = "Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 92);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 43;
            label1.Text = "Model:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(28, 55);
            lblType.Name = "lblType";
            lblType.Size = new Size(62, 23);
            lblType.TabIndex = 42;
            lblType.Text = "Brand:";
            // 
            // lvlBikeDetails
            // 
            lvlBikeDetails.AutoSize = true;
            lvlBikeDetails.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvlBikeDetails.ForeColor = Color.FromArgb(31, 78, 121);
            lvlBikeDetails.Location = new Point(25, 10);
            lvlBikeDetails.Name = "lvlBikeDetails";
            lvlBikeDetails.Size = new Size(113, 26);
            lvlBikeDetails.TabIndex = 41;
            lvlBikeDetails.Text = "Bike Details";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(703, 413);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 30);
            btnBack.TabIndex = 41;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmProductMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvInventory);
            Controls.Add(cboType);
            Controls.Add(lblSeverity);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Name = "frmProductMaintenance";
            Text = "Inventory";
            Load += frmProductMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private ComboBox cboType;
        private Label lblSeverity;
        private DataGridView dgvInventory;
        private DataGridViewTextBoxColumn colCustomerID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colPurchases;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblType;
        private Label lvlBikeDetails;
        private ComboBox cboType2;
        private TextBox txtQuantity;
        private TextBox txtModel;
        private TextBox txtBrand;
        private TextBox txtPrice;
        private Button btnBack;
    }
}