using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// Add this file to your existing Windows Forms project; adjust namespace to match your project.
namespace BikeShop.Forms
    public class frmError : Form
    {
        // Supply a function that reads the real error-log table from your group's database.
        public Func<DataTable> LoadErrorLogs { get; set; }
        // Supply a function that deletes or resolves the selected log, if permitted.
        public Action<string> ClearErrorLog { get; set; }
        private readonly TextBox txtSearch = new TextBox { Name = "txtSearch", MaxLength = 100, Width = 220 };
        private readonly ComboBox cboSeverity = new ComboBox { Name = "cboSeverity", DropDownStyle = ComboBoxStyle.DropDownList, Width = 130 };
        private readonly DateTimePicker dtpStartDate = new DateTimePicker { Name = "dtpStartDate", Format = DateTimePickerFormat.Short };
        private readonly DateTimePicker dtpEndDate = new DateTimePicker { Name = "dtpEndDate", Format = DateTimePickerFormat.Short };
        private readonly DataGridView dgvErrorLogs = new DataGridView { Name = "dgvErrorLogs", ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, SelectionMode = DataGridViewSelectionMode.FullRowSelect, MultiSelect = false, Dock = DockStyle.Fill };
        private readonly Label lblDetails = new Label { Name = "lblDetails", AutoSize = true, Text = "Select an error to view details." };
        private DataTable allLogs;
        public frmError()
        {
            Text = "Bike Store Manager - Error"; Width = 1050; Height = 680; StartPosition = FormStartPosition.CenterScreen;
            cboSeverity.Items.AddRange(new object[] { "All Levels", "Error", "Warning", "Info" }); cboSeverity.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Today.AddMonths(-1); dtpEndDate.Value = DateTime.Today;
            var root = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 4, ColumnCount = 1, Padding = new Padding(16) };
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize)); root.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); root.RowStyles.Add(new RowStyle(SizeType.AutoSize)); root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            var filters = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, WrapContents = true };
            filters.Controls.AddRange(new Control[] { L("Search:"), txtSearch, L("Severity:"), cboSeverity, L("From:"), dtpStartDate, L("To:"), dtpEndDate, B("Search", (s,e)=>Filter()), B("Refresh", (s,e)=>RefreshLogs()) });
            var actions = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoSize = true };
            actions.Controls.AddRange(new Control[] { B("View Details", (s,e)=>ShowDetails()), B("Clear Selected", (s,e)=>ClearSelected()), B("Back", (s,e)=>Close()) });
            root.Controls.Add(filters, 0, 0); root.Controls.Add(dgvErrorLogs, 0, 1); root.Controls.Add(lblDetails, 0, 2); root.Controls.Add(actions, 0, 3);
            Controls.Add(root);
            dgvErrorLogs.SelectionChanged += (s,e)=>UpdateDetails();
            Shown += (s,e)=>RefreshLogs();
        }
        private static Label L(string text) => new Label { Text = text, AutoSize = true, Margin = new Padding(7, 8, 4, 0) };
        private static Button B(string text, EventHandler handler) { var b = new Button { Text = text, AutoSize = true, Margin = new Padding(6) }; b.Click += handler; return b; }
        private void RefreshLogs()
        {
            if (LoadErrorLogs == null) { MessageBox.Show("Connect LoadErrorLogs to the group's database before using this form."); return; }
            try { allLogs = LoadErrorLogs(); Filter(); }
            catch (Exception ex) { MessageBox.Show("Unable to load error logs: " + ex.Message); }
        }
        private void Filter()
        {
            if (allLogs == null) return;
            if (dtpStartDate.Value.Date > dtpEndDate.Value.Date) { MessageBox.Show("Start date must be on or before end date."); return; }
            // Required data columns: LogID, DateTime, Level, Source, Message; optional: Status.
            string[] required = { "LogID", "DateTime", "Level", "Source", "Message" };
            if (required.Any(c => !allLogs.Columns.Contains(c))) { MessageBox.Show("Error-log data is missing expected columns: " + string.Join(", ", required)); return; }
            var rows = allLogs.AsEnumerable().Where(r =>
            {
                DateTime date; if (!DateTime.TryParse(Convert.ToString(r["DateTime"]), out date)) return false;
                string query = txtSearch.Text.Trim();
                bool matches = query.Length == 0 || Convert.ToString(r["LogID"]).IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 || Convert.ToString(r["Message"]).IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0;
                return matches && (cboSeverity.Text == "All Levels" || string.Equals(Convert.ToString(r["Level"]), cboSeverity.Text, StringComparison.OrdinalIgnoreCase)) && date.Date >= dtpStartDate.Value.Date && date.Date <= dtpEndDate.Value.Date;
            });
            dgvErrorLogs.DataSource = rows.Any() ? rows.CopyToDataTable() : allLogs.Clone(); UpdateDetails();
        }
        private DataRow SelectedRow => dgvErrorLogs.CurrentRow == null ? null : (dgvErrorLogs.CurrentRow.DataBoundItem as DataRowView)?.Row;
        private void UpdateDetails()
        {
            var row = SelectedRow;
            lblDetails.Text = row == null ? "Select an error to view details." : "Log ID: " + row["LogID"] + "   Source: " + row["Source"] + "   Status: " + (row.Table.Columns.Contains("Status") ? row["Status"].ToString() : "N/A");
        }
        private void ShowDetails()
        {
            var row = SelectedRow; if (row == null) { MessageBox.Show("Select an error first."); return; }
            MessageBox.Show("Log ID: " + row["LogID"] + "\nDate: " + row["DateTime"] + "\nLevel: " + row["Level"] + "\nSource: " + row["Source"] + "\nMessage: " + row["Message"], "Error Details");
        }
        private void ClearSelected()
        {
            var row = SelectedRow; if (row == null) { MessageBox.Show("Select an error first."); return; }
            if (ClearErrorLog == null) { MessageBox.Show("Clear Selected is not configured. Ask your group whether logs should be deleted or marked resolved."); return; }
            if (MessageBox.Show("Clear selected log?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try { ClearErrorLog(Convert.ToString(row["LogID"])); RefreshLogs(); }
            catch (Exception ex) { MessageBox.Show("Could not clear log: " + ex.Message); }
        }
    }
}
