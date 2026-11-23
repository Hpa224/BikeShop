namespace BikeShop.Forms
{
    partial class frmlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNamePassword = new Label();
            lblPassword = new Label();
            txtNamePassword = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblNamePassword
            // 
            lblNamePassword.AutoSize = true;
            lblNamePassword.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamePassword.Location = new Point(292, 65);
            lblNamePassword.Margin = new Padding(4, 0, 4, 0);
            lblNamePassword.Name = "lblNamePassword";
            lblNamePassword.Size = new Size(216, 23);
            lblNamePassword.TabIndex = 0;
            lblNamePassword.Text = "Email address / Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(357, 155);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 23);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            lblPassword.Click += lblPassword_Click;
            // 
            // txtNamePassword
            // 
            txtNamePassword.Location = new Point(261, 91);
            txtNamePassword.Margin = new Padding(4, 3, 4, 3);
            txtNamePassword.Name = "txtNamePassword";
            txtNamePassword.Size = new Size(278, 23);
            txtNamePassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(261, 181);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(278, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(46, 125, 60);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(467, 378);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 60);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(192, 0, 0);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(197, 378);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(145, 60);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtNamePassword);
            Controls.Add(lblPassword);
            Controls.Add(lblNamePassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmlogin";
            Text = "Log in Page";
            Load += frmlogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamePassword;
        private Label lblPassword;
        private TextBox txtNamePassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnBack;
    }
}