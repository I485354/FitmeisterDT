using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Meal
    {
        public int MealID { get; set; }
        public DateTime TimeStamp { get; set; }
        public int LogID { get; set; }
        public string Name { get; set; }
        public string PartOfDay { get; set; }

        public Meal() 
        { 

        }
    }
}
