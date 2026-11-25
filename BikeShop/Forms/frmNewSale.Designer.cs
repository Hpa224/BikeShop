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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            lblCustomer = new Label();
            cboCustomer = new ComboBox();
            lblOrderNumber = new Label();
            txtOrderNumber = new TextBox();
            lblOrderDate = new Label();
            dtpOrderDate = new DateTimePicker();
            grpFindProduct = new GroupBox();
            lblSearchHint = new Label();
            btnAddToCart = new Button();
            nudQuantity = new NumericUpDown();
            lblQuantity = new Label();
            dgvProducts = new DataGridView();
            colProductNumber = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            txtProductSearch = new TextBox();
            grpCart = new GroupBox();
            txtTotal = new TextBox();
            lblTotal = new Label();
            txtTax = new TextBox();
            lblTax = new Label();
            txtSubtotal = new TextBox();
            lblSubtotal = new Label();
            lblCartHint = new Label();
            btnRemove = new Button();
            btnUpdateQty = new Button();
            dgvCart = new DataGridView();
            colCartProductNumber = new DataGridViewTextBoxColumn();
            colCartName = new DataGridViewTextBoxColumn();
            colCartQty = new DataGridViewTextBoxColumn();
            colCartUnitPrice = new DataGridViewTextBoxColumn();
            colCartLineTotal = new DataGridViewTextBoxColumn();
            btnCompleteSale = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            grpFindProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            grpCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(12, 13);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(72, 18);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer:";
            // 
            // cboCustomer
            // 
            cboCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustomer.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Location = new Point(95, 12);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(255, 22);
            cboCustomer.TabIndex = 1;
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderNumber.Location = new Point(368, 13);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(58, 18);
            lblOrderNumber.TabIndex = 2;
            lblOrderNumber.Text = "Order #:";
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.BackColor = Color.White;
            txtOrderNumber.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderNumber.Location = new Point(436, 12);
            txtOrderNumber.MaxLength = 25;
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.ReadOnly = true;
            txtOrderNumber.Size = new Size(120, 22);
            txtOrderNumber.TabIndex = 3;
            txtOrderNumber.TabStop = false;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderDate.Location = new Point(578, 13);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(41, 18);
            lblOrderDate.TabIndex = 4;
            lblOrderDate.Text = "Date:";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(625, 12);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(163, 22);
            dtpOrderDate.TabIndex = 5;
            // 
            // grpFindProduct
            // 
            grpFindProduct.BackColor = Color.FromArgb(242, 242, 242);
            grpFindProduct.Controls.Add(lblSearchHint);
            grpFindProduct.Controls.Add(btnAddToCart);
            grpFindProduct.Controls.Add(nudQuantity);
            grpFindProduct.Controls.Add(lblQuantity);
            grpFindProduct.Controls.Add(dgvProducts);
            grpFindProduct.Controls.Add(btnSearch);
            grpFindProduct.Controls.Add(txtProductSearch);
            grpFindProduct.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpFindProduct.ForeColor = Color.FromArgb(31, 78, 121);
            grpFindProduct.Location = new Point(12, 45);
            grpFindProduct.Name = "grpFindProduct";
            grpFindProduct.Size = new Size(345, 340);
            grpFindProduct.TabIndex = 6;
            grpFindProduct.TabStop = false;
            grpFindProduct.Text = "Find Product";
            // 
            // lblSearchHint
            // 
            lblSearchHint.Font = new Font("Calibri", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSearchHint.ForeColor = Color.DimGray;
            lblSearchHint.Location = new Point(10, 305);
            lblSearchHint.Name = "lblSearchHint";
            lblSearchHint.Size = new Size(325, 30);
            lblSearchHint.TabIndex = 13;
            lblSearchHint.Text = "Typing part of a product name (e.g. \"frame\") and clicking Search lists every matching product.";
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FromArgb(46, 125, 60);
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Location = new Point(165, 268);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(170, 32);
            btnAddToCart.TabIndex = 12;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudQuantity.Location = new Point(90, 273);
            nudQuantity.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(60, 22);
            nudQuantity.TabIndex = 11;
            nudQuantity.TextAlign = HorizontalAlignment.Right;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Black;
            lblQuantity.Location = new Point(10, 274);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(66, 18);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity:";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeight = 26;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductNumber, colProductName, colPrice });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 78, 121);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(189, 215, 238);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.FromArgb(217, 217, 217);
            dgvProducts.Location = new Point(10, 60);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(325, 200);
            dgvProducts.TabIndex = 9;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // colProductNumber
            // 
            colProductNumber.HeaderText = "Product #";
            colProductNumber.Name = "colProductNumber";
            colProductNumber.ReadOnly = true;
            colProductNumber.Width = 90;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            colPrice.DefaultCellStyle = dataGridViewCellStyle2;
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 72;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(31, 78, 121);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(240, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 32);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtProductSearch
            // 
            txtProductSearch.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductSearch.Location = new Point(10, 28);
            txtProductSearch.MaxLength = 50;
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.Size = new Size(220, 22);
            txtProductSearch.TabIndex = 7;
            // 
            // grpCart
            // 
            grpCart.BackColor = Color.FromArgb(242, 242, 242);
            grpCart.Controls.Add(txtTotal);
            grpCart.Controls.Add(lblTotal);
            grpCart.Controls.Add(txtTax);
            grpCart.Controls.Add(lblTax);
            grpCart.Controls.Add(txtSubtotal);
            grpCart.Controls.Add(lblSubtotal);
            grpCart.Controls.Add(lblCartHint);
            grpCart.Controls.Add(btnRemove);
            grpCart.Controls.Add(btnUpdateQty);
            grpCart.Controls.Add(dgvCart);
            grpCart.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCart.ForeColor = Color.FromArgb(31, 78, 121);
            grpCart.Location = new Point(367, 45);
            grpCart.Name = "grpCart";
            grpCart.Size = new Size(421, 340);
            grpCart.TabIndex = 14;
            grpCart.TabStop = false;
            grpCart.Text = "Cart";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(311, 312);
            txtTotal.MaxLength = 20;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 22);
            txtTotal.TabIndex = 24;
            txtTotal.TabStop = false;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(185, 312);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(120, 22);
            lblTotal.TabIndex = 23;
            lblTotal.Text = "Total:";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTax
            // 
            txtTax.BackColor = Color.White;
            txtTax.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTax.Location = new Point(311, 284);
            txtTax.MaxLength = 20;
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(100, 22);
            txtTax.TabIndex = 22;
            txtTax.TabStop = false;
            txtTax.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTax
            // 
            lblTax.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTax.ForeColor = Color.Black;
            lblTax.Location = new Point(185, 284);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(120, 22);
            lblTax.TabIndex = 21;
            lblTax.Text = "Tax (7%):";
            lblTax.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSubtotal
            // 
            txtSubtotal.BackColor = Color.White;
            txtSubtotal.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubtotal.Location = new Point(311, 256);
            txtSubtotal.MaxLength = 20;
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(100, 22);
            txtSubtotal.TabIndex = 20;
            txtSubtotal.TabStop = false;
            txtSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.ForeColor = Color.Black;
            lblSubtotal.Location = new Point(185, 256);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(120, 22);
            lblSubtotal.TabIndex = 19;
            lblSubtotal.Text = "Subtotal:";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCartHint
            // 
            lblCartHint.Font = new Font("Calibri", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCartHint.ForeColor = Color.DimGray;
            lblCartHint.Location = new Point(231, 218);
            lblCartHint.Name = "lblCartHint";
            lblCartHint.Size = new Size(180, 30);
            lblCartHint.TabIndex = 18;
            lblCartHint.Text = "Change a Qty in the cart, then click Update Qty.";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(192, 0, 0);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(128, 216);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(95, 32);
            btnRemove.TabIndex = 17;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdateQty
            // 
            btnUpdateQty.BackColor = Color.FromArgb(31, 78, 121);
            btnUpdateQty.FlatAppearance.BorderSize = 0;
            btnUpdateQty.FlatStyle = FlatStyle.Flat;
            btnUpdateQty.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateQty.ForeColor = Color.White;
            btnUpdateQty.Location = new Point(10, 216);
            btnUpdateQty.Name = "btnUpdateQty";
            btnUpdateQty.Size = new Size(110, 32);
            btnUpdateQty.TabIndex = 16;
            btnUpdateQty.Text = "Update Qty";
            btnUpdateQty.UseVisualStyleBackColor = false;
            btnUpdateQty.Click += btnUpdateQty_Click;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AllowUserToResizeRows = false;
            dgvCart.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCart.ColumnHeadersHeight = 26;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { colCartProductNumber, colCartName, colCartQty, colCartUnitPrice, colCartLineTotal });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(31, 78, 121);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(189, 215, 238);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle8;
            dgvCart.EnableHeadersVisualStyles = false;
            dgvCart.GridColor = Color.FromArgb(217, 217, 217);
            dgvCart.Location = new Point(10, 28);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersVisible = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(401, 180);
            dgvCart.TabIndex = 15;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCartQty.DefaultCellStyle = dataGridViewCellStyle5;
            colCartQty.HeaderText = "Qty";
            colCartQty.Name = "colCartQty";
            colCartQty.Width = 45;
            // 
            // colCartUnitPrice
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            colCartUnitPrice.DefaultCellStyle = dataGridViewCellStyle6;
            colCartUnitPrice.HeaderText = "Unit Price";
            colCartUnitPrice.Name = "colCartUnitPrice";
            colCartUnitPrice.ReadOnly = true;
            colCartUnitPrice.Width = 75;
            // 
            // colCartLineTotal
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            colCartLineTotal.DefaultCellStyle = dataGridViewCellStyle7;
            colCartLineTotal.HeaderText = "Line Total";
            colCartLineTotal.Name = "colCartLineTotal";
            colCartLineTotal.ReadOnly = true;
            colCartLineTotal.Width = 80;
            // 
            // btnCompleteSale
            // 
            btnCompleteSale.BackColor = Color.FromArgb(46, 125, 60);
            btnCompleteSale.FlatAppearance.BorderSize = 0;
            btnCompleteSale.FlatStyle = FlatStyle.Flat;
            btnCompleteSale.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompleteSale.ForeColor = Color.White;
            btnCompleteSale.Location = new Point(12, 393);
            btnCompleteSale.Name = "btnCompleteSale";
            btnCompleteSale.Size = new Size(160, 45);
            btnCompleteSale.TabIndex = 25;
            btnCompleteSale.Text = "Complete Sale";
            btnCompleteSale.UseVisualStyleBackColor = false;
            btnCompleteSale.Click += btnCompleteSale_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(182, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 45);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            btnBack.TabIndex = 27;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmNewSale
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmNewSale";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Sale";
            Load += frmNewSale_Load;
            grpFindProduct.ResumeLayout(false);
            grpFindProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            grpCart.ResumeLayout(false);
            grpCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
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
        private NumericUpDown nudQuantity;
        private Button btnAddToCart;
        private Label lblSearchHint;
        private GroupBox grpCart;
        private DataGridView dgvCart;
        private DataGridViewTextBoxColumn colCartProductNumber;
        private DataGridViewTextBoxColumn colCartName;
        private DataGridViewTextBoxColumn colCartQty;
        private DataGridViewTextBoxColumn colCartUnitPrice;
        private DataGridViewTextBoxColumn colCartLineTotal;
        private Button btnUpdateQty;
        private Button btnRemove;
        private Label lblCartHint;
        private Label lblSubtotal;
        private TextBox txtSubtotal;
        private Label lblTax;
        private TextBox txtTax;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnCompleteSale;
        private Button btnCancel;
        private Button btnBack;
    }
}
