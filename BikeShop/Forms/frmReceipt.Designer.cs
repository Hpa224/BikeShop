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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceipt));
            lblStoreName = new Label();
            lblReceiptTitle = new Label();
            grpBillTo = new GroupBox();
            lblBillToAddress = new Label();
            lblCustomerName = new Label();
            grpOrderInfo = new GroupBox();
            lblCustomerID = new Label();
            lblCustomerIDCaption = new Label();
            lblDueDate = new Label();
            lblDueDateCaption = new Label();
            lblOrderDate = new Label();
            lblOrderDateCaption = new Label();
            lblOrderNumber = new Label();
            lblOrderNumberCaption = new Label();
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
            lblStoreName.Location = new Point(12, 8);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(130, 33);
            lblStoreName.TabIndex = 0;
            lblStoreName.Text = "Bike Store";
            // 
            // lblReceiptTitle
            // 
            lblReceiptTitle.AutoSize = true;
            lblReceiptTitle.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReceiptTitle.Location = new Point(15, 45);
            lblReceiptTitle.Name = "lblReceiptTitle";
            lblReceiptTitle.Size = new Size(156, 19);
            lblReceiptTitle.TabIndex = 1;
            lblReceiptTitle.Text = "Sales Receipt / Invoice";
            // 
            // grpBillTo
            // 
            grpBillTo.BackColor = Color.FromArgb(242, 242, 242);
            grpBillTo.Controls.Add(lblBillToAddress);
            grpBillTo.Controls.Add(lblCustomerName);
            grpBillTo.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBillTo.ForeColor = Color.FromArgb(31, 78, 121);
            grpBillTo.Location = new Point(12, 72);
            grpBillTo.Name = "grpBillTo";
            grpBillTo.Size = new Size(380, 115);
            grpBillTo.TabIndex = 2;
            grpBillTo.TabStop = false;
            grpBillTo.Text = "Bill To";
            // 
            // lblBillToAddress
            // 
            lblBillToAddress.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBillToAddress.ForeColor = Color.Black;
            lblBillToAddress.Location = new Point(12, 47);
            lblBillToAddress.Name = "lblBillToAddress";
            lblBillToAddress.Size = new Size(355, 62);
            lblBillToAddress.TabIndex = 4;
            lblBillToAddress.Text = "Address";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.ForeColor = Color.Black;
            lblCustomerName.Location = new Point(12, 25);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(108, 18);
            lblCustomerName.TabIndex = 3;
            lblCustomerName.Text = "Customer Name";
            // 
            // grpOrderInfo
            // 
            grpOrderInfo.BackColor = Color.FromArgb(242, 242, 242);
            grpOrderInfo.Controls.Add(lblCustomerID);
            grpOrderInfo.Controls.Add(lblCustomerIDCaption);
            grpOrderInfo.Controls.Add(lblDueDate);
            grpOrderInfo.Controls.Add(lblDueDateCaption);
            grpOrderInfo.Controls.Add(lblOrderDate);
            grpOrderInfo.Controls.Add(lblOrderDateCaption);
            grpOrderInfo.Controls.Add(lblOrderNumber);
            grpOrderInfo.Controls.Add(lblOrderNumberCaption);
            grpOrderInfo.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpOrderInfo.ForeColor = Color.FromArgb(31, 78, 121);
            grpOrderInfo.Location = new Point(408, 72);
            grpOrderInfo.Name = "grpOrderInfo";
            grpOrderInfo.Size = new Size(380, 115);
            grpOrderInfo.TabIndex = 5;
            grpOrderInfo.TabStop = false;
            grpOrderInfo.Text = "Order Information";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerID.ForeColor = Color.Black;
            lblCustomerID.Location = new Point(125, 88);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(14, 15);
            lblCustomerID.TabIndex = 13;
            lblCustomerID.Text = "0";
            // 
            // lblCustomerIDCaption
            // 
            lblCustomerIDCaption.AutoSize = true;
            lblCustomerIDCaption.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerIDCaption.ForeColor = Color.Black;
            lblCustomerIDCaption.Location = new Point(12, 88);
            lblCustomerIDCaption.Name = "lblCustomerIDCaption";
            lblCustomerIDCaption.Size = new Size(77, 15);
            lblCustomerIDCaption.TabIndex = 12;
            lblCustomerIDCaption.Text = "Customer ID:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDueDate.ForeColor = Color.Black;
            lblDueDate.Location = new Point(125, 67);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(73, 15);
            lblDueDate.TabIndex = 11;
            lblDueDate.Text = "01/01/2026";
            // 
            // lblDueDateCaption
            // 
            lblDueDateCaption.AutoSize = true;
            lblDueDateCaption.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDueDateCaption.ForeColor = Color.Black;
            lblDueDateCaption.Location = new Point(12, 67);
            lblDueDateCaption.Name = "lblDueDateCaption";
            lblDueDateCaption.Size = new Size(59, 15);
            lblDueDateCaption.TabIndex = 10;
            lblDueDateCaption.Text = "Due Date:";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderDate.ForeColor = Color.Black;
            lblOrderDate.Location = new Point(125, 46);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(73, 15);
            lblOrderDate.TabIndex = 9;
            lblOrderDate.Text = "01/01/2026";
            // 
            // lblOrderDateCaption
            // 
            lblOrderDateCaption.AutoSize = true;
            lblOrderDateCaption.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderDateCaption.ForeColor = Color.Black;
            lblOrderDateCaption.Location = new Point(12, 46);
            lblOrderDateCaption.Name = "lblOrderDateCaption";
            lblOrderDateCaption.Size = new Size(70, 15);
            lblOrderDateCaption.TabIndex = 8;
            lblOrderDateCaption.Text = "Order Date:";
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderNumber.ForeColor = Color.Black;
            lblOrderNumber.Location = new Point(125, 25);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(57, 15);
            lblOrderNumber.TabIndex = 7;
            lblOrderNumber.Text = "SO00000";
            // 
            // lblOrderNumberCaption
            // 
            lblOrderNumberCaption.AutoSize = true;
            lblOrderNumberCaption.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderNumberCaption.ForeColor = Color.Black;
            lblOrderNumberCaption.Location = new Point(12, 25);
            lblOrderNumberCaption.Name = "lblOrderNumberCaption";
            lblOrderNumberCaption.Size = new Size(51, 15);
            lblOrderNumberCaption.TabIndex = 6;
            lblOrderNumberCaption.Text = "Order #:";
            // 
            // dgvOrderLines
            // 
            dgvOrderLines.AllowUserToAddRows = false;
            dgvOrderLines.AllowUserToDeleteRows = false;
            dgvOrderLines.AllowUserToResizeRows = false;
            dgvOrderLines.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrderLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrderLines.ColumnHeadersHeight = 26;
            dgvOrderLines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOrderLines.Columns.AddRange(new DataGridViewColumn[] { colProductNumber, colProductName, colQty, colUnitPrice, colLineTotal });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(189, 215, 238);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvOrderLines.DefaultCellStyle = dataGridViewCellStyle5;
            dgvOrderLines.EnableHeadersVisualStyles = false;
            dgvOrderLines.GridColor = Color.FromArgb(217, 217, 217);
            dgvOrderLines.Location = new Point(12, 195);
            dgvOrderLines.MultiSelect = false;
            dgvOrderLines.Name = "dgvOrderLines";
            dgvOrderLines.ReadOnly = true;
            dgvOrderLines.RowHeadersVisible = false;
            dgvOrderLines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderLines.Size = new Size(776, 125);
            dgvOrderLines.TabIndex = 14;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            colQty.DefaultCellStyle = dataGridViewCellStyle2;
            colQty.HeaderText = "Qty";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            colQty.Width = 60;
            // 
            // colUnitPrice
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            colUnitPrice.DefaultCellStyle = dataGridViewCellStyle3;
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            colUnitPrice.Width = 110;
            // 
            // colLineTotal
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            colLineTotal.DefaultCellStyle = dataGridViewCellStyle4;
            colLineTotal.HeaderText = "Line Total";
            colLineTotal.Name = "colLineTotal";
            colLineTotal.ReadOnly = true;
            colLineTotal.Width = 120;
            // 
            // lblThankYou
            // 
            lblThankYou.AutoSize = true;
            lblThankYou.Font = new Font("Calibri", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblThankYou.Location = new Point(12, 330);
            lblThankYou.Name = "lblThankYou";
            lblThankYou.Size = new Size(205, 18);
            lblThankYou.TabIndex = 15;
            lblThankYou.Text = "Thank you for shopping with us!";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(520, 326);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(140, 20);
            lblSubtotal.TabIndex = 16;
            lblSubtotal.Text = "Subtotal:";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotalValue.Location = new Point(660, 326);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(128, 20);
            lblSubtotalValue.TabIndex = 17;
            lblSubtotalValue.Text = "$0.00";
            lblSubtotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            lblTax.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTax.Location = new Point(520, 346);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(140, 20);
            lblTax.TabIndex = 18;
            lblTax.Text = "Tax (7%):";
            lblTax.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTaxValue
            // 
            lblTaxValue.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaxValue.Location = new Point(660, 346);
            lblTaxValue.Name = "lblTaxValue";
            lblTaxValue.Size = new Size(128, 20);
            lblTaxValue.TabIndex = 19;
            lblTaxValue.Text = "$0.00";
            lblTaxValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(520, 366);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(140, 22);
            lblTotal.TabIndex = 20;
            lblTotal.Text = "Total Due:";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalValue
            // 
            lblTotalValue.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalValue.Location = new Point(660, 366);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(128, 22);
            lblTotalValue.TabIndex = 21;
            lblTotalValue.Text = "$0.00";
            lblTotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(31, 78, 121);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(12, 393);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(145, 45);
            btnPrint.TabIndex = 22;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 125, 60);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(167, 393);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 45);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(127, 127, 127);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(643, 393);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(145, 45);
            btnClose.TabIndex = 24;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // printDocument
            // 
            printDocument.DocumentName = "Sales Receipt";
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(800, 600);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmReceipt";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sales Receipt";
            Load += frmReceipt_Load;
            grpBillTo.ResumeLayout(false);
            grpBillTo.PerformLayout();
            grpOrderInfo.ResumeLayout(false);
            grpOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderLines).EndInit();
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
