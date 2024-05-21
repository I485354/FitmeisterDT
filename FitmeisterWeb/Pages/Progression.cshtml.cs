using BLL.Interface;
using DAL.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models.Model;
using System.Security.Claims;

namespace FitmeisterWeb.Pages
{
    public class ProgressionModel : PageModel
    {
        //public string UserName { get; private set; }
        //public string UserRole { get; private set; }
        private readonly IMealBLL _mealBLL;
        private readonly IFoodDAL _foodDAL;
        private readonly IDailylogBLL _dailylogBLL;

        public double FatsInPercentages {  get; set; }
        public double ProteinsInPercentages { get; set; }
        public double CarbsInPercentages { get; set; }
        public double CalsInPercentages { get; set; }
        public List<Meal> Meals { get; set; }
        public DailyLog DailyLog { get; set; }
        public Goal GoalP { get; set; }
        public Dictionary<int, List<FoodItem>> MealFoodItems { get; set; }

        public ProgressionModel(IMealBLL mealBLL, IFoodDAL foodDAL, IDailylogBLL dailylogBLL)
        {
            _mealBLL = mealBLL;
            _foodDAL = foodDAL;
            _dailylogBLL = dailylogBLL;

            GoalP = new Goal
            {
            GoalProteins = 200.0,
            GoalCals = 2000.0,
            GoalCarbs = 150.0,
            GoalFats = 40.0
            };
            
        }
        private void GoalPercentages()
        {
            if (DailyLog != null)
            {
                ProteinsInPercentages = Math.Min((DailyLog.TotalProteins / GoalP.GoalProteins) * 100, 100);
                FatsInPercentages = Math.Min((DailyLog.TotalFats / GoalP.GoalFats) * 100, 100);
                CarbsInPercentages = Math.Min((DailyLog.TotalCarbs / GoalP.GoalCarbs) * 100, 100);
                CalsInPercentages = Math.Min((DailyLog.TotalCalories / GoalP.GoalCals) * 100, 100);
            }
        }
        public async Task OnGetAsync()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim == null)
            {
                return;
            }
            int userId = int.Parse(userIdClaim.Value);
            var today = DateTime.Today;

            DailyLog = _dailylogBLL.GetOrCreateDailyLog(userId, today);
            Meals = _mealBLL.GetMealsForLog(DailyLog.LogID);
            MealFoodItems = new Dictionary<int, List<FoodItem>>();

            foreach (var meal in Meals)
            {
                var foodItems = _foodDAL.GetFoodItemsForMeal(meal.MealID);
                MealFoodItems[meal.MealID] = foodItems;
            }
            GoalPercentages();
        }
        /*public void OnGet()
        {
            UserName = User.FindFirst(ClaimTypes.Name)?.Value;
            UserRole = User.FindFirst(ClaimTypes.Role)?.Value;
        }*/
    }
}
