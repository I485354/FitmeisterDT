using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Goal
    {
        public int GoalId { get; set; }
        public string GoalName { get; set; }
        public double GoalCals { get; set; }
        public double GoalProteins { get; set; }
        public double GoalFats { get; set; }
        public double GoalCarbs { get; set; }
        public Goal() { }
    }
}
