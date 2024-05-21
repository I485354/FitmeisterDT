using Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IUserBLL
    {
        DataTable GetUser();
        bool CreateAccount(FitmeisterUser user, string password);
        bool IsUserAdmin(string email, string pass, out FitmeisterUser user);
        bool UpdateUser(FitmeisterUser user);
        bool DeleteUser(int userId);
        bool Login(string email, string password, out FitmeisterUser user);
    }
}
