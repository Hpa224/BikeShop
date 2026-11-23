using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace BikeShop.Forms
{
    public class frmReports : Form
    {
        // Hook these up to queries against your group's real tables.
        // Sales rows expected: SaleID, Date, Customer, Items, Total.
        // Inventory rows can use any columns; the grid/CSV will show them as provided.
        public Func<DateTime, DateTime, DataTable> LoadSalesReport { get; set; }
        public Func<DataTable> LoadInventoryReport { get; set; }
        private readonly ComboBox cboReportType = new ComboBox { Name = "cboReportType", DropDownStyle = ComboBoxStyle.DropDownList, Width = 160 };
        private readonly DateTimePicker dtpStartDate = new DateTimePicker { Name = "dtpStartDate", Format = DateTimePickerFormat.Short };
        private readonly DateTimePicker dtpEndDate = new DateTimePicker { Name = "dtpEndDate", Format = DateTimePickerFormat.Short };
        private readonly DataGridView dgvReport = new DataGridView { Name = "dgvReport", Dock = DockStyle.Fill, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, AllowUserToAddRows = false };
        private readonly Label lblTotalSales = new Label { AutoSize = true, Text = "Total Sales: -" };
        private readonly Label lblOrders = new Label { AutoSize = true, Text = "Orders: -" };
        private readonly Label lblItems = new Label { AutoSize = true, Text = "Items Sold: -" };
        private DataTable currentReport;
        private readonly PrintDocument printDocument = new PrintDocument();
        private int printRow;
        public frmReports()
        {
            Text = "Bike Store Manager - Reports"; Width = 1050; Height = 680; StartPosition = FormStartPosition.CenterScreen;
            cboReportType.Items.AddRange(new object[] { "Sales Summary", "Inventory" }); cboReportType.SelectedIndex = 0;
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); dtpEndDate.Value = DateTime.Today;
            var root = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 4, ColumnCount = 1, Padding = new Padding(16) };
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize)); root.RowStyles.Add(new RowStyle(SizeType.AutoSize)); root.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            var filters = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoSize = true };
            filters.Controls.AddRange(new Control[] { L("Report Type:"), cboReportType, L("From:"), dtpStartDate, L("To:"), dtpEndDate, B("Generate", (s,e)=>Generate()) });
            var totals = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoSize = true };
            totals.Controls.AddRange(new Control[] { lblTotalSales, lblOrders, lblItems });
            foreach (Control c in totals.Controls) c.Margin = new Padding(10);
            var actions = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoSize = true };
            actions.Controls.AddRange(new Control[] { B("Export CSV", (s,e)=>ExportCsv()), B("Print Report", (s,e)=>PrintReport()), B("Back", (s,e)=>Close()) });
            root.Controls.Add(filters, 0, 0); root.Controls.Add(totals, 0, 1); root.Controls.Add(dgvReport, 0, 2); root.Controls.Add(actions, 0, 3); Controls.Add(root);
            cboReportType.SelectedIndexChanged += (s,e)=> { bool sales = cboReportType.SelectedIndex == 0; dtpStartDate.Enabled = sales; dtpEndDate.Enabled = sales; };
            printDocument.PrintPage += PrintPage;
        }
        private static Label L(string text) => new Label { Text = text, AutoSize = true, Margin = new Padding(7, 8, 4, 0) };
        private static Button B(string text, EventHandler handler) { var b = new Button { Text = text, AutoSize = true, Margin = new Padding(6) }; b.Click += handler; return b; }
        private void Generate()
        {
            if (dtpStartDate.Value.Date > dtpEndDate.Value.Date) { MessageBox.Show("Start date must be on or before end date."); return; }
            try
            {
                bool sales = cboReportType.SelectedIndex == 0;
                if (sales && LoadSalesReport == null || !sales && LoadInventoryReport == null) { MessageBox.Show("Connect the report loader to your group's database first."); return; }
                currentReport = sales ? LoadSalesReport(dtpStartDate.Value.Date, dtpEndDate.Value.Date) : LoadInventoryReport();
                dgvReport.DataSource = currentReport;
                if (sales)
                {
                    string[] required = { "SaleID", "Date", "Customer", "Items", "Total" };
                    if (required.Any(c => !currentReport.Columns.Contains(c))) { MessageBox.Show("Sales report is missing expected columns: " + string.Join(", ", required)); return; }
                    decimal total = 0; int items = 0;
                    foreach (DataRow row in currentReport.Rows) { total += Convert.ToDecimal(row["Total"]); items += Convert.ToInt32(row["Items"]); }
                    lblTotalSales.Text = "Total Sales: " + total.ToString("C"); lblOrders.Text = "Orders: " + currentReport.Rows.Count; lblItems.Text = "Items Sold: " + items;
                }
                else { lblTotalSales.Text = "Inventory Report"; lblOrders.Text = "Records: " + currentReport.Rows.Count; lblItems.Text = ""; }
            }
            catch (Exception ex) { MessageBox.Show("Could not generate report: " + ex.Message); }
        }
        private static string Csv(string value) => "\"" + (value ?? "").Replace("\"", "\"\"") + "\"";
        private void ExportCsv()
        {
            if (currentReport == null) { MessageBox.Show("Generate a report first."); return; }
            using (var dialog = new SaveFileDialog { Filter = "CSV files (*.csv)|*.csv", FileName = "BikeStoreReport.csv" })
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                try
                {
                    using (var writer = new StreamWriter(dialog.FileName, false, new UTF8Encoding(true)))
                    {
                        writer.WriteLine(string.Join(",", currentReport.Columns.Cast<DataColumn>().Select(c=>Csv(c.ColumnName))));
                        foreach (DataRow row in currentReport.Rows) writer.WriteLine(string.Join(",", row.ItemArray.Select(v=>Csv(Convert.ToString(v)))));
                    }
                    MessageBox.Show("Report exported successfully.");
                }
                catch (Exception ex) { MessageBox.Show("Export failed: " + ex.Message); }
            }
        }
        private void PrintReport()
        {
            if (currentReport == null) { MessageBox.Show("Generate a report first."); return; }
            using (var dialog = new PrintPreviewDialog { Document = printDocument, Width = 950, Height = 700 })
            { printRow = 0; dialog.ShowDialog(this); }
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            using (var font = new Font("Arial", 9))
            {
                int y = e.MarginBounds.Top;
                e.Graphics.DrawString("Bike Store - " + cboReportType.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, y); y += 36;
                if (printRow == 0) { e.Graphics.DrawString(string.Join(" | ", currentReport.Columns.Cast<DataColumn>().Select(c=>c.ColumnName)), font, Brushes.Black, e.MarginBounds.Left, y); y += 25; }
                while (printRow < currentReport.Rows.Count && y < e.MarginBounds.Bottom - 25)
                {
                    string line = string.Join(" | ", currentReport.Rows[printRow].ItemArray.Select(v=>Convert.ToString(v)));
                    e.Graphics.DrawString(line, font, Brushes.Black, new RectangleF(e.MarginBounds.Left, y, e.MarginBounds.Width, 30));
                    y += 30; printRow++;
                }
                e.HasMorePages = printRow < currentReport.Rows.Count;
            }
        }
    }
}
