using BLL.Interface;
using DAL.Class;
using DAL.Interface;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admin
{
    public class FoodBLL : IFoodBLL
    {
        public readonly IFoodDAL foodDAL;
        public FoodBLL(IFoodDAL food) 
        { 
            this.foodDAL = food;
        }
        public DataTable GetFoodItems() 
        { 
            return foodDAL.GetFoodItems();  
        }
        public bool DeleteFoodItems(int foodId) 
        {
            return foodDAL.DeleteFoodItem(foodId);
        }
        public bool EditItem(FoodItem items)
        {
            return foodDAL.EditFoodItem(items);
        }
        public bool CreateItem(FoodItem items)
        {
            return foodDAL.CreateFoodItem(items);
        }
        public List<FoodItem> SearchItems(string searchTerm)
        {
            return foodDAL.SearchFoodItem(searchTerm);
        }
        public FoodItem GetDataById(int foodId)
        {
            return foodDAL.GetDataById(foodId);
        }
    }
}
