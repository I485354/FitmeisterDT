using BLL.Interface;
using DAL.Class;
using DAL.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models.Model;
using System.Data;
using System.Security.Claims;

namespace FitmeisterWeb.Pages
{
    public class FoodItemListModel : PageModel
    {
        private readonly IFoodDAL _foodDAL;
        private readonly IMealBLL _mealBLL;
        private readonly IDailylogBLL _dailylogBLL;

        public List<FoodItem> FoodItems { get; set; }
        [BindProperty]
        public string SearchTerm { get; set; }

        public FoodItemListModel(IFoodDAL foodDAL, IMealBLL mealBLL, IDailylogBLL dailylogBLL)
        {
            _foodDAL = foodDAL;
            _mealBLL = mealBLL;
            _dailylogBLL = dailylogBLL;
            FoodItems = new List<FoodItem>();
            
        }

        public void OnGet()
        {
            FoodItems = _foodDAL.GetNamesFoodItem();
        }

        public void OnPostSearch()
        {
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                FoodItems = _foodDAL.SearchFoodItem(SearchTerm);
            }
            else
            {
                FoodItems = _foodDAL.GetNamesFoodItem();
            }
        }

        public async Task<IActionResult> OnPostSubmitSelectionAsync()
        {
            var selectedItems = Request.Form["selectedItems"].ToString().Split(',').Select(int.Parse).ToList();

            if (selectedItems.Count > 0)
            {
                var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
                if (userIdClaim == null)
                {
                    return Unauthorized(); // Of handleer dit op een andere manier
                }
                int userId = int.Parse(userIdClaim.Value);

                DateTime today = DateTime.Today;
                DateTime currentDateTime = DateTime.Now;
                DailyLog dailyLog = _dailylogBLL.GetOrCreateDailyLog(userId, today);
                Meal meal = _mealBLL.GetOrCreateMealForLog(dailyLog.LogID, currentDateTime);
                foreach (var itemId in selectedItems)
                {
                    _mealBLL.AddFoodItemToMeal(meal.MealID, itemId);
                }

                _mealBLL.UpdateDailyLogTotals(dailyLog.LogID);
                TempData["SuccessMessage"] = "Geselecteerde voedselitems zijn succesvol opgeslagen.";
            }
            else
            {
                TempData["ErrorMessage"] = "Geen voedselitems geselecteerd.";
            }

            return RedirectToPage("/Progression");
        }
    }
}
