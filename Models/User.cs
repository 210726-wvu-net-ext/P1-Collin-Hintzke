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
        public User(int id, string name, string pass, string doB, int isAdmin)
        {
            Id = id;
            Name = name;
            Pass = pass;
            DoB = doB;
            IsAdmin = isAdmin;
        }
        public User() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public string DoB { get; set; }
        public int IsAdmin { get; set; } = 0;




    }
    public static class ApplicationRoles
    {
        public const string Member = "Member";
        public const string Admin = "Admin";
    }
}
