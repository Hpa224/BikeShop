namespace BikeShop.Forms
{
    partial class frmErrorDetails
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
            lblLogId = new Label();
            lblLine = new Label();
            lblErrorState = new Label();
            lblSeverity = new Label();
            lblErrorNumber = new Label();
            lblUserName = new Label();
            lblDateTime = new Label();
            lblErrorMessage = new Label();
            txtLogID = new TextBox();
            txtDateTime = new TextBox();
            txtUserName = new TextBox();
            txtErrorNumber = new TextBox();
            txtSeverity = new TextBox();
            txtErrorSTate = new TextBox();
            txtErrorLine = new TextBox();
            txtErrorMessage = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblLogId
            // 
            lblLogId.AutoSize = true;
            lblLogId.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogId.ForeColor = Color.FromArgb(65, 65, 65);
            lblLogId.Location = new Point(57, 12);
            lblLogId.Name = "lblLogId";
            lblLogId.Size = new Size(63, 23);
            lblLogId.TabIndex = 1;
            lblLogId.Text = "Log ID:";
            // 
            // lblLine
            // 
            lblLine.AutoSize = true;
            lblLine.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLine.ForeColor = Color.FromArgb(65, 65, 65);
            lblLine.Location = new Point(24, 183);
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(96, 23);
            lblLine.TabIndex = 2;
            lblLine.Text = "Error Line: ";
            // 
            // lblErrorState
            // 
            lblErrorState.AutoSize = true;
            lblErrorState.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorState.ForeColor = Color.FromArgb(65, 65, 65);
            lblErrorState.Location = new Point(17, 154);
            lblErrorState.Name = "lblErrorState";
            lblErrorState.Size = new Size(101, 23);
            lblErrorState.TabIndex = 3;
            lblErrorState.Text = "Error State:";
            // 
            // lblSeverity
            // 
            lblSeverity.AutoSize = true;
            lblSeverity.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeverity.ForeColor = Color.FromArgb(65, 65, 65);
            lblSeverity.Location = new Point(37, 125);
            lblSeverity.Name = "lblSeverity";
            lblSeverity.Size = new Size(81, 23);
            lblSeverity.TabIndex = 4;
            lblSeverity.Text = "Severity:";
            // 
            // lblErrorNumber
            // 
            lblErrorNumber.AutoSize = true;
            lblErrorNumber.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorNumber.ForeColor = Color.FromArgb(65, 65, 65);
            lblErrorNumber.Location = new Point(-4, 96);
            lblErrorNumber.Name = "lblErrorNumber";
            lblErrorNumber.Size = new Size(124, 23);
            lblErrorNumber.TabIndex = 5;
            lblErrorNumber.Text = "Error Number:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(65, 65, 65);
            lblUserName.Location = new Point(17, 68);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(103, 23);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "User Name:";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.FromArgb(65, 65, 65);
            lblDateTime.Location = new Point(12, 39);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(108, 23);
            lblDateTime.TabIndex = 7;
            lblDateTime.Text = "Date / Time:";
            lblDateTime.Click += lblDateTime_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorMessage.ForeColor = Color.FromArgb(65, 65, 65);
            lblErrorMessage.Location = new Point(8, 248);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(110, 19);
            lblErrorMessage.TabIndex = 8;
            lblErrorMessage.Text = "Error Message:";
            // 
            // txtLogID
            // 
            txtLogID.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogID.Location = new Point(124, 12);
            txtLogID.Name = "txtLogID";
            txtLogID.ReadOnly = true;
            txtLogID.Size = new Size(204, 22);
            txtLogID.TabIndex = 9;
            txtLogID.TextChanged += textBox1_TextChanged;
            // 
            // txtDateTime
            // 
            txtDateTime.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDateTime.Location = new Point(124, 40);
            txtDateTime.Name = "txtDateTime";
            txtDateTime.ReadOnly = true;
            txtDateTime.Size = new Size(204, 22);
            txtDateTime.TabIndex = 10;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(124, 68);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(204, 22);
            txtUserName.TabIndex = 11;
            // 
            // txtErrorNumber
            // 
            txtErrorNumber.Location = new Point(124, 96);
            txtErrorNumber.Name = "txtErrorNumber";
            txtErrorNumber.ReadOnly = true;
            txtErrorNumber.Size = new Size(204, 23);
            txtErrorNumber.TabIndex = 12;
            // 
            // txtSeverity
            // 
            txtSeverity.Location = new Point(124, 125);
            txtSeverity.Name = "txtSeverity";
            txtSeverity.ReadOnly = true;
            txtSeverity.Size = new Size(204, 23);
            txtSeverity.TabIndex = 13;
            // 
            // txtErrorSTate
            // 
            txtErrorSTate.Location = new Point(124, 154);
            txtErrorSTate.Name = "txtErrorSTate";
            txtErrorSTate.ReadOnly = true;
            txtErrorSTate.Size = new Size(204, 23);
            txtErrorSTate.TabIndex = 14;
            // 
            // txtErrorLine
            // 
            txtErrorLine.Location = new Point(124, 183);
            txtErrorLine.Name = "txtErrorLine";
            txtErrorLine.ReadOnly = true;
            txtErrorLine.Size = new Size(204, 23);
            txtErrorLine.TabIndex = 15;
            // 
            // txtErrorMessage
            // 
            txtErrorMessage.Location = new Point(12, 270);
            txtErrorMessage.Multiline = true;
            txtErrorMessage.Name = "txtErrorMessage";
            txtErrorMessage.ReadOnly = true;
            txtErrorMessage.Size = new Size(204, 168);
            txtErrorMessage.TabIndex = 16;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(233, 401);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 37);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmErrorDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 450);
            Controls.Add(btnExit);
            Controls.Add(txtErrorMessage);
            Controls.Add(txtErrorLine);
            Controls.Add(txtErrorSTate);
            Controls.Add(txtSeverity);
            Controls.Add(txtErrorNumber);
            Controls.Add(txtUserName);
            Controls.Add(txtDateTime);
            Controls.Add(txtLogID);
            Controls.Add(lblErrorMessage);
            Controls.Add(lblDateTime);
            Controls.Add(lblUserName);
            Controls.Add(lblErrorNumber);
            Controls.Add(lblSeverity);
            Controls.Add(lblErrorState);
            Controls.Add(lblLine);
            Controls.Add(lblLogId);
            Name = "frmErrorDetails";
            Text = "Error Details";
            Load += frmErrorDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogId;
        private Label lblLine;
        private Label lblErrorState;
        private Label lblSeverity;
        private Label lblErrorNumber;
        private Label lblUserName;
        private Label lblDateTime;
        private Label lblErrorMessage;
        private TextBox txtLogID;
        private TextBox txtDateTime;
        private TextBox txtUserName;
        private TextBox txtErrorNumber;
        private TextBox txtSeverity;
        private TextBox txtErrorSTate;
        private TextBox txtErrorLine;
        private TextBox txtErrorMessage;
        private Button btnExit;
    }
}