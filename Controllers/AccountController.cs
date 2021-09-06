using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestaurantReviewer.Models.DataControl;
using RestaurantReviewer.Models.Interfaces;
using RestaurantReviewer.Models.ViewModels;

namespace RestaurantReviewer.Controllers
{


    public class AccountController : Controller
    {

        private readonly IOptions<List<UserLoginDisplay>> _users;

        private readonly iUser _repo;
        public AccountController(IOptions<List<UserLoginDisplay>> users, iUser repo)
        {

            _users = users;
            _repo = repo;
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDisplay userLogin)
        {
            var user = _repo.GetAllUsers().Find(c => c.Name == userLogin.UserName && c.Pass == userLogin.Password);

            if (!(user is null))
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,userLogin.UserName),
                new Claim("FullName", userLogin.UserName),
                new Claim(ClaimTypes.Role, "Administrator"),
            };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties {

                    RedirectUri = "/Home/Index"

                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                return View();

            }

            return Redirect("/Shared/Error");
        }
    }
}