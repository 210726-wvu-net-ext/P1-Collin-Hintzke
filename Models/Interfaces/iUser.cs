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
        int NewUser(UserSignUpDisplay user);
        string DeleteUser();

        int GetUserByName(UserLoginDisplay user);





    }
}
