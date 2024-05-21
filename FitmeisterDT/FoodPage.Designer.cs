namespace FitmeisterDT
{
    partial class FoodPage
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
            HomeBtn = new Button();
            panelForFood = new Panel();
            SuspendLayout();
            // 
            // HomeBtn
            // 
            HomeBtn.Location = new Point(48, 34);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(126, 60);
            HomeBtn.TabIndex = 1;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // panelForFood
            // 
            panelForFood.Location = new Point(215, 12);
            panelForFood.Name = "panelForFood";
            panelForFood.Size = new Size(866, 584);
            panelForFood.TabIndex = 2;
            // 
            // FoodPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 215, 148);
            ClientSize = new Size(1093, 608);
            Controls.Add(panelForFood);
            Controls.Add(HomeBtn);
            Name = "FoodPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FoodPage";
            ResumeLayout(false);
        }

        #endregion
        private Button HomeBtn;
        private Panel panelForFood;
    }
}