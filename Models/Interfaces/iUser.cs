using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantReviewer.Models.ViewModels;

namespace RestaurantReviewer.Models.Interfaces
{
    public interface iUser
    {
        User GetUser(int id);
        List<User> GetAllUsers();
        void NewUser(UserSignUpDisplay user);
        string DeleteUser();







    }
}
