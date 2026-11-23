namespace BikeShop.Forms
{
    partial class frmLogin
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
            lblNameEmail = new Label();
            lblPassword = new Label();
            txtNameEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblNameEmail
            // 
            lblNameEmail.AutoSize = true;
            lblNameEmail.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameEmail.Location = new Point(292, 67);
            lblNameEmail.Name = "lblNameEmail";
            lblNameEmail.Size = new Size(216, 23);
            lblNameEmail.TabIndex = 0;
            lblNameEmail.Text = "Email address / Username";
            lblNameEmail.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(357, 145);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 23);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtNameEmail
            // 
            txtNameEmail.Location = new Point(269, 95);
            txtNameEmail.Name = "txtNameEmail";
            txtNameEmail.Size = new Size(263, 23);
            txtNameEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(269, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(263, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(45, 125, 50);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(453, 391);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
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
            btnBack.Location = new Point(191, 391);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(145, 45);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtNameEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblNameEmail);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmLogin";
            Text = "Log in page";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameEmail;
        private Label lblPassword;
        private TextBox txtNameEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnBack;
    }
}