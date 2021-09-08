using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models.ViewModels
{
    public class UserLoginDisplay
    {

            [Display(Name = "User Name")]
            [Required]
            public string UserName { get; set; }


            [Required]
            public string Password { get; set; }


      
    }
}
