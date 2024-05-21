using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IMealBLL
    {
        Meal GetOrCreateMealForLog(int logId, DateTime currentDateTime);
        void AddFoodItemToMeal(int mealId, int foodItemId);
        void UpdateDailyLogTotals(int logId);
        List<Meal> GetMealsForLog(int logId);
    }
}
