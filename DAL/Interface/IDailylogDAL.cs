using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IDailylogDAL
    {
        DailyLog GetDailyLog(int userId, DateTime date);
        DailyLog CreateDailyLog(int userId, DateTime date);
        void UpdateDailyLogs(int cal, decimal fat, decimal carbs, decimal proteins, int logID);
    }
}
