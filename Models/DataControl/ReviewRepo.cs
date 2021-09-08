using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantReviewer.Entities;
using RestaurantReviewer.Models.Interfaces;
using RestaurantReviewer.Models.ViewModels;

namespace RestaurantReviewer.Models.DataControl
{
    public class ReviewRepo : iReview
    {
        private hintrestaurantdbContext _context;
        public ReviewRepo(hintrestaurantdbContext context)
        {
            _context = context;
        }


        public void DeleteReview()
        {
            throw new NotImplementedException();

        }

        public void DeleteReview(int id)
        {
            var review = _context.Ratings.FirstOrDefault(r => r.Id == id);
            _context.Ratings.Remove(review);
            _context.SaveChanges();
        }

        public List<Review> GetAllReviews()
        {
            return _context.Ratings.Select(
                 Review => new Review(Review.Id, Review.Score, Review.RestaurantId, Review.Message, Review.UserId)
             ).ToList();
        }

        public List<Review> GetAllReviewsByRiD(int id)
        {
            List<Review> list = _context.Ratings.Select(
                Review => new Review(Review.Id, Review.Score, Review.UserId, Review.Message, Review.RestaurantId)
            ).ToList();
            List<Review> query = list.Where(Review => Review.RestaurantId == id).ToList();
            query.Reverse();
            return query;

        }
        public decimal AverageRating(List<Review> list)
        {
            decimal count = 0;
            if (list.Count == 0)
            {
                return 0;
            }
            foreach (var item in list)
            {
                count += Convert.ToDecimal(item.Score);
            }

            return Math.Round(count/list.Count, 2);
        }

        public Review GetReview(int id)
        {
            var Review = _context.Ratings.FirstOrDefaultAsync(m => m.Id == id).Result;
            Review rev = new Review(Review.Id, Review.Score, Review.UserId, Review.Message, Review.RestaurantId);
            return rev;
        }

        public void NewReview(ReviewDisplay rev)
        {
            
            _context.Ratings.Add(new Entities.Rating { Message = rev.Comment, RestaurantId = rev.RestaurantId, Score = rev.Score, UserId = rev.User});
            _context.SaveChanges();
        }
    }
}
