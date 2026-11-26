using BikeShop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BikeShop.Forms
{
    public partial class frmError : Form
    {
        private int? selectedErrorId = null;
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public frmError()
        {
            InitializeComponent();
            FormCaptionBackColor = Color.FromArgb(31, 78, 121);
            FormCaptionTextColor = Color.White;

            btnSearch.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 15, 15)
            );

            btnSearch2.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnSearch2.Width, btnSearch2.Height, 15, 15)
            );

            btnDetails.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnDetails.Width, btnDetails.Height, 15, 15)
            );

            btnRefresh.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnRefresh.Width, btnRefresh.Height, 15, 15)
            );

            btnBack.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnBack.Width, btnBack.Height, 15, 15)
            );
        }

        private void frmError_Load(object sender, EventArgs e)
        {
            cboSeverity.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvErrorLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(this, "Error selected.");
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Start date cannot be after the end date.",
                                "Invalid Date Range",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                dtpStartDate.Focus();
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show(this, "Please enter an error message or ID.");
                return;
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dgvErrorLogs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an error record.",
                                "No Error Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                dgvErrorLogs.Focus();
                return;
            }

            using var db = DatabaseHelper.CreateContext();
            var error = db.ErrorLogs.Find(selectedErrorId.Value);

            if (error != null)
            {
                using var form = new frmErrorDetails(error);
                form.ShowDialog(this);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Refresh button selected.");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvErrorLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) {
                return;
            }

            selectedErrorId = Convert.ToInt32(
            dgvErrorLogs.Rows[e.RowIndex].Cells["colErrorLogID"].Value);
        }
    }
}
