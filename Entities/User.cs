using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace RestaurantReviewer.Entities
{
    public partial class User
    {
        public User()
        {
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public string DoB { get; set; }
        public int IsAdmin { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }

    public static class ApplicationRoles
    {
        public const string Member = "Member";
        public const string Admin = "Admin";
    }
}
