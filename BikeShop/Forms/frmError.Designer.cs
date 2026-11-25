namespace BikeShop.Forms
{
    partial class frmError
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
            lblLogs = new Label();
            lblDate = new Label();
            label1 = new Label();
            btnSearch2 = new Button();
            lblSeverity = new Label();
            cboSeverity = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            colErrorMessage = new DataGridViewTextBoxColumn();
            ErrorSeverity = new DataGridViewTextBoxColumn();
            ErrorNumber = new DataGridViewTextBoxColumn();
            colErrorTime = new DataGridViewTextBoxColumn();
            ErrorLogID = new DataGridViewTextBoxColumn();
            dgvErrorLogs = new DataGridView();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnDetails = new Button();
            btnBack = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvErrorLogs).BeginInit();
            SuspendLayout();
            // 
            // lblLogs
            // 
            lblLogs.AutoSize = true;
            lblLogs.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogs.ForeColor = Color.FromArgb(31, 78, 121);
            lblLogs.Location = new Point(12, 173);
            lblLogs.Name = "lblLogs";
            lblLogs.Size = new Size(89, 26);
            lblLogs.TabIndex = 10;
            lblLogs.Text = "Error Log";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(12, 113);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(106, 23);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date Range:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 119);
            label1.Name = "label1";
            label1.Size = new Size(27, 23);
            label1.TabIndex = 6;
            label1.Text = "to";
            // 
            // btnSearch2
            // 
            btnSearch2.BackColor = Color.FromArgb(31, 78, 121);
            btnSearch2.FlatAppearance.BorderSize = 0;
            btnSearch2.FlatStyle = FlatStyle.Flat;
            btnSearch2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch2.ForeColor = Color.White;
            btnSearch2.Location = new Point(401, 114);
            btnSearch2.Name = "btnSearch2";
            btnSearch2.Size = new Size(85, 30);
            btnSearch2.TabIndex = 7;
            btnSearch2.Text = "Search";
            btnSearch2.UseVisualStyleBackColor = false;
            btnSearch2.Click += btnSearch2_Click;
            // 
            // lblSeverity
            // 
            lblSeverity.AutoSize = true;
            lblSeverity.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeverity.Location = new Point(432, 55);
            lblSeverity.Name = "lblSeverity";
            lblSeverity.Size = new Size(81, 23);
            lblSeverity.TabIndex = 8;
            lblSeverity.Text = "Severity:";
            // 
            // cboSeverity
            // 
            cboSeverity.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSeverity.FormattingEnabled = true;
            cboSeverity.Items.AddRange(new object[] { "All Levels", "Error", "Warning", "Info" });
            cboSeverity.Location = new Point(519, 52);
            cboSeverity.Name = "cboSeverity";
            cboSeverity.Size = new Size(121, 31);
            cboSeverity.TabIndex = 9;
            cboSeverity.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(31, 78, 121);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(279, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(86, 50);
            txtSearch.MaxLength = 4000;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(187, 31);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Message or error ID...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(12, 53);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // colErrorMessage
            // 
            colErrorMessage.FillWeight = 130.288788F;
            colErrorMessage.HeaderText = "Message";
            colErrorMessage.Name = "colErrorMessage";
            colErrorMessage.ReadOnly = true;
            colErrorMessage.Width = 200;
            // 
            // ErrorSeverity
            // 
            ErrorSeverity.FillWeight = 117.250137F;
            ErrorSeverity.HeaderText = "Severity";
            ErrorSeverity.Name = "ErrorSeverity";
            ErrorSeverity.ReadOnly = true;
            ErrorSeverity.Width = 180;
            // 
            // ErrorNumber
            // 
            ErrorNumber.FillWeight = 102.256683F;
            ErrorNumber.HeaderText = "Error Number";
            ErrorNumber.Name = "ErrorNumber";
            ErrorNumber.ReadOnly = true;
            ErrorNumber.Width = 157;
            // 
            // colErrorTime
            // 
            colErrorTime.FillWeight = 85.01532F;
            colErrorTime.HeaderText = "Date / Time\n";
            colErrorTime.Name = "colErrorTime";
            colErrorTime.ReadOnly = true;
            colErrorTime.Width = 130;
            // 
            // ErrorLogID
            // 
            ErrorLogID.FillWeight = 65.18906F;
            ErrorLogID.HeaderText = "Log ID";
            ErrorLogID.Name = "ErrorLogID";
            ErrorLogID.ReadOnly = true;
            // 
            // dgvErrorLogs
            // 
            dgvErrorLogs.AllowUserToAddRows = false;
            dgvErrorLogs.AllowUserToDeleteRows = false;
            dgvErrorLogs.AllowUserToResizeRows = false;
            dgvErrorLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvErrorLogs.Columns.AddRange(new DataGridViewColumn[] { ErrorLogID, colErrorTime, ErrorNumber, ErrorSeverity, colErrorMessage });
            dgvErrorLogs.Location = new Point(12, 202);
            dgvErrorLogs.MultiSelect = false;
            dgvErrorLogs.Name = "dgvErrorLogs";
            dgvErrorLogs.ReadOnly = true;
            dgvErrorLogs.RowHeadersVisible = false;
            dgvErrorLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvErrorLogs.Size = new Size(770, 150);
            dgvErrorLogs.TabIndex = 11;
            dgvErrorLogs.CellContentClick += dgvErrorLogs_CellContentClick;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(124, 113);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(116, 31);
            dtpStartDate.TabIndex = 12;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(279, 113);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(116, 31);
            dtpEndDate.TabIndex = 13;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.FromArgb(31, 78, 121);
            btnDetails.FlatAppearance.BorderSize = 0;
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetails.ForeColor = Color.White;
            btnDetails.Location = new Point(12, 408);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(120, 30);
            btnDetails.TabIndex = 14;
            btnDetails.Text = "View Details";
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(703, 408);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 30);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(46, 125, 60);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(183, 408);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 30);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // frmError
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Controls.Add(btnDetails);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(dgvErrorLogs);
            Controls.Add(lblLogs);
            Controls.Add(cboSeverity);
            Controls.Add(lblSeverity);
            Controls.Add(btnSearch2);
            Controls.Add(label1);
            Controls.Add(lblDate);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmError";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Error";
            Load += frmError_Load;
            ((System.ComponentModel.ISupportInitialize)dgvErrorLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLogs;
        private Label lblDate;
        private Label label1;
        private Button btnSearch2;
        private Label lblSeverity;
        private ComboBox cboSeverity;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridViewTextBoxColumn colErrorMessage;
        private DataGridViewTextBoxColumn ErrorSeverity;
        private DataGridViewTextBoxColumn ErrorNumber;
        private DataGridViewTextBoxColumn colErrorTime;
        private DataGridViewTextBoxColumn ErrorLogID;
        private DataGridView dgvErrorLogs;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnDetails;
        private Button btnBack;
        private Button btnRefresh;
    }
}