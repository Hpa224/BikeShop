namespace BikeShop.Forms
{
    partial class frmReceipt
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
            lblStoreName = new Label();
            lblReceiptTitle = new Label();
            grpBillTo = new GroupBox();
            lblCustomerName = new Label();
            lblBillToAddress = new Label();
            grpOrderInfo = new GroupBox();
            lblOrderNumberCaption = new Label();
            lblOrderNumber = new Label();
            lblOrderDateCaption = new Label();
            lblOrderDate = new Label();
            lblDueDateCaption = new Label();
            lblDueDate = new Label();
            lblCustomerIDCaption = new Label();
            lblCustomerID = new Label();
            dgvOrderLines = new DataGridView();
            colProductNumber = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colLineTotal = new DataGridViewTextBoxColumn();
            lblThankYou = new Label();
            lblSubtotal = new Label();
            lblSubtotalValue = new Label();
            lblTax = new Label();
            lblTaxValue = new Label();
            lblTotal = new Label();
            lblTotalValue = new Label();
            btnPrint = new Button();
            btnSave = new Button();
            btnClose = new Button();
            printDocument = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();
            saveFileDialog = new SaveFileDialog();
            grpBillTo.SuspendLayout();
            grpOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderLines).BeginInit();
            SuspendLayout();
            // 
            // lblStoreName
            // 
            lblStoreName.AutoSize = true;
            lblStoreName.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStoreName.ForeColor = Color.FromArgb(31, 78, 121);
            lblStoreName.Location = new Point(15, 8);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Text = "Bike Shop";
            lblStoreName.TabIndex = 0;
            // 
            // lblReceiptTitle
            // 
            lblReceiptTitle.AutoSize = true;
            lblReceiptTitle.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReceiptTitle.Location = new Point(18, 47);
            lblReceiptTitle.Name = "lblReceiptTitle";
            lblReceiptTitle.Text = "Sales Receipt / Invoice";
            lblReceiptTitle.TabIndex = 1;
            // 
            // grpBillTo
            // 
            grpBillTo.Controls.Add(lblBillToAddress);
            grpBillTo.Controls.Add(lblCustomerName);
            grpBillTo.Location = new Point(15, 76);
            grpBillTo.Name = "grpBillTo";
            grpBillTo.Size = new Size(380, 116);
            grpBillTo.TabStop = false;
            grpBillTo.Text = "Bill To";
            grpBillTo.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(12, 24);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Text = "Customer Name";
            lblCustomerName.TabIndex = 3;
            // 
            // lblBillToAddress
            // 
            lblBillToAddress.Location = new Point(12, 46);
            lblBillToAddress.Name = "lblBillToAddress";
            lblBillToAddress.Size = new Size(355, 64);
            lblBillToAddress.Text = "Address";
            lblBillToAddress.TabIndex = 4;
            // 
            // grpOrderInfo
            // 
            grpOrderInfo.Controls.Add(lblCustomerID);
            grpOrderInfo.Controls.Add(lblCustomerIDCaption);
            grpOrderInfo.Controls.Add(lblDueDate);
            grpOrderInfo.Controls.Add(lblDueDateCaption);
            grpOrderInfo.Controls.Add(lblOrderDate);
            grpOrderInfo.Controls.Add(lblOrderDateCaption);
            grpOrderInfo.Controls.Add(lblOrderNumber);
            grpOrderInfo.Controls.Add(lblOrderNumberCaption);
            grpOrderInfo.Location = new Point(405, 76);
            grpOrderInfo.Name = "grpOrderInfo";
            grpOrderInfo.Size = new Size(380, 116);
            grpOrderInfo.TabStop = false;
            grpOrderInfo.Text = "Order Information";
            grpOrderInfo.TabIndex = 5;
            // 
            // lblOrderNumberCaption
            // 
            lblOrderNumberCaption.AutoSize = true;
            lblOrderNumberCaption.Location = new Point(12, 24);
            lblOrderNumberCaption.Name = "lblOrderNumberCaption";
            lblOrderNumberCaption.Text = "Order #:";
            lblOrderNumberCaption.TabIndex = 6;
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderNumber.Location = new Point(130, 24);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Text = "SO00000";
            lblOrderNumber.TabIndex = 7;
            // 
            // lblOrderDateCaption
            // 
            lblOrderDateCaption.AutoSize = true;
            lblOrderDateCaption.Location = new Point(12, 46);
            lblOrderDateCaption.Name = "lblOrderDateCaption";
            lblOrderDateCaption.Text = "Order Date:";
            lblOrderDateCaption.TabIndex = 8;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(130, 46);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Text = "01/01/2026";
            lblOrderDate.TabIndex = 9;
            // 
            // lblDueDateCaption
            // 
            lblDueDateCaption.AutoSize = true;
            lblDueDateCaption.Location = new Point(12, 68);
            lblDueDateCaption.Name = "lblDueDateCaption";
            lblDueDateCaption.Text = "Due Date:";
            lblDueDateCaption.TabIndex = 10;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(130, 68);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Text = "01/01/2026";
            lblDueDate.TabIndex = 11;
            // 
            // lblCustomerIDCaption
            // 
            lblCustomerIDCaption.AutoSize = true;
            lblCustomerIDCaption.Location = new Point(12, 90);
            lblCustomerIDCaption.Name = "lblCustomerIDCaption";
            lblCustomerIDCaption.Text = "Customer ID:";
            lblCustomerIDCaption.TabIndex = 12;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(130, 90);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Text = "0";
            lblCustomerID.TabIndex = 13;
            // 
            // dgvOrderLines
            // 
            dgvOrderLines.AllowUserToAddRows = false;
            dgvOrderLines.AllowUserToDeleteRows = false;
            dgvOrderLines.AllowUserToResizeRows = false;
            dgvOrderLines.BackgroundColor = SystemColors.Window;
            dgvOrderLines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderLines.Location = new Point(15, 200);
            dgvOrderLines.MultiSelect = false;
            dgvOrderLines.Name = "dgvOrderLines";
            dgvOrderLines.ReadOnly = true;
            dgvOrderLines.RowHeadersVisible = false;
            dgvOrderLines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderLines.Size = new Size(770, 128);
            dgvOrderLines.TabIndex = 14;
            dgvOrderLines.Columns.AddRange(new DataGridViewColumn[] { colProductNumber, colProductName, colQty, colUnitPrice, colLineTotal });
            // 
            // colProductNumber
            // 
            colProductNumber.HeaderText = "Product #";
            colProductNumber.Name = "colProductNumber";
            colProductNumber.ReadOnly = true;
            colProductNumber.Width = 110;
            // 
            // colProductName
            // 
            colProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductName.HeaderText = "Product";
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.HeaderText = "Qty";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            colQty.Width = 60;
            // 
            // colUnitPrice
            // 
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            colUnitPrice.Width = 110;
            // 
            // colLineTotal
            // 
            colLineTotal.HeaderText = "Line Total";
            colLineTotal.Name = "colLineTotal";
            colLineTotal.ReadOnly = true;
            colLineTotal.Width = 120;
            // 
            // lblThankYou
            // 
            lblThankYou.AutoSize = true;
            lblThankYou.Font = new Font("Calibri", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblThankYou.Location = new Point(15, 336);
            lblThankYou.Name = "lblThankYou";
            lblThankYou.Text = "Thank you for shopping with us!";
            lblThankYou.TabIndex = 15;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Location = new Point(540, 334);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(130, 21);
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            lblSubtotal.Text = "Subtotal:";
            lblSubtotal.TabIndex = 16;
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.Location = new Point(670, 334);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(115, 21);
            lblSubtotalValue.TextAlign = ContentAlignment.MiddleRight;
            lblSubtotalValue.Text = "$0.00";
            lblSubtotalValue.TabIndex = 17;
            // 
            // lblTax
            // 
            lblTax.Location = new Point(540, 355);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(130, 21);
            lblTax.TextAlign = ContentAlignment.MiddleRight;
            lblTax.Text = "Tax (7%):";
            lblTax.TabIndex = 18;
            // 
            // lblTaxValue
            // 
            lblTaxValue.Location = new Point(670, 355);
            lblTaxValue.Name = "lblTaxValue";
            lblTaxValue.Size = new Size(115, 21);
            lblTaxValue.TextAlign = ContentAlignment.MiddleRight;
            lblTaxValue.Text = "$0.00";
            lblTaxValue.TabIndex = 19;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(540, 376);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(130, 23);
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Text = "Total Due:";
            lblTotal.TabIndex = 20;
            // 
            // lblTotalValue
            // 
            lblTotalValue.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalValue.Location = new Point(670, 376);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(115, 23);
            lblTotalValue.TextAlign = ContentAlignment.MiddleRight;
            lblTotalValue.Text = "$0.00";
            lblTotalValue.TabIndex = 21;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(46, 125, 60);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(15, 405);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(110, 38);
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.TabIndex = 22;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 125, 60);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(135, 405);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 38);
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.TabIndex = 23;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(675, 405);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 38);
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.TabIndex = 24;
            btnClose.Click += btnClose_Click;
            // 
            // printDocument
            // 
            printDocument.DocumentName = "Sales Receipt";
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.ClientSize = new Size(800, 600);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Name = "printPreviewDialog";
            printPreviewDialog.Visible = false;
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save Receipt";
            // 
            // frmReceipt
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(btnPrint);
            Controls.Add(lblTotalValue);
            Controls.Add(lblTotal);
            Controls.Add(lblTaxValue);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotalValue);
            Controls.Add(lblSubtotal);
            Controls.Add(lblThankYou);
            Controls.Add(dgvOrderLines);
            Controls.Add(grpOrderInfo);
            Controls.Add(grpBillTo);
            Controls.Add(lblReceiptTitle);
            Controls.Add(lblStoreName);
            Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Receipt";
            Load += frmReceipt_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderLines).EndInit();
            grpBillTo.ResumeLayout(false);
            grpBillTo.PerformLayout();
            grpOrderInfo.ResumeLayout(false);
            grpOrderInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStoreName;
        private Label lblReceiptTitle;
        private GroupBox grpBillTo;
        private Label lblCustomerName;
        private Label lblBillToAddress;
        private GroupBox grpOrderInfo;
        private Label lblOrderNumberCaption;
        private Label lblOrderNumber;
        private Label lblOrderDateCaption;
        private Label lblOrderDate;
        private Label lblDueDateCaption;
        private Label lblDueDate;
        private Label lblCustomerIDCaption;
        private Label lblCustomerID;
        private DataGridView dgvOrderLines;
        private DataGridViewTextBoxColumn colProductNumber;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colLineTotal;
        private Label lblThankYou;
        private Label lblSubtotal;
        private Label lblSubtotalValue;
        private Label lblTax;
        private Label lblTaxValue;
        private Label lblTotal;
        private Label lblTotalValue;
        private Button btnPrint;
        private Button btnSave;
        private Button btnClose;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private SaveFileDialog saveFileDialog;
    }
}
