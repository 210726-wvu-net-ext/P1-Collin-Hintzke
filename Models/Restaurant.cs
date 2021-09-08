using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantReviewer.Models.Interfaces;

namespace RestaurantReviewer.Models
{

    public class Restaurant
    {
        public Restaurant(int id) { }
        public Restaurant() { }

        public Restaurant(int id, string name, string location, string zipCode)
        {
            Id = id;
            Name = name;
            Location = location;
        }



        public Restaurant(int id, string name, string location)
        {
            Name = name;
            Id = id;
        }


        public Restaurant(int id, string name, string location, string zipCode, decimal rating, int isFast, int numberOfStores, List<Review> reviews, DateTime dateAdded) : this(id, name, location)
        {
            ZipCode = zipCode;
            Rating = rating;
            IsFast = isFast;
            NumberOfStores = numberOfStores;
            Reviews = reviews;
            DateAdded = dateAdded;
        }

        public Restaurant(int id, string name, string location, string zipcode, int isFast, int numberOfStores, decimal rating, DateTime dateAdded)
        {       
            Id = id;
            Name = name;
            Location = location;
            ZipCode = zipcode;
            IsFast = isFast;
            NumberOfStores = numberOfStores;
            Rating = rating;
            DateAdded = dateAdded;
        }

        public Restaurant(int id, string name, string location, string zipcode, int isFast, int numberOfStores, DateTime dateAdded)
        {
            Id = id;
            Name = name;
            Location = location;
            ZipCode = zipcode;
            IsFast = isFast;
            NumberOfStores = numberOfStores;
            DateAdded = dateAdded;
        }




        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ZipCode { get; set; }
        public decimal Rating { get; set; }
        public int IsFast { get; set; }
        public int NumberOfStores { get; set; }
        public List<Review> Reviews { get; set; }
        public DateTime DateAdded { get; set; }
    }

}

