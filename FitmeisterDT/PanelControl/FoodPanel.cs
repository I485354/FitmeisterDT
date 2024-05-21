using BLL.Admin;
using BLL.Interface;
using DAL.Class;
using Models.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitmeisterDT.PanelControl
{
    public partial class FoodPanel : UserControl
    {
        public readonly IFoodBLL foodBLL;
        private readonly FoodItem items;
        private bool isEditing = false;
        public FoodPanel(IFoodBLL food)
        {
            InitializeComponent();

            this.foodBLL = food;
            PopulateTable();
        }
        private void RefreshItemBtn_Click(object sender, EventArgs e)
        {
            if(PopulateData() == null)
            {
                PopulateTable();
            }
            else
            {
                PopulateData();
                FoodDataPanel.Show();
                SaveBtn.Hide();
            }
        }
        private void ClearData()
        {
            NameItemTxt.Clear();
            GroupItemTxt.Clear();
            ContainsTxt.Clear();
            QuantityTxt.Clear();
            KcalTxt.Clear();
            KjTxt.Clear();
            WaterTxt.Clear();
            FatTxt.Clear();
            CarbsTxt.Clear();
            ProteinTxt.Clear();
            SugarTxt.Clear();
            FoodDataPanel.Hide();
        }
        public async void PopulateTable()
        {
            try
            {
                DataTable dt = await Task.Run(() => foodBLL.GetFoodItems());
                if (dt != null && dt.Rows.Count > 0)
                {
                    foodData.DataSource = dt;
                    foodData.Refresh();
                }
                else
                {
                    MessageBox.Show("No data to display.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load food items: {ex.Message}");
            }
        }
        private FoodItem PopulateData()
        {
            if (foodData.SelectedRows.Count > 0)
            {
                int foodId = Convert.ToInt32(foodData.SelectedRows[0].Cells["foodID"].Value);
                FoodItem selectedItem = foodBLL.GetDataById(foodId);

                if (selectedItem != null)
                {
                    NameItemTxt.Text = selectedItem.FoodName;
                    GroupItemTxt.Text = selectedItem.FoodGroup;
                    ContainsTxt.Text = selectedItem.ContainsTracesOf;
                    QuantityTxt.Text = selectedItem.Quantity;
                    KjTxt.Text = selectedItem.KJ.ToString();
                    KcalTxt.Text = selectedItem.Kcal.ToString();
                    WaterTxt.Text = selectedItem.Water.ToString();
                    ProteinTxt.Text = selectedItem.Protein.ToString();
                    FatTxt.Text = selectedItem.Fat.ToString();
                    CarbsTxt.Text = selectedItem.Carbs.ToString();
                    SugarTxt.Text = selectedItem.Sugar.ToString();
                }
                
                return selectedItem;
                
            }
            else
            {
                return null;
            }
        }
        private bool CheckValid()
        {
            FoodDataPanel.Show();
            if (string.IsNullOrWhiteSpace(NameItemTxt.Text) ||
                string.IsNullOrWhiteSpace(GroupItemTxt.Text) ||
                string.IsNullOrWhiteSpace(QuantityTxt.Text) ||
                string.IsNullOrWhiteSpace(KcalTxt.Text) ||
                string.IsNullOrWhiteSpace(KjTxt.Text) ||
                string.IsNullOrWhiteSpace(WaterTxt.Text) ||
                string.IsNullOrWhiteSpace(ProteinTxt.Text) ||
                string.IsNullOrWhiteSpace(FatTxt.Text) ||
                string.IsNullOrWhiteSpace(CarbsTxt.Text) ||
                string.IsNullOrWhiteSpace(SugarTxt.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            SaveBtn.Show();
            isEditing = false;
            QuantityTxt.Text = "per 100g";
            QuantityTxt.Enabled = false;
            FoodDataPanel.Show();
            
        }
        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            if (foodData.SelectedRows.Count > 0)
            {
                int foodId = Convert.ToInt32(foodData.SelectedRows[0].Cells["foodID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this food item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool foodItemDeleted = foodBLL.DeleteFoodItems(foodId);
                    if (foodItemDeleted)
                    {
                        MessageBox.Show("Food item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulateTable();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete food item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a food item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditItemBtn_Click(object sender, EventArgs e)
        {
            SaveBtn.Show();
            QuantityTxt.Enabled = true;
            if (foodData.SelectedRows.Count > 0)
            {
                isEditing = true;
                PopulateData();
                FoodDataPanel.Show();
            }
            else
            {
                MessageBox.Show("Select a food item to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            if (isEditing == true)
            {
                if (foodData.SelectedRows.Count > 0)
                {
                    int foodid = Convert.ToInt32(foodData.SelectedRows[0].Cells["foodID"].Value);
                    FoodItem updatedItem = new FoodItem
                    {
                        FoodID = foodid,
                        FoodName = NameItemTxt.Text,
                        FoodGroup = GroupItemTxt.Text,
                        ContainsTracesOf = ContainsTxt.Text,
                        Quantity = QuantityTxt.Text,
                        KJ = Convert.ToInt32(KjTxt.Text),
                        Kcal = Convert.ToInt32(KcalTxt.Text),
                        Water = Convert.ToDecimal(WaterTxt.Text),
                        Protein = Convert.ToDecimal(ProteinTxt.Text),
                        Fat = Convert.ToDecimal(FatTxt.Text),
                        Carbs = Convert.ToDecimal(CarbsTxt.Text),
                        Sugar = Convert.ToDecimal(SugarTxt.Text)
                    };

                    // Roep de methode van de BLL aan om het item bij te werken
                    bool success = foodBLL.EditItem(updatedItem);

                    if (success)
                    {
                        MessageBox.Show("Item successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        FoodDataPanel.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save the item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (CheckValid())
                {
                    FoodItem newitem = new FoodItem
                    {
                        FoodName = NameItemTxt.Text,
                        FoodGroup = GroupItemTxt.Text,
                        ContainsTracesOf = ContainsTxt.Text,
                        Quantity = QuantityTxt.Text,
                        KJ = Convert.ToInt32(KjTxt.Text),
                        Kcal = Convert.ToInt32(KcalTxt.Text),
                        Water = Convert.ToDecimal(WaterTxt.Text),
                        Fat = Convert.ToDecimal(FatTxt.Text),
                        Carbs = Convert.ToDecimal(CarbsTxt.Text),
                        Protein = Convert.ToDecimal(ProteinTxt.Text),
                        Sugar = Convert.ToDecimal(SugarTxt.Text)
                    };
                    foodBLL.CreateItem(newitem);
                    MessageBox.Show("Item Created");
                    FoodDataPanel.Hide();
                    
                }
            }
        }
        private void SearchItemTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DisplaySearchItem();
                e.SuppressKeyPress = true;
            }
        }
        private void DisplaySearchItem()
        {
            try
            {
                string searchItem = SearchItemTxt.Text;
                List<FoodItem> result = foodBLL.SearchItems(searchItem);
                foodData.DataSource = result;
                if (result.Count > 0)
                {
                    foodData.DataSource = result;
                    foodData.Refresh();
                }
                else
                {
                    MessageBox.Show("No data to Show");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
