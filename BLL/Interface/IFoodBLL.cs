using Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IFoodBLL
    {
        DataTable GetFoodItems();
        FoodItem GetDataById(int foodId);
        bool DeleteFoodItems(int foodId);
        bool EditItem(FoodItem items);
        bool CreateItem(FoodItem items);
        List<FoodItem> SearchItems(string searchTerm);

    }
}
