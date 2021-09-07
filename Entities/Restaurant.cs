using System;
using System.Collections.Generic;

#nullable disable

namespace RestaurantReviewer.Entities
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ZipCode { get; set; }
        public int NumberOfStores { get; set; }
        public decimal Rating { get; set; }
        public int IsFast { get; set; }
        public DateTime DateAdded { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
