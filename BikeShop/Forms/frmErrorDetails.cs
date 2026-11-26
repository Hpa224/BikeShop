using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BikeShop.Entities;

namespace BikeShop.Forms
{
    public partial class frmErrorDetails : Form
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
        public frmErrorDetails(ErrorLog error)
        {
            InitializeComponent();
            txtLogID.Text = error.ErrorLogId.ToString();
            txtDateTime.Text = error.ErrorTime.ToString("MM/dd/yyyy HH:mm:ss");
            txtUserName.Text = error.UserName;
            txtErrorNumber.Text = error.ErrorNumber.ToString();
            txtSeverity.Text = error.ErrorSeverity?.ToString() ?? "";
            txtErrorState.Text = error.ErrorState?.ToString() ?? "";
            txtErrorProcedure.Text = error.ErrorProcedure ?? "";
            txtErrorLine.Text = error.ErrorLine?.ToString() ?? "";
            txtErrorMessage.Text = error.ErrorMessage;
            FormCaptionBackColor = Color.FromArgb(31, 78, 121);
            FormCaptionTextColor = Color.White;

            btnExit.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnExit.Width, btnExit.Height, 15, 15)
            );


        }

        private void frmErrorDetails_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
