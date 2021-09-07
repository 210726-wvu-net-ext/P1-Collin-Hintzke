using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantReviewer.Models.ViewModels;

namespace RestaurantReviewer.Models.Interfaces
{
    public interface iRestaurant
    {
        Restaurant GetRestaurantByName(string name);
        Restaurant GetRestaurantById(int id);
        List<Restaurant> GetAllRestaurants();
        List<Restaurant> GetRestaurantsByName(string name);
        List<Restaurant> GetRestaurantsByZip(string zip);

        Restaurant NewRestaurant();
        void DeleteRestaurant(Restaurant rest);

        void UpdateRestaurant(RestaurantDisplay rest);







    }
}
