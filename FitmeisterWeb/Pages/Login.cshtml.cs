using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Models.Model;
using BLL.Interface;
using DAL.Class;
using DAL.Interface;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace FitmeisterWeb.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUserBLL _userBLL; // Zorg dat je IUserDAL hebt geïnjecteerd

        public LoginModel(ILogger<IndexModel> logger, IUserBLL userBLL)
        {
            _logger = logger;
            _userBLL = userBLL; // Initialiseer IUserDAL
        }

        public void OnGet()
        {
            // Optioneel: Redirect gebruikers die al ingelogd zijn
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                Response.Redirect("/Home");
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            string email = Request.Form["email"];
            string password = Request.Form["password"];
            FitmeisterUser user;
            var loginResult = _userBLL.Login(email, password, out user);

            if (loginResult)
            {
                List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserID.ToString()), 
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role)
            };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                /*  var authProperties = new AuthenticationProperties
                  {

                  };*/

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));
                    //authProperties);

                TempData["Name"] = user.Email;
                TempData["Role"] = user.Role;

                return RedirectToPage("/Progression");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return Page();
            }
        }

    }
}
