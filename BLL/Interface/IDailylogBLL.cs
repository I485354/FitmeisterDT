﻿using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IDailylogBLL
    {
        DailyLog GetOrCreateDailyLog(int userId, DateTime date);
    }
}
