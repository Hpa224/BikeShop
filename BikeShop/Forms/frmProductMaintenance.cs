using BikeShop.Entities;
using BikeShop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BikeShop.Forms
{
    public partial class frmProductMaintenance : Form
    {
        private int? selectedProductId = null;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public frmProductMaintenance()
        {
            InitializeComponent();
            FormCaptionBackColor = Color.FromArgb(31, 78, 121);
            FormCaptionTextColor = Color.White;

            btnAdd.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 15, 15)
            );

            btnUpdate.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnUpdate.Width, btnUpdate.Height, 15, 15)
            );

            btnDelete.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnDelete.Width, btnDelete.Height, 15, 15)
            );

            btnClear.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 15, 15)
            );
        }
        private void LoadCategories()
        {
            using var db = DatabaseHelper.CreateContext();

            var categories = db.ProductCategories
                .OrderBy(c => c.Name)
                .ToList();

            var filterCategories = categories.ToList();

            filterCategories.Insert(0, new BikeShop.Entities.ProductCategory
            {
                ProductCategoryId = 0,
                Name = "All Categories"
            });

            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "ProductCategoryId";
            cboCategory.DataSource = filterCategories;
            cboCategory.SelectedIndex = -1;
            cboCategory2.DisplayMember = "Name";
            cboCategory2.ValueMember = "ProductCategoryId";
            cboCategory2.DataSource = categories.ToList();
            cboCategory2.SelectedIndex = -1;
        }

        private void LoadProducts()
        {
            using var db = DatabaseHelper.CreateContext();
            var query = db.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                query = query.Where(p => p.Name.Contains(txtSearch.Text.Trim()));
            }

            if (cboCategory.SelectedValue is int categoryId && categoryId != 0)
            {
                query = query.Where(p => p.ProductCategoryId == categoryId);
            }

            var products = query
                .Select(p => new
                {
                    p.ProductId,
                    p.ProductNumber,
                    p.Name,
                    p.ProductCategoryId,
                    Category = p.ProductCategory != null
                        ? p.ProductCategory.Name
                        : "",
                    p.ListPrice
                })
                .ToList();
            dgvInventory.AutoGenerateColumns = false;
            dgvInventory.DataSource = products;
            dgvInventory.ClearSelection();
            dgvInventory.CurrentCell = null;
        }

        private bool validateData()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name.");
                txtProductName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProductNumber.Text))
            {
                MessageBox.Show("Please enter a product number.");
                txtProductNumber.Focus();
                return false;
            }

            if (cboCategory2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product category.");
                cboCategory2.Focus();
                return false;
            }

            if (!decimal.TryParse(txtStandardCost.Text, out decimal cost) || cost <= 0)
            {
                MessageBox.Show("Please enter a valid standard cost.");
                txtStandardCost.Focus();
                return false;
            }

            if (!decimal.TryParse(txtListPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid list price.");
                txtListPrice.Focus();
                return false;
            }

            return true;
        }

        private void ClearDetails()
        {
            selectedProductId = null;
            txtProductName.Clear();
            txtProductNumber.Clear();
            txtStandardCost.Clear();
            txtListPrice.Clear();
            txtColor.Clear();
            txtSize.Clear();
            cboCategory2.SelectedIndex = -1;
            dgvInventory.ClearSelection();
            dgvInventory.CurrentCell = null;
        }
        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validateData())
            {
                return;
            }
            using var db = DatabaseHelper.CreateContext();
            var product = new BikeShop.Entities.Product

            {
                Name = txtProductName.Text.Trim(),
                ProductNumber = txtProductNumber.Text.Trim(),
                ProductCategoryId = (int)cboCategory2.SelectedValue,
                StandardCost = decimal.Parse(txtStandardCost.Text),
                ListPrice = decimal.Parse(txtListPrice.Text),
                Color = string.IsNullOrWhiteSpace(txtColor.Text) ? null : txtColor.Text.Trim(),
                Size = string.IsNullOrWhiteSpace(txtSize.Text) ? null : txtSize.Text.Trim(),
                SellStartDate = DateTime.Now
            };

            db.Products.Add(product);
            db.SaveChanges();
            MessageBox.Show("Product added successfully.");
            LoadProducts();
            ClearDetails();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (!validateData())
            {
                return;
            }

            using var db = DatabaseHelper.CreateContext();
            var product = db.Products.Find(selectedProductId.Value);

            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            product.Name = txtProductName.Text.Trim();
            product.ProductNumber = txtProductNumber.Text.Trim();
            product.ProductCategoryId = (int)cboCategory2.SelectedValue;
            product.StandardCost = decimal.Parse(txtStandardCost.Text);
            product.ListPrice = decimal.Parse(txtListPrice.Text);
            product.Color = string.IsNullOrWhiteSpace(txtColor.Text) ? null : txtColor.Text.Trim();
            product.Size = string.IsNullOrWhiteSpace(txtSize.Text) ? null : txtSize.Text.Trim();
            product.ModifiedDate = DateTime.Now;
            db.SaveChanges();
            MessageBox.Show("Product updated successfully.");
            LoadProducts();
            ClearDetails();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            using var db = DatabaseHelper.CreateContext();
            var product = db.Products.Find(selectedProductId.Value);

            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            if (db.SalesOrderDetails.Any(s => s.ProductId == product.ProductId))
            {
                MessageBox.Show("Cannot delete a product associated with existing sales.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {product.Name}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            db.Products.Remove(product);
            db.SaveChanges();
            MessageBox.Show("Product deleted successfully.");
            LoadProducts();
            ClearDetails();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBikeDetails_Click(object sender, EventArgs e)
        {

        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int productId = Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells["colProductID"].Value);
            using var db = DatabaseHelper.CreateContext();
            var product = db.Products.Find(productId);

            if (product == null)
            {
                return;
            }
            selectedProductId = product.ProductId;
            txtProductName.Text = product.Name;
            txtProductNumber.Text = product.ProductNumber;
            txtStandardCost.Text = product.StandardCost.ToString("F2");
            txtListPrice.Text = product.ListPrice.ToString("F2");
            txtColor.Text = product.Color ?? "";
            txtSize.Text = product.Size ?? "";

            if (product.ProductCategoryId.HasValue)
            {
                cboCategory2.SelectedValue = product.ProductCategoryId.Value;
            }
            else
            {
                cboCategory2.SelectedIndex = -1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDetails();
        }

        private void txtListPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
