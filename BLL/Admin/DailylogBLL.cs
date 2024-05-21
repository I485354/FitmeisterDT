using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using BLL.Interface;
using Models.Model;

namespace BLL.Admin
{
    public class DailylogBLL : IDailylogBLL
    {
        private readonly IDailylogDAL _dailylogDAL;

        public DailylogBLL(IDailylogDAL dailylogDAL)
        {
            this._dailylogDAL = dailylogDAL;
        }

        public DailyLog GetOrCreateDailyLog(int userId, DateTime date)
        {
            var dailyLog = _dailylogDAL.GetDailyLog(userId, date);
            if (dailyLog != null)
            {
                return dailyLog;
            }
            return _dailylogDAL.CreateDailyLog(userId, date);
        }
    }
}
