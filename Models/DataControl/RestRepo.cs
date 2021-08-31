
using RestaurantReviewer.Entities;
using RestaurantReviewer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models.DataControl
{
    public class RestRepo : iRestaurant
    {
        private hintrestaurantdbContext _context;

        public RestRepo(hintrestaurantdbContext context)
        {
            _context = context;
        }

        public void DeleteRestaurant(Restaurant rest)
        {




            throw new NotImplementedException();
        }
        /// <summary>
        /// Grabs all restaurants in our database
        /// </summary>
        /// <returns></returns>
        public List<Restaurant> GetAllRestaurants()
        {
            return _context.Restaurants.Select(
                rest => new Models.Restaurant(rest.Id, rest.Name, rest.Location)
            ).ToList();
            
        }

        public List<Restaurant> GetRestaurantsByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetRestaurantsByZip(string zip)
        {
            throw new NotImplementedException();
        }

        public Restaurant NewRestaurant()
        {
            throw new NotImplementedException();
        }

        Restaurant iRestaurant.GetRestaurant(string name)
        {
            throw new NotImplementedException();
        }
    }
}
