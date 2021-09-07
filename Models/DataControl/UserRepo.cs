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
                .FirstOrDefault(player => player.Name == user);
            if (newUser != null)
            {

                if (newUser.Pass == pass)
                {
                    return new User(newUser.Name, newUser.Pass, newUser.DoB, newUser.IsAdmin);
                }
                else throw new NotImplementedException();

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

        public void NewUser(UserSignUpDisplay user)
        {
            _context.Users.Add(new Entities.User { Name = user.Username, Pass = user.Password, DoB = user.DoB.ToString() }) ;
            _context.SaveChanges();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        string iUser.DeleteUser()
        {
            throw new NotImplementedException();
        }
    }
}
