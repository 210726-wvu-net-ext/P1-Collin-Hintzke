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

        private hintrestaurantdbContext _context;
        public UserRepo(hintrestaurantdbContext context)
        {
            _context = context;
        }


        public void DeleteUser()
        {
            
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
                    return new User(newUser.Name, newUser.Pass, newUser.DoB, newUser.IsAdmin);
                }

                return null;
            }
            else
            {
                return null;
               // return NewUser(user);
            }
        }

        private User Login(string v)
        {
            throw new NotImplementedException();
        }

        public int NewUser(UserSignUpDisplay user)
        {
            _context.Users.Add(new Entities.User { Name = user.Username, Pass = user.Password, DoB = user.DoB.ToString() }) ;
            _context.SaveChanges();
            return _context.Users.FirstOrDefault(r => r.Pass == user.Password && r.Name == user.Username).Id;
           
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }
        public int GetUserByName(UserLoginDisplay rev)
        {
            Entities.User user = _context.Users
                .FirstOrDefault(player => player.Name == rev.UserName && player.Pass == rev.Password);
            return user.Id;
        }
        string iUser.DeleteUser()
        {
            throw new NotImplementedException();
        }
    }
}
