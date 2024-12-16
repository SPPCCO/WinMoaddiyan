namespace WinMoaddiyan
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblSignUp = new LinkLabel();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(15, 15);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(93, 14);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "پست الکترونیکی:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 12);
            txtEmail.Name = "txtEmail";
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.Size = new Size(225, 22);
            txtEmail.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(15, 48);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(26, 14);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "رمز:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(114, 44);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.Size = new Size(225, 22);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(183, 79);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ورود";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Location = new Point(15, 83);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(57, 14);
            lblSignUp.TabIndex = 5;
            lblSignUp.TabStop = true;
            lblSignUp.Text = "نام‌نویسی";
            lblSignUp.LinkClicked += lblSignUp_LinkClicked;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(264, 79);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "انصراف";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(351, 115);
            Controls.Add(btnCancel);
            Controls.Add(lblSignUp);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel lblSignUp;
        private Button btnCancel;
    }
}
