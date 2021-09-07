using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models.ViewModels
{
    public class RestaurantDisplay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ZipCode { get; set; }
        public int IsFast { get; set; }
        public int NumberOfStores { get; set; }
        public DateTime DateAdded { get; set; }


    }
}
