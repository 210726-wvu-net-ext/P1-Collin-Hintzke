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
using RestaurantReviewer.Models;
using RestaurantReviewer.Models.DataControl;
using RestaurantReviewer.Models.Interfaces;
using RestaurantReviewer.Models.ViewModels;

namespace RestaurantReviewer.Controllers
{


    public class AccountController : Controller
    {


        private readonly IOptions<List<User>> _users;

        private readonly iUser _repo;
        public AccountController(IOptions<List<User>> users, iUser repo)
        {
            _users = users;
            _repo = repo;
        }

        //displays basic login screen
        public IActionResult Login()
        {
            return View();
        }

        //attaches attempted login and attaches Identity.Claims to the user when successfully logged in.
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDisplay userLogin)
        {
            var user = _repo.GetAllUsers().Find(c => c.Name == userLogin.UserName && c.Pass == userLogin.Password);

            if (!(user is null))
            {
                if (user.Name.Contains("Admin"))
                {
                    TempData["isAdmin"] = true;
                }
                if(user.Id < 1)
                {
                    user.Id = 1;
                }
                TempData["UserId"] = user.Id;
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
                return RedirectToAction("Index", "Restaurants");

            }

            return Redirect("/Account/Login");
        }
        //Displays the sign in page
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }


        //does a search for users, then redirects the user to login when successfully
        [HttpPost]
        public async Task<IActionResult> SignUp(UserSignUpDisplay user)
        {
            var search = _repo.GetUserByName(user.Username, user.Password);
            return RedirectToAction("Login");
        }
    }
}