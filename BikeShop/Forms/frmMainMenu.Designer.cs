namespace BikeShop.Forms
{
    partial class frmMainMenu
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
            btnInventory = new Button();
            btnCustomers = new Button();
            btnNewSale = new Button();
            btnError = new Button();
            btnReports = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(242, 242, 242);
            btnInventory.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.FromArgb(31, 78, 121);
            btnInventory.Location = new Point(12, 63);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(234, 115);
            btnInventory.TabIndex = 0;
            btnInventory.Text = "Inventory";
            btnInventory.TextAlign = ContentAlignment.TopCenter;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.FromArgb(242, 242, 242);
            btnCustomers.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.FromArgb(31, 78, 121);
            btnCustomers.Location = new Point(283, 63);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(234, 115);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.TopCenter;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnNewSale
            // 
            btnNewSale.BackColor = Color.FromArgb(242, 242, 242);
            btnNewSale.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewSale.ForeColor = Color.FromArgb(31, 78, 121);
            btnNewSale.Location = new Point(554, 63);
            btnNewSale.Name = "btnNewSale";
            btnNewSale.Size = new Size(234, 115);
            btnNewSale.TabIndex = 2;
            btnNewSale.Text = "New Sale";
            btnNewSale.TextAlign = ContentAlignment.TopCenter;
            btnNewSale.UseVisualStyleBackColor = false;
            btnNewSale.Click += btnNewSale_Click;
            // 
            // btnError
            // 
            btnError.BackColor = Color.FromArgb(242, 242, 242);
            btnError.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnError.ForeColor = Color.FromArgb(31, 78, 121);
            btnError.Location = new Point(154, 210);
            btnError.Name = "btnError";
            btnError.Size = new Size(234, 115);
            btnError.TabIndex = 3;
            btnError.Text = "Error";
            btnError.TextAlign = ContentAlignment.TopCenter;
            btnError.UseVisualStyleBackColor = false;
            btnError.Click += button4_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(242, 242, 242);
            btnReports.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.FromArgb(31, 78, 121);
            btnReports.Location = new Point(420, 210);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(234, 115);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.TopCenter;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += button5_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(127, 127, 127);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(643, 393);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 45);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnReports);
            Controls.Add(btnError);
            Controls.Add(btnNewSale);
            Controls.Add(btnCustomers);
            Controls.Add(btnInventory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            Load += frmMainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnInventory;
        private Button btnCustomers;
        private Button btnNewSale;
        private Button btnError;
        private Button btnReports;
        private Button btnExit;
    }
}