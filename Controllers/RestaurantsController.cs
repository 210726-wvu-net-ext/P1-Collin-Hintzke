using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantReviewer.Entities;
using RestaurantReviewer.Models;
using RestaurantReviewer.Models.Interfaces;

namespace RestaurantReviewer.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly hintrestaurantdbContext _context;

        public RestaurantsController(hintrestaurantdbContext context)
        {
            _context = context;
        }


    }
}
