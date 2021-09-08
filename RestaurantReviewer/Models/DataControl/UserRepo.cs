using Microsoft.Extensions.Logging;
using RestaurantReviewer.Entities;
using RestaurantReviewer.Models.Interfaces;
using RestaurantReviewer.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models.DataControl
{
    public class UserRepo : iUser
    {
        private readonly ILogger<UserRepo> _logger;
        private hintrestaurantdbContext _context;
        public UserRepo(hintrestaurantdbContext context, ILogger<UserRepo> logger)
        {
            _logger = logger;
            _context = context;
        }
        public List<User> GetAllUsers()
        {
            return _context.Users.Select(u => new User {
                Name = u.Name,
                Pass = u.Pass,
                DoB = u.DoB,
                IsAdmin = u.IsAdmin
            }).ToList();
        }

        public User GetUser(string user, string pass)
        {
            Entities.User newUser = _context.Users
                .FirstOrDefault(player => player.Name == user && player.Pass == pass);
            if (newUser != null)
            {

                if (newUser.Pass == pass)
                {
                    return new User(newUser.Id, newUser.Name, newUser.Pass, newUser.DoB, newUser.IsAdmin);
                }

                return null;
            }
            return null;
        }

        public int NewUser(UserSignUpDisplay user)
        {
            _context.Users.Add(new Entities.User { Name = user.Username, Pass = user.Password, DoB = user.DoB.ToString() }) ;
            _context.SaveChanges();
            return _context.Users.FirstOrDefault(r => r.Pass == user.Password && r.Name == user.Username).Id;
           
        }
        public User GetUserByName(string name, string pass)
        {
            Entities.User find = _context.Users
                .FirstOrDefault(player => player.Name == name && player.Pass == pass);
            User user = new User(find.Id, find.Name, find.Pass, find.DoB, find.IsAdmin);
            return user;
        }
    }
}
