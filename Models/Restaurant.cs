using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models
{

        public class Restaurant
        {
            public Restaurant() { }
            public Restaurant(int id, string name, string location)
            {
                Id = id;
                Name = name;
                Location = location;
            }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ZipCode { get; set; }
        public int IsFast { get; set; }
        public int NumberOfStores { get; set; }
        public DateTime DateAdded { get; set; }


        }
}

