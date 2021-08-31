using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models
{
    public class User
    {
        public User(string name, string pass)
        {
            Name = name;
            Pass = pass;
        }

        public string Name { get; set; }
        public string Pass { get; set; }
        public string DoB { get; set; }
        public int IsAdmin { get; set; } = 0;




    }
}
