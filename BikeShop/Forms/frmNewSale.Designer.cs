namespace BikeShop.Forms
{
    partial class frmNewSale
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
            lblCustomer = new Label();
            cboCustomer = new ComboBox();
            lblOrderNumber = new Label();
            txtOrderNumber = new TextBox();
            lblOrderDate = new Label();
            dtpOrderDate = new DateTimePicker();
            grpFindProduct = new GroupBox();
            txtProductSearch = new TextBox();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            colProductNumber = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnAddToCart = new Button();
            lblSearchHint = new Label();
            grpCart = new GroupBox();
            dgvCart = new DataGridView();
            colCartProductNumber = new DataGridViewTextBoxColumn();
            colCartName = new DataGridViewTextBoxColumn();
            colCartQty = new DataGridViewTextBoxColumn();
            colCartUnitPrice = new DataGridViewTextBoxColumn();
            colCartLineTotal = new DataGridViewTextBoxColumn();
            lblCartQuantity = new Label();
            txtCartQuantity = new TextBox();
            btnUpdateQty = new Button();
            btnRemove = new Button();
            lblSubtotal = new Label();
            lblSubtotalValue = new Label();
            lblTax = new Label();
            lblTaxValue = new Label();
            lblTotal = new Label();
            lblTotalValue = new Label();
            btnCompleteSale = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            grpFindProduct.SuspendLayout();
            grpCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(15, 17);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Text = "Customer:";
            lblCustomer.TabIndex = 0;
            // 
            // cboCustomer
            // 
            cboCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Location = new Point(95, 14);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(290, 26);
            cboCustomer.TabIndex = 1;
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Location = new Point(400, 17);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Text = "Order #:";
            lblOrderNumber.TabIndex = 2;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(468, 14);
            txtOrderNumber.MaxLength = 25;
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.ReadOnly = true;
            txtOrderNumber.TabStop = false;
            txtOrderNumber.Size = new Size(95, 25);
            txtOrderNumber.TabIndex = 0;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(578, 17);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Text = "Date:";
            lblOrderDate.TabIndex = 3;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(622, 14);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(163, 25);
            dtpOrderDate.TabIndex = 4;
            // 
            // grpFindProduct
            // 
            grpFindProduct.Controls.Add(lblSearchHint);
            grpFindProduct.Controls.Add(btnAddToCart);
            grpFindProduct.Controls.Add(txtQuantity);
            grpFindProduct.Controls.Add(lblQuantity);
            grpFindProduct.Controls.Add(dgvProducts);
            grpFindProduct.Controls.Add(btnSearch);
            grpFindProduct.Controls.Add(txtProductSearch);
            grpFindProduct.Location = new Point(15, 50);
            grpFindProduct.Name = "grpFindProduct";
            grpFindProduct.Size = new Size(355, 342);
            grpFindProduct.TabStop = false;
            grpFindProduct.Text = "Find Product";
            grpFindProduct.TabIndex = 5;
            // 
            // txtProductSearch
            // 
            txtProductSearch.Location = new Point(10, 26);
            txtProductSearch.MaxLength = 50;
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.Size = new Size(230, 25);
            txtProductSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(46, 125, 60);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(248, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 30);
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.TabIndex = 7;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.BackgroundColor = SystemColors.Window;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(10, 60);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(335, 210);
            dgvProducts.TabIndex = 8;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductNumber, colProductName, colPrice });
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // colProductNumber
            // 
            colProductNumber.HeaderText = "Product #";
            colProductNumber.Name = "colProductNumber";
            colProductNumber.ReadOnly = true;
            colProductNumber.Width = 95;
            // 
            // colProductName
            // 
            colProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductName.HeaderText = "Name";
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 75;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(10, 285);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Text = "Quantity:";
            lblQuantity.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(85, 282);
            txtQuantity.MaxLength = 3;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(60, 25);
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            txtQuantity.TabIndex = 10;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FromArgb(46, 125, 60);
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Location = new Point(195, 277);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(150, 34);
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.TabIndex = 11;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lblSearchHint
            // 
            lblSearchHint.AutoSize = true;
            lblSearchHint.Font = new Font("Calibri", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSearchHint.ForeColor = SystemColors.GrayText;
            lblSearchHint.Location = new Point(10, 317);
            lblSearchHint.Name = "lblSearchHint";
            lblSearchHint.Text = "Type part of a product name, then click Search.";
            lblSearchHint.TabIndex = 12;
            // 
            // grpCart
            // 
            grpCart.Controls.Add(lblTotalValue);
            grpCart.Controls.Add(lblTotal);
            grpCart.Controls.Add(lblTaxValue);
            grpCart.Controls.Add(lblTax);
            grpCart.Controls.Add(lblSubtotalValue);
            grpCart.Controls.Add(lblSubtotal);
            grpCart.Controls.Add(btnRemove);
            grpCart.Controls.Add(btnUpdateQty);
            grpCart.Controls.Add(txtCartQuantity);
            grpCart.Controls.Add(lblCartQuantity);
            grpCart.Controls.Add(dgvCart);
            grpCart.Location = new Point(380, 50);
            grpCart.Name = "grpCart";
            grpCart.Size = new Size(405, 342);
            grpCart.TabStop = false;
            grpCart.Text = "Cart";
            grpCart.TabIndex = 13;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AllowUserToResizeRows = false;
            dgvCart.BackgroundColor = SystemColors.Window;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(10, 26);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(385, 200);
            dgvCart.TabIndex = 14;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { colCartProductNumber, colCartName, colCartQty, colCartUnitPrice, colCartLineTotal });
            dgvCart.SelectionChanged += dgvCart_SelectionChanged;
            // 
            // colCartProductNumber
            // 
            colCartProductNumber.HeaderText = "Product #";
            colCartProductNumber.Name = "colCartProductNumber";
            colCartProductNumber.ReadOnly = true;
            colCartProductNumber.Width = 85;
            // 
            // colCartName
            // 
            colCartName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCartName.HeaderText = "Name";
            colCartName.Name = "colCartName";
            colCartName.ReadOnly = true;
            // 
            // colCartQty
            // 
            colCartQty.HeaderText = "Qty";
            colCartQty.Name = "colCartQty";
            colCartQty.ReadOnly = true;
            colCartQty.Width = 45;
            // 
            // colCartUnitPrice
            // 
            colCartUnitPrice.HeaderText = "Unit Price";
            colCartUnitPrice.Name = "colCartUnitPrice";
            colCartUnitPrice.ReadOnly = true;
            colCartUnitPrice.Width = 80;
            // 
            // colCartLineTotal
            // 
            colCartLineTotal.HeaderText = "Line Total";
            colCartLineTotal.Name = "colCartLineTotal";
            colCartLineTotal.ReadOnly = true;
            colCartLineTotal.Width = 85;
            // 
            // lblCartQuantity
            // 
            lblCartQuantity.AutoSize = true;
            lblCartQuantity.Location = new Point(10, 240);
            lblCartQuantity.Name = "lblCartQuantity";
            lblCartQuantity.Text = "Qty:";
            lblCartQuantity.TabIndex = 15;
            // 
            // txtCartQuantity
            // 
            txtCartQuantity.Location = new Point(48, 237);
            txtCartQuantity.MaxLength = 3;
            txtCartQuantity.Name = "txtCartQuantity";
            txtCartQuantity.Size = new Size(55, 25);
            txtCartQuantity.TextAlign = HorizontalAlignment.Right;
            txtCartQuantity.TabIndex = 16;
            // 
            // btnUpdateQty
            // 
            btnUpdateQty.BackColor = Color.FromArgb(31, 78, 121);
            btnUpdateQty.FlatAppearance.BorderSize = 0;
            btnUpdateQty.FlatStyle = FlatStyle.Flat;
            btnUpdateQty.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateQty.ForeColor = Color.White;
            btnUpdateQty.Location = new Point(113, 233);
            btnUpdateQty.Name = "btnUpdateQty";
            btnUpdateQty.Size = new Size(115, 32);
            btnUpdateQty.Text = "Update Qty";
            btnUpdateQty.UseVisualStyleBackColor = false;
            btnUpdateQty.TabIndex = 17;
            btnUpdateQty.Click += btnUpdateQty_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(192, 0, 0);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(238, 233);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(95, 32);
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.TabIndex = 18;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Location = new Point(180, 270);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(110, 22);
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            lblSubtotal.Text = "Subtotal:";
            lblSubtotal.TabIndex = 19;
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.Location = new Point(290, 270);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(105, 22);
            lblSubtotalValue.TextAlign = ContentAlignment.MiddleRight;
            lblSubtotalValue.Text = "$0.00";
            lblSubtotalValue.TabIndex = 20;
            // 
            // lblTax
            // 
            lblTax.Location = new Point(180, 292);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(110, 22);
            lblTax.TextAlign = ContentAlignment.MiddleRight;
            lblTax.Text = "Tax (7%):";
            lblTax.TabIndex = 21;
            // 
            // lblTaxValue
            // 
            lblTaxValue.Location = new Point(290, 292);
            lblTaxValue.Name = "lblTaxValue";
            lblTaxValue.Size = new Size(105, 22);
            lblTaxValue.TextAlign = ContentAlignment.MiddleRight;
            lblTaxValue.Text = "$0.00";
            lblTaxValue.TabIndex = 22;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(180, 314);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(110, 24);
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Text = "Total:";
            lblTotal.TabIndex = 23;
            // 
            // lblTotalValue
            // 
            lblTotalValue.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalValue.Location = new Point(290, 314);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(105, 24);
            lblTotalValue.TextAlign = ContentAlignment.MiddleRight;
            lblTotalValue.Text = "$0.00";
            lblTotalValue.TabIndex = 24;
            // 
            // btnCompleteSale
            // 
            btnCompleteSale.BackColor = Color.FromArgb(46, 125, 60);
            btnCompleteSale.FlatAppearance.BorderSize = 0;
            btnCompleteSale.FlatStyle = FlatStyle.Flat;
            btnCompleteSale.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompleteSale.ForeColor = Color.White;
            btnCompleteSale.Location = new Point(15, 402);
            btnCompleteSale.Name = "btnCompleteSale";
            btnCompleteSale.Size = new Size(170, 40);
            btnCompleteSale.Text = "Complete Sale";
            btnCompleteSale.UseVisualStyleBackColor = false;
            btnCompleteSale.TabIndex = 25;
            btnCompleteSale.Click += btnCompleteSale_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(195, 402);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 40);
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.TabIndex = 26;
            btnCancel.Click += btnCancel_Click;
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
            btnBack.TabIndex = 27;
            btnBack.Click += btnBack_Click;
            // 
            // frmNewSale
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnCancel);
            Controls.Add(btnCompleteSale);
            Controls.Add(grpCart);
            Controls.Add(grpFindProduct);
            Controls.Add(dtpOrderDate);
            Controls.Add(lblOrderDate);
            Controls.Add(txtOrderNumber);
            Controls.Add(lblOrderNumber);
            Controls.Add(cboCustomer);
            Controls.Add(lblCustomer);
            AcceptButton = btnSearch;
            Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmNewSale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Sale";
            Load += frmNewSale_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            grpFindProduct.ResumeLayout(false);
            grpFindProduct.PerformLayout();
            grpCart.ResumeLayout(false);
            grpCart.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomer;
        private ComboBox cboCustomer;
        private Label lblOrderNumber;
        private TextBox txtOrderNumber;
        private Label lblOrderDate;
        private DateTimePicker dtpOrderDate;
        private GroupBox grpFindProduct;
        private TextBox txtProductSearch;
        private Button btnSearch;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colProductNumber;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnAddToCart;
        private Label lblSearchHint;
        private GroupBox grpCart;
        private DataGridView dgvCart;
        private DataGridViewTextBoxColumn colCartProductNumber;
        private DataGridViewTextBoxColumn colCartName;
        private DataGridViewTextBoxColumn colCartQty;
        private DataGridViewTextBoxColumn colCartUnitPrice;
        private DataGridViewTextBoxColumn colCartLineTotal;
        private Label lblCartQuantity;
        private TextBox txtCartQuantity;
        private Button btnUpdateQty;
        private Button btnRemove;
        private Label lblSubtotal;
        private Label lblSubtotalValue;
        private Label lblTax;
        private Label lblTaxValue;
        private Label lblTotal;
        private Label lblTotalValue;
        private Button btnCompleteSale;
        private Button btnCancel;
        private Button btnBack;
    }
}
