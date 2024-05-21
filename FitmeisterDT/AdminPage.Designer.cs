namespace FitmeisterDT
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            logoPicture = new PictureBox();
            adminPanel = new Panel();
            UserInfoBtn = new Button();
            foodPageBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)logoPicture).BeginInit();
            adminPanel.SuspendLayout();
            SuspendLayout();
            // 
            // logoPicture
            // 
            logoPicture.BackColor = Color.FromArgb(41, 76, 37);
            logoPicture.Image = (Image)resources.GetObject("logoPicture.Image");
            logoPicture.Location = new Point(3, 3);
            logoPicture.Name = "logoPicture";
            logoPicture.Size = new Size(700, 363);
            logoPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            logoPicture.TabIndex = 0;
            logoPicture.TabStop = false;
            // 
            // adminPanel
            // 
            adminPanel.Controls.Add(logoPicture);
            adminPanel.Location = new Point(309, 70);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(707, 369);
            adminPanel.TabIndex = 1;
            // 
            // UserInfoBtn
            // 
            UserInfoBtn.Location = new Point(39, 70);
            UserInfoBtn.Name = "UserInfoBtn";
            UserInfoBtn.Size = new Size(168, 66);
            UserInfoBtn.TabIndex = 2;
            UserInfoBtn.Text = "User Information";
            UserInfoBtn.UseVisualStyleBackColor = true;
            UserInfoBtn.Click += UserInfoBtn_Click;
            // 
            // foodPageBtn
            // 
            foodPageBtn.Location = new Point(39, 179);
            foodPageBtn.Name = "foodPageBtn";
            foodPageBtn.Size = new Size(168, 66);
            foodPageBtn.TabIndex = 3;
            foodPageBtn.Text = "Foodpage";
            foodPageBtn.UseVisualStyleBackColor = true;
            foodPageBtn.Click += foodPageBtn_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 215, 148);
            ClientSize = new Size(1024, 543);
            Controls.Add(foodPageBtn);
            Controls.Add(UserInfoBtn);
            Controls.Add(adminPanel);
            Name = "AdminPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)logoPicture).EndInit();
            adminPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoPicture;
        private Panel adminPanel;
        private Button UserInfoBtn;
        private Button foodPageBtn;
    }
}