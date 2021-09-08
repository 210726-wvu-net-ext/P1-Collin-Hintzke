using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantReviewer.Models.ViewModels;

namespace RestaurantReviewer.Models.Interfaces
{
    public interface iUser
    {
        List<User> GetAllUsers();
        int NewUser(UserSignUpDisplay user);
        User GetUserByName(string name, string pass);





    }
}
