using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models.ViewModels
{
    public class UserSignUpDisplay
    {

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime DoB { get; set; }

    }
}
