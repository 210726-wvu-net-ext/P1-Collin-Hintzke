using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models.ViewModels
{
    public class ReviewDisplay
    {
        public int Id { get; set; }
        [Required]
        public int Score { get; set; }
        public int User { get; set; }
        [Required]
        public string Comment { get; set; }
        public int RestaurantId { get; set; }

    }
}
bad
