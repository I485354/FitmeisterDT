using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;


namespace DAL.Interface
{
    public interface IMealDAL
    {
        int AddMeal(Meal meal);
        void AddFoodItemToMeal(int mealId, int foodItemId);
        Meal GetMealForLog(int logId, string mealName);
        List<Meal> GetMealsForLog(int logId);
        Meal CreateMealForLog(int logId, string mealName, DateTime currentDateTime);
        
    }
}
