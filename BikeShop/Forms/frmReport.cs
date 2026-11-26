using BikeShop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace BikeShop.Forms
{
    public partial class frmReport : Form
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
        public frmReport()
        {
            InitializeComponent();
            FormCaptionBackColor = Color.FromArgb(31, 78, 121);
            FormCaptionTextColor = Color.White;

            btnGenerate.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnGenerate.Width, btnGenerate.Height, 15, 15)
            );

            btnBack.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnBack.Width, btnBack.Height, 15, 15)
            );

            btnExportCSV.Region = System.Drawing.Region.FromHrgn(
                 CreateRoundRectRgn(0, 0, btnExportCSV.Width, btnExportCSV.Height, 15, 15)
             );
        }

        private void LoadSales(DateTime startDate, DateTime endDate)
        {
            using var db = DatabaseHelper.CreateContext();
            var sales = db.SalesOrderDetails
                .Where(s => s.SalesOrder.OrderDate >= startDate && 
                    s.SalesOrder.OrderDate < endDate    )
                .Select(s => new
                {
                    s.SalesOrder.SalesOrderNumber,
                    s.SalesOrder.OrderDate,
                    s.Product.ProductNumber,
                    s.Product.Name,
                    s.OrderQty,
                    s.LineTotal
                })
                .OrderBy(s => s.OrderDate)
                .ToList();

            dgvSalesReport.AutoGenerateColumns = false;
            dgvSalesReport.DataSource = sales;
            lblOrdersAmount.Text = sales.Select(s => s.SalesOrderNumber).Distinct().Count().ToString();
            lblTotalSalesAmount.Text = sales.Sum(s => s.LineTotal).ToString("C2");
            lblItemsSoldAmount.Text = sales.Sum(s => s.OrderQty).ToString();
            dgvSalesReport.ClearSelection();
            dgvSalesReport.CurrentCell = null;
        }

        private string EscapeCSV(string value)
        {
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            dtpEndDate.Value = DateTime.Today;
            LoadSales(new DateTime(2000, 1, 1), DateTime.Today.AddDays(1));
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be after the end date.",
                                "Invalid Date Range",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                dtpStartDate.Focus();
                return;
            }

            LoadSales(startDate, endDate.AddDays(1));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (dgvSalesReport.Rows.Count == 0)
            {
                MessageBox.Show("Please generate a report before exporting.",
                                "No Report Available",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return;
            }

            using var dialog = new SaveFileDialog();
            dialog.Filter = "CSV Files (*.csv)|*.csv";
            dialog.FileName = "SalesReport.csv";

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            StringBuilder csv = new StringBuilder();

            foreach (DataGridViewColumn column in dgvSalesReport.Columns)
            {
                csv.Append(EscapeCSV(column.HeaderText));
                csv.Append(",");
            }

            csv.Length--;
            csv.AppendLine();

            foreach (DataGridViewRow row in dgvSalesReport.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                foreach (DataGridViewCell cell in row.Cells)
                {
                    csv.Append(EscapeCSV(cell.Value?.ToString() ?? ""));
                    csv.Append(",");
                }

                csv.Length--;
                csv.AppendLine();
            }

            File.WriteAllText(dialog.FileName, csv.ToString());
            MessageBox.Show("Report exported.");
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print selected.");
        }

        private void dgvSalesReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
