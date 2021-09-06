using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantReviewer.Models.DataControl;
using RestaurantReviewer.Models.Interfaces;

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
        public ActionResult Index()
        {
            var list = _repo.GetAllRestaurants();
            return View(list);
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
        public ActionResult Edit(int id)
        {

            var res = _repo.GetAllRestaurants().FirstOrDefault(x => x.Id == id);
            return View(res);
        }

        // POST: RestaurantsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: RestaurantsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RestaurantsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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
