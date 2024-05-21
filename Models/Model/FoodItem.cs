using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class FoodItem
    {
        public int FoodID {  get; set; }
        public string FoodGroup { get; set; }
        public string FoodName { get; set; }
        public string Quantity { get; set; }
        public string ContainsTracesOf { get; set; }
        public int KJ { get; set; }
        public int Kcal { get; set; }
        public decimal Water {  get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbs { get; set; }
        public decimal Sugar { get; set; }
        
        public FoodItem()
        {

        }

    }
}
