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
    public partial class frmlogin : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public frmlogin()
        {
            InitializeComponent();
            FormCaptionBackColor = Color.FromArgb(31, 78, 121);
            FormCaptionTextColor = Color.White;

            btnLogin.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 15, 15)
            );

            btnBack.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnBack.Width, btnBack.Height, 15, 15)
            );
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show(this, "Please enter your username.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(this, "Please enter your password.");
                return;
            }

            using var db = DatabaseHelper.CreateContext();
            var user = db.Users.FirstOrDefault(u => u.Username == username);

            if (user == null || !PasswordHelper.VerifyPassword(
                password, user.PasswordHash, user.PasswordSalt))
            {
                MessageBox.Show(this, "Invalid username or password.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
