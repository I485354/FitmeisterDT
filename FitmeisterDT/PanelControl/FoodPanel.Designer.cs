namespace FitmeisterDT.PanelControl
{
    partial class FoodPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            foodData = new DataGridView();
            foodID = new DataGridViewTextBoxColumn();
            foodGroup = new DataGridViewTextBoxColumn();
            foodName = new DataGridViewTextBoxColumn();
            foodItemsBindingSource1 = new BindingSource(components);
            foodItemsBindingSource = new BindingSource(components);
            QuantityTxt = new TextBox();
            KjTxt = new TextBox();
            KcalTxt = new TextBox();
            WaterTxt = new TextBox();
            ProteinTxt = new TextBox();
            FatTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CarbsTxt = new TextBox();
            SugarTxt = new TextBox();
            label7 = new Label();
            label8 = new Label();
            AddItemBtn = new Button();
            RefreshItemBtn = new Button();
            SearchItemTxt = new TextBox();
            label9 = new Label();
            EditItemBtn = new Button();
            DeleteItemBtn = new Button();
            FoodDataPanel = new Panel();
            SaveBtn = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            ContainsTxt = new TextBox();
            GroupItemTxt = new TextBox();
            NameItemTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)foodData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodItemsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foodItemsBindingSource).BeginInit();
            FoodDataPanel.SuspendLayout();
            SuspendLayout();
            // 
            // foodData
            // 
            foodData.AutoGenerateColumns = false;
            foodData.BackgroundColor = Color.MediumSeaGreen;
            foodData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            foodData.Columns.AddRange(new DataGridViewColumn[] { foodID, foodGroup, foodName });
            foodData.DataSource = foodItemsBindingSource1;
            foodData.Location = new Point(0, 0);
            foodData.Name = "foodData";
            foodData.RowHeadersWidth = 51;
            foodData.Size = new Size(429, 326);
            foodData.TabIndex = 0;
            // 
            // foodID
            // 
            foodID.DataPropertyName = "FoodID";
            foodID.HeaderText = "FoodID";
            foodID.MinimumWidth = 6;
            foodID.Name = "foodID";
            foodID.Width = 125;
            // 
            // foodGroup
            // 
            foodGroup.DataPropertyName = "FoodGroup";
            foodGroup.HeaderText = "FoodGroup";
            foodGroup.MinimumWidth = 6;
            foodGroup.Name = "foodGroup";
            foodGroup.Width = 125;
            // 
            // foodName
            // 
            foodName.DataPropertyName = "FoodName";
            foodName.HeaderText = "FoodName";
            foodName.MinimumWidth = 6;
            foodName.Name = "foodName";
            foodName.Width = 125;
            // 
            // foodItemsBindingSource1
            // 
            foodItemsBindingSource1.DataSource = typeof(Models.Model.FoodItem);
            // 
            // foodItemsBindingSource
            // 
            foodItemsBindingSource.DataSource = typeof(Models.Model.FoodItem);
            // 
            // QuantityTxt
            // 
            QuantityTxt.Location = new Point(669, 17);
            QuantityTxt.Name = "QuantityTxt";
            QuantityTxt.Size = new Size(125, 27);
            QuantityTxt.TabIndex = 1;
            // 
            // KjTxt
            // 
            KjTxt.Location = new Point(669, 50);
            KjTxt.Name = "KjTxt";
            KjTxt.Size = new Size(125, 27);
            KjTxt.TabIndex = 2;
            // 
            // KcalTxt
            // 
            KcalTxt.Location = new Point(669, 83);
            KcalTxt.Name = "KcalTxt";
            KcalTxt.Size = new Size(125, 27);
            KcalTxt.TabIndex = 3;
            // 
            // WaterTxt
            // 
            WaterTxt.Location = new Point(669, 116);
            WaterTxt.Name = "WaterTxt";
            WaterTxt.Size = new Size(125, 27);
            WaterTxt.TabIndex = 4;
            // 
            // ProteinTxt
            // 
            ProteinTxt.Location = new Point(669, 149);
            ProteinTxt.Name = "ProteinTxt";
            ProteinTxt.Size = new Size(125, 27);
            ProteinTxt.TabIndex = 5;
            // 
            // FatTxt
            // 
            FatTxt.Location = new Point(669, 182);
            FatTxt.Name = "FatTxt";
            FatTxt.Size = new Size(125, 27);
            FatTxt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(550, 20);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 7;
            label1.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(550, 53);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 8;
            label2.Text = "KJ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(550, 86);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 9;
            label3.Text = "Kcal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(550, 119);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 10;
            label4.Text = "Water";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(550, 156);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 11;
            label5.Text = "Protein";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(550, 185);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 12;
            label6.Text = "Fat";
            // 
            // CarbsTxt
            // 
            CarbsTxt.Location = new Point(669, 215);
            CarbsTxt.Name = "CarbsTxt";
            CarbsTxt.Size = new Size(125, 27);
            CarbsTxt.TabIndex = 13;
            // 
            // SugarTxt
            // 
            SugarTxt.Location = new Point(669, 248);
            SugarTxt.Name = "SugarTxt";
            SugarTxt.Size = new Size(125, 27);
            SugarTxt.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(550, 218);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 15;
            label7.Text = "Carbonhydrates";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(550, 251);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 16;
            label8.Text = "Sugar";
            // 
            // AddItemBtn
            // 
            AddItemBtn.Location = new Point(3, 344);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(111, 52);
            AddItemBtn.TabIndex = 17;
            AddItemBtn.Text = "Add Item";
            AddItemBtn.UseVisualStyleBackColor = true;
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // RefreshItemBtn
            // 
            RefreshItemBtn.Location = new Point(320, 350);
            RefreshItemBtn.Name = "RefreshItemBtn";
            RefreshItemBtn.Size = new Size(109, 46);
            RefreshItemBtn.TabIndex = 18;
            RefreshItemBtn.Text = "Refresh";
            RefreshItemBtn.UseVisualStyleBackColor = true;
            RefreshItemBtn.Click += RefreshItemBtn_Click;
            // 
            // SearchItemTxt
            // 
            SearchItemTxt.Location = new Point(304, 425);
            SearchItemTxt.Name = "SearchItemTxt";
            SearchItemTxt.Size = new Size(125, 27);
            SearchItemTxt.TabIndex = 19;
            SearchItemTxt.KeyDown += SearchItemTxt_KeyDown;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(245, 428);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 20;
            label9.Text = "Search";
            // 
            // EditItemBtn
            // 
            EditItemBtn.Location = new Point(3, 405);
            EditItemBtn.Name = "EditItemBtn";
            EditItemBtn.Size = new Size(111, 47);
            EditItemBtn.TabIndex = 21;
            EditItemBtn.Text = "Edit";
            EditItemBtn.UseVisualStyleBackColor = true;
            EditItemBtn.Click += EditItemBtn_Click;
            // 
            // DeleteItemBtn
            // 
            DeleteItemBtn.Location = new Point(3, 458);
            DeleteItemBtn.Name = "DeleteItemBtn";
            DeleteItemBtn.Size = new Size(111, 47);
            DeleteItemBtn.TabIndex = 22;
            DeleteItemBtn.Text = "Delete";
            DeleteItemBtn.UseVisualStyleBackColor = true;
            DeleteItemBtn.Click += DeleteItemBtn_Click;
            // 
            // FoodDataPanel
            // 
            FoodDataPanel.Controls.Add(SaveBtn);
            FoodDataPanel.Controls.Add(label13);
            FoodDataPanel.Controls.Add(label12);
            FoodDataPanel.Controls.Add(label11);
            FoodDataPanel.Controls.Add(label10);
            FoodDataPanel.Controls.Add(ContainsTxt);
            FoodDataPanel.Controls.Add(GroupItemTxt);
            FoodDataPanel.Controls.Add(NameItemTxt);
            FoodDataPanel.Location = new Point(541, 316);
            FoodDataPanel.Name = "FoodDataPanel";
            FoodDataPanel.Size = new Size(254, 174);
            FoodDataPanel.TabIndex = 23;
            FoodDataPanel.Visible = false;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(0, 122);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(103, 39);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 63);
            label13.Name = "label13";
            label13.Size = new Size(70, 20);
            label13.TabIndex = 7;
            label13.Text = "Contains ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 34);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 6;
            label12.Text = "Group";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 6);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 5;
            label11.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 21);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 4;
            // 
            // ContainsTxt
            // 
            ContainsTxt.Location = new Point(2, 89);
            ContainsTxt.Name = "ContainsTxt";
            ContainsTxt.Size = new Size(251, 27);
            ContainsTxt.TabIndex = 3;
            // 
            // GroupItemTxt
            // 
            GroupItemTxt.Location = new Point(126, 36);
            GroupItemTxt.Name = "GroupItemTxt";
            GroupItemTxt.Size = new Size(125, 27);
            GroupItemTxt.TabIndex = 2;
            // 
            // NameItemTxt
            // 
            NameItemTxt.Location = new Point(126, 3);
            NameItemTxt.Name = "NameItemTxt";
            NameItemTxt.Size = new Size(125, 27);
            NameItemTxt.TabIndex = 1;
            // 
            // FoodPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 215, 148);
            Controls.Add(FoodDataPanel);
            Controls.Add(DeleteItemBtn);
            Controls.Add(EditItemBtn);
            Controls.Add(label9);
            Controls.Add(SearchItemTxt);
            Controls.Add(RefreshItemBtn);
            Controls.Add(AddItemBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(SugarTxt);
            Controls.Add(CarbsTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FatTxt);
            Controls.Add(ProteinTxt);
            Controls.Add(WaterTxt);
            Controls.Add(KcalTxt);
            Controls.Add(KjTxt);
            Controls.Add(QuantityTxt);
            Controls.Add(foodData);
            Name = "FoodPanel";
            Size = new Size(866, 584);
            ((System.ComponentModel.ISupportInitialize)foodData).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodItemsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)foodItemsBindingSource).EndInit();
            FoodDataPanel.ResumeLayout(false);
            FoodDataPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView foodData;
        private BindingSource foodItemsBindingSource;
        private BindingSource foodItemsBindingSource1;
        private TextBox QuantityTxt;
        private TextBox KjTxt;
        private TextBox KcalTxt;
        private TextBox WaterTxt;
        private TextBox ProteinTxt;
        private TextBox FatTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox CarbsTxt;
        private TextBox SugarTxt;
        private Label label7;
        private Label label8;
        private Button AddItemBtn;
        private Button RefreshItemBtn;
        private TextBox SearchItemTxt;
        private Label label9;
        private Button EditItemBtn;
        private Button DeleteItemBtn;
        private Panel FoodDataPanel;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox ContainsTxt;
        private TextBox GroupItemTxt;
        private TextBox NameItemTxt;
        private DataGridViewTextBoxColumn foodID;
        private DataGridViewTextBoxColumn foodGroup;
        private DataGridViewTextBoxColumn foodName;
        private Button SaveBtn;
    }
}
