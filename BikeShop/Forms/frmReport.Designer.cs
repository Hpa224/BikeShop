namespace BikeShop.Forms
{
    partial class frmReport
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
            btnExportCSV = new Button();
            btnPrintReport = new Button();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            dgvSalesReport = new DataGridView();
            ErrorLogID = new DataGridViewTextBoxColumn();
            colErrorTime = new DataGridViewTextBoxColumn();
            ErrorNumber = new DataGridViewTextBoxColumn();
            ErrorSeverity = new DataGridViewTextBoxColumn();
            colErrorMessage = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            lblPreview = new Label();
            btnGenerate = new Button();
            label1 = new Label();
            lblDate = new Label();
            pnlTotalSales = new Panel();
            label2 = new Label();
            lblTotalSales = new Label();
            panel1 = new Panel();
            label3 = new Label();
            lblOrders = new Label();
            panel2 = new Panel();
            label5 = new Label();
            lblItemsSold = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).BeginInit();
            pnlTotalSales.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnExportCSV
            // 
            btnExportCSV.BackColor = Color.FromArgb(46, 125, 60);
            btnExportCSV.FlatAppearance.BorderSize = 0;
            btnExportCSV.FlatStyle = FlatStyle.Flat;
            btnExportCSV.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportCSV.ForeColor = Color.White;
            btnExportCSV.Location = new Point(183, 389);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(120, 30);
            btnExportCSV.TabIndex = 31;
            btnExportCSV.Text = "Export CSV";
            btnExportCSV.UseVisualStyleBackColor = false;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // btnPrintReport
            // 
            btnPrintReport.BackColor = Color.FromArgb(31, 78, 121);
            btnPrintReport.FlatAppearance.BorderSize = 0;
            btnPrintReport.FlatStyle = FlatStyle.Flat;
            btnPrintReport.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintReport.ForeColor = Color.White;
            btnPrintReport.Location = new Point(12, 389);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(120, 30);
            btnPrintReport.TabIndex = 29;
            btnPrintReport.Text = "Print Report";
            btnPrintReport.UseVisualStyleBackColor = false;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(411, 44);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(116, 31);
            dtpEndDate.TabIndex = 28;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(256, 44);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(116, 31);
            dtpStartDate.TabIndex = 27;
            // 
            // dgvSalesReport
            // 
            dgvSalesReport.AllowUserToAddRows = false;
            dgvSalesReport.AllowUserToDeleteRows = false;
            dgvSalesReport.AllowUserToResizeRows = false;
            dgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesReport.Columns.AddRange(new DataGridViewColumn[] { ErrorLogID, colErrorTime, ErrorNumber, ErrorSeverity, colErrorMessage });
            dgvSalesReport.Location = new Point(12, 219);
            dgvSalesReport.MultiSelect = false;
            dgvSalesReport.Name = "dgvSalesReport";
            dgvSalesReport.ReadOnly = true;
            dgvSalesReport.RowHeadersVisible = false;
            dgvSalesReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalesReport.Size = new Size(770, 150);
            dgvSalesReport.TabIndex = 26;
            // 
            // ErrorLogID
            // 
            ErrorLogID.FillWeight = 65.18906F;
            ErrorLogID.HeaderText = "Log ID";
            ErrorLogID.Name = "ErrorLogID";
            ErrorLogID.ReadOnly = true;
            // 
            // colErrorTime
            // 
            colErrorTime.FillWeight = 85.01532F;
            colErrorTime.HeaderText = "Date / Time\n";
            colErrorTime.Name = "colErrorTime";
            colErrorTime.ReadOnly = true;
            colErrorTime.Width = 130;
            // 
            // ErrorNumber
            // 
            ErrorNumber.FillWeight = 102.256683F;
            ErrorNumber.HeaderText = "Error Number";
            ErrorNumber.Name = "ErrorNumber";
            ErrorNumber.ReadOnly = true;
            ErrorNumber.Width = 157;
            // 
            // ErrorSeverity
            // 
            ErrorSeverity.FillWeight = 117.250137F;
            ErrorSeverity.HeaderText = "Severity";
            ErrorSeverity.Name = "ErrorSeverity";
            ErrorSeverity.ReadOnly = true;
            ErrorSeverity.Width = 180;
            // 
            // colErrorMessage
            // 
            colErrorMessage.FillWeight = 130.288788F;
            colErrorMessage.HeaderText = "Message";
            colErrorMessage.Name = "colErrorMessage";
            colErrorMessage.ReadOnly = true;
            colErrorMessage.Width = 200;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(703, 389);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 30);
            btnBack.TabIndex = 30;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblPreview
            // 
            lblPreview.AutoSize = true;
            lblPreview.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreview.ForeColor = Color.FromArgb(31, 78, 121);
            lblPreview.Location = new Point(12, 190);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(196, 26);
            lblPreview.TabIndex = 25;
            lblPreview.Text = "Sales Report Preview";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(31, 78, 121);
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(533, 45);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(98, 30);
            btnGenerate.TabIndex = 22;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnSearch2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 50);
            label1.Name = "label1";
            label1.Size = new Size(27, 23);
            label1.TabIndex = 21;
            label1.Text = "to";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(144, 49);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(106, 23);
            lblDate.TabIndex = 20;
            lblDate.Text = "Date Range:";
            // 
            // pnlTotalSales
            // 
            pnlTotalSales.BackColor = SystemColors.ButtonFace;
            pnlTotalSales.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalSales.Controls.Add(label2);
            pnlTotalSales.Controls.Add(lblTotalSales);
            pnlTotalSales.Location = new Point(12, 97);
            pnlTotalSales.Name = "pnlTotalSales";
            pnlTotalSales.Size = new Size(200, 90);
            pnlTotalSales.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(31, 78, 121);
            label2.Location = new Point(13, 49);
            label2.Name = "label2";
            label2.Size = new Size(67, 29);
            label2.TabIndex = 1;
            label2.Text = "$0.00";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalSales.ForeColor = Color.FromArgb(65, 65, 65);
            lblTotalSales.Location = new Point(13, 17);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(89, 23);
            lblTotalSales.TabIndex = 0;
            lblTotalSales.Text = "Total Sales";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblOrders);
            panel1.Location = new Point(305, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 90);
            panel1.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(31, 78, 121);
            label3.Location = new Point(13, 49);
            label3.Name = "label3";
            label3.Size = new Size(25, 29);
            label3.TabIndex = 1;
            label3.Text = "0";
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrders.ForeColor = Color.FromArgb(65, 65, 65);
            lblOrders.Location = new Point(13, 17);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(64, 23);
            lblOrders.TabIndex = 0;
            lblOrders.Text = "Orders";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblItemsSold);
            panel2.Location = new Point(582, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 90);
            panel2.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(31, 78, 121);
            label5.Location = new Point(13, 49);
            label5.Name = "label5";
            label5.Size = new Size(25, 29);
            label5.TabIndex = 1;
            label5.Text = "0";
            // 
            // lblItemsSold
            // 
            lblItemsSold.AutoSize = true;
            lblItemsSold.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemsSold.ForeColor = Color.FromArgb(65, 65, 65);
            lblItemsSold.Location = new Point(13, 17);
            lblItemsSold.Name = "lblItemsSold";
            lblItemsSold.Size = new Size(91, 23);
            lblItemsSold.TabIndex = 0;
            lblItemsSold.Text = "Items Sold";
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlTotalSales);
            Controls.Add(btnExportCSV);
            Controls.Add(btnPrintReport);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(dgvSalesReport);
            Controls.Add(btnBack);
            Controls.Add(lblPreview);
            Controls.Add(btnGenerate);
            Controls.Add(label1);
            Controls.Add(lblDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Report";
            Load += frmReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).EndInit();
            pnlTotalSales.ResumeLayout(false);
            pnlTotalSales.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExportCSV;
        private Button btnPrintReport;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private DataGridView dgvSalesReport;
        private DataGridViewTextBoxColumn ErrorLogID;
        private DataGridViewTextBoxColumn colErrorTime;
        private DataGridViewTextBoxColumn ErrorNumber;
        private DataGridViewTextBoxColumn ErrorSeverity;
        private DataGridViewTextBoxColumn colErrorMessage;
        private Button btnBack;
        private Label lblPreview;
        private Button btnGenerate;
        private Label label1;
        private Label lblDate;
        private Panel pnlTotalSales;
        private Label lblTotalSales;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label lblOrders;
        private Panel panel2;
        private Label label5;
        private Label lblItemsSold;
    }
}