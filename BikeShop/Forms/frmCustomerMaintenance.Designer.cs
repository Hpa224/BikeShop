namespace BikeShop.Forms
{
    partial class frmCustomerMaintenance
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
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnFind = new Button();
            btnShowAll = new Button();
            dgvCustomers = new DataGridView();
            colCustomerID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCompany = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            grpCustomer = new GroupBox();
            lblTitle = new Label();
            cboTitle = new ComboBox();
            lblSuffix = new Label();
            txtSuffix = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblCompanyName = new Label();
            txtCompanyName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            mskPhone = new MaskedTextBox();
            grpAddress = new GroupBox();
            lblAddressType = new Label();
            cboAddressType = new ComboBox();
            lblAddressLine1 = new Label();
            txtAddressLine1 = new TextBox();
            lblAddressLine2 = new Label();
            txtAddressLine2 = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblStateProvince = new Label();
            txtStateProvince = new TextBox();
            lblPostalCode = new Label();
            mskPostalCode = new MaskedTextBox();
            lblCountryRegion = new Label();
            cboCountryRegion = new ComboBox();
            btnAdd = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnPurchaseHistory = new Button();
            btnBack = new Button();
            grpCustomer.SuspendLayout();
            grpAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(15, 17);
            lblSearch.Name = "lblSearch";
            lblSearch.Text = "Search:";
            lblSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(80, 14);
            txtSearch.MaxLength = 50;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 25);
            txtSearch.TabIndex = 1;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(46, 125, 60);
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(390, 10);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(100, 32);
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.TabIndex = 2;
            btnFind.Click += btnFind_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.FromArgb(31, 78, 121);
            btnShowAll.FlatAppearance.BorderSize = 0;
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAll.ForeColor = Color.White;
            btnShowAll.Location = new Point(500, 10);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(100, 32);
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.TabIndex = 3;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.BackgroundColor = SystemColors.Window;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(15, 50);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(770, 110);
            dgvCustomers.TabIndex = 4;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colCustomerID, colName, colCompany, colPhone, colEmail });
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // colCustomerID
            // 
            colCustomerID.HeaderText = "ID";
            colCustomerID.Name = "colCustomerID";
            colCustomerID.ReadOnly = true;
            colCustomerID.Width = 55;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 170;
            // 
            // colCompany
            // 
            colCompany.HeaderText = "Company";
            colCompany.Name = "colCompany";
            colCompany.ReadOnly = true;
            colCompany.Width = 190;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 115;
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // grpCustomer
            // 
            grpCustomer.Controls.Add(mskPhone);
            grpCustomer.Controls.Add(lblPhone);
            grpCustomer.Controls.Add(txtEmail);
            grpCustomer.Controls.Add(lblEmail);
            grpCustomer.Controls.Add(txtCompanyName);
            grpCustomer.Controls.Add(lblCompanyName);
            grpCustomer.Controls.Add(txtLastName);
            grpCustomer.Controls.Add(lblLastName);
            grpCustomer.Controls.Add(txtMiddleName);
            grpCustomer.Controls.Add(lblMiddleName);
            grpCustomer.Controls.Add(txtFirstName);
            grpCustomer.Controls.Add(lblFirstName);
            grpCustomer.Controls.Add(txtSuffix);
            grpCustomer.Controls.Add(lblSuffix);
            grpCustomer.Controls.Add(cboTitle);
            grpCustomer.Controls.Add(lblTitle);
            grpCustomer.Location = new Point(15, 166);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Size = new Size(380, 228);
            grpCustomer.TabStop = false;
            grpCustomer.Text = "Customer Information";
            grpCustomer.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(10, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Title:";
            lblTitle.TabIndex = 6;
            // 
            // cboTitle
            // 
            cboTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTitle.FormattingEnabled = true;
            cboTitle.Location = new Point(110, 24);
            cboTitle.Name = "cboTitle";
            cboTitle.Size = new Size(80, 26);
            cboTitle.TabIndex = 7;
            cboTitle.Items.AddRange(new object[] { "Mr.", "Ms.", "Mrs.", "Dr." });
            // 
            // lblSuffix
            // 
            lblSuffix.AutoSize = true;
            lblSuffix.Location = new Point(205, 27);
            lblSuffix.Name = "lblSuffix";
            lblSuffix.Text = "Suffix:";
            lblSuffix.TabIndex = 8;
            // 
            // txtSuffix
            // 
            txtSuffix.Location = new Point(260, 24);
            txtSuffix.MaxLength = 10;
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(105, 25);
            txtSuffix.TabIndex = 9;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(10, 55);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Text = "First Name:";
            lblFirstName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(110, 52);
            txtFirstName.MaxLength = 50;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(255, 25);
            txtFirstName.TabIndex = 11;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(10, 83);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Text = "Middle Name:";
            lblMiddleName.TabIndex = 12;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(110, 80);
            txtMiddleName.MaxLength = 50;
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(255, 25);
            txtMiddleName.TabIndex = 13;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(10, 111);
            lblLastName.Name = "lblLastName";
            lblLastName.Text = "Last Name:";
            lblLastName.TabIndex = 14;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(110, 108);
            txtLastName.MaxLength = 50;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(255, 25);
            txtLastName.TabIndex = 15;
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(10, 139);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Text = "Company:";
            lblCompanyName.TabIndex = 16;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(110, 136);
            txtCompanyName.MaxLength = 128;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(255, 25);
            txtCompanyName.TabIndex = 17;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 167);
            lblEmail.Name = "lblEmail";
            lblEmail.Text = "Email:";
            lblEmail.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(110, 164);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(255, 25);
            txtEmail.TabIndex = 19;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(10, 195);
            lblPhone.Name = "lblPhone";
            lblPhone.Text = "Phone:";
            lblPhone.TabIndex = 20;
            // 
            // mskPhone
            // 
            mskPhone.Location = new Point(110, 192);
            mskPhone.Mask = "000-000-0000";
            mskPhone.Name = "mskPhone";
            mskPhone.Size = new Size(120, 25);
            mskPhone.TabIndex = 21;
            // 
            // grpAddress
            // 
            grpAddress.Controls.Add(cboCountryRegion);
            grpAddress.Controls.Add(lblCountryRegion);
            grpAddress.Controls.Add(mskPostalCode);
            grpAddress.Controls.Add(lblPostalCode);
            grpAddress.Controls.Add(txtStateProvince);
            grpAddress.Controls.Add(lblStateProvince);
            grpAddress.Controls.Add(txtCity);
            grpAddress.Controls.Add(lblCity);
            grpAddress.Controls.Add(txtAddressLine2);
            grpAddress.Controls.Add(lblAddressLine2);
            grpAddress.Controls.Add(txtAddressLine1);
            grpAddress.Controls.Add(lblAddressLine1);
            grpAddress.Controls.Add(cboAddressType);
            grpAddress.Controls.Add(lblAddressType);
            grpAddress.Location = new Point(405, 166);
            grpAddress.Name = "grpAddress";
            grpAddress.Size = new Size(380, 228);
            grpAddress.TabStop = false;
            grpAddress.Text = "Address";
            grpAddress.TabIndex = 22;
            // 
            // lblAddressType
            // 
            lblAddressType.AutoSize = true;
            lblAddressType.Location = new Point(10, 27);
            lblAddressType.Name = "lblAddressType";
            lblAddressType.Text = "Address Type:";
            lblAddressType.TabIndex = 23;
            // 
            // cboAddressType
            // 
            cboAddressType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAddressType.FormattingEnabled = true;
            cboAddressType.Location = new Point(115, 24);
            cboAddressType.Name = "cboAddressType";
            cboAddressType.Size = new Size(150, 26);
            cboAddressType.TabIndex = 24;
            cboAddressType.Items.AddRange(new object[] { "Main Office", "Shipping", "Home" });
            // 
            // lblAddressLine1
            // 
            lblAddressLine1.AutoSize = true;
            lblAddressLine1.Location = new Point(10, 55);
            lblAddressLine1.Name = "lblAddressLine1";
            lblAddressLine1.Text = "Address 1:";
            lblAddressLine1.TabIndex = 25;
            // 
            // txtAddressLine1
            // 
            txtAddressLine1.Location = new Point(115, 52);
            txtAddressLine1.MaxLength = 60;
            txtAddressLine1.Name = "txtAddressLine1";
            txtAddressLine1.Size = new Size(250, 25);
            txtAddressLine1.TabIndex = 26;
            // 
            // lblAddressLine2
            // 
            lblAddressLine2.AutoSize = true;
            lblAddressLine2.Location = new Point(10, 83);
            lblAddressLine2.Name = "lblAddressLine2";
            lblAddressLine2.Text = "Address 2:";
            lblAddressLine2.TabIndex = 27;
            // 
            // txtAddressLine2
            // 
            txtAddressLine2.Location = new Point(115, 80);
            txtAddressLine2.MaxLength = 60;
            txtAddressLine2.Name = "txtAddressLine2";
            txtAddressLine2.Size = new Size(250, 25);
            txtAddressLine2.TabIndex = 28;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(10, 111);
            lblCity.Name = "lblCity";
            lblCity.Text = "City:";
            lblCity.TabIndex = 29;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(115, 108);
            txtCity.MaxLength = 30;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(250, 25);
            txtCity.TabIndex = 30;
            // 
            // lblStateProvince
            // 
            lblStateProvince.AutoSize = true;
            lblStateProvince.Location = new Point(10, 139);
            lblStateProvince.Name = "lblStateProvince";
            lblStateProvince.Text = "State/Province:";
            lblStateProvince.TabIndex = 31;
            // 
            // txtStateProvince
            // 
            txtStateProvince.Location = new Point(115, 136);
            txtStateProvince.MaxLength = 50;
            txtStateProvince.Name = "txtStateProvince";
            txtStateProvince.Size = new Size(250, 25);
            txtStateProvince.TabIndex = 32;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(10, 167);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Text = "Postal Code:";
            lblPostalCode.TabIndex = 33;
            // 
            // mskPostalCode
            // 
            mskPostalCode.Location = new Point(115, 164);
            mskPostalCode.Mask = "00000";
            mskPostalCode.Name = "mskPostalCode";
            mskPostalCode.Size = new Size(80, 25);
            mskPostalCode.TabIndex = 34;
            // 
            // lblCountryRegion
            // 
            lblCountryRegion.AutoSize = true;
            lblCountryRegion.Location = new Point(10, 195);
            lblCountryRegion.Name = "lblCountryRegion";
            lblCountryRegion.Text = "Country:";
            lblCountryRegion.TabIndex = 35;
            // 
            // cboCountryRegion
            // 
            cboCountryRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCountryRegion.FormattingEnabled = true;
            cboCountryRegion.Location = new Point(115, 192);
            cboCountryRegion.Name = "cboCountryRegion";
            cboCountryRegion.Size = new Size(180, 26);
            cboCountryRegion.TabIndex = 36;
            cboCountryRegion.Items.AddRange(new object[] { "United States", "Canada", "United Kingdom" });
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 125, 60);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(15, 402);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.TabIndex = 37;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 125, 60);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(125, 402);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.TabIndex = 38;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(235, 402);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.TabIndex = 39;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(31, 78, 121);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(345, 402);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.TabIndex = 40;
            btnClear.Click += btnClear_Click;
            // 
            // btnPurchaseHistory
            // 
            btnPurchaseHistory.BackColor = Color.FromArgb(31, 78, 121);
            btnPurchaseHistory.FlatAppearance.BorderSize = 0;
            btnPurchaseHistory.FlatStyle = FlatStyle.Flat;
            btnPurchaseHistory.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchaseHistory.ForeColor = Color.White;
            btnPurchaseHistory.Location = new Point(455, 402);
            btnPurchaseHistory.Name = "btnPurchaseHistory";
            btnPurchaseHistory.Size = new Size(170, 40);
            btnPurchaseHistory.Text = "Purchase History";
            btnPurchaseHistory.UseVisualStyleBackColor = false;
            btnPurchaseHistory.TabIndex = 41;
            btnPurchaseHistory.Click += btnPurchaseHistory_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(192, 0, 0);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(685, 402);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 40);
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.TabIndex = 42;
            btnBack.Click += btnBack_Click;
            // 
            // frmCustomerMaintenance
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnPurchaseHistory);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(grpAddress);
            Controls.Add(grpCustomer);
            Controls.Add(dgvCustomers);
            Controls.Add(btnShowAll);
            Controls.Add(btnFind);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            AcceptButton = btnFind;
            Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmCustomerMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            Load += frmCustomerMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            grpAddress.ResumeLayout(false);
            grpAddress.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnFind;
        private Button btnShowAll;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn colCustomerID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCompany;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private GroupBox grpCustomer;
        private Label lblTitle;
        private ComboBox cboTitle;
        private Label lblSuffix;
        private TextBox txtSuffix;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblMiddleName;
        private TextBox txtMiddleName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblCompanyName;
        private TextBox txtCompanyName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private MaskedTextBox mskPhone;
        private GroupBox grpAddress;
        private Label lblAddressType;
        private ComboBox cboAddressType;
        private Label lblAddressLine1;
        private TextBox txtAddressLine1;
        private Label lblAddressLine2;
        private TextBox txtAddressLine2;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblStateProvince;
        private TextBox txtStateProvince;
        private Label lblPostalCode;
        private MaskedTextBox mskPostalCode;
        private Label lblCountryRegion;
        private ComboBox cboCountryRegion;
        private Button btnAdd;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClear;
        private Button btnPurchaseHistory;
        private Button btnBack;
    }
}
