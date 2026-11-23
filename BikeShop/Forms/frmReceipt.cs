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

            foreach (Button button in new[] { btnPrint, btnSave, btnClose })
            {
                button.Region = System.Drawing.Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, button.Width, button.Height, 15, 15)
                );
            }

            colQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colUnitPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colUnitPrice.DefaultCellStyle.Format = "c";
            colLineTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colLineTotal.DefaultCellStyle.Format = "c";

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
            lblDueDate.Text = order.DueDate.ToShortDateString();
            lblCustomerID.Text = order.CustomerID.ToString();

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

        /// <summary>Plain-text version of the receipt used for printing and saving.</summary>
        private string BuildReceiptText()
        {
            var sb = new StringBuilder();
            sb.AppendLine("BIKE SHOP");
            sb.AppendLine("Sales Receipt / Invoice");
            sb.AppendLine(new string('=', 72));
            sb.AppendLine($"Order #:    {order.SalesOrderNumber}");
            sb.AppendLine($"Order Date: {order.OrderDate:d}");
            sb.AppendLine($"Due Date:   {order.DueDate:d}");
            sb.AppendLine();
            sb.AppendLine("Bill To:");
            sb.AppendLine($"  {lblCustomerName.Text}");
            foreach (string line in lblBillToAddress.Text.Split(Environment.NewLine))
            {
                if (line.Trim() != "") sb.AppendLine($"  {line}");
            }
            sb.AppendLine(new string('-', 72));
            sb.AppendLine($"{"Product #",-12}{"Product",-30}{"Qty",5}{"Unit Price",12}{"Line Total",13}");
            sb.AppendLine(new string('-', 72));
            foreach (SalesOrderDetail d in order.Details)
            {
                string name = d.ProductName.Length > 29 ? d.ProductName[..29] : d.ProductName;
                sb.AppendLine($"{d.ProductNumber,-12}{name,-30}{d.OrderQty,5}{d.UnitPrice,12:N2}{d.LineTotal,13:N2}");
            }
            sb.AppendLine(new string('-', 72));
            sb.AppendLine($"{"Subtotal:",59}{order.SubTotal,13:c}");
            sb.AppendLine($"{"Tax (7%):",59}{order.TaxAmt,13:c}");
            sb.AppendLine($"{"Total Due:",59}{order.TotalDue,13:c}");
            sb.AppendLine();
            sb.AppendLine("Thank you for shopping with us!");
            return sb.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "The receipt could not be printed.\n\n" + ex.Message, "Print Receipt",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            using var font = new Font("Consolas", 10F);
            e.Graphics!.DrawString(BuildReceiptText(), font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);
            e.HasMorePages = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = $"Receipt_{order.SalesOrderNumber}.txt";
            if (saveFileDialog.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                File.WriteAllText(saveFileDialog.FileName, BuildReceiptText());
                MessageBox.Show(this, $"Receipt saved to:\n{saveFileDialog.FileName}", "Save Receipt",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, "The receipt could not be saved.\n\n" + ex.Message, "Save Receipt",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(this, "You do not have permission to save in that folder.\n\n" + ex.Message,
                    "Save Receipt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
