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

        private readonly ShoppingCart cart = new ShoppingCart();

        public frmNewSale()
        {
            InitializeComponent();
            FormCaptionBackColor = Color.FromArgb(31, 78, 121);
            FormCaptionTextColor = Color.White;

            btnSearch.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 15, 15)
            );

            btnAddToCart.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnAddToCart.Width, btnAddToCart.Height, 15, 15)
            );

            btnUpdateQty.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnUpdateQty.Width, btnUpdateQty.Height, 15, 15)
            );

            btnRemove.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnRemove.Width, btnRemove.Height, 15, 15)
            );

            btnCompleteSale.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnCompleteSale.Width, btnCompleteSale.Height, 15, 15)
            );

            btnCancel.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnCancel.Width, btnCancel.Height, 15, 15)
            );

            btnBack.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnBack.Width, btnBack.Height, 15, 15)
            );
        }

        private void frmNewSale_Load(object sender, EventArgs e)
        {
            ValidationHelper.Title = "Sale Entry Error";

            foreach (Customer c in SampleData.Customers.OrderBy(c => c.LastName).ThenBy(c => c.FirstName))
            {
                cboCustomer.Items.Add(c);
            }

            // Sales are entered for today or up to 30 days back, never in the future
            dtpOrderDate.Value = DateTime.Today;
            dtpOrderDate.MaxDate = DateTime.Today;
            dtpOrderDate.MinDate = DateTime.Today.AddDays(-30);

            StartNewSale();
        }

        private void StartNewSale()
        {
            cart.Clear();
            txtOrderNumber.Text = $"SO{SampleData.PeekNextOrderID()} (auto)";
            cboCustomer.SelectedIndex = -1;
            dtpOrderDate.Value = DateTime.Today;
            txtProductSearch.Clear();
            dgvProducts.Rows.Clear();
            nudQuantity.Value = 1;
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
                MessageBox.Show(this, $"No products found matching \"{txtProductSearch.Text.Trim()}\".", "Find Product");
                txtProductSearch.Focus();
                return;
            }

            foreach (Product p in matches)
            {
                int row = dgvProducts.Rows.Add(p.ProductNumber, p.Name, p.ListPrice);
                dgvProducts.Rows[row].Tag = p;
            }
            dgvProducts.Rows[0].Selected = true;
            nudQuantity.Focus();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnAddToCart.PerformClick();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0 || dgvProducts.SelectedRows[0].Tag is not Product product)
            {
                MessageBox.Show(this, "Search for a product and select it in the list first.", ValidationHelper.Title);
                txtProductSearch.Focus();
                return;
            }
            if (!ValidationHelper.IsWithinRange(nudQuantity, "Quantity", CartItem.MinQuantity, CartItem.MaxQuantity)) return;

            int quantity = (int)nudQuantity.Value;
            CartItem? existing = cart.Find(product.ProductID);
            if (existing != null && existing.Quantity + quantity > CartItem.MaxQuantity)
            {
                MessageBox.Show(this, $"The cart already has {existing.Quantity} of this product. " +
                    $"The total quantity cannot be more than {CartItem.MaxQuantity}.", ValidationHelper.Title);
                nudQuantity.Focus();
                return;
            }

            cart.Add(product, quantity);
            RefreshCart(product.ProductID);
            nudQuantity.Value = 1;
        }

        // ---------------- Cart ----------------

        private void btnUpdateQty_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0 || dgvCart.SelectedRows[0].Tag is not CartItem item)
            {
                MessageBox.Show(this, "Select an item in the cart and change its Qty first.", ValidationHelper.Title);
                return;
            }

            dgvCart.EndEdit();
            object? value = dgvCart.SelectedRows[0].Cells[colCartQty.Index].Value;
            if (!ValidationHelper.IsInt32WithinRange(value?.ToString(), "Quantity",
                    CartItem.MinQuantity, CartItem.MaxQuantity, dgvCart))
            {
                dgvCart.CurrentCell = dgvCart.SelectedRows[0].Cells[colCartQty.Index];
                return;
            }

            cart.UpdateQuantity(item.Product.ProductID, Convert.ToInt32(value));
            RefreshCart(item.Product.ProductID);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0 || dgvCart.SelectedRows[0].Tag is not CartItem item)
            {
                MessageBox.Show(this, "Select an item in the cart to remove.", ValidationHelper.Title);
                return;
            }

            cart.Remove(item.Product.ProductID);
            RefreshCart();
        }

        /// <summary>Redraws the cart and the subtotal, tax and total after every change.</summary>
        private void RefreshCart(int? selectProductID = null)
        {
            dgvCart.Rows.Clear();
            foreach (CartItem item in cart.Items)
            {
                int row = dgvCart.Rows.Add(item.Product.ProductNumber, item.Product.Name,
                                           item.Quantity, item.UnitPrice, item.LineTotal);
                dgvCart.Rows[row].Tag = item;
                if (item.Product.ProductID == selectProductID) dgvCart.Rows[row].Selected = true;
            }
            if (selectProductID == null) dgvCart.ClearSelection();

            txtSubtotal.Text = cart.Subtotal.ToString("c");
            txtTax.Text = cart.Tax.ToString("c");
            txtTotal.Text = cart.Total.ToString("c");
        }

        // ---------------- Complete / Cancel / Back ----------------

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (!IsValidData()) return;

            cart.Customer = (Customer)cboCustomer.SelectedItem!;
            // Order numbers increase in sequence
            SalesOrder order = SalesOrder.CreateFromCart(cart, SampleData.GetNextOrderID(), dtpOrderDate.Value);
            SampleData.Orders.Add(order);

            using (var receipt = new frmReceipt(order))
            {
                receipt.ShowDialog(this);
            }
            StartNewSale();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!cart.IsEmpty)
            {
                DialogResult answer = MessageBox.Show(this, "Cancel this sale and empty the cart?", "Cancel Sale",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (answer != DialogResult.Yes) return;
            }
            StartNewSale();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!cart.IsEmpty)
            {
                DialogResult answer = MessageBox.Show(this, "The cart has items that have not been sold. Leave anyway?",
                    "New Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (answer != DialogResult.Yes) return;
            }
            Close();
        }

        // ---------------- Validation ----------------

        private bool IsValidData()
        {
            if (!ValidationHelper.IsSelected(cboCustomer, "customer")) return false;
            if (!ValidationHelper.IsDateWithinRange(dtpOrderDate, "Date",
                    DateTime.Today.AddDays(-30), DateTime.Today)) return false;

            if (cart.IsEmpty)
            {
                MessageBox.Show(this, "The cart is empty. Add at least one product before completing the sale.",
                    ValidationHelper.Title);
                txtProductSearch.Focus();
                return false;
            }
            return true;
        }
    }
}
