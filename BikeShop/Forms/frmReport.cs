using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

            btnPrintReport.Region = System.Drawing.Region.FromHrgn(
                 CreateRoundRectRgn(0, 0, btnPrintReport.Width, btnPrintReport.Height, 15, 15)
             );
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

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
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print selected.");
        }
    }
}
