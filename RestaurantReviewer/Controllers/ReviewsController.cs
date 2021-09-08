using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantReviewer.Entities;
using RestaurantReviewer.Models;
using RestaurantReviewer.Models.Interfaces;
using RestaurantReviewer.Models.ViewModels;

namespace RestaurantReviewer.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly hintrestaurantdbContext _context;
        private iReview _repo;

        public ReviewsController(hintrestaurantdbContext context, iReview repo)
        {
            _repo = repo;
            _context = context;
        }

        // GET: Reviews
        
        public IActionResult Index(int id)
        {
            TempData["RestaurantId"] = id;
            ViewData["AvgRating"] = _repo.AverageRating(_repo.GetAllReviewsByRiD(id));
            return View(_repo.GetAllReviewsByRiD(id));
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Ratings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // GET: Reviews/Create
        public IActionResult Create()
        {

            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(ReviewDisplay review)
        {

            
            review.RestaurantId = (int)TempData["RestaurantId"];
            try
            {
                review.User = (int)TempData["UserId"];
            } catch (Exception e)
            {
                //  log the exception
            } finally
            {
            _repo.NewReview(review);
            }
            
            
            return View("Index", _repo.GetAllReviewsByRiD(review.RestaurantId));
        }

        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Ratings.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Score,User,Comment,RestaurantId")] Review review)
        {
            if (id != review.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(review);
        }
        [Authorize]
        // GET: Reviews/Delete/5
        public IActionResult Delete(int id)
        {

            _repo.DeleteReview(id);
            return RedirectToAction(nameof(Index));


           // return View(review);
        }

        // POST: Reviews/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var review = await _context.Ratings.FindAsync(id);
            _context.Ratings.Remove(review);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
            return _context.Ratings.Any(e => e.Id == id);
        }
    }
}
