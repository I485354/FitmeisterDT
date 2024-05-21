namespace FitmeisterDT
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LogoBoxLogin = new PictureBox();
            emailLoginLbl = new Label();
            passLoginLbl = new Label();
            LoginEmailTxt = new TextBox();
            passLoginTxt = new TextBox();
            LoginBtn = new Button();
            CancelLoginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)LogoBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // LogoBoxLogin
            // 
            LogoBoxLogin.Image = (Image)resources.GetObject("LogoBoxLogin.Image");
            LogoBoxLogin.Location = new Point(298, 25);
            LogoBoxLogin.Name = "LogoBoxLogin";
            LogoBoxLogin.Size = new Size(200, 200);
            LogoBoxLogin.SizeMode = PictureBoxSizeMode.AutoSize;
            LogoBoxLogin.TabIndex = 0;
            LogoBoxLogin.TabStop = false;
            // 
            // emailLoginLbl
            // 
            emailLoginLbl.AutoSize = true;
            emailLoginLbl.Location = new Point(256, 275);
            emailLoginLbl.Name = "emailLoginLbl";
            emailLoginLbl.Size = new Size(46, 20);
            emailLoginLbl.TabIndex = 1;
            emailLoginLbl.Text = "Email";
            // 
            // passLoginLbl
            // 
            passLoginLbl.AutoSize = true;
            passLoginLbl.Location = new Point(259, 324);
            passLoginLbl.Name = "passLoginLbl";
            passLoginLbl.Size = new Size(70, 20);
            passLoginLbl.TabIndex = 2;
            passLoginLbl.Text = "Password";
            // 
            // LoginEmailTxt
            // 
            LoginEmailTxt.Location = new Point(348, 275);
            LoginEmailTxt.Name = "LoginEmailTxt";
            LoginEmailTxt.Size = new Size(125, 27);
            LoginEmailTxt.TabIndex = 3;
            LoginEmailTxt.Text = "admin@gmail.com";
            // 
            // passLoginTxt
            // 
            passLoginTxt.Location = new Point(348, 321);
            passLoginTxt.Name = "passLoginTxt";
            passLoginTxt.PasswordChar = '*';
            passLoginTxt.Size = new Size(125, 27);
            passLoginTxt.TabIndex = 4;
            passLoginTxt.Text = "1234";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(181, 196, 161);
            LoginBtn.Location = new Point(433, 378);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(106, 51);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // CancelLoginBtn
            // 
            CancelLoginBtn.BackColor = Color.FromArgb(181, 196, 161);
            CancelLoginBtn.Location = new Point(259, 378);
            CancelLoginBtn.Name = "CancelLoginBtn";
            CancelLoginBtn.Size = new Size(106, 51);
            CancelLoginBtn.TabIndex = 6;
            CancelLoginBtn.Text = "Cancel";
            CancelLoginBtn.UseVisualStyleBackColor = false;
            CancelLoginBtn.Click += CancelLoginBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 215, 148);
            ClientSize = new Size(800, 450);
            Controls.Add(CancelLoginBtn);
            Controls.Add(LoginBtn);
            Controls.Add(passLoginTxt);
            Controls.Add(LoginEmailTxt);
            Controls.Add(passLoginLbl);
            Controls.Add(emailLoginLbl);
            Controls.Add(LogoBoxLogin);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)LogoBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LogoBoxLogin;
        private Label emailLoginLbl;
        private Label passLoginLbl;
        private TextBox LoginEmailTxt;
        private TextBox passLoginTxt;
        private Button LoginBtn;
        private Button CancelLoginBtn;
    }
}
