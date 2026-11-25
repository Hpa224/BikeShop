using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BikeShop.Forms
{
    public partial class frmMainMenu : Form
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
        public frmMainMenu()
        {
            InitializeComponent();
            FormCaptionBackColor = Color.FromArgb(31, 78, 121);
            FormCaptionTextColor = Color.White;

            btnExit.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnExit.Width, btnExit.Height, 15, 15)
            );
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using var form = new frmError();
            form.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using var form = new frmReport();
            form.ShowDialog(this);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            using var form = new frmProductMaintenance();
            form.ShowDialog(this);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            using var form = new frmCustomerMaintenance();
            form.ShowDialog(this);
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            using var form = new frmNewSale();
            form.ShowDialog(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
