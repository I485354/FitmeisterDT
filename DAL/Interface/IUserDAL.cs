using Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IUserDAL
    {
        bool CreateAccount(FitmeisterUser user);
        DataTable GetUser();
        bool UpdateUser(FitmeisterUser user);
        bool GetLoginData(string email, string pass, out FitmeisterUser user);
        bool DeleteUser(int userId);
    }
}
