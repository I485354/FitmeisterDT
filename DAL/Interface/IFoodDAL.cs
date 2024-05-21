using Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IFoodDAL
    {
        DataTable GetFoodItems();
        FoodItem GetDataById(int foodId);
        List<FoodItem> GetNamesFoodItem();
        bool DeleteFoodItem(int foodId);
        bool EditFoodItem(FoodItem items);
        bool CreateFoodItem(FoodItem items);
        List<FoodItem> SearchFoodItem(string searchTerm);
        List<FoodItem> GetFoodItemsForMeal(int mealId);

    }
}
