using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models.Interfaces
{
    interface iUser
    {
        User GetUser(int id);
        List<User> GetAllUsers();
        User NewUser();
        string DeleteUser();







    }
}
