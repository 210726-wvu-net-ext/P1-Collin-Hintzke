using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantReviewer.Models;
using RestaurantReviewer.Models.DataControl;
using RestaurantReviewer.Models.Interfaces;
using RestaurantReviewer.Models.ViewModels;
using Serilog;

namespace RestaurantReviewer.Controllers
{
    public class RestaurantsController : Controller
    {
        private iRestaurant _repo;
        private readonly ILogger<RestaurantsController> _logger;

        public RestaurantsController(iRestaurant repo, ILogger<RestaurantsController> logger)
        {
            _repo = repo;
            _logger = logger;
            _logger.LogInformation("Inside Rest-Con");

        }
        // GET: RestaurantsController
        [HttpGet]
        public ActionResult Index(string SearchBy, string search)
        {
            if(search == "")
            {
                return View(_repo.GetAllRestaurants());
            }
            if(SearchBy == "Name")
            {
                return View(_repo.GetRestaurantsByName(search));
            }
            else if(SearchBy == "ZipCode")
            {
                return View(_repo.GetRestaurantsByZip(search));
            }
            else if(SearchBy == "Address")
            {
                return View(_repo.GetRestaurantsByAddress(search));

            }
            else
            {
                var list = _repo.GetAllRestaurants();
                return View(list);
            }
        }

        // GET: RestaurantsController/Details/5
        public ActionResult Details(int id)
        {
            var res = _repo.GetAllRestaurants().FirstOrDefault(x => x.Id == id);

            return View(res);
        }

        // GET: RestaurantsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RestaurantsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestaurantsController/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            
            return View(_repo.GetRestaurantById(id));
        }

        // POST: RestaurantsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Edit(int id, RestaurantDisplay rest)
        {
            try
            {
               
                _repo.UpdateRestaurant(rest);

            }
            catch
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: RestaurantsController/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RestaurantsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
