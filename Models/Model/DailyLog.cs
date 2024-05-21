using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class DailyLog
    {
        public int LogID { get; set; } 
        public DateTime Date { get; set; }
        public int TotalCalories { get; set; }
        public double TotalFats { get; set; }
        public double TotalCarbs { get; set; }
        public double TotalProteins { get; set; }
        public int UserID { get; set; }

        public DailyLog() { 
        }   
    }
}
