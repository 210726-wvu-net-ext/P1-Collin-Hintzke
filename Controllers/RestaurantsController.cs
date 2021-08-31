using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantReviewer.Data;
using RestaurantReviewer.Models;
using RestaurantReviewer.Models.Interfaces;

namespace RestaurantReviewer.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly Models.Interfaces.iRestaurant _context;

        public RestaurantsController(Data.iRestaurant context)
        {
            _context = (Models.Interfaces.iRestaurant)context;
        }


    }
}
