using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BikeShop.Helpers;
using System.Linq;

namespace BikeShop.Forms
{
    public partial class frmProductMaintenance : Form
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
        }

        private void LoadProducts()
        {
            using var db = DatabaseHelper.CreateContext();
            var products = db.Products
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
        }
        private bool validateData()
        {
            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Please enter a brand.");
                txtBrand.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Please enter a model.");
                txtModel.Focus();
                return false;
            }

            if (cboType2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a bike type.");
                cboType2.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.");
                txtPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                txtQuantity.Focus();
                return false;
            }

            return true;
        }

        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please enter a search term.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtSearch.Focus();
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete button selected.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
