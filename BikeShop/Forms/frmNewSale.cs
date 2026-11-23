using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BikeShop.Helpers;
using BikeShop.Models;

namespace BikeShop.Forms
{
    /// <summary>
    /// New Sale (shopping cart): select a customer, search products by partial
    /// name, add quantities to the cart, then complete the sale and show the receipt.
    /// </summary>
    public partial class frmNewSale : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private SalesOrder order = new SalesOrder();

        public frmNewSale()
        {
            InitializeComponent();
            FormCaptionBackColor = Color.FromArgb(31, 78, 121);
            FormCaptionTextColor = Color.White;

            foreach (Button button in new[] { btnSearch, btnAddToCart, btnUpdateQty, btnRemove,
                                              btnCompleteSale, btnCancel, btnBack })
            {
                button.Region = System.Drawing.Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, button.Width, button.Height, 15, 15)
                );
            }

            // Number columns line up on the right and show as money
            colPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPrice.DefaultCellStyle.Format = "N2";
            colCartQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCartUnitPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCartUnitPrice.DefaultCellStyle.Format = "N2";
            colCartLineTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCartLineTotal.DefaultCellStyle.Format = "N2";
        }

        private void frmNewSale_Load(object sender, EventArgs e)
        {
            ValidationHelper.Title = "Sale Entry Error";
            LoadCustomers();

            // Sales are entered for today or a few days back, never in the future
            dtpOrderDate.Value = DateTime.Today;
            dtpOrderDate.MaxDate = DateTime.Today;
            dtpOrderDate.MinDate = DateTime.Today.AddDays(-30);

            StartNewOrder();
        }

        private void LoadCustomers()
        {
            cboCustomer.Items.Clear();
            foreach (Customer c in SampleData.Customers.OrderBy(c => c.LastName).ThenBy(c => c.FirstName))
            {
                cboCustomer.Items.Add(c);
            }
        }

        private void StartNewOrder()
        {
            order = new SalesOrder { SalesOrderID = SampleData.PeekNextOrderID() };
            txtOrderNumber.Text = $"{order.SalesOrderNumber}";
            cboCustomer.SelectedIndex = -1;
            dtpOrderDate.Value = DateTime.Today;
            txtProductSearch.Clear();
            dgvProducts.Rows.Clear();
            txtQuantity.Text = "1";
            txtCartQuantity.Clear();
            RefreshCart();
            cboCustomer.Focus();
        }

        // ---------------- Find Product ----------------

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.IsPresent(txtProductSearch, "Product name")) return;

            List<Product> matches = SampleData.SearchProducts(txtProductSearch.Text);
            dgvProducts.Rows.Clear();
            if (matches.Count == 0)
            {
                MessageBox.Show(this, $"No products found matching \"{txtProductSearch.Text.Trim()}\".",
                    "Find Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductSearch.Focus();
                return;
            }

            foreach (Product p in matches)
            {
                int row = dgvProducts.Rows.Add(p.ProductNumber, p.Name, p.ListPrice);
                dgvProducts.Rows[row].Tag = p;
            }
            dgvProducts.Rows[0].Selected = true;
            txtQuantity.Focus();
            txtQuantity.SelectAll();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnAddToCart.PerformClick();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0 || dgvProducts.SelectedRows[0].Tag is not Product product)
            {
                MessageBox.Show(this, "Search for a product and select it in the list first.",
                    ValidationHelper.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductSearch.Focus();
                return;
            }
            if (!IsValidQuantity(txtQuantity)) return;

            short quantity = Convert.ToInt16(txtQuantity.Text);
            SalesOrderDetail? line = order.Details.FirstOrDefault(d => d.ProductID == product.ProductID);

            if (line == null)
            {
                order.Details.Add(new SalesOrderDetail
                {
                    ProductID = product.ProductID,
                    ProductNumber = product.ProductNumber,
                    ProductName = product.Name,
                    OrderQty = quantity,
                    UnitPrice = product.ListPrice
                });
            }
            else
            {
                // Same product added again: combine the quantities
                int newQty = line.OrderQty + quantity;
                if (newQty > SalesOrderDetail.MaxQuantity)
                {
                    MessageBox.Show(this, $"The cart already has {line.OrderQty} of this product. " +
                        $"The total quantity cannot be more than {SalesOrderDetail.MaxQuantity}.",
                        ValidationHelper.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantity.Focus();
                    return;
                }
                line.OrderQty = (short)newQty;
            }

            RefreshCart(product.ProductID);
            txtQuantity.Text = "1";
        }

        // ---------------- Cart ----------------

        private void dgvCart_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedCartLine() is SalesOrderDetail line)
            {
                txtCartQuantity.Text = line.OrderQty.ToString();
            }
        }

        private void btnUpdateQty_Click(object sender, EventArgs e)
        {
            if (SelectedCartLine() is not SalesOrderDetail line)
            {
                MessageBox.Show(this, "Select an item in the cart to change its quantity.",
                    ValidationHelper.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidQuantity(txtCartQuantity)) return;

            line.OrderQty = Convert.ToInt16(txtCartQuantity.Text);
            RefreshCart(line.ProductID);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (SelectedCartLine() is not SalesOrderDetail line)
            {
                MessageBox.Show(this, "Select an item in the cart to remove.",
                    ValidationHelper.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            order.Details.Remove(line);
            txtCartQuantity.Clear();
            RefreshCart();
        }

        private SalesOrderDetail? SelectedCartLine() =>
            dgvCart.SelectedRows.Count == 0 ? null : dgvCart.SelectedRows[0].Tag as SalesOrderDetail;

        /// <summary>Redraws the cart and recalculates subtotal, tax and total.</summary>
        private void RefreshCart(int? selectProductID = null)
        {
            dgvCart.Rows.Clear();
            foreach (SalesOrderDetail d in order.Details)
            {
                int row = dgvCart.Rows.Add(d.ProductNumber, d.ProductName, d.OrderQty, d.UnitPrice, d.LineTotal);
                dgvCart.Rows[row].Tag = d;
                if (d.ProductID == selectProductID) dgvCart.Rows[row].Selected = true;
            }
            if (selectProductID == null) dgvCart.ClearSelection();

            lblSubtotalValue.Text = order.SubTotal.ToString("c");
            lblTaxValue.Text = order.TaxAmt.ToString("c");
            lblTotalValue.Text = order.TotalDue.ToString("c");
        }

        // ---------------- Complete / Cancel ----------------

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (!IsValidOrder()) return;

            order.Customer = (Customer)cboCustomer.SelectedItem!;
            order.OrderDate = dtpOrderDate.Value.Date;
            order.DueDate = order.OrderDate.AddDays(7);
            order.SalesOrderID = SampleData.GetNextOrderID();   // order numbers increase in sequence
            for (int i = 0; i < order.Details.Count; i++)
            {
                order.Details[i].SalesOrderID = order.SalesOrderID;
                order.Details[i].SalesOrderDetailID = i + 1;
            }
            SampleData.Orders.Add(order);

            using (var receipt = new frmReceipt(order))
            {
                receipt.ShowDialog(this);
            }
            StartNewOrder();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (order.Details.Count > 0)
            {
                DialogResult answer = MessageBox.Show(this, "Cancel this sale and empty the cart?",
                    "Cancel Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (answer != DialogResult.Yes) return;
            }
            StartNewOrder();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (order.Details.Count > 0)
            {
                DialogResult answer = MessageBox.Show(this, "The cart has items that have not been sold. Leave anyway?",
                    "New Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (answer != DialogResult.Yes) return;
            }
            Close();
        }

        // ---------------- Validation ----------------

        private bool IsValidQuantity(TextBox textBox)
        {
            return
                ValidationHelper.IsPresent(textBox, "Quantity") &&
                ValidationHelper.IsInt32(textBox, "Quantity") &&
                ValidationHelper.IsWithinRange(textBox, "Quantity",
                    SalesOrderDetail.MinQuantity, SalesOrderDetail.MaxQuantity);
        }

        private bool IsValidOrder()
        {
            if (!ValidationHelper.IsSelected(cboCustomer, "customer")) return false;
            if (!ValidationHelper.IsDateWithinRange(dtpOrderDate, "Order date",
                    DateTime.Today.AddDays(-30), DateTime.Today)) return false;

            if (order.Details.Count == 0)
            {
                MessageBox.Show(this, "The cart is empty. Add at least one product before completing the sale.",
                    ValidationHelper.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductSearch.Focus();
                return false;
            }
            return true;
        }
    }
}
