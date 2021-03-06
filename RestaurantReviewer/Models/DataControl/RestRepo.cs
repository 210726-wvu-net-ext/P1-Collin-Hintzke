
using RestaurantReviewer.Entities;
using RestaurantReviewer.Models.Interfaces;
using RestaurantReviewer.Models.ViewModels;
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
                rest => new Restaurant(rest.Id, rest.Name, rest.Location, rest.ZipCode, rest.IsFast, rest.NumberOfStores, rest.DateAdded)
            ).ToList();
            
        }

        public List<Restaurant> GetRestaurantsByName(string name)
        {
            return _context.Restaurants.Where(n => n.Name.StartsWith(name)).Select(x => new Restaurant(x.Id, x.Name, x.Location, x.ZipCode, x.IsFast, x.NumberOfStores, x.DateAdded)).ToList();
        }
        public List<Restaurant> GetRestaurantsByAddress(string add)
        {
            return _context.Restaurants.Where(n => n.Location.StartsWith(add)).Select(x => new Restaurant(x.Id, x.Name, x.Location, x.ZipCode, x.IsFast, x.NumberOfStores, x.DateAdded)).ToList();
        }
        public List<Restaurant> GetRestaurantsByZip(string zip)
        {

            return _context.Restaurants.Where(n => n.ZipCode.StartsWith(zip)).Select(x => new Restaurant(x.Id, x.Name, x.Location, x.ZipCode, x.IsFast, x.NumberOfStores, x.DateAdded)).ToList();
        }

        public Restaurant NewRestaurant()
        {
            throw new NotImplementedException();
        }

        public Restaurant GetRestaurantByName(string name)
        {
            throw new NotImplementedException();
        }
        public Restaurant GetRestaurantById(int id)
        {

            var rest = _context.Restaurants.FirstOrDefault(r => r.Id == id);
            Restaurant newRest = new Restaurant(rest.Id, rest.Name, rest.Location, rest.ZipCode, rest.IsFast, rest.NumberOfStores, rest.DateAdded);
            return newRest;

        }

        public void UpdateRestaurant (RestaurantDisplay rest)
        {
            var OriginalRest = _context.Restaurants.FirstOrDefault(r => r.Id == rest.Id);

            OriginalRest.IsFast = rest.IsFast;
            OriginalRest.Location = rest.Location;
            OriginalRest.Name = rest.Name;
            OriginalRest.NumberOfStores = rest.NumberOfStores;
            OriginalRest.ZipCode = rest.ZipCode;
            OriginalRest.DateAdded = DateTime.UtcNow;
            _context.SaveChanges();

           
        }

        public List<Restaurant> SearchRestaurants(string search)
        {
            return null;
        }
    }
}
