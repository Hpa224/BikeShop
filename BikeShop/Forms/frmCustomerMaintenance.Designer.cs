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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblPhone = new Label();
            mskPhone = new MaskedTextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblTitle = new Label();
            cboTitle = new ComboBox();
            lblSuffix = new Label();
            txtSuffix = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblCompanyName = new Label();
            txtCompanyName = new TextBox();
            lblAddressType = new Label();
            cboAddressType = new ComboBox();
            lblAddressLine1 = new Label();
            txtAddressLine1 = new TextBox();
            lblAddressLine2 = new Label();
            txtAddressLine2 = new TextBox();
            lblCountryRegion = new Label();
            cboCountryRegion = new ComboBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblStateProvince = new Label();
            txtStateProvince = new TextBox();
            lblPostalCode = new Label();
            mskPostalCode = new MaskedTextBox();
            btnFind = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvCustomers = new DataGridView();
            colCustomerID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colPurchases = new DataGridViewTextBoxColumn();
            btnPurchaseHistory = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(12, 13);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(115, 12);
            txtFirstName.MaxLength = 50;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 22);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(278, 13);
            lblLastName.Name = "lblLastName";
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(393, 12);
            txtLastName.MaxLength = 50;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 22);
            txtLastName.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(552, 13);
            lblPhone.Name = "lblPhone";
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone:";
            // 
            // mskPhone
            // 
            mskPhone.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskPhone.Location = new Point(660, 12);
            mskPhone.Mask = "000-000-0000";
            mskPhone.Name = "mskPhone";
            mskPhone.Size = new Size(110, 22);
            mskPhone.TabIndex = 5;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMiddleName.Location = new Point(12, 41);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.TabIndex = 6;
            lblMiddleName.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(115, 40);
            txtMiddleName.MaxLength = 50;
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(150, 22);
            txtMiddleName.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(278, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Title:";
            // 
            // cboTitle
            // 
            cboTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTitle.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTitle.FormattingEnabled = true;
            cboTitle.Location = new Point(393, 40);
            cboTitle.Name = "cboTitle";
            cboTitle.Size = new Size(80, 22);
            cboTitle.TabIndex = 9;
            cboTitle.Items.AddRange(new object[] { "Mr.", "Ms.", "Mrs.", "Dr." });
            // 
            // lblSuffix
            // 
            lblSuffix.AutoSize = true;
            lblSuffix.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuffix.Location = new Point(552, 41);
            lblSuffix.Name = "lblSuffix";
            lblSuffix.TabIndex = 10;
            lblSuffix.Text = "Suffix:";
            // 
            // txtSuffix
            // 
            txtSuffix.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSuffix.Location = new Point(660, 40);
            txtSuffix.MaxLength = 10;
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(80, 22);
            txtSuffix.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(12, 69);
            lblEmail.Name = "lblEmail";
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(115, 68);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 22);
            txtEmail.TabIndex = 13;
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompanyName.Location = new Point(278, 69);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.TabIndex = 14;
            lblCompanyName.Text = "Company:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCompanyName.Location = new Point(393, 68);
            txtCompanyName.MaxLength = 128;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(150, 22);
            txtCompanyName.TabIndex = 15;
            // 
            // lblAddressType
            // 
            lblAddressType.AutoSize = true;
            lblAddressType.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddressType.Location = new Point(552, 69);
            lblAddressType.Name = "lblAddressType";
            lblAddressType.TabIndex = 16;
            lblAddressType.Text = "Addr. Type:";
            // 
            // cboAddressType
            // 
            cboAddressType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAddressType.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboAddressType.FormattingEnabled = true;
            cboAddressType.Location = new Point(660, 68);
            cboAddressType.Name = "cboAddressType";
            cboAddressType.Size = new Size(128, 22);
            cboAddressType.TabIndex = 17;
            cboAddressType.Items.AddRange(new object[] { "Main Office", "Shipping", "Home" });
            // 
            // lblAddressLine1
            // 
            lblAddressLine1.AutoSize = true;
            lblAddressLine1.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddressLine1.Location = new Point(12, 97);
            lblAddressLine1.Name = "lblAddressLine1";
            lblAddressLine1.TabIndex = 18;
            lblAddressLine1.Text = "Address:";
            // 
            // txtAddressLine1
            // 
            txtAddressLine1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddressLine1.Location = new Point(115, 96);
            txtAddressLine1.MaxLength = 60;
            txtAddressLine1.Name = "txtAddressLine1";
            txtAddressLine1.Size = new Size(150, 22);
            txtAddressLine1.TabIndex = 19;
            // 
            // lblAddressLine2
            // 
            lblAddressLine2.AutoSize = true;
            lblAddressLine2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddressLine2.Location = new Point(278, 97);
            lblAddressLine2.Name = "lblAddressLine2";
            lblAddressLine2.TabIndex = 20;
            lblAddressLine2.Text = "Address 2:";
            // 
            // txtAddressLine2
            // 
            txtAddressLine2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddressLine2.Location = new Point(393, 96);
            txtAddressLine2.MaxLength = 60;
            txtAddressLine2.Name = "txtAddressLine2";
            txtAddressLine2.Size = new Size(150, 22);
            txtAddressLine2.TabIndex = 21;
            // 
            // lblCountryRegion
            // 
            lblCountryRegion.AutoSize = true;
            lblCountryRegion.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountryRegion.Location = new Point(552, 97);
            lblCountryRegion.Name = "lblCountryRegion";
            lblCountryRegion.TabIndex = 22;
            lblCountryRegion.Text = "Country:";
            // 
            // cboCountryRegion
            // 
            cboCountryRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCountryRegion.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCountryRegion.FormattingEnabled = true;
            cboCountryRegion.Location = new Point(660, 96);
            cboCountryRegion.Name = "cboCountryRegion";
            cboCountryRegion.Size = new Size(128, 22);
            cboCountryRegion.TabIndex = 23;
            cboCountryRegion.Items.AddRange(new object[] { "United States", "Canada", "United Kingdom" });
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCity.Location = new Point(12, 125);
            lblCity.Name = "lblCity";
            lblCity.TabIndex = 24;
            lblCity.Text = "City:";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.Location = new Point(115, 124);
            txtCity.MaxLength = 30;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 22);
            txtCity.TabIndex = 25;
            // 
            // lblStateProvince
            // 
            lblStateProvince.AutoSize = true;
            lblStateProvince.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStateProvince.Location = new Point(278, 125);
            lblStateProvince.Name = "lblStateProvince";
            lblStateProvince.TabIndex = 26;
            lblStateProvince.Text = "State:";
            // 
            // txtStateProvince
            // 
            txtStateProvince.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStateProvince.Location = new Point(393, 124);
            txtStateProvince.MaxLength = 50;
            txtStateProvince.Name = "txtStateProvince";
            txtStateProvince.Size = new Size(150, 22);
            txtStateProvince.TabIndex = 27;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPostalCode.Location = new Point(552, 125);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.TabIndex = 28;
            lblPostalCode.Text = "Zip Code:";
            // 
            // mskPostalCode
            // 
            mskPostalCode.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskPostalCode.Location = new Point(660, 124);
            mskPostalCode.Mask = "00000";
            mskPostalCode.Name = "mskPostalCode";
            mskPostalCode.Size = new Size(70, 22);
            mskPostalCode.TabIndex = 29;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(31, 78, 121);
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(12, 158);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 32);
            btnFind.TabIndex = 30;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(31, 78, 121);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(112, 158);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 32);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 125, 60);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(212, 158);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 32);
            btnSave.TabIndex = 32;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(312, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 32);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(127, 127, 127);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(412, 158);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 32);
            btnClear.TabIndex = 34;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.ColumnHeadersHeight = 26;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(189, 215, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.GridColor = Color.FromArgb(217, 217, 217);
            dgvCustomers.Location = new Point(12, 200);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(776, 180);
            dgvCustomers.TabIndex = 35;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colCustomerID, colName, colPhone, colEmail, colPurchases });
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "";
            colPurchases.DefaultCellStyle = dataGridViewCellStyle3;
            colPurchases.HeaderText = "Purchases";
            colPurchases.Name = "colPurchases";
            colPurchases.ReadOnly = true;
            colPurchases.Width = 90;
            // 
            // btnPurchaseHistory
            // 
            btnPurchaseHistory.BackColor = Color.FromArgb(31, 78, 121);
            btnPurchaseHistory.FlatAppearance.BorderSize = 0;
            btnPurchaseHistory.FlatStyle = FlatStyle.Flat;
            btnPurchaseHistory.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchaseHistory.ForeColor = Color.White;
            btnPurchaseHistory.Location = new Point(12, 393);
            btnPurchaseHistory.Name = "btnPurchaseHistory";
            btnPurchaseHistory.Size = new Size(200, 45);
            btnPurchaseHistory.TabIndex = 36;
            btnPurchaseHistory.Text = "View Purchase History";
            btnPurchaseHistory.UseVisualStyleBackColor = false;
            btnPurchaseHistory.Click += btnPurchaseHistory_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(127, 127, 127);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(643, 393);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(145, 45);
            btnBack.TabIndex = 37;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmCustomerMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnPurchaseHistory);
            Controls.Add(dgvCustomers);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(btnFind);
            Controls.Add(mskPostalCode);
            Controls.Add(lblPostalCode);
            Controls.Add(txtStateProvince);
            Controls.Add(lblStateProvince);
            Controls.Add(txtCity);
            Controls.Add(lblCity);
            Controls.Add(cboCountryRegion);
            Controls.Add(lblCountryRegion);
            Controls.Add(txtAddressLine2);
            Controls.Add(lblAddressLine2);
            Controls.Add(txtAddressLine1);
            Controls.Add(lblAddressLine1);
            Controls.Add(cboAddressType);
            Controls.Add(lblAddressType);
            Controls.Add(txtCompanyName);
            Controls.Add(lblCompanyName);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtSuffix);
            Controls.Add(lblSuffix);
            Controls.Add(cboTitle);
            Controls.Add(lblTitle);
            Controls.Add(txtMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(mskPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCustomerMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            Load += frmCustomerMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblPhone;
        private MaskedTextBox mskPhone;
        private Label lblMiddleName;
        private TextBox txtMiddleName;
        private Label lblTitle;
        private ComboBox cboTitle;
        private Label lblSuffix;
        private TextBox txtSuffix;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblCompanyName;
        private TextBox txtCompanyName;
        private Label lblAddressType;
        private ComboBox cboAddressType;
        private Label lblAddressLine1;
        private TextBox txtAddressLine1;
        private Label lblAddressLine2;
        private TextBox txtAddressLine2;
        private Label lblCountryRegion;
        private ComboBox cboCountryRegion;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblStateProvince;
        private TextBox txtStateProvince;
        private Label lblPostalCode;
        private MaskedTextBox mskPostalCode;
        private Button btnFind;
        private Button btnAdd;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn colCustomerID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colPurchases;
        private Button btnPurchaseHistory;
        private Button btnBack;
    }
}
