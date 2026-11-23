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
    /// Customer maintenance: search, add, update and delete customers and their
    /// main address. Data comes from SampleData until BikeStore.mdf is connected.
    /// </summary>
    public partial class frmCustomerMaintenance : Form
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

        private Customer? selectedCustomer;
        private bool loadingGrid;

        public frmCustomerMaintenance()
        {
            InitializeComponent();
            FormCaptionBackColor = Color.FromArgb(31, 78, 121);
            FormCaptionTextColor = Color.White;

            foreach (Button button in new[] { btnFind, btnShowAll, btnAdd, btnSave, btnDelete,
                                              btnClear, btnPurchaseHistory, btnBack })
            {
                button.Region = System.Drawing.Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, button.Width, button.Height, 15, 15)
                );
            }
        }

        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
            ValidationHelper.Title = "Customer Entry Error";
            LoadCustomerGrid(SampleData.Customers);
            ClearForm();
        }

        // ---------------- Grid ----------------

        private void LoadCustomerGrid(IEnumerable<Customer> customers)
        {
            loadingGrid = true;
            dgvCustomers.Rows.Clear();
            foreach (Customer c in customers.OrderBy(c => c.LastName).ThenBy(c => c.FirstName))
            {
                int row = dgvCustomers.Rows.Add(c.CustomerID, c.FullName, c.CompanyName, c.Phone, c.EmailAddress);
                dgvCustomers.Rows[row].Tag = c;
            }
            dgvCustomers.ClearSelection();
            loadingGrid = false;
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (loadingGrid || dgvCustomers.SelectedRows.Count == 0) return;

            selectedCustomer = dgvCustomers.SelectedRows[0].Tag as Customer;
            if (selectedCustomer != null) DisplayCustomer(selectedCustomer);
        }

        private void DisplayCustomer(Customer c)
        {
            cboTitle.SelectedIndex = cboTitle.FindStringExact(c.Title ?? "");
            txtFirstName.Text = c.FirstName;
            txtMiddleName.Text = c.MiddleName;
            txtLastName.Text = c.LastName;
            txtSuffix.Text = c.Suffix;
            txtCompanyName.Text = c.CompanyName;
            txtEmail.Text = c.EmailAddress;
            mskPhone.Text = c.Phone;

            cboAddressType.SelectedIndex = cboAddressType.FindStringExact(c.Address.AddressType);
            txtAddressLine1.Text = c.Address.AddressLine1;
            txtAddressLine2.Text = c.Address.AddressLine2;
            txtCity.Text = c.Address.City;
            txtStateProvince.Text = c.Address.StateProvince;
            mskPostalCode.Text = c.Address.PostalCode;
            cboCountryRegion.SelectedIndex = cboCountryRegion.FindStringExact(c.Address.CountryRegion);
        }

        // ---------------- Search ----------------

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.IsPresent(txtSearch, "Search text")) return;

            string text = txtSearch.Text.Trim();
            var matches = SampleData.Customers.Where(c =>
                    c.FirstName.Contains(text, StringComparison.OrdinalIgnoreCase) ||
                    c.LastName.Contains(text, StringComparison.OrdinalIgnoreCase) ||
                    (c.CompanyName ?? "").Contains(text, StringComparison.OrdinalIgnoreCase) ||
                    (c.EmailAddress ?? "").Contains(text, StringComparison.OrdinalIgnoreCase) ||
                    (c.Phone ?? "").Contains(text))
                .ToList();

            if (matches.Count == 0)
            {
                MessageBox.Show(this, $"No customers found matching \"{text}\".", "Find Customer",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
                return;
            }

            LoadCustomerGrid(matches);
            ClearForm();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadCustomerGrid(SampleData.Customers);
            ClearForm();
        }

        // ---------------- Add / Save / Delete ----------------

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidData()) return;

            var customer = new Customer { CustomerID = SampleData.GetNextCustomerID() };
            customer.Address.AddressID = customer.CustomerID;
            PutCustomerData(customer);
            SampleData.Customers.Add(customer);

            MessageBox.Show(this, $"Customer {customer.FullName} was added (ID {customer.CustomerID}).",
                "Customer Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCustomerGrid(SampleData.Customers);
            SelectCustomerRow(customer);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show(this, "Select a customer in the list before saving changes.\n" +
                    "To create a new customer, fill in the fields and click Add.", "Save Customer",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsValidData()) return;

            PutCustomerData(selectedCustomer);
            MessageBox.Show(this, $"Changes to {selectedCustomer.FullName} were saved.", "Customer Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Customer saved = selectedCustomer;
            LoadCustomerGrid(SampleData.Customers);
            SelectCustomerRow(saved);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show(this, "Select a customer in the list to delete.", "Delete Customer",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (SampleData.Orders.Any(o => o.CustomerID == selectedCustomer.CustomerID))
            {
                MessageBox.Show(this, $"{selectedCustomer.FullName} has sales orders and cannot be deleted.",
                    "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult answer = MessageBox.Show(this,
                $"Delete customer {selectedCustomer.FullName}?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (answer != DialogResult.Yes) return;

            SampleData.Customers.Remove(selectedCustomer);
            LoadCustomerGrid(SampleData.Customers);
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show(this, "Select a customer to view purchase history.", "Purchase History",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var orders = SampleData.Orders.Where(o => o.CustomerID == selectedCustomer.CustomerID)
                                          .OrderByDescending(o => o.OrderDate).ToList();
            if (orders.Count == 0)
            {
                MessageBox.Show(this, $"{selectedCustomer.FullName} has no purchases yet.", "Purchase History",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sb = new StringBuilder();
            foreach (SalesOrder o in orders)
            {
                sb.AppendLine($"{o.SalesOrderNumber}   {o.OrderDate:d}   {o.ItemCount} item(s)   {o.TotalDue:c}");
            }
            sb.AppendLine();
            sb.AppendLine($"Total purchases: {orders.Sum(o => o.TotalDue):c}");
            MessageBox.Show(this, sb.ToString(), $"Purchase History – {selectedCustomer.FullName}",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ---------------- Helpers ----------------

        private bool IsValidData()
        {
            return
                ValidationHelper.IsPresent(txtFirstName, "First Name") &&
                ValidationHelper.IsPresent(txtLastName, "Last Name") &&
                ValidationHelper.IsPresent(txtEmail, "Email") &&
                ValidationHelper.IsValidEmail(txtEmail, "Email") &&
                ValidationHelper.IsMaskCompleted(mskPhone, "Phone") &&
                ValidationHelper.IsSelected(cboAddressType, "Address Type") &&
                ValidationHelper.IsPresent(txtAddressLine1, "Address 1") &&
                ValidationHelper.IsPresent(txtCity, "City") &&
                ValidationHelper.IsPresent(txtStateProvince, "State/Province") &&
                ValidationHelper.IsMaskCompleted(mskPostalCode, "Postal Code") &&
                ValidationHelper.IsSelected(cboCountryRegion, "Country") &&
                IsUniqueEmail();
        }

        private bool IsUniqueEmail()
        {
            string email = txtEmail.Text.Trim();
            bool taken = SampleData.Customers.Any(c => c != selectedCustomer &&
                string.Equals(c.EmailAddress, email, StringComparison.OrdinalIgnoreCase));
            if (taken)
            {
                MessageBox.Show(this, "Another customer already uses this email address.",
                    ValidationHelper.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        private void PutCustomerData(Customer c)
        {
            c.Title = cboTitle.SelectedIndex == -1 ? null : cboTitle.Text;
            c.FirstName = txtFirstName.Text.Trim();
            c.MiddleName = NullIfBlank(txtMiddleName.Text);
            c.LastName = txtLastName.Text.Trim();
            c.Suffix = NullIfBlank(txtSuffix.Text);
            c.CompanyName = NullIfBlank(txtCompanyName.Text);
            c.EmailAddress = txtEmail.Text.Trim();
            c.Phone = mskPhone.Text;

            c.Address.AddressType = cboAddressType.Text;
            c.Address.AddressLine1 = txtAddressLine1.Text.Trim();
            c.Address.AddressLine2 = NullIfBlank(txtAddressLine2.Text);
            c.Address.City = txtCity.Text.Trim();
            c.Address.StateProvince = txtStateProvince.Text.Trim();
            c.Address.PostalCode = mskPostalCode.Text;
            c.Address.CountryRegion = cboCountryRegion.Text;
        }

        private static string? NullIfBlank(string text) =>
            string.IsNullOrWhiteSpace(text) ? null : text.Trim();

        private void SelectCustomerRow(Customer customer)
        {
            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                if (row.Tag == customer)
                {
                    row.Selected = true;
                    dgvCustomers.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void ClearForm()
        {
            ValidationHelper.ClearControls(grpCustomer.Controls);
            ValidationHelper.ClearControls(grpAddress.Controls);
            cboAddressType.SelectedIndex = 0;      // Main Office
            cboCountryRegion.SelectedIndex = 0;    // United States
            selectedCustomer = null;
            dgvCustomers.ClearSelection();
            txtFirstName.Focus();
        }
    }
}
