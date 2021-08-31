using System;
using System.Collections.Generic;

#nullable disable

namespace RestaurantReviewer.Entities
{
    public partial class User
    {
        public User()
        {
            Ratings = new HashSet<Rating>();
        }
        public User(string name, string pass)
        {
            Name = name;
            Pass = pass;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public string DoB { get; set; }
        public int IsAdmin { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
