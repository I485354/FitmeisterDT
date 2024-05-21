using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FitmeisterWeb.Pages
{
    using BLL.Interface;
    using DAL.Interface;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.EntityFrameworkCore;
    using Models.Model;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SignupModel : PageModel
    {
        private readonly IUserBLL _userBLL;

        [BindProperty]
        public FitmeisterUser User { get; set; }

        public SignupModel(IUserBLL userBll)
        {
            _userBLL = userBll;
        }

        public IActionResult OnPost()
        {
            User.BMI = User.Weight/User.Height * User.Weight;
            try
            {
                bool created = _userBLL.CreateAccount(User,User.Password);
                if (created)
                {
                    ModelState.AddModelError("", "acoount is created.");
                    return RedirectToPage("/Login");
                }
                else
                {
                    ModelState.AddModelError("User.Password", "vul geldige wachtwoord");
                    ModelState.AddModelError("User.Email", "De gegeven Email bestaat al");
                    return Page();
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Er is een fout opgetreden bij het maken van het account.");
                return Page();
            }
            
        }

    }
}
