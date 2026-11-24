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

            btnFind.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnFind.Width, btnFind.Height, 15, 15)
            );

            btnAdd.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 15, 15)
            );

            btnSave.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 15, 15)
            );

            btnDelete.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnDelete.Width, btnDelete.Height, 15, 15)
            );

            btnClear.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 15, 15)
            );

            btnPurchaseHistory.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnPurchaseHistory.Width, btnPurchaseHistory.Height, 15, 15)
            );

            btnBack.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnBack.Width, btnBack.Height, 15, 15)
            );
        }

        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
            ValidationHelper.Title = "Customer Entry Error";
            LoadCustomerGrid(SampleData.Customers);
            ClearScreen();
        }

        // ---------------- Grid ----------------

        private void LoadCustomerGrid(IEnumerable<Customer> customers)
        {
            loadingGrid = true;
            dgvCustomers.Rows.Clear();
            foreach (Customer c in customers.OrderBy(c => c.LastName).ThenBy(c => c.FirstName))
            {
                int purchases = SampleData.Orders.Count(o => o.CustomerID == c.CustomerID);
                int row = dgvCustomers.Rows.Add(c.CustomerID, c.FullName, c.Phone ?? "", c.EmailAddress ?? "", purchases);
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
            txtFirstName.Text = c.FirstName;
            txtLastName.Text = c.LastName;
            mskPhone.Text = c.Phone;
            txtMiddleName.Text = c.MiddleName;
            cboTitle.SelectedIndex = cboTitle.FindStringExact(c.Title ?? "");
            txtSuffix.Text = c.Suffix;
            txtEmail.Text = c.EmailAddress;
            txtCompanyName.Text = c.CompanyName;

            cboAddressType.SelectedIndex = cboAddressType.FindStringExact(c.Address.AddressType);
            txtAddressLine1.Text = c.Address.AddressLine1;
            txtAddressLine2.Text = c.Address.AddressLine2;
            cboCountryRegion.SelectedIndex = cboCountryRegion.FindStringExact(c.Address.CountryRegion);
            txtCity.Text = c.Address.City;
            txtStateProvince.Text = c.Address.StateProvince;
            mskPostalCode.Text = c.Address.PostalCode;
        }

        // ---------------- Buttons ----------------

        /// <summary>
        /// Finds customers that match whatever is typed in First Name, Last Name,
        /// Phone or Email (partial matches).
        /// </summary>
        private void btnFind_Click(object sender, EventArgs e)
        {
            string first = txtFirstName.Text.Trim();
            string last = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = mskPhone.MaskCompleted ? mskPhone.Text : "";

            if (first == "" && last == "" && email == "" && phone == "")
            {
                // Nothing to search on: show everyone
                LoadCustomerGrid(SampleData.Customers);
                MessageBox.Show(this, "Type part of a first name, last name, email or a full phone number, then click Find.",
                    "Find Customer");
                txtFirstName.Focus();
                return;
            }

            var matches = SampleData.Customers.Where(c =>
                    (first == "" || c.FirstName.Contains(first, StringComparison.OrdinalIgnoreCase)) &&
                    (last == "" || c.LastName.Contains(last, StringComparison.OrdinalIgnoreCase)) &&
                    (email == "" || (c.EmailAddress ?? "").Contains(email, StringComparison.OrdinalIgnoreCase)) &&
                    (phone == "" || c.Phone == phone))
                .ToList();

            if (matches.Count == 0)
            {
                MessageBox.Show(this, "No customers match what you entered.", "Find Customer");
                txtFirstName.Focus();
                return;
            }

            LoadCustomerGrid(matches);
            dgvCustomers.Rows[0].Selected = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidData()) return;

            var customer = new Customer { CustomerID = SampleData.GetNextCustomerID() };
            customer.Address.AddressID = customer.CustomerID;
            PutCustomerData(customer);
            SampleData.Customers.Add(customer);

            MessageBox.Show(this, $"Customer {customer.FullName} was added (ID {customer.CustomerID}).", "Customer Added");
            LoadCustomerGrid(SampleData.Customers);
            SelectCustomerRow(customer);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show(this, "Select a customer in the list before saving changes.\n" +
                    "To create a new customer, fill in the fields and click Add.", "Save Customer");
                return;
            }
            if (!IsValidData()) return;

            PutCustomerData(selectedCustomer);
            MessageBox.Show(this, $"Changes to {selectedCustomer.FullName} were saved.", "Customer Saved");

            Customer saved = selectedCustomer;
            LoadCustomerGrid(SampleData.Customers);
            SelectCustomerRow(saved);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show(this, "Select a customer in the list to delete.", "Delete Customer");
                return;
            }

            if (SampleData.Orders.Any(o => o.CustomerID == selectedCustomer.CustomerID))
            {
                MessageBox.Show(this, $"{selectedCustomer.FullName} has purchases and cannot be deleted.", "Delete Customer");
                return;
            }

            DialogResult answer = MessageBox.Show(this, $"Delete customer {selectedCustomer.FullName}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (answer != DialogResult.Yes) return;

            SampleData.Customers.Remove(selectedCustomer);
            LoadCustomerGrid(SampleData.Customers);
            ClearScreen();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadCustomerGrid(SampleData.Customers);
            ClearScreen();
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show(this, "Select a customer to view purchase history.", "Purchase History");
                return;
            }

            var orders = SampleData.Orders.Where(o => o.CustomerID == selectedCustomer.CustomerID)
                                          .OrderByDescending(o => o.OrderDate).ToList();
            if (orders.Count == 0)
            {
                MessageBox.Show(this, $"{selectedCustomer.FullName} has no purchases yet.", "Purchase History");
                return;
            }

            var sb = new StringBuilder();
            foreach (SalesOrder o in orders)
            {
                sb.AppendLine($"{o.SalesOrderNumber}   {o.OrderDate:d}   {o.ItemCount} item(s)   {o.TotalDue:c}");
            }
            sb.AppendLine();
            sb.AppendLine($"Total purchases: {orders.Sum(o => o.TotalDue):c}");
            MessageBox.Show(this, sb.ToString(), $"Purchase History - {selectedCustomer.FullName}");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ---------------- Validation ----------------

        private bool IsValidData()
        {
            return
                ValidationHelper.IsPresent(txtFirstName, "First Name") &&
                ValidationHelper.IsPresent(txtLastName, "Last Name") &&
                ValidationHelper.IsValidPhone(mskPhone, "Phone") &&
                ValidationHelper.IsPresent(txtEmail, "Email") &&
                ValidationHelper.IsValidEmail(txtEmail, "Email") &&
                IsUniqueEmail() &&
                ValidationHelper.IsSelected(cboAddressType, "Address Type") &&
                ValidationHelper.IsPresent(txtAddressLine1, "Address") &&
                ValidationHelper.IsSelected(cboCountryRegion, "Country") &&
                ValidationHelper.IsPresent(txtCity, "City") &&
                ValidationHelper.IsPresent(txtStateProvince, "State") &&
                ValidationHelper.IsMaskCompleted(mskPostalCode, "Zip Code");
        }

        private bool IsUniqueEmail()
        {
            string email = txtEmail.Text.Trim();
            bool taken = SampleData.Customers.Any(c => c != selectedCustomer &&
                string.Equals(c.EmailAddress, email, StringComparison.OrdinalIgnoreCase));
            if (taken)
            {
                MessageBox.Show(this, "Another customer already uses this email address.", ValidationHelper.Title);
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        // ---------------- Helpers ----------------

        private void PutCustomerData(Customer c)
        {
            c.FirstName = txtFirstName.Text.Trim();
            c.LastName = txtLastName.Text.Trim();
            c.Phone = mskPhone.Text;
            c.MiddleName = NullIfBlank(txtMiddleName.Text);
            c.Title = cboTitle.SelectedIndex == -1 ? null : cboTitle.Text;
            c.Suffix = NullIfBlank(txtSuffix.Text);
            c.EmailAddress = txtEmail.Text.Trim();
            c.CompanyName = NullIfBlank(txtCompanyName.Text);

            c.Address.AddressType = cboAddressType.Text;
            c.Address.AddressLine1 = txtAddressLine1.Text.Trim();
            c.Address.AddressLine2 = NullIfBlank(txtAddressLine2.Text);
            c.Address.CountryRegion = cboCountryRegion.Text;
            c.Address.City = txtCity.Text.Trim();
            c.Address.StateProvince = txtStateProvince.Text.Trim();
            c.Address.PostalCode = mskPostalCode.Text;
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

        private void ClearScreen()
        {
            ValidationHelper.ClearControls(Controls);
            cboAddressType.SelectedIndex = 0;      // Main Office
            cboCountryRegion.SelectedIndex = 0;    // United States
            selectedCustomer = null;
            dgvCustomers.ClearSelection();
            txtFirstName.Focus();
        }
    }
}
