using BLL.Admin;
using BLL.Interface;
using DAL.Class;
using DAL.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models.Model;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IUserDAL, UserDAL>();
builder.Services.AddTransient<IFoodDAL, FoodDAL>();
builder.Services.AddTransient<IMealDAL, MealDAL>();
builder.Services.AddTransient<IDailylogDAL, DailylogDAL>();
builder.Services.AddTransient<IMealBLL, MealBLL>();
builder.Services.AddTransient<IUserBLL, UserBLL>();
builder.Services.AddTransient<IFoodBLL, FoodBLL>();
builder.Services.AddTransient<IDailylogBLL, DailylogBLL>();
builder.Services.AddTransient<FitmeisterUser>();
builder.Services.AddTransient<FoodItem>();
builder.Services.AddTransient<Goal>();
builder.Services.AddScoped<IPasswordHasher<FitmeisterUser>, PasswordHasher<FitmeisterUser>>();



builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
.AddCookie(options =>
{
    options.LoginPath = "/Login";
    options.LogoutPath = "/Logout";
    options.AccessDeniedPath = "/AccessDenied";
});


builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
