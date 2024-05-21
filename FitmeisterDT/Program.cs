using BLL.Admin;
using BLL.Interface;
using DAL;
using DAL.Class;
using DAL.Interface;
using Models.Model;

namespace FitmeisterDT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            IUserDAL adminDAL = new UserDAL();
            IUserBLL userBLL = new UserBLL(adminDAL);
            IFoodDAL foodDAL = new FoodDAL(); 
            IFoodBLL foodBLL = new FoodBLL(foodDAL);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login(userBLL));
            
        }
    }
}