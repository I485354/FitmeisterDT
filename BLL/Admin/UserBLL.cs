using BLL.Interface;
using DAL.Class;
using DAL.Interface;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admin
{
    public class UserBLL : IUserBLL
    {
        public readonly IUserDAL _userDAL;
        public UserBLL(IUserDAL userDAL)
        {
            this._userDAL = userDAL;
        }
        public DataTable GetUser()
        {
            return _userDAL.GetUser();
        }
        public bool CreateAccount(FitmeisterUser user, string password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            user.Salt = salt;
            user.Password = hashedPassword;
            return _userDAL.CreateAccount(user);
        }

        public bool Login(string email, string password, out FitmeisterUser user) 
        {
            bool isAuthenticated = _userDAL.GetLoginData(email, password, out user);
            if (user != null && isAuthenticated)
            {
                bool passwordIsCorrect = BCrypt.Net.BCrypt.Verify(password, user.Password);
                return passwordIsCorrect;
            }
            else
            {
                return false;
            }
        }
        public bool IsUserAdmin(string email, string pass, out FitmeisterUser user)
        {
            bool isAuthenticated = _userDAL.GetLoginData(email, pass, out user);
            try
            {
                if(user.Role == "admin")
                {
                    return isAuthenticated;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return false;
                
            }
            
           
        }

        public bool UpdateUser(FitmeisterUser user) 
        {
            string newPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);
            user.Password = newPassword;
            return _userDAL.UpdateUser(user);
        }

        public bool DeleteUser(int userId)
        {
            return _userDAL.DeleteUser(userId);
        }
    }
}

