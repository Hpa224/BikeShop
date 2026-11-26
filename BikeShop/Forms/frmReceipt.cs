using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using BikeShop.Helpers;
using BikeShop.Models;

namespace BikeShop.Forms
{
    /// <summary>
    /// Receipt / invoice for a completed sale: order #, date, customer, itemized
    /// products, subtotal, tax and total. Can be printed or saved to a text file.
    /// </summary>
    public partial class frmReceipt : Form
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

        private readonly SalesOrder order;

        /// <summary>Opens the receipt with a sample order (for testing the form on its own).</summary>
        public frmReceipt() : this(SampleData.CreateSampleOrder())
        {
        }

        public frmReceipt(SalesOrder order)
        {
            InitializeComponent();
            FormCaptionBackColor = Color.FromArgb(31, 78, 121);
            FormCaptionTextColor = Color.White;

            btnClose.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnClose.Width, btnClose.Height, 15, 15)
            );

            this.order = order;
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            Text = $"Sales Receipt – {order.SalesOrderNumber}";

            Customer? c = order.Customer;
            lblCustomerName.Text = c?.FullName ?? "(no customer)";
            var bill = new StringBuilder();
            if (c != null && !string.IsNullOrWhiteSpace(c.CompanyName)) bill.AppendLine(c.CompanyName);
            if (c != null) bill.Append(c.Address.ToString());
            lblBillToAddress.Text = bill.ToString();

            lblOrderNumber.Text = order.SalesOrderNumber;
            lblOrderDate.Text = order.OrderDate.ToShortDateString();

            dgvOrderLines.Rows.Clear();
            foreach (SalesOrderDetail d in order.Details)
            {
                dgvOrderLines.Rows.Add(d.ProductNumber, d.ProductName, d.OrderQty, d.UnitPrice, d.LineTotal);
            }
            dgvOrderLines.ClearSelection();

            lblSubtotalValue.Text = order.SubTotal.ToString("c");
            lblTaxValue.Text = order.TaxAmt.ToString("c");
            lblTotalValue.Text = order.TotalDue.ToString("c");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
