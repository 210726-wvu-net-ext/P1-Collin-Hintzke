using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models.Interfaces
{
    interface iRestaurant
    {
        Restaurant GetRestaurant(string name);
        List<Restaurant> GetAllRestaurants();
        List<Restaurant> GetRestaurantsByName(string name);
        List<Restaurant> GetRestaurantsByZip(string zip);

        Restaurant NewRestaurant();
        void DeleteRestaurant(Restaurant rest);







    }
}
