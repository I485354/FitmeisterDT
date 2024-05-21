namespace FitmeisterDT
{
    partial class CreateAccount
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
            fNameBox = new TextBox();
            lNameBox = new TextBox();
            emailBox = new TextBox();
            passwordBox = new TextBox();
            telBox = new TextBox();
            birthdate = new DateTimePicker();
            genderBox = new ComboBox();
            heightBox = new TextBox();
            weightBox = new TextBox();
            lbl1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            CreateBtn = new Button();
            SuspendLayout();
            // 
            // fNameBox
            // 
            fNameBox.Location = new Point(364, 53);
            fNameBox.Name = "fNameBox";
            fNameBox.Size = new Size(125, 27);
            fNameBox.TabIndex = 0;
            // 
            // lNameBox
            // 
            lNameBox.Location = new Point(364, 86);
            lNameBox.Name = "lNameBox";
            lNameBox.Size = new Size(125, 27);
            lNameBox.TabIndex = 1;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(364, 146);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(125, 27);
            emailBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(364, 179);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(125, 27);
            passwordBox.TabIndex = 3;
            // 
            // telBox
            // 
            telBox.Location = new Point(364, 212);
            telBox.Name = "telBox";
            telBox.Size = new Size(125, 27);
            telBox.TabIndex = 4;
            // 
            // birthdate
            // 
            birthdate.Location = new Point(364, 113);
            birthdate.Name = "birthdate";
            birthdate.Size = new Size(250, 27);
            birthdate.TabIndex = 5;
            // 
            // genderBox
            // 
            genderBox.FormattingEnabled = true;
            genderBox.Location = new Point(364, 245);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(151, 28);
            genderBox.TabIndex = 6;
            genderBox.Text = "Select gender";
            // 
            // heightBox
            // 
            heightBox.Location = new Point(364, 279);
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(125, 27);
            heightBox.TabIndex = 7;
            // 
            // weightBox
            // 
            weightBox.Location = new Point(364, 312);
            weightBox.Name = "weightBox";
            weightBox.Size = new Size(125, 27);
            weightBox.TabIndex = 8;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(214, 60);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(73, 20);
            lbl1.TabIndex = 9;
            lbl1.Text = "Firstname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 89);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 10;
            label1.Text = "Lastname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 118);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 11;
            label2.Text = "Birth date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 149);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 179);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 13;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(214, 212);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 14;
            label5.Text = "Tel. Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(214, 245);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 15;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(217, 279);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 16;
            label7.Text = "Height";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(217, 312);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 17;
            label8.Text = "Weight";
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(395, 364);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(94, 29);
            CreateBtn.TabIndex = 18;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 215, 148);
            ClientSize = new Size(800, 450);
            Controls.Add(CreateBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl1);
            Controls.Add(weightBox);
            Controls.Add(heightBox);
            Controls.Add(genderBox);
            Controls.Add(birthdate);
            Controls.Add(telBox);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Controls.Add(lNameBox);
            Controls.Add(fNameBox);
            Name = "CreateAccount";
            Text = "CreateAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fNameBox;
        private TextBox lNameBox;
        private TextBox emailBox;
        private TextBox passwordBox;
        private TextBox telBox;
        private DateTimePicker birthdate;
        private ComboBox genderBox;
        private TextBox heightBox;
        private TextBox weightBox;
        private Label lbl1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button CreateBtn;
    }
}