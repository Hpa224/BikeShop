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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnExportCSV = new Button();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            dgvSalesReport = new DataGridView();
            colSalesOrderNumber = new DataGridViewTextBoxColumn();
            colOrderDate = new DataGridViewTextBoxColumn();
            colProductNumber = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colOrderQty = new DataGridViewTextBoxColumn();
            colLineTotal = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            lblPreview = new Label();
            btnGenerate = new Button();
            label1 = new Label();
            lblDate = new Label();
            pnlTotalSales = new Panel();
            lblTotalSalesAmount = new Label();
            lblTotalSales = new Label();
            panel1 = new Panel();
            lblOrdersAmount = new Label();
            lblOrders = new Label();
            panel2 = new Panel();
            lblItemsSoldAmount = new Label();
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
            btnExportCSV.Location = new Point(12, 408);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(120, 30);
            btnExportCSV.TabIndex = 31;
            btnExportCSV.Text = "Export CSV";
            btnExportCSV.UseVisualStyleBackColor = false;
            btnExportCSV.Click += btnExportCSV_Click;
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
            dtpStartDate.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dgvSalesReport
            // 
            dgvSalesReport.AllowUserToAddRows = false;
            dgvSalesReport.AllowUserToDeleteRows = false;
            dgvSalesReport.AllowUserToResizeRows = false;
            dgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesReport.Columns.AddRange(new DataGridViewColumn[] { colSalesOrderNumber, colOrderDate, colProductNumber, colProductName, colOrderQty, colLineTotal });
            dgvSalesReport.Location = new Point(12, 230);
            dgvSalesReport.MultiSelect = false;
            dgvSalesReport.Name = "dgvSalesReport";
            dgvSalesReport.ReadOnly = true;
            dgvSalesReport.RowHeadersVisible = false;
            dgvSalesReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalesReport.Size = new Size(776, 150);
            dgvSalesReport.TabIndex = 26;
            dgvSalesReport.CellContentClick += dgvSalesReport_CellContentClick;
            // 
            // colSalesOrderNumber
            // 
            colSalesOrderNumber.DataPropertyName = "SalesOrderNumber";
            colSalesOrderNumber.FillWeight = 65.18906F;
            colSalesOrderNumber.HeaderText = "Order #";
            colSalesOrderNumber.Name = "colSalesOrderNumber";
            colSalesOrderNumber.ReadOnly = true;
            // 
            // colOrderDate
            // 
            colOrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Format = "MM/dd/yyyy HH:mm";
            colOrderDate.DefaultCellStyle = dataGridViewCellStyle1;
            colOrderDate.FillWeight = 85.01532F;
            colOrderDate.HeaderText = "Order Date";
            colOrderDate.Name = "colOrderDate";
            colOrderDate.ReadOnly = true;
            colOrderDate.Width = 130;
            // 
            // colProductNumber
            // 
            colProductNumber.DataPropertyName = "ProductNumber";
            colProductNumber.FillWeight = 102.256683F;
            colProductNumber.HeaderText = "Product #";
            colProductNumber.Name = "colProductNumber";
            colProductNumber.ReadOnly = true;
            colProductNumber.Width = 157;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "Name";
            colProductName.FillWeight = 117.250137F;
            colProductName.HeaderText = "Product Name";
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.Width = 180;
            // 
            // colOrderQty
            // 
            colOrderQty.DataPropertyName = "OrderQty";
            colOrderQty.FillWeight = 130.288788F;
            colOrderQty.HeaderText = "Quantity";
            colOrderQty.Name = "colOrderQty";
            colOrderQty.ReadOnly = true;
            colOrderQty.Width = 200;
            // 
            // colLineTotal
            // 
            colLineTotal.DataPropertyName = "LineTotal";
            dataGridViewCellStyle2.Format = "C2";
            colLineTotal.DefaultCellStyle = dataGridViewCellStyle2;
            colLineTotal.HeaderText = "Line Total";
            colLineTotal.Name = "colLineTotal";
            colLineTotal.ReadOnly = true;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(703, 408);
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
            lblPreview.Location = new Point(12, 201);
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
            pnlTotalSales.Controls.Add(lblTotalSalesAmount);
            pnlTotalSales.Controls.Add(lblTotalSales);
            pnlTotalSales.Location = new Point(12, 97);
            pnlTotalSales.Name = "pnlTotalSales";
            pnlTotalSales.Size = new Size(200, 90);
            pnlTotalSales.TabIndex = 32;
            // 
            // lblTotalSalesAmount
            // 
            lblTotalSalesAmount.AutoSize = true;
            lblTotalSalesAmount.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalSalesAmount.ForeColor = Color.FromArgb(31, 78, 121);
            lblTotalSalesAmount.Location = new Point(13, 49);
            lblTotalSalesAmount.Name = "lblTotalSalesAmount";
            lblTotalSalesAmount.Size = new Size(67, 29);
            lblTotalSalesAmount.TabIndex = 1;
            lblTotalSalesAmount.Text = "$0.00";
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
            panel1.Controls.Add(lblOrdersAmount);
            panel1.Controls.Add(lblOrders);
            panel1.Location = new Point(305, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 90);
            panel1.TabIndex = 33;
            // 
            // lblOrdersAmount
            // 
            lblOrdersAmount.AutoSize = true;
            lblOrdersAmount.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrdersAmount.ForeColor = Color.FromArgb(31, 78, 121);
            lblOrdersAmount.Location = new Point(13, 49);
            lblOrdersAmount.Name = "lblOrdersAmount";
            lblOrdersAmount.Size = new Size(25, 29);
            lblOrdersAmount.TabIndex = 1;
            lblOrdersAmount.Text = "0";
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
            panel2.Controls.Add(lblItemsSoldAmount);
            panel2.Controls.Add(lblItemsSold);
            panel2.Location = new Point(582, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 90);
            panel2.TabIndex = 34;
            // 
            // lblItemsSoldAmount
            // 
            lblItemsSoldAmount.AutoSize = true;
            lblItemsSoldAmount.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemsSoldAmount.ForeColor = Color.FromArgb(31, 78, 121);
            lblItemsSoldAmount.Location = new Point(13, 49);
            lblItemsSoldAmount.Name = "lblItemsSoldAmount";
            lblItemsSoldAmount.Size = new Size(25, 29);
            lblItemsSoldAmount.TabIndex = 1;
            lblItemsSoldAmount.Text = "0";
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
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(dgvSalesReport);
            Controls.Add(btnBack);
            Controls.Add(lblPreview);
            Controls.Add(btnGenerate);
            Controls.Add(label1);
            Controls.Add(lblDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private DataGridView dgvSalesReport;
        private Button btnBack;
        private Label lblPreview;
        private Button btnGenerate;
        private Label label1;
        private Label lblDate;
        private Panel pnlTotalSales;
        private Label lblTotalSales;
        private Label lblTotalSalesAmount;
        private Panel panel1;
        private Label lblOrdersAmount;
        private Label lblOrders;
        private Panel panel2;
        private Label lblItemsSoldAmount;
        private Label lblItemsSold;
        private DataGridViewTextBoxColumn colSalesOrderNumber;
        private DataGridViewTextBoxColumn colOrderDate;
        private DataGridViewTextBoxColumn colProductNumber;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colOrderQty;
        private DataGridViewTextBoxColumn colLineTotal;
    }
}