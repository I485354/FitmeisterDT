namespace FitmeisterDT
{
    partial class EditUser
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
            editName = new TextBox();
            editEmail = new TextBox();
            editHeight = new TextBox();
            editWeight = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            UpdateBtn = new Button();
            CancelUpdateBtn = new Button();
            label5 = new Label();
            label9 = new Label();
            telEditBox = new TextBox();
            passwordEditBox = new TextBox();
            label6 = new Label();
            ConfirmPassword = new TextBox();
            roleCb = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // editName
            // 
            editName.Location = new Point(497, 47);
            editName.Name = "editName";
            editName.Size = new Size(125, 27);
            editName.TabIndex = 0;
            // 
            // editEmail
            // 
            editEmail.Location = new Point(497, 77);
            editEmail.Name = "editEmail";
            editEmail.Size = new Size(125, 27);
            editEmail.TabIndex = 1;
            // 
            // editHeight
            // 
            editHeight.Location = new Point(497, 110);
            editHeight.Name = "editHeight";
            editHeight.Size = new Size(125, 27);
            editHeight.TabIndex = 2;
            // 
            // editWeight
            // 
            editWeight.Location = new Point(497, 140);
            editWeight.Name = "editWeight";
            editWeight.Size = new Size(125, 27);
            editWeight.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 50);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 77);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 110);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 6;
            label3.Text = "Height";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 143);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 7;
            label4.Text = "Weight";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(551, 323);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(94, 29);
            UpdateBtn.TabIndex = 8;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // CancelUpdateBtn
            // 
            CancelUpdateBtn.Location = new Point(312, 323);
            CancelUpdateBtn.Name = "CancelUpdateBtn";
            CancelUpdateBtn.Size = new Size(94, 29);
            CancelUpdateBtn.TabIndex = 9;
            CancelUpdateBtn.Text = "Cancel";
            CancelUpdateBtn.UseVisualStyleBackColor = true;
            CancelUpdateBtn.Click += CancelUpdateBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 174);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 32;
            label5.Text = "Tel. Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(347, 208);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 31;
            label9.Text = "Password";
            // 
            // telEditBox
            // 
            telEditBox.Location = new Point(497, 174);
            telEditBox.Name = "telEditBox";
            telEditBox.Size = new Size(125, 27);
            telEditBox.TabIndex = 22;
            // 
            // passwordEditBox
            // 
            passwordEditBox.Location = new Point(497, 208);
            passwordEditBox.Name = "passwordEditBox";
            passwordEditBox.Size = new Size(125, 27);
            passwordEditBox.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(347, 243);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 33;
            label6.Text = "Confirm Password";
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.Location = new Point(497, 240);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.Size = new Size(125, 27);
            ConfirmPassword.TabIndex = 34;
            // 
            // roleCb
            // 
            roleCb.FormattingEnabled = true;
            roleCb.Location = new Point(497, 273);
            roleCb.Name = "roleCb";
            roleCb.Size = new Size(151, 28);
            roleCb.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 276);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 36;
            label7.Text = "Role";
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 215, 148);
            ClientSize = new Size(878, 459);
            Controls.Add(label7);
            Controls.Add(roleCb);
            Controls.Add(ConfirmPassword);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(telEditBox);
            Controls.Add(passwordEditBox);
            Controls.Add(CancelUpdateBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(editWeight);
            Controls.Add(editHeight);
            Controls.Add(editEmail);
            Controls.Add(editName);
            Name = "EditUser";
            Text = "EditUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox editName;
        private TextBox editEmail;
        private TextBox editHeight;
        private TextBox editWeight;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button UpdateBtn;
        private Button CancelUpdateBtn;
        private Label label5;
        private Label label9;
        private TextBox telEditBox;
        private TextBox passwordEditBox;
        private Label label6;
        private TextBox ConfirmPassword;
        private ComboBox roleCb;
        private Label label7;
    }
}