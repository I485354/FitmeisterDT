using BLL.Interface;
using DAL.Class;
using DAL.Interface;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admin
{
    public class MealBLL : IMealBLL
    { 
        
        private readonly IMealDAL _mealDAL;
        private readonly IFoodDAL _foodDAL;
        private readonly IDailylogDAL _dailylogDAL;
        public MealBLL(IMealDAL mealDAL, IFoodDAL foodDAL, IDailylogDAL dailylogDAL)
        {
            this._mealDAL = mealDAL;
            this._foodDAL = foodDAL;
            this._dailylogDAL = dailylogDAL;
        }
        public void AddFoodItemToMeal(int mealId, int foodItemId)
        {
           _mealDAL.AddFoodItemToMeal(mealId, foodItemId);
        }
        private List<MealTime> GetStandardMealTimes()
        {
            return new List<MealTime>
            {
                new MealTime { Name = "Breakfast", StartTime = new TimeSpan(6, 0, 0), EndTime = new TimeSpan(9, 0, 0) },
                new MealTime { Name = "Morning Snack", StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0) },
                new MealTime { Name = "Lunch", StartTime = new TimeSpan(12, 0, 0), EndTime = new TimeSpan(15, 0, 0) },
                new MealTime { Name = "Afternoon Snack", StartTime = new TimeSpan(15, 0, 0), EndTime = new TimeSpan(18, 0, 0) },
                new MealTime { Name = "Dinner", StartTime = new TimeSpan(18, 0, 0), EndTime = new TimeSpan(21, 0, 0) },
                new MealTime { Name = "Evening Snack", StartTime = new TimeSpan(21, 0, 0), EndTime = new TimeSpan(23, 59, 59) }
            };
        }
        public Meal GetOrCreateMealForLog(int logId, DateTime currentDateTime)
        {
            var currentTime = currentDateTime.TimeOfDay;
            var mealTimes = GetStandardMealTimes();

            var currentMealTime = mealTimes.FirstOrDefault(m => m.StartTime <= currentTime && m.EndTime >= currentTime);

            if (currentMealTime == null)
            {
                throw new Exception("No meal time found for the current time.");
            }

            var mealName = currentMealTime.Name;
            var meal = _mealDAL.GetMealForLog(logId, mealName);
            if (meal != null)
            {
                return meal;
            }
            return _mealDAL.CreateMealForLog(logId, mealName, currentDateTime);
        }  
        public void UpdateDailyLogTotals(int logId)
        {
            var meals = _mealDAL.GetMealsForLog(logId);
            int totalCalories = 0;
            decimal totalFat = 0;
            decimal totalCarbs = 0;
            decimal totalProteins = 0;

            foreach (var meal in meals)
            {
                var foodItems = _foodDAL.GetFoodItemsForMeal(meal.MealID);
                totalCalories += foodItems.Sum(fi => fi.Kcal);
                totalFat += foodItems.Sum(fi => fi.Fat);
                totalCarbs += foodItems.Sum(fi => fi.Carbs);
                totalProteins += foodItems.Sum(fi => fi.Protein);
            }

           _dailylogDAL.UpdateDailyLogs(totalCalories,totalFat,totalCarbs,totalProteins,logId);
        }
        public List<Meal> GetMealsForLog(int logId)
        {
            return _mealDAL.GetMealsForLog(logId);
        }

    }

}

