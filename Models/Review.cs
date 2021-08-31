using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int User { get; set; }
        public string Comment { get; set; }
        public int RestaurantId { get; set; }
    }
}
