using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantReviewer.Models;

namespace RestaurantReviewer.Data
{
    public class iRestaurant : DbContext
    {
        public iRestaurant (DbContextOptions<iRestaurant> options)
            : base(options)
        {
        }

        public DbSet<RestaurantReviewer.Models.Restaurant> Restaurant { get; set; }
    }
}
